# Envelope

**Properties**

| Name          | Type                  | Required | Description                                                                                                                                                             |
| :------------ | :-------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Id            | string                | ❌       | Unique identifier of the envelope                                                                                                                                       |
| Name          | string                | ❌       | Name of the envelope                                                                                                                                                    |
| Comment       | string                | ❌       | Comment for the envelope                                                                                                                                                |
| Pages         | long                  | ❌       | Total number of pages in the envelope                                                                                                                                   |
| FlowType      | EnvelopeFlowType      | ❌       | Flow type of the envelope (REQUEST_SIGNATURE is a request for signature)                                                                                                |
| LegalityLevel | EnvelopeLegalityLevel | ❌       | Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes) |
| Status        | EnvelopeStatus        | ❌       | Status of the envelope                                                                                                                                                  |
| CreatedAt     | long                  | ❌       | Unix timestamp of the creation date                                                                                                                                     |
| UpdatedAt     | long                  | ❌       | Unix timestamp of the last modification date                                                                                                                            |
| ExpiresAt     | long                  | ❌       | Unix timestamp of the expiration date                                                                                                                                   |
| NumRecipients | long                  | ❌       | Number of recipients in the envelope                                                                                                                                    |
| IsDuplicable  | bool                  | ❌       | Whether the envelope can be duplicated                                                                                                                                  |
| SigningSteps  | List<SigningStep>     | ❌       |                                                                                                                                                                         |
| Documents     | List<Document>        | ❌       |                                                                                                                                                                         |
| Notification  | EnvelopeNotification  | ❌       |                                                                                                                                                                         |
