using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Equipment {
    public partial class Camera {
        public static IEnumerable<Camera> Catalogue => catalogue.AsReadOnly();

        public static List<Camera> catalogue = new List<Camera> {
            new Camera {
                Manufacturer = "ALCCD",
                Model = "QHY-21c",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = (1940),
                    Height = (1460)
                }
            },
            new Camera {
                Manufacturer = "ALCCD",
                Model = "QHY-22c",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = (2758),
                    Height = (2208)
                }
            },
            new Camera {
                Manufacturer = "ALCCD",
                Model = "QHY-23c",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3388,
                    Height = 2712
                }
            },
            new Camera {
                Manufacturer = "Altair",
                Model = "GPCAM2 AR0130 M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Altair Astro",
                Model = "GPCAM MT9M034M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Altair Astro",
                Model = "GPCAMV2 IMX224 C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Astro Video Systems",
                Model = "DSO-1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.00),
                    Height = Length.Micrometres(5.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 768,
                    Height = 494
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "11000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4008,
                    Height = 2672
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "16200 Mono / Colour",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4499,
                    Height = 3599
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "16ic",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 659,
                    Height = 494
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "314L Plus",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "320E",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.40),
                    Height = Length.Micrometres(4.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1620,
                    Height = 1220
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "383L+",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3362,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "4000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2048,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "4120EX",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.10),
                    Height = Length.Micrometres(3.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4242,
                    Height = 2830
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "414EX",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "420",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.40),
                    Height = Length.Micrometres(4.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1619,
                    Height = 1219
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "428EX",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1932,
                    Height = 1452
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "450",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2448,
                    Height = 2050
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "460EX",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2750,
                    Height = 2200
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "490EX",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3380,
                    Height = 2704
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "ACIS 12.3",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 3008
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "ACIS 2.4",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1216
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "ACIS 7.1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.50),
                    Height = Length.Micrometres(4.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3208,
                    Height = 2200
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "Apx60 (CosMOS)",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 9576,
                    Height = 6388
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "GP",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1296,
                    Height = 964
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "Horizon",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.80),
                    Height = Length.Micrometres(3.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4644,
                    Height = 3506
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "Infinity",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "One 6.0",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2750,
                    Height = 2200
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "One 9.0",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3380,
                    Height = 2704
                }
            },
            new Camera {
                Manufacturer = "Atik",
                Model = "Titan",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 659,
                    Height = 494
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "1000D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.71),
                    Height = Length.Micrometres(5.71)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3888,
                    Height = 2591
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "10D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.38),
                    Height = Length.Micrometres(7.38)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3072,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "1200D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "20D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.40),
                    Height = Length.Micrometres(6.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3520,
                    Height = 2344
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "30D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.42),
                    Height = Length.Micrometres(6.42)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3504,
                    Height = 2336
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "350D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.41),
                    Height = Length.Micrometres(6.41)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3456,
                    Height = 2304
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "450D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.10),
                    Height = Length.Micrometres(5.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4272,
                    Height = 2848
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "50d",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.70),
                    Height = Length.Micrometres(4.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4752,
                    Height = 3168
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "550D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "5DS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.13),
                    Height = Length.Micrometres(4.13)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 8988,
                    Height = 5792
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "5DSR",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.14),
                    Height = Length.Micrometres(4.14)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 8688,
                    Height = 5792
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "600D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "600D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.31),
                    Height = Length.Micrometres(4.31)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "60Da",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "6D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.54),
                    Height = Length.Micrometres(6.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5472,
                    Height = 3648
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "70D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.10),
                    Height = Length.Micrometres(4.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5472,
                    Height = 3648
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "760D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.70),
                    Height = Length.Micrometres(3.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6000,
                    Height = 4000
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "7D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 1000D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.71),
                    Height = Length.Micrometres(5.71)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3888,
                    Height = 2592
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 100D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5196,
                    Height = 3464
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 1100D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.18),
                    Height = Length.Micrometres(5.18)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4272,
                    Height = 2848
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 40D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.70),
                    Height = Length.Micrometres(5.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3888,
                    Height = 2592
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 500D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.68),
                    Height = Length.Micrometres(4.68)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4752,
                    Height = 3168
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 5D Mk11",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.40),
                    Height = Length.Micrometres(6.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5616,
                    Height = 3744
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 5D Mk111",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.25),
                    Height = Length.Micrometres(6.25)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5760,
                    Height = 3840
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 5D MkIV",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.30),
                    Height = Length.Micrometres(5.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6720,
                    Height = 4480
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 700D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5184,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 750D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.70),
                    Height = Length.Micrometres(3.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6024,
                    Height = 4022
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 7D mkII",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.10),
                    Height = Length.Micrometres(4.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5472,
                    Height = 3648
                }
            },
            new Camera {
                Manufacturer = "Canon",
                Model = "EOS 80D",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.70),
                    Height = Length.Micrometres(3.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6000,
                    Height = 4000
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "NexImage 10",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(1.67),
                    Height = Length.Micrometres(1.67)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3856,
                    Height = 2764
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Neximage 5",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.20),
                    Height = Length.Micrometres(2.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2592,
                    Height = 1944
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Neximage Burst",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "NexImage Solar System Imager",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.00),
                    Height = Length.Micrometres(3.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 720
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Nightscape 8300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Skyris 132",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Skyris 236",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.80),
                    Height = Length.Micrometres(2.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Skyris 274",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.40),
                    Height = Length.Micrometres(4.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1600,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Skyris 445",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Celestron",
                Model = "Skyris 618",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.60),
                    Height = Length.Micrometres(5.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 640,
                    Height = 480
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML 8300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML-09000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(12.00),
                    Height = Length.Micrometres(12.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3056,
                    Height = 3056
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML11002",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4008,
                    Height = 2672
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML16803",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML16803",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "ML50100",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 8176,
                    Height = 6132
                }
            },
            new Camera {
                Manufacturer = "FLI",
                Model = "Proline PL 16803",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "Fujifilm",
                Model = "X-T1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.80),
                    Height = Length.Micrometres(4.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4896,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Fujifilm",
                Model = "X-T1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.80),
                    Height = Length.Micrometres(4.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4869,
                    Height = 3264
                }
            },
            new Camera {
                Manufacturer = "Imaging Source",
                Model = "DMK 41AU02",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.65),
                    Height = Length.Micrometres(4.65)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1360,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "iNova",
                Model = "PLB-Cx",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Lacerta",
                Model = "MGEN-3",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Lacerta",
                Model = "MGEN-II",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.70),
                    Height = Length.Micrometres(4.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 582
                }
            },
            new Camera {
                Manufacturer = "Lumix",
                Model = "GH2",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4608,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "MallinCam",
                Model = "SkyRaider",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "Mallincam",
                Model = "SkyRaider 23DS Plus",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1216
                }
            },
            new Camera {
                Manufacturer = "Meade",
                Model = "DSI 2",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.30),
                    Height = Length.Micrometres(8.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 582
                }
            },
            new Camera {
                Manufacturer = "Meade",
                Model = "DSI III Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1360,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Meade",
                Model = "DSI-C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.60),
                    Height = Length.Micrometres(9.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 510,
                    Height = 492
                }
            },
            new Camera {
                Manufacturer = "Microsoft",
                Model = "HD Lifecam",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.10),
                    Height = Length.Micrometres(3.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 720
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "16803",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "G2-4000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2056,
                    Height = 2042
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "G3-1000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(24.00),
                    Height = Length.Micrometres(24.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1024,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "G3-11000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4032,
                    Height = 2688
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "G3-16200",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4540,
                    Height = 3640
                }
            },
            new Camera {
                Manufacturer = "Moravian",
                Model = "G3-16200",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4540,
                    Height = 3640
                }
            },
            new Camera {
                Manufacturer = "Moravian Instruments",
                Model = "G2-8300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3358,
                    Height = 2536
                }
            },
            new Camera {
                Manufacturer = "NIKON",
                Model = "D300S",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.50),
                    Height = Length.Micrometres(5.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4288,
                    Height = 2848
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D3300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.90),
                    Height = Length.Micrometres(3.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4000,
                    Height = 6000
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D5100",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.78),
                    Height = Length.Micrometres(4.78)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4928,
                    Height = 3264
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D5300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.92),
                    Height = Length.Micrometres(3.92)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6000,
                    Height = 4000
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D5500",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.89),
                    Height = Length.Micrometres(3.89)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6000,
                    Height = 4000
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D7000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.70),
                    Height = Length.Micrometres(4.70)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4991,
                    Height = 3280
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D70S",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.90),
                    Height = Length.Micrometres(7.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3008,
                    Height = 2000
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D750",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.97),
                    Height = Length.Micrometres(5.97)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6016,
                    Height = 4016
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D800",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.88),
                    Height = Length.Micrometres(4.88)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 7360,
                    Height = 4912
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "D810a",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.88),
                    Height = Length.Micrometres(4.88)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 7360,
                    Height = 4912
                }
            },
            new Camera {
                Manufacturer = "Nikon",
                Model = "V1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.41),
                    Height = Length.Micrometres(3.41)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3872,
                    Height = 2592
                }
            },
            new Camera {
                Manufacturer = "Olympus",
                Model = "E-PM1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.29),
                    Height = Length.Micrometres(4.29)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4032,
                    Height = 3024
                }
            },
            new Camera {
                Manufacturer = "Olympus",
                Model = "OMD Em-5 mk2",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.74),
                    Height = Length.Micrometres(3.74)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4608,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "Opticstar",
                Model = "DS-616C XL",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.80),
                    Height = Length.Micrometres(7.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3032,
                    Height = 2014
                }
            },
            new Camera {
                Manufacturer = "Orion",
                Model = "SSAG",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.20),
                    Height = Length.Micrometres(5.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Orion",
                Model = "StarShoot AutoGuider",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.20),
                    Height = Length.Micrometres(5.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Orion",
                Model = "StarShoot G3 Mono",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.60),
                    Height = Length.Micrometres(8.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 852
                }
            },
            new Camera {
                Manufacturer = "Orion",
                Model = "StarShoot IV",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.60),
                    Height = Length.Micrometres(3.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Panasonic",
                Model = "DMC-G3",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.77),
                    Height = Length.Micrometres(3.77)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4592,
                    Height = 3448
                }
            },
            new Camera {
                Manufacturer = "Panasonic",
                Model = "DMC-GH4",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4608,
                    Height = 3456
                }
            },
            new Camera {
                Manufacturer = "PCO Imaging",
                Model = "PCO Edge",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.50),
                    Height = Length.Micrometres(6.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2560,
                    Height = 2160
                }
            },
            new Camera {
                Manufacturer = "Pentax",
                Model = "K-30",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.80),
                    Height = Length.Micrometres(4.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4928,
                    Height = 3264
                }
            },
            new Camera {
                Manufacturer = "Phil Dyer",
                Model = "PD1",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.50),
                    Height = Length.Micrometres(6.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 582
                }
            },
            new Camera {
                Manufacturer = "Phillips",
                Model = "SPC900NC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.60),
                    Height = Length.Micrometres(5.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 640,
                    Height = 480
                }
            },
            new Camera {
                Manufacturer = "Player One",
                Model = "Mars-C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1944,
                    Height = 1096
                }
            },
            new Camera {
                Manufacturer = "Player One",
                Model = "Mars-M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1944,
                    Height = 1096
                }
            },
            new Camera {
                Manufacturer = "Player One",
                Model = "Neptune-C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3096,
                    Height = 2078
                }
            },
            new Camera {
                Manufacturer = "Player One",
                Model = "Neptune-C II",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2712,
                    Height = 1538
                }
            },
            new Camera {
                Manufacturer = "Player One",
                Model = "Neptune-M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3096,
                    Height = 2078
                }
            },
            new Camera {
                Manufacturer = "Point Grey",
                Model = "Blackfly IMX249",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1080
                }
            },
            new Camera {
                Manufacturer = "Point Grey",
                Model = "Chameleon3 IMX264",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2448,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "Point Grey",
                Model = "Chameleon3 IMX265",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2048,
                    Height = 1536
                }
            },
            new Camera {
                Manufacturer = "Point Grey Research",
                Model = "Chameleon Color 1/3&quot;",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1296,
                    Height = 964
                }
            },
            new Camera {
                Manufacturer = "Pt Grey",
                Model = "Grasshopper",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1440
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "09000A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(12.00),
                    Height = Length.Micrometres(12.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3056,
                    Height = 3056
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "10",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.05),
                    Height = Length.Micrometres(6.05)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3900,
                    Height = 2616
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "11",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4032,
                    Height = 2688
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "12",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.12),
                    Height = Length.Micrometres(5.12)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4610,
                    Height = 3080
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "128C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.97),
                    Height = Length.Micrometres(5.97)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6036,
                    Height = 4028
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "16200A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4540,
                    Height = 3630
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "163M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.80),
                    Height = Length.Micrometres(3.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4656,
                    Height = 3522
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "16803A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "168C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.80),
                    Height = Length.Micrometres(4.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4952,
                    Height = 3288
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "174M/C/GPS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "178M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3072,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "183M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5544,
                    Height = 3694
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "21",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.50),
                    Height = Length.Micrometres(4.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1940,
                    Height = 1460
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "22",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.50),
                    Height = Length.Micrometres(4.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2758,
                    Height = 2208
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "224C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "23",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3388,
                    Height = 2712
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "247C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.91),
                    Height = Length.Micrometres(3.91)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6024,
                    Height = 4024
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "268C PH/EB/Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6280,
                    Height = 4210
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "27",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.50),
                    Height = Length.Micrometres(5.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4964,
                    Height = 3332
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "28",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4932,
                    Height = 3300
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "29",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.50),
                    Height = Length.Micrometres(5.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6644,
                    Height = 4452
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "290M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1080
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "294M/C Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.63),
                    Height = Length.Micrometres(4.63)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4164,
                    Height = 2796
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "367C Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.88),
                    Height = Length.Micrometres(4.88)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 7376,
                    Height = 4938
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "410C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.94),
                    Height = Length.Micrometres(5.94)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6072,
                    Height = 4044
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "461",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 11760,
                    Height = 8896
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.20),
                    Height = Length.Micrometres(5.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-II-M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.60),
                    Height = Length.Micrometres(5.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-174M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-178M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3072,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-185C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-224C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-290M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1080
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5-III-462C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1080
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "550M/C/P",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2464,
                    Height = 2056
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5L-II-M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5P-II-M/C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.20),
                    Height = Length.Micrometres(2.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2592,
                    Height = 1944
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "5R-II-C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.60),
                    Height = Length.Micrometres(5.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 720,
                    Height = 576
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "6",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.50),
                    Height = Length.Micrometres(6.50)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 582
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "600M/C L/PH/Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 9576,
                    Height = 6388
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "695A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2758,
                    Height = 2208
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "8",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.80),
                    Height = Length.Micrometres(7.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3000,
                    Height = 2000
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "814A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3468,
                    Height = 2728
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "8L/Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.80),
                    Height = Length.Micrometres(7.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3110,
                    Height = 2030
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "9/9S",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3358,
                    Height = 2536
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "90A",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3358,
                    Height = 2536
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "IMG132E",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.63),
                    Height = Length.Micrometres(3.63)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1329,
                    Height = 1049
                }
            },
            new Camera {
                Manufacturer = "QHY",
                Model = "miniCAM5",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "532 wsg",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.80),
                    Height = Length.Micrometres(6.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2184,
                    Height = 1472
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "583",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "6120",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.10),
                    Height = Length.Micrometres(3.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4250,
                    Height = 2838
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "616",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1536,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "6162",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4499,
                    Height = 3599
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "632",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.80),
                    Height = Length.Micrometres(6.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2184,
                    Height = 1472
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "660",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2758,
                    Height = 2208
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "683",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "QSI",
                Model = "690",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3388,
                    Height = 2712
                }
            },
            new Camera {
                Manufacturer = "RasberryPi v2",
                Model = "Sony IMX219 PQ CMOS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(1.12),
                    Height = Length.Micrometres(1.12)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3280,
                    Height = 2464
                }
            },
            new Camera {
                Manufacturer = "Raspberry pi Camera",
                Model = "version 1.3",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(1.40),
                    Height = Length.Micrometres(1.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2592,
                    Height = 1944
                }
            },
            new Camera {
                Manufacturer = "S-BIG",
                Model = "ST 8300C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "ST-1001E",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(24.00),
                    Height = Length.Micrometres(24.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1024,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "ST-10XME",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.80),
                    Height = Length.Micrometres(6.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2184,
                    Height = 1472
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "ST-2000XM",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1600,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "ST-237",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 640,
                    Height = 480
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "STF-8300",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2,
                    Height = 2
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "STF-8300M",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.20),
                    Height = Length.Micrometres(5.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "STL-1001e",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(24.00),
                    Height = Length.Micrometres(24.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1024,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "SBIG",
                Model = "STX-16803",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "A100",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.10),
                    Height = Length.Micrometres(6.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3872,
                    Height = 2592
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "A580",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.76),
                    Height = Length.Micrometres(4.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4912,
                    Height = 3264
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "A7s",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.40),
                    Height = Length.Micrometres(8.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4240,
                    Height = 2832
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "Alpha 3000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.30),
                    Height = Length.Micrometres(4.30)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5456,
                    Height = 3632
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "Alpha a6000",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.88),
                    Height = Length.Micrometres(3.88)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6000,
                    Height = 4000
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "Alpha a55",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.75),
                    Height = Length.Micrometres(4.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4912,
                    Height = 3264
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "NEX 5N",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.00),
                    Height = Length.Micrometres(5.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4592,
                    Height = 3056
                }
            },
            new Camera {
                Manufacturer = "Sony",
                Model = "Playstation Eye",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 640,
                    Height = 480
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "CoStar",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.20),
                    Height = Length.Micrometres(5.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1304,
                    Height = 1024
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "H16",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2048,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Lodestar",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.20),
                    Height = Length.Micrometres(8.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 580
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Lodestar C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.60),
                    Height = Length.Micrometres(8.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 580
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Lodestar X2",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(8.20),
                    Height = Length.Micrometres(8.20)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 752,
                    Height = 580
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Superstar",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.65),
                    Height = Length.Micrometres(4.65)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "SX Trius CSX-249 CMOS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1200
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "SX Trius CSX-290 CMOS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1945,
                    Height = 1097
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "SX Trius CSX-304 CMOS",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.45),
                    Height = Length.Micrometres(3.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 3000
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "SXVR-H18",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.40),
                    Height = Length.Micrometres(5.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3326,
                    Height = 2504
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "SXVR-H9",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius PRO-834",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.10),
                    Height = Length.Micrometres(3.10)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4240,
                    Height = 2824
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-16",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2048,
                    Height = 2048
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-25C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.80),
                    Height = Length.Micrometres(7.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3024,
                    Height = 2016
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-26C",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.05),
                    Height = Length.Micrometres(6.05)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3900,
                    Height = 2616
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-46",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.00),
                    Height = Length.Micrometres(6.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4540,
                    Height = 3640
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-56",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4096,
                    Height = 4096
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX-9",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-35",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.00),
                    Height = Length.Micrometres(9.00)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4032,
                    Height = 2688
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-36",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(7.40),
                    Height = Length.Micrometres(7.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4904,
                    Height = 3280
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-674",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1940,
                    Height = 1460
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-694",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.54),
                    Height = Length.Micrometres(4.54)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 2750,
                    Height = 2200
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-814",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.69),
                    Height = Length.Micrometres(3.69)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3380,
                    Height = 2704
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Trius SX/PRO-825",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.40),
                    Height = Length.Micrometres(6.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Starlight Xpress",
                Model = "Ultrastar",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(6.45),
                    Height = Length.Micrometres(6.45)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1392,
                    Height = 1040
                }
            },
            new Camera {
                Manufacturer = "Toucam Pro",
                Model = "SC4",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(9.90),
                    Height = Length.Micrometres(9.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 659,
                    Height = 494
                }
            },
            new Camera {
                Manufacturer = "ToupTek",
                Model = "GCMOS01200KMA Mono Imager/Guider",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "ToupTek",
                Model = "GCMOS01200KPA Colour Imager/Guider",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI034MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.60),
                    Height = Length.Micrometres(5.60)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 728,
                    Height = 512
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI071MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.78),
                    Height = Length.Micrometres(4.78)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4944,
                    Height = 3284
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI094MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.88),
                    Height = Length.Micrometres(4.88)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 7736,
                    Height = 4928
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI120MC-S",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI120MM/MC/Mini",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1280,
                    Height = 960
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI128MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.97),
                    Height = Length.Micrometres(5.97)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6032,
                    Height = 4032
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI1600",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.80),
                    Height = Length.Micrometres(3.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4656,
                    Height = 3520
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI1600MM/MC/GT",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.80),
                    Height = Length.Micrometres(3.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4656,
                    Height = 3520
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI174MM/MC/Mini",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.86),
                    Height = Length.Micrometres(5.86)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1216
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI178MM/MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3096,
                    Height = 2080
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI183MM/MC/GT",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.40),
                    Height = Length.Micrometres(2.40)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 5496,
                    Height = 3672
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI185MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1944,
                    Height = 1224
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI185MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3840,
                    Height = 2160
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI224MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1304,
                    Height = 976
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI2400MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.94),
                    Height = Length.Micrometres(5.94)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6072,
                    Height = 4042
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI2600MM/MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 6248,
                    Height = 4176
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI290MM/MC/Mini",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1096
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI294MM/MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(4.63),
                    Height = Length.Micrometres(4.63)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 4144,
                    Height = 2822
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI385MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.75),
                    Height = Length.Micrometres(3.75)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1096
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI462MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(2.90),
                    Height = Length.Micrometres(2.90)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1936,
                    Height = 1096
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI482MC",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(5.80),
                    Height = Length.Micrometres(5.80)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 1920,
                    Height = 1080
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI533MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution =  new Dimension2D<int> {
                    Width = 3008,
                    Height = 3008
                }
            },
            new Camera {
                Manufacturer = "ZWO",
                Model = "ASI6200MM/MC-Pro",
                PixelSize =  new Dimension2D<Length> {
                    Width = Length.Micrometres(3.76),
                    Height = Length.Micrometres(3.76)
                },
                Resolution = new Dimension2D<int> {
                    Width = 9576,
                    Height = 6388
                }
            },
        };
    }

}