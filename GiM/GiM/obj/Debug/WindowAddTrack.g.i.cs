﻿#pragma checksum "..\..\WindowAddTrack.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6BC825E8922965FD9FDCE4C7F62110D"
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
    /// WindowAddTrack
    /// </summary>
    public partial class WindowAddTrack : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_FullName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ShortName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Families;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Types;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_Features;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Confirm;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\WindowAddTrack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/GiM;component/windowaddtrack.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAddTrack.xaml"
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
            
            #line 4 "..\..\WindowAddTrack.xaml"
            ((GiM.WindowAddTrack)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown_1);
            
            #line default
            #line hidden
            
            #line 4 "..\..\WindowAddTrack.xaml"
            ((GiM.WindowAddTrack)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_FullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_ShortName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lb_Families = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.lb_Types = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.lb_Features = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btn_Confirm = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\WindowAddTrack.xaml"
            this.btn_Confirm.Click += new System.Windows.RoutedEventHandler(this.btn_Confirm_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\WindowAddTrack.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

