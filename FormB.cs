using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    public partial class FormB : Form
    {
        private FormA formA;
        private FormEncrypted formEncrypted;

        public FormB(FormA formAReference, FormEncrypted formEncrypted)
        {
            InitializeComponent();
            formA = formAReference;  // FormA referansını al
            this.formEncrypted = formEncrypted;
        }


        // DataGridView'i güncelleme
        public void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();  // DataGridView'i temizle

            var messages = MessageManager.GetMessages();  // Mesajları al

            // Mesajları DataGridView'e ekle
            foreach (var message in messages)
            {
                dataGridView1.Rows.Add(message.ID, message.Tarih.ToString(), message.Mesaj);
            }
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Mesaj", "Mesaj");

            UpdateDataGridView();  // Başlangıçta mesajları yükle
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string mesaj = txtMesaj.Text;
            MessageManager.AddMessage(mesaj);  // Mesajı ekle

            // DataGridView'i güncelle
            UpdateDataGridView();  // FormB'yi güncelle
            formA.UpdateDataGridView();  // FormA'yı da güncelle
            formEncrypted.UpdateDataGridView();
            txtMesaj.Clear();
        }
        public void SetFormA(FormA formAReference)
        {
            formA = formAReference;
        }
    }
}
