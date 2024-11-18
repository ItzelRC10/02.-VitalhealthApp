using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

    public class ViewModel
    {
        public ObservableCollection<ImageModel> ImageCollection { get; set; }

        public ViewModel()
        {
            // Agrega imágenes a la colección
            ImageCollection = new ObservableCollection<ImageModel>
            {
                new ImageModel { ImageUrl = "gojo.png" },
                new ImageModel { ImageUrl = "gojo2.png" },
                new ImageModel { ImageUrl = "carousel1.png" }
            };
        }
    }
    public class ImageModel
    {
        public string ImageUrl { get; set; }
    }

