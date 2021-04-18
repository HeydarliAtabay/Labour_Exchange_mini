using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(62,120,138);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("1", "IT", "Frontend Developer", "2", "Azerbaijani, Russian, English", "1 year", "HTML&CSS", "----", "700", "15/06/2020");
            dataGridView1.Rows.Add("2", "IT", "Backend developer", "1", "Azerbaijani, Russian, English", "1 year", "Python&Django", "----", "700", "15/06/2020");
            dataGridView1.Rows.Add("3", "Service", "Waitor", "2", "Azerbaijani, English", "---", "---", "---", "400", "15/06/2020");
            dataGridView1.Rows.Add("4", "Service", "Waitres", "2", "Azerbaijani, English", "---", "---", "---", "450", "15/06/2020");
            dataGridView1.Rows.Add("5", "Service", "Reception", "2", "Azerbaijani, English", "---", "---", "---", "600", "15/06/2020");
            dataGridView1.Rows.Add("6", "Design", "Graphic designer", "1", "Azerbaijani, Russian, English", "2 year", "Photoshop", "----", "480", "15/06/2020");
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
