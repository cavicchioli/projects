﻿#pragma checksum "D:\PhoneApp1\PhoneApp1\IsoStorageSettingsFile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E269661FF2EE51C7612E34A4DCE809D"
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
    
    
    public partial class IsoStorageSettingsFile : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtUsuario;
        
        internal System.Windows.Controls.PasswordBox txtSenha;
        
        internal System.Windows.Controls.CheckBox ckbLembrar;
        
        internal System.Windows.Controls.Button btnAcesso;
        
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/IsoStorageSettingsFile.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtUsuario = ((System.Windows.Controls.TextBox)(this.FindName("txtUsuario")));
            this.txtSenha = ((System.Windows.Controls.PasswordBox)(this.FindName("txtSenha")));
            this.ckbLembrar = ((System.Windows.Controls.CheckBox)(this.FindName("ckbLembrar")));
            this.btnAcesso = ((System.Windows.Controls.Button)(this.FindName("btnAcesso")));
            this.btnCancelar = ((System.Windows.Controls.Button)(this.FindName("btnCancelar")));
        }
    }
}

