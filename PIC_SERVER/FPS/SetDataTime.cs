﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FPS
{
    public partial class SetDataTime : Form
    {
        public SetDataTime()
        {
            InitializeComponent();

            hours_txt_box.MaxLength = 2;
            minutes_txt_box.MaxLength = 2;
        }
        Form1 form1 = new Form1();
       public static string interval = "";
       public static string hours = "";
       public static string minutes = "";
       public static bool IsselectedAm = false;
       public static bool IsselectedPm = false;
        private void Ok_btn_Click(object sender, EventArgs e)
        {

             hours = hours_txt_box.Text.ToString().Trim();
             minutes = minutes_txt_box.Text.ToString().Trim();

             if ((hours != null && hours != "") && (minutes != null && minutes != "") && (IsselectedAm || IsselectedPm))
             {

                 if (hours.Length == 1) {

                     hours = "0" + hours;
                 }

                 if (minutes.Length == 1) {

                     minutes = "0" + minutes;
                 }


                 this.Hide();
                 //DB.IsGenerateEOD_report = false;
                 //DB.IsGeneratePIC_Cash_report = false;
               //  MessageBox.Show(hours+":"+minutes+":01"+" "+interval+" "+DateTime.Now.ToString("hh:mm:ss tt"));

                 Display.ShowMessageBox("your time seted " + hours + ":" + minutes + " " + interval, 5);
             }
             else {

                 Display.ShowMessageBox("Please set all fields",5);
             }

           // this.Hide();
            
            //form1.Auto_check.Checked = false;
            //form1.Auto_check.CheckedChanged += new EventHandler(CheckBox_Checked);

          //  form1.Auto_check_CheckedChanged(null,null);
            
            //CheckBox check = (CheckBox)this.form1.Controls["Auto_check"];

        }

        private void am_btn_Click(object sender, EventArgs e)
        {
            interval = am_btn.Text.ToString();
            am_btn.BackColor = Color.Yellow;
            pm_btn.BackColor = Color.White;
            IsselectedAm = true;
            IsselectedPm = false;
        }

        private void pm_btn_Click(object sender, EventArgs e)
        {
            interval = pm_btn.Text.ToString();
            pm_btn.BackColor = Color.Yellow;
            am_btn.BackColor = Color.White;
            IsselectedPm = true;
            IsselectedAm = false;


        }

        private void hours_txt_box_TextChanged(object sender, EventArgs e)
        {

        }

      

       

       
        
    }
}
