using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pong
{
    public partial class EinstellungenDialog : Form
    {

        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return rueckgabe;
        }

        public EinstellungenDialog()
        {
            InitializeComponent();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }


        //-----------------------------------------------------------//
        //CSHP11D
        //-----------------------------------------------------------//
        // Die Eigenschaften 'SpielfeldFarbe' und 'BallLinieSchlaegerFarbe' dienen dazu,
        // die Farben für das Spielfeld und die Linien des Balls und Schlägers zu speichern.
        public Color SpielfeldFarbe { get; set; }
        public Color BallLinieSchlaegerFarbe { get; set; }
        
        private void ButtonBallSclaegerLinie_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BallLinieSchlaegerFarbe = colorDialog1.Color;

            VorLiniePanel.Refresh();
            VorLiniePanel.BackColor = BallLinieSchlaegerFarbe;

            VorSchalegerPanel.Refresh();
            VorSchalegerPanel.BackColor = BallLinieSchlaegerFarbe;

            VorBallPanel.Refresh();
            VorBallPanel.BackColor = BallLinieSchlaegerFarbe;

        }


        private void ButtonSpielfeld_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            SpielfeldFarbe = colorDialog2.Color;

            VorSpielfeldPanel.Refresh();
            VorSpielfeldPanel.BackColor = SpielfeldFarbe;

        }    
        
    }
}