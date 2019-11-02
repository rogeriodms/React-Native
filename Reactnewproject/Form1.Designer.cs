namespace Reactnewproject
{
    partial class name
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(name));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criar = new System.Windows.Forms.Button();
            this.cmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "name";
            this.textBox1.AccessibleName = "name ";
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(21, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "textname";
            this.label1.AccessibleName = "textname";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome do seu novo App";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "textname";
            this.label2.AccessibleName = "textname";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo App";
            // 
            // criar
            // 
            this.criar.AccessibleDescription = "criar";
            this.criar.AccessibleName = "criar";
            this.criar.Location = new System.Drawing.Point(21, 82);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(75, 23);
            this.criar.TabIndex = 3;
            this.criar.Text = "Criar";
            this.criar.UseVisualStyleBackColor = true;
            this.criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // cmd
            // 
            this.cmd.AccessibleDescription = "cmd";
            this.cmd.AccessibleName = "cmd";
            this.cmd.BackColor = System.Drawing.Color.Lavender;
            this.cmd.Location = new System.Drawing.Point(233, 22);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(107, 31);
            this.cmd.TabIndex = 4;
            this.cmd.Text = "Abrir cmd";
            this.cmd.UseVisualStyleBackColor = false;
            this.cmd.Click += new System.EventHandler(this.Cmd_Click);
            // 
            // name
            // 
            this.AccessibleDescription = "textname";
            this.AccessibleName = "textonome";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.criar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "name";
            this.Text = "React Native";
            this.Load += new System.EventHandler(this.Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button cmd;
        public System.Windows.Forms.TextBox textBox1;
    }
}

