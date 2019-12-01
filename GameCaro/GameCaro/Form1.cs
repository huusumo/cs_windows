using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties

        ChessBoardManager ChessBoard;

        #endregion

        #region Initialize

        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, tbxPLayerName, pictureboxMark);
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            prgrbCoolDown.Maximum = Cons.CoolDownTime;
            prgrbCoolDown.Step = Cons.CoolDownStep;
            prgrbCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.CoolDownInterval;

            NewGame();
        }

        #endregion

        #region Methods

        private void EndGame()
        {
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            tmCoolDown.Stop();
            MessageBox.Show("END GAME!!!", "Notification");
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prgrbCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prgrbCoolDown.PerformStep();

            if (prgrbCoolDown.Value >= prgrbCoolDown.Maximum)
                EndGame();
        }

        private void NewGame()
        {
            prgrbCoolDown.Value = 0;
            tmCoolDown.Stop();

            undoToolStripMenuItem.Enabled = true;

            ChessBoard.DrawChessBoard();
        }

        private void Undo()
        {
            ChessBoard.Undo();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbxIP.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(tbxIP.Text))
                tbxIP.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        // Get IPv4 of network card in use
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        #endregion       
    }
}