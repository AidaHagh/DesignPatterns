
namespace CommandPattern.Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // we can change command dynamically

         
            remoteControl.SetCommand(new LightOnCommand(light));
            remoteControl.ButtonWasPressed();

            remoteControl.SetCommand(new StereoOnWithCdCommand(stereo));
            remoteControl.ButtonWasPressed();

            remoteControl.SetCommand(new StereoOffCommand(stereo));
            remoteControl.ButtonWasPressed();

            remoteControl.SetCommand(new LightOffCommand(light));
            remoteControl.ButtonWasPressed();
        }
    }
}