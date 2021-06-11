using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variavéis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estuturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estuturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estuturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estuturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estuturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do/While - Estuturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estuturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estuturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estuturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estuturas de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params- Classes e Metodos", Params.Executar},
                {"Parametros Nomeados- Classes e Metodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"ReadOnly - Classes e Metodos", ReadOnly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct Vs Classe- Classes e Metodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros Por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros com Valor Padrão - Classes e Metodos", ParametroPadrao.Executar},
                {"teste", CalculadoraRenan.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", colecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDicionary.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulmento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lambda - Metodo e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegates - Metodo e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Metodo e Funções", UsandoDelegates.Executar},
                {"Delegates com Função Anonima - Metodo e Funções", DelegateFuncAnonima.Executar},
                {"Delegates como Parametros - Metodo e Funções", DelegatesComoParametros.Executar},
                {"Metodos de Extensão - Metodo e Funções", MetodosDeExtensao.Executar},

                // Excecoes
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalidas- Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo Date Time - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                
                //Topicos avançados
                 {"LINQ #01 - Topicos Avançados", LINQ1.Executar},
                 {"LINQ #02 - Topicos Avançados", LINQ2.Executar},
                 {"Nullables - Topicos Avançados", Nullables.Executar},
                 {"Dynamic - Topicos Avançados", Dynamic.Executar},
                 {"Genericos - Topicos Avançados", Genericos.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}