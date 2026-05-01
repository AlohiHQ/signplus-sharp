# DocumentsService

A list of all methods in the `DocumentsService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description            |
| :------------------------------------------------------ | :--------------------- |
| [GetEnvelopeDocumentsAsync](#getenvelopedocumentsasync) | Get envelope documents |

## GetEnvelopeDocumentsAsync

Get envelope documents

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/documents`

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

var response = await client.Documents.GetEnvelopeDocumentsAsync("envelope_id", "application/json");

Console.WriteLine(response);
```
