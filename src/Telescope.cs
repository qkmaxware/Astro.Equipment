using System;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Equipment {
    public partial class Telescope {
        public string Manufacturer {get; set;}
        public string Model {get; set;}

        public Length FocalLength {get; set;}
        public Length Aperture {get; set;}

        public override string ToString() => $"{Manufacturer} - {Model}";

        private static Angle arcseconds(double value) {
            return Angle.DegreesMinutesSeconds(0, 0, value);
        }

        #region Derived

        public double FocalRatio => (double)(FocalLength.TotalMillimetres() / Aperture.TotalMillimetres());
        public Angle DawesLimit => arcseconds(116 / (double)Aperture.TotalMillimetres());
        public Angle RayleighLimit => arcseconds(138 / (double)Aperture.TotalMillimetres());

        #endregion

        #region Eyepiece Math
        public Length FocalLengthWithLens(Lens barlow)  {
            return (barlow == null) ? this.FocalLength : this.FocalLength * barlow.Multiplier;
        }
        public double Magnification(Eyepiece eyepiece, Lens barlow = null) {
            var fl = FocalLengthWithLens(barlow);
            return (double)(fl.TotalMillimetres() / eyepiece.FocalLength.TotalMillimetres());
        }

        public Angle FieldOfView(Eyepiece eyepiece, Lens barlow = null) {
            var magnification = Magnification(eyepiece, barlow);
            var telescope_fov = eyepiece.FieldOfView.TotalDegrees() / magnification;
            return Angle.Degrees(telescope_fov);
        }

        public Length ExitPupilDistance(Eyepiece eyepiece, Lens barlow = null) {
            var magnification = Magnification(eyepiece, barlow);
            var eyepiece_fov = this.Aperture.TotalMillimetres() / magnification;
            return Length.Millimetres(eyepiece_fov);
        }

        #endregion

        #region CCD Math

        public Angle HorizontalResolution(Camera ccd, Lens barlow = null, int binning = 1) {
            var fl = (double)FocalLengthWithLens(barlow).TotalMillimetres();

            var pixelSize = (double)ccd.PixelSize.Width.TotalMicrometres();
            var fl2 = 2 * fl;

            var resolution = (((2 * Math.Atan(((pixelSize * binning) / 1000) / fl2)) * 180) * 3600) / Math.PI;
            return arcseconds(resolution);
        }

        public Angle VerticalResolution(Camera ccd, Lens barlow = null, int binning = 1) {
            var fl = (double)FocalLengthWithLens(barlow).TotalMillimetres();

            var pixelSize = (double)ccd.PixelSize.Height.TotalMicrometres();
            var fl2 = 2 * fl;

            var resolution = (((2 * Math.Atan(((pixelSize * binning) / 1000) / fl2)) * 180) * 3600) / Math.PI;
            return arcseconds(resolution);
        }

        public Angle HorizontalFieldOfView(Camera ccd, Lens barlow = null, int binning = 1) {
            var fl = (double)FocalLengthWithLens(barlow).TotalMillimetres();
            var size = ccd.SensorSize;
            var width = ((double)size.Width.TotalMillimetres() * binning);

            // Angle of view (in degrees) = 2 ArcTan( sensor width / (2 X focal length)) * (180/π)
            var fov = 2 * Math.Atan(width / (2 * fl));
            return Angle.Radians(fov);
        }
        public Angle VerticalFieldOfView(Camera ccd, Lens barlow = null, int binning = 1) {
            var fl = (double)FocalLengthWithLens(barlow).TotalMillimetres();
            var size = ccd.SensorSize;
            var height = ((double)size.Height.TotalMillimetres() * binning);

            // Angle of view (in degrees) = 2 ArcTan( sensor height / (2 X focal length)) * (180/π)
            var fov = 2 * Math.Atan(height / (2 * fl));
            return Angle.Radians(fov);
        }

        #endregion*/
    }
}