# EnvelopeIdService

A list of all methods in the `EnvelopeIdService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description     |
| :------------------------------------------ | :-------------- |
| [GetEnvelopeAsync](#getenvelopeasync)       | Get envelope    |
| [DeleteEnvelopeAsync](#deleteenvelopeasync) | Delete envelope |

## GetEnvelopeAsync

Get envelope

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.EnvelopeId.GetEnvelopeAsync("envelope_id", "application/json");

Console.WriteLine(response);
```

## DeleteEnvelopeAsync

Delete envelope

- HTTP Method: `DELETE`
- Endpoint: `/envelope/{envelope_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.EnvelopeId.DeleteEnvelopeAsync("envelope_id");

Console.WriteLine(response);
```
