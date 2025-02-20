// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Search.Mocking;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Search. </summary>
    public static partial class SearchExtensions
    {
        private static MockableSearchArmClient GetMockableSearchArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableSearchArmClient(client0));
        }

        private static MockableSearchResourceGroupResource GetMockableSearchResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSearchResourceGroupResource(client, resource.Id));
        }

        private static MockableSearchSubscriptionResource GetMockableSearchSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSearchSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="SearchServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SearchServiceResource.CreateResourceIdentifier" /> to create a <see cref="SearchServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchArmClient.GetSearchServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SearchServiceResource" /> object. </returns>
        public static SearchServiceResource GetSearchServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSearchArmClient(client).GetSearchServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SearchPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SearchPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="SearchPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchArmClient.GetSearchPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SearchPrivateEndpointConnectionResource" /> object. </returns>
        public static SearchPrivateEndpointConnectionResource GetSearchPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSearchArmClient(client).GetSearchPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SharedSearchServicePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SharedSearchServicePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="SharedSearchServicePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchArmClient.GetSharedSearchServicePrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedSearchServicePrivateLinkResource" /> object. </returns>
        public static SharedSearchServicePrivateLinkResource GetSharedSearchServicePrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableSearchArmClient(client).GetSharedSearchServicePrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of SearchServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchResourceGroupResource.GetSearchServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SearchServiceResources and their operations over a SearchServiceResource. </returns>
        public static SearchServiceCollection GetSearchServices(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableSearchResourceGroupResource(resourceGroupResource).GetSearchServices();
        }

        /// <summary>
        /// Gets the search service with the given name in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchResourceGroupResource.GetSearchServiceAsync(string,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SearchServiceResource>> GetSearchServiceAsync(this ResourceGroupResource resourceGroupResource, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return await GetMockableSearchResourceGroupResource(resourceGroupResource).GetSearchServiceAsync(searchServiceName, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the search service with the given name in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchResourceGroupResource.GetSearchService(string,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="searchServiceName"> The name of the Azure Cognitive Search service associated with the specified resource group. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="searchServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<SearchServiceResource> GetSearchService(this ResourceGroupResource resourceGroupResource, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchResourceGroupResource(resourceGroupResource).GetSearchService(searchServiceName, searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search services in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.GetSearchServices(SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SearchServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SearchServiceResource> GetSearchServicesAsync(this SubscriptionResource subscriptionResource, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).GetSearchServicesAsync(searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search services in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/searchServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.GetSearchServices(SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SearchServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SearchServiceResource> GetSearchServices(this SubscriptionResource subscriptionResource, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).GetSearchServices(searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Checks whether or not the given search service name is available for use. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.CheckSearchServiceNameAvailability(SearchServiceNameAvailabilityContent,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The resource name and type to check. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<SearchServiceNameAvailabilityResult>> CheckSearchServiceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, SearchServiceNameAvailabilityContent content, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return await GetMockableSearchSubscriptionResource(subscriptionResource).CheckSearchServiceNameAvailabilityAsync(content, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether or not the given search service name is available for use. Search service names must be globally unique since they are part of the service URI (https://&lt;name&gt;.search.windows.net).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.CheckSearchServiceNameAvailability(SearchServiceNameAvailabilityContent,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The resource name and type to check. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<SearchServiceNameAvailabilityResult> CheckSearchServiceNameAvailability(this SubscriptionResource subscriptionResource, SearchServiceNameAvailabilityContent content, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).CheckSearchServiceNameAvailability(content, searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search quota usages in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.GetUsagesBySubscription(AzureLocation,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaUsageResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<QuotaUsageResult> GetUsagesBySubscriptionAsync(this SubscriptionResource subscriptionResource, AzureLocation location, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).GetUsagesBySubscriptionAsync(location, searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Search quota usages in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.GetUsagesBySubscription(AzureLocation,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaUsageResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<QuotaUsageResult> GetUsagesBySubscription(this SubscriptionResource subscriptionResource, AzureLocation location, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).GetUsagesBySubscription(location, searchManagementRequestOptions, cancellationToken);
        }

        /// <summary>
        /// Gets the quota usage for a search sku in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageBySubscriptionSku</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.UsageBySubscriptionSku(AzureLocation,string,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique search service sku name supported by Azure Cognitive Search. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public static async Task<Response<QuotaUsageResult>> UsageBySubscriptionSkuAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return await GetMockableSearchSubscriptionResource(subscriptionResource).UsageBySubscriptionSkuAsync(location, skuName, searchManagementRequestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the quota usage for a search sku in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Search/locations/{location}/usages/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageBySubscriptionSku</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSearchSubscriptionResource.UsageBySubscriptionSku(AzureLocation,string,SearchManagementRequestOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The unique location name for a Microsoft Azure geographic region. </param>
        /// <param name="skuName"> The unique search service sku name supported by Azure Cognitive Search. </param>
        /// <param name="searchManagementRequestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public static Response<QuotaUsageResult> UsageBySubscriptionSku(this SubscriptionResource subscriptionResource, AzureLocation location, string skuName, SearchManagementRequestOptions searchManagementRequestOptions = null, CancellationToken cancellationToken = default)
        {
            return GetMockableSearchSubscriptionResource(subscriptionResource).UsageBySubscriptionSku(location, skuName, searchManagementRequestOptions, cancellationToken);
        }
    }
}
