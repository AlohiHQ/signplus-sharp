# ListEnvelopesRequest

**Properties**

| Name           | Type                 | Required | Description                                       |
| :------------- | :------------------- | :------- | :------------------------------------------------ |
| Name           | string               | ❌       | Name of the envelope                              |
| Tags           | List<string>         | ❌       | List of tags                                      |
| Comment        | string               | ❌       | Comment of the envelope                           |
| Ids            | List<string>         | ❌       | List of envelope IDs                              |
| Statuses       | List<EnvelopeStatus> | ❌       | List of envelope statuses                         |
| FolderIds      | List<string>         | ❌       | List of folder IDs                                |
| OnlyRootFolder | bool                 | ❌       | Whether to only list envelopes in the root folder |
| DateFrom       | long                 | ❌       | Unix timestamp of the start date                  |
| DateTo         | long                 | ❌       | Unix timestamp of the end date                    |
| Uid            | string               | ❌       | Unique identifier of the user                     |
| First          | long                 | ❌       |                                                   |
| Last           | long                 | ❌       |                                                   |
| After          | string               | ❌       |                                                   |
| Before         | string               | ❌       |                                                   |
| OrderField     | EnvelopeOrderField   | ❌       | Field to order envelopes by                       |
| Ascending      | bool                 | ❌       | Whether to order envelopes in ascending order     |
| IncludeTrash   | bool                 | ❌       | Whether to include envelopes in the trash         |
