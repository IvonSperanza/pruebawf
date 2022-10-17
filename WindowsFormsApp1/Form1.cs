using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbArena_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArena.Items.Add = ("10");
            cbArena.Items.Add = ("50"); 
            cbArena.Items.Add = ("100");
        }

        private void cbCal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCal.Items.Add = ("10");
            cbCal.Items.Add = ("50");
            cbCal.Items.Add = ("100");
        }

        private void cbCto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCto.Items.Add = ("10");
            cbCto.Items.Add = ("50");
            cbCto.Items.Add = ("100");
        }

        private void cbPdra_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPdra.Items.Add = ("10");
            cbPdra.Items.Add = ("50");
            cbPdra.Items.Add = ("100");
        }

        private void cbArenatp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArenatp.Items.Add = ("1");
            cbArenatp.Items.Add = ("2");
            cbArenatp.Items.Add = ("3");
        }

        private void cbCaltp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCalatp.Items.Add = ("1");
            cbCaltp.Items.Add = ("2");
            cbCaltp.Items.Add = ("3");
        }

        private void cbCtotp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCtotp.Items.Add = ("1");
            cbCtotp.Items.Add = ("2");
            cbCtotp.Items.Add = ("3");
        }

        private void cbPdratp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPdratp.Items.Add = ("1");
            cbPdratp.Items.Add = ("2");
            cbPdratp.Items.Add = ("3");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            switch (cbCto.Text == "10")
            {
                case "1":
                    preciolblCto.Text = ($"{10 * 200}");
                case "2":
                    preciolblCto.Text = ($"{10 * 100}");
                case "3":
                    preciolblCto.Text = ($"{10 * 50}");
            }
            switch (cbCto.Text == "50")
            {
                case "1":
                    preciolblCto.Text = ($"{50 * 200}");
                case "2":
                    preciolblCto.Text = ($"{50 * 100}");
                case "3":
                    preciolblCto.Text = ($"{50 * 50}");
            }
            switch (cbCto.Text == "10")
            {
                case "1":
                    preciolblCto.Text = ($"{100 * 200}");
                case "2":
                    preciolblCto.Text = ($"{100 * 100}");
                case "3":
                    preciolblCto.Text = ($"{100 * 50}");
            }
        }

        private void preciolbl_Click(object sender, EventArgs e)
        {
           
                switch(cbArena.Text == "10")
            {
                case "1":
                    preciolbl.Text = ($"{10*200}");
                case "2":
                    preciolbl.Text = ($"{10 * 100}");
                case "3":
                    preciolbl.Text = ($"{10 * 50}");
            }
            switch (cbArena.Text == "50")
            {
                case "1":
                    preciolbl.Text = ($"{50 * 200}");
                case "2":
                    preciolbl.Text = ($"{50 * 100}");
                case "3":
                    preciolbl.Text = ($"{50 * 50}");
            }
            switch (cbArena.Text == "10")
            {
                case "1":
                    preciolbl.Text = ($"{100 * 200}");
                case "2":
                    preciolbl.Text = ($"{100 * 100}");
                case "3":
                    preciolbl.Text = ($"{100 * 50}");
            }
        }

        private void preciolblcal_Click(object sender, EventArgs e)
        {
            switch (cbCal.Text == "10")
            {
                case "1":
                    preciolblCal.Text = ($"{10 * 200}");
                case "2":
                    preciolblCal.Text = ($"{10 * 100}");
                case "3":
                    preciolblCal.Text = ($"{10 * 50}");
            }
            switch (cbCal.Text == "50")
            {
                case "1":
                    preciolblCal.Text = ($"{50 * 200}");
                case "2":
                    preciolblCal.Text = ($"{50 * 100}");
                case "3":
                    preciolblCal.Text = ($"{50 * 50}");
            }
            switch (cbCal.Text == "10")
            {
                case "1":
                    preciolblCal.Text = ($"{100 * 200}");
                case "2":
                    preciolblCal.Text = ($"{100 * 100}");
                case "3":
                    preciolblCal.Text = ($"{100 * 50}");
            }
        }

        private void preciolblPdra_Click(object sender, EventArgs e)
        {
            switch (cbPdra.Text == "10")
            {
                case "1":
                    preciolblPdra.Text = ($"{10 * 200}");
                case "2":
                    preciolblPdra.Text = ($"{10 * 100}");
                case "3":
                    preciolblPdra.Text = ($"{10 * 50}");
            }
            switch (cbPdra.Text == "50")
            {
                case "1":
                    preciolblPdra.Text = ($"{50 * 200}");
                case "2":
                    preciolblPdra.Text = ($"{50 * 100}");
                case "3":
                    preciolblPdra.Text = ($"{50 * 50}");
            }
            switch (cbPdra.Text == "10")
            {
                case "1":
                    preciolblPdra.Text = ($"{100 * 200}");
                case "2":
                    preciolblPdra.Text = ($"{100 * 100}");
                case "3":
                    preciolblPdra.Text = ($"{100 * 50}");
            }
        }
    }

}
