using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague collegue);
    }


    public class ConcreteMediator : Mediator { 
        public ConcreteColleague1 colleague1;
        public ConcreteColleague2 colleague2;

        public override void Send(string message, Colleague collegue)
        {
            if (colleague1 == collegue)
            {
                colleague2.Notify(message);
            }
            else {
                colleague1.Notify(message);
            }
        }
    }
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
            
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague 1 gets message: " + message);
        }
    }
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague 2 gets message: " + message);
        }
    }

    /*
     *Mediator defines and object that encapsulates how a set of objects interact.
     *Promotes loose coupling by keeping objects from referring to eachother 
     */
    public class MediatorSample
    {
        public void Run()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 concreteColleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 concreteColleague2 = new ConcreteColleague2(mediator);

            mediator.colleague1 = concreteColleague1;
            mediator.colleague2 = concreteColleague2;

            concreteColleague1.Send("How are you?");
            concreteColleague2.Send("Fine, thanks");
        }
    }
}
