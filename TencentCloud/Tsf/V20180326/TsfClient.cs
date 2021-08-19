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

namespace TencentCloud.Tsf.V20180326
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tsf.V20180326.Models;

   public class TsfClient : AbstractClient{

       private const string endpoint = "tsf.tencentcloudapi.com";
       private const string version = "2018-03-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TsfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TsfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddClusterInstancesRequest"/></param>
        /// <returns><see cref="AddClusterInstancesResponse"/></returns>
        public async Task<AddClusterInstancesResponse> AddClusterInstances(AddClusterInstancesRequest req)
        {
             JsonResponseModel<AddClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddClusterInstancesRequest"/></param>
        /// <returns><see cref="AddClusterInstancesResponse"/></returns>
        public AddClusterInstancesResponse AddClusterInstancesSync(AddClusterInstancesRequest req)
        {
             JsonResponseModel<AddClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
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
        /// 添加云主机节点至TSF集群
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
        /// 网关与API分组批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindApiGroupRequest"/></param>
        /// <returns><see cref="BindApiGroupResponse"/></returns>
        public async Task<BindApiGroupResponse> BindApiGroup(BindApiGroupRequest req)
        {
             JsonResponseModel<BindApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网关与API分组批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindApiGroupRequest"/></param>
        /// <returns><see cref="BindApiGroupResponse"/></returns>
        public BindApiGroupResponse BindApiGroupSync(BindApiGroupRequest req)
        {
             JsonResponseModel<BindApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 插件与网关分组/API批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindPluginRequest"/></param>
        /// <returns><see cref="BindPluginResponse"/></returns>
        public async Task<BindPluginResponse> BindPlugin(BindPluginRequest req)
        {
             JsonResponseModel<BindPluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 插件与网关分组/API批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindPluginRequest"/></param>
        /// <returns><see cref="BindPluginResponse"/></returns>
        public BindPluginResponse BindPluginSync(BindPluginRequest req)
        {
             JsonResponseModel<BindPluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用或禁用API
        /// </summary>
        /// <param name="req"><see cref="ChangeApiUsableStatusRequest"/></param>
        /// <returns><see cref="ChangeApiUsableStatusResponse"/></returns>
        public async Task<ChangeApiUsableStatusResponse> ChangeApiUsableStatus(ChangeApiUsableStatusRequest req)
        {
             JsonResponseModel<ChangeApiUsableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeApiUsableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeApiUsableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用或禁用API
        /// </summary>
        /// <param name="req"><see cref="ChangeApiUsableStatusRequest"/></param>
        /// <returns><see cref="ChangeApiUsableStatusResponse"/></returns>
        public ChangeApiUsableStatusResponse ChangeApiUsableStatusSync(ChangeApiUsableStatusRequest req)
        {
             JsonResponseModel<ChangeApiUsableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeApiUsableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeApiUsableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对执行失败的任务批次执行续跑
        /// </summary>
        /// <param name="req"><see cref="ContinueRunFailedTaskBatchRequest"/></param>
        /// <returns><see cref="ContinueRunFailedTaskBatchResponse"/></returns>
        public async Task<ContinueRunFailedTaskBatchResponse> ContinueRunFailedTaskBatch(ContinueRunFailedTaskBatchRequest req)
        {
             JsonResponseModel<ContinueRunFailedTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ContinueRunFailedTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueRunFailedTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对执行失败的任务批次执行续跑
        /// </summary>
        /// <param name="req"><see cref="ContinueRunFailedTaskBatchRequest"/></param>
        /// <returns><see cref="ContinueRunFailedTaskBatchResponse"/></returns>
        public ContinueRunFailedTaskBatchResponse ContinueRunFailedTaskBatchSync(ContinueRunFailedTaskBatchRequest req)
        {
             JsonResponseModel<ContinueRunFailedTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ContinueRunFailedTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContinueRunFailedTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键导入API分组
        /// </summary>
        /// <param name="req"><see cref="CreateAllGatewayApiAsyncRequest"/></param>
        /// <returns><see cref="CreateAllGatewayApiAsyncResponse"/></returns>
        public async Task<CreateAllGatewayApiAsyncResponse> CreateAllGatewayApiAsync(CreateAllGatewayApiAsyncRequest req)
        {
             JsonResponseModel<CreateAllGatewayApiAsyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAllGatewayApiAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAllGatewayApiAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键导入API分组
        /// </summary>
        /// <param name="req"><see cref="CreateAllGatewayApiAsyncRequest"/></param>
        /// <returns><see cref="CreateAllGatewayApiAsyncResponse"/></returns>
        public CreateAllGatewayApiAsyncResponse CreateAllGatewayApiAsyncSync(CreateAllGatewayApiAsyncRequest req)
        {
             JsonResponseModel<CreateAllGatewayApiAsyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAllGatewayApiAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAllGatewayApiAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建API分组
        /// </summary>
        /// <param name="req"><see cref="CreateApiGroupRequest"/></param>
        /// <returns><see cref="CreateApiGroupResponse"/></returns>
        public async Task<CreateApiGroupResponse> CreateApiGroup(CreateApiGroupRequest req)
        {
             JsonResponseModel<CreateApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建API分组
        /// </summary>
        /// <param name="req"><see cref="CreateApiGroupRequest"/></param>
        /// <returns><see cref="CreateApiGroupResponse"/></returns>
        public CreateApiGroupResponse CreateApiGroupSync(CreateApiGroupRequest req)
        {
             JsonResponseModel<CreateApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建API限流规则
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleResponse"/></returns>
        public async Task<CreateApiRateLimitRuleResponse> CreateApiRateLimitRule(CreateApiRateLimitRuleRequest req)
        {
             JsonResponseModel<CreateApiRateLimitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiRateLimitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiRateLimitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建API限流规则
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleResponse"/></returns>
        public CreateApiRateLimitRuleResponse CreateApiRateLimitRuleSync(CreateApiRateLimitRuleRequest req)
        {
             JsonResponseModel<CreateApiRateLimitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiRateLimitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiRateLimitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
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
        /// 创建配置项
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public async Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建配置项
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器部署组
        /// </summary>
        /// <param name="req"><see cref="CreateContainGroupRequest"/></param>
        /// <returns><see cref="CreateContainGroupResponse"/></returns>
        public async Task<CreateContainGroupResponse> CreateContainGroup(CreateContainGroupRequest req)
        {
             JsonResponseModel<CreateContainGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContainGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContainGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器部署组
        /// </summary>
        /// <param name="req"><see cref="CreateContainGroupRequest"/></param>
        /// <returns><see cref="CreateContainGroupResponse"/></returns>
        public CreateContainGroupResponse CreateContainGroupSync(CreateContainGroupRequest req)
        {
             JsonResponseModel<CreateContainGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContainGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContainGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件配置项
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigRequest"/></param>
        /// <returns><see cref="CreateFileConfigResponse"/></returns>
        public async Task<CreateFileConfigResponse> CreateFileConfig(CreateFileConfigRequest req)
        {
             JsonResponseModel<CreateFileConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFileConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件配置项
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigRequest"/></param>
        /// <returns><see cref="CreateFileConfigResponse"/></returns>
        public CreateFileConfigResponse CreateFileConfigSync(CreateFileConfigRequest req)
        {
             JsonResponseModel<CreateFileConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFileConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量导入API至api分组(也支持新建API到分组)
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayApiRequest"/></param>
        /// <returns><see cref="CreateGatewayApiResponse"/></returns>
        public async Task<CreateGatewayApiResponse> CreateGatewayApi(CreateGatewayApiRequest req)
        {
             JsonResponseModel<CreateGatewayApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGatewayApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGatewayApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量导入API至api分组(也支持新建API到分组)
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayApiRequest"/></param>
        /// <returns><see cref="CreateGatewayApiResponse"/></returns>
        public CreateGatewayApiResponse CreateGatewayApiSync(CreateGatewayApiRequest req)
        {
             JsonResponseModel<CreateGatewayApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGatewayApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGatewayApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建泳道
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRequest"/></param>
        /// <returns><see cref="CreateLaneResponse"/></returns>
        public async Task<CreateLaneResponse> CreateLane(CreateLaneRequest req)
        {
             JsonResponseModel<CreateLaneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建泳道
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRequest"/></param>
        /// <returns><see cref="CreateLaneResponse"/></returns>
        public CreateLaneResponse CreateLaneSync(CreateLaneRequest req)
        {
             JsonResponseModel<CreateLaneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建泳道规则
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRuleRequest"/></param>
        /// <returns><see cref="CreateLaneRuleResponse"/></returns>
        public async Task<CreateLaneRuleResponse> CreateLaneRule(CreateLaneRuleRequest req)
        {
             JsonResponseModel<CreateLaneRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLaneRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaneRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建泳道规则
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRuleRequest"/></param>
        /// <returns><see cref="CreateLaneRuleResponse"/></returns>
        public CreateLaneRuleResponse CreateLaneRuleSync(CreateLaneRuleRequest req)
        {
             JsonResponseModel<CreateLaneRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLaneRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaneRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增微服务
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceRequest"/></param>
        /// <returns><see cref="CreateMicroserviceResponse"/></returns>
        public async Task<CreateMicroserviceResponse> CreateMicroservice(CreateMicroserviceRequest req)
        {
             JsonResponseModel<CreateMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增微服务
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceRequest"/></param>
        /// <returns><see cref="CreateMicroserviceResponse"/></returns>
        public CreateMicroserviceResponse CreateMicroserviceSync(CreateMicroserviceRequest req)
        {
             JsonResponseModel<CreateMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路径重写
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesRequest"/></param>
        /// <returns><see cref="CreatePathRewritesResponse"/></returns>
        public async Task<CreatePathRewritesResponse> CreatePathRewrites(CreatePathRewritesRequest req)
        {
             JsonResponseModel<CreatePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路径重写
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesRequest"/></param>
        /// <returns><see cref="CreatePathRewritesResponse"/></returns>
        public CreatePathRewritesResponse CreatePathRewritesSync(CreatePathRewritesRequest req)
        {
             JsonResponseModel<CreatePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建公共配置项
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigRequest"/></param>
        /// <returns><see cref="CreatePublicConfigResponse"/></returns>
        public async Task<CreatePublicConfigResponse> CreatePublicConfig(CreatePublicConfigRequest req)
        {
             JsonResponseModel<CreatePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建公共配置项
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigRequest"/></param>
        /// <returns><see cref="CreatePublicConfigResponse"/></returns>
        public CreatePublicConfigResponse CreatePublicConfigSync(CreatePublicConfigRequest req)
        {
             JsonResponseModel<CreatePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public async Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
             JsonResponseModel<CreateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessGroupRequest"/></param>
        /// <returns><see cref="CreateServerlessGroupResponse"/></returns>
        public async Task<CreateServerlessGroupResponse> CreateServerlessGroup(CreateServerlessGroupRequest req)
        {
             JsonResponseModel<CreateServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessGroupRequest"/></param>
        /// <returns><see cref="CreateServerlessGroupResponse"/></returns>
        public CreateServerlessGroupResponse CreateServerlessGroupSync(CreateServerlessGroupRequest req)
        {
             JsonResponseModel<CreateServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFlowRequest"/></param>
        /// <returns><see cref="CreateTaskFlowResponse"/></returns>
        public async Task<CreateTaskFlowResponse> CreateTaskFlow(CreateTaskFlowRequest req)
        {
             JsonResponseModel<CreateTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFlowRequest"/></param>
        /// <returns><see cref="CreateTaskFlowResponse"/></returns>
        public CreateTaskFlowResponse CreateTaskFlowSync(CreateTaskFlowRequest req)
        {
             JsonResponseModel<CreateTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建单元化规则
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleRequest"/></param>
        /// <returns><see cref="CreateUnitRuleResponse"/></returns>
        public async Task<CreateUnitRuleResponse> CreateUnitRule(CreateUnitRuleRequest req)
        {
             JsonResponseModel<CreateUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建单元化规则
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleRequest"/></param>
        /// <returns><see cref="CreateUnitRuleResponse"/></returns>
        public CreateUnitRuleResponse CreateUnitRuleSync(CreateUnitRuleRequest req)
        {
             JsonResponseModel<CreateUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Api分组
        /// </summary>
        /// <param name="req"><see cref="DeleteApiGroupRequest"/></param>
        /// <returns><see cref="DeleteApiGroupResponse"/></returns>
        public async Task<DeleteApiGroupResponse> DeleteApiGroup(DeleteApiGroupRequest req)
        {
             JsonResponseModel<DeleteApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Api分组
        /// </summary>
        /// <param name="req"><see cref="DeleteApiGroupRequest"/></param>
        /// <returns><see cref="DeleteApiGroupResponse"/></returns>
        public DeleteApiGroupResponse DeleteApiGroupSync(DeleteApiGroupRequest req)
        {
             JsonResponseModel<DeleteApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public async Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
             JsonResponseModel<DeleteApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
             JsonResponseModel<DeleteApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public async Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerGroupRequest"/></param>
        /// <returns><see cref="DeleteContainerGroupResponse"/></returns>
        public async Task<DeleteContainerGroupResponse> DeleteContainerGroup(DeleteContainerGroupRequest req)
        {
             JsonResponseModel<DeleteContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerGroupRequest"/></param>
        /// <returns><see cref="DeleteContainerGroupResponse"/></returns>
        public DeleteContainerGroupResponse DeleteContainerGroupSync(DeleteContainerGroupRequest req)
        {
             JsonResponseModel<DeleteContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除镜像版本
        /// </summary>
        /// <param name="req"><see cref="DeleteImageTagsRequest"/></param>
        /// <returns><see cref="DeleteImageTagsResponse"/></returns>
        public async Task<DeleteImageTagsResponse> DeleteImageTags(DeleteImageTagsRequest req)
        {
             JsonResponseModel<DeleteImageTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除镜像版本
        /// </summary>
        /// <param name="req"><see cref="DeleteImageTagsRequest"/></param>
        /// <returns><see cref="DeleteImageTagsResponse"/></returns>
        public DeleteImageTagsResponse DeleteImageTagsSync(DeleteImageTagsRequest req)
        {
             JsonResponseModel<DeleteImageTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除泳道
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRequest"/></param>
        /// <returns><see cref="DeleteLaneResponse"/></returns>
        public async Task<DeleteLaneResponse> DeleteLane(DeleteLaneRequest req)
        {
             JsonResponseModel<DeleteLaneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除泳道
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRequest"/></param>
        /// <returns><see cref="DeleteLaneResponse"/></returns>
        public DeleteLaneResponse DeleteLaneSync(DeleteLaneRequest req)
        {
             JsonResponseModel<DeleteLaneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除微服务
        /// </summary>
        /// <param name="req"><see cref="DeleteMicroserviceRequest"/></param>
        /// <returns><see cref="DeleteMicroserviceResponse"/></returns>
        public async Task<DeleteMicroserviceResponse> DeleteMicroservice(DeleteMicroserviceRequest req)
        {
             JsonResponseModel<DeleteMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除微服务
        /// </summary>
        /// <param name="req"><see cref="DeleteMicroserviceRequest"/></param>
        /// <returns><see cref="DeleteMicroserviceResponse"/></returns>
        public DeleteMicroserviceResponse DeleteMicroserviceSync(DeleteMicroserviceRequest req)
        {
             JsonResponseModel<DeleteMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路径重写
        /// </summary>
        /// <param name="req"><see cref="DeletePathRewritesRequest"/></param>
        /// <returns><see cref="DeletePathRewritesResponse"/></returns>
        public async Task<DeletePathRewritesResponse> DeletePathRewrites(DeletePathRewritesRequest req)
        {
             JsonResponseModel<DeletePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路径重写
        /// </summary>
        /// <param name="req"><see cref="DeletePathRewritesRequest"/></param>
        /// <returns><see cref="DeletePathRewritesResponse"/></returns>
        public DeletePathRewritesResponse DeletePathRewritesSync(DeletePathRewritesRequest req)
        {
             JsonResponseModel<DeletePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req"><see cref="DeletePkgsRequest"/></param>
        /// <returns><see cref="DeletePkgsResponse"/></returns>
        public async Task<DeletePkgsResponse> DeletePkgs(DeletePkgsRequest req)
        {
             JsonResponseModel<DeletePkgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req"><see cref="DeletePkgsRequest"/></param>
        /// <returns><see cref="DeletePkgsResponse"/></returns>
        public DeletePkgsResponse DeletePkgsSync(DeletePkgsRequest req)
        {
             JsonResponseModel<DeletePkgsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除公共配置项
        /// </summary>
        /// <param name="req"><see cref="DeletePublicConfigRequest"/></param>
        /// <returns><see cref="DeletePublicConfigResponse"/></returns>
        public async Task<DeletePublicConfigResponse> DeletePublicConfig(DeletePublicConfigRequest req)
        {
             JsonResponseModel<DeletePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除公共配置项
        /// </summary>
        /// <param name="req"><see cref="DeletePublicConfigRequest"/></param>
        /// <returns><see cref="DeletePublicConfigResponse"/></returns>
        public DeletePublicConfigResponse DeletePublicConfigSync(DeletePublicConfigRequest req)
        {
             JsonResponseModel<DeletePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public async Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
             JsonResponseModel<DeleteRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessGroupRequest"/></param>
        /// <returns><see cref="DeleteServerlessGroupResponse"/></returns>
        public async Task<DeleteServerlessGroupResponse> DeleteServerlessGroup(DeleteServerlessGroupRequest req)
        {
             JsonResponseModel<DeleteServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessGroupRequest"/></param>
        /// <returns><see cref="DeleteServerlessGroupResponse"/></returns>
        public DeleteServerlessGroupResponse DeleteServerlessGroupSync(DeleteServerlessGroupRequest req)
        {
             JsonResponseModel<DeleteServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public async Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitNamespacesRequest"/></param>
        /// <returns><see cref="DeleteUnitNamespacesResponse"/></returns>
        public async Task<DeleteUnitNamespacesResponse> DeleteUnitNamespaces(DeleteUnitNamespacesRequest req)
        {
             JsonResponseModel<DeleteUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitNamespacesRequest"/></param>
        /// <returns><see cref="DeleteUnitNamespacesResponse"/></returns>
        public DeleteUnitNamespacesResponse DeleteUnitNamespacesSync(DeleteUnitNamespacesRequest req)
        {
             JsonResponseModel<DeleteUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单元化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitRuleRequest"/></param>
        /// <returns><see cref="DeleteUnitRuleResponse"/></returns>
        public async Task<DeleteUnitRuleResponse> DeleteUnitRule(DeleteUnitRuleRequest req)
        {
             JsonResponseModel<DeleteUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单元化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitRuleRequest"/></param>
        /// <returns><see cref="DeleteUnitRuleResponse"/></returns>
        public DeleteUnitRuleResponse DeleteUnitRuleSync(DeleteUnitRuleRequest req)
        {
             JsonResponseModel<DeleteUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署容器应用
        /// </summary>
        /// <param name="req"><see cref="DeployContainerGroupRequest"/></param>
        /// <returns><see cref="DeployContainerGroupResponse"/></returns>
        public async Task<DeployContainerGroupResponse> DeployContainerGroup(DeployContainerGroupRequest req)
        {
             JsonResponseModel<DeployContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署容器应用
        /// </summary>
        /// <param name="req"><see cref="DeployContainerGroupRequest"/></param>
        /// <returns><see cref="DeployContainerGroupResponse"/></returns>
        public DeployContainerGroupResponse DeployContainerGroupSync(DeployContainerGroupRequest req)
        {
             JsonResponseModel<DeployContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署虚拟机部署组应用
        /// </summary>
        /// <param name="req"><see cref="DeployGroupRequest"/></param>
        /// <returns><see cref="DeployGroupResponse"/></returns>
        public async Task<DeployGroupResponse> DeployGroup(DeployGroupRequest req)
        {
             JsonResponseModel<DeployGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署虚拟机部署组应用
        /// </summary>
        /// <param name="req"><see cref="DeployGroupRequest"/></param>
        /// <returns><see cref="DeployGroupResponse"/></returns>
        public DeployGroupResponse DeployGroupSync(DeployGroupRequest req)
        {
             JsonResponseModel<DeployGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署Serverless应用
        /// </summary>
        /// <param name="req"><see cref="DeployServerlessGroupRequest"/></param>
        /// <returns><see cref="DeployServerlessGroupResponse"/></returns>
        public async Task<DeployServerlessGroupResponse> DeployServerlessGroup(DeployServerlessGroupRequest req)
        {
             JsonResponseModel<DeployServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 部署Serverless应用
        /// </summary>
        /// <param name="req"><see cref="DeployServerlessGroupRequest"/></param>
        /// <returns><see cref="DeployServerlessGroupResponse"/></returns>
        public DeployServerlessGroupResponse DeployServerlessGroupSync(DeployServerlessGroupRequest req)
        {
             JsonResponseModel<DeployServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public async Task<DescribeApiDetailResponse> DescribeApiDetail(DescribeApiDetailRequest req)
        {
             JsonResponseModel<DescribeApiDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public DescribeApiDetailResponse DescribeApiDetailSync(DescribeApiDetailRequest req)
        {
             JsonResponseModel<DescribeApiDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupRequest"/></param>
        /// <returns><see cref="DescribeApiGroupResponse"/></returns>
        public async Task<DescribeApiGroupResponse> DescribeApiGroup(DescribeApiGroupRequest req)
        {
             JsonResponseModel<DescribeApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupRequest"/></param>
        /// <returns><see cref="DescribeApiGroupResponse"/></returns>
        public DescribeApiGroupResponse DescribeApiGroupSync(DescribeApiGroupRequest req)
        {
             JsonResponseModel<DescribeApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupsRequest"/></param>
        /// <returns><see cref="DescribeApiGroupsResponse"/></returns>
        public async Task<DescribeApiGroupsResponse> DescribeApiGroups(DescribeApiGroupsRequest req)
        {
             JsonResponseModel<DescribeApiGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupsRequest"/></param>
        /// <returns><see cref="DescribeApiGroupsResponse"/></returns>
        public DescribeApiGroupsResponse DescribeApiGroupsSync(DescribeApiGroupsRequest req)
        {
             JsonResponseModel<DescribeApiGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API限流规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="DescribeApiRateLimitRulesResponse"/></returns>
        public async Task<DescribeApiRateLimitRulesResponse> DescribeApiRateLimitRules(DescribeApiRateLimitRulesRequest req)
        {
             JsonResponseModel<DescribeApiRateLimitRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiRateLimitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiRateLimitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API限流规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="DescribeApiRateLimitRulesResponse"/></returns>
        public DescribeApiRateLimitRulesResponse DescribeApiRateLimitRulesSync(DescribeApiRateLimitRulesRequest req)
        {
             JsonResponseModel<DescribeApiRateLimitRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiRateLimitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiRateLimitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关API监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeApiUseDetailResponse"/></returns>
        public async Task<DescribeApiUseDetailResponse> DescribeApiUseDetail(DescribeApiUseDetailRequest req)
        {
             JsonResponseModel<DescribeApiUseDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关API监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeApiUseDetailResponse"/></returns>
        public DescribeApiUseDetailResponse DescribeApiUseDetailSync(DescribeApiUseDetailRequest req)
        {
             JsonResponseModel<DescribeApiUseDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API 版本
        /// </summary>
        /// <param name="req"><see cref="DescribeApiVersionsRequest"/></param>
        /// <returns><see cref="DescribeApiVersionsResponse"/></returns>
        public async Task<DescribeApiVersionsResponse> DescribeApiVersions(DescribeApiVersionsRequest req)
        {
             JsonResponseModel<DescribeApiVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询API 版本
        /// </summary>
        /// <param name="req"><see cref="DescribeApiVersionsRequest"/></param>
        /// <returns><see cref="DescribeApiVersionsResponse"/></returns>
        public DescribeApiVersionsResponse DescribeApiVersionsSync(DescribeApiVersionsRequest req)
        {
             JsonResponseModel<DescribeApiVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public async Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns><see cref="DescribeApplicationAttributeResponse"/></returns>
        public async Task<DescribeApplicationAttributeResponse> DescribeApplicationAttribute(DescribeApplicationAttributeRequest req)
        {
             JsonResponseModel<DescribeApplicationAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns><see cref="DescribeApplicationAttributeResponse"/></returns>
        public DescribeApplicationAttributeResponse DescribeApplicationAttributeSync(DescribeApplicationAttributeRequest req)
        {
             JsonResponseModel<DescribeApplicationAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public async Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF基本资源信息概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeBasicResourceUsageResponse"/></returns>
        public async Task<DescribeBasicResourceUsageResponse> DescribeBasicResourceUsage(DescribeBasicResourceUsageRequest req)
        {
             JsonResponseModel<DescribeBasicResourceUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicResourceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicResourceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF基本资源信息概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeBasicResourceUsageResponse"/></returns>
        public DescribeBasicResourceUsageResponse DescribeBasicResourceUsageSync(DescribeBasicResourceUsageRequest req)
        {
             JsonResponseModel<DescribeBasicResourceUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicResourceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicResourceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群实例
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
        /// 查询集群实例
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
        /// 查询配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribeConfigReleaseLogsResponse"/></returns>
        public async Task<DescribeConfigReleaseLogsResponse> DescribeConfigReleaseLogs(DescribeConfigReleaseLogsRequest req)
        {
             JsonResponseModel<DescribeConfigReleaseLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigReleaseLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigReleaseLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribeConfigReleaseLogsResponse"/></returns>
        public DescribeConfigReleaseLogsResponse DescribeConfigReleaseLogsSync(DescribeConfigReleaseLogsRequest req)
        {
             JsonResponseModel<DescribeConfigReleaseLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigReleaseLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigReleaseLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigReleasesResponse"/></returns>
        public async Task<DescribeConfigReleasesResponse> DescribeConfigReleases(DescribeConfigReleasesRequest req)
        {
             JsonResponseModel<DescribeConfigReleasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigReleasesResponse"/></returns>
        public DescribeConfigReleasesResponse DescribeConfigReleasesSync(DescribeConfigReleasesRequest req)
        {
             JsonResponseModel<DescribeConfigReleasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribeConfigSummaryResponse"/></returns>
        public async Task<DescribeConfigSummaryResponse> DescribeConfigSummary(DescribeConfigSummaryRequest req)
        {
             JsonResponseModel<DescribeConfigSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribeConfigSummaryResponse"/></returns>
        public DescribeConfigSummaryResponse DescribeConfigSummarySync(DescribeConfigSummaryRequest req)
        {
             JsonResponseModel<DescribeConfigSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public async Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取容器事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerEventsResponse"/></returns>
        public async Task<DescribeContainerEventsResponse> DescribeContainerEvents(DescribeContainerEventsRequest req)
        {
             JsonResponseModel<DescribeContainerEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取容器事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerEventsResponse"/></returns>
        public DescribeContainerEventsResponse DescribeContainerEventsSync(DescribeContainerEventsRequest req)
        {
             JsonResponseModel<DescribeContainerEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  容器部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDetailResponse"/></returns>
        public async Task<DescribeContainerGroupDetailResponse> DescribeContainerGroupDetail(DescribeContainerGroupDetailRequest req)
        {
             JsonResponseModel<DescribeContainerGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  容器部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDetailResponse"/></returns>
        public DescribeContainerGroupDetailResponse DescribeContainerGroupDetailSync(DescribeContainerGroupDetailRequest req)
        {
             JsonResponseModel<DescribeContainerGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupsResponse"/></returns>
        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroups(DescribeContainerGroupsRequest req)
        {
             JsonResponseModel<DescribeContainerGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupsResponse"/></returns>
        public DescribeContainerGroupsResponse DescribeContainerGroupsSync(DescribeContainerGroupsRequest req)
        {
             JsonResponseModel<DescribeContainerGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一键导入API分组任务的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateGatewayApiStatusRequest"/></param>
        /// <returns><see cref="DescribeCreateGatewayApiStatusResponse"/></returns>
        public async Task<DescribeCreateGatewayApiStatusResponse> DescribeCreateGatewayApiStatus(DescribeCreateGatewayApiStatusRequest req)
        {
             JsonResponseModel<DescribeCreateGatewayApiStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCreateGatewayApiStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCreateGatewayApiStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一键导入API分组任务的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateGatewayApiStatusRequest"/></param>
        /// <returns><see cref="DescribeCreateGatewayApiStatusResponse"/></returns>
        public DescribeCreateGatewayApiStatusResponse DescribeCreateGatewayApiStatusSync(DescribeCreateGatewayApiStatusRequest req)
        {
             JsonResponseModel<DescribeCreateGatewayApiStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCreateGatewayApiStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCreateGatewayApiStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfoResponse"/></returns>
        public async Task<DescribeDownloadInfoResponse> DescribeDownloadInfo(DescribeDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfoResponse"/></returns>
        public DescribeDownloadInfoResponse DescribeDownloadInfoSync(DescribeDownloadInfoRequest req)
        {
             JsonResponseModel<DescribeDownloadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDownloadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询生效的单元化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnabledUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeEnabledUnitRuleResponse"/></returns>
        public async Task<DescribeEnabledUnitRuleResponse> DescribeEnabledUnitRule(DescribeEnabledUnitRuleRequest req)
        {
             JsonResponseModel<DescribeEnabledUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnabledUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnabledUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询生效的单元化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnabledUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeEnabledUnitRuleResponse"/></returns>
        public DescribeEnabledUnitRuleResponse DescribeEnabledUnitRuleSync(DescribeEnabledUnitRuleRequest req)
        {
             JsonResponseModel<DescribeEnabledUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnabledUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnabledUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigsRequest"/></param>
        /// <returns><see cref="DescribeFileConfigsResponse"/></returns>
        public async Task<DescribeFileConfigsResponse> DescribeFileConfigs(DescribeFileConfigsRequest req)
        {
             JsonResponseModel<DescribeFileConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigsRequest"/></param>
        /// <returns><see cref="DescribeFileConfigsResponse"/></returns>
        public DescribeFileConfigsResponse DescribeFileConfigsSync(DescribeFileConfigsRequest req)
        {
             JsonResponseModel<DescribeFileConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询工作流最新一个批次的状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLastBatchStateRequest"/></param>
        /// <returns><see cref="DescribeFlowLastBatchStateResponse"/></returns>
        public async Task<DescribeFlowLastBatchStateResponse> DescribeFlowLastBatchState(DescribeFlowLastBatchStateRequest req)
        {
             JsonResponseModel<DescribeFlowLastBatchStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLastBatchState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLastBatchStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询工作流最新一个批次的状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLastBatchStateRequest"/></param>
        /// <returns><see cref="DescribeFlowLastBatchStateResponse"/></returns>
        public DescribeFlowLastBatchStateResponse DescribeFlowLastBatchStateSync(DescribeFlowLastBatchStateRequest req)
        {
             JsonResponseModel<DescribeFlowLastBatchStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowLastBatchState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLastBatchStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关所有分组下Api列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAllGroupApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayAllGroupApisResponse"/></returns>
        public async Task<DescribeGatewayAllGroupApisResponse> DescribeGatewayAllGroupApis(DescribeGatewayAllGroupApisRequest req)
        {
             JsonResponseModel<DescribeGatewayAllGroupApisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayAllGroupApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayAllGroupApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关所有分组下Api列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAllGroupApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayAllGroupApisResponse"/></returns>
        public DescribeGatewayAllGroupApisResponse DescribeGatewayAllGroupApisSync(DescribeGatewayAllGroupApisRequest req)
        {
             JsonResponseModel<DescribeGatewayAllGroupApisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayAllGroupApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayAllGroupApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关监控概览
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorOverviewRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorOverviewResponse"/></returns>
        public async Task<DescribeGatewayMonitorOverviewResponse> DescribeGatewayMonitorOverview(DescribeGatewayMonitorOverviewRequest req)
        {
             JsonResponseModel<DescribeGatewayMonitorOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayMonitorOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayMonitorOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关监控概览
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorOverviewRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorOverviewResponse"/></returns>
        public DescribeGatewayMonitorOverviewResponse DescribeGatewayMonitorOverviewSync(DescribeGatewayMonitorOverviewRequest req)
        {
             JsonResponseModel<DescribeGatewayMonitorOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayMonitorOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayMonitorOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public async Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个API分组已绑定的网关部署组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBindedGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupBindedGatewaysResponse"/></returns>
        public async Task<DescribeGroupBindedGatewaysResponse> DescribeGroupBindedGateways(DescribeGroupBindedGatewaysRequest req)
        {
             JsonResponseModel<DescribeGroupBindedGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupBindedGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupBindedGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个API分组已绑定的网关部署组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBindedGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupBindedGatewaysResponse"/></returns>
        public DescribeGroupBindedGatewaysResponse DescribeGroupBindedGatewaysSync(DescribeGroupBindedGatewaysRequest req)
        {
             JsonResponseModel<DescribeGroupBindedGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupBindedGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupBindedGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个网关绑定的API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupGatewaysResponse"/></returns>
        public async Task<DescribeGroupGatewaysResponse> DescribeGroupGateways(DescribeGroupGatewaysRequest req)
        {
             JsonResponseModel<DescribeGroupGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个网关绑定的API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupGatewaysResponse"/></returns>
        public DescribeGroupGatewaysResponse DescribeGroupGatewaysSync(DescribeGroupGatewaysRequest req)
        {
             JsonResponseModel<DescribeGroupGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeGroupInstancesResponse"/></returns>
        public async Task<DescribeGroupInstancesResponse> DescribeGroupInstances(DescribeGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeGroupInstancesResponse"/></returns>
        public DescribeGroupInstancesResponse DescribeGroupInstancesSync(DescribeGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询部署组相关的发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupReleaseRequest"/></param>
        /// <returns><see cref="DescribeGroupReleaseResponse"/></returns>
        public async Task<DescribeGroupReleaseResponse> DescribeGroupRelease(DescribeGroupReleaseRequest req)
        {
             JsonResponseModel<DescribeGroupReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询部署组相关的发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupReleaseRequest"/></param>
        /// <returns><see cref="DescribeGroupReleaseResponse"/></returns>
        public DescribeGroupReleaseResponse DescribeGroupReleaseSync(DescribeGroupReleaseRequest req)
        {
             JsonResponseModel<DescribeGroupReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关分组监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupUseDetailRequest"/></param>
        /// <returns><see cref="DescribeGroupUseDetailResponse"/></returns>
        public async Task<DescribeGroupUseDetailResponse> DescribeGroupUseDetail(DescribeGroupUseDetailRequest req)
        {
             JsonResponseModel<DescribeGroupUseDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关分组监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupUseDetailRequest"/></param>
        /// <returns><see cref="DescribeGroupUseDetailResponse"/></returns>
        public DescribeGroupUseDetailResponse DescribeGroupUseDetailSync(DescribeGroupUseDetailRequest req)
        {
             JsonResponseModel<DescribeGroupUseDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取虚拟机部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public async Task<DescribeGroupsResponse> DescribeGroups(DescribeGroupsRequest req)
        {
             JsonResponseModel<DescribeGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取虚拟机部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public DescribeGroupsResponse DescribeGroupsSync(DescribeGroupsRequest req)
        {
             JsonResponseModel<DescribeGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个插件下绑定或未绑定的API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsWithPluginRequest"/></param>
        /// <returns><see cref="DescribeGroupsWithPluginResponse"/></returns>
        public async Task<DescribeGroupsWithPluginResponse> DescribeGroupsWithPlugin(DescribeGroupsWithPluginRequest req)
        {
             JsonResponseModel<DescribeGroupsWithPluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupsWithPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsWithPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个插件下绑定或未绑定的API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsWithPluginRequest"/></param>
        /// <returns><see cref="DescribeGroupsWithPluginResponse"/></returns>
        public DescribeGroupsWithPluginResponse DescribeGroupsWithPluginSync(DescribeGroupsWithPluginRequest req)
        {
             JsonResponseModel<DescribeGroupsWithPluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupsWithPlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsWithPluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRepositoryRequest"/></param>
        /// <returns><see cref="DescribeImageRepositoryResponse"/></returns>
        public async Task<DescribeImageRepositoryResponse> DescribeImageRepository(DescribeImageRepositoryRequest req)
        {
             JsonResponseModel<DescribeImageRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRepositoryRequest"/></param>
        /// <returns><see cref="DescribeImageRepositoryResponse"/></returns>
        public DescribeImageRepositoryResponse DescribeImageRepositorySync(DescribeImageRepositoryRequest req)
        {
             JsonResponseModel<DescribeImageRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTagsRequest"/></param>
        /// <returns><see cref="DescribeImageTagsResponse"/></returns>
        public async Task<DescribeImageTagsResponse> DescribeImageTags(DescribeImageTagsRequest req)
        {
             JsonResponseModel<DescribeImageTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTagsRequest"/></param>
        /// <returns><see cref="DescribeImageTagsResponse"/></returns>
        public DescribeImageTagsResponse DescribeImageTagsSync(DescribeImageTagsRequest req)
        {
             JsonResponseModel<DescribeImageTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询泳道规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLaneRulesRequest"/></param>
        /// <returns><see cref="DescribeLaneRulesResponse"/></returns>
        public async Task<DescribeLaneRulesResponse> DescribeLaneRules(DescribeLaneRulesRequest req)
        {
             JsonResponseModel<DescribeLaneRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLaneRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLaneRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询泳道规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLaneRulesRequest"/></param>
        /// <returns><see cref="DescribeLaneRulesResponse"/></returns>
        public DescribeLaneRulesResponse DescribeLaneRulesSync(DescribeLaneRulesRequest req)
        {
             JsonResponseModel<DescribeLaneRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLaneRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLaneRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询泳道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLanesRequest"/></param>
        /// <returns><see cref="DescribeLanesResponse"/></returns>
        public async Task<DescribeLanesResponse> DescribeLanes(DescribeLanesRequest req)
        {
             JsonResponseModel<DescribeLanesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLanes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLanesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询泳道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLanesRequest"/></param>
        /// <returns><see cref="DescribeLanesResponse"/></returns>
        public DescribeLanesResponse DescribeLanesSync(DescribeLanesRequest req)
        {
             JsonResponseModel<DescribeLanesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLanes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLanesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroserviceRequest"/></param>
        /// <returns><see cref="DescribeMicroserviceResponse"/></returns>
        public async Task<DescribeMicroserviceResponse> DescribeMicroservice(DescribeMicroserviceRequest req)
        {
             JsonResponseModel<DescribeMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroserviceRequest"/></param>
        /// <returns><see cref="DescribeMicroserviceResponse"/></returns>
        public DescribeMicroserviceResponse DescribeMicroserviceSync(DescribeMicroserviceRequest req)
        {
             JsonResponseModel<DescribeMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroservicesRequest"/></param>
        /// <returns><see cref="DescribeMicroservicesResponse"/></returns>
        public async Task<DescribeMicroservicesResponse> DescribeMicroservices(DescribeMicroservicesRequest req)
        {
             JsonResponseModel<DescribeMicroservicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMicroservices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroservicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroservicesRequest"/></param>
        /// <returns><see cref="DescribeMicroservicesResponse"/></returns>
        public DescribeMicroservicesResponse DescribeMicroservicesSync(DescribeMicroservicesRequest req)
        {
             JsonResponseModel<DescribeMicroservicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMicroservices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMicroservicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMsApiListRequest"/></param>
        /// <returns><see cref="DescribeMsApiListResponse"/></returns>
        public async Task<DescribeMsApiListResponse> DescribeMsApiList(DescribeMsApiListRequest req)
        {
             JsonResponseModel<DescribeMsApiListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMsApiList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMsApiListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMsApiListRequest"/></param>
        /// <returns><see cref="DescribeMsApiListResponse"/></returns>
        public DescribeMsApiListResponse DescribeMsApiListSync(DescribeMsApiListRequest req)
        {
             JsonResponseModel<DescribeMsApiListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMsApiList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMsApiListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路径重写
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewriteRequest"/></param>
        /// <returns><see cref="DescribePathRewriteResponse"/></returns>
        public async Task<DescribePathRewriteResponse> DescribePathRewrite(DescribePathRewriteRequest req)
        {
             JsonResponseModel<DescribePathRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePathRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePathRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路径重写
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewriteRequest"/></param>
        /// <returns><see cref="DescribePathRewriteResponse"/></returns>
        public DescribePathRewriteResponse DescribePathRewriteSync(DescribePathRewriteRequest req)
        {
             JsonResponseModel<DescribePathRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePathRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePathRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路径重写列表
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewritesRequest"/></param>
        /// <returns><see cref="DescribePathRewritesResponse"/></returns>
        public async Task<DescribePathRewritesResponse> DescribePathRewrites(DescribePathRewritesRequest req)
        {
             JsonResponseModel<DescribePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路径重写列表
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewritesRequest"/></param>
        /// <returns><see cref="DescribePathRewritesResponse"/></returns>
        public DescribePathRewritesResponse DescribePathRewritesSync(DescribePathRewritesRequest req)
        {
             JsonResponseModel<DescribePathRewritesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePathRewrites");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePathRewritesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribePkgsRequest"/></param>
        /// <returns><see cref="DescribePkgsResponse"/></returns>
        public async Task<DescribePkgsResponse> DescribePkgs(DescribePkgsRequest req)
        {
             JsonResponseModel<DescribePkgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribePkgsRequest"/></param>
        /// <returns><see cref="DescribePkgsResponse"/></returns>
        public DescribePkgsResponse DescribePkgsSync(DescribePkgsRequest req)
        {
             JsonResponseModel<DescribePkgsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePkgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePkgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询网关分组/API绑定（或未绑定）的插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginInstancesRequest"/></param>
        /// <returns><see cref="DescribePluginInstancesResponse"/></returns>
        public async Task<DescribePluginInstancesResponse> DescribePluginInstances(DescribePluginInstancesRequest req)
        {
             JsonResponseModel<DescribePluginInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePluginInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询网关分组/API绑定（或未绑定）的插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginInstancesRequest"/></param>
        /// <returns><see cref="DescribePluginInstancesResponse"/></returns>
        public DescribePluginInstancesResponse DescribePluginInstancesSync(DescribePluginInstancesRequest req)
        {
             JsonResponseModel<DescribePluginInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePluginInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePluginInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取部署组实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodInstancesRequest"/></param>
        /// <returns><see cref="DescribePodInstancesResponse"/></returns>
        public async Task<DescribePodInstancesResponse> DescribePodInstances(DescribePodInstancesRequest req)
        {
             JsonResponseModel<DescribePodInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePodInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePodInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取部署组实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodInstancesRequest"/></param>
        /// <returns><see cref="DescribePodInstancesResponse"/></returns>
        public DescribePodInstancesResponse DescribePodInstancesSync(DescribePodInstancesRequest req)
        {
             JsonResponseModel<DescribePodInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePodInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePodInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置（单条）
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigRequest"/></param>
        /// <returns><see cref="DescribePublicConfigResponse"/></returns>
        public async Task<DescribePublicConfigResponse> DescribePublicConfig(DescribePublicConfigRequest req)
        {
             JsonResponseModel<DescribePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置（单条）
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigRequest"/></param>
        /// <returns><see cref="DescribePublicConfigResponse"/></returns>
        public DescribePublicConfigResponse DescribePublicConfigSync(DescribePublicConfigRequest req)
        {
             JsonResponseModel<DescribePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleaseLogsResponse"/></returns>
        public async Task<DescribePublicConfigReleaseLogsResponse> DescribePublicConfigReleaseLogs(DescribePublicConfigReleaseLogsRequest req)
        {
             JsonResponseModel<DescribePublicConfigReleaseLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicConfigReleaseLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigReleaseLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleaseLogsResponse"/></returns>
        public DescribePublicConfigReleaseLogsResponse DescribePublicConfigReleaseLogsSync(DescribePublicConfigReleaseLogsRequest req)
        {
             JsonResponseModel<DescribePublicConfigReleaseLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicConfigReleaseLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigReleaseLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleasesResponse"/></returns>
        public async Task<DescribePublicConfigReleasesResponse> DescribePublicConfigReleases(DescribePublicConfigReleasesRequest req)
        {
             JsonResponseModel<DescribePublicConfigReleasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicConfigReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleasesResponse"/></returns>
        public DescribePublicConfigReleasesResponse DescribePublicConfigReleasesSync(DescribePublicConfigReleasesRequest req)
        {
             JsonResponseModel<DescribePublicConfigReleasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicConfigReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribePublicConfigSummaryResponse"/></returns>
        public async Task<DescribePublicConfigSummaryResponse> DescribePublicConfigSummary(DescribePublicConfigSummaryRequest req)
        {
             JsonResponseModel<DescribePublicConfigSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicConfigSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribePublicConfigSummaryResponse"/></returns>
        public DescribePublicConfigSummaryResponse DescribePublicConfigSummarySync(DescribePublicConfigSummaryRequest req)
        {
             JsonResponseModel<DescribePublicConfigSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicConfigSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigsResponse"/></returns>
        public async Task<DescribePublicConfigsResponse> DescribePublicConfigs(DescribePublicConfigsRequest req)
        {
             JsonResponseModel<DescribePublicConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询公共配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigsResponse"/></returns>
        public DescribePublicConfigsResponse DescribePublicConfigsSync(DescribePublicConfigsRequest req)
        {
             JsonResponseModel<DescribePublicConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询group发布的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReleasedConfigRequest"/></param>
        /// <returns><see cref="DescribeReleasedConfigResponse"/></returns>
        public async Task<DescribeReleasedConfigResponse> DescribeReleasedConfig(DescribeReleasedConfigRequest req)
        {
             JsonResponseModel<DescribeReleasedConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReleasedConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleasedConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询group发布的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReleasedConfigRequest"/></param>
        /// <returns><see cref="DescribeReleasedConfigResponse"/></returns>
        public DescribeReleasedConfigResponse DescribeReleasedConfigSync(DescribeReleasedConfigRequest req)
        {
             JsonResponseModel<DescribeReleasedConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReleasedConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleasedConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public async Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
             JsonResponseModel<DescribeRepositoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepositories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeRepositoryResponse"/></returns>
        public async Task<DescribeRepositoryResponse> DescribeRepository(DescribeRepositoryRequest req)
        {
             JsonResponseModel<DescribeRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeRepositoryResponse"/></returns>
        public DescribeRepositoryResponse DescribeRepositorySync(DescribeRepositoryRequest req)
        {
             JsonResponseModel<DescribeRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Serverless部署组明细
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessGroupRequest"/></param>
        /// <returns><see cref="DescribeServerlessGroupResponse"/></returns>
        public async Task<DescribeServerlessGroupResponse> DescribeServerlessGroup(DescribeServerlessGroupRequest req)
        {
             JsonResponseModel<DescribeServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Serverless部署组明细
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessGroupRequest"/></param>
        /// <returns><see cref="DescribeServerlessGroupResponse"/></returns>
        public DescribeServerlessGroupResponse DescribeServerlessGroupSync(DescribeServerlessGroupRequest req)
        {
             JsonResponseModel<DescribeServerlessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerlessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Serverless部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessGroupsRequest"/></param>
        /// <returns><see cref="DescribeServerlessGroupsResponse"/></returns>
        public async Task<DescribeServerlessGroupsResponse> DescribeServerlessGroups(DescribeServerlessGroupsRequest req)
        {
             JsonResponseModel<DescribeServerlessGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerlessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Serverless部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessGroupsRequest"/></param>
        /// <returns><see cref="DescribeServerlessGroupsResponse"/></returns>
        public DescribeServerlessGroupsResponse DescribeServerlessGroupsSync(DescribeServerlessGroupsRequest req)
        {
             JsonResponseModel<DescribeServerlessGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerlessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationsResponse"/></returns>
        public async Task<DescribeSimpleApplicationsResponse> DescribeSimpleApplications(DescribeSimpleApplicationsRequest req)
        {
             JsonResponseModel<DescribeSimpleApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationsResponse"/></returns>
        public DescribeSimpleApplicationsResponse DescribeSimpleApplicationsSync(DescribeSimpleApplicationsRequest req)
        {
             JsonResponseModel<DescribeSimpleApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSimpleApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns><see cref="DescribeSimpleClustersResponse"/></returns>
        public async Task<DescribeSimpleClustersResponse> DescribeSimpleClusters(DescribeSimpleClustersRequest req)
        {
             JsonResponseModel<DescribeSimpleClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns><see cref="DescribeSimpleClustersResponse"/></returns>
        public DescribeSimpleClustersResponse DescribeSimpleClustersSync(DescribeSimpleClustersRequest req)
        {
             JsonResponseModel<DescribeSimpleClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSimpleClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns><see cref="DescribeSimpleGroupsResponse"/></returns>
        public async Task<DescribeSimpleGroupsResponse> DescribeSimpleGroups(DescribeSimpleGroupsRequest req)
        {
             JsonResponseModel<DescribeSimpleGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns><see cref="DescribeSimpleGroupsResponse"/></returns>
        public DescribeSimpleGroupsResponse DescribeSimpleGroupsSync(DescribeSimpleGroupsRequest req)
        {
             JsonResponseModel<DescribeSimpleGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSimpleGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单命名空间列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns><see cref="DescribeSimpleNamespacesResponse"/></returns>
        public async Task<DescribeSimpleNamespacesResponse> DescribeSimpleNamespaces(DescribeSimpleNamespacesRequest req)
        {
             JsonResponseModel<DescribeSimpleNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询简单命名空间列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns><see cref="DescribeSimpleNamespacesResponse"/></returns>
        public DescribeSimpleNamespacesResponse DescribeSimpleNamespacesSync(DescribeSimpleNamespacesRequest req)
        {
             JsonResponseModel<DescribeSimpleNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSimpleNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务最近一次执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLastStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLastStatusResponse"/></returns>
        public async Task<DescribeTaskLastStatusResponse> DescribeTaskLastStatus(DescribeTaskLastStatusRequest req)
        {
             JsonResponseModel<DescribeTaskLastStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskLastStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLastStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务最近一次执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLastStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLastStatusResponse"/></returns>
        public DescribeTaskLastStatusResponse DescribeTaskLastStatusSync(DescribeTaskLastStatusRequest req)
        {
             JsonResponseModel<DescribeTaskLastStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskLastStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLastStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 翻页查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRecordsRequest"/></param>
        /// <returns><see cref="DescribeTaskRecordsResponse"/></returns>
        public async Task<DescribeTaskRecordsResponse> DescribeTaskRecords(DescribeTaskRecordsRequest req)
        {
             JsonResponseModel<DescribeTaskRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 翻页查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRecordsRequest"/></param>
        /// <returns><see cref="DescribeTaskRecordsResponse"/></returns>
        public DescribeTaskRecordsResponse DescribeTaskRecordsSync(DescribeTaskRecordsRequest req)
        {
             JsonResponseModel<DescribeTaskRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关API监控明细数据（仅单元化网关），非单元化网关使用DescribeApiUseDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeUnitApiUseDetailResponse"/></returns>
        public async Task<DescribeUnitApiUseDetailResponse> DescribeUnitApiUseDetail(DescribeUnitApiUseDetailRequest req)
        {
             JsonResponseModel<DescribeUnitApiUseDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnitApiUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitApiUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关API监控明细数据（仅单元化网关），非单元化网关使用DescribeApiUseDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeUnitApiUseDetailResponse"/></returns>
        public DescribeUnitApiUseDetailResponse DescribeUnitApiUseDetailSync(DescribeUnitApiUseDetailRequest req)
        {
             JsonResponseModel<DescribeUnitApiUseDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnitApiUseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitApiUseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUnitNamespacesResponse"/></returns>
        public async Task<DescribeUnitNamespacesResponse> DescribeUnitNamespaces(DescribeUnitNamespacesRequest req)
        {
             JsonResponseModel<DescribeUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUnitNamespacesResponse"/></returns>
        public DescribeUnitNamespacesResponse DescribeUnitNamespacesSync(DescribeUnitNamespacesRequest req)
        {
             JsonResponseModel<DescribeUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeUnitRuleResponse"/></returns>
        public async Task<DescribeUnitRuleResponse> DescribeUnitRule(DescribeUnitRuleRequest req)
        {
             JsonResponseModel<DescribeUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeUnitRuleResponse"/></returns>
        public DescribeUnitRuleResponse DescribeUnitRuleSync(DescribeUnitRuleRequest req)
        {
             JsonResponseModel<DescribeUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesRequest"/></param>
        /// <returns><see cref="DescribeUnitRulesResponse"/></returns>
        public async Task<DescribeUnitRulesResponse> DescribeUnitRules(DescribeUnitRulesRequest req)
        {
             JsonResponseModel<DescribeUnitRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单元化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesRequest"/></param>
        /// <returns><see cref="DescribeUnitRulesResponse"/></returns>
        public DescribeUnitRulesResponse DescribeUnitRulesSync(DescribeUnitRulesRequest req)
        {
             JsonResponseModel<DescribeUnitRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadInfoResponse"/></returns>
        public async Task<DescribeUploadInfoResponse> DescribeUploadInfo(DescribeUploadInfoRequest req)
        {
             JsonResponseModel<DescribeUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadInfoResponse"/></returns>
        public DescribeUploadInfoResponse DescribeUploadInfoSync(DescribeUploadInfoRequest req)
        {
             JsonResponseModel<DescribeUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用于被导入的命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsableUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUsableUnitNamespacesResponse"/></returns>
        public async Task<DescribeUsableUnitNamespacesResponse> DescribeUsableUnitNamespaces(DescribeUsableUnitNamespacesRequest req)
        {
             JsonResponseModel<DescribeUsableUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsableUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsableUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用于被导入的命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsableUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUsableUnitNamespacesResponse"/></returns>
        public DescribeUsableUnitNamespacesResponse DescribeUsableUnitNamespacesSync(DescribeUsableUnitNamespacesRequest req)
        {
             JsonResponseModel<DescribeUsableUnitNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsableUnitNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsableUnitNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用任务
        /// </summary>
        /// <param name="req"><see cref="DisableTaskRequest"/></param>
        /// <returns><see cref="DisableTaskResponse"/></returns>
        public async Task<DisableTaskResponse> DisableTask(DisableTaskRequest req)
        {
             JsonResponseModel<DisableTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用任务
        /// </summary>
        /// <param name="req"><see cref="DisableTaskRequest"/></param>
        /// <returns><see cref="DisableTaskResponse"/></returns>
        public DisableTaskResponse DisableTaskSync(DisableTaskRequest req)
        {
             JsonResponseModel<DisableTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用工作流
        /// </summary>
        /// <param name="req"><see cref="DisableTaskFlowRequest"/></param>
        /// <returns><see cref="DisableTaskFlowResponse"/></returns>
        public async Task<DisableTaskFlowResponse> DisableTaskFlow(DisableTaskFlowRequest req)
        {
             JsonResponseModel<DisableTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用工作流
        /// </summary>
        /// <param name="req"><see cref="DisableTaskFlowRequest"/></param>
        /// <returns><see cref="DisableTaskFlowResponse"/></returns>
        public DisableTaskFlowResponse DisableTaskFlowSync(DisableTaskFlowRequest req)
        {
             JsonResponseModel<DisableTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用单元化路由
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRouteRequest"/></param>
        /// <returns><see cref="DisableUnitRouteResponse"/></returns>
        public async Task<DisableUnitRouteResponse> DisableUnitRoute(DisableUnitRouteRequest req)
        {
             JsonResponseModel<DisableUnitRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableUnitRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUnitRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用单元化路由
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRouteRequest"/></param>
        /// <returns><see cref="DisableUnitRouteResponse"/></returns>
        public DisableUnitRouteResponse DisableUnitRouteSync(DisableUnitRouteRequest req)
        {
             JsonResponseModel<DisableUnitRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableUnitRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUnitRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用单元化规则
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRuleRequest"/></param>
        /// <returns><see cref="DisableUnitRuleResponse"/></returns>
        public async Task<DisableUnitRuleResponse> DisableUnitRule(DisableUnitRuleRequest req)
        {
             JsonResponseModel<DisableUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用单元化规则
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRuleRequest"/></param>
        /// <returns><see cref="DisableUnitRuleResponse"/></returns>
        public DisableUnitRuleResponse DisableUnitRuleSync(DisableUnitRuleRequest req)
        {
             JsonResponseModel<DisableUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线Api分组
        /// </summary>
        /// <param name="req"><see cref="DraftApiGroupRequest"/></param>
        /// <returns><see cref="DraftApiGroupResponse"/></returns>
        public async Task<DraftApiGroupResponse> DraftApiGroup(DraftApiGroupRequest req)
        {
             JsonResponseModel<DraftApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DraftApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DraftApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线Api分组
        /// </summary>
        /// <param name="req"><see cref="DraftApiGroupRequest"/></param>
        /// <returns><see cref="DraftApiGroupResponse"/></returns>
        public DraftApiGroupResponse DraftApiGroupSync(DraftApiGroupRequest req)
        {
             JsonResponseModel<DraftApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DraftApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DraftApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用任务
        /// </summary>
        /// <param name="req"><see cref="EnableTaskRequest"/></param>
        /// <returns><see cref="EnableTaskResponse"/></returns>
        public async Task<EnableTaskResponse> EnableTask(EnableTaskRequest req)
        {
             JsonResponseModel<EnableTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用任务
        /// </summary>
        /// <param name="req"><see cref="EnableTaskRequest"/></param>
        /// <returns><see cref="EnableTaskResponse"/></returns>
        public EnableTaskResponse EnableTaskSync(EnableTaskRequest req)
        {
             JsonResponseModel<EnableTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用工作流
        /// </summary>
        /// <param name="req"><see cref="EnableTaskFlowRequest"/></param>
        /// <returns><see cref="EnableTaskFlowResponse"/></returns>
        public async Task<EnableTaskFlowResponse> EnableTaskFlow(EnableTaskFlowRequest req)
        {
             JsonResponseModel<EnableTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用工作流
        /// </summary>
        /// <param name="req"><see cref="EnableTaskFlowRequest"/></param>
        /// <returns><see cref="EnableTaskFlowResponse"/></returns>
        public EnableTaskFlowResponse EnableTaskFlowSync(EnableTaskFlowRequest req)
        {
             JsonResponseModel<EnableTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用单元化路由
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRouteRequest"/></param>
        /// <returns><see cref="EnableUnitRouteResponse"/></returns>
        public async Task<EnableUnitRouteResponse> EnableUnitRoute(EnableUnitRouteRequest req)
        {
             JsonResponseModel<EnableUnitRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableUnitRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableUnitRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用单元化路由
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRouteRequest"/></param>
        /// <returns><see cref="EnableUnitRouteResponse"/></returns>
        public EnableUnitRouteResponse EnableUnitRouteSync(EnableUnitRouteRequest req)
        {
             JsonResponseModel<EnableUnitRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableUnitRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableUnitRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用单元化规则
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRuleRequest"/></param>
        /// <returns><see cref="EnableUnitRuleResponse"/></returns>
        public async Task<EnableUnitRuleResponse> EnableUnitRule(EnableUnitRuleRequest req)
        {
             JsonResponseModel<EnableUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用单元化规则
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRuleRequest"/></param>
        /// <returns><see cref="EnableUnitRuleResponse"/></returns>
        public EnableUnitRuleResponse EnableUnitRuleSync(EnableUnitRuleRequest req)
        {
             JsonResponseModel<EnableUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动执行一次任务。
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public async Task<ExecuteTaskResponse> ExecuteTask(ExecuteTaskRequest req)
        {
             JsonResponseModel<ExecuteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动执行一次任务。
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public ExecuteTaskResponse ExecuteTaskSync(ExecuteTaskRequest req)
        {
             JsonResponseModel<ExecuteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行一次工作流
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskFlowRequest"/></param>
        /// <returns><see cref="ExecuteTaskFlowResponse"/></returns>
        public async Task<ExecuteTaskFlowResponse> ExecuteTaskFlow(ExecuteTaskFlowRequest req)
        {
             JsonResponseModel<ExecuteTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行一次工作流
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskFlowRequest"/></param>
        /// <returns><see cref="ExecuteTaskFlowResponse"/></returns>
        public ExecuteTaskFlowResponse ExecuteTaskFlowSync(ExecuteTaskFlowRequest req)
        {
             JsonResponseModel<ExecuteTaskFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteTaskFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组添加实例
        /// </summary>
        /// <param name="req"><see cref="ExpandGroupRequest"/></param>
        /// <returns><see cref="ExpandGroupResponse"/></returns>
        public async Task<ExpandGroupResponse> ExpandGroup(ExpandGroupRequest req)
        {
             JsonResponseModel<ExpandGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组添加实例
        /// </summary>
        /// <param name="req"><see cref="ExpandGroupRequest"/></param>
        /// <returns><see cref="ExpandGroupResponse"/></returns>
        public ExpandGroupResponse ExpandGroupSync(ExpandGroupRequest req)
        {
             JsonResponseModel<ExpandGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpandGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerGroupRequest"/></param>
        /// <returns><see cref="ModifyContainerGroupResponse"/></returns>
        public async Task<ModifyContainerGroupResponse> ModifyContainerGroup(ModifyContainerGroupRequest req)
        {
             JsonResponseModel<ModifyContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerGroupRequest"/></param>
        /// <returns><see cref="ModifyContainerGroupResponse"/></returns>
        public ModifyContainerGroupResponse ModifyContainerGroupSync(ModifyContainerGroupRequest req)
        {
             JsonResponseModel<ModifyContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns><see cref="ModifyContainerReplicasResponse"/></returns>
        public async Task<ModifyContainerReplicasResponse> ModifyContainerReplicas(ModifyContainerReplicasRequest req)
        {
             JsonResponseModel<ModifyContainerReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContainerReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改容器部署组实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns><see cref="ModifyContainerReplicasResponse"/></returns>
        public ModifyContainerReplicasResponse ModifyContainerReplicasSync(ModifyContainerReplicasRequest req)
        {
             JsonResponseModel<ModifyContainerReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContainerReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新泳道信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRequest"/></param>
        /// <returns><see cref="ModifyLaneResponse"/></returns>
        public async Task<ModifyLaneResponse> ModifyLane(ModifyLaneRequest req)
        {
             JsonResponseModel<ModifyLaneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新泳道信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRequest"/></param>
        /// <returns><see cref="ModifyLaneResponse"/></returns>
        public ModifyLaneResponse ModifyLaneSync(ModifyLaneRequest req)
        {
             JsonResponseModel<ModifyLaneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLane");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新泳道规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRuleRequest"/></param>
        /// <returns><see cref="ModifyLaneRuleResponse"/></returns>
        public async Task<ModifyLaneRuleResponse> ModifyLaneRule(ModifyLaneRuleRequest req)
        {
             JsonResponseModel<ModifyLaneRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLaneRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaneRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新泳道规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRuleRequest"/></param>
        /// <returns><see cref="ModifyLaneRuleResponse"/></returns>
        public ModifyLaneRuleResponse ModifyLaneRuleSync(ModifyLaneRuleRequest req)
        {
             JsonResponseModel<ModifyLaneRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLaneRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaneRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改微服务详情
        /// </summary>
        /// <param name="req"><see cref="ModifyMicroserviceRequest"/></param>
        /// <returns><see cref="ModifyMicroserviceResponse"/></returns>
        public async Task<ModifyMicroserviceResponse> ModifyMicroservice(ModifyMicroserviceRequest req)
        {
             JsonResponseModel<ModifyMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改微服务详情
        /// </summary>
        /// <param name="req"><see cref="ModifyMicroserviceRequest"/></param>
        /// <returns><see cref="ModifyMicroserviceResponse"/></returns>
        public ModifyMicroserviceResponse ModifyMicroserviceSync(ModifyMicroserviceRequest req)
        {
             JsonResponseModel<ModifyMicroserviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMicroservice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMicroserviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改路径重写
        /// </summary>
        /// <param name="req"><see cref="ModifyPathRewriteRequest"/></param>
        /// <returns><see cref="ModifyPathRewriteResponse"/></returns>
        public async Task<ModifyPathRewriteResponse> ModifyPathRewrite(ModifyPathRewriteRequest req)
        {
             JsonResponseModel<ModifyPathRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPathRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPathRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改路径重写
        /// </summary>
        /// <param name="req"><see cref="ModifyPathRewriteRequest"/></param>
        /// <returns><see cref="ModifyPathRewriteResponse"/></returns>
        public ModifyPathRewriteResponse ModifyPathRewriteSync(ModifyPathRewriteRequest req)
        {
             JsonResponseModel<ModifyPathRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPathRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPathRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRequest"/></param>
        /// <returns><see cref="ModifyTaskResponse"/></returns>
        public async Task<ModifyTaskResponse> ModifyTask(ModifyTaskRequest req)
        {
             JsonResponseModel<ModifyTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRequest"/></param>
        /// <returns><see cref="ModifyTaskResponse"/></returns>
        public ModifyTaskResponse ModifyTaskSync(ModifyTaskRequest req)
        {
             JsonResponseModel<ModifyTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req"><see cref="ModifyUploadInfoRequest"/></param>
        /// <returns><see cref="ModifyUploadInfoResponse"/></returns>
        public async Task<ModifyUploadInfoResponse> ModifyUploadInfo(ModifyUploadInfoRequest req)
        {
             JsonResponseModel<ModifyUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req"><see cref="ModifyUploadInfoRequest"/></param>
        /// <returns><see cref="ModifyUploadInfoResponse"/></returns>
        public ModifyUploadInfoResponse ModifyUploadInfoSync(ModifyUploadInfoRequest req)
        {
             JsonResponseModel<ModifyUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定解绑tcr仓库
        /// </summary>
        /// <param name="req"><see cref="OperateApplicationTcrBindingRequest"/></param>
        /// <returns><see cref="OperateApplicationTcrBindingResponse"/></returns>
        public async Task<OperateApplicationTcrBindingResponse> OperateApplicationTcrBinding(OperateApplicationTcrBindingRequest req)
        {
             JsonResponseModel<OperateApplicationTcrBindingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OperateApplicationTcrBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateApplicationTcrBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定解绑tcr仓库
        /// </summary>
        /// <param name="req"><see cref="OperateApplicationTcrBindingRequest"/></param>
        /// <returns><see cref="OperateApplicationTcrBindingResponse"/></returns>
        public OperateApplicationTcrBindingResponse OperateApplicationTcrBindingSync(OperateApplicationTcrBindingRequest req)
        {
             JsonResponseModel<OperateApplicationTcrBindingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OperateApplicationTcrBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateApplicationTcrBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行任务
        /// </summary>
        /// <param name="req"><see cref="RedoTaskRequest"/></param>
        /// <returns><see cref="RedoTaskResponse"/></returns>
        public async Task<RedoTaskResponse> RedoTask(RedoTaskRequest req)
        {
             JsonResponseModel<RedoTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RedoTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行任务
        /// </summary>
        /// <param name="req"><see cref="RedoTaskRequest"/></param>
        /// <returns><see cref="RedoTaskResponse"/></returns>
        public RedoTaskResponse RedoTaskSync(RedoTaskRequest req)
        {
             JsonResponseModel<RedoTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RedoTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行任务批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskBatchRequest"/></param>
        /// <returns><see cref="RedoTaskBatchResponse"/></returns>
        public async Task<RedoTaskBatchResponse> RedoTaskBatch(RedoTaskBatchRequest req)
        {
             JsonResponseModel<RedoTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RedoTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行任务批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskBatchRequest"/></param>
        /// <returns><see cref="RedoTaskBatchResponse"/></returns>
        public RedoTaskBatchResponse RedoTaskBatchSync(RedoTaskBatchRequest req)
        {
             JsonResponseModel<RedoTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RedoTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行在某个节点上执行任务。
        /// </summary>
        /// <param name="req"><see cref="RedoTaskExecuteRequest"/></param>
        /// <returns><see cref="RedoTaskExecuteResponse"/></returns>
        public async Task<RedoTaskExecuteResponse> RedoTaskExecute(RedoTaskExecuteRequest req)
        {
             JsonResponseModel<RedoTaskExecuteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RedoTaskExecute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskExecuteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行在某个节点上执行任务。
        /// </summary>
        /// <param name="req"><see cref="RedoTaskExecuteRequest"/></param>
        /// <returns><see cref="RedoTaskExecuteResponse"/></returns>
        public RedoTaskExecuteResponse RedoTaskExecuteSync(RedoTaskExecuteRequest req)
        {
             JsonResponseModel<RedoTaskExecuteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RedoTaskExecute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskExecuteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行工作流批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskFlowBatchRequest"/></param>
        /// <returns><see cref="RedoTaskFlowBatchResponse"/></returns>
        public async Task<RedoTaskFlowBatchResponse> RedoTaskFlowBatch(RedoTaskFlowBatchRequest req)
        {
             JsonResponseModel<RedoTaskFlowBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RedoTaskFlowBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskFlowBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新执行工作流批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskFlowBatchRequest"/></param>
        /// <returns><see cref="RedoTaskFlowBatchResponse"/></returns>
        public RedoTaskFlowBatchResponse RedoTaskFlowBatchSync(RedoTaskFlowBatchRequest req)
        {
             JsonResponseModel<RedoTaskFlowBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RedoTaskFlowBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedoTaskFlowBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布Api分组
        /// </summary>
        /// <param name="req"><see cref="ReleaseApiGroupRequest"/></param>
        /// <returns><see cref="ReleaseApiGroupResponse"/></returns>
        public async Task<ReleaseApiGroupResponse> ReleaseApiGroup(ReleaseApiGroupRequest req)
        {
             JsonResponseModel<ReleaseApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布Api分组
        /// </summary>
        /// <param name="req"><see cref="ReleaseApiGroupRequest"/></param>
        /// <returns><see cref="ReleaseApiGroupResponse"/></returns>
        public ReleaseApiGroupResponse ReleaseApiGroupSync(ReleaseApiGroupRequest req)
        {
             JsonResponseModel<ReleaseApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigRequest"/></param>
        /// <returns><see cref="ReleaseConfigResponse"/></returns>
        public async Task<ReleaseConfigResponse> ReleaseConfig(ReleaseConfigRequest req)
        {
             JsonResponseModel<ReleaseConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigRequest"/></param>
        /// <returns><see cref="ReleaseConfigResponse"/></returns>
        public ReleaseConfigResponse ReleaseConfigSync(ReleaseConfigRequest req)
        {
             JsonResponseModel<ReleaseConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布文件配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseFileConfigRequest"/></param>
        /// <returns><see cref="ReleaseFileConfigResponse"/></returns>
        public async Task<ReleaseFileConfigResponse> ReleaseFileConfig(ReleaseFileConfigRequest req)
        {
             JsonResponseModel<ReleaseFileConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseFileConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseFileConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布文件配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseFileConfigRequest"/></param>
        /// <returns><see cref="ReleaseFileConfigResponse"/></returns>
        public ReleaseFileConfigResponse ReleaseFileConfigSync(ReleaseFileConfigRequest req)
        {
             JsonResponseModel<ReleaseFileConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseFileConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseFileConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布公共配置
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicConfigRequest"/></param>
        /// <returns><see cref="ReleasePublicConfigResponse"/></returns>
        public async Task<ReleasePublicConfigResponse> ReleasePublicConfig(ReleasePublicConfigRequest req)
        {
             JsonResponseModel<ReleasePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleasePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleasePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布公共配置
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicConfigRequest"/></param>
        /// <returns><see cref="ReleasePublicConfigResponse"/></returns>
        public ReleasePublicConfigResponse ReleasePublicConfigSync(ReleasePublicConfigRequest req)
        {
             JsonResponseModel<ReleasePublicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleasePublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleasePublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public async Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public RemoveInstancesResponse RemoveInstancesSync(RemoveInstancesRequest req)
        {
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤回已发布的配置
        /// </summary>
        /// <param name="req"><see cref="RevocationConfigRequest"/></param>
        /// <returns><see cref="RevocationConfigResponse"/></returns>
        public async Task<RevocationConfigResponse> RevocationConfig(RevocationConfigRequest req)
        {
             JsonResponseModel<RevocationConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevocationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevocationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤回已发布的配置
        /// </summary>
        /// <param name="req"><see cref="RevocationConfigRequest"/></param>
        /// <returns><see cref="RevocationConfigResponse"/></returns>
        public RevocationConfigResponse RevocationConfigSync(RevocationConfigRequest req)
        {
             JsonResponseModel<RevocationConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevocationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevocationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤回已发布的公共配置
        /// </summary>
        /// <param name="req"><see cref="RevocationPublicConfigRequest"/></param>
        /// <returns><see cref="RevocationPublicConfigResponse"/></returns>
        public async Task<RevocationPublicConfigResponse> RevocationPublicConfig(RevocationPublicConfigRequest req)
        {
             JsonResponseModel<RevocationPublicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevocationPublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevocationPublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤回已发布的公共配置
        /// </summary>
        /// <param name="req"><see cref="RevocationPublicConfigRequest"/></param>
        /// <returns><see cref="RevocationPublicConfigResponse"/></returns>
        public RevocationPublicConfigResponse RevocationPublicConfigSync(RevocationPublicConfigRequest req)
        {
             JsonResponseModel<RevocationPublicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevocationPublicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevocationPublicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚配置
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigRequest"/></param>
        /// <returns><see cref="RollbackConfigResponse"/></returns>
        public async Task<RollbackConfigResponse> RollbackConfig(RollbackConfigRequest req)
        {
             JsonResponseModel<RollbackConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚配置
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigRequest"/></param>
        /// <returns><see cref="RollbackConfigResponse"/></returns>
        public RollbackConfigResponse RollbackConfigSync(RollbackConfigRequest req)
        {
             JsonResponseModel<RollbackConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 业务日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchBusinessLogRequest"/></param>
        /// <returns><see cref="SearchBusinessLogResponse"/></returns>
        public async Task<SearchBusinessLogResponse> SearchBusinessLog(SearchBusinessLogRequest req)
        {
             JsonResponseModel<SearchBusinessLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchBusinessLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchBusinessLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 业务日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchBusinessLogRequest"/></param>
        /// <returns><see cref="SearchBusinessLogResponse"/></returns>
        public SearchBusinessLogResponse SearchBusinessLogSync(SearchBusinessLogRequest req)
        {
             JsonResponseModel<SearchBusinessLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchBusinessLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchBusinessLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标准输出日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchStdoutLogRequest"/></param>
        /// <returns><see cref="SearchStdoutLogResponse"/></returns>
        public async Task<SearchStdoutLogResponse> SearchStdoutLog(SearchStdoutLogRequest req)
        {
             JsonResponseModel<SearchStdoutLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchStdoutLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchStdoutLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标准输出日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchStdoutLogRequest"/></param>
        /// <returns><see cref="SearchStdoutLogResponse"/></returns>
        public SearchStdoutLogResponse SearchStdoutLogSync(SearchStdoutLogRequest req)
        {
             JsonResponseModel<SearchStdoutLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchStdoutLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchStdoutLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线部署组所有机器实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkGroupRequest"/></param>
        /// <returns><see cref="ShrinkGroupResponse"/></returns>
        public async Task<ShrinkGroupResponse> ShrinkGroup(ShrinkGroupRequest req)
        {
             JsonResponseModel<ShrinkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShrinkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线部署组所有机器实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkGroupRequest"/></param>
        /// <returns><see cref="ShrinkGroupResponse"/></returns>
        public ShrinkGroupResponse ShrinkGroupSync(ShrinkGroupRequest req)
        {
             JsonResponseModel<ShrinkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ShrinkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组下线实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkInstancesRequest"/></param>
        /// <returns><see cref="ShrinkInstancesResponse"/></returns>
        public async Task<ShrinkInstancesResponse> ShrinkInstances(ShrinkInstancesRequest req)
        {
             JsonResponseModel<ShrinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShrinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 虚拟机部署组下线实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkInstancesRequest"/></param>
        /// <returns><see cref="ShrinkInstancesResponse"/></returns>
        public ShrinkInstancesResponse ShrinkInstancesSync(ShrinkInstancesRequest req)
        {
             JsonResponseModel<ShrinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ShrinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShrinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动容器部署组
        /// </summary>
        /// <param name="req"><see cref="StartContainerGroupRequest"/></param>
        /// <returns><see cref="StartContainerGroupResponse"/></returns>
        public async Task<StartContainerGroupResponse> StartContainerGroup(StartContainerGroupRequest req)
        {
             JsonResponseModel<StartContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动容器部署组
        /// </summary>
        /// <param name="req"><see cref="StartContainerGroupRequest"/></param>
        /// <returns><see cref="StartContainerGroupResponse"/></returns>
        public StartContainerGroupResponse StartContainerGroupSync(StartContainerGroupRequest req)
        {
             JsonResponseModel<StartContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动分组
        /// </summary>
        /// <param name="req"><see cref="StartGroupRequest"/></param>
        /// <returns><see cref="StartGroupResponse"/></returns>
        public async Task<StartGroupResponse> StartGroup(StartGroupRequest req)
        {
             JsonResponseModel<StartGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动分组
        /// </summary>
        /// <param name="req"><see cref="StartGroupRequest"/></param>
        /// <returns><see cref="StartGroupResponse"/></returns>
        public StartGroupResponse StartGroupSync(StartGroupRequest req)
        {
             JsonResponseModel<StartGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止容器部署组
        /// </summary>
        /// <param name="req"><see cref="StopContainerGroupRequest"/></param>
        /// <returns><see cref="StopContainerGroupResponse"/></returns>
        public async Task<StopContainerGroupResponse> StopContainerGroup(StopContainerGroupRequest req)
        {
             JsonResponseModel<StopContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止容器部署组
        /// </summary>
        /// <param name="req"><see cref="StopContainerGroupRequest"/></param>
        /// <returns><see cref="StopContainerGroupResponse"/></returns>
        public StopContainerGroupResponse StopContainerGroupSync(StopContainerGroupRequest req)
        {
             JsonResponseModel<StopContainerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopContainerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopContainerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="StopGroupRequest"/></param>
        /// <returns><see cref="StopGroupResponse"/></returns>
        public async Task<StopGroupResponse> StopGroup(StopGroupRequest req)
        {
             JsonResponseModel<StopGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="StopGroupRequest"/></param>
        /// <returns><see cref="StopGroupResponse"/></returns>
        public StopGroupResponse StopGroupSync(StopGroupRequest req)
        {
             JsonResponseModel<StopGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止执行中的任务批次， 非运行中的任务不可调用。
        /// </summary>
        /// <param name="req"><see cref="StopTaskBatchRequest"/></param>
        /// <returns><see cref="StopTaskBatchResponse"/></returns>
        public async Task<StopTaskBatchResponse> StopTaskBatch(StopTaskBatchRequest req)
        {
             JsonResponseModel<StopTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止执行中的任务批次， 非运行中的任务不可调用。
        /// </summary>
        /// <param name="req"><see cref="StopTaskBatchRequest"/></param>
        /// <returns><see cref="StopTaskBatchResponse"/></returns>
        public StopTaskBatchResponse StopTaskBatchSync(StopTaskBatchRequest req)
        {
             JsonResponseModel<StopTaskBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopTaskBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTaskBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止正在某个节点上执行的任务
        /// </summary>
        /// <param name="req"><see cref="StopTaskExecuteRequest"/></param>
        /// <returns><see cref="StopTaskExecuteResponse"/></returns>
        public async Task<StopTaskExecuteResponse> StopTaskExecute(StopTaskExecuteRequest req)
        {
             JsonResponseModel<StopTaskExecuteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopTaskExecute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTaskExecuteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止正在某个节点上执行的任务
        /// </summary>
        /// <param name="req"><see cref="StopTaskExecuteRequest"/></param>
        /// <returns><see cref="StopTaskExecuteResponse"/></returns>
        public StopTaskExecuteResponse StopTaskExecuteSync(StopTaskExecuteRequest req)
        {
             JsonResponseModel<StopTaskExecuteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopTaskExecute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTaskExecuteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止一个工作流批次
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskFlowBatchRequest"/></param>
        /// <returns><see cref="TerminateTaskFlowBatchResponse"/></returns>
        public async Task<TerminateTaskFlowBatchResponse> TerminateTaskFlowBatch(TerminateTaskFlowBatchRequest req)
        {
             JsonResponseModel<TerminateTaskFlowBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTaskFlowBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTaskFlowBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止一个工作流批次
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskFlowBatchRequest"/></param>
        /// <returns><see cref="TerminateTaskFlowBatchResponse"/></returns>
        public TerminateTaskFlowBatchResponse TerminateTaskFlowBatchSync(TerminateTaskFlowBatchRequest req)
        {
             JsonResponseModel<TerminateTaskFlowBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateTaskFlowBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTaskFlowBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// API分组批量与网关解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindApiGroupRequest"/></param>
        /// <returns><see cref="UnbindApiGroupResponse"/></returns>
        public async Task<UnbindApiGroupResponse> UnbindApiGroup(UnbindApiGroupRequest req)
        {
             JsonResponseModel<UnbindApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// API分组批量与网关解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindApiGroupRequest"/></param>
        /// <returns><see cref="UnbindApiGroupResponse"/></returns>
        public UnbindApiGroupResponse UnbindApiGroupSync(UnbindApiGroupRequest req)
        {
             JsonResponseModel<UnbindApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Api分组
        /// </summary>
        /// <param name="req"><see cref="UpdateApiGroupRequest"/></param>
        /// <returns><see cref="UpdateApiGroupResponse"/></returns>
        public async Task<UpdateApiGroupResponse> UpdateApiGroup(UpdateApiGroupRequest req)
        {
             JsonResponseModel<UpdateApiGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Api分组
        /// </summary>
        /// <param name="req"><see cref="UpdateApiGroupRequest"/></param>
        /// <returns><see cref="UpdateApiGroupResponse"/></returns>
        public UpdateApiGroupResponse UpdateApiGroupSync(UpdateApiGroupRequest req)
        {
             JsonResponseModel<UpdateApiGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRuleResponse"/></returns>
        public async Task<UpdateApiRateLimitRuleResponse> UpdateApiRateLimitRule(UpdateApiRateLimitRuleRequest req)
        {
             JsonResponseModel<UpdateApiRateLimitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiRateLimitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiRateLimitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRuleResponse"/></returns>
        public UpdateApiRateLimitRuleResponse UpdateApiRateLimitRuleSync(UpdateApiRateLimitRuleRequest req)
        {
             JsonResponseModel<UpdateApiRateLimitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiRateLimitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiRateLimitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRulesResponse"/></returns>
        public async Task<UpdateApiRateLimitRulesResponse> UpdateApiRateLimitRules(UpdateApiRateLimitRulesRequest req)
        {
             JsonResponseModel<UpdateApiRateLimitRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiRateLimitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiRateLimitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRulesResponse"/></returns>
        public UpdateApiRateLimitRulesResponse UpdateApiRateLimitRulesSync(UpdateApiRateLimitRulesRequest req)
        {
             JsonResponseModel<UpdateApiRateLimitRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiRateLimitRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiRateLimitRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新API超时
        /// </summary>
        /// <param name="req"><see cref="UpdateApiTimeoutsRequest"/></param>
        /// <returns><see cref="UpdateApiTimeoutsResponse"/></returns>
        public async Task<UpdateApiTimeoutsResponse> UpdateApiTimeouts(UpdateApiTimeoutsRequest req)
        {
             JsonResponseModel<UpdateApiTimeoutsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiTimeouts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiTimeoutsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量更新API超时
        /// </summary>
        /// <param name="req"><see cref="UpdateApiTimeoutsRequest"/></param>
        /// <returns><see cref="UpdateApiTimeoutsResponse"/></returns>
        public UpdateApiTimeoutsResponse UpdateApiTimeoutsSync(UpdateApiTimeoutsRequest req)
        {
             JsonResponseModel<UpdateApiTimeoutsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiTimeouts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiTimeoutsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新API
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayApiRequest"/></param>
        /// <returns><see cref="UpdateGatewayApiResponse"/></returns>
        public async Task<UpdateGatewayApiResponse> UpdateGatewayApi(UpdateGatewayApiRequest req)
        {
             JsonResponseModel<UpdateGatewayApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGatewayApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGatewayApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新API
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayApiRequest"/></param>
        /// <returns><see cref="UpdateGatewayApiResponse"/></returns>
        public UpdateGatewayApiResponse UpdateGatewayApiSync(UpdateGatewayApiRequest req)
        {
             JsonResponseModel<UpdateGatewayApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGatewayApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGatewayApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateHealthCheckSettingsRequest"/></param>
        /// <returns><see cref="UpdateHealthCheckSettingsResponse"/></returns>
        public async Task<UpdateHealthCheckSettingsResponse> UpdateHealthCheckSettings(UpdateHealthCheckSettingsRequest req)
        {
             JsonResponseModel<UpdateHealthCheckSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateHealthCheckSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateHealthCheckSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateHealthCheckSettingsRequest"/></param>
        /// <returns><see cref="UpdateHealthCheckSettingsResponse"/></returns>
        public UpdateHealthCheckSettingsResponse UpdateHealthCheckSettingsSync(UpdateHealthCheckSettingsRequest req)
        {
             JsonResponseModel<UpdateHealthCheckSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateHealthCheckSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateHealthCheckSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新仓库信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRepositoryRequest"/></param>
        /// <returns><see cref="UpdateRepositoryResponse"/></returns>
        public async Task<UpdateRepositoryResponse> UpdateRepository(UpdateRepositoryRequest req)
        {
             JsonResponseModel<UpdateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新仓库信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRepositoryRequest"/></param>
        /// <returns><see cref="UpdateRepositoryResponse"/></returns>
        public UpdateRepositoryResponse UpdateRepositorySync(UpdateRepositoryRequest req)
        {
             JsonResponseModel<UpdateRepositoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRepository");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRepositoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新单元化规则
        /// </summary>
        /// <param name="req"><see cref="UpdateUnitRuleRequest"/></param>
        /// <returns><see cref="UpdateUnitRuleResponse"/></returns>
        public async Task<UpdateUnitRuleResponse> UpdateUnitRule(UpdateUnitRuleRequest req)
        {
             JsonResponseModel<UpdateUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新单元化规则
        /// </summary>
        /// <param name="req"><see cref="UpdateUnitRuleRequest"/></param>
        /// <returns><see cref="UpdateUnitRuleResponse"/></returns>
        public UpdateUnitRuleResponse UpdateUnitRuleSync(UpdateUnitRuleRequest req)
        {
             JsonResponseModel<UpdateUnitRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUnitRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUnitRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
