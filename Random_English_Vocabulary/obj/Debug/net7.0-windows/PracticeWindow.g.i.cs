﻿#pragma checksum "..\..\..\PracticeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6BAAFB6BE3F1169CA5E37168437A5A66DA059CEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Random_English_Vocabulary;
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


namespace Random_English_Vocabulary {
    
    
    /// <summary>
    /// PracticeWindow
    /// </summary>
    public partial class PracticeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\PracticeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menuButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\PracticeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock scoreTextBlock;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\PracticeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image wordImage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\PracticeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button answerA;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\PracticeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button answerB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Random_English_Vocabulary;component/practicewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PracticeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\PracticeWindow.xaml"
            ((Random_English_Vocabulary.PracticeWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menuButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\PracticeWindow.xaml"
            this.menuButton.Click += new System.Windows.RoutedEventHandler(this.menuButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.scoreTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.wordImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.answerA = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\PracticeWindow.xaml"
            this.answerA.Click += new System.Windows.RoutedEventHandler(this.answerA_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.answerB = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\PracticeWindow.xaml"
            this.answerB.Click += new System.Windows.RoutedEventHandler(this.answerB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

