using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string fullName;
        public string reversfullName;
         public string GetFullName()
        {
           fullName = firstName +" "+ middleName +" "+ lastName;
            return fullName;


        }

       public string GetReverseName()
       {
          
          

           char[] cArray = fullName.ToCharArray();
           string reverse = String.Empty;
           for (int i = cArray.Length - 1; i > -1; i--)
           {
               reverse += cArray[i];
           }
           return reverse;


       }
    }
}
