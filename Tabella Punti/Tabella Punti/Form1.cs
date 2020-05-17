using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabella_Punti
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("192.168.136.129:6379,password=Password123");
            List<string> stati = new List<string>();
            muxer.GetServer(muxer.GetEndPoints()[0]).Keys(pattern: "classifiche:*").ToList().ForEach(x => stati.Add(x.ToString().Remove(0, 12)));
            stati.ForEach(x => lista.Items.Add(x));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Classifica_Utenti().Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(lista.SelectedItem != null)
            {
                string state = lista.SelectedItem.ToString();
                new Pagina_utente(state).Show();
            }           
        }
    }
}
