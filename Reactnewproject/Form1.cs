using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reactnewproject
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            
            string nome = @"/C " + "cd c:/reactnative && react-native init "+ textBox1.Text;

            System.Diagnostics.Process.Start("cmd.exe", nome);

        }

        private void Cmd_Click(object sender, EventArgs e)
        {
            //Define uma instância da classe ProcessStartInfo
            ProcessStartInfo pro = new ProcessStartInfo();
            //Define a propriedade FileName a ser iniciada
            pro.FileName = "cmd.exe";
            //inicia o processo
            Process proStart = new Process();
            // Define o nome do processo
            proStart.StartInfo = pro;
            // chama o método Start para começar
            proStart.Start();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Load(object sender, EventArgs e)
        {

        }
    }
}
