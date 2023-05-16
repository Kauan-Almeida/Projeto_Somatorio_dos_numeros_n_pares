namespace Projeto_Somatório_dos_n_pares
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
            lblNum = new Label();
            txtNum = new TextBox();
            btnLimpar = new Button();
            btnCalcular = new Button();
            lblSoma = new Label();
            txtSoma = new TextBox();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(25, 21);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(56, 15);
            lblNum.TabIndex = 0;
            lblNum.Text = "Números";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(87, 21);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(25, 62);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(126, 62);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSoma
            // 
            lblSoma.AutoSize = true;
            lblSoma.Location = new Point(25, 112);
            lblSoma.Name = "lblSoma";
            lblSoma.Size = new Size(37, 15);
            lblSoma.TabIndex = 4;
            lblSoma.Text = "Soma";
            // 
            // txtSoma
            // 
            txtSoma.Location = new Point(87, 112);
            txtSoma.Name = "txtSoma";
            txtSoma.ReadOnly = true;
            txtSoma.Size = new Size(100, 23);
            txtSoma.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 247);
            Controls.Add(txtSoma);
            Controls.Add(lblSoma);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(txtNum);
            Controls.Add(lblNum);
            Name = "Form1";
            Text = "Soma Pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum;
        private TextBox txtNum;
        private Button btnLimpar;
        private Button btnCalcular;
        private Label lblSoma;
        private TextBox txtSoma;
    }
}