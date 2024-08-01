# CreateEnvelopeRequest

**Properties**

| Name          | Type                  | Required | Description                                                                                                                                                             |
| :------------ | :-------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Name          | string                | ❌       | Name of the envelope                                                                                                                                                    |
| FlowType      | EnvelopeFlowType      | ❌       | Flow type of the envelope (REQUEST_SIGNATURE is a request for signature, SIGN_MYSELF is a self-signing flow)                                                            |
| LegalityLevel | EnvelopeLegalityLevel | ❌       | Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes) |
| ExpiresAt     | long                  | ❌       | Unix timestamp of the expiration date                                                                                                                                   |
| Comment       | string                | ❌       | Comment for the envelope                                                                                                                                                |
| Sandbox       | bool                  | ❌       | Whether the envelope is created in sandbox mode                                                                                                                         |