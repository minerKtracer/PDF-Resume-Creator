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
            public string Name { get; set; }
            public string Specification { get; set; }
            public string PNumber { get; set; }
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
            try
            {
                var pathOfJSONFile = @"C:\Users\kylene shane varona\Desktop\ASSIGNMENT 6\PDF Resume Creator\PDF Resume Creator\pdfresume.json";
                string jsonReadFile = File.ReadAllText(pathOfJSONFile);
                PDFResume convert = JsonConvert.DeserializeObject<PDFResume>(jsonReadFile);
                FirstName1.Text = convert.FirstName + " " + convert.LastName;
                BasicDetails3.Text = convert.PhoneNumber + "\n" + convert.Email + "\n" + convert.Address + "\n";
                Education8.Text = convert.Year + " " + convert.Course + "\n" + convert.School1 + "\n" + convert.Address1 + "\n" + "\n" + convert.Year1 + " " + convert.School2 + "\n" + convert.Strand + "\n" + convert.Address2 + "\n" + "\n" + convert.Year2 + " " + convert.School3 + "\n" + convert.Address3 + "\n" + "\n" + convert.Year3 + " " + convert.School4 + "\n" + convert.Address4 + "\n";
                skills5.Text = convert.Skill1 + "\n" + convert.Skill2 + "\n" + convert.Skill3 + "\n" + convert.Skill4 + "\n" + convert.Skill5 + "\n";
                achievements6.Text = convert.Achievement1 + "\n" + convert.Achievement2 + "\n" + convert.Achievement3 + "\n" + convert.Achievement4 + "\n";
                CharR.Text = convert.Name + "\n" + convert.Specification + "\n" + convert.PNumber + "\n";
            }
            catch (Exception)
            {

            }
        }

        private void Gpdf_Click(object sender, EventArgs e)
        {
            Document docx = new Document();
            PdfWriter.GetInstance(docx, new FileStream(@"C:\Users\kylene shane varona\Desktop\ASSIGNMENT 6\PDF Resume Creator\PDF Resume Creator\pdfresume.pdf", FileMode.Create));
            docx.Open();
            Chunk Sline = new Chunk("______________________________________________________________________________");
            Paragraph FirstName = new Paragraph(FirstName1.Text, FontFactory.GetFont("Arial", 25));
            Paragraph BD = new Paragraph(BasicDetails3.Text, FontFactory.GetFont("Arial", 8));
            Paragraph edu = new Paragraph("Education", FontFactory.GetFont("Arial", 20));
            Paragraph ed = new Paragraph(Education8.Text, FontFactory.GetFont("Arial", 12));
            Paragraph skills = new Paragraph("Skills", FontFactory.GetFont("Arial", 20));
            Paragraph skill = new Paragraph(skills5.Text, FontFactory.GetFont("Arial", 12));
            Paragraph ACS = new Paragraph("Achievements", FontFactory.GetFont("Arial", 20));
            Paragraph AC = new Paragraph(achievements6.Text, FontFactory.GetFont("Arial", 12));
            Paragraph CRS = new Paragraph("Character References", FontFactory.GetFont("Arial", 20));
            Paragraph CR = new Paragraph(CharR.Text, FontFactory.GetFont("Arial", 12));
            docx.Add(FirstName);
            docx.Add(BD);
            docx.Add(Sline);
            docx.Add(edu);
            docx.Add(ed);
            docx.Add(Sline);
            docx.Add(skills);
            docx.Add(skill);
            docx.Add(Sline);
            docx.Add(ACS);
            docx.Add(AC);
            docx.Add(Sline);
            docx.Add(CRS);
            docx.Add(CR);
            docx.Close();

            MessageBox.Show("Done");
        }
    }
}
