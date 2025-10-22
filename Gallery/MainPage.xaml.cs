using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Gallery
{

       
 
    public partial class MainPage : ContentPage
    {

        public class ImageGallery
        {
            public string Path { get; set; }
            public string Description { get; set; }
            
            public bool IsLiked { get; set; }
            public ImageSource Source => ImageSource.FromFile(Path);
        }

        public List<ImageGallery> Images { get; set; }
        private ImageGallery _currentImage;

        public MainPage()
        {


            Images = new List<ImageGallery> {
            new() { Path = "image1.jpg", Description = "Mountain" },
            new() { Path = "image2.jpg", Description = "Lake" },
            new() { Path = "image3.jpg", Description = "Lake2" },
            new() { Path = "image4.jpg", Description = "Town" },
            new() { Path = "image5.jpg", Description = "Cat on window" },
            new() { Path = "image6.jpg", Description = "Ruins" },
            new() { Path = "image7.jpg", Description = "Beach" },
            new() { Path = "image8.jpg", Description = "Mountain2" },
            new() { Path = "image9.jpg", Description = "Asian architecture" },
            new() { Path = "image10.jpg", Description = "Church" }

        };





            


            InitializeComponent();
        }

        private void ShowImageClicked(object sender, EventArgs e)
        {
            Random random = new Random();
            _currentImage = Images[random.Next(Images.Count)];
            ShowImage.Source = _currentImage.Source;
            ImageLabel.Text = _currentImage.Description;

            LikeUpdater();

        }

        private void IsLiked(object sender, EventArgs e)
        {
            if (_currentImage == null) return;
            {
                _currentImage.IsLiked = !_currentImage.IsLiked;
            }

            LikeUpdater();
        }





        private void LikeUpdater() {

            if (_currentImage == null) return;
            {
                IsLikable.Source = _currentImage.IsLiked ? "hearticoncolor.png" : "hearticon.png";
            }
        
        }
        


    }

}
