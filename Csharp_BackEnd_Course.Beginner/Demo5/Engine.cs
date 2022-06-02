 

namespace EngineLib
{ 
   public class Engine : IEngine
   {
      public string Name { get; }
      public int Capacity { get; }
      public double Power { get; }
      public EngineStatus Status { get; private set; }

      public Engine(string name, int capacity, double power)
      {
         Name = name;
         Capacity = capacity;
         Power = power;
         Status = EngineStatus.Stopped;
      }

      public void Start()
      {
         Status = EngineStatus.Started;
      }

      public void Stop()
      {
         Status = EngineStatus.Stopped;
      }
   }

    public enum EngineStatus { Stopped, Started }

    public interface IEngine
    {
        EngineStatus Status { get; }
        void Start();
        void Stop();
    }
}
