﻿#pragma checksum "..\..\..\Windows\AddWeatherWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A34A57757FE09D9FE72EB2EA7CA96428EABC686B6BFDEC77DE1CA06C21EDBA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using ЛР7.Windows;


namespace ЛР7.Windows {
    
    
    /// <summary>
    /// AddWeatherWindow
    /// </summary>
    public partial class AddWeatherWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSave;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBack;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShowWeather;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAdd;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxTypes;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTemperature;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxHumidity;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\AddWeatherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxTime;
        
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
            System.Uri resourceLocater = new System.Uri("/ЛР7;component/windows/addweatherwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddWeatherWindow.xaml"
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
            this.buttonSave = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\AddWeatherWindow.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.buttonSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.calendar1 = ((System.Windows.Controls.Calendar)(target));
            
            #line 32 "..\..\..\Windows\AddWeatherWindow.xaml"
            this.calendar1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.calendar1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonBack = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Windows\AddWeatherWindow.xaml"
            this.buttonBack.Click += new System.Windows.RoutedEventHandler(this.buttonBack_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonShowWeather = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Windows\AddWeatherWindow.xaml"
            this.buttonShowWeather.Click += new System.Windows.RoutedEventHandler(this.buttonShowWeather_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Windows\AddWeatherWindow.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.comboboxTypes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.textBoxTemperature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textBoxHumidity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.comboboxTime = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

