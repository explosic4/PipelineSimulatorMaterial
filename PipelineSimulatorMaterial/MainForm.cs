using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PipelineSimulatorMaterial
{
    public partial class MainForm : MaterialForm
    {
        private static ListViewItem foundItem;

        private static int timer1Cnt;
        private static int timer2Cnt;
        private static int timer3Cnt;

        public MainForm( )
        {
            InitializeComponent( );
            InitializeListViewMemory( );
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage( this );
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme( Primary.Indigo500, Primary.Indigo700, Primary.Indigo100,
                Accent.Pink200, TextShade.WHITE );
            //materialSkinManager.ColorScheme = new ColorScheme( Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE );
        }

        private void InitializeListViewMemory( )
        {
            for ( var addr = 0; addr + 3 < 2049; addr += 4 )
            {
                var item = new ListViewItem( "" );
                item.SubItems.Add( "" );

                lvMemory.Items.Add( item );
            }
        }

        private void CodeDisplay( )
        {
            lvCode.Items.Clear( );
            lvCode.Update( );
            Pipeline.DisplayInstr( this );
            lvCode.EndUpdate( );
        }

        public void ProcessDisplay( )
        {
            if ( tabNavbar.SelectedTab != tpProcess )
            {
                return;
            }
            Pipeline.DisplayProcess( this );
        }

        public void MemoryDisplay( )
        {
            if ( tabNavbar.SelectedTab != tpMemory )
            {
                return;
            }

            MemoryDisplay( true );
        }

        public void MemoryDisplay( bool isImmediate )
        {
            if ( isImmediate == false )
            {
                return;
            }

            lvMemory.Update( );
            Pipeline.DisplyMemory( this );
            lvMemory.EndUpdate( );
        }

        public void InsertListViewCode( string[ ] data )
        {
            Debug.WriteLine( "insert lvcode" );

            //Add
            ListViewItem item = null;
            foreach ( var property in data )
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
            if ( item != null )
            {
                if ( item.SubItems[ 2 ].Text != "" )
                {
                    item.SubItems[ 1 ].Text = ( lvCode.Items.Count + 1 ).ToString( );
                }

                lvCode.Items.Add( item );
            }
        }

        public void EditListViewMemory( string[ ] data, int index )
        {
            lvMemory.Items[ index ].SubItems[ 0 ].Text = data[ 0 ];
            lvMemory.Items[ index ].SubItems[ 1 ].Text = data[ 1 ];
        }

        private void btnOpenInstrFile_Click( object sender, EventArgs e )
        {
            var dialog = new OpenFileDialog( );
            var info = new DirectoryInfo( Application.ExecutablePath );
            if ( info.Parent != null )
            {
                dialog.InitialDirectory = info.Parent.FullName;
            }
            dialog.Filter = @"所有文件(*.*)|*.*";
            if ( dialog.ShowDialog( ) == DialogResult.OK )
            {
                if ( Pipeline.IsRuning )
                {
                    Pipeline.StopRunning( );
                }
                Pipeline.Init( );

                var path = dialog.FileName;
                FileHandler.ReadInstrFile( path );

                CodeDisplay( );
                MemoryDisplay( true );
                tabNavbar.SelectTab( "tpCode" );
            }
        }

        private void btnOpenBinaryFile_Click( object sender, EventArgs e )
        {
            var dialog = new OpenFileDialog( );
            var info = new DirectoryInfo( Application.ExecutablePath );
            if ( info.Parent != null )
            {
                dialog.InitialDirectory = info.Parent.FullName;
            }
            dialog.Filter = @"所有文件(*.*)|*.*";
            if ( dialog.ShowDialog( ) == DialogResult.OK )
            {
                if ( Pipeline.IsRuning )
                {
                    Pipeline.StopRunning( );
                }
                Pipeline.Init( );

                var path = dialog.FileName;
                FileHandler.ReadBinaryFile( path );

                CodeDisplay( );
                MemoryDisplay( true );
                tabNavbar.SelectTab( "tpCode" );
            }
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


            timer_Start( false );
        }

        private void btnNextStep_Click( object sender, EventArgs e )
        {
            //btnPlay.Hide( );
            //btnNextStep.Hide( );
            //btnNextBreakpoint.Hide( );
            //btnReset.Hide( );
            //btnProcessOptions.Hide( );
            //btnStop.Show( );

            timer3.Interval = 1000;
            if ( rbtn1Hz.Checked )
            {
                timer3.Interval = 1000;
            }
            if ( rbtn5Hz.Checked )
            {
                timer3.Interval = 200;
            }
            if ( rbtn10Hz.Checked )
            {
                timer3.Interval = 100;
            }
            if ( rbtn50Hz.Checked )
            {
                timer3.Interval = 20;
            }

            if ( !Pipeline.IsRuning )
            {
                Pipeline.StartRuning( );
            }

            Pipeline.Step( this );
            ProcessDisplay( );
            MemoryDisplay( );
            timer3.Enabled = true;
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
            ProcessDisplay( );
            MemoryDisplay( );
            TabpageAnimation( );

            timer_Start( true );
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            if ( timer1.Enabled )
            {
                timer1.Stop( );
            }
            if ( timer2.Enabled )
            {
                timer2.Stop( );
            }
            btnStop.Hide( );
            btnPlay.Show( );
            btnNextStep.Show( );
            btnNextBreakpoint.Show( );
            btnReset.Show( );
            btnProcessOptions.Show( );
        }

        private void btnReset_Click( object sender, EventArgs e )
        {
            if ( Pipeline.IsRuning )
            {
                Pipeline.StopRunning( );
            }
            Pipeline.Init( );
            ProcessDisplay( );
            MemoryDisplay( );
            tabProcess.SelectTab( 0 );
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

        private void btnProcessOptionConfirm_Click( object sender, EventArgs e )
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

        public void ButtonDisplaySwitch( )
        {
            btnStop.Hide( );
            btnPlay.Show( );
            btnNextStep.Show( );
            btnNextBreakpoint.Show( );
            btnReset.Show( );
            btnProcessOptions.Show( );
        }

        private void timer_Start( bool breakpointEnable )
        {
            if ( breakpointEnable == false )
            {
                Debug.WriteLine( "time1 enable" );
                timer1Cnt = tabProcess.SelectedIndex;
                timer1.Enabled = true;
            }
            else
            {
                Debug.WriteLine( "time2 enable" );
                timer2Cnt = tabProcess.SelectedIndex;
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {

            timer1Cnt %= 5;
            if ( timer1Cnt == 0 )
            {
                Pipeline.Step( this );
                if ( timer1.Interval >= 200 )
                {
                  fcircle.Focus( );
                }
            }
            tabProcess.SelectTab( timer1Cnt );
            timer1Cnt++;
        }

        private void timer2_Tick( object sender, EventArgs e )
        {

            timer2Cnt %= 5;
            if ( timer2Cnt == 0 )
            {
                Pipeline.StepBreakPoint( this );
                if ( timer1.Interval >= 200 )
                {
                    fcircle.Focus( );
                }
            }
            tabProcess.SelectTab( timer2Cnt );
            timer2Cnt++;
        }

        private void timer3_Tick( object sender, EventArgs e )
        {

            if ( timer3Cnt == 5 )
            {
                timer3Cnt = 0;
                timer3.Enabled = false;
                return;
            }

            if ( timer3Cnt == 0 )
            {
                if ( timer3.Interval >= 200 )
                {
                    fcircle.Focus( );
                }
            }

            tabProcess.SelectTab( timer3Cnt );
            timer3Cnt++;
        }

        public void TabpageAnimation( )
        {
            if ( tabNavbar.SelectedTab != tpProcess )
            {
                return;
            }

            for ( var cnt = 0; cnt < 5; cnt ++ )
            {


                if ( cnt == 0 )
                {
                    Pipeline.Step( this );
                    if ( timer1.Interval >= 200 )
                    {
                        fcircle.Focus( );
                    }
                }

                tabProcess.SelectTab( cnt );
            }
        }

        private void mnuitDisableBreakpoint_Click( object sender, EventArgs e )
        {
            DisableBreakpoint( );
        }

        private void btnDisableBreakpoint_Click( object sender, EventArgs e )
        {
            DisableBreakpoint( );
        }

        private void DisableBreakpoint( )
        {
            Debug.WriteLine( "Disable" );

            if ( lvCode.SelectedItems.Count == 0 )
            {
                return;
            }
            var item = lvCode.SelectedItems[ 0 ];


            var addr = PipeConvert.BigEnd2I( item.SubItems[ 2 ].Text.Substring( 2 ) );

            var bp = Pipeline.Breakpoints;

            if ( !bp.Contains( addr ) )
            {
                return;
            }

            bp.Remove( addr );
            if ( bp.Count >= 2 )
            {
                bp.Sort( );
            }
            item.SubItems[ 0 ].Text = "";
        }

        private void mnuitEnableBreakpoint_Click( object sender, EventArgs e )
        {
            EnableBreakpoint( );
        }

        private void btnEnableBreakpoint_Click( object sender, EventArgs e )
        {
            EnableBreakpoint( );
        }

        private void EnableBreakpoint( )
        {
            Debug.WriteLine( "Enable" );
            if ( lvCode.SelectedItems.Count == 0 )
            {
                return;
            }
            var item = lvCode.SelectedItems[ 0 ];
            var addr = PipeConvert.BigEnd2I( item.SubItems[ 2 ].Text.Substring( 2 ) );

            Debug.WriteLine( addr );


            var bp = Pipeline.Breakpoints;

            if ( bp.Contains( addr ) )
            {
                return;
            }

            bp.Add( addr );
            item.SubItems[ 0 ].Text = @"-";
            if ( bp.Count >= 2 )
            {
                bp.Sort( );
            }

            Debug.Write( "bp:" );
            foreach ( var breakaddr in bp )
            {
                Debug.Write( breakaddr + " " );
            }
            Debug.WriteLine( "" );
        }

        private void mnuitSearch_Click( object sender, EventArgs e )
        {
            //textBox1.Focus(  );
            searchText.Focus( );
        }

        private void SearchFisrtText( )
        {
            if ( searchText.Text == "" )
            {
                return;
            }

            foundItem = lvCode.FindItemWithText( searchText.Text, true, 0, true );
            if ( foundItem != null )
            {
                lvCode.Update( );
                lvCode.TopItem = foundItem;
                foundItem.Selected = true;

                lvCode.EndUpdate( );
                pnlUnderLine.Show( );
            }
            else
            {
                pnlUnderLine.Hide( );
            }
        }

        private void SearchNextText( )
        {
            if ( foundItem == null || foundItem.Index == lvCode.Items.Count - 1 )
            {
                return;
            }

            foundItem = lvCode.FindItemWithText( searchText.Text, true, foundItem.Index + 1, true );
            if ( foundItem != null )
            {
                Debug.WriteLine( foundItem.SubItems[ 1 ].Text );

                lvCode.BeginUpdate( );
                //lvCode.Update( );
                lvCode.TopItem = foundItem;

                //lvCode.EnsureVisible( foundItem.Index );
                foundItem.Selected = true;

                lvCode.EndUpdate( );
                pnlUnderLine.Show( );
            }
        }

        private void searchText_TextChanged( object sender, EventArgs e )
        {
            SearchFisrtText( );
        }

        private void searchText_LostFocus( object sender, EventArgs e )
        {
            pnlUnderLine.Hide( );
            searchText.Text = "";
        }

        private void searchText_Keydown( object sender, KeyEventArgs e )
        {
            Debug.WriteLine( "key " + e.KeyValue );
            if ( e.KeyValue == 13 ) // press enter
            {
                SearchNextText( );
            }

            if ( e.KeyValue == 120 ) // press f9
            {
                Debug.WriteLine( "F9" );
                EnableBreakpoint( );
            }

            if ( e.KeyValue == 119 ) // press f8
            {
                Debug.WriteLine( "F8" );
                DisableBreakpoint( );
                Debug.WriteLine( "Focus" );
                searchText.Focus( );
            }
        }


    }
}