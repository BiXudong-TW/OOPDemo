# Encapsulation Demo

## Background
There is an online shopping system consisting of orders.
You want to get the order time and order name.
Please read the content in the google doc first, then move to here.

## Introduction

### Object Oriented
The Order Class is an example of object-oriented programming.
The Order object contains attributes such as id, customer name, order date and so on.
The Order object has behaviours such as get/set order time.

The Order object is a abstract collection of these information.

### Public vs Private
In the Order Class, you can see some attributes are public and some are private.
The public attributes(e.g. Bill) can be access directly by others.
The private attributes(e.g. OrderTime) cannot be access directly by others, you can only 
access that by exposed method(e.g. GetOrderTime()).

The advantages of this design is that others can only access/edit attributes you exposed.
This can improve the safety of your program. Also, others do not have to concern about details
of the Class.

Question 1
How does get/set(line:8 in Order) work? What's their purpose?

Question 2
Please design a customer with name, age, phone number and address.
I want phone number and address can be access by others. The address can be set by others.
Please implement the requirement in a new branch called dev.
Please write down all your git operations here.

Question 3
Please find an example in Tiger codebase.
