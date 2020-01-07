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
        /// AddInstances接口的同步版本，添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req">参考<see cref="AddInstancesRequest"/></param>
        /// <returns>参考<see cref="AddInstancesResponse"/>实例</returns>
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
        /// CreateApplication接口的同步版本，创建应用
        /// </summary>
        /// <param name="req">参考<see cref="CreateApplicationRequest"/></param>
        /// <returns>参考<see cref="CreateApplicationResponse"/>实例</returns>
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
        /// CreateCluster接口的同步版本，创建集群
        /// </summary>
        /// <param name="req">参考<see cref="CreateClusterRequest"/></param>
        /// <returns>参考<see cref="CreateClusterResponse"/>实例</returns>
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
        /// CreateConfig接口的同步版本，创建配置项
        /// </summary>
        /// <param name="req">参考<see cref="CreateConfigRequest"/></param>
        /// <returns>参考<see cref="CreateConfigResponse"/>实例</returns>
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
        /// CreateContainGroup接口的同步版本，创建容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="CreateContainGroupRequest"/></param>
        /// <returns>参考<see cref="CreateContainGroupResponse"/>实例</returns>
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
        /// 创建容器部署组
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
        /// CreateGroup接口的同步版本，创建容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="CreateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateGroupResponse"/>实例</returns>
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
        /// CreateMicroservice接口的同步版本，新增微服务
        /// </summary>
        /// <param name="req">参考<see cref="CreateMicroserviceRequest"/></param>
        /// <returns>参考<see cref="CreateMicroserviceResponse"/>实例</returns>
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
        /// CreateNamespace接口的同步版本，创建命名空间
        /// </summary>
        /// <param name="req">参考<see cref="CreateNamespaceRequest"/></param>
        /// <returns>参考<see cref="CreateNamespaceResponse"/>实例</returns>
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
        /// CreatePublicConfig接口的同步版本，创建公共配置项
        /// </summary>
        /// <param name="req">参考<see cref="CreatePublicConfigRequest"/></param>
        /// <returns>参考<see cref="CreatePublicConfigResponse"/>实例</returns>
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
        /// CreateServerlessGroup接口的同步版本，创建Serverless部署组
        /// </summary>
        /// <param name="req">参考<see cref="CreateServerlessGroupRequest"/></param>
        /// <returns>参考<see cref="CreateServerlessGroupResponse"/>实例</returns>
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
        /// DeleteApplication接口的同步版本，删除应用
        /// </summary>
        /// <param name="req">参考<see cref="DeleteApplicationRequest"/></param>
        /// <returns>参考<see cref="DeleteApplicationResponse"/>实例</returns>
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
        /// DeleteConfig接口的同步版本，删除配置项
        /// </summary>
        /// <param name="req">参考<see cref="DeleteConfigRequest"/></param>
        /// <returns>参考<see cref="DeleteConfigResponse"/>实例</returns>
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
        /// DeleteContainerGroup接口的同步版本，删除容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteContainerGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteContainerGroupResponse"/>实例</returns>
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
        /// DeleteGroup接口的同步版本，删除容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteGroupResponse"/>实例</returns>
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
        /// DeleteImageTags接口的同步版本，批量删除镜像版本
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImageTagsRequest"/></param>
        /// <returns>参考<see cref="DeleteImageTagsResponse"/>实例</returns>
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
        /// DeleteMicroservice接口的同步版本，删除微服务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMicroserviceRequest"/></param>
        /// <returns>参考<see cref="DeleteMicroserviceResponse"/>实例</returns>
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
        /// DeleteNamespace接口的同步版本，删除命名空间
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNamespaceRequest"/></param>
        /// <returns>参考<see cref="DeleteNamespaceResponse"/>实例</returns>
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
        /// DeletePkgs接口的同步版本，从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePkgsRequest"/></param>
        /// <returns>参考<see cref="DeletePkgsResponse"/>实例</returns>
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
        /// DeletePublicConfig接口的同步版本，删除公共配置项
        /// </summary>
        /// <param name="req">参考<see cref="DeletePublicConfigRequest"/></param>
        /// <returns>参考<see cref="DeletePublicConfigResponse"/>实例</returns>
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
        /// DeleteServerlessGroup接口的同步版本，删除Serverless部署组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServerlessGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteServerlessGroupResponse"/>实例</returns>
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
        /// DeployContainerGroup接口的同步版本，部署容器应用
        /// </summary>
        /// <param name="req">参考<see cref="DeployContainerGroupRequest"/></param>
        /// <returns>参考<see cref="DeployContainerGroupResponse"/>实例</returns>
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
        /// DeployGroup接口的同步版本，部署虚拟机部署组应用
        /// </summary>
        /// <param name="req">参考<see cref="DeployGroupRequest"/></param>
        /// <returns>参考<see cref="DeployGroupResponse"/>实例</returns>
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
        /// DeployServerlessGroup接口的同步版本，部署Serverless应用
        /// </summary>
        /// <param name="req">参考<see cref="DeployServerlessGroupRequest"/></param>
        /// <returns>参考<see cref="DeployServerlessGroupResponse"/>实例</returns>
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
        /// DescribeApplication接口的同步版本，获取应用详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationResponse"/>实例</returns>
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
        /// DescribeApplicationAttribute接口的同步版本，获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationAttributeResponse"/>实例</returns>
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
        /// DescribeApplications接口的同步版本，获取应用列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeApplicationsRequest"/></param>
        /// <returns>参考<see cref="DescribeApplicationsResponse"/>实例</returns>
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
        /// DescribeClusterInstances接口的同步版本，查询集群实例
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterInstancesResponse"/>实例</returns>
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
        /// DescribeConfig接口的同步版本，查询配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigResponse"/>实例</returns>
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
        /// DescribeConfigReleaseLogs接口的同步版本，查询配置发布历史
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigReleaseLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigReleaseLogsResponse"/>实例</returns>
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
        /// DescribeConfigReleases接口的同步版本，查询配置发布信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigReleasesRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigReleasesResponse"/>实例</returns>
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
        /// DescribeConfigSummary接口的同步版本，查询配置汇总列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigSummaryRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigSummaryResponse"/>实例</returns>
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
        /// DescribeConfigs接口的同步版本，查询配置项列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeConfigsResponse"/>实例</returns>
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
        /// DescribeContainerGroupDetail接口的同步版本， 容器部署组详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerGroupDetailResponse"/>实例</returns>
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
        /// DescribeContainerGroups接口的同步版本，容器部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeContainerGroupsResponse"/>实例</returns>
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
        /// DescribeDownloadInfo接口的同步版本，TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDownloadInfoResponse"/>实例</returns>
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
        /// DescribeGroup接口的同步版本，查询虚拟机部署组详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupResponse"/>实例</returns>
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
        /// DescribeGroupInstances接口的同步版本，查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupInstancesResponse"/>实例</returns>
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
        /// DescribeGroups接口的同步版本，获取虚拟机部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeGroupsResponse"/>实例</returns>
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
        /// DescribeImageTags接口的同步版本，镜像版本列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageTagsRequest"/></param>
        /// <returns>参考<see cref="DescribeImageTagsResponse"/>实例</returns>
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
        /// DescribeMicroservice接口的同步版本，查询微服务详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMicroserviceRequest"/></param>
        /// <returns>参考<see cref="DescribeMicroserviceResponse"/>实例</returns>
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
        /// DescribeMicroservices接口的同步版本，获取微服务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMicroservicesRequest"/></param>
        /// <returns>参考<see cref="DescribeMicroservicesResponse"/>实例</returns>
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
        /// DescribePkgs接口的同步版本，无
        /// </summary>
        /// <param name="req">参考<see cref="DescribePkgsRequest"/></param>
        /// <returns>参考<see cref="DescribePkgsResponse"/>实例</returns>
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
        /// DescribePublicConfig接口的同步版本，查询公共配置（单条）
        /// </summary>
        /// <param name="req">参考<see cref="DescribePublicConfigRequest"/></param>
        /// <returns>参考<see cref="DescribePublicConfigResponse"/>实例</returns>
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
        /// DescribePublicConfigReleaseLogs接口的同步版本，查询公共配置发布历史
        /// </summary>
        /// <param name="req">参考<see cref="DescribePublicConfigReleaseLogsRequest"/></param>
        /// <returns>参考<see cref="DescribePublicConfigReleaseLogsResponse"/>实例</returns>
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
        /// DescribePublicConfigReleases接口的同步版本，查询公共配置发布信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribePublicConfigReleasesRequest"/></param>
        /// <returns>参考<see cref="DescribePublicConfigReleasesResponse"/>实例</returns>
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
        /// DescribePublicConfigSummary接口的同步版本，查询公共配置汇总列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribePublicConfigSummaryRequest"/></param>
        /// <returns>参考<see cref="DescribePublicConfigSummaryResponse"/>实例</returns>
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
        /// DescribePublicConfigs接口的同步版本，查询公共配置项列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribePublicConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribePublicConfigsResponse"/>实例</returns>
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
        /// DescribeReleasedConfig接口的同步版本，查询group发布的配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeReleasedConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeReleasedConfigResponse"/>实例</returns>
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
        /// DescribeServerlessGroup接口的同步版本，查询Serverless部署组明细
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServerlessGroupRequest"/></param>
        /// <returns>参考<see cref="DescribeServerlessGroupResponse"/>实例</returns>
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
        /// DescribeServerlessGroups接口的同步版本，查询Serverless部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServerlessGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeServerlessGroupsResponse"/>实例</returns>
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
        /// DescribeSimpleApplications接口的同步版本，查询简单应用列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleApplicationsResponse"/>实例</returns>
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
        /// DescribeSimpleClusters接口的同步版本，查询简单集群列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleClustersResponse"/>实例</returns>
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
        /// DescribeSimpleGroups接口的同步版本，查询简单部署组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleGroupsResponse"/>实例</returns>
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
        /// DescribeSimpleNamespaces接口的同步版本，查询简单命名空间列表 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns>参考<see cref="DescribeSimpleNamespacesResponse"/>实例</returns>
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
        /// DescribeUploadInfo接口的同步版本，TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUploadInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeUploadInfoResponse"/>实例</returns>
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
        /// ExpandGroup接口的同步版本，虚拟机部署组添加实例
        /// </summary>
        /// <param name="req">参考<see cref="ExpandGroupRequest"/></param>
        /// <returns>参考<see cref="ExpandGroupResponse"/>实例</returns>
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
        /// ModifyContainerGroup接口的同步版本，修改容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContainerGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyContainerGroupResponse"/>实例</returns>
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
        /// ModifyContainerReplicas接口的同步版本，修改容器部署组实例数
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns>参考<see cref="ModifyContainerReplicasResponse"/>实例</returns>
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
        /// ModifyMicroservice接口的同步版本，修改微服务详情
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMicroserviceRequest"/></param>
        /// <returns>参考<see cref="ModifyMicroserviceResponse"/>实例</returns>
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
        /// ModifyUploadInfo接口的同步版本，调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyUploadInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyUploadInfoResponse"/>实例</returns>
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
        /// ReleaseConfig接口的同步版本，发布配置
        /// </summary>
        /// <param name="req">参考<see cref="ReleaseConfigRequest"/></param>
        /// <returns>参考<see cref="ReleaseConfigResponse"/>实例</returns>
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
        /// ReleasePublicConfig接口的同步版本，发布公共配置
        /// </summary>
        /// <param name="req">参考<see cref="ReleasePublicConfigRequest"/></param>
        /// <returns>参考<see cref="ReleasePublicConfigResponse"/>实例</returns>
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
        /// RemoveInstances接口的同步版本，从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req">参考<see cref="RemoveInstancesRequest"/></param>
        /// <returns>参考<see cref="RemoveInstancesResponse"/>实例</returns>
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
        /// RevocationConfig接口的同步版本，撤回已发布的配置
        /// </summary>
        /// <param name="req">参考<see cref="RevocationConfigRequest"/></param>
        /// <returns>参考<see cref="RevocationConfigResponse"/>实例</returns>
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
        /// RevocationPublicConfig接口的同步版本，撤回已发布的公共配置
        /// </summary>
        /// <param name="req">参考<see cref="RevocationPublicConfigRequest"/></param>
        /// <returns>参考<see cref="RevocationPublicConfigResponse"/>实例</returns>
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
        /// RollbackConfig接口的同步版本，回滚配置
        /// </summary>
        /// <param name="req">参考<see cref="RollbackConfigRequest"/></param>
        /// <returns>参考<see cref="RollbackConfigResponse"/>实例</returns>
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
        /// ShrinkGroup接口的同步版本，下线部署组所有机器实例
        /// </summary>
        /// <param name="req">参考<see cref="ShrinkGroupRequest"/></param>
        /// <returns>参考<see cref="ShrinkGroupResponse"/>实例</returns>
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
        /// ShrinkInstances接口的同步版本，虚拟机部署组下线实例
        /// </summary>
        /// <param name="req">参考<see cref="ShrinkInstancesRequest"/></param>
        /// <returns>参考<see cref="ShrinkInstancesResponse"/>实例</returns>
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
        /// StartContainerGroup接口的同步版本，启动容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="StartContainerGroupRequest"/></param>
        /// <returns>参考<see cref="StartContainerGroupResponse"/>实例</returns>
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
        /// StartGroup接口的同步版本，启动分组
        /// </summary>
        /// <param name="req">参考<see cref="StartGroupRequest"/></param>
        /// <returns>参考<see cref="StartGroupResponse"/>实例</returns>
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
        /// StopContainerGroup接口的同步版本，停止容器部署组
        /// </summary>
        /// <param name="req">参考<see cref="StopContainerGroupRequest"/></param>
        /// <returns>参考<see cref="StopContainerGroupResponse"/>实例</returns>
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
        /// StopGroup接口的同步版本，停止虚拟机部署组
        /// </summary>
        /// <param name="req">参考<see cref="StopGroupRequest"/></param>
        /// <returns>参考<see cref="StopGroupResponse"/>实例</returns>
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

    }
}
