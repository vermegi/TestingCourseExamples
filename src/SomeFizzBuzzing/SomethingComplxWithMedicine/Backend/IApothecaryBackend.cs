namespace SomethingComplxWithMedicine.Backend
{
    public interface IApothecaryBackend
    {
        void SendCommand(ICommand theCommand);
    }

    public interface ICommand
    {}
}