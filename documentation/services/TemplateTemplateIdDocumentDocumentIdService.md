# TemplateTemplateIdDocumentDocumentIdService

A list of all methods in the `TemplateTemplateIdDocumentDocumentIdService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description           |
| :---------------------------------------------------- | :-------------------- |
| [GetTemplateDocumentAsync](#gettemplatedocumentasync) | Get template document |

## GetTemplateDocumentAsync

Get template document

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/document/{document_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |
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

var response = await client.TemplateTemplateIdDocumentDocumentId.GetTemplateDocumentAsync("template_id", "document_id", "application/json");

Console.WriteLine(response);
```
