using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuitarTuner
{
    public partial class TunerView : Form, ITunerView
    {
        private TunerController controller;
        private List<Label> stringLabels;

        public TunerView ()
        {
            InitializeComponent();
            stringLabels = new List<Label>();
            controller = new TunerController(this, new PitchDetector(8000));
            CorrelationChart.Series.Add("Line");
            CorrelationChart.Series["Line"].ChartType = SeriesChartType.Line;
        }

        public int DeviceNumber
        {
            get { return DevicesBox.SelectedIndex; }
            set { DevicesBox.SelectedIndex = value; }
        }

        public int TuningNumber
        {
            get { return this.TuningsListBox.SelectedIndex; }
            set { this.TuningsListBox.SelectedIndex = value; }
        }

        private void buttonStartMonitoring_Click (object sender, EventArgs e)
        {
            controller.StartDetecting();
            buttonStopMonitoring.Enabled = true;
            buttonStartMonitoring.Enabled = false;
        }

        private void buttonStopMonitoring_Click (object sender, EventArgs e)
        {
            controller.StopDetecting();
            RefreschChart();

            buttonStopMonitoring.Enabled = false;
            buttonStartMonitoring.Enabled = true;
        }

        public void SetController (TunerController CONTROLLER)
        {
            controller = CONTROLLER;
        }

        public void ChangeVolumeLevel (float VOLUME)
        {
            VolumeBar.Value = (int)VOLUME;
            VolumeLabel.Text = VOLUME.ToString();
        }

        public void ChangePitch (Pitch PITCH)
        {
            PitchLabel.Text = PITCH.Name;
            FrequencyLabel.Text = PITCH.Fundamental.ToString();
        }

        public void ChangeError (int ERROR_VAL)
        {
            ErrorBar.Value = ERROR_VAL;
            ErrorLabel.Text = ERROR_VAL.ToString();
        }

        public void SetDeviceList (IList<string> DEVICE_LIST)
        {
            foreach (var device in DEVICE_LIST)
            {
                DevicesBox.Items.Add(device);
            }
        }

        public void SetDevicesBoxEnable (bool STATE)
        {
            DevicesBox.Enabled = STATE;
        }

        public void DrawStringsLabels (Tuning TUNING)
        {
            float pxPerHz = (float)(PitchBar.Height - 22) / (PitchBar.Maximum - PitchBar.Minimum);
            int xPosition, yPosition;
            xPosition = PitchBar.Right - 20;

            foreach (var pitch in TUNING.StringsPitches)
            {
                var stringLabel = new Label
                {
                    Text = pitch.Name,
                    AutoSize = true,
                    Font = new Font("Arial", 8),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                stringLabels.Add(stringLabel);
                this.Controls.Add(stringLabel);
                float diff = (PitchBar.Maximum - pitch.Fundamental);
                yPosition = (int)(diff * pxPerHz) + PitchBar.Top + 10 - stringLabel.Height / 2;
                stringLabel.Location = new Point(xPosition, yPosition);
                stringLabel.BringToFront();
            }
        }

        public void SetTuningsListBox (Tuning TUNING)
        {
            foreach (var tuning in TUNING.TuningList)
            {
                this.TuningsListBox.Items.Add(tuning);
            }
            TuningsListBox.SelectedIndex = 0;
        }

        private void TuningsListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            controller.ChangeTuning(this.TuningsListBox.SelectedIndex);
        }

        public void ClearStringLabels ()
        {
            foreach (var lab in stringLabels)
            {
                lab.Hide();
                lab.Dispose();
            }
            stringLabels.Clear();
        }

        public void ChangePitchLabelColor (bool GREEN_OR_RED)
        {
            if (GREEN_OR_RED)
                PitchLabel.ForeColor = Color.Green;
            else
                PitchLabel.ForeColor = Color.Red;
        }

        public void ChangePitchBar (int FUNDAMENTAL)
        {
            if (FUNDAMENTAL < PitchBar.Minimum)
                PitchBar.Value = PitchBar.Minimum;
            else if (PitchBar.Maximum < FUNDAMENTAL)
                PitchBar.Value = PitchBar.Maximum;
            else
                PitchBar.Value = FUNDAMENTAL;
        }

        public void AddDataToChart (float[] DATA)
        {
            RefreschChart();
            double[] arr = new double[DATA.Length];
            for (int x = 0; x < DATA.Length; x++)
            {
                CorrelationChart.Series["Line"].Points.Add(new double[] { DATA[x], DATA[x] });
            }
        }

        public void RefreschChart ()
        {
            CorrelationChart.Series["Line"].Points.Clear();
        }
    }
}
