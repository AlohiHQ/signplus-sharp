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
/// Service class providing access to API endpoints for AnnotationIdService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class AnnotationIdService : BaseService
{
    private RequestConfig? _deleteEnvelopeAnnotationAsyncConfig;

    internal AnnotationIdService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteEnvelopeAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public AnnotationIdService SetDeleteEnvelopeAnnotationAsyncConfig(RequestConfig config)
    {
        _deleteEnvelopeAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>Delete envelope annotation</summary>
    public async Task<object> DeleteEnvelopeAnnotationAsync(
        string envelopeId,
        string annotationId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
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

        var resolvedConfig = GetResolvedConfig(_deleteEnvelopeAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "envelope/{envelope_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
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
