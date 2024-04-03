using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace bassein
{
    public partial class Bassein : Form
    {
        int heightOfBassein = 0;
        int speed = 1;
        int time = 200;
        bool crane = false;

        public static bool messageMax = false;
        public static bool messageMin = false;
        int max = (int)(2000 * 0.75);
        int min = (int)(2000 * 0.25);

        Publisher pub = new Publisher();

        public class SampleEventArgs
        {
            public SampleEventArgs() { }
            //public bool Value { get; } // readonly
        }

        public class Publisher
        {
            public delegate void SampleEventHandler(object sender, SampleEventArgs e);

            public event SampleEventHandler SampleEvent1;
            public event SampleEventHandler SampleEvent2;

            public virtual void RaiseSampleEvent1()
            {
                SampleEvent1?.Invoke(this, new SampleEventArgs());
            }
            public virtual void RaiseSampleEvent2()
            {
                SampleEvent2?.Invoke(this, new SampleEventArgs());
            }
        }

        public Bassein()
        {
            InitializeComponent();
            buttonCrane.BackColor = Color.White;

            Pump.time = time;
            foreach (Pump pump in Controls.OfType<Pump>())
            {
                pump.BasseinEvent += UpdateBassein;
                pump.Subscribe(pub);
            }
        }

        private void UpdateBassein(int height)
        {
            // heightOfBassein больше height, погрешность работы потоков, какой-то поток запаздывает
            heightOfBassein = height;

            if (!workerCrane.IsBusy)
            {
                //Pump.HeightOfBassein = heightOfBassein;
                Action action = () =>
                {
                    HeightBasseinChange();
                };
                Invoke(action);

                Thread.Sleep(time);
            }
        }

        private void buttonCrane_Click(object sender, EventArgs e)
        {
            if (crane)
            { // когда нажимаем с включенным краном                
                if (workerCrane.IsBusy)
                {
                    workerCrane.CancelAsync();
                    buttonCrane.BackColor = Color.White;
                }
            }
            else
            { // когда нажимаем с выключенным краном
                if (!workerCrane.IsBusy)
                {
                    workerCrane.RunWorkerAsync();
                    buttonCrane.BackColor = Color.FromArgb(52, 186, 235);
                }
            }

            crane = !crane;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // при "ручной" остановке крана
                if (workerCrane.CancellationPending)
                    break;

                if (heightOfBassein < max && heightOfBassein + speed >= max)
                    messageMax = true;

                heightOfBassein += speed;
                Pump.HeightOfBassein = heightOfBassein;
                    
                Action action = () =>
                {
                    HeightBasseinChange();
                };
                Invoke(action);

                if (messageMax)
                {
                    pub.RaiseSampleEvent1();
                    messageMax = false;
                    buttonCrane.BackColor = Color.White;
                }

                if (messageMin)
                {
                    pub.RaiseSampleEvent2();
                    messageMin = false;
                }

                Thread.Sleep(time);
            }
        }

        private void HeightBasseinChange()
        {
            if (heightOfBassein >= verticalProgressBarBassein.Maximum)
            {
                heightOfBassein = verticalProgressBarBassein.Maximum;
                verticalProgressBarBassein.Value = heightOfBassein;
            }
            else if (heightOfBassein <= verticalProgressBarBassein.Minimum)
            {
                heightOfBassein = 0;
                verticalProgressBarBassein.Value = heightOfBassein;
            }
            else
            {
                verticalProgressBarBassein.Value = heightOfBassein + 1; // для нормальной работы progress bar при остановке крана
                verticalProgressBarBassein.Value = heightOfBassein;
            }

            ShowState();
        }

        private void ShowState()
        {
            labelVolumeWater.Text = $"{heightOfBassein}/2000 литров = {heightOfBassein / 20} %";
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            speed = (int)numericUpDownCranePower.Value;
        }
    }
}
