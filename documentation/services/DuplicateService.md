# DuplicateService

A list of all methods in the `DuplicateService` service. Click on the method name to view detailed information about that method.

| Methods                                           | Description        |
| :------------------------------------------------ | :----------------- |
| [DuplicateEnvelopeAsync](#duplicateenvelopeasync) | Duplicate envelope |

## DuplicateEnvelopeAsync

Duplicate envelope

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/duplicate`

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

var response = await client.Duplicate.DuplicateEnvelopeAsync("envelope_id", "application/json");

Console.WriteLine(response);
```
