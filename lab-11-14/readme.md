# Aula dia 14/11

## Coesão x Acoplamento

```java
public interface SuperMega {
    public void iniciaPilhaComandos();
    public void iniciaRelatorio();
    public void iniciaDadosGlobais();
    public void empilhaComando(Object comando);
    public void formataRelatorio(Object relatorio);
    public void imprimiRelatorio(Object relatorio);
    public void desempilhaComando();
    public void finalizaPilhaComandos();
    public void finalizaDadosGlobais();
}
```

```java
public interface Comandos{
    public void iniciaPilhaComandos();
    public void finalizaPilhaComandos();
    public void empilhaComando(Comandos comando);
    public void desempilhaComando();
}

public interface Relatorio{
    public void iniciaRelatorio();
    public void formataRelatorio(Relatorio relatorio);
    public void imprimiRelatorio(Relatorio relatorio);
}

public interface BaseDeDados {
    public void iniciaDadosGlobais();
    public void finalizaDadosGlobais();
}


public interface SuperMega {
    public void initiate();
}
```


### Estrutura de projeto

Cada um tem suas vantagens e desvantagens

```
//camadas 

Controllers
Services
Views
Entities
```

```
Entidade1
    Controllers
    Services
    Views
Entidade2
    Controllers
    Services
    Views
```

### 

aumentar a coesão e diminuir o acoplamento