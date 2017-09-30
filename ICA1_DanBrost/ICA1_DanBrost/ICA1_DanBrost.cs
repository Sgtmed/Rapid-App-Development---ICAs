/*
 * Name: Dan Brost
 * Date: September 22, 2017
 * Purpose: This application displays a Message that shows the user what promotions are available and the code to us
 * The output can be cleared. The form can be printed and the user can exit the form.
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

namespace ICA1_DanBrost
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When user selects it will display a promotion message and code
        /// </summary>
        /// <param name="sender">The Books button</param>
        /// <param name="e">The event arguments</param>
        private void btnBooks_Click(object sender, EventArgs e)
        {
            lblPromotion.Text = "Buy two. Get the second one for half price";
            lblPromotionCode.Text = "code B608";
        }
        /// <summary>
        /// When user selects it will display a promotion message and code
        /// </summary>
        /// <param name="sender">The Music button</param>
        /// <param name="e">The event arguments</param>
        private void btnMusic_Click(object sender, EventArgs e)
        {
            lblPromotion.Text = "Get a free MP3 download with purchase of a CD";
            lblPromotionCode.Text = "code M608";
        }
        /// <summary>
        /// When user selects it will display a promotion message and code
        /// </summary>
        /// <param name="sender">The Periodicals button</param>
        /// <param name="e">The event arguments</param>
        private void btnPeriodicals_Click(object sender, EventArgs e)
        {
            lblPromotion.Text = "Elite members receive 10% off every purchase";
            lblPromotionCode.Text = "code P608";
        }
        /// <summary>
        /// When user selects it will display a promotion message and code
        /// </summary>
        /// <param name="sender">The Coffee Bar button</param>
        /// <param name="e">The event arguments</param>
        private void btnCoffeeBar_Click(object sender, EventArgs e)
        {
            lblPromotion.Text = "Celebrate the season with 20% off specialty drinks";
            lblPromotionCode.Text = "code C608";
        }
        /// <summary>
        /// When user selects the promotion and code will be cleared
        /// </summary>
        /// <param name="sender">The Books button</param>
        /// <param name="e">The event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPromotion.Text = String.Empty;
            lblPromotionCode.Text = String.Empty;
        }
        /// <summary>
        /// When user selects it will Print Preview
        /// </summary>
        /// <param name="sender">The Print button</param>
        /// <param name="e">The event arguments</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
         printForm1.Print();
        }
        /// <summary>
        /// When user selects it exit the application
        /// </summary>
        /// <param name="sender">The Exit button</param>
        /// <param name="e">The event arguments</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }
    }
}
