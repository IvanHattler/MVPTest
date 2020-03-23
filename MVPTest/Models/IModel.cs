namespace MVPTest.Models
{
    public interface IModel
    {
        uint FirstNumber { get; set; }
        uint SecondNumber { get; set; }
        uint Result { get; set; }
        void Div();
    }
}