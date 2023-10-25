#include <stdio.h>

int main(){
	printf("Adjon meg egy dátumot egyben\n");
	int datum = 0;
	scanf("%d", &datum);
	int nap = 0;
	int honap = 0;
	int ev = 0;
	ev = datum %10000;
	honap = (datum / 10000)%100;
	nap = datum /1000000;
	
	printf("%d %d %d\n", ev, honap, nap);
	return 0;
	
}
