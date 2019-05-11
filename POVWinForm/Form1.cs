using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.IO.Ports;
using System.IO;
namespace POVWinForm
{

    public partial class POVWinForm : Form
    {
        char currentFocus = 'f';
        int maxStrLeng = 10;
        int currentManualIndex;
        bool manualOpen = false;
        bool bluetoothHelpOpen = false;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gn5S1RHVMuZUFrqgDWpPWPTuIQs0U6n0krlYTGiL",
            BasePath = "https://povglobedatabase.firebaseio.com/"
        };
        IFirebaseClient client;
        System.IO.Ports.SerialPort btLink = new System.IO.Ports.SerialPort();
        public POVWinForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();
                var result = ping.Send("www.google.com");
            }
            catch
            {
                MessageBox.Show("Internet connectivity issue. Please connect to the internet and try again.");
                this.Close();
            }
            client = new FireSharp.FirebaseClient(config);
            var data = new Data
            {
                text = "BOOT",
                red = 0,
                green = 0,
                blue = 0,
                fps = 0,
                timeDate = DateTime.Now.ToString("MM/dd/yyyy") + " @ " + DateTime.Now.ToString("HH:mm:ss")
            };
            log(data);
            try
            {
                System.Threading.Thread.Sleep(2000);
                btLink.BaudRate = 9600;
                btLink.PortName = "COM4";
                btLink.Open();
            }
            catch
            {
                MessageBox.Show("Error pairing to POV Globe via bluetooth. Please restart both applications or contact Brannon for assistance :)\nbrannonh@buffalo.edu");
            }

        }
        bool ensureAllDigits(string s)
        {
            if (s.All(char.IsDigit)) { return true; }
            else { return false; }
        }
        private async void log(Data d)
        {
            try
            {
                int i = 1;
                while (true)
                {
                    FirebaseResponse firebaseResponse = await client.GetAsync("src/" + i);
                    Data obj = firebaseResponse.ResultAs<Data>();
                    if (obj != null)
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        SetResponse response = await client.SetAsync("src/" + i, d);
                        break;
                    }
                }
            }
            catch
            {

            }
        }
        private async void mainButton_Click(object sender, EventArgs e)
        {
            string textString;
            if (string.IsNullOrWhiteSpace(stringBox.Text))
            {
                textString = "";
            }
            else
            {
                textString = stringBox.Text.ToString();
            }

            string redString;
            if (string.IsNullOrWhiteSpace(redBox.Text))
            {
                redString = "000";
            }
            else
            {
                redString = redBox.Text.ToString();
                while (redString.Length < 3)
                {
                    redString = "0" + redString;
                }
            }
            string greenString;
            if (string.IsNullOrWhiteSpace(greenBox.Text))
            {
                greenString = "000";
            }
            else
            {
                greenString = greenBox.Text.ToString();
                while (greenString.Length < 3)
                {
                    greenString = "0" + greenString;
                }
            }
            string blueString;
            if (string.IsNullOrWhiteSpace(blueBox.Text))
            {
                blueString = "000";
            }
            else
            {
                blueString = blueBox.Text.ToString();
                while (blueString.Length < 3)
                {
                    blueString = "0" + blueString;
                }
            }
            string fpsString;
            if (string.IsNullOrWhiteSpace(fpsBox.Text))
            {
                fpsString = "000";
            }
            else
            {
                fpsString = fpsBox.Text.ToString();
                while (fpsString.Length < 3)
                {
                    fpsString = "0" + fpsString;
                }
            }
            if (!ensureAllDigits(redString) || !ensureAllDigits(greenString) || !ensureAllDigits(blueString) || !ensureAllDigits(fpsString))
            {
                MessageBox.Show("Please check the syntax of your input.");
                return;
            }
            int redInt = Convert.ToInt16(redString);
            int greenInt = Convert.ToInt16(greenString);
            int blueInt = Convert.ToInt16(blueString);
            int fpsInt = Convert.ToInt16(fpsString);
            if (redInt > 255 || greenInt > 255 || blueInt > 255 || fpsInt > 255)
            {
                MessageBox.Show("Please check the values of your input.");
                return;
            }
            //else valid data
            var data = new Data
            {
                text = textString,
                red = redInt,
                green = greenInt,
                blue = blueInt,
                fps = fpsInt,
                timeDate = DateTime.Now.ToString("MM/dd/yyyy") + " @ " + DateTime.Now.ToString("HH:mm:ss")
            };
            int i = 1;
            while (true)
            {
                FirebaseResponse firebaseResponse = await client.GetAsync("src/" + i);
                Data obj = firebaseResponse.ResultAs<Data>();
                if (obj != null)
                {
                    i++;
                    continue;
                }
                else
                {
                    SetResponse response = await client.SetAsync("src/" + i, data);
                    break;
                }
            }
            string transmissionString = "";
            transmissionString += "s";
            transmissionString += "r" + redString;
            transmissionString += "g" + greenString;
            transmissionString += "b" + blueString;
            transmissionString += "f" + fpsString;
            transmissionString += ";" + textString + '~';
            try
            {
                //transmission
                btLink.WriteLine(transmissionString);
            }
            catch
            {
                MessageBox.Show("Transmission error. Please contact Brannon with any technical difficulties. brannonh@buffalo.edu");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                //transmission
                btLink.WriteLine("r");
            }
            catch
            {
                MessageBox.Show("Transmission error. Please contact Brannon with any technical difficulties. brannonh@buffalo.edu");
            }
        }
        private bool dontOverFlowMyTextBoxesPlz()
        {
            if ((fpsBox.Text.Length == 2 && currentFocus == 'f')
                || (redBox.Text.Length == 3 && currentFocus == 'r')
                || (greenBox.Text.Length == 3 && currentFocus == 'g')
                || (blueBox.Text.Length == 3 && currentFocus == 'b')
                || (stringBox.Text.Length == maxStrLeng && currentFocus == 's'))
            { return false; }
            else { return true; }

        }

        private void fpsBox_Click(object sender, EventArgs e)
        {
            currentFocus = 'f';
        }
        private void stringBox_Click(object sender, EventArgs e)
        {
            currentFocus = 's';
        }
        private void redBox_Click(object sender, EventArgs e)
        {
            currentFocus = 'r';
        }
        private void greenBox_Click(object sender, EventArgs e)
        {
            currentFocus = 'g';
        }
        private void blueBox_Click(object sender, EventArgs e)

        {
            currentFocus = 'b';
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            manualOpen = true;
            authorLabel.Visible = false;
            manualPictureBox.Visible = true;
            leftButton.Visible = true;
            exitManualButton.Visible = true;
            rightButton.Visible = true;
            resetButton.Enabled = false;
            btHelpButton.Enabled = false;
            mainButton.Enabled = false;
            manualButton.Enabled = false;
            manualPictureBox.Load(Application.StartupPath + "\\slides\\" + "manualSlide0.png");
            currentManualIndex = 0;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (bluetoothHelpOpen == true)
            {
                if (File.Exists(Application.StartupPath + "\\btHelp\\" + "btHelp" + (currentManualIndex + (-1)) + ".png"))
                {
                    currentManualIndex--;
                    manualPictureBox.Load(Application.StartupPath + "\\btHelp\\" + "btHelp" + currentManualIndex + ".png");
                }
            }
            else
            {
                if (File.Exists(Application.StartupPath + "\\slides\\" + "manualSlide" + (currentManualIndex + (-1)) + ".png"))
                {
                    currentManualIndex--;
                    manualPictureBox.Load(Application.StartupPath + "\\slides\\" + "manualSlide" + currentManualIndex + ".png");
                }
            }
        }

        private void exitManualButton_Click(object sender, EventArgs e)
        {
            if (manualOpen == true) { manualOpen = false; }
            else { bluetoothHelpOpen = false; }
            manualPictureBox.Visible = false;
            leftButton.Visible = false;
            exitManualButton.Visible = false;
            rightButton.Visible = false;
            resetButton.Enabled = true;
            btHelpButton.Enabled = true;
            mainButton.Enabled = true;
            manualButton.Enabled = true;
            authorLabel.Visible = true;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (bluetoothHelpOpen == true)
            {
                if (File.Exists(Application.StartupPath + "\\btHelp\\" + "btHelp" + (currentManualIndex + 1) + ".png"))
                {
                    currentManualIndex++;
                    manualPictureBox.Load(Application.StartupPath + "\\btHelp\\" + "btHelp" + currentManualIndex + ".png");
                }
            }
            else
            {
                if (File.Exists(Application.StartupPath + "\\slides\\" + "manualSlide" + (currentManualIndex + 1) + ".png"))
                {
                    currentManualIndex++;
                    manualPictureBox.Load(Application.StartupPath + "\\slides\\" + "manualSlide" + currentManualIndex + ".png");
                }
            }
        }

        private void btHelpButton_Click(object sender, EventArgs e)
        {
            bluetoothHelpOpen = true;
            authorLabel.Visible = false;
            manualPictureBox.Visible = true;
            leftButton.Visible = true;
            exitManualButton.Visible = true;
            btHelpButton.Enabled = false;
            rightButton.Visible = true;
            resetButton.Enabled = false;
            mainButton.Enabled = false;
            manualButton.Enabled = false;
            manualPictureBox.Load(Application.StartupPath + "\\btHelp\\" + "btHelp0.png");
            currentManualIndex = 0;
        }
    }
    internal class Data
    {
        public string text { get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int fps { get; set; }
        public string timeDate { get; set; }
    }

}