#include <stdio.h>
#include <math.h>
#include<string.h>
int main()
{
    //Declaracion de variables
    FILE *archivo_l;
    float tasa_interes_anual,cantidad_prestamo,sumas_total = 0,Cinteres = 0, pgmensual = 0;
    int plazo,menu,Cplazo = 0;;
    char Nom_archivo[12],nombre[12];;


    printf("\n\t Bienvenido\n");

    do//presentacion del menu
    {
        printf("\n\t ¿Que desea hacer?\n\n");
        printf("0 - Salir\n");
        printf("1 - Calcula tu prestamo\n");
        printf("2 - Guardar\n");
        scanf("%d",&menu);

        switch(menu)
        {

        case 0: //Si la opcion es 0 el programa se cerrara

            printf("\n\n\tGracias por confiar en nosotros\n");

            return 0;//Lo que cierra el programa
            break;


        case 1: //Si la opcion es 1 se calcula la deuda

            fflush(stdin); //limpia el buffer
            printf("Ingrese su nombre: ");
            gets(nombre);//escribe dentro de la variable nombre

            printf("Ingrese el monto del prestamo: ");
            scanf("%f", &cantidad_prestamo); //guarda el valor asignado

            sumas_total = cantidad_prestamo;//guarda el valor asignado

            printf("Ingrese la tasa de interes anual (porcentaje): ");
            scanf("%f", &tasa_interes_anual);//guarda el valor asignado
            Cinteres = tasa_interes_anual;//guarda el valor asignado

            printf("Ingrese el plazo del prestamo en meses: ");
            scanf("%d", &plazo);//guarda el valor asignado
            Cplazo = plazo;//guarda el valor asignado

            float tasa_interes_mensual = tasa_interes_anual / 12.0 / 100.0;//calcula el interes por meses de la deuda
            float tinteres_m = tasa_interes_mensual;//guarda el valor asignado

            float pago_mensual;

            pago_mensual = cantidad_prestamo * (tasa_interes_mensual / (1 - pow((1 + tasa_interes_mensual), -plazo)));
            /*se calcula el pago mensual con la formula de un prestamo amortizado
            La formula quiere decir = La cantidad de la deuda * el interes mensual de la misma / 1 - 1 + el mismo interes mensual
            elevado al plazo en negativo */


            printf("Mes\tSaldo restante\tPago principal\tPago interes\tPago total\n");
            float saldo_prestamo = cantidad_prestamo;

            for ( int mes = 1; mes <= plazo; mes++)//Inicia un bucle que se repetira dependiendo del plazo asignado
            {
                float pago_interes = saldo_prestamo * tasa_interes_mensual;
                //formula para calcula el pago del interes multiplicando el interes por el capital que se debe

                float pago_principal = pago_mensual - pago_interes;
                //Y lo que se va a abonar a la deuda directamnte en cada mes

                cantidad_prestamo  -= pago_mensual; //restando lo que se paga a la deuda
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       if(cantidad_prestamo<=0) { cantidad_prestamo = 0; }
                printf("%d\t%.2f\t\t%.2f\t\t%.2f\t\t%.2f\n", mes, cantidad_prestamo, pago_principal, pago_interes, pago_mensual); // Presenta los detalles del préstamo para el mes actual
            }

            break;

        case 2://Guardar los detalles del préstamo en un archivo

               /*En esta parte seria basicamente  lo mismas formulas de la opcion 1 pero con las
                 diferentes variables que almacenaban el valor de las  demas variables*/

            pgmensual = sumas_total * (tinteres_m / (1 - pow((1 + tinteres_m), -plazo)));

            fflush(stdin);//limpia el buffer
            printf("Indique el nombre y el formato del archivo \n");
            printf("'Asegurese de indicar el nombre y el formato del archivo de la manera correcta'\n");

            memset(Nom_archivo, 0, sizeof(Nom_archivo));//limpia la variable colocando 0 bytes en la variable en cuestion

            gets(Nom_archivo);//guarda lo que se escriba


            FILE *archivo_l = fopen(Nom_archivo, "w");//Abre el archivo en escritura
            if (archivo_l == NULL)
                /*si el archivo devuelve null, ya sea por los permisos no los tiene
                    o por falta de memoria, no se crea el archivo*/

            {
                printf("No se pudo hacer el archivo.\n");
                break;
            }

            fprintf(archivo_l,"Nombre \tMes\tDeuda resntante\tPago principal\tPago interes\tPago total\n");

            for ( int mes = 1; mes <= plazo; mes++)//El mismo bucle anterior pero con las variables correspondientes
            {


                float pago_interes = sumas_total * tinteres_m;

                float pago_principal = pgmensual - pago_interes;

                sumas_total -= pgmensual;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if(sumas_total <= 0)    {  sumas_total = 0;}

       fprintf(archivo_l,"%s \t%d\t%.2f\t\t%.2f\t\t%.2f\t\t%.2f\n",nombre, mes, sumas_total, pago_principal, pago_interes, pgmensual);
            }

            fclose(archivo_l);//cierra el archivo


            printf("\nLos datos del archivo han sido leidos exitosamente.\n");
            break;

        }

    }
    while(menu != 0);//Si el menu es diferente de 0 seguira ejecutandose hasta que lo sea



    return 0;
}
