using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDragonsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int diceRollAttack(Item item)
        {
            Random diceRoll = new Random();
            switch(item.Die)
            {
                case Die.d4:
                    return diceRoll.Next(1, 5);
                case Die.d4x2:
                    return diceRoll.Next(1, 5) + diceRoll.Next(1, 5);
                case Die.d4x3:
                    return diceRoll.Next(1, 5) + diceRoll.Next(1, 5) + diceRoll.Next(1, 5);
                case Die.d6:
                    return diceRoll.Next(1, 7);
                case Die.d6x2:
                    return diceRoll.Next(1, 7) + diceRoll.Next(1, 7);
                case Die.d6x3:
                    return diceRoll.Next(1, 7) + diceRoll.Next(1, 7) + diceRoll.Next(1, 7);
                case Die.d8:
                    return diceRoll.Next(1, 9);
                case Die.d8x2:
                    return diceRoll.Next(1, 9) + diceRoll.Next(1, 9);
                case Die.d10:
                    return diceRoll.Next(1, 11);
                case Die.d12:
                    return diceRoll.Next(1, 13);
            }
            return 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
