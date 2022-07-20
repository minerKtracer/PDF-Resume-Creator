using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PDF_Resume_Creator
{
    public partial class PDFGen : Form
    {
        public PDFGen()
        {
            InitializeComponent();
        }
        public class PDFResume
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public string Year { get; set; }
            public string Course { get; set; }
            public string School1 { get; set; }
            public string Address1 { get; set; }

            public string Year1 { get; set; }
            public string School2 { get; set; }
            public string Strand { get; set; }
            public string Address2 { get; set; }

            public string Year2 { get; set; }
            public string School3 { get; set; }
            public string Address3 { get; set; }

            public string Year3 { get; set; }
            public string School4 { get; set; }
            public string Address4 { get; set; }

            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Skill4 { get; set; }
            public string Skill5 { get; set; }
            public string Achievement1 { get; set; }
            public string Achievement2 { get; set; }
            public string Achievement3 { get; set; }
            public string Achievement4 { get; set; }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            var pathOfJSONFile = @"C:\Users\kylene shane varona\Desktop\ASSIGNMENT 6\PDF Resume Creator\PDF Resume Creator\pdfresume.json";
            string jsonReadFile = File.ReadAllText(pathOfJSONFile);
            ReadBx.Text = jsonReadFile;
        }

        private void Convert_Click(object sender, EventArgs e)
        {

        }
    }
}
