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

namespace TencentCloud.Tdcpg.V20211118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdcpg.V20211118.Models;

   public class TdcpgClient : AbstractClient{

       private const string endpoint = "tdcpg.tencentcloudapi.com";
       private const string version = "2021-11-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdcpgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdcpgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 使用指定时间点的备份克隆一个新的集群
        /// </summary>
        /// <param name="req"><see cref="CloneClusterToPointInTimeRequest"/></param>
        /// <returns><see cref="CloneClusterToPointInTimeResponse"/></returns>
        public async Task<CloneClusterToPointInTimeResponse> CloneClusterToPointInTime(CloneClusterToPointInTimeRequest req)
        {
             JsonResponseModel<CloneClusterToPointInTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneClusterToPointInTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneClusterToPointInTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用指定时间点的备份克隆一个新的集群
        /// </summary>
        /// <param name="req"><see cref="CloneClusterToPointInTimeRequest"/></param>
        /// <returns><see cref="CloneClusterToPointInTimeResponse"/></returns>
        public CloneClusterToPointInTimeResponse CloneClusterToPointInTimeSync(CloneClusterToPointInTimeRequest req)
        {
             JsonResponseModel<CloneClusterToPointInTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneClusterToPointInTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneClusterToPointInTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在集群中新建实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public async Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在集群中新建实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群，集群中的实例和数据都将被删除，且无法恢复。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群，集群中的实例和数据都将被删除，且无法恢复。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例。只有当实例状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public async Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例。只有当实例状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据库账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据库账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群的备份集
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBackupsRequest"/></param>
        /// <returns><see cref="DescribeClusterBackupsResponse"/></returns>
        public async Task<DescribeClusterBackupsResponse> DescribeClusterBackups(DescribeClusterBackupsRequest req)
        {
             JsonResponseModel<DescribeClusterBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群的备份集
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBackupsRequest"/></param>
        /// <returns><see cref="DescribeClusterBackupsResponse"/></returns>
        public DescribeClusterBackupsResponse DescribeClusterBackupsSync(DescribeClusterBackupsRequest req)
        {
             JsonResponseModel<DescribeClusterBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群接入点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public async Task<DescribeClusterEndpointsResponse> DescribeClusterEndpoints(DescribeClusterEndpointsRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群接入点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public DescribeClusterEndpointsResponse DescribeClusterEndpointsSync(DescribeClusterEndpointsRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRecoveryTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeClusterRecoveryTimeRangeResponse"/></returns>
        public async Task<DescribeClusterRecoveryTimeRangeResponse> DescribeClusterRecoveryTimeRange(DescribeClusterRecoveryTimeRangeRequest req)
        {
             JsonResponseModel<DescribeClusterRecoveryTimeRangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRecoveryTimeRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRecoveryTimeRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRecoveryTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeClusterRecoveryTimeRangeResponse"/></returns>
        public DescribeClusterRecoveryTimeRangeResponse DescribeClusterRecoveryTimeRangeSync(DescribeClusterRecoveryTimeRangeRequest req)
        {
             JsonResponseModel<DescribeClusterRecoveryTimeRangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRecoveryTimeRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRecoveryTimeRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public async Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号获取资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public async Task<DescribeResourcesByDealNameResponse> DescribeResourcesByDealName(DescribeResourcesByDealNameRequest req)
        {
             JsonResponseModel<DescribeResourcesByDealNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByDealName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByDealNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号获取资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public DescribeResourcesByDealNameResponse DescribeResourcesByDealNameSync(DescribeResourcesByDealNameRequest req)
        {
             JsonResponseModel<DescribeResourcesByDealNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourcesByDealName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByDealNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离集群，集群的接入点网络将会断掉无法连接使用数据库。只有当集群状态处于running(运行中)时才生效。
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public async Task<IsolateClusterResponse> IsolateCluster(IsolateClusterRequest req)
        {
             JsonResponseModel<IsolateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离集群，集群的接入点网络将会断掉无法连接使用数据库。只有当集群状态处于running(运行中)时才生效。
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public IsolateClusterResponse IsolateClusterSync(IsolateClusterRequest req)
        {
             JsonResponseModel<IsolateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离实例。此接口只针对状态为running的实例生效，使用场景包括：
        ///  - 批量隔离集群内所有的实例
        ///  - 在读写实例为running(运行中)时，单个/批量隔离只读实例
        ///  - 集群内所有只读实例为isolated(已隔离)时，单独隔离读写实例
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterInstancesRequest"/></param>
        /// <returns><see cref="IsolateClusterInstancesResponse"/></returns>
        public async Task<IsolateClusterInstancesResponse> IsolateClusterInstances(IsolateClusterInstancesRequest req)
        {
             JsonResponseModel<IsolateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离实例。此接口只针对状态为running的实例生效，使用场景包括：
        ///  - 批量隔离集群内所有的实例
        ///  - 在读写实例为running(运行中)时，单个/批量隔离只读实例
        ///  - 集群内所有只读实例为isolated(已隔离)时，单独隔离读写实例
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterInstancesRequest"/></param>
        /// <returns><see cref="IsolateClusterInstancesResponse"/></returns>
        public IsolateClusterInstancesResponse IsolateClusterInstancesSync(IsolateClusterInstancesRequest req)
        {
             JsonResponseModel<IsolateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据库账号描述
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据库账号描述
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或者关闭接入点外网
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointWanStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointWanStatusResponse"/></returns>
        public async Task<ModifyClusterEndpointWanStatusResponse> ModifyClusterEndpointWanStatus(ModifyClusterEndpointWanStatusRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointWanStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterEndpointWanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointWanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或者关闭接入点外网
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointWanStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointWanStatusResponse"/></returns>
        public ModifyClusterEndpointWanStatusResponse ModifyClusterEndpointWanStatusSync(ModifyClusterEndpointWanStatusRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointWanStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterEndpointWanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointWanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例规格，此接口只针对状态为running(运行中)的实例生效
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterInstancesSpecRequest"/></param>
        /// <returns><see cref="ModifyClusterInstancesSpecResponse"/></returns>
        public async Task<ModifyClusterInstancesSpecResponse> ModifyClusterInstancesSpec(ModifyClusterInstancesSpecRequest req)
        {
             JsonResponseModel<ModifyClusterInstancesSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterInstancesSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterInstancesSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例规格，此接口只针对状态为running(运行中)的实例生效
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterInstancesSpecRequest"/></param>
        /// <returns><see cref="ModifyClusterInstancesSpecResponse"/></returns>
        public ModifyClusterInstancesSpecResponse ModifyClusterInstancesSpecSync(ModifyClusterInstancesSpecRequest req)
        {
             JsonResponseModel<ModifyClusterInstancesSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterInstancesSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterInstancesSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群名字
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public async Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群名字
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群自动续费，只对预付费集群生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyClustersAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyClustersAutoRenewFlagResponse"/></returns>
        public async Task<ModifyClustersAutoRenewFlagResponse> ModifyClustersAutoRenewFlag(ModifyClustersAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyClustersAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClustersAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClustersAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群自动续费，只对预付费集群生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyClustersAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyClustersAutoRenewFlagResponse"/></returns>
        public ModifyClustersAutoRenewFlagResponse ModifyClustersAutoRenewFlagSync(ModifyClustersAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyClustersAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClustersAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClustersAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复集群，恢复集群的接入点网络，恢复后继续连接使用数据库。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterRequest"/></param>
        /// <returns><see cref="RecoverClusterResponse"/></returns>
        public async Task<RecoverClusterResponse> RecoverCluster(RecoverClusterRequest req)
        {
             JsonResponseModel<RecoverClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复集群，恢复集群的接入点网络，恢复后继续连接使用数据库。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterRequest"/></param>
        /// <returns><see cref="RecoverClusterResponse"/></returns>
        public RecoverClusterResponse RecoverClusterSync(RecoverClusterRequest req)
        {
             JsonResponseModel<RecoverClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实例。此接口的使用场景包括：
        ///  - 读写实例状态为running(运行中)时，批量恢复状态为isolated(已隔离)的只读实例
        ///  - 读写实例状态为isolated(已隔离)时，恢复读写实例
        ///  - 读写实例状态为isolated(已隔离)时，批量恢复读写实例以及状态为isolated(已隔离)的只读实例
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterInstancesRequest"/></param>
        /// <returns><see cref="RecoverClusterInstancesResponse"/></returns>
        public async Task<RecoverClusterInstancesResponse> RecoverClusterInstances(RecoverClusterInstancesRequest req)
        {
             JsonResponseModel<RecoverClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实例。此接口的使用场景包括：
        ///  - 读写实例状态为running(运行中)时，批量恢复状态为isolated(已隔离)的只读实例
        ///  - 读写实例状态为isolated(已隔离)时，恢复读写实例
        ///  - 读写实例状态为isolated(已隔离)时，批量恢复读写实例以及状态为isolated(已隔离)的只读实例
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterInstancesRequest"/></param>
        /// <returns><see cref="RecoverClusterInstancesResponse"/></returns>
        public RecoverClusterInstancesResponse RecoverClusterInstancesSync(RecoverClusterInstancesRequest req)
        {
             JsonResponseModel<RecoverClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClusterRequest"/></param>
        /// <returns><see cref="RenewClusterResponse"/></returns>
        public async Task<RenewClusterResponse> RenewCluster(RenewClusterRequest req)
        {
             JsonResponseModel<RenewClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClusterRequest"/></param>
        /// <returns><see cref="RenewClusterResponse"/></returns>
        public RenewClusterResponse RenewClusterSync(RenewClusterRequest req)
        {
             JsonResponseModel<RenewClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启实例，此接口只针对状态为running(运行中)的实例生效。
        /// </summary>
        /// <param name="req"><see cref="RestartClusterInstancesRequest"/></param>
        /// <returns><see cref="RestartClusterInstancesResponse"/></returns>
        public async Task<RestartClusterInstancesResponse> RestartClusterInstances(RestartClusterInstancesRequest req)
        {
             JsonResponseModel<RestartClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启实例，此接口只针对状态为running(运行中)的实例生效。
        /// </summary>
        /// <param name="req"><see cref="RestartClusterInstancesRequest"/></param>
        /// <returns><see cref="RestartClusterInstancesResponse"/></returns>
        public RestartClusterInstancesResponse RestartClusterInstancesSync(RestartClusterInstancesRequest req)
        {
             JsonResponseModel<RestartClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 转换集群付费模式，目前只支持从 后付费 转换成 与预付费。
        /// </summary>
        /// <param name="req"><see cref="TransformClusterPayModeRequest"/></param>
        /// <returns><see cref="TransformClusterPayModeResponse"/></returns>
        public async Task<TransformClusterPayModeResponse> TransformClusterPayMode(TransformClusterPayModeRequest req)
        {
             JsonResponseModel<TransformClusterPayModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransformClusterPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformClusterPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 转换集群付费模式，目前只支持从 后付费 转换成 与预付费。
        /// </summary>
        /// <param name="req"><see cref="TransformClusterPayModeRequest"/></param>
        /// <returns><see cref="TransformClusterPayModeResponse"/></returns>
        public TransformClusterPayModeResponse TransformClusterPayModeSync(TransformClusterPayModeRequest req)
        {
             JsonResponseModel<TransformClusterPayModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransformClusterPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformClusterPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
