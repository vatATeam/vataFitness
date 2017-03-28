using System;
using System.Collections.Generic;
using System.Text;

namespace vataFitness.Models
{
    public sealed class WorkSet
    {
        public Exercise SetExercise { get; private set; }
        public TimeSpan Duration { get; set; }
        public double Weight { get; set; }
        public int Reps { get; set; }
        public string Comment { get; set; }

        public WorkSet(Exercise exercise)
        {
            SetExercise = exercise;
        }
    }
}
