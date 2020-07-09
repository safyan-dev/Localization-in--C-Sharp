﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;

namespace Localization.Helper
{
    public class CultureHelper
    {
        protected HttpSessionState session;

        //constructor   
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }
        // Properties  
        public static int  Culture 
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "en-GB")
                {
                    return 0;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ar-SA")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            set 
            {
                if (value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                }
                else if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            } 
        }

    }
}