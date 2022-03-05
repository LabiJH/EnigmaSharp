using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSharp
{
    public partial class Form1 : Form
    {
        /* Deklaration & Initialisierung */
        /*                                A    B    C    D    E    F    G    H    I    J    K    L    M    N    O    P    Q    R    S    T    U    V    W    X    Y    Z*/
        string[] walze1 = new string[] { "E", "K", "M", "F", "L", "G", "D", "Q", "V", "Z", "N", "T", "O", "W", "Y", "H", "X", "U", "S", "P", "A", "I", "B", "R", "C", "J" };
        string[] walze2 = new string[] { "A", "J", "D", "K", "S", "I", "R", "U", "X", "B", "L", "H", "W", "T", "M", "C", "Q", "G", "Z", "N", "P", "Y", "F", "V", "O", "E" };
        string[] walze3 = new string[] { "B", "D", "F", "H", "J", "L", "C", "P", "R", "T", "X", "V", "Z", "N", "Y", "E", "I", "W", "G", "A", "K", "M", "U", "S", "Q", "O" };
        string[] walze4 = new string[] { "E", "S", "O", "V", "P", "Z", "J", "A", "Y", "Q", "U", "I", "R", "H", "X", "L", "N", "F", "T", "G", "K", "D", "C", "M", "W", "B" };
        string[] walze5 = new string[] { "V", "Z", "B", "R", "G", "I", "T", "Y", "U", "P", "S", "D", "N", "H", "L", "X", "A", "W", "M", "J", "Q", "O", "F", "E", "C", "K" };
        /*                               A    B    C    D    E    F    G    H    I    J    K    L    M    N    O    P    Q    R    S    T    U    V    W    X    Y    Z*/
        string[] UKW_A = new string[] { "E", "J", "M", "Z", "A", "L", "Y", "X", "V", "B", "W", "F", "C", "R", "Q", "U", "O", "N", "T", "S", "P", "I", "K", "H", "G", "D" };
        string[] UKW_B = new string[] { "Y", "R", "U", "H", "Q", "S", "L", "D", "P", "X", "N", "G", "O", "K", "M", "I", "E", "B", "F", "Z", "C", "W", "V", "J", "A", "T" };
        string[] UKW_C = new string[] { "F", "V", "P", "J", "I", "A", "O", "Y", "E", "D", "R", "Z", "X", "W", "G", "C", "T", "K", "U", "Q", "S", "B", "N", "M", "H", "L" };

        int indexBu1 = 0;
        int indexBu2 = 0;
        int indexBu3 = 0;
        int indexUKW = 0;

        int ringStell1 = 0;
        int ringStell2 = 0;
        int ringStell3 = 0;

        int walzPos1 = 0;
        int walzPos2 = 0;
        int walzPos3 = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void btWalze3P_Click(object sender, EventArgs e)
        {

        }

        private void btWalze2P_Click(object sender, EventArgs e)
        {

        }

        private void btWalze1P_Click(object sender, EventArgs e)
        {

        }

        private void btWalze3M_Click(object sender, EventArgs e)
        {

        }
    }
}
