// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridNamespacePermissionBindingOperationSource : IOperationSource<EventGridNamespacePermissionBindingResource>
    {
        private readonly ArmClient _client;

        internal EventGridNamespacePermissionBindingOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridNamespacePermissionBindingResource IOperationSource<EventGridNamespacePermissionBindingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventGridNamespacePermissionBindingData.DeserializeEventGridNamespacePermissionBindingData(document.RootElement);
            return new EventGridNamespacePermissionBindingResource(_client, data);
        }

        async ValueTask<EventGridNamespacePermissionBindingResource> IOperationSource<EventGridNamespacePermissionBindingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventGridNamespacePermissionBindingData.DeserializeEventGridNamespacePermissionBindingData(document.RootElement);
            return new EventGridNamespacePermissionBindingResource(_client, data);
        }
    }
}
