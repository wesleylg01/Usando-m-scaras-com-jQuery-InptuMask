﻿using System.Web;
using System.Web.Mvc;

namespace Mvc_jQueryMask
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
