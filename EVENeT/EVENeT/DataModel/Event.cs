using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace EVENeT.DataModel
{
    public class Event
    {
        public int EventId { get; set; }
        string thumbnailPath;
        public ObservableCollection<BitmapImage> ImageGallery = new ObservableCollection<BitmapImage>();
        public string Thumbnail
        {
            get
            {
                return thumbnailPath;
            }
            set
            {
                thumbnailPath = value;
                changeBitmap();
            }
        }
        public string ImageGalleryCombine
        {
            set {
                ImageGalleryCombine = value;
                ConvertPathToBitmap();
            }
            get {
                return ImageGalleryCombine;
            }
            }

        public async void ConvertPathToBitmap()
        {
            if (ImageGalleryCombine == null) return;
            string[] ImageGalleryPaths = ImageGalleryCombine.Split('$');
            foreach (string path in ImageGalleryPaths)
            {
               string temp = path.Trim();
                BitmapImage bitmap = new BitmapImage();
                StorageFile file = await StorageFile.GetFileFromPathAsync(temp);
                bitmap = new BitmapImage();
                await bitmap.SetSourceAsync(await file.OpenAsync(FileAccessMode.Read));
                ImageGallery.Add(bitmap);
            }     
        }


        public string Title { get; set; }

        public BitmapImage ImageThumbnail { get; set; }


        public Event(int EventId, string Title, string Thumbnail, string ImageGalleryCombine)
        {
            this.EventId = EventId;
            this.Title = Title;
            this.Thumbnail = Thumbnail;
        }

        public async void changeBitmap()
        {
            if (thumbnailPath == "") return;
            StorageFile file = await StorageFile.GetFileFromPathAsync(thumbnailPath);
            ImageThumbnail = new BitmapImage();
            await ImageThumbnail.SetSourceAsync(await file.OpenAsync(FileAccessMode.Read));
        }
    }
}
