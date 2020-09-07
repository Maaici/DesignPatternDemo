namespace AdapterPattern
{
    /// <summary>
    /// 数据操作帮助类接口
    /// </summary>
    public interface IDbHepler
    {
        //增
        void Add<T>();
        //删
        void Delete<T>();
        //改
        void Update<T>();
        //查
        void Query<T>();
    }
}
