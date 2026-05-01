# WebhookIdService

A list of all methods in the `WebhookIdService` service. Click on the method name to view detailed information about that method.

| Methods                                   | Description    |
| :---------------------------------------- | :------------- |
| [DeleteWebhookAsync](#deletewebhookasync) | Delete webhook |

## DeleteWebhookAsync

Delete webhook

- HTTP Method: `DELETE`
- Endpoint: `/webhook/{webhook_id}`

**Parameters**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| webhookId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.WebhookId.DeleteWebhookAsync("webhook_id");

Console.WriteLine(response);
```
