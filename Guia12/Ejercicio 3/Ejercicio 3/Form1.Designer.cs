namespace Ejercicio_3
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
            label1 = new Label();
            label2 = new Label();
            btnSolicitar = new Button();
            lbCantidad = new Label();
            lsbListado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 56);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 56);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(63, 12);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(108, 23);
            btnSolicitar.TabIndex = 2;
            btnSolicitar.Text = "Solicitar Opcion";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(157, 56);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(0, 15);
            lbCantidad.TabIndex = 3;
            lbCantidad.Click += lbCantidad_Click;
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(36, 74);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(160, 79);
            lsbListado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 220);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(btnSolicitar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSolicitar;
        private Label lbCantidad;
        private ListBox lsbListado;
    }
}
