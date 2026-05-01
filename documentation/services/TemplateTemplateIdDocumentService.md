# TemplateTemplateIdDocumentService

A list of all methods in the `TemplateTemplateIdDocumentService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description           |
| :---------------------------------------------------- | :-------------------- |
| [AddTemplateDocumentAsync](#addtemplatedocumentasync) | Add template document |

## AddTemplateDocumentAsync

Add template document

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/document`

**Parameters**

| Name       | Type                       | Required | Description       |
| :--------- | :------------------------- | :------- | :---------------- |
| input      | AddTemplateDocumentRequest | ✅       | The request body. |
| templateId | string                     | ✅       |                   |
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

var input = new AddTemplateDocumentRequest(Optional<byte[]?>.Of(new byte[] {}));

var response = await client.TemplateTemplateIdDocument.AddTemplateDocumentAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
