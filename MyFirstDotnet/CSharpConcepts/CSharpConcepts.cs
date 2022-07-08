// we can include libraries with USING statements

using System;

//a namespace is like a file cabinet that we can store lots of stuff in

namespace CSharpConcepts{
    // { are curly braces
    // [ are brackets

    // a class is made of members
    // these members are called fields and methods
    // fields are variables
    // methods are functions
    class Program{
        //As a language, c# does not care about indentations, only line endings and logical blocks

        // Modifiers
        // Private = limits access to the class from outside the program
        // Static = limits access to the class itself and the class's static methods
        // Public = access is limited to the class and all of its members 
        // Internal- access is limited to the class and all of its members,but not to the class's static members
        // Protected - access is limited to the class and all of its members, but not the class's static members

        //(modifier) (return type) (method name) (parameters)
        static void Main(string[] args){
            // boolean - true or false
            // char - a single character value which is stored as an integer and then translated
            // string - a sequence of characters

            // Collections
            // arrays - are a collection of items of the same type
            // lists - a collection of items of different types
            // dictionaries - a collection of key/value pairs
            // queues - a first-in, first-out collection of items
            // stacks - a first-in, last-out collection of items

            Console.WriteLine("This is a functional line of code");

            // declaring a variable
            // (type)(name)=(value)
            string s = "Hello World";
            s = "Hello CSharp";
            Console.WriteLine(s);

            string s2;
            s2 = "hello!";

            // these are integer types
            int newint = 10;
            int newint2 = 11;
            // int  (4 byte)
            // byte (1 byte), short (2 byte), long (8 byte)

            // decimal types
            // **double (8 byte)**, float (4 byte)

            // boolean types
            bool a = true;
            bool b = false;

            // logical operators
            b = true || false; // OR - if one condition is true, the result is true
            b = true && false; // AND - if either condition is flase, the result is false
            b = !b; // NOT - if the condistion is true, the result is false, and vice versa

            // Comparison operators
            a == b; // checks to see if the values are equivalent to each other
            a != b; // checks to see if the values are not equivalent to each other
            newint < newint2; // checks to see if the value is less than the other
            newint > newint2; // checks to see if the value is greater than the other
            newint >= newint2; // checks to see if the value greater than or equal to the other
            newint <= newint2; // checks to see if the value is less than  or equal to the other

            // control flow
            // conditional statements

            // if
            // if (condition)
            if (3 == 3){
                // take some action but only if 3 == 3
            }
            else if (newint == 4){
                // take some action, but only if newint == 4
            }
            // else
            else{
                // take some other action, but only if 3 != 3 
            }

            // switch 
            // switch (expression)
            switch (newint){
                case 1: // if (newint == 1)
                    Console.WriteLine("here");
                    break;
                case "2":  // if (newint == "2")
                    Console.WriteLine("now here");
                    break;
                case 3: // if newint = 3
                    Console.WriteLine("nah I'm actually here");
                    break;
            }

            // Loops
            // for loops, while loops

            // for (initialization; condition; increment)
            for (int i = 0; i < 10; i++){
                Console.WriteLine("Hello");
            }

            //while (condition) - continues until the condition is false
            while (newint < 10){
                Console.WriteLine("printy boi");
                newint ++;
            }

            // do while - will run at least once
            do{
                Console.WriteLine("made it");
                newint++;
            }while(false);

            bool test = !(newint >= 5) || (newint <= 10);

            if(test){

            }

            int result = AddValues(1,2);
            int result2 = AddValues(newint,newint2);
        }
        private int AddValues(int x, int y){
            // variable scope is where the variable is accessible from
            return(x + y);
        }

        // Object oriented programming principles
        // Encapsulation - Rich's bad gumball machine example, or simply limiting the access to outside parties to only the parts they need to know about
        // Abstraction - hiding the details of how something works. think "black box", or the bad coffee machine example rich came up with
        // Inheritance - creating new classes from existing ones. Can be described as an "Is-a" relationship
            // a child/sub/derived class "is a" parent/super/base class. a dog is an animal. A corgi is a dog. etc.
            // a parent class can be derived to multiple sub classes
            // TRUE Multiple inheritance is a NO NO! but we can fake it with interfaces.
        // Polymorphism - taking on many forms through method overloading and overriding
            // overloading - same method name but different parameters
                // example: AddValues(int a, int b) 
                // example: AddValues(int a, int b, int c)
            // overriding - same method and parameters, but different functionality
    }
}