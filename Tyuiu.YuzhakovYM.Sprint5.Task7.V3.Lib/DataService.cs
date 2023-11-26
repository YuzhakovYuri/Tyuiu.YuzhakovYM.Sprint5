using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.YuzhakovYM.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V3.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'а') && (line[i] != 'б') && (line[i] != 'в') && (line[i] != 'г') &&
                                (line[i] != 'д') && (line[i] != 'е') && (line[i] != 'ё') && (line[i] != 'ж') &&
                                (line[i] != 'з') && (line[i] != 'и') && (line[i] != 'й') && (line[i] != 'к') &&
                                (line[i] != 'л') && (line[i] != 'м') && (line[i] != 'н') && (line[i] != 'о') &&
                                (line[i] != 'п') && (line[i] != 'р') && (line[i] != 'с') && (line[i] != 'т') &&
                                (line[i] != 'у') && (line[i] != 'ф') && (line[i] != 'х') && (line[i] != 'ц') &&
                                (line[i] != 'ч') && (line[i] != 'ш') && (line[i] != 'щ') && (line[i] != 'ъ') &&
                                (line[i] != 'ы') && (line[i] != 'ь') && (line[i] != 'э') && (line[i] != 'ю') &&
                                (line[i] != 'я') &&
                                (line[i] != 'А') && (line[i] != 'Б') && (line[i] != 'В') && (line[i] != 'Г') &&
                                (line[i] != 'Д') && (line[i] != 'Е') && (line[i] != 'Ё') && (line[i] != 'Ж') &&
                                (line[i] != 'З') && (line[i] != 'И') && (line[i] != 'Й') && (line[i] != 'К') &&
                                (line[i] != 'Л') && (line[i] != 'М') && (line[i] != 'Н') && (line[i] != 'О') &&
                                (line[i] != 'П') && (line[i] != 'Р') && (line[i] != 'С') && (line[i] != 'Т') &&
                                (line[i] != 'У') && (line[i] != 'Ф') && (line[i] != 'Х') && (line[i] != 'Ц') &&
                                (line[i] != 'Ч') && (line[i] != 'Ш') && (line[i] != 'Щ') && (line[i] != 'Ъ') &&
                                (line[i] != 'Ы') && (line[i] != 'Ь') && (line[i] != 'Э') && (line[i] != 'Ю') &&
                                (line[i] != 'Я'))
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
