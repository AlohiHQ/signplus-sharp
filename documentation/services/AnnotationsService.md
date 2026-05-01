# AnnotationsService

A list of all methods in the `AnnotationsService` service. Click on the method name to view detailed information about that method.

| Methods                                                     | Description              |
| :---------------------------------------------------------- | :----------------------- |
| [GetEnvelopeAnnotationsAsync](#getenvelopeannotationsasync) | Get envelope annotations |

## GetEnvelopeAnnotationsAsync

Get envelope annotations

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/annotations`

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

var response = await client.Annotations.GetEnvelopeAnnotationsAsync("envelope_id", "application/json");

Console.WriteLine(response);
```
