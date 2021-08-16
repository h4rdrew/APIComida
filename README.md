# APIComida
Testes API + Angular

> ## Endpoints:
- [Alimentos]
  - [[GET] ​/alimentos​/listar_alimentos](#get-listar_alimentos)
  - [[POST] ​/alimentos​/cadastrar_alimento](#get-cadastrar_alimento)
  - [[GET] ​/alimentos​/buscar_alimento](#get-buscar_alimento)
  - [[GET] ​/alimentos​/buscar_alimento_guid](#get-buscar_alimento_guid)
  - [[GET] ​/alimentos​/random_alimentos](#get-random_alimentos)
  - [[POST] ​/alimentos​/atualizar_alimento](#get-atualizar_alimento)

# Alimentos

## [GET] ​/alimentos​/listar_alimentos
Lista todos os alimentos cadastrados.

OUTPUT
~~~c#
Guid? ID
string Nome
TipoAlimento TipoAlimento
~~~
EXEMPLO:
~~~JSON
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "string",
  "tipoAlimento": 1
}
~~~

## [POST] ​/alimentos​/cadastrar_alimento
Cadastra alimento.

Parâmetros:
>  * `(string) NomeAlimento` [OBRIGATÓRIO]
>  * `(int/string) TipoAlimento` [OBRIGATÓRIO]

~~~C#
  public enum TipoAlimento
  {
      Proteina = 1,
      Carboidrato = 2,
      Gordura = 3,
      Vitamina = 4,
  }
~~~

## [GET] ​/alimentos​/buscar_alimento
Busca alimento por nome do alimento.

Parâmetros:
>  * `(string) NomeAlimento` [OBRIGATÓRIO]

OUTPUT
~~~c#
Guid? ID
string Nome
TipoAlimento TipoAlimento
~~~
EXEMPLO:
~~~JSON
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "string",
  "tipoAlimento": 1
}
~~~

## [GET] ​/alimentos​/buscar_alimento_guid
Busca alimento por GUID do alimento.

Parâmetros:
>  * `(Guid) Guid` [OBRIGATÓRIO]

OUTPUT
~~~c#
Guid? ID
string Nome
TipoAlimento TipoAlimento
~~~
EXEMPLO:
~~~JSON
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "string",
  "tipoAlimento": 1
}
~~~

## [GET] ​/alimentos​/random_alimentos
Busca apenas 4 alimentos aleatórios.

OUTPUT
~~~c#
Guid? ID
string Nome
TipoAlimento TipoAlimento
~~~
EXEMPLO:
~~~JSON
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "string",
  "tipoAlimento": 1
}
~~~

## [POST] ​/alimentos​/atualizar_alimento
Atualiza o cadastro do alimento por GUID inserido.

Parâmetros:
>  * `(Guid) Guid` [OBRIGATÓRIO]
