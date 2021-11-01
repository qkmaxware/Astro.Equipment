using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Equipment {
    public partial class Telescope {
        public static IEnumerable<Telescope> Catalogue => catalogue.AsReadOnly();

        public static List<Telescope> catalogue = new List<Telescope> {
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "Convergent 10\" f5",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1270.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 10\" f6.7",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1702.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 12.5\" f5",
                Aperture =  Length.Millimetres(317.50),
                FocalLength =  Length.Millimetres(1570.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 12.5\" f6.8",
                Aperture =  Length.Millimetres(312.00),
                FocalLength =  Length.Millimetres(2120.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 14.5 f5",
                Aperture =  Length.Millimetres(368.30),
                FocalLength =  Length.Millimetres(1841.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 14.5\" f6.7",
                Aperture =  Length.Millimetres(368.00),
                FocalLength =  Length.Millimetres(2464.00)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 17\" f6.7",
                Aperture =  Length.Millimetres(431.80),
                FocalLength =  Length.Millimetres(2895.60)
            },
            new Telescope {
                Manufacturer = "AG Optical",
                Model = "iDK 18\" f6.7",
                Aperture =  Length.Millimetres(457.20),
                FocalLength =  Length.Millimetres(3063.24)
            },
            new Telescope {
                Manufacturer = "Agena Astro",
                Model = "StarGuider II 50mm Finder",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(162.00)
            },
            new Telescope {
                Manufacturer = "Airdrie Observatory",
                Model = "Victorian Refractor",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(2250.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "60 EDF",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "60mm Mini Guider",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(225.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "72 EDF",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(432.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "80mm Finder",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(328.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "F4 Newtonian Astrograph",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1016.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Lightwave 60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Lightwave 66 ED",
                Aperture =  Length.Millimetres(66.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Lightwave 72 ED-R",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(432.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Lightwave 80 ED",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "RC-300 TT V3",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(2432.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "RC250TT",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "RC250TT",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 110",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 152 f5.9",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(896.80)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 152 V3 \"Red Tube\" Achromat",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 50mm Finder",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(206.60)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 70 EDQ-R",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 70ED",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Starwave 80 ED",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(555.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Wave 102 F7 ED Triplet",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(715.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Wave 115 ED",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(805.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Wave 130 EDT",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(905.00)
            },
            new Telescope {
                Manufacturer = "Altair",
                Model = "Wave 80",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Apertura",
                Model = "AD10 10\" Dobsonian",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Apertura",
                Model = "AD12 12\" Dobsonian",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1520.00)
            },
            new Telescope {
                Manufacturer = "Apertura",
                Model = "AD8 8\" Dobsonian",
                Aperture =  Length.Millimetres(203.20),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "100 ED Doublet 45-Degree Binocular",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(550.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "100 f5.5 Semi-Apo (gray)",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(550.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "107/700",
                Aperture =  Length.Millimetres(107.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "120 APO Binocular",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(660.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "123/738",
                Aperture =  Length.Millimetres(123.00),
                FocalLength =  Length.Millimetres(738.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "140 ED Doublet APO",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(980.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "140/980",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(980.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "152/1200",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "203/1800",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "304/3600",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(3600.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "80/480",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "LZOS 115 f7",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(805.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "LZOS 130/780",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(780.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "LZOS 130/780",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(780.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "LZOS 180 APO",
                Aperture =  Length.Millimetres(180.00),
                FocalLength =  Length.Millimetres(1260.00)
            },
            new Telescope {
                Manufacturer = "APM",
                Model = "MCT 406/4000",
                Aperture =  Length.Millimetres(406.00),
                FocalLength =  Length.Millimetres(4000.00)
            },
            new Telescope {
                Manufacturer = "Aquila",
                Model = "90/500",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Artesky",
                Model = "ARTEC 200",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(780.00)
            },
            new Telescope {
                Manufacturer = "ASA",
                Model = "10N",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(950.00)
            },
            new Telescope {
                Manufacturer = "ASA",
                Model = "400RC",
                Aperture =  Length.Millimetres(400.00),
                FocalLength =  Length.Millimetres(3200.00)
            },
            new Telescope {
                Manufacturer = "ASA",
                Model = "CA400",
                Aperture =  Length.Millimetres(400.00),
                FocalLength =  Length.Millimetres(3600.00)
            },
            new Telescope {
                Manufacturer = "ASA",
                Model = "N-250",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Ascension",
                Model = "102 f7",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Ascension",
                Model = "127ED APO ",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(952.00)
            },
            new Telescope {
                Manufacturer = "Ascension",
                Model = "80ED",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Askar",
                Model = "ACL200",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(200.00)
            },
            new Telescope {
                Manufacturer = "Askar",
                Model = "FMA180",
                Aperture =  Length.Millimetres(40.00),
                FocalLength =  Length.Millimetres(180.00)
            },
            new Telescope {
                Manufacturer = "Askar",
                Model = "FRA400",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Askar",
                Model = "FRA600",
                Aperture =  Length.Millimetres(108.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Astelco",
                Model = "TCC1",
                Aperture =  Length.Millimetres(1400.00),
                FocalLength =  Length.Millimetres(16800.00)
            },
            new Telescope {
                Manufacturer = "Astele",
                Model = "70/925",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(925.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "10” Maksutov",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(3708.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "130 EDF",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(780.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "155 f7",
                Aperture =  Length.Millimetres(155.00),
                FocalLength =  Length.Millimetres(1085.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "175 EDF F/8",
                Aperture =  Length.Millimetres(175.00),
                FocalLength =  Length.Millimetres(1400.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "AP 10\" Mak Cass",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(3650.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "RH305",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1159.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "Starfire 130 EDF",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(780.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "Starfire 152 f9 ",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1368.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "Stowaway",
                Aperture =  Length.Millimetres(92.00),
                FocalLength =  Length.Millimetres(604.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "TMB 180",
                Aperture =  Length.Millimetres(180.00),
                FocalLength =  Length.Millimetres(1635.00)
            },
            new Telescope {
                Manufacturer = "Astro Physics",
                Model = "Traveler 105",
                Aperture =  Length.Millimetres(105.00),
                FocalLength =  Length.Millimetres(610.00)
            },
            new Telescope {
                Manufacturer = "Astro Professional",
                Model = "102/714",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Astro Professional",
                Model = "110/770",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "Astro Professional",
                Model = "80/560",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(560.00)
            },
            new Telescope {
                Manufacturer = "Astro Systems",
                Model = "10\" f4 Newtonian",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Astro systems",
                Model = "20\" f3.9 Dobsonian",
                Aperture =  Length.Millimetres(508.00),
                FocalLength =  Length.Millimetres(1981.00)
            },
            new Telescope {
                Manufacturer = "Astro Systems",
                Model = "8\" f5 Newtonian",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "12\" Astrograph",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(2432.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT106EDT",
                Aperture =  Length.Millimetres(106.00),
                FocalLength =  Length.Millimetres(690.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT10INT",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1016.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT10RC",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT111ED",
                Aperture =  Length.Millimetres(7.00),
                FocalLength =  Length.Millimetres(777.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT115EDT",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(805.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT12INT",
                Aperture =  Length.Millimetres(304.80),
                FocalLength =  Length.Millimetres(1220.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT130EDT",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT130EDT",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT14RCT",
                Aperture =  Length.Millimetres(355.00),
                FocalLength =  Length.Millimetres(2850.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT152EDT",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1216.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT60ED",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(360.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT65EDQ",
                Aperture =  Length.Millimetres(6.60),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT65EDQ",
                Aperture =  Length.Millimetres(65.00),
                FocalLength =  Length.Millimetres(422.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT6RC",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1350.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT72ED",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(430.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT72EDii",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(432.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT80EDT",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT8IN",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT8RC",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1625.00)
            },
            new Telescope {
                Manufacturer = "Astro Tech",
                Model = "AT92 APO",
                Aperture =  Length.Millimetres(92.00),
                FocalLength =  Length.Millimetres(506.00)
            },
            new Telescope {
                Manufacturer = "Astronomers Without Borders",
                Model = "Onesky",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "107FL @ f/6",
                Aperture =  Length.Millimetres(107.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "107FL F/3.9ED",
                Aperture =  Length.Millimetres(107.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "107FL f/5.6",
                Aperture =  Length.Millimetres(107.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "36ED @ f/6.0",
                Aperture =  Length.Millimetres(36.00),
                FocalLength =  Length.Millimetres(216.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "45EDII @ f/5.0",
                Aperture =  Length.Millimetres(45.00),
                FocalLength =  Length.Millimetres(227.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "50FL @ f/5.6",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(280.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "55FL @ f/3.6",
                Aperture =  Length.Millimetres(55.00),
                FocalLength =  Length.Millimetres(200.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "55FL @ f/4.5",
                Aperture =  Length.Millimetres(55.00),
                FocalLength =  Length.Millimetres(250.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "60ED @ f4",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(245.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "67FL @ f/3.8",
                Aperture =  Length.Millimetres(67.00),
                FocalLength =  Length.Millimetres(255.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "67FL @ f/4.5",
                Aperture =  Length.Millimetres(67.00),
                FocalLength =  Length.Millimetres(300.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "71FL @ 3.7",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(264.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "71FL @ f/3.9",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(277.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "71FL @ f/4",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(280.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "71FL @ f/5.6",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "71FL @ f/6.0",
                Aperture =  Length.Millimetres(67.00),
                FocalLength =  Length.Millimetres(426.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "76-ED",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "77EDII @ f/4.3",
                Aperture =  Length.Millimetres(77.00),
                FocalLength =  Length.Millimetres(331.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "77EDII @ f/4.6",
                Aperture =  Length.Millimetres(77.00),
                FocalLength =  Length.Millimetres(354.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "77EDII @ f/6.6",
                Aperture =  Length.Millimetres(77.00),
                FocalLength =  Length.Millimetres(510.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "89ED @ f/4.3",
                Aperture =  Length.Millimetres(89.00),
                FocalLength =  Length.Millimetres(382.70)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "89ED @ f/4.7",
                Aperture =  Length.Millimetres(89.00),
                FocalLength =  Length.Millimetres(418.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "89ED @ f/6.7",
                Aperture =  Length.Millimetres(89.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "90FL @ f/3.6",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(324.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "90FL @ f/4",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(360.00)
            },
            new Telescope {
                Manufacturer = "Borg",
                Model = "90FL @ f/5.6",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "6\" Planetary Dobsonian",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "AR-127S",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(635.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "AR-152S",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(760.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "AR127L",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "Messier 10\"",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1270.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "Messier 102/1000",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Bresser",
                Model = "Messier Dobsonian",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1218.00)
            },
            new Telescope {
                Manufacturer = "Bresser-Messier",
                Model = "R152s",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(760.00)
            },
            new Telescope {
                Manufacturer = "Canon",
                Model = "200mm f 2.8 lens",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(200.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "102 SLT",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(660.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "114 GT",
                Aperture =  Length.Millimetres(114.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "127 SLT",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "130 SLT",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "14\" Edge HD + Hyperstar",
                Aperture =  Length.Millimetres(355.60),
                FocalLength =  Length.Millimetres(675.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "14\" Rowe Ackermann Schmidt Astrograph",
                Aperture =  Length.Millimetres(355.60),
                FocalLength =  Length.Millimetres(790.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "8” Rowe-Ackermann Schmidt Astrograph",
                Aperture =  Length.Millimetres(203.20),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "80 SLT",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "90 SLT",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Advanced VX 5 SCT",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Astro Fi 102mm Maksutov",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1325.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Astro Fi 125mm/5\" SCT",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Astro Fi 130mm Newtonian",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Astro Fi 6\" SCT",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster 114EQ",
                Aperture =  Length.Millimetres(114.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster 130EQ",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster 70EQ/AZ",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster 80EQ",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster 90 EQ/AZ",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster LT 60AZ",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster LT 70AZ",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "AstroMaster LT 76AZ",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C100 ED",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C11 + Hyperstar",
                Aperture =  Length.Millimetres(280.00),
                FocalLength =  Length.Millimetres(560.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C11 EDGE HD",
                Aperture =  Length.Millimetres(279.00),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C11 EdgeHD + HyperStar v4",
                Aperture =  Length.Millimetres(279.40),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C11 SCT",
                Aperture =  Length.Millimetres(279.40),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C11 SCT",
                Aperture =  Length.Millimetres(280.00),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C14 EDGE HD",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(3910.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C14 SCT",
                Aperture =  Length.Millimetres(355.50),
                FocalLength =  Length.Millimetres(3910.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C14 SCT",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(3910.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C5 SCT (aka Spotting Scope)",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C6 SCT",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C6N",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C6R",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8 EDGE HD",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8 Edge HD + Hyperstar v3",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(425.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8 Edge HD + Hyperstar v4",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(390.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8 SCT",
                Aperture =  Length.Millimetres(203.20),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8N",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C8N Advanced VX",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C9.25 + Hyperstar",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C9.25 EDGE HD",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(2350.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C9.25 SCT",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(2350.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C90 Mak",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "C925 Edge HD + Hyperstar",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 1100 Deluxe HD",
                Aperture =  Length.Millimetres(280.00),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 1100 Edge HD",
                Aperture =  Length.Millimetres(280.00),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 1100 GPS",
                Aperture =  Length.Millimetres(279.00),
                FocalLength =  Length.Millimetres(2800.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 800 Deluxe HD",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 800 GPS",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 800 SCT",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 925 Deluxe HD",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(2350.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "CPC 925 GPS",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(2350.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Firstscope 76",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(296.40)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 102GT",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 4SE",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1325.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 5 SLT",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 5SE",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 6 SLT",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 6SE",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar 8SE",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar Evolution 5",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar Evolution 6",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar Evolution 8",
                Aperture =  Length.Millimetres(203.20),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "NexStar Evolution 9.25",
                Aperture =  Length.Millimetres(235.00),
                FocalLength =  Length.Millimetres(2350.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Omni XLT 102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Omni XLT 120",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Omni XLT 127",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Omni XLT 150 (Newtonian)",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Omni XLT 150-R (Refractor)",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Powerseeker 70",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Rowe-Ackermann Astrograph",
                Aperture =  Length.Millimetres(279.00),
                FocalLength =  Length.Millimetres(620.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Skyprodigy 6 SCT",
                Aperture =  Length.Millimetres(155.00),
                FocalLength =  Length.Millimetres(1550.00)
            },
            new Telescope {
                Manufacturer = "Celestron",
                Model = "Travel Scope 70",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "CFF",
                Model = "92mm",
                Aperture =  Length.Millimetres(92.00),
                FocalLength =  Length.Millimetres(550.00)
            },
            new Telescope {
                Manufacturer = "CFF Telescopes",
                Model = "250mm RC f15",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(3750.00)
            },
            new Telescope {
                Manufacturer = "Coronado",
                Model = "PST",
                Aperture =  Length.Millimetres(40.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Coronado",
                Model = "Solarmax II 60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Coronado",
                Model = "SolarMax II 60mm",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Custom",
                Model = "16\" f5 Dobsonian",
                Aperture =  Length.Millimetres(400.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "D & G Optical",
                Model = "Refractor",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1905.00)
            },
            new Telescope {
                Manufacturer = "DarkStar",
                Model = "14\" f4.5 Dobsonian",
                Aperture =  Length.Millimetres(355.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "David Lukehurst",
                Model = "18\" F4 Dobsonian",
                Aperture =  Length.Millimetres(456.00),
                FocalLength =  Length.Millimetres(1824.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "102mm ED APO Triplet Essential",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "127ed",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(952.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "208 f3.9 Newtonian",
                Aperture =  Length.Millimetres(208.00),
                FocalLength =  Length.Millimetres(812.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "208mm f3.9",
                Aperture =  Length.Millimetres(205.00),
                FocalLength =  Length.Millimetres(812.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "AR102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(663.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "AR127",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(826.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "AR152",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(988.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "Comet Hunter",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(731.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "ED115 f/5.5",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(632.00)
            },
            new Telescope {
                Manufacturer = "Explore Scientific",
                Model = "ES 80 APO",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "10\" Newton f5",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "12\" f4 Truss Newtonian",
                Aperture =  Length.Millimetres(302.00),
                FocalLength =  Length.Millimetres(1204.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "12\" Newtonian (various)",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "12\" RC (various)",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(2432.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "14\" RC (various)",
                Aperture =  Length.Millimetres(355.00),
                FocalLength =  Length.Millimetres(2854.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "200mm f4",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "6\" Newton f5",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "8\" f/12 Classical Cassegrain",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2346.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "Carbon Fibre Newton 8\" f/5",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "RC6",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1370.00)
            },
            new Telescope {
                Manufacturer = "GSO",
                Model = "RC8 Carbon Fibre 8\" f/8",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1625.00)
            },
            new Telescope {
                Manufacturer = "Ikharos",
                Model = "10\" RC",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Ikharos",
                Model = "200mm RC",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "iOptron",
                Model = "Photron 6\" RC",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1370.00)
            },
            new Telescope {
                Manufacturer = "iOptron",
                Model = "Photron 8\" RC",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1624.00)
            },
            new Telescope {
                Manufacturer = "Istar",
                Model = "Perseus AT150-12",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Lunt",
                Model = "80 THa",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(560.00)
            },
            new Telescope {
                Manufacturer = "Lunt",
                Model = "LS100THa",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Lunt",
                Model = "LS35 THa",
                Aperture =  Length.Millimetres(35.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Lunt",
                Model = "LS50 THa",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Lunt",
                Model = "LS60 THa",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "10\" LX-850 ACF",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "10\" LX200",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "12\" ACF f/8",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(2438.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "130mm f7 Series 6000",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "14\" ACF",
                Aperture =  Length.Millimetres(355.60),
                FocalLength =  Length.Millimetres(2845.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "14\" LX600 ACF",
                Aperture =  Length.Millimetres(14.00),
                FocalLength =  Length.Millimetres(2845.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "14\" LX850 ACF",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "5000 80mm f6 Apo",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "5000 series Triplet Apo",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "8\" ACF",
                Aperture =  Length.Millimetres(203.50),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "8\" f6.3 LX200",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1280.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "8\" LX200",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1280.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "8\" LX200",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1280.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "DS-114",
                Aperture =  Length.Millimetres(114.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "ETX 105",
                Aperture =  Length.Millimetres(105.00),
                FocalLength =  Length.Millimetres(1470.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "ETX-125",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(1900.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "ETX-60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "ETX-80",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "ETX-90",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LightBridge Mini",
                Aperture =  Length.Millimetres(114.00),
                FocalLength =  Length.Millimetres(450.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LS 6 ACF",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1520.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX 800",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX10",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX10",
                Aperture =  Length.Millimetres(203.20),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200 10\"",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2540.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200 12\"",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(3048.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200 16\"",
                Aperture =  Length.Millimetres(406.40),
                FocalLength =  Length.Millimetres(4064.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200 7\"",
                Aperture =  Length.Millimetres(178.00),
                FocalLength =  Length.Millimetres(2670.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200GPS",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(3556.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX200GPS 14\"",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(3556.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX600",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(2438.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LX90",
                Aperture =  Length.Millimetres(2030.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "LXD SN-10 AT",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1016.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "RCX 400",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(2032.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "RCX400 14\"",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(2845.00)
            },
            new Telescope {
                Manufacturer = "Meade",
                Model = "SN8 Schmidt Newtonian",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(812.00)
            },
            new Telescope {
                Manufacturer = "Obsession UC 18\"",
                Model = "UC 18\"",
                Aperture =  Length.Millimetres(457.00),
                FocalLength =  Length.Millimetres(1905.00)
            },
            new Telescope {
                Manufacturer = "Omegon",
                Model = "127 ED APO",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(952.00)
            },
            new Telescope {
                Manufacturer = "Omegon",
                Model = "127mm Maksutov",
                Aperture =  Length.Millimetres(1900.00),
                FocalLength =  Length.Millimetres(127.00)
            },
            new Telescope {
                Manufacturer = "Omegon",
                Model = "72mm",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "10\" f/3.9 Newtonian Astrograph",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "110 Duplex",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "120mm f/5.0 (short)",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "120mm f5 (short)",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "120mm f8.3 (long)",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "150mm Maksutov",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "50mm Guidescope",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(169.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "6\" RC",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1370.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "8\" f/3.9 Newtonian Astrograph",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "8\" RC",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "8\" Reflector F4.9",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "80ED APO f6.26",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Apex 127",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1540.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "ED 80mm",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "ED80T CF",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "EON",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(660.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "EON 115mm ED",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(805.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "EON 130",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "GoScope 80mm",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(350.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Guidescope 60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(240.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Guidescope 60mm",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(240.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Guidescope 70",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(279.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Mini Guidescope",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(162.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Premium 110 ED",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "RC 8\"",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "Short Tube 80",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "SkyQuest XT10",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "SkyQuest XT10g",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "SpaceProbe 130ST EQ",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "XT-10",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion",
                Model = "XT8",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1256.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "10\" VX10",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "12\" VX f4",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "300mm F/5.3 Newtonian",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(1590.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "ODK10",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(1700.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "ODK16",
                Aperture =  Length.Millimetres(400.00),
                FocalLength =  Length.Millimetres(2720.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "OMC 250",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(2250.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "OMC140",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "VX6",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "VX6L",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics",
                Model = "VX8",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics UK",
                Model = "250mm SPX",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics UK",
                Model = "DX300",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics UK",
                Model = "Europa 150",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Orion Optics UK",
                Model = "Europa 200",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Ostara",
                Model = "102ED",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "pentax",
                Model = "105sdhf",
                Aperture =  Length.Millimetres(105.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "pentax",
                Model = "75sdhf",
                Aperture =  Length.Millimetres(75.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "PlaneWave",
                Model = "12.5\" CDK",
                Aperture =  Length.Millimetres(320.00),
                FocalLength =  Length.Millimetres(2541.00)
            },
            new Telescope {
                Manufacturer = "PlaneWave",
                Model = "14\" CDK",
                Aperture =  Length.Millimetres(356.00),
                FocalLength =  Length.Millimetres(2563.00)
            },
            new Telescope {
                Manufacturer = "PlaneWave",
                Model = "17\" CDK",
                Aperture =  Length.Millimetres(432.00),
                FocalLength =  Length.Millimetres(2939.00)
            },
            new Telescope {
                Manufacturer = "Planewave",
                Model = "24\" RC",
                Aperture =  Length.Millimetres(610.00),
                FocalLength =  Length.Millimetres(3962.00)
            },
            new Telescope {
                Manufacturer = "Planewave",
                Model = "CDK700",
                Aperture =  Length.Millimetres(700.00),
                FocalLength =  Length.Millimetres(4531.00)
            },
            new Telescope {
                Manufacturer = "PlaneWave",
                Model = "PW1000",
                Aperture =  Length.Millimetres(1000.00),
                FocalLength =  Length.Millimetres(6000.00)
            },
            new Telescope {
                Manufacturer = "Primaluce",
                Model = "Airy APO 65F",
                Aperture =  Length.Millimetres(65.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "QHY",
                Model = "Mini Guidescope",
                Aperture =  Length.Millimetres(30.00),
                FocalLength =  Length.Millimetres(130.00)
            },
            new Telescope {
                Manufacturer = "Radian",
                Model = "Raptor 61",
                Aperture =  Length.Millimetres(61.00),
                FocalLength =  Length.Millimetres(275.00)
            },
            new Telescope {
                Manufacturer = "Relevation",
                Model = "Dobsonian 12\"  f/5",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1520.00)
            },
            new Telescope {
                Manufacturer = "Revelation",
                Model = "12\" f5 Dobsonian",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(1520.00)
            },
            new Telescope {
                Manufacturer = "Saxon",
                Model = "8\" Dobsonian Telescope",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "100QII",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(580.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "107H APO",
                Aperture =  Length.Millimetres(107.00),
                FocalLength =  Length.Millimetres(700.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "121SDQ",
                Aperture =  Length.Millimetres(121.00),
                FocalLength =  Length.Millimetres(678.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "140PH",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "15028HNT",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "20032PNT",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(640.00)
            },
            new Telescope {
                Manufacturer = "Sharpstar",
                Model = "61 EDPH II",
                Aperture =  Length.Millimetres(61.00),
                FocalLength =  Length.Millimetres(335.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "76EDPH",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(418.00)
            },
            new Telescope {
                Manufacturer = "SharpStar",
                Model = "94EDPH",
                Aperture =  Length.Millimetres(94.00),
                FocalLength =  Length.Millimetres(517.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "9x50 Finder",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(180.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Equinox 100 Pro",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Equinox 120 Pro",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Equinox 80 Pro",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Esprit 100 Quintuplet",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Esprit 100ED",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(550.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Esprit 120ED",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(840.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Esprit 150ED",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1050.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Esprit 80ED",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "EvoGuide 50ED",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(242.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 100ED DS-Pro",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 120",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 120ED DS-Pro",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 150",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 150ED DS-Pro",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 72ED",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 80ED DS-Pro",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Evostar 90 f10",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 130 / 130M",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 130P / P-DS",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 150P / P-DS",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 150PDS",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 150PL",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 190MN DS-Pro",
                Aperture =  Length.Millimetres(190.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 200P / P-DS",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 250P / P-DS",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Explorer 300P / P-DS",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Heritage 100p reflector",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Heritage 130P",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Heritage 150P",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Heritage 90 Virtuoso",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Heritage-114p Virtuoso",
                Aperture =  Length.Millimetres(114.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Quattro 10\" f4",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Quattro 8\" f4",
                Aperture =  Length.Millimetres(205.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner / Classic 150P",
                Aperture =  Length.Millimetres(153.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner / Classic 200P",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner / Classic 300P",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 250PX",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 300P Flextube",
                Aperture =  Length.Millimetres(305.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 350P ",
                Aperture =  Length.Millimetres(355.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 350P FlexTube",
                Aperture =  Length.Millimetres(355.00),
                FocalLength =  Length.Millimetres(1650.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 400P",
                Aperture =  Length.Millimetres(406.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skyliner 400P Flextube",
                Aperture =  Length.Millimetres(406.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skymax 102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(1300.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skymax 127",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skymax 150 Pro",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Skymax 180 PRO",
                Aperture =  Length.Millimetres(180.00),
                FocalLength =  Length.Millimetres(2700.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Star Discovery 150P",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Star Discovery 90i",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Stargate 450P",
                Aperture =  Length.Millimetres(458.00),
                FocalLength =  Length.Millimetres(1900.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Stargate 500P",
                Aperture =  Length.Millimetres(508.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Startravel 120",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Startravel 150",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(750.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Startravel 80",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Sky-Watcher",
                Model = "Startravel-102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Skywatcher",
                Model = "Equinox 66 ED",
                Aperture =  Length.Millimetres(66.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Skywatcher",
                Model = "Skymax",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1500.00)
            },
            new Telescope {
                Manufacturer = "Solomark",
                Model = "F60 Guidescope",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(215.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "10\" F/12 M-LRC Classical Cassegrains Truss",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(3045.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "10\" f/5 Dobsonian",
                Aperture =  Length.Millimetres(254.00),
                FocalLength =  Length.Millimetres(1250.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "10\" F/8 Ritchey-Chrétien",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(2000.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "12\" f/5 Dobsonian",
                Aperture =  Length.Millimetres(304.00),
                FocalLength =  Length.Millimetres(1520.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "12\" F/8 Ritchey-Chrétien",
                Aperture =  Length.Millimetres(300.00),
                FocalLength =  Length.Millimetres(2400.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "16\" f/4.5 Truss Dobsonian",
                Aperture =  Length.Millimetres(406.00),
                FocalLength =  Length.Millimetres(1829.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "6\" F/12 M-CRF Classical Cassegrain",
                Aperture =  Length.Millimetres(153.00),
                FocalLength =  Length.Millimetres(1836.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "6\" f/8 Dobsonian",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "6\" F/9 M-CRF Ritchey-Chrétien",
                Aperture =  Length.Millimetres(153.00),
                FocalLength =  Length.Millimetres(1370.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "8\" F/12 M-LRS Classical Cassegrain",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(2436.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "8\" f/6 Dobsonian",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "StellaLyra",
                Model = "8\" F/8 M-LRS Ritchey-Chrétien",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1600.00)
            },
            new Telescope {
                Manufacturer = "StellaMira",
                Model = "104mm ED2 Triplet",
                Aperture =  Length.Millimetres(104.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "StellaMira",
                Model = "80mm ED f/10",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "StellaMira",
                Model = "85mm ED2 Triplet",
                Aperture =  Length.Millimetres(85.00),
                FocalLength =  Length.Millimetres(560.00)
            },
            new Telescope {
                Manufacturer = "StellaMira",
                Model = "90mm ED Triplet",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "102T",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "80mm APO Triplet",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "90mm f7 APO",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(630.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "Access",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(560.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "Finderscope 13x80 RA",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(300.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV-SV60EDS",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(330.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV105T",
                Aperture =  Length.Millimetres(105.00),
                FocalLength =  Length.Millimetres(735.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV105T",
                Aperture =  Length.Millimetres(105.00),
                FocalLength =  Length.Millimetres(735.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV110ED 25SV",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV125-Access ED (doublet) ",
                Aperture =  Length.Millimetres(125.00),
                FocalLength =  Length.Millimetres(975.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV60EDS",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(330.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SV70T",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVA 130T",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVQ-100",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(580.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVR 90T",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(630.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVR 90T-25SV",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(630.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVR90T-25SV",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(630.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX080T",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX102T",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX102T-R",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX127D",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(1016.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX130T",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX140T",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(938.00)
            },
            new Telescope {
                Manufacturer = "Stellarvue",
                Model = "SVX152T (triplet)",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "Stellavue",
                Model = "130T-IS",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "106ED",
                Aperture =  Length.Millimetres(106.00),
                FocalLength =  Length.Millimetres(530.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "CN212 Cassegrain",
                Aperture =  Length.Millimetres(212.00),
                FocalLength =  Length.Millimetres(2635.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "CN212 Newton",
                Aperture =  Length.Millimetres(212.00),
                FocalLength =  Length.Millimetres(835.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Epsilon 130-ED",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(430.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Epsilon 130D",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(430.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Epsilon 180 ED",
                Aperture =  Length.Millimetres(180.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-100DC",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(740.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-100DL",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-76 DS",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(417.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-76DCU",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(570.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FC-76DS",
                Aperture =  Length.Millimetres(76.00),
                FocalLength =  Length.Millimetres(550.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FOA-60",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(530.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FOA-60Q",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(901.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FS 102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(820.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FS-60CB",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(355.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FS-60Q",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FSQ-106",
                Aperture =  Length.Millimetres(106.00),
                FocalLength =  Length.Millimetres(530.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FSQ-106EDX4",
                Aperture =  Length.Millimetres(106.00),
                FocalLength =  Length.Millimetres(530.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FSQ-130ED",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "FSQ-85EDX",
                Aperture =  Length.Millimetres(85.00),
                FocalLength =  Length.Millimetres(450.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Mewlon 180C",
                Aperture =  Length.Millimetres(180.00),
                FocalLength =  Length.Millimetres(2160.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Mewlon 210",
                Aperture =  Length.Millimetres(210.00),
                FocalLength =  Length.Millimetres(2415.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Mewlon 250",
                Aperture =  Length.Millimetres(250.00),
                FocalLength =  Length.Millimetres(3000.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "Sky-90",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "TOA130",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "TOA150",
                Aperture =  Length.Millimetres(150.00),
                FocalLength =  Length.Millimetres(1100.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "TSA-102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(816.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "TSA-120",
                Aperture =  Length.Millimetres(120.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "Takahashi",
                Model = "TSC225",
                Aperture =  Length.Millimetres(225.00),
                FocalLength =  Length.Millimetres(2700.00)
            },
            new Telescope {
                Manufacturer = "Tal",
                Model = "100RS",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "TAL",
                Model = "200K",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1700.00)
            },
            new Telescope {
                Manufacturer = "TEC",
                Model = "140ED",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(980.00)
            },
            new Telescope {
                Manufacturer = "TEC",
                Model = "140ED Apo Triplet",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(980.00)
            },
            new Telescope {
                Manufacturer = "TEC",
                Model = "160-APO",
                Aperture =  Length.Millimetres(160.00),
                FocalLength =  Length.Millimetres(1280.00)
            },
            new Telescope {
                Manufacturer = "TEC",
                Model = "160FL f7",
                Aperture =  Length.Millimetres(160.00),
                FocalLength =  Length.Millimetres(1120.00)
            },
            new Telescope {
                Manufacturer = "Tele Vue",
                Model = "NP-101",
                Aperture =  Length.Millimetres(101.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "Telescop Services",
                Model = "80mm triplet apo fpl53",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Telescop Services",
                Model = "TS65 Quad",
                Aperture =  Length.Millimetres(65.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Telescope Service",
                Model = "60/234mm Richfield Refractor",
                Aperture =  Length.Millimetres(60.00),
                FocalLength =  Length.Millimetres(234.00)
            },
            new Telescope {
                Manufacturer = "Telescope Service",
                Model = "TS Imaging Star 65mm f/6,5 Quadruplet Astrograph",
                Aperture =  Length.Millimetres(65.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Telescope Service",
                Model = "TS PHOTOLINE 130 mm f/7 Triplet APO",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "Telescope Service",
                Model = "TS Photoline 80mm f/6 Triplet",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Teleskop Service",
                Model = "ED APO 90/500",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(500.00)
            },
            new Telescope {
                Manufacturer = "Teleskop Service",
                Model = "INED70",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "Teleskop Service",
                Model = "TLAPO 1027 FT",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "Teleskop Service",
                Model = "TS ED70Q",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(474.00)
            },
            new Telescope {
                Manufacturer = "Teleskop Service",
                Model = "TSAPO81Q",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(352.00)
            },
            new Telescope {
                Manufacturer = "Televue",
                Model = "102",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(880.00)
            },
            new Telescope {
                Manufacturer = "TeleVue",
                Model = "NP101is",
                Aperture =  Length.Millimetres(101.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "TeleVue",
                Model = "NP127is",
                Aperture =  Length.Millimetres(127.00),
                FocalLength =  Length.Millimetres(660.00)
            },
            new Telescope {
                Manufacturer = "TeleVue",
                Model = "TV-85",
                Aperture =  Length.Millimetres(85.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "TeleVue",
                Model = "TV102",
                Aperture =  Length.Millimetres(101.95),
                FocalLength =  Length.Millimetres(880.00)
            },
            new Telescope {
                Manufacturer = "TMB",
                Model = "100/800",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "TMB",
                Model = "130",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(910.00)
            },
            new Telescope {
                Manufacturer = "TMB",
                Model = "80mm Super APO",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "TMB/APM",
                Model = "152",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(1200.00)
            },
            new Telescope {
                Manufacturer = "TPO",
                Model = "16\" RC",
                Aperture =  Length.Millimetres(406.40),
                FocalLength =  Length.Millimetres(3250.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "102 APO",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(714.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "115mm APO",
                Aperture =  Length.Millimetres(115.00),
                FocalLength =  Length.Millimetres(805.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "130Q f5",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "150mm Newtonian f5",
                Aperture =  Length.Millimetres(5.00),
                FocalLength =  Length.Millimetres(150.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "152mm f5.9",
                Aperture =  Length.Millimetres(152.00),
                FocalLength =  Length.Millimetres(900.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "50mm APO f6.6",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(330.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "8\" f/5 ONTC",
                Aperture =  Length.Millimetres(203.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "80mm f7.5",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(600.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "APO71Q",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(347.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "Imaging Star 100",
                Aperture =  Length.Millimetres(100.00),
                FocalLength =  Length.Millimetres(580.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "Imaging Star 130mm f5",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "Imaging Star 71 (f4.9)",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(347.00)
            },
            new Telescope {
                Manufacturer = "TS",
                Model = "ONTC Newton",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1000.00)
            },
            new Telescope {
                Manufacturer = "TS Optics",
                Model = "94 mm f/5.5 Triplet Apo",
                Aperture =  Length.Millimetres(94.00),
                FocalLength =  Length.Millimetres(517.00)
            },
            new Telescope {
                Manufacturer = "TS Optics",
                Model = "94EDPH f/4.4",
                Aperture =  Length.Millimetres(94.00),
                FocalLength =  Length.Millimetres(414.00)
            },
            new Telescope {
                Manufacturer = "TS Optics",
                Model = "Imaging star 70mm f/6.78 quadruplet ED",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(474.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "140 SS Neo-Achromat",
                Aperture =  Length.Millimetres(140.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "AX 103S",
                Aperture =  Length.Millimetres(103.00),
                FocalLength =  Length.Millimetres(825.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "BT-ED70S-A",
                Aperture =  Length.Millimetres(70.00),
                FocalLength =  Length.Millimetres(400.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "BT81S-A",
                Aperture =  Length.Millimetres(81.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "ED 102 SS",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(663.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "ED80 SF",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(640.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "ED81s",
                Aperture =  Length.Millimetres(81.00),
                FocalLength =  Length.Millimetres(625.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "R130Sf",
                Aperture =  Length.Millimetres(130.00),
                FocalLength =  Length.Millimetres(650.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "R135S",
                Aperture =  Length.Millimetres(135.00),
                FocalLength =  Length.Millimetres(720.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "R200SS",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "RR200SS",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(800.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "SD103S",
                Aperture =  Length.Millimetres(103.00),
                FocalLength =  Length.Millimetres(795.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "VC200L",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1800.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "VMC110L",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(1035.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "VMC200L",
                Aperture =  Length.Millimetres(200.00),
                FocalLength =  Length.Millimetres(1900.00)
            },
            new Telescope {
                Manufacturer = "Vixen",
                Model = "VMC260L",
                Aperture =  Length.Millimetres(260.00),
                FocalLength =  Length.Millimetres(3000.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "98-FLT @ f/6.3",
                Aperture =  Length.Millimetres(98.00),
                FocalLength =  Length.Millimetres(618.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "FLT-110  f/7",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(770.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "FLT-123 f/6 (LZOS)",
                Aperture =  Length.Millimetres(123.00),
                FocalLength =  Length.Millimetres(738.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "FLT-132  f/7",
                Aperture =  Length.Millimetres(132.00),
                FocalLength =  Length.Millimetres(925.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "FLT132",
                Aperture =  Length.Millimetres(132.00),
                FocalLength =  Length.Millimetres(924.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "FLT91",
                Aperture =  Length.Millimetres(91.00),
                FocalLength =  Length.Millimetres(540.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "GT-102 f/6.9",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(704.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "GT-102F f/6.9 (5-element)",
                Aperture =  Length.Millimetres(102.00),
                FocalLength =  Length.Millimetres(703.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "GT-81 f/5.9",
                Aperture =  Length.Millimetres(81.00),
                FocalLength =  Length.Millimetres(478.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "GT-81 f/6.6 (5-element)",
                Aperture =  Length.Millimetres(81.00),
                FocalLength =  Length.Millimetres(535.00)
            },
            new Telescope {
                Manufacturer = "William optics",
                Model = "GT71",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(420.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Megrez-110  f/5.95",
                Aperture =  Length.Millimetres(110.00),
                FocalLength =  Length.Millimetres(655.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Megrez-72 f/6.0",
                Aperture =  Length.Millimetres(72.00),
                FocalLength =  Length.Millimetres(432.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Megrez-80 f/6 (LOMO)",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(480.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Megrez-90  f/6.2",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(558.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Megrez-90 f/6.9",
                Aperture =  Length.Millimetres(90.00),
                FocalLength =  Length.Millimetres(621.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "RedCat 51mm f/4.9",
                Aperture =  Length.Millimetres(51.00),
                FocalLength =  Length.Millimetres(250.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Star-71 f/4.9",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(348.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "Zenithstar 61 FPL53",
                Aperture =  Length.Millimetres(61.00),
                FocalLength =  Length.Millimetres(360.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZenithStar-103 ED f/6.9",
                Aperture =  Length.Millimetres(103.00),
                FocalLength =  Length.Millimetres(710.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZenithStar-66 SD f/5.9",
                Aperture =  Length.Millimetres(66.00),
                FocalLength =  Length.Millimetres(388.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZenithStar-71 ED f/5.9",
                Aperture =  Length.Millimetres(71.00),
                FocalLength =  Length.Millimetres(418.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZenithStar-80 II ED f/6.8",
                Aperture =  Length.Millimetres(80.00),
                FocalLength =  Length.Millimetres(545.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZS126",
                Aperture =  Length.Millimetres(126.00),
                FocalLength =  Length.Millimetres(970.00)
            },
            new Telescope {
                Manufacturer = "William Optics",
                Model = "ZS73 & ZS73 II",
                Aperture =  Length.Millimetres(73.00),
                FocalLength =  Length.Millimetres(430.00)
            },
            new Telescope {
                Manufacturer = "Williams Optics",
                Model = "Guide Scope",
                Aperture =  Length.Millimetres(50.00),
                FocalLength =  Length.Millimetres(200.00)
            },
            new Telescope {
                Manufacturer = "Ziess",
                Model = "Telementor",
                Aperture =  Length.Millimetres(63.00),
                FocalLength =  Length.Millimetres(840.00)
            },
        };
    }

}