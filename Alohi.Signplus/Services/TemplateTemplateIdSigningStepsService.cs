using System.Net.Http.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Http.Serialization;
using Alohi.Signplus.Models;
using Alohi.Signplus.Validation;
using Alohi.Signplus.Validation.Extensions;

namespace Alohi.Signplus.Services;

/// <summary>
/// Service class providing access to API endpoints for TemplateTemplateIdSigningStepsService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class TemplateTemplateIdSigningStepsService : BaseService
{
    private RequestConfig? _addTemplateSigningStepsAsyncConfig;

    internal TemplateTemplateIdSigningStepsService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>AddTemplateSigningStepsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public TemplateTemplateIdSigningStepsService SetAddTemplateSigningStepsAsyncConfig(
        RequestConfig config
    )
    {
        _addTemplateSigningStepsAsyncConfig = config;
        return this;
    }

    /// <summary>Add template signing steps</summary>
    public async Task<object> AddTemplateSigningStepsAsync(
        AddTemplateSigningStepsRequest? input,
        string templateId,
        string? accept,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var acceptValidationResult = new StringValidator().ValidateRequired<string>(accept);
        if (acceptValidationResult != null)
        {
            validationResults.Add(acceptValidationResult);
        }
        ;
        var validator = new AddTemplateSigningStepsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addTemplateSigningStepsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/signing_steps")
            .SetPathParameter("template_id", templateId)
            .SetHeader("Accept", accept)
            .SetContentAsJson(input, _jsonSerializerOptions)
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
