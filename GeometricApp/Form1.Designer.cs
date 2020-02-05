namespace GeometricApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radius = new System.Windows.Forms.Label();
            this.polygon = new System.Windows.Forms.Label();
            this.lat_surf = new System.Windows.Forms.Label();
            this.surf_area = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.r_input = new System.Windows.Forms.TextBox();
            this.p_input = new System.Windows.Forms.TextBox();
            this.lsf_input = new System.Windows.Forms.TextBox();
            this.a_input = new System.Windows.Forms.TextBox();
            this.altitude = new System.Windows.Forms.Label();
            this.alt_input = new System.Windows.Forms.TextBox();
            this.v_input = new System.Windows.Forms.TextBox();
            this.baseT = new System.Windows.Forms.Label();
            this.base_input = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rcm = new System.Windows.Forms.Label();
            this.altcm = new System.Windows.Forms.Label();
            this.bcm = new System.Windows.Forms.Label();
            this.lscm = new System.Windows.Forms.Label();
            this.sacm = new System.Windows.Forms.Label();
            this.vcm = new System.Windows.Forms.Label();
            this.bacm = new System.Windows.Forms.Label();
            this.baseArea_input = new System.Windows.Forms.TextBox();
            this.baseArea = new System.Windows.Forms.Label();
            this.scm = new System.Windows.Forms.Label();
            this.side_input = new System.Windows.Forms.TextBox();
            this.side = new System.Windows.Forms.Label();
            this.tacm = new System.Windows.Forms.Label();
            this.topArea_input = new System.Windows.Forms.TextBox();
            this.topArea = new System.Windows.Forms.Label();
            this.tbcm = new System.Windows.Forms.Label();
            this.topBase_input = new System.Windows.Forms.TextBox();
            this.topBase = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyramidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pyramidalFrustumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conicalFrustumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcHist = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentMode = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radius.ForeColor = System.Drawing.Color.Lime;
            this.radius.Location = new System.Drawing.Point(22, 68);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(47, 15);
            this.radius.TabIndex = 0;
            this.radius.Text = "Radius";
            // 
            // polygon
            // 
            this.polygon.AutoSize = true;
            this.polygon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygon.ForeColor = System.Drawing.Color.White;
            this.polygon.Location = new System.Drawing.Point(3, 93);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(61, 15);
            this.polygon.TabIndex = 1;
            this.polygon.Text = "Polygon #";
            this.polygon.Visible = false;
            // 
            // lat_surf
            // 
            this.lat_surf.AutoSize = true;
            this.lat_surf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lat_surf.ForeColor = System.Drawing.Color.Lime;
            this.lat_surf.Location = new System.Drawing.Point(202, 151);
            this.lat_surf.Name = "lat_surf";
            this.lat_surf.Size = new System.Drawing.Size(89, 15);
            this.lat_surf.TabIndex = 2;
            this.lat_surf.Text = "Lateral surface";
            // 
            // surf_area
            // 
            this.surf_area.AutoSize = true;
            this.surf_area.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surf_area.ForeColor = System.Drawing.Color.White;
            this.surf_area.Location = new System.Drawing.Point(214, 123);
            this.surf_area.Name = "surf_area";
            this.surf_area.Size = new System.Drawing.Size(77, 15);
            this.surf_area.TabIndex = 3;
            this.surf_area.Text = "Surface area";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volume.ForeColor = System.Drawing.Color.Lime;
            this.volume.Location = new System.Drawing.Point(242, 178);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(48, 15);
            this.volume.TabIndex = 5;
            this.volume.Text = "Volume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Give 1 data for sphere, 2: cylinder / cone, 3 for others";
            // 
            // r_input
            // 
            this.r_input.BackColor = System.Drawing.Color.DimGray;
            this.r_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_input.ForeColor = System.Drawing.SystemColors.Window;
            this.r_input.Location = new System.Drawing.Point(70, 62);
            this.r_input.Name = "r_input";
            this.r_input.Size = new System.Drawing.Size(100, 21);
            this.r_input.TabIndex = 11;
            // 
            // p_input
            // 
            this.p_input.BackColor = System.Drawing.Color.DimGray;
            this.p_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p_input.ForeColor = System.Drawing.SystemColors.Window;
            this.p_input.Location = new System.Drawing.Point(70, 90);
            this.p_input.Name = "p_input";
            this.p_input.Size = new System.Drawing.Size(100, 21);
            this.p_input.TabIndex = 12;
            this.p_input.Visible = false;
            // 
            // lsf_input
            // 
            this.lsf_input.BackColor = System.Drawing.Color.DimGray;
            this.lsf_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsf_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsf_input.ForeColor = System.Drawing.SystemColors.Window;
            this.lsf_input.Location = new System.Drawing.Point(296, 148);
            this.lsf_input.Name = "lsf_input";
            this.lsf_input.Size = new System.Drawing.Size(100, 21);
            this.lsf_input.TabIndex = 13;
            // 
            // a_input
            // 
            this.a_input.BackColor = System.Drawing.Color.DimGray;
            this.a_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a_input.ForeColor = System.Drawing.SystemColors.Window;
            this.a_input.Location = new System.Drawing.Point(296, 119);
            this.a_input.Name = "a_input";
            this.a_input.ReadOnly = true;
            this.a_input.Size = new System.Drawing.Size(100, 21);
            this.a_input.TabIndex = 14;
            // 
            // altitude
            // 
            this.altitude.AutoSize = true;
            this.altitude.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altitude.ForeColor = System.Drawing.Color.Lime;
            this.altitude.Location = new System.Drawing.Point(18, 121);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(47, 15);
            this.altitude.TabIndex = 16;
            this.altitude.Text = "Altitude";
            // 
            // alt_input
            // 
            this.alt_input.BackColor = System.Drawing.Color.DimGray;
            this.alt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alt_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alt_input.ForeColor = System.Drawing.SystemColors.Window;
            this.alt_input.Location = new System.Drawing.Point(70, 117);
            this.alt_input.Name = "alt_input";
            this.alt_input.Size = new System.Drawing.Size(100, 21);
            this.alt_input.TabIndex = 17;
            // 
            // v_input
            // 
            this.v_input.BackColor = System.Drawing.Color.DimGray;
            this.v_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v_input.ForeColor = System.Drawing.SystemColors.Window;
            this.v_input.Location = new System.Drawing.Point(296, 177);
            this.v_input.Name = "v_input";
            this.v_input.Size = new System.Drawing.Size(100, 21);
            this.v_input.TabIndex = 18;
            // 
            // baseT
            // 
            this.baseT.AutoSize = true;
            this.baseT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baseT.ForeColor = System.Drawing.Color.White;
            this.baseT.Location = new System.Drawing.Point(28, 148);
            this.baseT.Name = "baseT";
            this.baseT.Size = new System.Drawing.Size(41, 15);
            this.baseT.TabIndex = 19;
            this.baseT.Text = "Base*";
            this.baseT.Visible = false;
            // 
            // base_input
            // 
            this.base_input.BackColor = System.Drawing.Color.DimGray;
            this.base_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.base_input.ForeColor = System.Drawing.SystemColors.Window;
            this.base_input.Location = new System.Drawing.Point(70, 145);
            this.base_input.Name = "base_input";
            this.base_input.Size = new System.Drawing.Size(100, 21);
            this.base_input.TabIndex = 20;
            this.base_input.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(106, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 53);
            this.button2.TabIndex = 21;
            this.button2.Text = "Calculate it!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rcm
            // 
            this.rcm.AutoSize = true;
            this.rcm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rcm.ForeColor = System.Drawing.Color.Lime;
            this.rcm.Location = new System.Drawing.Point(176, 68);
            this.rcm.Name = "rcm";
            this.rcm.Size = new System.Drawing.Size(24, 15);
            this.rcm.TabIndex = 22;
            this.rcm.Text = "cm";
            // 
            // altcm
            // 
            this.altcm.AutoSize = true;
            this.altcm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altcm.ForeColor = System.Drawing.Color.Lime;
            this.altcm.Location = new System.Drawing.Point(176, 119);
            this.altcm.Name = "altcm";
            this.altcm.Size = new System.Drawing.Size(24, 15);
            this.altcm.TabIndex = 24;
            this.altcm.Text = "cm";
            // 
            // bcm
            // 
            this.bcm.AutoSize = true;
            this.bcm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bcm.ForeColor = System.Drawing.Color.White;
            this.bcm.Location = new System.Drawing.Point(176, 148);
            this.bcm.Name = "bcm";
            this.bcm.Size = new System.Drawing.Size(24, 15);
            this.bcm.TabIndex = 25;
            this.bcm.Text = "cm";
            this.bcm.Visible = false;
            // 
            // lscm
            // 
            this.lscm.AutoSize = true;
            this.lscm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lscm.ForeColor = System.Drawing.Color.Lime;
            this.lscm.Location = new System.Drawing.Point(402, 154);
            this.lscm.Name = "lscm";
            this.lscm.Size = new System.Drawing.Size(28, 15);
            this.lscm.TabIndex = 26;
            this.lscm.Text = "cm²";
            // 
            // sacm
            // 
            this.sacm.AutoSize = true;
            this.sacm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacm.ForeColor = System.Drawing.Color.White;
            this.sacm.Location = new System.Drawing.Point(402, 123);
            this.sacm.Name = "sacm";
            this.sacm.Size = new System.Drawing.Size(28, 15);
            this.sacm.TabIndex = 27;
            this.sacm.Text = "cm²";
            // 
            // vcm
            // 
            this.vcm.AutoSize = true;
            this.vcm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vcm.ForeColor = System.Drawing.Color.Lime;
            this.vcm.Location = new System.Drawing.Point(402, 183);
            this.vcm.Name = "vcm";
            this.vcm.Size = new System.Drawing.Size(28, 15);
            this.vcm.TabIndex = 28;
            this.vcm.Text = "cm³";
            // 
            // bacm
            // 
            this.bacm.AutoSize = true;
            this.bacm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bacm.ForeColor = System.Drawing.Color.White;
            this.bacm.Location = new System.Drawing.Point(402, 65);
            this.bacm.Name = "bacm";
            this.bacm.Size = new System.Drawing.Size(28, 15);
            this.bacm.TabIndex = 31;
            this.bacm.Text = "cm²";
            // 
            // baseArea_input
            // 
            this.baseArea_input.BackColor = System.Drawing.Color.DimGray;
            this.baseArea_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseArea_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baseArea_input.ForeColor = System.Drawing.SystemColors.Window;
            this.baseArea_input.Location = new System.Drawing.Point(296, 65);
            this.baseArea_input.Name = "baseArea_input";
            this.baseArea_input.ReadOnly = true;
            this.baseArea_input.Size = new System.Drawing.Size(100, 21);
            this.baseArea_input.TabIndex = 30;
            // 
            // baseArea
            // 
            this.baseArea.AutoSize = true;
            this.baseArea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baseArea.ForeColor = System.Drawing.Color.White;
            this.baseArea.Location = new System.Drawing.Point(227, 68);
            this.baseArea.Name = "baseArea";
            this.baseArea.Size = new System.Drawing.Size(64, 15);
            this.baseArea.TabIndex = 29;
            this.baseArea.Text = "Base area";
            // 
            // scm
            // 
            this.scm.AutoSize = true;
            this.scm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scm.ForeColor = System.Drawing.Color.White;
            this.scm.Location = new System.Drawing.Point(176, 175);
            this.scm.Name = "scm";
            this.scm.Size = new System.Drawing.Size(24, 15);
            this.scm.TabIndex = 35;
            this.scm.Text = "cm";
            this.scm.Visible = false;
            // 
            // side_input
            // 
            this.side_input.BackColor = System.Drawing.Color.DimGray;
            this.side_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.side_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.side_input.ForeColor = System.Drawing.SystemColors.Window;
            this.side_input.Location = new System.Drawing.Point(70, 172);
            this.side_input.Name = "side_input";
            this.side_input.Size = new System.Drawing.Size(100, 21);
            this.side_input.TabIndex = 34;
            this.side_input.Visible = false;
            // 
            // side
            // 
            this.side.AutoSize = true;
            this.side.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.side.ForeColor = System.Drawing.Color.White;
            this.side.Location = new System.Drawing.Point(28, 172);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(37, 15);
            this.side.TabIndex = 33;
            this.side.Text = "Side*";
            this.side.Visible = false;
            // 
            // tacm
            // 
            this.tacm.AutoSize = true;
            this.tacm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tacm.ForeColor = System.Drawing.Color.White;
            this.tacm.Location = new System.Drawing.Point(402, 96);
            this.tacm.Name = "tacm";
            this.tacm.Size = new System.Drawing.Size(28, 15);
            this.tacm.TabIndex = 42;
            this.tacm.Text = "cm²";
            this.tacm.Visible = false;
            // 
            // topArea_input
            // 
            this.topArea_input.BackColor = System.Drawing.Color.DimGray;
            this.topArea_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topArea_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topArea_input.ForeColor = System.Drawing.SystemColors.Window;
            this.topArea_input.Location = new System.Drawing.Point(296, 93);
            this.topArea_input.Name = "topArea_input";
            this.topArea_input.Size = new System.Drawing.Size(100, 21);
            this.topArea_input.TabIndex = 41;
            this.topArea_input.Visible = false;
            // 
            // topArea
            // 
            this.topArea.AutoSize = true;
            this.topArea.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topArea.ForeColor = System.Drawing.Color.White;
            this.topArea.Location = new System.Drawing.Point(236, 96);
            this.topArea.Name = "topArea";
            this.topArea.Size = new System.Drawing.Size(55, 15);
            this.topArea.TabIndex = 40;
            this.topArea.Text = "Top area";
            this.topArea.Visible = false;
            // 
            // tbcm
            // 
            this.tbcm.AutoSize = true;
            this.tbcm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbcm.ForeColor = System.Drawing.Color.White;
            this.tbcm.Location = new System.Drawing.Point(176, 202);
            this.tbcm.Name = "tbcm";
            this.tbcm.Size = new System.Drawing.Size(24, 15);
            this.tbcm.TabIndex = 45;
            this.tbcm.Text = "cm";
            this.tbcm.Visible = false;
            // 
            // topBase_input
            // 
            this.topBase_input.BackColor = System.Drawing.Color.DimGray;
            this.topBase_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topBase_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topBase_input.ForeColor = System.Drawing.SystemColors.Window;
            this.topBase_input.Location = new System.Drawing.Point(70, 199);
            this.topBase_input.Name = "topBase_input";
            this.topBase_input.Size = new System.Drawing.Size(100, 21);
            this.topBase_input.TabIndex = 44;
            this.topBase_input.Visible = false;
            // 
            // topBase
            // 
            this.topBase.AutoSize = true;
            this.topBase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topBase.ForeColor = System.Drawing.Color.White;
            this.topBase.Location = new System.Drawing.Point(6, 199);
            this.topBase.Name = "topBase";
            this.topBase.Size = new System.Drawing.Size(63, 15);
            this.topBase.TabIndex = 43;
            this.topBase.Text = "Top base*";
            this.topBase.Visible = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Maroon;
            this.clear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(249, 282);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 53);
            this.clear.TabIndex = 49;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "*: at Conical frustum(from top to bottom) base radius, generatrix, top radius";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modesToolStripMenuItem,
            this.unitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCalculationsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCalculationsToolStripMenuItem
            // 
            this.saveCalculationsToolStripMenuItem.Name = "saveCalculationsToolStripMenuItem";
            this.saveCalculationsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveCalculationsToolStripMenuItem.Text = "Save calculations...";
            this.saveCalculationsToolStripMenuItem.Click += new System.EventHandler(this.SaveCalculationsToolStripMenuItem_Click);
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cylinderToolStripMenuItem,
            this.pyramidToolStripMenuItem,
            this.coneToolStripMenuItem,
            this.prismToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.pyramidalFrustumToolStripMenuItem,
            this.conicalFrustumToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.CylinderToolStripMenuItem_Click);
            // 
            // pyramidToolStripMenuItem
            // 
            this.pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem";
            this.pyramidToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pyramidToolStripMenuItem.Text = "Pyramid";
            this.pyramidToolStripMenuItem.Click += new System.EventHandler(this.PyramidToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.ConeToolStripMenuItem_Click);
            // 
            // prismToolStripMenuItem
            // 
            this.prismToolStripMenuItem.Name = "prismToolStripMenuItem";
            this.prismToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.prismToolStripMenuItem.Text = "Prism";
            this.prismToolStripMenuItem.Click += new System.EventHandler(this.PrismToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.SphereToolStripMenuItem_Click);
            // 
            // pyramidalFrustumToolStripMenuItem
            // 
            this.pyramidalFrustumToolStripMenuItem.Name = "pyramidalFrustumToolStripMenuItem";
            this.pyramidalFrustumToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pyramidalFrustumToolStripMenuItem.Text = "Pyramidal frustum";
            this.pyramidalFrustumToolStripMenuItem.Click += new System.EventHandler(this.PyramidalFrustumToolStripMenuItem_Click);
            // 
            // conicalFrustumToolStripMenuItem
            // 
            this.conicalFrustumToolStripMenuItem.Name = "conicalFrustumToolStripMenuItem";
            this.conicalFrustumToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.conicalFrustumToolStripMenuItem.Text = "Conical frustum";
            this.conicalFrustumToolStripMenuItem.Click += new System.EventHandler(this.ConicalFrustumToolStripMenuItem_Click);
            // 
            // calcHist
            // 
            this.calcHist.BackColor = System.Drawing.Color.DimGray;
            this.calcHist.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calcHist.ForeColor = System.Drawing.SystemColors.Window;
            this.calcHist.Location = new System.Drawing.Point(453, 63);
            this.calcHist.Name = "calcHist";
            this.calcHist.ReadOnly = true;
            this.calcHist.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.calcHist.Size = new System.Drawing.Size(262, 272);
            this.calcHist.TabIndex = 52;
            this.calcHist.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(450, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Calculation History";
            // 
            // currentMode
            // 
            this.currentMode.AutoSize = true;
            this.currentMode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentMode.ForeColor = System.Drawing.Color.White;
            this.currentMode.Location = new System.Drawing.Point(17, 39);
            this.currentMode.Name = "currentMode";
            this.currentMode.Size = new System.Drawing.Size(52, 15);
            this.currentMode.TabIndex = 54;
            this.currentMode.Text = "Cylinder";
            this.currentMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_input
            // 
            this.name_input.BackColor = System.Drawing.Color.DimGray;
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_input.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name_input.ForeColor = System.Drawing.SystemColors.Window;
            this.name_input.Location = new System.Drawing.Point(164, 34);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 21);
            this.name_input.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(114, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmToolStripMenuItem,
            this.cmToolStripMenuItem,
            this.dmToolStripMenuItem,
            this.mToolStripMenuItem,
            this.kmToolStripMenuItem});
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.unitToolStripMenuItem.Text = "Unit";
            // 
            // mmToolStripMenuItem
            // 
            this.mmToolStripMenuItem.Name = "mmToolStripMenuItem";
            this.mmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mmToolStripMenuItem.Text = "mm";
            this.mmToolStripMenuItem.Click += new System.EventHandler(this.MmToolStripMenuItem_Click);
            // 
            // cmToolStripMenuItem
            // 
            this.cmToolStripMenuItem.Name = "cmToolStripMenuItem";
            this.cmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cmToolStripMenuItem.Text = "cm";
            this.cmToolStripMenuItem.Click += new System.EventHandler(this.CmToolStripMenuItem_Click);
            // 
            // dmToolStripMenuItem
            // 
            this.dmToolStripMenuItem.Name = "dmToolStripMenuItem";
            this.dmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dmToolStripMenuItem.Text = "dm";
            this.dmToolStripMenuItem.Click += new System.EventHandler(this.DmToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mToolStripMenuItem.Text = "m";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.MToolStripMenuItem_Click);
            // 
            // kmToolStripMenuItem
            // 
            this.kmToolStripMenuItem.Name = "kmToolStripMenuItem";
            this.kmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kmToolStripMenuItem.Text = "km";
            this.kmToolStripMenuItem.Click += new System.EventHandler(this.KmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(727, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.currentMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcHist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tbcm);
            this.Controls.Add(this.topBase_input);
            this.Controls.Add(this.topBase);
            this.Controls.Add(this.tacm);
            this.Controls.Add(this.topArea_input);
            this.Controls.Add(this.topArea);
            this.Controls.Add(this.scm);
            this.Controls.Add(this.side_input);
            this.Controls.Add(this.side);
            this.Controls.Add(this.bacm);
            this.Controls.Add(this.baseArea_input);
            this.Controls.Add(this.baseArea);
            this.Controls.Add(this.vcm);
            this.Controls.Add(this.sacm);
            this.Controls.Add(this.lscm);
            this.Controls.Add(this.bcm);
            this.Controls.Add(this.altcm);
            this.Controls.Add(this.rcm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.base_input);
            this.Controls.Add(this.baseT);
            this.Controls.Add(this.v_input);
            this.Controls.Add(this.alt_input);
            this.Controls.Add(this.altitude);
            this.Controls.Add(this.a_input);
            this.Controls.Add(this.lsf_input);
            this.Controls.Add(this.p_input);
            this.Controls.Add(this.r_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.surf_area);
            this.Controls.Add(this.lat_surf);
            this.Controls.Add(this.polygon);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Geometrical Calculator App by Kun Attila v0.93";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label radius;
        public System.Windows.Forms.Label polygon;
        public System.Windows.Forms.Label lat_surf;
        public System.Windows.Forms.Label surf_area;
        public System.Windows.Forms.Label volume;
        public System.Windows.Forms.TextBox r_input;
        public System.Windows.Forms.TextBox p_input;
        public System.Windows.Forms.TextBox lsf_input;
        public System.Windows.Forms.TextBox a_input;
        public System.Windows.Forms.Label altitude;
        public System.Windows.Forms.TextBox alt_input;
        public System.Windows.Forms.TextBox v_input;
        public System.Windows.Forms.Label baseT;
        public System.Windows.Forms.TextBox base_input;
        public System.Windows.Forms.Label rcm;
        public System.Windows.Forms.Label altcm;
        public System.Windows.Forms.Label bcm;
        public System.Windows.Forms.Label lscm;
        public System.Windows.Forms.Label sacm;
        public System.Windows.Forms.Label vcm;
        public System.Windows.Forms.Label bacm;
        public System.Windows.Forms.TextBox baseArea_input;
        public System.Windows.Forms.Label baseArea;
        public System.Windows.Forms.Label scm;
        public System.Windows.Forms.TextBox side_input;
        public System.Windows.Forms.Label side;
        public System.Windows.Forms.Label tacm;
        public System.Windows.Forms.TextBox topArea_input;
        public System.Windows.Forms.Label topArea;
        public System.Windows.Forms.Label tbcm;
        public System.Windows.Forms.TextBox topBase_input;
        public System.Windows.Forms.Label topBase;
        private System.Windows.Forms.Button clear;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCalculationsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox calcHist;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyramidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pyramidalFrustumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conicalFrustumToolStripMenuItem;
        public System.Windows.Forms.Label currentMode;
        private System.Windows.Forms.TextBox name_input;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmToolStripMenuItem;
    }
}

