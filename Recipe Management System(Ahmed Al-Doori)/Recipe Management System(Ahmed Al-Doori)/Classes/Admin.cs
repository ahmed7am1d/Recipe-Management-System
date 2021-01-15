using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipe_Management_System_Ahmed_Al_Doori_.Interfaces;

namespace Recipe_Management_System_Ahmed_Al_Doori_.Classes
{
    public class Admin : IUser
    {

        #region Members Field
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }


        #endregion

        #region Methods

        #endregion

    }
}
