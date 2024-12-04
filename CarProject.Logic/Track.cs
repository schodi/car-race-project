namespace CarProject.Logic;

public class Track(List<Section> trackList)
{
  #region field
  private readonly List<Section> _trackList = trackList;
  #endregion

  #region properties
  public Section? StartSection { get => _trackList.FirstOrDefault(); }

  public int GetTotalLenght 
  {
    get
    {
      int result = 0;
      foreach (var section in _trackList)
        result += section.Length;
      return result;
    }
  }

  #endregion

}