using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Library;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel worksheets | *.xlsx"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                string path = dialog.FileName; // get name of file
                SourceFilePathTextBox.Text = path;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SourceFilePathTextBox.Text))
            {
                MessageBox.Show("Выберите исходный файл!");
                return;
            }

            if (string.IsNullOrWhiteSpace(DestinationFilePathTextBox.Text))
            {
                MessageBox.Show("Выберите путь сохранения полученных данных!");
                return;
            }

            AllocConsole();

            IpAddressesDataRetriever.GetDataAndSaveToExcel(SourceFilePathTextBox.Text,
                DestinationFilePathTextBox.Text);

            FreeConsole();

            MessageBox.Show("Завершено");
        }

        private void DestinationFileBrowseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel worksheets | *.xlsx"; // file types, that will be allowed to upload
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                string path = dialog.FileName; // get name of file
                DestinationFilePathTextBox.Text = path;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

    }
}
