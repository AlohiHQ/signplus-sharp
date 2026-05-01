# SettingsService

A list of all methods in the `SettingsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                      |
| :-------------------------------------------------------------------------- | :------------------------------- |
| [SetEnvelopeAttachmentsSettingsAsync](#setenvelopeattachmentssettingsasync) | Set envelope attachment settings |

## SetEnvelopeAttachmentsSettingsAsync

Set envelope attachment settings

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/attachments/settings`

**Parameters**

| Name       | Type                                  | Required | Description       |
| :--------- | :------------------------------------ | :------- | :---------------- |
| input      | SetEnvelopeAttachmentsSettingsRequest | ✅       | The request body. |
| envelopeId | string                                | ✅       |                   |
| accept     | string                                | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var settings = new SetEnvelopeAttachmentsSettingsRequestSettings(Optional<string?>.Of("<boolean>"));
var input = new SetEnvelopeAttachmentsSettingsRequest(Optional<SetEnvelopeAttachmentsSettingsRequestSettings?>.Of(settings));

var response = await client.Settings.SetEnvelopeAttachmentsSettingsAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
