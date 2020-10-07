namespace BehavioralPatterns.CommandPattern.LightCommands
{
    public class LightOffCommand : Command
    {
        Light Light;

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }
    }
}
