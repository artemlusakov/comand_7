using Xunit;
using BlazorWebAssemblySignalRApp.Server.Valudation;
namespace UnitTests
{
    public class UnitTest1
    {
        private readonly EmailValidation _validation;

        public UnitTest1() => _validation = new EmailValidation();
        [Fact]
        public void Test_Email_right()
            => Assert.True(_validation.IsValid("aboba@gmail.com"));
        [Fact]
        public void Test_Email_wrong()
            => Assert.False(_validation.IsValid("aboba@gmail?com"));
    }
}