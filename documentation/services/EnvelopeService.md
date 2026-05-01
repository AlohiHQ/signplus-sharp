# EnvelopeService

A list of all methods in the `EnvelopeService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description         |
| :------------------------------------------ | :------------------ |
| [CreateEnvelopeAsync](#createenvelopeasync) | Create new envelope |

## CreateEnvelopeAsync

Create new envelope

- HTTP Method: `POST`
- Endpoint: `/envelope`

**Parameters**

| Name   | Type                  | Required | Description       |
| :----- | :-------------------- | :------- | :---------------- |
| input  | CreateEnvelopeRequest | ✅       | The request body. |
| accept | string                | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new CreateEnvelopeRequest(Optional<string?>.Of("7ox22"), Optional<string?>.Of("SES"), Optional<double?>.Of(5681), Optional<string?>.Of("string"), Optional<bool?>.Of(false));

var response = await client.Envelope.CreateEnvelopeAsync(input, "application/json");

Console.WriteLine(response);
```
