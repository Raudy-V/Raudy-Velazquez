#include<stdio.h>


int main(void){

int factura[5];
int total = 0;


factura[0] = 1500;
factura[1] = 100;
factura[2] = 800;
factura[3] = 0;
factura[4] = 0;

for(int i = 0;i < 5;i++){

    total += factura[i];

printf("\nEl valor de su factura es: %d\t",factura[i]);

}
printf("\nEL valor total:\n\n %d", total);

return 0;
}
