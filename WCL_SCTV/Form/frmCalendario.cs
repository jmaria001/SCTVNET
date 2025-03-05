using System;
using System.Collections.Generic;
using System.ComponentModel;
 
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class frmCalendario : Form
    {
        private UC.UCData oUCData;

        #region Form

        public frmCalendario()
        {
            InitializeComponent();
        }

        public frmCalendario(UC.UCData UCData )
        {
            InitializeComponent();
            this.oUCData = UCData; 
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            try
            {
                this.monthCalendar.TodayDate = DateTime.Now;
                    this.monthCalendar.SelectionStart = DateTime.Now;
                this.monthCalendar.SelectionEnd = DateTime.Now;

                if (this.oUCData.isDate)
                {
                    this.monthCalendar.SelectionStart = this.oUCData.DateTime;
                    this.monthCalendar.SelectionEnd = this.oUCData.DateTime;
                }

                this.Size = this.monthCalendar.Size; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "frmCalendario_Load\n" + ex.Message, "frmCalendario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (this.oUCData != null)
                {
                    this.oUCData.DateTime = this.monthCalendar.SelectionRange.Start; 
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "monthCalendar_DateSelected\n" + ex.Message, "frmCalendario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}