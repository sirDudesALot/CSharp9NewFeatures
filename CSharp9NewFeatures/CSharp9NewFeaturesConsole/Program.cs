using CSharp9NewFeaturesConsole;
using System;


// This is top level code.  There is no need to decalre a main method anymore.
static int SomeMethod(int x, int y)
{
    return x + y;
}

// This is the entry point for the application
Console.WriteLine(SomeMethod(2, 3));

// Can now instantiate objects without having to decalre Class after new
Person thisPerson = new() { Id = 1, FirstName = "Joe", LastName = "Bloggs" };



