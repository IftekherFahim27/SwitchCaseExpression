# ⚡ Switch Case vs Switch Expression in C\#

This repository demonstrates a **clean, practical comparison** between the traditional `switch-case` statement and the modern **switch expression** (C# 8+). It includes runnable example code (measuring execution time with `Stopwatch`), a summary of advantages and drawbacks, clear differences, and step-by-step instructions to run the benchmark.

---

## 📌 Table of Contents

- [Overview](#overview)
- [Program (example)](#program-example)
- [Advantages](#advantages)
- [Drawbacks](#drawbacks)
- [Differences](#differences)
- [Performance Test](#performance-test)
- [How to Run](#how-to-run)
- [Tips & Recommendations](#tips--recommendations)
- [License](#license)

---

## Overview

`switch-case` and `switch expression` both provide branching based on a value. This repository contains a small benchmark that runs both approaches many times (by default `1_000_000` iterations) to make timing measurable. The goal is **readability** and **maintainability** — performance differences are usually negligible on modern machines, but this demo shows how to measure them.

---

## Program (example)

The repository includes a sample `Program.cs` that you can run directly. The important parts:

```csharp
using System;
using System.Diagnostics;

namespace SwitchCaseExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Value
            int testValue = 6;
            int loopCount = 1_000_000;

            Stopwatch sw = new Stopwatch();

            // Switch Case
            sw.Start();
            for (int i = 0; i < loopCount; i++)
            {
                _ = SwitchCaseExample(testValue);
            }
            sw.Stop();
            Console.WriteLine($"Switch-Case Time: {sw.ElapsedMilliseconds} ms");

            // Switch Expression
            sw.Restart();
            for (int i = 0; i < loopCount; i++)
            {
                _ = SwitchExpressionExample(testValue);
            }
            sw.Stop();
            Console.WriteLine($"Switch Expression Time: {sw.ElapsedMilliseconds} ms");

            Console.ReadLine();
        }

        // Old Style Switch-Case
        static string SwitchCaseExample(int fusion_infotech_product)
        {
            switch (fusion_infotech_product)
            {
                case 1: return "SAP A1";
                case 2: return "SAP B1";
                case 3: return "Oracel";
                case 4: return "ERPNext";
                case 5: return "Mobile Applicaton";
                case 6: return "Web Application";
                default: return "AI ......Coming Soon";
            }
        }

        // New Style Switch Expression
        static string SwitchExpressionExample(int fusion_infotech_product) =>
            fusion_infotech_product switch
            {
                1 => "SAP A1",
                2 => "SAP B1",
                3 => "Oracel",
                4 => "ERPNext",
                5 => "Mobile Applicaton",
                6 => "Web Application",
                _ => "AI ......Coming Soon"
            };
    }
}
```

> Tip: You can change `testValue` and `loopCount` to see how results vary.

---

## Advantages

### Switch Case

- ✅ Supported in **all C# versions**.
- ✅ Handles **complex multi-line logic** inside each `case` block.
- ✅ Flexible (multiple case labels can share logic).

### Switch Expression

- ✅ **Concise and expressive** for simple value → result mappings.
- ✅ Ideal for **inline assignments** and return expressions.
- ✅ No `break` statements required — less boilerplate.

---

## Drawbacks

### Switch Case

- ❌ Verbose for simple mappings.
- ❌ Requires `break` or `return` to avoid fall-through (more opportunities for minor mistakes).
- ❌ Boilerplate makes intent less obvious for simple mapping scenarios.

### Switch Expression

- ❌ Requires **C# 8.0 or newer**.
- ❌ Not a good fit for complex, multi-statement logic.
- ❌ Can be slightly harder to step-through in a debugger if expression becomes large.

---

## Differences

| Feature                        | Switch Case                | Switch Expression         |
| ------------------------------ | -------------------------- | ------------------------- |
| Syntax                         | Verbose, multi-line blocks | Concise, expression style |
| C# Version                     | All versions               | C# 8+                     |
| Best use                       | Complex multi-step logic   | Simple value mapping      |
| `break` required               | Yes                        | No                        |
| Inline assignment              | No                         | Yes                       |
| Readability for simple mapping | Lower                      | Higher                    |

---

## Performance Test

**What this demo does:**

- Calls each implementation `loopCount` times.
- Uses `Stopwatch` to measure elapsed milliseconds for each approach.

**Why run a benchmark?**

- Micro-benchmarks help measure cost of small differences but be mindful: results depend on JIT, CPU, OS and background processes.
- In most real applications, readability and maintainability matter more than the tiny differences shown here.

**Benchmark snippet** (already included in `Program.cs`):

```csharp
Stopwatch sw = new Stopwatch();

// Switch Case
sw.Start();
for (int i = 0; i < loopCount; i++)
{
    _ = SwitchCaseExample(testValue);
}
sw.Stop();
Console.WriteLine($"Switch-Case Time: {sw.ElapsedMilliseconds} ms");

// Switch Expression
sw.Restart();
for (int i = 0; i < loopCount; i++)
{
    _ = SwitchExpressionExample(testValue);
}
sw.Stop();
Console.WriteLine($"Switch Expression Time: {sw.ElapsedMilliseconds} ms");
```

**Typical output** (example only):

```
Switch-Case Time: 85 ms
Switch Expression Time: 78 ms
```

---

## How to Run

1. **Clone the repository**

```bash
git clone https://github.com/yourusername/SwitchCaseExpression.git
cd SwitchCaseExpression
```

2. **Open in Visual Studio**

- Open the `.sln` or the folder in Visual Studio. Set target framework to .NET Core / .NET 5+ or compatible with C# 8+.

3. **Or run from the command line**

```bash
# If project is a .NET project
dotnet run --project ./Path/To/Project
```

4. **Change parameters** (optional)

- Edit `Program.cs` to change `testValue` and `loopCount`.

5. **View console output**

- The app prints two timings — one for `switch-case` and one for `switch expression`.

---

## Tips & Recommendations

- Prefer **switch expressions** for short, readable mappings (value → result).
- Use **switch-case** when you need multiple statements, side effects, or complex branching per case.
- When benchmarking: run tests multiple times, and consider more advanced benchmarking tools (e.g., BenchmarkDotNet) for production-level microbenchmarks.

---

## License

This example is provided under the **MIT License** — feel free to reuse and adapt.

---

*If you want changes (more visuals, an SVG decision chart, or a badge), tell me what style you prefer and I will update the README.*

