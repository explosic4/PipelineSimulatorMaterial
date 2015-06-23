using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace PipelineSimulatorMaterial
{
    public class Pipeline
    {
        public enum Instrs
        {
            INOP,
            IHALT,
            IRRMOVL,
            IIRMOVL,
            IRMMOVL,
            IMRMOVL,
            IOPL,
            IJXX,
            ICALL,
            IRET,
            IPUSHL,
            IPOPL
        };

        public enum Stats
        {
            SAOK = 1,
            SADR = 2,
            SINS = 3,
            SHLT = 4
        };

        public static int F_stall,
            F_predPC,
            f_ifun,
            f_rA,
            f_rB,
            f_predPC,
            f_valC,
            f_valP,
            f_pc,
            f_needr,
            f_needvc,
            D_stall,
            D_bubble,
            D_ifun,
            D_rA,
            D_rB,
            D_valC,
            D_valP,
            d_ifun,
            d_rA,
            d_rB,
            d_valC,
            d_valP,
            d_valA,
            d_valB,
            d_srcA,
            d_srcB,
            d_dstE,
            d_dstM,
            d_rvalA,
            d_rvalB,
            E_bubble,
            E_ifun,
            E_valC,
            E_valA,
            E_valB,
            E_dstE,
            E_dstM,
            E_srcA,
            E_srcB,
            e_ifun,
            e_valC,
            e_valA,
            e_valB,
            e_dstE,
            e_dstM,
            e_srcA,
            e_srcB,
            e_Cnd,
            e_valE,
            e_alufun,
            e_aluA,
            e_aluB,
            e_setcc,
            M_bubble,
            M_Cnd,
            M_valE,
            M_valA,
            M_dstE,
            M_dstM,
            m_valE,
            m_valA,
            m_dstE,
            m_dstM,
            m_addr,
            m_valM,
            m_Memread,
            m_Memwrite,
            W_stall,
            W_valE,
            W_valM,
            W_dstE,
            W_dstM;

        public static int Cycle;
        public static int InstrFileLen = 0;
        public static string InstrString = "";
        public static int[ ] Registers = new int[ 9 ];
        public static int zf, sf, of;
        public static Stats f_stat, D_stat, d_stat, E_stat, e_stat, M_stat, m_stat, W_stat, w_stat;
        public static Instrs f_icode, D_icode, d_icode, E_icode, e_icode, M_icode, m_icode, W_icode;
        public static string f_code, D_code, d_code, E_code, e_code, M_code, m_code, W_code;
        private static readonly ArrayList InstrAddrs = new ArrayList( );
        public static ArrayList Breakpoints = new ArrayList( );
        public static byte[ ] Memory = new byte[ 2049 ];
        public static byte[ ] MemoryClone = new byte[ 2049 ];
        public static bool IsRuning;
        public static ArrayList InstrAddrs1
        {
            get { return InstrAddrs; }
        }

        public static void Init( )
        {
            Cycle = 0;
            zf = 0;
            sf = 0;
            of = 0;

            InstrAddrs.Clear( );

            for ( var i = 0; i < 9; i++ )
            {
                Registers[ i ] = 0;
            }

            F_predPC = 0;
            f_stat = Stats.SAOK;
            f_icode = Instrs.INOP;
            f_ifun = 0;
            f_rA = 8;
            f_rB = 8;
            f_predPC = 0;
            f_valC = 0;
            f_valP = 0;
            f_pc = 0;
            f_needr = 0;
            f_needvc = 0;

            D_stat = Stats.SAOK;
            D_icode = Instrs.INOP;
            D_ifun = 0;
            D_rA = 8;
            D_rB = 8;
            D_valC = 0;
            D_valP = 0;
            D_code = "nop";

            d_stat = Stats.SAOK;
            d_icode = Instrs.INOP;
            d_ifun = 0;
            d_rA = 8;
            d_rB = 8;
            d_valC = 0;
            d_valP = 0;
            d_valA = 0;
            d_valB = 0;
            d_srcA = 8;
            d_srcB = 8;
            d_dstE = 8;
            d_dstM = 8;
            d_rvalA = 0;
            d_rvalB = 0;

            E_stat = Stats.SAOK;
            E_icode = Instrs.INOP;
            E_ifun = 0;
            E_valC = 0;
            E_valA = 0;
            E_valB = 0;
            E_dstE = 8;
            E_dstM = 8;
            E_srcA = 8;
            E_srcB = 8;
            E_code = "nop";

            e_stat = Stats.SAOK;
            e_icode = Instrs.INOP;
            e_ifun = 0;
            e_valC = 0;
            e_valA = 0;
            e_valB = 0;
            e_dstE = 8;
            e_dstM = 8;
            e_srcA = 8;
            e_srcB = 8;
            e_Cnd = 0;
            e_valE = 0;
            e_alufun = 0;

            e_aluA = 0;
            e_aluB = 0;
            e_setcc = 0;

            M_stat = Stats.SAOK;
            M_icode = Instrs.INOP;
            M_Cnd = 0;
            M_valE = 0;
            M_valA = 0;
            M_dstE = 8;
            M_dstM = 8;
            M_code = "nop";

            m_stat = Stats.SAOK;
            m_icode = Instrs.INOP;
            m_valE = 0;
            m_valA = 0;
            m_dstE = 8;
            m_dstM = 8;
            m_addr = 0;
            m_valM = 0;
            m_Memread = 0;
            m_Memwrite = 0;
            W_stat = Stats.SAOK;

            W_icode = Instrs.INOP;
            W_valE = 0;
            W_valM = 0;
            W_dstE = 8;
            W_dstM = 8;
            W_code = "nop";
            w_stat = Stats.SAOK;
        }

        public static void Reset( )
        {
            Init( );
            Memory = (byte[ ]) MemoryClone.Clone( );
        }

        public static byte[ ] GetBytesArray( int addr ) //read a 4 bytes long bytes array from memory at adrress of addr
        {
            var ret = new byte[ 4 ];
            ret[ 0 ] = Memory[ addr ];
            ret[ 1 ] = Memory[ addr + 1 ];
            ret[ 2 ] = Memory[ addr + 2 ];
            ret[ 3 ] = Memory[ addr + 3 ];
            return ret;
        }

        public static void DisplayInstr( MainForm mainForm )
        {
            Debug.WriteLine( "display instr" );

            for ( var addr = 0; addr < InstrFileLen; )
            {
                var icode = (byte) ( Memory[ addr ] / 16 );
                var ifun = (byte) ( Memory[ addr ] % 16 );

                var instr = GetString.Instr( icode, ifun );
                var operand = GetString.InstrOperand( icode, addr );

                var len = GetLength.Instr( icode );
                var bina = "";
                for ( var i = 0; i < len; i++ )
                {
                    bina += new string( PipeConvert.Byte2C_Array( Memory[ addr + i ] ) );
                }
                var data = new[ ] { "", "", PipeConvert.BigEnd2S( addr ), bina, instr + " " + operand };
                mainForm.InsertListViewCode( data );

                foreach ( var s in data )
                {
                    Debug.Write( s );
                }
                Debug.WriteLine( "" );
                addr += bina.Length / 2;
            }
            var blank = new[ ] { "", "", "", "", "" };
            for ( var i = 0; i < 10; i++ )
            {
                mainForm.InsertListViewCode( blank );
            }
        }

        public static void DisplayProcess( MainForm mainForm )
        {
            //图表刷新

            mainForm.fpredPC.Text = "predpc    " + PipeConvert.LitEnd2S( F_predPC );
            mainForm.fcircle.Text = "cycle    " + Convert.ToString( Cycle );

            mainForm.dinstr.Text = "" + Convert.ToString( D_code );
            mainForm.dstat.Text = "state    " + Convert.ToString( D_stat );
            mainForm.dicode.Text = "icode    " + PipeConvert.Byte2S( (byte) ( D_icode ) );
            mainForm.difun.Text = "ifun    " + PipeConvert.Byte2S( (byte) ( D_ifun ) );
            mainForm.dra.Text = "ra    " + PipeConvert.Byte2S( (byte) ( D_rA ) );
            mainForm.drb.Text = "rb    " + PipeConvert.Byte2S( (byte) ( D_rB ) );
            mainForm.dvalc.Text = "valc    " + PipeConvert.LitEnd2S( D_valC );
            mainForm.dvalp.Text = "valp    " + PipeConvert.LitEnd2S( D_valP );


            mainForm.einstr.Text = "" + Convert.ToString( E_code );
            mainForm.estat.Text = "stat    " + Convert.ToString( E_stat );
            mainForm.eicode.Text = "icode    " + PipeConvert.Byte2S( (byte) ( E_icode ) );
            mainForm.eifun.Text = "ifun    " + PipeConvert.Byte2S( (byte) ( E_ifun ) );

            mainForm.evalc.Text = "valc    " + PipeConvert.LitEnd2S( E_valC );
            mainForm.evala.Text = "vala    " + PipeConvert.LitEnd2S( E_valA );
            mainForm.evalb.Text = "valb    " + PipeConvert.LitEnd2S( E_valB );
            mainForm.edste.Text = "dste    " + PipeConvert.Byte2S( (byte) ( E_dstE ) );
            mainForm.edstm.Text = "dstm    " + PipeConvert.Byte2S( (byte) ( E_dstM ) );
            mainForm.esrca.Text = "srca    " + PipeConvert.Byte2S( (byte) ( E_srcA ) );
            mainForm.esrcb.Text = "srcb    " + PipeConvert.Byte2S( (byte) ( E_srcB ) );


            mainForm.minstr.Text = "" + Convert.ToString( M_code );

            mainForm.mstat.Text = "state    " + Convert.ToString( M_stat );
            mainForm.mifun.Text = "cnd    " + Convert.ToString( M_Cnd );
            mainForm.micode.Text = "icode    " + PipeConvert.Byte2S( (byte) ( M_icode ) );
            mainForm.mvale.Text = "valE    " + PipeConvert.LitEnd2S( M_valE );
            mainForm.mvala.Text = "valM    " + PipeConvert.LitEnd2S( M_valA );
            mainForm.mdste.Text = "dstE    " + PipeConvert.Byte2S( (byte) ( M_dstE ) );
            mainForm.mdstm.Text = "dstM    " + PipeConvert.Byte2S( (byte) ( M_dstM ) );

            mainForm.mcc.Text = "ZF  " + PipeConvert.Byte2C( (byte) ( zf ) ) + "    SF  " +
                                PipeConvert.Byte2C( (byte) ( sf ) ) + "    OF  " + PipeConvert.Byte2C( (byte) ( of ) );

            mainForm.winstr.Text = "" + Convert.ToString( W_code );
            mainForm.wstat.Text = "state    " + Convert.ToString( W_stat );
            mainForm.wicode.Text = "icode    " + PipeConvert.Byte2S( (byte) ( W_icode ) );
            mainForm.wvale.Text = "valE    " + PipeConvert.LitEnd2S( W_valE );
            mainForm.wvalm.Text = "valM    " + PipeConvert.LitEnd2S( W_valM );
            mainForm.wdste.Text = "dstE    " + PipeConvert.Byte2S( (byte) ( W_dstE ) );
            mainForm.wdstm.Text = "dstM    " + PipeConvert.Byte2S( (byte) ( W_dstM ) );

            if ( mainForm.eax.Text != "eax    " + PipeConvert.LitEnd2S( Registers[ 0 ] ) )
            {
                // mainForm.Trigger(mainForm.eax,EventArgs.Empty);//相当于鼠标点击触发
                //mainForm.eax.OnClick( EventArgs.Empty );
            } //*/

            mainForm.eax.Text = "eax    " + PipeConvert.LitEnd2S( Registers[ 0 ] );
            mainForm.ecx.Text = "ecx    " + PipeConvert.LitEnd2S( Registers[ 1 ] );
            mainForm.edx.Text = "edx    " + PipeConvert.LitEnd2S( Registers[ 2 ] );
            mainForm.ebx.Text = "ebx    " + PipeConvert.LitEnd2S( Registers[ 3 ] );
            mainForm.esp.Text = "esp    " + PipeConvert.LitEnd2S( Registers[ 4 ] );
            mainForm.ebp.Text = "ebp    " + PipeConvert.LitEnd2S( Registers[ 5 ] );
            mainForm.esi.Text = "esi     " + PipeConvert.LitEnd2S( Registers[ 6 ] );
            mainForm.edi.Text = "edi     " + PipeConvert.LitEnd2S( Registers[ 7 ] );

            mainForm.fstall.Text = "";
            mainForm.dstall.Text = "";
            mainForm.estall.Text = "";
            mainForm.mstall.Text = "";
            mainForm.wstall.Text = "";

            mainForm.fstall.Hide( );
            mainForm.dstall.Hide( );
            mainForm.estall.Hide( );
            mainForm.mstall.Hide( );
            mainForm.wstall.Hide( );

            if ( F_stall == 1 )
            {
                mainForm.fstall.Text = "stall";
                mainForm.fstall.Show( );
            }
            if ( D_stall == 1 )
            {
                mainForm.dstall.Text = "stall";
                mainForm.dstall.Show( );
            }
            else if ( D_bubble == 1 )
            {
                mainForm.dstall.Text = "bubble";
                mainForm.dstall.Show( );
            }
            if ( E_bubble == 1 )
            {
                mainForm.estall.Text = "bubble";
                mainForm.estall.Show( );
            }
            if ( M_bubble == 1 )
            {
                mainForm.mstall.Text = "bubble";
                mainForm.mstall.Show( );
            }
            if ( W_stall == 1 )
            {
                mainForm.wstall.Text = "stall";
                mainForm.wstall.Show( );
            }
        }

        public static void DisplyMemory( MainForm mainForm )
        {
            var idx = 0;
            for ( var addr = 0; addr + 3 < 2049; addr += 4, idx++ )
            {
                var addr_ = PipeConvert.BigEnd2S( addr );
                var mem0 = new string( PipeConvert.Byte2C_Array( Memory[ addr ] ) );
                var mem1 = new string( PipeConvert.Byte2C_Array( Memory[ addr + 1 ] ) );
                var mem2 = new string( PipeConvert.Byte2C_Array( Memory[ addr + 2 ] ) );
                var mem3 = new string( PipeConvert.Byte2C_Array( Memory[ addr + 3 ] ) );
                var mem = mem0 + " " + mem1 + " " + mem2 + " " + mem3;
                
                string[ ] data = { addr_, mem };
                mainForm.EditListViewMemory( data , idx );
                //mainForm.lvMemory.Items[ idx ].SubItems[ 0 ].Text = addr_;
                //mainForm.lvMemory.Items[ idx ].SubItems[ 1 ].Text = mem;
            }
        }

        private static void WriteBack( )
        {
            //W
            W_stall = W_stat != Stats.SAOK ? 1 : 0;

            if ( W_stall != 0 )
            {
                return;
            }

            w_stat = W_stat;
            if ( W_dstE < 8 )
            {
                Registers[ W_dstE ] = W_valE;
            }
            if ( W_dstM < 8 )
            {
                Registers[ W_dstM ] = W_valM;
            }
        }

        private static void MemoryVisit( )
        {
            //M->W
            m_code = M_code;
            m_stat = M_stat;
            m_icode = M_icode;
            m_valE = M_valE;
            m_valA = M_valA;
            m_dstE = M_dstE;
            m_dstM = M_dstM;

            if ( m_stat != Stats.SAOK || m_icode == Instrs.INOP )
            {
                m_addr = 0;
                m_valM = 0;
                m_Memread = 0;
                m_Memwrite = 0;
                return;
            }

            switch ( m_icode )
            {
                case Instrs.IRMMOVL :
                case Instrs.IPUSHL :
                case Instrs.ICALL :
                case Instrs.IMRMOVL :
                    m_addr = m_valE;
                    break;

                case Instrs.IPOPL :
                case Instrs.IRET :
                    m_addr = m_valA;
                    break;
            }

            if ( m_icode == Instrs.IMRMOVL || m_icode == Instrs.IPOPL || m_icode == Instrs.IRET )
            {
                m_Memread = 1;
            }
            else
            {
                m_Memread = 0;
            }

            if ( M_icode == Instrs.IRMMOVL || m_icode == Instrs.IPUSHL || m_icode == Instrs.ICALL )
            {
                m_Memwrite = 1;
            }
            else
            {
                m_Memwrite = 0;
            }

            if ( m_Memread == 1 )
            {
                if ( m_addr >= 0 && m_addr < 2049 )
                {
                    m_valM = 0;
                    m_valM = ( m_valM << 8 ) | Memory[ m_addr ];
                    m_valM = ( m_valM << 8 ) | Memory[ m_addr + 1 ];
                    m_valM = ( m_valM << 8 ) | Memory[ m_addr + 2 ];
                    m_valM = ( m_valM << 8 ) | Memory[ m_addr + 3 ];
                }
                else
                {
                    m_stat = Stats.SADR;
                }
            }

            if ( m_Memwrite == 1 )
            {
                if ( m_addr >= 0 && m_addr < 2049 )
                {
                    Memory[ m_addr ] = Convert.ToByte( ( m_valA & 0xff000000 ) >> 24 );
                    Memory[ m_addr + 1 ] = Convert.ToByte( ( m_valA & 0x00ff0000 ) >> 16 );
                    Memory[ m_addr + 2 ] = Convert.ToByte( ( m_valA & 0x0000ff00 ) >> 8 );
                    Memory[ m_addr + 3 ] = Convert.ToByte( m_valA & 0x000000ff );
                }
                else
                {
                    m_stat = Stats.SADR;
                }
            }
        }

        private static void Execute( )
        {
            //E->M
            e_code = E_code;
            e_stat = E_stat;
            e_icode = E_icode;
            e_ifun = E_ifun;
            e_valC = E_valC;
            e_valA = E_valA;
            e_valB = E_valB;
            e_srcA = E_srcA;
            e_srcB = E_srcB;

            if ( e_stat != Stats.SAOK || e_icode == Instrs.INOP )
            {
                e_dstE = 8;
                e_dstM = 8;
                e_Cnd = 0;
                e_valE = 0;
                e_alufun = 0;
                e_aluA = 0;
                e_aluB = 0;
                e_setcc = 0;
                return;
            }

            e_alufun = e_icode == Instrs.IOPL ? e_ifun : 0;

            switch ( e_icode )
            {
                case Instrs.IRRMOVL :
                case Instrs.IOPL :
                    e_aluA = e_valA;
                    break;
                case Instrs.IIRMOVL :
                case Instrs.IRMMOVL :
                case Instrs.IMRMOVL :
                    e_aluA = e_valC;
                    break;
                case Instrs.ICALL :
                case Instrs.IPUSHL :
                    e_aluA = -4;
                    break;
                case Instrs.IRET :
                case Instrs.IPOPL :
                    e_aluA = 4;
                    break;
            }

            switch ( e_icode )
            {
                case Instrs.IRMMOVL :
                case Instrs.IMRMOVL :
                case Instrs.IOPL :
                case Instrs.ICALL :
                case Instrs.IPUSHL :
                case Instrs.IRET :
                case Instrs.IPOPL :
                    e_aluB = e_valB;
                    break;
                case Instrs.IRRMOVL :
                case Instrs.IIRMOVL :
                    e_aluB = 0;
                    break;
            }

            if ( W_stat != Stats.SAOK || m_stat != Stats.SAOK )
            {
                e_setcc = 0;
            }
            else if ( e_icode == Instrs.IOPL )
            {
                e_setcc = 1;
            }
            else
            {
                e_setcc = 0;
            }

            switch ( e_alufun )
            {
                case 0 :
                    e_valE = e_aluA + e_aluB;
                    break;
                case 1 :
                    e_valE = e_aluB - e_aluA;
                    break;
                case 2 :
                    e_valE = e_aluA & e_aluB;
                    break;
                case 3 :
                    e_valE = e_aluA ^ e_aluB;
                    break;
            }
            if ( e_setcc == 1 )
            {
                zf = 0;
                sf = 0;
                of = 0;
                if ( e_valE == 0 )
                {
                    zf = 1;
                }
                if ( e_valE < 0 )
                {
                    sf = 1;
                }
                switch ( e_alufun )
                {
                    case 0 :
                        if ( ( e_aluA < 0 ) == ( e_aluB < 0 ) && ( e_valE < 0 ) != ( e_aluA < 0 ) )
                        {
                            of = 1;
                        }
                        break;
                    case 1 :
                        if ( ( e_aluA < 0 ) == ( e_aluB > 0 ) &&
                             ( e_aluB < e_aluA && e_valE > 0 || e_aluB > e_aluA && e_valE < 0 ) )
                        {
                            of = 1;
                        }
                        break;
                    case 2 :
                        break;
                    case 3 :
                        break;
                }
            }
            if ( e_icode == Instrs.IJXX || e_icode == Instrs.IRRMOVL )
            {
                switch ( e_ifun )
                {
                    case 0 :
                        e_Cnd = 1;
                        break;
                    case 1 :
                        e_Cnd = ( sf ^ of ) | zf;
                        break;
                    case 2 :
                        e_Cnd = sf ^ of;
                        break;
                    case 3 :
                        e_Cnd = zf;
                        break;
                    case 4 :
                        e_Cnd = 1 - zf;
                        break;
                    case 5 :
                        e_Cnd = 1 - ( sf ^ of );
                        break;
                    case 6 :
                        e_Cnd = ( 1 - ( sf ^ of ) ) & ( 1 - zf );
                        break;
                }
            }
            if ( e_Cnd == 1 || e_icode != Instrs.IRRMOVL )
            {
                e_dstE = E_dstE;
            }
            else
            {
                e_dstE = 8;
            }
            e_dstM = E_dstM;
        }

        private static void Decode( )
        {
            //D->E
            d_code = D_code;
            d_stat = D_stat;
            d_icode = D_icode;
            d_ifun = D_ifun;
            d_rA = D_rA;
            d_rB = D_rB;
            d_valC = D_valC;
            d_valP = D_valP;
            if ( d_stat != Stats.SAOK || d_icode == Instrs.INOP )
            {
                d_valA = 0;
                d_valB = 0;
                d_srcA = 8;
                d_srcB = 8;
                d_dstE = 8;
                d_dstM = 8;
                d_rvalA = 0;
                d_rvalB = 0;
                return;
            }

            switch ( d_icode )
            {
                case Instrs.IRRMOVL :
                case Instrs.IRMMOVL :
                case Instrs.IOPL :
                case Instrs.IPUSHL :
                    d_srcA = d_rA;
                    break;

                case Instrs.IPOPL :
                case Instrs.IRET :
                    d_srcA = 4;
                    break;

                default :
                    d_srcA = 8;
                    break;
            }

            if ( d_icode == Instrs.IOPL || d_icode == Instrs.IRMMOVL || d_icode == Instrs.IMRMOVL )
            {
                d_srcB = d_rB;
            }
            else if ( d_icode == Instrs.IPUSHL || d_icode == Instrs.IPOPL || d_icode == Instrs.ICALL ||
                      d_icode == Instrs.IRET )
            {
                d_srcB = 4;
            }
            else
            {
                d_srcB = 8;
            }

            if ( d_icode == Instrs.IRRMOVL || d_icode == Instrs.IIRMOVL || d_icode == Instrs.IOPL )
            {
                d_dstE = d_rB;
            }
            else if ( d_icode == Instrs.IPUSHL || d_icode == Instrs.IPOPL || d_icode == Instrs.ICALL ||
                      d_icode == Instrs.IRET )
            {
                d_dstE = 4;
            }
            else
            {
                d_dstE = 8;
            }

            if ( d_icode == Instrs.IMRMOVL || d_icode == Instrs.IPOPL )
            {
                d_dstM = d_rA;
            }
            else
            {
                d_dstM = 8;
            }

            d_rvalA = Registers[ d_srcA ];
            d_rvalB = Registers[ d_srcB ];

            if ( d_icode == Instrs.ICALL || d_icode == Instrs.IJXX )
            {
                d_valA = d_valP;
            }
            else if ( d_srcA == e_dstE )
            {
                d_valA = e_valE;
            }
            else if ( d_srcA == M_dstM )
            {
                d_valA = m_valM;
            }
            else if ( d_srcA == M_dstE )
            {
                d_valA = M_valE;
            }
            else if ( d_srcA == W_dstM )
            {
                d_valA = W_valM;
            }
            else if ( d_srcA == W_dstE )
            {
                d_valA = W_valE;
            }
            else
            {
                d_valA = d_rvalA;
            }

            if ( d_srcB == e_dstE )
            {
                d_valB = e_valE;
            }
            else if ( d_srcB == M_dstM )
            {
                d_valB = m_valM;
            }
            else if ( d_srcB == M_dstE )
            {
                d_valB = M_valE;
            }
            else if ( d_srcB == W_dstM )
            {
                d_valB = W_valM;
            }
            else if ( d_srcB == W_dstE )
            {
                d_valB = W_valE;
            }
            else
            {
                d_valB = d_rvalB;
            }
        }

        private static void Fetch( )
        {
            //F->D

            // Getf_pc
            if ( M_icode == Instrs.IJXX && M_Cnd == 0 )
            {
                f_pc = M_valA;
            }
            else if ( W_icode == Instrs.IRET )
            {
                f_pc = W_valM;
            }
            else
            {
                f_pc = F_predPC;
            }

            // IsSADR
            if ( InstrAddrs.Count != 0 && !InstrAddrs.Contains( f_pc ) )
            {
                f_code = "address error";
                f_stat = Stats.SADR;
                f_icode = Instrs.INOP;
                f_ifun = 0;
                f_rA = 8;
                f_rB = 8;
                f_predPC = 0;
                f_valC = 0;
                f_valP = 0;
                f_pc = 0;
                f_needr = 0;
                f_needvc = 0;
                return;
            }

            var addr = f_pc;
            var icode = (byte) ( Memory[ addr ] / 16 );
            var ifun = (byte) ( Memory[ addr ] % 16 );

            var instr = GetString.Instr( icode, ifun );
            var operand = GetString.InstrOperand( icode, addr );


            // IsSINS
            if ( instr.Equals( "error" ) || operand.Equals( "error" ) )
            {
                f_code = "instruction error";
                f_stat = Stats.SINS;
                f_icode = Instrs.INOP;
                f_ifun = 0;
                f_rA = 8;
                f_rB = 8;
                f_predPC = 0;
                f_valC = 0;
                f_valP = 0;
                f_pc = 0;
                f_needr = 0;
                f_needvc = 0;
                return;
            }

            // IsSHLT
            if ( icode == 1 )
            {
                f_code = "halt";
                f_stat = Stats.SHLT;
                f_icode = Instrs.IHALT;
                f_ifun = 0;
                f_rA = 8;
                f_rB = 8;
                f_predPC = 0;
                f_valC = 0;
                f_valP = 0;
                f_pc = 0;
                f_needr = 0;
                f_needvc = 0;
                return;
            }

            f_code = instr + " " + operand;
            f_stat = Stats.SAOK;
            f_icode = (Instrs) icode;
            f_ifun = ifun;

            var rA = (byte) ( Memory[ addr + 1 ] / 16 );
            var rB = (byte) ( Memory[ addr + 1 ] % 16 );

            var valc = GetBytesArray( addr + 2 );
            var vald = GetBytesArray( addr + 1 ); // dest of JXX and CALL


            if ( f_icode == Instrs.IRRMOVL || f_icode == Instrs.IOPL || f_icode == Instrs.IPUSHL ||
                 f_icode == Instrs.IPOPL || f_icode == Instrs.IIRMOVL || f_icode == Instrs.IRMMOVL ||
                 f_icode == Instrs.IMRMOVL )
            {
                f_needr = 1;
            }
            else
            {
                f_needr = 0;
            }

            if ( f_icode == Instrs.IIRMOVL || f_icode == Instrs.IRMMOVL || f_icode == Instrs.IMRMOVL ||
                 f_icode == Instrs.IJXX || f_icode == Instrs.ICALL )
            {
                f_needvc = 1;
            }
            else
            {
                f_needvc = 0;
            }

            if ( f_needr == 1 )
            {
                f_rA = rA;
                f_rB = rB;
            }
            else
            {
                f_rA = 8;
                f_rB = 8;
            }

            if ( f_needvc == 1 && f_needr == 1 )
            {
                f_valC = PipeConvert.LitEnd2I( valc );
            }
            else if ( f_needvc == 1 && f_needr == 0 )
            {
                f_valC = PipeConvert.LitEnd2I( vald );
            }
            else
            {
                f_valC = 0;
            }

            if ( f_needvc == 1 && f_needr == 1 )
            {
                f_valP = f_pc + 6;
            }
            else if ( f_needvc == 1 && f_needr == 0 )
            {
                f_valP = f_pc + 5;
            }
            else if ( f_needvc == 0 && f_needr == 1 )
            {
                f_valP = f_pc + 2;
            }
            else
            {
                f_valP = f_pc + 1;
            }


            if ( f_icode == Instrs.IJXX || f_icode == Instrs.ICALL )
            {
                f_predPC = f_valC;
            }
            else
            {
                f_predPC = f_valP;
            }
        }

        private static void Bubble( )
        {
            //Stall/Bubble处理
            if ( ( E_icode == Instrs.IMRMOVL || E_icode == Instrs.IPOPL ) && ( E_dstM == d_srcA || E_dstM == d_srcB ) )
            {
                D_stall = 1;
            }
            else
            {
                D_stall = 0;
            }

            if ( ( E_icode == Instrs.IMRMOVL || E_icode == Instrs.IPOPL ) && ( E_dstM == d_srcA || E_dstM == d_srcB ) ||
                 ( D_icode == Instrs.IRET || E_icode == Instrs.IRET || M_icode == Instrs.IRET ) )
            {
                F_stall = 1;
            }
            else
            {
                F_stall = 0;
            }

            if ( m_stat != Stats.SAOK || W_stat != Stats.SAOK )
            {
                M_bubble = 1;
            }
            else
            {
                M_bubble = 0;
            }

            if ( ( E_icode == Instrs.IJXX && e_Cnd == 0 ) ||
                 ( E_icode == Instrs.IMRMOVL || E_icode == Instrs.IPOPL ) && ( E_dstM == d_srcA || E_dstM == d_srcB ) )
            {
                E_bubble = 1;
            }
            else
            {
                E_bubble = 0;
            }

            if ( ( E_icode == Instrs.IJXX && e_Cnd == 0 ) ||
                 !( ( E_icode == Instrs.IMRMOVL || E_icode == Instrs.IPOPL ) && ( E_dstM == d_srcA || E_dstM == d_srcB ) ) &&
                 ( D_icode == Instrs.IRET || E_icode == Instrs.IRET || M_icode == Instrs.IRET ) )
            {
                D_bubble = 1;
            }
            else
            {
                D_bubble = 0;
            }

            if ( D_stall == 1 )
            {
                d_code = E_code;
                d_stat = E_stat;
                d_icode = E_icode;
                d_ifun = E_ifun;
                d_valC = E_valC;
                d_valA = E_valA;
                d_valB = E_valB;
                d_dstE = E_dstE;
                d_dstM = E_dstM;
                d_srcA = E_srcA;
                d_srcB = E_srcB;
            }

            if ( F_stall == 1 )
            {
                f_code = D_code;
                f_stat = D_stat;
                f_icode = D_icode;
                f_ifun = D_ifun;
                f_rA = D_rA;
                f_rB = D_rB;
                f_valC = D_valC;
                f_valP = D_valP;
                f_predPC = F_predPC;
            }

            if ( M_bubble == 1 )
            {
                e_code = "bubble";
                e_stat = Stats.SAOK;
                e_icode = Instrs.INOP;
                e_ifun = 0;
                e_valC = 0;
                e_valA = 0;
                e_valB = 0;
                e_dstE = 8;
                e_dstM = 8;
                e_srcA = 8;
                e_srcB = 8;
                e_Cnd = 0;
                e_valE = 0;
                e_alufun = 0;
                e_aluA = 0;
                e_aluB = 0;
                e_setcc = 0;
            }

            if ( E_bubble == 1 )
            {
                d_code = "bubble";
                d_stat = Stats.SAOK;
                d_icode = Instrs.INOP;
                d_ifun = 0;
                d_rA = 8;
                d_rB = 8;
                d_valC = 0;
                d_valP = 0;
                d_valA = 0;
                d_valB = 0;
                d_srcA = 8;
                d_srcB = 8;
                d_dstE = 8;
                d_dstM = 8;
                d_rvalA = 0;
                d_rvalB = 0;
            }

            if ( D_bubble == 1 )
            {
                f_code = "bubble";
                f_stat = Stats.SAOK;
                f_icode = Instrs.INOP;
                f_ifun = 0;
                f_rA = 8;
                f_rB = 8;
                f_predPC = 0;
                f_valC = 0;
                f_valP = 0;
                f_pc = 0;
                f_needr = 0;
                f_needvc = 0;
            }
        }

        private static void UpdateRegisters( )
        {
            //传值到寄存器
            F_predPC = f_predPC;
            D_code = f_code;
            D_stat = f_stat;
            D_icode = f_icode;
            D_ifun = f_ifun;
            D_rA = f_rA;
            D_rB = f_rB;
            D_valC = f_valC;
            D_valP = f_valP;

            E_code = d_code;
            E_stat = d_stat;
            E_icode = d_icode;
            E_ifun = d_ifun;
            E_valC = d_valC;
            E_valA = d_valA;
            E_valB = d_valB;
            E_dstE = d_dstE;
            E_dstM = d_dstM;
            E_srcA = d_srcA;
            E_srcB = d_srcB;

            M_code = e_code;
            M_stat = e_stat;
            M_icode = e_icode;
            M_Cnd = e_Cnd;
            M_valE = e_valE;
            M_valA = e_valA;
            M_dstE = e_dstE;
            M_dstM = e_dstM;

            W_code = m_code;
            W_stat = m_stat;
            W_icode = m_icode;
            W_valE = m_valE;
            W_valM = m_valM;
            W_dstE = m_dstE;
            W_dstM = m_dstM;
        }

        public static void StartRuning( )
        {
            if ( IsRuning )
            {
                return;
            }

            IsRuning = true;
            Reset( );
            FileHandler.InitStreamWriter( "out.txt" );
        }

        public static void StopRunning( )
        {
            if ( !IsRuning )
            {
                return;
            }

            IsRuning = false;
            FileHandler.CloseStreamWriter( );
        }

        private static void Step( )
        {
            WriteBack( );
            MemoryVisit( );
            Execute( );
            Decode( );
            Fetch( );
            Bubble( );
            UpdateRegisters( );

            Cycle++;
            FileHandler.WrtiePipeInfo( Cycle );
        }

        public static void Step( MainForm mainform )
        {
            Step( );

            mainform.ProcessDisplay( );
            mainform.MemoryDisplay( );

            if ( w_stat == Stats.SAOK && W_icode == Instrs.IHALT )
            {
                //mainform.timer1.Stop( );
                mainform.timer1.Enabled = false;
                mainform.ButtonDisplaySwitch( );

                StopRunning( );

                MessageBox.Show( @"Done. Pipeling info saved as out.txt." );
            }
            else if ( W_code == "address error" )
            {
                //mainform.timer1.Stop( );
                mainform.timer1.Enabled = false;
                mainform.ButtonDisplaySwitch( );
                StopRunning( );

                MessageBox.Show( @"Address error. Pipeling info saved as out.txt." );
            }
        }

        public static void StepBreakPoint( MainForm mainform )
        {
            WriteBack( );
            MemoryVisit( );
            Execute( );
            Decode( );
            Fetch( );
            Bubble( );

            Debug.WriteLine( " In stepBreakPoint breakpoints: " );
            foreach ( var breakaddr in Breakpoints )
            {
                Debug.WriteLine( breakaddr + " " );
            }
            Debug.WriteLine( f_pc );
            Debug.WriteLine( "" );
            if ( Breakpoints.Contains( f_pc ) )
            {
                //mainform.timer2.Stop( );
                mainform.timer2.Enabled = false;
                mainform.ButtonDisplaySwitch( );

                MessageBox.Show( @"Breakpoint." );
                return;
            }

            UpdateRegisters( );
            Cycle++;

            mainform.ProcessDisplay( );
            mainform.MemoryDisplay( );

            FileHandler.WrtiePipeInfo( Cycle );

            if ( w_stat == Stats.SAOK && W_icode == Instrs.IHALT )
            {
                //mainform.timer2.Stop( );
                mainform.timer2.Enabled = false;
                mainform.ButtonDisplaySwitch( );

                StopRunning( );

                MessageBox.Show( @"Done. Pipeling info saved as out.txt." );
            }
            else if ( W_code == "address error" )
            {
                //mainform.timer2.Stop( );
                mainform.timer2.Enabled = false;
                mainform.ButtonDisplaySwitch( );
                StopRunning( );

                MessageBox.Show( @"Address error. Pipeling info saved as out.txt." );
            }
        }
    }
}