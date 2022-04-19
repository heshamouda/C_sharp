using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class School
    {
       public string Name { get; set; }
       public string Description { get; set; }
       public string type { get; set; }
       public string Address { get; set; }
       public string SchoolCity { get; set; }
       public string SchoolCountry { get; set; }
       public string SchoolPhone { get; set; }
       public string SchoolPostalCode { get; set; }
       public string SchoolCountryCode { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure that the twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@")) {
                    _twitterAddress = value.Substring(1);
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }    
            }
        }


    }
}
