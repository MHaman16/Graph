using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;


namespace graph
{
    class vypocet
    {
        public double od { get; private set; }
        public double po { get; private set; }
        public double krok { get; private set; }
        public String vzorec { get; private set; }

        public vypocet()
        {
            od = 0;
            po = 0.1;
            krok = 1;
            vzorec = "x";

        }
        public vypocet(double od, double po, double krok, String vzorec)
        {
            nastav(od, po, krok, vzorec);
        }
        public void nastav(double od, double po, double krok, String vzorec)
        {
            if (od > po || od == po)
            {
                throw new System.ArgumentException("Spatne zadani intervalu pro vypocet");
            }
            else if ((po - od) < krok || krok < 0)
            {
                throw new System.ArgumentException("Spatne zadani kroku");
            }
            else if (!vzorec.Contains('x'))
            {
                throw new System.ArgumentException("Ve vzorci neni promena x");
            }
            else
            {
                this.od = od;
                this.po = po;
                this.krok = krok;
                this.vzorec = vzorec;
            }

        }
        public void vypocitej(ref List<double[]> hodnoty)
        {
            int konec = (int)((po-od)/krok);
            hodnoty.Clear();
            double[] a = new double[2];
            Function f = new Function("f(x)=" + vzorec);
            for (int i = 0; i <= konec; i++)
            {
                a[0] = od + (krok * i);
                a[1] = f.calculate(od + (krok * i));
                hodnoty.Add(new double[2] { od + (krok * i),f.calculate(od + (krok * i))});
            }
            if ((konec * krok) != po)
            {
                hodnoty.Add(new double[2] { po, f.calculate(po) });
            }
        }
    }
}
