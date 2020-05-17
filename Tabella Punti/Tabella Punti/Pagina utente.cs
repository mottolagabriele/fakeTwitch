using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;
using StackExchange.Redis;

namespace Tabella_Punti
{
    public partial class Pagina_utente : MetroFramework.Forms.MetroForm
    {
        bool visione = false;
        string key = "";
        string usr = "";

        int contPunti = 0;

        System.Timers.Timer TimerVisione;
        System.Timers.Timer TimerBonus;

        ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("192.168.136.129:6379,password=Password123");

        public Pagina_utente(string state)
        {
            InitializeComponent();
            key = "classifiche:" + state;
        }

        private void Pagina_utente_Load(object sender, EventArgs e)
        {
            Image i = Image.FromFile(@"./live_off.png");
            pictureBox1.Image = i;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            punti.ReadOnly = true;
            ciaoLabel.Hide();
            puntiLabel.Hide();
            punti.Hide();
            nomeUtente.Hide();

            bonus.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Image i;
            if (!visione)
            {
                //live start
                action.Text = "PAUSE";
                i = Image.FromFile(@"./live_on.png");
                if (usr != "")
                {
                    setTimerBonus();
                    setTimerVisione();
                }
            }
            else
            {
                //live stop
                action.Text = "PLAY";
                i = Image.FromFile(@"./live_off.png");
                if (usr != "")
                {
                    TimerVisione.Stop();
                    TimerBonus.Stop();
                }
            }
            visione = !visione;
            pictureBox1.Image = i;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //610,450 senza login
            string inputName = username.Text;
            string inputPassword = password.Text;
            IDatabase conn = muxer.GetDatabase();
            List<HashEntry> risu = conn.HashGetAll("utenti:" + inputName).ToList();
            if(risu.Count > 0)
            {
                if(inputPassword == risu[0].Value)
                {
                    MessageBox.Show("Login avvenuto con successo");
                    usr = inputName;
                    this.Size = new Size(610, 450);
                    puntiLabel.Show();
                    punti.Show();
                    RedisKey classifica = new RedisKey(key);
                    RedisValue member = new RedisValue(usr);
                    double? ris = conn.SortedSetScore(classifica, member);
                    int punt;
                    if(ris == null)
                    {
                        punt = 0;
                    }
                    else
                    {
                        punt = (int)ris;
                    }
                    punti.Text = punt.ToString();
                    contPunti = punt;
                    if (visione)
                    {
                        setTimerBonus();
                        setTimerVisione();
                    }
                }
                else
                {
                    MessageBox.Show("Password sbagliata");
                }
            }
            else
            {
                MessageBox.Show("Utente non esistente");
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            //pulsante bonus schiacciato           
            addPoints(10);
            bonus.Hide();
            if (visione)
            {
                setTimerBonus(); //lo ricreo a tempo casuale
            }
        }

        void setTimerVisione()
        {
            TimerVisione = new System.Timers.Timer(3000);
            TimerVisione.Elapsed += eventoVisione;
            TimerVisione.AutoReset = true;
            TimerVisione.Enabled = true;
        }

        void eventoVisione(Object source, ElapsedEventArgs e)
        {
            addPoints(2);
        }
        
        void setTimerBonus()
        {            
            TimerBonus = new System.Timers.Timer(new Random().Next(5000,10000));
            TimerBonus.Elapsed += eventoBonus;
            TimerBonus.AutoReset = true;
            TimerBonus.Enabled = true;
        }

        void eventoBonus(Object source, ElapsedEventArgs e)
        {                        
            this.Invoke(new Action(() =>
            {
                bonus.Show();
            }));            
        }

        public void addPoints(double points)
        {
            IDatabase conn = muxer.GetDatabase();
            RedisKey classifica = new RedisKey(key);
            RedisValue member = new RedisValue(usr);
            conn.SortedSetIncrement(classifica, member, points);
            this.Invoke(new Action(() =>
            {
                contPunti += (int)points;
                punti.Text = (contPunti).ToString();
            })); 
        }

        private void Pagina_utente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TimerBonus != null)
            {
                TimerBonus.Stop();
                TimerBonus.Dispose();
            }
            if (TimerVisione != null)
            {
                TimerVisione.Stop();
                TimerVisione.Dispose();
            }
        }
    }
}
