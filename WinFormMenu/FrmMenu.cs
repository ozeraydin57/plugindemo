using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinFormMenu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void mnLoadMenu_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "..//..//Plugins//ClassLibPlugin.dll");
            Type classType = asm.GetType("ClassLibPlugin.FormMenu");
            object cls = Activator.CreateInstance(classType);

            MethodInfo addMenu = classType.GetMethod("AddMenu");
            addMenu.Invoke(cls, new object[] { mnRoot });
        }
    }
}
