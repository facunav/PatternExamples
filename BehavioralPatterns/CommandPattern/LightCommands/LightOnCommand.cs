namespace BehavioralPatterns.CommandPattern.LightCommands
{
    public class LightOnCommand : Command
    {
        Light Light;

        // The constructor is passed the light it 
        // is going to control. 
        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }
    }
}
