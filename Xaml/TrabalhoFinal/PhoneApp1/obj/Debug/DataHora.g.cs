﻿#pragma checksum "D:\Projects\PhoneApp1\PhoneApp1\DataHora.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "766202BB90A0F173320C224BB2E1527F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp1 {
    
    
    public partial class DataHora : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel datePicker;
        
        internal Microsoft.Phone.Controls.DatePicker dtpData;
        
        internal System.Windows.Controls.StackPanel timePicke;
        
        internal Microsoft.Phone.Controls.TimePicker tmpHora;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/DataHora.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.datePicker = ((System.Windows.Controls.StackPanel)(this.FindName("datePicker")));
            this.dtpData = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("dtpData")));
            this.timePicke = ((System.Windows.Controls.StackPanel)(this.FindName("timePicke")));
            this.tmpHora = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("tmpHora")));
        }
    }
}

