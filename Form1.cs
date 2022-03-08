using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Threading.Tasks;

namespace Arbeidskrav1
{
    public partial class Form1 : Form
    {
        List<int> analogReading = new List<int>();
        List<DateTime> timeStamp = new List<DateTime>();

        List<float> scaledReading = new List<float>();
        List<DateTime> timeStampScaled = new List<DateTime>();

        //KOMMUNIKASJON MED ARDUINO + BITRATE + TIMER

        public Form1()
        {
            InitializeComponent();
            ComPort.Items.AddRange(SerialPort.GetPortNames());
            ComPort.Text = "--Velg--";
            string[] bitRate = new string[] { "1200", "2400", "4800", "9600",
                                              "19200", "38400", "57600", "115200" };
            BitRate.Items.AddRange(bitRate);
            BitRate.SelectedIndex = BitRate.Items.IndexOf("9600");

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer2.Interval = 5000;
            timer2.Tick += new EventHandler(timer2_Tick);

            timer3.Interval = 10000;
            timer3.Tick += new EventHandler(timer3_Tick);

            timer4.Interval = 5000;
            timer4.Tick += new EventHandler(timer4_Tick);




        }

        //READRAW TIMER-FUNKSJON

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.WriteLine("readraw");
            }


        }

        //TIMER FOR SCALED-VERDIER
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.WriteLine("readscaled");
            }
        }

        //TIMER FOR READSTATUS
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                serialPort1.WriteLine("readstatus");
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                timer4.Stop();
                MessageBox.Show("Connection is lost");
                label4.Text = "Disconnected";
            }

        }



        // MOTTAK AV DATA FRA ARDUINO + CHART

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            float iVab_float;
            string RecievedData = ((SerialPort)sender).ReadLine();
            string[] separateParts = RecievedData.Split(';');
            //textBox1.Invoke((MethodInvoker)delegate { textBox1.AppendText(separateParts[1] + "\r\n"); });


            //PASSWORD

            if (separateParts[0] == "writeconf" && separateParts[1] == "1\r")
            {
                MessageBox.Show("Correct Password. Configuration has been changed!");
                serialPort1.WriteLine("readconf");
            }
            if (separateParts[0] == "writeconf" && separateParts[1] == "0\r")
            {
                MessageBox.Show("Wrong Password. Please try again!");
            }

            // READCONF

            if (separateParts[0] == "readconf")
            {
                textBox1.Invoke((MethodInvoker)delegate
                {
                    labelName.Text = separateParts[1];
                    labelLowLevel.Text = separateParts[2];
                    labelUpperLevel.Text = separateParts[3];
                    labelAlarmLow.Text = separateParts[4];
                    labelAlarmHigh.Text = separateParts[5];
                });
            }

            // READSTATUS

            if ((separateParts[0] == "readstatus"))
            {
                StatusLabel.Invoke((MethodInvoker)delegate
                {
                    if (separateParts[1] == "2\r")
                    {
                        StatusLabel.Text = "Low alarm!";
                    }
                    if (separateParts[1] == "0\r")
                    {
                        StatusLabel.Text = "Everything is OK";
                    }
                    if (separateParts[1] == "1\r")
                    {
                        StatusLabel.Text = "Something is wrong!";
                    }
                    if (separateParts[1] == "3\r")
                    {
                        StatusLabel.Text = "Alarm High!";
                    }
                });
            }

            //READRAW
            if (separateParts[0] == "readraw")
            {
                Monitoring.Invoke((MethodInvoker)delegate
                {
                    Monitoring.AppendText("Raw Data" + "," + DateTime.Now.ToString("HH:mm:ss") + ", " + separateParts[1] + "\n");
                });
            }

            // READSCALED
            if (separateParts[0] == "readscaled")
            {
                Monitoring.Invoke((MethodInvoker)(delegate
                {
                    Monitoring.AppendText("Scaled Data" + "," + DateTime.Now.ToString("HH:mm:ss") + ", " + separateParts[1] + "\n");
                    if (float.TryParse(separateParts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out iVab_float))
                    {
                        scaledReading.Add(iVab_float);
                        timeStampScaled.Add(DateTime.Now);
                        Chart.Series["Vba"].Points.DataBindXY(timeStampScaled, scaledReading);
                        Chart.Invalidate();
                    }
                }));
            }


            // GRAPH

            if (separateParts[0] == "readraw")
            {
                if (int.TryParse(separateParts[1], out iVab))
                {
                    analogReading.Add(iVab);
                    timeStamp.Add(DateTime.Now);
                    textBox1.Invoke((MethodInvoker)delegate { Chart.Series["Vba"].Points.DataBindXY(timeStamp, analogReading); });
                    textBox1.Invoke((MethodInvoker)delegate { Chart.Invalidate(); });

                }
                else
                {
                    MessageBox.Show("Fungerer ikke!!");
                }
            }

            

        }

         //TRY-CATCH TIL KOMMUNIKASJON. LAGRER ERRORMELDING TIL FIL


        private void Connect_Click_1(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Mats_\Desktop\Text1.tmp.txt";

            try
            {
                timer4.Stop();
                serialPort1.Close();
                serialPort1.PortName = ComPort.Text;
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                MessageBox.Show("Connected " + ComPort.Text);
                label4.Text = ("Connected");
                timer3.Start();
                timer4.Start();
            }

            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    MessageBox.Show("Ikke gyldig port.");
                }
                else if (ex is UnauthorizedAccessException)
                {
                    MessageBox.Show("Ikke tilkoblet. Porten kan være i bruk.");
                }
                else
                {
                    MessageBox.Show("Noe er feil. Sjekk USB.");
                    //throw;



                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine("---------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine();

                        while (ex != null)
                        {
                            writer.WriteLine(ex.GetType().FullName);
                            writer.WriteLine("Error code : " + ex.Message);
                            writer.WriteLine("Tracing : " + ex.StackTrace);

                            ex = ex.InnerException;
                        }
                    }


                }



            }

        }



        // FRAKOBLING

        private void Disconnect_Click(object sender, EventArgs e)
        {

            {
                serialPort1.Close();
                MessageBox.Show("Disconnected");
                label4.Text = ("Disconnected");
                timer3.Stop();
                timer4.Stop();
            }

        }

        // SEND-FUNKSJON

        private void Send_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(Commando.Text);
                //textBox1.AppendText("Sent: " + textBox1.Text + "\r\n");
            }
        }

        // STOP READ FUNKSJONEN

        private void ManualRead_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Commando.ReadOnly = false;
                timer1.Stop();
                timer2.Stop();
                

                DialogResult dialogResult = MessageBox.Show("Do you want to save to file?", "Save To File", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveFileDialog saveConfigDialog = new SaveFileDialog();
                    saveConfigDialog.Filter = "txt files (.csv)|.csv|All files (.)|.";
                    if (saveConfigDialog.ShowDialog() == DialogResult.OK)
                    {
                        Stream s = File.Open(saveConfigDialog.FileName, FileMode.CreateNew);
                        StreamWriter savefile = new StreamWriter(s);
                        {
                            //savefile.WriteLine("Dato : " + DateTime.Now.ToString());
                            savefile.Write(Monitoring.Text);
                            savefile.Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Porten er ikke åpen!");
            }

        }

        
    

        //READ RAW KLIKK
        private void RawValues_Click(object sender, EventArgs e)
        {

            timer2.Stop();
            if (serialPort1.IsOpen)
            {
                Commando.Text = "readraw";
                Commando.ReadOnly = true;
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Porten er ikke åpen");
            }
            label9.Text = "Raw Values";
        }


        // READ SCALED KLIKK
        private void ScaledValues_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (serialPort1.IsOpen)
            {
                Commando.Text = "readscaled";
                Commando.ReadOnly = true;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Porten er ikke åpen");
            }
            label9.Text = "Scaled Values";


        }

        // CONFIG GREIER


        // CHANGE-PARAMETERE
        private string ChangeName()
        {
            if (NameText.Text == "")
            {
                return labelName.Text;
            }
            else
            {
                return NameText.Text;
            }
        }
        private string ChangeLRV()
        {
            if (LowLevelText.Text == "")
            {
                return labelLowLevel.Text;
            }
            else
            {
                return LowLevelText.Text;
            }
        }
        private string ChangeURV()
        {
            if (UpperLevelText.Text == "")
            {
                return labelUpperLevel.Text;
            }
            else
            {
                return UpperLevelText.Text;
            }

        }
        private string ChangeAL()
        {
            if (AlarmLowText.Text == "")
            {
                return labelAlarmLow.Text;
            }
            else
            {
                return AlarmLowText.Text;
            }
        }
        private string ChangeAH()
        {
            if (AlarmHighText.Text == "")
            {
                return labelAlarmHigh.Text;
            }
            else
            {
                return AlarmHighText.Text;
            }
        }

        private string ValidateText(string n, string lv, string uv, string al, string au)
        {
            string new_n = n;
            string new_lv = lv;
            string new_uv = uv;
            string new_al = al;
            string new_au = au;
            string[] newargs = {new_n, new_lv, new_uv, new_al, new_au};
            string NewConf = string.Join(";", newargs);
            return NewConf;

        }
            
        private void WriteConfig_Click(object sender, EventArgs e)
        {
            string n = ChangeName();
            string lv = ChangeLRV();
            string uv = ChangeURV();
            string al = ChangeAL();
            string au = ChangeAH();
            string writeconf = ValidateText(n, lv, uv, al, au);
            string password = Interaction.InputBox("Enter Password: ", "Password", "..", 10, 10);
            serialPort1.WriteLine("writeconf>" + password + ">" + writeconf);
        }

        private void ReadConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current config loaded");
            serialPort1.WriteLine("readconf");
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {

            string n = labelName.Text;
            string lv = labelLowLevel.Text;
            string uv = labelUpperLevel.Text;
            string al = labelAlarmLow.Text;
            string au = labelAlarmHigh.Text;
            string[] viewconf = { n, uv, lv, al, au };
            string viewConf = string.Join(";", viewconf);

            SaveFileDialog saveConfigDialog = new SaveFileDialog();
            saveConfigDialog.Filter = "txt files (.ssc)|.ssc|All files (.)|.";
            if (saveConfigDialog.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(saveConfigDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                {
                    sw.Write(viewConf);
                    sw.Close();
                }
            }

        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader inputfile = new StreamReader(@filename);

                string text = inputfile.ReadLine();
                string[] splitelements = text.Split(';');
                NameText.Text = splitelements[0];
                LowLevelText.Text = splitelements[2];
                UpperLevelText.Text = splitelements[1];
                AlarmHighText.Text = splitelements[4];
                AlarmLowText.Text = splitelements[3];
            }
        }

    }
    }



        

