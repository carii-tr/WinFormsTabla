namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            labelNombre = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(192, 192, 255);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(3, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(785, 426);
            panelPrincipal.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(256, 67);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(284, 20);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Vanessa Carolina Torres Rojas   Id: 300058";
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.BackColor = Color.LavenderBlush;
            richTextBoxResultados.Font = new Font("MS PGothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxResultados.Location = new Point(425, 120);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(224, 273);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.LavenderBlush;
            buttonVer.Location = new Point(168, 270);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(94, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.LavenderBlush;
            textBoxNum.Location = new Point(145, 203);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(133, 27);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("MS PGothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.Location = new Point(92, 143);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(249, 28);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(192, 192, 255);
            labelTitulo.Font = new Font("MS PGothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(233, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(340, 40);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Label labelNumero;
        private Button buttonVer;
        private TextBox textBoxNum;
        private RichTextBox richTextBoxResultados;
        private Label labelNombre;
    }
}
