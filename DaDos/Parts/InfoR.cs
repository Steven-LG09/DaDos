using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace DaDos.Parts
{
    public partial class InfoR : Form
    {
        private Class9 class9;
        public InfoR(Class9 data)
        {
            InitializeComponent();
            class9 = data;

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.None;
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
            gMapControl1.Position = new PointLatLng(4.833412, -75.659733);
            gMapControl1.MaxZoom = 30;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 15;

            List<PointLatLng> points = new List<PointLatLng>
            {
                new PointLatLng(4.833710, -75.660118),
                new PointLatLng(4.833325, -75.659630),
                new PointLatLng(4.833282, -75.659370),
                new PointLatLng(4.833334, -75.658636),
                new PointLatLng(4.833408, -75.657860),
                new PointLatLng(4.834146, -75.656835),
                new PointLatLng(4.834202, -75.656918),
                new PointLatLng(4.834098, -75.657270),
                new PointLatLng(4.834111, -75.657602),
                new PointLatLng(4.833817, -75.657986),
                new PointLatLng(4.833774, -75.658200),
                new PointLatLng(4.833740, -75.658699),
                new PointLatLng(4.833638, -75.658927),
                new PointLatLng(4.834608, -75.660107),
                new PointLatLng(4.834098, -75.660558),
                new PointLatLng(4.833710, -75.660118),
            };

            GMapRoute gMapRoute = new GMapRoute(points, "Route 1");
            GMapOverlay routesOverlay = new GMapOverlay("Routes");
            routesOverlay.Routes.Add(gMapRoute);
            gMapControl1.Overlays.Add(routesOverlay);

            gMapControl1.ZoomAndCenterRoutes("Routes");


            ruta.Text = class9.Label1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            List<PointLatLng> points = new List<PointLatLng>
            {
                new PointLatLng(4.833710, -75.660118),
                new PointLatLng(4.833325, -75.659630),
                new PointLatLng(4.833282, -75.659370),
                new PointLatLng(4.833334, -75.658636),
                new PointLatLng(4.833408, -75.657860),
                new PointLatLng(4.834146, -75.656835),
                new PointLatLng(4.834202, -75.656918),
                new PointLatLng(4.834098, -75.657270),
                new PointLatLng(4.834111, -75.657602),
                new PointLatLng(4.833817, -75.657986),
                new PointLatLng(4.833774, -75.658200),
                new PointLatLng(4.833740, -75.658699),
                new PointLatLng(4.833638, -75.658927),
                new PointLatLng(4.834608, -75.660107),
                new PointLatLng(4.834098, -75.660558),
                new PointLatLng(4.833710, -75.660118),
            };

            foreach ( PointLatLng position in points)
            {
                GMarkerGoogle marker = new GMarkerGoogle(position, GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                marker.IsVisible = true;
                await Task.Delay(2000);
                marker.IsVisible = false;

                gMapControl1.Overlays.Add(markersOverlay);
            }
        }
    }
}
