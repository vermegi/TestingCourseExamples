namespace SomethingComplxWithMedicine.Validation
{
    public interface IValidate<in TSomething>
    {
        bool Validate(TSomething medicine);
    }
}