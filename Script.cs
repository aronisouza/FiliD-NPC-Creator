using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NPC
{
    public partial class Script : Form
    {
        public Script(string titulo, string script)
        {
            InitializeComponent();
            tituloL = titulo;
            scriptL = script;
            MensagemL();
        }

        public string tituloL { get; set; }
        public string scriptL { get; set; }

        private void MensagemL()
        {
            lbTitulo.Text = "NPC : " + tituloL;
            txtScript.Text = scriptL;
            lbBotaoFundoTexto.Focus();
        }

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

        private void lbBotaoFundoTexto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbBotaoSalvar_Click(object sender, EventArgs e)
        {
            string s = tituloL;
            s = s.Replace(" ", "");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Filid Npc|*.txt";
            sfd.FileName = s + "_fld";
            sfd.CheckPathExists = true;
            sfd.ShowDialog();
            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                using (StreamWriter ws = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    ws.WriteLine(txtScript.Text);
                    ws.Write("// Criado com FiliÐ NPC Creator.");
                }
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
