# TemplateTemplateIdAttachmentsSettingsService

A list of all methods in the `TemplateTemplateIdAttachmentsSettingsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                      |
| :-------------------------------------------------------------------------- | :------------------------------- |
| [SetTemplateAttachmentsSettingsAsync](#settemplateattachmentssettingsasync) | Set template attachment settings |

## SetTemplateAttachmentsSettingsAsync

Set template attachment settings

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/attachments/settings`

**Parameters**

| Name       | Type                                  | Required | Description       |
| :--------- | :------------------------------------ | :------- | :---------------- |
| input      | SetTemplateAttachmentsSettingsRequest | ✅       | The request body. |
| templateId | string                                | ✅       |                   |
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

var settings = new SetTemplateAttachmentsSettingsRequestSettings(Optional<bool?>.Of(false));
var input = new SetTemplateAttachmentsSettingsRequest(Optional<SetTemplateAttachmentsSettingsRequestSettings?>.Of(settings));

var response = await client.TemplateTemplateIdAttachmentsSettings.SetTemplateAttachmentsSettingsAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
