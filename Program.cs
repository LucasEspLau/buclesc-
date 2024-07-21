// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");


//FOR
int maxNum=10;

for(int i=0;i<=maxNum;i++)
{
    Console.WriteLine("El contador: "+i);
}
*/
/*
int sum = 0;

// 1+2+3+4+5
for (int i = 1; i <= 100; i++)
{
    sum =sum+i; 
    Console.WriteLine("La suma: "+sum);
}

Console.WriteLine("La suma de 1 a 100: " + sum);
*/

/*
Console.WriteLine("Ingresar el numero: ");
int numero=int.Parse(Console.ReadLine());

for (int i = 1; i <=10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero*i}");
}
*/
///WHILE
/*
int i=0;
while(i<5){
    Console.WriteLine("El contador: "+i);

}*/
/*
int i=1;
int suma=0;
while(i<=100)
{
    Console.WriteLine("La suma antes: "+suma);
    Console.WriteLine("El i antes: "+i);

    suma += i;
    i++;
    Console.WriteLine("La suma despues: "+suma);
    Console.WriteLine("El i antes: "+i);

    
}
Console.WriteLine("La suma de 1 a 100 es: "+suma);
*/
/*
Console.WriteLine("Ingresar un número");
int numero=int.Parse(Console.ReadLine());

int i = 1;

while(i<=10){
    Console.WriteLine($"{numero} x {i} = {numero*i}");

    i++;
}*/

//DO WHILE
/*
int i=0;
do{
    Console.WriteLine("El contador: "+i);
    i++;
}while(i<5);

int suma=0;
i=1;
do{
    Console.WriteLine("La suma antes: "+suma);
    Console.WriteLine("El i antes: "+i);

    suma += i;
    i++;
    Console.WriteLine("La suma despues: "+suma);
    Console.WriteLine("El i antes: "+i);
}while(i<=100);
Console.WriteLine("La suma de 1 a 100 es: "+suma);

int numero=10;
i = 1;
do{
    Console.WriteLine($"{numero} x {i} = {numero*i}");

    i++;
}while(i<=10);
*/

/*
int opcion;

do
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Opción 1");
    Console.WriteLine("2. Opción 2");
    Console.WriteLine("3. Opción 3");
    Console.WriteLine("4. Salir");
    Console.Write("Elija una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Elegiste la Opción 1.");
            break;
        case 2:
            Console.WriteLine("Elegiste la Opción 2.");
            break;
        case 3:
            Console.WriteLine("Elegiste la Opción 3.");
            break;
        case 4:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, inténtelo de nuevo.");
            break;
    }
} while (opcion != 4);

Console.WriteLine("Programa terminado.");
*/
/*
Random random = new Random();
int objetivo = random.Next(1, 101);
int adivinanza;

do
{
    Console.Write("Adivina el número (entre 1 y 100): ");
    adivinanza = int.Parse(Console.ReadLine());

    if (adivinanza > objetivo)
    {
        Console.WriteLine("¡Demasiado alto!");
    }
    else if (adivinanza < objetivo)
    {
        Console.WriteLine("¡Demasiado bajo!");
    }
} while (adivinanza != objetivo);

Console.WriteLine("¡Felicidades! Adivinaste el número.");
*/
//ARREGLOS
/*
int[] numeros = { 1, 2, 3, 4, 5 };
for(int i=0;i<numeros.Length;i++)
{
    Console.WriteLine("Elemento en el indice "+i+": "+numeros[i]);
}*/
/*
int[] numeros = { 15, 22, 8, 19, 31, 4 };
int maximo = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > maximo)
    {
        maximo = numeros[i];
    }
}

Console.WriteLine("El valor máximo es: " + maximo);
*/
/*
int[] numeros = { 10, 20, 30, 40, 50 };
Console.Write("Ingrese un número para buscar: ");
int buscar = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscar)
    {
        Console.WriteLine("Número encontrado en la posición: " + i);
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("Número no encontrado en el arreglo.");
}
*/