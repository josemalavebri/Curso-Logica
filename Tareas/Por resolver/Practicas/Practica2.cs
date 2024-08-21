using System;

int a = operacion1(2);
int b = operacion2(3);
int c = operacion3(4);
int d = operacion4(5);
int e = operacion5(6);

Console.WriteLine($"{a} - {b} - {c} - {d} - {e}");

int operacionNumero()
{
    return 2 * (3 + 1);
}

int operacion1(int n)
{
    return operacionValidacion(n);
}

int operacion(int a)
{
    if (operacionBool())
    {
        return a + 2;
    }
    else
    {
        return a - 2;
    }
}

int operacion2(int c)
{
    c = operacionValidacion(c) + 3;
    return operacion(c);
}

int operacionValidacion(int d)
{
    int a = d + operacionNumero();
    if (a > operacionNumero())
    {
        return a + operacion1(a);
    }
    else
    {
        return a - operacion1(a);
    }
}

bool operacionBool()
{
    return true;
}

bool operacionBool2(bool d)
{
    return !d;
}

int operacion3(int a)
{
    int c = 1;
    bool bandera = false;
    for (int b = 0; b < 3; c++)
    {
        b = b + 5;
        bandera = !bandera;
        if (operacionBool2(bandera))
        {
            a = b;
            b = b - 5;
            return a + c;
        }
        else
        {
            return operacionValidacion(b);
        }
    }
    return a + c;
}

int operacion4(int n)
{
    return n * 2 + operacionNumero();
}

int operacion5(int n)
{
    int res = operacionValidacion(n);
    if (res % 2 == 0)
    {
        return res * 2;
    }
    else
    {
        return res + 5;
    }
}
