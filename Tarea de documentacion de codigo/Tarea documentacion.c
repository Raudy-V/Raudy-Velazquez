#include <time.h>
 
#define ARRAY_SIZE 10
 
int i;
int change;
int n;
int a[ARRAY_SIZE];
int buf;
time_t seed;
 
int main(int argc, char* argv[])
{
    //inicio generacion de numeros
    seed = 0;
    srand(time(&seed));
    n = sizeof(a) / sizeof(*a);
 
    for (i = 0; i <= n-1; i++)
    {
        a[i] = rand() % 1000;
    }
    //fin generacion de numeros
 
    for (i = 0; i <= n-1; i++)
    {
        printf("Element a[%d]: %d\n", i, a[i]);
    }
    /*inicio algoritmo BubleSort*/
    change = 1; //iguala la variable a 1
    while (change == 1) //Crea un bucle y da la condicion del mismo que es: cuando(change) sea igual a 1

    { //signo que indica la apertura del bucle while
        change = 0; //iguala el valor de la variable a 0

        for (i = 0; i <= n-2; i++) //Abre otro bucle y establece la condicion de que i tiene que ser menor/igual a n-2
        { //signo de apertura de bucle for
        
            if (a[i] > a[i+1]) //Abre una condicion que es: cuando el numero en i sea mayor que el siguiente de este
            { //Signo de apertura de condicional if

                buf = a[i]; //la bariable buf se iguala al componente del arreglo en cuestion 
                a[i] = a[i+1]; //pasa al siguiente componente del arreglo o podrimos decir que a[i] toma el valor del elemento en a[i+1]
                a[i+1] = buf;// El componente de a[i+1] toma el valor de buf
                change = 1; //Se iguala la variable a 1 para que el bucle vuelva a realizarse
            }//se cierra la condicional
        }//se cierra bucle for

    }//se cierra bucle while

    /*fin algorimo*/

/* Podriamos decir que este algoritmo bublesort, el proposito de este es organizar datos 
estos lo hace mediante el intercambio  de datos en el condicional if, cambiando en escala piramidal
ya sea en la condicion que se le asigne
*/






    printf("\n-------------------\n");
    for (i = 0; i <= n-1; i++)
    {
        printf("Element a[%d]: %d\n", i, a[i]);
    }
    return 0;
}