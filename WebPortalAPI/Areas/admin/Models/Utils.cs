﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class Utils
    {
        public string TruncateString(string content, int isGreaterThan, int keppThisNumber)
        {
            if (content.Length > isGreaterThan)
            {
                content = (content).Substring(0, keppThisNumber) + "...";
            }
            return content;
        }
       public enum FileType {
            Logo = 0,
            Background = 1,
            Icon = 2,
            PDF = 3,
            IMG = 4,
            PNG = 5,
            Docx = 6
        }

    }
}
