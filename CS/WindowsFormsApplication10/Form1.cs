using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (Int64 i = 0; i < Int64.MaxValue; i++)
            {

                BackColor = Color.FromArgb(BackColor.R, BackColor.R, Convert.ToByte(i % 255));
                Refresh();
                Application.DoEvents();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            popupContainerEdit1.Properties.Popup += new EventHandler(Properties_Popup);
            popupContainerEdit1.Properties.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(Properties_CloseUp);
        }

        void Properties_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            (sender as TextEdit).SelectionStart = 0;
            (sender as TextEdit).SelectionLength = (sender as TextEdit).Text.Length;
        }

        void Properties_Popup(object sender, EventArgs e)
        {
            memoEdit1.SelectAll();
        }

        private void popupContainerEdit1_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            memoEdit1.Text = (sender as TextEdit).Text;
        }

        private void popupContainerEdit1_Properties_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = memoEdit1.Text;
        }
    }
}
