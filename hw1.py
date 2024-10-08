"""
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
"""


def hw1():
    m = int(input("Enter the number\n"))
    n = int(input("Enter the number\n"))
    result = 0
    for i in range(m, n + 1):
        result += i
    return result


def hw2():
    m = int(input("Enter the number\n"))
    n = int(input("Enter the number\n"))
    for i in range(m, n + 1):
        print(i)


def hw3(m, n):
    if m == 0:
        return n + 1
    if m > 0 and n == 0:
        return hw3(m - 1, 1)
    if m > 0 and n > 0:
        return hw3(m - 1, hw3(m, n - 1))


print(hw3(int(input("Enter the number\n")), int(input("Enter the number\n"))))
