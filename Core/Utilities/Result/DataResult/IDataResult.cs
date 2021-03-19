namespace Core.Utilities.Result.DataResult
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}