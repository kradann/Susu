#include <stdio.h>
#include <stdlib.h> //random fgv
#include <time.h> //időhöz kötés
int make_a_guess()
{
	int a;
	scanf("%d", &a);
	return a;
}

int evealute(int guess, int to_guess){
	if(guess<to_guess){
		return 1;
	}else if(guess>to_guess){
		return -1;
	}
	else{
		return 0;
	}
}
int main(){
	int tipp;
	srand(time(0));	
	int adott =rand()%31;
	int try = 0;
	int result;
	printf("Szam megadasa\n");
	//scanf("%d", &adott);
	do{
		
		printf("Adjon meg a tippjét\n");
		tipp = make_a_guess();
		result = evealute(tipp, adott);
		if(tipp<adott)
			printf("a tipp kisebb\n");
		if(tipp> adott)
			printf("a tipp nagyobb\n");
		try++;
	}while(result);
	switch(try)
		{
			case 1:
				printf("uges vagy");
				break;
			case 2:
				printf("uges vagy");
				break;
			default:
				printf("bena vagy");
				break;
		}
	return 0;
}


	


