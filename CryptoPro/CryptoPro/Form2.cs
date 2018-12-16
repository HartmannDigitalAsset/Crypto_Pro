using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPro
{
    public partial class Form2 : Form
    {
        cryptoDataLayer dataHandle = new cryptoDataLayer();
        List<Watching> watchList = new List<Watching>();
        Watching currentCrypto;
        String olddesc;
        


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            watchList = dataHandle.getWatchListDatabase();

            watchingBindingSource.DataSource = watchList; // bind to list

            disableControls();
        }

        private void watchingBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentCrypto = (Watching)watchingBindingSource.Current;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to remove from Watchlist?", "Remove from Watching", MessageBoxButtons.YesNoCancel);
            if(dr == DialogResult.Yes)
            {
                dataHandle.deleteWatching(currentCrypto);
                watchingBindingSource.RemoveCurrent();
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            currentCrypto.Description1 = description1TextBox.Text;

            // we know this is an edit so we dont need addingnew
            dataHandle.editWatching(currentCrypto);
            disableControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // all we need is the old description to revert if cancelled
            olddesc = description1TextBox.Text;
            enableControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            description1TextBox.Text = olddesc;
            disableControls();
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            watchingBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            watchingBindingSource.MovePrevious();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            watchingBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            watchingBindingSource.MoveLast();
        }

        private void enableControls()
        {
            description1TextBox.ReadOnly = false;
            btnSave2.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void disableControls()
        {
            description1TextBox.ReadOnly = true;
            btnSave2.Enabled = false;
            btnCancel.Enabled = false;
        }


        }
}
