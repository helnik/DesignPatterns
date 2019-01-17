using System;

namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver NextOnCommand { get; private set; }

        public void SetNetOnCommand(Approver nextOnCommand) => NextOnCommand = nextOnCommand;
        
        public abstract bool GetApproval(ActorHiringRequest request);
    }

    public class Director : Approver
    {
        public override bool GetApproval(ActorHiringRequest request)
        {
            if (request.ActorSalary <= 10.000)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} approves the hiring of the well known actor {request.ActorName} {request.ActorSurname}");
                return true;
            }

            if (NextOnCommand != null)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} cannot approve such a salary will ask for the approve of {NextOnCommand.GetType().Name}");
                return NextOnCommand.GetApproval(request);
            }

            Console.WriteLine(
                $"As the highest authority {this.GetType().Name} does not approve the cocky expensive actor {request.ActorName} {request.ActorSurname}");
            return false;
        }
    }

    public class Producer : Approver
    {
        public override bool GetApproval(ActorHiringRequest request)
        {
            if (request.ActorSalary <= 50.000)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} approves the hiring of the well known actor {request.ActorName} {request.ActorSurname}");
                return true;
            }

            if (NextOnCommand != null)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} cannot approve such a salary will ask for the approve of {NextOnCommand.GetType().Name}");
                return NextOnCommand.GetApproval(request);
            }

            Console.WriteLine(
                $"As the highest authority {this.GetType().Name} does not approve the cocky expensive actor {request.ActorName} {request.ActorSurname}");
            return false;
        }
    }

    public class StudioCEO : Approver
    {
        public override bool GetApproval(ActorHiringRequest request)
        {
            if (request.ActorSalary <= 100.000)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} approves the hiring of the well known actor {request.ActorName} {request.ActorSurname}");
                return true;
            }

            if (NextOnCommand != null)
            {
                Console.WriteLine(
                    $"{this.GetType().Name} cannot approve such a salary will ask for the approve of {NextOnCommand.GetType().Name}");
                return NextOnCommand.GetApproval(request);
            }

            Console.WriteLine(
                $"As the highest authority {this.GetType().Name} does not approve the cocky expensive actor {request.ActorName} {request.ActorSurname}");
            return false;

        }
    }
}
