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
        Queen queen = new Queen();
        public Form1()
        {
            InitializeComponent();
            workers[0] = new Worker (new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker (new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker (new string[] { "Utrzymanie ula", "Patrol z żądłami" });
            workers[3] = new Worker (new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" });
            queen = new Queen();

        }

        private void AssignWork(jobList.Items, numericUpDown1.Value);
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}


