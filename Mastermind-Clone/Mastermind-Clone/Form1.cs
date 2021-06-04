﻿using Mastermind_Clone.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_Clone {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            ChangeForm();
        }

        private void ChangeForm() {
            Game game = new Game();
            game.TopLevel = false;
            panel1.Controls.Add(game);
            game.Show();
        }
    }
}
