using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public class TrackBuilder
    {
        public Track Track { get; }

        public TrackBuilder((int, int)[] sectionInfos)
        {
            if (sectionInfos == null || sectionInfos.Length == 0)
                throw new ArgumentNullException("Section information cannot be null or empty.");

            List<Section> sections = new List<Section>();
            foreach (var (speed, length) in sectionInfos)
            {
                sections.Add(new Section(speed, length));
            }

            for (int i = 0; i < sections.Count - 1; i++)
            {
                sections[i].NextSection = sections[i + 1];
            }

            Track = new Track(sections);
        }
    }
}
