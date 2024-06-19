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
       private const string sdkVersion = "SDK_NET_3.0.1029";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TsfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddClusterInstancesRequest"/></param>
        /// <returns><see cref="AddClusterInstancesResponse"/></returns>
        public Task<AddClusterInstancesResponse> AddClusterInstances(AddClusterInstancesRequest req)
        {
            return InternalRequestAsync<AddClusterInstancesResponse>(req, "AddClusterInstances");
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddClusterInstancesRequest"/></param>
        /// <returns><see cref="AddClusterInstancesResponse"/></returns>
        public AddClusterInstancesResponse AddClusterInstancesSync(AddClusterInstancesRequest req)
        {
            return InternalRequestAsync<AddClusterInstancesResponse>(req, "AddClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public Task<AddInstancesResponse> AddInstances(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances");
        }

        /// <summary>
        /// 添加云主机节点至TSF集群
        /// </summary>
        /// <param name="req"><see cref="AddInstancesRequest"/></param>
        /// <returns><see cref="AddInstancesResponse"/></returns>
        public AddInstancesResponse AddInstancesSync(AddInstancesRequest req)
        {
            return InternalRequestAsync<AddInstancesResponse>(req, "AddInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联日志配置项到应用
        /// </summary>
        /// <param name="req"><see cref="AssociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="AssociateBusinessLogConfigResponse"/></returns>
        public Task<AssociateBusinessLogConfigResponse> AssociateBusinessLogConfig(AssociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<AssociateBusinessLogConfigResponse>(req, "AssociateBusinessLogConfig");
        }

        /// <summary>
        /// 关联日志配置项到应用
        /// </summary>
        /// <param name="req"><see cref="AssociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="AssociateBusinessLogConfigResponse"/></returns>
        public AssociateBusinessLogConfigResponse AssociateBusinessLogConfigSync(AssociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<AssociateBusinessLogConfigResponse>(req, "AssociateBusinessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联投递配置到部署组
        /// </summary>
        /// <param name="req"><see cref="AssociateConfigWithGroupRequest"/></param>
        /// <returns><see cref="AssociateConfigWithGroupResponse"/></returns>
        public Task<AssociateConfigWithGroupResponse> AssociateConfigWithGroup(AssociateConfigWithGroupRequest req)
        {
            return InternalRequestAsync<AssociateConfigWithGroupResponse>(req, "AssociateConfigWithGroup");
        }

        /// <summary>
        /// 关联投递配置到部署组
        /// </summary>
        /// <param name="req"><see cref="AssociateConfigWithGroupRequest"/></param>
        /// <returns><see cref="AssociateConfigWithGroupResponse"/></returns>
        public AssociateConfigWithGroupResponse AssociateConfigWithGroupSync(AssociateConfigWithGroupRequest req)
        {
            return InternalRequestAsync<AssociateConfigWithGroupResponse>(req, "AssociateConfigWithGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 网关与API分组批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindApiGroupRequest"/></param>
        /// <returns><see cref="BindApiGroupResponse"/></returns>
        public Task<BindApiGroupResponse> BindApiGroup(BindApiGroupRequest req)
        {
            return InternalRequestAsync<BindApiGroupResponse>(req, "BindApiGroup");
        }

        /// <summary>
        /// 网关与API分组批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindApiGroupRequest"/></param>
        /// <returns><see cref="BindApiGroupResponse"/></returns>
        public BindApiGroupResponse BindApiGroupSync(BindApiGroupRequest req)
        {
            return InternalRequestAsync<BindApiGroupResponse>(req, "BindApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 插件与网关分组/API批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindPluginRequest"/></param>
        /// <returns><see cref="BindPluginResponse"/></returns>
        public Task<BindPluginResponse> BindPlugin(BindPluginRequest req)
        {
            return InternalRequestAsync<BindPluginResponse>(req, "BindPlugin");
        }

        /// <summary>
        /// 插件与网关分组/API批量绑定
        /// </summary>
        /// <param name="req"><see cref="BindPluginRequest"/></param>
        /// <returns><see cref="BindPluginResponse"/></returns>
        public BindPluginResponse BindPluginSync(BindPluginRequest req)
        {
            return InternalRequestAsync<BindPluginResponse>(req, "BindPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用或禁用API
        /// </summary>
        /// <param name="req"><see cref="ChangeApiUsableStatusRequest"/></param>
        /// <returns><see cref="ChangeApiUsableStatusResponse"/></returns>
        public Task<ChangeApiUsableStatusResponse> ChangeApiUsableStatus(ChangeApiUsableStatusRequest req)
        {
            return InternalRequestAsync<ChangeApiUsableStatusResponse>(req, "ChangeApiUsableStatus");
        }

        /// <summary>
        /// 启用或禁用API
        /// </summary>
        /// <param name="req"><see cref="ChangeApiUsableStatusRequest"/></param>
        /// <returns><see cref="ChangeApiUsableStatusResponse"/></returns>
        public ChangeApiUsableStatusResponse ChangeApiUsableStatusSync(ChangeApiUsableStatusRequest req)
        {
            return InternalRequestAsync<ChangeApiUsableStatusResponse>(req, "ChangeApiUsableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对执行失败的任务批次执行续跑
        /// </summary>
        /// <param name="req"><see cref="ContinueRunFailedTaskBatchRequest"/></param>
        /// <returns><see cref="ContinueRunFailedTaskBatchResponse"/></returns>
        public Task<ContinueRunFailedTaskBatchResponse> ContinueRunFailedTaskBatch(ContinueRunFailedTaskBatchRequest req)
        {
            return InternalRequestAsync<ContinueRunFailedTaskBatchResponse>(req, "ContinueRunFailedTaskBatch");
        }

        /// <summary>
        /// 对执行失败的任务批次执行续跑
        /// </summary>
        /// <param name="req"><see cref="ContinueRunFailedTaskBatchRequest"/></param>
        /// <returns><see cref="ContinueRunFailedTaskBatchResponse"/></returns>
        public ContinueRunFailedTaskBatchResponse ContinueRunFailedTaskBatchSync(ContinueRunFailedTaskBatchRequest req)
        {
            return InternalRequestAsync<ContinueRunFailedTaskBatchResponse>(req, "ContinueRunFailedTaskBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 一键导入API分组
        /// </summary>
        /// <param name="req"><see cref="CreateAllGatewayApiAsyncRequest"/></param>
        /// <returns><see cref="CreateAllGatewayApiAsyncResponse"/></returns>
        public Task<CreateAllGatewayApiAsyncResponse> CreateAllGatewayApiAsync(CreateAllGatewayApiAsyncRequest req)
        {
            return InternalRequestAsync<CreateAllGatewayApiAsyncResponse>(req, "CreateAllGatewayApiAsync");
        }

        /// <summary>
        /// 一键导入API分组
        /// </summary>
        /// <param name="req"><see cref="CreateAllGatewayApiAsyncRequest"/></param>
        /// <returns><see cref="CreateAllGatewayApiAsyncResponse"/></returns>
        public CreateAllGatewayApiAsyncResponse CreateAllGatewayApiAsyncSync(CreateAllGatewayApiAsyncRequest req)
        {
            return InternalRequestAsync<CreateAllGatewayApiAsyncResponse>(req, "CreateAllGatewayApiAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建API分组
        /// </summary>
        /// <param name="req"><see cref="CreateApiGroupRequest"/></param>
        /// <returns><see cref="CreateApiGroupResponse"/></returns>
        public Task<CreateApiGroupResponse> CreateApiGroup(CreateApiGroupRequest req)
        {
            return InternalRequestAsync<CreateApiGroupResponse>(req, "CreateApiGroup");
        }

        /// <summary>
        /// 创建API分组
        /// </summary>
        /// <param name="req"><see cref="CreateApiGroupRequest"/></param>
        /// <returns><see cref="CreateApiGroupResponse"/></returns>
        public CreateApiGroupResponse CreateApiGroupSync(CreateApiGroupRequest req)
        {
            return InternalRequestAsync<CreateApiGroupResponse>(req, "CreateApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建API限流规则
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleResponse"/></returns>
        public Task<CreateApiRateLimitRuleResponse> CreateApiRateLimitRule(CreateApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<CreateApiRateLimitRuleResponse>(req, "CreateApiRateLimitRule");
        }

        /// <summary>
        /// 创建API限流规则
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleResponse"/></returns>
        public CreateApiRateLimitRuleResponse CreateApiRateLimitRuleSync(CreateApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<CreateApiRateLimitRuleResponse>(req, "CreateApiRateLimitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建API限流规则,并返回规则信息
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleWithDetailRespResponse"/></returns>
        public Task<CreateApiRateLimitRuleWithDetailRespResponse> CreateApiRateLimitRuleWithDetailResp(CreateApiRateLimitRuleWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateApiRateLimitRuleWithDetailRespResponse>(req, "CreateApiRateLimitRuleWithDetailResp");
        }

        /// <summary>
        /// 创建API限流规则,并返回规则信息
        /// </summary>
        /// <param name="req"><see cref="CreateApiRateLimitRuleWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateApiRateLimitRuleWithDetailRespResponse"/></returns>
        public CreateApiRateLimitRuleWithDetailRespResponse CreateApiRateLimitRuleWithDetailRespSync(CreateApiRateLimitRuleWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateApiRateLimitRuleWithDetailRespResponse>(req, "CreateApiRateLimitRuleWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建配置项
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig");
        }

        /// <summary>
        /// 创建配置项
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建参数模板
        /// </summary>
        /// <param name="req"><see cref="CreateConfigTemplateRequest"/></param>
        /// <returns><see cref="CreateConfigTemplateResponse"/></returns>
        public Task<CreateConfigTemplateResponse> CreateConfigTemplate(CreateConfigTemplateRequest req)
        {
            return InternalRequestAsync<CreateConfigTemplateResponse>(req, "CreateConfigTemplate");
        }

        /// <summary>
        /// 创建参数模板
        /// </summary>
        /// <param name="req"><see cref="CreateConfigTemplateRequest"/></param>
        /// <returns><see cref="CreateConfigTemplateResponse"/></returns>
        public CreateConfigTemplateResponse CreateConfigTemplateSync(CreateConfigTemplateRequest req)
        {
            return InternalRequestAsync<CreateConfigTemplateResponse>(req, "CreateConfigTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建参数模板，并返回模板详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateConfigTemplateWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateConfigTemplateWithDetailRespResponse"/></returns>
        public Task<CreateConfigTemplateWithDetailRespResponse> CreateConfigTemplateWithDetailResp(CreateConfigTemplateWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateConfigTemplateWithDetailRespResponse>(req, "CreateConfigTemplateWithDetailResp");
        }

        /// <summary>
        /// 创建参数模板，并返回模板详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateConfigTemplateWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateConfigTemplateWithDetailRespResponse"/></returns>
        public CreateConfigTemplateWithDetailRespResponse CreateConfigTemplateWithDetailRespSync(CreateConfigTemplateWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateConfigTemplateWithDetailRespResponse>(req, "CreateConfigTemplateWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建配置项，返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateConfigWithDetailRespResponse"/></returns>
        public Task<CreateConfigWithDetailRespResponse> CreateConfigWithDetailResp(CreateConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateConfigWithDetailRespResponse>(req, "CreateConfigWithDetailResp");
        }

        /// <summary>
        /// 创建配置项，返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateConfigWithDetailRespResponse"/></returns>
        public CreateConfigWithDetailRespResponse CreateConfigWithDetailRespSync(CreateConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateConfigWithDetailRespResponse>(req, "CreateConfigWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// （已废弃，请使用 CreateGroup 和 DeployContainerGroup 创建和部署容器部署组）创建容器部署组
        /// </summary>
        /// <param name="req"><see cref="CreateContainGroupRequest"/></param>
        /// <returns><see cref="CreateContainGroupResponse"/></returns>
        public Task<CreateContainGroupResponse> CreateContainGroup(CreateContainGroupRequest req)
        {
            return InternalRequestAsync<CreateContainGroupResponse>(req, "CreateContainGroup");
        }

        /// <summary>
        /// （已废弃，请使用 CreateGroup 和 DeployContainerGroup 创建和部署容器部署组）创建容器部署组
        /// </summary>
        /// <param name="req"><see cref="CreateContainGroupRequest"/></param>
        /// <returns><see cref="CreateContainGroupResponse"/></returns>
        public CreateContainGroupResponse CreateContainGroupSync(CreateContainGroupRequest req)
        {
            return InternalRequestAsync<CreateContainGroupResponse>(req, "CreateContainGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件配置项
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigRequest"/></param>
        /// <returns><see cref="CreateFileConfigResponse"/></returns>
        public Task<CreateFileConfigResponse> CreateFileConfig(CreateFileConfigRequest req)
        {
            return InternalRequestAsync<CreateFileConfigResponse>(req, "CreateFileConfig");
        }

        /// <summary>
        /// 创建文件配置项
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigRequest"/></param>
        /// <returns><see cref="CreateFileConfigResponse"/></returns>
        public CreateFileConfigResponse CreateFileConfigSync(CreateFileConfigRequest req)
        {
            return InternalRequestAsync<CreateFileConfigResponse>(req, "CreateFileConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件配置项，返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateFileConfigWithDetailRespResponse"/></returns>
        public Task<CreateFileConfigWithDetailRespResponse> CreateFileConfigWithDetailResp(CreateFileConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateFileConfigWithDetailRespResponse>(req, "CreateFileConfigWithDetailResp");
        }

        /// <summary>
        /// 创建文件配置项，返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateFileConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateFileConfigWithDetailRespResponse"/></returns>
        public CreateFileConfigWithDetailRespResponse CreateFileConfigWithDetailRespSync(CreateFileConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateFileConfigWithDetailRespResponse>(req, "CreateFileConfigWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量导入API至api分组(也支持新建API到分组)
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayApiRequest"/></param>
        /// <returns><see cref="CreateGatewayApiResponse"/></returns>
        public Task<CreateGatewayApiResponse> CreateGatewayApi(CreateGatewayApiRequest req)
        {
            return InternalRequestAsync<CreateGatewayApiResponse>(req, "CreateGatewayApi");
        }

        /// <summary>
        /// 批量导入API至api分组(也支持新建API到分组)
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayApiRequest"/></param>
        /// <returns><see cref="CreateGatewayApiResponse"/></returns>
        public CreateGatewayApiResponse CreateGatewayApiSync(CreateGatewayApiRequest req)
        {
            return InternalRequestAsync<CreateGatewayApiResponse>(req, "CreateGatewayApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// 创建虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建泳道
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRequest"/></param>
        /// <returns><see cref="CreateLaneResponse"/></returns>
        public Task<CreateLaneResponse> CreateLane(CreateLaneRequest req)
        {
            return InternalRequestAsync<CreateLaneResponse>(req, "CreateLane");
        }

        /// <summary>
        /// 创建泳道
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRequest"/></param>
        /// <returns><see cref="CreateLaneResponse"/></returns>
        public CreateLaneResponse CreateLaneSync(CreateLaneRequest req)
        {
            return InternalRequestAsync<CreateLaneResponse>(req, "CreateLane")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建泳道规则
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRuleRequest"/></param>
        /// <returns><see cref="CreateLaneRuleResponse"/></returns>
        public Task<CreateLaneRuleResponse> CreateLaneRule(CreateLaneRuleRequest req)
        {
            return InternalRequestAsync<CreateLaneRuleResponse>(req, "CreateLaneRule");
        }

        /// <summary>
        /// 创建泳道规则
        /// </summary>
        /// <param name="req"><see cref="CreateLaneRuleRequest"/></param>
        /// <returns><see cref="CreateLaneRuleResponse"/></returns>
        public CreateLaneRuleResponse CreateLaneRuleSync(CreateLaneRuleRequest req)
        {
            return InternalRequestAsync<CreateLaneRuleResponse>(req, "CreateLaneRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增微服务
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceRequest"/></param>
        /// <returns><see cref="CreateMicroserviceResponse"/></returns>
        public Task<CreateMicroserviceResponse> CreateMicroservice(CreateMicroserviceRequest req)
        {
            return InternalRequestAsync<CreateMicroserviceResponse>(req, "CreateMicroservice");
        }

        /// <summary>
        /// 新增微服务
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceRequest"/></param>
        /// <returns><see cref="CreateMicroserviceResponse"/></returns>
        public CreateMicroserviceResponse CreateMicroserviceSync(CreateMicroserviceRequest req)
        {
            return InternalRequestAsync<CreateMicroserviceResponse>(req, "CreateMicroservice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增微服务返回id
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateMicroserviceWithDetailRespResponse"/></returns>
        public Task<CreateMicroserviceWithDetailRespResponse> CreateMicroserviceWithDetailResp(CreateMicroserviceWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateMicroserviceWithDetailRespResponse>(req, "CreateMicroserviceWithDetailResp");
        }

        /// <summary>
        /// 新增微服务返回id
        /// </summary>
        /// <param name="req"><see cref="CreateMicroserviceWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateMicroserviceWithDetailRespResponse"/></returns>
        public CreateMicroserviceWithDetailRespResponse CreateMicroserviceWithDetailRespSync(CreateMicroserviceWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateMicroserviceWithDetailRespResponse>(req, "CreateMicroserviceWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建路径重写
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesRequest"/></param>
        /// <returns><see cref="CreatePathRewritesResponse"/></returns>
        public Task<CreatePathRewritesResponse> CreatePathRewrites(CreatePathRewritesRequest req)
        {
            return InternalRequestAsync<CreatePathRewritesResponse>(req, "CreatePathRewrites");
        }

        /// <summary>
        /// 创建路径重写
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesRequest"/></param>
        /// <returns><see cref="CreatePathRewritesResponse"/></returns>
        public CreatePathRewritesResponse CreatePathRewritesSync(CreatePathRewritesRequest req)
        {
            return InternalRequestAsync<CreatePathRewritesResponse>(req, "CreatePathRewrites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建路径重写，并返回路径重写规则信息
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesWithDetailRespRequest"/></param>
        /// <returns><see cref="CreatePathRewritesWithDetailRespResponse"/></returns>
        public Task<CreatePathRewritesWithDetailRespResponse> CreatePathRewritesWithDetailResp(CreatePathRewritesWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreatePathRewritesWithDetailRespResponse>(req, "CreatePathRewritesWithDetailResp");
        }

        /// <summary>
        /// 创建路径重写，并返回路径重写规则信息
        /// </summary>
        /// <param name="req"><see cref="CreatePathRewritesWithDetailRespRequest"/></param>
        /// <returns><see cref="CreatePathRewritesWithDetailRespResponse"/></returns>
        public CreatePathRewritesWithDetailRespResponse CreatePathRewritesWithDetailRespSync(CreatePathRewritesWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreatePathRewritesWithDetailRespResponse>(req, "CreatePathRewritesWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建公共配置项
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigRequest"/></param>
        /// <returns><see cref="CreatePublicConfigResponse"/></returns>
        public Task<CreatePublicConfigResponse> CreatePublicConfig(CreatePublicConfigRequest req)
        {
            return InternalRequestAsync<CreatePublicConfigResponse>(req, "CreatePublicConfig");
        }

        /// <summary>
        /// 创建公共配置项
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigRequest"/></param>
        /// <returns><see cref="CreatePublicConfigResponse"/></returns>
        public CreatePublicConfigResponse CreatePublicConfigSync(CreatePublicConfigRequest req)
        {
            return InternalRequestAsync<CreatePublicConfigResponse>(req, "CreatePublicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建公共配置项，并返回配置项详细信息
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreatePublicConfigWithDetailRespResponse"/></returns>
        public Task<CreatePublicConfigWithDetailRespResponse> CreatePublicConfigWithDetailResp(CreatePublicConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreatePublicConfigWithDetailRespResponse>(req, "CreatePublicConfigWithDetailResp");
        }

        /// <summary>
        /// 创建公共配置项，并返回配置项详细信息
        /// </summary>
        /// <param name="req"><see cref="CreatePublicConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="CreatePublicConfigWithDetailRespResponse"/></returns>
        public CreatePublicConfigWithDetailRespResponse CreatePublicConfigWithDetailRespSync(CreatePublicConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreatePublicConfigWithDetailRespResponse>(req, "CreatePublicConfigWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository");
        }

        /// <summary>
        /// 创建仓库
        /// </summary>
        /// <param name="req"><see cref="CreateRepositoryRequest"/></param>
        /// <returns><see cref="CreateRepositoryResponse"/></returns>
        public CreateRepositoryResponse CreateRepositorySync(CreateRepositoryRequest req)
        {
            return InternalRequestAsync<CreateRepositoryResponse>(req, "CreateRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFlowRequest"/></param>
        /// <returns><see cref="CreateTaskFlowResponse"/></returns>
        public Task<CreateTaskFlowResponse> CreateTaskFlow(CreateTaskFlowRequest req)
        {
            return InternalRequestAsync<CreateTaskFlowResponse>(req, "CreateTaskFlow");
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFlowRequest"/></param>
        /// <returns><see cref="CreateTaskFlowResponse"/></returns>
        public CreateTaskFlowResponse CreateTaskFlowSync(CreateTaskFlowRequest req)
        {
            return InternalRequestAsync<CreateTaskFlowResponse>(req, "CreateTaskFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateUnitNamespacesRequest"/></param>
        /// <returns><see cref="CreateUnitNamespacesResponse"/></returns>
        public Task<CreateUnitNamespacesResponse> CreateUnitNamespaces(CreateUnitNamespacesRequest req)
        {
            return InternalRequestAsync<CreateUnitNamespacesResponse>(req, "CreateUnitNamespaces");
        }

        /// <summary>
        /// 批量创建单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateUnitNamespacesRequest"/></param>
        /// <returns><see cref="CreateUnitNamespacesResponse"/></returns>
        public CreateUnitNamespacesResponse CreateUnitNamespacesSync(CreateUnitNamespacesRequest req)
        {
            return InternalRequestAsync<CreateUnitNamespacesResponse>(req, "CreateUnitNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建单元化规则
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleRequest"/></param>
        /// <returns><see cref="CreateUnitRuleResponse"/></returns>
        public Task<CreateUnitRuleResponse> CreateUnitRule(CreateUnitRuleRequest req)
        {
            return InternalRequestAsync<CreateUnitRuleResponse>(req, "CreateUnitRule");
        }

        /// <summary>
        /// 创建单元化规则
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleRequest"/></param>
        /// <returns><see cref="CreateUnitRuleResponse"/></returns>
        public CreateUnitRuleResponse CreateUnitRuleSync(CreateUnitRuleRequest req)
        {
            return InternalRequestAsync<CreateUnitRuleResponse>(req, "CreateUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建单元化规则, 并返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateUnitRuleWithDetailRespResponse"/></returns>
        public Task<CreateUnitRuleWithDetailRespResponse> CreateUnitRuleWithDetailResp(CreateUnitRuleWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateUnitRuleWithDetailRespResponse>(req, "CreateUnitRuleWithDetailResp");
        }

        /// <summary>
        /// 创建单元化规则, 并返回详细信息
        /// </summary>
        /// <param name="req"><see cref="CreateUnitRuleWithDetailRespRequest"/></param>
        /// <returns><see cref="CreateUnitRuleWithDetailRespResponse"/></returns>
        public CreateUnitRuleWithDetailRespResponse CreateUnitRuleWithDetailRespSync(CreateUnitRuleWithDetailRespRequest req)
        {
            return InternalRequestAsync<CreateUnitRuleWithDetailRespResponse>(req, "CreateUnitRuleWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Api分组
        /// </summary>
        /// <param name="req"><see cref="DeleteApiGroupRequest"/></param>
        /// <returns><see cref="DeleteApiGroupResponse"/></returns>
        public Task<DeleteApiGroupResponse> DeleteApiGroup(DeleteApiGroupRequest req)
        {
            return InternalRequestAsync<DeleteApiGroupResponse>(req, "DeleteApiGroup");
        }

        /// <summary>
        /// 删除Api分组
        /// </summary>
        /// <param name="req"><see cref="DeleteApiGroupRequest"/></param>
        /// <returns><see cref="DeleteApiGroupResponse"/></returns>
        public DeleteApiGroupResponse DeleteApiGroupSync(DeleteApiGroupRequest req)
        {
            return InternalRequestAsync<DeleteApiGroupResponse>(req, "DeleteApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除API限流规则
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="DeleteApiRateLimitRuleResponse"/></returns>
        public Task<DeleteApiRateLimitRuleResponse> DeleteApiRateLimitRule(DeleteApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<DeleteApiRateLimitRuleResponse>(req, "DeleteApiRateLimitRule");
        }

        /// <summary>
        /// 删除API限流规则
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="DeleteApiRateLimitRuleResponse"/></returns>
        public DeleteApiRateLimitRuleResponse DeleteApiRateLimitRuleSync(DeleteApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<DeleteApiRateLimitRuleResponse>(req, "DeleteApiRateLimitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig");
        }

        /// <summary>
        /// 删除配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigTemplateRequest"/></param>
        /// <returns><see cref="DeleteConfigTemplateResponse"/></returns>
        public Task<DeleteConfigTemplateResponse> DeleteConfigTemplate(DeleteConfigTemplateRequest req)
        {
            return InternalRequestAsync<DeleteConfigTemplateResponse>(req, "DeleteConfigTemplate");
        }

        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigTemplateRequest"/></param>
        /// <returns><see cref="DeleteConfigTemplateResponse"/></returns>
        public DeleteConfigTemplateResponse DeleteConfigTemplateSync(DeleteConfigTemplateRequest req)
        {
            return InternalRequestAsync<DeleteConfigTemplateResponse>(req, "DeleteConfigTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerGroupRequest"/></param>
        /// <returns><see cref="DeleteContainerGroupResponse"/></returns>
        public Task<DeleteContainerGroupResponse> DeleteContainerGroup(DeleteContainerGroupRequest req)
        {
            return InternalRequestAsync<DeleteContainerGroupResponse>(req, "DeleteContainerGroup");
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteContainerGroupRequest"/></param>
        /// <returns><see cref="DeleteContainerGroupResponse"/></returns>
        public DeleteContainerGroupResponse DeleteContainerGroupSync(DeleteContainerGroupRequest req)
        {
            return InternalRequestAsync<DeleteContainerGroupResponse>(req, "DeleteContainerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteFileConfigRequest"/></param>
        /// <returns><see cref="DeleteFileConfigResponse"/></returns>
        public Task<DeleteFileConfigResponse> DeleteFileConfig(DeleteFileConfigRequest req)
        {
            return InternalRequestAsync<DeleteFileConfigResponse>(req, "DeleteFileConfig");
        }

        /// <summary>
        /// 删除文件配置项
        /// </summary>
        /// <param name="req"><see cref="DeleteFileConfigRequest"/></param>
        /// <returns><see cref="DeleteFileConfigResponse"/></returns>
        public DeleteFileConfigResponse DeleteFileConfigSync(DeleteFileConfigRequest req)
        {
            return InternalRequestAsync<DeleteFileConfigResponse>(req, "DeleteFileConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除API
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayApiRequest"/></param>
        /// <returns><see cref="DeleteGatewayApiResponse"/></returns>
        public Task<DeleteGatewayApiResponse> DeleteGatewayApi(DeleteGatewayApiRequest req)
        {
            return InternalRequestAsync<DeleteGatewayApiResponse>(req, "DeleteGatewayApi");
        }

        /// <summary>
        /// 批量删除API
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayApiRequest"/></param>
        /// <returns><see cref="DeleteGatewayApiResponse"/></returns>
        public DeleteGatewayApiResponse DeleteGatewayApiSync(DeleteGatewayApiRequest req)
        {
            return InternalRequestAsync<DeleteGatewayApiResponse>(req, "DeleteGatewayApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// 删除容器部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除镜像版本
        /// </summary>
        /// <param name="req"><see cref="DeleteImageTagsRequest"/></param>
        /// <returns><see cref="DeleteImageTagsResponse"/></returns>
        public Task<DeleteImageTagsResponse> DeleteImageTags(DeleteImageTagsRequest req)
        {
            return InternalRequestAsync<DeleteImageTagsResponse>(req, "DeleteImageTags");
        }

        /// <summary>
        /// 批量删除镜像版本
        /// </summary>
        /// <param name="req"><see cref="DeleteImageTagsRequest"/></param>
        /// <returns><see cref="DeleteImageTagsResponse"/></returns>
        public DeleteImageTagsResponse DeleteImageTagsSync(DeleteImageTagsRequest req)
        {
            return InternalRequestAsync<DeleteImageTagsResponse>(req, "DeleteImageTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除泳道
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRequest"/></param>
        /// <returns><see cref="DeleteLaneResponse"/></returns>
        public Task<DeleteLaneResponse> DeleteLane(DeleteLaneRequest req)
        {
            return InternalRequestAsync<DeleteLaneResponse>(req, "DeleteLane");
        }

        /// <summary>
        /// 删除泳道
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRequest"/></param>
        /// <returns><see cref="DeleteLaneResponse"/></returns>
        public DeleteLaneResponse DeleteLaneSync(DeleteLaneRequest req)
        {
            return InternalRequestAsync<DeleteLaneResponse>(req, "DeleteLane")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除泳道规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRuleRequest"/></param>
        /// <returns><see cref="DeleteLaneRuleResponse"/></returns>
        public Task<DeleteLaneRuleResponse> DeleteLaneRule(DeleteLaneRuleRequest req)
        {
            return InternalRequestAsync<DeleteLaneRuleResponse>(req, "DeleteLaneRule");
        }

        /// <summary>
        /// 删除泳道规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLaneRuleRequest"/></param>
        /// <returns><see cref="DeleteLaneRuleResponse"/></returns>
        public DeleteLaneRuleResponse DeleteLaneRuleSync(DeleteLaneRuleRequest req)
        {
            return InternalRequestAsync<DeleteLaneRuleResponse>(req, "DeleteLaneRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除微服务
        /// </summary>
        /// <param name="req"><see cref="DeleteMicroserviceRequest"/></param>
        /// <returns><see cref="DeleteMicroserviceResponse"/></returns>
        public Task<DeleteMicroserviceResponse> DeleteMicroservice(DeleteMicroserviceRequest req)
        {
            return InternalRequestAsync<DeleteMicroserviceResponse>(req, "DeleteMicroservice");
        }

        /// <summary>
        /// 删除微服务
        /// </summary>
        /// <param name="req"><see cref="DeleteMicroserviceRequest"/></param>
        /// <returns><see cref="DeleteMicroserviceResponse"/></returns>
        public DeleteMicroserviceResponse DeleteMicroserviceSync(DeleteMicroserviceRequest req)
        {
            return InternalRequestAsync<DeleteMicroserviceResponse>(req, "DeleteMicroservice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace");
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除路径重写
        /// </summary>
        /// <param name="req"><see cref="DeletePathRewritesRequest"/></param>
        /// <returns><see cref="DeletePathRewritesResponse"/></returns>
        public Task<DeletePathRewritesResponse> DeletePathRewrites(DeletePathRewritesRequest req)
        {
            return InternalRequestAsync<DeletePathRewritesResponse>(req, "DeletePathRewrites");
        }

        /// <summary>
        /// 删除路径重写
        /// </summary>
        /// <param name="req"><see cref="DeletePathRewritesRequest"/></param>
        /// <returns><see cref="DeletePathRewritesResponse"/></returns>
        public DeletePathRewritesResponse DeletePathRewritesSync(DeletePathRewritesRequest req)
        {
            return InternalRequestAsync<DeletePathRewritesResponse>(req, "DeletePathRewrites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req"><see cref="DeletePkgsRequest"/></param>
        /// <returns><see cref="DeletePkgsResponse"/></returns>
        public Task<DeletePkgsResponse> DeletePkgs(DeletePkgsRequest req)
        {
            return InternalRequestAsync<DeletePkgsResponse>(req, "DeletePkgs");
        }

        /// <summary>
        /// 从软件仓库批量删除程序包。
        /// 一次最多支持删除1000个包，数量超过1000，返回UpperDeleteLimit错误。
        /// </summary>
        /// <param name="req"><see cref="DeletePkgsRequest"/></param>
        /// <returns><see cref="DeletePkgsResponse"/></returns>
        public DeletePkgsResponse DeletePkgsSync(DeletePkgsRequest req)
        {
            return InternalRequestAsync<DeletePkgsResponse>(req, "DeletePkgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除公共配置项
        /// </summary>
        /// <param name="req"><see cref="DeletePublicConfigRequest"/></param>
        /// <returns><see cref="DeletePublicConfigResponse"/></returns>
        public Task<DeletePublicConfigResponse> DeletePublicConfig(DeletePublicConfigRequest req)
        {
            return InternalRequestAsync<DeletePublicConfigResponse>(req, "DeletePublicConfig");
        }

        /// <summary>
        /// 删除公共配置项
        /// </summary>
        /// <param name="req"><see cref="DeletePublicConfigRequest"/></param>
        /// <returns><see cref="DeletePublicConfigResponse"/></returns>
        public DeletePublicConfigResponse DeletePublicConfigSync(DeletePublicConfigRequest req)
        {
            return InternalRequestAsync<DeletePublicConfigResponse>(req, "DeletePublicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public Task<DeleteRepositoryResponse> DeleteRepository(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository");
        }

        /// <summary>
        /// 删除仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteRepositoryRequest"/></param>
        /// <returns><see cref="DeleteRepositoryResponse"/></returns>
        public DeleteRepositoryResponse DeleteRepositorySync(DeleteRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteRepositoryResponse>(req, "DeleteRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessGroupRequest"/></param>
        /// <returns><see cref="DeleteServerlessGroupResponse"/></returns>
        public Task<DeleteServerlessGroupResponse> DeleteServerlessGroup(DeleteServerlessGroupRequest req)
        {
            return InternalRequestAsync<DeleteServerlessGroupResponse>(req, "DeleteServerlessGroup");
        }

        /// <summary>
        /// 删除Serverless部署组
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessGroupRequest"/></param>
        /// <returns><see cref="DeleteServerlessGroupResponse"/></returns>
        public DeleteServerlessGroupResponse DeleteServerlessGroupSync(DeleteServerlessGroupRequest req)
        {
            return InternalRequestAsync<DeleteServerlessGroupResponse>(req, "DeleteServerlessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitNamespacesRequest"/></param>
        /// <returns><see cref="DeleteUnitNamespacesResponse"/></returns>
        public Task<DeleteUnitNamespacesResponse> DeleteUnitNamespaces(DeleteUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DeleteUnitNamespacesResponse>(req, "DeleteUnitNamespaces");
        }

        /// <summary>
        /// 删除单元化命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitNamespacesRequest"/></param>
        /// <returns><see cref="DeleteUnitNamespacesResponse"/></returns>
        public DeleteUnitNamespacesResponse DeleteUnitNamespacesSync(DeleteUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DeleteUnitNamespacesResponse>(req, "DeleteUnitNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除单元化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitRuleRequest"/></param>
        /// <returns><see cref="DeleteUnitRuleResponse"/></returns>
        public Task<DeleteUnitRuleResponse> DeleteUnitRule(DeleteUnitRuleRequest req)
        {
            return InternalRequestAsync<DeleteUnitRuleResponse>(req, "DeleteUnitRule");
        }

        /// <summary>
        /// 删除单元化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteUnitRuleRequest"/></param>
        /// <returns><see cref="DeleteUnitRuleResponse"/></returns>
        public DeleteUnitRuleResponse DeleteUnitRuleSync(DeleteUnitRuleRequest req)
        {
            return InternalRequestAsync<DeleteUnitRuleResponse>(req, "DeleteUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 部署容器应用-更新
        /// </summary>
        /// <param name="req"><see cref="DeployContainerGroupRequest"/></param>
        /// <returns><see cref="DeployContainerGroupResponse"/></returns>
        public Task<DeployContainerGroupResponse> DeployContainerGroup(DeployContainerGroupRequest req)
        {
            return InternalRequestAsync<DeployContainerGroupResponse>(req, "DeployContainerGroup");
        }

        /// <summary>
        /// 部署容器应用-更新
        /// </summary>
        /// <param name="req"><see cref="DeployContainerGroupRequest"/></param>
        /// <returns><see cref="DeployContainerGroupResponse"/></returns>
        public DeployContainerGroupResponse DeployContainerGroupSync(DeployContainerGroupRequest req)
        {
            return InternalRequestAsync<DeployContainerGroupResponse>(req, "DeployContainerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 部署虚拟机部署组应用
        /// </summary>
        /// <param name="req"><see cref="DeployGroupRequest"/></param>
        /// <returns><see cref="DeployGroupResponse"/></returns>
        public Task<DeployGroupResponse> DeployGroup(DeployGroupRequest req)
        {
            return InternalRequestAsync<DeployGroupResponse>(req, "DeployGroup");
        }

        /// <summary>
        /// 部署虚拟机部署组应用
        /// </summary>
        /// <param name="req"><see cref="DeployGroupRequest"/></param>
        /// <returns><see cref="DeployGroupResponse"/></returns>
        public DeployGroupResponse DeployGroupSync(DeployGroupRequest req)
        {
            return InternalRequestAsync<DeployGroupResponse>(req, "DeployGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public Task<DescribeApiDetailResponse> DescribeApiDetail(DescribeApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiDetailResponse>(req, "DescribeApiDetail");
        }

        /// <summary>
        /// 查询API详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public DescribeApiDetailResponse DescribeApiDetailSync(DescribeApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiDetailResponse>(req, "DescribeApiDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupRequest"/></param>
        /// <returns><see cref="DescribeApiGroupResponse"/></returns>
        public Task<DescribeApiGroupResponse> DescribeApiGroup(DescribeApiGroupRequest req)
        {
            return InternalRequestAsync<DescribeApiGroupResponse>(req, "DescribeApiGroup");
        }

        /// <summary>
        /// 查询API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupRequest"/></param>
        /// <returns><see cref="DescribeApiGroupResponse"/></returns>
        public DescribeApiGroupResponse DescribeApiGroupSync(DescribeApiGroupRequest req)
        {
            return InternalRequestAsync<DescribeApiGroupResponse>(req, "DescribeApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupsRequest"/></param>
        /// <returns><see cref="DescribeApiGroupsResponse"/></returns>
        public Task<DescribeApiGroupsResponse> DescribeApiGroups(DescribeApiGroupsRequest req)
        {
            return InternalRequestAsync<DescribeApiGroupsResponse>(req, "DescribeApiGroups");
        }

        /// <summary>
        /// 查询API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiGroupsRequest"/></param>
        /// <returns><see cref="DescribeApiGroupsResponse"/></returns>
        public DescribeApiGroupsResponse DescribeApiGroupsSync(DescribeApiGroupsRequest req)
        {
            return InternalRequestAsync<DescribeApiGroupsResponse>(req, "DescribeApiGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API限流规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="DescribeApiRateLimitRulesResponse"/></returns>
        public Task<DescribeApiRateLimitRulesResponse> DescribeApiRateLimitRules(DescribeApiRateLimitRulesRequest req)
        {
            return InternalRequestAsync<DescribeApiRateLimitRulesResponse>(req, "DescribeApiRateLimitRules");
        }

        /// <summary>
        /// 查询API限流规则
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="DescribeApiRateLimitRulesResponse"/></returns>
        public DescribeApiRateLimitRulesResponse DescribeApiRateLimitRulesSync(DescribeApiRateLimitRulesRequest req)
        {
            return InternalRequestAsync<DescribeApiRateLimitRulesResponse>(req, "DescribeApiRateLimitRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关API监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeApiUseDetailResponse"/></returns>
        public Task<DescribeApiUseDetailResponse> DescribeApiUseDetail(DescribeApiUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiUseDetailResponse>(req, "DescribeApiUseDetail");
        }

        /// <summary>
        /// 查询网关API监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeApiUseDetailResponse"/></returns>
        public DescribeApiUseDetailResponse DescribeApiUseDetailSync(DescribeApiUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiUseDetailResponse>(req, "DescribeApiUseDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API 版本
        /// </summary>
        /// <param name="req"><see cref="DescribeApiVersionsRequest"/></param>
        /// <returns><see cref="DescribeApiVersionsResponse"/></returns>
        public Task<DescribeApiVersionsResponse> DescribeApiVersions(DescribeApiVersionsRequest req)
        {
            return InternalRequestAsync<DescribeApiVersionsResponse>(req, "DescribeApiVersions");
        }

        /// <summary>
        /// 查询API 版本
        /// </summary>
        /// <param name="req"><see cref="DescribeApiVersionsRequest"/></param>
        /// <returns><see cref="DescribeApiVersionsResponse"/></returns>
        public DescribeApiVersionsResponse DescribeApiVersionsSync(DescribeApiVersionsRequest req)
        {
            return InternalRequestAsync<DescribeApiVersionsResponse>(req, "DescribeApiVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication");
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns><see cref="DescribeApplicationAttributeResponse"/></returns>
        public Task<DescribeApplicationAttributeResponse> DescribeApplicationAttribute(DescribeApplicationAttributeRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAttributeResponse>(req, "DescribeApplicationAttribute");
        }

        /// <summary>
        /// 获取应用列表其它字段，如实例数量信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAttributeRequest"/></param>
        /// <returns><see cref="DescribeApplicationAttributeResponse"/></returns>
        public DescribeApplicationAttributeResponse DescribeApplicationAttributeSync(DescribeApplicationAttributeRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAttributeResponse>(req, "DescribeApplicationAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用关联日志配置项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationBusinessLogConfigResponse"/></returns>
        public Task<DescribeApplicationBusinessLogConfigResponse> DescribeApplicationBusinessLogConfig(DescribeApplicationBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationBusinessLogConfigResponse>(req, "DescribeApplicationBusinessLogConfig");
        }

        /// <summary>
        /// 查询应用关联日志配置项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationBusinessLogConfigResponse"/></returns>
        public DescribeApplicationBusinessLogConfigResponse DescribeApplicationBusinessLogConfigSync(DescribeApplicationBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationBusinessLogConfigResponse>(req, "DescribeApplicationBusinessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// 获取应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TSF基本资源信息概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeBasicResourceUsageResponse"/></returns>
        public Task<DescribeBasicResourceUsageResponse> DescribeBasicResourceUsage(DescribeBasicResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeBasicResourceUsageResponse>(req, "DescribeBasicResourceUsage");
        }

        /// <summary>
        /// TSF基本资源信息概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeBasicResourceUsageResponse"/></returns>
        public DescribeBasicResourceUsageResponse DescribeBasicResourceUsageSync(DescribeBasicResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeBasicResourceUsageResponse>(req, "DescribeBasicResourceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询业务日志配置项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeBusinessLogConfigResponse"/></returns>
        public Task<DescribeBusinessLogConfigResponse> DescribeBusinessLogConfig(DescribeBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeBusinessLogConfigResponse>(req, "DescribeBusinessLogConfig");
        }

        /// <summary>
        /// 查询业务日志配置项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeBusinessLogConfigResponse"/></returns>
        public DescribeBusinessLogConfigResponse DescribeBusinessLogConfigSync(DescribeBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeBusinessLogConfigResponse>(req, "DescribeBusinessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeBusinessLogConfigsResponse"/></returns>
        public Task<DescribeBusinessLogConfigsResponse> DescribeBusinessLogConfigs(DescribeBusinessLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeBusinessLogConfigsResponse>(req, "DescribeBusinessLogConfigs");
        }

        /// <summary>
        /// 查询日志配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeBusinessLogConfigsResponse"/></returns>
        public DescribeBusinessLogConfigsResponse DescribeBusinessLogConfigsSync(DescribeBusinessLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeBusinessLogConfigsResponse>(req, "DescribeBusinessLogConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// 查询集群实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// 查询配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribeConfigReleaseLogsResponse"/></returns>
        public Task<DescribeConfigReleaseLogsResponse> DescribeConfigReleaseLogs(DescribeConfigReleaseLogsRequest req)
        {
            return InternalRequestAsync<DescribeConfigReleaseLogsResponse>(req, "DescribeConfigReleaseLogs");
        }

        /// <summary>
        /// 查询配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribeConfigReleaseLogsResponse"/></returns>
        public DescribeConfigReleaseLogsResponse DescribeConfigReleaseLogsSync(DescribeConfigReleaseLogsRequest req)
        {
            return InternalRequestAsync<DescribeConfigReleaseLogsResponse>(req, "DescribeConfigReleaseLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigReleasesResponse"/></returns>
        public Task<DescribeConfigReleasesResponse> DescribeConfigReleases(DescribeConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribeConfigReleasesResponse>(req, "DescribeConfigReleases");
        }

        /// <summary>
        /// 查询配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigReleasesResponse"/></returns>
        public DescribeConfigReleasesResponse DescribeConfigReleasesSync(DescribeConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribeConfigReleasesResponse>(req, "DescribeConfigReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribeConfigSummaryResponse"/></returns>
        public Task<DescribeConfigSummaryResponse> DescribeConfigSummary(DescribeConfigSummaryRequest req)
        {
            return InternalRequestAsync<DescribeConfigSummaryResponse>(req, "DescribeConfigSummary");
        }

        /// <summary>
        /// 查询配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribeConfigSummaryResponse"/></returns>
        public DescribeConfigSummaryResponse DescribeConfigSummarySync(DescribeConfigSummaryRequest req)
        {
            return InternalRequestAsync<DescribeConfigSummaryResponse>(req, "DescribeConfigSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigTemplateRequest"/></param>
        /// <returns><see cref="DescribeConfigTemplateResponse"/></returns>
        public Task<DescribeConfigTemplateResponse> DescribeConfigTemplate(DescribeConfigTemplateRequest req)
        {
            return InternalRequestAsync<DescribeConfigTemplateResponse>(req, "DescribeConfigTemplate");
        }

        /// <summary>
        /// 导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigTemplateRequest"/></param>
        /// <returns><see cref="DescribeConfigTemplateResponse"/></returns>
        public DescribeConfigTemplateResponse DescribeConfigTemplateSync(DescribeConfigTemplateRequest req)
        {
            return InternalRequestAsync<DescribeConfigTemplateResponse>(req, "DescribeConfigTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs");
        }

        /// <summary>
        /// 查询配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取容器事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerEventsResponse"/></returns>
        public Task<DescribeContainerEventsResponse> DescribeContainerEvents(DescribeContainerEventsRequest req)
        {
            return InternalRequestAsync<DescribeContainerEventsResponse>(req, "DescribeContainerEvents");
        }

        /// <summary>
        /// 获取容器事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerEventsRequest"/></param>
        /// <returns><see cref="DescribeContainerEventsResponse"/></returns>
        public DescribeContainerEventsResponse DescribeContainerEventsSync(DescribeContainerEventsRequest req)
        {
            return InternalRequestAsync<DescribeContainerEventsResponse>(req, "DescribeContainerEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取部署组其他字段-用于前端并发调用
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupAttributeRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupAttributeResponse"/></returns>
        public Task<DescribeContainerGroupAttributeResponse> DescribeContainerGroupAttribute(DescribeContainerGroupAttributeRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupAttributeResponse>(req, "DescribeContainerGroupAttribute");
        }

        /// <summary>
        /// 获取部署组其他字段-用于前端并发调用
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupAttributeRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupAttributeResponse"/></returns>
        public DescribeContainerGroupAttributeResponse DescribeContainerGroupAttributeSync(DescribeContainerGroupAttributeRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupAttributeResponse>(req, "DescribeContainerGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  获取部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDeployInfoRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDeployInfoResponse"/></returns>
        public Task<DescribeContainerGroupDeployInfoResponse> DescribeContainerGroupDeployInfo(DescribeContainerGroupDeployInfoRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupDeployInfoResponse>(req, "DescribeContainerGroupDeployInfo");
        }

        /// <summary>
        ///  获取部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDeployInfoRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDeployInfoResponse"/></returns>
        public DescribeContainerGroupDeployInfoResponse DescribeContainerGroupDeployInfoSync(DescribeContainerGroupDeployInfoRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupDeployInfoResponse>(req, "DescribeContainerGroupDeployInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  容器部署组详情（已废弃，请使用  DescribeContainerGroupDeployInfo）
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDetailResponse"/></returns>
        public Task<DescribeContainerGroupDetailResponse> DescribeContainerGroupDetail(DescribeContainerGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupDetailResponse>(req, "DescribeContainerGroupDetail");
        }

        /// <summary>
        ///  容器部署组详情（已废弃，请使用  DescribeContainerGroupDeployInfo）
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupDetailResponse"/></returns>
        public DescribeContainerGroupDetailResponse DescribeContainerGroupDetailSync(DescribeContainerGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupDetailResponse>(req, "DescribeContainerGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 容器部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupsResponse"/></returns>
        public Task<DescribeContainerGroupsResponse> DescribeContainerGroups(DescribeContainerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupsResponse>(req, "DescribeContainerGroups");
        }

        /// <summary>
        /// 容器部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerGroupsRequest"/></param>
        /// <returns><see cref="DescribeContainerGroupsResponse"/></returns>
        public DescribeContainerGroupsResponse DescribeContainerGroupsSync(DescribeContainerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeContainerGroupsResponse>(req, "DescribeContainerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一键导入API分组任务的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateGatewayApiStatusRequest"/></param>
        /// <returns><see cref="DescribeCreateGatewayApiStatusResponse"/></returns>
        public Task<DescribeCreateGatewayApiStatusResponse> DescribeCreateGatewayApiStatus(DescribeCreateGatewayApiStatusRequest req)
        {
            return InternalRequestAsync<DescribeCreateGatewayApiStatusResponse>(req, "DescribeCreateGatewayApiStatus");
        }

        /// <summary>
        /// 查询一键导入API分组任务的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCreateGatewayApiStatusRequest"/></param>
        /// <returns><see cref="DescribeCreateGatewayApiStatusResponse"/></returns>
        public DescribeCreateGatewayApiStatusResponse DescribeCreateGatewayApiStatusSync(DescribeCreateGatewayApiStatusRequest req)
        {
            return InternalRequestAsync<DescribeCreateGatewayApiStatusResponse>(req, "DescribeCreateGatewayApiStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个投递项配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigResponse"/></returns>
        public Task<DescribeDeliveryConfigResponse> DescribeDeliveryConfig(DescribeDeliveryConfigRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigResponse>(req, "DescribeDeliveryConfig");
        }

        /// <summary>
        /// 获取单个投递项配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigResponse"/></returns>
        public DescribeDeliveryConfigResponse DescribeDeliveryConfigSync(DescribeDeliveryConfigRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigResponse>(req, "DescribeDeliveryConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用部署组id获取绑定信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigByGroupIdRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigByGroupIdResponse"/></returns>
        public Task<DescribeDeliveryConfigByGroupIdResponse> DescribeDeliveryConfigByGroupId(DescribeDeliveryConfigByGroupIdRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigByGroupIdResponse>(req, "DescribeDeliveryConfigByGroupId");
        }

        /// <summary>
        /// 用部署组id获取绑定信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigByGroupIdRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigByGroupIdResponse"/></returns>
        public DescribeDeliveryConfigByGroupIdResponse DescribeDeliveryConfigByGroupIdSync(DescribeDeliveryConfigByGroupIdRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigByGroupIdResponse>(req, "DescribeDeliveryConfigByGroupId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取多个投递项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigsRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigsResponse"/></returns>
        public Task<DescribeDeliveryConfigsResponse> DescribeDeliveryConfigs(DescribeDeliveryConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigsResponse>(req, "DescribeDeliveryConfigs");
        }

        /// <summary>
        /// 获取多个投递项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDeliveryConfigsRequest"/></param>
        /// <returns><see cref="DescribeDeliveryConfigsResponse"/></returns>
        public DescribeDeliveryConfigsResponse DescribeDeliveryConfigsSync(DescribeDeliveryConfigsRequest req)
        {
            return InternalRequestAsync<DescribeDeliveryConfigsResponse>(req, "DescribeDeliveryConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfoResponse"/></returns>
        public Task<DescribeDownloadInfoResponse> DescribeDownloadInfo(DescribeDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeDownloadInfoResponse>(req, "DescribeDownloadInfo");
        }

        /// <summary>
        /// TSF上传的程序包存放在腾讯云对象存储（COS）中，通过该API可以获取从COS下载程序包需要的信息，包括包所在的桶、存储路径、鉴权信息等，之后使用COS API（或SDK）进行下载。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfoRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfoResponse"/></returns>
        public DescribeDownloadInfoResponse DescribeDownloadInfoSync(DescribeDownloadInfoRequest req)
        {
            return InternalRequestAsync<DescribeDownloadInfoResponse>(req, "DescribeDownloadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询生效的单元化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnabledUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeEnabledUnitRuleResponse"/></returns>
        public Task<DescribeEnabledUnitRuleResponse> DescribeEnabledUnitRule(DescribeEnabledUnitRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnabledUnitRuleResponse>(req, "DescribeEnabledUnitRule");
        }

        /// <summary>
        /// 查询生效的单元化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeEnabledUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeEnabledUnitRuleResponse"/></returns>
        public DescribeEnabledUnitRuleResponse DescribeEnabledUnitRuleSync(DescribeEnabledUnitRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnabledUnitRuleResponse>(req, "DescribeEnabledUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件配置项发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeFileConfigReleasesResponse"/></returns>
        public Task<DescribeFileConfigReleasesResponse> DescribeFileConfigReleases(DescribeFileConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribeFileConfigReleasesResponse>(req, "DescribeFileConfigReleases");
        }

        /// <summary>
        /// 查询文件配置项发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribeFileConfigReleasesResponse"/></returns>
        public DescribeFileConfigReleasesResponse DescribeFileConfigReleasesSync(DescribeFileConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribeFileConfigReleasesResponse>(req, "DescribeFileConfigReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigsRequest"/></param>
        /// <returns><see cref="DescribeFileConfigsResponse"/></returns>
        public Task<DescribeFileConfigsResponse> DescribeFileConfigs(DescribeFileConfigsRequest req)
        {
            return InternalRequestAsync<DescribeFileConfigsResponse>(req, "DescribeFileConfigs");
        }

        /// <summary>
        /// 查询文件配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileConfigsRequest"/></param>
        /// <returns><see cref="DescribeFileConfigsResponse"/></returns>
        public DescribeFileConfigsResponse DescribeFileConfigsSync(DescribeFileConfigsRequest req)
        {
            return InternalRequestAsync<DescribeFileConfigsResponse>(req, "DescribeFileConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流最新一个批次的状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLastBatchStateRequest"/></param>
        /// <returns><see cref="DescribeFlowLastBatchStateResponse"/></returns>
        public Task<DescribeFlowLastBatchStateResponse> DescribeFlowLastBatchState(DescribeFlowLastBatchStateRequest req)
        {
            return InternalRequestAsync<DescribeFlowLastBatchStateResponse>(req, "DescribeFlowLastBatchState");
        }

        /// <summary>
        /// 查询工作流最新一个批次的状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLastBatchStateRequest"/></param>
        /// <returns><see cref="DescribeFlowLastBatchStateResponse"/></returns>
        public DescribeFlowLastBatchStateResponse DescribeFlowLastBatchStateSync(DescribeFlowLastBatchStateRequest req)
        {
            return InternalRequestAsync<DescribeFlowLastBatchStateResponse>(req, "DescribeFlowLastBatchState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关所有分组下Api列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAllGroupApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayAllGroupApisResponse"/></returns>
        public Task<DescribeGatewayAllGroupApisResponse> DescribeGatewayAllGroupApis(DescribeGatewayAllGroupApisRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAllGroupApisResponse>(req, "DescribeGatewayAllGroupApis");
        }

        /// <summary>
        /// 查询网关所有分组下Api列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAllGroupApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayAllGroupApisResponse"/></returns>
        public DescribeGatewayAllGroupApisResponse DescribeGatewayAllGroupApisSync(DescribeGatewayAllGroupApisRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAllGroupApisResponse>(req, "DescribeGatewayAllGroupApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询API分组下的Api列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayApisResponse"/></returns>
        public Task<DescribeGatewayApisResponse> DescribeGatewayApis(DescribeGatewayApisRequest req)
        {
            return InternalRequestAsync<DescribeGatewayApisResponse>(req, "DescribeGatewayApis");
        }

        /// <summary>
        /// 查询API分组下的Api列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayApisRequest"/></param>
        /// <returns><see cref="DescribeGatewayApisResponse"/></returns>
        public DescribeGatewayApisResponse DescribeGatewayApisSync(DescribeGatewayApisRequest req)
        {
            return InternalRequestAsync<DescribeGatewayApisResponse>(req, "DescribeGatewayApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关监控概览
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorOverviewRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorOverviewResponse"/></returns>
        public Task<DescribeGatewayMonitorOverviewResponse> DescribeGatewayMonitorOverview(DescribeGatewayMonitorOverviewRequest req)
        {
            return InternalRequestAsync<DescribeGatewayMonitorOverviewResponse>(req, "DescribeGatewayMonitorOverview");
        }

        /// <summary>
        /// 查询网关监控概览
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorOverviewRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorOverviewResponse"/></returns>
        public DescribeGatewayMonitorOverviewResponse DescribeGatewayMonitorOverviewSync(DescribeGatewayMonitorOverviewRequest req)
        {
            return InternalRequestAsync<DescribeGatewayMonitorOverviewResponse>(req, "DescribeGatewayMonitorOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询虚拟机部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup");
        }

        /// <summary>
        /// 查询虚拟机部署组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取部署组其他属性
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAttributeRequest"/></param>
        /// <returns><see cref="DescribeGroupAttributeResponse"/></returns>
        public Task<DescribeGroupAttributeResponse> DescribeGroupAttribute(DescribeGroupAttributeRequest req)
        {
            return InternalRequestAsync<DescribeGroupAttributeResponse>(req, "DescribeGroupAttribute");
        }

        /// <summary>
        /// 获取部署组其他属性
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAttributeRequest"/></param>
        /// <returns><see cref="DescribeGroupAttributeResponse"/></returns>
        public DescribeGroupAttributeResponse DescribeGroupAttributeSync(DescribeGroupAttributeRequest req)
        {
            return InternalRequestAsync<DescribeGroupAttributeResponse>(req, "DescribeGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个API分组已绑定的网关部署组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBindedGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupBindedGatewaysResponse"/></returns>
        public Task<DescribeGroupBindedGatewaysResponse> DescribeGroupBindedGateways(DescribeGroupBindedGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeGroupBindedGatewaysResponse>(req, "DescribeGroupBindedGateways");
        }

        /// <summary>
        /// 查询某个API分组已绑定的网关部署组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBindedGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupBindedGatewaysResponse"/></returns>
        public DescribeGroupBindedGatewaysResponse DescribeGroupBindedGatewaysSync(DescribeGroupBindedGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeGroupBindedGatewaysResponse>(req, "DescribeGroupBindedGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分组管理日志配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBusinessLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeGroupBusinessLogConfigsResponse"/></returns>
        public Task<DescribeGroupBusinessLogConfigsResponse> DescribeGroupBusinessLogConfigs(DescribeGroupBusinessLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeGroupBusinessLogConfigsResponse>(req, "DescribeGroupBusinessLogConfigs");
        }

        /// <summary>
        /// 查询分组管理日志配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupBusinessLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeGroupBusinessLogConfigsResponse"/></returns>
        public DescribeGroupBusinessLogConfigsResponse DescribeGroupBusinessLogConfigsSync(DescribeGroupBusinessLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeGroupBusinessLogConfigsResponse>(req, "DescribeGroupBusinessLogConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个网关绑定的API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupGatewaysResponse"/></returns>
        public Task<DescribeGroupGatewaysResponse> DescribeGroupGateways(DescribeGroupGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeGroupGatewaysResponse>(req, "DescribeGroupGateways");
        }

        /// <summary>
        /// 查询某个网关绑定的API 分组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupGatewaysRequest"/></param>
        /// <returns><see cref="DescribeGroupGatewaysResponse"/></returns>
        public DescribeGroupGatewaysResponse DescribeGroupGatewaysSync(DescribeGroupGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeGroupGatewaysResponse>(req, "DescribeGroupGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeGroupInstancesResponse"/></returns>
        public Task<DescribeGroupInstancesResponse> DescribeGroupInstances(DescribeGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGroupInstancesResponse>(req, "DescribeGroupInstances");
        }

        /// <summary>
        /// 查询虚拟机部署组云主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeGroupInstancesResponse"/></returns>
        public DescribeGroupInstancesResponse DescribeGroupInstancesSync(DescribeGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGroupInstancesResponse>(req, "DescribeGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询部署组相关的发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupReleaseRequest"/></param>
        /// <returns><see cref="DescribeGroupReleaseResponse"/></returns>
        public Task<DescribeGroupReleaseResponse> DescribeGroupRelease(DescribeGroupReleaseRequest req)
        {
            return InternalRequestAsync<DescribeGroupReleaseResponse>(req, "DescribeGroupRelease");
        }

        /// <summary>
        /// 查询部署组相关的发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupReleaseRequest"/></param>
        /// <returns><see cref="DescribeGroupReleaseResponse"/></returns>
        public DescribeGroupReleaseResponse DescribeGroupReleaseSync(DescribeGroupReleaseRequest req)
        {
            return InternalRequestAsync<DescribeGroupReleaseResponse>(req, "DescribeGroupRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关分组监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupUseDetailRequest"/></param>
        /// <returns><see cref="DescribeGroupUseDetailResponse"/></returns>
        public Task<DescribeGroupUseDetailResponse> DescribeGroupUseDetail(DescribeGroupUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeGroupUseDetailResponse>(req, "DescribeGroupUseDetail");
        }

        /// <summary>
        /// 查询网关分组监控明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupUseDetailRequest"/></param>
        /// <returns><see cref="DescribeGroupUseDetailResponse"/></returns>
        public DescribeGroupUseDetailResponse DescribeGroupUseDetailSync(DescribeGroupUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeGroupUseDetailResponse>(req, "DescribeGroupUseDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取虚拟机部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public Task<DescribeGroupsResponse> DescribeGroups(DescribeGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGroupsResponse>(req, "DescribeGroups");
        }

        /// <summary>
        /// 获取虚拟机部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public DescribeGroupsResponse DescribeGroupsSync(DescribeGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGroupsResponse>(req, "DescribeGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个插件下绑定或未绑定的API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsWithPluginRequest"/></param>
        /// <returns><see cref="DescribeGroupsWithPluginResponse"/></returns>
        public Task<DescribeGroupsWithPluginResponse> DescribeGroupsWithPlugin(DescribeGroupsWithPluginRequest req)
        {
            return InternalRequestAsync<DescribeGroupsWithPluginResponse>(req, "DescribeGroupsWithPlugin");
        }

        /// <summary>
        /// 查询某个插件下绑定或未绑定的API分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsWithPluginRequest"/></param>
        /// <returns><see cref="DescribeGroupsWithPluginResponse"/></returns>
        public DescribeGroupsWithPluginResponse DescribeGroupsWithPluginSync(DescribeGroupsWithPluginRequest req)
        {
            return InternalRequestAsync<DescribeGroupsWithPluginResponse>(req, "DescribeGroupsWithPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRepositoryRequest"/></param>
        /// <returns><see cref="DescribeImageRepositoryResponse"/></returns>
        public Task<DescribeImageRepositoryResponse> DescribeImageRepository(DescribeImageRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeImageRepositoryResponse>(req, "DescribeImageRepository");
        }

        /// <summary>
        /// 查询镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRepositoryRequest"/></param>
        /// <returns><see cref="DescribeImageRepositoryResponse"/></returns>
        public DescribeImageRepositoryResponse DescribeImageRepositorySync(DescribeImageRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeImageRepositoryResponse>(req, "DescribeImageRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTagsRequest"/></param>
        /// <returns><see cref="DescribeImageTagsResponse"/></returns>
        public Task<DescribeImageTagsResponse> DescribeImageTags(DescribeImageTagsRequest req)
        {
            return InternalRequestAsync<DescribeImageTagsResponse>(req, "DescribeImageTags");
        }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTagsRequest"/></param>
        /// <returns><see cref="DescribeImageTagsResponse"/></returns>
        public DescribeImageTagsResponse DescribeImageTagsSync(DescribeImageTagsRequest req)
        {
            return InternalRequestAsync<DescribeImageTagsResponse>(req, "DescribeImageTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 废弃
        /// </summary>
        /// <param name="req"><see cref="DescribeInovcationIndicatorsRequest"/></param>
        /// <returns><see cref="DescribeInovcationIndicatorsResponse"/></returns>
        public Task<DescribeInovcationIndicatorsResponse> DescribeInovcationIndicators(DescribeInovcationIndicatorsRequest req)
        {
            return InternalRequestAsync<DescribeInovcationIndicatorsResponse>(req, "DescribeInovcationIndicators");
        }

        /// <summary>
        /// 废弃
        /// </summary>
        /// <param name="req"><see cref="DescribeInovcationIndicatorsRequest"/></param>
        /// <returns><see cref="DescribeInovcationIndicatorsResponse"/></returns>
        public DescribeInovcationIndicatorsResponse DescribeInovcationIndicatorsSync(DescribeInovcationIndicatorsRequest req)
        {
            return InternalRequestAsync<DescribeInovcationIndicatorsResponse>(req, "DescribeInovcationIndicators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询调用指标数据变化曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataCurveRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataCurveResponse"/></returns>
        public Task<DescribeInvocationMetricDataCurveResponse> DescribeInvocationMetricDataCurve(DescribeInvocationMetricDataCurveRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataCurveResponse>(req, "DescribeInvocationMetricDataCurve");
        }

        /// <summary>
        /// 查询调用指标数据变化曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataCurveRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataCurveResponse"/></returns>
        public DescribeInvocationMetricDataCurveResponse DescribeInvocationMetricDataCurveSync(DescribeInvocationMetricDataCurveRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataCurveResponse>(req, "DescribeInvocationMetricDataCurve")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询维度
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataDimensionRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataDimensionResponse"/></returns>
        public Task<DescribeInvocationMetricDataDimensionResponse> DescribeInvocationMetricDataDimension(DescribeInvocationMetricDataDimensionRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataDimensionResponse>(req, "DescribeInvocationMetricDataDimension");
        }

        /// <summary>
        /// 查询维度
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataDimensionRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataDimensionResponse"/></returns>
        public DescribeInvocationMetricDataDimensionResponse DescribeInvocationMetricDataDimensionSync(DescribeInvocationMetricDataDimensionRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataDimensionResponse>(req, "DescribeInvocationMetricDataDimension")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单值指标维度
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataPointRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataPointResponse"/></returns>
        public Task<DescribeInvocationMetricDataPointResponse> DescribeInvocationMetricDataPoint(DescribeInvocationMetricDataPointRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataPointResponse>(req, "DescribeInvocationMetricDataPoint");
        }

        /// <summary>
        /// 查询单值指标维度
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricDataPointRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricDataPointResponse"/></returns>
        public DescribeInvocationMetricDataPointResponse DescribeInvocationMetricDataPointSync(DescribeInvocationMetricDataPointRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricDataPointResponse>(req, "DescribeInvocationMetricDataPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询调用指标数据散点图
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricScatterPlotRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricScatterPlotResponse"/></returns>
        public Task<DescribeInvocationMetricScatterPlotResponse> DescribeInvocationMetricScatterPlot(DescribeInvocationMetricScatterPlotRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricScatterPlotResponse>(req, "DescribeInvocationMetricScatterPlot");
        }

        /// <summary>
        /// 查询调用指标数据散点图
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationMetricScatterPlotRequest"/></param>
        /// <returns><see cref="DescribeInvocationMetricScatterPlotResponse"/></returns>
        public DescribeInvocationMetricScatterPlotResponse DescribeInvocationMetricScatterPlotSync(DescribeInvocationMetricScatterPlotRequest req)
        {
            return InternalRequestAsync<DescribeInvocationMetricScatterPlotResponse>(req, "DescribeInvocationMetricScatterPlot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询java实例jvm监控数据,返回数据可选
        /// </summary>
        /// <param name="req"><see cref="DescribeJvmMonitorRequest"/></param>
        /// <returns><see cref="DescribeJvmMonitorResponse"/></returns>
        public Task<DescribeJvmMonitorResponse> DescribeJvmMonitor(DescribeJvmMonitorRequest req)
        {
            return InternalRequestAsync<DescribeJvmMonitorResponse>(req, "DescribeJvmMonitor");
        }

        /// <summary>
        /// 查询java实例jvm监控数据,返回数据可选
        /// </summary>
        /// <param name="req"><see cref="DescribeJvmMonitorRequest"/></param>
        /// <returns><see cref="DescribeJvmMonitorResponse"/></returns>
        public DescribeJvmMonitorResponse DescribeJvmMonitorSync(DescribeJvmMonitorRequest req)
        {
            return InternalRequestAsync<DescribeJvmMonitorResponse>(req, "DescribeJvmMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询泳道规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLaneRulesRequest"/></param>
        /// <returns><see cref="DescribeLaneRulesResponse"/></returns>
        public Task<DescribeLaneRulesResponse> DescribeLaneRules(DescribeLaneRulesRequest req)
        {
            return InternalRequestAsync<DescribeLaneRulesResponse>(req, "DescribeLaneRules");
        }

        /// <summary>
        /// 查询泳道规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLaneRulesRequest"/></param>
        /// <returns><see cref="DescribeLaneRulesResponse"/></returns>
        public DescribeLaneRulesResponse DescribeLaneRulesSync(DescribeLaneRulesRequest req)
        {
            return InternalRequestAsync<DescribeLaneRulesResponse>(req, "DescribeLaneRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询泳道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLanesRequest"/></param>
        /// <returns><see cref="DescribeLanesResponse"/></returns>
        public Task<DescribeLanesResponse> DescribeLanes(DescribeLanesRequest req)
        {
            return InternalRequestAsync<DescribeLanesResponse>(req, "DescribeLanes");
        }

        /// <summary>
        /// 查询泳道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLanesRequest"/></param>
        /// <returns><see cref="DescribeLanesResponse"/></returns>
        public DescribeLanesResponse DescribeLanesSync(DescribeLanesRequest req)
        {
            return InternalRequestAsync<DescribeLanesResponse>(req, "DescribeLanes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroserviceRequest"/></param>
        /// <returns><see cref="DescribeMicroserviceResponse"/></returns>
        public Task<DescribeMicroserviceResponse> DescribeMicroservice(DescribeMicroserviceRequest req)
        {
            return InternalRequestAsync<DescribeMicroserviceResponse>(req, "DescribeMicroservice");
        }

        /// <summary>
        /// 查询微服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroserviceRequest"/></param>
        /// <returns><see cref="DescribeMicroserviceResponse"/></returns>
        public DescribeMicroserviceResponse DescribeMicroserviceSync(DescribeMicroserviceRequest req)
        {
            return InternalRequestAsync<DescribeMicroserviceResponse>(req, "DescribeMicroservice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取微服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroservicesRequest"/></param>
        /// <returns><see cref="DescribeMicroservicesResponse"/></returns>
        public Task<DescribeMicroservicesResponse> DescribeMicroservices(DescribeMicroservicesRequest req)
        {
            return InternalRequestAsync<DescribeMicroservicesResponse>(req, "DescribeMicroservices");
        }

        /// <summary>
        /// 获取微服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMicroservicesRequest"/></param>
        /// <returns><see cref="DescribeMicroservicesResponse"/></returns>
        public DescribeMicroservicesResponse DescribeMicroservicesSync(DescribeMicroservicesRequest req)
        {
            return InternalRequestAsync<DescribeMicroservicesResponse>(req, "DescribeMicroservices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMsApiListRequest"/></param>
        /// <returns><see cref="DescribeMsApiListResponse"/></returns>
        public Task<DescribeMsApiListResponse> DescribeMsApiList(DescribeMsApiListRequest req)
        {
            return InternalRequestAsync<DescribeMsApiListResponse>(req, "DescribeMsApiList");
        }

        /// <summary>
        /// 查询服务API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMsApiListRequest"/></param>
        /// <returns><see cref="DescribeMsApiListResponse"/></returns>
        public DescribeMsApiListResponse DescribeMsApiListSync(DescribeMsApiListRequest req)
        {
            return InternalRequestAsync<DescribeMsApiListResponse>(req, "DescribeMsApiList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务调用监控统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewInvocationRequest"/></param>
        /// <returns><see cref="DescribeOverviewInvocationResponse"/></returns>
        public Task<DescribeOverviewInvocationResponse> DescribeOverviewInvocation(DescribeOverviewInvocationRequest req)
        {
            return InternalRequestAsync<DescribeOverviewInvocationResponse>(req, "DescribeOverviewInvocation");
        }

        /// <summary>
        /// 服务调用监控统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewInvocationRequest"/></param>
        /// <returns><see cref="DescribeOverviewInvocationResponse"/></returns>
        public DescribeOverviewInvocationResponse DescribeOverviewInvocationSync(DescribeOverviewInvocationRequest req)
        {
            return InternalRequestAsync<DescribeOverviewInvocationResponse>(req, "DescribeOverviewInvocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询路径重写
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewriteRequest"/></param>
        /// <returns><see cref="DescribePathRewriteResponse"/></returns>
        public Task<DescribePathRewriteResponse> DescribePathRewrite(DescribePathRewriteRequest req)
        {
            return InternalRequestAsync<DescribePathRewriteResponse>(req, "DescribePathRewrite");
        }

        /// <summary>
        /// 查询路径重写
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewriteRequest"/></param>
        /// <returns><see cref="DescribePathRewriteResponse"/></returns>
        public DescribePathRewriteResponse DescribePathRewriteSync(DescribePathRewriteRequest req)
        {
            return InternalRequestAsync<DescribePathRewriteResponse>(req, "DescribePathRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询路径重写列表
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewritesRequest"/></param>
        /// <returns><see cref="DescribePathRewritesResponse"/></returns>
        public Task<DescribePathRewritesResponse> DescribePathRewrites(DescribePathRewritesRequest req)
        {
            return InternalRequestAsync<DescribePathRewritesResponse>(req, "DescribePathRewrites");
        }

        /// <summary>
        /// 查询路径重写列表
        /// </summary>
        /// <param name="req"><see cref="DescribePathRewritesRequest"/></param>
        /// <returns><see cref="DescribePathRewritesResponse"/></returns>
        public DescribePathRewritesResponse DescribePathRewritesSync(DescribePathRewritesRequest req)
        {
            return InternalRequestAsync<DescribePathRewritesResponse>(req, "DescribePathRewrites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribePkgsRequest"/></param>
        /// <returns><see cref="DescribePkgsResponse"/></returns>
        public Task<DescribePkgsResponse> DescribePkgs(DescribePkgsRequest req)
        {
            return InternalRequestAsync<DescribePkgsResponse>(req, "DescribePkgs");
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="DescribePkgsRequest"/></param>
        /// <returns><see cref="DescribePkgsResponse"/></returns>
        public DescribePkgsResponse DescribePkgsSync(DescribePkgsRequest req)
        {
            return InternalRequestAsync<DescribePkgsResponse>(req, "DescribePkgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询网关分组/API绑定（或未绑定）的插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginInstancesRequest"/></param>
        /// <returns><see cref="DescribePluginInstancesResponse"/></returns>
        public Task<DescribePluginInstancesResponse> DescribePluginInstances(DescribePluginInstancesRequest req)
        {
            return InternalRequestAsync<DescribePluginInstancesResponse>(req, "DescribePluginInstances");
        }

        /// <summary>
        /// 分页查询网关分组/API绑定（或未绑定）的插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginInstancesRequest"/></param>
        /// <returns><see cref="DescribePluginInstancesResponse"/></returns>
        public DescribePluginInstancesResponse DescribePluginInstancesSync(DescribePluginInstancesRequest req)
        {
            return InternalRequestAsync<DescribePluginInstancesResponse>(req, "DescribePluginInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取部署组实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodInstancesRequest"/></param>
        /// <returns><see cref="DescribePodInstancesResponse"/></returns>
        public Task<DescribePodInstancesResponse> DescribePodInstances(DescribePodInstancesRequest req)
        {
            return InternalRequestAsync<DescribePodInstancesResponse>(req, "DescribePodInstances");
        }

        /// <summary>
        /// 获取部署组实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodInstancesRequest"/></param>
        /// <returns><see cref="DescribePodInstancesResponse"/></returns>
        public DescribePodInstancesResponse DescribePodInstancesSync(DescribePodInstancesRequest req)
        {
            return InternalRequestAsync<DescribePodInstancesResponse>(req, "DescribePodInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProgramsRequest"/></param>
        /// <returns><see cref="DescribeProgramsResponse"/></returns>
        public Task<DescribeProgramsResponse> DescribePrograms(DescribeProgramsRequest req)
        {
            return InternalRequestAsync<DescribeProgramsResponse>(req, "DescribePrograms");
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProgramsRequest"/></param>
        /// <returns><see cref="DescribeProgramsResponse"/></returns>
        public DescribeProgramsResponse DescribeProgramsSync(DescribeProgramsRequest req)
        {
            return InternalRequestAsync<DescribeProgramsResponse>(req, "DescribePrograms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公共配置（单条）
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigRequest"/></param>
        /// <returns><see cref="DescribePublicConfigResponse"/></returns>
        public Task<DescribePublicConfigResponse> DescribePublicConfig(DescribePublicConfigRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigResponse>(req, "DescribePublicConfig");
        }

        /// <summary>
        /// 查询公共配置（单条）
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigRequest"/></param>
        /// <returns><see cref="DescribePublicConfigResponse"/></returns>
        public DescribePublicConfigResponse DescribePublicConfigSync(DescribePublicConfigRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigResponse>(req, "DescribePublicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公共配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleaseLogsResponse"/></returns>
        public Task<DescribePublicConfigReleaseLogsResponse> DescribePublicConfigReleaseLogs(DescribePublicConfigReleaseLogsRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigReleaseLogsResponse>(req, "DescribePublicConfigReleaseLogs");
        }

        /// <summary>
        /// 查询公共配置发布历史
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleaseLogsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleaseLogsResponse"/></returns>
        public DescribePublicConfigReleaseLogsResponse DescribePublicConfigReleaseLogsSync(DescribePublicConfigReleaseLogsRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigReleaseLogsResponse>(req, "DescribePublicConfigReleaseLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公共配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleasesResponse"/></returns>
        public Task<DescribePublicConfigReleasesResponse> DescribePublicConfigReleases(DescribePublicConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigReleasesResponse>(req, "DescribePublicConfigReleases");
        }

        /// <summary>
        /// 查询公共配置发布信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigReleasesRequest"/></param>
        /// <returns><see cref="DescribePublicConfigReleasesResponse"/></returns>
        public DescribePublicConfigReleasesResponse DescribePublicConfigReleasesSync(DescribePublicConfigReleasesRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigReleasesResponse>(req, "DescribePublicConfigReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公共配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribePublicConfigSummaryResponse"/></returns>
        public Task<DescribePublicConfigSummaryResponse> DescribePublicConfigSummary(DescribePublicConfigSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigSummaryResponse>(req, "DescribePublicConfigSummary");
        }

        /// <summary>
        /// 查询公共配置汇总列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigSummaryRequest"/></param>
        /// <returns><see cref="DescribePublicConfigSummaryResponse"/></returns>
        public DescribePublicConfigSummaryResponse DescribePublicConfigSummarySync(DescribePublicConfigSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigSummaryResponse>(req, "DescribePublicConfigSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公共配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigsResponse"/></returns>
        public Task<DescribePublicConfigsResponse> DescribePublicConfigs(DescribePublicConfigsRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigsResponse>(req, "DescribePublicConfigs");
        }

        /// <summary>
        /// 查询公共配置项列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicConfigsRequest"/></param>
        /// <returns><see cref="DescribePublicConfigsResponse"/></returns>
        public DescribePublicConfigsResponse DescribePublicConfigsSync(DescribePublicConfigsRequest req)
        {
            return InternalRequestAsync<DescribePublicConfigsResponse>(req, "DescribePublicConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询group发布的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReleasedConfigRequest"/></param>
        /// <returns><see cref="DescribeReleasedConfigResponse"/></returns>
        public Task<DescribeReleasedConfigResponse> DescribeReleasedConfig(DescribeReleasedConfigRequest req)
        {
            return InternalRequestAsync<DescribeReleasedConfigResponse>(req, "DescribeReleasedConfig");
        }

        /// <summary>
        /// 查询group发布的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReleasedConfigRequest"/></param>
        /// <returns><see cref="DescribeReleasedConfigResponse"/></returns>
        public DescribeReleasedConfigResponse DescribeReleasedConfigSync(DescribeReleasedConfigRequest req)
        {
            return InternalRequestAsync<DescribeReleasedConfigResponse>(req, "DescribeReleasedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public Task<DescribeRepositoriesResponse> DescribeRepositories(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories");
        }

        /// <summary>
        /// 查询仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeRepositoriesResponse"/></returns>
        public DescribeRepositoriesResponse DescribeRepositoriesSync(DescribeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeRepositoriesResponse>(req, "DescribeRepositories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeRepositoryResponse"/></returns>
        public Task<DescribeRepositoryResponse> DescribeRepository(DescribeRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryResponse>(req, "DescribeRepository");
        }

        /// <summary>
        /// 查询仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeRepositoryResponse"/></returns>
        public DescribeRepositoryResponse DescribeRepositorySync(DescribeRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryResponse>(req, "DescribeRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源任务的执行状态描述接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeResourceTaskStatusResponse"/></returns>
        public Task<DescribeResourceTaskStatusResponse> DescribeResourceTaskStatus(DescribeResourceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeResourceTaskStatusResponse>(req, "DescribeResourceTaskStatus");
        }

        /// <summary>
        /// 资源任务的执行状态描述接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeResourceTaskStatusResponse"/></returns>
        public DescribeResourceTaskStatusResponse DescribeResourceTaskStatusSync(DescribeResourceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeResourceTaskStatusResponse>(req, "DescribeResourceTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询简单应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationsResponse"/></returns>
        public Task<DescribeSimpleApplicationsResponse> DescribeSimpleApplications(DescribeSimpleApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeSimpleApplicationsResponse>(req, "DescribeSimpleApplications");
        }

        /// <summary>
        /// 查询简单应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationsRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationsResponse"/></returns>
        public DescribeSimpleApplicationsResponse DescribeSimpleApplicationsSync(DescribeSimpleApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeSimpleApplicationsResponse>(req, "DescribeSimpleApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询简单集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns><see cref="DescribeSimpleClustersResponse"/></returns>
        public Task<DescribeSimpleClustersResponse> DescribeSimpleClusters(DescribeSimpleClustersRequest req)
        {
            return InternalRequestAsync<DescribeSimpleClustersResponse>(req, "DescribeSimpleClusters");
        }

        /// <summary>
        /// 查询简单集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleClustersRequest"/></param>
        /// <returns><see cref="DescribeSimpleClustersResponse"/></returns>
        public DescribeSimpleClustersResponse DescribeSimpleClustersSync(DescribeSimpleClustersRequest req)
        {
            return InternalRequestAsync<DescribeSimpleClustersResponse>(req, "DescribeSimpleClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询简单部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns><see cref="DescribeSimpleGroupsResponse"/></returns>
        public Task<DescribeSimpleGroupsResponse> DescribeSimpleGroups(DescribeSimpleGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSimpleGroupsResponse>(req, "DescribeSimpleGroups");
        }

        /// <summary>
        /// 查询简单部署组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleGroupsRequest"/></param>
        /// <returns><see cref="DescribeSimpleGroupsResponse"/></returns>
        public DescribeSimpleGroupsResponse DescribeSimpleGroupsSync(DescribeSimpleGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSimpleGroupsResponse>(req, "DescribeSimpleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询简单命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns><see cref="DescribeSimpleNamespacesResponse"/></returns>
        public Task<DescribeSimpleNamespacesResponse> DescribeSimpleNamespaces(DescribeSimpleNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleNamespacesResponse>(req, "DescribeSimpleNamespaces");
        }

        /// <summary>
        /// 查询简单命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleNamespacesRequest"/></param>
        /// <returns><see cref="DescribeSimpleNamespacesResponse"/></returns>
        public DescribeSimpleNamespacesResponse DescribeSimpleNamespacesSync(DescribeSimpleNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleNamespacesResponse>(req, "DescribeSimpleNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务统计页面：接口和服务维度
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStatisticsResponse"/></returns>
        public Task<DescribeStatisticsResponse> DescribeStatistics(DescribeStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticsResponse>(req, "DescribeStatistics");
        }

        /// <summary>
        /// 服务统计页面：接口和服务维度
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStatisticsResponse"/></returns>
        public DescribeStatisticsResponse DescribeStatisticsSync(DescribeStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticsResponse>(req, "DescribeStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务最近一次执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLastStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLastStatusResponse"/></returns>
        public Task<DescribeTaskLastStatusResponse> DescribeTaskLastStatus(DescribeTaskLastStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLastStatusResponse>(req, "DescribeTaskLastStatus");
        }

        /// <summary>
        /// 查询任务最近一次执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLastStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLastStatusResponse"/></returns>
        public DescribeTaskLastStatusResponse DescribeTaskLastStatusSync(DescribeTaskLastStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLastStatusResponse>(req, "DescribeTaskLastStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 翻页查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRecordsRequest"/></param>
        /// <returns><see cref="DescribeTaskRecordsResponse"/></returns>
        public Task<DescribeTaskRecordsResponse> DescribeTaskRecords(DescribeTaskRecordsRequest req)
        {
            return InternalRequestAsync<DescribeTaskRecordsResponse>(req, "DescribeTaskRecords");
        }

        /// <summary>
        /// 翻页查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRecordsRequest"/></param>
        /// <returns><see cref="DescribeTaskRecordsResponse"/></returns>
        public DescribeTaskRecordsResponse DescribeTaskRecordsSync(DescribeTaskRecordsRequest req)
        {
            return InternalRequestAsync<DescribeTaskRecordsResponse>(req, "DescribeTaskRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关API监控明细数据（仅单元化网关），非单元化网关使用DescribeApiUseDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeUnitApiUseDetailResponse"/></returns>
        public Task<DescribeUnitApiUseDetailResponse> DescribeUnitApiUseDetail(DescribeUnitApiUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeUnitApiUseDetailResponse>(req, "DescribeUnitApiUseDetail");
        }

        /// <summary>
        /// 查询网关API监控明细数据（仅单元化网关），非单元化网关使用DescribeApiUseDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitApiUseDetailRequest"/></param>
        /// <returns><see cref="DescribeUnitApiUseDetailResponse"/></returns>
        public DescribeUnitApiUseDetailResponse DescribeUnitApiUseDetailSync(DescribeUnitApiUseDetailRequest req)
        {
            return InternalRequestAsync<DescribeUnitApiUseDetailResponse>(req, "DescribeUnitApiUseDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单元化命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUnitNamespacesResponse"/></returns>
        public Task<DescribeUnitNamespacesResponse> DescribeUnitNamespaces(DescribeUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeUnitNamespacesResponse>(req, "DescribeUnitNamespaces");
        }

        /// <summary>
        /// 查询单元化命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUnitNamespacesResponse"/></returns>
        public DescribeUnitNamespacesResponse DescribeUnitNamespacesSync(DescribeUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeUnitNamespacesResponse>(req, "DescribeUnitNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单元化规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeUnitRuleResponse"/></returns>
        public Task<DescribeUnitRuleResponse> DescribeUnitRule(DescribeUnitRuleRequest req)
        {
            return InternalRequestAsync<DescribeUnitRuleResponse>(req, "DescribeUnitRule");
        }

        /// <summary>
        /// 查询单元化规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRuleRequest"/></param>
        /// <returns><see cref="DescribeUnitRuleResponse"/></returns>
        public DescribeUnitRuleResponse DescribeUnitRuleSync(DescribeUnitRuleRequest req)
        {
            return InternalRequestAsync<DescribeUnitRuleResponse>(req, "DescribeUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单元化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesRequest"/></param>
        /// <returns><see cref="DescribeUnitRulesResponse"/></returns>
        public Task<DescribeUnitRulesResponse> DescribeUnitRules(DescribeUnitRulesRequest req)
        {
            return InternalRequestAsync<DescribeUnitRulesResponse>(req, "DescribeUnitRules");
        }

        /// <summary>
        /// 查询单元化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesRequest"/></param>
        /// <returns><see cref="DescribeUnitRulesResponse"/></returns>
        public DescribeUnitRulesResponse DescribeUnitRulesSync(DescribeUnitRulesRequest req)
        {
            return InternalRequestAsync<DescribeUnitRulesResponse>(req, "DescribeUnitRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单元化规则列表V2
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesV2Request"/></param>
        /// <returns><see cref="DescribeUnitRulesV2Response"/></returns>
        public Task<DescribeUnitRulesV2Response> DescribeUnitRulesV2(DescribeUnitRulesV2Request req)
        {
            return InternalRequestAsync<DescribeUnitRulesV2Response>(req, "DescribeUnitRulesV2");
        }

        /// <summary>
        /// 查询单元化规则列表V2
        /// </summary>
        /// <param name="req"><see cref="DescribeUnitRulesV2Request"/></param>
        /// <returns><see cref="DescribeUnitRulesV2Response"/></returns>
        public DescribeUnitRulesV2Response DescribeUnitRulesV2Sync(DescribeUnitRulesV2Request req)
        {
            return InternalRequestAsync<DescribeUnitRulesV2Response>(req, "DescribeUnitRulesV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadInfoResponse"/></returns>
        public Task<DescribeUploadInfoResponse> DescribeUploadInfo(DescribeUploadInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadInfoResponse>(req, "DescribeUploadInfo");
        }

        /// <summary>
        /// TSF会将软件包上传到腾讯云对象存储（COS）。调用此接口获取上传信息，如目标地域，桶，包Id，存储路径，鉴权信息等，之后请使用COS API（或SDK）进行上传。
        /// COS相关文档请查阅：https://cloud.tencent.com/document/product/436
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadInfoResponse"/></returns>
        public DescribeUploadInfoResponse DescribeUploadInfoSync(DescribeUploadInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadInfoResponse>(req, "DescribeUploadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可用于被导入的命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsableUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUsableUnitNamespacesResponse"/></returns>
        public Task<DescribeUsableUnitNamespacesResponse> DescribeUsableUnitNamespaces(DescribeUsableUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeUsableUnitNamespacesResponse>(req, "DescribeUsableUnitNamespaces");
        }

        /// <summary>
        /// 查询可用于被导入的命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsableUnitNamespacesRequest"/></param>
        /// <returns><see cref="DescribeUsableUnitNamespacesResponse"/></returns>
        public DescribeUsableUnitNamespacesResponse DescribeUsableUnitNamespacesSync(DescribeUsableUnitNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeUsableUnitNamespacesResponse>(req, "DescribeUsableUnitNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用泳道规则
        /// </summary>
        /// <param name="req"><see cref="DisableLaneRuleRequest"/></param>
        /// <returns><see cref="DisableLaneRuleResponse"/></returns>
        public Task<DisableLaneRuleResponse> DisableLaneRule(DisableLaneRuleRequest req)
        {
            return InternalRequestAsync<DisableLaneRuleResponse>(req, "DisableLaneRule");
        }

        /// <summary>
        /// 禁用泳道规则
        /// </summary>
        /// <param name="req"><see cref="DisableLaneRuleRequest"/></param>
        /// <returns><see cref="DisableLaneRuleResponse"/></returns>
        public DisableLaneRuleResponse DisableLaneRuleSync(DisableLaneRuleRequest req)
        {
            return InternalRequestAsync<DisableLaneRuleResponse>(req, "DisableLaneRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停用任务
        /// </summary>
        /// <param name="req"><see cref="DisableTaskRequest"/></param>
        /// <returns><see cref="DisableTaskResponse"/></returns>
        public Task<DisableTaskResponse> DisableTask(DisableTaskRequest req)
        {
            return InternalRequestAsync<DisableTaskResponse>(req, "DisableTask");
        }

        /// <summary>
        /// 停用任务
        /// </summary>
        /// <param name="req"><see cref="DisableTaskRequest"/></param>
        /// <returns><see cref="DisableTaskResponse"/></returns>
        public DisableTaskResponse DisableTaskSync(DisableTaskRequest req)
        {
            return InternalRequestAsync<DisableTaskResponse>(req, "DisableTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停用工作流
        /// </summary>
        /// <param name="req"><see cref="DisableTaskFlowRequest"/></param>
        /// <returns><see cref="DisableTaskFlowResponse"/></returns>
        public Task<DisableTaskFlowResponse> DisableTaskFlow(DisableTaskFlowRequest req)
        {
            return InternalRequestAsync<DisableTaskFlowResponse>(req, "DisableTaskFlow");
        }

        /// <summary>
        /// 停用工作流
        /// </summary>
        /// <param name="req"><see cref="DisableTaskFlowRequest"/></param>
        /// <returns><see cref="DisableTaskFlowResponse"/></returns>
        public DisableTaskFlowResponse DisableTaskFlowSync(DisableTaskFlowRequest req)
        {
            return InternalRequestAsync<DisableTaskFlowResponse>(req, "DisableTaskFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用单元化路由
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRouteRequest"/></param>
        /// <returns><see cref="DisableUnitRouteResponse"/></returns>
        public Task<DisableUnitRouteResponse> DisableUnitRoute(DisableUnitRouteRequest req)
        {
            return InternalRequestAsync<DisableUnitRouteResponse>(req, "DisableUnitRoute");
        }

        /// <summary>
        /// 禁用单元化路由
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRouteRequest"/></param>
        /// <returns><see cref="DisableUnitRouteResponse"/></returns>
        public DisableUnitRouteResponse DisableUnitRouteSync(DisableUnitRouteRequest req)
        {
            return InternalRequestAsync<DisableUnitRouteResponse>(req, "DisableUnitRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用单元化规则
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRuleRequest"/></param>
        /// <returns><see cref="DisableUnitRuleResponse"/></returns>
        public Task<DisableUnitRuleResponse> DisableUnitRule(DisableUnitRuleRequest req)
        {
            return InternalRequestAsync<DisableUnitRuleResponse>(req, "DisableUnitRule");
        }

        /// <summary>
        /// 禁用单元化规则
        /// </summary>
        /// <param name="req"><see cref="DisableUnitRuleRequest"/></param>
        /// <returns><see cref="DisableUnitRuleResponse"/></returns>
        public DisableUnitRuleResponse DisableUnitRuleSync(DisableUnitRuleRequest req)
        {
            return InternalRequestAsync<DisableUnitRuleResponse>(req, "DisableUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消关联业务日志配置项和应用
        /// </summary>
        /// <param name="req"><see cref="DisassociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DisassociateBusinessLogConfigResponse"/></returns>
        public Task<DisassociateBusinessLogConfigResponse> DisassociateBusinessLogConfig(DisassociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DisassociateBusinessLogConfigResponse>(req, "DisassociateBusinessLogConfig");
        }

        /// <summary>
        /// 取消关联业务日志配置项和应用
        /// </summary>
        /// <param name="req"><see cref="DisassociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="DisassociateBusinessLogConfigResponse"/></returns>
        public DisassociateBusinessLogConfigResponse DisassociateBusinessLogConfigSync(DisassociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<DisassociateBusinessLogConfigResponse>(req, "DisassociateBusinessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消关联投递信息和部署组
        /// </summary>
        /// <param name="req"><see cref="DisassociateKafkaConfigRequest"/></param>
        /// <returns><see cref="DisassociateKafkaConfigResponse"/></returns>
        public Task<DisassociateKafkaConfigResponse> DisassociateKafkaConfig(DisassociateKafkaConfigRequest req)
        {
            return InternalRequestAsync<DisassociateKafkaConfigResponse>(req, "DisassociateKafkaConfig");
        }

        /// <summary>
        /// 取消关联投递信息和部署组
        /// </summary>
        /// <param name="req"><see cref="DisassociateKafkaConfigRequest"/></param>
        /// <returns><see cref="DisassociateKafkaConfigResponse"/></returns>
        public DisassociateKafkaConfigResponse DisassociateKafkaConfigSync(DisassociateKafkaConfigRequest req)
        {
            return InternalRequestAsync<DisassociateKafkaConfigResponse>(req, "DisassociateKafkaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下线Api分组
        /// </summary>
        /// <param name="req"><see cref="DraftApiGroupRequest"/></param>
        /// <returns><see cref="DraftApiGroupResponse"/></returns>
        public Task<DraftApiGroupResponse> DraftApiGroup(DraftApiGroupRequest req)
        {
            return InternalRequestAsync<DraftApiGroupResponse>(req, "DraftApiGroup");
        }

        /// <summary>
        /// 下线Api分组
        /// </summary>
        /// <param name="req"><see cref="DraftApiGroupRequest"/></param>
        /// <returns><see cref="DraftApiGroupResponse"/></returns>
        public DraftApiGroupResponse DraftApiGroupSync(DraftApiGroupRequest req)
        {
            return InternalRequestAsync<DraftApiGroupResponse>(req, "DraftApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用泳道规则
        /// </summary>
        /// <param name="req"><see cref="EnableLaneRuleRequest"/></param>
        /// <returns><see cref="EnableLaneRuleResponse"/></returns>
        public Task<EnableLaneRuleResponse> EnableLaneRule(EnableLaneRuleRequest req)
        {
            return InternalRequestAsync<EnableLaneRuleResponse>(req, "EnableLaneRule");
        }

        /// <summary>
        /// 启用泳道规则
        /// </summary>
        /// <param name="req"><see cref="EnableLaneRuleRequest"/></param>
        /// <returns><see cref="EnableLaneRuleResponse"/></returns>
        public EnableLaneRuleResponse EnableLaneRuleSync(EnableLaneRuleRequest req)
        {
            return InternalRequestAsync<EnableLaneRuleResponse>(req, "EnableLaneRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用任务
        /// </summary>
        /// <param name="req"><see cref="EnableTaskRequest"/></param>
        /// <returns><see cref="EnableTaskResponse"/></returns>
        public Task<EnableTaskResponse> EnableTask(EnableTaskRequest req)
        {
            return InternalRequestAsync<EnableTaskResponse>(req, "EnableTask");
        }

        /// <summary>
        /// 启用任务
        /// </summary>
        /// <param name="req"><see cref="EnableTaskRequest"/></param>
        /// <returns><see cref="EnableTaskResponse"/></returns>
        public EnableTaskResponse EnableTaskSync(EnableTaskRequest req)
        {
            return InternalRequestAsync<EnableTaskResponse>(req, "EnableTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用工作流
        /// </summary>
        /// <param name="req"><see cref="EnableTaskFlowRequest"/></param>
        /// <returns><see cref="EnableTaskFlowResponse"/></returns>
        public Task<EnableTaskFlowResponse> EnableTaskFlow(EnableTaskFlowRequest req)
        {
            return InternalRequestAsync<EnableTaskFlowResponse>(req, "EnableTaskFlow");
        }

        /// <summary>
        /// 启用工作流
        /// </summary>
        /// <param name="req"><see cref="EnableTaskFlowRequest"/></param>
        /// <returns><see cref="EnableTaskFlowResponse"/></returns>
        public EnableTaskFlowResponse EnableTaskFlowSync(EnableTaskFlowRequest req)
        {
            return InternalRequestAsync<EnableTaskFlowResponse>(req, "EnableTaskFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用单元化路由
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRouteRequest"/></param>
        /// <returns><see cref="EnableUnitRouteResponse"/></returns>
        public Task<EnableUnitRouteResponse> EnableUnitRoute(EnableUnitRouteRequest req)
        {
            return InternalRequestAsync<EnableUnitRouteResponse>(req, "EnableUnitRoute");
        }

        /// <summary>
        /// 启用单元化路由
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRouteRequest"/></param>
        /// <returns><see cref="EnableUnitRouteResponse"/></returns>
        public EnableUnitRouteResponse EnableUnitRouteSync(EnableUnitRouteRequest req)
        {
            return InternalRequestAsync<EnableUnitRouteResponse>(req, "EnableUnitRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用单元化规则
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRuleRequest"/></param>
        /// <returns><see cref="EnableUnitRuleResponse"/></returns>
        public Task<EnableUnitRuleResponse> EnableUnitRule(EnableUnitRuleRequest req)
        {
            return InternalRequestAsync<EnableUnitRuleResponse>(req, "EnableUnitRule");
        }

        /// <summary>
        /// 启用单元化规则
        /// </summary>
        /// <param name="req"><see cref="EnableUnitRuleRequest"/></param>
        /// <returns><see cref="EnableUnitRuleResponse"/></returns>
        public EnableUnitRuleResponse EnableUnitRuleSync(EnableUnitRuleRequest req)
        {
            return InternalRequestAsync<EnableUnitRuleResponse>(req, "EnableUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动执行一次任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public Task<ExecuteTaskResponse> ExecuteTask(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask");
        }

        /// <summary>
        /// 手动执行一次任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public ExecuteTaskResponse ExecuteTaskSync(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 执行一次工作流
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskFlowRequest"/></param>
        /// <returns><see cref="ExecuteTaskFlowResponse"/></returns>
        public Task<ExecuteTaskFlowResponse> ExecuteTaskFlow(ExecuteTaskFlowRequest req)
        {
            return InternalRequestAsync<ExecuteTaskFlowResponse>(req, "ExecuteTaskFlow");
        }

        /// <summary>
        /// 执行一次工作流
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskFlowRequest"/></param>
        /// <returns><see cref="ExecuteTaskFlowResponse"/></returns>
        public ExecuteTaskFlowResponse ExecuteTaskFlowSync(ExecuteTaskFlowRequest req)
        {
            return InternalRequestAsync<ExecuteTaskFlowResponse>(req, "ExecuteTaskFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 虚拟机部署组添加实例
        /// </summary>
        /// <param name="req"><see cref="ExpandGroupRequest"/></param>
        /// <returns><see cref="ExpandGroupResponse"/></returns>
        public Task<ExpandGroupResponse> ExpandGroup(ExpandGroupRequest req)
        {
            return InternalRequestAsync<ExpandGroupResponse>(req, "ExpandGroup");
        }

        /// <summary>
        /// 虚拟机部署组添加实例
        /// </summary>
        /// <param name="req"><see cref="ExpandGroupRequest"/></param>
        /// <returns><see cref="ExpandGroupResponse"/></returns>
        public ExpandGroupResponse ExpandGroupSync(ExpandGroupRequest req)
        {
            return InternalRequestAsync<ExpandGroupResponse>(req, "ExpandGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public Task<ModifyClusterResponse> ModifyCluster(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster");
        }

        /// <summary>
        /// 修改集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public ModifyClusterResponse ModifyClusterSync(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容器部署组
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerGroupRequest"/></param>
        /// <returns><see cref="ModifyContainerGroupResponse"/></returns>
        public Task<ModifyContainerGroupResponse> ModifyContainerGroup(ModifyContainerGroupRequest req)
        {
            return InternalRequestAsync<ModifyContainerGroupResponse>(req, "ModifyContainerGroup");
        }

        /// <summary>
        /// 修改容器部署组
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerGroupRequest"/></param>
        /// <returns><see cref="ModifyContainerGroupResponse"/></returns>
        public ModifyContainerGroupResponse ModifyContainerGroupSync(ModifyContainerGroupRequest req)
        {
            return InternalRequestAsync<ModifyContainerGroupResponse>(req, "ModifyContainerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容器部署组实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns><see cref="ModifyContainerReplicasResponse"/></returns>
        public Task<ModifyContainerReplicasResponse> ModifyContainerReplicas(ModifyContainerReplicasRequest req)
        {
            return InternalRequestAsync<ModifyContainerReplicasResponse>(req, "ModifyContainerReplicas");
        }

        /// <summary>
        /// 修改容器部署组实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerReplicasRequest"/></param>
        /// <returns><see cref="ModifyContainerReplicasResponse"/></returns>
        public ModifyContainerReplicasResponse ModifyContainerReplicasSync(ModifyContainerReplicasRequest req)
        {
            return InternalRequestAsync<ModifyContainerReplicasResponse>(req, "ModifyContainerReplicas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新部署组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup");
        }

        /// <summary>
        /// 更新部署组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新泳道信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRequest"/></param>
        /// <returns><see cref="ModifyLaneResponse"/></returns>
        public Task<ModifyLaneResponse> ModifyLane(ModifyLaneRequest req)
        {
            return InternalRequestAsync<ModifyLaneResponse>(req, "ModifyLane");
        }

        /// <summary>
        /// 更新泳道信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRequest"/></param>
        /// <returns><see cref="ModifyLaneResponse"/></returns>
        public ModifyLaneResponse ModifyLaneSync(ModifyLaneRequest req)
        {
            return InternalRequestAsync<ModifyLaneResponse>(req, "ModifyLane")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新泳道规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRuleRequest"/></param>
        /// <returns><see cref="ModifyLaneRuleResponse"/></returns>
        public Task<ModifyLaneRuleResponse> ModifyLaneRule(ModifyLaneRuleRequest req)
        {
            return InternalRequestAsync<ModifyLaneRuleResponse>(req, "ModifyLaneRule");
        }

        /// <summary>
        /// 更新泳道规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLaneRuleRequest"/></param>
        /// <returns><see cref="ModifyLaneRuleResponse"/></returns>
        public ModifyLaneRuleResponse ModifyLaneRuleSync(ModifyLaneRuleRequest req)
        {
            return InternalRequestAsync<ModifyLaneRuleResponse>(req, "ModifyLaneRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改微服务详情
        /// </summary>
        /// <param name="req"><see cref="ModifyMicroserviceRequest"/></param>
        /// <returns><see cref="ModifyMicroserviceResponse"/></returns>
        public Task<ModifyMicroserviceResponse> ModifyMicroservice(ModifyMicroserviceRequest req)
        {
            return InternalRequestAsync<ModifyMicroserviceResponse>(req, "ModifyMicroservice");
        }

        /// <summary>
        /// 修改微服务详情
        /// </summary>
        /// <param name="req"><see cref="ModifyMicroserviceRequest"/></param>
        /// <returns><see cref="ModifyMicroserviceResponse"/></returns>
        public ModifyMicroserviceResponse ModifyMicroserviceSync(ModifyMicroserviceRequest req)
        {
            return InternalRequestAsync<ModifyMicroserviceResponse>(req, "ModifyMicroservice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace");
        }

        /// <summary>
        /// 修改命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改路径重写
        /// </summary>
        /// <param name="req"><see cref="ModifyPathRewriteRequest"/></param>
        /// <returns><see cref="ModifyPathRewriteResponse"/></returns>
        public Task<ModifyPathRewriteResponse> ModifyPathRewrite(ModifyPathRewriteRequest req)
        {
            return InternalRequestAsync<ModifyPathRewriteResponse>(req, "ModifyPathRewrite");
        }

        /// <summary>
        /// 修改路径重写
        /// </summary>
        /// <param name="req"><see cref="ModifyPathRewriteRequest"/></param>
        /// <returns><see cref="ModifyPathRewriteResponse"/></returns>
        public ModifyPathRewriteResponse ModifyPathRewriteSync(ModifyPathRewriteRequest req)
        {
            return InternalRequestAsync<ModifyPathRewriteResponse>(req, "ModifyPathRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRequest"/></param>
        /// <returns><see cref="ModifyTaskResponse"/></returns>
        public Task<ModifyTaskResponse> ModifyTask(ModifyTaskRequest req)
        {
            return InternalRequestAsync<ModifyTaskResponse>(req, "ModifyTask");
        }

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRequest"/></param>
        /// <returns><see cref="ModifyTaskResponse"/></returns>
        public ModifyTaskResponse ModifyTaskSync(ModifyTaskRequest req)
        {
            return InternalRequestAsync<ModifyTaskResponse>(req, "ModifyTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req"><see cref="ModifyUploadInfoRequest"/></param>
        /// <returns><see cref="ModifyUploadInfoResponse"/></returns>
        public Task<ModifyUploadInfoResponse> ModifyUploadInfo(ModifyUploadInfoRequest req)
        {
            return InternalRequestAsync<ModifyUploadInfoResponse>(req, "ModifyUploadInfo");
        }

        /// <summary>
        /// 调用该接口和COS的上传接口后，需要调用此接口更新TSF中保存的程序包状态。
        /// 调用此接口完成后，才标志上传包流程结束。
        /// </summary>
        /// <param name="req"><see cref="ModifyUploadInfoRequest"/></param>
        /// <returns><see cref="ModifyUploadInfoResponse"/></returns>
        public ModifyUploadInfoResponse ModifyUploadInfoSync(ModifyUploadInfoRequest req)
        {
            return InternalRequestAsync<ModifyUploadInfoResponse>(req, "ModifyUploadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定解绑tcr仓库
        /// </summary>
        /// <param name="req"><see cref="OperateApplicationTcrBindingRequest"/></param>
        /// <returns><see cref="OperateApplicationTcrBindingResponse"/></returns>
        public Task<OperateApplicationTcrBindingResponse> OperateApplicationTcrBinding(OperateApplicationTcrBindingRequest req)
        {
            return InternalRequestAsync<OperateApplicationTcrBindingResponse>(req, "OperateApplicationTcrBinding");
        }

        /// <summary>
        /// 绑定解绑tcr仓库
        /// </summary>
        /// <param name="req"><see cref="OperateApplicationTcrBindingRequest"/></param>
        /// <returns><see cref="OperateApplicationTcrBindingResponse"/></returns>
        public OperateApplicationTcrBindingResponse OperateApplicationTcrBindingSync(OperateApplicationTcrBindingRequest req)
        {
            return InternalRequestAsync<OperateApplicationTcrBindingResponse>(req, "OperateApplicationTcrBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重关联业务日志配置
        /// </summary>
        /// <param name="req"><see cref="ReassociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="ReassociateBusinessLogConfigResponse"/></returns>
        public Task<ReassociateBusinessLogConfigResponse> ReassociateBusinessLogConfig(ReassociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<ReassociateBusinessLogConfigResponse>(req, "ReassociateBusinessLogConfig");
        }

        /// <summary>
        /// 重关联业务日志配置
        /// </summary>
        /// <param name="req"><see cref="ReassociateBusinessLogConfigRequest"/></param>
        /// <returns><see cref="ReassociateBusinessLogConfigResponse"/></returns>
        public ReassociateBusinessLogConfigResponse ReassociateBusinessLogConfigSync(ReassociateBusinessLogConfigRequest req)
        {
            return InternalRequestAsync<ReassociateBusinessLogConfigResponse>(req, "ReassociateBusinessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新执行任务
        /// </summary>
        /// <param name="req"><see cref="RedoTaskRequest"/></param>
        /// <returns><see cref="RedoTaskResponse"/></returns>
        public Task<RedoTaskResponse> RedoTask(RedoTaskRequest req)
        {
            return InternalRequestAsync<RedoTaskResponse>(req, "RedoTask");
        }

        /// <summary>
        /// 重新执行任务
        /// </summary>
        /// <param name="req"><see cref="RedoTaskRequest"/></param>
        /// <returns><see cref="RedoTaskResponse"/></returns>
        public RedoTaskResponse RedoTaskSync(RedoTaskRequest req)
        {
            return InternalRequestAsync<RedoTaskResponse>(req, "RedoTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新执行任务批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskBatchRequest"/></param>
        /// <returns><see cref="RedoTaskBatchResponse"/></returns>
        public Task<RedoTaskBatchResponse> RedoTaskBatch(RedoTaskBatchRequest req)
        {
            return InternalRequestAsync<RedoTaskBatchResponse>(req, "RedoTaskBatch");
        }

        /// <summary>
        /// 重新执行任务批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskBatchRequest"/></param>
        /// <returns><see cref="RedoTaskBatchResponse"/></returns>
        public RedoTaskBatchResponse RedoTaskBatchSync(RedoTaskBatchRequest req)
        {
            return InternalRequestAsync<RedoTaskBatchResponse>(req, "RedoTaskBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新执行在某个节点上执行任务。
        /// </summary>
        /// <param name="req"><see cref="RedoTaskExecuteRequest"/></param>
        /// <returns><see cref="RedoTaskExecuteResponse"/></returns>
        public Task<RedoTaskExecuteResponse> RedoTaskExecute(RedoTaskExecuteRequest req)
        {
            return InternalRequestAsync<RedoTaskExecuteResponse>(req, "RedoTaskExecute");
        }

        /// <summary>
        /// 重新执行在某个节点上执行任务。
        /// </summary>
        /// <param name="req"><see cref="RedoTaskExecuteRequest"/></param>
        /// <returns><see cref="RedoTaskExecuteResponse"/></returns>
        public RedoTaskExecuteResponse RedoTaskExecuteSync(RedoTaskExecuteRequest req)
        {
            return InternalRequestAsync<RedoTaskExecuteResponse>(req, "RedoTaskExecute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新执行工作流批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskFlowBatchRequest"/></param>
        /// <returns><see cref="RedoTaskFlowBatchResponse"/></returns>
        public Task<RedoTaskFlowBatchResponse> RedoTaskFlowBatch(RedoTaskFlowBatchRequest req)
        {
            return InternalRequestAsync<RedoTaskFlowBatchResponse>(req, "RedoTaskFlowBatch");
        }

        /// <summary>
        /// 重新执行工作流批次
        /// </summary>
        /// <param name="req"><see cref="RedoTaskFlowBatchRequest"/></param>
        /// <returns><see cref="RedoTaskFlowBatchResponse"/></returns>
        public RedoTaskFlowBatchResponse RedoTaskFlowBatchSync(RedoTaskFlowBatchRequest req)
        {
            return InternalRequestAsync<RedoTaskFlowBatchResponse>(req, "RedoTaskFlowBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布Api分组
        /// </summary>
        /// <param name="req"><see cref="ReleaseApiGroupRequest"/></param>
        /// <returns><see cref="ReleaseApiGroupResponse"/></returns>
        public Task<ReleaseApiGroupResponse> ReleaseApiGroup(ReleaseApiGroupRequest req)
        {
            return InternalRequestAsync<ReleaseApiGroupResponse>(req, "ReleaseApiGroup");
        }

        /// <summary>
        /// 发布Api分组
        /// </summary>
        /// <param name="req"><see cref="ReleaseApiGroupRequest"/></param>
        /// <returns><see cref="ReleaseApiGroupResponse"/></returns>
        public ReleaseApiGroupResponse ReleaseApiGroupSync(ReleaseApiGroupRequest req)
        {
            return InternalRequestAsync<ReleaseApiGroupResponse>(req, "ReleaseApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigRequest"/></param>
        /// <returns><see cref="ReleaseConfigResponse"/></returns>
        public Task<ReleaseConfigResponse> ReleaseConfig(ReleaseConfigRequest req)
        {
            return InternalRequestAsync<ReleaseConfigResponse>(req, "ReleaseConfig");
        }

        /// <summary>
        /// 发布配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigRequest"/></param>
        /// <returns><see cref="ReleaseConfigResponse"/></returns>
        public ReleaseConfigResponse ReleaseConfigSync(ReleaseConfigRequest req)
        {
            return InternalRequestAsync<ReleaseConfigResponse>(req, "ReleaseConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布配置,并且返回配置 ID
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="ReleaseConfigWithDetailRespResponse"/></returns>
        public Task<ReleaseConfigWithDetailRespResponse> ReleaseConfigWithDetailResp(ReleaseConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<ReleaseConfigWithDetailRespResponse>(req, "ReleaseConfigWithDetailResp");
        }

        /// <summary>
        /// 发布配置,并且返回配置 ID
        /// </summary>
        /// <param name="req"><see cref="ReleaseConfigWithDetailRespRequest"/></param>
        /// <returns><see cref="ReleaseConfigWithDetailRespResponse"/></returns>
        public ReleaseConfigWithDetailRespResponse ReleaseConfigWithDetailRespSync(ReleaseConfigWithDetailRespRequest req)
        {
            return InternalRequestAsync<ReleaseConfigWithDetailRespResponse>(req, "ReleaseConfigWithDetailResp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布文件配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseFileConfigRequest"/></param>
        /// <returns><see cref="ReleaseFileConfigResponse"/></returns>
        public Task<ReleaseFileConfigResponse> ReleaseFileConfig(ReleaseFileConfigRequest req)
        {
            return InternalRequestAsync<ReleaseFileConfigResponse>(req, "ReleaseFileConfig");
        }

        /// <summary>
        /// 发布文件配置
        /// </summary>
        /// <param name="req"><see cref="ReleaseFileConfigRequest"/></param>
        /// <returns><see cref="ReleaseFileConfigResponse"/></returns>
        public ReleaseFileConfigResponse ReleaseFileConfigSync(ReleaseFileConfigRequest req)
        {
            return InternalRequestAsync<ReleaseFileConfigResponse>(req, "ReleaseFileConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布公共配置
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicConfigRequest"/></param>
        /// <returns><see cref="ReleasePublicConfigResponse"/></returns>
        public Task<ReleasePublicConfigResponse> ReleasePublicConfig(ReleasePublicConfigRequest req)
        {
            return InternalRequestAsync<ReleasePublicConfigResponse>(req, "ReleasePublicConfig");
        }

        /// <summary>
        /// 发布公共配置
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicConfigRequest"/></param>
        /// <returns><see cref="ReleasePublicConfigResponse"/></returns>
        public ReleasePublicConfigResponse ReleasePublicConfigSync(ReleasePublicConfigRequest req)
        {
            return InternalRequestAsync<ReleasePublicConfigResponse>(req, "ReleasePublicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances");
        }

        /// <summary>
        /// 从 TSF 集群中批量移除云主机节点
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public RemoveInstancesResponse RemoveInstancesSync(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤回已发布的配置
        /// </summary>
        /// <param name="req"><see cref="RevocationConfigRequest"/></param>
        /// <returns><see cref="RevocationConfigResponse"/></returns>
        public Task<RevocationConfigResponse> RevocationConfig(RevocationConfigRequest req)
        {
            return InternalRequestAsync<RevocationConfigResponse>(req, "RevocationConfig");
        }

        /// <summary>
        /// 撤回已发布的配置
        /// </summary>
        /// <param name="req"><see cref="RevocationConfigRequest"/></param>
        /// <returns><see cref="RevocationConfigResponse"/></returns>
        public RevocationConfigResponse RevocationConfigSync(RevocationConfigRequest req)
        {
            return InternalRequestAsync<RevocationConfigResponse>(req, "RevocationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤回已发布的公共配置
        /// </summary>
        /// <param name="req"><see cref="RevocationPublicConfigRequest"/></param>
        /// <returns><see cref="RevocationPublicConfigResponse"/></returns>
        public Task<RevocationPublicConfigResponse> RevocationPublicConfig(RevocationPublicConfigRequest req)
        {
            return InternalRequestAsync<RevocationPublicConfigResponse>(req, "RevocationPublicConfig");
        }

        /// <summary>
        /// 撤回已发布的公共配置
        /// </summary>
        /// <param name="req"><see cref="RevocationPublicConfigRequest"/></param>
        /// <returns><see cref="RevocationPublicConfigResponse"/></returns>
        public RevocationPublicConfigResponse RevocationPublicConfigSync(RevocationPublicConfigRequest req)
        {
            return InternalRequestAsync<RevocationPublicConfigResponse>(req, "RevocationPublicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤回已发布的文件配置
        /// </summary>
        /// <param name="req"><see cref="RevokeFileConfigRequest"/></param>
        /// <returns><see cref="RevokeFileConfigResponse"/></returns>
        public Task<RevokeFileConfigResponse> RevokeFileConfig(RevokeFileConfigRequest req)
        {
            return InternalRequestAsync<RevokeFileConfigResponse>(req, "RevokeFileConfig");
        }

        /// <summary>
        /// 撤回已发布的文件配置
        /// </summary>
        /// <param name="req"><see cref="RevokeFileConfigRequest"/></param>
        /// <returns><see cref="RevokeFileConfigResponse"/></returns>
        public RevokeFileConfigResponse RevokeFileConfigSync(RevokeFileConfigRequest req)
        {
            return InternalRequestAsync<RevokeFileConfigResponse>(req, "RevokeFileConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚配置
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigRequest"/></param>
        /// <returns><see cref="RollbackConfigResponse"/></returns>
        public Task<RollbackConfigResponse> RollbackConfig(RollbackConfigRequest req)
        {
            return InternalRequestAsync<RollbackConfigResponse>(req, "RollbackConfig");
        }

        /// <summary>
        /// 回滚配置
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigRequest"/></param>
        /// <returns><see cref="RollbackConfigResponse"/></returns>
        public RollbackConfigResponse RollbackConfigSync(RollbackConfigRequest req)
        {
            return InternalRequestAsync<RollbackConfigResponse>(req, "RollbackConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 业务日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchBusinessLogRequest"/></param>
        /// <returns><see cref="SearchBusinessLogResponse"/></returns>
        public Task<SearchBusinessLogResponse> SearchBusinessLog(SearchBusinessLogRequest req)
        {
            return InternalRequestAsync<SearchBusinessLogResponse>(req, "SearchBusinessLog");
        }

        /// <summary>
        /// 业务日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchBusinessLogRequest"/></param>
        /// <returns><see cref="SearchBusinessLogResponse"/></returns>
        public SearchBusinessLogResponse SearchBusinessLogSync(SearchBusinessLogRequest req)
        {
            return InternalRequestAsync<SearchBusinessLogResponse>(req, "SearchBusinessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 标准输出日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchStdoutLogRequest"/></param>
        /// <returns><see cref="SearchStdoutLogResponse"/></returns>
        public Task<SearchStdoutLogResponse> SearchStdoutLog(SearchStdoutLogRequest req)
        {
            return InternalRequestAsync<SearchStdoutLogResponse>(req, "SearchStdoutLog");
        }

        /// <summary>
        /// 标准输出日志搜索
        /// </summary>
        /// <param name="req"><see cref="SearchStdoutLogRequest"/></param>
        /// <returns><see cref="SearchStdoutLogResponse"/></returns>
        public SearchStdoutLogResponse SearchStdoutLogSync(SearchStdoutLogRequest req)
        {
            return InternalRequestAsync<SearchStdoutLogResponse>(req, "SearchStdoutLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下线部署组所有机器实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkGroupRequest"/></param>
        /// <returns><see cref="ShrinkGroupResponse"/></returns>
        public Task<ShrinkGroupResponse> ShrinkGroup(ShrinkGroupRequest req)
        {
            return InternalRequestAsync<ShrinkGroupResponse>(req, "ShrinkGroup");
        }

        /// <summary>
        /// 下线部署组所有机器实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkGroupRequest"/></param>
        /// <returns><see cref="ShrinkGroupResponse"/></returns>
        public ShrinkGroupResponse ShrinkGroupSync(ShrinkGroupRequest req)
        {
            return InternalRequestAsync<ShrinkGroupResponse>(req, "ShrinkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 虚拟机部署组下线实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkInstancesRequest"/></param>
        /// <returns><see cref="ShrinkInstancesResponse"/></returns>
        public Task<ShrinkInstancesResponse> ShrinkInstances(ShrinkInstancesRequest req)
        {
            return InternalRequestAsync<ShrinkInstancesResponse>(req, "ShrinkInstances");
        }

        /// <summary>
        /// 虚拟机部署组下线实例
        /// </summary>
        /// <param name="req"><see cref="ShrinkInstancesRequest"/></param>
        /// <returns><see cref="ShrinkInstancesResponse"/></returns>
        public ShrinkInstancesResponse ShrinkInstancesSync(ShrinkInstancesRequest req)
        {
            return InternalRequestAsync<ShrinkInstancesResponse>(req, "ShrinkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动容器部署组
        /// </summary>
        /// <param name="req"><see cref="StartContainerGroupRequest"/></param>
        /// <returns><see cref="StartContainerGroupResponse"/></returns>
        public Task<StartContainerGroupResponse> StartContainerGroup(StartContainerGroupRequest req)
        {
            return InternalRequestAsync<StartContainerGroupResponse>(req, "StartContainerGroup");
        }

        /// <summary>
        /// 启动容器部署组
        /// </summary>
        /// <param name="req"><see cref="StartContainerGroupRequest"/></param>
        /// <returns><see cref="StartContainerGroupResponse"/></returns>
        public StartContainerGroupResponse StartContainerGroupSync(StartContainerGroupRequest req)
        {
            return InternalRequestAsync<StartContainerGroupResponse>(req, "StartContainerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动分组
        /// </summary>
        /// <param name="req"><see cref="StartGroupRequest"/></param>
        /// <returns><see cref="StartGroupResponse"/></returns>
        public Task<StartGroupResponse> StartGroup(StartGroupRequest req)
        {
            return InternalRequestAsync<StartGroupResponse>(req, "StartGroup");
        }

        /// <summary>
        /// 启动分组
        /// </summary>
        /// <param name="req"><see cref="StartGroupRequest"/></param>
        /// <returns><see cref="StartGroupResponse"/></returns>
        public StartGroupResponse StartGroupSync(StartGroupRequest req)
        {
            return InternalRequestAsync<StartGroupResponse>(req, "StartGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止容器部署组
        /// </summary>
        /// <param name="req"><see cref="StopContainerGroupRequest"/></param>
        /// <returns><see cref="StopContainerGroupResponse"/></returns>
        public Task<StopContainerGroupResponse> StopContainerGroup(StopContainerGroupRequest req)
        {
            return InternalRequestAsync<StopContainerGroupResponse>(req, "StopContainerGroup");
        }

        /// <summary>
        /// 停止容器部署组
        /// </summary>
        /// <param name="req"><see cref="StopContainerGroupRequest"/></param>
        /// <returns><see cref="StopContainerGroupResponse"/></returns>
        public StopContainerGroupResponse StopContainerGroupSync(StopContainerGroupRequest req)
        {
            return InternalRequestAsync<StopContainerGroupResponse>(req, "StopContainerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="StopGroupRequest"/></param>
        /// <returns><see cref="StopGroupResponse"/></returns>
        public Task<StopGroupResponse> StopGroup(StopGroupRequest req)
        {
            return InternalRequestAsync<StopGroupResponse>(req, "StopGroup");
        }

        /// <summary>
        /// 停止虚拟机部署组
        /// </summary>
        /// <param name="req"><see cref="StopGroupRequest"/></param>
        /// <returns><see cref="StopGroupResponse"/></returns>
        public StopGroupResponse StopGroupSync(StopGroupRequest req)
        {
            return InternalRequestAsync<StopGroupResponse>(req, "StopGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止执行中的任务批次， 非运行中的任务不可调用。
        /// </summary>
        /// <param name="req"><see cref="StopTaskBatchRequest"/></param>
        /// <returns><see cref="StopTaskBatchResponse"/></returns>
        public Task<StopTaskBatchResponse> StopTaskBatch(StopTaskBatchRequest req)
        {
            return InternalRequestAsync<StopTaskBatchResponse>(req, "StopTaskBatch");
        }

        /// <summary>
        /// 停止执行中的任务批次， 非运行中的任务不可调用。
        /// </summary>
        /// <param name="req"><see cref="StopTaskBatchRequest"/></param>
        /// <returns><see cref="StopTaskBatchResponse"/></returns>
        public StopTaskBatchResponse StopTaskBatchSync(StopTaskBatchRequest req)
        {
            return InternalRequestAsync<StopTaskBatchResponse>(req, "StopTaskBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止正在某个节点上执行的任务
        /// </summary>
        /// <param name="req"><see cref="StopTaskExecuteRequest"/></param>
        /// <returns><see cref="StopTaskExecuteResponse"/></returns>
        public Task<StopTaskExecuteResponse> StopTaskExecute(StopTaskExecuteRequest req)
        {
            return InternalRequestAsync<StopTaskExecuteResponse>(req, "StopTaskExecute");
        }

        /// <summary>
        /// 停止正在某个节点上执行的任务
        /// </summary>
        /// <param name="req"><see cref="StopTaskExecuteRequest"/></param>
        /// <returns><see cref="StopTaskExecuteResponse"/></returns>
        public StopTaskExecuteResponse StopTaskExecuteSync(StopTaskExecuteRequest req)
        {
            return InternalRequestAsync<StopTaskExecuteResponse>(req, "StopTaskExecute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止一个工作流批次
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskFlowBatchRequest"/></param>
        /// <returns><see cref="TerminateTaskFlowBatchResponse"/></returns>
        public Task<TerminateTaskFlowBatchResponse> TerminateTaskFlowBatch(TerminateTaskFlowBatchRequest req)
        {
            return InternalRequestAsync<TerminateTaskFlowBatchResponse>(req, "TerminateTaskFlowBatch");
        }

        /// <summary>
        /// 停止一个工作流批次
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskFlowBatchRequest"/></param>
        /// <returns><see cref="TerminateTaskFlowBatchResponse"/></returns>
        public TerminateTaskFlowBatchResponse TerminateTaskFlowBatchSync(TerminateTaskFlowBatchRequest req)
        {
            return InternalRequestAsync<TerminateTaskFlowBatchResponse>(req, "TerminateTaskFlowBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API分组批量与网关解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindApiGroupRequest"/></param>
        /// <returns><see cref="UnbindApiGroupResponse"/></returns>
        public Task<UnbindApiGroupResponse> UnbindApiGroup(UnbindApiGroupRequest req)
        {
            return InternalRequestAsync<UnbindApiGroupResponse>(req, "UnbindApiGroup");
        }

        /// <summary>
        /// API分组批量与网关解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindApiGroupRequest"/></param>
        /// <returns><see cref="UnbindApiGroupResponse"/></returns>
        public UnbindApiGroupResponse UnbindApiGroupSync(UnbindApiGroupRequest req)
        {
            return InternalRequestAsync<UnbindApiGroupResponse>(req, "UnbindApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Api分组
        /// </summary>
        /// <param name="req"><see cref="UpdateApiGroupRequest"/></param>
        /// <returns><see cref="UpdateApiGroupResponse"/></returns>
        public Task<UpdateApiGroupResponse> UpdateApiGroup(UpdateApiGroupRequest req)
        {
            return InternalRequestAsync<UpdateApiGroupResponse>(req, "UpdateApiGroup");
        }

        /// <summary>
        /// 更新Api分组
        /// </summary>
        /// <param name="req"><see cref="UpdateApiGroupRequest"/></param>
        /// <returns><see cref="UpdateApiGroupResponse"/></returns>
        public UpdateApiGroupResponse UpdateApiGroupSync(UpdateApiGroupRequest req)
        {
            return InternalRequestAsync<UpdateApiGroupResponse>(req, "UpdateApiGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRuleResponse"/></returns>
        public Task<UpdateApiRateLimitRuleResponse> UpdateApiRateLimitRule(UpdateApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<UpdateApiRateLimitRuleResponse>(req, "UpdateApiRateLimitRule");
        }

        /// <summary>
        /// 更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRuleRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRuleResponse"/></returns>
        public UpdateApiRateLimitRuleResponse UpdateApiRateLimitRuleSync(UpdateApiRateLimitRuleRequest req)
        {
            return InternalRequestAsync<UpdateApiRateLimitRuleResponse>(req, "UpdateApiRateLimitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRulesResponse"/></returns>
        public Task<UpdateApiRateLimitRulesResponse> UpdateApiRateLimitRules(UpdateApiRateLimitRulesRequest req)
        {
            return InternalRequestAsync<UpdateApiRateLimitRulesResponse>(req, "UpdateApiRateLimitRules");
        }

        /// <summary>
        /// 批量更新API限流规则
        /// </summary>
        /// <param name="req"><see cref="UpdateApiRateLimitRulesRequest"/></param>
        /// <returns><see cref="UpdateApiRateLimitRulesResponse"/></returns>
        public UpdateApiRateLimitRulesResponse UpdateApiRateLimitRulesSync(UpdateApiRateLimitRulesRequest req)
        {
            return InternalRequestAsync<UpdateApiRateLimitRulesResponse>(req, "UpdateApiRateLimitRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新API超时
        /// </summary>
        /// <param name="req"><see cref="UpdateApiTimeoutsRequest"/></param>
        /// <returns><see cref="UpdateApiTimeoutsResponse"/></returns>
        public Task<UpdateApiTimeoutsResponse> UpdateApiTimeouts(UpdateApiTimeoutsRequest req)
        {
            return InternalRequestAsync<UpdateApiTimeoutsResponse>(req, "UpdateApiTimeouts");
        }

        /// <summary>
        /// 批量更新API超时
        /// </summary>
        /// <param name="req"><see cref="UpdateApiTimeoutsRequest"/></param>
        /// <returns><see cref="UpdateApiTimeoutsResponse"/></returns>
        public UpdateApiTimeoutsResponse UpdateApiTimeoutsSync(UpdateApiTimeoutsRequest req)
        {
            return InternalRequestAsync<UpdateApiTimeoutsResponse>(req, "UpdateApiTimeouts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新参数模板
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigTemplateRequest"/></param>
        /// <returns><see cref="UpdateConfigTemplateResponse"/></returns>
        public Task<UpdateConfigTemplateResponse> UpdateConfigTemplate(UpdateConfigTemplateRequest req)
        {
            return InternalRequestAsync<UpdateConfigTemplateResponse>(req, "UpdateConfigTemplate");
        }

        /// <summary>
        /// 更新参数模板
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigTemplateRequest"/></param>
        /// <returns><see cref="UpdateConfigTemplateResponse"/></returns>
        public UpdateConfigTemplateResponse UpdateConfigTemplateSync(UpdateConfigTemplateRequest req)
        {
            return InternalRequestAsync<UpdateConfigTemplateResponse>(req, "UpdateConfigTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新API
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayApiRequest"/></param>
        /// <returns><see cref="UpdateGatewayApiResponse"/></returns>
        public Task<UpdateGatewayApiResponse> UpdateGatewayApi(UpdateGatewayApiRequest req)
        {
            return InternalRequestAsync<UpdateGatewayApiResponse>(req, "UpdateGatewayApi");
        }

        /// <summary>
        /// 更新API
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayApiRequest"/></param>
        /// <returns><see cref="UpdateGatewayApiResponse"/></returns>
        public UpdateGatewayApiResponse UpdateGatewayApiSync(UpdateGatewayApiRequest req)
        {
            return InternalRequestAsync<UpdateGatewayApiResponse>(req, "UpdateGatewayApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateHealthCheckSettingsRequest"/></param>
        /// <returns><see cref="UpdateHealthCheckSettingsResponse"/></returns>
        public Task<UpdateHealthCheckSettingsResponse> UpdateHealthCheckSettings(UpdateHealthCheckSettingsRequest req)
        {
            return InternalRequestAsync<UpdateHealthCheckSettingsResponse>(req, "UpdateHealthCheckSettings");
        }

        /// <summary>
        /// 更新健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateHealthCheckSettingsRequest"/></param>
        /// <returns><see cref="UpdateHealthCheckSettingsResponse"/></returns>
        public UpdateHealthCheckSettingsResponse UpdateHealthCheckSettingsSync(UpdateHealthCheckSettingsRequest req)
        {
            return InternalRequestAsync<UpdateHealthCheckSettingsResponse>(req, "UpdateHealthCheckSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新仓库信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRepositoryRequest"/></param>
        /// <returns><see cref="UpdateRepositoryResponse"/></returns>
        public Task<UpdateRepositoryResponse> UpdateRepository(UpdateRepositoryRequest req)
        {
            return InternalRequestAsync<UpdateRepositoryResponse>(req, "UpdateRepository");
        }

        /// <summary>
        /// 更新仓库信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRepositoryRequest"/></param>
        /// <returns><see cref="UpdateRepositoryResponse"/></returns>
        public UpdateRepositoryResponse UpdateRepositorySync(UpdateRepositoryRequest req)
        {
            return InternalRequestAsync<UpdateRepositoryResponse>(req, "UpdateRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新单元化规则
        /// </summary>
        /// <param name="req"><see cref="UpdateUnitRuleRequest"/></param>
        /// <returns><see cref="UpdateUnitRuleResponse"/></returns>
        public Task<UpdateUnitRuleResponse> UpdateUnitRule(UpdateUnitRuleRequest req)
        {
            return InternalRequestAsync<UpdateUnitRuleResponse>(req, "UpdateUnitRule");
        }

        /// <summary>
        /// 更新单元化规则
        /// </summary>
        /// <param name="req"><see cref="UpdateUnitRuleRequest"/></param>
        /// <returns><see cref="UpdateUnitRuleResponse"/></returns>
        public UpdateUnitRuleResponse UpdateUnitRuleSync(UpdateUnitRuleRequest req)
        {
            return InternalRequestAsync<UpdateUnitRuleResponse>(req, "UpdateUnitRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
