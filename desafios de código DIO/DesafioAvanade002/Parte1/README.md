# Desafios de Código Coding The Future Avanade ll
<h3 align="center"> 1 / 3 - Calculando o Dano</p>


## Desafio

Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

    dano = ataque - defesa


Se o valor do dano for negativo, ele deve ser considerado zero.
Entrada:

Seu programa deverá receber uma  entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.
Saída:

A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída:

    "O dano causado pelo ataque foi: 2"

## Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

<div align=center>
<table>
  <tr>
    <th>Entrada</th>
    <th>Saída</th>
  </tr>
  <tr>
    <td>10<br> 8</td>
    <td>O dano causado pelo ataque foi: 2</td>
  </tr>
  <tr>
    <td>3 <br> 9</td>
    <td>O dano causado pelo ataque foi: 0</td>
  </tr>
  
  <tr>
    <td>7 <br> 1</td>
    <td>O dano causado pelo ataque foi: 6</td>
  </tr>
  
</table>
</div>
<div align="center">

[Enunciado retirado de bootcamp da plataforma DIO®](https://web.dio.me)

</div>