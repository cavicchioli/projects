#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

void cria(FILE *Arq);
void converte(FILE *Arq);

void cria(FILE *Arq)
{
    Arq=fopen("Ex_1.txt","w+");

    char tecla;

    printf("Digite o texto para convercao:");

    do
    {
        tecla=getche();

        if(tecla!=27)
         fputc(tecla,Arq);

         if(tecla==13)
         {
            fputc('\n',Arq);
            printf("\n");
         }

    }while(tecla!=27);
    fclose(Arq);
}

void converte(FILE *Arq)
{
    Arq=fopen("Ex_1.txt","r+");
    FILE *Arq2=fopen("Ex_1a.txt","w+");
    
    char palavra[100];
    
    fgets(palavra,100,Arq);
    
    while(!feof(Arq))
    {
      strupr(palavra);
      fputs(palavra,Arq2);
      printf("%s",palavra);
      
      fgets(palavra,100,Arq);
    }
    fclose(Arq);
    fclose(Arq2);
}

int main()
{
 FILE *A;
 cria(A);
 converte(A);
 getch();
}

