#include <stdio.h>

void add(int *ptr){
	*ptr += 1;

}

int main()
{
	int i = 3;
	add(&i);
	printf("%d\n",i);
}
