using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSA_Skylanders_by_element
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            switch (index)
            {
                case 0:
                    label1.Text = "Double Trouble";
                    pictureBox1.Image = Properties.Resources.DoubleTrouble;
                    label2.Text = "Spyro";
                    pictureBox2.Image = Properties.Resources.Spyro;
                    label3.Text = "Voodood";
                    pictureBox3.Image = Properties.Resources.Voodood;
                    label4.Text = "Wrecking Ball";
                    pictureBox4.Image = Properties.Resources.WreckingBall;
                    return;
                case 1:
                    {
                        label1.Text = "Gill Grunt";
                        pictureBox1.Image = Properties.Resources.GillGrunt;
                        label2.Text = "Slam Bam";
                        pictureBox2.Image = Properties.Resources.SlamBam;
                        label3.Text = "Wham-Shell";
                        pictureBox3.Image = Properties.Resources.WhamShell;
                        label4.Text = "Zap";
                        pictureBox4.Image = Properties.Resources.Zap;
                        return;
                    }
                case 2:
                    label1.Text = "Boomer";
                    pictureBox1.Image = Properties.Resources.Boomer;
                    label2.Text = "Drill Sargeant";
                    pictureBox2.Image = Properties.Resources.DrillSergeant;
                    label3.Text = "Drobot";
                    pictureBox3.Image = Properties.Resources.Drobot;
                    label4.Text = "Trigger Happy";
                    pictureBox4.Image = Properties.Resources.TriggerHappy;
                    return;
                case 3:
                    {
                        label1.Text = "Camo";
                        pictureBox1.Image = Properties.Resources.Camo;
                        label2.Text = "Stealth Elf";
                        pictureBox2.Image = Properties.Resources.StealthElf;
                        label3.Text = "Stump Smash";
                        pictureBox3.Image = Properties.Resources.StumpSmash;
                        label4.Text = "Zook";
                        pictureBox4.Image = Properties.Resources.Zook;
                        return;
                    }
                case 4:
                    {
                        label1.Text = "Eruptor";
                        pictureBox1.Image = Properties.Resources.Eruptor;
                        label2.Text = "Flameslinger";
                        pictureBox2.Image = Properties.Resources.Flameslinger;
                        label3.Text = "Ignitor";
                        pictureBox3.Image = Properties.Resources.Ignitor;
                        label4.Text = "Sunburn";
                        pictureBox4.Image = Properties.Resources.Sunburn;
                        return;
                    }
                case 5:
                    {
                        label1.Text = "Bash";
                        pictureBox1.Image = Properties.Resources.Bash;
                        label2.Text = "Dino-Rang";
                        pictureBox2.Image = Properties.Resources.DinoRang;
                        label3.Text = "Prism Break";
                        pictureBox3.Image = Properties.Resources.PrismBreak;
                        label4.Text = "Terrafin";
                        pictureBox4.Image = Properties.Resources.Terrafin;
                        return;
                    }
                case 6:
                    {
                        label1.Text = "Lightning Rod";
                        pictureBox1.Image = Properties.Resources.LightningRod;
                        label2.Text = "Sonic Boom";
                        pictureBox2.Image = Properties.Resources.SonicBoom;
                        label3.Text = "Warnado";
                        pictureBox3.Image = Properties.Resources.Warnado;
                        label4.Text = "Whirlwind";
                        pictureBox4.Image = Properties.Resources.Whirlwind;
                        return;
                    }
                case 7:
                    {
                        label1.Text = "Chop Chop";
                        pictureBox1.Image= Properties.Resources.ChopChop;
                        label2.Text = "Cynder";
                        pictureBox2.Image = Properties.Resources.Cynder;
                        label3.Text = "Ghost Roaster";
                        pictureBox3.Image = Properties.Resources.GhostRoaster;
                        label4.Text = "Hex";
                        pictureBox4.Image = Properties.Resources.Hex;
                        return;
                    }
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Double Trouble")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.doubleTroubleCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Gill Grunt")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.gillGruntCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Boomer")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.boomerCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Camo")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.camoCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Eruptor")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.eruptorCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Bash")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.bashCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Lightning Rod")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.lightningRodCatchphrase);
                player.Play();
            }
            else if (label1.Text == "Chop Chop")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.chopChopCatchphrase);
                player.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Spyro")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.spyroCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Slam Bam")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.slamBamCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Drill Sargeant")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.drillSargeantCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Stealth Elf")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.stealthElfCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Flameslinger")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.flameslingerCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Dino-Rang")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.dinoRangCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Sonic Boom")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.sonicBoomCatchphrase);
                player.Play();
            }
            else if (label2.Text == "Cynder")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.cynderCatchphrase);
                player.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Voodood")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.voodoodCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Wham-Shell")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.whamShellCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Drobot")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.drobotCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Stump Smash")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.stumpSmashCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Ignitor")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.ignitorCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Prism Break")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.prismBreakCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Warnado")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.warnadoCatchphrase);
                player.Play();
            }
            else if (label3.Text == "Ghost Roaster")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.ghostRoasterCatchphrase);
                player.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "Wrecking Ball")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.wreckingBallCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Zap")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.zapCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Trigger Happy")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.triggerHappyCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Zook")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.zookCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Sunburn")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.sunburnCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Terrafin")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.terrafinCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Whirlwind")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.whirlwindCatchphrase);
                player.Play();
            }
            else if (label4.Text == "Hex")
            {
                var player = new System.Media.SoundPlayer(Properties.Resources.hexCatchphrase);
                player.Play();
            }
        }
    }
}
