# SignplusService

A list of all methods in the `SignplusService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                       |
| :-------------------------------------------------------------------------- | :-------------------------------- |
| [CreateEnvelopeAsync](#createenvelopeasync)                                 | Create new envelope               |
| [CreateEnvelopeFromTemplateAsync](#createenvelopefromtemplateasync)         | Create new envelope from template |
| [ListEnvelopesAsync](#listenvelopesasync)                                   | List envelopes                    |
| [GetEnvelopeAsync](#getenvelopeasync)                                       | Get envelope                      |
| [DeleteEnvelopeAsync](#deleteenvelopeasync)                                 | Delete envelope                   |
| [GetEnvelopeDocumentAsync](#getenvelopedocumentasync)                       | Get envelope document             |
| [GetEnvelopeDocumentsAsync](#getenvelopedocumentsasync)                     | Get envelope documents            |
| [AddEnvelopeDocumentAsync](#addenvelopedocumentasync)                       | Add envelope document             |
| [SetEnvelopeDynamicFieldsAsync](#setenvelopedynamicfieldsasync)             | Set envelope dynamic fields       |
| [AddEnvelopeSigningStepsAsync](#addenvelopesigningstepsasync)               | Add envelope signing steps        |
| [SendEnvelopeAsync](#sendenvelopeasync)                                     | Send envelope for signature       |
| [DuplicateEnvelopeAsync](#duplicateenvelopeasync)                           | Duplicate envelope                |
| [VoidEnvelopeAsync](#voidenvelopeasync)                                     | Void envelope                     |
| [RenameEnvelopeAsync](#renameenvelopeasync)                                 | Rename envelope                   |
| [SetEnvelopeCommentAsync](#setenvelopecommentasync)                         | Set envelope comment              |
| [SetEnvelopeNotificationAsync](#setenvelopenotificationasync)               | Set envelope notification         |
| [SetEnvelopeExpirationDateAsync](#setenvelopeexpirationdateasync)           | Set envelope expiration date      |
| [SetEnvelopeLegalityLevelAsync](#setenvelopelegalitylevelasync)             | Set envelope legality level       |
| [GetEnvelopeAnnotationsAsync](#getenvelopeannotationsasync)                 | Get envelope annotations          |
| [GetEnvelopeDocumentAnnotationsAsync](#getenvelopedocumentannotationsasync) | Get envelope document annotations |
| [AddEnvelopeAnnotationAsync](#addenvelopeannotationasync)                   | Add envelope annotation           |
| [DeleteEnvelopeAnnotationAsync](#deleteenvelopeannotationasync)             | Delete envelope annotation        |
| [CreateTemplateAsync](#createtemplateasync)                                 | Create new template               |
| [ListTemplatesAsync](#listtemplatesasync)                                   | List templates                    |
| [GetTemplateAsync](#gettemplateasync)                                       | Get template                      |
| [DeleteTemplateAsync](#deletetemplateasync)                                 | Delete template                   |
| [DuplicateTemplateAsync](#duplicatetemplateasync)                           | Duplicate template                |
| [AddTemplateDocumentAsync](#addtemplatedocumentasync)                       | Add template document             |
| [GetTemplateDocumentAsync](#gettemplatedocumentasync)                       | Get template document             |
| [GetTemplateDocumentsAsync](#gettemplatedocumentsasync)                     | Get template documents            |
| [AddTemplateSigningStepsAsync](#addtemplatesigningstepsasync)               | Add template signing steps        |
| [RenameTemplateAsync](#renametemplateasync)                                 | Rename template                   |
| [SetTemplateCommentAsync](#settemplatecommentasync)                         | Set template comment              |
| [SetTemplateNotificationAsync](#settemplatenotificationasync)               | Set template notification         |
| [GetTemplateAnnotationsAsync](#gettemplateannotationsasync)                 | Get template annotations          |
| [GetDocumentTemplateAnnotationsAsync](#getdocumenttemplateannotationsasync) | Get document template annotations |
| [AddTemplateAnnotationAsync](#addtemplateannotationasync)                   | Add template annotation           |
| [DeleteTemplateAnnotationAsync](#deletetemplateannotationasync)             | Delete template annotation        |
| [CreateWebhookAsync](#createwebhookasync)                                   | Create webhook                    |
| [ListWebhooksAsync](#listwebhooksasync)                                     | List webhooks                     |
| [DeleteWebhookAsync](#deletewebhookasync)                                   | Delete webhook                    |

## CreateEnvelopeAsync

Create new envelope

- HTTP Method: `POST`
- Endpoint: `/envelope`

**Parameters**

| Name  | Type                  | Required | Description       |
| :---- | :-------------------- | :------- | :---------------- |
| input | CreateEnvelopeRequest | ✅       | The request body. |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new CreateEnvelopeRequest("name", EnvelopeLegalityLevel.Ses);

var response = await client.Signplus.CreateEnvelopeAsync(input);

Console.WriteLine(response);
```

## CreateEnvelopeFromTemplateAsync

Create new envelope from template

- HTTP Method: `POST`
- Endpoint: `/envelope/from_template/{template_id}`

**Parameters**

| Name       | Type                              | Required | Description       |
| :--------- | :-------------------------------- | :------- | :---------------- |
| input      | CreateEnvelopeFromTemplateRequest | ✅       | The request body. |
| templateId | string                            | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new CreateEnvelopeFromTemplateRequest("name");

var response = await client.Signplus.CreateEnvelopeFromTemplateAsync(input, "template_id");

Console.WriteLine(response);
```

## ListEnvelopesAsync

List envelopes

- HTTP Method: `POST`
- Endpoint: `/envelopes`

**Parameters**

| Name  | Type                 | Required | Description       |
| :---- | :------------------- | :------- | :---------------- |
| input | ListEnvelopesRequest | ❌       | The request body. |

**Return Type**

`ListEnvelopesResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new ListEnvelopesRequest();

var response = await client.Signplus.ListEnvelopesAsync(input);

Console.WriteLine(response);
```

## GetEnvelopeAsync

Get envelope

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetEnvelopeAsync("envelope_id");

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

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

await client.Signplus.DeleteEnvelopeAsync("envelope_id");
```

## GetEnvelopeDocumentAsync

Get envelope document

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/document/{document_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |
| documentId | string | ✅       |             |

**Return Type**

`Document`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetEnvelopeDocumentAsync("envelope_id", "document_id");

Console.WriteLine(response);
```

## GetEnvelopeDocumentsAsync

Get envelope documents

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/documents`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`ListEnvelopeDocumentsResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetEnvelopeDocumentsAsync("envelope_id");

Console.WriteLine(response);
```

## AddEnvelopeDocumentAsync

Add envelope document

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/document`

**Parameters**

| Name       | Type                       | Required | Description       |
| :--------- | :------------------------- | :------- | :---------------- |
| input      | AddEnvelopeDocumentRequest | ✅       | The request body. |
| envelopeId | string                     | ✅       |                   |

**Return Type**

`Document`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new AddEnvelopeDocumentRequest();

var response = await client.Signplus.AddEnvelopeDocumentAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SetEnvelopeDynamicFieldsAsync

Set envelope dynamic fields

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/dynamic_fields`

**Parameters**

| Name       | Type                            | Required | Description       |
| :--------- | :------------------------------ | :------- | :---------------- |
| input      | SetEnvelopeDynamicFieldsRequest | ✅       | The request body. |
| envelopeId | string                          | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var dynamicFieldsItem = new DynamicField();
var dynamicFields = new List<DynamicField>() { dynamicFieldsItem };
var input = new SetEnvelopeDynamicFieldsRequest(dynamicFields);

var response = await client.Signplus.SetEnvelopeDynamicFieldsAsync(input, "envelope_id");

Console.WriteLine(response);
```

## AddEnvelopeSigningStepsAsync

Add envelope signing steps

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/signing_steps`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | AddEnvelopeSigningStepsRequest | ✅       | The request body. |
| envelopeId | string                         | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new AddEnvelopeSigningStepsRequest();

var response = await client.Signplus.AddEnvelopeSigningStepsAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SendEnvelopeAsync

Send envelope for signature

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/send`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.SendEnvelopeAsync("envelope_id");

Console.WriteLine(response);
```

## DuplicateEnvelopeAsync

Duplicate envelope

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/duplicate`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.DuplicateEnvelopeAsync("envelope_id");

Console.WriteLine(response);
```

## VoidEnvelopeAsync

Void envelope

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/void`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| envelopeId | string | ✅       |             |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.VoidEnvelopeAsync("envelope_id");

Console.WriteLine(response);
```

## RenameEnvelopeAsync

Rename envelope

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/rename`

**Parameters**

| Name       | Type                  | Required | Description       |
| :--------- | :-------------------- | :------- | :---------------- |
| input      | RenameEnvelopeRequest | ✅       | The request body. |
| envelopeId | string                | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new RenameEnvelopeRequest();

var response = await client.Signplus.RenameEnvelopeAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SetEnvelopeCommentAsync

Set envelope comment

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_comment`

**Parameters**

| Name       | Type                      | Required | Description       |
| :--------- | :------------------------ | :------- | :---------------- |
| input      | SetEnvelopeCommentRequest | ✅       | The request body. |
| envelopeId | string                    | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new SetEnvelopeCommentRequest("comment");

var response = await client.Signplus.SetEnvelopeCommentAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SetEnvelopeNotificationAsync

Set envelope notification

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_notification`

**Parameters**

| Name       | Type                 | Required | Description       |
| :--------- | :------------------- | :------- | :---------------- |
| input      | EnvelopeNotification | ✅       | The request body. |
| envelopeId | string               | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new EnvelopeNotification();

var response = await client.Signplus.SetEnvelopeNotificationAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SetEnvelopeExpirationDateAsync

Set envelope expiration date

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_expiration_date`

**Parameters**

| Name       | Type                         | Required | Description       |
| :--------- | :--------------------------- | :------- | :---------------- |
| input      | SetEnvelopeExpirationRequest | ✅       | The request body. |
| envelopeId | string                       | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new SetEnvelopeExpirationRequest(3);

var response = await client.Signplus.SetEnvelopeExpirationDateAsync(input, "envelope_id");

Console.WriteLine(response);
```

## SetEnvelopeLegalityLevelAsync

Set envelope legality level

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_legality_level`

**Parameters**

| Name       | Type                            | Required | Description       |
| :--------- | :------------------------------ | :------- | :---------------- |
| input      | SetEnvelopeLegalityLevelRequest | ✅       | The request body. |
| envelopeId | string                          | ✅       |                   |

**Return Type**

`Envelope`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new SetEnvelopeLegalityLevelRequest();

var response = await client.Signplus.SetEnvelopeLegalityLevelAsync(input, "envelope_id");

Console.WriteLine(response);
```

## GetEnvelopeAnnotationsAsync

Get envelope annotations

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/annotations`

**Parameters**

| Name       | Type   | Required | Description        |
| :--------- | :----- | :------- | :----------------- |
| envelopeId | string | ✅       | ID of the envelope |

**Return Type**

`List<Annotation>`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetEnvelopeAnnotationsAsync("envelope_id");

Console.WriteLine(response);
```

## GetEnvelopeDocumentAnnotationsAsync

Get envelope document annotations

- HTTP Method: `GET`
- Endpoint: `/envelope/{envelope_id}/annotations/{document_id}`

**Parameters**

| Name       | Type   | Required | Description        |
| :--------- | :----- | :------- | :----------------- |
| envelopeId | string | ✅       | ID of the envelope |
| documentId | string | ✅       | ID of document     |

**Return Type**

`ListEnvelopeDocumentAnnotationsResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetEnvelopeDocumentAnnotationsAsync("envelope_id", "document_id");

Console.WriteLine(response);
```

## AddEnvelopeAnnotationAsync

Add envelope annotation

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/annotation`

**Parameters**

| Name       | Type                 | Required | Description        |
| :--------- | :------------------- | :------- | :----------------- |
| input      | AddAnnotationRequest | ✅       | The request body.  |
| envelopeId | string               | ✅       | ID of the envelope |

**Return Type**

`Annotation`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new AddAnnotationRequest("document_id", 7, 7.25, 7.35, 6.25, 9.77, AnnotationType.Text);

var response = await client.Signplus.AddEnvelopeAnnotationAsync(input, "envelope_id");

Console.WriteLine(response);
```

## DeleteEnvelopeAnnotationAsync

Delete envelope annotation

- HTTP Method: `DELETE`
- Endpoint: `/envelope/{envelope_id}/annotation/{annotation_id}`

**Parameters**

| Name         | Type   | Required | Description                    |
| :----------- | :----- | :------- | :----------------------------- |
| envelopeId   | string | ✅       | ID of the envelope             |
| annotationId | string | ✅       | ID of the annotation to delete |

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

await client.Signplus.DeleteEnvelopeAnnotationAsync("envelope_id", "annotation_id");
```

## CreateTemplateAsync

Create new template

- HTTP Method: `POST`
- Endpoint: `/template`

**Parameters**

| Name  | Type                  | Required | Description       |
| :---- | :-------------------- | :------- | :---------------- |
| input | CreateTemplateRequest | ✅       | The request body. |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new CreateTemplateRequest("name");

var response = await client.Signplus.CreateTemplateAsync(input);

Console.WriteLine(response);
```

## ListTemplatesAsync

List templates

- HTTP Method: `POST`
- Endpoint: `/templates`

**Parameters**

| Name  | Type                 | Required | Description       |
| :---- | :------------------- | :------- | :---------------- |
| input | ListTemplatesRequest | ❌       | The request body. |

**Return Type**

`ListTemplatesResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new ListTemplatesRequest();

var response = await client.Signplus.ListTemplatesAsync(input);

Console.WriteLine(response);
```

## GetTemplateAsync

Get template

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetTemplateAsync("template_id");

Console.WriteLine(response);
```

## DeleteTemplateAsync

Delete template

- HTTP Method: `DELETE`
- Endpoint: `/template/{template_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

await client.Signplus.DeleteTemplateAsync("template_id");
```

## DuplicateTemplateAsync

Duplicate template

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/duplicate`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.DuplicateTemplateAsync("template_id");

Console.WriteLine(response);
```

## AddTemplateDocumentAsync

Add template document

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/document`

**Parameters**

| Name       | Type                       | Required | Description       |
| :--------- | :------------------------- | :------- | :---------------- |
| input      | AddTemplateDocumentRequest | ✅       | The request body. |
| templateId | string                     | ✅       |                   |

**Return Type**

`Document`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new AddTemplateDocumentRequest(file);

var response = await client.Signplus.AddTemplateDocumentAsync(input, "template_id");

Console.WriteLine(response);
```

## GetTemplateDocumentAsync

Get template document

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/document/{document_id}`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |
| documentId | string | ✅       |             |

**Return Type**

`Document`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetTemplateDocumentAsync("template_id", "document_id");

Console.WriteLine(response);
```

## GetTemplateDocumentsAsync

Get template documents

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/documents`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |

**Return Type**

`ListTemplateDocumentsResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetTemplateDocumentsAsync("template_id");

Console.WriteLine(response);
```

## AddTemplateSigningStepsAsync

Add template signing steps

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/signing_steps`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | AddTemplateSigningStepsRequest | ✅       | The request body. |
| templateId | string                         | ✅       |                   |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var signingStepsItem = new TemplateSigningStep();
var signingSteps = new List<TemplateSigningStep>() { signingStepsItem };
var input = new AddTemplateSigningStepsRequest(signingSteps);

var response = await client.Signplus.AddTemplateSigningStepsAsync(input, "template_id");

Console.WriteLine(response);
```

## RenameTemplateAsync

Rename template

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/rename`

**Parameters**

| Name       | Type                  | Required | Description       |
| :--------- | :-------------------- | :------- | :---------------- |
| input      | RenameTemplateRequest | ✅       | The request body. |
| templateId | string                | ✅       |                   |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new RenameTemplateRequest("name");

var response = await client.Signplus.RenameTemplateAsync(input, "template_id");

Console.WriteLine(response);
```

## SetTemplateCommentAsync

Set template comment

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/set_comment`

**Parameters**

| Name       | Type                      | Required | Description       |
| :--------- | :------------------------ | :------- | :---------------- |
| input      | SetTemplateCommentRequest | ✅       | The request body. |
| templateId | string                    | ✅       |                   |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new SetTemplateCommentRequest("comment");

var response = await client.Signplus.SetTemplateCommentAsync(input, "template_id");

Console.WriteLine(response);
```

## SetTemplateNotificationAsync

Set template notification

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/set_notification`

**Parameters**

| Name       | Type                 | Required | Description       |
| :--------- | :------------------- | :------- | :---------------- |
| input      | EnvelopeNotification | ✅       | The request body. |
| templateId | string               | ✅       |                   |

**Return Type**

`Template`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new EnvelopeNotification();

var response = await client.Signplus.SetTemplateNotificationAsync(input, "template_id");

Console.WriteLine(response);
```

## GetTemplateAnnotationsAsync

Get template annotations

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/annotations`

**Parameters**

| Name       | Type   | Required | Description        |
| :--------- | :----- | :------- | :----------------- |
| templateId | string | ✅       | ID of the template |

**Return Type**

`ListTemplateAnnotationsResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetTemplateAnnotationsAsync("template_id");

Console.WriteLine(response);
```

## GetDocumentTemplateAnnotationsAsync

Get document template annotations

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/annotations/{document_id}`

**Parameters**

| Name       | Type   | Required | Description        |
| :--------- | :----- | :------- | :----------------- |
| templateId | string | ✅       | ID of the template |
| documentId | string | ✅       | ID of document     |

**Return Type**

`ListTemplateDocumentAnnotationsResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

var response = await client.Signplus.GetDocumentTemplateAnnotationsAsync("template_id", "document_id");

Console.WriteLine(response);
```

## AddTemplateAnnotationAsync

Add template annotation

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/annotation`

**Parameters**

| Name       | Type                 | Required | Description        |
| :--------- | :------------------- | :------- | :----------------- |
| input      | AddAnnotationRequest | ✅       | The request body.  |
| templateId | string               | ✅       | ID of the template |

**Return Type**

`Annotation`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new AddAnnotationRequest("document_id", 7, 7.25, 7.35, 6.25, 9.77, AnnotationType.Text);

var response = await client.Signplus.AddTemplateAnnotationAsync(input, "template_id");

Console.WriteLine(response);
```

## DeleteTemplateAnnotationAsync

Delete template annotation

- HTTP Method: `DELETE`
- Endpoint: `/template/{template_id}/annotation/{annotation_id}`

**Parameters**

| Name         | Type   | Required | Description                    |
| :----------- | :----- | :------- | :----------------------------- |
| templateId   | string | ✅       | ID of the template             |
| annotationId | string | ✅       | ID of the annotation to delete |

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

await client.Signplus.DeleteTemplateAnnotationAsync("template_id", "annotation_id");
```

## CreateWebhookAsync

Create webhook

- HTTP Method: `POST`
- Endpoint: `/webhook`

**Parameters**

| Name  | Type                 | Required | Description       |
| :---- | :------------------- | :------- | :---------------- |
| input | CreateWebhookRequest | ✅       | The request body. |

**Return Type**

`Webhook`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new CreateWebhookRequest(WebhookEvent.EnvelopeExpired, "target");

var response = await client.Signplus.CreateWebhookAsync(input);

Console.WriteLine(response);
```

## ListWebhooksAsync

List webhooks

- HTTP Method: `POST`
- Endpoint: `/webhooks`

**Parameters**

| Name  | Type                | Required | Description       |
| :---- | :------------------ | :------- | :---------------- |
| input | ListWebhooksRequest | ❌       | The request body. |

**Return Type**

`ListWebhooksResponse`

**Example Usage Code Snippet**

```csharp
using Signplus;
using Signplus.Models;

var client = new SignplusClient();

var input = new ListWebhooksRequest();

var response = await client.Signplus.ListWebhooksAsync(input);

Console.WriteLine(response);
```

## DeleteWebhookAsync

Delete webhook

- HTTP Method: `DELETE`
- Endpoint: `/webhook/{webhook_id}`

**Parameters**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| webhookId | string | ✅       |             |

**Example Usage Code Snippet**

```csharp
using Signplus;

var client = new SignplusClient();

await client.Signplus.DeleteWebhookAsync("webhook_id");
```
