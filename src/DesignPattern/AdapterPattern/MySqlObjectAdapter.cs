namespace AdapterPattern
{
    /// <summary>
    /// MySql帮助类的对象适配器
    /// 1、实现IDbHepler 接口，使其适配现有项目
    /// 2、内部实例化MySqlHelper 对象或者通过其他途径得到MySqlHelper 的实例，用它的方法实现接口的方法
    /// </summary>
    public class MySqlObjectAdapter : IDbHepler
    {
        MySqlHelper _helper = new MySqlHelper();

        //private readonly MySqlHelper _helper;

        //public MySqlObjectAdapter(MySqlHelper helper)
        //{
        //    _helper = helper;
        //}

        public void Add<T>()
        {
            _helper.AddData<T>();
        }

        public void Delete<T>()
        {
            _helper.DeleteData<T>();
        }

        public void Update<T>()
        {
            _helper.UpdateData<T>();
        }

        public void Query<T>()
        {
            _helper.QueryData<T>();
        }
    }
}
