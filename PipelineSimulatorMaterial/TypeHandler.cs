namespace PipelineSimulatorMaterial
{
    public class PipeConvert
    {
        public static byte Char2B( char c ) // convert a 1-bit hex number in char to byte 
        {
            switch ( c )
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'a':
                    return 10;
                case 'b':
                    return 11;
                case 'c':
                    return 12;
                case 'd':
                    return 13;
                case 'e':
                    return 14;
                case 'f':
                    return 15;
            }
            return 16;
        }

        public static byte Char2B( char c1, char c2 ) // convert a 2-bits hex number in char to byte
        {
            return (byte) ( ( Char2B( c1 ) << 4 ) + Char2B( c2 ) );
        }

        public static char Byte2C( byte b ) // convert a 1-bit hex number in byte to char
        {
            b &= 0xf;
            switch ( b )
            {
                case 0:
                    return '0';
                case 1:
                    return '1';
                case 2:
                    return '2';
                case 3:
                    return '3';
                case 4:
                    return '4';
                case 5:
                    return '5';
                case 6:
                    return '6';
                case 7:
                    return '7';
                case 8:
                    return '8';
                case 9:
                    return '9';
                case 10:
                    return 'a';
                case 11:
                    return 'b';
                case 12:
                    return 'c';
                case 13:
                    return 'd';
                case 14:
                    return 'e';
                case 15:
                    return 'f';
            }
            return 'f';
        }

        public static string Byte2S( byte b ) // convert a 1-bit hex number in byte to char with a prefix of "0x" 
        {
            return "0x" + Byte2C( b );
        }

        public static char[ ] Byte2C_Array( byte b ) // convert a 2-bits hex number in byte to char array
        {
            var c = new char[ 2 ];
            c[ 0 ] = Byte2C( (byte) ( b >> 4 ) );
            c[ 1 ] = Byte2C( (byte) ( b & 0xf ) );
            return c;
        }

        public static int BigEnd2I( string s ) // convert a n-bits hex number in big end ecoding string to int
        {
            var ret = 0;

            foreach ( var c in s )
            {
                ret <<= 4;
                ret += Char2B( c );
            }

            return ret;
        }

        public static int LitEnd2I( string s ) // convert a n-bits hex number in Lit end ecoding string to int
        {
            var len = s.Length;
            var ret = 0;

            var i = len - 1;
            while ( i > 0 )
            {
                ret <<= 8;
                ret += Char2B( s[ i - 1 ], s[ i ] );
                i -= 2;
            }
            if ( ( len & 1 ) == 1 )
            {
                ret <<= 4;
                ret += Char2B( s[ 0 ] );
            }
            return ret;
        }

        public static int LitEnd2I( byte[ ] b ) // convert a 8-bits hex number in Lit end ecoding bytes array to int
        {
            var ret = 0;
            ret = ret << 8 | b[ 3 ];
            ret = ret << 8 | b[ 2 ];
            ret = ret << 8 | b[ 1 ];
            ret = ret << 8 | b[ 0 ];
            return ret;
        }

        public static string LitEnd2S( byte[ ] b ) // convert a 8-bits hex number in Lit end ecoding bytes array to string with a prefix of "0x"
        {
            var ret = "0x";
            ret = ret + new string( Byte2C_Array( b[ 3 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 2 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 1 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 0 ] ) );
            return ret;

        }

        public static string LitEnd2S( int t ) // convert a int number to Lit end ecoding string
        {
            var b = new byte[ 4 ];
            b[ 3 ] = (byte) ( t >> 24 );
            t &= 0xffffff;
            b[ 2 ] = (byte) ( t >> 16 );
            t &= 0xffff;
            b[ 1 ] = (byte) ( t >> 8 );
            t &= 0xff;
            b[ 0 ] = (byte) ( t );
            return LitEnd2S( b );
        }

        public static string BigEnd2S( byte[ ] b )
        {
            var ret = "0x";
            ret = ret + new string( Byte2C_Array( b[ 0 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 1 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 2 ] ) );
            ret = ret + new string( Byte2C_Array( b[ 3 ] ) );
            return ret;
        }

        public static string BigEnd2S( int t ) // convert a int number to Big end ecoding string
        {
            var b = new byte[ 4 ];
            b[ 0 ] = (byte) ( t >> 24 );
            t &= 0xffffff;
            b[ 1 ] = (byte) ( t >> 16 );
            t &= 0xffff;
            b[ 2 ] = (byte) ( t >> 8 );
            t &= 0xff;
            b[ 3 ] = (byte) ( t );
            return BigEnd2S( b);
        }
    }

    public class GetString
    {
        public static string InstrMove( byte ifun ) // return instruction of JXX as string
        {
            switch ( ifun )
            {
                case 0:
                    return "rrmovl ";
                case 1:
                    return "cmovle ";
                case 2:
                    return "cmovl ";
                case 3:
                    return "cmove ";
                case 4:
                    return "cmovne ";
                case 5:
                    return "cmovge ";
                case 6:
                    return "cmovg ";
            }
            return "error";
        }

        public static string InstrOpl( byte ifun ) // return instruction of JXX as string
        {
            switch ( ifun )
            {
                case 0:
                    return "addl ";
                case 1:
                    return "subl ";
                case 2:
                    return "andl ";
                case 3:
                    return "xorl ";
            }
            return "error";
        }

        public static string InstrJmp( byte ifun ) // return instruction of JXX as string
        {
            switch ( ifun )
            {
                case 0:
                    return "jmp ";
                case 1:
                    return "jle ";
                case 2:
                    return "jl ";
                case 3:
                    return "je ";
                case 4:
                    return "jne ";
                case 5:
                    return "jge ";
                case 6:
                    return "jg ";
            }
            return "error";
        }

        public static string Instr( byte icode, byte ifun ) // return instruction as string
        {
            switch ( icode )
            {
                case 0:
                    return "nop";
                case 1:
                    return "halt";
                case 2:
                    return InstrMove( ifun );
                case 3:
                    return "irmovl ";
                case 4:
                    return "rmmovl ";
                case 5:
                    return "mrmovl ";
                case 6:
                    return InstrOpl( ifun );
                case 7:
                    return InstrJmp( ifun );
                case 8:
                    return "call ";
                case 9:
                    return "ret";
                case 10:
                    return "pushl ";
                case 11:
                    return "popl ";
            }
            return "error";
        }

        public static string Register( byte register ) //return register name as string
        {
            switch ( register )
            {
                case 0:
                    return "%eax";
                case 1:
                    return "%ecx";
                case 2:
                    return "%edx";
                case 3:
                    return "%ebx";
                case 4:
                    return "%esp";
                case 5:
                    return "%ebp";
                case 6:
                    return "%esi";
                case 7:
                    return "%edi";
            }
            return "error";
        }

        public static string InstrOperand( byte icode, int addr ) // return instrucion operand as string
        {
            var rA_ = (byte) ( Pipeline.Memory[ addr + 1 ] / 16 );
            var rB_ = (byte) ( Pipeline.Memory[ addr + 1 ] % 16 );

            var valc_ = Pipeline.GetBytesArray( addr + 2 );
            var vald_ = Pipeline.GetBytesArray( addr + 1 ); // dest of JXX and CALL

            var rA = Register( rA_ );
            var rB = Register( rB_ );

            var valc = PipeConvert.LitEnd2I( valc_ ).ToString( );
            var vald = PipeConvert.LitEnd2S( vald_ );

            switch ( icode )
            {
                case 0:
                    return "";
                case 1:
                    return "";
                case 2:
                    return rA + ", " + rB;
                case 3:
                    return "$" + valc + ", " + rB;
                case 4:
                    return rA + ", " + "$" + valc + "(" + rB + ")";
                case 5:
                    return "$" + valc + "(" + rB + "), " + rA;
                case 6:
                    return rA + ", " + rB;
                case 7:
                    return vald;
                case 8:
                    return vald;
                case 9:
                    return "";
                case 10:
                    return rA;
                case 11:
                    return rA;
            }
            return "error";
        }
    }

    public class GetLength
    {
        public static int Instr( int icode )
        {
            icode &= 0xf;
            switch ( icode )
            {
                case 0:
                case 1:
                case 9:
                    return 1;

                case 2:
                case 6:  
                case 10: 
                case 11:
                    return 2;
              
                case 7:
                case 8:
                    return 5;

                case 3:
                case 4:
                case 5:
                    return 6;
            }
            return 1;
        }
    }

}