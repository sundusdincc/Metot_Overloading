## C# | Method Overloading
Method Overloading is the common way of implementing polymorphism. It is the ability to redefine a function in more than one form. A user can implement function overloading by defining two or more functions in a class sharing the same name. C# can distinguish the methods with different method signatures. i.e. the methods can have the same name but with different parameters list (i.e. the number of the parameters, order of the parameters, and data types of the parameters) within the same class. 

Overloaded methods are differentiated based on the number and type of the parameters passed as arguments to the methods.
You can not define more than one method with the same name, Order and the type of the arguments. It would be compiler error.
The compiler does not consider the return type while differentiating the overloaded method. But you cannot declare two methods with the same signature and different return type. It will throw a compile-time error. If both methods have the same parameter types, but different return type, then it is not possible.

## Why do we need Method Overloading?

If we need to do the same kind of the operation in different ways i.e. for different inputs. In the example described below, we are doing the addition operation for different inputs. It is hard to find many different meaningful names for single action.

[Method Overloading](https://www.geeksforgeeks.org/c-sharp-method-overloading/)

### Different ways of doing overloading methods-
Method overloading can be done by changing:  
- The number of parameters in two methods.
- The data types of the parameters of methods.
- The Order of the parameters of methods.

### Out Parameter
The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values.

Important Points:

It is similar to ref keyword. But the main difference between ref and out keyword is that ref needs that the variable must be initialized before it passed to the method. But out parameter doesn’t require the variables to be initialized before it passed to the method. But before it returns a value to the calling method, the variable must be initialized in the called method.
It is also similar to the in keyword but the in keyword does not allow the method that called to change the argument value but ref allows.
For using out keyword as a parameter both the method definition and calling method must use the out keyword explicitly.

[Out Parameter](https://www.geeksforgeeks.org/out-parameter-with-examples-in-c-sharp/)

