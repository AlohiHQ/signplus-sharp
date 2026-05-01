# FileIdService

A list of all methods in the `FileIdService` service. Click on the method name to view detailed information about that method.

| Methods                                           | Description                  |
| :------------------------------------------------ | :--------------------------- |
| [GetAttachmentFileAsync](#getattachmentfileasync) | Get envelope attachment file |

## GetAttachmentFileAsync

Get envelope attachment file

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/attachments/{file_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |
| fileId     | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.FileId.GetAttachmentFileAsync("envelope_id", "file_id", "application/octet-stream");

Console.WriteLine(response);
```
