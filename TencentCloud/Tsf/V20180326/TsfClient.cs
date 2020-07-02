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

    }
}
