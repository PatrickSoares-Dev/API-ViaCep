# Sistema de Consumo de API de CEP

Este é um sistema simples desenvolvido em C# que consome uma API de CEP para buscar informações de endereço. Ele utiliza a biblioteca Refit para facilitar a integração com a API ViaCEP.

## Biblioteca Utilizada

A biblioteca Refit foi utilizada neste projeto para simplificar a comunicação com a API ViaCEP. Ela permite criar interfaces que representam os endpoints da API e gera automaticamente o código necessário para realizar as requisições HTTP.

## Lógica do Sistema

A lógica do sistema consiste nos seguintes passos:

1. O sistema solicita que o usuário informe um CEP.
2. O CEP informado é utilizado para fazer uma consulta à API ViaCEP através da interface `ICepApiService`.
3. A biblioteca Refit realiza a requisição HTTP ao endpoint da API ViaCEP.
4. A API retorna um objeto JSON contendo as informações do endereço correspondente ao CEP.
5. O sistema utiliza a biblioteca Newtonsoft.Json para desserializar o objeto JSON em uma instância da classe `CepResponse`.
6. As informações do endereço, como logradouro, bairro, cidade e complemento, são exibidas no console.
