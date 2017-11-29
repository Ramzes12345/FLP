using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FLP.Models.MainDataModel;

namespace FLP.Models.MainDataModel
{
    public class LoadStartData
    {
        public AllData LoadMainDataCategories()
        {

            var AllDataItem = new AllData();
            AllDataItem.CategoriesList = new List<Categories>();

            var NewCategory = new Categories();
            NewCategory.CategoryId = 1;
            NewCategory.CategoryName = "WI FI Category";
            NewCategory.CategoryText = "WI FI Category Text";
            NewCategory.CategoryLink = "~/Materials/WiFiMaterial";
            NewCategory.CategoryImagePath = "/images/MainCategories/WIFI.jpg";
            NewCategory.CategoryAction = "WiFiMaterial";
            NewCategory.CategoryController = "Materials";

            NewCategory.PodCategoriesList = new List<PodCategories>();

            var PodCategories = new PodCategories();

            PodCategories.ParentCategoryId = 1;
            PodCategories.PodCategoryId = 1;
            PodCategories.PodCategoryImagePath = "/images/PodCategories/PodCatWIFI.jpg";
            PodCategories.PodCategoryName = "Подкатегория Вайфая  - Быстро";
            PodCategories.PodCategoryText = "Подкатегория Вайфая  - Быстро Text";

            var ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 1;
            ServicePrice.PriceName = "Установка банки Быстро 1";
            ServicePrice.PriceCost = 100;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 2, PriceTypeName = "шт." };
            PodCategories.ServicePriceList = new List<ServicePrice>();

            PodCategories.ServicePriceList.Add(ServicePrice);

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 1;
            ServicePrice.PriceName = "Прокладка кабеля медленно 1";
            ServicePrice.PriceCost = 300;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 1, PriceTypeName = "м.п." };

            PodCategories.ServicePriceList.Add(ServicePrice);

            NewCategory.PodCategoriesList.Add(PodCategories);

            //  -----------------------------------------
            PodCategories = new PodCategories();
            PodCategories.ParentCategoryId = 1;
            PodCategories.PodCategoryId = 2;
            PodCategories.PodCategoryImagePath = "/images/PodCategories/PodCatWIFI.jpg";
            PodCategories.PodCategoryName = "Подкатегория Вайфая  - Медленно";
            PodCategories.PodCategoryText = "Подкатегория Вайфая  - Медленно Text";

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 2;
            ServicePrice.PriceName = "Установка банки Медленно 2";
            ServicePrice.PriceCost = 100;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 2, PriceTypeName = "шт." };
            PodCategories.ServicePriceList = new List<ServicePrice>();

            PodCategories.ServicePriceList.Add(ServicePrice);

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 2;
            ServicePrice.PriceName = "Прокладка быстро 2";
            ServicePrice.PriceCost = 200;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 1, PriceTypeName = "м.п." };

            PodCategories.ServicePriceList.Add(ServicePrice);


            NewCategory.PodCategoriesList.Add(PodCategories);
            //------------------------------------------------------
            AllDataItem.CategoriesList.Add(NewCategory);


            ///////////////////////-------------
            //////////////////////---------------
            NewCategory = new Categories();
            NewCategory.CategoryId = 2;
            NewCategory.CategoryName = "Системы безопасности Category";
            NewCategory.CategoryText = "Системы безопасности Category Text";
            NewCategory.CategoryLink = "~/Materials/SignalMaterial";
            NewCategory.CategoryImagePath = "/images/MainCategories/Signal.jpg";
            NewCategory.CategoryAction = "SignalMaterial";
            NewCategory.CategoryController = "Materials";

            NewCategory.PodCategoriesList = new List<PodCategories>();

            PodCategories = new PodCategories();
            PodCategories.ParentCategoryId = 2;
            PodCategories.PodCategoryId = 3;
            PodCategories.PodCategoryImagePath = "/images/PodCategories/PodCatSignal.jpg";
            PodCategories.PodCategoryName = "Подкатегория Системы  - Быстро";
            PodCategories.PodCategoryText = "Подкатегория Системы  - Быстро Text";

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 3;
            ServicePrice.PriceName = "Установка банки Быстро 6";
            ServicePrice.PriceCost = 100;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 2, PriceTypeName = "шт." };
            PodCategories.ServicePriceList = new List<ServicePrice>();

            PodCategories.ServicePriceList.Add(ServicePrice);

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 3;
            ServicePrice.PriceName = "Прокладка кабеля медленно 5";
            ServicePrice.PriceCost = 300;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 1, PriceTypeName = "м.п." };

            PodCategories.ServicePriceList.Add(ServicePrice);

            NewCategory.PodCategoriesList.Add(PodCategories);

            //  -----------------------------------------
            PodCategories = new PodCategories();
            PodCategories.ParentCategoryId = 2;
            PodCategories.PodCategoryId = 4;
            PodCategories.PodCategoryImagePath = "/images/PodCategories/PodCatSignal.jpg";
            PodCategories.PodCategoryName = "Подкатегория Системы  - Медленно";
            PodCategories.PodCategoryText = "Подкатегория Системы  - Медленно Text";

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 4;
            ServicePrice.PriceName = "Установка банки Медленно 3";
            ServicePrice.PriceCost = 100;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 2, PriceTypeName = "шт." };
            PodCategories.ServicePriceList = new List<ServicePrice>();

            PodCategories.ServicePriceList.Add(ServicePrice);

            ServicePrice = new ServicePrice();
            ServicePrice.ParentPodCategoryId = 4;
            ServicePrice.PriceName = "Прокладка быстро 4";
            ServicePrice.PriceCost = 200;
            ServicePrice.PriceType = new PriceType() { PriceTypeId = 1, PriceTypeName = "м.п." };

            PodCategories.ServicePriceList.Add(ServicePrice);


            NewCategory.PodCategoriesList.Add(PodCategories);
            //------------------------------------------------------
            AllDataItem.CategoriesList.Add(NewCategory);


            ////////------------------------------
            //////////-----------------
            return AllDataItem;
        }
    }
}