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

namespace TencentCloud.Cynosdb.V20190107
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cynosdb.V20190107.Models;

   public class CynosdbClient : AbstractClient{

       private const string endpoint = "cynosdb.tencentcloudapi.com";
       private const string version = "2019-01-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CynosdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CynosdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AddInstances）用于集群添加实例
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public async Task<AddInstancesResponse> AddInstances(AddInstancesRequest req)
        {
             JsonResponseModel<AddInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AddInstances）用于集群添加实例
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public AddInstancesResponse AddInstancesSync(AddInstancesRequest req)
        {
             JsonResponseModel<AddInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddInstancesResponse>>(strResp);
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
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public async Task<CreateClustersResponse> CreateClusters(CreateClustersRequest req)
        {
             JsonResponseModel<CreateClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClustersResponse>>(strResp);
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
        /// <param name="req"><see cref="CreateClustersRequest"/></param>
        /// <returns><see cref="CreateClustersResponse"/></returns>
        public CreateClustersResponse CreateClustersSync(CreateClustersRequest req)
        {
             JsonResponseModel<CreateClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询数据库管理账号。
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
        /// 本接口(DescribeAccounts)用于查询数据库管理账号。
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
        /// 获取指定集群的备份配置信息，包括全量备份时间段，备份文件保留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public async Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定集群的备份配置信息，包括全量备份时间段，备份文件保留时间
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public async Task<DescribeBackupListResponse> DescribeBackupList(DescribeBackupListRequest req)
        {
             JsonResponseModel<DescribeBackupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupListRequest"/></param>
        /// <returns><see cref="DescribeBackupListResponse"/></returns>
        public DescribeBackupListResponse DescribeBackupListSync(DescribeBackupListRequest req)
        {
             JsonResponseModel<DescribeBackupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 显示集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 显示集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public async Task<DescribeClusterInstanceGrpsResponse> DescribeClusterInstanceGrps(DescribeClusterInstanceGrpsRequest req)
        {
             JsonResponseModel<DescribeClusterInstanceGrpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstanceGrps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstanceGrpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusterInstanceGrps）用于查询实例组
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstanceGrpsRequest"/></param>
        /// <returns><see cref="DescribeClusterInstanceGrpsResponse"/></returns>
        public DescribeClusterInstanceGrpsResponse DescribeClusterInstanceGrpsSync(DescribeClusterInstanceGrpsRequest req)
        {
             JsonResponseModel<DescribeClusterInstanceGrpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInstanceGrps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstanceGrpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群列表
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
        /// 查询集群列表
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
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstanceDetail)用于查询实例详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public async Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstanceDetail)用于查询实例详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceSpecs）用于查询实例规格
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecs(DescribeInstanceSpecsRequest req)
        {
             JsonResponseModel<DescribeInstanceSpecsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceSpecs）用于查询实例规格
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeInstanceSpecsResponse"/></returns>
        public DescribeInstanceSpecsResponse DescribeInstanceSpecsSync(DescribeInstanceSpecsRequest req)
        {
             JsonResponseModel<DescribeInstanceSpecsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例维护时间窗
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public async Task<DescribeMaintainPeriodResponse> DescribeMaintainPeriod(DescribeMaintainPeriodRequest req)
        {
             JsonResponseModel<DescribeMaintainPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaintainPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintainPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例维护时间窗
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintainPeriodRequest"/></param>
        /// <returns><see cref="DescribeMaintainPeriodResponse"/></returns>
        public DescribeMaintainPeriodResponse DescribeMaintainPeriodSync(DescribeMaintainPeriodRequest req)
        {
             JsonResponseModel<DescribeMaintainPeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaintainPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintainPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定集群有效回滚时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public async Task<DescribeRollbackTimeRangeResponse> DescribeRollbackTimeRange(DescribeRollbackTimeRangeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeRangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackTimeRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定集群有效回滚时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeRangeResponse"/></returns>
        public DescribeRollbackTimeRangeResponse DescribeRollbackTimeRangeSync(DescribeRollbackTimeRangeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeRangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackTimeRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定时间和集群查询是否可回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeValidityRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeValidityResponse"/></returns>
        public async Task<DescribeRollbackTimeValidityResponse> DescribeRollbackTimeValidity(DescribeRollbackTimeValidityRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeValidityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackTimeValidity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeValidityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定时间和集群查询是否可回滚
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeValidityRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeValidityResponse"/></returns>
        public DescribeRollbackTimeValidityResponse DescribeRollbackTimeValiditySync(DescribeRollbackTimeValidityRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeValidityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackTimeValidity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeValidityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离集群
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
        /// 隔离集群
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
        /// 本接口(IsolateInstance)用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public async Task<IsolateInstanceResponse> IsolateInstance(IsolateInstanceRequest req)
        {
             JsonResponseModel<IsolateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateInstance)用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateInstanceRequest"/></param>
        /// <returns><see cref="IsolateInstanceResponse"/></returns>
        public IsolateInstanceResponse IsolateInstanceSync(IsolateInstanceRequest req)
        {
             JsonResponseModel<IsolateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定集群的备份配置
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public async Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定集群的备份配置
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改维护时间配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public async Task<ModifyMaintainPeriodConfigResponse> ModifyMaintainPeriodConfig(ModifyMaintainPeriodConfigRequest req)
        {
             JsonResponseModel<ModifyMaintainPeriodConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaintainPeriodConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintainPeriodConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改维护时间配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintainPeriodConfigRequest"/></param>
        /// <returns><see cref="ModifyMaintainPeriodConfigResponse"/></returns>
        public ModifyMaintainPeriodConfigResponse ModifyMaintainPeriodConfigSync(ModifyMaintainPeriodConfigRequest req)
        {
             JsonResponseModel<ModifyMaintainPeriodConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaintainPeriodConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintainPeriodConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线集群
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public async Task<OfflineClusterResponse> OfflineCluster(OfflineClusterRequest req)
        {
             JsonResponseModel<OfflineClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线集群
        /// </summary>
        /// <param name="req"><see cref="OfflineClusterRequest"/></param>
        /// <returns><see cref="OfflineClusterResponse"/></returns>
        public OfflineClusterResponse OfflineClusterSync(OfflineClusterRequest req)
        {
             JsonResponseModel<OfflineClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线实例
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public async Task<OfflineInstanceResponse> OfflineInstance(OfflineInstanceRequest req)
        {
             JsonResponseModel<OfflineInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线实例
        /// </summary>
        /// <param name="req"><see cref="OfflineInstanceRequest"/></param>
        /// <returns><see cref="OfflineInstanceResponse"/></returns>
        public OfflineInstanceResponse OfflineInstanceSync(OfflineInstanceRequest req)
        {
             JsonResponseModel<OfflineInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetRenewFlag设置实例的自动续费功能
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public async Task<SetRenewFlagResponse> SetRenewFlag(SetRenewFlagRequest req)
        {
             JsonResponseModel<SetRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetRenewFlag设置实例的自动续费功能
        /// </summary>
        /// <param name="req"><see cref="SetRenewFlagRequest"/></param>
        /// <returns><see cref="SetRenewFlagResponse"/></returns>
        public SetRenewFlagResponse SetRenewFlagSync(SetRenewFlagRequest req)
        {
             JsonResponseModel<SetRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
