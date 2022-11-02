function initialize() {
    var mapOptions = {
        zoom: 16,
        scrollwheel: false,
        center: new google.maps.LatLng(32.8145185,-96.6353685)
    };
    var map = new google.maps.Map(document.getElementById('googleMap'),
          mapOptions);
    var marker = new google.maps.Marker({
        icon: 'images/map-marker.png',
        position: map.getCenter(),
        map: map
    });
    var styles = [
    {
        "featureType": "landscape",
        "elementType": "labels",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "transit",
        "elementType": "labels",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "poi",
        "elementType": "labels",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "water",
        "elementType": "labels",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "road",
        "elementType": "labels.icon",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "stylers": [
            {
                "hue": "#bf0d3e"
            },
            {
                "saturation": 1
            },
            {
                "gamma": 2.15
            },
            {
                "lightness": 7
            }
        ]
    },
    {
        "featureType": "road",
        "elementType": "labels.text.fill",
        "stylers": [
            {
                "visibility": "on"
            },
            {
                "lightness": 14
            }
        ]
    },
    {
        "featureType": "road",
        "elementType": "geometry",
        "stylers": [
            {
                "lightness": 37
            }
        ]
    }
]

    map.setOptions({styles: styles});
}
google.maps.event.addDomListener(window, 'load', initialize);	
