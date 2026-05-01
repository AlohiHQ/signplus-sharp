# SetNotificationService

A list of all methods in the `SetNotificationService` service. Click on the method name to view detailed information about that method.

| Methods                                                       | Description               |
| :------------------------------------------------------------ | :------------------------ |
| [SetEnvelopeNotificationAsync](#setenvelopenotificationasync) | Set envelope notification |

## SetEnvelopeNotificationAsync

Set envelope notification

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_notification`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | SetEnvelopeNotificationRequest | ✅       | The request body. |
| envelopeId | string                         | ✅       |                   |
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

var input = new SetEnvelopeNotificationRequest(Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<double?>.Of(4732));

var response = await client.SetNotification.SetEnvelopeNotificationAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
