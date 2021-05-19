namespace StoreTests
{
    public class CustomerTest
    {
        [Fact]
        public void CityShouldSetValidData()
        {
            // Arrange 
            string CustomerName = "Cesar";
            string Customerhometown = "Pallet";
            Random nums = new Random();
            int ID = nums.Next(1111,9999);
            Customer test = new Customer(CustomerName,Customerhometown, ID);

            //Act
            test.CustomerName = CustomerName;
            test.Customerhometown = Customerhometown;
            test.ID = ID;

            //Assert 
            Assert.Equal(CustomerName, test.CustomerName);
            Assert.Equal(Customerhometown, test.Customerhometown);
            Assert.Equal(ID,ID);
        }
        [Theory]
        [InlineData("2345678i")]
        [InlineData("beufkjsdhfkjs1")]
        public void CityShouldNotSetInvalidData(string input, int number)
        {
            //Arrange 
            Customer test = new Customer(test.CustomerName,test.Customerhometown, test.ID);

            //Act & Assert
            Assert.Throws<Exception>(() => test.CustomerName = input);
            Assert.Throws<Exception>(() => test.Customerhometown = input);
            Assert.Throws<Exception>(() => test.ID = input);
        }
    }
}