using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLP.Models.MainDataModel
{
    public class PodCategories
    {
        public List<ServicePrice> ServicePriceList;

        public int ParentCategoryId;

        public int PodCategoryId;

        public string PodCategoryName;

      //  public string PodCategoryLink;

        public string PodCategoryText;

        public string PodCategoryImagePath;
    }
}