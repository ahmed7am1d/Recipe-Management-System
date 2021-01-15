using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Management_System_Ahmed_Al_Doori_.Interfaces
{
    public interface IUser
    {
        #region Members Field
         string UserName { get; set; }

         string FirstName { get; set; }
         string LastName { get; set; }
         string Password { get; set; }


        #endregion

        #region Methods

        //create recipe method that's return a recipe 


        #endregion
    }
}
