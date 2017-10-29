using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Drawing.Imaging;

namespace Ambient_Light
{
    public partial class Form1 : Form
    {
        //*************************************************************
        //*** Properties ***
        private Ambi ambie = new Ambi();
        private XmlDocument doc = new XmlDocument();
        private bool numericupdowndeactivate = false;

        //*************************************************************
        //*** Constructor ***

        public Form1()
        {
            InitializeComponent();
        }

        //*************************************************************
        //*** Start & End ***

        /// <summary>
        /// Get the startup color.
        /// </summary>
        private void StartUpColor()
        {
            if (radioButtonOff.Checked == true)
            {
                ambie.Fadespeed = 0;
                ambie.ChangeColor(Color.Black);
            }
            else if (radioButtonMode.Checked == true)
            {
                if (radioButtonColorFlow.Checked == true)
                {
                    BtnColorFlow.PerformClick();
                }
                else if (radioButtonLive.Checked == true)
                {
                    if (BtnLiveOnOff.BackColor != Color.Red)
                        BtnLiveOnOff.PerformClick();
                }
            }
            else if (radioButtonColor.Checked == true)
            {
                if (radioButtonRed.Checked == true)
                {
                    ambie.ChangeColor(255, 0, 0, 0, 3);
                }
                else if (radioButtonGreen.Checked == true)
                {
                    ambie.ChangeColor(0, 255, 0, 0, 3);
                }
                else if (radioButtonBlue.Checked == true)
                {
                    ambie.ChangeColor(0, 0, 255, 0, 3);
                }
                else if (radioButtonWhite.Checked == true)
                {
                    ambie.ChangeColor(0, 0, 0, 255, 3);
                }
                else if (radioButtonCustom.Checked == true)
                {
                    ambie.ChangeColor(BtnCustom.BackColor.R,
                                      BtnCustom.BackColor.G,
                                      BtnCustom.BackColor.B,
                                      0, 3);
                }
            }
        }

        /// <summary>
        /// Load the settings from the XML.
        /// </summary>
        private void LoadXMLData()
        {
            string xmlPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\AmbiSetup.xml";
            Console.WriteLine(xmlPath);
            try
            {
                if (File.Exists(xmlPath) == true)
                {
                    doc.Load(xmlPath);
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/startup");
                    XmlNodeList nodelist = node.ChildNodes;
                    foreach (XmlNode n in nodelist)
                    {
                        Console.WriteLine(n.Name);
                        switch (n.Name)
                        {
                            case "fadespeed":
                                numericUpDownFadeSpeed.Value = Convert.ToInt32(n.InnerText);
                                break;

                            case "startonstartup":
                                Console.WriteLine("Entered: " + n.Name);
                                Console.WriteLine("startonstartup is:" + n.InnerText);
                                try
                                {
                                    if (n.InnerText == "true")
                                    {
                                        checkBoxstartup.Checked = true;
                                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk") == false)
                                        {
                                            File.Copy(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Ambi.lnk", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk");
                                        }
                                    }
                                    else
                                    {
                                        checkBoxstartup.Checked = false;
                                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk") == true)
                                        {
                                            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }

                                break;

                            case "modeorcolor":
                                switch (n.InnerText)
                                {
                                    case "color":
                                        radioButtonColor.Checked = true;
                                        break;

                                    case "mode":
                                        radioButtonMode.Checked = true;
                                        break;

                                    case "off":
                                        radioButtonOff.Checked = true;
                                        break;
                                }
                                break;

                            case "startupcolor":
                                XmlNodeList xlist = n.ChildNodes;
                                foreach (XmlNode xn in xlist)
                                {
                                    switch (xn.Name)
                                    {
                                        case "colortype":
                                            Console.WriteLine("Entered: " + xn.Name);
                                            List<Control> rblist = new List<Control>();
                                            foreach (Control c in groupBoxStartup.Controls)
                                            {
                                                if (c is RadioButton)
                                                {
                                                    rblist.Add(c);
                                                }
                                            }
                                            switch (xn.InnerText)
                                            {
                                                case "red":
                                                    radioButtonRed.Checked = true;
                                                    break;

                                                case "green":
                                                    radioButtonGreen.Checked = true;
                                                    break;

                                                case "blue":
                                                    radioButtonBlue.Checked = true;
                                                    break;

                                                case "white":
                                                    radioButtonWhite.Checked = true;
                                                    break;

                                                case "custom":
                                                    radioButtonCustom.Checked = true;
                                                    break;
                                            }
                                            break;

                                        case "color":
                                            XmlNodeList xl = xn.ChildNodes;
                                            int r = 0;
                                            int g = 0;
                                            int b = 0;
                                            int alpha = 0;
                                            foreach (XmlNode x in xl)
                                            {
                                                switch (x.Name)
                                                {
                                                    case "red":
                                                        r = Convert.ToInt16(x.InnerText);
                                                        break;

                                                    case "green":
                                                        g = Convert.ToInt16(x.InnerText);
                                                        break;

                                                    case "blue":
                                                        b = Convert.ToInt16(x.InnerText);
                                                        break;
                                                    case "alpha":
                                                        alpha = Convert.ToInt16(x.InnerText);
                                                        break;
                                                }
                                            }
                                            BtnCustom.BackColor = Color.FromArgb(alpha, r, g, b);
                                            break;
                                    }
                                }
                                break;

                            case "startupmode":
                                switch (n.InnerText)
                                {
                                    case "colorflow":
                                        radioButtonColorFlow.Checked = true;
                                        break;

                                    case "live":
                                        radioButtonLive.Checked = true;
                                        break;
                                }
                                break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Save the settings to the XML.
        /// </summary>
        private void SaveXMLData()
        {
            string xmlPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\AmbiSetup.xml";
            Console.WriteLine(xmlPath);
            try
            {
                if (File.Exists(xmlPath) == true)
                {
                    doc.Load(xmlPath);
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/startup");
                    XmlNodeList nodelist = node.ChildNodes;
                    foreach (XmlNode n in nodelist)
                    {
                        switch (n.Name)
                        {
                            case "fadespeed":
                                n.InnerText = numericUpDownFadeSpeed.Value.ToString();
                                break;

                            case "startonstartup":
                                n.InnerText = checkBoxstartup.Checked.ToString().ToLower();
                                if (checkBoxstartup.Checked == false)
                                {
                                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk") == true)
                                    {
                                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk");
                                    }
                                }
                                else if (checkBoxstartup.Checked == true)
                                {
                                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk") == false)
                                    {
                                        File.Copy(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\Ambi.lnk", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\Ambi.lnk");
                                    }
                                }

                                Console.WriteLine(n.InnerText);
                                break;

                            case "modeorcolor":
                                if (radioButtonColor.Checked == true)
                                {
                                    n.InnerText = "color";
                                }
                                else if (radioButtonMode.Checked == true)
                                {
                                    n.InnerText = "mode";
                                }
                                else if (radioButtonOff.Checked == true)
                                {
                                    n.InnerText = "off";
                                }
                                break;

                            case "startupcolor":
                                XmlNodeList xlist = n.ChildNodes;
                                foreach (XmlNode xn in xlist)
                                {
                                    switch (xn.Name)
                                    {
                                        case "colortype":
                                            if (radioButtonRed.Checked == true)
                                            {
                                                xn.InnerText = "red";
                                            }
                                            else if (radioButtonGreen.Checked == true)
                                            {
                                                xn.InnerText = "green";
                                            }
                                            else if (radioButtonBlue.Checked == true)
                                            {
                                                xn.InnerText = "blue";
                                            }
                                            else if (radioButtonWhite.Checked == true)
                                            {
                                                xn.InnerText = "white";
                                            }
                                            else if (radioButtonCustom.Checked == true)
                                            {
                                                xn.InnerText = "custom";
                                            }
                                            break;

                                        case "color":
                                            XmlNodeList xnlist = xn.ChildNodes;
                                            foreach (XmlNode xnode in xnlist)
                                            {
                                                switch (xnode.Name)
                                                {
                                                    case "red":
                                                        xnode.InnerText = BtnCustom.BackColor.R.ToString();
                                                        break;

                                                    case "green":
                                                        xnode.InnerText = BtnCustom.BackColor.G.ToString();
                                                        break;

                                                    case "blue":
                                                        xnode.InnerText = BtnCustom.BackColor.B.ToString();
                                                        break;

                                                    case "alpha":
                                                        xnode.InnerText = BtnCustom.BackColor.A.ToString();
                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                }
                                break;

                            case "startupmode":
                                if (radioButtonLive.Checked == true)
                                {
                                    n.InnerText = "live";
                                }
                                else if (radioButtonColorFlow.Checked == true)
                                {
                                    n.InnerText = "colorflow";
                                }
                                break;
                        }
                    }
                }
                doc.Save(xmlPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Load all settings and start the LEDs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadXMLData();
            StartUpColor();
            notifyIconTray.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// Close the COM port, turne of the LEDs and save all settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXMLData();
            ambie.ChangeColor(0, 0, 0, 0, 3);
            SerialPort Serialport1 = ambie.Serialport;  // G the serial port whitch was used for the ambientlight.
            ambie = null;  // Set the object to null to ensure that it is no longer in use.
            Serialport1.Close();  // Close the serial port. Any other programm is now able to use this port.
        }

        //*************************************************************
        //*** Events ***

        /// <summary>
        /// Change the LED color to red.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRed_Click(object sender, EventArgs e)
        {
            numericUpDownRed.Value = 255;
            numericUpDownGreen.Value = 0;
            numericUpDownBlue.Value = 0;
            numericUpDownWhite.Value = 0;
        }

        /// <summary>
        /// Change the LED color to Green.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGreen_Click(object sender, EventArgs e)
        {
            numericUpDownRed.Value = 0;
            numericUpDownGreen.Value = 255;
            numericUpDownBlue.Value = 0;
            numericUpDownWhite.Value = 0;
        }

        /// <summary>
        /// Change the LED color to blue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBlue_Click(object sender, EventArgs e)
        {
            numericUpDownRed.Value = 0;
            numericUpDownGreen.Value = 0;
            numericUpDownBlue.Value = 255;
            numericUpDownWhite.Value = 0;
        }

        /// <summary>
        /// Change the LED color to warm white.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWhite_Click(object sender, EventArgs e)
        {
            numericUpDownRed.Value = 0;
            numericUpDownGreen.Value = 0;
            numericUpDownBlue.Value = 0;
            numericUpDownWhite.Value = 255;
        }

        /// <summary>
        /// turne the LEDs off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLedOff_Click(object sender, EventArgs e)
        {
            numericUpDownRed.Value = 0;
            numericUpDownGreen.Value = 0;
            numericUpDownBlue.Value = 0;
            numericUpDownWhite.Value = 0;
            ambie.ChangeColor(Color.Black);
        }

        /// <summary>
        /// Calculate the momentual average color of the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSingleLive_Click(object sender, EventArgs e)
        {
            Bitmap screenshot = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format32bppArgb);  // Create a new Bitmap and set the size of it.
            Graphics screenGraph = Graphics.FromImage(screenshot);  // Create new Graphic drawing area based on the bitmab named "screenshot".
            screenGraph.CopyFromScreen(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y, 0, 0, SystemInformation.VirtualScreen.Size, CopyPixelOperation.SourceCopy); // Copy the screen to the bitmap.
            ambie.Fadespeed = 0;
            ambie.ChangeColor(screenshot, 1);
            numericupdowndeactivate = true;
            numericUpDownRed.Value = ambie.Red;
            numericUpDownGreen.Value = ambie.Green;
            numericUpDownBlue.Value = ambie.Blue;
            numericUpDownWhite.Value = ambie.White;
            numericupdowndeactivate = false;
            screenshot.Dispose();
            screenGraph.Dispose();
        }

        /// <summary>
        /// Start or Stop the Live mode.
        /// Every 10ms the average color will be refreshed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLiveOnOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (timerAmbiRefresh.Enabled == false)
                {
                    Console.WriteLine("Starting background worker.");
                    ambie.Fadespeed = 0;
                    BtnLiveOnOff.BackColor = Color.Red;
                    BtnColorFlow.Enabled = false;
                    timerAmbiRefresh.Enabled = true;
                }
                else
                {
                    backgroundWorkerLive.CancelAsync();
                    timerAmbiRefresh.Enabled = false;
                    BtnLiveOnOff.BackColor = SystemColors.Control;
                    BtnColorFlow.Enabled = true;
                    Console.WriteLine("Finished background worker.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// Open a colordialog to let the user select a custom color.
        /// This color will show up on the programm startup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustom_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog coldia = new ColorDialog();
                coldia.ShowDialog();
                BtnCustom.BackColor = coldia.Color;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Open a colordialog to let the user select a custom color.
        /// The color will change immediatly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustomColor_Click(object sender, EventArgs e)
        {
            ColorDialog coldia = new ColorDialog();
            coldia.ShowDialog();
            ambie.ChangeColor(coldia.Color);
            numericUpDownRed.Value = coldia.Color.R;
            numericUpDownGreen.Value = coldia.Color.G;
            numericUpDownBlue.Value = coldia.Color.B;
            numericUpDownWhite.Value = 0;
        }

        /// <summary>
        /// Start a color Flow form red to green to blue and so on.
        /// Speed can be adjusted by changing the value of fadespeed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnColorFlow_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnColorFlow.BackColor == Color.Red)
                {
                    backgroundWorkerColorFlow.CancelAsync();
                    ambie.ChangeColor(Color.Black);
                    BtnLiveOnOff.Enabled = true;
                    BtnColorFlow.BackColor = SystemColors.Control;
                }
                else
                {
                    BtnColorFlow.BackColor = Color.Red;
                    BtnLiveOnOff.Enabled = false;
                    backgroundWorkerColorFlow.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Change the brightness of the red LED.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            if (numericupdowndeactivate == false)
                ambie.ChangeColor(Convert.ToInt16(numericUpDownRed.Value),
                                  Convert.ToInt16(numericUpDownGreen.Value),
                                  Convert.ToInt16(numericUpDownBlue.Value),
                                  Convert.ToInt16(numericUpDownWhite.Value),
                                  Convert.ToInt32(numericUpDownFadeSpeed.Value));
        }

        /// <summary>
        /// Change the brightness of the green LED.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            if (numericupdowndeactivate == false)
                ambie.ChangeColor(Convert.ToInt16(numericUpDownRed.Value),
                              Convert.ToInt16(numericUpDownGreen.Value),
                              Convert.ToInt16(numericUpDownBlue.Value),
                              Convert.ToInt16(numericUpDownWhite.Value),
                              Convert.ToInt32(numericUpDownFadeSpeed.Value));
        }

        /// <summary>
        /// Change the brightness of the blue LED.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            if (numericupdowndeactivate == false)
                ambie.ChangeColor(Convert.ToInt16(numericUpDownRed.Value),
                              Convert.ToInt16(numericUpDownGreen.Value),
                              Convert.ToInt16(numericUpDownBlue.Value),
                              Convert.ToInt16(numericUpDownWhite.Value),
                              Convert.ToInt32(numericUpDownFadeSpeed.Value));
        }

        /// <summary>
        /// Change the brightness of the white LED.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownWhite_ValueChanged(object sender, EventArgs e)
        {
            if (numericupdowndeactivate == false)
                ambie.ChangeColor(Convert.ToInt16(numericUpDownRed.Value),
                              Convert.ToInt16(numericUpDownGreen.Value),
                              Convert.ToInt16(numericUpDownBlue.Value),
                              Convert.ToInt16(numericUpDownWhite.Value),
                              Convert.ToInt32(numericUpDownFadeSpeed.Value));
        }

        /// <summary>
        /// Change the Fadespeed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownFadeSpeed_ValueChanged(object sender, EventArgs e)
        {
            ambie.Fadespeed = Convert.ToInt16(numericUpDownFadeSpeed.Value);
        }

        /// <summary>
        /// Start a backgroundworker every 10ms.
        /// Is used for the Live mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAmbiRefresh_Tick(object sender, EventArgs e)
        {
            if (backgroundWorkerLive.IsBusy == false)
                backgroundWorkerLive.RunWorkerAsync();
        }

        /// <summary>
        /// Show the window when the tray icon is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconTray_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIconTray.Visible = false;
        }

        /// <summary>
        /// Hide the windows to tray when minimized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconTray.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }

        }

        //*************************************************************
        //*** Background Worker ***

        /// <summary>
        /// Creeate a screenshot and calculate the average color of it.
        /// Then let the LEDs shine in this color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerLive_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Bitmap screenshot = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format32bppArgb);  // Create a new Bitmap and set the size of it.
                Graphics screenGraph = Graphics.FromImage(screenshot);  // Create new Graphic drawing area based on the bitmab named "screenshot".
                screenGraph.CopyFromScreen(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y, 0, 0, SystemInformation.VirtualScreen.Size, CopyPixelOperation.SourceCopy); // Copy the screen to the bitmap.
                ambie.ChangeColor(screenshot, 10);
                screenshot.Dispose();
                screenGraph.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Outputs a color flow from red to green to blue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerColorFlow_DoWork(object sender, DoWorkEventArgs e)
        {
            int colorcounter = 0;
            while (backgroundWorkerColorFlow.CancellationPending == false)
            {
                switch (colorcounter)
                {
                    case 0:
                        ambie.ChangeColor(Color.Red);
                        colorcounter = 1;
                        break;

                    case 1:
                        ambie.ChangeColor(Color.Green);
                        colorcounter = 2;
                        break;

                    case 2:
                        ambie.ChangeColor(Color.Blue);
                        colorcounter = 0;
                        break;
                }
                System.Threading.Thread.Sleep(Convert.ToInt32(numericUpDownFadeSpeed.Value) * 200);
            }
            ambie.ChangeColor(Color.Black);
        }
    }
}
