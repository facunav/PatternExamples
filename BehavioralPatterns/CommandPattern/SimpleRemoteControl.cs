namespace BehavioralPatterns.CommandPattern
{
    // A Simple remote control with one button 
    public class SimpleRemoteControl
    {
        Command Slot;  // only one button 

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(Command command)
        {
            // set the command the remote will 
            // execute 
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
