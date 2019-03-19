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
namespace POVWinForm
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gn5S1RHVMuZUFrqgDWpPWPTuIQs0U6n0krlYTGiL",
            BasePath = "https://povglobedatabase.firebaseio.com/"
        };
        IFirebaseClient client;
        System.IO.Ports.SerialPort btLink = new System.IO.Ports.SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            try
            {
                System.Threading.Thread.Sleep(2000);
                btLink.BaudRate = 9600;
                btLink.PortName = "COM4";
                btLink.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        bool ensureAllDigits(string s)
        {
            if (s.All(char.IsDigit)) { return true; }
            else { return false; }
        }
        int[,] serializeString(string ori)
        {
            int[,] mainArray = new int[144, 144];
            if (ori.Length > 10)
            {
                MessageBox.Show("string too long");
                return mainArray;
            }
            for (int i = 0; i < ori.Length; i++)
            {

            }

            return mainArray;
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
                redString = "0";
            }
            else
            {
                redString = redBox.Text.ToString();
            }
            string greenString;
            if (string.IsNullOrWhiteSpace(greenBox.Text))
            {
                greenString = "0";
            }
            else
            {
                greenString = greenBox.Text.ToString();
            }
            string blueString;
            if (string.IsNullOrWhiteSpace(blueBox.Text))
            {
                blueString = "0";
            }
            else
            {
                blueString = blueBox.Text.ToString();
            }
            string fpsString;
            if (string.IsNullOrWhiteSpace(fpsBox.Text))
            {
                fpsString = "0";
            }
            else
            {
                fpsString = fpsBox.Text.ToString();
            }
            if (!ensureAllDigits(redString) || !ensureAllDigits(greenString) || !ensureAllDigits(blueString) || !ensureAllDigits(fpsString))
            {
                MessageBox.Show("syntax error");
                return;
            }
            int redInt = Convert.ToInt16(redString);
            int greenInt = Convert.ToInt16(greenString);
            int blueInt = Convert.ToInt16(blueString);
            int fpsInt = Convert.ToInt16(fpsString);
            if (redInt > 255 || greenInt > 255 || blueInt > 255 || fpsInt > 50)
            {
                MessageBox.Show("value error");
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
                timeDate = DateTime.Now.ToString("dd/MM/yyyy") + " @ " + DateTime.Now.ToString("HH:mm:ss")
            };
            SetResponse response = await client.SetAsync("src/", data);

            //btLink.WriteLine(textString + " " + redInt + " " + greenInt + " " + blueInt + " " + fpsInt);
            Console.WriteLine(textString + " " + redInt + " " + greenInt + " " + blueInt + " " + fpsInt);

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
