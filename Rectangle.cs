using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{

    /// Rectangle class has width and length fields. 
    /// This unique shape has constructors, properties and methods to perform basic rectangle tasks.  
    class Rectangle
    {
        private double _width;
        private double _length;

        //Default constructor. All classes must have a default constructor which sets the private fields to default values. 
        //A method should provide enough constructors to allow flexibility on how to create the object. 
        //Example: Default is for no parameters, the other constructors receive all or some of the fields. 

        /// Default constructor sets backing fields to 0. 
        public Rectangle()
        {
            Width = 0;     //Using the Width Property as validation.
            Length = 0;    //Using the Length Property as validation
        }

        public Rectangle(double w_, double l_)  //Microsoft recommends using name_ when sending parameters inside Classes. 
        {
            Width = w_;         //Using the Width Property as validation. this keyword is not used, but it's implicit; always there.
            Length = l_;        //Using the Length Property as validation

            //Another implementation
            //this._width = w;
            //this._length = l;
            //This implementation is dangerous because w or l can be negative. 
            //Then our class will contain negatives values which do not make sense in this context.
        }

        /*
            Properties: 
                - Starts with a Capital letter. Usual has the same name as the private backing field (data member).
                - Replaces getters and setters.
                - No argument list included.
                - Set block: allow us to add a class level validation for private data members and assign values to private data members.
                - Get block: allow us to return a private data member.
        */

        public double Length        //Properties always start with a capital letter
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)          //Class level validation. Application validation should still be in main()
                    throw new ArgumentException("Value cannot be negative", "Length");

                _length = value;
            }
        }


        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Value cannot be negative", "Width");

                _width = value;     //value is a keyword. It is the value assigned to this property from main. 
            }
        }

        //Read only Property: not set, only a get.
        //Area is a calculated property. It's calculated at run time. There is no data member holding area. 
        public double Area
        {
            get
            {
                return Width * Length;
            }
        }

        /*
         * Always override the parent Object's ToString() method, when creating a class. 
         * We decide the output of ToString(). 
         * Pillar of OOP: Polymorphism
         */
        public override string ToString()
        {
            //Using data and method members. 
            //return string.Format("Rectangle: length={0}, width={1}, area={2}", _length, _width, Area);

            //Using properties
            return string.Format("[Rectangle: Length={0}, Width={1}, Area={2}]", Length, Width, Area);
        }
    }
}

