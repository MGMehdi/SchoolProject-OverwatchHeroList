﻿#pragma checksum "..\..\FicheInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DB349B46CD85BD5EBA581BADC6D56BD8CBB1CA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using hackathon;


namespace hackathon {
    
    
    /// <summary>
    /// FicheInfo
    /// </summary>
    public partial class FicheInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border_img;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBio;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBInGame;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBFirstName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBLastName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBNationality;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBAge;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FicheInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbox_type;
        
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
            System.Uri resourceLocater = new System.Uri("/hackathon;component/ficheinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FicheInfo.xaml"
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
            
            #line 8 "..\..\FicheInfo.xaml"
            ((hackathon.FicheInfo)(target)).Closed += new System.EventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 2:
            this.border_img = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.txtBio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\FicheInfo.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\FicheInfo.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLoadImage = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\FicheInfo.xaml"
            this.btnLoadImage.Click += new System.Windows.RoutedEventHandler(this.LoadImage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtBInGame = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtBFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtBLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtBNationality = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtBAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.cmbox_type = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

