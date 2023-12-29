using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encryptador
{
    class EncryptarPassword
    {
        public string Encrypt ( string mensaje)
        {
            string clave = "MercadoDeImportaciones";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);


        }

        public string Decrypt (string mensajeEn)
        {
            string clave = "MercadoDeImportaciones";
            byte[] data = Convert.FromBase64String(mensajeEn);

            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();

            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            tripldes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);

        }
    }
}
