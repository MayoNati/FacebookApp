using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MapServices
{
    public class MapControl
    {
        GMapControl m_mapControl;
        string MapStartPlace { get; set; } = "Israel";
        int MinZoom { get; set; } = 5;
        int MaxZoom { get; set; } = 100;
        int Zoom { get; set; } = 10;

        List<string> lngAndLat = null;
        public MapControl()
        {
            m_mapControl = new GMapControl();
            initMap();
        }

        private void initMap()
        {
            m_mapControl.DragButton = MouseButtons.Left;
            m_mapControl.MapProvider = GMapProviders.GoogleMap;
            m_mapControl.SetPositionByKeywords(MapStartPlace);
            m_mapControl.MinZoom = 5;
            m_mapControl.MaxZoom = 100;
            m_mapControl.Zoom = 10;
        }

        public GMapControl GetMap()
        {
            return m_mapControl;
        }

        public GMapControl AddPointOnMap(double i_latitude, double i_longitude)
        {
            if (lngAndLat == null)
            {
                lngAndLat = new List<string>();
            }
            m_mapControl.Position = new GMap.NET.PointLatLng(i_latitude, i_longitude);
            PointLatLng point = new PointLatLng(i_latitude, i_longitude);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            m_mapControl.Overlays.Add(markers);

            lngAndLat.Add(string.Format("Lat]{0},Lng={1}", i_latitude, i_longitude));
            return m_mapControl;
        }

        public GMapControl GetMapByAddress(string address)
        {
            m_mapControl.SetPositionByKeywords(address);
            return m_mapControl;
        }

        public GMapControl RemovePoints()
        {
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Clear();
            m_mapControl.Overlays.Remove(markers);
            return m_mapControl;
        }

    }
}
