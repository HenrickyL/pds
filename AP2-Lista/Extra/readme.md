# Sistema de Notificações com Design Patterns

Este projeto implementa um sistema de notificações para gerenciar tarefas utilizando os princípios **SOLID** e os **Design Patterns**: Singleton, Strategy e Observer.

## Descrição do Sistema

O sistema gerencia tarefas (chamadas de `Activity`) e envia notificações baseadas na prioridade das tarefas. Ele atende aos seguintes requisitos:

1. **Notificações Baseadas em Prioridade**:
   - **Alta prioridade**: Notificar imediatamente por SMS e e-mail.
   - **Média prioridade**: Notificar apenas por e-mail no final do dia.
   - **Baixa prioridade**: Apenas armazenar logs das alterações realizadas na tarefa.

2. **Sistema de Observadores**:
   - Observadores (como notificações por e-mail, SMS ou armazenamento de logs) podem ser cadastrados para reagir automaticamente às alterações nas tarefas.

3. **Centralização e Consistência**:
   - O sistema de notificações é gerenciado por uma instância única para garantir consistência, implementada através do padrão **Singleton**.

## Design Patterns Aplicados

1. **Singleton**:
   - Usado na classe `NotificationManager` para garantir que haja apenas uma instância responsável por gerenciar notificações no sistema.

2. **Observer**:
   - Observadores (e.g., `EmailNotifier`, `SMSNotifier`, `LogStorage`) são notificados automaticamente sobre eventos relacionados às tarefas.

3. **Strategy**:
   - Diferentes estratégias de notificação (`HighPriorityStrategy`, `MediumPriorityStrategy`, `LowPriorityStrategy`) encapsulam o comportamento de notificação baseado na prioridade da tarefa.

## Estrutura do Código

- **NotificationManager**: Gerencia as notificações e a lista de observadores.
- **Observers**: Recebem notificações do `NotificationManager`. Exemplos incluem:
  - `EmailNotifier`: Envia e-mails.
  - `SMSNotifier`: Envia SMS.
  - `LogStorage`: Armazena logs das alterações.
- **NotificationStrategy**: Define o comportamento de notificação baseado na prioridade da tarefa.
  - `HighPriorityStrategy`: Notifica imediatamente.
  - `MediumPriorityStrategy`: Notifica no final do dia.
  - `LowPriorityStrategy`: Apenas registra logs.
- **TaskItem**: Representa uma tarefa no sistema, com suporte para alterar o status e disparar notificações.

