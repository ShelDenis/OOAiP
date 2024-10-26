public interface IQueue
{
    public void Put(ICommand com);
    public ICommand Take();
}