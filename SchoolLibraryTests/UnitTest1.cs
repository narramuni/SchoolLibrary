using SchoolLibrary;

namespace SchoolLibraryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestFixture]
        public class TeacherTests
        {
            [Test]
            public void Teacher_Name_Should_Not_Be_Null_Or_Empty()
            {
                // Arrange
                var teacher = new Teacher();

                // Act
                teacher.Name = "Vinay";

                // Assert
                Assert.That(teacher.Name, Is.Not.Null.And.Not.Empty, "Teacher's Name should not be null or empty.");
            }
        }

        [TestFixture]
        public class StudentTests
        {
            [Test]
            public void Student_Name_Should_Not_Be_Null_Or_Empty()
            {
                // Arrange
                var student = new Student();

                // Act
                student.Name = "Sai Pavan";

                // Assert
                Assert.That(student.Name, Is.Not.Null.And.Not.Empty);
            }
        }

        [TestFixture]
        public class SubjectTests
        {
            [Test]
            public void Subject_Name_Should_Not_Be_Null_Or_Empty()
            {
                // Arrange
                var subject = new Subject();

                // Act
                subject.Name = "Math";

                // Assert
                Assert.That(subject.Name, Is.Not.Null.And.Not.Empty);
            }
        }


    }
}