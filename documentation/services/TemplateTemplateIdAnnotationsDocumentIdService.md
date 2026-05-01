# TemplateTemplateIdAnnotationsDocumentIdService

A list of all methods in the `TemplateTemplateIdAnnotationsDocumentIdService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                       |
| :-------------------------------------------------------------------------- | :-------------------------------- |
| [GetDocumentTemplateAnnotationsAsync](#getdocumenttemplateannotationsasync) | Get document template annotations |

## GetDocumentTemplateAnnotationsAsync

Get document template annotations

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/annotations/{document_id}`

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

var response = await client.TemplateTemplateIdAnnotationsDocumentId.GetDocumentTemplateAnnotationsAsync("template_id", "document_id", "application/json");

Console.WriteLine(response);
```
