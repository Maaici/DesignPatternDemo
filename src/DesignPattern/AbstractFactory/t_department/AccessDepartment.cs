using System;

namespace AbstractFactory.t_department
{
    public class AccessDepartment : IDepartment
    {

        public void InserDepartment(Department dept)
        {
            Console.WriteLine($"通过 Access 添加了一个名叫 {dept.DeptName} 的部门。");
        }

        public void GetDepartment(int id)
        {
            Console.WriteLine("通过 Access 获取一个部门信息。");
        }
    }
}
