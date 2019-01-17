namespace ChainOfResponsibility
{
    public class ActorHiringRequest
    {
        public readonly string ActorName;
        public readonly string ActorSurname;
        public readonly double ActorSalary;

        public ActorHiringRequest(string actorName, string actorSurname, double actorSalary)
        {
            ActorName = actorName;
            ActorSurname = actorSurname;
            ActorSalary = actorSalary;
        }
    }
}
