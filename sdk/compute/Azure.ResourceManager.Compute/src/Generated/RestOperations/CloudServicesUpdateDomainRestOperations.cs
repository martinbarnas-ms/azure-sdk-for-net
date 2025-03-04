// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    internal partial class CloudServicesUpdateDomainRestOperations
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of CloudServicesUpdateDomainRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        public CloudServicesUpdateDomainRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateWalkUpdateDomainRequest(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain, UpdateDomain parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains/", false);
            uri.AppendPath(updateDomain, true);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (parameters != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(parameters);
                request.Content = content;
            }
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates the role instances in the specified update domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="parameters"> The update domain object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response> WalkUpdateDomainAsync(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain, UpdateDomain parameters = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateWalkUpdateDomainRequest(subscriptionId, resourceGroupName, cloudServiceName, updateDomain, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the role instances in the specified update domain. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="parameters"> The update domain object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public Response WalkUpdateDomain(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain, UpdateDomain parameters = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateWalkUpdateDomainRequest(subscriptionId, resourceGroupName, cloudServiceName, updateDomain, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUpdateDomainRequest(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains/", false);
            uri.AppendPath(updateDomain, true);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified update domain of a cloud service. Use nextLink property in the response to get the next page of update domains. Do this till nextLink is null to fetch all the update domains. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<UpdateDomain>> GetUpdateDomainAsync(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateGetUpdateDomainRequest(subscriptionId, resourceGroupName, cloudServiceName, updateDomain);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomain value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomain.DeserializeUpdateDomain(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified update domain of a cloud service. Use nextLink property in the response to get the next page of update domains. Do this till nextLink is null to fetch all the update domains. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public Response<UpdateDomain> GetUpdateDomain(string subscriptionId, string resourceGroupName, string cloudServiceName, int updateDomain, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateGetUpdateDomainRequest(subscriptionId, resourceGroupName, cloudServiceName, updateDomain);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomain value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomain.DeserializeUpdateDomain(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListUpdateDomainsRequest(string subscriptionId, string resourceGroupName, string cloudServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains", false);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<UpdateDomainListResult>> ListUpdateDomainsAsync(string subscriptionId, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsRequest(subscriptionId, resourceGroupName, cloudServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public Response<UpdateDomainListResult> ListUpdateDomains(string subscriptionId, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsRequest(subscriptionId, resourceGroupName, cloudServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListUpdateDomainsNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string cloudServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<UpdateDomainListResult>> ListUpdateDomainsNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsNextPageRequest(nextLink, subscriptionId, resourceGroupName, cloudServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public Response<UpdateDomainListResult> ListUpdateDomainsNextPage(string nextLink, string subscriptionId, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsNextPageRequest(nextLink, subscriptionId, resourceGroupName, cloudServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
