# Programação orientada a objetos

Um objeto é uma abstração de algo real;

Um objeto possui propriedades (características), métodos (ações) e eventos (coisas que acontecem quando uma ação é tomada).

No C# usamos class para montar um objeto por possuir características, métodos, eventos e ser um tipo de referência (guarda o endereço do valor), diferentemente do struct que é um tipo de valor (armazena apenas o valor). Isso facilita usar o código em diferentes locais da aplicação.

Tipo de referência significa que se temos uma informação em algum lugar na aplicação e nós a mudamos, todos os locais que usam essa informação recebem a nova informação também.

## Encapsulamento
Agrupar o que faz sentido estar junto. Ver código exemplo

## Abstrações
Esconder o que não precisa ser mostrado. Ver código exemplo

## Herança
A capacidade de um objeto herdar propriedades, métodos e eventos de outros objetos

## Polimorfismo
A capacidade de um objeto, método ou classe poder ter várias formas.

## Modificadores de acesso
No C# podemos adicionar modificadores que permitem métodos serem sobrescritos (virtual; na classe pai / override; na classe filha) deve haver Herança para isso acontecer.
pai > public virtual void Pagar(){}
filho > public override void Pagar(){}

## Propriedades
São uma forma de trabalhar ao invés de usar variáveis, tem um atalho no C# que é o prop.
São aqueles com {get; set;}

## Métodos
Trazem tudo o que as funções já possuem e incrementam com os modificadores de acesso.
