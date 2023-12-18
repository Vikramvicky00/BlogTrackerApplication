using DataAccessLayer;
using Moq;
using NUnit.Framework;

namespace DALTestLayer
{
    [TestFixture]  
    public class TestingUsingMoq
    {
        [Test]
        public void checkEmployeeExistWithMoq()
        {
        
            var fakeObject = new Mock<EmpInfoRepository>();
            fakeObject.Setup(x => x.GetEmpInfo(It.IsAny<string>()));
            var res = fakeObject.Object.GetEmpInfo("demo@gmail.com");
            Assert.That(res,Is.Not.Null);
        }
    }
}
