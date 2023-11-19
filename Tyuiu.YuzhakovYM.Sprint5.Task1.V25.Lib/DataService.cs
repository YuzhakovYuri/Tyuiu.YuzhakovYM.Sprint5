using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YuzhakovYM.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                strY = Convert.ToString(y);

                if (3*x+1.2 != 0)
                {
                    if (x != stopValue)
                    {
                        File.AppendAllText(path, strY + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, strY);
                    }
                }
                else
                {
                    y = 0;
                }    
            }
            return path;
        }
    }
}
