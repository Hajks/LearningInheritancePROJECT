using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInheritancePROJECT
{

    public partial class Form1 : Form
    {
        Worker[] workers = new Worker[4];
        Queen queen;

        public Form1()
        {
            InitializeComponent();
            jobList.SelectedIndex = 0;
            workers[0] = new Worker (new string[] { "Nauczanie pszczółek", "Pielęgnacja jaj" });
            workers[1] = new Worker (new string[] { "Utrzymalnie ula", "Wytwarzanie miodu" });
            workers[2] = new Worker (new string[] { "Zbieranie nektaru", "Patrol z żądłami" });
            workers[3] = new Worker (new string[] { "Nauczanie pszczółek", "Pielęgnacja jaj", "Utrzymanie ula", "Wytwarzanie miodu", "Zbieranie nektaru", "Patrol z żadłami" });
            queen = new Queen(workers);
            
        }


        private void button2_Click(object sender, EventArgs e) //asignwork
        {
            queen.AssignWork(jobList.Text, (int) numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e) //workshift
        {
            textBox1.Text = queen.WorkTheNextShift();
        }
    }
}


