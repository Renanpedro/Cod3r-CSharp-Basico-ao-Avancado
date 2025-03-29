# Cod3r - C# Completo
Link do curso - https://www.udemy.com/course/curso-c-sharp/

# Introdução
**Linguagem natural x Artificial** - Natural linguagem humana, artificial a linguagem de programação C#, JavaScript e etc.., artificial não aceita ambiguidade.
**Estrutura de dados** - Ela organiza os dados definindo regras para os dados de como eles deverão ser utilizados.
**Fifo - first in first out**  -  O primeiro a chegar é o primeiro a sair
**Lifo - last in first out**  - O ultimo a chegar é o primeiro a sair

**O que é .NET?**
É o framework (contém funcionalidades para ajudar a construir um sistema) é a estrutura para desenvolver a aplicação, C# é a linguagem de programação utilizada.
.NET - Windows, Mac e Linux é separado em duas partes CLR(Ele traduz o código do C# o “ILcode” para o código de máquina) e LIB(Conjunto de bibliotecas pré prontas).

# FUNDAMENTOS (Variáveis, Tipos, Formatação Números, Operações Aritméticas, Relacionais e Lógicas)
**Arquitetura de Solução .NET** - Começa definindo uma solução(Projetos (Assembly pode gerar arquivos .Exe e DLL código compilado que pode ser compartilhado com multiplos projetos)) para a aplicação contendo pastas e arquivos.

**NO C#:**
SOLUÇÃO → PROJETOS → NAMESPACE (DIFERENTES DE PASTAS) → CLASSES (DIFERENTES DE ARQUIVOS)

**Atalhos Visual Studio**
CRTL + K + D - Para formatar o código de forma automática
CRTL + K + C - Para comentar o trecho selecionado
CRTL + K + U - para descomentar o trecho de código
CTRL + TAB - Para ir navegando entre os arquivos abertos

**Inferência** - Ao declarar uma variavel com o tipo VAR após a mesma ser iniciada não será possivel ela aceitar valores diferentes do tipo iniciado. Exemplo uma váriavel VAR NOME = “Renan” não poderá receber valores númericos pois foi iniciada como uma string.

**Expressão Lógica**
^ Exclusivo - Inverte o falor da expressão
Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False

**Operador Ternário (?)**
var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado” (Se a nota for maior que 7 está aprovado caso contrario reprovado)

# ESTRUTURA DE CONTROLE (IF, ELSE, SWITCH, WHILE, DO WHILE, FOR, FOREACH, BREAK e Continue)
**Estrutura de Controle**
IF 
IF ELSE
SWTICH CASE

**Estrutura de Repetição**
FOR - Utilizado para uma quantiade pre-determinada de repetições.
For(Declarar e iniciar varivael; condição; incremento) → For(int i = 0; i < 10; i++).
WHILE - utilizado para uma quantidade indertemidade de repetições Se for verdadeiro executa o bloco de código dentro do while.
DO/WHILE - Sempre executar o Do pelo menos uma vez e caso no final o While seja verdadeiro irá retornar para o DO e ficara executnado em LOOP.
ForEach(para cada) - Irá percorrer do primeiro ao ultimo elemento de uma variavel, vetor e etc e armazenar na variável declarada.

# CLASSES E MÉTODOS (Classe, Objeto, Construtor, Metodo, Get/Set, ReadOnly, Enum, Struct,Ref/Out)

**Classe X Struct** - Utilizando o Struct a atribuição será feita por valor e nao referencia (São espaços de memoria diferentes), usando a classe a atribuição e feita por referência (Compartilham o mesmo espaço de memoria).

**Classe == Tipo**
- Classe vai definir uma estrutura de dados personalizada, uma estrutura de dados que eu irei criar.
- Dentro de uma classe temos atributos(dados ex com pessoa: nome, cpf, altura, peso) e Comportamentos(Métodos/Algoritmos).
- Objeto é a instancia de uma classe, ira possui os atributos e comportamentos que a classe possuir.
    var carro1 = new Carro();

**Métodos** - Um método é um bloco de código que contém uma série de instruções, caso não seja void e necessário informar o tipo de retorno e dentro do metodo colocar o Return. o metodo precisa ter uma assinatura única “public double somar(Assinatura)”. Métodos com void são metodos que nao retornam nada;
**Construtor** - Apartir do construtor que um objeto é criado. (Não é necessario informar o tipo de retorno a IDE ja sabe que o tipo é a classe), caso não seja criado um construtor cada classe sempre terá o seu construtor padrão
**Static** - Siginifca que o metodo não pertence ao objeto e sim a classe, eu nao preciso instanciar o objeto para poder usar os metodos, neste caso eu irei utilizar os metodos através da classe.
    Se a variavel for STATIC ela deixara de ser por intancia e sera por classe sendo assim as variaveis que tiverem nas instancas terão o valor fixo da varivel com STATIC
**.format()** - Retorna uma string formatada, faz a mesma coisa que o writeline mas ao invés de imprimir no console ele retorna uma string formatada.
**.THIS** -  retora para a instancia atual que estou utilizando.
**GetSet** - Metodos publicos para fazer as alterações possiveis em atributos get(ler) e Set(Alterar).
**ReadOnly** - Torna o valor imutavel após o valor ser setado o mesmo não poderá ser alterado novamente, só podera ser alterado no construtor.
**Enum** - Enum é um tipo mas para valores já pré definidos.


**PARAMETROS IN, OUT, REF e Params**
In - Ele será um parametro de entrada, eu irei receber a referencia do numero mas o mesmo não podeera ser alterado.
Ref - Quando usa a passagem por referencia ao passar o valor de entrada ele não passa um novo valor de memoria e sim ele referencia ao endereço de memoria da variavel passada, no caso abaixo a variavel “num” irá valer 100.
Out - Argumento de entrada que também é de saida, caso eu tenha um metodo que eu necessite retornar dois valores, na declaração do metodo eu posso informar uma variavel como (OUT tipo Nome) esta variavel irá compartilhar o mesmo espaço de memoria com a variavel de fora do metodo. Eu passo uma varivavel e quando o metodo terminar ele me retorna essa variavel
params - Argumentos variados posso passar quantos parametros eu quiser para um método, cada elemento passado será guardado em uma posição do array por causa da utilização da palavra reservada params.

# Coleções (Array, List, ArrayList, Set, Queue, Stack, Dictionary)
**Array** - Estrutura que serve para guardar dados, o mesmo funciona com um espaço fixo já definido.
**List** - Algo parecido com o Array porém não precisa informar a quantidade de itens, Quando eu precisar criar uma estrutura dinamica que irá armazenar uma quantidade de valores indeterminada posso usar o List, diferente do array. 
    Para usar o comando LIST é necessário importar a bibliotece (System.Collections.Generic;)
**ArrayList** - Diferente do List o ArrayList consegue receber itens de diferentes tipos ele funciona de forma heterogenea recebendo dados misturados (int, string, double, boolean…)
    utiliza a biblioteca - using System.Collections;
**HashSet** - Estrutura que não é indexada não tem como pegar o elemento com indice, remover com base em indicie e afins, é uma lista que não aceita repetição.
**Queue(Lista)** - Cria uma lista ordenada, podendo receber só um tipo ou vários tipos o primeiro a entrar é o primeiro a sair.
    Usa a biblioteca:  using System.Collections; e using System.Collections.Generic;
**Equals e GetHashCode** 
    Equals compara referência de memoria mas é possível implementar o Equals para que o mesmo realize a comparação por valor.
**GetHashCode** - Mesma coisa que o Equals mas será utilizado no caso de listas criadas utilizando o hashset
**Stack** -  É uma fila onde o primeiro a entrar será o ultimo a sair seria um Queue ao contrário.
    utiliza a biblioteca - using System.Collections;
**Dictionary** - é uma estrutura chave valor que não aceita repetição na chave mas aceita repetição no valor.

# ORIENTAÇÃO A OBJETO (Abstração, Herança, Encapsulamento, Polimorfismo e Tipos de Visibilidade)
Os 4 pilares da OO (Abstração, Herença, Encapsulamento e Polimorfismo):
**Abstração** - Serve para modelar o mundo real em um Software
- Se importa definir algo unico que existe no mundo real.
- Mapear os atributos e comportamentos que fazem sentido serem incluídos no software.

**Herança** - Serve para aplicarmos o Reuso de código.
- É uma forma de receber atributos e comportamentos de outra classe (Classe pai e Filha).
- Se um atributo for privado não é transferido por herança.
- Só é possivel fazer herança com uma classe.
    Ex: Class Humano : Animal - Forma de realizar a herança a classe Humano irá herdar os atributos e comportamentos da classe animal.

**Encapsulamento** - Tem o objetivo de proteger os dados internos de um objeto, permitindo o acesso controlado através de métodos específicos.

**Polimorfismo(Múltiplas Formas)** - Ele pode ser divido em duas partes Estatica e Dinamico
Estatica - Funciona como uma sobrecarga de metodo, dois metodos com o mesmo nome dentro do mesmo contexto porém com a assinatura diferente.
Dinamico - Serve para instancaiar um tipo mais especifico para atribuir um tipo mais generico.

**Tipos de Visibilidade**
Public - Qualquer lugar até fora do projeto podera usar os membros declarados como publico (variavel, metdo, calass e afins).
Internal - Só podera ser acessado dentro do projeto.
Protected - É transmitido por herança. quando um membro for Protected caso alguém precise acessar o mesmo antes precisara realizar uma herança.
Private - Só é visto dentro da classe.
Override - Serve para sobreescrever um código da classe pai, se eu chamar um metodo da classe pai já com um valor se eu quiser sobreescrever o mesmo preciso usar o override.
Classe concreta (class normal)- Todos os membros da classe estão definidos.
Classe Abstrata - Pode ser 100% implementa ou 100% não implementada Só tem uma classe abstrata caso tenha alguma classe que herde a mesma, se marcar uma classe como abstrata a mesma nao podera ser instanciada.
    se tiver um metodo abstrato caso uma classe concreta herde a classe a abstrrata o metodo abstrato precisara ser implementado.
Interface - Todos os metodos de uma interface são abstratos, apenas define a estruura do metodo, eles são por padrão publicos
Sealed -  Classe selada proibi qualquer tipo de herança, e membros com seales nao pode ser sobreescrito.

# Metodos e Funções (Lambda, Delegate, Metodos de Extensão)
Lambda(= >) = é uma função anomina que armazena em uma variavel.
Delegate - é um tipo que armazena uma assinatura de uma função.
Metodo com Extensão - Na assinatura do metodo posso colocar um this diz que eu irei criar uma função de extensão.

# TOPICOS AVANÇADOS
LINQ - Linguagem de consulta integrada.
Nullables - Serve para colocar nulo em algum tipo de variavel.
Dynamic - Dynamic é um tipo de varíavel que não é fortemente tipada a mesma pode receber diferentes tipos de valores ao decorrer do codigo.
Generics - é uma classe generica que no momento que esta sendo instanciada você informar de que tipo são os elementos desta classe.
