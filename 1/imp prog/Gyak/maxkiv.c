#include <stdio.h>
int getMax(int a[]int size){
	int max = a[0];
	for(int i = 1; i<size;i++)
	{
		if(t[i]>max){
			max = t[i];
		}

	}
	return max;	
}
int main(){
	int t[10] = {12,3421,34,342,34,54,34,45,34,919191};
	int max = getMax(t, sizeof(t)/sizeof(t[0]);
	printf("%d",max);
	return 0;
}
