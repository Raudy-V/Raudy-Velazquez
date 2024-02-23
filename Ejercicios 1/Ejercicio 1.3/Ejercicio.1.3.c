#include<stdio.h>

int main(void) {
  int Cla,S1,S2,S3,S4,S5,S6;
  float ing_sem = 0,pro_m = 0;
  

  printf("Ingrese su contraseña: ");
  scanf("%d", &Cla);
  
  printf("Ingrese sus primeros 6 sueldos: ");
  scanf("%d %d %d %d %d %d", &S1, &S2, &S3, &S4, &S5, &S6);

ing_sem = S1 + S2 + S3 + S4 + S5 + S6;
  pro_m = ing_sem / 6;
  
  printf("Clave del empleado: %d\n", Cla);
  
    printf("Ing_sem: %.2f\n", ing_sem);
    printf("Promedio mensual: %.2f\n", pro_m);
}