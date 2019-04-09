/**
 *  @file           Form1.cs / FormMegaManIPassGenGB
 *  @brief          Password Generator for the Nintendo Gameboy Game MegaMan I
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/09/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Windows.Forms;

namespace MegaManIPassGenGB
{
    public partial class FormMegaManIPassGenGB : Form
    {
        public FormMegaManIPassGenGB()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            disablePasswordCheckboxes();
        }

        private void disablePasswordCheckboxes()
        {
            checkBoxA1.Enabled = false;
            checkBoxA2.Enabled = false;
            checkBoxA3.Enabled = false;
            checkBoxA4.Enabled = false;

            checkBoxB1.Enabled = false;
            checkBoxB2.Enabled = false;
            checkBoxB3.Enabled = false;
            checkBoxB4.Enabled = false;

            checkBoxC1.Enabled = false;
            checkBoxC2.Enabled = false;
            checkBoxC3.Enabled = false;
            checkBoxC4.Enabled = false;

            checkBoxD1.Enabled = false;
            checkBoxD2.Enabled = false;
            checkBoxD3.Enabled = false;
            checkBoxD4.Enabled = false;
        }

        private void clearPasswordCheckboxes()
        {
            checkBoxA1.Checked = false;
            checkBoxA2.Checked = false;
            checkBoxA3.Checked = false;
            checkBoxA4.Checked = false;

            checkBoxB1.Checked = false;
            checkBoxB2.Checked = false;
            checkBoxB3.Checked = false;
            checkBoxB4.Checked = false;

            checkBoxC1.Checked = false;
            checkBoxC2.Checked = false;
            checkBoxC3.Checked = false;
            checkBoxC4.Checked = false;

            checkBoxD1.Checked = false;
            checkBoxD2.Checked = false;
            checkBoxD3.Checked = false;
            checkBoxD4.Checked = false;
        }

        private int getTotalChecked()
        {
            int totalChecked = 0;

            if (checkBoxFireStorm.Checked)
            {
                totalChecked++;
            }

            if (checkBoxIceSlasher.Checked)
            {
                totalChecked++;
            }

            if (checkBoxRollingCutter.Checked)
            {
                totalChecked++;
            }

            if (checkBoxThunderBeam.Checked)
            {
                totalChecked++;
            }

            return totalChecked;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            clearPasswordCheckboxes();

            bool hasFireStorm = checkBoxFireStorm.Checked;
            bool hasIceSlasher = checkBoxIceSlasher.Checked;
            bool hasRollingCutter = checkBoxRollingCutter.Checked;
            bool hasThunderBeam = checkBoxThunderBeam.Checked;

            int totalChecked = getTotalChecked();

            if (totalChecked == 4)
            {
                checkBoxA2.Checked = true;
                checkBoxA3.Checked = true;
                checkBoxB4.Checked = true;
                checkBoxC2.Checked = true;
                checkBoxC3.Checked = true;
            }

            if (totalChecked == 3)
            {
                if (hasIceSlasher && hasFireStorm && hasThunderBeam)
                {
                    checkBoxA2.Checked = true;
                    checkBoxA3.Checked = true;
                    checkBoxC1.Checked = true;
                    checkBoxD2.Checked = true;
                    checkBoxD3.Checked = true;
                }
                else if (hasRollingCutter && hasFireStorm && hasThunderBeam)
                {
                    checkBoxA3.Checked = true;
                    checkBoxB2.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxB4.Checked = true;
                    checkBoxC4.Checked = true;
                }
                else if (hasRollingCutter && hasIceSlasher && hasThunderBeam)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA3.Checked = true;
                    checkBoxC1.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxD3.Checked = true;
                }
                else if (hasRollingCutter && hasIceSlasher && hasFireStorm)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA2.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxD4.Checked = true;
                }
            }

            if (totalChecked == 2)
            {
                if (hasIceSlasher && hasRollingCutter)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA3.Checked = true;
                    checkBoxA4.Checked = true;
                    checkBoxB4.Checked = true;
                    checkBoxD2.Checked = true;
                }
                else if (hasRollingCutter && hasFireStorm)
                {
                    checkBoxA2.Checked = true;
                    checkBoxB2.Checked = true;
                    checkBoxC3.Checked = true;
                    checkBoxD1.Checked = true;
                    checkBoxD3.Checked = true;
                }
                else if (hasRollingCutter && hasThunderBeam)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA3.Checked = true;
                    checkBoxB1.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxD3.Checked = true;
                }
                else if (hasIceSlasher && hasFireStorm)
                {
                    checkBoxA2.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxD2.Checked = true;
                    checkBoxD3.Checked = true;
                    checkBoxD4.Checked = true;
                }
                else if (hasIceSlasher && hasThunderBeam)
                {
                    checkBoxA1.Checked = true;
                    checkBoxB4.Checked = true;
                    checkBoxC1.Checked = true;
                    checkBoxD2.Checked = true;
                    checkBoxD4.Checked = true;
                }
                else if (hasThunderBeam && hasFireStorm)
                {
                    checkBoxB2.Checked = true;
                    checkBoxB4.Checked = true;
                    checkBoxC1.Checked = true;
                    checkBoxC3.Checked = true;
                    checkBoxC4.Checked = true;
                }
            }

            if (totalChecked == 1)
            {
                if (hasIceSlasher)
                {
                    checkBoxA1.Checked = true;
                    checkBoxA2.Checked = true;
                    checkBoxB2.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxD4.Checked = true;
                }
                else if (hasRollingCutter)
                {
                    checkBoxA4.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxD3.Checked = true;
                    checkBoxD4.Checked = true;
                }
                else if (hasFireStorm)
                {
                    checkBoxA1.Checked = true;
                    checkBoxB1.Checked = true;
                    checkBoxB2.Checked = true;
                    checkBoxC4.Checked = true;
                    checkBoxD2.Checked = true;
                }
                else if (hasThunderBeam)
                {
                    checkBoxA2.Checked = true;
                    checkBoxA4.Checked = true;
                    checkBoxB3.Checked = true;
                    checkBoxD1.Checked = true;
                    checkBoxD2.Checked = true;
                }
            }

            if (totalChecked == 0)
            {
                checkBoxA3.Checked = true;
                checkBoxB1.Checked = true;
                checkBoxB3.Checked = true;
                checkBoxC2.Checked = true;
                checkBoxC4.Checked = true;
            }
        }
    }
}
