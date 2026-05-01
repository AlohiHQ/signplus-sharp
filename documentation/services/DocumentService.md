# DocumentService

A list of all methods in the `DocumentService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description           |
| :---------------------------------------------------- | :-------------------- |
| [AddEnvelopeDocumentAsync](#addenvelopedocumentasync) | Add envelope document |

## AddEnvelopeDocumentAsync

Add envelope document

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/document`

**Parameters**

| Name       | Type                       | Required | Description       |
| :--------- | :------------------------- | :------- | :---------------- |
| input      | AddEnvelopeDocumentRequest | ✅       | The request body. |
| envelopeId | string                     | ✅       |                   |
| accept     | string                     | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new AddEnvelopeDocumentRequest(Optional<byte[]?>.Of(new byte[] {}));

var response = await client.Document.AddEnvelopeDocumentAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
