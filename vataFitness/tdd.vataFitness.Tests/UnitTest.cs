using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using vataFitness.Models;

namespace tdd.vataFitness.Tests
{
    [TestClass]
    public class ExerciseUnitTests
    {
        [TestMethod]
        public void TestAddNewExerciseReturnNotNull()
        {
            var newExercise = new Exercise("new exrcise title")
            {
                Description = "new exercise description"
            };

            Assert.IsNotNull(newExercise);
        }
    }

    [TestClass]
    public class WorkSetUnitTests
    {
        [TestMethod]
        public void TestAddNewWorkSet()
        {
            var newWorkSet = new WorkSet(new Exercise("test exercise"))
            {
                Duration = new TimeSpan(0, 10, 0),
                Weight = 100.0,
                Reps = 2,
                Comment = "test set"
            };

            Assert.IsNotNull(newWorkSet);
        }
    }

    [TestClass]
    public class WorkComplexUnitTests
    {
        [TestMethod]
        public void TestAddWorkSetToWorkComplexReturnTrue()
        {
            var newComplex = new WorkComplex("test complex title", WorkComplexTypes.AMRAP);
            var newWorkSet = new WorkSet(new Exercise("test exercise"))
            {
                Duration = new TimeSpan(0, 10, 0),
                Reps = 2
            };
            newComplex.AddWorkSet(newWorkSet);
            Assert.IsTrue(newComplex.WorkSets.Contains(newWorkSet));
        }

        [TestMethod]
        public void TestRemoveWorkSetFromWorkComplexReturnTrue()
        {
            var newComplex = new WorkComplex("test complex title", WorkComplexTypes.AMRAP);
            var newWorkSet = new WorkSet(new Exercise("test exercise"))
            {
                Duration = new TimeSpan(0, 10, 0),
                Reps = 2
            };
            newComplex.AddWorkSet(newWorkSet);

            newComplex.RemoveWorkSet(newWorkSet);
            Assert.IsFalse(newComplex.WorkSets.Contains(newWorkSet));
        }
    }

    [TestClass]
    public class CommonUnitTest
    {
        [TestMethod]
        public void TestAppStartApplication()
        {
            Assert.IsTrue(true);
        }
    }
}
