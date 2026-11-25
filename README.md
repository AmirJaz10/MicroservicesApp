# MicroservicesApp — TP8

Ce dépôt contient le TP8 consacré à une architecture de microservices .NET.

## Architecture

- **ApiGateway** utilise Ocelot pour router les requêtes vers les API.
- **OrdersAPI** publie un `OrderCreatedEvent` lorsqu’une commande est créée.
- **ProductsAPI** consomme cet événement avec MassTransit et décrémente `StockQte` pour le produit concerné.
- RabbitMQ sert de broker de messages entre OrdersAPI et ProductsAPI.

## Démarrer RabbitMQ

Le dépôt ne contient pas de fichier `docker-compose.yml`. Lancez RabbitMQ manuellement avec Docker Desktop :

```bash
docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
```

L’interface de gestion est disponible sur <http://localhost:15672>, avec les identifiants `guest` / `guest`.
