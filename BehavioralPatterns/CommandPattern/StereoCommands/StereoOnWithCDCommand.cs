namespace BehavioralPatterns.CommandPattern.StereoCommands
{
    public class StereoOnWithCDCommand : Command
    {
        Stereo Stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume(11);
        }
    }
}
