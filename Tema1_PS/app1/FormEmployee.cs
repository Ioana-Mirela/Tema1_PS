using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _piataAZ.BL;
using System.Collections;

namespace app1
{
    public partial class FormEmployee : Form
    {
        private AdService adService;
        private String username;
        private String updateOldTitle;
        private Form _login;

        public FormEmployee(String username, Form login)
        {
            InitializeComponent();
            this.username = username;
            label_logged.Text = "Logged in as Employee: " + username; 
            adService = new AdService();
            this.setComboBox();
            _login = login;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _login.Visible = true;
        }

        private void button_addAd_Click(object sender, EventArgs e)
        {
            adService.createAd(textBox_titleAd.Text, textBox_descriptionAd.Text, textBox_imageAd.Text,username);
            this.setComboBox();
        }

        private void setComboBox()
        {
            comboBox_deleteAd.Items.Clear();
            comboBox_updateTitle.Items.Clear();
            comboBox_viewAd.Items.Clear();
            ArrayList list = new ArrayList();
            list = adService.getAllTitles();
            foreach (string s in list)
            {
                comboBox_deleteAd.Items.Add(s);
                comboBox_updateTitle.Items.Add(s);
                comboBox_viewAd.Items.Add(s);
            }
        }

        private void button_deleteAd_Click(object sender, EventArgs e)
        {
            adService.deleteAd(comboBox_deleteAd.GetItemText(comboBox_deleteAd.SelectedItem));
            setComboBox();
        }

        private void comboBox_updateTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOldTitle = comboBox_updateTitle.GetItemText(comboBox_updateTitle.SelectedItem);
            textBox_updateDescription.Text = adService.getDescription(comboBox_updateTitle.GetItemText(comboBox_updateTitle.SelectedItem));
            textBox_updateImage.Text = adService.getImage(comboBox_updateTitle.GetItemText(comboBox_updateTitle.SelectedItem));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            adService.updateAd(updateOldTitle, textBox_newUpdateTitle.Text, textBox_updateDescription.Text, textBox_updateImage.Text, username);
            setComboBox();
        }

        private void comboBox_viewAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_viewAd.Text =  adService.getDescription(comboBox_viewAd.GetItemText(comboBox_viewAd.SelectedItem));
            String imgName = adService.getImage(comboBox_viewAd.GetItemText(comboBox_viewAd.SelectedItem));
            pictureBox_viewImage.Image = Image.FromFile(imgName);
           
        }

        private void button_adImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_updateImage.Text = dlg.FileName.ToString(); 
            }
        }

        private void button_addAdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_imageAd.Text = dlg.FileName.ToString();
            }

        }
        
    }
}
