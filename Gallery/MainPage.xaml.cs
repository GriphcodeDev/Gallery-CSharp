using System.Collections.ObjectModel;

namespace Gallery
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<GalleryItem> Images { get; } = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            Images.Add(new GalleryItem(
                "Mountain Sunrise",
                "https://images.unsplash.com/photo-1500530855697-b586d89ba3ee?w=600",
                "Warm light spilling over a mountain range."));

            Images.Add(new GalleryItem(
                "Forest Trail",
                "https://images.unsplash.com/photo-1501785888041-af3ef285b470?w=600",
                "A calm walk through dense woodland."));

            Images.Add(new GalleryItem(
                "City Nights",
                "https://images.unsplash.com/photo-1499346030926-9a72daac6c63?w=600",
                "Skyscrapers glowing after dusk."));

            Images.Add(new GalleryItem(
                "Beach Escape",
                "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?w=600",
                "Turquoise water brushing against soft sand."));

            Images.Add(new GalleryItem(
                "Desert Journey",
                "https://images.unsplash.com/photo-1500530855697-9fef9a48d3d8?w=600",
                "Rolling dunes under a clear sky."));
        }
    }

    public record GalleryItem(string Title, string Source, string Description);

}
