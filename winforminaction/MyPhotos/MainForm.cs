﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class MainForm : Form
    {
        //     v v  private ContextMenuStrip ctxMenuPhoto;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(dlg.OpenFile());
            }
            dlg.Dispose();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = new Bitmap(dlg.OpenFile());
            }
            dlg.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scaleToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
