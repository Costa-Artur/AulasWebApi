List<int> numeros = new List<int>{1,2,3,4,5};

//Retornar primeiro elemento que encontrar, porque nao tem condição
int primeiroNumero = numeros.FirstOrDefault();
Console.WriteLine(primeiroNumero);

//Retorna o valor 4
//Retorna primeiro numero maior que 3
int primeiroNumeroMaiorqueTres = numeros.FirstOrDefault(n => n>3);
Console.WriteLine(primeiroNumeroMaiorqueTres);

//Não encontrou nenhuma correspondencia por isso retorna 0
// "0" é o valor padrão para int
int primeiroNumeroMaiorQueCinco = numeros.FirstOrDefault(n => n>5);
Console.WriteLine(primeiroNumeroMaiorQueCinco);

//Não encontrou nenhuma correspondencia, portanto retorna "100"
//"100" é o vaor que definimos como padrçao se nenhuma correspondência fosse encontrada
int primeiroNumeroMaiorQueSete = numeros.FirstOrDefault(n => n > 7, 100);
Console.WriteLine(primeiroNumeroMaiorQueSete);