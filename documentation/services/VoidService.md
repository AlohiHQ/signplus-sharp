# VoidService

A list of all methods in the `VoidService` service. Click on the method name to view detailed information about that method.

| Methods                                 | Description   |
| :-------------------------------------- | :------------ |
| [VoidEnvelopeAsync](#voidenvelopeasync) | Void envelope |

## VoidEnvelopeAsync

Void envelope

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/void`

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

var response = await client.Void_.VoidEnvelopeAsync("envelope_id", "application/json");

Console.WriteLine(response);
```
