﻿#pragma checksum "..\..\..\..\View\GestionView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206ADA3317CBBE11E6E9FB247395AA1943B345A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using System.Windows.Controls.Ribbon;
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
using ValentinRoyerCsharpProjet.View;


namespace ValentinRoyerCsharpProjet.View {
    
    
    /// <summary>
    /// GestionView
    /// </summary>
    public partial class GestionView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\View\GestionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxClient;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\GestionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCompte;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\GestionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelChange;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\GestionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxVal;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\GestionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonValid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ValentinRoyerCsharpProjet;component/view/gestionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\GestionView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\..\View\GestionView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CréditerMenuItemOnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\..\View\GestionView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DébiterMenuItemOnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\..\..\View\GestionView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DécouvertMenuItemOnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\View\GestionView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ClientMenuItemOnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListBoxClient = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\..\..\View\GestionView.xaml"
            this.ListBoxClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxClient_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListBoxCompte = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.LabelChange = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TextBoxVal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ButtonValid = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\View\GestionView.xaml"
            this.ButtonValid.Click += new System.Windows.RoutedEventHandler(this.ButtonValid_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

