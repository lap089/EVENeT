﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EVENeT.Navigation;
using EVENeT.EVENeTServiceReference;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EVENeT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountSetUpPage : Page
    {
        string username;
        int userType;
        ServiceClient client = null;
        bool informationFilled = false;

        public AccountSetUpPage()
        {
            this.InitializeComponent();
            client = new ServiceClient();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            username = e.Parameter.ToString();
            userType = await client.UserTypeAsync(username);
            if (userType == 2)
                IndividualPanel.Visibility = Visibility.Collapsed;
            else if (userType == 1)
                OrganizationPanel.Visibility = Visibility.Collapsed;

            MessageDialog dialog = new MessageDialog("Welcome to EVENeT!\nBefore you continue, please set up your account.", "Account Setup");
            await dialog.ShowAsync();
        }

        private void continueBtn_Click(object sender, RoutedEventArgs e)
        {
            CheckForError();
            if (informationFilled)
            {
                // 
                Frame frame = Window.Current.Content as Frame;
                frame.Navigate(typeof(AppShell), username);
                Window.Current.Activate();
            }
        }

        private void CheckForError()
        {
            if (userType == 1)
            {
                if (string.IsNullOrEmpty(FirstNameTbx.Text) ||
                    string.IsNullOrEmpty(LastnameTbx.Text) ||
                    BirthdayPicker.Date.CompareTo(DateTime.Now) >= 0 ||
                    GenderCbx.SelectedIndex == -1)
                {
                    informationFilled = false;
                }
                else
                    informationFilled = true;
            }
            else if (userType == 2)
            {
                informationFilled = false;
            }
        }

        private async void ChooseAvatarBtn_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".png");
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".bmp");

            StorageFile file = await openPicker.PickSingleFileAsync();
            // Some magic, because I can only display the files directly on computer
            if (file != null)
            {
                BitmapImage image = new BitmapImage();
                await image.SetSourceAsync(await file.OpenAsync(FileAccessMode.Read));
                indAvatar.Source = image;
            }
        }

        private async void ChooseCoverBtn_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".png");
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".bmp");

            StorageFile file = await openPicker.PickSingleFileAsync();
            // Some magic, because I can only display the files directly on computer
            if (file != null)
            {
                BitmapImage image = new BitmapImage();
                await image.SetSourceAsync(await file.OpenAsync(FileAccessMode.Read));
                indCover.Source = image;
            }
        }
    }
}
