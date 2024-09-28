namespace PuertoSerie
{
    partial class frmSerie
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
            btnConectar = new Button();
            label2 = new Label();
            rtbLog = new RichTextBox();
            btnActualizar = new Button();
            label3 = new Label();
            cmbEntrada = new ComboBox();
            cmbSalida = new ComboBox();
            label4 = new Label();
            termometro = new ProgressBar();
            label1 = new Label();
            lblTemp = new Label();
            btnEscala = new Button();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(210, 26);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(12, 56);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(70, 133);
            rtbLog.TabIndex = 4;
            rtbLog.Text = "";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(300, 26);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Entrada";
            label3.Click += label3_Click;
            // 
            // cmbEntrada
            // 
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(12, 27);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(70, 23);
            cmbEntrada.TabIndex = 9;
            // 
            // cmbSalida
            // 
            cmbSalida.FormattingEnabled = true;
            cmbSalida.Location = new Point(102, 27);
            cmbSalida.Name = "cmbSalida";
            cmbSalida.Size = new Size(70, 23);
            cmbSalida.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Salida";
            // 
            // termometro
            // 
            termometro.ForeColor = SystemColors.HotTrack;
            termometro.Location = new Point(117, 122);
            termometro.Maximum = 60;
            termometro.Name = "termometro";
            termometro.Size = new Size(277, 23);
            termometro.Step = 1;
            termometro.Style = ProgressBarStyle.Continuous;
            termometro.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 74);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 13;
            label1.Text = "Temperatura:";
            label1.Click += label1_Click;
            // 
            // lblTemp
            // 
            lblTemp.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemp.Location = new Point(240, 74);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(154, 21);
            lblTemp.TabIndex = 14;
            lblTemp.Text = "°";
            lblTemp.Click += lblTemp_Click;
            // 
            // btnEscala
            // 
            btnEscala.Location = new Point(299, 57);
            btnEscala.Name = "btnEscala";
            btnEscala.Size = new Size(76, 49);
            btnEscala.TabIndex = 15;
            btnEscala.Text = "Cambiar escala";
            btnEscala.UseVisualStyleBackColor = true;
            btnEscala.Click += btnEscala_Click;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 211);
            Controls.Add(btnEscala);
            Controls.Add(lblTemp);
            Controls.Add(label1);
            Controls.Add(termometro);
            Controls.Add(label4);
            Controls.Add(cmbSalida);
            Controls.Add(cmbEntrada);
            Controls.Add(label3);
            Controls.Add(btnActualizar);
            Controls.Add(rtbLog);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Name = "frmSerie";
            Text = "Puerto Serie";
            Load += frmSerie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConectar;
        private Label label2;
        private RichTextBox rtbLog;
        private Button btnActualizar;
        private Label label3;
        private ComboBox cmbEntrada;
        private ComboBox cmbSalida;
        private Label label4;
        private ProgressBar termometro;
        private Label label1;
        private Label lblTemp;
        private Button btnEscala;
    }
}
