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

        public int unknown;

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

    public struct ShipSystem
    {
        public int capacity;
        public int powerBars;
        public int damagedBars;
        public int ionizedBars;
        public int deionizationTicks;
        public int repairProgress;
        public int damageProgress;
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

        public string[] raceIDs = {
            "human",
            "engi",
            "energy",
            "slug",
            "rock",
            "mantis",
            "crystal"
        };

        public string[] systemNames = {
            "Shields",
            "Engines",
            "Oxygen",
            "Weapons",
            "Drone control",
            "Medbay",
            "Pilot",
            "Sensors",
            "Doors",
            "Teleporter",
            "Cloaking",
            "Artillery"
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
        public int fuel;
        public int droneParts;
        public int missiles;
        public int scrap;
        public List<CrewMember> crewMembers = new List<CrewMember>();
        public int powerCapacity;
        public List<ShipSystem> systems = new List<ShipSystem>();

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
                }

                //-----SHIP RESOURCES-----
                shipHull = shipHullBar.Value = reader.readInt();
                shipHullBox.Value = (decimal)shipHull;
                fuel = reader.readInt();
                fuelBox.Value = (decimal)fuel;
                droneParts = reader.readInt();
                dronePartsBox.Value = (decimal)droneParts;
                missiles = reader.readInt();
                missilesBox.Value = (decimal)missiles;
                scrap = reader.readInt();
                scrapBox.Value = (decimal)scrap;

                //-----CREW MEMBERS-----
                num = reader.readInt();
                crewMembers.Clear();
                for (int i = 0; i < num; i++)
                {
                    CrewMember c = new CrewMember();
                    c.name = reader.readString();
                    c.race = reader.readString();
                    c.isDrone = reader.readInt() == 1;
                    c.health = reader.readInt();
                    c.x = reader.readInt();
                    c.y = reader.readInt();
                    c.room = reader.readInt();
                    c.roomTile = reader.readInt();
                    c.unknown = reader.readInt();
                    c.pilotingSkill = reader.readInt();
                    c.engineSkill = reader.readInt();
                    c.shieldSkill = reader.readInt();
                    c.weaponSkill = reader.readInt();
                    c.repairSkill = reader.readInt();
                    c.combatSkill = reader.readInt();
                    c.gender = reader.readInt();
                    c.repairsStat = reader.readInt();
                    c.killsStat = reader.readInt();
                    c.evasionsStat = reader.readInt();
                    c.jumpsStat = reader.readInt();
                    c.masteriesStat = reader.readInt();
                    crewMembers.Add(c);
                    crewList.Items.Add(c.name + " (" + raceToHumanReadable(c.race) + ")");
                }

                crewList.SelectedIndex = 0;
                updateCrewInfo(crewMembers[0]);

                for (int i = 0; i < systemNames.Length; i++)
                {
                    ShipSystem s = new ShipSystem();
                    s.capacity = reader.readInt();
                    if (s.capacity > 0)
                    {
                        s.powerBars = reader.readInt();
                        s.damageProgress = reader.readInt();
                        s.ionizedBars = reader.readInt();
                        s.deionizationTicks = reader.readInt();
                        s.repairProgress = reader.readInt();
                        s.damageProgress = reader.readInt();
                    }
                    systems.Add(s);
                }

                byte[] unread = reader.Reader.ReadBytes((int) (reader.Reader.BaseStream.Length - reader.Reader.BaseStream.Position));
                for (int i = 0; i < unread.Length; i++)
                    unreadBox.AppendText(unread[i] + (char.IsLetterOrDigit((char) unread[i]) ? " -> " + (char) unread[i] : "") + "\n");
            }
        }

        private void updateCrewInfo(CrewMember c)
        {
            crewNameBox.Text = c.name;
            for (int i = 0; i < raceIDs.Length; i++)
                if (raceIDs[i] == c.race)
                    crewRaceList.SelectedIndex = i;
            crewIsDroneCheckbox.Checked = c.isDrone;

            crewHealthBox.Maximum = crewHealthBar.Maximum = c.race == "energy" ? 70 : c.race == "rock" ? 150 : c.race == "crystal" ? 125 : 100;
            crewHealthBar.Value = c.health;
            crewHealthBox.Value = (decimal)c.health;
        }

        private void crewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCrewInfo(crewMembers[crewList.SelectedIndex]);
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
            shipHullBar.Value = (int)shipHullBox.Value;
        }

        private void shipHullBar_Scroll(object sender, EventArgs e)
        {
            shipHullBox.Value = shipHullBar.Value;
        }

        private void crewHealthBox_ValueChanged(object sender, EventArgs e)
        {
            crewHealthBar.Value = (int)crewHealthBox.Value;
        }

        private void crewHealthBar_Scroll(object sender, EventArgs e)
        {
            crewHealthBox.Value = crewHealthBar.Value;
        }

        private void crewPilotingBox_ValueChanged(object sender, EventArgs e)
        {
            crewPilotingBar.Value = (int)crewPilotingBox.Value;
        }

        private void crewPilotingBar_Scroll(object sender, EventArgs e)
        {
            crewPilotingBox.Value = crewPilotingBar.Value;
        }

        private void crewEnginesBox_ValueChanged(object sender, EventArgs e)
        {
            crewEnginesBar.Value = (int)crewEnginesBox.Value;
        }

        private void crewEnginesBar_Scroll(object sender, EventArgs e)
        {
            crewEnginesBox.Value = crewEnginesBar.Value;
        }

        private void crewShieldsBox_ValueChanged(object sender, EventArgs e)
        {
            crewShieldsBar.Value = (int)crewShieldsBox.Value;
        }

        private void crewShieldsBar_Scroll(object sender, EventArgs e)
        {
            crewShieldsBox.Value = crewShieldsBar.Value;
        }

        private void crewWeaponsBox_ValueChanged(object sender, EventArgs e)
        {
            crewWeaponsBar.Value = (int)crewWeaponsBox.Value;
        }

        private void crewWeaponsBar_Scroll(object sender, EventArgs e)
        {
            crewWeaponsBox.Value = crewWeaponsBar.Value;
        }

        private void crewRepairBox_ValueChanged(object sender, EventArgs e)
        {
            crewRepairBar.Value = (int)crewRepairBox.Value;
        }

        private void crewRepairBar_Scroll(object sender, EventArgs e)
        {
            crewRepairBox.Value = crewRepairBar.Value;
        }

        private void crewCombatBox_ValueChanged(object sender, EventArgs e)
        {
            crewCombatBar.Value = (int)crewCombatBox.Value;
        }

        private void crewCombatBar_Scroll(object sender, EventArgs e)
        {
            crewCombatBox.Value = crewCombatBar.Value;
        }
    }
}
