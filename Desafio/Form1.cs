using Desafio.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Collections;
 

namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtToken.Text))
                {
                    MessageBox.Show("Informe o token");
                }
                else
                {
                    var json = ObterJson(txtToken.Text);

                    if (json != null)
                    {

                        txtNumeroCasas.Text = json.numero_casas.ToString();
                        txtCifrado.Text = json.cifrado;
                        txtDecifrado.Text = json.decifrado;
                        txtResumo.Text = json.resumo_criptografico;

                        txtToken.ReadOnly = true;
                    }
                }
           
             }catch(Exception err)
            {
                MessageBox.Show("Não foi possível obter arquivo com o token informado");
            }

}

        private Json ObterJson(string token)
        {

            string url = string.Format("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token={0}", token);
            WebRequest request = WebRequest.Create(url);

            request.Credentials = CredentialCache.DefaultCredentials;

            Desafio.Classes.Json json = new Classes.Json();

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                var retorno = reader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();

                json = js.Deserialize<Json>(retorno);
            }


            return json;

        }

   
        private void btnDecifrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCifrado.Text))
            {
                MessageBox.Show("Informe o texto cifrado");
            }
            else
            {
                txtDecifrado.Text = Descifrar(txtCifrado.Text, int.Parse(txtNumeroCasas.Text));
            }
        }

        private string Descifrar(string texto, int salt)
        {

            int letra;
            string decript = string.Empty;
            for (int i = 0; i < texto.Length; i++)
            {
                var number = texto[i];
                letra = Convert.ToInt32(texto[i]) - salt;

                //se passar do 'z' volta ao inicio do alfabeto

                if (letra > 122) { letra = letra - 26; }

                if (letra < 97) { letra = letra + 26; }

                decript = Char.IsNumber(number) || Char.IsWhiteSpace(number) || number == '.' ? decript += number : decript += Convert.ToChar(letra);

            }

            return decript;
        }

        private string Cifrar(string texto, int salt)
        {

            int letra;
            string decript = string.Empty;
            for (int i = 0; i < texto.Length; i++)
            {
                var number = texto[i];
                letra = Convert.ToInt32(texto[i]) + salt;

                //se passar do 'z' volta ao inicio do alfabeto

                if (letra > 122) { letra = letra - 26; }

                if (letra < 97) { letra = letra + 26; }

                decript = Char.IsNumber(number) || Char.IsWhiteSpace(number) || number == '.' ? decript += number : decript += Convert.ToChar(letra);

            }

            return decript;
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDecifrado.Text))
            {
                MessageBox.Show("Informe o texto descifrado");
            }
            else
            {
               MessageBox.Show(Cifrar(txtDecifrado.Text, int.Parse(txtNumeroCasas.Text)));
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDecifrado.Text))
            {
                MessageBox.Show("Informe o texto descifrado");
            }
            else
            {
                txtResumo.Text = HashSHA1(txtDecifrado.Text);
            }
        }


        public static string HashSHA1(string value)
        {
            var shaSHA1 = System.Security.Cryptography.SHA1.Create();
            var inputEncodingBytes = Encoding.ASCII.GetBytes(value);
            var hashString = shaSHA1.ComputeHash(inputEncodingBytes);

            var stringBuilder = new StringBuilder();
            for (var x = 0; x < hashString.Length; x++)
            {
                stringBuilder.Append(hashString[x].ToString("x2"));
            }
            return stringBuilder.ToString();

        }

        /// <summary>
        /// depreciado (Usa form-data file)
        /// </summary>
        /// <param name="json"></param>
        /// <param name="token"></param>
        public void EnviarJson(Json json, string token)
        {

            string url = string.Format("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token={0}", token);

            WebRequest request = WebRequest.Create(url);

            request.Method = "POST";


            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(json);

 
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);


            request.ContentType = "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW";

            request.ContentLength = byteArray.Length;

 
            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();


            WebResponse response = request.GetResponse();

            var statusDescription = ((HttpWebResponse)response).StatusCode;


            using (dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                var retorno = reader.ReadToEnd();
 
            }

        }

        private void btnGerarJson_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtCifrado.Text) || string.IsNullOrWhiteSpace(txtDecifrado.Text) || string.IsNullOrWhiteSpace(txtResumo.Text))
                {
                    MessageBox.Show("Campos obrigatórios em branco");
                }
                else
                {

                    Json json = new Json();
                    json.numero_casas = int.Parse(txtNumeroCasas.Text);
                    json.token = txtToken.Text;
                    json.cifrado = txtCifrado.Text;
                    json.decifrado = txtDecifrado.Text;
                    json.resumo_criptografico = txtResumo.Text;

                    GerarJson(json);

                    MessageBox.Show("Arquivo .json gerado com sucesso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gerar arquivo .json");
            }
        }

        private void GerarJson(Json json)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(json);
            System.IO.File.WriteAllText(@"C:\Users\izaias.costa\source\repos\Desafio\Desafio\bin\answer.json", jsonData);
        }

       
    }
}
