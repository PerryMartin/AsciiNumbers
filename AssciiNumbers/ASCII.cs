/*
 * Created by: Perry Martin
 * Created on: 16-10-2015
 * Created for: ICS3U
 * Daily Assignment – unit# 3-11
 * This program displays ASCII
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssciiNumbers
{
    public partial class frmAscii : Form
    {
        public frmAscii()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Varibles
            const int maxNumber = 91;
            // Process
            for (int loopCounter = 65; loopCounter != maxNumber; loopCounter++)
            {
                this.lstOfAscii.Items.Add(Char.ConvertFromUtf32(loopCounter) + " --> " + loopCounter);
            }

        }
    }
}
