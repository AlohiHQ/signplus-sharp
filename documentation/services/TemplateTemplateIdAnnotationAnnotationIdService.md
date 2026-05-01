# TemplateTemplateIdAnnotationAnnotationIdService

A list of all methods in the `TemplateTemplateIdAnnotationAnnotationIdService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                |
| :-------------------------------------------------------------- | :------------------------- |
| [DeleteTemplateAnnotationAsync](#deletetemplateannotationasync) | Delete template annotation |

## DeleteTemplateAnnotationAsync

Delete template annotation

- HTTP Method: `DELETE`
- Endpoint: `/template/{template_id}/annotation/{annotation_id}`

**Parameters**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| templateId   | string | ✅       |             |
| annotationId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.TemplateTemplateIdAnnotationAnnotationId.DeleteTemplateAnnotationAsync("template_id", "annotation_id");

Console.WriteLine(response);
```
