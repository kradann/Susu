#include <stdio.h>
int main(){
	float number = 6;
	float input;
	printf("Kérlek add meg a másik számot");
	scanf("%f", &input);
	printf("A két szám átlaga %.3f",(input+number)/2 );
	return 0;
}

