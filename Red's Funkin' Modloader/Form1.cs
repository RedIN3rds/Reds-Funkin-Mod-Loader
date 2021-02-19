using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Red_s_Funkin__Modloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "cache.txt"))
            {
                switch (File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt").Length) //I hope you like lotsa spaghetti
                {
                    case 1:
                        string last_name = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt")[0];
                        string[] last_name_get = last_name.Split('\\');
                        button8.Enabled = true;
                        button7.Enabled = false;
                        button6.Enabled = false;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        label4.Enabled = false;
                        button8.Show();
                        button7.Hide();
                        button6.Hide();
                        button9.Hide();
                        button10.Hide();
                        label4.Hide();
                        button8.Text = last_name_get[last_name_get.Length - 1];
                        break;
                    case 2:
                        string[] last_name_1 = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
                        string[] last_name_get_1 = last_name_1[0].Split('\\');
                        string[] last_name_get_2 = last_name_1[1].Split('\\');
                        button8.Enabled = true;
                        button7.Enabled = true;
                        button6.Enabled = false;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        label4.Enabled = false;
                        button8.Show();
                        button7.Show();
                        button6.Hide();
                        button9.Hide();
                        button10.Hide();
                        label4.Hide();
                        button8.Text = last_name_get_1[last_name_get_1.Length - 1];
                        button7.Text = last_name_get_2[last_name_get_2.Length - 1];
                        break;
                    case 3:
                        string[] last_name_2 = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
                        string[] last_name_get_1_1 = last_name_2[0].Split('\\');
                        string[] last_name_get_2_1 = last_name_2[1].Split('\\');
                        string[] last_name_get_3_1 = last_name_2[2].Split('\\');
                        button8.Enabled = true;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        label4.Enabled = false;
                        button8.Show();
                        button7.Show();
                        button6.Show();
                        button9.Hide();
                        button10.Hide();
                        label4.Hide();
                        button8.Text = last_name_get_1_1[last_name_get_1_1.Length - 1];
                        button7.Text = last_name_get_2_1[last_name_get_2_1.Length - 1];
                        button6.Text = last_name_get_3_1[last_name_get_3_1.Length - 1];
                        break;
                    case 4:
                        string[] last_name_3 = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
                        string[] last_name_get_1_2 = last_name_3[0].Split('\\');
                        string[] last_name_get_2_2 = last_name_3[1].Split('\\');
                        string[] last_name_get_3_2 = last_name_3[2].Split('\\');
                        string[] last_name_get_4_2 = last_name_3[3].Split('\\');
                        button8.Enabled = true;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = false;
                        label4.Enabled = false;
                        button8.Show();
                        button7.Show();
                        button6.Show();
                        button9.Show();
                        button10.Hide();
                        label4.Hide();
                        button8.Text = last_name_get_1_2[last_name_get_1_2.Length - 1];
                        button7.Text = last_name_get_2_2[last_name_get_2_2.Length - 1];
                        button6.Text = last_name_get_3_2[last_name_get_3_2.Length - 1];
                        button9.Text = last_name_get_4_2[last_name_get_4_2.Length - 1];
                        break;
                    case 5:
                        string[] last_name_4 = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
                        string[] last_name_get_1_3 = last_name_4[0].Split('\\');
                        string[] last_name_get_2_3 = last_name_4[1].Split('\\');
                        string[] last_name_get_3_3 = last_name_4[2].Split('\\');
                        string[] last_name_get_4_3 = last_name_4[3].Split('\\');
                        string[] last_name_get_5_3 = last_name_4[4].Split('\\');
                        button8.Enabled = true;
                        button7.Enabled = true;
                        button6.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = true;
                        label4.Enabled = false;
                        button8.Show();
                        button7.Show();
                        button6.Show();
                        button9.Show();
                        button10.Show();
                        label4.Hide();
                        button8.Text = last_name_get_1_3[last_name_get_1_3.Length - 1];
                        button7.Text = last_name_get_2_3[last_name_get_2_3.Length - 1];
                        button6.Text = last_name_get_3_3[last_name_get_3_3.Length - 1];
                        button9.Text = last_name_get_4_3[last_name_get_4_3.Length - 1];
                        button10.Text = last_name_get_5_3[last_name_get_5_3.Length - 1];
                        break;
                    default:
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button8.Enabled = false;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        label4.Enabled = false;
                        button6.Hide();
                        button7.Hide();
                        button8.Hide();
                        button9.Hide();
                        button10.Hide();
                        label4.Show();
                        break;
                }
            }
            else 
            {
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label4.Enabled = false;
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                label4.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void Channel()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC4qZmcNf8XzM1MejRJ81v6A");
        }
        public void onLoad(string test) 
        {
            textBox1.Text = test;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    TextBox mod_Dir = textBox1;
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
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\");
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Mods");
                        Directory.CreateDirectory(backup_Dir);
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
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\music\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Music + tmp, true);
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\sounds\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Sounds + tmp, true);
                    }

                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\data\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Data + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir.Text + "\\data\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir.Text + "\\data", "");
                            File.Copy(file, asset_Data + tmp2 + tmp, true);
                        }
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\images\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Images + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir.Text + "\\images\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir.Text + "\\images", "");
                            File.Copy(file, asset_Images + tmp2 + tmp, true);
                        }
                    }
                    MessageBox.Show("Install Finished!");
                    MessageBox.Show("Opening FnF");
                    List<string> mods = new List<string>();
                    if (File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt").Length == 0 || !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "cache.txt"))
                    {
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "cache.txt", mod_Dir.Text);
                    }
                    else 
                    {
                        foreach (string line in File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt")) 
                        {
                            mods.Add(line);
                        }
                        mods.Add(mod_Dir.Text);
                        string[] final_mods = mods.ToArray();
                        if (final_mods.Length > 5) 
                        {
                            mods.Clear();
                            mods.Add(final_mods[1]);
                            mods.Add(final_mods[2]);
                            mods.Add(final_mods[3]);
                            mods.Add(final_mods[4]);
                            mods.Add(final_mods[5]);
                            final_mods = mods.ToArray();
                        }
                        File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt", final_mods);
                        MessageBox.Show("Deleted 1 of list to make room");
                    }
                    System.Diagnostics.Process.Start("Funkin.exe");
                    System.Windows.Forms.Application.Exit();
                }
                catch (Exception) 
                {
                    MessageBox.Show("Error opening mod. Is this in the correct format?");
                }
                }
            else
            {
                MessageBox.Show("No mod to load...");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\backup"))
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
                MessageBox.Show("Opening FnF");
                System.Diagnostics.Process.Start("Funkin.exe");
                System.Windows.Forms.Application.Exit();
            }
            else 
            {
                MessageBox.Show("Directory does not exist. \n Have you opened a mod before?");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "mods\\RM-Mod\\backup"))
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
            }
            else
            {
                MessageBox.Show("Directory does not exist. \n Have you opened a mod before?");
            }
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    TextBox mod_Dir = textBox1;
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
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\");
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\mods\\RM-Mod\\Mods");
                        Directory.CreateDirectory(backup_Dir);
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
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\music\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Music + tmp, true);
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\sounds\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Sounds + tmp, true);
                    }

                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\data\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Data + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir.Text + "\\data\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir.Text + "\\data", "");
                            File.Copy(file, asset_Data + tmp2 + tmp, true);
                        }
                    }
                    foreach (string asset in Directory.GetFiles(mod_Dir.Text + "\\images\\"))
                    {
                        tmp = "\\" + Path.GetFileName(asset);
                        File.Copy(asset, asset_Images + tmp, true);
                    }
                    foreach (string asset in Directory.GetDirectories(mod_Dir.Text + "\\images\\"))
                    {
                        foreach (string file in Directory.GetFiles(asset))
                        {
                            tmp = "\\" + Path.GetFileName(file);
                            tmp2 = Path.GetDirectoryName(file);
                            tmp2 = tmp2.Replace(mod_Dir.Text + "\\images", "");
                            File.Copy(file, asset_Images + tmp2 + tmp, true);
                        }
                    }
                    MessageBox.Show("Install Finished!");
                    MessageBox.Show("Opening FnF");
                    List<string> mods = new List<string>();
                    if (File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt").Length == 0 || !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "cache.txt"))
                    {
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "cache.txt", mod_Dir.Text);
                    }
                    else
                    {
                        foreach (string line in File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt"))
                        {
                            mods.Add(line);
                        }
                        mods.Add(mod_Dir.Text);
                        string[] final_mods = mods.ToArray();
                        if (final_mods.Length > 5)
                        {
                            mods.Clear();
                            mods.Add(final_mods[1]);
                            mods.Add(final_mods[2]);
                            mods.Add(final_mods[3]);
                            mods.Add(final_mods[4]);
                            mods.Add(final_mods[5]);
                            final_mods = mods.ToArray();
                        }
                        File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt", final_mods);
                        MessageBox.Show("Deleted 1 of list to make room");
                    }
                    System.Diagnostics.Process.Start("Funkin.exe");
                    System.Windows.Forms.Application.Exit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error opening mod. Is this in the correct format?");
                }
            }
            else
            {
                MessageBox.Show("No mod to load...");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[] who_am_I; // trick question, i will always be 4
            who_am_I = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
            textBox1.Text = who_am_I[4];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] who_am_I; // trick question, i will always be 0
            who_am_I = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
            textBox1.Text = who_am_I[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] who_am_I; // trick question, i will always be 1
            who_am_I = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
            textBox1.Text = who_am_I[1];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] who_am_I; // trick question, i will always be 2
            who_am_I = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
            textBox1.Text = who_am_I[2];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] who_am_I; // trick question, i will always be 3
            who_am_I = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "cache.txt");
            textBox1.Text = who_am_I[3];
        }
    }
}

