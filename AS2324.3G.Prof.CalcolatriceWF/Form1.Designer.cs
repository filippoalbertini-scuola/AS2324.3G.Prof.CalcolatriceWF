namespace AS2324._3G.Prof.CalcolatriceWF
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
            txtOperando1 = new TextBox();
            txtOperando2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbOperatore = new ComboBox();
            label3 = new Label();
            btnCalcola = new Button();
            lblRisultato = new Label();
            SuspendLayout();
            // 
            // txtOperando1
            // 
            txtOperando1.Location = new Point(206, 54);
            txtOperando1.Name = "txtOperando1";
            txtOperando1.Size = new Size(125, 27);
            txtOperando1.TabIndex = 0;
            // 
            // txtOperando2
            // 
            txtOperando2.Location = new Point(206, 103);
            txtOperando2.Name = "txtOperando2";
            txtOperando2.Size = new Size(125, 27);
            txtOperando2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 57);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Operando 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 104);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Operando 2";
            // 
            // cmbOperatore
            // 
            cmbOperatore.FormattingEnabled = true;
            cmbOperatore.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperatore.Location = new Point(196, 165);
            cmbOperatore.Name = "cmbOperatore";
            cmbOperatore.Size = new Size(151, 28);
            cmbOperatore.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 168);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Operatore";
            // 
            // btnCalcola
            // 
            btnCalcola.Location = new Point(224, 223);
            btnCalcola.Name = "btnCalcola";
            btnCalcola.Size = new Size(94, 29);
            btnCalcola.TabIndex = 3;
            btnCalcola.Text = "=";
            btnCalcola.UseVisualStyleBackColor = true;
            // 
            // lblRisultato
            // 
            lblRisultato.AutoSize = true;
            lblRisultato.Location = new Point(196, 293);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.Size = new Size(80, 20);
            lblRisultato.TabIndex = 1;
            lblRisultato.Text = "Risultato ...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 359);
            Controls.Add(btnCalcola);
            Controls.Add(cmbOperatore);
            Controls.Add(lblRisultato);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOperando2);
            Controls.Add(txtOperando1);
            Name = "Form1";
            Text = "3G;14/03/24;Prof;Calcolatrice Windows Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperando1;
        private TextBox txtOperando2;
        private Label label1;
        private Label label2;
        private ComboBox cmbOperatore;
        private Label label3;
        private Button btnCalcola;
        private Label lblRisultato;
    }
}
