#include <stdio.h>
#include <math.h>
double ker(double a, double b){
	
	return (a+2*b);
}

double ter(double a, double b){
	return sqrt((a*(b*b-a*a))/2);
}
int main(){
	printf("Adja meg a háromszög oldalait\n");
	double a;
	scanf("%lf",&a);
	double b;
	scanf("%lf",&b);
	double kerulet;
	kerulet = ker(a,b);
	double terulet;
	terulet = ter(a,b);
	printf("A háromszög kerülete %.3lf\n",kerulet);
	printf("A háromszög területe %.3lf\n",terulet);
	return 0;
}
