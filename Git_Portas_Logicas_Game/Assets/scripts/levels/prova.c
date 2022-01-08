#include<stdio.h>
#include <stdlib.h>

int notas[9] = {0, 0, 0, 0, 0, 0, 0, 0, 0,};

void update(int * teclas, int a, int b) {
	int i;
	
	for(i = 0; i< 9 ; i++) {
	notas[i] = 0;
	}
	
	for(i = a; i <= b ; i++) {
	notas[teclas[i]]++;
}

	int max = 0, f;
	for (i = 9; i >= 0; i--) {
	 if (notas[i] > max) {
	   max = notas [i];
	   f = i;	
	 }
	}

	for (i = a; i <= b ; i++) {
	  teclas[i] = (teclas[i] + f) % 9;
	}
	
}

int main() {
	int qTeclas, qAcordes, i, j;
	int a, b;
	
	scanf("%d", &qTeclas);
	scanf("%d", &qAcordes);
	
	int * teclas = (int *) malloc(sizeof(int) * qTeclas);
	
	for(i = 0; i< qAcordes ; i++) {
		teclas[i] = 1;
	}
	
	for(i = 0; i < qAcordes ; i++) {
		scanf("%d", &a);
		scanf("%d", &b);
		
		
		//atualizar as teclas a e b
		update(teclas, a, b);
	
	
	}
		
	for(j = 0; j< qAcordes ; j++) {
		printf("%d\n" , teclas[j]);			
   }
	
	free(teclas);
	
 	return 0;		
}
