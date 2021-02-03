using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NPC
{
    public partial class NpcFalas : Form
    {
        public NpcFalas()
        {
            InitializeComponent();
        }

        // Metodos de arrastar ================================================================================================
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveJ(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Botao informação ====================================================================================================
        private void lbBotaoInfo_Click(object sender, EventArgs e)
        {

        }

        private void lbBotaoInfo_MouseHover(object sender, EventArgs e)
        {
            lbBotaoInfo.ForeColor = Color.Turquoise;
            lbBotaoInfo.BackColor = Color.Gray;
        }

        private void lbBotaoInfo_MouseLeave(object sender, EventArgs e)
        {
            lbBotaoInfo.BackColor = SystemColors.MenuText;
            lbBotaoInfo.ForeColor = Color.White;
        }

        // Botao fechar ====================================================================================================
        private void lbBotaoFechar_MouseDown(object sender, MouseEventArgs e)
        {
            lbBotaoFechar.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        }

        private void lbBotaoFechar_MouseHover(object sender, EventArgs e)
        {
            lbBotaoFechar.BackColor = Color.Red;
        }

        private void lbBotaoFechar_MouseLeave(object sender, EventArgs e)
        {
            lbBotaoFechar.BackColor = SystemColors.MenuText;
        }

        private void lbBotaoFechar_MouseUp(object sender, MouseEventArgs e)
        {
            lbBotaoFechar.BackColor = Color.Red;
        }

        private void lbBotaoFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
