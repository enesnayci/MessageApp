using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormA());

            // Formları oluştur
            FormA formA = new FormA();
            FormB formB = new FormB();
            FormEncrypted formEncrypted = new FormEncrypted();

            // Tüm formları göster
            formA.Show();
            formB.Show();
            formEncrypted.Show();

            // Ana form olarak birini çalıştır (diğerleri zaten gösterilmiş)
            Application.Run();
        }
    }
}
