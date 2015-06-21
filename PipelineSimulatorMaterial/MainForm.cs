using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PipelineSimulatorMaterial
{
    public partial class MainForm : MaterialForm
    {
        public MainForm( )
        {
            InitializeComponent( );

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage( this );
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme( Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE );
            //materialSkinManager.ColorScheme = new ColorScheme( Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE );
        }

        private void BtnOpenInstrFile_Click( object sender, EventArgs e )
        {

            var dialog = new OpenFileDialog( );
            var info = new DirectoryInfo( Application.ExecutablePath );
            dialog.InitialDirectory = info.Parent.FullName;
            dialog.Filter = "所有文件(*.*)|*.*";
            if ( dialog.ShowDialog( ) == DialogResult.OK )
            {
                if ( Pipeline.IsRuning )
                {
                    Pipeline.StopRunning( );
                }
                Pipeline.Init( );

                var path = dialog.FileName;
                FileHandler.ReadInstrFile( path );

                listViewCode_Display( );
                tabNavbar.SelectTab( "tpCode" );
            }
        }

        public void InsertListViewCode( string[ ] data )
        {
            //Add
            ListViewItem item = null;
            foreach ( string property in data )
            {
                if ( item == null )
                {
                    item = new ListViewItem( property );
                }
                else
                {
                    item.SubItems.Add( property );
                }
            }
            item.SubItems[ 1 ].Text = ( lvCode.Items.Count + 1 ).ToString( );

            lvCode.Items.Add( item );
        }

        public static bool Delay( int delayTime ) // seconds
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents( );
            }
            while ( s < delayTime );
            return true;
        }

        private void BtnOpenBinaryFile_Click( object sender, EventArgs e )
        {

            var dialog = new OpenFileDialog( );
            var info = new DirectoryInfo( Application.ExecutablePath );
            dialog.InitialDirectory = info.Parent.FullName;
            dialog.Filter = "所有文件(*.*)|*.*";
            if ( dialog.ShowDialog( ) == DialogResult.OK )
            {
                if ( Pipeline.IsRuning )
                {
                    Pipeline.StopRunning( );
                }
                Pipeline.Init( );

                var path = dialog.FileName;
                FileHandler.ReadBinaryFile( path );
                listViewCode_Display( );
                tabNavbar.SelectTab( "tpCode" );
            }
        }

        private void listViewCode_Display( )
        {
            lvCode.Items.Clear( );
            lvCode.Update( );
            Pipeline.DisplayInstr( this );
            lvCode.EndUpdate( );
        }

        private void btnCodeOptions_Click( object sender, EventArgs e )
        {
            btnCodeOptions.Text = "Changed";

        }

        private void btnProcessOption_Click( object sender, EventArgs e )
        {
            btnPlay.Hide( );
            btnNextStep.Hide( );
            btnNextBreakpoint.Hide( );
            btnReset.Hide( );
            btnProcessOptions.Hide( );

            rbtn1Hz.Show( );
            rbtn5Hz.Show( );
            rbtn10Hz.Show( );
            rbtn50Hz.Show( );
            btnConfirmSpeed.Show( );
        }

        private void btnPlay_Click( object sender, EventArgs e )
        {

            btnPlay.Hide( );
            btnNextStep.Hide( );
            btnNextBreakpoint.Hide( );
            btnReset.Hide( );
            btnProcessOptions.Hide( );
            btnStop.Show( );


            timer1.Interval = 1000;
            if ( rbtn1Hz.Checked )
            {
                timer1.Interval = 1000;
            }
            if ( rbtn5Hz.Checked )
            {
                timer1.Interval = 200;
            }
            if ( rbtn10Hz.Checked )
            {
                timer1.Interval = 100;
            }
            if ( rbtn50Hz.Checked )
            {
                timer1.Interval = 20;
            }

            if ( !Pipeline.IsRuning )
            {
                Pipeline.StartRuning( );
            }
            timer1.Start( );
        }

        private void btnConfirmSpeed_Click( object sender, EventArgs e )
        {
            btnPlay.Show( );
            btnNextStep.Show( );
            btnNextBreakpoint.Show( );
            btnReset.Show( );
            btnProcessOptions.Show( );

            rbtn1Hz.Hide( );
            rbtn5Hz.Hide( );
            rbtn10Hz.Hide( );
            rbtn50Hz.Hide( );
            btnConfirmSpeed.Hide( );
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            if ( timer1.Enabled ) timer1.Stop( );
            if ( timer2.Enabled ) timer2.Stop( );
            btnStop.Hide( );
            btnPlay.Show( );
            btnNextStep.Show( );
            btnNextBreakpoint.Show( );
            btnReset.Show( );
            btnProcessOptions.Show( );
        }

        private void materialRadioButton2_CheckedChanged( object sender, EventArgs e )
        {

        }

        private void materialTabSelector1_Click( object sender, EventArgs e )
        {

        }

        private void materialLabel1_Click( object sender, EventArgs e )
        {

        }

        private void label24_Click( object sender, EventArgs e )
        {

        }

        private void materialLabel1_Click_1( object sender, EventArgs e )
        {

        }

        private void materialFlatButton5_Click_1( object sender, EventArgs e )
        {

        }

        public void TabpageAnimation( )
        {
            var index = tabProcess.SelectedIndex;
            index = ( index + 1 ) % 5;
            tabProcess.SelectTab( index );
        }

        private void timer1_Tick( object sender, EventArgs e )
        {


            //tabProcess.Update(  );
            //Process_Display( );

            Pipeline.Step( this );
            //TabpageAnimation( );
        }

        private void timer2_Tick( object sender, EventArgs e )
        {


            //tabProcess.Update(  );
            // Process_Display( );
            Pipeline.StepBreakPoint( this );
            // TabpageAnimation( );

        }

        public void Process_Display( )
        {
            Pipeline.DisplayProcess( this );
        }

        private void btnReset_Click( object sender, EventArgs e )
        {
            if ( Pipeline.IsRuning )
            {
                Pipeline.StopRunning( );
            }
            Pipeline.Init( );
            Process_Display( );
        }

        public void btnChange( )
        {

            btnStop.Hide( );
            btnPlay.Show( );
            btnNextStep.Show( );
            btnNextBreakpoint.Show( );
            btnReset.Show( );
            btnProcessOptions.Show( );
        }

        private void btnNextStep_Click( object sender, EventArgs e )
        {
            //btnPlay.Hide( );
            //btnNextStep.Hide( );
            //btnNextBreakpoint.Hide( );
            //btnReset.Hide( );
            //btnProcessOptions.Hide( );
            //btnStop.Show( );

            if ( !Pipeline.IsRuning )
            {
                Pipeline.StartRuning( );
            }

            Pipeline.Step( this );
            Process_Display( );
            TabpageAnimation( );
        }

        private void btnNextBreakpoint_Click( object sender, EventArgs e )
        {
            btnPlay.Hide( );
            btnNextStep.Hide( );
            btnNextBreakpoint.Hide( );
            btnReset.Hide( );
            btnProcessOptions.Hide( );
            btnStop.Show( );

           

            timer2.Interval = 1000;
            if ( rbtn1Hz.Checked )
            {
                timer2.Interval = 1000;
            }
            if ( rbtn5Hz.Checked )
            {
                timer2.Interval = 200;
            }
            if ( rbtn10Hz.Checked )
            {
                timer2.Interval = 100;
            }
            if ( rbtn50Hz.Checked )
            {
                timer2.Interval = 20;
            }

            if ( !Pipeline.IsRuning )
            {
                Pipeline.StartRuning( );
            }

            Pipeline.Step( this );
            Process_Display( );
            TabpageAnimation( );

            timer2.Start( );
        }

        private void materialSingleLineTextField1_Click( object sender, EventArgs e )
        {

        }

        private void lvCode_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void lvCode_DoubleClick( object sender, EventArgs e )
        {
            /* var item = lvCode.SelectedItems;
             var addr = PipeConvert.LitEnd2I( item[ 0 ].Text );
             ArrayList bp = Pipeline.Breakpoints;

             if ( bp.Contains( addr ) )
             {
                 bp.Remove( addr );
                 //Pipeline.Breakpoints.Sort( );
             }
             else
             {
                 bp.Add( addr );
                 Debug.WriteLine( "Pipeline"  + Pipeline.Breakpoints.Count );
                 Debug.WriteLine( "bp" + bp.Count );
                 item[ 0 ].Text += "B";
                 //Pipeline.Breakpoints.Sort( );
                 //lvCode.SelectedItems[ 0 ].BackColor = BackColor;
             }*/
        }

        private void DisableBreakpoint_Click( object sender, EventArgs e )
        {
            Debug.WriteLine( "Disable" );

            if ( lvCode.SelectedItems.Count == 0 )
            {
                return;
            }
            var item = lvCode.SelectedItems[ 0 ];


            var addr = PipeConvert.BigEnd2I( item.SubItems[ 2 ].Text.Substring( 2 ) );

            ArrayList bp = Pipeline.Breakpoints;

            if ( !bp.Contains( addr ) )
            {
                return;

            }

            bp.Remove( addr );
            if ( bp.Count >= 2 ) bp.Sort( );
            item.SubItems[ 0 ].Text = "";

            //debug
            Debug.WriteLine( "Disable" );
            foreach ( int bpaddr in bp )
            {
                Debug.Write( PipeConvert.LitEnd2S( bpaddr ) );
            }
            Debug.WriteLine( "" );
            foreach ( int bpaddr in Pipeline.Breakpoints )
            {
                Debug.Write( PipeConvert.LitEnd2S( bpaddr ) );
            }
        }

        private void EnableBreakpoint_Click( object sender, EventArgs e )
        {

            Debug.WriteLine( "Enable" );
            if ( lvCode.SelectedItems.Count == 0 )
            {
                return;
            }
            var item = lvCode.SelectedItems[ 0 ];
            var addr = PipeConvert.BigEnd2I( item.SubItems[ 2 ].Text.Substring( 2 ) );

            Debug.WriteLine( "" );
            Debug.WriteLine( addr );


            ArrayList bp = Pipeline.Breakpoints;

            if ( bp.Contains( addr ) )
            {
                return;
            }

            bp.Add( addr );
            item.SubItems[ 0 ].Text = "-";
            if ( bp.Count >= 2 ) bp.Sort( );

            //debug
            Debug.WriteLine( "Enable" );
            foreach ( int bpaddr in bp )
            {
                Debug.Write( PipeConvert.LitEnd2S( bpaddr ) );
            }
            Debug.WriteLine( "" );
            foreach ( int bpaddr in Pipeline.Breakpoints )
            {
                Debug.Write( PipeConvert.LitEnd2S( bpaddr ) );
            }
        }
    }
}
