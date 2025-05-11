using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string mesaj = txtMesaj.Text;
            MessageManager.AddMessage(mesaj);
            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, DateTime.Now.ToString(), mesaj);
            txtMesaj.Clear();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Mesaj", "Mesaj");
        }
    }
}
