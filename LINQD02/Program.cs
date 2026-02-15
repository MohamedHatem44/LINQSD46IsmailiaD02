namespace LINQD02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Respository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------");
            //foreach (var item in departments)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Deffered Execution vs Immediate Execution
            //// All LINQ queries are deferred execution,
            //// meaning they are not executed until you iterate over the results.
            //// Expect Single Object
            //var q1 = employees.Where(e => e.DeptId == 1).Count(); // Not Here

            //var newEmployee = new Employee
            //{
            //    Id = 6,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 50000,
            //    DeptId = 1
            //};
            //employees.Add(newEmployee);
            //foreach (var item in q1) // Ex happen here
            //{
            //    Console.WriteLine(item);
            //}

            //var q1 = employees.Where(e => e.DeptId == 1).ToList(); // Here

            //var newEmployee = new Employee
            //{
            //    Id = 6,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 50000,
            //    DeptId = 1
            //};
            //employees.Add(newEmployee);
            //foreach (var item in q1) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Select Top 3,
            //// Take
            //// TakeLast
            //// Takeq
            //// Skip
            //// SkipLast
            //// SkipWhile
            //var q3 = employees.Take(3);
            //var q4 = employees.Take(30);

            //var q5 = employees.TakeLast(3);
            //var q6 = employees.TakeLast(30);

            //var q7 = employees.Skip(3);
            //var q8 = employees.Skip(3).Skip(3);

            //var q9 = employees.Skip(3).Take(3);
            //var q10 = employees.Skip(3).Take(30);

            //var q11 = employees.SkipLast(3);
            //var q12 = employees.SkipLast(30);

            //// TakeWhile
            //// TakeWhile takes elements from the sequence
            //// as long as a specified condition is true.
            //// Once the condition becomes false,
            //// it stops taking elements, even if there are more elements
            //// in the sequence that would satisfy the condition.
            //var q13 = employees.TakeWhile(e => e.DeptId == 1);
            //var q14 = employees.TakeWhile(e => e.DeptId == 2);

            //// SkipWhile
            //// SkipWhile skips elements from the sequence
            //// as long as a specified condition is true.
            //// Once the condition becomes false,
            //// it stops skipping elements and includes the rest of the sequence,
            //// even if there are more elements in the sequence that would satisfy the condition.
            //var q15 = employees.SkipWhile(e => e.DeptId == 1);
            //var q16 = employees.SkipWhile(e => e.DeptId == 2);

            //foreach (var item in q16)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region All, Any
            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var res1 = ints.All(i => i % 2 == 0); // False
            //var res2 = ints.Any(i => i % 2 == 0); // True
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion
            /*------------------------------------------------------------------*/
            #region Distincit
            //List<int> ints = new List<int> { 1, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8 };
            //var q17 = ints.Distinct();
            //foreach (var item in q17)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Distincit Employee && DistinctBy
            //var emps = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1 },
            //    new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2 },
            //    new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3 },
            //    new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4 },
            //    new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DeptId = 1 },
            //    new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2 },
            //    new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3 },
            //    new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4 },
            //    new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2 },
            //};

            //var empComp = new EmpComparer();
            //var q18 = emps.Distinct(empComp);

            //var q19 = emps.DistinctBy(e=>e.Id);
            //foreach (var item in q19)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Projection => Select Columns
            //// Filter rows but select all columns

            //var q20 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => e.Name);

            //var q21 = from e in employees
            //          where e.DeptId == 1
            //          select e.Name;

            ////var q21_1 = from e in employees
            ////            where e.DeptId == 1
            ////            select e.Name && e.Age; // Not Allowed

            ////var q22_1 = employees
            ////    .Where(e => e.DeptId == 1)
            ////    .Select(e => e.Name && e.Age); // Not Allowed

            //var q22 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => e.Name + "Age" + e.Age);


            //var q23 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new Employee { Id = e.Id, Name = e.Name });

            //var q24 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new { SSN = e.Id, FullName = e.Name });

            //var q25 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new { e.Id, e.Name });

            //var q26 = employees
            //    .Where(e => e.DeptId == 1)
            //    .Select(e => new { SSN = e.Id, FullName = e.Name })
            //    .OrderBy(a => a.SSN);

            //var q27 = from e in employees
            //          where e.DeptId == 1
            //          select new { SSN = e.Id, FullName = e.Name };

            ////var q27 = from e in employees
            ////            where e.DeptId == 1
            ////            select  e.Id, e.Name; // Not Allowed

            //foreach (var item in q25)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Query Syntax]
            //// Select all employees with their department name
            //var q28 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { EmpName = e.Name, DepartmentName = d.DeptName };

            //var q29 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          select new { Employee = e, DepartmentName = d.DeptName };
            //foreach (var item in q28)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");
            //foreach (var item in q29)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Join [Method Syntax]
            ////public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>
            ////(this IEnumerable<TOuter> outer,
            ////IEnumerable<TInner> inner,
            ////Func<TOuter, TKey> outerKeySelector,
            ////Func<TInner, TKey> innerKeySelector,
            ////Func<TOuter, TInner, TResult> resultSelector)
            //var q30 = employees
            //    .Join(departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (emp, dept) => new { EmpName = emp.Name, DepartmentName = dept.DeptName });

            //var q31 = departments
            //    .Join(employees,
            //    d => d.DeptId,
            //    e => e.DeptId,
            //    (dept, emp) => new { EmpName = emp.Name, DepartmentName = dept.DeptName });

            //foreach (var item in q30)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------------");
            //foreach (var item in q31)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region GroupBy
            //  //var q32_1 = employees.GroupBy(employees => employees.DeptId);
            //  //foreach (var item in q32_1)
            //  //{
            //  //    Console.WriteLine(item); // System.Linq.Lookup`2+Grouping[System.Int32,LINQD02.Employee]
            //  //    // XXXX
            //  //}

            //  var q32 = employees.GroupBy(employees => employees.DeptId);
            //  // Dept Id = 1 => List<Employee>
            //  // Dept Id = 2 => List<Employee>
            //  // Dept Id = 3 => List<Employee>
            //  // [ { Key = DeptId, List<Employee> } ]

            //  var q33 = from e in employees
            //            group e by e.DeptId;

            //  var q34 = from e in employees
            //            group e by e.DeptId into g
            //            select g;

            //  var q35 = from e in employees
            //            join d in departments
            //            on e.DeptId equals d.DeptId
            //            group e by d.DeptName;

            //  //var q36 = { EmpName = Ahmed, DepartmentName = SD }
            //  //{ EmpName = Mohamed, DepartmentName = UI }
            //  //{ EmpName = Sara, DepartmentName = Mob }
            //  //{ EmpName = Omar, DepartmentName = Network }
            //  //{ EmpName = Ali, DepartmentName = SD }
            //  //{ EmpName = Mai, DepartmentName = UI }
            //  //{ EmpName = Ramy, DepartmentName = Mob }
            //  //{ EmpName = Hamada, DepartmentName = Network }
            //  //{ EmpName = Hatem, DepartmentName = SD }
            //  //{ EmpName = Osama, DepartmentName = UI }
            //  //    .GroupBy();

            //  var q36 = employees
            //    .Join(departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (emp, dept) => new { EmpName = emp.Name, DepartmentName = dept.DeptName })
            //.GroupBy(h => h.DepartmentName);

            //  //foreach (var item in q35)
            //  //{
            //  //    Console.WriteLine($"DeptName: {item.Key}");
            //  //    foreach (var emp in item)
            //  //    {
            //  //        Console.WriteLine(emp);
            //  //    }
            //  //}

            //  foreach (var item in q36)
            //  {
            //      Console.WriteLine(item);
            //  }
            #endregion
            /*------------------------------------------------------------------*/
            #region GroupBy and Aggregate FN
            //var q37 = from e in employees
            //          join d in departments
            //          on e.DeptId equals d.DeptId
            //          group e by d.DeptName into grouped
            //          select new
            //          {
            //              DepartmentName = grouped.Key,
            //              TotalSalary = grouped.Sum(e => e.Salary),
            //              AvgSalary = grouped.Average(e => e.Salary),
            //              MaxSalary = grouped.Max(e => e.Salary),
            //              MinSalary = grouped.Min(e => e.Salary),
            //          };

            //var q38 = departments
            //    .Join(employees,
            //    d => d.DeptId,
            //    e => e.DeptId,
            //    (dept, emp) => new { EmpName = emp.Name, Salary = emp.Salary, DepartmentName = dept.DeptName })
            //    .GroupBy(x => x.DepartmentName)
            //    .Select(g => new
            //    {
            //        DepartmentName = g.Key,
            //        TotalSalary = g.Sum(e => e.Salary),
            //        AvgSalary = g.Average(e => e.Salary),
            //        MaxSalary = g.Max(e => e.Salary),
            //        MinSalary = g.Min(e => e.Salary),
            //    });


            //foreach (var item in q38)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Min, Max, Count, Avg, Sum
            //var q39 = employees.Min(e => e.Salary);
            //var q40 = employees.Max(e => e.Salary);
            //var q41 = employees.Count(e => e.Salary > 5000);
            //var q42 = employees.Average(e => e.Salary);
            //var q43 = employees.Sum(e => e.Salary);

            //Console.WriteLine(q39);
            //Console.WriteLine(q40);
            //Console.WriteLine(q41);
            //Console.WriteLine(q42);
            //Console.WriteLine(q43);
            //var q44 = employees.Where(e => e.Salary > employees.Average(e => e.Salary));
            //var q45 = employees.Where(e => e.Salary > q42);
            //foreach (var item in q44)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region OfType
            //List<User> users = new List<User>()
            //{
            //    new Male { Id = 1, Name = "Ahmed"},
            //    new Male { Id = 2, Name = "Ali"},
            //    new Female { Id = 3, Name = "Sara"},
            //    new Female { Id = 4, Name = "Mai"},
            //};

            //var q46 = users.OfType<Male>();
            //var q47 = users.OfType<Female>();
            //foreach (var item in q47)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Concat, Union, Expect, Intersect
            //List<int> ints1 = new List<int> { 1, 1, 2, 3, 4, 5, 5 };
            //List<int> ints2 = new List<int> { 4, 5, 6, 7, 8 };

            //var q48 = ints1.Concat(ints2);
            //var q49 = ints1.Union(ints2);
            //var q50 = ints1.Except(ints2);
            //var q51 = ints1.Intersect(ints2);
            ////var q52 = ints1.Intersect(IEqComp Object);

            ////var q53 = employees.IntersectBy()

            //foreach (var item in q51)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Zip Operator
            //List<int> ints = new List<int> { 1, 2, 3 };
            //List<string> names = new List<string> { "Ahmed", "Ali", "Sara", "Mai" };

            //var q52 = ints.Zip(names);
            //var q52_1 = Enumerable.Zip(ints, names);
            //var q53 = ints.Zip(names, (num, name) => new { Number = num, Name = name });

            //foreach (var item in q53)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region IndexedWhere && IndexedSelect
            ////var q54 = employees.Select((emp, index)=> new { Employee = emp, Index = index });
            ////foreach (var item in q54)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //var q55 = employees.Where((emp, index) => emp.DeptId == 1 && index < 5);
            //foreach (var item in q55)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Insert, Update, Delete
            //// Insert
            //var newEmployee = new Employee
            //{
            //    Id = 11,
            //    Name = "New Employee",
            //    Age = 30,
            //    Salary = 50000,
            //    DeptId = 1
            //};
            //employees.Add(newEmployee);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            //// Update
            //// 1- Catch the object to update
            //var empToUpdate = employees.FirstOrDefault(e => e.Id == 1);
            //if (empToUpdate != null)
            //{
            //    empToUpdate.Name = "Updated Name";
            //}
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            //// Delete
            //// 1- Catch the object to delete
            //var empToDelete = employees.FirstOrDefault(e => e.Id == 1);
            //if (empToDelete != null)
            //{
            //    employees.Remove(empToDelete);
            //}
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Where
            //// Empty []
            //// 1 Item [{}]
            //// 2 Item [{}, {}]

            //var q56 = employees.Where(e => e.DeptId == 1000000);
            //Console.WriteLine(q56); // XXXXXX
            //foreach (var item in q56)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
