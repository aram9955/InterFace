using System;
using System.Collections.Generic;
using static FurnitureFactory.Reporter;

namespace FurnitureFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IReport reporter1 = new Reporter();
            IReport reporter2 = new FilmReporter();

            List<IReport> reporters = new List<IReport>();

            reporters.Add(reporter1);
            reporters.Add(reporter2);
            reporters[0].Report();

            List<IWalk> walkers = new List<IWalk>();

            IWalk walker1 = new Doctor();

            walkers.Add(walker1);
            walkers.Add((IWalk)reporter1);
            walkers[0].Walk();



        }
    }
}
