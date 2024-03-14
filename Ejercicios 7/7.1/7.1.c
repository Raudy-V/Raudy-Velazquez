#include <stdio.h>

int main(void) {
    char p1, p2, p3 = "$";

    printf("\nIngrese un caracter: ");
    p1 = getchar(); // Se utiliza la funci�n getchar para leer un caracter
    putchar(p1); // Se utiliza la funci�n putchar para escribir un caracter
    printf("\n");

  fflush(stdin);

  /* Luego de leer un caracter siempre es conveniente escribir la funci�n fflush
para limpiar el b�fer, porque generalmente queda con basura y genera un error
en la ejecuci�n del programa. El error se produce porque cuando se ingresa un
dato se oprime el return y luego cuando volvemos a leer un caracter o una
cadena de caracteres se toma a ese return como el nuevo dato ingresado. */

    printf("\nEl caracter p3 es: ");
    putchar(p3); // Se utiliza la funci�n putchar para escribir el caracter almacenado en p3
    printf("\n");

    return 0; // Agregar un valor de retorno para main
}
