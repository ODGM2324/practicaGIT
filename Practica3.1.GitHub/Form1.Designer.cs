namespace Practica3._1.GitHub
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
            txtTelegrama = new TextBox();
            cbUrgente = new CheckBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(25, 53);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(374, 100);
            txtTelegrama.TabIndex = 1;
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(25, 183);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(73, 19);
            cbUrgente.TabIndex = 2;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 260);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(69, 257);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(132, 23);
            txtPrecio.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(272, 231);
            button1.Name = "button1";
            button1.Size = new Size(127, 49);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 309);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(cbUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelegrama;
        private CheckBox cbUrgente;
        private Label label2;
        private TextBox txtPrecio;
        private Button button1;
    }
}