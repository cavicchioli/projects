﻿#pragma checksum "D:\PhoneApp1\PhoneApp1\Database.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DFFDCF2E803BE4FB98C34E30412C32B1"
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
    
    
    public partial class Database : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.DataTemplate ProdutosTemplate;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.ListBox lbProdutos;
        
        internal Microsoft.Phone.Controls.PhoneTextBox txtProduto;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/Database.xaml", System.UriKind.Relative));
            this.ProdutosTemplate = ((System.Windows.DataTemplate)(this.FindName("ProdutosTemplate")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.lbProdutos = ((System.Windows.Controls.ListBox)(this.FindName("lbProdutos")));
            this.txtProduto = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("txtProduto")));
        }
    }
}

