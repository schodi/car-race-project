using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    // Klasse Section repräsentiert einen Straßenabschnitt mit Maximalgeschwindigkeit und Länge.
    public class Section
    {
        #region properties
        public int MaxSpeed { get; set; } // Maximalgeschwindigkeit des Abschnitts.
        public int Length { get; set; } // Länge des Abschnitts in Metern.
        public Section? NextSection { get; private set; }
        public Section? PreviousSection { get; private set; }
        #endregion properties

        #region constructors
        // Konstruktor für den Abschnitt, initialisiert Geschwindigkeit und Länge.
        public Section(int speed, int length)
        {
            MaxSpeed = speed;
            Length = length;
        }
        #endregion constructors

        public void AddAfterMe(Section section)
        {
            Section? tmp = NextSection;

            NextSection = section;

            section.NextSection = tmp;
        }

        public void AddBeforeMe(Section section)
        {
            PreviousSection = section;
        }
    }
}
