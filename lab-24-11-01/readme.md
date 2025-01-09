# Aula dia 1 Nov

## EBC (Entidade, fronteira, Controlador)

User -> Fronteira -> controladores -> Entindade

* **Fronteira** (Entrada e saída): Telas ou API Externa
* **Controladores**: Controle de fluxo e regras

## Jogo da Forca

* Escolha de tema
* Sortear palavra
* Iniciar partida
* Player tem acesso a tela com a palavra
* Ele escolhe uma letra
* Verifica se a letra existe na palavra
  * Se não está devo remover uma vida
  * Se está devo mostrar a letra
* O usuário pode falar uma letra ou uma palavra


## EBC

* Menu | Board: Fronteira
    - Pega a lista de temas
    - Permite a escolha do tema
    <!-- - Permite iniciar o jogo -->
    - Permite escolher:
      - Seleciona uma letra
      - Chutar palavra

* Controlador:
  - Retorna os temas
  - Recebe o tema escolhido  e retorna a palavra sorteada
  - Verifica se a palavra chutada é correta
  - Verifica se a letra chutada pertence a palavra
    - Remove Vida e adiciona a letra nas erradas

* Entidades:
  - Player
  - Game
