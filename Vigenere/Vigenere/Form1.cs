using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[,] Vig = new String[26, 26] { { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }, 
            { "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A" },
            { "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B" },
            { "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C" },
            { "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D" },
            { "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E" },
            { "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F" },
            { "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G" },
            { "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H" },
            { "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I" }, 
            { "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }, 
            { "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" },
            { "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" },
            { "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" },
            { "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" }, 
            { "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" }, 
            { "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" }, 
            { "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q" },
            { "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R" }, 
            { "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S" },
            { "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" }, 
            { "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U" },
            { "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V" },
            { "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W" }, 
            { "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X" },
            { "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y" } };



        private void btnCode_Click(object sender, EventArgs e)
        {
            String strTekst, strTekst1, strKey, strVersleuteld, strLetterT, strLetterK;
            Int32 intL1, intLK, intPos, intTeller;
            Int32 x, y;

            x = 0;
            y = 0;
            strVersleuteld = "";
            strTekst = "";
            strTekst1 = txt1.Text.ToUpper();
            strKey = txtSleutel.Text.ToUpper();
            intPos = 0;
            intL1 = strTekst1.Length;
            intLK = strKey.Length;

            while (intPos < intL1)
            {
                strLetterT = strTekst1.Substring(intPos, 1);
                if (strLetterT == " ")
                {
                    strLetterT = "";
                }
                intPos += 1;
                strTekst = strTekst + strLetterT;
            }
            //Removing space

            intPos = 0;
            intL1 = strTekst.Length;
            while (intL1 > intLK)
            {
                strKey = strKey + strKey.Substring(intPos, 1);
                intPos += 1;
                intLK = strKey.Length;
            }

            for (intTeller = 0; intTeller < intL1; intTeller++)
            {
                strLetterT = strTekst.Substring(intTeller, 1);
                strLetterK = strKey.Substring(intTeller, 1);

                switch (strLetterT)
                {
                    case  "A":
                        x = 0;
                        break;
                    case "B":
                        x = 1;
                        break;
                    case "C":
                        x = 2;
                        break;
                    case "D":
                        x = 3;
                        break;
                    case "E":
                        x = 4;
                        break;
                    case "F":
                        x = 5;
                        break;
                    case "G":
                        x = 6;
                        break;
                    case "H":
                        x = 7;
                        break;
                    case "I":
                        x = 8;
                        break;
                    case "J":
                        x = 9;
                        break;
                    case "K":
                        x = 10;
                        break;
                    case "L":
                        x = 11;
                        break;
                    case "M":
                        x = 12;
                        break;
                    case "N":
                        x = 13;
                        break;
                    case "O":
                        x = 14;
                        break;
                    case "P":
                        x = 15;
                        break;
                    case "Q":
                        x = 16;
                        break;
                    case "R":
                        x = 17;
                        break;
                    case "S":
                        x = 18;
                        break;
                    case "T":
                        x = 19;
                        break;
                    case "U":
                        x = 20;
                        break;
                    case "V":
                        x = 21;
                        break;
                    case "W":
                        x = 22;
                        break;
                    case "X":
                        x = 23;
                        break;
                    case "Y":
                        x = 24;
                        break;
                    case "Z":
                        x = 25;
                        break;

                }
                switch (strLetterK)
                {
                    case "A":
                        y = 0;
                        break;
                    case "B":
                        y = 1;
                        break;
                    case "C":
                        y = 2;
                        break;
                    case "D":
                        y = 3;
                        break;
                    case "E":
                        y = 4;
                        break;
                    case "F":
                        y = 5;
                        break;
                    case "G":
                        y = 6;
                        break;
                    case "H":
                        y = 7;
                        break;
                    case "I":
                        y = 8;
                        break;
                    case "J":
                        y = 9;
                        break;
                    case "K":
                        y = 10;
                        break;
                    case "L":
                        y = 11;
                        break;
                    case "M":
                        y = 12;
                        break;
                    case "N":
                        y = 13;
                        break;
                    case "O":
                        y= 14;
                        break;
                    case "P":
                        y = 15;
                        break;
                    case "Q":
                        y = 16;
                        break;
                    case "R":
                        y = 17;
                        break;
                    case "S":
                        y = 18;
                        break;
                    case "T":
                        y = 19;
                        break;
                    case "U":
                        y = 20;
                        break;
                    case "V":
                        y = 21;
                        break;
                    case "W":
                        y = 22;
                        break;
                    case "X":
                        y = 23;
                        break;
                    case "Y":
                        y= 24;
                        break;
                    case "Z":
                        y = 25;
                        break;

                }
                strVersleuteld = strVersleuteld + Vig[x,y];
            }

            txt2.Text = strVersleuteld;
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {

            string strKEY, strReversedCode, strLettre, strTekst, strLetterT, strLetterK, strMes;

            string strDecodedMessage, strCMessageLettre;

            int intY;

            int intLengthCode, intPos, intLengtTekst, intTeller,intIndexY;
            Int32 x, y;

            strTekst = txt1.Text;
            strKEY = txtSleutel.Text;
            strReversedCode = string.Empty;
            strLettre = "";
            strMes = txt2.Text;
            strDecodedMessage = "";

            intLengtTekst = strTekst.Length;
            intLengthCode = strKEY.Length;
            intPos = 0;

            x = 0;

            while (intLengtTekst > intLengthCode)
            {
                strLettre = strKEY.Substring(intPos, 1);
                strKEY = strKEY + strLettre;

                intPos++;
                intLengthCode = strKEY.Length;
            }
            //Creating code;

            strLettre = "";
            intPos = strKEY.Length;
            
            //Reversing Code;
            
            for (intTeller = 0; intTeller < intLengtTekst; intTeller++)
            {
                strLetterT = strMes.Substring(intTeller, 1);
                strLetterK = strKEY.Substring(intTeller, 1);
                
                switch (strLetterK.ToUpper())
                {
                    case "A":                    
                        x = 0;
                        break;
                    case "B":
                        x = 1;
                        break;
                    case "C":
                        x = 2;
                        break;
                    case "D":
                        x = 3;
                        break;
                    case "E":
                        x = 4;
                        break;
                    case "F":
                        x = 5;
                        break;
                    case "G":
                        x = 6;
                        break;
                    case "H":
                        x = 7;
                        break;
                    case "I":
                        x = 8;
                        break;
                    case "J":
                        x = 9;
                        break;
                    case "K":
                        x = 10;
                        break;
                    case "L":
                        x = 11;
                        break;
                    case "M":
                        x = 12;
                        break;
                    case "N":
                        x = 13;
                        break;
                    case "O":
                        x = 14;
                        break;
                    case "P":
                        x = 15;
                        break;
                    case "Q":
                        x = 16;
                        break;
                    case "R":
                        x = 17;
                        break;
                    case "S":
                        x = 18;
                        break;
                    case "T":
                        x = 19;
                        break;
                    case "U":
                        x = 20;
                        break;
                    case "V":
                        x = 21;
                        break;
                    case "W":
                        x = 22;
                        break;
                    case "X":
                        x = 23;
                        break;
                    case "Y":
                        x = 24;
                        break;
                    case "Z":
                        x = 25;
                        break;

                }

                for (int i = 0; i < 26; i++)
                {
                    if (Vig[x,i] == strLetterT)
                    {
                        intIndexY = i;
                        strDecodedMessage = strDecodedMessage + Vig[0, intIndexY];
                        break;
                    }
                }


            }            

            MessageBox.Show(strDecodedMessage);
        }
    }
}