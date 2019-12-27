Cannon Lord - Job Test

1.Como executar:
	A versão para windows e WebGL estão no link: https://drive.google.com/drive/folders/11cb0K2iFtaPwd8GD7gIvk8YEPE6PkgwI?usp=sharing
	
  Versão windows: Baixe a pasta Windows Build e execute Cannon Lord - Job Test.exe 
	
  Versão Web: Baixe a pasta WEBuild, e execute o arquivo com o Mozila Firefox, caso não funcione, na barra de pesquisa digite about:config e pesquise por privacy.file_unique_origin, coloque esta opção como falso e o jogo funcionará normalmente.

2.Instruções do jogo:
  - Para iniciar o jogo o jogador deve apertar o botão de PLay no canto superior esquerdo.
  - Existem dois tipos de movimentação: Automática e manual, a movimentação automática move o canhão sem que o jogador precise fazer algo, o modo manual faz com que o canhão olhe para a posição do mouse, para alternar entre elas basta clicar no botão Toggle Movimentation, no canto superior direito.
  - Para atirar use o botão esquerdo do mouse.
  - o jogador perde se a sua vida chegar a 0.

3.Como o código foi organizado:
	Toda e qualquer mecânica dentro do jogo foi separada por funções para facilitar o entendimento de qualquer pessoa que pegue o projeto, os nomes de variaveis e funções são descritivos e fazem exatamente o que o seu nome diz. 

4.Listagem dos pontos adicionais:
- Export para Web:
    - Foi realizada a build para web utilizando a ferramenta de build para web da unity
- Melhorias no jogo:
  - Foram adicionados, tipos de inimigos com a possibilidade de inserção de mais variações de inimigos (utilizando Scriptable Objects), inimigos que tem caracteristicas como, vida, velocidade, sprite, dano, pontuação e cor.	  
  - Foi adicionado mais um tipo de movimentação extra, onde o canhão está sempre olhando para a posição no mouse
  - O botão de atirar foi substituido pelo pressionar do botão esquerdo do mouse.
  - O jogador agora tem uma barra de vida que é atualizada a cada vez que ele toma dano, tendo uma tela de game over caso a vida chegue em zero
  - Foi adicionado um contador de tempo de jogo mais amigável ao jogador.

As melhorias adicionais foram todas feitas em uma média de 3 horas, espaçadas entre as outras funções do projeto
