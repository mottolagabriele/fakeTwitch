using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using StackExchange.Redis;

namespace Tabella_Punti
{
    public partial class Classifica_Utenti : MetroFramework.Forms.MetroForm
    {
        private System.Timers.Timer aTimer;
        string key = "";
        ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("192.168.136.129:6379,password=Password123");
        public Classifica_Utenti()
        {
            InitializeComponent();
        }

        private void Classifica_Utenti_Load(object sender, EventArgs e)
        {
            List<string> stati = new List<string>();
            muxer.GetServer(muxer.GetEndPoints()[0]).Keys(pattern: "classifiche:*").ToList().ForEach(x => stati.Add(x.ToString().Remove(0, 12)));
            stati.ForEach(x => stato.Items.Add(x));
            key = "classifiche:" + stati[0];
            stato.SelectedIndex = 0;
            DownloadAndView();
            SetTimer();
        }

        private void DownloadAndView()
        {
            // ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("192.168.136.129:6379,password=Password123");            
            this.Invoke(new Action(() =>
            {
            IDatabase conn = muxer.GetDatabase();
            RedisKey classifica = new RedisKey(key);
            List<SortedSetEntry> risultati = conn.SortedSetRangeByScoreWithScores(key: classifica, order: Order.Descending).ToList();
            tabella.RowCount = risultati.Count;
            tabella.ColumnCount = 3;

            tabella.Columns[0].HeaderText = "Posizione";
            tabella.Columns[1].HeaderText = "Nome";
            tabella.Columns[2].HeaderText = "Punteggio";

            for (int i = 0; i < tabella.RowCount; i++)
            {
                tabella[0, i].Value = i + 1;
                tabella[1, i].Value = risultati[i].Element;
                tabella[2, i].Value = risultati[i].Score;
            }
            }));
        }

         void SetTimer()
         {            
            aTimer = new System.Timers.Timer(2000); 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
         }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DownloadAndView();
        }

        private void Classifica_Utenti_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
            aTimer.Dispose();
        }

        private void stato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aTimer != null)
            {
                aTimer.Stop();
                key = "classifiche:" + stato.SelectedItem;
                DownloadAndView();
                aTimer.Start();
            }
        }
    }
}
