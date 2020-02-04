using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] modes = { "Cylinder", "Pyramid", "Cone", "Prism", "Sphere", "Conical frustum", "Pyramidal frustum" };
        int mode = 1;
        List<string> Results = new List<string>();
        private void CylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            currentMode.Text = modes[0];
            r_input.Visible = true;
            radius.Visible = true;
            rcm.Visible = true;
            r_input.ReadOnly = false;
            radius.ForeColor = Color.FromArgb(0, 255, 0);
            alt_input.Visible = true;
            altitude.Visible = true;
            altcm.Visible = true;
            alt_input.ReadOnly = false;
            altitude.ForeColor = Color.FromArgb(0, 255, 0);
            base_input.Visible = false;
            baseT.Visible = false;
            bcm.Visible = false;
            side_input.Visible = false;
            side.Visible = false;
            scm.Visible = false;
            topArea_input.Visible = false;
            topArea.Visible = false;
            tacm.Visible = false;
            topBase_input.Visible = false;
            topBase.Visible = false;
            tbcm.Visible = false;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = false;
            baseArea.ForeColor = Color.FromArgb(0, 255, 0);
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = true;
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            a_input.Visible = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            a_input.ReadOnly = true;
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            p_input.Visible = false;
            polygon.Visible = false;
            rcm.ForeColor = Color.FromArgb(0, 255, 0);
            altcm.ForeColor = Color.FromArgb(0, 255, 0);
            bacm.ForeColor = Color.FromArgb(0, 255, 0);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void PyramidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;
            currentMode.Text = modes[1];
            r_input.Visible = false;
            radius.Visible = false;
            rcm.Visible = false;
            r_input.ReadOnly = true;
            alt_input.Visible = true;
            altitude.Visible = true;
            alt_input.ReadOnly = true;
            altcm.Visible = true;
            base_input.Visible = true;
            base_input.ReadOnly = false;
            baseT.Visible = true;
            bcm.Visible = true;
            side_input.Visible = true;
            side_input.ReadOnly = false;
            side.Visible = true;
            scm.Visible = true;
            topArea_input.Visible = false;
            topArea_input.ReadOnly = true;
            topArea.Visible = false;
            tacm.Visible = false;
            topBase_input.Visible = false;
            topBase_input.ReadOnly = true;
            topBase.Visible = false;
            tbcm.Visible = false;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = true;
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = true;
            a_input.Visible = true;
            a_input.ReadOnly = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            p_input.Visible = true;
            polygon.Visible = true;
            //colors for the texts
            altitude.ForeColor = Color.FromArgb(255, 255, 255);
            altcm.ForeColor = Color.FromArgb(255, 255, 255);
            polygon.ForeColor = Color.FromArgb(0, 255, 0);
            baseT.ForeColor = Color.FromArgb(0, 255, 0);
            bcm.ForeColor = Color.FromArgb(0, 255, 0);
            side.ForeColor = Color.FromArgb(0, 255, 0);
            scm.ForeColor = Color.FromArgb(0, 255, 0);
            baseArea.ForeColor = Color.FromArgb(255, 255, 255);
            bacm.ForeColor = Color.FromArgb(255, 255, 255);
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ConeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 3;
            currentMode.Text = modes[2];
            r_input.Visible = true;
            radius.Visible = true;
            rcm.Visible = true;
            r_input.ReadOnly = false;
            alt_input.Visible = true;
            altitude.Visible = true;
            alt_input.ReadOnly = false;
            altcm.Visible = true;
            base_input.Visible = false;
            base_input.ReadOnly = true;
            baseT.Visible = false;
            bcm.Visible = false;
            side_input.Visible = true;
            side_input.ReadOnly = false;
            side.Visible = true;
            scm.Visible = true;
            topArea_input.Visible = false;
            topArea_input.ReadOnly = true;
            topArea.Visible = false;
            tacm.Visible = false;
            topBase_input.Visible = false;
            topBase_input.ReadOnly = true;
            topBase.Visible = false;
            tbcm.Visible = false;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = true;
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            a_input.Visible = true;
            a_input.ReadOnly = false;
            surf_area.Visible = true;
            sacm.Visible = true;
            p_input.Visible = false;
            polygon.Visible = false;
            radius.ForeColor = Color.FromArgb(0, 255, 0);
            rcm.ForeColor = Color.FromArgb(0, 255, 0);
            altitude.ForeColor = Color.FromArgb(0, 255, 0);
            altcm.ForeColor = Color.FromArgb(0, 255, 0);
            side.ForeColor = Color.FromArgb(0, 255, 0);
            scm.ForeColor = Color.FromArgb(0, 255, 0);
            baseArea.ForeColor = Color.FromArgb(255, 255, 255);
            bacm.ForeColor = Color.FromArgb(255, 255, 255);
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void PrismToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 4;
            currentMode.Text = modes[3];
            r_input.Visible = false;
            radius.Visible = false;
            rcm.Visible = false;
            r_input.ReadOnly = false;
            alt_input.Visible = true;
            altitude.Visible = true;
            alt_input.ReadOnly = false;
            altcm.Visible = true;
            base_input.Visible = true;
            base_input.ReadOnly = false;
            baseT.Visible = true;
            bcm.Visible = true;
            side_input.Visible = false;
            side_input.ReadOnly = true;
            side.Visible = false;
            scm.Visible = false;
            topArea_input.Visible = false;
            topArea_input.ReadOnly = true;
            topArea.Visible = false;
            tacm.Visible = false;
            topBase_input.Visible = false;
            topBase_input.ReadOnly = true;
            topBase.Visible = false;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = true;
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = true;
            a_input.Visible = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            a_input.ReadOnly = true;
            p_input.Visible = true;
            polygon.Visible = true;
            altitude.ForeColor = Color.FromArgb(0, 255, 0);
            altcm.ForeColor = Color.FromArgb(0, 255, 0);
            polygon.ForeColor = Color.FromArgb(0, 255, 0);
            baseT.ForeColor = Color.FromArgb(0, 255, 0);
            bcm.ForeColor = Color.FromArgb(0, 255, 0);
            side.ForeColor = Color.FromArgb(64, 64, 64);
            scm.ForeColor = Color.FromArgb(64, 64, 64);
            topArea.ForeColor = Color.FromArgb(64, 64, 64);
            tacm.ForeColor = Color.FromArgb(64, 64, 64);
            topBase.ForeColor = Color.FromArgb(64, 64, 64);
            tbcm.ForeColor = Color.FromArgb(64, 64, 64);
            baseArea.ForeColor = Color.FromArgb(255, 255, 255);
            bacm.ForeColor = Color.FromArgb(255, 255, 255);
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void SphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 5;
            currentMode.Text = modes[4];
            r_input.Visible = true;
            radius.Visible = true;
            rcm.Visible = true;
            r_input.ReadOnly = false;
            alt_input.Visible = false;
            altitude.Visible = false;
            alt_input.ReadOnly = false;
            altcm.Visible = false;
            base_input.Visible = false;
            base_input.ReadOnly = false;
            baseT.Visible = false;
            bcm.Visible = false;
            side_input.Visible = false;
            side_input.ReadOnly = false;
            side.Visible = false;
            scm.Visible = false;
            topArea_input.Visible = false;
            topArea_input.ReadOnly = false;
            topArea.Visible = false;
            tacm.Visible = false;
            topBase_input.Visible = false;
            topBase_input.ReadOnly = false;
            topBase.Visible = false;
            tbcm.Visible = false;
            baseArea_input.Visible = false;
            baseArea.Visible = false;
            bacm.Visible = false;
            baseArea_input.ReadOnly = false;
            lsf_input.Visible = false;
            lat_surf.Visible = false;
            lscm.Visible = false;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = false;
            a_input.Visible = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            a_input.ReadOnly = false;
            p_input.Visible = false;
            polygon.Visible = false;
            radius.ForeColor = Color.FromArgb(0, 255, 0);
            rcm.ForeColor = Color.FromArgb(0, 255, 0);
            altitude.ForeColor = Color.FromArgb(64, 64, 64);
            altcm.ForeColor = Color.FromArgb(64, 64, 64);
            polygon.ForeColor = Color.FromArgb(64, 64, 64);
            baseT.ForeColor = Color.FromArgb(64, 64, 64);
            bcm.ForeColor = Color.FromArgb(64, 64, 64);
            side.ForeColor = Color.FromArgb(64, 64, 64);
            scm.ForeColor = Color.FromArgb(64, 64, 64);
            topArea.ForeColor = Color.FromArgb(64, 64, 64);
            tacm.ForeColor = Color.FromArgb(64, 64, 64);
            topBase.ForeColor = Color.FromArgb(64, 64, 64);
            tbcm.ForeColor = Color.FromArgb(64, 64, 64);
            baseArea.ForeColor = Color.FromArgb(64, 64, 64);
            bacm.ForeColor = Color.FromArgb(64, 64, 64);
            lat_surf.ForeColor = Color.FromArgb(64, 64, 64);
            lscm.ForeColor = Color.FromArgb(64, 64, 64);
            volume.ForeColor = Color.FromArgb(0, 255, 0);
            vcm.ForeColor = Color.FromArgb(0, 255, 0);
            surf_area.ForeColor = Color.FromArgb(0, 255, 0);
            sacm.ForeColor = Color.FromArgb(0, 255, 0);
        }

        private void PyramidalFrustumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 7;
            currentMode.Text = modes[6];
            r_input.Visible = false;
            radius.Visible = false;
            rcm.Visible = false;
            r_input.ReadOnly = true;
            alt_input.Visible = true;
            altitude.Visible = true;
            alt_input.ReadOnly = false;
            altcm.Visible = true;
            base_input.Visible = true;
            base_input.ReadOnly = false;
            baseT.Visible = true;
            bcm.Visible = true;
            side_input.Visible = true;
            side_input.ReadOnly = false;
            side.Visible = true;
            scm.Visible = true;
            topArea_input.Visible = true;
            topArea_input.ReadOnly = true;
            topArea.Visible = true;
            tacm.Visible = true;
            topBase_input.Visible = true;
            topBase_input.ReadOnly = false;
            topBase.Visible = true;
            tbcm.Visible = true;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = true;
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = true;
            a_input.Visible = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            a_input.ReadOnly = true;
            p_input.Visible = false;
            polygon.Visible = false;
            altitude.ForeColor = Color.FromArgb(0, 255, 0);
            altcm.ForeColor = Color.FromArgb(0, 255, 0);
            baseT.ForeColor = Color.FromArgb(0, 255, 0);
            bcm.ForeColor = Color.FromArgb(0, 255, 0);
            side.ForeColor = Color.FromArgb(0, 255, 0);
            scm.ForeColor = Color.FromArgb(0, 255, 0);
            topArea.ForeColor = Color.FromArgb(255, 255, 255);
            tacm.ForeColor = Color.FromArgb(255, 255, 255);
            topBase.ForeColor = Color.FromArgb(0, 255, 0);
            tbcm.ForeColor = Color.FromArgb(0, 255, 0);
            baseArea.ForeColor = Color.FromArgb(255, 255, 255);
            bacm.ForeColor = Color.FromArgb(255, 255, 255);
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ConicalFrustumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 6;
            currentMode.Text = modes[5];
            r_input.Visible = false;
            radius.Visible = false;
            rcm.Visible = false;
            r_input.ReadOnly = true;
            alt_input.Visible = true;
            altitude.Visible = true;
            alt_input.ReadOnly = false;
            altcm.Visible = true;
            base_input.Visible = true;
            base_input.ReadOnly = false;
            baseT.Visible = true;
            bcm.Visible = true;
            side_input.Visible = true;
            side_input.ReadOnly = false;
            side.Visible = true;
            scm.Visible = true;
            topArea_input.Visible = true;
            topArea_input.ReadOnly = true;
            topArea.Visible = true;
            tacm.Visible = true;
            topBase_input.Visible = true;
            topBase_input.ReadOnly = false;
            topBase.Visible = true;
            tbcm.Visible = true;
            baseArea_input.Visible = true;
            baseArea.Visible = true;
            bacm.Visible = true;
            baseArea_input.ReadOnly = true;
            lsf_input.Visible = true;
            lat_surf.Visible = true;
            lscm.Visible = true;
            lsf_input.ReadOnly = true;
            v_input.Visible = true;
            volume.Visible = true;
            vcm.Visible = true;
            v_input.ReadOnly = true;
            a_input.Visible = true;
            surf_area.Visible = true;
            sacm.Visible = true;
            a_input.ReadOnly = true;
            p_input.Visible = false;
            polygon.Visible = false;
            altitude.ForeColor = Color.FromArgb(0, 255, 0);
            altcm.ForeColor = Color.FromArgb(0, 255, 0);
            baseT.ForeColor = Color.FromArgb(0, 255, 0);
            bcm.ForeColor = Color.FromArgb(0, 255, 0);
            side.ForeColor = Color.FromArgb(0, 255, 0);
            scm.ForeColor = Color.FromArgb(0, 255, 0);
            topArea.ForeColor = Color.FromArgb(255, 255, 255);
            tacm.ForeColor = Color.FromArgb(255, 255, 255);
            topBase.ForeColor = Color.FromArgb(0, 255, 0);
            tbcm.ForeColor = Color.FromArgb(0, 255, 0);
            baseArea.ForeColor = Color.FromArgb(255, 255, 255);
            bacm.ForeColor = Color.FromArgb(255, 255, 255);
            lat_surf.ForeColor = Color.FromArgb(255, 255, 255);
            lscm.ForeColor = Color.FromArgb(255, 255, 255);
            volume.ForeColor = Color.FromArgb(255, 255, 255);
            vcm.ForeColor = Color.FromArgb(255, 255, 255);
            surf_area.ForeColor = Color.FromArgb(255, 255, 255);
            sacm.ForeColor = Color.FromArgb(255, 255, 255);
        }
        public void Button2_Click(object sender, EventArgs e) // Calculate it button
        {
            switch (mode)
            {
                case 1:
                    Cylinder(); calcHist.Lines = Results.ToArray();
                    break;
                case 2:
                    Pyramid(); calcHist.Lines = Results.ToArray();
                    break;
                case 3:
                    Cone(); calcHist.Lines = Results.ToArray();
                    break;
                case 4:
                    Prism(); calcHist.Lines = Results.ToArray();
                    break;
                case 5:
                    Sphere(); calcHist.Lines = Results.ToArray();
                    break;
                case 6:
                    CFrustum(); calcHist.Lines = Results.ToArray();
                    break;
                case 7:
                    PFrustum(); calcHist.Lines = Results.ToArray();
                    break;
                default: break;

            }
        }
        public void Cylinder()
        {
            double surfaceArea = 0, lateralSurface = 0, radius = 0, altitude = 0, baseArea = 0, volume = 0;
            if (r_input.Text != "" && alt_input.Text != "")
            {
                radius = double.Parse(r_input.Text);
                altitude = double.Parse(alt_input.Text);
                surfaceArea = Math.Round(2 * Math.PI * radius * (radius + altitude), 2);
                lateralSurface = Math.Round(2 * Math.PI * radius * altitude, 2);
                baseArea = Math.Round(2 * Math.PI * Math.Pow(radius, 2), 2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude, 2);
                a_input.Text = Convert.ToString(surfaceArea);
                lsf_input.Text = Convert.ToString(lateralSurface);
                baseArea_input.Text = Convert.ToString(baseArea);
                v_input.Text = Convert.ToString(volume);
            }
            else if (alt_input.Text != "" && lsf_input.Text != "")
            {
                lateralSurface = double.Parse(lsf_input.Text);
                altitude = double.Parse(alt_input.Text);
                radius = lateralSurface / (2 * Math.PI * altitude);
                baseArea = Math.Round(2 * Math.PI * Math.Pow(radius, 2), 2);
                surfaceArea = Math.Round(2 * Math.PI * radius * (radius + altitude), 2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude, 2);
                a_input.Text = Convert.ToString(surfaceArea);
                r_input.Text = Convert.ToString(Math.Round(radius, 2));
                baseArea_input.Text = Convert.ToString(baseArea);
                v_input.Text = Convert.ToString(volume);
            }
            else if (r_input.Text != "" && lsf_input.Text != "")
            {
                lateralSurface = double.Parse(lsf_input.Text);
                radius = double.Parse(r_input.Text);
                altitude = lateralSurface / (2 * Math.PI * radius);
                baseArea = Math.Round(2 * Math.PI * Math.Pow(radius, 2), 2);
                surfaceArea = Math.Round(2 * Math.PI * radius * (radius + altitude), 2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude, 2);
                a_input.Text = Convert.ToString(surfaceArea);
                alt_input.Text = Convert.ToString(Math.Round(altitude, 2));
                baseArea_input.Text = Convert.ToString(baseArea);
                v_input.Text = Convert.ToString(volume);
            }
            if ((r_input.Text != "" && alt_input.Text != "") || alt_input.Text != "" && lsf_input.Text != "" || r_input.Text != "" && lsf_input.Text != "")
            {
                Results.Add("---Cylinder---");
                Results.Add("Radius: " + radius + " cm");
                Results.Add("Length of altitude: " + altitude + " cm");
                Results.Add("Area of the base: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Area of lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surfaceArea + " cm²");
            }
        }
        public double DegreeToRadian(double angle)
        {
            return (angle / 180)*Math.PI;
        }
        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        public void Pyramid()
        {
            if (p_input.Text != "" && base_input.Text != "" && side_input.Text != "") // we need the length of side, the number of sides,the length side of the pyramid
            {
                double polygon = double.Parse(p_input.Text);
                double baseLength = double.Parse(base_input.Text);
                double sideLength = double.Parse(side_input.Text);
                double baseheight = polygon / Math.Tan(DegreeToRadian(360/polygon)/2);
                double thirdside = Math.Sqrt(Math.Pow(baseLength/2, 2) + Math.Pow(baseheight, 2));
                double altitude = Math.Round(polygon ==3||polygon==6?Math.Sqrt(Math.Pow(sideLength, 2) - Math.Pow(baseLength, 2)):Math.Sqrt(Math.Pow(sideLength, 2)-Math.Pow(thirdside,2)),2);
                double baseArea = Math.Round((Math.Pow(baseLength, 2) * polygon) / (4 * Math.Tan(DegreeToRadian(180 / polygon))),2);
                double lateralSurfaceHeight = Math.Sqrt(Math.Pow(sideLength, 2) - Math.Pow(baseLength / 2, 2));
                double lateralSurface = Math.Round(2 * polygon * ((baseLength/2)*lateralSurfaceHeight)/2,2);
                double volume = Math.Round((baseArea * altitude) / 3,2);
                double surfArea = Math.Round(baseArea + lateralSurface, 2);
                alt_input.Text = Convert.ToString(altitude);
                lsf_input.Text = Convert.ToString(lateralSurface);
                baseArea_input.Text = Convert.ToString(baseArea);
                a_input.Text = Convert.ToString(baseArea + lateralSurface);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Pyramid---");
                Results.Add("Number of sides(polygon type): " + polygon);
                Results.Add("Length of base: " + baseLength + " cm");
                Results.Add("Length of altitude: " + altitude + " cm");
                Results.Add("Area of the base: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Area of lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surfArea + " cm²");
            }
        }

        public void Cone()
        {
            double surfaceArea = 0, lateralSurface = 0, radius = 0, altitude = 0, baseArea = 0, volume = 0, side = 0;
            if (r_input.Text != "" && alt_input.Text != "")
            {
                radius = double.Parse(r_input.Text);
                altitude = double.Parse(alt_input.Text);
                side = Math.Round(Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(altitude, 2)),2);
                surfaceArea = Math.Round(Math.PI*radius*(radius+side),2);
                baseArea = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
                lateralSurface = Math.Round(surfaceArea - baseArea, 2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude / 3, 2);
            }
            else if (alt_input.Text != "" && side_input.Text != "")
            {
                side = double.Parse(side_input.Text);
                altitude = double.Parse(alt_input.Text);
                radius = Math.Round(Math.Sqrt(Math.Pow(side, 2) - Math.Pow(altitude, 2)));
                surfaceArea = Math.Round(Math.PI * radius * (radius + side), 2);
                baseArea = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
                lateralSurface = Math.Round(surfaceArea - baseArea,2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude / 3,2);
                r_input.Text = Convert.ToString(radius);
            }
            else if (side_input.Text != "" && r_input.Text != "")
            {
                side = double.Parse(side_input.Text);
                radius = double.Parse(alt_input.Text);
                altitude = Math.Round(Math.Sqrt(Math.Pow(side, 2) - Math.Pow(radius, 2)));
                surfaceArea = Math.Round(Math.PI * radius * (radius + side), 2);
                baseArea = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
                lateralSurface = Math.Round(surfaceArea - baseArea, 2);
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * altitude / 3, 2);
            }
            if ((r_input.Text != "" && alt_input.Text != "") || alt_input.Text != "" && lsf_input.Text != "" || r_input.Text != "" && lsf_input.Text != "")
            {
                a_input.Text = Convert.ToString(surfaceArea);
                lsf_input.Text = Convert.ToString(lateralSurface);
                side_input.Text = Convert.ToString(side);
                baseArea_input.Text = Convert.ToString(baseArea);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Cone---");
                Results.Add("Radius: " + radius + " cm");
                Results.Add("Length of 'imaginary' side: " + altitude + " cm");
                Results.Add("Length of altitude: " + altitude + " cm");
                Results.Add("Area of the base: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Area of lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surfaceArea + " cm²");
            }
        }
        public void Prism()
        {
            if (p_input.Text != "" && base_input.Text != "" && alt_input.Text != "")
            {
                double polygon = double.Parse(p_input.Text);
                double baseLength = double.Parse(base_input.Text);
                double altitude = double.Parse(alt_input.Text);
                double degree = RadianToDegree(Math.Asin(baseLength/2/baseLength));
                double baseHeight = (baseLength / 2) / Math.Tan(DegreeToRadian(degree));
                double baseArea = Math.Round(polygon ==3 || polygon==6 ? Math.Pow(baseLength, 2) * Math.Sin(DegreeToRadian(60)) : polygon * ((baseLength*baseHeight)/2),2);
                double volume = Math.Round(baseArea * altitude,2);
                double lateralSurface = Math.Round(polygon * (altitude * baseLength),2);
                double surfArea = Math.Round(2 * baseArea + lateralSurface, 2);
                baseArea_input.Text = Convert.ToString(baseArea);
                lsf_input.Text = Convert.ToString(lateralSurface);
                a_input.Text = Convert.ToString(surfArea);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Prism---");
                Results.Add("Number of sides(polygon type): " + polygon);
                Results.Add("Length of base: " + baseLength + " cm");
                Results.Add("Length of altitude: " + altitude + " cm");
                Results.Add("Area of the base: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Area of lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surfArea + " cm²");
            }
        }
        public void Sphere()
        {
            if(r_input.Text != "")
            {
                double radius = double.Parse(r_input.Text);
                double area = Math.Round(4 * Math.Pow(radius, 2) * Math.PI,2);
                double volume = Math.Round(4 * Math.PI * Math.Pow(radius, 3) / 3,2);
                a_input.Text = Convert.ToString(area);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Sphere---");
                Results.Add("Radius: " + radius + " cm");
                Results.Add("Surface area: " + area + " cm²");
                Results.Add("Volume: " + volume + " cm³");
            }
            else if (a_input.Text != "")
            {
                double area = double.Parse(a_input.Text);
                double radius = Math.Round(Math.Sqrt(area/(4 * Math.PI)), 2);
                double volume = Math.Round((4 * Math.Pow(radius, 3) * Math.PI) / 3, 2);
                r_input.Text = Convert.ToString(radius);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Sphere---");
                Results.Add("Radius: " + radius + " cm");
                Results.Add("Surface area: " + area + " cm");
                Results.Add("Volume: " + volume + " cm³");
            }
            else if (v_input.Text != "")
            {
                double volume = double.Parse(v_input.Text);
                double radius = Math.Round(Math.Pow(volume*3/(4* Math.PI),(double)1/3), 2);
                double area = Math.Round(4 * Math.Pow(radius, 2) * Math.PI, 2);
                a_input.Text = Convert.ToString(area);
                r_input.Text = Convert.ToString(radius);
                Results.Add("---Sphere---");
                Results.Add("Radius: " + radius + " cm");
                Results.Add("Surface area: " + area + " cm²");
                Results.Add("Volume: " + volume + " cm³");
            }
        }
        public void PFrustum() 
        {
            double baseArea = 0, topArea = 0, lateralSurface = 0, surf_area = 0, volume = 0;
            if (base_input.Text != "" && topBase_input.Text != "" && side_input.Text != "")
            {
                double baseLength = double.Parse(base_input.Text);
                double topLength = double.Parse(topBase_input.Text);
                double side = double.Parse(side_input.Text);
                double thirdsideSmall = Math.Sqrt(2 * Math.Pow(topLength,2));  /*this means the diagonal of the smaller square, 
                * top of the trapezium inside which we're gonna use to calculate the altitude */
                double thirdsideLarge = Math.Sqrt(2 * Math.Pow(baseLength, 2)); // this means the diagonal of the larger square / hypotenuse of larger triangle
                double baseOfTriangle = (thirdsideLarge - thirdsideSmall) / 2;
                double altitude = Math.Round(Math.Sqrt(Math.Pow(side, 2) - Math.Pow(baseOfTriangle, 2)),2);
                topArea = Math.Round(Math.Pow(topLength, 2),2);
                baseArea = Math.Round(Math.Pow(baseLength, 2),2);
                double areaOfTrapezium = Math.Round((baseLength + topLength) / 2 * altitude,2);
                volume = Math.Round((altitude / 3) * (baseArea + Math.Sqrt(baseArea*topArea)+topArea),2);
                lateralSurface = Math.Round(4 * areaOfTrapezium,2); 
                surf_area = Math.Round(topArea + baseArea + areaOfTrapezium * 4,2);
                alt_input.Text = Convert.ToString(Math.Round(altitude, 2));
                Results.Add("---Pyramidal Frustum---");
                Results.Add("Base length: " + baseLength + " cm");
                Results.Add("Top side length: " + topLength + " cm");
                Results.Add("Side of pyramid: " + side + " cm");
                Results.Add("Altitude: " + altitude + " cm");
                Results.Add("Top area: " + topArea + " cm²");
                Results.Add("Base area: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surf_area + " cm²");
            }
            else if (base_input.Text != "" && alt_input.Text != "" && side_input.Text != "")
            {
                // case when we give base, side, altitude comes here
                double baseLength = double.Parse(base_input.Text);
                double side = double.Parse(side_input.Text);
                double altitude = double.Parse(alt_input.Text);
                double topLength = baseLength / 2;
                topArea = Math.Round(Math.Pow(topLength, 2), 2);
                baseArea = Math.Round(Math.Pow(baseLength, 2), 2);
                double areaOfTrapezium = Math.Round((baseLength + topLength) / 2 * altitude, 2);
                volume = Math.Round((altitude / 3) * (baseArea + Math.Sqrt(baseArea * topArea) + topArea), 2);
                lateralSurface = Math.Round(4 * areaOfTrapezium, 2);
                surf_area = Math.Round(topArea + baseArea + areaOfTrapezium * 4, 2);
                side_input.Text = Convert.ToString(Math.Round(side, 2));
                topBase_input.Text = Convert.ToString(Math.Round(topLength, 2));
                Results.Add("---Pyramidal Frustum---");
                Results.Add("Base length: " + baseLength + " cm");
                Results.Add("Top side length: " + topLength + " cm");
                Results.Add("Side of pyramid: " + side + " cm");
                Results.Add("Altitude: " + altitude + " cm");
                Results.Add("Top area: " + topArea + " cm²");
                Results.Add("Base area: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surf_area + " cm²");
            }
            if ((base_input.Text != "" && topBase_input.Text != "" && side_input.Text != "") || (base_input.Text != "" && alt_input.Text != "" && side_input.Text != "")){
                baseArea_input.Text = Convert.ToString(Math.Round(baseArea, 2));
                topArea_input.Text = Convert.ToString(Math.Round(topArea, 2));
                lsf_input.Text = Convert.ToString(Math.Round(lateralSurface, 2));
                a_input.Text = Convert.ToString(Math.Round(surf_area));
                v_input.Text = Convert.ToString(Math.Round(volume, 2)); }

        }

        public void CFrustum()
        {
            double baseArea = 0, topArea = 0, lateralSurface = 0, surf_area = 0, volume = 0, baseRadius=0, topRadius = 0, generatrix = 0, altitude =0;
            if (base_input.Text != "" && topBase_input.Text != "" && side_input.Text != "")
            {
                baseRadius = double.Parse(base_input.Text);
                topRadius = double.Parse(topBase_input.Text);
                generatrix = double.Parse(side_input.Text);
                altitude = Math.Round(Math.Sqrt(Math.Pow(generatrix, 2) - Math.Pow(baseRadius - topRadius, 2)),2);
                topArea = Math.Round(Math.Pow(topRadius, 2),2);
                baseArea = Math.Round(Math.Pow(baseRadius, 2),2);
                volume = Math.Round((Math.PI * altitude / 3) * (Math.Pow(baseRadius, 2) + (baseRadius * topRadius) + Math.Pow(topRadius, 2)),2);
                lateralSurface = Math.Round((baseRadius + topRadius) * generatrix * Math.PI,2);
                surf_area = Math.Round(Math.PI * (Math.Pow(baseRadius, 2) + Math.Pow(topRadius, 2) + (baseRadius + topRadius) * generatrix),2);
                alt_input.Text = Convert.ToString(altitude);
            }
            else if (base_input.Text != "" && alt_input.Text != "" && topBase_input.Text != "")
            {
                baseRadius = double.Parse(base_input.Text);
                topRadius = double.Parse(topBase_input.Text);
                altitude = double.Parse(alt_input.Text);
                generatrix = Math.Round(Math.Sqrt(Math.Pow(altitude, 2) + Math.Pow(baseRadius - topRadius, 2)),2);
                topArea = Math.Round(Math.Pow(topRadius, 2),2);
                baseArea = Math.Round(Math.Pow(baseRadius, 2),2);
                volume = Math.Round((Math.PI * altitude / 3) * (Math.Pow(baseRadius, 2) + (baseRadius * topRadius) + Math.Pow(topRadius, 2)),2);
                lateralSurface = Math.Round((baseRadius + topRadius) * generatrix * Math.PI,2);
                surf_area = Math.Round(Math.PI * (Math.Pow(baseRadius, 2) + Math.Pow(topRadius, 2) + (baseRadius + topRadius) * generatrix),2);
                side_input.Text = Convert.ToString(Math.Round(generatrix, 2));
            }
            else if (base_input.Text != "" && alt_input.Text != "" && side_input.Text != "")
            {
                baseRadius = double.Parse(base_input.Text);
                altitude = double.Parse(alt_input.Text);
                generatrix = double.Parse(side_input.Text);
                topRadius = Math.Round(baseRadius - Math.Sqrt(Math.Pow(generatrix, 2) - Math.Pow(altitude, 2)), 2);
                topArea = Math.Round(Math.Pow(topRadius, 2), 2);
                baseArea = Math.Round(Math.Pow(baseRadius, 2), 2);
                volume = Math.Round((Math.PI * altitude / 3) * (Math.Pow(baseRadius, 2) + (baseRadius * topRadius) + Math.Pow(topRadius, 2)), 2);
                lateralSurface = Math.Round((baseRadius + topRadius) * generatrix * Math.PI, 2);
                surf_area = Math.Round(Math.PI * (Math.Pow(baseRadius, 2) + Math.Pow(topRadius, 2) + (baseRadius + topRadius) * generatrix), 2);
                topBase_input.Text = Convert.ToString(Math.Round(topRadius, 2));
            }
            if ((base_input.Text != "" && topBase_input.Text != "" && side_input.Text != "") || (base_input.Text != "" && alt_input.Text != "" && topBase_input.Text != "") || (base_input.Text != "" && alt_input.Text != "" && side_input.Text != ""))
            {
                baseArea_input.Text = Convert.ToString(baseArea);
                topArea_input.Text = Convert.ToString(topArea);
                lsf_input.Text = Convert.ToString(lateralSurface);
                a_input.Text = Convert.ToString(surf_area);
                v_input.Text = Convert.ToString(volume);
                Results.Add("---Conical Frustum---");
                Results.Add("Base radius: " + baseRadius + " cm");
                Results.Add("Top radius: " + topRadius + " cm");
                Results.Add("Generatrix: " + generatrix + " cm");
                Results.Add("Top area: " + topArea + " cm²");
                Results.Add("Base area: " + baseArea + " cm²");
                Results.Add("Volume: " + volume + " cm³");
                Results.Add("Lateral surface: " + lateralSurface + " cm²");
                Results.Add("Surface area: " + surf_area + " cm²");
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            r_input.Text = "";
            alt_input.Text = "";
            base_input.Text = "";
            side_input.Text = "";
            topArea_input.Text = "";
            topBase_input.Text = "";
            baseArea_input.Text = "";
            lsf_input.Text = "";
            v_input.Text = "";
            a_input.Text = "";
            p_input.Text = "";
        }

        private void SaveCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "Calculations";
            sfd.Title = "Save Text File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (string x in Results) sw.WriteLine(x);
                sw.Close();
            }
        }
    }
}
