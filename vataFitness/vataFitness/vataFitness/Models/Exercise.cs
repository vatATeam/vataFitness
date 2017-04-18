using System;
using System.Collections.Generic;
using System.Text;

namespace vataFitness.Models
{
    public sealed class Exercise
    {
        public int Id { get; set; }
        public string Title { get ; set; }
        public string Description { get; set; }

        public Exercise(string title)
        {
            Title = title;
        }
    }
}
