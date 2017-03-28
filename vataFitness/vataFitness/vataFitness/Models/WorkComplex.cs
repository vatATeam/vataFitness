using System;
using System.Collections.Generic;
using System.Text;

namespace vataFitness.Models
{
    public enum WorkComplexTypes
    {
        AMRAP
    }

    public class WorkComplex
    {
        public string Title { get; set; }
        public WorkComplexTypes ComplexType { get; set; }

        public List<WorkSet> WorkSets { get; private set; }

        public WorkComplex(string complexTitle, WorkComplexTypes complexType)
        {
            Title = complexTitle;
            ComplexType = complexType;
            WorkSets = new List<WorkSet>();
        }

        public void AddWorkSet(WorkSet workSet)
        {
            WorkSets.Add(workSet);
        }

        public void RemoveWorkSet(WorkSet workSet)
        {
            WorkSets.Remove(workSet);
        }
    }
}
