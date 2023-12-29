using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Encryp(string mensaje)
        {

            try
            {

                EncryptarPassword encr = new EncryptarPassword();


                string lpass = encr.Encrypt(mensaje);

                txtPassWordEnc.Text = lpass;



            }
            catch (Exception e)
            {


                MessageBox.Show(e.Message);
            }
        }

        public void Desencryp(string mensajeEnd)
        {
            EncryptarPassword encr = new EncryptarPassword();
            string lpass = encr.Decrypt(mensajeEnd);

            txtPassWordDes.Text = lpass;
        }
        public void Limpiar()
        {
            txtEncryptado.Text = "";
            txtPassWord.Text = "";
            txtPassWordDes.Text = "";
            txtPassWordEnc.Text = "";

        }
        private void btnEncryptar_Click(object sender, EventArgs e)
        {
            if (this.txtPassWord.Text == "")
            {
                MessageBox.Show("El Campo Contraseña no debe estar vacio.");
            }
            else
            {
                Encryp(this.txtPassWord.Text);
            }
        }

        private void btnDesencryptar_Click(object sender, EventArgs e)
        {
            if (this.txtEncryptado.Text =="")
            {
                MessageBox.Show("El Campo Contraseña Encryptada no debe esta vacio.");
            }
            else
            {
                Desencryp(this.txtEncryptado.Text);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
