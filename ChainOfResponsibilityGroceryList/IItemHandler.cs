namespace ChainOfResponsibilityGroceryList;

interface IItemHandler
{
    IItemHandler Next { get; set; }
    void Handle(string items);
}