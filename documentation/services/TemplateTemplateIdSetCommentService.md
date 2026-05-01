# TemplateTemplateIdSetCommentService

A list of all methods in the `TemplateTemplateIdSetCommentService` service. Click on the method name to view detailed information about that method.

| Methods                                             | Description          |
| :-------------------------------------------------- | :------------------- |
| [SetTemplateCommentAsync](#settemplatecommentasync) | Set template comment |

## SetTemplateCommentAsync

Set template comment

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/set_comment`

**Parameters**

| Name       | Type                      | Required | Description       |
| :--------- | :------------------------ | :------- | :---------------- |
| input      | SetTemplateCommentRequest | ✅       | The request body. |
| templateId | string                    | ✅       |                   |
| accept     | string                    | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new SetTemplateCommentRequest(Optional<string?>.Of("<string>"));

var response = await client.TemplateTemplateIdSetComment.SetTemplateCommentAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
