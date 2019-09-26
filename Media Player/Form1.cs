using System;
using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class MediaPlayer : Form
    {
        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer Jarvis = new SpeechSynthesizer();
        bool shuffle = false, playing = false;
        string[] files, paths;
        int top, x, y;
        public MediaPlayer()
        {
            InitializeComponent();

            try
            {

                speechRecognitionEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(engine_AudioLevelUpdated);
                speechRecognitionEngine.SpeechRecognized += engine_SpeechRecognized;

                LoadGrammarAndCommands();

                speechRecognitionEngine.SetInputToDefaultAudioDevice();

                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                Jarvis.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(Jarvis_SpeakCompleted);

                if (Jarvis.State == SynthesizerState.Speaking)
                    Jarvis.SpeakAsyncCancelAll();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Voice Failed");
            }
        }

        private void engine_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {

        }

        private void Jarvis_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (Jarvis.State == SynthesizerState.Speaking)
                Jarvis.SpeakAsyncCancelAll();
        }

        private void LoadGrammarAndCommands()
        {
            try
            {
                Choices Text = new Choices();
                string[] Lines = File.ReadAllLines(Environment.CurrentDirectory + "\\Commands.txt");
                Text.Add(Lines);
                Grammar WordsList = new Grammar(new GrammarBuilder(Text));
                speechRecognitionEngine.LoadGrammar(WordsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = (e.Result.Text);
            switch (speech)
            {
                case "Browse":
                    Browse.PerformClick();
                    break;
                case "Next":
                    nextbutton.PerformClick();
                    break;
                case "Pre":
                    prebutton.PerformClick();
                    break;
                case "Resume":
                    mp.Ctlcontrols.play();
                    break;
                case "Stop":
                    stopbutton.PerformClick();
                    break;
                case "Sec":
                    pausebutton.PerformClick();
                    break;
                case "Down":
                    mp.settings.volume -= 10;
                    break;
                case "Up":
                    mp.settings.volume += 10;
                    break;
                case "Hide":
                    FormBorderStyle formborderstyle;

                    formborderstyle = FormBorderStyle.None;

                    WindowState = FormWindowState.Minimized;
                    break;
                    /*case"Exit":
                          this.Close();
                        break;
                        */


            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            string userName = System.Environment.UserName;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\Users\" + userName + "\\Documents\\MyMusic";
            ofd.Filter = "(mp3,wav,mp4,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    playList.Items.Add(files[i]);
                }
                playList.SelectedIndex = playList.SelectedIndex + 1;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle formborderstyle;

            formborderstyle = FormBorderStyle.None;

            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void playbutton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                mp.Ctlcontrols.play();
                playList_DoubleClick(sender, e);
                timer1.Start();
            }
            else
            {
                mp.Ctlcontrols.pause();
                timer1.Stop();
            }
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.pause();
            timer1.Stop();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.stop();


        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            // mp.Ctlcontrols.next();
            try
            {
                if (shuffle == true)
                {
                    int total = playList.Items.Count;
                    Random rnd = new Random();
                    int random = rnd.Next(1, total);
                    playList.SelectedIndex = random;
                }
                else
                {
                    ++playList.SelectedIndex;
                }
                playList_DoubleClick(sender, e);
                timer1.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void prebutton_Click(object sender, EventArgs e)
        {
            //mp.Ctlcontrols.previous();
            try
            {
                if (shuffle == true)
                {
                    int total = playList.Items.Count;
                    Random rnd = new Random();
                    int random = rnd.Next(1, total);
                    playList.SelectedIndex = random;
                }
                else
                {
                    --playList.SelectedIndex;
                }
                playList_DoubleClick(sender, e);
                timer1.Start();

            }
            catch (Exception ex)
            {

            }
        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {



        }

        private void plusbutton_Click(object sender, EventArgs e)
        {

            try
            {
                mp.settings.volume += 10;
            }
            catch (Exception ex)
            {

            }
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            try
            {
                mp.settings.volume -= 10;
            }
            catch (Exception ex)
            {

            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            top = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (top == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            top = 0;
        }

        private void mp_Enter(object sender, EventArgs e)
        {

        }

        private void playList_DoubleClick(object sender, EventArgs e)
        {
            mp.URL = paths[playList.SelectedIndex];
            timer1.Start();

        }

        private void Repeatsongchecbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Repeatsongchecbox.Checked == true)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int itemno;
                itemno = playList.SelectedIndex;
                if (mp.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    if (Repeatsongchecbox.Checked) itemno--;
                    playList.SelectedIndex = itemno + 1;
                    mp.URL = paths[playList.SelectedIndex];
                    timer1.Start();
                }
                else { timer1.Start(); }
            }
            catch (Exception ex)
            {
                if (repeatallbox.Checked == true)
                {
                    playList.SelectedIndex = 0;
                    mp.URL = paths[playList.SelectedIndex];
                }
                else
                {
                    mp.URL = "";
                    playList.SelectedIndex = 0;
                }
            }
        }

        private void repeatallbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Shuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (Shuffle.Checked == true)
            {
                shuffle = true;



            }
            else
            {
                shuffle = false;
            }
        }




    }
}
