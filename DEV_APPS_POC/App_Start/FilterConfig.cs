﻿using System.Web;
using System.Web.Mvc;

namespace DEV_APPS_POC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
