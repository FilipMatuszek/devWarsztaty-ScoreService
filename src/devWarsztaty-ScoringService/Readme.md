# Scoring Service

## Endpoints definitions

Verb : POST 
Path : /scores
Request body :
```json
{
    "name" : "jan",
    "lastName" : "kowalski",
    "country" : "Poland",
    "income" : 100000,
    "mortgage" : false
} 
```

Response body :
```json
{
    "eligible" : true
}
```