﻿using System.Web;
using System.Web.Mvc;

namespace BigSchool2_DucTai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
