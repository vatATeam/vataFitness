using System;
using System.Collections.Generic;
using System.Text;

namespace vataFitness.Models
{
    public abstract class Workout
    {
        public DateTime Date;
        public List<WorkComplex> WorkComplexes { get; protected set; }
        public string Comment;

        public virtual void AddWorkComplex(WorkComplex workComplex)
        {
            WorkComplexes.Add(workComplex);
        }

        public virtual void RemoveWorkComplex(WorkComplex workComplex)
        {
            WorkComplexes.Remove(workComplex);
        }

    }

    public class RealWorkout : Workout
    {
        public RealWorkout()
        {
          WorkComplexes = new List<WorkComplex>();
        }

    }
}
