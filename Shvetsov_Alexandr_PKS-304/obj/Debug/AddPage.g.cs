﻿#pragma checksum "..\..\AddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C95CDB0DAE7C74946AB2AC1E336746502C1E062271ACA333E3DE28FE1D2AE20"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Shvetsov_Alexandr_PKS_304;
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


namespace Shvetsov_Alexandr_PKS_304 {
    
    
    /// <summary>
    /// AddPage
    /// </summary>
    public partial class AddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoverTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameID_TVTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoverageID_TVTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionsTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LaunchTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_TVKopiratorTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDKopiratorTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Shvetsov_Alexandr_PKS-304;component/addpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddPage.xaml"
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
            
            #line 12 "..\..\AddPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CoverTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 22 "..\..\AddPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddOpiration_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NameID_TVTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CoverageID_TVTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DescriptionsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.LaunchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 29 "..\..\AddPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTV_channel_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ID_TVKopiratorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.IDKopiratorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 38 "..\..\AddPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddUnion_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

