using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroSplashScreen
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);//Demo
            t.Abort();//Complete
        }

        
        void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }
    }
}
