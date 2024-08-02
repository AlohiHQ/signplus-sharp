# ListTemplatesRequest

**Properties**

| Name       | Type               | Required | Description                                   |
| :--------- | :----------------- | :------- | :-------------------------------------------- |
| Name       | string             | ❌       | Name of the template                          |
| Tags       | List<string>       | ❌       | List of tag templates                         |
| Ids        | List<string>       | ❌       | List of templates IDs                         |
| First      | long               | ❌       |                                               |
| Last       | long               | ❌       |                                               |
| After      | string             | ❌       |                                               |
| Before     | string             | ❌       |                                               |
| OrderField | TemplateOrderField | ❌       | Field to order templates by                   |
| Ascending  | bool               | ❌       | Whether to order templates in ascending order |
