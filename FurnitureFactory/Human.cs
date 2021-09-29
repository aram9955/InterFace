using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    public interface IWalk
    {
        void Walk();
    }
    public interface IReport
    {
        void Report();
    }
    public class FilmReporter :IReport
    {
        public void Report()
        {
            throw new NotImplementedException();
        }
}
    public class Reporter : IWalk, IReport
    {
        public void Report()
        {
            throw new NotImplementedException();
        }
        public void Walk()
        {
            throw new NotImplementedException();

        }
        public class Blogger : IWalk, IReport
        {

            public void Report()
            {
                throw new NotImplementedException();
            }
            public void Walk()
            {
                throw new NotImplementedException();
            }
        }

        public class Doctor : IWalk
        {
            public void Walk()
            {
                throw new NotImplementedException();

            }
        }
        public class Casier : IWalk
        {
            public void Walk()
            {
                throw new NotImplementedException();

            }
        }
    }
}
