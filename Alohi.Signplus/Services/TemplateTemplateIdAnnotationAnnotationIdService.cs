using System.Net.Http.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Http.Serialization;
using Alohi.Signplus.Validation;
using Alohi.Signplus.Validation.Extensions;

namespace Alohi.Signplus.Services;

/// <summary>
/// Service class providing access to API endpoints for TemplateTemplateIdAnnotationAnnotationIdService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class TemplateTemplateIdAnnotationAnnotationIdService : BaseService
{
    private RequestConfig? _deleteTemplateAnnotationAsyncConfig;

    internal TemplateTemplateIdAnnotationAnnotationIdService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteTemplateAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public TemplateTemplateIdAnnotationAnnotationIdService SetDeleteTemplateAnnotationAsyncConfig(
        RequestConfig config
    )
    {
        _deleteTemplateAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>Delete template annotation</summary>
    public async Task<object> DeleteTemplateAnnotationAsync(
        string templateId,
        string annotationId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var annotationIdValidationResult = new StringValidator().ValidateRequired<string>(
            annotationId
        );
        if (annotationIdValidationResult != null)
        {
            validationResults.Add(annotationIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteTemplateAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "template/{template_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("annotation_id", annotationId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result = DeserializationValidation.DeserializeWithRequiredFieldValidation<object>(
            jsonContent,
            _jsonSerializerOptions
        );

        // Validate the response
        // Skip validation for primitive types or OneOf types

        return result;
    }
}
