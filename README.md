# API Endpoints:

## HOTELS
### Hotels.com Provider

https://rapidapi.com/tipsters/api/hotels-com-provider

** TWO STEPS **

Step 1:
"GET/Regions Search"

REQUIRED: city name

Return:
```bash
{
  "query": "Prag",
  "data": [
    {
      "@type": "gaiaRegionResult",
      "index": "0",
      "gaiaId": "2872",
      "type": "CITY",
      "regionNames": {
        "fullName": "Prague, Czechia",
        "shortName": "Prague",
        "displayName": "Prague, Czechia",
        "primaryDisplayName": "Prague",
        "secondaryDisplayName": "Czechia",
        "lastSearchName": "Prague"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "2872"
      },
      "coordinates": {
        "lat": "50.08718",
        "long": "14.42564"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "1",
      "gaiaId": "6278809",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Prague City Center, Prague, Czechia",
        "shortName": "Prague City Center",
        "displayName": "Prague City Center, Prague, Czechia",
        "primaryDisplayName": "Prague City Center",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague City Center"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6278809"
      },
      "coordinates": {
        "lat": "50.086571352258844",
        "long": "14.413673111122518"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "2",
      "gaiaId": "6242762",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Prague 1, Prague, Czechia",
        "shortName": "Prague 1",
        "displayName": "Prague 1, Prague, Czechia",
        "primaryDisplayName": "Prague 1",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague 1"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6242762"
      },
      "coordinates": {
        "lat": "50.087833",
        "long": "14.421049"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "3",
      "gaiaId": "6242738",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Prague 2, Prague, Czechia",
        "shortName": "Prague 2",
        "displayName": "Prague 2, Prague, Czechia",
        "primaryDisplayName": "Prague 2",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague 2"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6242738"
      },
      "coordinates": {
        "lat": "50.075069",
        "long": "14.435078"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "4",
      "gaiaId": "4674128",
      "type": "AIRPORT",
      "regionNames": {
        "fullName": "Prague, Czechia (PRG-Vaclav Havel)",
        "shortName": "Prague (PRG-Vaclav Havel)",
        "displayName": "Prague (PRG - Vaclav Havel), Czechia",
        "primaryDisplayName": "Prague (PRG - Vaclav Havel)",
        "secondaryDisplayName": "Czechia",
        "lastSearchName": "Prague (PRG - Vaclav Havel)"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "4674128"
      },
      "coordinates": {
        "lat": "50.10769",
        "long": "14.26755"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      },
      "isMinorAirport": "false"
    },
    {
      "@type": "gaiaRegionResult",
      "index": "5",
      "gaiaId": "508612",
      "type": "POI",
      "regionNames": {
        "fullName": "Old Town Square, Prague, Czechia",
        "shortName": "Old Town Square",
        "displayName": "Old Town Square, Prague, Czechia",
        "primaryDisplayName": "Old Town Square",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Old Town Square"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "508612"
      },
      "coordinates": {
        "lat": "50.087538",
        "long": "14.420704"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaHotelResult",
      "index": "6",
      "hotelId": "282738",
      "type": "HOTEL",
      "regionNames": {
        "fullName": "Prague Marriott Hotel, Prague, Czechia",
        "shortName": "Prague Marriott Hotel",
        "displayName": "Prague Marriott Hotel, Prague, Czechia",
        "primaryDisplayName": "Prague Marriott Hotel",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague Marriott Hotel"
      },
      "essId": {
        "sourceName": "LCM",
        "sourceId": "282738"
      },
      "coordinates": {
        "lat": "50.088295",
        "long": "14.431192"
      },
      "hierarchyInfo": {
        "country": {
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      },
      "cityId": "2872",
      "hotelAddress": {
        "street": "V Celnici 8",
        "city": "Prague",
        "province": ""
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "7",
      "gaiaId": "6242733",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Prague 3, Prague, Czechia",
        "shortName": "Prague 3",
        "displayName": "Prague 3, Prague, Czechia",
        "primaryDisplayName": "Prague 3",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague 3"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6242733"
      },
      "coordinates": {
        "lat": "50.085411",
        "long": "14.454351"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "8",
      "gaiaId": "6242711",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Prague 4, Prague, Czechia",
        "shortName": "Prague 4",
        "displayName": "Prague 4, Prague, Czechia",
        "primaryDisplayName": "Prague 4",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Prague 4"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6242711"
      },
      "coordinates": {
        "lat": "50.041466",
        "long": "14.44296"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    },
    {
      "@type": "gaiaRegionResult",
      "index": "9",
      "gaiaId": "6046563",
      "type": "NEIGHBORHOOD",
      "regionNames": {
        "fullName": "Stare Mesto, Prague, Czechia",
        "shortName": "Stare Mesto",
        "displayName": "Stare Mesto, Prague, Czechia",
        "primaryDisplayName": "Stare Mesto",
        "secondaryDisplayName": "Prague, Czechia",
        "lastSearchName": "Stare Mesto"
      },
      "essId": {
        "sourceName": "GAI",
        "sourceId": "6046563"
      },
      "coordinates": {
        "lat": "50.084285",
        "long": "14.417839"
      },
      "hierarchyInfo": {
        "country": {
          "name": "Czechia",
          "isoCode2": "CZ",
          "isoCode3": "CZE"
        },
        "airport": {
          "airportCode": "PRG",
          "airportId": "4674128",
          "multicity": "180014"
        }
      }
    }
  ]
}
```

To Model:
```bash
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Airport
    {
        public string AirportCode { get; set; }
        public string AirportId { get; set; }
        public string Multicity { get; set; }
    }

    public class Coordinates
    {
        public string Lat { get; set; }
        public string Long { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
    }

    public class Datum
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public string Index { get; set; }
        public string GaiaId { get; set; }
        public string Type { get; set; }
        public RegionNames RegionNames { get; set; }
        public EssId EssId { get; set; }
        public Coordinates Coordinates { get; set; }
        public HierarchyInfo HierarchyInfo { get; set; }
        public string IsMinorAirport { get; set; }
        public string HotelId { get; set; }
        public string CityId { get; set; }
        public HotelAddress HotelAddress { get; set; }
    }

    public class EssId
    {
        public string SourceName { get; set; }
        public string SourceId { get; set; }
    }

    public class HierarchyInfo
    {
        public Country Country { get; set; }
        public Airport Airport { get; set; }
    }

    public class HotelAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }

    public class RegionNames
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string DisplayName { get; set; }
        public string PrimaryDisplayName { get; set; }
        public string SecondaryDisplayName { get; set; }
        public string LastSearchName { get; set; }
    }

    public class Root
    {
        public string Query { get; set; }
        public List<Datum> Data { get; set; }
    }
```

Step 2:
"GET/Hotels Search"

REQUIRED: region_id from step 1, checkout date, num of adults, sort by (REVIEW, DISTANCE, RECOMMENDED, PRICE),

OPTIONAL: availability (SHOW_AVAILABLE_ONLY), guest rating minimum, payment type (PAY_LATER, GIFT_CARD), amenities (WIFI, SPA, OCEAN_VIEW), price maximum, meal plan (ALL_INCLUSIVE, FREE_BREAKFAST), star rating, min price, accessibility (SIGN_LANGUAGE_INTERPRETER, ELEVATOR), lodging type (HOSTAL, HOTEL, BED_AND_BREAKFAST), age of children

Return:
```bash
{
  "__typename": "PropertySearchResults",
  "filterMetadata": {
    "__typename": "PropertyFilterMetadata",
    "amenities": [
      {
        "__typename": "PropertyAmenityValue",
        "id": 7
      }
    ],
    "neighborhoods": [
      {
        "__typename": "Neighborhood",
        "name": "Prague (and vicinity)",
        "regionId": "180014"
      },
      {
        "__typename": "Neighborhood",
        "name": "Prague City Center",
        "regionId": "6278809"
      }
    ],
    "priceRange": {
      "__typename": "PriceRange",
      "max": 3504.26,
      "min": 132.56
    }
  },
  "universalSortAndFilter": {
    "__typename": "ShoppingSortAndFilters",
    "toolbar": {
      "__typename": "UIToolbar",
      "primary": "Sort & filter",
      "actions": {
        "__typename": "UIToolbarActions",
        "primary": {
          "__typename": "UITertiaryButton",
          "primary": null,
          "action": {
            "__typename": "ShoppingSortAndFilterAction",
            "actionType": "CLOSE_AND_DO_NOT_APPLY",
            "accessibility": null,
            "analytics": {
              "__typename": "ClientSideAnalytics",
              "linkName": "close search filters dialog",
              "referrerId": "HOT.SR.CloseFilterDialog.Close"
            }
          }
        },
        "secondaries": [
          {
            "__typename": "UITertiaryButton",
            "primary": "Clear",
            "disabled": false,
            "action": {
              "__typename": "ShoppingSortAndFilterAction",
              "actionType": "CLEAR_DATA",
              "accessibility": "All selections now cleared",
              "analytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "clear all selections",
                "referrerId": "HOT.SR.ClearFilters"
              }
            }
          }
        ]
      }
    },
    "revealAction": {
      "__typename": "UISecondaryFloatingActionButton",
      "primary": "Sort & filter",
      "action": {
        "__typename": "ShoppingSortAndFilterAction",
        "actionType": "OPEN_MODAL",
        "accessibility": null,
        "analytics": {
          "__typename": "ClientSideAnalytics",
          "linkName": "Launch filters takeover",
          "referrerId": "HOT.SR:FilterControl"
        }
      },
      "accessibility": "11 filters applied. Change sort or apply more filters.",
      "badge": 11,
      "disabled": false,
      "icon": {
        "__typename": "Icon",
        "id": "tune",
        "description": "reveals sort and filter window",
        "size": null,
        "token": "icon__tune",
        "theme": null
      }
    },
    "applyAction": {
      "__typename": "UIPrimaryFloatingActionButton",
      "primary": "Done",
      "action": {
        "__typename": "ShoppingSortAndFilterAction",
        "actionType": "CLOSE_AND_APPLY",
        "accessibility": null,
        "analytics": {
          "__typename": "ClientSideAnalytics",
          "linkName": "done search filters dialog",
          "referrerId": "HOT.SR.FilterControlDone"
        }
      },
      "accessibility": "Apply and close Sort and filter",
      "badge": null,
      "disabled": false,
      "icon": null
    },
    "filterSections": [
      {
        "__typename": "ShoppingSortAndFilterSection",
        "title": "Search by property name",
        "fields": [
          {
            "__typename": "ShoppingTextInputField",
            "primary": null,
            "secondary": null,
            "action": {
              "__typename": "ShoppingSortAndFilterAction",
              "actionType": "OPEN_MODAL",
              "accessibility": null,
              "analytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "id": "hotelName",
            "label": null,
            "placeholder": "e.g. Marriott",
            "selected": null,
            "typeaheadInfo": {
              "__typename": "TypeaheadInfo",
              "client": "Hotels.Search",
              "isDestination": true,
              "lineOfBusiness": "hotels",
              "maxNumberOfResults": 10,
              "packageType": null,
              "personalize": false,
              "regionType": 128,
              "typeaheadFeatures": "ta_hierarchy|postal_code|contextual_ta|consistent_display"
            },
            "icon": {
              "__typename": "Icon",
              "id": "search",
              "description": "magnifying glass",
              "size": null,
              "token": "icon__search",
              "theme": null
            },
            "analytics": {
              "__typename": "ClientSideAnalytics",
              "linkName": "hotelName.",
              "referrerId": "HOT.SR.hotelName."
            }
          }
        ]
      },
      {
        "__typename": "ShoppingSortAndFilterSection",
        "title": "Filter by",
        "fields": [
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Your previous filters",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 10,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Aparthotel",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "APART_HOTEL",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.APART_HOTEL",
                  "referrerId": "HOT.SR.previousFilter.lodging.APART_HOTEL.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.APART_HOTEL",
                  "referrerId": "HOT.SR.previousFilter.lodging.APART_HOTEL.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Hostal",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOSTAL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOSTAL",
                  "referrerId": "HOT.SR.previousFilter.lodging.HOSTAL.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOSTAL",
                  "referrerId": "HOT.SR.previousFilter.lodging.HOSTAL.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Hotel",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOTEL",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL",
                  "referrerId": "HOT.SR.previousFilter.lodging.HOTEL.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL",
                  "referrerId": "HOT.SR.previousFilter.lodging.HOTEL.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "WiFi included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "wifi",
                  "description": "",
                  "size": null,
                  "token": "icon__wifi",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "WIFI",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WIFI",
                  "referrerId": "HOT.SR.previousFilter.amenities.WIFI.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WIFI",
                  "referrerId": "HOT.SR.previousFilter.amenities.WIFI.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "5 stars",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.50",
                  "referrerId": "HOT.SR.previousFilter.star.50.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.50",
                  "referrerId": "HOT.SR.previousFilter.star.50.false:4"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Popular filters",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 10,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "mealPlan",
                "primary": "Breakfast included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FREE_BREAKFAST",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FREE_BREAKFAST",
                  "referrerId": "HOT.SR.popularFilter.mealPlan.FREE_BREAKFAST.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FREE_BREAKFAST",
                  "referrerId": "HOT.SR.popularFilter.mealPlan.FREE_BREAKFAST.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Parking",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "local_parking",
                  "description": "",
                  "size": null,
                  "token": "icon__local_parking",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FREE_PARKING",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_PARKING",
                  "referrerId": "HOT.SR.popularFilter.amenities.FREE_PARKING.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_PARKING",
                  "referrerId": "HOT.SR.popularFilter.amenities.FREE_PARKING.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "paymentType",
                "primary": "Reserve now, pay later",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "PAY_LATER",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_LATER",
                  "referrerId": "HOT.SR.popularFilter.paymentType.PAY_LATER.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_LATER",
                  "referrerId": "HOT.SR.popularFilter.paymentType.PAY_LATER.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Pool",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "pool",
                  "description": "",
                  "size": null,
                  "token": "icon__pool",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "POOL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.POOL",
                  "referrerId": "HOT.SR.popularFilter.amenities.POOL.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.POOL",
                  "referrerId": "HOT.SR.popularFilter.amenities.POOL.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Hlavni Station",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6021418",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6021418",
                  "referrerId": "HOT.SR.popularFilter.regionId.6021418.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6021418",
                  "referrerId": "HOT.SR.popularFilter.regionId.6021418.false:4"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingRangeField",
            "primary": "Price per night",
            "secondary": null,
            "range": {
              "__typename": "ShoppingRangeFilterOption",
              "id": "price",
              "primary": "",
              "secondary": null,
              "icon": null,
              "analytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "price.",
                "referrerId": "HOT.SR.price."
              },
              "selected": {
                "__typename": "RangeValue",
                "id": "price",
                "min": 0,
                "max": 300
              },
              "characteristics": {
                "__typename": "ShoppingRangeCharacteristics",
                "min": 0,
                "max": 300,
                "step": 30,
                "labels": [
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$0",
                    "value": 0
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$30",
                    "value": 30
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$60",
                    "value": 60
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$90",
                    "value": 90
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$120",
                    "value": 120
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$150",
                    "value": 150
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$180",
                    "value": 180
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$210",
                    "value": 210
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$240",
                    "value": 240
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$270",
                    "value": 270
                  },
                  {
                    "__typename": "ShoppingRangeLabel",
                    "label": "$300+",
                    "value": 300
                  }
                ]
              }
            }
          },
          {
            "__typename": "ShoppingSelectionField",
            "primary": "Guest rating",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 10,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "options": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "guestRating",
                "primary": "Any",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.ANY",
                  "referrerId": "HOT.SR.guestRating.ANY.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.ANY",
                  "referrerId": "HOT.SR.guestRating.ANY.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "guestRating",
                "primary": "Wonderful 9+",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "45",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.45",
                  "referrerId": "HOT.SR.guestRating.45.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.45",
                  "referrerId": "HOT.SR.guestRating.45.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "guestRating",
                "primary": "Very good 8+",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "40",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.40",
                  "referrerId": "HOT.SR.guestRating.40.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.40",
                  "referrerId": "HOT.SR.guestRating.40.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "guestRating",
                "primary": "Good 7+",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "35",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.35",
                  "referrerId": "HOT.SR.guestRating.35.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "guestRating.35",
                  "referrerId": "HOT.SR.guestRating.35.false:3"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionStackedTileField",
            "primary": "Property class",
            "secondary": null,
            "tileMultiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "1",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "10",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.10",
                  "referrerId": "HOT.SR.star.10.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.10",
                  "referrerId": "HOT.SR.star.10.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "2",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "20",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.20",
                  "referrerId": "HOT.SR.star.20.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.20",
                  "referrerId": "HOT.SR.star.20.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "3",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "30",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.30",
                  "referrerId": "HOT.SR.star.30.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.30",
                  "referrerId": "HOT.SR.star.30.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "4",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "40",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.40",
                  "referrerId": "HOT.SR.star.40.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.40",
                  "referrerId": "HOT.SR.star.40.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "star",
                "primary": "5",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "star",
                  "description": "star",
                  "size": null,
                  "token": "icon__star",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.50",
                  "referrerId": "HOT.SR.star.50.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "star.50",
                  "referrerId": "HOT.SR.star.50.false:4"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Payment type",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "paymentType",
                "primary": "Reserve now, pay later",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "PAY_LATER",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_LATER",
                  "referrerId": "HOT.SR.paymentType.PAY_LATER.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_LATER",
                  "referrerId": "HOT.SR.paymentType.PAY_LATER.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "paymentType",
                "primary": "Reserve without a credit card",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "PAY_WITHOUT_CREDITCARD",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_WITHOUT_CREDITCARD",
                  "referrerId": "HOT.SR.paymentType.PAY_WITHOUT_CREDITCARD.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "paymentType.PAY_WITHOUT_CREDITCARD",
                  "referrerId": "HOT.SR.paymentType.PAY_WITHOUT_CREDITCARD.false:1"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Property type",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Holiday rentals",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "VACATION_RENTALS",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.VACATION_RENTALS",
                  "referrerId": "HOT.SR.lodging.VACATION_RENTALS.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.VACATION_RENTALS",
                  "referrerId": "HOT.SR.lodging.VACATION_RENTALS.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Hotel",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOTEL",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL",
                  "referrerId": "HOT.SR.lodging.HOTEL.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL",
                  "referrerId": "HOT.SR.lodging.HOTEL.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Hostal",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOSTAL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOSTAL",
                  "referrerId": "HOT.SR.lodging.HOSTAL.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOSTAL",
                  "referrerId": "HOT.SR.lodging.HOSTAL.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Aparthotel",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "APART_HOTEL",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.APART_HOTEL",
                  "referrerId": "HOT.SR.lodging.APART_HOTEL.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.APART_HOTEL",
                  "referrerId": "HOT.SR.lodging.APART_HOTEL.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Motel",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "MOTEL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.MOTEL",
                  "referrerId": "HOT.SR.lodging.MOTEL.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.MOTEL",
                  "referrerId": "HOT.SR.lodging.MOTEL.false:4"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Hotel resort",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOTEL_RESORT",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL_RESORT",
                  "referrerId": "HOT.SR.lodging.HOTEL_RESORT.true:5"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.HOTEL_RESORT",
                  "referrerId": "HOT.SR.lodging.HOTEL_RESORT.false:5"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Pousada (Portugal)",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "POUSADA_PORTUGAL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.POUSADA_PORTUGAL",
                  "referrerId": "HOT.SR.lodging.POUSADA_PORTUGAL.true:6"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.POUSADA_PORTUGAL",
                  "referrerId": "HOT.SR.lodging.POUSADA_PORTUGAL.false:6"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "lodging",
                "primary": "Pousada (Brazil)",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "POUSADA_BRAZIL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.POUSADA_BRAZIL",
                  "referrerId": "HOT.SR.lodging.POUSADA_BRAZIL.true:7"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "lodging.POUSADA_BRAZIL",
                  "referrerId": "HOT.SR.lodging.POUSADA_BRAZIL.false:7"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionStackedTileField",
            "primary": "Number of bedrooms",
            "secondary": null,
            "tileMultiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "bedroomFilter",
                "primary": "Studio",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "0",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.0",
                  "referrerId": "HOT.SR.bedroomFilter.0.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.0",
                  "referrerId": "HOT.SR.bedroomFilter.0.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "bedroomFilter",
                "primary": "1",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "1",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.1",
                  "referrerId": "HOT.SR.bedroomFilter.1.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.1",
                  "referrerId": "HOT.SR.bedroomFilter.1.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "bedroomFilter",
                "primary": "2",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "2",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.2",
                  "referrerId": "HOT.SR.bedroomFilter.2.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.2",
                  "referrerId": "HOT.SR.bedroomFilter.2.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "bedroomFilter",
                "primary": "3",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "3",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.3",
                  "referrerId": "HOT.SR.bedroomFilter.3.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.3",
                  "referrerId": "HOT.SR.bedroomFilter.3.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "bedroomFilter",
                "primary": "4+",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "4",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.4",
                  "referrerId": "HOT.SR.bedroomFilter.4.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "bedroomFilter.4",
                  "referrerId": "HOT.SR.bedroomFilter.4.false:4"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingSelectionField",
            "primary": "Area",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "options": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "2872",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": true,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.2872",
                  "referrerId": "HOT.SR.regionId.2872.true:16"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.2872",
                  "referrerId": "HOT.SR.regionId.2872.false:16"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague (and vicinity)",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "180014",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.180014",
                  "referrerId": "HOT.SR.regionId.180014.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.180014",
                  "referrerId": "HOT.SR.regionId.180014.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Hlavni Station",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6021418",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6021418",
                  "referrerId": "HOT.SR.regionId.6021418.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6021418",
                  "referrerId": "HOT.SR.regionId.6021418.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Stare Mesto",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6046563",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6046563",
                  "referrerId": "HOT.SR.regionId.6046563.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6046563",
                  "referrerId": "HOT.SR.regionId.6046563.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 9",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242725",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242725",
                  "referrerId": "HOT.SR.regionId.6242725.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242725",
                  "referrerId": "HOT.SR.regionId.6242725.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 7",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242823",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242823",
                  "referrerId": "HOT.SR.regionId.6242823.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242823",
                  "referrerId": "HOT.SR.regionId.6242823.false:4"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 4",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242711",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242711",
                  "referrerId": "HOT.SR.regionId.6242711.true:5"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242711",
                  "referrerId": "HOT.SR.regionId.6242711.false:5"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Karlín",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6051627",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051627",
                  "referrerId": "HOT.SR.regionId.6051627.true:6"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051627",
                  "referrerId": "HOT.SR.regionId.6051627.false:6"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 3",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242733",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242733",
                  "referrerId": "HOT.SR.regionId.6242733.true:7"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242733",
                  "referrerId": "HOT.SR.regionId.6242733.false:7"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Mala Strana",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6046562",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6046562",
                  "referrerId": "HOT.SR.regionId.6046562.true:8"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6046562",
                  "referrerId": "HOT.SR.regionId.6046562.false:8"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 2",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242738",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242738",
                  "referrerId": "HOT.SR.regionId.6242738.true:9"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242738",
                  "referrerId": "HOT.SR.regionId.6242738.false:9"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 1",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242762",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242762",
                  "referrerId": "HOT.SR.regionId.6242762.true:10"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242762",
                  "referrerId": "HOT.SR.regionId.6242762.false:10"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 8",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242750",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242750",
                  "referrerId": "HOT.SR.regionId.6242750.true:11"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242750",
                  "referrerId": "HOT.SR.regionId.6242750.false:11"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 10",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242719",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242719",
                  "referrerId": "HOT.SR.regionId.6242719.true:12"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242719",
                  "referrerId": "HOT.SR.regionId.6242719.false:12"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Zizkov",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6051629",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051629",
                  "referrerId": "HOT.SR.regionId.6051629.true:13"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051629",
                  "referrerId": "HOT.SR.regionId.6051629.false:13"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague (PRG-Vaclav Havel)",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "4674128",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.4674128",
                  "referrerId": "HOT.SR.regionId.4674128.true:14"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.4674128",
                  "referrerId": "HOT.SR.regionId.4674128.false:14"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 6",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242700",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242700",
                  "referrerId": "HOT.SR.regionId.6242700.true:15"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242700",
                  "referrerId": "HOT.SR.regionId.6242700.false:15"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague 5",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6242704",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242704",
                  "referrerId": "HOT.SR.regionId.6242704.true:17"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6242704",
                  "referrerId": "HOT.SR.regionId.6242704.false:17"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Prague City Center",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6278809",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6278809",
                  "referrerId": "HOT.SR.regionId.6278809.true:18"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6278809",
                  "referrerId": "HOT.SR.regionId.6278809.false:18"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "regionId",
                "primary": "Vinohrady",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "6051628",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051628",
                  "referrerId": "HOT.SR.regionId.6051628.true:19"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "regionId.6051628",
                  "referrerId": "HOT.SR.regionId.6051628.false:19"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingSelectionField",
            "primary": "Popular locations",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "options": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Any",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": true,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.ANY",
                  "referrerId": "HOT.SR.poi.ANY.true:8"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.ANY",
                  "referrerId": "HOT.SR.poi.ANY.false:8"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Charles Bridge",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08651,14.41130:508601",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08651,14.41130:508601",
                  "referrerId": "HOT.SR.poi.50.08651,14.41130:508601.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08651,14.41130:508601",
                  "referrerId": "HOT.SR.poi.50.08651,14.41130:508601.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "O2 Arena",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.10477,14.49381:6071197",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.10477,14.49381:6071197",
                  "referrerId": "HOT.SR.poi.50.10477,14.49381:6071197.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.10477,14.49381:6071197",
                  "referrerId": "HOT.SR.poi.50.10477,14.49381:6071197.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Prague Astronomical Clock",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08699,14.42072:6071133",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08699,14.42072:6071133",
                  "referrerId": "HOT.SR.poi.50.08699,14.42072:6071133.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08699,14.42072:6071133",
                  "referrerId": "HOT.SR.poi.50.08699,14.42072:6071133.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Wenceslas Square",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08104,14.42771:507867",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08104,14.42771:507867",
                  "referrerId": "HOT.SR.poi.50.08104,14.42771:507867.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08104,14.42771:507867",
                  "referrerId": "HOT.SR.poi.50.08104,14.42771:507867.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Palladium Shopping Centre",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08940,14.42964:6145321",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08940,14.42964:6145321",
                  "referrerId": "HOT.SR.poi.50.08940,14.42964:6145321.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08940,14.42964:6145321",
                  "referrerId": "HOT.SR.poi.50.08940,14.42964:6145321.false:4"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Dancing House",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.07551,14.41409:6071189",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.07551,14.41409:6071189",
                  "referrerId": "HOT.SR.poi.50.07551,14.41409:6071189.true:5"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.07551,14.41409:6071189",
                  "referrerId": "HOT.SR.poi.50.07551,14.41409:6071189.false:5"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Prague Castle",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.09047,14.39890:502375",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.09047,14.39890:502375",
                  "referrerId": "HOT.SR.poi.50.09047,14.39890:502375.true:6"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.09047,14.39890:502375",
                  "referrerId": "HOT.SR.poi.50.09047,14.39890:502375.false:6"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Hotel International Prague",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.10944,14.39343:553248621533096879",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.10944,14.39343:553248621533096879",
                  "referrerId": "HOT.SR.poi.50.10944,14.39343:553248621533096879.true:7"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.10944,14.39343:553248621533096879",
                  "referrerId": "HOT.SR.poi.50.10944,14.39343:553248621533096879.false:7"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Charles University",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08891,14.41632:6071141",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08891,14.41632:6071141",
                  "referrerId": "HOT.SR.poi.50.08891,14.41632:6071141.true:9"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08891,14.41632:6071141",
                  "referrerId": "HOT.SR.poi.50.08891,14.41632:6071141.false:9"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Prague Congress Centre",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.06143,14.42920:6071187",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.06143,14.42920:6071187",
                  "referrerId": "HOT.SR.poi.50.06143,14.42920:6071187.true:10"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.06143,14.42920:6071187",
                  "referrerId": "HOT.SR.poi.50.06143,14.42920:6071187.false:10"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Royal Route",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08723,14.42054:6344401",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08723,14.42054:6344401",
                  "referrerId": "HOT.SR.poi.50.08723,14.42054:6344401.true:11"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08723,14.42054:6344401",
                  "referrerId": "HOT.SR.poi.50.08723,14.42054:6344401.false:11"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Fortuna Arena",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.06744,14.47153:6248373",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.06744,14.47153:6248373",
                  "referrerId": "HOT.SR.poi.50.06744,14.47153:6248373.true:12"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.06744,14.47153:6248373",
                  "referrerId": "HOT.SR.poi.50.06744,14.47153:6248373.false:12"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "AquaPalace",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.00744,14.57156:6099288",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.00744,14.57156:6099288",
                  "referrerId": "HOT.SR.poi.50.00744,14.57156:6099288.true:13"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.00744,14.57156:6099288",
                  "referrerId": "HOT.SR.poi.50.00744,14.57156:6099288.false:13"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "New Town Hall",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.07812,14.42104:553248621533096906",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.07812,14.42104:553248621533096906",
                  "referrerId": "HOT.SR.poi.50.07812,14.42104:553248621533096906.true:14"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.07812,14.42104:553248621533096906",
                  "referrerId": "HOT.SR.poi.50.07812,14.42104:553248621533096906.false:14"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "PVA Letnany Exhibition Center",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.12976,14.51361:6145319",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.12976,14.51361:6145319",
                  "referrerId": "HOT.SR.poi.50.12976,14.51361:6145319.true:15"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.12976,14.51361:6145319",
                  "referrerId": "HOT.SR.poi.50.12976,14.51361:6145319.false:15"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Kampa Island",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08495,14.40847:505903",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08495,14.40847:505903",
                  "referrerId": "HOT.SR.poi.50.08495,14.40847:505903.true:16"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08495,14.40847:505903",
                  "referrerId": "HOT.SR.poi.50.08495,14.40847:505903.false:16"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "VJ Rott Building",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08667,14.41938:553248621533096909",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08667,14.41938:553248621533096909",
                  "referrerId": "HOT.SR.poi.50.08667,14.41938:553248621533096909.true:17"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08667,14.41938:553248621533096909",
                  "referrerId": "HOT.SR.poi.50.08667,14.41938:553248621533096909.false:17"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Museum of the Infant Jesus of Prague",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08561,14.40395:553248621533096919",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08561,14.40395:553248621533096919",
                  "referrerId": "HOT.SR.poi.50.08561,14.40395:553248621533096919.true:18"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08561,14.40395:553248621533096919",
                  "referrerId": "HOT.SR.poi.50.08561,14.40395:553248621533096919.false:18"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "poi",
                "primary": "Lesser Town Square",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "50.08854,14.40377:508603",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08854,14.40377:508603",
                  "referrerId": "HOT.SR.poi.50.08854,14.40377:508603.true:19"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "poi.50.08854,14.40377:508603",
                  "referrerId": "HOT.SR.poi.50.08854,14.40377:508603.false:19"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Meal plans available",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 4,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "mealPlan",
                "primary": "Breakfast included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FREE_BREAKFAST",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FREE_BREAKFAST",
                  "referrerId": "HOT.SR.mealPlan.FREE_BREAKFAST.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FREE_BREAKFAST",
                  "referrerId": "HOT.SR.mealPlan.FREE_BREAKFAST.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "mealPlan",
                "primary": "Lunch included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HALF_BOARD",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.HALF_BOARD",
                  "referrerId": "HOT.SR.mealPlan.HALF_BOARD.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.HALF_BOARD",
                  "referrerId": "HOT.SR.mealPlan.HALF_BOARD.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "mealPlan",
                "primary": "Dinner included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FULL_BOARD",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FULL_BOARD",
                  "referrerId": "HOT.SR.mealPlan.FULL_BOARD.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.FULL_BOARD",
                  "referrerId": "HOT.SR.mealPlan.FULL_BOARD.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "mealPlan",
                "primary": "All-inclusive",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ALL_INCLUSIVE",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.ALL_INCLUSIVE",
                  "referrerId": "HOT.SR.mealPlan.ALL_INCLUSIVE.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "mealPlan.ALL_INCLUSIVE",
                  "referrerId": "HOT.SR.mealPlan.ALL_INCLUSIVE.false:3"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionTileField",
            "primary": "Amenities",
            "secondary": null,
            "tileMultiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "WiFi included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "wifi",
                  "description": "",
                  "size": null,
                  "token": "icon__wifi",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "WIFI",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WIFI",
                  "referrerId": "HOT.SR.amenities.WIFI.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WIFI",
                  "referrerId": "HOT.SR.amenities.WIFI.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Parking",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "local_parking",
                  "description": "",
                  "size": null,
                  "token": "icon__local_parking",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FREE_PARKING",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_PARKING",
                  "referrerId": "HOT.SR.amenities.FREE_PARKING.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_PARKING",
                  "referrerId": "HOT.SR.amenities.FREE_PARKING.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Pool",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "pool",
                  "description": "",
                  "size": null,
                  "token": "icon__pool",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "POOL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.POOL",
                  "referrerId": "HOT.SR.amenities.POOL.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.POOL",
                  "referrerId": "HOT.SR.amenities.POOL.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Pet-friendly",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "pets",
                  "description": "",
                  "size": null,
                  "token": "icon__pets",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "PETS",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.PETS",
                  "referrerId": "HOT.SR.amenities.PETS.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.PETS",
                  "referrerId": "HOT.SR.amenities.PETS.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Air conditioned",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "ac_unit",
                  "description": "",
                  "size": null,
                  "token": "icon__ac_unit",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "AIR_CONDITIONING",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.AIR_CONDITIONING",
                  "referrerId": "HOT.SR.amenities.AIR_CONDITIONING.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.AIR_CONDITIONING",
                  "referrerId": "HOT.SR.amenities.AIR_CONDITIONING.false:4"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Kitchen",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "kitchen",
                  "description": "",
                  "size": null,
                  "token": "icon__kitchen",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "KITCHEN_KITCHENETTE",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.KITCHEN_KITCHENETTE",
                  "referrerId": "HOT.SR.amenities.KITCHEN_KITCHENETTE.true:5"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.KITCHEN_KITCHENETTE",
                  "referrerId": "HOT.SR.amenities.KITCHEN_KITCHENETTE.false:5"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Casino",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "casino",
                  "description": "",
                  "size": null,
                  "token": "icon__casino",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "CASINO",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.CASINO",
                  "referrerId": "HOT.SR.amenities.CASINO.true:6"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.CASINO",
                  "referrerId": "HOT.SR.amenities.CASINO.false:6"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Gym",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "fitness_center",
                  "description": "",
                  "size": null,
                  "token": "fitness_center",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "GYM",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.GYM",
                  "referrerId": "HOT.SR.amenities.GYM.true:7"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.GYM",
                  "referrerId": "HOT.SR.amenities.GYM.false:7"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Airport shuttle included",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "airport_shuttle",
                  "description": "",
                  "size": null,
                  "token": "icon__airport_shuttle",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FREE_AIRPORT_TRANSPORTATION",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_AIRPORT_TRANSPORTATION",
                  "referrerId": "HOT.SR.amenities.FREE_AIRPORT_TRANSPORTATION.true:8"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.FREE_AIRPORT_TRANSPORTATION",
                  "referrerId": "HOT.SR.amenities.FREE_AIRPORT_TRANSPORTATION.false:8"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Spa",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "spa",
                  "description": "",
                  "size": null,
                  "token": "icon__spa",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "SPA_ON_SITE",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.SPA_ON_SITE",
                  "referrerId": "HOT.SR.amenities.SPA_ON_SITE.true:9"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.SPA_ON_SITE",
                  "referrerId": "HOT.SR.amenities.SPA_ON_SITE.false:9"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Outdoor space",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "balcony",
                  "description": "",
                  "size": null,
                  "token": "balcony",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "BALCONY_OR_TERRACE",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.BALCONY_OR_TERRACE",
                  "referrerId": "HOT.SR.amenities.BALCONY_OR_TERRACE.true:10"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.BALCONY_OR_TERRACE",
                  "referrerId": "HOT.SR.amenities.BALCONY_OR_TERRACE.false:10"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Restaurant",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "local_dining",
                  "description": "",
                  "size": null,
                  "token": "local_dining",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "RESTAURANT_IN_HOTEL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.RESTAURANT_IN_HOTEL",
                  "referrerId": "HOT.SR.amenities.RESTAURANT_IN_HOTEL.true:11"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.RESTAURANT_IN_HOTEL",
                  "referrerId": "HOT.SR.amenities.RESTAURANT_IN_HOTEL.false:11"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Ocean view",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "water",
                  "description": "",
                  "size": null,
                  "token": "icon__water",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "OCEAN_VIEW",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.OCEAN_VIEW",
                  "referrerId": "HOT.SR.amenities.OCEAN_VIEW.true:12"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.OCEAN_VIEW",
                  "referrerId": "HOT.SR.amenities.OCEAN_VIEW.false:12"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Hot tub",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "hot_tub",
                  "description": "",
                  "size": null,
                  "token": "icon__hot_tub",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "HOT_TUB",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.HOT_TUB",
                  "referrerId": "HOT.SR.amenities.HOT_TUB.true:13"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.HOT_TUB",
                  "referrerId": "HOT.SR.amenities.HOT_TUB.false:13"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Washer and dryer",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "local_laundry_service",
                  "description": "",
                  "size": null,
                  "token": "icon__local_laundry_service",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "WASHER_DRYER",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WASHER_DRYER",
                  "referrerId": "HOT.SR.amenities.WASHER_DRYER.true:14"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WASHER_DRYER",
                  "referrerId": "HOT.SR.amenities.WASHER_DRYER.false:14"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Electric car charging station",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "ev_station",
                  "description": "",
                  "size": null,
                  "token": "ev_station",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ELECTRIC_CAR",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.ELECTRIC_CAR",
                  "referrerId": "HOT.SR.amenities.ELECTRIC_CAR.true:15"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.ELECTRIC_CAR",
                  "referrerId": "HOT.SR.amenities.ELECTRIC_CAR.false:15"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Cots",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "bedding__crib",
                  "description": "",
                  "size": null,
                  "token": "bedding__crib",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "CRIB",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.CRIB",
                  "referrerId": "HOT.SR.amenities.CRIB.true:16"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.CRIB",
                  "referrerId": "HOT.SR.amenities.CRIB.false:16"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "amenities",
                "primary": "Water park",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "water_park",
                  "description": "",
                  "size": null,
                  "token": "water_park",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "WATER_PARK",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WATER_PARK",
                  "referrerId": "HOT.SR.amenities.WATER_PARK.true:17"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "amenities.WATER_PARK",
                  "referrerId": "HOT.SR.amenities.WATER_PARK.false:17"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Hotels.com Rewards",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "rewards",
                "primary": "Redeem reward nights",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "REDEEM_REWARD_NIGHTS",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "rewards.REDEEM_REWARD_NIGHTS",
                  "referrerId": "HOT.SR.rewards.REDEEM_REWARD_NIGHTS.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "rewards.REDEEM_REWARD_NIGHTS",
                  "referrerId": "HOT.SR.rewards.REDEEM_REWARD_NIGHTS.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "",
                "primary": "VIP Access properties",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "",
                "description": "A collection of top-rated stays",
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": ".",
                  "referrerId": "HOT.SR...true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": ".",
                  "referrerId": "HOT.SR...false:1"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Accessibility",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Accessible bathroom",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ACCESSIBLE_BATHROOM",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ACCESSIBLE_BATHROOM",
                  "referrerId": "HOT.SR.accessibility.ACCESSIBLE_BATHROOM.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ACCESSIBLE_BATHROOM",
                  "referrerId": "HOT.SR.accessibility.ACCESSIBLE_BATHROOM.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Sign language-capable staff",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "SIGN_LANGUAGE_INTERPRETER",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.SIGN_LANGUAGE_INTERPRETER",
                  "referrerId": "HOT.SR.accessibility.SIGN_LANGUAGE_INTERPRETER.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.SIGN_LANGUAGE_INTERPRETER",
                  "referrerId": "HOT.SR.accessibility.SIGN_LANGUAGE_INTERPRETER.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Wheelchair-accessible parking",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ACCESSIBLE_PARKING",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ACCESSIBLE_PARKING",
                  "referrerId": "HOT.SR.accessibility.ACCESSIBLE_PARKING.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ACCESSIBLE_PARKING",
                  "referrerId": "HOT.SR.accessibility.ACCESSIBLE_PARKING.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Lift",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ELEVATOR",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ELEVATOR",
                  "referrerId": "HOT.SR.accessibility.ELEVATOR.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ELEVATOR",
                  "referrerId": "HOT.SR.accessibility.ELEVATOR.false:3"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "In-room accessibility",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "IN_ROOM_ACCESSIBLE",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.IN_ROOM_ACCESSIBLE",
                  "referrerId": "HOT.SR.accessibility.IN_ROOM_ACCESSIBLE.true:4"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.IN_ROOM_ACCESSIBLE",
                  "referrerId": "HOT.SR.accessibility.IN_ROOM_ACCESSIBLE.false:4"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Roll-in shower",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ROLL_IN_SHOWER",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ROLL_IN_SHOWER",
                  "referrerId": "HOT.SR.accessibility.ROLL_IN_SHOWER.true:5"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.ROLL_IN_SHOWER",
                  "referrerId": "HOT.SR.accessibility.ROLL_IN_SHOWER.false:5"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Service animals allowed",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "SERVICE_ANIMAL",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.SERVICE_ANIMAL",
                  "referrerId": "HOT.SR.accessibility.SERVICE_ANIMAL.true:6"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.SERVICE_ANIMAL",
                  "referrerId": "HOT.SR.accessibility.SERVICE_ANIMAL.false:6"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "accessibility",
                "primary": "Stair-free path to entrance",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "STAIR_FREE_PATH",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.STAIR_FREE_PATH",
                  "referrerId": "HOT.SR.accessibility.STAIR_FREE_PATH.true:7"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "accessibility.STAIR_FREE_PATH",
                  "referrerId": "HOT.SR.accessibility.STAIR_FREE_PATH.false:7"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Traveller experience",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 4,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "travelerType",
                "primary": "Eco-certified",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "ECO_CERTIFIED",
                "description": "See properties certified by an accredited independent organisation for meeting certain sustainability standards.",
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.ECO_CERTIFIED",
                  "referrerId": "HOT.SR.travelerType.ECO_CERTIFIED.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.ECO_CERTIFIED",
                  "referrerId": "HOT.SR.travelerType.ECO_CERTIFIED.false:0"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "travelerType",
                "primary": "LGBTQ welcoming",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "LGBT",
                "description": "See properties that pledge to make all guests feel safe, welcome and respected.",
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.LGBT",
                  "referrerId": "HOT.SR.travelerType.LGBT.true:1"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.LGBT",
                  "referrerId": "HOT.SR.travelerType.LGBT.false:1"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "travelerType",
                "primary": "Business-friendly",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "BUSINESS",
                "description": "See properties with amenities to help you work comfortably, like WiFi and breakfast.",
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.BUSINESS",
                  "referrerId": "HOT.SR.travelerType.BUSINESS.true:2"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.BUSINESS",
                  "referrerId": "HOT.SR.travelerType.BUSINESS.false:2"
                }
              },
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "travelerType",
                "primary": "Family-friendly",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "FAMILY",
                "description": "See properties that include family essentials like in-room conveniences and activities for the kids.",
                "selected": false,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.FAMILY",
                  "referrerId": "HOT.SR.travelerType.FAMILY.true:3"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "travelerType.FAMILY",
                  "referrerId": "HOT.SR.travelerType.FAMILY.false:3"
                }
              }
            ]
          },
          {
            "__typename": "ShoppingMultiSelectionField",
            "primary": "Availability",
            "secondary": null,
            "expando": {
              "__typename": "ShoppingSelectionExpando",
              "threshold": 3,
              "collapseLabel": "See less",
              "expandLabel": "See more",
              "collapseAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              },
              "expandAnalytics": {
                "__typename": "ClientSideAnalytics",
                "linkName": "",
                "referrerId": ""
              }
            },
            "multiSelectionOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "availableFilter",
                "primary": "Only show available properties",
                "secondary": null,
                "icon": {
                  "__typename": "Icon",
                  "id": "",
                  "description": "",
                  "size": null,
                  "token": "",
                  "theme": null
                },
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "SHOW_AVAILABLE_ONLY",
                "description": null,
                "selected": true,
                "disabled": false,
                "default": false,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "availableFilter.SHOW_AVAILABLE_ONLY",
                  "referrerId": "HOT.SR.availableFilter.SHOW_AVAILABLE_ONLY.true:0"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "availableFilter.SHOW_AVAILABLE_ONLY",
                  "referrerId": "HOT.SR.availableFilter.SHOW_AVAILABLE_ONLY.false:0"
                }
              }
            ]
          }
        ]
      }
    ],
    "sortSections": [
      {
        "__typename": "ShoppingSortAndFilterSection",
        "title": null,
        "fields": [
          {
            "__typename": "ShoppingDropdownField",
            "primary": "Sort by",
            "secondary": null,
            "dropdownFilterOptions": [
              {
                "__typename": "ShoppingSelectableFilterOption",
                "id": "sort",
                "primary": "Recommended",
                "secondary": null,
                "icon": null,
                "analytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "",
                  "referrerId": ""
                },
                "value": "RECOMMENDED",
                "description": null,
                "selected": false,
                "disabled": false,
                "default": true,
                "selectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "sort.RECOMMENDED",
                  "referrerId": "HOT.SR.sort.RECOMMENDED.true"
                },
                "deselectAnalytics": {
                  "__typename": "ClientSideAnalytics",
                  "linkName": "sort.RECOMMENDED",
                  "referrerId": "HOT.SR.sort.RECOMMENDED.false"
                }
              }
            ]
          }
        ]
      }
    ]
  },
  "properties": [
    {
      "__typename": "Property",
      "id": "66932918",
      "featuredMessages": [],
      "name": "Hotel CUBE Prague",
      "availability": {
        "__typename": "PropertyAvailability",
        "available": true,
        "minRoomsLeft": 2
      },
      "propertyImage": {
        "__typename": "PropertyImage",
        "alt": "",
        "fallbackImage": null,
        "image": {
          "__typename": "Image",
          "description": "Interior",
          "url": "https://images.trvl-media.com/lodging/67000000/66940000/66933000/66932918/8c4afbfe.jpg?impolicy=resizecrop&rw=455&ra=fit"
        },
        "subjectId": 83000
      },
      "destinationInfo": {
        "__typename": "PropertyDestinationInfo",
        "distanceFromDestination": {
          "__typename": "Distance",
          "unit": "KILOMETER",
          "value": 1.1
        },
        "distanceFromMessaging": null,
        "regionId": "2872"
      },
      "legalDisclaimer": null,
      "listingFooter": null,
      "mapMarker": {
        "__typename": "MapMarker",
        "label": "$272",
        "latLong": {
          "__typename": "Coordinates",
          "latitude": 50.079023,
          "longitude": 14.417016
        }
      },
      "neighborhood": {
        "__typename": "Region",
        "name": "Nove Mesto"
      },
      "offerBadge": {
        "__typename": "OfferBadge",
        "primary": {
          "__typename": "Badge",
          "text": "Member Price",
          "theme_temp": "DEAL_MEMBER",
          "icon_temp": {
            "__typename": "Icon",
            "id": "mod",
            "description": "mod"
          },
          "mark": null
        },
        "secondary": {
          "__typename": "Badge",
          "text": "10% off",
          "theme_temp": "DEAL_MEMBER",
          "icon_temp": {
            "__typename": "Icon",
            "id": "mod",
            "description": "mod"
          },
          "mark": null
        }
      },
      "offerSummary": {
        "__typename": "OfferSummary",
        "messages": [
          {
            "__typename": "OfferSummaryMessage",
            "message": "Fully refundable",
            "theme": "SUCCESS",
            "type": "FREE_CANCEL",
            "mark": null
          }
        ],
        "attributes": [
          {
            "__typename": "OfferAttribute",
            "type": "FREE_CANCELLATION"
          }
        ]
      },
      "pinnedDetails": null,
      "price": {
        "__typename": "PropertyPrice",
        "options": [
          {
            "__typename": "PropertyPriceOption",
            "strikeOut": {
              "__typename": "Money",
              "amount": 302.7,
              "formatted": "$303"
            },
            "disclaimer": {
              "__typename": "LodgingPlainMessage",
              "value": "Standard rate on our site, provided by the property and based on your search, before all discounts and rewards applied."
            },
            "formattedDisplayPrice": "$272"
          }
        ],
        "priceMessaging": null,
        "lead": {
          "__typename": "Money",
          "amount": 272.43,
          "currencyInfo": {
            "__typename": "Currency",
            "code": "USD",
            "symbol": "$"
          },
          "formatted": "$272"
        },
        "strikeOut": {
          "__typename": "Money",
          "amount": 302.7,
          "currencyInfo": {
            "__typename": "Currency",
            "code": "USD",
            "symbol": "$"
          },
          "formatted": "$303"
        },
        "displayMessages": [
          {
            "__typename": "PriceDisplayMessage",
            "lineItems": [
              {
                "__typename": "DisplayPrice",
                "disclaimer": {
                  "__typename": "LodgingPlainDialog",
                  "content": [
                    "Standard rate on our site, provided by the property and based on your search, before all discounts and rewards applied."
                  ],
                  "title": null
                },
                "price": {
                  "__typename": "FormattedMoney",
                  "formatted": "$303",
                  "accessibilityLabel": "The price was $303"
                },
                "role": "STRIKEOUT"
              },
              {
                "__typename": "DisplayPrice",
                "disclaimer": null,
                "price": {
                  "__typename": "FormattedMoney",
                  "formatted": "$272",
                  "accessibilityLabel": "The price is $272"
                },
                "role": "LEAD"
              }
            ]
          },
          {
            "__typename": "PriceDisplayMessage",
            "lineItems": [
              {
                "__typename": "LodgingEnrichedMessage",
                "accessibilityLabel": null,
                "mark": null,
                "state": null,
                "value": "$326 total",
                "badge": null
              }
            ]
          }
        ],
        "strikeOutType": "STANDALONE",
        "priceMessages": [
          {
            "__typename": "LodgingPlainMessage",
            "value": "per night"
          },
          {
            "__typename": "LodgingPlainMessage",
            "value": "26 Oct - 27 Oct"
          }
        ]
      },
      "priceAfterLoyaltyPointsApplied": {
        "__typename": "PropertyPrice",
        "options": [
          {
            "__typename": "PropertyPriceOption",
            "strikeOut": {
              "__typename": "Money",
              "amount": 302.7,
              "formatted": "$303"
            },
            "disclaimer": {
              "__typename": "LodgingPlainMessage",
              "value": "Standard rate on our site, provided by the property and based on your search, before all discounts and rewards applied."
            },
            "formattedDisplayPrice": "$272"
          }
        ],
        "lead": {
          "__typename": "Money",
          "amount": 272.43,
          "currencyInfo": {
            "__typename": "Currency",
            "code": "USD",
            "symbol": "$"
          },
          "formatted": "$272"
        }
      },
      "propertyFees": [
        {
          "__typename": "Fees",
          "type": "RESORT"
        }
      ],
      "reviews": {
        "__typename": "PropertyReviewsSummary",
        "score": 9.8,
        "total": 88
      },
      "star": 3.5,
      "supportingMessages": null,
      "regionId": "2872",
      "priceMetadata": {
        "__typename": "PropertyPriceMetadata",
        "discountType": "MEMBER_DEAL",
        "rateDiscount": {
          "__typename": "RateDiscount",
          "description": "Private sale: save 9%"
        },
        "totalDiscountPercentage": 10
      },
      "saveTripItem": null
    }
  }
}
```

To Model:
```bash
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Action
    {
        public string Typename { get; set; }
        public string ActionType { get; set; }
        public object Accessibility { get; set; }
        public Analytics Analytics { get; set; }
    }

    public class Actions
    {
        public string Typename { get; set; }
        public Primary Primary { get; set; }
        public List<Secondary> Secondaries { get; set; }
    }

    public class Amenity
    {
        public string Typename { get; set; }
        public int Id { get; set; }
    }

    public class Analytics
    {
        public string Typename { get; set; }
        public string LinkName { get; set; }
        public string ReferrerId { get; set; }
    }

    public class ApplyAction
    {
        public string Typename { get; set; }
        public string Primary { get; set; }
        public Action Action { get; set; }
        public string Accessibility { get; set; }
        public object Badge { get; set; }
        public bool Disabled { get; set; }
        public object Icon { get; set; }
    }

    public class Attribute
    {
        public string Typename { get; set; }
        public string Type { get; set; }
    }

    public class Availability
    {
        public string Typename { get; set; }
        public bool Available { get; set; }
        public int MinRoomsLeft { get; set; }
    }

    public class Characteristics
    {
        public string Typename { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Step { get; set; }
        public List<Label> Labels { get; set; }
    }

    public class CollapseAnalytics
    {
        public string Typename { get; set; }
        public string LinkName { get; set; }
        public string ReferrerId { get; set; }
    }

    public class CurrencyInfo
    {
        public string Typename { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
    }

    public class DeselectAnalytics
    {
        public string Typename { get; set; }
        public string LinkName { get; set; }
        public string ReferrerId { get; set; }
    }

    public class DestinationInfo
    {
        public string Typename { get; set; }
        public DistanceFromDestination DistanceFromDestination { get; set; }
        public object DistanceFromMessaging { get; set; }
        public string RegionId { get; set; }
    }

    public class Disclaimer
    {
        public string Typename { get; set; }
        public string Value { get; set; }
        public List<string> Content { get; set; }
        public object Title { get; set; }
    }

    public class DisplayMessage
    {
        public string Typename { get; set; }
        public List<LineItem> LineItems { get; set; }
    }

    public class DistanceFromDestination
    {
        public string Typename { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
    }

    public class DropdownFilterOption
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public object Icon { get; set; }
        public Analytics Analytics { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public bool Default { get; set; }
        public SelectAnalytics SelectAnalytics { get; set; }
        public DeselectAnalytics DeselectAnalytics { get; set; }
    }

    public class ExpandAnalytics
    {
        public string Typename { get; set; }
        public string LinkName { get; set; }
        public string ReferrerId { get; set; }
    }

    public class Expando
    {
        public string Typename { get; set; }
        public int Threshold { get; set; }
        public string CollapseLabel { get; set; }
        public string ExpandLabel { get; set; }
        public CollapseAnalytics CollapseAnalytics { get; set; }
        public ExpandAnalytics ExpandAnalytics { get; set; }
    }

    public class Field
    {
        public string Typename { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public Action Action { get; set; }
        public string Id { get; set; }
        public object Label { get; set; }
        public string Placeholder { get; set; }
        public object Selected { get; set; }
        public TypeaheadInfo TypeaheadInfo { get; set; }
        public Icon Icon { get; set; }
        public Analytics Analytics { get; set; }
        public Expando Expando { get; set; }
        public List<MultiSelectionOption> MultiSelectionOptions { get; set; }
        public Range Range { get; set; }
        public List<Option> Options { get; set; }
        public List<TileMultiSelectionOption> TileMultiSelectionOptions { get; set; }
        public List<DropdownFilterOption> DropdownFilterOptions { get; set; }
    }

    public class FilterMetadata
    {
        public string Typename { get; set; }
        public List<Amenity> Amenities { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; }
        public PriceRange PriceRange { get; set; }
    }

    public class FilterSection
    {
        public string Typename { get; set; }
        public string Title { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class Icon
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public object Size { get; set; }
        public string Token { get; set; }
        public object Theme { get; set; }
    }

    public class IconTemp
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
    }

    public class Image
    {
        public string Typename { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class Label
    {
        public string Typename { get; set; }
        public string Label { get; set; }
        public int Value { get; set; }
    }

    public class LatLong
    {
        public string Typename { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Lead
    {
        public string Typename { get; set; }
        public double Amount { get; set; }
        public CurrencyInfo CurrencyInfo { get; set; }
        public string Formatted { get; set; }
    }

    public class LineItem
    {
        public string Typename { get; set; }
        public Disclaimer Disclaimer { get; set; }
        public Price Price { get; set; }
        public string Role { get; set; }
        public object AccessibilityLabel { get; set; }
        public object Mark { get; set; }
        public object State { get; set; }
        public string Value { get; set; }
        public object Badge { get; set; }
    }

    public class MapMarker
    {
        public string Typename { get; set; }
        public string Label { get; set; }
        public LatLong LatLong { get; set; }
    }

    public class Message
    {
        public string Typename { get; set; }
        public string Message { get; set; }
        public string Theme { get; set; }
        public string Type { get; set; }
        public object Mark { get; set; }
    }

    public class MultiSelectionOption
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public Icon Icon { get; set; }
        public Analytics Analytics { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public bool Default { get; set; }
        public SelectAnalytics SelectAnalytics { get; set; }
        public DeselectAnalytics DeselectAnalytics { get; set; }
    }

    public class Neighborhood
    {
        public string Typename { get; set; }
        public string Name { get; set; }
        public string RegionId { get; set; }
    }

    public class Neighborhood2
    {
        public string Typename { get; set; }
        public string Name { get; set; }
    }

    public class OfferBadge
    {
        public string Typename { get; set; }
        public Primary Primary { get; set; }
        public Secondary Secondary { get; set; }
    }

    public class OfferSummary
    {
        public string Typename { get; set; }
        public List<Message> Messages { get; set; }
        public List<Attribute> Attributes { get; set; }
    }

    public class Option
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public Icon Icon { get; set; }
        public Analytics Analytics { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public bool Default { get; set; }
        public SelectAnalytics SelectAnalytics { get; set; }
        public DeselectAnalytics DeselectAnalytics { get; set; }
        public StrikeOut StrikeOut { get; set; }
        public Disclaimer Disclaimer { get; set; }
        public string FormattedDisplayPrice { get; set; }
    }

    public class Price
    {
        public string Typename { get; set; }
        public List<Option> Options { get; set; }
        public object PriceMessaging { get; set; }
        public Lead Lead { get; set; }
        public StrikeOut StrikeOut { get; set; }
        public List<DisplayMessage> DisplayMessages { get; set; }
        public string StrikeOutType { get; set; }
        public List<PriceMessage> PriceMessages { get; set; }
        public string Formatted { get; set; }
        public string AccessibilityLabel { get; set; }
    }

    public class PriceAfterLoyaltyPointsApplied
    {
        public string Typename { get; set; }
        public List<Option> Options { get; set; }
        public Lead Lead { get; set; }
    }

    public class PriceMessage
    {
        public string Typename { get; set; }
        public string Value { get; set; }
    }

    public class PriceMetadata
    {
        public string Typename { get; set; }
        public string DiscountType { get; set; }
        public RateDiscount RateDiscount { get; set; }
        public int TotalDiscountPercentage { get; set; }
    }

    public class PriceRange
    {
        public string Typename { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
    }

    public class Primary
    {
        public string Typename { get; set; }
        public object Primary { get; set; }
        public Action Action { get; set; }
        public string Text { get; set; }
        public string ThemeTemp { get; set; }
        public IconTemp IconTemp { get; set; }
        public object Mark { get; set; }
    }

    public class Property
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public List<object> FeaturedMessages { get; set; }
        public string Name { get; set; }
        public Availability Availability { get; set; }
        public PropertyImage PropertyImage { get; set; }
        public DestinationInfo DestinationInfo { get; set; }
        public object LegalDisclaimer { get; set; }
        public object ListingFooter { get; set; }
        public MapMarker MapMarker { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public OfferBadge OfferBadge { get; set; }
        public OfferSummary OfferSummary { get; set; }
        public object PinnedDetails { get; set; }
        public Price Price { get; set; }
        public PriceAfterLoyaltyPointsApplied PriceAfterLoyaltyPointsApplied { get; set; }
        public List<PropertyFee> PropertyFees { get; set; }
        public Reviews Reviews { get; set; }
        public double Star { get; set; }
        public object SupportingMessages { get; set; }
        public string RegionId { get; set; }
        public PriceMetadata PriceMetadata { get; set; }
        public object SaveTripItem { get; set; }
    }

    public class PropertyFee
    {
        public string Typename { get; set; }
        public string Type { get; set; }
    }

    public class PropertyImage
    {
        public string Typename { get; set; }
        public string Alt { get; set; }
        public object FallbackImage { get; set; }
        public Image Image { get; set; }
        public int SubjectId { get; set; }
    }

    public class Range
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public object Icon { get; set; }
        public Analytics Analytics { get; set; }
        public Selected Selected { get; set; }
        public Characteristics Characteristics { get; set; }
    }

    public class RateDiscount
    {
        public string Typename { get; set; }
        public string Description { get; set; }
    }

    public class RevealAction
    {
        public string Typename { get; set; }
        public string Primary { get; set; }
        public Action Action { get; set; }
        public string Accessibility { get; set; }
        public int Badge { get; set; }
        public bool Disabled { get; set; }
        public Icon Icon { get; set; }
    }

    public class Reviews
    {
        public string Typename { get; set; }
        public double Score { get; set; }
        public int Total { get; set; }
    }

    public class Root
    {
        public string Typename { get; set; }
        public FilterMetadata FilterMetadata { get; set; }
        public UniversalSortAndFilter UniversalSortAndFilter { get; set; }
        public List<Property> Properties { get; set; }
    }

    public class Secondary
    {
        public string Typename { get; set; }
        public string Primary { get; set; }
        public bool Disabled { get; set; }
        public Action Action { get; set; }
    }

    public class Secondary2
    {
        public string Typename { get; set; }
        public string Text { get; set; }
        public string ThemeTemp { get; set; }
        public IconTemp IconTemp { get; set; }
        public object Mark { get; set; }
    }

    public class SelectAnalytics
    {
        public string Typename { get; set; }
        public string LinkName { get; set; }
        public string ReferrerId { get; set; }
    }

    public class Selected
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class SortSection
    {
        public string Typename { get; set; }
        public object Title { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class StrikeOut
    {
        public string Typename { get; set; }
        public double Amount { get; set; }
        public string Formatted { get; set; }
        public CurrencyInfo CurrencyInfo { get; set; }
    }

    public class TileMultiSelectionOption
    {
        public string Typename { get; set; }
        public string Id { get; set; }
        public string Primary { get; set; }
        public object Secondary { get; set; }
        public Icon Icon { get; set; }
        public Analytics Analytics { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
        public bool Default { get; set; }
        public SelectAnalytics SelectAnalytics { get; set; }
        public DeselectAnalytics DeselectAnalytics { get; set; }
    }

    public class Toolbar
    {
        public string Typename { get; set; }
        public string Primary { get; set; }
        public Actions Actions { get; set; }
    }

    public class TypeaheadInfo
    {
        public string Typename { get; set; }
        public string Client { get; set; }
        public bool IsDestination { get; set; }
        public string LineOfBusiness { get; set; }
        public int MaxNumberOfResults { get; set; }
        public object PackageType { get; set; }
        public bool Personalize { get; set; }
        public int RegionType { get; set; }
        public string TypeaheadFeatures { get; set; }
    }

    public class UniversalSortAndFilter
    {
        public string Typename { get; set; }
        public Toolbar Toolbar { get; set; }
        public RevealAction RevealAction { get; set; }
        public ApplyAction ApplyAction { get; set; }
        public List<FilterSection> FilterSections { get; set; }
        public List<SortSection> SortSections { get; set; }
    }
```

## CAR RENTAL
### Booking.com
https://rapidapi.com/tipsters/api/booking-com

"GET/Search car rental"

REQUIRED: pick up longitude, pick up latitude, drop off longitude, drop off latitude, pickup datetime, drop off datetime, currency

Return example:
```bash
{
  "search_key": "eyJkcml2ZXJzQWdlIjozNSwiZHJvcE9mZkRhdGVUaW1lIjoiMjAyMy0xMC0zMVQxNjowMDowMCIsImRyb3BPZmZMb2NhdGlvbiI6IjUwLjA4NzczLDE0LjQyMTEzMyIsImRyb3BPZmZMb2NhdGlvblR5cGUiOiJMQVRMT05HIiwicGlja1VwRGF0ZVRpbWUiOiIyMDIzLTEwLTI5VDE2OjAwOjAwIiwicGlja1VwTG9jYXRpb24iOiI1MC4wODc3MywxNC40MjExMzMiLCJwaWNrVXBMb2NhdGlvblR5cGUiOiJMQVRMT05HIiwicmVudGFsRHVyYXRpb25JbkRheXMiOjIsInNlcnZpY2VGZWF0dXJlcyI6WyJOT19PUEFRVUVTIiwiU1VQUkVTU19GSVhFRF9QUklDRV9WRUhJQ0xFUyJdfQ==",
  "sort": [
    {
      "name": "Recommended – best first",
      "identifier": "recommended",
      "title_tag": "tr.searchresults.sortBy.recommended"
    },
    {
      "identifier": "price_low_to_high",
      "name": "Price - lowest first",
      "title_tag": "tr.searchresults.sortBy.price.lowHigh"
    }
  ],
  "count": 232,
  "filter": [
    {
      "layout": {
        "collapsed_count": 5,
        "layout_type": "list",
        "is_collapsed": "true",
        "is_collapsable": "true"
      },
      "type": "multiple_union",
      "categories": [
        {
          "name": "Small",
          "id": "carCategory::small"
        },
        {
          "id": "carCategory::medium",
          "name": "Medium"
        }
      ],
      "id": "carCategory",
      "title": "Car Type"
    },
    {
      "id": "supplier",
      "categories": [
        {
          "id": "supplier::Alamo",
          "name": "Alamo"
        },
        {
          "name": "AUTO Prestige Czech",
          "id": "supplier::AUTO Prestige Czech"
        }
      ],
      "title": "Supplier",
      "layout": {
        "layout_type": "list",
        "collapsed_count": 5,
        "is_collapsable": "true",
        "is_collapsed": "true"
      },
      "type": "multiple_union"
    },
    {
      "layout": {
        "layout_type": "list",
        "collapsed_count": 5,
        "is_collapsed": "true",
        "is_collapsable": "true"
      },
      "type": "multiple_union",
      "title": "Transmission",
      "categories": [
        {
          "name": "Automatic",
          "id": "transmission::AUTOMATIC"
        },
        {
          "name": "Manual",
          "id": "transmission::MANUAL"
        }
      ],
      "id": "transmission"
    },
    {
      "layout": {
        "layout_type": "list"
      },
      "type": "single_option",
      "id": "hasAirConditioning",
      "categories": [
        {
          "name": "",
          "id": "hasAirConditioning::true"
        }
      ],
      "title": "Air Conditioning"
    },
    {
      "title": "Electric cars",
      "id": "fuelType",
      "categories": [
        {
          "id": "fuelType::Self-charging hybrid",
          "name": "Hybrid"
        }
      ],
      "type": "multiple_union",
      "layout": {
        "layout_type": "list"
      }
    }
  ],
  "is_genius_location": true,
  "meta": {
    "response_code": 200
  },
  "search_results": [
    {
      "freebies": [
        "Amendments"
      ],
      "content": {
        "supplier": {
          "name": "Rent Plus",
          "imageUrl": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png",
          "rating": {
            "average": "8.4",
            "title": "Very good",
            "subtitle": "9,291 reviews"
          }
        },
        "badges": [
          {
            "variation": "DEFAULT",
            "text": "Free cancellation",
            "type": "CONSTRUCTIVE"
          }
        ]
      },
      "applied_discount_types": [],
      "fee_info": {
        "fee": 0,
        "currency": "",
        "type": "",
        "tax": 0
      },
      "pricing_info": {
        "drive_away_price_before": null,
        "base_currency": "EUR",
        "discount": 0,
        "drive_away_price": 59.27,
        "currency": "CAD",
        "quote_allowed": 1,
        "price": 59.27,
        "fee_breakdown": {
          "fuel_policy": {
            "amount": 0,
            "currency": "",
            "type": "RETURN_SAME"
          }
          "known_fees": [
            {
              "is_tax_included": 1,
              "distance_allowed": null,
              "currency": "EUR",
              "min_amount": 925,
              "is_always_payable": 0,
              "amount": 925,
              "type": "THEFT_EXCESS",
              "max_amount": 925
            }
          ]
        },
        "base_price": 40.72,
        "deposit": 59.27,
        "base_deposit": 40.72,
        "drive_away_price_is_approx": true,
        "pay_when": "PAY_NOW"
      },
      "rating_info": {
        "efficiency": 7.7,
        "dropoff_time": 9.5,
        "value_for_money": 8.1,
        "average": 8.4,
        "condition": 8.7,
        "location": 8.5,
        "cleanliness": 8.5,
        "pickup_time": 8.1,
        "no_of_ratings": 9291,
        "average_text": "Excellent"
      },
      "supplier_info": {
        "pickup_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "dropoff_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "longitude": "14.267488",
        "location_type": "Car Rental Centre",
        "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
        "may_require_credit_card_guarantee": false,
        "logo_url": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png",
        "name": "Rent Plus",
        "latitude": "50.105336"
      },
      "vehicle_info": {
        "suitcases": {
          "big": "0",
          "small": "0"
        },
        "insurance_package": "",
        "seats": "5",
        "v_name": "Opel Corsa",
        "fuel_policy_description": "",
        "badges": {},
        "aircon": 1,
        "group": "Economy",
        "free_cancellation": 1,
        "special_offer_text": "Guaranteed 2023 registered car",
        "label": "Economy car with:",
        "image_thumbnail_url": "https://cdn.rcstatic.com/images/car_images/web/opel/corsa_4_doors_lrg.png",
        "v_id": "737302491",
        "cma_compliant": -1,
        "image_url": "https://cdn.rcstatic.com/images/car_images/web/opel/corsa_4_doors_lrg.png",
        "mileage": "Unlimited km",
        "unlimited_mileage": 1,
        "fuel_type": "N/A",
        "airbags": 1,
        "fuel_policy": "Like for like",
        "transmission": "Manual",
        "doors": "4"
      },
      "route_info": {
        "dropoff": {
          "country_code": "CZ",
          "location_id": "4123202",
          "icon": "",
          "name": "Prague Airport",
          "latitude": "50.105336",
          "country": "",
          "city": "",
          "location_type": "CAR_RENTAL_CENTRE",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "longitude": "14.267488"
        },
        "pickup": {
          "country": "",
          "icon": "",
          "latitude": "50.105336",
          "name": "Prague Airport",
          "location_id": "4123202",
          "country_code": "CZ",
          "longitude": "14.267488",
          "location_type": "CAR_RENTAL_CENTRE",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "city": ""
        }
      },
      "accessibility": {
        "supplier_rating": "At this location, our customers have rated Rent Plus as 8.4 out of 10, Very good.",
        "pick_up_location": "Pick-up information: Car Rental Centre",
        "fuel_policy": "Fuel policy is: Like for like",
        "transmission": "Manual gearbox"
      }
    },
    {
      "vehicle_info": {
        "unlimited_mileage": 1,
        "image_url": "https://cdn.rcstatic.com/images/car_images/web/volkswagen/polo_lrg.png",
        "mileage": "Unlimited km",
        "image_thumbnail_url": "https://cdn.rcstatic.com/images/car_images/web/volkswagen/polo_lrg.png",
        "v_id": "663316418",
        "cma_compliant": -1,
        "special_offer_text": "Guaranteed 2023 registered car",
        "label": "Economy car with:",
        "doors": "4",
        "fuel_policy": "Like for like",
        "transmission": "Automatic",
        "fuel_type": "N/A",
        "airbags": 1,
        "fuel_policy_description": "",
        "insurance_package": "",
        "seats": "5",
        "v_name": "Volkswagen Polo",
        "suitcases": {
          "big": "0",
          "small": "0"
        },
        "free_cancellation": 1,
        "group": "Economy",
        "badges": {},
        "aircon": 1
      },
      "route_info": {
        "dropoff": {
          "country": "",
          "icon": "",
          "name": "Prague Airport",
          "latitude": "50.105336",
          "country_code": "CZ",
          "location_id": "4123202",
          "longitude": "14.267488",
          "city": "",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "location_type": "CAR_RENTAL_CENTRE"
        },
        "pickup": {
          "longitude": "14.267488",
          "city": "",
          "location_type": "CAR_RENTAL_CENTRE",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "latitude": "50.105336",
          "icon": "",
          "name": "Prague Airport",
          "country_code": "CZ",
          "location_id": "4123202",
          "country": ""
        }
      },
      "accessibility": {
        "supplier_rating": "At this location, our customers have rated Rent Plus as 8.4 out of 10, Very good.",
        "pick_up_location": "Pick-up information: Car Rental Centre",
        "fuel_policy": "Fuel policy is: Like for like",
        "transmission": "Automatic gearbox"
      },
      "fee_info": {
        "fee": 0,
        "type": "",
        "currency": "",
        "tax": 0
      },
      "freebies": [
        "Amendments"
      ],
      "content": {
        "supplier": {
          "name": "Rent Plus",
          "rating": {
            "subtitle": "9,291 reviews",
            "title": "Very good",
            "average": "8.4"
          },
          "imageUrl": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png"
        },
        "badges": [
          {
            "text": "Free cancellation",
            "type": "CONSTRUCTIVE",
            "variation": "DEFAULT"
          }
        ]
      },
      "applied_discount_types": [],
      "rating_info": {
        "pickup_time": 8.1,
        "no_of_ratings": 9291,
        "average_text": "Excellent",
        "efficiency": 7.7,
        "dropoff_time": 9.5,
        "value_for_money": 8.1,
        "average": 8.4,
        "condition": 8.7,
        "cleanliness": 8.5,
        "location": 8.5
      },
      "supplier_info": {
        "longitude": "14.267488",
        "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
        "location_type": "Car Rental Centre",
        "pickup_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "dropoff_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "latitude": "50.105336",
        "name": "Rent Plus",
        "may_require_credit_card_guarantee": false,
        "logo_url": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png"
      },
      "pricing_info": {
        "drive_away_price_before": null,
        "base_currency": "EUR",
        "currency": "CAD",
        "discount": 0,
        "drive_away_price": 71.53,
        "fee_breakdown": {
          "known_fees": [
            {
              "type": "DEPOSIT",
              "max_amount": 925,
              "is_always_payable": 0,
              "is_tax_included": 1,
              "distance_allowed": null,
              "currency": "EUR",
              "min_amount": 925,
              "amount": 925
            },
            {
              "type": "DAMAGE_EXCESS",
              "max_amount": 925,
              "is_tax_included": 1,
              "distance_allowed": null,
              "currency": "EUR",
              "min_amount": 925,
              "is_always_payable": 0,
              "amount": 925
            },
              "is_tax_included": null,
              "currency": null,
              "min_amount": null
            }
          ]
          "fuel_policy": {
            "currency": "",
            "type": "RETURN_SAME",
            "amount": 0
          }
        },
        "base_price": 49.14,
        "quote_allowed": 1,
        "price": 71.53,
        "pay_when": "PAY_NOW",
        "base_deposit": 49.14,
        "deposit": 71.53,
        "drive_away_price_is_approx": true
      }
    },
    {
      "supplier_info": {
        "pickup_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "dropoff_instructions": "The office is in the 'Car Rental Centre', 400m from the terminal.",
        "longitude": "14.267488",
        "location_type": "Car Rental Centre",
        "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
        "may_require_credit_card_guarantee": false,
        "logo_url": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png",
        "name": "Rent Plus",
        "latitude": "50.105336"
      },
      "rating_info": {
        "dropoff_time": 9.5,
        "efficiency": 7.7,
        "condition": 8.7,
        "location": 8.5,
        "cleanliness": 8.5,
        "value_for_money": 8.1,
        "average": 8.4,
        "no_of_ratings": 9291,
        "pickup_time": 8.1,
        "average_text": "Excellent"
      },
      "pricing_info": {
        "pay_when": "PAY_NOW",
        "drive_away_price_is_approx": true,
        "deposit": 69.49,
        "base_deposit": 47.74,
        "base_price": 47.74,
        "fee_breakdown": {
          "fuel_policy": {
            "amount": 0,
            "currency": "",
            "type": "RETURN_SAME"
          }
          "known_fees": [
            {
              "is_always_payable": 0,
              "min_amount": 925,
              "is_tax_included": 1,
              "distance_allowed": null,
              "currency": "EUR",
              "amount": 925,
              "type": "DEPOSIT",
              "max_amount": 925
            },
            {
              "is_always_payable": 0,
              "is_tax_included": null,
              "currency": null,
              "distance_allowed": {
                "is_km": 1,
                "per_duration": null,
                "is_unlimited": 1,
                "value": null
              },
              "min_amount": null,
              "amount": null,
              "type": "MILEAGE",
              "max_amount": null
            }
          ]
        },
        "price": 69.49,
        "quote_allowed": 1,
        "currency": "CAD",
        "drive_away_price": 69.49,
        "discount": 0,
        "base_currency": "EUR",
        "drive_away_price_before": null
      },
      "fee_info": {
        "tax": 0,
        "fee": 0,
        "type": "",
        "currency": ""
      },
      "applied_discount_types": [],
      "freebies": [
        "Amendments"
      ],
      "content": {
        "badges": [
          {
            "text": "Free cancellation",
            "type": "CONSTRUCTIVE",
            "variation": "DEFAULT"
          }
        ],
        "supplier": {
          "name": "Rent Plus",
          "imageUrl": "https://cdn.rcstatic.com/sp/images/suppliers/1596_logo_200.png",
          "rating": {
            "subtitle": "9,291 reviews",
            "title": "Very good",
            "average": "8.4"
          }
        }
      },
      "accessibility": {
        "supplier_rating": "At this location, our customers have rated Rent Plus as 8.4 out of 10, Very good.",
        "pick_up_location": "Pick-up information: Car Rental Centre",
        "fuel_policy": "Fuel policy is: Like for like",
        "transmission": "Manual gearbox"
      },
      "route_info": {
        "pickup": {
          "longitude": "14.267488",
          "city": "",
          "location_type": "CAR_RENTAL_CENTRE",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "country": "",
          "name": "Prague Airport",
          "icon": "",
          "latitude": "50.105336",
          "country_code": "CZ",
          "location_id": "4123202"
        },
        "dropoff": {
          "country": "",
          "country_code": "CZ",
          "location_id": "4123202",
          "icon": "",
          "name": "Prague Airport",
          "latitude": "50.105336",
          "city": "",
          "location_type": "CAR_RENTAL_CENTRE",
          "address": "Parking building C, Aviatická 1082/10, 161 00, Praha 6, Prague, Czech Republic",
          "longitude": "14.267488"
        }
      },
      "vehicle_info": {
        "doors": "4",
        "fuel_policy": "Like for like",
        "transmission": "Manual",
        "fuel_type": "N/A",
        "airbags": 1,
        "unlimited_mileage": 1,
        "image_url": "https://cdn.rcstatic.com/images/car_images/web/volkswagen/golf_lrg.png",
        "mileage": "Unlimited km",
        "image_thumbnail_url": "https://cdn.rcstatic.com/images/car_images/web/volkswagen/golf_lrg.png",
        "v_id": "737302616",
        "cma_compliant": -1,
        "special_offer_text": "Guaranteed 2023 registered car",
        "label": "Compact car with:",
        "free_cancellation": 1,
        "group": "Compact",
        "badges": {},
        "aircon": 1,
        "fuel_policy_description": "",
        "seats": "5",
        "insurance_package": "",
        "v_name": "Volkswagen Golf",
        "suitcases": {
          "small": "0",
          "big": "0"
        }
      }
    }
  }
```
To model:
```bash
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Accessibility
    {
        public string SupplierRating { get; set; }
        public string PickUpLocation { get; set; }
        public string FuelPolicy { get; set; }
        public string Transmission { get; set; }
    }

    public class Badge
    {
        public string Variation { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Content
    {
        public Supplier Supplier { get; set; }
        public List<Badge> Badges { get; set; }
    }

    public class DistanceAllowed
    {
        public int IsKm { get; set; }
        public object PerDuration { get; set; }
        public int IsUnlimited { get; set; }
        public object Value { get; set; }
    }

    public class Dropoff
    {
        public string CountryCode { get; set; }
        public string LocationId { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string LocationType { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
    }

    public class FeeBreakdown
    {
        public FuelPolicy FuelPolicy { get; set; }
        public List<KnownFee> KnownFees { get; set; }
    }

    public class FeeInfo
    {
        public int Fee { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }
        public int Tax { get; set; }
    }

    public class Filter
    {
        public Layout Layout { get; set; }
        public string Type { get; set; }
        public List<Category> Categories { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class FuelPolicy
    {
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }
    }

    public class KnownFee
    {
        public int? IsTaxIncluded { get; set; }
        public DistanceAllowed DistanceAllowed { get; set; }
        public string Currency { get; set; }
        public int? MinAmount { get; set; }
        public int IsAlwaysPayable { get; set; }
        public int? Amount { get; set; }
        public string Type { get; set; }
        public int? MaxAmount { get; set; }
    }

    public class Layout
    {
        public int CollapsedCount { get; set; }
        public string LayoutType { get; set; }
        public string IsCollapsed { get; set; }
        public string IsCollapsable { get; set; }
    }

    public class Meta
    {
        public int ResponseCode { get; set; }
    }

    public class Pickup
    {
        public string Country { get; set; }
        public string Icon { get; set; }
        public string Latitude { get; set; }
        public string Name { get; set; }
        public string LocationId { get; set; }
        public string CountryCode { get; set; }
        public string Longitude { get; set; }
        public string LocationType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }

    public class PricingInfo
    {
        public object DriveAwayPriceBefore { get; set; }
        public string BaseCurrency { get; set; }
        public int Discount { get; set; }
        public double DriveAwayPrice { get; set; }
        public string Currency { get; set; }
        public int QuoteAllowed { get; set; }
        public double Price { get; set; }
        public FeeBreakdown FeeBreakdown { get; set; }
        public double BasePrice { get; set; }
        public double Deposit { get; set; }
        public double BaseDeposit { get; set; }
        public bool DriveAwayPriceIsApprox { get; set; }
        public string PayWhen { get; set; }
    }

    public class Rating
    {
        public string Average { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }

    public class RatingInfo
    {
        public double Efficiency { get; set; }
        public double DropoffTime { get; set; }
        public double ValueForMoney { get; set; }
        public double Average { get; set; }
        public double Condition { get; set; }
        public double Location { get; set; }
        public double Cleanliness { get; set; }
        public double PickupTime { get; set; }
        public int NoOfRatings { get; set; }
        public string AverageText { get; set; }
    }

    public class Root
    {
        public string SearchKey { get; set; }
        public List<Sort> Sort { get; set; }
        public int Count { get; set; }
        public List<Filter> Filter { get; set; }
        public bool IsGeniusLocation { get; set; }
        public Meta Meta { get; set; }
        public List<SearchResult> SearchResults { get; set; }
    }

    public class RouteInfo
    {
        public Dropoff Dropoff { get; set; }
        public Pickup Pickup { get; set; }
    }

    public class SearchResult
    {
        public List<string> Freebies { get; set; }
        public Content Content { get; set; }
        public List<object> AppliedDiscountTypes { get; set; }
        public FeeInfo FeeInfo { get; set; }
        public PricingInfo PricingInfo { get; set; }
        public RatingInfo RatingInfo { get; set; }
        public SupplierInfo SupplierInfo { get; set; }
        public VehicleInfo VehicleInfo { get; set; }
        public RouteInfo RouteInfo { get; set; }
        public Accessibility Accessibility { get; set; }
    }

    public class Sort
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string TitleTag { get; set; }
    }

    public class Suitcases
    {
        public string Big { get; set; }
        public string Small { get; set; }
    }

    public class Supplier
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Rating Rating { get; set; }
    }

    public class SupplierInfo
    {
        public string PickupInstructions { get; set; }
        public string DropoffInstructions { get; set; }
        public string Longitude { get; set; }
        public string LocationType { get; set; }
        public string Address { get; set; }
        public bool MayRequireCreditCardGuarantee { get; set; }
        public string LogoUrl { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
    }

    public class VehicleInfo
    {
        public Suitcases Suitcases { get; set; }
        public string InsurancePackage { get; set; }
        public string Seats { get; set; }
        public string VName { get; set; }
        public string FuelPolicyDescription { get; set; }
        public Badges Badges { get; set; }
        public int Aircon { get; set; }
        public string Group { get; set; }
        public int FreeCancellation { get; set; }
        public string SpecialOfferText { get; set; }
        public string Label { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public string VId { get; set; }
        public int CmaCompliant { get; set; }
        public string ImageUrl { get; set; }
        public string Mileage { get; set; }
        public int UnlimitedMileage { get; set; }
        public string FuelType { get; set; }
        public int Airbags { get; set; }
        public string FuelPolicy { get; set; }
        public string Transmission { get; set; }
        public string Doors { get; set; }
    }

```


## ATTRACTIONS
### Travel Advisor
https://rapidapi.com/apidojo/api/travel-advisor/

"GET/locations/v2/auto-complete"

REQUIRED: name of city

Return example:
```bash
{
  "data": {
    "Typeahead_autocomplete": {
      "__typename": "Typeahead_Response",
      "resultsId": "6c789ff7-4af7-4343-9ee1-28e774c31317_bc3e6e12-b7f0-448a-8dd8-209c21223668",
      "results": [
        {
          "__typename": "Typeahead_LocationItem",
          "documentId": "188151",
          "detailsV2": {
            "__typename": "LocationSelection_LocationInformationV2",
            "locationId": 188151,
            "isGeo": false,
            "placeType": "ATTRACTION",
            "names": {
              "__typename": "LocationSelection_LocationNames",
              "name": "Eiffel Tower",
              "longOnlyHierarchyTypeaheadV2": "Paris, Ile-de-France, France"
            },
            "geocode": {
              "__typename": "LocationSelection_LocationInformationV2Geocode",
              "latitude": 48.858353,
              "longitude": 2.294464
            },
            "contact": {
              "__typename": "LocationSelection_LocationInformationV2Contact",
              "streetAddress": {
                "__typename": "LocationSelection_Address",
                "street1": "5 Avenue Anatole France"
              }
            },
            "route": null
          },
          "details": {
            "__typename": "LocationInformation",
            "socialStatistics": {
              "__typename": "SocialStatistics",
              "isSaved": false
            }
          },
          "image": {
            "__typename": "PrimaryMedia_PrimaryMedia",
            "photo": {
              "__typename": "Photo",
              "photoSizeDynamic": {
                "__typename": "PhotoSizeDynamic",
                "maxHeight": 1744,
                "maxWidth": 1172,
                "urlTemplate": "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/9e/7f/9d/eiffeltoren.jpg?w={width}&h={height}&s=1"
              },
              "photoSizes": [
                {
                  "__typename": "PhotoSize",
                  "height": 0,
                  "width": 0,
                  "url": "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/9e/7f/9d/eiffeltoren.jpg?w=100&h=100&s=1"
                },
                {
                  "__typename": "PhotoSize",
                  "height": 50,
                  "width": 50,
                  "url": "https://media-cdn.tripadvisor.com/media/photo-t/1a/9e/7f/9d/eiffeltoren.jpg"
                }
              ]
            }
          }
        }
      ]
    }
  }
}
```

## RESTAURANTS
### Tripadvisor
https://rapidapi.com/DataCrawler/api/tripadvisor16

"GET/Search Restaurant Location"

REQUIRED DB INFO: locationID or name of location

Return example:

```bash
{
  "status": true,
  "message": "Success",
  "timestamp": 1664130190825,
  "data": [
    {
      "documentId": "304554",
      "locationId": 304554,
      "localizedName": "Mumbai",
      "localizedAdditionalNames": {
        "longOnlyHierarchy": "Maharashtra, India, Asia"
      },
      "streetAddress": {
        "street1": ""
      },
      "locationV2": {
        "placeType": "CITY",
        "names": {
          "longOnlyHierarchyTypeaheadV2": "Maharashtra, India"
        },
        "vacationRentalsRoute": {
          "url": "/VacationRentals-g304554-Reviews-Mumbai_Maharashtra-Vacation_Rentals.html"
        }
      },
      "placeType": "CITY",
      "latitude": 18.936844,
      "longitude": 72.8291,
      "isGeo": true,
      "thumbnail": {
        "photoSizeDynamic": {
          "maxWidth": 5328,
          "maxHeight": 3000,
          "urlTemplate": "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0b/4e/55/e6/chhatrapati-shivaji-terminus.jpg?w={width}&h={height}&s=1"
        }
      }
    }
}
```

As model:
```bash
public class Datum
    {
        public string DocumentId { get; set; }
        public int LocationId { get; set; }
        public string LocalizedName { get; set; }
        public LocalizedAdditionalNames LocalizedAdditionalNames { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public LocationV2 LocationV2 { get; set; }
        public string PlaceType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsGeo { get; set; }
        public Thumbnail Thumbnail { get; set; }
    }

    public class LocalizedAdditionalNames
    {
        public string LongOnlyHierarchy { get; set; }
    }

    public class LocationV2
    {
        public string PlaceType { get; set; }
        public Names Names { get; set; }
        public VacationRentalsRoute VacationRentalsRoute { get; set; }
    }

    public class Names
    {
        public string LongOnlyHierarchyTypeaheadV2 { get; set; }
    }

    public class PhotoSizeDynamic
    {
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public string UrlTemplate { get; set; }
    }

    public class Root
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public long Timestamp { get; set; }
        public List<Datum> Data { get; set; }
    }

    public class StreetAddress
    {
        public string Street1 { get; set; }
    }

    public class Thumbnail
    {
        public PhotoSizeDynamic PhotoSizeDynamic { get; set; }
    }

    public class VacationRentalsRoute
    {
        public string Url { get; set; }
    }
```