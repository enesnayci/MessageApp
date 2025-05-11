using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    public partial class FormEncrypted : Form
    {
        public FormEncrypted()
        {
            InitializeComponent();
        }

        private void FormEncrypted_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Mesaj", "Şifreli Mesaj");

            string key = "KEY";

            foreach (var item in MessageManager.GetMessages())
            {
                string encrypted = Encryption.AESEncrypt(item.Mesaj);
                dataGridView1.Rows.Add(item.ID, item.Tarih.ToString(), encrypted);
            }
        }
        public void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            string key = "KEY";

            foreach (var item in MessageManager.GetMessages())
            {
                string encrypted = Encryption.AESEncrypt(item.Mesaj);
                dataGridView1.Rows.Add(item.ID, item.Tarih.ToString(), encrypted);
            }
        }

    }
}
