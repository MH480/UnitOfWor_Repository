namespace models.ResultModels
{
    public class TServiceResult<TResult> : ServiceResult
    {
        public TResult ReturnObject { get; set; }
    }
}