#include <stdio.h>
void swap(int *a, int *b){
	int tmp = *a;
	*a = *b;
	*b = tmp;;
}

int add(int *elso, int *utolso){
	int sum = 0;
	while( elso <= utolso){
		sum += *elso;
		elso++;
	}
	return sum;
}


int main(){
	int c = 2;
	int d = 5;
	printf("c: %d, d: %d\n", c,d);
	swap(&c,&d);
	printf("c: %d, d: %d\n", c, d);
	int array[] = {1,2,3,4,5};
	int ered = add(array, &array[4]);
	printf("%d\n", ered);
	return 0;
	
}
