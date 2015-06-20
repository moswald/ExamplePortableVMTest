namespace ViewModels
{
    using System;
    using System.Reactive.Concurrency;
    using System.Reactive.Linq;
    using ReactiveUI;

    public class FooViewModel : ReactiveObject
    {
        public IObservable<long> SomeCount { get; set; } 

        public FooViewModel(IScheduler sched)
        {
            SomeCount = Observable.Interval(TimeSpan.FromSeconds(1), sched).Take(10);
        }
    }
}
