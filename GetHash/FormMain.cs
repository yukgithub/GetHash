using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GetHash
{
    /// <summary>
    /// FormMain Class
    /// </summary>
    public partial class FormMain : System.Windows.Forms.Form
    {
        /// <summary>
        /// Algorithms
        /// </summary>
        private enum enumAlgorithm
        {
            MD5 = 0,
            SHA1 = 1,
            SHA256 = 2,
            SHA384 = 3,
            SHA512 = 4
        }

        /// <summary>
        /// Initialize
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCompare_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCompare.Checked)
            {
                this.txtCompareHash.Enabled = true;
                this.lblResult.Visible = true;
                this.lblCompareHash.Enabled = true;
            }
            else
            {
                this.txtCompareHash.Text = string.Empty;
                this.txtCompareHash.Enabled = false;
                this.lblResult.Visible = false;
                this.lblCompareHash.Enabled = false;
            }
        }

        /// <summary>
        /// Select file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                this.txtCharas.Text = dialog.FileName;
            }

            this.SetCompareHash();
        }

        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoMD5_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCompareHash();
        }

        /// <summary>
        /// SHA1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSHA1_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCompareHash();
        }

        /// <summary>
        /// SHA256
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSHA256_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCompareHash();
        }

        /// <summary>
        /// SHA384
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSHA384_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCompareHash();
        }

        /// <summary>
        /// SHA512
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSHA512_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCompareHash();
        }

        /// <summary>
        /// Use characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoChars_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFileButton();
        }

        /// <summary>
        /// Use file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoFile_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFileButton();
        }

        /// <summary>
        /// Toggle file select button
        /// </summary>
        private void ToggleFileButton()
        {
            //Enable or disable fiel select button
            if (this.rdoFile.Checked)
            {
                this.btnFile.Enabled = true;
            }
            else
            {
                this.btnFile.Enabled = false;
            }

            this.txtCharas.Text = string.Empty;
            this.txtInputHash.Text = string.Empty;
        }

        /// <summary>
        /// Set Hash to text box
        /// </summary>
        /// <param name="algorithm"></param>
        private void SetCompareHash()
        {

            if (this.txtCharas.Text == string.Empty) return;

            //initialize value
            this.txtInputHash.Text = string.Empty;

            if (this.rdoMD5.Checked) this.txtInputHash.Text = this.getHash(enumAlgorithm.MD5);
            if (this.rdoSHA1.Checked) this.txtInputHash.Text = this.getHash(enumAlgorithm.SHA1);
            if (this.rdoSHA256.Checked) this.txtInputHash.Text = this.getHash(enumAlgorithm.SHA256);
            if (this.rdoSHA384.Checked) this.txtInputHash.Text = this.getHash(enumAlgorithm.SHA384);
            if (this.rdoSHA512.Checked) this.txtInputHash.Text = this.getHash(enumAlgorithm.SHA512);

            if (this.chkCompare.Checked)
                CompareHash();

        }

        /// <summary>
        /// Get hash
        /// </summary>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        private string getHash(enumAlgorithm algorithm)
        {
            HashAlgorithm hashobject;

            //create object
            hashobject = algorithm switch
            {
                enumAlgorithm.MD5 => (HashAlgorithm)MD5.Create(),
                enumAlgorithm.SHA1 => SHA1.Create(),
                enumAlgorithm.SHA256 => SHA256.Create(),
                enumAlgorithm.SHA384 => SHA384.Create(),
                enumAlgorithm.SHA512 => SHA512.Create(),
                _ => null
            };

            string retval = string.Empty;

            //from characters
            if (this.rdoChars.Checked)
            {
                byte[] orgdata = Encoding.UTF8.GetBytes(this.txtCharas.Text);
                byte[] hashbytes = hashobject.ComputeHash(orgdata);
                retval = BitConverter.ToString(hashbytes).Replace("-", "").ToLower();
            }

            //from file
            if (this.rdoFile.Checked)
            {
                if (this.txtCharas.Text.Trim() == string.Empty)
                    return string.Empty;

                if (!File.Exists(this.txtCharas.Text))
                    return "File not found!";

                using (FileStream fs = File.OpenRead(this.txtCharas.Text))
                {
                    byte[] hashbytes = hashobject.ComputeHash(fs);
                    retval = BitConverter.ToString(hashbytes).Replace("-", "").ToLower();

                }
            }

            return retval;
        }

        /// <summary>
        /// Input source changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCharas_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCharas.Text != string.Empty)
                this.SetCompareHash();

        }

        /// <summary>
        /// Compare hash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCompareHash_TextChanged(object sender, EventArgs e)
        {
            CompareHash();
        }

        /// <summary>
        /// Comapre hash
        /// </summary>
        private void CompareHash()
        {
            this.lblResult.Text = string.Empty;

            if (this.txtCompareHash.Text.Trim() == string.Empty) return;

            if (this.txtInputHash.Text.Equals(this.txtCompareHash.Text.ToLower()))
            {
                this.lblResult.Text = "OK";
            }
            else
            {
                this.lblResult.Text = "NG";
            }
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //set file path
            if (Environment.GetCommandLineArgs().Length == 2)
            {
                this.rdoFile.Checked = true;
                this.txtCharas.Text = Environment.GetCommandLineArgs()[1];
                this.SetCompareHash();
            }
                

            
        }

        /// <summary>
        /// drag and drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCharas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// drag and drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCharas_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropdata =  (string[])e.Data.GetData(DataFormats.FileDrop);

            if (dropdata.Length > 0)
                this.txtCharas.Text = dropdata[0];

        }

    }
}

