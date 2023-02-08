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

namespace TencentCloud.Keewidb.V20220308
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Keewidb.V20220308.Models;

   public class KeewidbClient : AbstractClient{

       private const string endpoint = "keewidb.tencentcloudapi.com";
       private const string version = "2022-03-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KeewidbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public KeewidbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChangeInstanceMaster）用于将副本节点提升为主节点。
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceMasterRequest"/></param>
        /// <returns><see cref="ChangeInstanceMasterResponse"/></returns>
        public async Task<ChangeInstanceMasterResponse> ChangeInstanceMaster(ChangeInstanceMasterRequest req)
        {
             JsonResponseModel<ChangeInstanceMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeInstanceMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChangeInstanceMaster）用于将副本节点提升为主节点。
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceMasterRequest"/></param>
        /// <returns><see cref="ChangeInstanceMasterResponse"/></returns>
        public ChangeInstanceMasterResponse ChangeInstanceMasterSync(ChangeInstanceMasterRequest req)
        {
             JsonResponseModel<ChangeInstanceMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeInstanceMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CleanUpInstance）用于立即下线回收站已隔离的实例。
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public async Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CleanUpInstance）用于立即下线回收站已隔离的实例。
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ClearInstance）用于清空实例数据。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public async Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ClearInstance）用于清空实例数据。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动发起备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupManuallyRequest"/></param>
        /// <returns><see cref="CreateBackupManuallyResponse"/></returns>
        public async Task<CreateBackupManuallyResponse> CreateBackupManually(CreateBackupManuallyRequest req)
        {
             JsonResponseModel<CreateBackupManuallyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackupManually");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupManuallyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动发起备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupManuallyRequest"/></param>
        /// <returns><see cref="CreateBackupManuallyResponse"/></returns>
        public CreateBackupManuallyResponse CreateBackupManuallySync(CreateBackupManuallyRequest req)
        {
             JsonResponseModel<CreateBackupManuallyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackupManually");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupManuallyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据库实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据库实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public async Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
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
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
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
        /// 本接口（DescribeInstanceBackups）用于查询实例全量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public async Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例全量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceBinlogs）用于查询增量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBinlogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBinlogsResponse"/></returns>
        public async Task<DescribeInstanceBinlogsResponse> DescribeInstanceBinlogs(DescribeInstanceBinlogsRequest req)
        {
             JsonResponseModel<DescribeInstanceBinlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceBinlogs）用于查询增量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBinlogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBinlogsResponse"/></returns>
        public DescribeInstanceBinlogsResponse DescribeInstanceBinlogsSync(DescribeInstanceBinlogsRequest req)
        {
             JsonResponseModel<DescribeInstanceBinlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceParamRecords）查询参数配置修改历史列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public async Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceParamRecords）查询参数配置修改历史列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public async Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceReplicas）用于获取实例副本节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceReplicasRequest"/></param>
        /// <returns><see cref="DescribeInstanceReplicasResponse"/></returns>
        public async Task<DescribeInstanceReplicasResponse> DescribeInstanceReplicas(DescribeInstanceReplicasRequest req)
        {
             JsonResponseModel<DescribeInstanceReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceReplicas）用于获取实例副本节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceReplicasRequest"/></param>
        /// <returns><see cref="DescribeInstanceReplicasResponse"/></returns>
        public DescribeInstanceReplicasResponse DescribeInstanceReplicasSync(DescribeInstanceReplicasRequest req)
        {
             JsonResponseModel<DescribeInstanceReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstances）可以根据地域、网络、实例id、标签、计费方式等条件，搜索查询实例列表。
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
        /// 本接口（DescribeInstances）可以根据地域、网络、实例id、标签、计费方式等条件，搜索查询实例列表。
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
        /// 本接口（DescribeMaintenanceWindow）用于查询实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public async Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
             JsonResponseModel<DescribeMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceWindow）用于查询实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
             JsonResponseModel<DescribeMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口查询指定可用区和实例类型下keewidb 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public async Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口查询指定可用区和实例类型下keewidb 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
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
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
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
        /// 本接口（DescribeProxySlowLog）用于查询代理（Proxy）慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public async Task<DescribeProxySlowLogResponse> DescribeProxySlowLog(DescribeProxySlowLogRequest req)
        {
             JsonResponseModel<DescribeProxySlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxySlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProxySlowLog）用于查询代理（Proxy）慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public DescribeProxySlowLogResponse DescribeProxySlowLogSync(DescribeProxySlowLogRequest req)
        {
             JsonResponseModel<DescribeProxySlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxySlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于查询异步任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于查询异步任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public async Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTendisSlowLog）用于查询实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public async Task<DescribeTendisSlowLogResponse> DescribeTendisSlowLog(DescribeTendisSlowLogRequest req)
        {
             JsonResponseModel<DescribeTendisSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTendisSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTendisSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTendisSlowLog）用于查询实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public DescribeTendisSlowLogResponse DescribeTendisSlowLogSync(DescribeTendisSlowLogRequest req)
        {
             JsonResponseModel<DescribeTendisSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTendisSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTendisSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyPostpaidInstance）用于退还按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public async Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyPostpaidInstance）用于退还按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyPrepaidInstance）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public async Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyPrepaidInstance）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于修改自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public async Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于修改自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyConnectionConfig）用于修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public async Task<ModifyConnectionConfigResponse> ModifyConnectionConfig(ModifyConnectionConfigRequest req)
        {
             JsonResponseModel<ModifyConnectionConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConnectionConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConnectionConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyConnectionConfig）用于修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public ModifyConnectionConfigResponse ModifyConnectionConfigSync(ModifyConnectionConfigRequest req)
        {
             JsonResponseModel<ModifyConnectionConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConnectionConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConnectionConfigResponse>>(strResp);
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
        /// 本接口（ModifyInstance）用于修改实例相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstance）用于修改实例相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改实例参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public async Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改实例参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceWindow）修改实例维护时间窗时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public async Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
             JsonResponseModel<ModifyMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceWindow）修改实例维护时间窗时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
             JsonResponseModel<ModifyMaintenanceWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaintenanceWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public async Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewInstance）用于为包年包月计费实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewInstance）用于为包年包月计费实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetPassword）用于重置数据库访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetPassword）用于重置数据库访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartUpInstance）用于按量计费实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartUpInstanceRequest"/></param>
        /// <returns><see cref="StartUpInstanceResponse"/></returns>
        public async Task<StartUpInstanceResponse> StartUpInstance(StartUpInstanceRequest req)
        {
             JsonResponseModel<StartUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartUpInstance）用于按量计费实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartUpInstanceRequest"/></param>
        /// <returns><see cref="StartUpInstanceResponse"/></returns>
        public StartUpInstanceResponse StartUpInstanceSync(StartUpInstanceRequest req)
        {
             JsonResponseModel<StartUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeInstance）用于对实例进行配置变更。
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
        /// 本接口（UpgradeInstance）用于对实例进行配置变更。
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
