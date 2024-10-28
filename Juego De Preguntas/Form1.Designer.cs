namespace Juego_De_Preguntas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpGeografia = new TabPage();
            rightAnswer1 = new RadioButton();
            Geowronganswer2 = new RadioButton();
            Geowronganswer1 = new RadioButton();
            lblGeografia = new Label();
            tpRedes = new TabPage();
            RedesWrongAnswer1 = new RadioButton();
            RedesWrongAnswer2 = new RadioButton();
            rightAnswer2 = new RadioButton();
            label1 = new Label();
            tpAnatomia = new TabPage();
            AnatomiaWrongAnswer1 = new RadioButton();
            AnatomiaWrongAnswer2 = new RadioButton();
            rightAnswer3 = new RadioButton();
            label2 = new Label();
            tpProgramacion = new TabPage();
            InformaticaWrongAnswer1 = new RadioButton();
            InformaticaWrongAnswer2 = new RadioButton();
            rightAnswer4 = new RadioButton();
            label3 = new Label();
            tpBiologia = new TabPage();
            rightAnswer5 = new RadioButton();
            BiologiaWrongAnswer2 = new RadioButton();
            BiologiaWrongAnswer1 = new RadioButton();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tpGeografia.SuspendLayout();
            tpRedes.SuspendLayout();
            tpAnatomia.SuspendLayout();
            tpProgramacion.SuspendLayout();
            tpBiologia.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpGeografia);
            tabControl1.Controls.Add(tpRedes);
            tabControl1.Controls.Add(tpAnatomia);
            tabControl1.Controls.Add(tpProgramacion);
            tabControl1.Controls.Add(tpBiologia);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tpGeografia
            // 
            tpGeografia.Controls.Add(rightAnswer1);
            tpGeografia.Controls.Add(Geowronganswer2);
            tpGeografia.Controls.Add(Geowronganswer1);
            tpGeografia.Controls.Add(lblGeografia);
            tpGeografia.Location = new Point(4, 24);
            tpGeografia.Name = "tpGeografia";
            tpGeografia.Padding = new Padding(3);
            tpGeografia.Size = new Size(768, 398);
            tpGeografia.TabIndex = 0;
            tpGeografia.Text = "Geografia";
            tpGeografia.UseVisualStyleBackColor = true;
            // 
            // rightAnswer1
            // 
            rightAnswer1.AutoSize = true;
            rightAnswer1.Font = new Font("Yu Gothic", 12F);
            rightAnswer1.Location = new Point(259, 150);
            rightAnswer1.Name = "rightAnswer1";
            rightAnswer1.Size = new Size(227, 25);
            rightAnswer1.TabIndex = 3;
            rightAnswer1.Text = "Polonia, Eslovaquia, Serbia";
            rightAnswer1.UseVisualStyleBackColor = true;
            rightAnswer1.CheckedChanged += RightAnswerrdButton_CheckedChanged;
            // 
            // Geowronganswer2
            // 
            Geowronganswer2.AutoSize = true;
            Geowronganswer2.Font = new Font("Yu Gothic", 12F);
            Geowronganswer2.Location = new Point(259, 196);
            Geowronganswer2.Name = "Geowronganswer2";
            Geowronganswer2.Size = new Size(192, 25);
            Geowronganswer2.TabIndex = 2;
            Geowronganswer2.Text = "Grecia, Italia, Bulgaria";
            Geowronganswer2.UseVisualStyleBackColor = true;
            Geowronganswer2.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // Geowronganswer1
            // 
            Geowronganswer1.AutoSize = true;
            Geowronganswer1.Font = new Font("Yu Gothic", 12F);
            Geowronganswer1.Location = new Point(259, 97);
            Geowronganswer1.Name = "Geowronganswer1";
            Geowronganswer1.Size = new Size(210, 25);
            Geowronganswer1.TabIndex = 1;
            Geowronganswer1.Text = "Hungría, Austria, Albania";
            Geowronganswer1.UseVisualStyleBackColor = true;
            Geowronganswer1.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // lblGeografia
            // 
            lblGeografia.AutoSize = true;
            lblGeografia.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            lblGeografia.Location = new Point(103, 33);
            lblGeografia.Name = "lblGeografia";
            lblGeografia.Size = new Size(606, 26);
            lblGeografia.TabIndex = 0;
            lblGeografia.Text = "¿Cuál de los siguientes países pertenece a la región eslava?";
            // 
            // tpRedes
            // 
            tpRedes.Controls.Add(RedesWrongAnswer1);
            tpRedes.Controls.Add(RedesWrongAnswer2);
            tpRedes.Controls.Add(rightAnswer2);
            tpRedes.Controls.Add(label1);
            tpRedes.Location = new Point(4, 24);
            tpRedes.Name = "tpRedes";
            tpRedes.Padding = new Padding(3);
            tpRedes.Size = new Size(768, 398);
            tpRedes.TabIndex = 1;
            tpRedes.Text = "Redes";
            tpRedes.UseVisualStyleBackColor = true;
            // 
            // RedesWrongAnswer1
            // 
            RedesWrongAnswer1.AutoSize = true;
            RedesWrongAnswer1.Font = new Font("Yu Gothic", 12F);
            RedesWrongAnswer1.Location = new Point(239, 213);
            RedesWrongAnswer1.Name = "RedesWrongAnswer1";
            RedesWrongAnswer1.Size = new Size(236, 25);
            RedesWrongAnswer1.TabIndex = 7;
            RedesWrongAnswer1.TabStop = true;
            RedesWrongAnswer1.Text = "FTP (File Transfer Protocol)";
            RedesWrongAnswer1.UseVisualStyleBackColor = true;
            RedesWrongAnswer1.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // RedesWrongAnswer2
            // 
            RedesWrongAnswer2.AutoSize = true;
            RedesWrongAnswer2.Font = new Font("Yu Gothic", 12F);
            RedesWrongAnswer2.Location = new Point(239, 278);
            RedesWrongAnswer2.Name = "RedesWrongAnswer2";
            RedesWrongAnswer2.Size = new Size(311, 25);
            RedesWrongAnswer2.TabIndex = 6;
            RedesWrongAnswer2.TabStop = true;
            RedesWrongAnswer2.Text = "SMTP (Simple Mail Transfer Protocol)";
            RedesWrongAnswer2.UseVisualStyleBackColor = true;
            RedesWrongAnswer2.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // rightAnswer2
            // 
            rightAnswer2.AutoSize = true;
            rightAnswer2.Font = new Font("Yu Gothic", 12F);
            rightAnswer2.Location = new Point(239, 142);
            rightAnswer2.Name = "rightAnswer2";
            rightAnswer2.Size = new Size(294, 25);
            rightAnswer2.TabIndex = 5;
            rightAnswer2.TabStop = true;
            rightAnswer2.Text = "HTTP (Hypertext Transfer Protocol)";
            rightAnswer2.TextAlign = ContentAlignment.BottomRight;
            rightAnswer2.UseVisualStyleBackColor = true;
            rightAnswer2.CheckedChanged += RightAnswerrdButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(72, 17);
            label1.Name = "label1";
            label1.Size = new Size(665, 78);
            label1.TabIndex = 4;
            label1.Text = "¿Cuál es el protocolo principal que se utiliza para la transferencia \r\nde información en la web\r\n y permite a los navegadores acceder a páginas web?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tpAnatomia
            // 
            tpAnatomia.Controls.Add(AnatomiaWrongAnswer1);
            tpAnatomia.Controls.Add(AnatomiaWrongAnswer2);
            tpAnatomia.Controls.Add(rightAnswer3);
            tpAnatomia.Controls.Add(label2);
            tpAnatomia.Location = new Point(4, 24);
            tpAnatomia.Name = "tpAnatomia";
            tpAnatomia.Padding = new Padding(3);
            tpAnatomia.Size = new Size(768, 398);
            tpAnatomia.TabIndex = 2;
            tpAnatomia.Text = "Anatomia";
            tpAnatomia.UseVisualStyleBackColor = true;
            // 
            // AnatomiaWrongAnswer1
            // 
            AnatomiaWrongAnswer1.AutoSize = true;
            AnatomiaWrongAnswer1.Font = new Font("Yu Gothic", 12F);
            AnatomiaWrongAnswer1.Location = new Point(292, 213);
            AnatomiaWrongAnswer1.Name = "AnatomiaWrongAnswer1";
            AnatomiaWrongAnswer1.Size = new Size(141, 25);
            AnatomiaWrongAnswer1.TabIndex = 11;
            AnatomiaWrongAnswer1.Text = "Bíceps braquial";
            AnatomiaWrongAnswer1.UseVisualStyleBackColor = true;
            AnatomiaWrongAnswer1.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // AnatomiaWrongAnswer2
            // 
            AnatomiaWrongAnswer2.AutoSize = true;
            AnatomiaWrongAnswer2.Font = new Font("Yu Gothic", 12F);
            AnatomiaWrongAnswer2.Location = new Point(292, 267);
            AnatomiaWrongAnswer2.Name = "AnatomiaWrongAnswer2";
            AnatomiaWrongAnswer2.Size = new Size(132, 25);
            AnatomiaWrongAnswer2.TabIndex = 10;
            AnatomiaWrongAnswer2.Text = "Braquiorradial";
            AnatomiaWrongAnswer2.UseVisualStyleBackColor = true;
            AnatomiaWrongAnswer2.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // rightAnswer3
            // 
            rightAnswer3.AutoSize = true;
            rightAnswer3.Font = new Font("Yu Gothic", 12F);
            rightAnswer3.Location = new Point(292, 159);
            rightAnswer3.Name = "rightAnswer3";
            rightAnswer3.Size = new Size(146, 25);
            rightAnswer3.TabIndex = 9;
            rightAnswer3.Text = "Triceps Braquial";
            rightAnswer3.TextAlign = ContentAlignment.BottomRight;
            rightAnswer3.UseVisualStyleBackColor = true;
            rightAnswer3.CheckedChanged += RightAnswerrdButton_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label2.Location = new Point(144, 43);
            label2.Name = "label2";
            label2.Size = new Size(470, 92);
            label2.TabIndex = 8;
            label2.Text = "¿Cuál de los siguientes músculos es el principal responsable de la extensión del codo\r\n permitiendo alejar la mano del hombro?";
            // 
            // tpProgramacion
            // 
            tpProgramacion.Controls.Add(InformaticaWrongAnswer1);
            tpProgramacion.Controls.Add(InformaticaWrongAnswer2);
            tpProgramacion.Controls.Add(rightAnswer4);
            tpProgramacion.Controls.Add(label3);
            tpProgramacion.Location = new Point(4, 24);
            tpProgramacion.Name = "tpProgramacion";
            tpProgramacion.Size = new Size(768, 398);
            tpProgramacion.TabIndex = 0;
            tpProgramacion.Text = "Informatica";
            tpProgramacion.UseVisualStyleBackColor = true;
            // 
            // InformaticaWrongAnswer1
            // 
            InformaticaWrongAnswer1.AutoSize = true;
            InformaticaWrongAnswer1.Font = new Font("Yu Gothic", 12F);
            InformaticaWrongAnswer1.Location = new Point(234, 128);
            InformaticaWrongAnswer1.Name = "InformaticaWrongAnswer1";
            InformaticaWrongAnswer1.Size = new Size(188, 25);
            InformaticaWrongAnswer1.TabIndex = 11;
            InformaticaWrongAnswer1.Text = "Tarjeta gráfica (GPU)";
            InformaticaWrongAnswer1.UseVisualStyleBackColor = true;
            InformaticaWrongAnswer1.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // InformaticaWrongAnswer2
            // 
            InformaticaWrongAnswer2.AutoSize = true;
            InformaticaWrongAnswer2.Font = new Font("Yu Gothic", 12F);
            InformaticaWrongAnswer2.Location = new Point(234, 259);
            InformaticaWrongAnswer2.Name = "InformaticaWrongAnswer2";
            InformaticaWrongAnswer2.Size = new Size(135, 25);
            InformaticaWrongAnswer2.TabIndex = 10;
            InformaticaWrongAnswer2.Text = "Memoria RAM";
            InformaticaWrongAnswer2.UseVisualStyleBackColor = true;
            InformaticaWrongAnswer2.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // rightAnswer4
            // 
            rightAnswer4.AutoSize = true;
            rightAnswer4.Font = new Font("Yu Gothic", 12F);
            rightAnswer4.Location = new Point(234, 188);
            rightAnswer4.Name = "rightAnswer4";
            rightAnswer4.Size = new Size(324, 25);
            rightAnswer4.TabIndex = 9;
            rightAnswer4.Text = "Unidad central de procesamiento (CPU)";
            rightAnswer4.TextAlign = ContentAlignment.BottomRight;
            rightAnswer4.UseVisualStyleBackColor = true;
            rightAnswer4.CheckedChanged += RightAnswerrdButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label3.Location = new Point(111, 21);
            label3.Name = "label3";
            label3.Size = new Size(569, 104);
            label3.TabIndex = 8;
            label3.Text = "¿Cuál de los siguientes componentes es responsable de \r\nrealizar los cálculos y operaciones lógicas\r\n en una computadora?\r\n\r\n";
            // 
            // tpBiologia
            // 
            tpBiologia.Controls.Add(rightAnswer5);
            tpBiologia.Controls.Add(BiologiaWrongAnswer2);
            tpBiologia.Controls.Add(BiologiaWrongAnswer1);
            tpBiologia.Controls.Add(label4);
            tpBiologia.Location = new Point(4, 24);
            tpBiologia.Name = "tpBiologia";
            tpBiologia.Size = new Size(768, 398);
            tpBiologia.TabIndex = 0;
            tpBiologia.Text = "Biologia";
            tpBiologia.UseVisualStyleBackColor = true;
            // 
            // rightAnswer5
            // 
            rightAnswer5.AutoSize = true;
            rightAnswer5.Font = new Font("Yu Gothic", 12F);
            rightAnswer5.Location = new Point(292, 221);
            rightAnswer5.Name = "rightAnswer5";
            rightAnswer5.Size = new Size(158, 25);
            rightAnswer5.TabIndex = 15;
            rightAnswer5.Text = "Seleccion Natural";
            rightAnswer5.UseVisualStyleBackColor = true;
            rightAnswer5.CheckedChanged += RightAnswerrdButton_CheckedChanged;
            // 
            // BiologiaWrongAnswer2
            // 
            BiologiaWrongAnswer2.AutoSize = true;
            BiologiaWrongAnswer2.Font = new Font("Yu Gothic", 12F);
            BiologiaWrongAnswer2.Location = new Point(292, 170);
            BiologiaWrongAnswer2.Name = "BiologiaWrongAnswer2";
            BiologiaWrongAnswer2.Size = new Size(165, 25);
            BiologiaWrongAnswer2.TabIndex = 14;
            BiologiaWrongAnswer2.Text = "Mutación genética";
            BiologiaWrongAnswer2.UseVisualStyleBackColor = true;
            BiologiaWrongAnswer2.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // BiologiaWrongAnswer1
            // 
            BiologiaWrongAnswer1.AutoSize = true;
            BiologiaWrongAnswer1.Font = new Font("Yu Gothic", 12F);
            BiologiaWrongAnswer1.Location = new Point(293, 119);
            BiologiaWrongAnswer1.Name = "BiologiaWrongAnswer1";
            BiologiaWrongAnswer1.Size = new Size(144, 25);
            BiologiaWrongAnswer1.TabIndex = 13;
            BiologiaWrongAnswer1.Text = "Deriva genética";
            BiologiaWrongAnswer1.TextAlign = ContentAlignment.BottomRight;
            BiologiaWrongAnswer1.UseVisualStyleBackColor = true;
            BiologiaWrongAnswer1.CheckedChanged += WrongAnswerrdButton_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label4.Location = new Point(118, 16);
            label4.Name = "label4";
            label4.Size = new Size(513, 100);
            label4.TabIndex = 12;
            label4.Text = "¿Cuál de los siguientes conceptos describe el proceso por el cual los organismos \r\nmejor adaptados a su entorno tienden a sobrevivir y reproducirse con mayor éxito?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tpGeografia.ResumeLayout(false);
            tpGeografia.PerformLayout();
            tpRedes.ResumeLayout(false);
            tpRedes.PerformLayout();
            tpAnatomia.ResumeLayout(false);
            tpAnatomia.PerformLayout();
            tpProgramacion.ResumeLayout(false);
            tpProgramacion.PerformLayout();
            tpBiologia.ResumeLayout(false);
            tpBiologia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpGeografia;
        private TabPage tpRedes;
        private TabPage tpAnatomia;
        private TabPage tpProgramacion;
        private TabPage tpBiologia;
        private Label lblGeografia;
        private RadioButton rightAnswer1;
        private RadioButton Geowronganswer2;
        private RadioButton Geowronganswer1;
        private RadioButton RedesWrongAnswer1;
        private RadioButton RedesWrongAnswer2;
        private RadioButton rightAnswer2;
        private Label label1;
        private RadioButton AnatomiaWrongAnswer1;
        private RadioButton AnatomiaWrongAnswer2;
        private RadioButton rightAnswer3;
        private Label label2;
        private RadioButton InformaticaWrongAnswer1;
        private RadioButton InformaticaWrongAnswer2;
        private RadioButton rightAnswer4;
        private Label label3;
        private RadioButton rightAnswer5;
        private RadioButton BiologiaWrongAnswer2;
        private RadioButton BiologiaWrongAnswer1;
        private Label label4;
    }
}
