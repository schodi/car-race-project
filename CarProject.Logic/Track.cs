namespace CarProject.Logic;

public class Track
{
  #region field
  private readonly List<Section> _trackList;
  #endregion

  #region constructor
  public Track(List<Section>? trackList)
  {
    if (trackList == null || trackList.Count == 0)
      throw new ArgumentNullException(nameof(trackList));

    _trackList = trackList;
  }
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

  public int GetMaxSpeed
  {
    get
    {
      int result = 0;

      foreach (var section in _trackList)
        if (section.MaxSpeed > result)
          result = section.MaxSpeed;

      return result;
    }
  }

  #endregion

}