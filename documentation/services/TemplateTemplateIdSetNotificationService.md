# TemplateTemplateIdSetNotificationService

A list of all methods in the `TemplateTemplateIdSetNotificationService` service. Click on the method name to view detailed information about that method.

| Methods                                                       | Description               |
| :------------------------------------------------------------ | :------------------------ |
| [SetTemplateNotificationAsync](#settemplatenotificationasync) | Set template notification |

## SetTemplateNotificationAsync

Set template notification

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/set_notification`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | SetTemplateNotificationRequest | ✅       | The request body. |
| templateId | string                         | ✅       |                   |
| accept     | string                         | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new SetTemplateNotificationRequest(Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<integer>"));

var response = await client.TemplateTemplateIdSetNotification.SetTemplateNotificationAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
