# api-dotnet-dev

### Dependencies
* NancyFX
* NewtonsoftJSON
* Log4Net


### Structure

**Core**
Contains the main methods, Fibonacci and XML2JSON

**Unit Tests**
Can be found in  a separate project

**API**
Can be found in a REST project

### Testing the API
* Clone this project
* Use an API proxy (eg: Postman)


#### Fibonacci
``` GET /fibo/{n} ``` 

#### XML2JSON
``` POST /xml2json , Request body contains xml input```` 


### Copyright
This example used few snippets from :
* Converting from XML to JSON - http://www.newtonsoft.com/json/help/html/convertingjsonandxml.htm
* Adding Log4net to NancyFX - http://www.philhack.com/wire-up-log4net-to-nancy/
