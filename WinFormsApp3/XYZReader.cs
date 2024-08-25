using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class XYZReader
    {
        public static List<Point3D> ReadXYZ(string path)
        {
            
            List<Point3D> outputList = new List<Point3D>();
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                int j = 0;
                
                List<float> xyz = new List<float>();

                while (j < line.Length)
                {
                    string singleStr = line.Substring(j, 1);
                    double _;
                    if (double.TryParse(singleStr, out _))
                    {
                        try
                        {
                            string temp = "";
                            while (j < line.Length)
                            {
                                if (" " == line.Substring(j, 1))
                                {
                                    j++;
                                    break;
                                }
                                else if (0 != j && "-" == line.Substring(j - 1, 1))
                                {
                                    temp += line.Substring(j - 1, 2);
                                }
                                else
                                {
                                    temp += line.Substring(j, 1);
                                }                                
                                j++;
                            }
                            xyz.Add((float)Convert.ToDouble(temp));
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("got an exception", ex);
                        }
                        
                        
                        
                        if(xyz.Count == 3)
                        {
                            outputList.Add(new Point3D(xyz[0], xyz[1], xyz[2]));
                            xyz.Clear();
                            break;
                        }
                        continue;
                    }
                    j++;
                }
            
            }
            return outputList;
        }
    }
}
