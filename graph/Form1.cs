using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace graph
{
    public partial class Form1 : Form
    {
        List<double[]> hodnoty;
        vypocet v;
        public Form1()
        {
            InitializeComponent();
            v = new vypocet();
            hodnoty = new List<double[]>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Vykresli_Click(object sender, EventArgs e)
        {
            try
            {
                funkce.Series.Clear();
                VzorecForm.Text = VzorecForm.Text.Replace(',', '.');
                OdForm.Text = OdForm.Text.Replace('.', ',');
                DoForm.Text = DoForm.Text.Replace('.', ',');
                KrokForm.Text = KrokForm.Text.Replace('.', ',');
                string name = ("f(x)=" + VzorecForm.Text);
                v.nastav(Convert.ToDouble(OdForm.Text), Convert.ToDouble(DoForm.Text), Convert.ToDouble(KrokForm.Text), VzorecForm.Text);
                v.vypocitej(ref hodnoty);
                funkce.Series.Add(name);
                funkce.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                for (int i = 0; i < hodnoty.Count; i++)
                {
                    funkce.Series[name].Points.AddXY((hodnoty[i])[0], (hodnoty[i])[1]);
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            /*funkce.Series.Clear();
            string name = "kosinus";
            funkce.Series.Add(name);
            funkce.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < 100; i++)
            {
                funkce.Series[name].Points.AddXY(i * ((2 * Math.PI) / (100)), Math.Cos(i * ((2 * Math.PI) / (100))));
            }*/
        }
    }
    


        
    
}
