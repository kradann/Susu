#include <stdio.h>

int main(){
	printf("Adjon meg egy számot\n");
	int n;
	int sum =0;
	scanf("%d", &n);
	for(int i = 1; i<2*n;i+=2){
		sum += i;
		printf("%d\n", i);
	}
	printf("%d darab páratlan szám összege: %d\n", n,sum);
	return 0;
		
}	
