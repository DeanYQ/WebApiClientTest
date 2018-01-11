# WebApiClientTest
for web api client http test

## Test Api

| Path              | Http Method   | body                  | Description                        |
| ----------------- | ------------- | --------------------- | ---------------------------------- |
| /get/ok           | GET           | N/A                   | Ok("Return OK");                   |
| /get/BadRequest   | GET           | N/A                   | BadRequest("Return bad request");  |
| /get/InternalServerError | GET    | N/A                   | InternalServerError();             |
| /get/Exception    | GET           | N/A                   | InternalServerError(new Exception("Return Empty Exception"));|
| /get/StatusCode   | GET           | N/A                   | StatusCode(HttpStatusCode.Accepted);|
| /get/Unauthorized | GET           | N/A                   | Unauthorized();                    |
| /get/Json         | GET           | N/A                   | Json(new{ Name = "testName", Age = 13 });|

The API also contains the POST/PUT/DELETE method. Change the Path prefix and invoke the targeted method api.