# LINQSD46IsmailiaD02

# 🔷 LINQ Deep Dive – Advanced LINQ Operators (.NET 9)

This repository contains a .NET 9 console application that demonstrates advanced LINQ operations, data manipulation techniques, and real-world query scenarios using:

- ✅ Deferred vs Immediate Execution  
- ✅ Projection (Select)  
- ✅ Join (Query & Method Syntax)  
- ✅ GroupBy  
- ✅ Aggregate Functions  
- ✅ Distinct & DistinctBy  
- ✅ Set Operators  
- ✅ Zip Operator  
- ✅ Indexed Where & Select  
- ✅ Insert, Update, Delete Simulation  

Built using **.NET 9 Console Application**

---

# 📁 Solution Structure

```
LINQ-Solution
│
├── LINQD01   → Basic LINQ Operations (Day 1)
└── LINQD02   → Advanced LINQ Operations (Day 2)
```

---

# 🚀 Project: LINQD02

This project builds on Day 1 and explores real-world data querying scenarios using:

- Employee class  
- Department class  
- Repository pattern  
- Custom Equality Comparer  

---

# 📌 Deferred Execution vs Immediate Execution

## 🔹 Deferred Execution

Query is NOT executed until iteration.

```csharp
var q1 = employees.Where(e => e.DeptId == 1);
```

Execution happens only when:

```csharp
foreach(var item in q1)
```

---

## 🔹 Immediate Execution

Triggered by:

- `ToList()`
- `ToArray()`
- `Count()`
- `First()`
- `Sum()` etc.

```csharp
var q1 = employees.Where(e => e.DeptId == 1).ToList();
```

✔ Data is executed immediately  
✔ Result stored in memory  

---

# 📌 Take & Skip Operators

| Operator | Description |
|----------|------------|
| `Take(n)` | Takes first n elements |
| `TakeLast(n)` | Takes last n elements |
| `Skip(n)` | Skips first n elements |
| `SkipLast(n)` | Skips last n elements |
| `TakeWhile()` | Takes elements while condition is true |
| `SkipWhile()` | Skips elements while condition is true |

---

# 📌 All & Any

```csharp
ints.All(i => i % 2 == 0);
ints.Any(i => i % 2 == 0);
```

✔ `All()` → checks if ALL elements satisfy condition  
✔ `Any()` → checks if AT LEAST ONE satisfies condition  

---

# 📌 Distinct & Custom Equality

## 1️⃣ Distinct Primitive

```csharp
ints.Distinct();
```

---

## 2️⃣ Distinct with Custom Comparer

Custom comparer:

```csharp
public class EmpComparer : IEqualityComparer<Employee>
```

```csharp
emps.Distinct(new EmpComparer());
```

---

## 3️⃣ DistinctBy (Modern .NET)

```csharp
emps.DistinctBy(e => e.Id);
```

✔ Cleaner  
✔ No need for custom comparer  

---

# 📌 Projection (Select Columns)

## Select Specific Fields

```csharp
employees
   .Where(e => e.DeptId == 1)
   .Select(e => new { e.Id, e.Name });
```

---

## Anonymous Object Projection

```csharp
.Select(e => new { SSN = e.Id, FullName = e.Name });
```

✔ Lightweight  
✔ Read-only  

---

# 📌 Join Operations

## 1️⃣ Query Syntax

```csharp
var result =
    from e in employees
    join d in departments
    on e.DeptId equals d.DeptId
    select new { e.Name, d.DeptName };
```

---

## 2️⃣ Method Syntax

```csharp
employees.Join(
    departments,
    e => e.DeptId,
    d => d.DeptId,
    (emp, dept) => new { emp.Name, dept.DeptName });
```

✔ Internally uses hash matching  
✔ Very efficient  

---

# 📌 GroupBy

## Basic Grouping

```csharp
employees.GroupBy(e => e.DeptId);
```

Result:

```
DeptId → IEnumerable<Employee>
```

---

## Group By Department Name

```csharp
employees
    .Join(departments,
        e => e.DeptId,
        d => d.DeptId,
        (emp, dept) => new { emp, dept.DeptName })
    .GroupBy(x => x.DeptName);
```

---

# 📌 GroupBy with Aggregate Functions

```csharp
.GroupBy(x => x.DepartmentName)
.Select(g => new
{
    DepartmentName = g.Key,
    TotalSalary = g.Sum(e => e.Salary),
    AvgSalary = g.Average(e => e.Salary),
    MaxSalary = g.Max(e => e.Salary),
    MinSalary = g.Min(e => e.Salary)
});
```

✔ Real-world reporting  
✔ Dashboard statistics  
✔ Data summarization  

---

# 📌 Aggregate Methods

| Method | Description |
|--------|------------|
| `Min()` | Minimum value |
| `Max()` | Maximum value |
| `Count()` | Number of elements |
| `Average()` | Average value |
| `Sum()` | Total |

---

# 📌 OfType Operator

Used with inheritance.

```csharp
users.OfType<Male>();
users.OfType<Female>();
```

✔ Filters by type  
✔ Safe casting  

---

# 📌 Set Operators

| Method | Description |
|--------|------------|
| `Concat()` | Combines sequences |
| `Union()` | Removes duplicates |
| `Except()` | Elements in first not in second |
| `Intersect()` | Common elements |

---

# 📌 Zip Operator

```csharp
ints.Zip(names, (num, name) =>
    new { Number = num, Name = name });
```

✔ Combines two sequences element-by-element  

---

# 📌 Indexed Where & Select

```csharp
employees.Where((emp, index) =>
    emp.DeptId == 1 && index < 5);
```

✔ Access element + index  

---

# 📌 Insert, Update, Delete (Simulation)

## Insert

```csharp
employees.Add(newEmployee);
```

## Update

```csharp
var emp = employees.FirstOrDefault(e => e.Id == 1);
```

## Delete

```csharp
employees.Remove(emp);
```

✔ LINQ does NOT modify data  
✔ It only queries  
✔ Collection handles modifications  

---

# 🎯 Learning Goals (Day 2)

This project helps understand:

- Advanced LINQ operators  
- Data grouping & aggregation  
- Custom equality comparison  
- Query vs Method syntax difference  
- Real-world reporting scenarios  
- Execution behavior  
- Data transformation  

---

# 🛠 Requirements

- .NET 9 SDK  
- Visual Studio 2022+  

---

# ▶ How to Run

```bash
dotnet run
```

Or open in Visual Studio and press **F5**

---

# 📌 Key Takeaway

Day 2 shows that LINQ is not just filtering…

It supports:

- Joining multiple collections  
- Grouping data  
- Aggregating statistics  
- Transforming objects  
- Combining datasets  

LINQ turns C# into a powerful data query language.

---

# 👨‍💻 Author

Mohamed Hatem  
Software Engineer  

---
