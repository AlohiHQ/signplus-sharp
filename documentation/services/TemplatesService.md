# TemplatesService

A list of all methods in the `TemplatesService` service. Click on the method name to view detailed information about that method.

| Methods                                   | Description    |
| :---------------------------------------- | :------------- |
| [ListTemplatesAsync](#listtemplatesasync) | List templates |

## ListTemplatesAsync

List templates

- HTTP Method: `POST`
- Endpoint: `/templates`

**Parameters**

| Name   | Type                 | Required | Description       |
| :----- | :------------------- | :------- | :---------------- |
| input  | ListTemplatesRequest | ✅       | The request body. |
| accept | string               | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var tags = new List<string>() { "<string>" };
var ids = new List<string>() { "<string>" };
var input = new ListTemplatesRequest(Optional<string?>.Of("<string>"), Optional<List<string>?>.Of(tags), Optional<List<string>?>.Of(ids), Optional<string?>.Of("<integer>"), Optional<string?>.Of("<integer>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("TEMPLATE_CREATION_DATE"), Optional<string?>.Of("<boolean>"));

var response = await client.Templates.ListTemplatesAsync(input, "application/json");

Console.WriteLine(response);
```
