using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PipelineSimulatorMaterial
{
    public class FileHandler
    {
        private static StreamWriter sw;

        public static void InitStreamWriter( string path )
        {
            sw = new StreamWriter( path );
        }

        public static void CloseStreamWriter( )
        {
            sw.Close(  );
        }

        public static void ReadInstrFile( string path )
        {
            using ( var stream = new FileStream( path, FileMode.Open, FileAccess.Read ) )
            {
                var sr = new StreamReader( stream );

                string input;
                while ( ( input = sr.ReadLine( ) ) != null )
                {
                    var regex = new Regex( @"0x([0-9a-zA-Z]+):" );
                    var match = regex.Match( input );
                    var addr_ = match.Groups[ 1 ].Value;
                    var addr = PipeConvert.BigEnd2I( addr_ );

                    regex = new Regex( @": (.*)\b.*\|" );
                    match = regex.Match( input );
                    var instr = match.Groups[ 1 ].Value;

                    if ( instr == "" )
                    {
                        continue;
                    }

                    Pipeline.InstrAddrs1.Add( addr );
                    Pipeline.InstrFileLen = addr + ( instr.Length / 2 );

                   

                    for ( var i = 0; i < instr.Length; i += 2 )
                    {
                        Pipeline.Memory[ addr++ ] = PipeConvert.Char2B( instr[ i ], instr[ i + 1 ] );
                    }
                }

                sr.Close( );
                stream.Close( );
                Pipeline.MemoryClone = (byte[ ]) Pipeline.Memory.Clone( );
            }


            for ( var i = 0; i < 10; i++ )
            {
                Debug.Write( Pipeline.Memory[ i ] );
            }
            Debug.WriteLine( "******************" );
            for ( var i = 0; i < 10; i++ )
            {
                Debug.Write( Pipeline.MemoryClone[ i ] );
            }
        }


        public static void ReadBinaryFile( string path )
        {   
            using( var stream = new FileStream(path, FileMode.Open, FileAccess.Read) )
            {
                var bytes = new byte[ stream.Length ];
                //char[] y86 = new char[fsr.Length * 4];
                stream.Read( bytes, 0, bytes.Length );
                Pipeline.InstrFileLen = bytes.Length;
                bytes.CopyTo( Pipeline.Memory, 0 );
                Pipeline.MemoryClone = (byte[ ]) Pipeline.Memory.Clone( );

                for ( var i = 0; i < 10; i++ )
                {
                    Debug.Write( Pipeline.Memory[i] );
                }
                Debug.WriteLine( "******************");
                for ( var i = 0; i < 10; i++ )
                {
                    Debug.Write( Pipeline.MemoryClone[ i ] );
                }

                stream.Close( );
            }
        }

        public static void WrtiePipeInfo( int cycle )
        {
            
            sw.WriteLine( "Cycle_" + System.Convert.ToString( cycle ) );
            sw.WriteLine( "--------------------" );
            sw.WriteLine( "FETCH:" );
            sw.WriteLine( "\tF_predPC      = " + PipeConvert.LitEnd2S( Pipeline.F_predPC ) );
            sw.WriteLine( "" );
            sw.WriteLine( "DECODE:" );
            sw.WriteLine( "\tD_icode       = " + PipeConvert.Byte2S( (byte) ( Pipeline.D_icode ) ) );
            sw.WriteLine( "\tD_ifun        = " + PipeConvert.Byte2S( (byte) ( Pipeline.D_ifun  ) ) );
            sw.WriteLine( "\tD_rA          = " + PipeConvert.Byte2S( (byte) ( Pipeline.D_rA ) ));
            sw.WriteLine( "\tD_rB          = " + PipeConvert.Byte2S( (byte) ( Pipeline.D_rB )));
            sw.WriteLine( "\tD_valC        = " + PipeConvert.LitEnd2S( Pipeline.D_valC ) );
            sw.WriteLine( "\tD_valP        = " + PipeConvert.LitEnd2S( Pipeline.D_valP ) );
            sw.WriteLine( "" );
            sw.WriteLine( "EXECUTE:" );
            sw.WriteLine( "\tE_icode       = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_icode )));
            sw.WriteLine( "\tE_ifun        = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_ifun)));
            sw.WriteLine( "\tE_valC        = " + PipeConvert.LitEnd2S( Pipeline.E_valC ) );
            sw.WriteLine( "\tE_valA        = " + PipeConvert.LitEnd2S( Pipeline.E_valA ) );
            sw.WriteLine( "\tE_valB        = " + PipeConvert.LitEnd2S( Pipeline.E_valB ) );
            sw.WriteLine( "\tE_dstE        = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_dstE )));
            sw.WriteLine( "\tE_dstM        = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_dstM )));
            sw.WriteLine( "\tE_srcA        = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_srcA)) );
            sw.WriteLine( "\tE_srcB        = " + PipeConvert.Byte2S( (byte) ( Pipeline.E_srcB )));
            sw.WriteLine( "" );
            sw.WriteLine( "MEMORY:" );
            sw.WriteLine( "\tM_icode       = " + PipeConvert.Byte2S( (byte) ( Pipeline.M_icode)) );
            sw.WriteLine( "\tM_Cnd         = " + PipeConvert.Byte2S( (byte) ( Pipeline.M_Cnd )));
            sw.WriteLine( "\tM_valE        = " + PipeConvert.LitEnd2S( Pipeline.M_valE ) );
            sw.WriteLine( "\tM_valA        = " + PipeConvert.LitEnd2S( Pipeline.M_valA ) );
            sw.WriteLine( "\tM_dstE        = " + PipeConvert.Byte2S( (byte) ( Pipeline.M_dstE )));
            sw.WriteLine( "\tM_dstM        = " + PipeConvert.Byte2S( (byte) ( Pipeline.M_dstM )));
            sw.WriteLine( "" );
            sw.WriteLine( "WRITE BACK:" );
            sw.WriteLine( "\tW_icode       = " + PipeConvert.Byte2S( (byte) ( Pipeline.W_icode )));
            sw.WriteLine( "\tW_valE        = " + PipeConvert.LitEnd2S( Pipeline.W_valE ) );
            sw.WriteLine( "\tW_valM        = " + PipeConvert.LitEnd2S( Pipeline.W_valM ) );
            sw.WriteLine( "\tW_dstE        = " + PipeConvert.Byte2S( (byte) ( Pipeline.W_dstE )));
            sw.WriteLine( "\tW_dstM        = " + PipeConvert.Byte2S( (byte) ( Pipeline.W_dstM )));
            sw.WriteLine( "" ); 
        }
    }
}