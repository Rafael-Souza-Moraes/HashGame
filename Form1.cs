using System;
using System.Windows.Forms;

namespace HashGame {
    
    public partial class Form1 : Form {
        
        bool X, O = false;
        int QTD, QTDX, QTDO, Empates, Limite = 1, Partida;

        private void btn1_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn1.Text = "X";
                btn1.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn1.Text = "O";
                btn1.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn2_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn2.Text = "X";
                btn2.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn2.Text = "O";
                btn2.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn3_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn3.Text = "X";
                btn3.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn3.Text = "O";
                btn3.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn4_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn4.Text = "X";
                btn4.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn4.Text = "O";
                btn4.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn5_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn5.Text = "X";
                btn5.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn5.Text = "O";
                btn5.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn6_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn6.Text = "X";
                btn6.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn6.Text = "O";
                btn6.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn7_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn7.Text = "X";
                btn7.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn7.Text = "O";
                btn7.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }


        private void btn8_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn8.Text = "X";
                btn8.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn8.Text = "O";
                btn8.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        private void btn9_Click(object sender, EventArgs e) {
            
            btnReset.Enabled = true;

            if (X == true && O == false) {
                
                btn9.Text = "X";
                btn9.Enabled = false;
                X = false;
                O = true;
            }
            else {
                
                btn9.Text = "O";
                btn9.Enabled = false;
                X = true;
                O = false;
            }
            Clicks();
            Ganhador();
            Empate();
            Contador();
        }

        public void Ganhador() {
            
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" || btn4.Text != "" && btn5.Text != "" && btn6.Text != "" || btn7.Text != "" && btn8.Text != "" && btn9.Text != "" || btn1.Text != "" && btn4.Text != "" && btn7.Text != "" || btn2.Text != "" && btn5.Text != "" && btn8.Text != "" || btn3.Text != "" && btn6.Text != "" && btn9.Text != "" || btn1.Text != "" && btn5.Text != "" && btn9.Text != "" || btn3.Text != "" && btn5.Text != "" && btn7.Text != "") {
                
                if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" || btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") {
                    
                    QTDX++;
                    lblXPont.Text = QTDX.ToString();
                    MessageBox.Show("Ponto para o Jogador X!", "Jogador X", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Partidas();
                    Limpar();
                }
                else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") {
                    
                    QTDO++;
                    lblOPont.Text = QTDO.ToString();
                    MessageBox.Show("Ponto para o Jogador O!", "Jogador O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Partidas();
                    Limpar();
                }
            }
        }

        public void Empate() {
            
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "") {
                
                /* Dinamicidade... */
                if (!(btn1.Text != "O" && btn2.Text != "O" && btn3.Text != "O") || (btn4.Text != "O" && btn5.Text != "O" && btn6.Text != "O") || (btn7.Text != "O" && btn8.Text != "O" && btn9.Text != "O") || (btn1.Text != "O" && btn4.Text != "O" && btn7.Text != "O") || (btn2.Text != "O" && btn5.Text != "O" && btn8.Text != "O") || (btn3.Text != "O" && btn6.Text != "O" && btn9.Text != "O") || (btn1.Text != "O" && btn5.Text != "O" && btn9.Text != "O") || (btn3.Text != "O" && btn5.Text != "O" && btn7.Text != "O") || (btn1.Text != "X" && btn2.Text != "X" && btn3.Text != "X") || (btn4.Text != "X" && btn5.Text != "X" && btn6.Text != "X") || (btn7.Text != "X" && btn8.Text != "X" && btn9.Text != "X") || (btn1.Text != "X" && btn4.Text != "X" && btn7.Text != "X") || (btn2.Text != "X" && btn5.Text != "X" && btn8.Text != "X") || (btn3.Text != "X" && btn6.Text != "X" && btn9.Text != "X") || (btn1.Text != "X" && btn5.Text != "X" && btn9.Text != "X") || (btn3.Text != "X" && btn5.Text != "X" && btn7.Text != "X")) {
                    
                    MessageBox.Show("Ih! Deu empate...", "Nem um nem outro...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Empates++;
                    lblEmpates.Text = Empates.ToString();
                    Partidas();
                    Limpar();
                }
            }
        }

        public void Contador() {                     
            
            if (QTDX == int.Parse(lblLimite.Text)) {
                
                MessageBox.Show($"Fim de jogo! O ganhador foi o jogador X com um total de {QTDX} pontos! Enquanto seu adversário, jogador O, ficou com um total de {QTDO} pontos! Houve uma diferença de {QTDX - QTDO} pontos! O número de empates nessa partida foi de {Empates}! Dê um Ok para continuar...", "Jogador X", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpar();
                Zerar();
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnOk.Enabled = true;
                Reiniciar();
            }

            if (QTDO == int.Parse(lblLimite.Text)) {
                
                MessageBox.Show($"Fim de jogo! O ganhador foi o jogador O com um total de {QTDO} pontos! Enquanto seu adversário, jogador X, ficou com um total de {QTDX} pontos! Houve uma diferença de {QTDO - QTDX} pontos! O número de empates nessa partida foi de {Empates}! Dê um Ok para continuar...", "Jogador O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpar();
                Zerar();
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnOk.Enabled = true;
                Reiniciar();
            }
        }

        public void Reiniciar() {
            
            QTDX = 0;
            QTDO = 0;
            Empates = 0;
        }

        public void Partidas() {
            
            Partida++;
            lblPartidas.Text = Partida.ToString();
        }

        public void Zerar() {
            
            btnXP.Enabled = false;
            btnOP.Enabled = false;
            lblOPont.Text = "0";
            lblXPont.Text = "0";
            lblEmpates.Text = "0";
        }

        public void Limpar() {
            
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnReset.Enabled = false;
            btnXP.Enabled = true;
            btnOP.Enabled = true;
            Clicks();
        }

        public void Opcao() {
            
            btnXP.Enabled = false;
            btnOP.Enabled = false;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        public void Clicks() {
            
            QTD++;
            lblClick.Text = QTD.ToString();
        }

        private void btnOP_Click(object sender, EventArgs e) {
            
            O = true;
            X = false;
            Opcao();
            Clicks();
        }

        private void btnXP_Click(object sender, EventArgs e) {
            
            X = true;
            O = false;
            Opcao();
            Clicks();
        }
      
        private void btnOk_Click(object sender, EventArgs e) {
            
            btnMais.Enabled = false;
            btnMenos.Enabled = false;
            btnOk.Enabled = false;
            Clicks();
            btnXP.Enabled = true;
            btnOP.Enabled = true;
        }

        /* Menos 1 */
        private void button1_Click(object sender, EventArgs e) {
            
            Clicks();
            if (Limite <= 1)
                lblLimite.Text = "1";
            else
                lblLimite.Text = (Limite -= 1).ToString();
        }

        /* Mais um */
        private void button1_Click_1(object sender, EventArgs e) {
            
            Clicks();
            lblLimite.Text = (Limite += 1).ToString();
        }
        
        private void btnSair_Click(object sender, EventArgs e) => Close();
        private void btnReset_Click(object sender, EventArgs e) => Limpar();
        private void Form1_Load(object sender, EventArgs e) => MessageBox.Show("Boa sorte!", "Tenham um bom jogo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        public Form1() => InitializeComponent();
    }
}