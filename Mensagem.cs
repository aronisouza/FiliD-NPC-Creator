using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NPC
{
    public partial class Mensagem : Form
    {
        
        public Mensagem(string titulo, string mensagem, string carinha, string textoBt )
        {
            InitializeComponent();
            tituloL = titulo;
            mensagemL = mensagem;
            carinhaL = carinha;
            textoBrL = textoBt;
            MensagemL();
        }

        public string tituloL { get; set; }
        public string mensagemL { get; set; }
        public string carinhaL { get; set; }
        public string textoBrL { get; set; }

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

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MensagemL()
        {
            lbCarinha.Text = carinhaL;
            lbTitulo.Text = tituloL;
            lbMensagem.Text = mensagemL;
            lbBotaoFundoTexto.Text = textoBrL;
        }

        private void lbBotaoFundoTexto_MouseDown(object sender, MouseEventArgs e)
        {
            lbBotaoFundoTexto.BackColor = Color.DimGray;
        }

        private void lbBotaoFundoTexto_MouseHover(object sender, EventArgs e)
        {
            lbBotaoFundoTexto.BackColor = Color.Gray;
        }

        private void lbBotaoFundoTexto_MouseLeave(object sender, EventArgs e)
        {
            lbBotaoFundoTexto.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void lbBotaoFundoTexto_MouseUp(object sender, MouseEventArgs e)
        {
            lbBotaoFundoTexto.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
    }
}
