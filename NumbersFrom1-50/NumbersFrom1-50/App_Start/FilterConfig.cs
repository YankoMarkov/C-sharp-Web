﻿using System.Web;
using System.Web.Mvc;

namespace NumbersFrom1_50
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
