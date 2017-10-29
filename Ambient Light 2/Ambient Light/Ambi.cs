using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;
using System.Drawing;

namespace Ambient_Light
{
    class Ambi
    {
        //**********************************************************************************
        //*** Attributes ***
        private int colR = 0;  // How bright the Red LEDs should shine. 0 to 255 for Off to completely On.
        private int colG = 0;  // How bright the Green LEDs should shine. 0 to 255 for Off to completely On.
        private int colB = 0;  // How bright the Blue LEDs should shine. 0 to 255 for Off to completely On.
        private int colW = 0;  // How bright the White LEDs should shine. 0 to 255 for Off to completely On.
        private int fadespeed = 0;  // How fast the colors should change.
        private SerialPort serialPort1 = new SerialPort();  // Create new Serial port. Will be used to controll the arduino.
        private int arduinobaudrate = 9600;  // Set de Baudrate of the serial Port. The baudrate oof the arduino has to be the same.

        //**********************************************************************************
        //*** Constructor ***

        /// <summary>
        /// Constructor
        /// </summary>
        public Ambi()
        {
            try
            {
                serialPort1.BaudRate = arduinobaudrate;  // Set the baudrate of the SerialPort. The Baudrate of the Arduino has to be the same.
                ArduinoCOMfinder();
                if (serialPort1.IsOpen == true)
                {
                    ChangeColor();
                }
                else
                {
                    Console.WriteLine("Unable to open Port.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_colR">How bright the Red LEDs should shine. 0 to 255.</param>
        /// <param name="_colG">How bright the Green LEDs should shine. 0 to 255.</param>
        /// <param name="_colB">How bright the Blue LEDs should shine. 0 to 255.</param>
        /// <param name="_colW">How bright the White LEDs should shine. 0 to 255.</param>
        /// <param name="_fadespeed">How fast the color should change. 0 to 255</param>
        public Ambi(int _colR, int _colG, int _colB, int _colW, int _fadespeed)
        {
            colR = _colR;
            colG = _colG;
            colB = _colB;
            colW = _colW;
            fadespeed = _fadespeed;

            try
            {
                serialPort1.BaudRate = arduinobaudrate;  // Set the baudrate of the SerialPort. The Baudrate of the Arduino has to be the same.
                ArduinoCOMfinder();
                if(serialPort1.IsOpen == true)
                {
                    ChangeColor();
                }
                else
                {
                    Console.WriteLine("Unable to open Port.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //**********************************************************************************
        //*** Get Set ***

        /// <summary>
        /// Get or Set the baudrate of the Serial Port.
        /// </summary>
        public int ArduinoBaudrate
        {
            get { return (ArduinoBaudrate); }
            set { arduinobaudrate = value; }
        }

        /// <summary>
        /// Get the brightnes of the Red LED.
        /// </summary>
        public int Red
        {
            get { return (colR); }
        }

        /// <summary>
        /// Get the brightnes of the Green LED.
        /// </summary>
        public int Green
        {
            get { return (colG); }
        }

        /// <summary>
        /// Get the brightnes of the Blue LED.
        /// </summary>
        public int Blue
        {
            get { return (colB); }
        }

        /// <summary>
        /// Get the brightnes of the White LED.
        /// </summary>
        public int White
        {
            get { return (colW); }
        }

        /// <summary>
        /// Get or set how fast the colors should change.
        /// </summary>
        public int Fadespeed
        {
            get { return (fadespeed); }
            set { fadespeed = value; }
        }

        /// <summary>
        /// Get the SerialPort. Mainly used to close the Port when leaving the programm.
        /// </summary>
        public SerialPort Serialport
        {
            get { return (serialPort1); }
        }

        //**********************************************************************************
        //*** Methods ***

        /// <summary>
        /// Find the COM port of the Arduino
        /// </summary>
        /// <returns></returns>
        private void ArduinoCOMfinder()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort"); // get all Active ports from the system.
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery); // Create a new search scope.
            List<string> serialports = new List<string>();

            try
            {
                foreach (ManagementObject item in searcher.Get())  // Scan all COM ports until one is found which name contains "Arduino".
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        serialports.Add(deviceId);
                        //return deviceId;  // Returne de device id of the arduino in form of a string.
                    }
                }
            }
            catch (ManagementException ex)
            {
                Console.WriteLine(ex);

            }

            foreach(string port in serialports)
            {
                try
                {
                    serialPort1.PortName = port;  // Get the port at which the Arduino is connected.
                    serialPort1.Open();  // Open the port. No other programm will now be able to use this port except this.
                    break;
                }
                catch
                {
                    Console.WriteLine("Port: " + port + ", could't be opened.");
                }
            }
        }

        /// <summary>
        /// Change the color. All parameters will be used.
        /// </summary>
        private void ChangeColor()
        {
            try
            {
                Console.WriteLine("R: " + colR + " , " +
                                  "G: " + colG + " , " +
                                  "B: " + colB + " , " +
                                  "W: " + colW + " , " +
                                  "fadespeed: " + fadespeed);
                byte[] commands = { Convert.ToByte(colR),
                                Convert.ToByte(colG),
                                Convert.ToByte(colB),
                                Convert.ToByte(colW),
                                Convert.ToByte(fadespeed)};
                serialPort1.Write(commands, 0, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Change the color. All LEDs can be used.
        /// </summary>
        /// <param name="_colR">How bright the Red LEDs should shine. 0 to 255.</param>
        /// <param name="_colG">How bright the Green LEDs should shine. 0 to 255.</param>
        /// <param name="_colB">How bright the Blue LEDs should shine. 0 to 255.</param>
        /// <param name="_colW">How bright the White LEDs should shine. 0 to 255.</param>
        /// <param name="_fadespeed">How fast the color should change. 0 to 255</param>
        public void ChangeColor(int _colR, int _colG, int _colB, int _colW, int _fadespeed)
        {
            colR = _colR;
            colG = _colG;
            colB = _colB;
            colW = _colW;
            fadespeed = _fadespeed;
            try
            {
                Console.WriteLine("R: " + colR + " , " +
                                  "G: " + colG + " , " +
                                  "B: " + colB + " , " +
                                  "W: " + colW + " , " +
                                  "fadespeed: " + fadespeed);
                byte[] commands = { Convert.ToByte(colR),
                                Convert.ToByte(colG),
                                Convert.ToByte(colB),
                                Convert.ToByte(colW),
                                Convert.ToByte(fadespeed)};
                serialPort1.Write(commands, 0, 5);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Change the color. The White LEd cant be used with this Methode.
        /// </summary>
        /// <param name="_color">The color whitch the LED schould show.</param>
        public void ChangeColor(Color _color)
        {
            Color color = _color;
            colR = color.R;
            colG = color.G;
            colB = color.B;
            colW = 0;
            try
            {
                Console.WriteLine("R: " + colR + " , " +
                                  "G: " + colG + " , " +
                                  "B: " + colB + " , " +
                                  "W: " + colW + " , " +
                                  "fadespeed: " + fadespeed);
                byte[] commands = { Convert.ToByte(colR),
                                Convert.ToByte(colG),
                                Convert.ToByte(colB),
                                Convert.ToByte(colW),
                                Convert.ToByte(fadespeed)};
                serialPort1.Write(commands, 0, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Cheche the color. Calculate the average color of the bitmap.
        /// </summary>
        /// <param name="_bmp">The average color of this bitmap will be calculated</param>
        /// <param name="_piceldensity">How big the jumps from pixel to pixel are to calculate. 1 to screenresulotion.</param>
        public void ChangeColor(Bitmap _bmp, int _piceldensity)
        {
            Bitmap bmp = _bmp;
            int pixeldensity = _piceldensity;

            int cnt = 0;  // Counter for summary of pixels.
            int R = 0;  // Summary of the red part.
            int G = 0;  // Summary of the green part.
            int B = 0;  // Summary of the blue part.

            try
            {   // Go thrue the pixels of the screenshot and grab the colors.
                for (int x = 0; x < bmp.Width; x += pixeldensity)
                {
                    for (int y = 0; y < bmp.Height; y += pixeldensity)
                    {
                        Color xy = bmp.GetPixel(x, y);  // Get the color of the pixel.
                        R += xy.R;  // Add the red to the red-part-calculator.
                        G += xy.G;  // Add the green to the green-part-calculator.
                        B += xy.B;  // Add the blue to the blue-part-calculator.
                        cnt++;  // increase the counter  of the total checked pixels by one.
                    }
                }

                R = R / cnt;  // Divide the summary of the respective color part by the total counted pixels to get the average color.
                G = G / cnt;
                B = B / cnt;
                Console.WriteLine("R: " + R + " G: " + G + " B: " + B);  // Write the average color to the console for debuging.
                ChangeColor(Color.FromArgb(R, G, B));  // returne the colors in for of a Color.
                bmp.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
