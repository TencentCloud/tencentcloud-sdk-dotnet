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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加复制组成员
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public async Task<AddReplicationInstanceResponse> AddReplicationInstance(AddReplicationInstanceRequest req)
        {
             JsonResponseModel<AddReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加复制组成员
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public AddReplicationInstanceResponse AddReplicationInstanceSync(AddReplicationInstanceRequest req)
        {
             JsonResponseModel<AddReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通外网
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public async Task<AllocateWanAddressResponse> AllocateWanAddress(AllocateWanAddressRequest req)
        {
             JsonResponseModel<AllocateWanAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通外网
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public AllocateWanAddressResponse AllocateWanAddressSync(AllocateWanAddressRequest req)
        {
             JsonResponseModel<AllocateWanAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用参数模板到实例
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public async Task<ApplyParamsTemplateResponse> ApplyParamsTemplate(ApplyParamsTemplateRequest req)
        {
             JsonResponseModel<ApplyParamsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyParamsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyParamsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用参数模板到实例
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public ApplyParamsTemplateResponse ApplyParamsTemplateSync(ApplyParamsTemplateRequest req)
        {
             JsonResponseModel<ApplyParamsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyParamsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyParamsTemplateResponse>>(strResp);
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
        /// 复制组实例更换角色
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public async Task<ChangeInstanceRoleResponse> ChangeInstanceRole(ChangeInstanceRoleRequest req)
        {
             JsonResponseModel<ChangeInstanceRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeInstanceRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制组实例更换角色
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public ChangeInstanceRoleResponse ChangeInstanceRoleSync(ChangeInstanceRoleRequest req)
        {
             JsonResponseModel<ChangeInstanceRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeInstanceRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeInstanceRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制组实例切主
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public async Task<ChangeMasterInstanceResponse> ChangeMasterInstance(ChangeMasterInstanceRequest req)
        {
             JsonResponseModel<ChangeMasterInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeMasterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeMasterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制组实例切主
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public ChangeMasterInstanceResponse ChangeMasterInstanceSync(ChangeMasterInstanceRequest req)
        {
             JsonResponseModel<ChangeMasterInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeMasterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeMasterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChangeReplicaToMaster）适用于实例副本组提主或副本提主。
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public async Task<ChangeReplicaToMasterResponse> ChangeReplicaToMaster(ChangeReplicaToMasterRequest req)
        {
             JsonResponseModel<ChangeReplicaToMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeReplicaToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeReplicaToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ChangeReplicaToMaster）适用于实例副本组提主或副本提主。
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public ChangeReplicaToMasterResponse ChangeReplicaToMasterSync(ChangeReplicaToMasterRequest req)
        {
             JsonResponseModel<ChangeReplicaToMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeReplicaToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeReplicaToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回收站实例立即下线
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
        /// 回收站实例立即下线
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
        /// 清空Redis实例的实例数据。
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
        /// 清空Redis实例的实例数据。
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
        /// 本接口（CloneInstances）用于基于当前实例的备份文件克隆一个完整的新实例。
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public async Task<CloneInstancesResponse> CloneInstances(CloneInstancesRequest req)
        {
             JsonResponseModel<CloneInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloneInstances）用于基于当前实例的备份文件克隆一个完整的新实例。
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public CloneInstancesResponse CloneInstancesSync(CloneInstancesRequest req)
        {
             JsonResponseModel<CloneInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭SSL
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public async Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
             JsonResponseModel<CloseSSLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭SSL
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
             JsonResponseModel<CloseSSLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例子账号
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例子账号
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateInstances）用于创建 Redis 实例。
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
        /// 本接口（CreateInstances）用于创建 Redis 实例。
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
        /// 创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public async Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建复制组
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public async Task<CreateReplicationGroupResponse> CreateReplicationGroup(CreateReplicationGroupRequest req)
        {
             JsonResponseModel<CreateReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建复制组
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public CreateReplicationGroupResponse CreateReplicationGroupSync(CreateReplicationGroupRequest req)
        {
             JsonResponseModel<CreateReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例子账号
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例子账号
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除参数模板
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public async Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除参数模板
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除复制组成员 注：接口下线中，请使用 RemoveReplicationInstance
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public async Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除复制组成员 注：接口下线中，请使用 RemoveReplicationInstance
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
             JsonResponseModel<DeleteReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取备份配置
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
        /// 获取备份配置
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
        /// 本接口（DescribeBackupDownloadRestriction）用于查询当前地域数据库备份文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public async Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询当前地域数据库备份文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupUrl）用于查询备份 Rdb 文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public async Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupUrl）用于查询备份 Rdb 文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBandwidthRange）用于查询实例带宽信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public async Task<DescribeBandwidthRangeResponse> DescribeBandwidthRange(DescribeBandwidthRangeRequest req)
        {
             JsonResponseModel<DescribeBandwidthRangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBandwidthRange）用于查询实例带宽信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public DescribeBandwidthRangeResponse DescribeBandwidthRangeSync(DescribeBandwidthRangeRequest req)
        {
             JsonResponseModel<DescribeBandwidthRangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthRange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthRangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Redis实例列表信息。该接口已废弃。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public async Task<DescribeCommonDBInstancesResponse> DescribeCommonDBInstances(DescribeCommonDBInstancesRequest req)
        {
             JsonResponseModel<DescribeCommonDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCommonDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommonDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Redis实例列表信息。该接口已废弃。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public DescribeCommonDBInstancesResponse DescribeCommonDBInstancesSync(DescribeCommonDBInstancesRequest req)
        {
             JsonResponseModel<DescribeCommonDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCommonDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommonDBInstancesResponse>>(strResp);
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
        /// 查看实例子账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public async Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看实例子账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例备份列表。
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
        /// 本接口（DescribeInstanceBackups）用于查询实例备份列表。
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
        /// 查询实例DTS信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public async Task<DescribeInstanceDTSInfoResponse> DescribeInstanceDTSInfo(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例DTS信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public DescribeInstanceDTSInfoResponse DescribeInstanceDTSInfoSync(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public async Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见[查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见[查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例热Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例热Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问来源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public async Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问来源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问的耗时分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问的耗时分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问命令
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问命令
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例CPU耗时
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例CPU耗时
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例节点信息
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
        /// 查询实例节点信息
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
        /// 查询参数修改历史列表
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
        /// 查询参数修改历史列表
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
        /// 查询实例参数列表
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
        /// 查询实例参数列表
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
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public async Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceShards）用于获取集群架构实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public async Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceShards）用于获取集群架构实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Redis节点详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public async Task<DescribeInstanceZoneInfoResponse> DescribeInstanceZoneInfo(DescribeInstanceZoneInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Redis节点详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public DescribeInstanceZoneInfoResponse DescribeInstanceZoneInfoSync(DescribeInstanceZoneInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询Redis实例列表。
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
        /// 本接口（DescribeInstances）用于查询Redis实例列表。
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
        /// 查询实例维护时间窗，在实例需要进行版本升级或者架构升级的时候，会在维护时间窗时间内进行切换
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
        /// 查询实例维护时间窗，在实例需要进行版本升级或者架构升级的时候，会在维护时间窗时间内进行切换
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
        /// 本接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public async Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询参数模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public async Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询参数模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductInfo）用于查询全地域 Redis 的售卖规格。
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
        /// 本接口（DescribeProductInfo）用于查询全地域 Redis 的售卖规格。
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
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
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
        /// 本接口（DescribeProxySlowLog）用于查询代理慢查询。
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
        /// 本接口（DescribeProxySlowLog）用于查询代理慢查询。
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
        /// 本接口（DescribeReplicationGroup）查询复制组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public async Task<DescribeReplicationGroupResponse> DescribeReplicationGroup(DescribeReplicationGroupRequest req)
        {
             JsonResponseModel<DescribeReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReplicationGroup）查询复制组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public DescribeReplicationGroupResponse DescribeReplicationGroupSync(DescribeReplicationGroupRequest req)
        {
             JsonResponseModel<DescribeReplicationGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSSLStatus）用于查询实例 SSL 认证相关信息，包括开启状态、配置状态、证书地址等。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public async Task<DescribeSSLStatusResponse> DescribeSSLStatus(DescribeSSLStatusRequest req)
        {
             JsonResponseModel<DescribeSSLStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSSLStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSSLStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSSLStatus）用于查询实例 SSL 认证相关信息，包括开启状态、配置状态、证书地址等。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public DescribeSSLStatusResponse DescribeSSLStatusSync(DescribeSSLStatusRequest req)
        {
             JsonResponseModel<DescribeSSLStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSSLStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSSLStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLog）查询实例慢查询记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public async Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLog）查询实例慢查询记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务结果
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
        /// 用于查询任务结果
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
        /// 本接口（DescribeTaskList）用于查询指定实例的任务列表信息。
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
        /// 本接口（DescribeTaskList）用于查询指定实例的任务列表信息。
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
        /// 查询Tendis慢查询
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
        /// 查询Tendis慢查询
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
        /// 按量计费实例销毁
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
        /// 按量计费实例销毁
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
        /// 包年包月实例退还
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
        /// 包年包月实例退还
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
        /// 禁用读写分离
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public async Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用读写分离
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
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
        /// 启用读写分离
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public async Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用读写分离
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新购实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public async Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询新购实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例续费价格（包年包月）
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例续费价格（包年包月）
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例扩容价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeInstanceResponse> InquiryPriceUpgradeInstance(InquiryPriceUpgradeInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例扩容价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public InquiryPriceUpgradeInstanceResponse InquiryPriceUpgradeInstanceSync(InquiryPriceUpgradeInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（KillMasterGroup）模拟故障。
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public async Task<KillMasterGroupResponse> KillMasterGroup(KillMasterGroupRequest req)
        {
             JsonResponseModel<KillMasterGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillMasterGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMasterGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（KillMasterGroup）模拟故障。
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public KillMasterGroupResponse KillMasterGroupSync(KillMasterGroupRequest req)
        {
             JsonResponseModel<KillMasterGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillMasterGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMasterGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动备份Redis实例
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public async Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动备份Redis实例
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModfiyInstancePassword）用于修改实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public async Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModfiyInstancePassword）用于修改实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于设置自动备份的配置。
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
        /// 本接口（ModifyAutoBackupConfig）用于设置自动备份的配置。
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
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载的网络信息与地址。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public async Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载的网络信息与地址。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的连接配置，包括带宽和最大连接数。
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
        /// 修改实例的连接配置，包括带宽和最大连接数。
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
        /// 修改实例相关信息
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
        /// 修改实例相关信息
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
        /// 修改实例子账号
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public async Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例子账号
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyInstanceParams)用于修改Redis实例的参数配置。
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
        /// 本接口(ModifyInstanceParams)用于修改Redis实例的参数配置。
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
        /// 设置实例输入模式
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public async Task<ModifyInstanceReadOnlyResponse> ModifyInstanceReadOnly(ModifyInstanceReadOnlyRequest req)
        {
             JsonResponseModel<ModifyInstanceReadOnlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceReadOnly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceReadOnlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实例输入模式
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public ModifyInstanceReadOnlyResponse ModifyInstanceReadOnlySync(ModifyInstanceReadOnlyRequest req)
        {
             JsonResponseModel<ModifyInstanceReadOnlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceReadOnly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceReadOnlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例维护时间窗时间，需要进行版本升级或者架构升级的实例，会在维护时间窗内进行时间切换。注意：已经发起版本升级或者架构升级的实例，无法修改维护时间窗。
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
        /// 修改实例维护时间窗时间，需要进行版本升级或者架构升级的实例，会在维护时间窗内进行时间切换。注意：已经发起版本升级或者架构升级的实例，无法修改维护时间窗。
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
        /// 修改参数模板
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public async Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改参数模板
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启SSL
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public async Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
             JsonResponseModel<OpenSSLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启SSL
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
             JsonResponseModel<OpenSSLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenSSL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenSSLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭外网
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public async Task<ReleaseWanAddressResponse> ReleaseWanAddress(ReleaseWanAddressRequest req)
        {
             JsonResponseModel<ReleaseWanAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭外网
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public ReleaseWanAddressResponse ReleaseWanAddressSync(ReleaseWanAddressRequest req)
        {
             JsonResponseModel<ReleaseWanAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseWanAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseWanAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除复制组成员
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public async Task<RemoveReplicationInstanceResponse> RemoveReplicationInstance(RemoveReplicationInstanceRequest req)
        {
             JsonResponseModel<RemoveReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除复制组成员
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public RemoveReplicationInstanceResponse RemoveReplicationInstanceSync(RemoveReplicationInstanceRequest req)
        {
             JsonResponseModel<RemoveReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewInstance）可用于为实例续费。
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
        /// 本接口（RenewInstance）可用于为实例续费。
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
        /// 重置密码
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
        /// 重置密码
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
        /// 恢复 CRS 实例
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复 CRS 实例
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public async Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public async Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Proxy模拟故障接口
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public async Task<SwitchProxyResponse> SwitchProxy(SwitchProxyRequest req)
        {
             JsonResponseModel<SwitchProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Proxy模拟故障接口
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public SwitchProxyResponse SwitchProxySync(SwitchProxyRequest req)
        {
             JsonResponseModel<SwitchProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变更实例配置
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
        /// 变更实例配置
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

        /// <summary>
        /// 将原本实例升级到高版本实例，或者将主从版实例升级到集群版实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersion(UpgradeInstanceVersionRequest req)
        {
             JsonResponseModel<UpgradeInstanceVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstanceVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将原本实例升级到高版本实例，或者将主从版实例升级到集群版实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionSync(UpgradeInstanceVersionRequest req)
        {
             JsonResponseModel<UpgradeInstanceVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstanceVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例proxy版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public async Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例proxy版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例小版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public async Task<UpgradeSmallVersionResponse> UpgradeSmallVersion(UpgradeSmallVersionRequest req)
        {
             JsonResponseModel<UpgradeSmallVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeSmallVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeSmallVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例小版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public UpgradeSmallVersionResponse UpgradeSmallVersionSync(UpgradeSmallVersionRequest req)
        {
             JsonResponseModel<UpgradeSmallVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeSmallVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeSmallVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级实例支持多AZ
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public async Task<UpgradeVersionToMultiAvailabilityZonesResponse> UpgradeVersionToMultiAvailabilityZones(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
             JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeVersionToMultiAvailabilityZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级实例支持多AZ
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public UpgradeVersionToMultiAvailabilityZonesResponse UpgradeVersionToMultiAvailabilityZonesSync(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
             JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeVersionToMultiAvailabilityZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeVersionToMultiAvailabilityZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
