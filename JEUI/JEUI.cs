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

namespace JEUI
{
    public partial class JEUI : Form
    {
        public JEUI()
        {
            InitializeComponent();
            tbPassword.TextChanged += tbPasswordTextChanged;
        }

        private void tbPasswordTextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEncryptClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbInput.Text))
            {
                rtbOutput.Text = Encoding.Unicode.GetString(JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Encrypt(rtbInput.Text, tbPassword.Text));
            }
        }

        private void btnDecryptClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbInput.Text))
            {
                object exData;
                rtbOutput.Text = Encoding.Unicode.GetString(JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(rtbInput.Text, tbPassword.Text, out exData));
            }
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = "c:\\";
                sfd.Filter = "JED File|*.JED";
                sfd.RestoreDirectory = true;
                sfd.FilterIndex = 1;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    byte[] stream = JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Encrypt(rtbInput.Text, tbPassword.Text);
                    fs.Write(stream, 0, stream.Length);
                    fs.Close();
                }
            }
        }

        private void btnImportClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "JED File|*.JED";
                ofd.RestoreDirectory = true;
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                    object exData;
                    byte[] stream = JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(data, tbPassword.Text, out exData);
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.InitialDirectory = "c:\\";
                    sfd.Filter = "TXT File|*.txt";
                    sfd.RestoreDirectory = true;
                    sfd.FilterIndex = 1;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream sfs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                        StreamWriter sw = new StreamWriter(sfs);
                        sw.Write(Encoding.Unicode.GetString(stream));
                        sw.Close();
                        sfs.Close();
                    }
                    rtbOutput.Text = Encoding.Unicode.GetString(stream);
                    fs.Close();
                }
            }
        }

        private void btnEncryptFileClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "All File|*.*";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                object exData;
                byte[] stream = JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(data, tbPassword.Text, out exData);
                SaveFileDialog sfd = new SaveFileDialog();
            }
        }

        private void btnDecryptFileClick(object sender, EventArgs e)
        {

        }
    }
}
