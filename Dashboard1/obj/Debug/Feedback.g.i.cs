﻿#pragma checksum "..\..\Feedback.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF13FF11E2A0AD7CD68D5B93694EE085EE6F07463C08A932262C2BB479AE3F01"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dashboard1;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Dashboard1 {
    
    
    /// <summary>
    /// Feedback
    /// </summary>
    public partial class Feedback : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEmail;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox letter;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraTitulo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rollup;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Feedback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbName;
        
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
            System.Uri resourceLocater = new System.Uri("/Dashboard1;component/feedback.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Feedback.xaml"
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
            this.txbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.letter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GridBarraTitulo = ((System.Windows.Controls.Grid)(target));
            
            #line 22 "..\..\Feedback.xaml"
            this.GridBarraTitulo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBarraTitulo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\Feedback.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Feedback.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Rollup = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Feedback.xaml"
            this.Rollup.Click += new System.Windows.RoutedEventHandler(this.Rollup_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonFechar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Feedback.xaml"
            this.ButtonFechar.Click += new System.Windows.RoutedEventHandler(this.ButtonFechar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Feedback.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txbName = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

