using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        public ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", name, observerState);
        }
    }

    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get { return subjectState; }    
            set { subjectState = value; }
        }
    }

    public class ObserverSample
    {
        public void Run()
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
