namespace AdapterPattern
{
    /// <summary>
    /// MySql帮助类的类适配器
    /// 1、实现IDbHepler 接口，使其适配现有项目
    /// 2、继承MySqlHelper，用它的方法来实现接口中的方法
    /// 注意：由于它继承了MySqlHelper,所以它具备父类的全部能力，他能使用IDbHepler接口的方法，也能使用父类中的全部方法
    /// </summary>
    public class MySqlClassAdapter : MySqlHelper, IDbHepler
    {
        public void Add<T>()
        {
            base.AddData<T>();
        }

        public void Delete<T>()
        {
            base.DeleteData<T>();
        }

        public void Update<T>()
        {
            base.UpdateData<T>();
        }

        public void Query<T>()
        {
            base.QueryData<T>();
        }
    }
}
