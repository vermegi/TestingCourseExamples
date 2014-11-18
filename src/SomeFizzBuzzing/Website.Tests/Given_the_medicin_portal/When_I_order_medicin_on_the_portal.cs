using Moq;
using NUnit.Framework;
using SomethingComplxWithMedicine.Backend;
using SomethingComplxWithMedicine.Commands;
using SomethingComplxWithMedicine.Controllers;
using SomethingComplxWithMedicine.Models;
using SomethingComplxWithMedicine.Validation;

namespace Website.Tests.Given_the_medicin_portal
{
    [TestFixture]
    public class When_I_order_medicin_on_the_portal
    {
        [Test]
        public void It_sends_the_OrderMedicin_command_to_the_backend()
        {
            //arrange
            var backend = new Mock<IApothecaryBackend>();
            var sut = new MedicineController(backend.Object, null);
            var medicine = new Medicine();
            
            //act
            sut.OrderMedicine(medicine);

            //assert
            backend.Verify(back => back.SendCommand(It.Is<OrderMedicineCommand>(cmd => cmd.Name == medicine.Name)));
        }

        [Test]
        public void It_verifies_the_Medicine_for_validness()
        {
            //arrange
            var backend = new Mock<IApothecaryBackend>();
            var validator = new Mock<IValidate<Medicine>>();
            var sut = new MedicineController(backend.Object, validator.Object);
            var medicine = new Medicine();
            
            //act
            sut.OrderMedicine(medicine);

            //assert
            validator.Verify(val => val.Validate(medicine));
        }
    }
}