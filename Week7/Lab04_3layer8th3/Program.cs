using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_3layer8th3.BLL;
using Lab04_3layer8th3.GUI;

namespace Lab04_3layer8th3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCRUD());
            //StudentAccessBLL studentAccessBLL = new StudentAccessBLL();
            //studentAccessBLL.DeleteStudent("S10");
            //Console.WriteLine(studentAccessBLL.GetStudents());
        }
    }
}
