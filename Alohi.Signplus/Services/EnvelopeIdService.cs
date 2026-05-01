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
/// Service class providing access to API endpoints for EnvelopeIdService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class EnvelopeIdService : BaseService
{
    private RequestConfig? _getEnvelopeAsyncConfig;
    private RequestConfig? _deleteEnvelopeAsyncConfig;

    internal EnvelopeIdService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public EnvelopeIdService SetGetEnvelopeAsyncConfig(RequestConfig config)
    {
        _getEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public EnvelopeIdService SetDeleteEnvelopeAsyncConfig(RequestConfig config)
    {
        _deleteEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>Get envelope</summary>
    public async Task<object> GetEnvelopeAsync(
        string envelopeId,
        string? accept,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var acceptValidationResult = new StringValidator().ValidateRequired<string>(accept);
        if (acceptValidationResult != null)
        {
            validationResults.Add(acceptValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
            .SetHeader("Accept", accept)
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

    /// <summary>Delete envelope</summary>
    public async Task<object> DeleteEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Delete, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
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
