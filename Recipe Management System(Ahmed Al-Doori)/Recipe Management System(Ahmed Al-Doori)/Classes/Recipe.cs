using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Management_System_Ahmed_Al_Doori_.Classes
{
    public class Recipe
    {
        #region Members
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string RecipeStatus { get; set; }
        public int User_ID { get; set; }

        public List<Step> steps = new List<Step>();

        #endregion
    }

}
