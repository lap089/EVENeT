﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EVENeT.Common;
using EVENeT.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace EVENeT
{
    public sealed partial class PageHeader : UserControl
    {

        public static event EventHandler selectedItemChangeEvent;

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(object), typeof(PageHeader), new PropertyMetadata(null));
        public object Title
        {
            get { return GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public ContentPresenter TitleControl
        {
            get { return pageTitle; }
        }

        public CommandBar AppCommandBar
        {
            get { return topCommandBar; }
        }

        public static readonly DependencyProperty WideLayoutThresholdProperty = DependencyProperty.Register("WideLayoutThreshold", typeof(double), typeof(PageHeader), new PropertyMetadata(600));
        public double WideLayoutThreshold
        {
            get { return (double)GetValue(WideLayoutThresholdProperty); }
            set
            {
                SetValue(WideLayoutThresholdProperty, value);
                WideLayoutTrigger.MinWindowWidth = value;
            }
        }

        public PageHeader()
        {
            this.InitializeComponent();

            if (ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                //Remove the backbutton because physical buttons are present
                backButton.Visibility = Visibility.Collapsed;
            }
        }

        private void navPaneToggle_Click(object sender, RoutedEventArgs e)
        {
            AppShell.NavPane.IsPaneOpen = !AppShell.NavPane.IsPaneOpen;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            bool ignored = false;
            this.BackRequested(ref ignored);
        }

        public void BackRequested(ref bool handled)
        {
            // Check if the frame is available
            if (AppShell.RootFrame == null)
                return;

            // Check to see if this is the top-most page on the app back stack.
            if (AppShell.RootFrame.CanGoBack && !handled)
            {
                // If not, set the event to handled and go back to the previous page in the app.
                PageStackEntry pageStack = AppShell.RootFrame.BackStack.Last();
                int index = AppShell.navList.FindIndex(x => x.DestPage == pageStack.SourcePageType);
                selectedItemChangeEvent(this, new MyEventArgs(index));

                handled = true;
                AppShell.RootFrame.GoBack();
            }
        }




        public class MyEventArgs : EventArgs
        {
            public int MyEventInt { get; set; }

            public MyEventArgs(int index)
            {
                this.MyEventInt = index;
            }
        }

        private void eventsSearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            AppShell.RootFrame.Navigate(typeof(SearchResultPage), args.QueryText);
        }
    }
}
