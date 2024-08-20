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
            
            List<Point3D> p = new List<Point3D>();
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] xyz = lines[i].Split(' ');
                if (xyz[0] == "#")
                {
                    continue;
                }
                float x = Convert.ToSingle(xyz[0]);
                float y = Convert.ToSingle(xyz[1]);
                float z = Convert.ToSingle(xyz[2]);
                p.Add(new Point3D(x, y, z));
            }
            return p;
        }
    }
}
