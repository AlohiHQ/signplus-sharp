# SetExpirationDateService

A list of all methods in the `SetExpirationDateService` service. Click on the method name to view detailed information about that method.

| Methods                                                           | Description                  |
| :---------------------------------------------------------------- | :--------------------------- |
| [SetEnvelopeExpirationDateAsync](#setenvelopeexpirationdateasync) | Set envelope expiration date |

## SetEnvelopeExpirationDateAsync

Set envelope expiration date

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_expiration_date`

**Parameters**

| Name       | Type                             | Required | Description       |
| :--------- | :------------------------------- | :------- | :---------------- |
| input      | SetEnvelopeExpirationDateRequest | ✅       | The request body. |
| envelopeId | string                           | ✅       |                   |
| accept     | string                           | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new SetEnvelopeExpirationDateRequest(Optional<string?>.Of("<integer>"));

var response = await client.SetExpirationDate.SetEnvelopeExpirationDateAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
