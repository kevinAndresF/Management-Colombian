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

            }
        }
    }
}
