using System;
using System.Windows.Forms;

namespace MesajlasmaProjesi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormEncrypted formEncrypted = new FormEncrypted();
            FormA formA = new FormA(formEncrypted);
            FormB formB = new FormB(formA, formEncrypted);
            formA.SetFormB(formB);

            formA.Show();
            formB.Show();
            formEncrypted.Show();

            Application.Run(formA);
        }
    }
}
