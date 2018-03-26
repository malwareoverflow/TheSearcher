using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryIterator
{
    public partial class TheSearcher : Form,IDisposable

    {
        // This delegate enables asynchronous calls for setting  
        // the text property on a TextBox control.  
        delegate string StringArgReturningVoidDelegate();
        private delegate void SetDataSourceDelegate(object value);

      //  delegate void  StringArgReturningVoidDelegate(string text);

        List<string> ChoiceExtension = new List<string>();

        List<string> File = new List<string>();
        List<string> Directories = new List<string>();

        public Thread Startthread;
        string requirefilename;
        string requirefileextension;
        int TotalDirectories = 0;
        public TheSearcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
               string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
              Path.Text   = folderBrowserDialog1.SelectedPath;

            }
        }
        public void AddDir(string[] Dir)
        {
            try
            {
                foreach (string item in Dir)
                {
                    TotalDirectories += 1;

                    Directories.Add(item);
                }
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
           
        }
        public bool AddFiles(string[] Files)
        {
            try
            {
                foreach (string item in Files)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(item);
                    string extension = System.IO.Path.GetExtension(item);
                    if ($"{filename}{extension}"==$"{requirefilename}.{requirefileextension}")
                    {
                        MessageBox.Show($"File found inside {item.ToString()}");
                      
                        return true;
                    }
                    File.Add(item);
                
                }
                return false;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return false;
            }
           
        }
       
        public bool IsDirectoryEmpty(string path)
        {
            try
            {
                return !Directory.EnumerateFileSystemEntries(path).Any();

            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return true;
            }
        }
        public void Recursive(List<string> Dirs)
        {
            bool FileFound = false;
            try
            {
                for (var x = 0; x < Dirs.Count; x++)
                {
                    if (IsDirectoryEmpty(Directories[x]) == false)
                    {

                        AddDir(Directory.GetDirectories(Directories[x]));
                        if (AddFiles(Directory.GetFiles(Directories[x])))
                        {
                            FileFound = true;
                            break;
                        }
                        else
                        {
                            AddFiles(Directory.GetFiles(Directories[x]));
                        }
                        


                    }
                    Directories.Remove(Directories[x]);
                }
                if (Directories.Count > 0 && FileFound==false)
                {
                    Recursive(Directories);
                }
            }
            catch (Exception ex)
            {

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
           
        }
        public void ShowAllFiles()
        {
            try
            {
               // MessageBox.Show($"Total files were {File.Count} and Total Directories were  {TotalDirectories}");
                foreach (var item in File)
                {
                    if (System.IO.Path.GetFileName(item) == Searchvalue.Text)
                    {
                        MessageBox.Show($"File exist inside {item}");

                        if (Deletechoice.Checked)
                        {
                            DialogResult result = MessageBox.Show($"Do you want to detele {item}", "Confirmation", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                               System.IO.File.Delete(item);

                                MessageBox.Show($"{item} Deleted");

                            }
                           
                           

                        }
                        return;
                    }
                    if (Extensionvalue.Text!= "")
                    {
                        string ext = "."+GetExtensionvalue();
                        string filename = System.IO.Path.GetFileName(item);
                        string pathext = System.IO.Path.GetExtension(filename);
                      
                        if(pathext == ext)
                        {
                            ChoiceExtension.Add(item);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
           
        }
        public void Start()
        {
            try
            {
                if (IsDirectoryEmpty(Path.Text) == false)
                {

                    AddDir(Directory.GetDirectories(Path.Text));
                    AddFiles(Directory.GetFiles(Path.Text));

                    Recursive(Directories);

                    //ShowAllFiles();
                    //InserttoGrid(ChoiceExtension);
                    //this.Dispose();
                    MessageBox.Show("Done");
                 
                    //timer1.Stop();
                    //timer1.Enabled = false;
               
                        
                }
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                MessageBox.Show(ex.ToString());

            }

        }
       
        private string GetExtensionvalue()
        {
            string text="null";
            try
            {
                if (this.Extensionvalue.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(GetExtensionvalue);
                    Extensionvalue.Invoke(new MethodInvoker(delegate { text = Extensionvalue.Text; }));
                    
                    return text;

                }
                else
                {
                    return text;
                }
            }
            catch (Exception ex)
            {
             
                GC.Collect();
                GC.WaitForPendingFinalizers();
                MessageBox.Show(ex.ToString());

                return this.Extensionvalue.Text;


            }
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  

        }
        //private void SetLabel(string text)
        //{
        //    // InvokeRequired required compares the thread ID of the  
        //    // calling thread to the thread ID of the creating thread.  
        //    // If these threads are different, it returns true.  
        //    if (this.Timer.InvokeRequired)
        //    {
        //        StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetLabel);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.Timer.Text = text;
        //    }
        //}

        private void SetDataSource(object value)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Path of Extension");
            foreach (var item in value as List<string>)
            {

                dt.Rows.Add(new object[] { item });

            }
            ExtensionList.DataSource = dt;
            DataGridViewColumn secondcolumn = ExtensionList.Columns[0];
            secondcolumn.Width = 385;
        }
        public void  InserttoGrid(List<string> List)
        {
            if (ChoiceExtension.Count >0)
            {

                if (this.ExtensionList.InvokeRequired)
                {
                   ExtensionList.Invoke(new SetDataSourceDelegate(SetDataSource), new Object[] { List });


                }
                else
                {
                    SetDataSource(List);

                }

            }
        }

        private void Timertick(object sender, EventArgs e)
        {

            this.Timer.BeginInvoke((MethodInvoker)delegate () { this.Timer.Text = DateTime.Now.ToString("HH:mm:ss tt"); });
          
        }

        public void Panelcontrols(bool Enable)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Enabled = Enable;
            }
        }
       

        private void Start(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
            requirefilename = Searchvalue.Text;
            requirefileextension = Extensionvalue.Text;
            timer1.Enabled = true;
            timer1.Start();
            Startthread = new Thread(new ThreadStart(Start));
            Startthread.IsBackground = true;
            Startthread.Start();
        }
    }
}
