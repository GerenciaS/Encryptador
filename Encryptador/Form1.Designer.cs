
namespace Encryptador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordEnd = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPassWordEnc = new System.Windows.Forms.TextBox();
            this.btnEncryptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesencryptar = new System.Windows.Forms.Button();
            this.txtPassWordDes = new System.Windows.Forms.TextBox();
            this.txtEncryptado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(54, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 22);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "PassWord:";
            // 
            // lblPasswordEnd
            // 
            this.lblPasswordEnd.AutoSize = true;
            this.lblPasswordEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPasswordEnd.Location = new System.Drawing.Point(54, 107);
            this.lblPasswordEnd.Name = "lblPasswordEnd";
            this.lblPasswordEnd.Size = new System.Drawing.Size(206, 22);
            this.lblPasswordEnd.TabIndex = 1;
            this.lblPasswordEnd.Text = "PassWord Encryptado:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(179, 59);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(136, 25);
            this.txtPassWord.TabIndex = 2;
            // 
            // txtPassWordEnc
            // 
            this.txtPassWordEnc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordEnc.Location = new System.Drawing.Point(58, 144);
            this.txtPassWordEnc.Name = "txtPassWordEnc";
            this.txtPassWordEnc.Size = new System.Drawing.Size(216, 25);
            this.txtPassWordEnc.TabIndex = 3;
            // 
            // btnEncryptar
            // 
            this.btnEncryptar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEncryptar.Location = new System.Drawing.Point(58, 276);
            this.btnEncryptar.Name = "btnEncryptar";
            this.btnEncryptar.Size = new System.Drawing.Size(101, 61);
            this.btnEncryptar.TabIndex = 4;
            this.btnEncryptar.Text = "Encryptar";
            this.btnEncryptar.UseVisualStyleBackColor = true;
            this.btnEncryptar.Click += new System.EventHandler(this.btnEncryptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSalir.Location = new System.Drawing.Point(992, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 59);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(466, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "PassWord Encryptado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(466, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "PassWord Desencryptado:";
            // 
            // btnDesencryptar
            // 
            this.btnDesencryptar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnDesencryptar.Location = new System.Drawing.Point(470, 276);
            this.btnDesencryptar.Name = "btnDesencryptar";
            this.btnDesencryptar.Size = new System.Drawing.Size(134, 61);
            this.btnDesencryptar.TabIndex = 8;
            this.btnDesencryptar.Text = "Desencryptar";
            this.btnDesencryptar.UseVisualStyleBackColor = true;
            this.btnDesencryptar.Click += new System.EventHandler(this.btnDesencryptar_Click);
            // 
            // txtPassWordDes
            // 
            this.txtPassWordDes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWordDes.Location = new System.Drawing.Point(711, 118);
            this.txtPassWordDes.Name = "txtPassWordDes";
            this.txtPassWordDes.Size = new System.Drawing.Size(216, 25);
            this.txtPassWordDes.TabIndex = 9;
            // 
            // txtEncryptado
            // 
            this.txtEncryptado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptado.Location = new System.Drawing.Point(711, 59);
            this.txtEncryptado.Name = "txtEncryptado";
            this.txtEncryptado.Size = new System.Drawing.Size(216, 25);
            this.txtEncryptado.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(58, 405);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 63);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 527);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtEncryptado);
            this.Controls.Add(this.txtPassWordDes);
            this.Controls.Add(this.btnDesencryptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEncryptar);
            this.Controls.Add(this.txtPassWordEnc);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblPasswordEnd);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.Text = "Encryptador de Claves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordEnd;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtPassWordEnc;
        private System.Windows.Forms.Button btnEncryptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesencryptar;
        private System.Windows.Forms.TextBox txtPassWordDes;
        private System.Windows.Forms.TextBox txtEncryptado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

