﻿using System.Web;
using System.Web.Mvc;

namespace CRUD_Mahasiswa_FIX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}