using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NPC
{
    public partial class NpcQuest : Form
    {
        public NpcQuest()
        {
            InitializeComponent();
            lbnpcId.Text = Convert.ToString(npvId);
            //if (cbWeb.Checked) pictureBox1.ImageLocation = "http://nn.nachtwolke.com/dev/npclist/i/" + npdid.npcId(npvId) + ".gif";
            //else
            pictureBox1.ImageLocation = "npcspr/" + npdid.npcId(npvId) + ".gif";
        }
        // variavel
        public int npvId = 46, buscaTipo = 0;
        public int idItem1 = 0, idItem2 = 0, idItem3= 0, idItem4 = 0;
        _NpcId npdid = new _NpcId();

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

        private void btFecharWin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNextImg_Click(object sender, EventArgs e)
        {
            npvId++;
            if (!btPrevImg.Enabled) btPrevImg.Enabled = true;
            if (npvId >= 1000)
            {
                npvId--;
                btNextImg.Enabled = false;
                return;
            }

            if (npvId >= 126 && npvId <= 400) npvId = 401;

            //if(cbWeb.Checked) pictureBox1.ImageLocation = "http://nn.nachtwolke.com/dev/npclist/i/" + npdid.npcId(npvId) + ".gif";
            //else
            pictureBox1.ImageLocation = "npcspr/" + npdid.npcId(npvId) + ".gif";
            
            lbnpcId.Text = Convert.ToString(npvId);
            btNextImg.Focus();
        }

        private void btPrevImg_Click(object sender, EventArgs e)
        {
            npvId--;
            if (!btNextImg.Enabled) btNextImg.Enabled = true;
            if (npvId <= 44)
            {
                npvId++;
                btPrevImg.Enabled = false;
                return;
            }
            if (npvId >= 126 && npvId <= 400) npvId = 125;

            //if (cbWeb.Checked) pictureBox1.ImageLocation = "http://nn.nachtwolke.com/dev/npclist/i/" + npdid.npcId(npvId) + ".gif";
            //else
            pictureBox1.ImageLocation = "npcspr/" + npdid.npcId(npvId) + ".gif";

            lbnpcId.Text = Convert.ToString(npvId);
            btPrevImg.Focus();
        }

        private void lbnpcId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                npvId = Convert.ToInt32(lbnpcId.Text);
                if (npvId <= 44 || npvId >= 126 && npvId <= 400)
                {
                    npvId = 45;
                    lbnpcId.Text = Convert.ToString(npvId);
                }

                //if (cbWeb.Checked) pictureBox1.ImageLocation = "http://nn.nachtwolke.com/dev/npclist/i/" + npdid.npcId(npvId) + ".gif";
               //else
               pictureBox1.ImageLocation = "npcspr/" + npdid.npcId(npvId) + ".gif";

                txtNomeScript.Focus();
            }
        }

        private void soNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buscaTipo = 0;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            buscaTipo = 1;
        }

        //==================================================================================================================

        private void buscaItem(string texto)
        {
            try
            {
                if (txtnome.Text.Length > 0)
                {
                    cbList.Items.Clear();
                    string busca = buscaTipo == 0 ? "id" : "valor";
                    XElement xml = XElement.Load("items.xml");
                    var items = from p in xml.Descendants("item")
                                where p.Attribute(busca).Value.Contains(texto)
                                select new
                                {
                                    id = p.Attribute("id").Value,
                                    valor = p.Attribute("valor").Value
                                };
                    foreach (var item in items)
                        cbList.Items.Add(item.valor);
                }
                else cbList.Items.Clear();
                lbQntBusca.Text = cbList.Items.Count <= 1 ? "Item Encontrado [ " + Convert.ToString(cbList.Items.Count) + " ]" : "Itens Encontrados [ " + Convert.ToString(cbList.Items.Count) + " ]";
            }
            catch
            {
                lbTitulo.Text = "Erro na busca";
            }
        }

        private int buscaIdSelected(string texto)
        {
            try
            {
                if (txtnome.Text.Length > 0)
                {
                    XElement xml = XElement.Load("items.xml");
                    var items = from p in xml.Descendants("item")
                                where p.Attribute("valor").Value.Equals(texto)
                                select new
                                {
                                    id = p.Attribute("id").Value,
                                };

                    foreach (var item in items)
                        return Convert.ToInt32(item.id);
                }
            }
            catch
            {
                lbTitulo.Text = "Erro na busca id";
                return 512;
            }
            return 512;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            buscaItem(txtnome.Text);
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (rbItem1.Checked) i = 1;
            if (rbItem2.Checked) i = 2;
            if (rbItem3.Checked) i = 3;
            if (rbItem4.Checked) i = 4;

            switch (i)
            {
                case 1: rbItem1.Text = Convert.ToString(cbList.SelectedItem); idItem1 = buscaIdSelected(rbItem1.Text); break;
                case 2: rbItem2.Text = Convert.ToString(cbList.SelectedItem); idItem2 = buscaIdSelected(rbItem2.Text); break;
                case 3: rbItem3.Text = Convert.ToString(cbList.SelectedItem); idItem3 = buscaIdSelected(rbItem3.Text); break;
                case 4: rbItem4.Text = Convert.ToString(cbList.SelectedItem); idItem4 = buscaIdSelected(rbItem4.Text); break;
            }
        }

        // Meu botao =======================================================================================================
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

        // Botao ? =========================================================================================================
        private void lbBotaoInfo_MouseLeave(object sender, EventArgs e)
        {
            lbBotaoInfo.BackColor = SystemColors.MenuText;
            lbBotaoInfo.ForeColor = Color.White;
        }

        private void lbBotaoInfo_Click(object sender, EventArgs e)
        {
            Mensagem sms = new Mensagem("Informação do sistema", "Crie seu NPC de quest Simples. \r\rCom este aplicativo você faz um NPC que entrega 1 Item. Caso queira fazer varias quests terá que criar um NPC para cada uma.", "?", "Fechar");
            sms.ShowDialog();
        }
        private void lbBotaoInfo_MouseHover(object sender, EventArgs e)
        {
            lbBotaoInfo.ForeColor = Color.Turquoise;
            lbBotaoInfo.BackColor = Color.Gray;
        }
        // lbbotao ? 2 =====================================================================================================
        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Turquoise;
            label14.BackColor = Color.Gray;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Mensagem sms = new Mensagem("Informação do sistema", "Qnt = Quantidade do item necessária para fazer a quest.\rSelecione o item Vazio e clique no resultado da busca\rpara adicionar o valor ao item.", "?", "Fechar");
            sms.ShowDialog();
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label14.ForeColor = Color.White;
        }

        

        //==================================================================================================================
        private void checBuscatipo(object sender, KeyPressEventArgs e)
        {
            if (rbId.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    e.Handled = true;
            }
        }

        private void btScript_Click(object sender, EventArgs e)
        {
            if (npcScript() == "erro") return;
            Script scr = new Script(txtNomeScript.Text, npcScript());
            scr.ShowDialog();
        }

        private string npcScript()
        {
            if (string.IsNullOrEmpty(txtNomeScript.Text) || string.IsNullOrEmpty(txtMapa.Text) || string.IsNullOrEmpty(txtCoorx.Text) || string.IsNullOrEmpty(txtCoory.Text) || string.IsNullOrEmpty(txtIdPremio.Text) || string.IsNullOrEmpty(txtNomeScript.Text) ||
                string.IsNullOrEmpty(txtItem1Q.Text) || string.IsNullOrEmpty(txtItem2Q.Text) || string.IsNullOrEmpty(txtItem3Q.Text) || string.IsNullOrEmpty(txtItem4Q.Text) ||
                rbItem1.Text == "Vazio" || rbItem2.Text == "Vazio" || rbItem3.Text == "Vazio" || rbItem4.Text == "Vazio")
            {
                Mensagem sms = new Mensagem("Falta de Informações", "Todos os campos devem ser preenchidos\r\nE todos os 4 itens devem estar com um valor.", ":(", "Ok");
                sms.ShowDialog();
                return "erro";
            }

            else
            {
                int i = 0;
                if (rd0.Checked) i = 0;
                if (rd1.Checked) i = 1;
                if (rd2.Checked) i = 2;
                if (rd3.Checked) i = 3;
                if (rd4.Checked) i = 4;
                if (rd5.Checked) i = 5;
                if (rd6.Checked) i = 6;
                if (rd7.Checked) i = 7;
                string npc = txtMapa.Text + "," + txtCoorx.Text + "," + txtCoory.Text + "," + i + "\tscript\t" + txtNomeScript.Text + "\t" + lbnpcId.Text + ",{\r\n" +
                    "set .@tia$, \"^0000FF[ Quest ]^B5B5B5 By FiliÐ^000000\";\r\n" +
                    "if (vendoQuestn)\r\n" +
                    "{\r\n" +
                    "   mes .@tia$;\r\n" +
                    "   mes \"Você esta em modo de teste visual. Volte depois\";\r\n" +
                    "   close;\r\n" +
                    "}\r\n" +
                    "set .@idquest, " + txtIdPremio.Text + ";\r\n" +
                    "set .@itemquest01, " + idItem1 + ";\r\n" +
                    "set .@qntquest01, " + txtItem1Q.Text + ";\r\n" +
                    "set .@itemquest02, " + idItem2 + ";\r\n" +
                    "set .@qntquest02, " + txtItem2Q.Text + ";\r\n" +
                    "set .@itemquest03, " + idItem3 + ";\r\n" +
                    "set .@qntquest03, " + txtItem3Q.Text + ";\r\n" +
                    "set .@itemquest04, " + idItem4 + ";\r\n" +
                    "set .@qntquest04, " + txtItem4Q.Text + ";\r\n" +
                    "set .@ii, true;\r\n" +
                    "mes .@tia$;\r\n" +
                    "mes \"Sou responsável pela Quest ^0000BB\" +getitemname(.@idquest)+ \"^000000\";\r\n" +
                    "mes \"O que deseja fazer?\";\r\n" +
                    "next;\r\n" +
                    "   while (.@ii)\r\n" +
                    "   {\r\n" +
                    "        switch (select( \"^FF8000- Ver os Itens.^000000\", \"^007700- Fazer a Quest.^000000\", \"- ^004400Ver como fica.^000000\" ) )\r\n" +
                    "        {\r\n" +
                    "            case 1:\r\n" +
                    "                mes .@tia$;\r\n" +
                    "                mes \"Para fazer a Quest ^0000BB\" +getitemname(.@idquest)+ \"^000000 você precisa:\";\r\n" +
                    "                mes \"- ^0000BB\" +.@qntquest01+ \" ^DD0000\" +getitemname(.@itemquest01)+ \"^000000.\";\r\n" +
                    "                mes \"- ^0000BB\" +.@qntquest02+ \" ^DD0000\" +getitemname(.@itemquest02)+ \"^000000.\";\r\n" +
                    "                mes \"- ^0000BB\" +.@qntquest03+ \" ^DD0000\" +getitemname(.@itemquest03)+ \"^000000.\";\r\n" +
                    "                next;\r\n" +
                    "                mes .@tia$;\r\n" +
                    "                mes \"O que deseja fazer agora?\";\r\n" +
                    "                next;\r\n" +
                    "                break;\r\n" +
                    "            case 2:\r\n" +
                    "                mes .@tia$;\r\n" +
                    "                mes \"Muito bem!\";\r\n" +
                    "                mes \"Deixe-me ver se você esta com todos os itens necessários para fazer a Quest: ^DD0000\" +getitemname(.@idquest)+ \"^000000.\";\r\n" +
                    "                next;\r\n" +
                    "                if (countitem(.@itemquest01) < .@qntquest01 || countitem(.@itemquest02) < .@qntquest02 || countitem(.@itemquest03) < .@qntquest03 || countitem(.@itemquest04) < .@qntquest04)\r\n" +
                    "                {\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Desculpe mais você não esta com todos os itens.\";\r\n" +
                    "                    next;\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Esta faltando:\";\r\n" +
                    "                    if (countitem(.@itemquest01) < .@qntquest01)\r\n" +
                    "                        mes \"- ^DD0000\" +(.@qntquest01 - countitem(.@itemquest01))+ \"^000000 \" +getitemname(.@itemquest01)+ \".\";\r\n" +
                    "                    if (countitem(.@itemquest02) < .@qntquest02)\r\n" +
                    "                        mes \"- ^DD0000\" +(.@qntquest02 - countitem(.@itemquest02))+ \"^000000 \" +getitemname(.@itemquest02)+ \".\";\r\n" +
                    "                    if (countitem(.@itemquest03) < .@qntquest03)\r\n" +
                    "                        mes \"- ^DD0000\" +(.@qntquest03 - countitem(.@itemquest03))+ \"^000000 \" +getitemname(.@itemquest03)+ \".\";\r\n" +
                    "                    if (countitem(.@itemquest04) < .@qntquest04)\r\n" +
                    "                        mes \"- ^DD0000\" +(.@qntquest04 - countitem(.@itemquest04))+ \"^000000 \" +getitemname(.@itemquest04)+ \".\";\r\n" +
                    "                    next;\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Volte quando estiver com Todos.\";\r\n" +
                    "                    set.@ii, false;\r\n" +
                    "                }\r\n" +
                    "                else\r\n" +
                    "                {\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Parabéns ^0000BB\" +strcharinfo(0)+ \"^000000! Você completou a quest!\";\r\n" +
                    "                    delitem .@itemquest01, .@qntquest01;\r\n" +
                    "                    delitem .@itemquest02, .@qntquest02;\r\n" +
                    "                    delitem .@itemquest03, .@qntquest03;\r\n" +
                    "                    delitem .@itemquest04, .@qntquest04;\r\n" +
                    "                    next;\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Aqui está a sua Quest.\";\r\n" +
                    "                    getitem .@idquest, 1;\r\n" +
                    "                    next;\r\n" +
                    "                    mes .@tia$;\r\n" +
                    "                    mes \"Volte sempre!\";\r\n" +
                    "                    set .@ii, false;\r\n" +
                    "                }\r\n" +
                    "                break;\r\n" +
                    "            case 3:\r\n" +
                    "                set @bottomview, getlook(3);\r\n" +
                    "                set @topview, getlook(4);\r\n" +
                    "                set @midview, getlook(5);\r\n" +
                    "                mes .@tia$;\r\n" +
                    "                mes \"Ok o item ^0000BB\" +getitemname(.@idquest)+ \"^000000 ficará com você por 1 minuto.\";\r\n" +
                    "                mes \"Enquanto não terminar o tempo não deslogue do char ou use outro item, pois você poderá bugar!\";\r\n" +
                    "                close2;\r\n" +
                    "                    set @equip, getiteminfo(.@idquest, 5);\r\n" +
                    "                    set @view, getiteminfo(.@idquest, 11);\r\n" +
                    "                    set vendoQuestn, 1;\r\n" +
                    "                    atcommand \"@changelook 1 \" + 0;\r\n" +
                    "                    atcommand \"@changelook 2 \" + 0;\r\n" +
                    "                    atcommand \"@changelook 3 \" + 0;\r\n" +
                    "                    if (@equip != -1 && @view > 0)\r\n" +
                    "                    {\r\n" +
                    "                        if (@equip & 1) atcommand \"@changelook 3 \" +@view;\r\n" +
                    "                        if (@equip & 256) atcommand \"@changelook 1 \" +@view;\r\n" +
                    "                        if (@equip & 512) atcommand \"@changelook 2 \" +@view;\r\n" +
                    "                    }\r\n" +
                    "                   sleep2 60000;\r\n" +
                    "                   dispbottom \"Obrigado, espero que tenha gostado.\";\r\n" +
                    "                   atcommand \"@changelook 1 \" +@topview;\r\n" +
                    "                   atcommand \"@changelook 2 \" +@midview;\r\n" +
                    "                   atcommand \"@changelook 3 \" +@bottomview;\r\n" +
                    "                   set vendoQuestn, 0;\r\n" +
                    "                end;\r\n" +
                    "       }\r\n" +
                    "    }\r\n" +
                    "    close;\r\n" +
                    "}";
                return npc;
            }
        }
    }
}
