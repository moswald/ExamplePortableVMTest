namespace Unit_Tests
{
    using System;
    using Microsoft.Reactive.Testing;
    using ViewModels;
    using Xunit;

    public class TestingVM
    {
        [Fact]
        public void SomeCountIncreasesToTenByOne()
        {
            var sched = new TestScheduler();

            var vm = new FooViewModel(sched);

            var expected = 0L;
            vm.SomeCount.Subscribe(val => Assert.Equal(expected, val));

            for (var i = 0; i != 10; ++i)
            {
                expected = i;
                sched.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
            }

            sched.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);
        }
    }
}
