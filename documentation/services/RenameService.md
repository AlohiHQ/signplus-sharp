# RenameService

A list of all methods in the `RenameService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description     |
| :------------------------------------------ | :-------------- |
| [RenameEnvelopeAsync](#renameenvelopeasync) | Rename envelope |

## RenameEnvelopeAsync

Rename envelope

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/rename`

**Parameters**

| Name       | Type                  | Required | Description       |
| :--------- | :-------------------- | :------- | :---------------- |
| input      | RenameEnvelopeRequest | ✅       | The request body. |
| envelopeId | string                | ✅       |                   |
| accept     | string                | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new RenameEnvelopeRequest(Optional<string?>.Of("<string>"));

var response = await client.Rename.RenameEnvelopeAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
