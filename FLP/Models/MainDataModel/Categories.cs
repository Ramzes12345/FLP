using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLP.Models.MainDataModel
{
    public class Categories
    {
        public List<PodCategories> PodCategoriesList;

        public int CategoryId;

        public string CategoryName;

        public string CategoryAction;

        public string CategoryController;

        public string CategoryLink;

        public string CategoryText;

        public string CategoryImagePath;
    }
}