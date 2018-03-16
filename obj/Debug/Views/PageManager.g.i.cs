﻿#pragma checksum "..\..\..\Views\PageManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6D0EED67636FBB752BFA88FDCC52330BCDEE225"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EdibleFungusGreenhouse.Views;
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
using Utils;


namespace EdibleFungusGreenhouse.Views {
    
    
    /// <summary>
    /// PageManager
    /// </summary>
    public partial class PageManager : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridScan;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Utils.ScanCheckBox CheckBoxScan;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridScanResult;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabCardcode;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabName;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabCollectTime;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabSaveTemperature;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Views\PageManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabShelfLife;
        
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
            System.Uri resourceLocater = new System.Uri("/EdibleFungusGreenhouse;component/views/pagemanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PageManager.xaml"
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
            
            #line 10 "..\..\..\Views\PageManager.xaml"
            ((EdibleFungusGreenhouse.Views.PageManager)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridScan = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.CheckBoxScan = ((Utils.ScanCheckBox)(target));
            return;
            case 4:
            
            #line 38 "..\..\..\Views\PageManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BeginScan);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GridScanResult = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 77 "..\..\..\Views\PageManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCloseScan);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LabCardcode = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.LabName = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.LabCollectTime = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.LabSaveTemperature = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.LabShelfLife = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

