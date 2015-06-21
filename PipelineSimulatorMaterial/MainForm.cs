using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PipelineSimulatorMaterial
{
    public partial class MainForm : MaterialForm
    {
        private static ListViewItem foundItem;

        public MainForm( )
        {
            InitializeComponent( );

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage( this );
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme( Primary.Indigo500, Primary.Indigo700, Primary.Indigo100,
                Accent.Pink200, TextShade.WHITE );
            //materialSkinManager.ColorScheme = new ColorScheme( Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE );
        }

        private void BtnOpenInstrFile_Click( object sender, EventArgs e )
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

                lvCode_Display( );
                lvMemory_DisplayImmediate( );
                tabNavbar.SelectTab( "tpCode" );
            }
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
                item.SubItems[ 1 ].Text = ( lvCode.Items.Count + 1 ).ToString( );

                lvCode.Items.Add( item );
            }
        }

        public static bool Delay( int delayTime ) // seconds
        {
            var now = DateTime.Now;
            int s;
            do
            {
                var spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents( );
            } while ( s < delayTime );
            return true;
        }

        private void BtnOpenBinaryFile_Click( object sender, EventArgs e )
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

                lvCode_Display( );
                lvMemory_DisplayImmediate( );
                tabNavbar.SelectTab( "tpCode" );
            }
        }

        private void lvCode_Display( )
        {
            lvCode.Items.Clear( );
            lvCode.Update( );
            Pipeline.DisplayInstr( this );
            lvCode.EndUpdate( );
        }

        private void btnCodeOptions_Click( object sender, EventArgs e )
        {
            EnableBreakpoint_Click( sender, e );
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

        public void TabpageAnimation( )
        {
            if ( tabNavbar.SelectedTab != tpProcess )
            {
                return;
            }

            var index = tabProcess.SelectedIndex;
            index = ( index + 1 ) % 5;
            tabProcess.SelectTab( index );
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            Pipeline.Step( this );
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
            if ( tabNavbar.SelectedTab != tpProcess )
            {
                return;
            }
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
            lvMemory_Display( );
            tabProcess.SelectTab( 0 );
        }

        public void BtnChange( )
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
            lvMemory_Display( );
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
            lvMemory_Display( );
            TabpageAnimation( );

            timer2.Start( );
        }

        private void DisableBreakpoint_Click( object sender, EventArgs e )
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

        private void EnableBreakpoint_Click( object sender, EventArgs e )
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

            Debug.WriteLine( "" );
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
        }

        public void lvMemory_Display( )
        {
            if ( tabNavbar.SelectedTab != tpMemory )
            {
                return;
            }

            lvMemory_DisplayImmediate( );
        }

        public void lvMemory_DisplayImmediate( )
        {
            lvMemory.Items.Clear( );
            lvMemory.Update( );
            Pipeline.DisplyMemory( this );
            lvMemory.EndUpdate( );
        }

        public void InsertListViewMemory( string[ ] data )
        {
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
                lvMemory.Items.Add( item );
            }
        }

        private void mnuitSearch_Click( object sender, EventArgs e )
        {
            //textBox1.Focus(  );
            searchText.Focus( );
        }

        private void searchText_TextChanged( object sender, EventArgs e )
        {
            SearchFisrtText( );
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
                lvCode.BeginUpdate( );
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

        private void SearchNextText( )
        {
            if ( foundItem == null || foundItem.Index == lvCode.Items.Count - 1 )
            {
                return;
            }

            foundItem = lvCode.FindItemWithText( searchText.Text, true, foundItem.Index + 1, true );
            if ( foundItem != null )
            {
                lvCode.BeginUpdate( );
                lvCode.Update( );

                lvCode.TopItem = foundItem;
                foundItem.Selected = true;


                lvCode.EndUpdate( );
                pnlUnderLine.Show( );
            }
        }

        private void btnDisableBreakpoint_Click( object sender, EventArgs e )
        {
            DisableBreakpoint_Click( sender, e );
        }
    }
}