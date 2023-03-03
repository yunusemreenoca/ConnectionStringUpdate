using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ConnectionStringUpdate
{
    public partial class Form1 : Form
    {
        string file = string.Empty;
        string prodFile = string.Empty;
        string testFile = string.Empty;
        string devFile = string.Empty;
        string solitonRoute = string.Empty;
        public Form1()
        {
            InitializeComponent();
            solitonRoute = ConfigurationManager.AppSettings["solutionroute"];
        }        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            DirectoryInfo fileData = new DirectoryInfo(solitonRoute);
            FileInfo[] files = fileData.GetFiles();

            foreach (FileInfo item in files)
            {

                if (item.Name.Equals("appsettings.json"))
                {
                    file = item.FullName; break;
                }
            }
            SourceFileSelect(files);

            ControlRadio();
        }

        private void ControlRadio()
        {
            if (radioDev.Checked)
            {
                UpdateDatabaseConnectionString(file, devFile);
            }
            else if (radioProd.Checked)
            {
                UpdateDatabaseConnectionString(file, prodFile);
            }
            else
            {
                UpdateDatabaseConnectionString(file, testFile);
            }
        }

        string SourceFileSelect(FileInfo[] files)
        {



            if (radioDev.Checked)
            {
                devFile = files.FirstOrDefault(x => x.Name == "appsettings.dev.json").FullName.ToString();
                return devFile;
            }
            else if (radioProd.Checked)
            {
                prodFile = files.FirstOrDefault(x => x.Name == "appsettings.prod.json").FullName.ToString();
                return prodFile;
            }
            else
            {
                testFile = files.FirstOrDefault(x => x.Name == "appsettings.test.json").FullName.ToString();
                return testFile;
            }


        }
        private void UpdateDatabaseConnectionString(string path, string sourcePath)
        {
            // Dosya var mı yok mu kontrol ediyoruz
            if (!File.Exists(path))
            {
                MessageBox.Show("Dosya bulunamadı");
                return;
            }
            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("Dosya bulunamadı");
                return;
            }
            // Dosyadaki tüm metni okuyoruz
            string targetJson = File.ReadAllText(path);

            string sourceJson = File.ReadAllText(sourcePath);





            // JSON dosyasını güncelliyoruz

            File.WriteAllText(path, sourceJson);

            richTextBox1.Text = targetJson;
            richTextBox2.Text = sourceJson;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}