#include <stdio.h>
int main(){
	float number;
	printf("Adj meg egy számot\n");
	scanf("%f", &number);
	if(number > 0){
		printf("A szám pozitiv\n");
	}
	else if(number < 0){
		printf("A szám negativ\n");
	}
	else
	{
		printf("A megadott szám a 0\n");
	}
	return 0;
}
