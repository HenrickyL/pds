# Revisão 

## Princípios de Projeto Orientado a Objetos
Software degradam, logo são necessários alguns padrões.
 * code smells: rigidez, fragilidade, imobilidade, viscosidade, complexidadede desnecessária, ...

### GRASP
  - conceito e modelagem
### PPOO (SOLID)
  - [ ] **Responsabilidade Única**
    - Responsabilidades: classes que sabem(guardam) e as que fazem(processam).
    - Classes coesas
  - [ ] **Aberto/Fechado**
    - Aberto para extensão e Fechado para Modificações
    - Aberto: ter mais coisas que a classe que extende; Fechado: não pode deixar de ter o que o pai tem;
    - filho tem que ser substituto perfeito do pai;
    - "Programa pra uma interface não para uma implementação" - Gof
      - Acoplado com classe concreta (err) - amarrado ao contrato e a implementação
      - Acoplamento com abstração (ok)
  - [ ] **Substituição de Liskov**
    - Filhos tem que ser Substitutos da classe pai.
    - comportamento esperado
  - [ ] **Segregação de Interfaces**
    - Clientes n"ao devem ser forçados a depender de métodos que não usam.

------
* Prova: 23/01 - GRASP PPOO
------
Trabalho
* Diagrama de classes
* Codigo
* Documento - explicando a escolha do padrão com parte de código