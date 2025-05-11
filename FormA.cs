using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    public partial class FormA : Form
    {
        private FormB formB;  
        private FormEncrypted formEncrypted;

        public FormA(FormEncrypted encryptedForm)
        {
            InitializeComponent();
            //formB = formBReference;
            this.formEncrypted = encryptedForm;
        }



        private void btnGonder_Click(object sender, EventArgs e)
        {
            string mesaj = txtMesaj.Text;
            MessageManager.AddMessage(mesaj);

            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, DateTime.Now.ToString(), mesaj);
            // FormB'yi de güncellemeyi sağlıyoruz
            formB.UpdateDataGridView();
            formEncrypted.UpdateDataGridView();

            txtMesaj.Clear();
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Mesaj", "Mesaj");
        }
        public void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            var messages = MessageManager.GetMessages();
            foreach (var message in messages)
            {
                dataGridView1.Rows.Add(message.ID, message.Tarih.ToString(), message.Mesaj);
            }
        }
        public void SetFormB(FormB formBReference)
        {
            formB = formBReference;
        }
    }
}
