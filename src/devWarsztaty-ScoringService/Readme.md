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
    "mortgage" : false,
    "age" : 12
} 
```

Response body :
```json
{
    "eligible" : true
}
```

###
1. If Country is not Poland then validate fails 
2. If Mortgage exist then validate fails

###
1. Add Age to the Request
2. If Age is less than 21 then validate fails