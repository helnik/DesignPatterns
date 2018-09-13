namespace DesignPatterns.Other.Creational.DependencyInjection
{
    /// <summary>
    /// the client, demonstrating constructor injection
    /// </summary>
    public class Television
    {
        private ITvEpisode constructorInjectedService;
        
        /// <summary>
        /// Constructor Injection
        /// </summary>
        /// <param name="tvEpisodeService"></param>
        public Television(ITvEpisode tvEpisodeService)
        {
            constructorInjectedService = tvEpisodeService;
        }

        public void OpenTv()
        {
            constructorInjectedService.Play();
        }
    }

    /// <summary>
    /// the client, demonstrating property injection
    /// </summary>
    public class TelevisionHD
    {
        private IRecorder recorder;
        public IRecorder Recorder { set { recorder = value; } }

        public void RecordShow()
        {
            recorder.Record();
        }
    }

    /// <summary>
    /// the client, demonstrating method injection
    /// Whole class does not need the dependency except one specific method
    /// </summary>
    public class TelevisionUHD
    {
        public void PlayKidsShow() { }
        public void PlayWomenShow() { }
        public void TvGuide() { }

        /// <summary>
        /// This and only this method needs the replay dependency
        /// </summary>
        /// <param name="replayer"></param>
        public void PlayFootballMatch(IReplayer replayer)
        {
            replayer.Replay();
        }
    }
}
