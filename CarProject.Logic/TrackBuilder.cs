namespace CarProject.Logic;

public class TrackBuilder
{
  #region field
  private readonly (int, int)[ ] _sectionInfos;

  private readonly Track? _track;

  public TrackBuilder((int, int)[ ] sectionInfos)
  {
    _sectionInfos = sectionInfos;
    List<Section> allSections = [ ];

    foreach (var section in _sectionInfos)
    {
      Section newSection = new(section.Item1 , section.Item2);
      allSections.Add(newSection);
    }

    int sectionNumber = 0;
    foreach (var section in allSections)
    {
      if (sectionNumber > 0)
        allSections[ sectionNumber - 1 ].AddAfterMe(allSections[ sectionNumber ]);
    
      sectionNumber++;
    }

    _track = new Track(allSections);
  }
  #endregion

  #region property
  public Track? Track => _track;
  #endregion


}
