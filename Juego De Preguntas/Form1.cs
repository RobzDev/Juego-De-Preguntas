using System.Windows.Forms;

namespace Juego_De_Preguntas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int i = 0;
        // Manejador de eventos para respuestas incorrectas
        private void WrongAnswerrdButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked)
            {
                return;
            }
            TabPage? currentTabPage = tabControl1.SelectedTab;
            if (currentTabPage != null)
            {
                BlockRadioButtons(currentTabPage);
            }

            lastQuestionButton_Click(tabControl1.SelectedIndex);
           
            if (rb.Checked)
            {
                rb.BackColor = Color.Red;
            }
            else
            {
                rb.BackColor = Color.White;
            }
        }

        // Manejador de eventos para respuestas correctas
        private void RightAnswerrdButton_CheckedChanged(object sender, EventArgs e)
        {
            //if the change is not checked, return
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked)
            {
                return;
            }
            score++;

            TabPage? currentTabPage = tabControl1.SelectedTab;
            if (currentTabPage != null)
            {
                BlockRadioButtons(currentTabPage);
            }
            lastQuestionButton_Click(tabControl1.SelectedIndex);
        }

        // Bloquear los RadioButton en una pestaña
        private void BlockRadioButtons(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = false;
                }
            }
        }

        // Reiniciar los RadioButton y la puntuación
        private void resetButton_Click()
        {
            score = 0;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        radioButton.Enabled = true;
                        radioButton.Checked = false;
                        radioButton.BackColor = Color.White;
                    }
                }
            }
            tabControl1.SelectedIndex = 0;
            // Volver a la primera pestaña
        }

        private void lastQuestionButton_Click(int index)
        {
            if (index == tabControl1.TabCount - 1)
            {
                if (score == tabControl1.TabCount)
                {
                    MessageBox.Show("¡Felicidades! Has ganado el juego.");
                }
                else
                {
                    MessageBox.Show("Tu puntuación fue de: " + score);
                }

                resetButton_Click();
                return;
            }
        }
    }
}

