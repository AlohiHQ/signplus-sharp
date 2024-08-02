using System.Net.Http.Json;
using Signplus.Http;
using Signplus.Http.Serialization;
using Signplus.Models;

namespace Signplus.Services;

public class SignplusService : BaseService
{
    internal SignplusService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Create new envelope</summary>
    public async Task<Envelope> CreateEnvelopeAsync(
        CreateEnvelopeRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "envelope")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Create new envelope from template</summary>
    public async Task<Envelope> CreateEnvelopeFromTemplateAsync(
        CreateEnvelopeFromTemplateRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/from_template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>List envelopes</summary>
    public async Task<ListEnvelopesResponse> ListEnvelopesAsync(
        ListEnvelopesRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "envelopes")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListEnvelopesResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get envelope</summary>
    public async Task<Envelope> GetEnvelopeAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete envelope</summary>
    public async Task DeleteEnvelopeAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Delete, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Get envelope document</summary>
    public async Task<Document> GetEnvelopeDocumentAsync(
        string envelopeId,
        string documentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "envelope/{envelope_id}/document/{document_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Document>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get envelope documents</summary>
    public async Task<ListEnvelopeDocumentsResponse> GetEnvelopeDocumentsAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/documents")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListEnvelopeDocumentsResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add envelope document</summary>
    public async Task<Document> AddEnvelopeDocumentAsync(
        AddEnvelopeDocumentRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/document")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Document>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set envelope dynamic fields</summary>
    public async Task<Envelope> SetEnvelopeDynamicFieldsAsync(
        SetEnvelopeDynamicFieldsRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/dynamic_fields")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add envelope signing steps</summary>
    public async Task<Envelope> AddEnvelopeSigningStepsAsync(
        AddEnvelopeSigningStepsRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/signing_steps")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Send envelope for signature</summary>
    public async Task<Envelope> SendEnvelopeAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/send")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Duplicate envelope</summary>
    public async Task<Envelope> DuplicateEnvelopeAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/duplicate")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Void envelope</summary>
    public async Task<Envelope> VoidEnvelopeAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/void")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Rename envelope</summary>
    public async Task<Envelope> RenameEnvelopeAsync(
        RenameEnvelopeRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/rename")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set envelope comment</summary>
    public async Task<Envelope> SetEnvelopeCommentAsync(
        SetEnvelopeCommentRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/set_comment")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set envelope notification</summary>
    public async Task<Envelope> SetEnvelopeNotificationAsync(
        EnvelopeNotification input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/set_notification")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set envelope expiration date</summary>
    public async Task<Envelope> SetEnvelopeExpirationDateAsync(
        SetEnvelopeExpirationRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/set_expiration_date"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set envelope legality level</summary>
    public async Task<Envelope> SetEnvelopeLegalityLevelAsync(
        SetEnvelopeLegalityLevelRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/set_legality_level"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Envelope>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get envelope annotations</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    public async Task<List<Annotation>> GetEnvelopeAnnotationsAsync(
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/annotations")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<List<Annotation>>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get envelope document annotations</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    /// <param name="documentId">ID of document</param>
    public async Task<ListEnvelopeDocumentAnnotationsResponse> GetEnvelopeDocumentAnnotationsAsync(
        string envelopeId,
        string documentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "envelope/{envelope_id}/annotations/{document_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListEnvelopeDocumentAnnotationsResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add envelope annotation</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    public async Task<Annotation> AddEnvelopeAnnotationAsync(
        AddAnnotationRequest input,
        string envelopeId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/annotation")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Annotation>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete envelope annotation</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    /// <param name="annotationId">ID of the annotation to delete</param>
    public async Task DeleteEnvelopeAnnotationAsync(
        string envelopeId,
        string annotationId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "envelope/{envelope_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("annotation_id", annotationId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Create new template</summary>
    public async Task<Template> CreateTemplateAsync(
        CreateTemplateRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "template")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>List templates</summary>
    public async Task<ListTemplatesResponse> ListTemplatesAsync(
        ListTemplatesRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "templates")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListTemplatesResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get template</summary>
    public async Task<Template> GetTemplateAsync(
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete template</summary>
    public async Task DeleteTemplateAsync(
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Delete, "template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Duplicate template</summary>
    public async Task<Template> DuplicateTemplateAsync(
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/duplicate")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add template document</summary>
    public async Task<Document> AddTemplateDocumentAsync(
        AddTemplateDocumentRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/document")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Document>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get template document</summary>
    public async Task<Document> GetTemplateDocumentAsync(
        string templateId,
        string documentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "template/{template_id}/document/{document_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Document>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get template documents</summary>
    public async Task<ListTemplateDocumentsResponse> GetTemplateDocumentsAsync(
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}/documents")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListTemplateDocumentsResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add template signing steps</summary>
    public async Task<Template> AddTemplateSigningStepsAsync(
        AddTemplateSigningStepsRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/signing_steps")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Rename template</summary>
    public async Task<Template> RenameTemplateAsync(
        RenameTemplateRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/rename")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set template comment</summary>
    public async Task<Template> SetTemplateCommentAsync(
        SetTemplateCommentRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/set_comment")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Set template notification</summary>
    public async Task<Template> SetTemplateNotificationAsync(
        EnvelopeNotification input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/set_notification")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Template>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get template annotations</summary>
    /// <param name="templateId">ID of the template</param>
    public async Task<ListTemplateAnnotationsResponse> GetTemplateAnnotationsAsync(
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}/annotations")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListTemplateAnnotationsResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get document template annotations</summary>
    /// <param name="templateId">ID of the template</param>
    /// <param name="documentId">ID of document</param>
    public async Task<ListTemplateDocumentAnnotationsResponse> GetDocumentTemplateAnnotationsAsync(
        string templateId,
        string documentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "template/{template_id}/annotations/{document_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListTemplateDocumentAnnotationsResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Add template annotation</summary>
    /// <param name="templateId">ID of the template</param>
    public async Task<Annotation> AddTemplateAnnotationAsync(
        AddAnnotationRequest input,
        string templateId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/annotation")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Annotation>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete template annotation</summary>
    /// <param name="templateId">ID of the template</param>
    /// <param name="annotationId">ID of the annotation to delete</param>
    public async Task DeleteTemplateAnnotationAsync(
        string templateId,
        string annotationId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "template/{template_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("annotation_id", annotationId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Create webhook</summary>
    public async Task<Webhook> CreateWebhookAsync(
        CreateWebhookRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "webhook")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Webhook>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>List webhooks</summary>
    public async Task<ListWebhooksResponse> ListWebhooksAsync(
        ListWebhooksRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "webhooks")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ListWebhooksResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Delete webhook</summary>
    public async Task DeleteWebhookAsync(
        string webhookId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(webhookId, nameof(webhookId));

        var request = new RequestBuilder(HttpMethod.Delete, "webhook/{webhook_id}")
            .SetPathParameter("webhook_id", webhookId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }
}
