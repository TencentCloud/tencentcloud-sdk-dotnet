/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdc.V20201214
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdc.V20201214.Models;

   public class CdcClient : AbstractClient{

       private const string endpoint = "cdc.tencentcloudapi.com";
       private const string version = "2020-12-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建专用集群
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterResponse"/></returns>
        public async Task<CreateDedicatedClusterResponse> CreateDedicatedCluster(CreateDedicatedClusterRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDedicatedCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建专用集群
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterResponse"/></returns>
        public CreateDedicatedClusterResponse CreateDedicatedClusterSync(CreateDedicatedClusterRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDedicatedCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建专用集群订单
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterOrderRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterOrderResponse"/></returns>
        public async Task<CreateDedicatedClusterOrderResponse> CreateDedicatedClusterOrder(CreateDedicatedClusterOrderRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDedicatedClusterOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建专用集群订单
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterOrderRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterOrderResponse"/></returns>
        public CreateDedicatedClusterOrderResponse CreateDedicatedClusterOrderSync(CreateDedicatedClusterOrderRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDedicatedClusterOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建站点
        /// </summary>
        /// <param name="req"><see cref="CreateSiteRequest"/></param>
        /// <returns><see cref="CreateSiteResponse"/></returns>
        public async Task<CreateSiteResponse> CreateSite(CreateSiteRequest req)
        {
             JsonResponseModel<CreateSiteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSiteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建站点
        /// </summary>
        /// <param name="req"><see cref="CreateSiteRequest"/></param>
        /// <returns><see cref="CreateSiteResponse"/></returns>
        public CreateSiteResponse CreateSiteSync(CreateSiteRequest req)
        {
             JsonResponseModel<CreateSiteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSiteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除专用集群
        /// </summary>
        /// <param name="req"><see cref="DeleteDedicatedClustersRequest"/></param>
        /// <returns><see cref="DeleteDedicatedClustersResponse"/></returns>
        public async Task<DeleteDedicatedClustersResponse> DeleteDedicatedClusters(DeleteDedicatedClustersRequest req)
        {
             JsonResponseModel<DeleteDedicatedClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDedicatedClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDedicatedClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除专用集群
        /// </summary>
        /// <param name="req"><see cref="DeleteDedicatedClustersRequest"/></param>
        /// <returns><see cref="DeleteDedicatedClustersResponse"/></returns>
        public DeleteDedicatedClustersResponse DeleteDedicatedClustersSync(DeleteDedicatedClustersRequest req)
        {
             JsonResponseModel<DeleteDedicatedClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDedicatedClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDedicatedClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除站点
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public async Task<DeleteSitesResponse> DeleteSites(DeleteSitesRequest req)
        {
             JsonResponseModel<DeleteSitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除站点
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public DeleteSitesResponse DeleteSitesSync(DeleteSitesRequest req)
        {
             JsonResponseModel<DeleteSitesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群内cos的容量信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterCosCapacityRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterCosCapacityResponse"/></returns>
        public async Task<DescribeDedicatedClusterCosCapacityResponse> DescribeDedicatedClusterCosCapacity(DescribeDedicatedClusterCosCapacityRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterCosCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterCosCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterCosCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群内cos的容量信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterCosCapacityRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterCosCapacityResponse"/></returns>
        public DescribeDedicatedClusterCosCapacityResponse DescribeDedicatedClusterCosCapacitySync(DescribeDedicatedClusterCosCapacityRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterCosCapacityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterCosCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterCosCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群内宿主机的统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostStatisticsResponse"/></returns>
        public async Task<DescribeDedicatedClusterHostStatisticsResponse> DescribeDedicatedClusterHostStatistics(DescribeDedicatedClusterHostStatisticsRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterHostStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterHostStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterHostStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群内宿主机的统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostStatisticsResponse"/></returns>
        public DescribeDedicatedClusterHostStatisticsResponse DescribeDedicatedClusterHostStatisticsSync(DescribeDedicatedClusterHostStatisticsRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterHostStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterHostStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterHostStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专用集群宿主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostsResponse"/></returns>
        public async Task<DescribeDedicatedClusterHostsResponse> DescribeDedicatedClusterHosts(DescribeDedicatedClusterHostsRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专用集群宿主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterHostsRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterHostsResponse"/></returns>
        public DescribeDedicatedClusterHostsResponse DescribeDedicatedClusterHostsSync(DescribeDedicatedClusterHostsRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群支持的实例规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterInstanceTypesResponse"/></returns>
        public async Task<DescribeDedicatedClusterInstanceTypesResponse> DescribeDedicatedClusterInstanceTypes(DescribeDedicatedClusterInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群支持的实例规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterInstanceTypesResponse"/></returns>
        public DescribeDedicatedClusterInstanceTypesResponse DescribeDedicatedClusterInstanceTypesSync(DescribeDedicatedClusterInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOrdersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOrdersResponse"/></returns>
        public async Task<DescribeDedicatedClusterOrdersResponse> DescribeDedicatedClusterOrders(DescribeDedicatedClusterOrdersRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOrdersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOrdersResponse"/></returns>
        public DescribeDedicatedClusterOrdersResponse DescribeDedicatedClusterOrdersSync(DescribeDedicatedClusterOrdersRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专用集群概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOverviewRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOverviewResponse"/></returns>
        public async Task<DescribeDedicatedClusterOverviewResponse> DescribeDedicatedClusterOverview(DescribeDedicatedClusterOverviewRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专用集群概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterOverviewRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterOverviewResponse"/></returns>
        public DescribeDedicatedClusterOverviewResponse DescribeDedicatedClusterOverviewSync(DescribeDedicatedClusterOverviewRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专有集群配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterTypesResponse"/></returns>
        public async Task<DescribeDedicatedClusterTypesResponse> DescribeDedicatedClusterTypes(DescribeDedicatedClusterTypesRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusterTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专有集群配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClusterTypesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClusterTypesResponse"/></returns>
        public DescribeDedicatedClusterTypesResponse DescribeDedicatedClusterTypesSync(DescribeDedicatedClusterTypesRequest req)
        {
             JsonResponseModel<DescribeDedicatedClusterTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusterTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClusterTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public async Task<DescribeDedicatedClustersResponse> DescribeDedicatedClusters(DescribeDedicatedClustersRequest req)
        {
             JsonResponseModel<DescribeDedicatedClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedClustersRequest"/></param>
        /// <returns><see cref="DescribeDedicatedClustersResponse"/></returns>
        public DescribeDedicatedClustersResponse DescribeDedicatedClustersSync(DescribeDedicatedClustersRequest req)
        {
             JsonResponseModel<DescribeDedicatedClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群支持的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedSupportedZonesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedSupportedZonesResponse"/></returns>
        public async Task<DescribeDedicatedSupportedZonesResponse> DescribeDedicatedSupportedZones(DescribeDedicatedSupportedZonesRequest req)
        {
             JsonResponseModel<DescribeDedicatedSupportedZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDedicatedSupportedZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedSupportedZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专用集群支持的可用区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDedicatedSupportedZonesRequest"/></param>
        /// <returns><see cref="DescribeDedicatedSupportedZonesResponse"/></returns>
        public DescribeDedicatedSupportedZonesResponse DescribeDedicatedSupportedZonesSync(DescribeDedicatedSupportedZonesRequest req)
        {
             JsonResponseModel<DescribeDedicatedSupportedZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDedicatedSupportedZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDedicatedSupportedZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public async Task<DescribeSitesResponse> DescribeSites(DescribeSitesRequest req)
        {
             JsonResponseModel<DescribeSitesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public DescribeSitesResponse DescribeSitesSync(DescribeSitesRequest req)
        {
             JsonResponseModel<DescribeSitesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesDetailRequest"/></param>
        /// <returns><see cref="DescribeSitesDetailResponse"/></returns>
        public async Task<DescribeSitesDetailResponse> DescribeSitesDetail(DescribeSitesDetailRequest req)
        {
             JsonResponseModel<DescribeSitesDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSitesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesDetailRequest"/></param>
        /// <returns><see cref="DescribeSitesDetailResponse"/></returns>
        public DescribeSitesDetailResponse DescribeSitesDetailSync(DescribeSitesDetailRequest req)
        {
             JsonResponseModel<DescribeSitesDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSitesDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSitesDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改本地专用集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDedicatedClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDedicatedClusterInfoResponse"/></returns>
        public async Task<ModifyDedicatedClusterInfoResponse> ModifyDedicatedClusterInfo(ModifyDedicatedClusterInfoRequest req)
        {
             JsonResponseModel<ModifyDedicatedClusterInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDedicatedClusterInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDedicatedClusterInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改本地专用集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDedicatedClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDedicatedClusterInfoResponse"/></returns>
        public ModifyDedicatedClusterInfoResponse ModifyDedicatedClusterInfoSync(ModifyDedicatedClusterInfoRequest req)
        {
             JsonResponseModel<ModifyDedicatedClusterInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDedicatedClusterInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDedicatedClusterInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改大订单、小订单的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderStatusRequest"/></param>
        /// <returns><see cref="ModifyOrderStatusResponse"/></returns>
        public async Task<ModifyOrderStatusResponse> ModifyOrderStatus(ModifyOrderStatusRequest req)
        {
             JsonResponseModel<ModifyOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改大订单、小订单的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderStatusRequest"/></param>
        /// <returns><see cref="ModifyOrderStatusResponse"/></returns>
        public ModifyOrderStatusResponse ModifyOrderStatusSync(ModifyOrderStatusRequest req)
        {
             JsonResponseModel<ModifyOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机房设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifySiteDeviceInfoRequest"/></param>
        /// <returns><see cref="ModifySiteDeviceInfoResponse"/></returns>
        public async Task<ModifySiteDeviceInfoResponse> ModifySiteDeviceInfo(ModifySiteDeviceInfoRequest req)
        {
             JsonResponseModel<ModifySiteDeviceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySiteDeviceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySiteDeviceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机房设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifySiteDeviceInfoRequest"/></param>
        /// <returns><see cref="ModifySiteDeviceInfoResponse"/></returns>
        public ModifySiteDeviceInfoResponse ModifySiteDeviceInfoSync(ModifySiteDeviceInfoRequest req)
        {
             JsonResponseModel<ModifySiteDeviceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySiteDeviceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySiteDeviceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机房信息
        /// </summary>
        /// <param name="req"><see cref="ModifySiteInfoRequest"/></param>
        /// <returns><see cref="ModifySiteInfoResponse"/></returns>
        public async Task<ModifySiteInfoResponse> ModifySiteInfo(ModifySiteInfoRequest req)
        {
             JsonResponseModel<ModifySiteInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySiteInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySiteInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机房信息
        /// </summary>
        /// <param name="req"><see cref="ModifySiteInfoRequest"/></param>
        /// <returns><see cref="ModifySiteInfoResponse"/></returns>
        public ModifySiteInfoResponse ModifySiteInfoSync(ModifySiteInfoRequest req)
        {
             JsonResponseModel<ModifySiteInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySiteInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySiteInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
