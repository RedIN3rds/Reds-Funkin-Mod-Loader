using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace Red_s_Funkin__Modloader
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public int lastdir;
        public string[] dirname;
        public object[] mods;
        public List<string> alist = new List<string>();
        public List<string> blist = new List<string>();
        public Form1()
        {
            if (instance == null) { instance = this; }
            InitializeComponent();
            this.BackColor = Color.FromArgb(47, 66, 107);
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\backup");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Tools");
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/824439385708953602/824439420568600617/prev.jpg"), AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\prev.jpg");
                    client.DownloadFile(new Uri("https://github.com/RedIN3rds/Reds-Funkin-JSON-Generator/releases/download/Alpha/Debug.zip"), AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Tools\\tool.zip");
                    ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Tools\\tool.zip", AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Tools\\");
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Tools\\tool.zip");
                }
            }
            foreach (string file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods")) 
            {
                if (file.Contains(".rml")) { Translate(file); }
            }
            for (int i = 0; i < Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods").Length; i++)
            {
                CheckBox newButton = new CheckBox();
                newButton.Text = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods")[i].Replace(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods\\", ""); 
                newButton.Tag = i;
                newButton.Location = new Point(20, 30 * i + 10);
                newButton.Click += new EventHandler(toggle);
                panel1.Controls.Add(newButton);
            }
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            panel2.AutoScroll = true;
        }
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Channel();
            }
            catch (Exception oof)
            {
                MessageBox.Show($"Link was not funkin'... \n Error:{oof}");
            }
        }
        private void Translate(string modDir) 
        {
            File.Move(modDir, modDir.Replace(".rml", ".zip"));
            if (File.Exists(modDir)) 
            {
                File.Delete(modDir);
            }
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\mods\\" + modDir.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods\\", "").Replace(".rml", ".zip").Replace(".zip", ""));
            ZipFile.ExtractToDirectory(modDir.Replace(".rml", ".zip"), AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\mods\\" + modDir.Replace(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods\\", "").Replace(".rml",".zip").Replace(".zip", ""));
            if (File.Exists(modDir.Replace(".rml", ".zip")))
            {
                File.Delete(modDir.Replace(".rml", ".zip"));
            }
        }
        private void Channel()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC4qZmcNf8XzM1MejRJ81v6A");
        }
        private void Install()
        {
            int totalmods = 0;
            int modssel = 0;
            foreach (CheckBox check in panel1.Controls) { if (check.Checked) { modssel++; } }
            foreach (object id in mods) {
                totalmods++;
                string mod_Dir = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\mods")[Int32.Parse(id.ToString())];
                try
                {
                    string tmp = "";
                    string tmp2 = "";
                    string asset_Dir = AppDomain.CurrentDomain.BaseDirectory + "\\assets";
                    string asset_Images = asset_Dir + "\\images";
                    string[] asset_Images_Sub = { "\\christmas", "\\limo", "\\pauseAlt", "\\philly", "\\weeb" };
                    string asset_Music = asset_Dir + "\\music";
                    string asset_Sounds = asset_Dir + "\\sounds";
                    string asset_Data = asset_Dir + "\\data";
                    string[] asset_Data_Sub = { "\\blammed", "\\bopeebo", "\\cocoa", "\\dadbattle", "\\eggnog", "\\fresh", "\\high", "\\milf", "\\monster", "\\philly", "\\pico", "\\ridge", "\\roses", "\\satin-panties", "\\senpai", "\\smash", "\\south", "\\spookeez", "\\thorns", "\\tutorial", "\\winter-horrorland" };
                    string backup_Dir = AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\backup";
                    var asset_subdir = Directory.GetDirectories(asset_Dir);
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\backup\\data"))
                    {
                        Directory.CreateDirectory(backup_Dir + "\\data");
                        Directory.CreateDirectory(backup_Dir + "\\images");
                        Directory.CreateDirectory(backup_Dir + "\\music");
                        Directory.CreateDirectory(backup_Dir + "\\sounds");
                    }
                    if (!Directory.Exists(backup_Dir + "\\data\\blammed"))
                    { //Note: This "Catch-All" may be bugged in future versions
                        foreach (string dir in asset_Data_Sub)
                        {
                            Directory.CreateDirectory(backup_Dir + "\\data" + dir);
                        }
                        foreach (string dir in asset_Images_Sub)
                        {
                            Directory.CreateDirectory(backup_Dir + "\\images" + dir);
                        }
                        foreach (string asset in Directory.GetFiles(asset_Music))
                        {
                            tmp = asset.Replace(asset_Music, "");
                            File.Copy(asset, backup_Dir + "\\music" + tmp, true);
                        }
                        foreach (string asset in Directory.GetFiles(asset_Sounds))
                        {
                            tmp = asset.Replace(asset_Sounds, "");
                            File.Copy(asset, backup_Dir + "\\sounds" + tmp, true);
                        }
                        foreach (string asset in Directory.GetFiles(asset_Data))
                        {
                            tmp = asset.Replace(asset_Data, "");
                            File.Copy(asset, backup_Dir + "\\data" + tmp, true);
                        }
                        foreach (string asset in Directory.GetDirectories(asset_Data))
                        {
                            foreach (string file in Directory.GetFiles(asset))
                            {
                                tmp = file.Replace(asset_Data, "");
                                File.Copy(file, backup_Dir + "\\data" + tmp, true);
                            }
                        }
                        foreach (string asset in Directory.GetFiles(asset_Images))
                        {
                            tmp = asset.Replace(asset_Images, "");
                            File.Copy(asset, backup_Dir + "\\images" + tmp, true);
                        }
                        foreach (string asset in Directory.GetDirectories(asset_Images))
                        {
                            foreach (string file in Directory.GetFiles(asset))
                            {
                                tmp = file.Replace(asset_Images, "");
                                File.Copy(file, backup_Dir + "\\images" + tmp, true);
                            }
                        }
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\music\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Music + tmp, true);
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\sounds\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Sounds + tmp, true);
                    }

                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\data\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Data + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir + "\\data\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir + "\\data", "");
                            File.Copy(file, asset_Data + tmp2 + tmp, true);
                        }
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\images\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Images + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir + "\\images\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir + "\\images", "");
                            File.Copy(file, asset_Images + tmp2 + tmp, true);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error opening mod." + "\n" + e.Message);
                }
            }
            MessageBox.Show("Installed " + modssel + " of " + totalmods);
        }
        private void restore()
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\backup"))
            {
                try
                {
                    string mod_Dir = AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\backup";
                    string tmp = "";
                    string tmp2 = "";
                    string asset_Dir = AppDomain.CurrentDomain.BaseDirectory + "\\assets";
                    string asset_Images = asset_Dir + "\\images";
                    string[] asset_Images_Sub = { "\\christmas", "\\limo", "\\pauseAlt", "\\philly", "\\weeb" };
                    string asset_Music = asset_Dir + "\\music";
                    string asset_Sounds = asset_Dir + "\\sounds";
                    string asset_Data = asset_Dir + "\\data";
                    string[] asset_Data_Sub = { "\\blammed", "\\bopeebo", "\\cocoa", "\\dadbattle", "\\eggnog", "\\fresh", "\\high", "\\milf", "\\monster", "\\philly", "\\pico", "\\ridge", "\\roses", "\\satin-panties", "\\senpai", "\\smash", "\\south", "\\spookeez", "\\thorns", "\\tutorial", "\\winter-horrorland" };
                    string backup_Dir = AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\backup";
                    var asset_subdir = Directory.GetDirectories(asset_Dir);
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\music\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Music + tmp, true);
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\sounds\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Sounds + tmp, true);
                    }

                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\data\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Data + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir + "\\data\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir + "\\data", "");
                            File.Copy(file, asset_Data + tmp2 + tmp, true);
                        }
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir + "\\images\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Images + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir + "\\images\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir + "\\images", "");
                            File.Copy(file, asset_Images + tmp2 + tmp, true);
                        }
                    }
                    MessageBox.Show("Restore Finished!");
                } catch (Exception)
                {
                    MessageBox.Show("Directory does not exist. \n Have you opened a mod before?");
                }
            }
            else 
            {
                MessageBox.Show("Directory does not exist.\nHave you opened a mod before?");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh() 
        {
            panel1.Controls.Clear();
            for (int i = 0; i < Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods").Length; i++)
            {
                CheckBox newButton = new CheckBox();
                newButton.Text = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods")[i].Replace(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods\\", ""); ;
                newButton.Tag = i;
                newButton.Location = new Point(20, 30 * i + 10);
                newButton.Click += new EventHandler(toggle);
                panel1.Controls.Add(newButton);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (100);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string[] dir = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods");
            if (dir.Length != lastdir) 
            {
                refresh();
                lastdir = dir.Length;
            }
            foreach (string file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods"))
            {
                if (file.Contains(".rml")) { Translate(file); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            foreach (CheckBox check in panel1.Controls) 
            {
                if (check.CheckState == CheckState.Checked) {
                    list.Add(check.Tag);
                }
            }
            mods = list.ToArray();
            Install();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        public void toggle(object sender, System.EventArgs e)
        {
            foreach (CheckBox check in panel1.Controls)
            {
                if (check.CheckState == CheckState.Checked)
                {
                    if (!alist.Contains(check.Tag.ToString()))
                    {
                        alist.Add(check.Tag.ToString());
                        try
                        {
                            panel2.Controls.Clear();
                            panel3.Controls.Clear();
                            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(File.ReadAllText(Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods")[Int32.Parse(check.Tag.ToString())] + "\\" + "Info.json"));
                            List<string> jsondata = new List<string>();
                            jsondata.Add(myDeserializedClass.name);
                            if (myDeserializedClass.name == "red" + "lolmod") 
                            {
                                panel1.BackColor = Color.FromArgb(255, 0, 0);
                                panel2.BackColor = Color.FromArgb(255, 0, 0);
                                panel3.BackColor = Color.FromArgb(255, 0, 0);
                                panel4.BackColor = Color.FromArgb(133, 0, 0);
                                Form1.instance.BackColor = Color.FromArgb(56, 0, 0);
                                button1.BackColor = Color.FromArgb(255, 0, 0);
                                button2.BackColor = Color.FromArgb(255, 0, 0);
                                button4.BackColor = Color.FromArgb(255, 0, 0);
                            }
                            jsondata.Add(myDeserializedClass.description);
                            jsondata.Add(myDeserializedClass.mod);
                            jsondata.Add(myDeserializedClass.author);
                            foreach (string u in myDeserializedClass.tags)
                            {
                                jsondata.Add(u);
                            }
                            for (int i = 0; i < 4 + myDeserializedClass.tags.ToArray().Length; i++)
                            {
                                if (i != 1)
                                {
                                    Label newButton = new Label();
                                    newButton.TextAlign = ContentAlignment.MiddleCenter;
                                    newButton.Location = new Point(100, 30 * i + 10);
                                    newButton.Text = jsondata.ToArray()[i];
                                    newButton.AutoSize = true;
                                    newButton.Tag = i;
                                    panel2.Controls.Add(newButton);
                                }
                                else
                                {
                                    TextBox newButton = new TextBox();
                                    newButton.Location = new Point(100, 20 * i + 7);
                                    newButton.Height = 40;
                                    newButton.Width = 155;
                                    newButton.ReadOnly = true;
                                    newButton.Text = jsondata.ToArray()[i];
                                    newButton.Multiline = true;
                                    newButton.ScrollBars = ScrollBars.Vertical;
                                    newButton.Tag = i;
                                    panel2.Controls.Add(newButton);
                                }
                            }
                            for (int i = 0; i < 4 + myDeserializedClass.tags.ToArray().Length; i++)
                            {
                                Label newButton = new Label();
                                newButton.TextAlign = ContentAlignment.MiddleCenter;
                                newButton.Location = new Point(0, 30 * i + 5);
                                switch (i)
                                {
                                    case 0:
                                        newButton.Text = "Name:";
                                        break;
                                    case 1:
                                        newButton.Text = "Description:";
                                        break;
                                    case 2:
                                        newButton.Text = "Mod Type:";
                                        break;
                                    case 3:
                                        newButton.Text = "Author:";
                                        break;
                                    default:
                                        newButton.Text = "Tag:";
                                        break;
                                }
                                newButton.Tag = i;
                                panel2.Controls.Add(newButton);
                            }
                            PictureBox news = new PictureBox();
                            try
                            {
                                news.Image = Image.FromFile(Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\mods")[Int32.Parse(check.Tag.ToString())] + "\\prev.jpg");
                            }
                            catch (Exception)
                            {
                                news.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\prev.jpg");
                            }
                            news.Location = new Point(0, 0);
                            news.Size = new Size(300, 170);
                            panel3.Controls.Add(news);
                        }
                        catch (Exception b)
                        {
                            MessageBox.Show("Mod is broken. Is it in the right format? \n" + b.Message);
                        }
                        return;
                    }
                }
                else
                {
                    alist.Remove(check.Tag.ToString());
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class Root
    {
        public string name { get; set; }
        public string author { get; set; }
        public string mod { get; set; }
        public string description { get; set; }
        public List<string> tags { get; set; }
    }
}

