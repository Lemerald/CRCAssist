using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCAssist
{
    public partial class CRCAssist : Form
    {

        //Vars with getters and setters
        private int gps;

        private int loops;

        private float beatDelay;

        private bool startInstantly;

        private bool transition;

        public String debug = "debug";

        public CRCAssist()
        {
            InitializeComponent();
            Setgps(54);
            Setloops(0);
            SetbeatDelay(2.0f);
            SetstartInstantly(false);
            Settransition(false);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String output = Getgps() + "; " + GetbeatDelay() +"; " + GetstartInstantly() + "; " + Gettransition() + "; " + Getloops();
            lblOutput.Text = output;
            playSounds();
        }

        public void playSound(string file)
        {
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(file));
            BlockAlignReductionStream stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            DirectSoundOut output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            Sleep(((int)new AudioFileReader(file).TotalTime.TotalMilliseconds)-6);
        }

        public Queue<String> makePlaylist(string[] soundFiles)
        {
            //Easier access to each file
            string crcP = soundFiles[0];
            string oneGpEasyP = soundFiles[1];
            string oneGpExactP = soundFiles[2];
            string oneGpFastP = soundFiles[3];
            string smashP = soundFiles[4];
            string transitionP = soundFiles[5];
            string warmupEasyP = soundFiles[6];
            string warmupExactP = soundFiles[7];
            string warmupFastP = soundFiles[8];

            //Create a playlist
            Queue<String> playlist = new Queue<string>();
            //Select the correct gp beat speed
            string oneGpP = oneGpEasyP;
            string warmupP = warmupEasyP;
            if (GetbeatDelay() == 1.8f) { oneGpP = oneGpExactP; warmupP = warmupExactP; }
            else if (GetbeatDelay() == 1.9f) { oneGpP = oneGpFastP; warmupP = warmupFastP; }
            //Fill playlist
            //Only play the warmup if the checkbox isn't checked
            if (!GetstartInstantly()) { playlist.Enqueue(warmupP); }
            //Add the GP beat the requested amount of times
            for (int i = Gettransition() ? 1 : 0; i < Getgps(); i++) { playlist.Enqueue(oneGpP); }
            //Only necessary if the beat should transition into a CRC beat
            if (Gettransition())
            {
                //Add the transition sound
                playlist.Enqueue(transitionP);
                //Add the amount of CRC loops
                for (int i = 0; i < Getloops(); i++) { playlist.Enqueue(crcP); }
                //Add a final snare sound;
                playlist.Enqueue(smashP);
            }

            return playlist;
        }

        public void playSounds()
        {
            //Store files into soundFiles and sort them by name
            string exePath = System.AppDomain.CurrentDomain.BaseDirectory;
            string soundPath = Path.GetFullPath(Path.Combine(exePath, @"..\..\..\..\..\soundFiles"));
            string[] soundFiles = Directory.GetFiles(soundPath);
            soundFiles.OrderBy(f => f);
            Queue<String> playlist = makePlaylist(soundFiles);
            while(playlist.Count > 0)
            {
                playSound(playlist.First());
                playlist.Dequeue();
            }
            
        }

        //Accurate sleep method
        public void Sleep(double milliseconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds < milliseconds)
            {
                int timeout = (int)(milliseconds - stopwatch.ElapsedMilliseconds);
                Thread.Sleep(timeout >= 0 ? timeout : 0);
            }

            stopwatch.Stop();
        }

        //Events
        private void nudGp_ValueChanged(object sender, EventArgs e)
        {
            Setgps((int)nudGp.Value);
        }

        private void rbExact_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExact.Checked) SetbeatDelay(1.8f);
        }

        private void rbFast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFast.Checked) SetbeatDelay(1.9f);
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked) SetbeatDelay(2.0f);
        }

        private void cbInstant_CheckedChanged(object sender, EventArgs e)
        {
            SetstartInstantly(cbInstant.Checked);
        }

        private void cbTransition_CheckedChanged(object sender, EventArgs e)
        {
            Settransition(cbTransition.Checked);
        }

        private void nudLoops_ValueChanged(object sender, EventArgs e)
        {
            Setloops(Gettransition() ? (int)nudLoops.Value : 0);
        }




        //Getter and Setter
        public int Getgps()
        {
            return gps;
        }

        public void Setgps(int value)
        {
            gps = value;
        }

        private int Getloops()
        {
            return loops;
        }

        private void Setloops(int value)
        {
            loops = value;
        }

        private float GetbeatDelay()
        {
            return beatDelay;
        }

        private void SetbeatDelay(float value)
        {
            beatDelay = value;
        }

        private bool GetstartInstantly()
        {
            return startInstantly;
        }

        private void SetstartInstantly(bool value)
        {
            startInstantly = value;
        }

        private bool Gettransition()
        {
            return transition;
        }

        private void Settransition(bool value)
        {
            transition = value;
        }
    }
}
