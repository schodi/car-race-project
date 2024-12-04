namespace CarProject.Logic;

public class Track(List<Section> trackList)
{
  private readonly List<Section> _trackList = trackList;

  public Section? StartSection { get => _trackList[ 0 ]; }
}
