using AddressBookADO;
using NUnit.Framework;

namespace AddressBookTest
{
    public class Tests
    {
        AddressBook address;
        AddressBookDetail addressBookDetail;
        [SetUp]
        public void Setup()
        {
            address = new AddressBook();
            addressBookDetail = new AddressBookDetail();
        }
        //<summary>
        //UC2 : Insert Details
        //</summary>
        [Test]
        public void Inserting_AddressBook_Details()
        {
            int expected = 1;
            address.FirstName = "shri";
            address.LastName = "oliva";
            address.Address = "ganapti mandir";
            address.City = "thane";
            address.State = "Maharashtra";
            address.Zip = 425673;
            address.PhoneNumber = 8798573735;
            address.Email = "shri@gmail.com";
            var actual = addressBookDetail.InsertAddressData(address);
            Assert.AreEqual(expected, actual);
        }
    }
}