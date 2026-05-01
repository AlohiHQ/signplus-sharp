# PlaceholdersService

A list of all methods in the `PlaceholdersService` service. Click on the method name to view detailed information about that method.

| Methods                                                                             | Description                                                     |
| :---------------------------------------------------------------------------------- | :-------------------------------------------------------------- |
| [SetEnvelopeAttachmentsPlaceholdersAsync](#setenvelopeattachmentsplaceholdersasync) | Placeholders to be set, completely replacing the existing ones. |

## SetEnvelopeAttachmentsPlaceholdersAsync

Placeholders to be set, completely replacing the existing ones.

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/attachments/placeholders`

**Parameters**

| Name       | Type                                      | Required | Description       |
| :--------- | :---------------------------------------- | :------- | :---------------- |
| input      | SetEnvelopeAttachmentsPlaceholdersRequest | ✅       | The request body. |
| envelopeId | string                                    | ✅       |                   |
| accept     | string                                    | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var placeholdersItem = new SetEnvelopeAttachmentsPlaceholdersRequestPlaceholders(Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"));
var placeholders = new List<SetEnvelopeAttachmentsPlaceholdersRequestPlaceholders>() { placeholdersItem };
var input = new SetEnvelopeAttachmentsPlaceholdersRequest(Optional<List<SetEnvelopeAttachmentsPlaceholdersRequestPlaceholders>?>.Of(placeholders));

var response = await client.Placeholders.SetEnvelopeAttachmentsPlaceholdersAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
