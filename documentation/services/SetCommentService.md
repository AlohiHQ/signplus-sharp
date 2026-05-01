# SetCommentService

A list of all methods in the `SetCommentService` service. Click on the method name to view detailed information about that method.

| Methods                                             | Description          |
| :-------------------------------------------------- | :------------------- |
| [SetEnvelopeCommentAsync](#setenvelopecommentasync) | Set envelope comment |

## SetEnvelopeCommentAsync

Set envelope comment

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_comment`

**Parameters**

| Name       | Type                      | Required | Description       |
| :--------- | :------------------------ | :------- | :---------------- |
| input      | SetEnvelopeCommentRequest | ✅       | The request body. |
| envelopeId | string                    | ✅       |                   |
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

var input = new SetEnvelopeCommentRequest(Optional<string?>.Of("string"));

var response = await client.SetComment.SetEnvelopeCommentAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
