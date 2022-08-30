using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /// <summary>
    /// Creating a Predicate Class
    /// </summary>
    internal class Delegates1
    {
        public delegate bool Predicate(XClass x);

        void LambdaExpansion()
        {

            var UsedName = "Messi";

            Predicate classwork = (XClass x) =>
            {
                if (x.UserName == UsedName)  //check if Username is equal to UsedName
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }
    }


    
    // Property class
    
    class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string UserName { get; set; }

    }
}