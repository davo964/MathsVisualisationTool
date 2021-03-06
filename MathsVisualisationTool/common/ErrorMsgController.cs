﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MathsVisualisationTool
{
    public partial class ErrorMsg
    {
        public ErrorMsg(string errorMessage,string code)
        {
            InitializeComponent();
            errorCode.Text = code;
            errorMsgText.Text = errorMessage;
        }

        /*
         * OnOkay_Clicked - Handle event if the Okay button is 
         *                  clicked on the error message
         */
        private void OnOkay_Clicked(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        /*
         * OnCancel_Clicked - Handle event if the Cancel button is 
         *                  clicked on the error message
         */
        private void OnCancel_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
