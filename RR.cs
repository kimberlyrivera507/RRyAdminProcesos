using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round_Robin
{
    public partial class RR : Form
    {
        int y = 0;
        int x = 0;
        int z = 0;
        int i = 0;
         int anInteger,op;
        public RR()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random Color = new Random();
            Procesos P = new Procesos();
            dgvProcesos.Rows.Add();
            dgvProcesos[0, i].Value = tbNombre.Text;
            dgvProcesos[1, i].Value = tbReq.Text;

            op = Convert.ToInt32(tbReq.Text);
            op = int.Parse(tbReq.Text);

            dgvProcesos[2, i].Value = P.GenerarColores(Color);
          
            i++;
           
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int w = 0;
            
       
             while (w<i) {
                string nombre = Convert.ToString(dgvProcesos[0, w].Value);
                string reque = Convert.ToString(dgvProcesos[1, w].Value);
                op = Convert.ToInt32(reque);
                op = int.Parse(reque);
                string colore = Convert.ToString(dgvProcesos[2, w].Value);
                Color c = ColorTranslator.FromHtml(colore);

               planifi(nombre, op, c,w);
                
                w++;
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEjec.Rows.Add(50);
            
          
        }
        public void planifi(string nombre, int op, Color c, int p) {
            anInteger = Convert.ToInt32(tbQuantom.Text);
            anInteger = int.Parse(tbQuantom.Text);
            if (op < anInteger) { z = op;  op = 0; }
            else if (op > anInteger)
            { op = op - anInteger; z = anInteger; }
            else { z = anInteger;  op = 0; }
            for (int i = 0; i < z; i++)
            {

                dgvEjec.Rows[y].Cells[x].Style.BackColor = c;
                dgvEjec[x, y].Value = nombre;
                x++;
                if (x == 8) { y++; x = 0; };
            }
            string re = Convert.ToString(op);
            dgvProcesos[1, p].Value = re;
        }
        private void tbQuantom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvEjec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProcesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
