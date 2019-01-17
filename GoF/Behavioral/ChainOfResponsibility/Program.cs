using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //chain participants
            var director = new Director();
            var producer = new Producer();
            var studioCeo = new StudioCEO();

            //chain hierarchy
            director.SetNetOnCommand(producer);
            producer.SetNetOnCommand(studioCeo);

            //hire some
            var request = new ActorHiringRequest("Daniel", "Craig", 300.000);
            var isHired = director.GetApproval(request);
            if(isHired) Console.WriteLine($"Welcome on our brand new tv show {request.ActorName} {request.ActorSurname}!");
            Console.WriteLine();

            request = new ActorHiringRequest("Matt", "Smith", 100.000);
            isHired = director.GetApproval(request);
            if (isHired) Console.WriteLine($"Welcome on our brand new tv show {request.ActorName} {request.ActorSurname}!");
            Console.WriteLine();

            request = new ActorHiringRequest("Úrsula", "Corberó", 20.000);
            isHired = director.GetApproval(request);
            if (isHired) Console.WriteLine($"Welcome on our brand new tv show {request.ActorName} {request.ActorSurname}!");
            Console.WriteLine();

            request = new ActorHiringRequest("Kostas", "Gouzgkounis", 10.000);
            isHired = director.GetApproval(request);
            if (isHired) Console.WriteLine($"Welcome on our brand new tv show {request.ActorName} {request.ActorSurname}!");

            Console.Read();
        }
    }
}
