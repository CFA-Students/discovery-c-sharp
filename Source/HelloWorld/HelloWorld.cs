// using System;
// using System.Windows.Forms;

// namespace morpionGUI {
//   public class Game {
//     public char[,] grid;
//     public char currentPlayer;

//     public Game() {
//       grid = new char[,] {{' ',' ',' '},
//                                 {' ',' ',' '},
//                                 {' ',' ',' '}};
//       currentPlayer = 'O';
//     }

//     public void changeCurrentPlayer() {
//       if (currentPlayer == 'O') {
//         currentPlayer = 'X';
//       } else {
//         currentPlayer = 'O';
//       }
//     }

//     public bool isWin() {
//       for (int i = 0; i < 3; i++) {
//         if (this.grid[i, 0] == this.grid[i, 1] && this.grid[i, 1] == this.grid[i, 2] && grid[i, 0] != ' ') {
//           return true;
//         }
//       }

//       for (int i = 0; i < 3; i++) {
//         if (this.grid[0, i] == this.grid[1, i] && this.grid[1, i] == this.grid[2, i] && grid[0, i] != ' ') {
//           return true;
//         }
//       }

//       if (this.grid[0, 0] == this.grid[1, 1] && this.grid[2, 2] == this.grid[1, 1] && grid[0, 0] != ' ') {
//         return true;
//       }

//       if (this.grid[0, 2] == this.grid[1, 1] && this.grid[2, 0] == this.grid[1, 1] && grid[0, 2] != ' ') {
//         return true;
//       }

//       return false;
//     }

//     public bool isNull() {
//       for (int i = 0; i < grid.GetLength(0); i++) {
//         for (int j = 0; j < grid.GetLength(1); j++) {
//           if (grid[i, j] == ' ') {
//             return false;
//           }
//         }
//       }
//       return true;
//     }
//   }

//   public partial class Form1 : Form {
//     private Game game;
//     public Form1() {
//       InitializeComponent();
//       game = new Game();
//     }

//     public void restartGame() {
//       for (int i = 0; i < 9; i++) {
//         tabCases[i].Text = "";
//       }
//       game = new Game();
//     }
//     private void onCaseClick(object sender, System.EventArgs e) {
//       Case caseSelected = (Case) sender;

//       if (caseSelected.Text.Equals("")) {
//         caseSelected.Text = game.currentPlayer + "";
//         int x = caseSelected.getCoord()[0];
//         int y = caseSelected.getCoord()[1];
//         game.grid[y, x] = game.currentPlayer;
//         if (game.isWin()) {
//           MessageBox.Show($"{game.currentPlayer} a gagné!");
//           restartGame();
//         } else if (game.isNull()) {
//           MessageBox.Show("Match null!!!");
//           restartGame();
//         } else {
//           game.changeCurrentPlayer();
//         }
//       }

//       /*MessageBox.Show($"coord: {caseSelected.getCoord()[0]}, {caseSelected.getCoord()[1]}",
//                   "numero "+caseSelected.number, 
//                   MessageBoxButtons.OK, MessageBoxIcon.Information);*/
//     }
//   }

//   partial class Form1 {
//     /// <summary>
//     ///  Required designer variable.
//     /// </summary>
//     private System.ComponentModel.IContainer components = null;

//     /// <summary>
//     ///  Clean up any resources being used.
//     /// </summary>
//     /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//     protected override void Dispose(bool disposing) {
//       if (disposing && (components != null)) {
//         components.Dispose();
//       }
//       base.Dispose(disposing);
//     }

//     #region Windows Form Designer generated code

//     /// <summary>
//     ///  Required method for Designer support - do not modify
//     ///  the contents of this method with the code editor.
//     /// </summary>

//     private Case[] tabCases = new Case[9];

//     private void InitializeComponent() {
//       this.components = new System.ComponentModel.Container();
//       this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//       this.ClientSize = new System.Drawing.Size(400, 400);
//       this.Text = "Morpion";

//       TableLayoutPanel tab = new TableLayoutPanel();
//       tab.RowCount = 3;
//       tab.ColumnCount = 3;
//       tab.Size = new System.Drawing.Size(400, 400);
//       for (int i = 0; i < 9; i++) {
//         tabCases[i] = new Case(i);
//         tabCases[i].Size = new System.Drawing.Size(100, 100);
//         tabCases[i].Click += new EventHandler(this.onCaseClick);
//         tab.Controls.Add(tabCases[i]);
//       }
//       this.Controls.Add(tab);
//     }

//     #endregion
//   }

//   class Case : Button {
//     public int number;

//     public Case(int n) : base() {
//       this.number = n;
//     }


//     public int[] getCoord() {
//       int[] coord = new int[2];
//       coord[0] = (this.number == 0 || this.number == 3 || this.number == 6) ? 0 :
//                   (this.number == 1 || this.number == 4 || this.number == 7) ? 1 : 2;
//       coord[1] = (this.number == 0 || this.number == 1 || this.number == 2) ? 0 :
//                   (this.number == 3 || this.number == 4 || this.number == 5) ? 1 : 2;

//       return coord;
//     }

//   }

//   static class Program {
//     /// <summary>
//     ///  The main entry point for the application.
//     /// </summary>
//     [STAThread]
//     static void Main() {
//       ApplicationConfiguration.Initialize();
//       Application.Run(new Form1());
//     }
//   }
// }
