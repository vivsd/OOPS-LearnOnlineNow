using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateApp
{
    public class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnCheckLeapYear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckLeapYear
            // 
            this.btnCheckLeapYear.Location = new System.Drawing.Point(33, 154);
            this.btnCheckLeapYear.Name = "btnCheckLeapYear";
            this.btnCheckLeapYear.Size = new System.Drawing.Size(75, 23);
            this.btnCheckLeapYear.TabIndex = 0;
            this.btnCheckLeapYear.Text = "Leap Year?";
            this.btnCheckLeapYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckLeapYear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblShowResult
            // 
            this.lblShowResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowResult.Location = new System.Drawing.Point(87, 61);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(100, 23);
            this.lblShowResult.TabIndex = 2;
            this.lblShowResult.Click += new System.EventHandler(this.lblShowResult_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblShowResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckLeapYear);
            this.Name = "frmMain";
            this.ResumeLayout(false);

        }

        //public static void Main()
        //{
        //    frmMain main = new frmMain();
        //    Application.Run(main);
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private Button btnCheckLeapYear;
        private Button btnExit;
        private Label lblShowResult;

        private void lblShowResult_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
