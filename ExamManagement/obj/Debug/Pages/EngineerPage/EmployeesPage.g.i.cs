﻿#pragma checksum "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F60B759618BF4D0E7944D3C74D77B4A457D7A98B93BEBA0DDC291EA4972EBBC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamManagement.Pages.EngineerPage;
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


namespace ExamManagement.Pages.EngineerPage {
    
    
    /// <summary>
    /// EmployeesPage
    /// </summary>
    public partial class EmployeesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLoggedUser;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdd;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEdit;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRemove;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSurch;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBPost;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVEmployees;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamManagement;component/pages/engineerpage/employeespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
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
            
            #line 11 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            ((ExamManagement.Pages.EngineerPage.EmployeesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBLoggedUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BAdd = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            this.BAdd.Click += new System.Windows.RoutedEventHandler(this.BAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BEdit = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            this.BEdit.Click += new System.Windows.RoutedEventHandler(this.BEdit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BRemove = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            this.BRemove.Click += new System.Windows.RoutedEventHandler(this.BRemove_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBSurch = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            this.TBSurch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSurch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CBPost = ((System.Windows.Controls.ComboBox)(target));
            
            #line 95 "..\..\..\..\Pages\EngineerPage\EmployeesPage.xaml"
            this.CBPost.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBPost_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LVEmployees = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
