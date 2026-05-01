# CertificateService

A list of all methods in the `CertificateService` service. Click on the method name to view detailed information about that method.

| Methods                                                               | Description                                        |
| :-------------------------------------------------------------------- | :------------------------------------------------- |
| [DownloadEnvelopeCertificateAsync](#downloadenvelopecertificateasync) | Download certificate of completion for an envelope |

## DownloadEnvelopeCertificateAsync

Download certificate of completion for an envelope

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/certificate`

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

var response = await client.Certificate.DownloadEnvelopeCertificateAsync("envelope_id", "application/pdf");

Console.WriteLine(response);
```
