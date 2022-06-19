using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP
{
    public class Subscriber
    {
        private string name;
        private Channel channel=new Channel();

        public Subscriber(string name)
        {
            this.name = name;
        }
        public void update()
        {
            Console.WriteLine("New Video Updated "+this.name);
        }
        public void subscribeChannel(Channel ch)
        {
            channel = ch;
        }
    }
    public class Channel
    {
        List<Subscriber> subscribers = new List<Subscriber>();
        private string title;
        public void subscribe(Subscriber sub)
        {
            subscribers.Add(sub);
        }

        public void unsubscribe(Subscriber sub)
        {
            subscribers.Remove(sub);
        }
        public void Notify()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.update();
            }
        }
        public void upload(string title)
        {
            this.title = title;
            Notify();
        }

    }
    internal class ObserverDP_Yt
    {
        public static void Youtube()
        {
            Channel codingWithAman=new Channel();
            Subscriber sub=new Subscriber("Aman");
            Subscriber sub2=new Subscriber("Raman");
            Subscriber sub3=new Subscriber("Hema");
            Subscriber sub4=new Subscriber("Priya");
            Subscriber sub5=new Subscriber("Dhiro");

            codingWithAman.subscribe(sub);
            codingWithAman.subscribe(sub2);
            codingWithAman.subscribe(sub3);
            codingWithAman.subscribe(sub4);
            codingWithAman.subscribe(sub5);

            sub.subscribeChannel(codingWithAman);
            sub2.subscribeChannel(codingWithAman);
            sub3.subscribeChannel(codingWithAman);
            sub4.subscribeChannel(codingWithAman);
            sub5.subscribeChannel(codingWithAman);

            codingWithAman.upload("Learn DP");
        }
    }
}
