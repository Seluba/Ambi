using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Ambient_Light
{
    class XMLOrganizer
    {
        // ***************************************************************
        // *** definies & enums ***

        public enum startupactions : int { off, color, mode };
        public enum startupcolors : int { red, green, blue, white, cutom };
        public enum startupmodes : int { live, colorflow };

        public startupactions StartupActions { get; }
        public startupcolors Colors { get; }
        public startupmodes Modes { get; }


        // ***************************************************************
        // *** properties ***

        private bool useallscreens = false;
        private int usedscreens = 1;
        private int fadespeed = 0;
        private bool startminimized = false;
        private bool startonstartup = false;
        private int startupaction = Convert.ToInt32(startupactions.color);
        private int startupcolor = Convert.ToInt32(startupcolors.white);
        private int colorred = 0;
        private int colorgreen = 0;
        private int colorblue = 0;
        private int coloralpha = 0;
        private int startupmode = Convert.ToInt32(startupmodes.colorflow);

        private string xmlpath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\AmbiSetup.xml";
        private XmlDocument xmldoc = new XmlDocument();
        private XmlNode xmlnode;


        // ***************************************************************
        // *** constructors ***

        /// <summary>
        /// Basic constructor. Allowes the user to set a manual path of the XML.
        /// </summary>
        /// <param name="_xmlpath"></param>
        public XMLOrganizer(string _xmlpath = null)
        {
            if (_xmlpath != null)
            {
                xmlpath = _xmlpath;
            }
        }


        // ***************************************************************
        // *** Get / Set ***

        public bool UseAllScreens
        {
            get { return (useallscreens); }
        }

        public int UsedScreen
        {
            get { return (usedscreens); }
        }

        public int FadeSpeed
        {
            get { return (fadespeed); }
        }

        public bool StartMinimized
        {
            get { return (startminimized); }
        }

        public bool StartOnStartup
        {
            get { return (startonstartup); }
        }

        public int StartupAction
        {
            get { return (startupaction); }
        }

        public int Color
        {
            get { return (startupcolor); }
        }

        public int Mode
        {
            get { return (startupmode); }
        }


        // ***************************************************************
        // *** methods ***

        /// <summary>
        /// Load the XML File and set the xmlnode to the root node.
        /// </summary>
        private void XMLOpen()
        {
            try
            {
                if (File.Exists(xmlpath) == true)
                {
                    xmldoc.Load(xmlpath);
                    xmlnode = xmldoc.DocumentElement.SelectSingleNode("/root");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void XMLLoad()
        {
            try
            {
                xmlnode = xmlnode.SelectSingleNode("/root/startup/useallscreens");
                useallscreens = Convert.ToBoolean(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/usedscreens");
                usedscreens = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startonstartup");
                startonstartup = Convert.ToBoolean(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/fadespeed");
                fadespeed = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupaction");
                startupaction = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor");
                startupcolor = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupmode");
                startupmode = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor/colortype");
                startupcolor = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor/color/red");
                colorred = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor/color/green");
                colorgreen = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor/color/blue");
                colorblue = Convert.ToInt32(xmlnode.InnerText);
                xmlnode = xmlnode.SelectSingleNode("/root/startup/startupcolor/color/ralpha");
                coloralpha = Convert.ToInt32(xmlnode.InnerText);
            }
            catch
            {

            }
        }

        public void XMLSave(bool _useallscreens, int _usedscreens, int _fadespeed, bool _startminimized, bool _startonstartup, int _startupaction, int _color, int _mode)
        {
            useallscreens = _useallscreens;
            usedscreens = _usedscreens;
            fadespeed = _fadespeed;
            startminimized = _startminimized;
            startonstartup = _startonstartup;
            startupaction = _startupaction;
            startupcolor = _color;
            startupmode = _mode;
        }

    }
}
