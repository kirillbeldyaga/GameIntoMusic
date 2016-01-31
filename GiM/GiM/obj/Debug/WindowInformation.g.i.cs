﻿#pragma checksum "..\..\WindowInformation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "875BC2DCB156FC40586BDF327DB7E5CC"
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


namespace GiM {
    
    
    /// <summary>
    /// WindowInformation
    /// </summary>
    public partial class WindowInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Title;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Artist;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Album;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Subtitle;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Words;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Music;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Tabs;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Copytight;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Notice;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_OK;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Edit;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Tracks;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\WindowInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Instruments;
        
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
            System.Uri resourceLocater = new System.Uri("/GiM;component/windowinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowInformation.xaml"
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
            
            #line 4 "..\..\WindowInformation.xaml"
            ((GiM.WindowInformation)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_Title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_Artist = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_Album = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_Subtitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_Words = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_Music = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tb_Tabs = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tb_Copytight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tb_Notice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btn_OK = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\WindowInformation.xaml"
            this.btn_OK.Click += new System.Windows.RoutedEventHandler(this.btn_OK_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\WindowInformation.xaml"
            this.btn_Edit.Click += new System.Windows.RoutedEventHandler(this.btn_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lb_Tracks = ((System.Windows.Controls.ListBox)(target));
            return;
            case 14:
            this.lb_Instruments = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
