{==> Leitura dos elementos de um Vetor (de inteiros e positivos) - Tamanho
     L�gico;
 ==> Exibir os elementos de um Vetor;
 ==> Consulta de um determinado elemento - informando a posi��o que o mesmo
     se encontra no Vetor;
 ==> Exclus�o de um determinado elemento.}
{--------------MODULARIZANDO-----------------------------------------------}

Program AULA2ABC;

Uses NewDelay, Crt;

Const TF=10;

{==============================================================}
   {Vari�veis Globais}
Var Vetor: Array[1..TF] of integer;
    TL: integer;

{==============================================================}

Procedure Moldura;
var k:integer;
Begin
     ClrScr;
     {Moldura}
     TextColor(15);    {Cor de frente}
     TextBackGround(2);  {Cor de fundo}
     Gotoxy(1,1); Write(CHR(201));
     Gotoxy(79,1); Write(CHR(187));
     Gotoxy(1,25); Write(CHR(200));
     Gotoxy(79,25); Write(CHR(188));
     For k:=2 to 78 do
     begin
         gotoxy(k,1); write(CHR(205));
         gotoxy(k,25); write(CHR(205));
     end;
     For k:=2 to 24 do
     begin
         gotoxy(1,k); write(CHR(186));
         gotoxy(79,k); write(CHR(186));
     end;
end;

{==============================================================}
     {Leitura dos elementos de um vetor}
Procedure Leitura;
var AuxNum, k: integer;
begin
     Moldura;
     k:=3;       {k => Controle de linha}
     gotoxy(5,k); Write('Digite um valor (inteiro e posivito) - 0 para Sair: ');
     ReadLn(AuxNum);

     While (AuxNum>0) and (TL<TF) do
     begin
          TL:= TL+1;      { INC(TL); }
          Vetor[TL] := AuxNum;
          inc(k);
          gotoxy(5,k); Write('Digite um valor (inteiro e posivito) - 0 para Sair: ');
          ReadLn(AuxNum);
     end;
end;

{==============================================================}
     {Lista todos os elementos de um vetor}
Procedure Listar;
var k, Indice: integer;
begin
     Moldura;
     k:=15; {k => Controle de linha}
     gotoxy(20,k); Write('# # #  ELEMENTOS DO VETOR  # # #');
     For Indice:=1 to TL do
     begin
          inc(k);
          gotoxy(10,k);
          Write('Vetor na posi��o ',Indice,' ==> ', Vetor[Indice]);
     end;
     ReadKey;
end;

{==============================================================}
     {... Continuar posicionando... os "textos" na tela ...}

     {Consulta um determinado elemento e retorna a posi��o que o mesmo
      se encontra}
Procedure Consulta;
var AuxNum, Indice: integer;
begin
     Moldura;
     Write('Qual elemento procurar? ');  Readln(AuxNum);
     Indice:=1;
     While (Indice<=TL) and (AuxNum<>Vetor[Indice]) do
             INC(Indice);    {Indice:= Indice+1;}

     If (AuxNum=Vetor[Indice])
     then Write('O Elemento foi encontrado na posi��o ',Indice)
     else Write('Elemento n�o encontrado!');

     ReadKey;
end;

{==============================================================}
     {Excluir um determinado elemento}
Procedure Excluir;
var AuxNum, Indice, k: integer;
begin
     Moldura;
     Write('Qual elemento excluir? ');  Readln(AuxNum);
     Indice:=1;
     While (Indice<=TL) and (AuxNum<>Vetor[Indice]) do
             INC(Indice);    {Indice:= Indice+1;}

     If (AuxNum=Vetor[Indice])
     then  Begin
                For k:=Indice to TL-1 do
                    Vetor[k]:= Vetor[k+1];

                TL:=TL-1;     {DEC(TL);}
           End;
end;

{==============================================================}

Function Menu: integer;
var Op: integer;
begin
    Moldura;
    Writeln('# # # Menu de Op��es # # #');
    Writeln('[1] - Leitura');
    Writeln('[2] - Consulta');
    Writeln('[3] - Exclus�o');
    Writeln('[4] - Listar Elementos');
    Writeln('[5] - Finalizar');
    Writeln('Op��o Desejada: '); Readln(Op);
    Menu:= Op;
end;

{==============================================================}

Procedure Execucao;
var Opcao: integer;
begin
    Repeat
        Opcao:= Menu;
        Case Opcao of
          1: Leitura;
          2: Consulta;
          3: Excluir;
          4: Listar;
        end;
    Until (Opcao=5);
end;

{Programa Principal}
Begin
     Execucao;
End.


