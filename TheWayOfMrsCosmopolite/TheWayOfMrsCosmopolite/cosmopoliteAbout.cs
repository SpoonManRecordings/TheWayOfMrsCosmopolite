using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWayOfMrsCosmopolite
{
    partial class cosmopoliteAbout : Form
    {
        public cosmopoliteAbout()
        {
            InitializeComponent();
            this.Text = String.Format("About");
            this.labelProductName.Text = "The Way Of Mrs Cosmopolite";
            this.labelVersion.Text = String.Format("Version 1.042");
            this.labelCopyright.Text = "© 2018 Dan Ladle";
            this.labelCompanyName.Text = "LadleWritings";
            this.textBoxDescription.Text = "Mrs Cosmopolite, The Way of Mrs Cosmopolite and HEX are © Sir Terry Pratchett OBE.\r\n\r\nTheWayOfMrsCosmopolite was developed and coded by Dan Ladle, additional material was devised and written by Dan.\r\n\r\n#GNUTerryPratchett";
        }
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void helpButton_Click(object sender, EventArgs e)
        {
            string[] copyString = { "Message\r \n", "Buttock Prodding Message\r \n", "Motivational Message\r \n", "This Prod\r \n", "Message\r \n" };
            string[] newString = { "For A New Motivational Buttock Prodding Message...", "For A New Motivational Message...", "For A New Buttock Prodding Message...", "To Prod Some More Buttock...", "For A New Message...\r \n" + "What do you need, an invitation?" };
            Random rndNum;
            rndNum = new Random();
            int copyNumber = rndNum.Next(1, copyString.Length);
            int newNumber = rndNum.Next(1, newString.Length);
            MessageBox.Show("Click To Copy " + copyString[copyNumber] + "Double Click " + newString[newNumber], "!!! Help !!!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
