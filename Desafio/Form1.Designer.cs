namespace Desafio
{
    partial class Form1
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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDecifrado = new System.Windows.Forms.TextBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.txtNumeroCasas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.btnDecifrar = new System.Windows.Forms.Button();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnGerarJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(84, 17);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(339, 20);
            this.txtToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Obter Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDecifrado
            // 
            this.txtDecifrado.Location = new System.Drawing.Point(132, 229);
            this.txtDecifrado.Multiline = true;
            this.txtDecifrado.Name = "txtDecifrado";
            this.txtDecifrado.Size = new System.Drawing.Size(618, 52);
            this.txtDecifrado.TabIndex = 3;
            // 
            // txtCifrado
            // 
            this.txtCifrado.Location = new System.Drawing.Point(132, 164);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(618, 52);
            this.txtCifrado.TabIndex = 4;
            // 
            // txtNumeroCasas
            // 
            this.txtNumeroCasas.Location = new System.Drawing.Point(132, 116);
            this.txtNumeroCasas.Name = "txtNumeroCasas";
            this.txtNumeroCasas.ReadOnly = true;
            this.txtNumeroCasas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCasas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de casas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cifrado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decifrado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resumo:";
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(132, 299);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(331, 20);
            this.txtResumo.TabIndex = 10;
            // 
            // btnDecifrar
            // 
            this.btnDecifrar.Location = new System.Drawing.Point(132, 366);
            this.btnDecifrar.Name = "btnDecifrar";
            this.btnDecifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDecifrar.TabIndex = 11;
            this.btnDecifrar.Text = "Decifrar";
            this.btnDecifrar.UseMnemonic = false;
            this.btnDecifrar.UseVisualStyleBackColor = true;
            this.btnDecifrar.Click += new System.EventHandler(this.btnDecifrar_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(388, 366);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 12;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Visible = false;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(213, 366);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 13;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnGerarJson
            // 
            this.btnGerarJson.Location = new System.Drawing.Point(294, 366);
            this.btnGerarJson.Name = "btnGerarJson";
            this.btnGerarJson.Size = new System.Drawing.Size(75, 23);
            this.btnGerarJson.TabIndex = 15;
            this.btnGerarJson.Text = "Gerar Json";
            this.btnGerarJson.UseVisualStyleBackColor = true;
            this.btnGerarJson.Click += new System.EventHandler(this.btnGerarJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnGerarJson);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.btnDecifrar);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCasas);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.txtDecifrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDecifrado;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.TextBox txtNumeroCasas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Button btnDecifrar;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnGerarJson;
    }
}

