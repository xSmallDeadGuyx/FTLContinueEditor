using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FTLContinueEditor
{
    public struct CrewMemberOverview
    {
        public string race;
        public string name;
    }

    public struct CrewMember
    {
        public string name;
        public string race;

        public bool isDrone;
        public int health;

        public int x;
        public int y;
        public int room;
        public int roomTile;

        public int pilotingSkill;
        public int engineSkill;
        public int shieldSkill;
        public int weaponSkill;
        public int repairSkill;
        public int combatSkill;

        public int gender;

        public int repairsStat;
        public int killsStat;
        public int evasionsStat;
        public int jumpsStat;
        public int masteriesStat;
    }

    public partial class MainForm : Form
    {
        public string[] shipIDs = {
            "PLAYER_SHIP_HARD", "PLAYER_SHIP_HARD_2",
            "PLAYER_SHIP_STEALTH", "PLAYER_SHIP_STEALTH_2",
            "PLAYER_SHIP_MANTIS", "PLAYER_SHIP_MANTIS_2",
            "PLAYER_SHIP_CIRCLE", "PLAYER_SHIP_CIRCLE_2",
            "PLAYER_SHIP_FED", "PLAYER_SHIP_FED_2",
            "PLAYER_SHIP_JELLY", "PLAYER_SHIP_JELLY_2",
            "PLAYER_SHIP_ROCK", "PLAYER_SHIP_ROCK_2",
            "PLAYER_SHIP_ENERGY", "PLAYER_SHIP_ENERGY_2",
            "PLAYER_SHIP_CRYSTAL", "PLAYER_SHIP_CRYSTAL_2"
        };

        public string[] shipArtIDs = {
            "kestral", "kestral_2",
            "stealth", "stealth_2",
            "mantis_cruiser", "mantis_cruiser_2",
            "circle_cruiser", "circle_cruiser_2",
            "fed_cruiser", "fed_cruiser_2",
            "jelly_cruiser", "jelly_cruiser_2",
            "rock_cruiser", "rock_cruiser_2",
            "energy_cruiser", "energy_cruiser_2",
            "crystal_cruiser", "crystal_cruiser_2"
        };

        public string raceToHumanReadable(string race)
        {
            if (race == "energy") race = "zoltan";
            return race.Substring(0, 1).ToUpper() + race.Substring(1);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public int version;
        public int unknown1;
        public int shipsDefeated;
        public int jumpsInSector;
        public int scrapCollected;
        public int crewRecruited;
        public string shipDesignationName;
        public string shipDesignationID;
        public int unknown2;
        public int unknown3;
        public Dictionary<string, int> stats = new Dictionary<string,int>();
        public string shipID;
        public string shipName;
        public string shipArtID;
        public List<CrewMemberOverview> crewOverview = new List<CrewMemberOverview>();
        public int shipHull;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Stream stream = openFileDialog.OpenFile();
                FTLContinueReader reader = new FTLContinueReader(stream);

                version = reader.readInt();
                unknown1 = reader.readInt(); //unknown value
                
                //-----STATS-----
                shipsDefeated = reader.readInt();
                jumpsInSector = reader.readInt();
                scrapCollected = reader.readInt();
                crewRecruited = reader.readInt();

                //-----SHIP DESIGNATION-----
                shipDesignationName = reader.readString();
                shipDesignationID = reader.readString();
                unknown2 = reader.readInt(); //unknown value
                unknown3 = reader.readInt(); //unknown value

                //-----SCORE-----
                int num = reader.readInt();
                stats.Clear();
                for (int i = 0; i < num; i++)
                {
                    string name = reader.readString();
                    int value = reader.readInt();
                    stats.Add(name, value);
                    statsGrid.Rows.Add(name, value);
                    Console.WriteLine(name + ": " + value);
                }

                //-----SHIP-----
                shipID = reader.readString();
                for (int i = 0; i < shipIDs.Length; i++)
                    if (shipIDs[i] == shipID)
                        shipIDList.SelectedIndex = i;
                shipName = shipNameBox.Text = reader.readString();
                shipArtID = reader.readString();
                for (int i = 0; i < shipArtIDs.Length; i++)
                    if (shipArtIDs[i] == shipArtID)
                        shipArtList.SelectedIndex = i;
                matchArtCheckbox.Checked = shipArtList.SelectedIndex == shipIDList.SelectedIndex;
            
                //-----CREW OVERVIEW-----
                num = reader.readInt();
                crewOverview.Clear();
                for (int i = 0; i < num; i++)
                {
                    CrewMemberOverview c = new CrewMemberOverview();
                    c.race = reader.readString();
                    c.name = reader.readString();
                    crewOverview.Add(c);
                    crewList.Items.Add(c.name + " (" + raceToHumanReadable(c.race) + ")");
                }

                //-----SHIP RESOURCES-----
                shipHull = shipHullBar.Value = reader.readInt();
                shipHullBox.Value = (decimal)shipHull;
            }
        }

        private void matchArtCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            shipArtList.Enabled = !matchArtCheckbox.Checked;
            if (matchArtCheckbox.Checked)
                shipArtList.SelectedIndex = shipIDList.SelectedIndex;
        }

        private void shipIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchArtCheckbox.Checked)
                shipArtList.SelectedIndex = shipIDList.SelectedIndex;
        }

        private void shipHullBox_ValueChanged(object sender, EventArgs e)
        {
            shipHullBar.Value = (int) shipHullBox.Value;
        }

        private void shipHullBar_Scroll(object sender, EventArgs e)
        {
            shipHullBox.Value = shipHullBar.Value;
        }
    }
}
