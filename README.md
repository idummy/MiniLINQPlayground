# MiniLINQPlayground 🚀

A hands-on C# learning lab focused on **LINQ**, **functional programming**, and **custom extension methods** — written from scratch to understand the internals, not just to use them.

## 📚 What is this?

This repo is a collection of:

- ✅ Custom implementations of LINQ-like methods (`Select`, `Where`, `Aggregate`, etc.)
- ✅ Practical lambda and delegate challenges
- ✅ Function composition patterns using `Func<>` and `Aggregate`
- ✅ Exercises to master `.Aggregate`, `.Where`, `.Select` and functional logic
- ✅ Experimental playground to simulate real LINQ pipelines without relying on built-in LINQ

## 📁 Folder Structure

```
MiniLINQPlayground/
├── MiniLINQPlayground.csproj
├── Program.cs
├── Logic/
│   ├── MiniSelectExtension.cs
│   ├── MiniWhereExtension.cs
│   └── (more coming soon)
└── Exercises/
    ├── AggregateChallenges.cs
    ├── FuncCompositionSamples.cs
    └── ...
```

## 🔧 Topics Covered

- ✅ Lambda expressions
- ✅ `Func<>`, delegates
- ✅ Function composition
- ✅ `.Aggregate()` deeply explained
- ✅ IEnumerable vs IEnumerator
- ✅ Yield return vs return
- ✅ Building custom LINQ extensions

## 🤯 Why build this?

I was learning LINQ and wanted to go **beyond syntax**, into how it really works under the hood.  
So instead of reading docs, I built my own LINQ functions and tested them with real problems.

This is my **mental gym** — if you're learning LINQ or `Func<>`, feel free to fork or suggest challenges!

## 🚀 How to Run

```bash
dotnet build
dotnet run
```

> Target framework: .NET 6 / 7 (adjust in .csproj if needed)

## 💡 Inspired by

- Real-world dev challenges I faced while understanding LINQ
- Clean code and functional patterns in C#
- My own curiosity and need to fight AI-suggested code by writing it myself 😤

---

## 🧠 Want to contribute?

Feel free to create new challenges or add your own version of LINQ methods. Let's learn this the hard (and fun) way.

---

## 🐍 P.S.

Yes, I write LINQ like a rebel.  
Yes, sometimes it's overkill.  
But hey — learning this way makes me stronger than AI suggestions. 😎