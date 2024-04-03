using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using static bassein.Bassein;

namespace bassein
{
    public partial class Pump : UserControl
    {
        public delegate void BasseinHandler(int height);
        public event BasseinHandler BasseinEvent;
        
        public static int time;
        int speed = 20;
        bool pump = false;
        bool rozetka = false;

        public bool goToMin;

        static int heightOfBassein;
        public static int HeightOfBassein
        {
            set { heightOfBassein = value; }
            get
            {
                return heightOfBassein;
            }
        }

        public Pump()
        {
            InitializeComponent();
        }

        private void workerPump_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // при "ручной" остановке насоса
                if (workerPump.CancellationPending)
                    break;

                if (heightOfBassein > (2000 * 0.25) && heightOfBassein - speed <= (2000 * 0.25))
                    Bassein.messageMin = true;

                heightOfBassein -= speed;

                BasseinEvent?.Invoke(HeightOfBassein);

                Thread.Sleep(time);
            }
        }

        private void Pump_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Pump_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Pump_Click(object sender, EventArgs e)
        {
            if (!rozetka)
            {
                if (!pump)
                { // когда нажимаем с выключенным насосом
                    if (!workerPump.IsBusy)
                    {
                        workerPump.RunWorkerAsync();
                        BackColor = Color.FromArgb(52, 186, 235);
                    }
                }
                else
                { // когда нажимаем с включенным насосом
                    if (workerPump.IsBusy)
                    {
                        workerPump.CancelAsync();
                        BackColor = Color.White;
                    }
                }

                pump = !pump;
            }
        }

        public void Subscribe(Bassein.Publisher pub)
        {
            pub.SampleEvent1 += AllPumpOn;
            pub.SampleEvent2 += AllPumpOff;
        }

        private void AllPumpOn(object sender, SampleEventArgs e)
        {
            if (!rozetka)
            {
                pump = !pump;
                if (!workerPump.IsBusy)
                {
                    workerPump.RunWorkerAsync();
                    BackColor = Color.FromArgb(52, 186, 235);
                }
            }
        }

        private void AllPumpOff(object sender, SampleEventArgs e)
        {
            pump = !pump;
            if (workerPump.IsBusy)
            {
                workerPump.CancelAsync();
                BackColor = Color.White;
            }
        }

        private void buttonRozetka_Click(object sender, EventArgs e)
        {
            if (!rozetka)
            {
                BackColor = Color.White;
                workerPump.CancelAsync();
                buttonRozetka.BackColor = Color.Red;
            }
            else
            {
                buttonRozetka.BackColor = SystemColors.Control;
            }
            rozetka = !rozetka;
        }
    }
}
