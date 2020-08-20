using System;

namespace AbstractFactory.t_department
{
    public class SqlServerDepartment : IDepartment
    {

        public void InserDepartment(Department dept)
        {
            Console.WriteLine($"通过 SqlServer 添加了一个名叫 {dept.DeptName} 的部门。");
        }

        public void GetDepartment(int id)
        {
            Console.WriteLine("通过 SqlServer 获取一个部门信息。");
        }
    }
}
