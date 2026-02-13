using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public sealed class PracticeClass
    {
        private static PracticeClass practiceClass = null;
        private static readonly Object lockObj = new Object();
        private PracticeClass() { }

        public static PracticeClass GetInstance
        {
            get
            {
                if (practiceClass == null)
                {
                    lock (lockObj)
                    {
                        if (practiceClass == null)
                        {
                            practiceClass = new PracticeClass();
                        }
                    }
                }
                return practiceClass;
            }
        }
    }

    public sealed class PracticeLazySingleTonClass
    {
        private static readonly Lazy<PracticeLazySingleTonClass> practiceLazySingleTon = new Lazy<PracticeLazySingleTonClass>(() => new PracticeLazySingleTonClass());
        private PracticeLazySingleTonClass() { }
        public static PracticeLazySingleTonClass practiceLazySingleTonClass => practiceLazySingleTon.Value;

    }

    public abstract class AbstractClass
    {
        public abstract void AbstractMethod();
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual Method in Abstract Class");
        }

        public int nonAbstractMethod()
        {
            return int.MinValue;
        }
        public string NonVirtualMethod()
        {
            return "Non-Virtual Method in Abstract Class";
        }

    }

    public class DerivedClass : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract Method Implemented in Derived Class");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("Overridden Virtual Method in Derived Class");
        }
        public new string NonVirtualMethod()
        {
            return "Non-Virtual Method in Derived Class";
        }
        public int NonAbstractMethod()
        {
            return 90; // base.nonAbstractMethod();
        }
    }
}
