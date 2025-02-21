# Sistema de Notifica��es com Design Patterns

Este projeto implementa um sistema de notifica��es para gerenciar tarefas utilizando os princ�pios **SOLID** e os **Design Patterns**: Singleton, Strategy e Observer.

## Descri��o do Sistema

O sistema gerencia tarefas (chamadas de `Activity`) e envia notifica��es baseadas na prioridade das tarefas. Ele atende aos seguintes requisitos:

1. **Notifica��es Baseadas em Prioridade**:
   - **Alta prioridade**: Notificar imediatamente por SMS e e-mail.
   - **M�dia prioridade**: Notificar apenas por e-mail no final do dia.
   - **Baixa prioridade**: Apenas armazenar logs das altera��es realizadas na tarefa.

2. **Sistema de Observadores**:
   - Observadores (como notifica��es por e-mail, SMS ou armazenamento de logs) podem ser cadastrados para reagir automaticamente �s altera��es nas tarefas.

3. **Centraliza��o e Consist�ncia**:
   - O sistema de notifica��es � gerenciado por uma inst�ncia �nica para garantir consist�ncia, implementada atrav�s do padr�o **Singleton**.

## Design Patterns Aplicados

1. **Singleton**:
   - Usado na classe `NotificationManager` para garantir que haja apenas uma inst�ncia respons�vel por gerenciar notifica��es no sistema.

2. **Observer**:
   - Observadores (e.g., `EmailNotifier`, `SMSNotifier`, `LogStorage`) s�o notificados automaticamente sobre eventos relacionados �s tarefas.

3. **Strategy**:
   - Diferentes estrat�gias de notifica��o (`HighPriorityStrategy`, `MediumPriorityStrategy`, `LowPriorityStrategy`) encapsulam o comportamento de notifica��o baseado na prioridade da tarefa.

## Estrutura do C�digo

- **NotificationManager**: Gerencia as notifica��es e a lista de observadores.
- **Observers**: Recebem notifica��es do `NotificationManager`. Exemplos incluem:
  - `EmailNotifier`: Envia e-mails.
  - `SMSNotifier`: Envia SMS.
  - `LogStorage`: Armazena logs das altera��es.
- **NotificationStrategy**: Define o comportamento de notifica��o baseado na prioridade da tarefa.
  - `HighPriorityStrategy`: Notifica imediatamente.
  - `MediumPriorityStrategy`: Notifica no final do dia.
  - `LowPriorityStrategy`: Apenas registra logs.
- **TaskItem**: Representa uma tarefa no sistema, com suporte para alterar o status e disparar notifica��es.

