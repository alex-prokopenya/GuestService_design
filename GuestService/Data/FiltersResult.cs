﻿namespace GuestService.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    public class FiltersResult
    {
        [XmlArray("CategoryGroups")]
        public List<CatalogFilterCategoryGroup> categorygroups { get; set; }

        [XmlArray("Departures")]
        public List<CatalogFilterLocationItem> departures { get; set; }

        [XmlArray("Destinations")]
        public List<CatalogFilterLocationItem> destinations { get; set; }

        [XmlElement("Durations")]
        public CatalogFilterDuration durations { get; set; }

        [XmlArray("Languages")]
        public List<CatalogFilterItem> languages { get; set; }
    }
}

