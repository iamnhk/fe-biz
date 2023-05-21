using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeBiz
{
    public class Category
    {
        private int categoryID;
        private string type;
        private string subType;

        //Constructors
        public Category()
        {
            this.categoryID = 0;
            this.type = string.Empty;
            this.subType = string.Empty;
        }

        public Category(int categoryID, string type, string subType)
        {
            this.categoryID = categoryID;
            this.type = type;
            this.subType = subType;
        }

        public Category(string type, string subType)
        {
            this.categoryID = 0;
            this.type = type;
            this.subType = subType;
        }

        //Properties
        public int CategoryID
        {
            get
            {
                return this.categoryID;
            }
            set
            {
                this.categoryID = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string SubType
        {
            get
            {
                return this.subType;
            }
            set
            {
                this.subType = value;
            }
        }

        //Methods


    }
}
