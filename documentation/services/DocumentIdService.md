# DocumentIdService

A list of all methods in the `DocumentIdService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description           |
| :---------------------------------------------------- | :-------------------- |
| [GetEnvelopeDocumentAsync](#getenvelopedocumentasync) | Get envelope document |

## GetEnvelopeDocumentAsync

Get envelope document

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/document/{document_id}`

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

var response = await client.DocumentId.GetEnvelopeDocumentAsync("envelope_id", "document_id", "application/json");

Console.WriteLine(response);
```
