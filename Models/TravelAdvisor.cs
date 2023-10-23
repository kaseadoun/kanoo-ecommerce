using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    // https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
    // https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
    public class Root
    {
        [Key]
        public int RootId { get; set; }
        public virtual ICollection<Data>? Data { get; set; }
    }


    public class Data
    {
        [Key]
        public int DataId { get; set; }
        public virtual ICollection<TypeaheadAutocomplete>? Typeahead_autocomplete { get; set; }

        [ForeignKey("DataId")]
        public virtual Root Root { get; set; }

    }


    public class TypeaheadAutocomplete
    {
        [Key]
        public int TypeaheadAutocompleteId { get; set; }
        public string? __typename { get; set; }
        public string? resultsId { get; set; }
        public virtual ICollection<TravelAdvisor> results { get; set; }

        [ForeignKey("TypeaheadAutocompleteId")]
        public virtual Data Data { get; set; }

    }

    public class TravelAdvisor
    {
        [Key]
        public int TravelAdvisorId { get; set; }
        public int? TypeaheadAutocompleteId { get; set; }
        public string? __typename { get; set; }
        public string? documentId { get; set; }
        public string? suggestionType { get; set; }
        public string? buCategory { get; set; }
        public string? text { get; set; }
        public virtual ICollection<ParentGeoDetails>? parentGeoDetails { get; set; }
        public virtual ICollection<Route>? route { get; set; }
        public string? scopeType { get; set; }
        public virtual ICollection<DetailsV2>? detailsV2 { get; set; }
        public virtual ICollection<Details>? details { get; set; }
        public virtual ICollection<Image>? image { get; set; }

        [ForeignKey("TypeaheadAutocompleteId")]
        public virtual TypeaheadAutocomplete? TypeaheadAutocomplete { get; set; }

    }

    public class Details
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public virtual ICollection<SocialStatistics>? socialStatistics { get; set; }

        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }

    }

    public class DetailsV2
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public int? locationId { get; set; }
        public bool? isGeo { get; set; }
        public string? placeType { get; set; }
        public virtual ICollection<Names>? names { get; set; }
        public virtual ICollection<Geocode>? geocode { get; set; }
        public virtual ICollection<Contact>? contact { get; set; }
        public virtual ICollection<Route>? route { get; set; }

        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class Image
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public virtual ICollection<Photo>? photo { get; set; }

        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public virtual ICollection<StreetAddress>? streetAddress { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class Geocode
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }
    public class Names

    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public string? longOnlyHierarchyTypeaheadV2 { get; set; }
        public string? name { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class ParentGeoDetails
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public virtual ICollection<Names>? names { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class Photo
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public virtual ICollection<PhotoSizeDynamic>? photoSizeDynamic { get; set; }
        public virtual ICollection<PhotoSize>? photoSizes { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class PhotoSize
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public int? height { get; set; }
        public int? width { get; set; }
        public string? url { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class PhotoSizeDynamic
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public int? maxHeight { get; set; }
        public int? maxWidth { get; set; }
        public string? urlTemplate { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class Route
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public string? fragment { get; set; }
        public string? page { get; set; }
        public string? url { get; set; }
        public string? nonCanonicalUrl { get; set; }
        public virtual ICollection<TypedParams>? typedParams { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class SocialStatistics
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public bool? isSaved { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class StreetAddress
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public string? street1 { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

    public class TypedParams
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int TravelAdvisorId { get; set; } = 0;
        public string? __typename { get; set; }
        public int? geoId { get; set; }
        [ForeignKey("TravelAdvisorId")]
        public virtual TravelAdvisor TravelAdvisor { get; set; }
    }

}