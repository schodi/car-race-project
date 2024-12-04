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

    Section lastSection = null;

    foreach (var section in sectionInfos)
    {
      Section newSection = new(section.Item1 , section.Item2);

      if (allSections.Count > 0)
        lastSection.AddAfterMe(newSection);

      lastSection = newSection;

      allSections.Add(newSection);
    }

    _track = new Track(allSections);
  }
  #endregion

  #region property
  public Track? RaceTrack => _track;
  #endregion


}
