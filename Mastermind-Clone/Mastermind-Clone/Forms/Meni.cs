﻿using Mastermind_Clone.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Mastermind_Clone.Forms {
    public partial class Meni : Form {
        public AudioPlayer Player { get; set; }
        public Panel Panel { get; set; }
        public Meni(Panel panel1, AudioPlayer player) {
            InitializeComponent();

            Player = player;
            Panel = panel1;
        }

        private void btnNewGame_Click(object sender, EventArgs e) {
            Game game = new Game(Panel, Player);
            game.TopLevel = false;
            Panel.Controls.Clear();
            Panel.Controls.Add(game);
            game.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e) {
            String instructions = File.ReadAllText("../../Instructions.txt");
            MessageBox.Show(instructions, "How to Play", MessageBoxButtons.OK);
        }

        private void btnExitGame_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
