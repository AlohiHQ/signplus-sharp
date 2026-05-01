# TemplateTemplateIdAnnotationsService

A list of all methods in the `TemplateTemplateIdAnnotationsService` service. Click on the method name to view detailed information about that method.

| Methods                                                     | Description              |
| :---------------------------------------------------------- | :----------------------- |
| [GetTemplateAnnotationsAsync](#gettemplateannotationsasync) | Get template annotations |

## GetTemplateAnnotationsAsync

Get template annotations

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/annotations`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.TemplateTemplateIdAnnotations.GetTemplateAnnotationsAsync("template_id", "application/json");

Console.WriteLine(response);
```
