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
        private int gps { get; set; }

        private int loops { get; set; }

        private int soundDelay { get; set; }

        private float beatDelay { get; set; }

        private bool startInstantly { get; set; }

        private bool transition { get; set; }

        private bool secs { get; set; }

        public CRCAssist()
        {
            InitializeComponent();
            gps = 54;
            loops = 0;
            soundDelay = -16;
            beatDelay = 2.0f;
            startInstantly = false;
            transition = false;
        }

        //Important events
        //Beatmaker events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            playGPbeat();
        }

        private void btnCRC_Click(object sender, EventArgs e)
        {
            playCRCbeat();
        }

        //Settings events
        private void pbSettings_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.pnlBeatmaker);
            this.Controls.Remove(this.pnlMore);
            this.Controls.Add(this.pnlSettings);
        }

        private void btnStOK_Click(object sender, EventArgs e)
        {
            soundDelay = (int)nudSoundDelay.Value;
            this.Controls.Remove(this.pnlSettings);
            this.Controls.Add(this.pnlBeatmaker);
        }

        private void btnStApply_Click(object sender, EventArgs e)
        {
            soundDelay = (int)nudSoundDelay.Value;
        }

        private void btnStCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.pnlSettings);
            this.Controls.Add(this.pnlBeatmaker);
        }

        //"More" events
        private void pbMore_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.pnlBeatmaker);
            this.Controls.Remove(this.pnlSettings);
            this.Controls.Add(this.pnlMore);

        }
        private void nudMSecs_ValueChanged(object sender, EventArgs e)
        {
            if (secs) { nudMGPs.Value = secondsToGPs((int)nudMSecs.Value); }
        }
        private void nudMSecs_Enter(object sender, EventArgs e)
        {
            secs = true;
        }
        private void nudMSecs_Leave(object sender, EventArgs e)
        {
            if (secs) { nudMGPs.Value = secondsToGPs((int)nudMSecs.Value); }
        }

        private void nudMGPs_ValueChanged(object sender, EventArgs e)
        {
            if (!secs) { nudMSecs.Value = gpsToSeconds((int)nudMGPs.Value); }
        }
        private void nudMGPs_Enter(object sender, EventArgs e)
        {
            secs = false;
        }
        private void nudMGPs_Leave(object sender, EventArgs e)
        {
            if (!secs) { nudMSecs.Value = gpsToSeconds((int)nudMGPs.Value); }
        }

        private void btnMBack_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.pnlMore);
            this.Controls.Add(this.pnlBeatmaker);
        }

        //Beatmaking methods
        public void playGPbeat()
        {
            //Store files into soundFiles and sort them by name
            string exePath = System.AppDomain.CurrentDomain.BaseDirectory;
            string soundPath = Path.GetFullPath(Path.Combine(exePath, @".\Soundfiles"));
            string[] soundFiles = Directory.GetFiles(soundPath);
            soundFiles.OrderBy(f => f);
            Queue<String> playlist = makeGPplaylist(soundFiles);
            while (playlist.Count > 0)
            {
                playSound(playlist.First());
                playlist.Dequeue();
            }

        }

        public void playCRCbeat()
        {
            //Store files into soundFiles and sort them by name
            string exePath = System.AppDomain.CurrentDomain.BaseDirectory;
            string soundPath = Path.GetFullPath(Path.Combine(exePath, @".\Soundfiles"));
            string[] soundFiles = Directory.GetFiles(soundPath);
            soundFiles.OrderBy(f => f);
            Queue<String> playlist = makeCRCplaylist(soundFiles);
            while (playlist.Count > 0)
            {
                playSound(playlist.First());
                playlist.Dequeue();
            }
        }

        public Queue<String> makeGPplaylist(string[] soundFiles)
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
            if (beatDelay == 1.8f) { oneGpP = oneGpExactP; warmupP = warmupExactP; }
            else if (beatDelay == 1.9f) { oneGpP = oneGpFastP; warmupP = warmupFastP; }
            //Fill playlist
            //Only play the warmup if the checkbox isn't checked
            if (!startInstantly) { playlist.Enqueue(warmupP); }
            //Add the GP beat the requested amount of times
            //For-loop starts at 1 because if it transitions into a CRC beat there will be an additional snare hit
            //And if it won't transition there will nevertheless be another snare hit at the end
            for (int i =1; i < gps; i++) { playlist.Enqueue(oneGpP); }
            //Only necessary if the beat should transition into a CRC beat
            if (transition)
            {
                //Add the transition sound
                playlist.Enqueue(transitionP);
                //Add the amount of CRC loops
                for (int i = 0; i < loops; i++) { playlist.Enqueue(crcP); }
                //Add a final snare sound;
            }
            playlist.Enqueue(smashP);

            return playlist;
        }

        public Queue<String> makeCRCplaylist(string[] soundFiles)
        {
            //Easier access to each file
            string crcP = soundFiles[0];
            string smashP = soundFiles[4];
            string transitionP = soundFiles[5];

            //Create a playlist
            Queue<String> playlist = new Queue<string>();
            //Select the correct gp beat speed
            //Fill playlist
            //Add the transition sound
            playlist.Enqueue(transitionP);
            //Add the amount of CRC loops
            for (int i = 0; i < loops; i++) { playlist.Enqueue(crcP); }
            //Add a final snare sound;
            playlist.Enqueue(smashP);

            return playlist;
        }

        public void playSound(string file)
        {
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(file));
            BlockAlignReductionStream stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            DirectSoundOut output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            Thread.Sleep(((int)new AudioFileReader(file).TotalTime.TotalMilliseconds)+soundDelay);
        }

        //Conversion methods
        public int gpsToSeconds(int gps)
        {
            return (int)Math.Round(gps * 1.8);
        }

        public int secondsToGPs(int seconds)
        {
            return (int)Math.Ceiling(seconds / 1.8);
        }
        private void btnMApply_Click(object sender, EventArgs e)
        {
            if(nudMGPs.Value > 0) { nudGp.Value = nudMGPs.Value; }
            this.Controls.Remove(this.pnlMore);
            this.Controls.Add(this.pnlBeatmaker);
        }

        //More accurate sleep method (maybe)
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


        //General events
        private void nudGp_ValueChanged(object sender, EventArgs e)
        {
            gps = (int)nudGp.Value;
        }

        private void rbExact_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExact.Checked) beatDelay = 1.8f;
        }

        private void rbFast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFast.Checked) beatDelay = 1.9f;
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked) beatDelay = 2.0f;
        }

        private void cbInstant_CheckedChanged(object sender, EventArgs e)
        {
            startInstantly = cbInstant.Checked;
        }

        private void cbTransition_CheckedChanged(object sender, EventArgs e)
        {
            transition = cbTransition.Checked;
            if (cbTransition.Checked) { nudLoops.Enabled = true; lblLoops.ForeColor = Color.Black; }
            else { nudLoops.Enabled = false; lblLoops.ForeColor = Color.Gray; }
        }

        private void nudLoops_ValueChanged(object sender, EventArgs e)
        {
            loops = (int)nudLoops.Value;
        }

    }
}
