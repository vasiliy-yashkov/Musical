using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarTuner
{
    /// <summary>
    /// Class representation of guitar tuning. Stores information about guitar strings pitches, and allows
    /// to choose tuning from few most popular guitar tunings.
    /// </summary>
    public class Tuning
    {
        string name;
        List<Pitch> stringsPitches;
        List<String> tuningList;

        public Tuning ()
        {
            stringsPitches = new List<Pitch>();
            tuningList = new List<string>
            {
                "Гитара: Классический строй - E",
                "Гитара: Опущенная 6 струна - Drop D",
                "Гитара: Опущенный - Eb half step",
                "Гитара: Опущенные 6 и 1 струны - D whole step",
                "Балалайка: Классический строй"
            };
        }

        public string Name { get { return name; } }
        public List<string> TuningList { get { return tuningList; } set { tuningList = value; } }
        public List<Pitch> StringsPitches { get { return stringsPitches; } set { stringsPitches = value; } }

        /// <summary>
        /// Gets tuning's name from list of possible tunings
        /// </summary>
        /// <param name="INDEX"></param>
        /// <returns></returns>
        public string GetTuningName (int INDEX)
        {
            return tuningList[INDEX];
        }

        /// <summary>
        /// Set current tuning from list of possible tunings
        /// </summary>
        /// <param name="INDEX"></param>
        public void SetTuning (int INDEX)
        {
            switch (INDEX)
            {
                case 0:
                    SetGuitarStandardTuning();
                    break;
                case 1:
                    SetGuitarDropDTuning();
                    break;
                case 2:
                    SetGuitarEbTuning();
                    break;
                case 3:
                    SetGuitarDTuning();
                    break;
                case 4:
                    SetBalalaikaStandartTuning();
                    break;
            }

        }
        /// <summary>
        /// Add new string's pitch to current tuning.
        /// </summary>
        /// <param name="PITCH_NAME">Name of pitch</param>
        /// <param name="PITCH_FUNDAMENTAL">Fundamental frequency of pitch</param>
        public void AddString (string PITCH_NAME, float PITCH_FUNDAMENTAL)
        {
            stringsPitches.Add(new GuitarTuner.Pitch(PITCH_FUNDAMENTAL, PITCH_NAME));
        }

        public void SetGuitarStandardTuning ()
        {
            if (name == "Standard E") return;

            stringsPitches.Clear();
            AddString("E6", 82.41f);
            AddString("A5", 110f);
            AddString("D4", 146.83f);
            AddString("G3", 196f);
            AddString("B2", 246.94f);
            AddString("E1", 329.63f);
            name = "Standard E";

        }

        public void SetGuitarDropDTuning ()
        {
            if (name == "Drop D") return;

            stringsPitches.Clear();
            AddString("D6", 71.35f);
            AddString("A5", 110f);
            AddString("D4", 146.83f);
            AddString("G3", 196f);
            AddString("B2", 246.94f);
            AddString("E1", 329.63f);
            name = "Drop D";
        }

        public void SetGuitarEbTuning ()
        {
            if (name == "Eb - half step") return;

            stringsPitches.Clear();
            AddString("Eb6", 77.8f);
            AddString("Ab5", 103.8f);
            AddString("Db4", 138.6f);
            AddString("Gb3", 185f);
            AddString("Bb2", 233.1f);
            AddString("Eb1", 311.1f);
            name = "Eb half step";
        }

        public void SetGuitarDTuning ()
        {
            if (name == "D - whole step") return;

            stringsPitches.Clear();
            AddString("D6", 73.4f);
            AddString("G5", 98f);
            AddString("C4", 130.8f);
            AddString("F3", 174.6f);
            AddString("A2", 220f);
            AddString("D1", 293.7f);
            name = "D whole step";
        }

        public void SetBalalaikaStandartTuning()
        {
            if (name == "Balalaika Standard") return;

            stringsPitches.Clear();
            AddString("G3", 196f);
            AddString("B2", 246.94f);
            AddString("E1", 329.63f);

            name = "Balalaika Standard";
        }
    }
}
