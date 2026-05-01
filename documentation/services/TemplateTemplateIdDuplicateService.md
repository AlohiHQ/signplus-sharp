# TemplateTemplateIdDuplicateService

A list of all methods in the `TemplateTemplateIdDuplicateService` service. Click on the method name to view detailed information about that method.

| Methods                                           | Description        |
| :------------------------------------------------ | :----------------- |
| [DuplicateTemplateAsync](#duplicatetemplateasync) | Duplicate template |

## DuplicateTemplateAsync

Duplicate template

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/duplicate`

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

var response = await client.TemplateTemplateIdDuplicate.DuplicateTemplateAsync("template_id", "application/json");

Console.WriteLine(response);
```
