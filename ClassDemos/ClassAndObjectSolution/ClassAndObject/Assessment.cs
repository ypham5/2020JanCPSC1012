using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Assessment
    {
        //the access priviledge to this code 
        //programs (outside user) can use this class
        //it is NOT static, therefore the outside user 
        //  will have to create an instance of this class 
        //  if they wish to use it

        //Private Data Member 
        // a private data member CANNOT be touched by the outside user 
        private string _Comment;

        //Properties 
        //Properties are the interface to the outside world 
        //Properties that are reference by the outside world need 
        //  to the exposed, that is, made public
        //Properties has the following syntax
        //  accesstype datatype propertyname {coding block}
        //Auto Implemented Properties do not need a private data member
        //  data is stored internally by the system using the requested datatype 
        //  access to data stored ising this implemematation  MUST be via the Property name 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssessmentName { get; set; }
        public double Mark { get; set; }
        //Fully Implemented Properties requires a private data member of
        //  the same datatype as the property
        //  data is stored in the private data member
        //  any coding within the class itself can access the private data member
        //  best pratices is to always use the property and NOT directly access 
        //  the private data member 
        //  reason: the property likely has special coding to validate or manage 
        //      the data which you do not want t by-pass
        //Comment is a nullable field, it is a string, we wish to avoid storing an
        //  empty string. We either have NO data (null) or we have a character string 
        //  with at least one real character.
        public string Comment
        {
            //get is used when the use of the property is on the "right side" of an assignment statement
            get { return _Comment; }
            //set is used when the data is trying to be placed within the instance
            //(the "left side" of an assignment statement
            //since Properties do NOT have a parameter list AND are associated with
            //  a single piece of data, the data within the property is accessed 
            //  using the key word --> value
            set { _Comment = string.IsNullOrEmpty(value) ? null : value; }
        }


    }
}
