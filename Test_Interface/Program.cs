namespace Test_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New Interface!");

            Drone npDrone = new Drone("Np430");
            npDrone.SendNotfication("Drone is on the way");
            Console.WriteLine($"Time for delivery is {npDrone.CalculateDeliveryTime(500)} hours");

            npDrone.StartTracking();

            npDrone.StopTracking();

            npDrone.Move();

            ITracable tracableDrone = (ITracable)npDrone;
   
            tracableDrone.StartTracking(); 
            tracableDrone.StopTracking();
           


        }
    }

    public abstract class DeliveryVehicle
    {
        public string VehicleName { get; set; }

        protected DeliveryVehicle(string VehicleName)
        {
            this.VehicleName = VehicleName;
        }

        public abstract double CalculateDeliveryTime(double distance);

        public virtual void SendNotfication (string message)
        {
            Console.WriteLine($"[{VehicleName}]: Notification: {message}");
        }
    }

    public class Drone : DeliveryVehicle, ITracable, IMove
    {
        public Drone(string VehicleName) : base(VehicleName)
        {
            
        }

        public override double CalculateDeliveryTime(double distance)
        {
            return distance / 50; // Speed 50 km per hour
        }

        public void Move()
        {
            Console.WriteLine("Wzhuh!!!");
        }

        public void StartTracking()
        {
            Console.WriteLine("Drone started tracking");
        }

        public void StopTracking()
        {
            Console.WriteLine("Drane stoped tracking");
        }
    }
}
