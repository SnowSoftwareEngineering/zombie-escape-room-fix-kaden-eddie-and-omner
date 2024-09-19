
using ZombieEscapeRoom;
namespace Zombie_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetFirstTest()
        {
            int answer = Program.GetFirst();
            Assert.Equal(666, answer);
        }

        [Fact]
        public void GetSecondTest()
        {
            int answer = Program.GetSecond();
            Assert.Equal(258, answer);
        }

        [Fact]
        public void GetThirdTest()
        {
            int answer = Program.GetThird();
            Assert.Equal(797, answer);
        }

        [Fact]
        public void GetFourthTest()
        {
            int answer = Program.GetFourth();
            Assert.Equal(861, answer);
        }
    }
}