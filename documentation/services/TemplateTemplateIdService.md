# TemplateTemplateIdService

A list of all methods in the `TemplateTemplateIdService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description     |
| :------------------------------------------ | :-------------- |
| [GetTemplateAsync](#gettemplateasync)       | Get template    |
| [DeleteTemplateAsync](#deletetemplateasync) | Delete template |

## GetTemplateAsync

Get template

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}`

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

var response = await client.TemplateTemplateId.GetTemplateAsync("template_id", "application/json");

Console.WriteLine(response);
```

## DeleteTemplateAsync

Delete template

- HTTP Method: `DELETE`
- Endpoint: `/template/{template_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.TemplateTemplateId.DeleteTemplateAsync("template_id");

Console.WriteLine(response);
```
