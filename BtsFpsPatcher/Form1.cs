using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BtsFpsPatcher
{
    public partial class Form1 : Form
    {
        private static Form1 form = null;

        public Form1()
        {
            InitializeComponent();
            Version ver = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = this.Text + " v" + ver.Major + "." + ver.Minor + (ver.Build.ToString() == "0" ? "" : "." + ver.Build.ToString());
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            form = this;
        }

        public static float GetFPSLimit()
        {
            float index = -1;
            form.StatusText.Invoke((MethodInvoker)(() => { index = (float)form.numericUpDown1.Value; }));
            return index;
        }

        public static void IncrementProgress(int value)
        {
            form.progressBar1.Invoke((MethodInvoker)(() => { form.progressBar1.Increment(value); }));
        }

        public static void SetProgress(int value, Color? color = null)
        {
            form.progressBar1.Invoke((MethodInvoker)(() => { form.progressBar1.Value = value; }));
            form.progressBar1.Invoke((MethodInvoker)(() => { form.progressBar1.ForeColor = color.GetValueOrDefault(Color.Green); }));
        }

        public static void SetStatus(string status, Color color)
        {
            form.StatusText.Invoke((MethodInvoker)(() => { form.StatusText.Text = status; }));
            form.StatusText.Invoke((MethodInvoker)(() => { form.StatusText.ForeColor = color; }));
        }

        public void CheckStatus()
        {
            if (File.Exists(this.PathBox.Text))
            {
                this.StatusText.Text = "Ejecutable detectado";
                this.StatusText.ForeColor = Color.YellowGreen;
                this.PatchButton.Enabled = true;
                this.progressBar1.Value = 0;
            }
            else
            {
                this.StatusText.Text = "Esperando...";
                this.StatusText.ForeColor = Color.Blue;
                this.PatchButton.Enabled = false;
                this.progressBar1.Value = 0;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

            //Modificado por Baip | https://github.com/baip49, https://usecodebaip.com
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta completa del archivo seleccionado
                    string selectedFilePath = openFileDialog.FileName;
                    // Establece el valor del TextBox con la ruta del archivo seleccionado
                    PathBox.Text = selectedFilePath;
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.PathBox.Text = files[0];
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1 && Path.GetExtension(files[0]) == ".exe" && Path.GetFileName(files[0]) == PathBox.Text)
                    e.Effect = DragDropEffects.Copy;
            }
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            if (!PatchWorker.IsBusy)
            {
                PatchButton.Enabled = false;
                PatchWorker.RunWorkerAsync();
            }
        }

        private void PatchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.PatchFunction(this.PathBox.Text);
            SetProgress(100);
            form.PatchButton.Invoke((MethodInvoker)(() => { form.PatchButton.Enabled = true; }));
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void ResolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckStatus();
            Console.WriteLine(numericUpDown1.Value);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el link.");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://usecodebaip.com");
        }
    }
}