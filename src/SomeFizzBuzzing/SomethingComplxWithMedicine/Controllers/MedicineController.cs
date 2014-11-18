using SomethingComplxWithMedicine.Backend;
using SomethingComplxWithMedicine.Commands;
using SomethingComplxWithMedicine.Models;
using SomethingComplxWithMedicine.Validation;

namespace SomethingComplxWithMedicine.Controllers
{
    public class MedicineController
    {
        private readonly IApothecaryBackend _apothecaryBackend;
        private readonly IValidate<Medicine> _validator;

        public MedicineController(IApothecaryBackend apothecaryBackend, IValidate<Medicine> validator)
        {
            _apothecaryBackend = apothecaryBackend;
            _validator = validator;
        }

        public void OrderMedicine(Medicine medicine)
        {
            _apothecaryBackend.SendCommand(new OrderMedicineCommand{Name = medicine.Name});
        }
    }
}