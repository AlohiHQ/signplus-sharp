# TemplateIdService

A list of all methods in the `TemplateIdService` service. Click on the method name to view detailed information about that method.

| Methods                                                             | Description                       |
| :------------------------------------------------------------------ | :-------------------------------- |
| [CreateEnvelopeFromTemplateAsync](#createenvelopefromtemplateasync) | Create new envelope from template |

## CreateEnvelopeFromTemplateAsync

Create new envelope from template

- HTTP Method: `POST`
- Endpoint: `/envelope/from_template/{template_id}`

**Parameters**

| Name       | Type                              | Required | Description       |
| :--------- | :-------------------------------- | :------- | :---------------- |
| input      | CreateEnvelopeFromTemplateRequest | ✅       | The request body. |
| templateId | string                            | ✅       |                   |
| accept     | string                            | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new CreateEnvelopeFromTemplateRequest(Optional<string?>.Of("fND"), Optional<string?>.Of("<string>"), Optional<bool?>.Of(false));

var response = await client.TemplateId.CreateEnvelopeFromTemplateAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
