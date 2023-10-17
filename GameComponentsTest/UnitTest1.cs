using CaveOfEnviorments;
namespace GameComponentsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayer()
        {
            //Arrange
            Player player;
            //Act
            player = new Player();
            //Assert
            Assert.IsNotNull(player);
            Assert.AreEqual(player.name, player.input);
        }

        [TestMethod]
        public void TestGame()
        {
            //Arrange
            Game game;
            //Act
            game = new Game();
            //Assert
            Assert.IsNotNull(game);
            Assert.AreEqual(game.WelcomeMessage, "Enter your Name: ");


        }
    }
}