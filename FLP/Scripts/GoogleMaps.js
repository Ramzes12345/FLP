$(document).ready(function () { 
    Initialize(); 
}); 
 
// Where all the fun happens 
function Initialize() { 
 
    // Google has tweaked their interface somewhat - this tells the api to use that new UI 
    google.maps.visualRefresh = true; 
    var Tunisie = new google.maps.LatLng(48.461067, 35.035215);
 
    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show 
    var mapOptions = { 
        zoom: 15, 
        center: Tunisie, 
        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP 
    }; 
 
    // This makes the div with id "map_canvas" a google map 
    var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions); 
 
    // a sample list of JSON encoded data of places to visit in Tunisia 
    // you can either make up a JSON list server side, or call it from a controller using JSONResult 
    var data = [ 
              { "Id": 1, "PlaceName": "ул. Воскресенская (Ленина) 41", "GeoLong": "48.461067", "GeoLat": "35.035215" }
    ]; 
 
    // Using the JQuery "each" selector to iterate through the JSON list and drop marker pins 
    $.each(data, function (i, item) { 
        var marker = new google.maps.Marker({ 
            'position': new google.maps.LatLng(item.GeoLong, item.GeoLat), 
            'map': map, 
            'title': item.PlaceName 
        }); 
 
        // Make the marker-pin blue! 
        marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png') 
 
        // put in some information about each json object - in this case, the opening hours. 
        var infowindow = new google.maps.InfoWindow({ 
            content: "<div class='infoDiv'><h2>" + item.PlaceName + "</div></div>" 
        }); 
 
        // finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked! 
        google.maps.event.addListener(marker, 'click', function () { 
            infowindow.open(map, marker); 
        }); 
 
    })
} 
 
 
