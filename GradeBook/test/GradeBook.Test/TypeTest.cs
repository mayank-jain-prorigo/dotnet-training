using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book1 = GetBook("book 1");
            var book2 = GetBook("book 2");
            // Act

            // Assert
            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 2", book2.Name);

        }

        Book GetBook(String name)
        {
            return new Book(name);
        }
    }
}
