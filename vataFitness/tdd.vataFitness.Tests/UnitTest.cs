using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using vataFitness.Models;

namespace tdd.vataFitness.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAppStartApplication()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestAddNewExerciseReturnNotNull()
        {
            var newExercise = new Exercise()
            {
                Title = "new exrcise title",
                Description = "new exercise description"
            };

            Assert.IsNotNull(newExercise);
        }
    }
}
