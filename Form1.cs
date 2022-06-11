using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[] _grid;

        private string[] _tokens = new string[] { "X", "0" };

        public Form1()
        {
            InitializeComponent();
            InitalizeGameBoard();
        }

        private void InitalizeGameBoard()
        {
            _grid = new Button[]
            {
                button0, button1, button2,
                button3, button4, button5,
                button6, button7, button8
            };

            foreach(var button in _grid)
            {
                button.Text = "";
                button.Enabled = false;
            }
        }

        private void Toggle(bool enabled)
        {
            foreach(var button in _grid)
            {
                button.Enabled = enabled;
            }
        }
    }
}
