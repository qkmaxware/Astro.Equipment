using System;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Equipment {
    public partial class Camera {
        public string Manufacturer;
        public string Model;
        public Dimension2D<Length> PixelSize;
        public Dimension2D<int> Resolution;
        public Dimension2D<Length> SensorSize => new Dimension2D<Length>{ 
            Width=PixelSize.Width * Resolution.Width, 
            Height=PixelSize.Height * Resolution.Height 
        };
        public override string ToString() => $"{Manufacturer} - {Model}";
    }

}