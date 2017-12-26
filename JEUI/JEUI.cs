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
                rtbOutput.Text = Encoding.Unicode.GetString(JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(rtbInput.Text, tbPassword.Text));
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
                    byte[] stream = JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(data, tbPassword.Text);
                    rtbOutput.Text = Encoding.Unicode.GetString(stream);
                    fs.Close();
                }
            }
        }
    }
}
