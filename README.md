# API Endpoints:

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