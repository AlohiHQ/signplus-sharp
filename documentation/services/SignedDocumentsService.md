# SignedDocumentsService

A list of all methods in the `SignedDocumentsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                       | Description                               |
| :---------------------------------------------------------------------------- | :---------------------------------------- |
| [DownloadEnvelopeSignedDocumentsAsync](#downloadenvelopesigneddocumentsasync) | Download signed documents for an envelope |

## DownloadEnvelopeSignedDocumentsAsync

Download signed documents for an envelope

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/signed_documents`

**Parameters**

| Name                    | Type   | Required | Description                                                             |
| :---------------------- | :----- | :------- | :---------------------------------------------------------------------- |
| envelopeId              | string | ✅       |                                                                         |
| accept                  | string | ✅       |                                                                         |
| certificateOfCompletion | string | ❌       | Whether to include the certificate of completion in the downloaded file |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.SignedDocuments.DownloadEnvelopeSignedDocumentsAsync("envelope_id", "application/pdf", "true");

Console.WriteLine(response);
```
