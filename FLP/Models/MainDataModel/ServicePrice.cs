using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLP.Models.MainDataModel
{
    public class ServicePrice
    {
        public int ParentPodCategoryId;

        public string PriceName;

        public PriceType PriceType;

        public decimal PriceCost;
    }
}