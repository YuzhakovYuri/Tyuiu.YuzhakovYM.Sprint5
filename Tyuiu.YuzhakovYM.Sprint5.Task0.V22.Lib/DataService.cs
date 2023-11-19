﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YuzhakovYM.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = Math.Pow((1 - (double)x), 2) / -3 * (double)x;
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));

            return path;

        }
    }
}
