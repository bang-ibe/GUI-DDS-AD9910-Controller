using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; 

namespace Control_Frequency
{
    public partial class Form_ControlFrequency : Form
    {
        string SingleFrequencyMode = "11";
        string SweepFrequencyPerDecadeMode = "12";
        string SweepFrequencyMode = "13";

        string SingleFrequencyValue;
        string StartPerDecadeValue;
        string StopPerdecadeValue;
        string StartFrequencyValue;
        string StepFrequencyValue;
        string StopFrequencyValue;

        string MCS_LockBytes = "MCS#";
        string afterMOde = "=";
        string betweenFrequency = ";";
        string ZeroParameter = "0";

        string modeArus1 = "1"; //1 mA
        string modeArus2 = "2"; //100 uA
        string modeArus3 = "3"; //10 uA
        string modeArus4 = "4"; //1 uA
        string modeArus5 = "5"; //0,1 uA
        string channelMux1 = "0"; //1 mA
        string channelMux2 = "1"; //100 uA
        string channelMux3 = "2"; //10 uA
        string channelMux4 = "3"; //1 uA
        string channelMux5 = "4"; //0,1 uA
        string ESPRestart = "88";

        public Form_ControlFrequency()
        {
            InitializeComponent();
        }

        private void Form_ControlFrequency_Load_1(object sender, EventArgs e)
        {
            string[] MCSport = SerialPort.GetPortNames();
            comboBox_COMPORT.Items.AddRange(MCSport);
            button_SINGLEFREQUENCY.Enabled = false;
            button_SWEEPFREQUENCY.Enabled = false;
            button_SweepPerdecade.Enabled = false;
            button_SetCurrent.Enabled = false;
            groupBox_ControlFrequency.Enabled = false;
            groupBox_Single_Frequency.Enabled = false;
            groupBox_SweepFrequencyPerDecade.Enabled = false;
            groupBox_Sweep_Frequency.Enabled = false;
        }

        private void button_CONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_COMPORT.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();

                progressBar1.Value = 100;
                label_COMPORTONOFFSTATUS.Text = "ON";

                button_SetCurrent.Enabled = true;
                groupBox_ControlFrequency.Enabled = true;
                groupBox_ControlCurrent.Enabled = true;
                serialPort1.Write(MCS_LockBytes + ESPRestart + afterMOde + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                label_COMPORTONOFFSTATUS.Text = "OFF";
               /* serialPort1.Close();*/
                
            }
        }

        private void checkBox_Single_Frequency_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Single_Frequency.Checked == true)
            {
                checkBox_Sweep_Frequency.Checked = false;
                checkBox_Single_Frequency.Checked = true;
                checkBox_SweepPerDecade.Checked = false;

                groupBox_SweepFrequencyPerDecade.Enabled = false;
                groupBox_Single_Frequency.Enabled = true;
                groupBox_Sweep_Frequency.Enabled = false;

                textBox_StartPerdecade.Text = "e.g.: 10000000";
                textBox_StopPerdecade.Text = "e.g.: 10000000";
                textBox_START_FREQUENCY.Text = "e.g.: 10000000";
                textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
                textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
            }
        }

        private void checkBox_SweepPerDecade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SweepPerDecade.Checked == true)
            {
                checkBox_SweepPerDecade.Checked = true;
                checkBox_Sweep_Frequency.Checked = false;
                checkBox_Single_Frequency.Checked = false;

                groupBox_SweepFrequencyPerDecade.Enabled = true;
                groupBox_Single_Frequency.Enabled = false;
                groupBox_Sweep_Frequency.Enabled = false;

                textBox_START_FREQUENCY.Text = "e.g.: 10000000";
                textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
                textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
                textBox_SingleFrequency.Text = "e.g.: 10000000";
            }
        }

        private void checkBox_Sweep_Frequency_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sweep_Frequency.Checked == true)
            {
                checkBox_Single_Frequency.Checked = false;
                checkBox_Sweep_Frequency.Checked = true;
                checkBox_SweepPerDecade.Checked = false;

                groupBox_SweepFrequencyPerDecade.Enabled = false;
                groupBox_Sweep_Frequency.Enabled = true;
                groupBox_Single_Frequency.Enabled = false;

                textBox_StartPerdecade.Text = "e.g.: 10000000";
                textBox_StopPerdecade.Text = "e.g.: 10000000";
                textBox_SingleFrequency.Text = "e.g.: 10000000";
            }
        }
        private void textBox_SingleFrequency_Leave(object sender, EventArgs e)
        {
            if (textBox_SingleFrequency.Text == "")
            {
                textBox_SingleFrequency.Text = "e.g.: 10000000";
                textBox_SingleFrequency.ForeColor = Color.DimGray;
            }
        }

        private void textBox_SingleFrequency_Enter(object sender, EventArgs e)
        {
            button_SINGLEFREQUENCY.Enabled = true;
            if (textBox_SingleFrequency.Text == "e.g.: 10000000")
            {
                textBox_SingleFrequency.Text = "";
                textBox_SingleFrequency.ForeColor = Color.LightGray;
            }
        }

        private void textBox_StartPerdecade_Enter(object sender, EventArgs e)
        {
            button_SweepPerdecade.Enabled = true;
            if (textBox_StartPerdecade.Text == "e.g.: 10000000")
            {
                textBox_StartPerdecade.Text = "";
                textBox_StartPerdecade.ForeColor = Color.LightGray;
            }
        }

        private void textBox_StartPerdecade_Leave(object sender, EventArgs e)
        {
            if (textBox_StartPerdecade.Text == "")
            {
                textBox_StartPerdecade.Text = "e.g.: 10000000";
                textBox_StartPerdecade.ForeColor = Color.DimGray;
            }
        }

        private void textBox_StopPerdecade_Leave(object sender, EventArgs e)
        {
            if (textBox_StopPerdecade.Text == "")
            {
                textBox_StopPerdecade.Text = "e.g.: 10000000";
                textBox_StopPerdecade.ForeColor = Color.DimGray;
            }
        }

        private void textBox_StopPerdecade_Enter(object sender, EventArgs e)
        {
            if (textBox_StopPerdecade.Text == "e.g.: 10000000")
            {
                textBox_StopPerdecade.Text = "";
                textBox_StopPerdecade.ForeColor = Color.LightGray;
            }
        }

        private void textBox_START_FREQUENCY_Leave(object sender, EventArgs e)
        {
            if (textBox_START_FREQUENCY.Text == "")
            {
                textBox_START_FREQUENCY.Text = "e.g.: 10000000";
                textBox_START_FREQUENCY.ForeColor = Color.DimGray;
            }
        }

        private void textBox_START_FREQUENCY_Enter(object sender, EventArgs e)
        {
            if (textBox_START_FREQUENCY.Text == "e.g.: 10000000")
            {
                textBox_START_FREQUENCY.Text = "";
                textBox_START_FREQUENCY.ForeColor = Color.LightGray;
            }
        }

        private void textBox_STEPFREQUENCY_Leave(object sender, EventArgs e)
        {
            if (textBox_STEPFREQUENCY.Text == "")
            {
                textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
                textBox_STEPFREQUENCY.ForeColor = Color.DimGray;
            }
        }

        private void textBox_STEPFREQUENCY_Enter(object sender, EventArgs e)
        {
            if (textBox_STEPFREQUENCY.Text == "e.g.: 10000000")
            {
                textBox_STEPFREQUENCY.Text = "";
                textBox_STEPFREQUENCY.ForeColor = Color.LightGray;
            }
        }

        private void textBox_STOPFREQUENCY_Leave(object sender, EventArgs e)
        {
            if (textBox_STOPFREQUENCY.Text == "")
            {
                textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
                textBox_STOPFREQUENCY.ForeColor = Color.DimGray;
            }
        }

        private void textBox_STOPFREQUENCY_Enter(object sender, EventArgs e)
        {
            if (textBox_STOPFREQUENCY.Text == "e.g.: 10000000")
            {
                textBox_STOPFREQUENCY.Text = "";
                textBox_STOPFREQUENCY.ForeColor = Color.LightGray;
                button_SWEEPFREQUENCY.Enabled = true;
            }
        }

        private void button_DISCONNECT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                label_COMPORTONOFFSTATUS.Text = "OFF";
                groupBox_ControlFrequency.Enabled = false;
                groupBox_ControlCurrent.Enabled = false;
                checkBox_Sweep_Frequency.Checked = false;
                checkBox_Single_Frequency.Checked = false;
                checkBox_SweepPerDecade.Checked = false;
            }
        }

        private void button_SINGLEFREQUENCY_Click(object sender, EventArgs e)
        {
            try
            {
                SingleFrequencyValue = textBox_SingleFrequency.Text;
                serialPort1.Write(MCS_LockBytes + SingleFrequencyMode + afterMOde + SingleFrequencyValue + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SweepPerdecade_Click(object sender, EventArgs e)
        {
            try
            {
                StartPerDecadeValue = textBox_StartPerdecade.Text;
                StopPerdecadeValue = textBox_StopPerdecade.Text;

                serialPort1.Write(MCS_LockBytes + SweepFrequencyPerDecadeMode + afterMOde + StartPerDecadeValue + betweenFrequency + StopPerdecadeValue + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void button_SWEEPFREQUENCY_Click(object sender, EventArgs e) 
        {
            try
            {
                StartFrequencyValue = textBox_START_FREQUENCY.Text;
                StepFrequencyValue = textBox_STEPFREQUENCY.Text;
                StopFrequencyValue = textBox_STOPFREQUENCY.Text;
                serialPort1.Write(MCS_LockBytes + SweepFrequencyMode + afterMOde + StartFrequencyValue + betweenFrequency + StepFrequencyValue + betweenFrequency + StopFrequencyValue + betweenFrequency + "\n");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SetCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_SELECTCURRENT.Text == "1 mA")
                {
                    serialPort1.Write(MCS_LockBytes + modeArus1 + afterMOde + channelMux1 + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
                }
                else if (comboBox_SELECTCURRENT.Text == "100 μA")
                {
                    serialPort1.Write(MCS_LockBytes + modeArus2 + afterMOde + channelMux2 + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
                }
                else if (comboBox_SELECTCURRENT.Text == "10 μA")
                {
                    serialPort1.Write(MCS_LockBytes + modeArus3 + afterMOde + channelMux3 + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
                }
                else if (comboBox_SELECTCURRENT.Text == "1 μA")
                {
                    serialPort1.Write(MCS_LockBytes + modeArus4 + afterMOde + channelMux4 + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
                }
                else if (comboBox_SELECTCURRENT.Text == "0,1 μA")
                {
                    serialPort1.Write(MCS_LockBytes + modeArus5 + afterMOde + channelMux5 + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RESTARTESP_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(MCS_LockBytes + ESPRestart + afterMOde + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency + "\n");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                label_COMPORTONOFFSTATUS.Text = "OFF";
                /* serialPort1.Close();*/

            }
        }
    }
}
