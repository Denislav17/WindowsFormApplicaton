﻿#pragma checksum "..\..\AddContact.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4830E440546675A3A0FBC4AAFAB8D33C682533B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using firstWpfapp;


namespace firstWpfapp {
    
    
    /// <summary>
    /// AddContact
    /// </summary>
    public partial class AddContact : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox existingUsersList;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCompany;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPosition;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCardNumber;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddToContactBasket;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFirstName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCompanyName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCompanyPosition;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBusinessCardNumber;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddContact.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/firstWpfapp;component/addcontact.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddContact.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.existingUsersList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\AddContact.xaml"
            this.existingUsersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.existingUsersList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCompany = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPosition = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCardNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddToContactBasket = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AddContact.xaml"
            this.btnAddToContactBasket.Click += new System.Windows.RoutedEventHandler(this.btnAddToContactBasket_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblFirstName = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblLastName = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblCompanyName = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lblCompanyPosition = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.lblBusinessCardNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.btnGoBack = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddContact.xaml"
            this.btnGoBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

