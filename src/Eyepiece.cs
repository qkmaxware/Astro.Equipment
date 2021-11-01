using System;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Equipment {

    public partial class Eyepiece {
        public string Manufacturer {get; set;}
        public string Model {get; set;}

        public Length FocalLength {get; set;}
        public Angle FieldOfView {get; set;}

    }

}