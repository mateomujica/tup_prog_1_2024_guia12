namespace Ejercciio1
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
            btnSolicitar = new Button();
            label1 = new Label();
            lbMostrarValor = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(122, 26);
            btnSolicitar.Margin = new Padding(4);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(190, 32);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 1;
            label1.Text = "Resultado";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(122, 103);
            lbMostrarValor.Margin = new Padding(4, 0, 4, 0);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(298, 84);
            lbMostrarValor.TabIndex = 2;
            lbMostrarValor.Click += lbMostrarValor_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(351, 29);
            txtValor.Margin = new Padding(4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(127, 29);
            txtValor.TabIndex = 3;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 276);
            Controls.Add(txtValor);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label lbMostrarValor;
        private TextBox txtValor;
    }
}
