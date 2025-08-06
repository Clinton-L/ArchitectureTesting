namespace ArchitectureTesting.Patterns.Adapter
{
    public class DvdPlayer : IDisc
    {
        private readonly StandardDvd _standardDvd;

        public DvdPlayer(StandardDvd dvd)
        {
            _standardDvd = dvd;
        }

        public string Playing() => _standardDvd.Play();
    }
}
