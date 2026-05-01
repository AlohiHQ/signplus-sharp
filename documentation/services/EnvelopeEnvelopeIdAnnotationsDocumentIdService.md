# EnvelopeEnvelopeIdAnnotationsDocumentIdService

A list of all methods in the `EnvelopeEnvelopeIdAnnotationsDocumentIdService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                       |
| :-------------------------------------------------------------------------- | :-------------------------------- |
| [GetEnvelopeDocumentAnnotationsAsync](#getenvelopedocumentannotationsasync) | Get envelope document annotations |

## GetEnvelopeDocumentAnnotationsAsync

Get envelope document annotations

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/annotations/{document_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |
| documentId | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.EnvelopeEnvelopeIdAnnotationsDocumentId.GetEnvelopeDocumentAnnotationsAsync("envelope_id", "document_id", "application/json");

Console.WriteLine(response);
```
