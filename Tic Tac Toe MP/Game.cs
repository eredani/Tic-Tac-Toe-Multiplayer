using System;
using System.Drawing;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;

namespace Tic_Tac_Toe_MP
{
    public partial class Game : Form
    {
        public Socket socket;
        public string User;
        public string ID;
        static string XorO = string.Empty;
        static Dictionary<string, string> Usernames = new Dictionary<string, string>();
        public Game(string Username)
        { 
            InitializeComponent();
            User = Username;
            socket = IO.Socket("http://eredani.com:333");
            socket.Emit("setName", User);
            this.Text = "Hello, " + User;
            iTalk_ThemeContainer1.Text = this.Text + " | Tic-Tac-Toe Multiplayer";
            socket.On("ID", (data) =>
            {
                ID = data.ToString();
            });
            socket.On("Reject", (data) => {
                MessageBox.Show(data.ToString());
             });
            socket.On("Update", (data) =>
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
                var json = JsonConvert.SerializeObject(data, Formatting.Indented); ;
                dynamic players = JsonConvert.DeserializeObject(json);
                dataGridView1.Rows.Clear();
                Usernames.Clear();
                foreach (var id in players)
                {
                    foreach(var player in id)
                    {
                        if (player.Status == true)
                        {
                            string[] row = new string[] { player["Name"], player["Score"], "True" };
                            dataGridView1.Rows.Add(row);
                        }
                        else
                        {
                            string[] row = new string[] { player["Name"], player["Score"], "False" };
                            dataGridView1.Rows.Add(row);
                        }
                        Usernames[player["Name"].ToString()] = Convert.ToString(player["ID"].ToString());
                    }
                }
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            });
            socket.On("StartGame", (data) =>
            {
                Console.WriteLine(data.ToString());
                dynamic option = JsonConvert.DeserializeObject(data.ToString());
                if (Convert.ToString(option["First"]) == User.ToString().Trim())
                {
                    XorO = option["Xor0"];
                    status_game.Text = "It's your turn.";
                    BlockChoice(false);
                }
                else
                {
                    
                    XorO = option["Second"];
                    status_game.Text = "It's opponent turn.";
                }
            });
            socket.On("Message", (data) =>
            {
                MessageBox.Show(data.ToString());
            });
            socket.On("InviteLobby", (data) =>
            {
                DialogResult dialogResult = MessageBox.Show(data.ToString(), "Join Game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    socket.Emit("Accept");
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                    socket.Emit("Reject");
                }
            });
            socket.On("Change", (data) =>
            {
                string opponentType = string.Empty;
                Color col;
                if (XorO == "X")
                {
                    opponentType = "O";
                    col = Color.Blue;
                }
                else
                {
                    opponentType = "X";
                    col = Color.Red;
                }
                foreach (Control action in panel1.Controls)
                {
                    if (action is Button)
                    {
                        if (action.Name == data.ToString())
                        {
                            action.Text = opponentType;
                            action.ForeColor = col;
                        }
                    }
                }
            });
            socket.On("Turn", () =>
            {
                BlockChoice(false);
                status_game.Text = "It's your turn.";
            });
            socket.On("Draw", (data) =>
            {
                status_game.Text = "The game ended equally.";
                New_Game.Visible = true;
            });
            socket.On("Winner", () =>
            {
                New_Game.Visible = true;
                status_game.Text = "You lose!";
            });
            socket.On("Left", () =>
            {
                BlockChoice(true);
                New_Game.Visible = true;
                foreach (Control action in panel1.Controls)
                {
                    if (action is Button)
                    {
                        action.Text = "";
                        action.BackColor = Color.White;
                    }
                }
                status_game.Text = "Your opponent was disconnected!";
            });
        }
        public void Disconect()
        {
            socket.Emit("disconnect");
        }
        public void WinnShow(Button bt1, Button bt2, Button bt3)
        {
            bt1.BackColor = Color.Green;
            bt2.BackColor = Color.Green;
            bt3.BackColor = Color.Green;
            BlockChoice(true);
            status_game.Text = "You won!";
            socket.Emit("SendWinner");
            New_Game.Visible = true;
        }
        public void EqualShow()
        {
            BlockChoice(true);
            socket.Emit("SendDraw");
            New_Game.Visible = true;
        }
        public bool CheckDraw()
        {
            if (!button1.Text.Equals("") && !button2.Text.Equals("") && !button3.Text.Equals("") &&
    !button4.Text.Equals("") && !button5.Text.Equals("") && !button6.Text.Equals("") && !button7.Text.Equals("") &&
    !button8.Text.Equals("") && !button9.Text.Equals(""))
            {
                EqualShow();
                return true;
            }
            return false;
        }
        public bool getTheWinner()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                WinnShow(button1, button2, button3); return true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                WinnShow(button4, button5, button6);
                return true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                WinnShow(button7, button8, button9);
                return true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                WinnShow(button1, button4, button7);
                return true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                WinnShow(button2, button5, button8);
                return true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                WinnShow(button3, button6, button9);
                return true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                WinnShow(button1, button5, button9);
                return true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                WinnShow(button3, button5, button7);
                return true;
            }

            return false;
        }
        public void Choice(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                socket.Emit("ChangeButton", btn.Name);
                if (XorO == "O")
                {
                    btn.Text = XorO;
                    btn.ForeColor = Color.Blue;
                    if (getTheWinner())
                    {
                        return;
                    }
                    else if(CheckDraw())
                    {
                        return;
                    }
                }
                else
                {
                    btn.Text = XorO;
                    btn.ForeColor = Color.Red;
                    if (getTheWinner())
                    {
                        return;
                    }
                    else if (CheckDraw())
                    {
                        return;
                    }
                }
                BlockChoice(true);
                socket.Emit("ChangeTurn");
                
                status_game.Text = "It's opponent turn.";
                Refresh();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(Choice);
                }
            }
            BlockChoice(true);
        }
        public void BlockChoice(bool status)
        {
            foreach (Control action in panel1.Controls)
            {
                if (action is Button)
                {
                    if (!status)
                        action.Enabled = true;
                    else
                        action.Enabled = false;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                socket.Emit("Invite", Usernames[name]);
            }
        }
        private void Ping_Tick(object sender, EventArgs e)
        {
            socket.Emit("Ping");
        }
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            socket.Emit("NewGame");
            status_game.Text = "";
            foreach (Control action in panel1.Controls)
            {
                if (action is Button)
                {
                        action.Text = "";
                        action.BackColor = Color.White;
                }
            }
            New_Game.Visible = false;
        }
    }
}