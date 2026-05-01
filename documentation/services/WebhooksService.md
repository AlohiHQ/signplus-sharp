# WebhooksService

A list of all methods in the `WebhooksService` service. Click on the method name to view detailed information about that method.

| Methods                                 | Description   |
| :-------------------------------------- | :------------ |
| [ListWebhooksAsync](#listwebhooksasync) | List webhooks |

## ListWebhooksAsync

List webhooks

- HTTP Method: `POST`
- Endpoint: `/webhooks`

**Parameters**

| Name   | Type                | Required | Description       |
| :----- | :------------------ | :------- | :---------------- |
| input  | ListWebhooksRequest | ✅       | The request body. |
| accept | string              | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new ListWebhooksRequest(Optional<string?>.Of("<string>"), Optional<string?>.Of("ENVELOPE_COMPLETED"));

var response = await client.Webhooks.ListWebhooksAsync(input, "application/json");

Console.WriteLine(response);
```
