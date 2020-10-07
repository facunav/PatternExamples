namespace BehavioralPatterns.CommandPattern.StereoCommands
{
    public class StereoOffCommand : Command
    {
        Stereo Stereo;

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.Off();
        }
    }
}
