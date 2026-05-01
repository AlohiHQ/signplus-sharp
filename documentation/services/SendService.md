# SendService

A list of all methods in the `SendService` service. Click on the method name to view detailed information about that method.

| Methods                                 | Description                 |
| :-------------------------------------- | :-------------------------- |
| [SendEnvelopeAsync](#sendenvelopeasync) | Send envelope for signature |

## SendEnvelopeAsync

Send envelope for signature

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/send`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.Send.SendEnvelopeAsync("envelope_id", "application/json");

Console.WriteLine(response);
```
