namespace GuestService.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    public class ExcursionExtendedDescription : ExcursionDescription
    {
        public ExcursionExtendedDescription()
        {
        }

        public ExcursionExtendedDescription(ExcursionDescription item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            base.excursion = item.excursion;
            base.pictures = item.pictures;
            base.description = item.description;
        }

        [XmlArray("DestinationCountry")]
        public GeoPlace destinationCountry { get; set; }

        [XmlArray("DestinationCity")]
        public GeoPlace destinationCity { get; set; }

        [XmlArray("Country")]
        public GeoPlace country { get; set; }

        [XmlArray("Cities")]
        public List<GeoPlace> cities { get; set; }

        [XmlArray("CategoryGroups")]
        public List<CatalogFilterCategoryGroup> categorygroups { get; set; }

        [XmlArray("ExcursionDates")]
        public List<ExcursionDate> excursiondates { get; set; }

        [XmlElement("Ranking")]
        public CatalogDescriptionExcursionRanking ranking { get; set; }

        [XmlArray("SurveyNotes")]
        public List<ExcursionSurveyNote> surveynotes { get; set; }
    }
}

