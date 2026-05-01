# WebhookService

A list of all methods in the `WebhookService` service. Click on the method name to view detailed information about that method.

| Methods                                   | Description    |
| :---------------------------------------- | :------------- |
| [CreateWebhookAsync](#createwebhookasync) | Create webhook |

## CreateWebhookAsync

Create webhook

- HTTP Method: `POST`
- Endpoint: `/webhook`

**Parameters**

| Name   | Type                 | Required | Description       |
| :----- | :------------------- | :------- | :---------------- |
| input  | CreateWebhookRequest | ✅       | The request body. |
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

var input = new CreateWebhookRequest(Optional<string?>.Of("ENVELOPE_VOIDED"), Optional<string?>.Of("<string>"));

var response = await client.Webhook.CreateWebhookAsync(input, "application/json");

Console.WriteLine(response);
```
