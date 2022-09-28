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
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Panel_Control_Frequency
{
    public partial class Panel_4ControlFrequency : Form
{
        string SingleFrequencyValue;
        string SingleFrequencyMode = "11";
        string SweepFrequencyMode = "12"; 
        string StartFrequencyValue;
        string StepFrequencyValue;
        string StopFrequencyValue;
        string MCS_LockBytes = "MCS#";
        string afterMOde = "=";
        string betweenFrequency = ";";
        string ZeroParameter = "0";
        string modeArus1 = "1"; //100 mA
        string modeArus2 = "2"; //100 uA
        string modeArus3 = "3"; //10 uA
        string modeArus4 = "4"; //1 uA
        string modeArus5 = "5"; //0,1 uA
        string channelMux1 = "3"; //100 mA
        string channelMux2 = "4"; //100 uA
        string channelMux3 = "5"; //10 uA
        string channelMux4 = "6"; //1 uA
        string channelMux5 = "7"; //0,1 uA
        
        public Panel_4ControlFrequency()
    {
        InitializeComponent();
    }

    private void Panel_4ControlFrequency_Load(object sender, EventArgs e)
    {
        string[] MCSport = SerialPort.GetPortNames();
        comboBox_COMPORT.Items.AddRange(MCSport);
        button_SINGLEFREQUENCY.Enabled = false;
        button_SWEEPFREQUENCY.Enabled = false;
        button_SetCurrent.Enabled = false;
        groupBox_FREQUENCYCONTROL.Enabled = false;
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
            button_SWEEPFREQUENCY.Enabled = true;
    }

    private void textBox1_Leave(object sender, EventArgs e)
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

    private void textBox_START_FREQUENCY_Enter(object sender, EventArgs e)
    {
        if (textBox_START_FREQUENCY.Text == "e.g.: 10000000")
        {
            textBox_START_FREQUENCY.Text = "";
            textBox_START_FREQUENCY.ForeColor = Color.LightGray;
        }
    }

    private void textBox_START_FREQUENCY_Leave(object sender, EventArgs e)
    {
        if (textBox_START_FREQUENCY.Text == "")
        {
            textBox_START_FREQUENCY.Text = "e.g.: 10000000";
            textBox_START_FREQUENCY.ForeColor = Color.DarkGray;
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

    private void textBox_STOPFREQUENCY_Enter(object sender, EventArgs e)
    {
        if (textBox_STOPFREQUENCY.Text == "e.g.: 10000000")
        {
            textBox_STOPFREQUENCY.Text = "";
            textBox_STOPFREQUENCY.ForeColor = Color.LightGray;
        }
    }

    private void textBox_STEPFREQUENCY_Leave(object sender, EventArgs e)
    {
        if (textBox_STEPFREQUENCY.Text == "")
        {
            textBox_STEPFREQUENCY.Text = "e.g.: 10000000";
            textBox_STEPFREQUENCY.ForeColor = Color.DarkGray;
        }
    }

    private void textBox_STOPFREQUENCY_Leave(object sender, EventArgs e)
    {
        if (textBox_STOPFREQUENCY.Text == "")
        {
            textBox_STOPFREQUENCY.Text = "e.g.: 10000000";
            textBox_STOPFREQUENCY.ForeColor = Color.DarkGray;
        }
    }

    private void checkBox_Single_Frequency_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_Single_Frequency.Checked == true)
        {
            checkBox_Sweep_Frequency.Checked = false;
            checkBox_Single_Frequency.Checked = true;

            groupBox_Single_Frequency.Enabled = true;
            groupBox_Sweep_Frequency.Enabled = false;

        }
    }

    private void checkBox_Sweep_Frequency_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox_Sweep_Frequency.Checked == true)
        {
            checkBox_Single_Frequency.Checked = false;
            checkBox_Sweep_Frequency.Checked = true;

            groupBox_Sweep_Frequency.Enabled = true;
            groupBox_Single_Frequency.Enabled = false;
        }
    }

    private void button_SWEEPFREQUENCY_Click(object sender, EventArgs e)
    {
            try
            {
                StartFrequencyValue = textBox_START_FREQUENCY.Text;
                StepFrequencyValue = textBox_STEPFREQUENCY.Text;
                StopFrequencyValue = textBox_STOPFREQUENCY.Text;
                serialPort1.Write(MCS_LockBytes + SweepFrequencyMode + afterMOde + StartFrequencyValue + betweenFrequency + StepFrequencyValue + betweenFrequency + StopFrequencyValue + betweenFrequency + "\n" );
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            groupBox_FREQUENCYCONTROL.Enabled = true;
            groupBox_Select_Current.Enabled = true;
            

        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                label_COMPORTONOFFSTATUS.Text = "OFF";
        }
    }

        private void button_DISCONNECT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                label_COMPORTONOFFSTATUS.Text = "OFF";
                groupBox_FREQUENCYCONTROL.Enabled = false;
                groupBox_Select_Current.Enabled = false;
            }
        }

        private void label_COMPORTONOFFSTATUS_Click(object sender, EventArgs e)
        {
              
        }

        private void button_SINGLEFREQUENCY_Click(object sender, EventArgs e)
        {
                try
                {
                    SingleFrequencyValue = textBox_SingleFrequency.Text;
                    serialPort1.Write(MCS_LockBytes + SingleFrequencyMode + afterMOde + SingleFrequencyValue + betweenFrequency + ZeroParameter + betweenFrequency + ZeroParameter + betweenFrequency+"\n");

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
        }


        private void groupBox_Single_Frequency_Enter(object sender, EventArgs e)
        {
           
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

        private void groupBox_Sweep_Frequency_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox_START_FREQUENCY_TextChanged(object sender, EventArgs e)
        {
            button_SWEEPFREQUENCY.Enabled = true;
        }

        private void textBox_STEPFREQUENCY_TextChanged(object sender, EventArgs e)
        {
            button_SWEEPFREQUENCY.Enabled = true;
        }
    }
}