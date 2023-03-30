namespace OrderSchduler.Application.Features.Order
{
    public class OrderVm
    {
        public string Name { get; init; } = string.Empty;
        public string ArrivalCity { get; init; } = string.Empty;

        public override string ToString()
        {
            return $"Name: {Name}, arrival: {ArrivalCity}";
        }
    }
}