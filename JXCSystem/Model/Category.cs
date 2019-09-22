using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class Category
    {
        private string categoryID;
        private string categoryName;

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public Category()
        {

        }
        public Category(string categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }
    }
}
