using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace KontaktRegistryTool
{
    public partial class MainForm : Form
    {
        private readonly BindingSource __libraryListBox_BindingSource = new BindingSource();

        private readonly List<RegistryKey> __key_List = new List<RegistryKey>(); // A List of RegistryKey used to find Kontakt Libraries.
        private readonly List<RegistryKey> __deleteKey_List = new List<RegistryKey>(); // A List of RegistryKey contains Kontakt Library information.

        public MainForm()
        {
            InitializeComponent();

            try
            {
                __key_List.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Native Instruments"));
                __key_List.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Native Instruments"));

                __deleteKey_List.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Native Instruments", true));
                __deleteKey_List.Add(Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Native Instruments", true));
                __deleteKey_List.Add(Registry.CurrentUser.OpenSubKey("SOFTWARE\\Native Instruments", true));
            }
            catch (SecurityException e)
            {
                foreach (var key in __key_List)
                {
                    key.Close();
                }

                MessageBox.Show($"{e.Message}\n请尝试使用管理员权限打开。", "Kontakt Registry Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            __key_List.RemoveAll(key => key == null);
            __deleteKey_List.RemoveAll(key => key == null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> libraryName_List = new List<string>();
            foreach (var key in __key_List)
            {
                foreach (var name in key.GetSubKeyNames())
                {
                    using var libraryKey = key.OpenSubKey(name, true);
                    if (libraryKey.GetValueNames().Contains("Visibility"))
                    {
                        if (!libraryName_List.Contains(name))
                        {
                            libraryName_List.Add(name);
                        }
                    }
                }
            }

            __libraryListBox_BindingSource.DataSource = libraryName_List;
            Libraries_ListBox.DataSource = __libraryListBox_BindingSource;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var key in __key_List)
            {
                key.Close();
            }
            foreach (var key in __deleteKey_List)
            {
                key.Close();
            }
        }

        private void DeleteLibrary_Button_Click(object sender, EventArgs e)
        {
            string name = Libraries_ListBox.SelectedItem.ToString();

            if (MessageBox.Show($"确定要移除 Library: {name} 吗 (≧﹏ ≦)", "移除 Library", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                __libraryListBox_BindingSource.Remove(name);
                foreach (var key in __deleteKey_List)
                {
                    if (key.GetSubKeyNames().Contains(name))
                    {
                        key.DeleteSubKey(name);
                    }
                }

                MessageBox.Show($"移除 Library {name} 成功 ヾ(≧▽≦*)o", "移除 Library", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
