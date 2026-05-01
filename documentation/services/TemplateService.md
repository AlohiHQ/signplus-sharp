# TemplateService

A list of all methods in the `TemplateService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description         |
| :------------------------------------------ | :------------------ |
| [CreateTemplateAsync](#createtemplateasync) | Create new template |

## CreateTemplateAsync

Create new template

- HTTP Method: `POST`
- Endpoint: `/template`

**Parameters**

| Name   | Type                  | Required | Description       |
| :----- | :-------------------- | :------- | :---------------- |
| input  | CreateTemplateRequest | ✅       | The request body. |
| accept | string                | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new CreateTemplateRequest(Optional<string?>.Of("9AF5Q5BuJY8"));

var response = await client.Template.CreateTemplateAsync(input, "application/json");

Console.WriteLine(response);
```
