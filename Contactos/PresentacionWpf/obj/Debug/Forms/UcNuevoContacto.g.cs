﻿#pragma checksum "..\..\..\Forms\UcNuevoContacto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C677632E8E0878E46E2A9D19A4315ED7EA8D8E73"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PresentacionWpf.Forms;
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


namespace PresentacionWpf.Forms {
    
    
    /// <summary>
    /// UcNuevoContacto
    /// </summary>
    public partial class UcNuevoContacto : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNombre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtApellido;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTelefono;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtFechaNacimiento;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboGrupo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Forms\UcNuevoContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGuardar;
        
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
            System.Uri resourceLocater = new System.Uri("/PresentacionWpf;component/forms/ucnuevocontacto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\UcNuevoContacto.xaml"
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
            
            #line 8 "..\..\..\Forms\UcNuevoContacto.xaml"
            ((PresentacionWpf.Forms.UcNuevoContacto)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DtFechaNacimiento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.CboGrupo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Forms\UcNuevoContacto.xaml"
            this.BtnGuardar.Click += new System.Windows.RoutedEventHandler(this.BtnGuardar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

