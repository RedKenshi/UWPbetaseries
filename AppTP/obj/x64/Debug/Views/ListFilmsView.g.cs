﻿#pragma checksum "C:\Users\developer\Documents\Visual Studio 2015\Projects\UWPbetaseries\AppTP\Views\ListFilmsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A80E6FC1D072D7C2AF59F94312D6FE57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppTP.Views
{
    partial class ListFilmsView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.FilmslistView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 2:
                {
                    this.flipViewFilms = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 3:
                {
                    this.listViewFilms = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4:
                {
                    this.returnButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Views\ListFilmsView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.returnButton).Click += this.Return_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.filmsTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

