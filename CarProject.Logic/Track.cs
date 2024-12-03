using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public class Track
    {
        private List<Section> _trackList;
        
        public Track(List<Section> trackList)
        {
            this._trackList = trackList;
        }

        public Section? StartSection { get => _trackList[0]; }
    }
}
