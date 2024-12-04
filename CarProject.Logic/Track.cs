namespace CarProject.Logic;

public class Track(List<Section> trackList)
{
  #region field
  private readonly List<Section> _trackList = trackList;
  #endregion

  #region property
  public Section? StartSection { get => _trackList.FirstOrDefault(); }
  #endregion

}