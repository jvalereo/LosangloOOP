
namespace DiagonalOOP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMaior = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.textBoxDiagoMaior = new System.Windows.Forms.TextBox();
            this.textBoxDiagoMenor = new System.Windows.Forms.TextBox();
            this.BtnClique = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(87, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule Area do Losanglo";
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaior.Location = new System.Drawing.Point(22, 140);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(120, 21);
            this.lblMaior.TabIndex = 1;
            this.lblMaior.Text = "Diagonal maior:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenor.Location = new System.Drawing.Point(22, 223);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(125, 21);
            this.lblMenor.TabIndex = 2;
            this.lblMenor.Text = "Diagonal menor:";
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagem.Image")));
            this.pictureBoxImagem.Location = new System.Drawing.Point(221, 118);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(137, 200);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagem.TabIndex = 3;
            this.pictureBoxImagem.TabStop = false;
            // 
            // textBoxDiagoMaior
            // 
            this.textBoxDiagoMaior.Location = new System.Drawing.Point(22, 173);
            this.textBoxDiagoMaior.Name = "textBoxDiagoMaior";
            this.textBoxDiagoMaior.Size = new System.Drawing.Size(148, 23);
            this.textBoxDiagoMaior.TabIndex = 4;
            // 
            // textBoxDiagoMenor
            // 
            this.textBoxDiagoMenor.Location = new System.Drawing.Point(22, 257);
            this.textBoxDiagoMenor.Name = "textBoxDiagoMenor";
            this.textBoxDiagoMenor.Size = new System.Drawing.Size(148, 23);
            this.textBoxDiagoMenor.TabIndex = 5;
            // 
            // BtnClique
            // 
            this.BtnClique.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClique.Location = new System.Drawing.Point(37, 376);
            this.BtnClique.Name = "BtnClique";
            this.BtnClique.Size = new System.Drawing.Size(98, 30);
            this.BtnClique.TabIndex = 6;
            this.BtnClique.Text = "Clique ";
            this.BtnClique.UseVisualStyleBackColor = true;
            this.BtnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(148, 376);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 30);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFechar.Location = new System.Drawing.Point(260, 376);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(98, 30);
            this.BtnFechar.TabIndex = 8;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnClique);
            this.Controls.Add(this.textBoxDiagoMenor);
            this.Controls.Add(this.textBoxDiagoMaior);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Losanglo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.TextBox textBoxDiagoMaior;
        private System.Windows.Forms.TextBox textBoxDiagoMenor;
        private System.Windows.Forms.Button BtnClique;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFechar;
    }
}