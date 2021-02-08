using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace colombia_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            chart1.Series.Clear();

            int numM = 0;

            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = buscar.FileName;
            }
            String[] lines;
            lines = File.ReadAllLines(txtPath.Text);

            for (int i = 0; i < lines.Length; i++)
            {
                //agregamos una fila
                int n = table.Rows.Add();

                // dividimos en un arreglo cada celda
                String[] values = lines[i].Split(',');

                //colocamos informacion
                table.Rows[n].Cells[0].Value = values[0];
                table.Rows[n].Cells[1].Value = values[1];
                table.Rows[n].Cells[2].Value = values[2];
                table.Rows[n].Cells[3].Value = values[3];
                table.Rows[n].Cells[4].Value = values[4];
                numM++;
            }

            String[] tiposM = { "Municipio", "Isla", "Area No Mu" };

            chart1.Titles.Clear();


            chart1.Titles.Add("Tipos de Municipios");
            int cantMun = 0;
            int cantIsla = 0;
            int cantAreaNoM = 0;
            for (int i = 0; i < numM; i++)
            {
                if ("Municipio".Equals(table.Rows[i].Cells[4].Value.ToString()))
                {
                    cantMun++;
                }
            }

            for (int i = 0; i < numM; i++)
            {
                if ("Isla".Equals(table.Rows[i].Cells[4].Value.ToString()))
                {
                    cantIsla++;
                }
            }

            for (int i = 0; i < numM; i++)
            {
                if ("Ãrea no municipalizada".Equals(table.Rows[i].Cells[4].Value.ToString()))
                {
                    cantAreaNoM++;
                }
            }

            int[] cant = { cantMun, cantIsla, cantAreaNoM };

            chart1.Palette = ChartColorPalette.Berry;


            for (int i = 0; i < tiposM.Length; i++)
            {
                Series serie = chart1.Series.Add(tiposM[i]);

                serie.Label = cant[i].ToString();
                serie.Points.Add(cant[i]);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            chart1.Series.Clear();

            int numM = 0;

            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = buscar.FileName;
            }
            String[] lines;
            lines = File.ReadAllLines(txtPath.Text);

            for (int i = 0; i < lines.Length; i++)
            {


                // dividimos en un arreglo cada celda
                String[] values = lines[i].Split(',');

                String dpt = values[2];
                String dptSelected = comboBox1.Text;

                if (dpt.Equals(dptSelected))
                {
                    //agregamos una fila
                    int n = table.Rows.Add();

                    //colocamos informacion
                    table.Rows[n].Cells[0].Value = values[0];
                    table.Rows[n].Cells[1].Value = values[1];
                    table.Rows[n].Cells[2].Value = values[2];
                    table.Rows[n].Cells[3].Value = values[3];
                    table.Rows[n].Cells[4].Value = values[4];

                    numM++;
                }

            }

            String[] tiposM = { "Municipio", "Isla", "Area No Mu" };

            chart1.Titles.Clear();


            chart1.Titles.Add("Tipos de Municipios");
            int cantMun = 0;
            int cantIsla = 0;
            int cantAreaNoM = 0;
            for (int i = 0; i < numM; i++)
            {
                if ("Municipio".Equals(table.Rows[i].Cells[4].Value.ToString()))
                { 
                    cantMun++;
                }
            }

            for (int i = 0; i < numM; i++)
            {
                if ("Isla".Equals(table.Rows[i].Cells[4].Value.ToString()))
                {
                    cantIsla++;
                }
            }

            for (int i = 0; i < numM; i++)
            {
                if ("Ãrea no municipalizada".Equals(table.Rows[i].Cells[4].Value.ToString()))
                {
                    cantAreaNoM++;
                }
            }

            int[] cant = {cantMun , cantIsla , cantAreaNoM };

            chart1.Palette = ChartColorPalette.Berry;


            for (int i = 0; i < tiposM.Length; i++)
            {
                Series serie = chart1.Series.Add(tiposM[i]);

                serie.Label = cant[i].ToString();
                serie.Points.Add(cant[i]);
            }

        }


    }
}
