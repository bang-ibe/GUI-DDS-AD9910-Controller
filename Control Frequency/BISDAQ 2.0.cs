using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Panel_Control_Frequency;

namespace Control_Frequency
{
    public partial class Form_ControlFreq_DataAcq : Form
    {
        private Panel LeftBorderBtn;
        
        public Form_ControlFreq_DataAcq()
        {
            InitializeComponent();
            icon_resize.Visible = false;
            Icon_Maximize.Visible = false;

            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);
            panel_MenuVertical.Controls.Add(LeftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Icon_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Icon_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Icon_Maximize.Visible = false;
            icon_resize.Visible = true;
        }

        private void icon_resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Icon_Maximize.Visible = true;
            icon_resize.Visible = false;
        }

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_BarTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddFormPanel(object Formhijo)
        {
            if (this.panel_Content.Controls.Count > 0)
                this.panel_Content.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Content.Controls.Add(fh);
            this.panel_Content.Tag = fh;
            fh.Show();
        } 

        private void button_ControlFrequency_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            AddFormPanel(new Form_ControlFrequency());
        }

        private void panel_MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
