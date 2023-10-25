#include <stdio.h>
#include <math.h>
int main(){
	printf("Adja meg a kör sugarát\n");
	float r = 0;
	scanf("%f", &r);
	printf("A kör átmérője :%f\n",2*r);
	float k = 2*r*M_PI;
	float t = r*r*M_PI;
	printf("A kör kerülete: %f, a területe %f\n", k,t);
}

