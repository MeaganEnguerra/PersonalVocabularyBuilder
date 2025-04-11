using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyCommon
{
     public class UserAccount
    {
        private  string _defaultPIN = "1234";
       
        public string Password 
        {
            get { return _defaultPIN; }
            set
            {
                if ((value.Length == 4 || value.Length == 6) && int.TryParse(value, out _) ) 
                {
                    _defaultPIN = value;
                }
            }
        }

        public string UserName { get; set; }
       

    }
}
