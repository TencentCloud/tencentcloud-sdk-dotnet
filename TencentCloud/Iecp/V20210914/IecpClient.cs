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

namespace TencentCloud.Iecp.V20210914
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iecp.V20210914.Models;

   public class IecpClient : AbstractClient{

       private const string endpoint = "iecp.tencentcloudapi.com";
       private const string version = "2021-09-14";
       private const string sdkVersion = "SDK_NET_3.0.1028";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IecpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IecpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 从组件市场选中组件并添加到应用模板列表
        /// </summary>
        /// <param name="req"><see cref="ApplyMarketComponentRequest"/></param>
        /// <returns><see cref="ApplyMarketComponentResponse"/></returns>
        public Task<ApplyMarketComponentResponse> ApplyMarketComponent(ApplyMarketComponentRequest req)
        {
            return InternalRequestAsync<ApplyMarketComponentResponse>(req, "ApplyMarketComponent");
        }

        /// <summary>
        /// 从组件市场选中组件并添加到应用模板列表
        /// </summary>
        /// <param name="req"><see cref="ApplyMarketComponentRequest"/></param>
        /// <returns><see cref="ApplyMarketComponentResponse"/></returns>
        public ApplyMarketComponentResponse ApplyMarketComponentSync(ApplyMarketComponentRequest req)
        {
            return InternalRequestAsync<ApplyMarketComponentResponse>(req, "ApplyMarketComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 建立消息路由
        /// </summary>
        /// <param name="req"><see cref="BuildMessageRouteRequest"/></param>
        /// <returns><see cref="BuildMessageRouteResponse"/></returns>
        public Task<BuildMessageRouteResponse> BuildMessageRoute(BuildMessageRouteRequest req)
        {
            return InternalRequestAsync<BuildMessageRouteResponse>(req, "BuildMessageRoute");
        }

        /// <summary>
        /// 建立消息路由
        /// </summary>
        /// <param name="req"><see cref="BuildMessageRouteRequest"/></param>
        /// <returns><see cref="BuildMessageRouteResponse"/></returns>
        public BuildMessageRouteResponse BuildMessageRouteSync(BuildMessageRouteRequest req)
        {
            return InternalRequestAsync<BuildMessageRouteResponse>(req, "BuildMessageRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建可视化创建应用模板
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateApplicationVisualizationResponse"/></returns>
        public Task<CreateApplicationVisualizationResponse> CreateApplicationVisualization(CreateApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<CreateApplicationVisualizationResponse>(req, "CreateApplicationVisualization");
        }

        /// <summary>
        /// 创建可视化创建应用模板
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateApplicationVisualizationResponse"/></returns>
        public CreateApplicationVisualizationResponse CreateApplicationVisualizationSync(CreateApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<CreateApplicationVisualizationResponse>(req, "CreateApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建ConfigMap
        /// </summary>
        /// <param name="req"><see cref="CreateConfigMapRequest"/></param>
        /// <returns><see cref="CreateConfigMapResponse"/></returns>
        public Task<CreateConfigMapResponse> CreateConfigMap(CreateConfigMapRequest req)
        {
            return InternalRequestAsync<CreateConfigMapResponse>(req, "CreateConfigMap");
        }

        /// <summary>
        /// 创建ConfigMap
        /// </summary>
        /// <param name="req"><see cref="CreateConfigMapRequest"/></param>
        /// <returns><see cref="CreateConfigMapResponse"/></returns>
        public CreateConfigMapResponse CreateConfigMapSync(CreateConfigMapRequest req)
        {
            return InternalRequestAsync<CreateConfigMapResponse>(req, "CreateConfigMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeResponse"/></returns>
        public Task<CreateEdgeNodeResponse> CreateEdgeNode(CreateEdgeNodeRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeResponse>(req, "CreateEdgeNode");
        }

        /// <summary>
        /// 创建边缘节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeResponse"/></returns>
        public CreateEdgeNodeResponse CreateEdgeNodeSync(CreateEdgeNodeRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeResponse>(req, "CreateEdgeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量预注册节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeBatchRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeBatchResponse"/></returns>
        public Task<CreateEdgeNodeBatchResponse> CreateEdgeNodeBatch(CreateEdgeNodeBatchRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeBatchResponse>(req, "CreateEdgeNodeBatch");
        }

        /// <summary>
        /// 批量预注册节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeBatchRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeBatchResponse"/></returns>
        public CreateEdgeNodeBatchResponse CreateEdgeNodeBatchSync(CreateEdgeNodeBatchRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeBatchResponse>(req, "CreateEdgeNodeBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeGroupResponse"/></returns>
        public Task<CreateEdgeNodeGroupResponse> CreateEdgeNodeGroup(CreateEdgeNodeGroupRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeGroupResponse>(req, "CreateEdgeNodeGroup");
        }

        /// <summary>
        /// 创建边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeGroupResponse"/></returns>
        public CreateEdgeNodeGroupResponse CreateEdgeNodeGroupSync(CreateEdgeNodeGroupRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeGroupResponse>(req, "CreateEdgeNodeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeUnitTemplateResponse"/></returns>
        public Task<CreateEdgeNodeUnitTemplateResponse> CreateEdgeNodeUnitTemplate(CreateEdgeNodeUnitTemplateRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeUnitTemplateResponse>(req, "CreateEdgeNodeUnitTemplate");
        }

        /// <summary>
        /// 创建边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeUnitTemplateResponse"/></returns>
        public CreateEdgeNodeUnitTemplateResponse CreateEdgeNodeUnitTemplateSync(CreateEdgeNodeUnitTemplateRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeUnitTemplateResponse>(req, "CreateEdgeNodeUnitTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可视化创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationVisualizationResponse"/></returns>
        public Task<CreateEdgeUnitApplicationVisualizationResponse> CreateEdgeUnitApplicationVisualization(CreateEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitApplicationVisualizationResponse>(req, "CreateEdgeUnitApplicationVisualization");
        }

        /// <summary>
        /// 可视化创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationVisualizationResponse"/></returns>
        public CreateEdgeUnitApplicationVisualizationResponse CreateEdgeUnitApplicationVisualizationSync(CreateEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitApplicationVisualizationResponse>(req, "CreateEdgeUnitApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// yaml方式创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationYamlResponse"/></returns>
        public Task<CreateEdgeUnitApplicationYamlResponse> CreateEdgeUnitApplicationYaml(CreateEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitApplicationYamlResponse>(req, "CreateEdgeUnitApplicationYaml");
        }

        /// <summary>
        /// yaml方式创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationYamlResponse"/></returns>
        public CreateEdgeUnitApplicationYamlResponse CreateEdgeUnitApplicationYamlSync(CreateEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitApplicationYamlResponse>(req, "CreateEdgeUnitApplicationYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitCloudResponse"/></returns>
        public Task<CreateEdgeUnitCloudResponse> CreateEdgeUnitCloud(CreateEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitCloudResponse>(req, "CreateEdgeUnitCloud");
        }

        /// <summary>
        /// 创建边缘单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitCloudResponse"/></returns>
        public CreateEdgeUnitCloudResponse CreateEdgeUnitCloudSync(CreateEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitCloudResponse>(req, "CreateEdgeUnitCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定设备到单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitDevicesRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitDevicesResponse"/></returns>
        public Task<CreateEdgeUnitDevicesResponse> CreateEdgeUnitDevices(CreateEdgeUnitDevicesRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitDevicesResponse>(req, "CreateEdgeUnitDevices");
        }

        /// <summary>
        /// 批量绑定设备到单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitDevicesRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitDevicesResponse"/></returns>
        public CreateEdgeUnitDevicesResponse CreateEdgeUnitDevicesSync(CreateEdgeUnitDevicesRequest req)
        {
            return InternalRequestAsync<CreateEdgeUnitDevicesResponse>(req, "CreateEdgeUnitDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子设备
        /// </summary>
        /// <param name="req"><see cref="CreateIotDeviceRequest"/></param>
        /// <returns><see cref="CreateIotDeviceResponse"/></returns>
        public Task<CreateIotDeviceResponse> CreateIotDevice(CreateIotDeviceRequest req)
        {
            return InternalRequestAsync<CreateIotDeviceResponse>(req, "CreateIotDevice");
        }

        /// <summary>
        /// 创建子设备
        /// </summary>
        /// <param name="req"><see cref="CreateIotDeviceRequest"/></param>
        /// <returns><see cref="CreateIotDeviceResponse"/></returns>
        public CreateIotDeviceResponse CreateIotDeviceSync(CreateIotDeviceRequest req)
        {
            return InternalRequestAsync<CreateIotDeviceResponse>(req, "CreateIotDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建消息路由
        /// </summary>
        /// <param name="req"><see cref="CreateMessageRouteRequest"/></param>
        /// <returns><see cref="CreateMessageRouteResponse"/></returns>
        public Task<CreateMessageRouteResponse> CreateMessageRoute(CreateMessageRouteRequest req)
        {
            return InternalRequestAsync<CreateMessageRouteResponse>(req, "CreateMessageRoute");
        }

        /// <summary>
        /// 创建消息路由
        /// </summary>
        /// <param name="req"><see cref="CreateMessageRouteRequest"/></param>
        /// <returns><see cref="CreateMessageRouteResponse"/></returns>
        public CreateMessageRouteResponse CreateMessageRouteSync(CreateMessageRouteRequest req)
        {
            return InternalRequestAsync<CreateMessageRouteResponse>(req, "CreateMessageRoute")
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
        /// 创建Secret
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public Task<CreateSecretResponse> CreateSecret(CreateSecretRequest req)
        {
            return InternalRequestAsync<CreateSecretResponse>(req, "CreateSecret");
        }

        /// <summary>
        /// 创建Secret
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public CreateSecretResponse CreateSecretSync(CreateSecretRequest req)
        {
            return InternalRequestAsync<CreateSecretResponse>(req, "CreateSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或更新边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="CreateUpdateNodeUnitRequest"/></param>
        /// <returns><see cref="CreateUpdateNodeUnitResponse"/></returns>
        public Task<CreateUpdateNodeUnitResponse> CreateUpdateNodeUnit(CreateUpdateNodeUnitRequest req)
        {
            return InternalRequestAsync<CreateUpdateNodeUnitResponse>(req, "CreateUpdateNodeUnit");
        }

        /// <summary>
        /// 创建或更新边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="CreateUpdateNodeUnitRequest"/></param>
        /// <returns><see cref="CreateUpdateNodeUnitResponse"/></returns>
        public CreateUpdateNodeUnitResponse CreateUpdateNodeUnitSync(CreateUpdateNodeUnitRequest req)
        {
            return InternalRequestAsync<CreateUpdateNodeUnitResponse>(req, "CreateUpdateNodeUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建token
        /// </summary>
        /// <param name="req"><see cref="CreateUserTokenRequest"/></param>
        /// <returns><see cref="CreateUserTokenResponse"/></returns>
        public Task<CreateUserTokenResponse> CreateUserToken(CreateUserTokenRequest req)
        {
            return InternalRequestAsync<CreateUserTokenResponse>(req, "CreateUserToken");
        }

        /// <summary>
        /// 创建token
        /// </summary>
        /// <param name="req"><see cref="CreateUserTokenRequest"/></param>
        /// <returns><see cref="CreateUserTokenResponse"/></returns>
        public CreateUserTokenResponse CreateUserTokenSync(CreateUserTokenRequest req)
        {
            return InternalRequestAsync<CreateUserTokenResponse>(req, "CreateUserToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用模板
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationsRequest"/></param>
        /// <returns><see cref="DeleteApplicationsResponse"/></returns>
        public Task<DeleteApplicationsResponse> DeleteApplications(DeleteApplicationsRequest req)
        {
            return InternalRequestAsync<DeleteApplicationsResponse>(req, "DeleteApplications");
        }

        /// <summary>
        /// 删除应用模板
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationsRequest"/></param>
        /// <returns><see cref="DeleteApplicationsResponse"/></returns>
        public DeleteApplicationsResponse DeleteApplicationsSync(DeleteApplicationsRequest req)
        {
            return InternalRequestAsync<DeleteApplicationsResponse>(req, "DeleteApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除ConfigMap
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigMapRequest"/></param>
        /// <returns><see cref="DeleteConfigMapResponse"/></returns>
        public Task<DeleteConfigMapResponse> DeleteConfigMap(DeleteConfigMapRequest req)
        {
            return InternalRequestAsync<DeleteConfigMapResponse>(req, "DeleteConfigMap");
        }

        /// <summary>
        /// 删除ConfigMap
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigMapRequest"/></param>
        /// <returns><see cref="DeleteConfigMapResponse"/></returns>
        public DeleteConfigMapResponse DeleteConfigMapSync(DeleteConfigMapRequest req)
        {
            return InternalRequestAsync<DeleteConfigMapResponse>(req, "DeleteConfigMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeGroupResponse"/></returns>
        public Task<DeleteEdgeNodeGroupResponse> DeleteEdgeNodeGroup(DeleteEdgeNodeGroupRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodeGroupResponse>(req, "DeleteEdgeNodeGroup");
        }

        /// <summary>
        /// 删除边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeGroupResponse"/></returns>
        public DeleteEdgeNodeGroupResponse DeleteEdgeNodeGroupSync(DeleteEdgeNodeGroupRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodeGroupResponse>(req, "DeleteEdgeNodeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeUnitTemplatesResponse"/></returns>
        public Task<DeleteEdgeNodeUnitTemplatesResponse> DeleteEdgeNodeUnitTemplates(DeleteEdgeNodeUnitTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodeUnitTemplatesResponse>(req, "DeleteEdgeNodeUnitTemplates");
        }

        /// <summary>
        /// 删除边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeUnitTemplatesResponse"/></returns>
        public DeleteEdgeNodeUnitTemplatesResponse DeleteEdgeNodeUnitTemplatesSync(DeleteEdgeNodeUnitTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodeUnitTemplatesResponse>(req, "DeleteEdgeNodeUnitTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除边缘节点
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodesResponse"/></returns>
        public Task<DeleteEdgeNodesResponse> DeleteEdgeNodes(DeleteEdgeNodesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodesResponse>(req, "DeleteEdgeNodes");
        }

        /// <summary>
        /// 批量删除边缘节点
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodesResponse"/></returns>
        public DeleteEdgeNodesResponse DeleteEdgeNodesSync(DeleteEdgeNodesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeNodesResponse>(req, "DeleteEdgeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用列表
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitApplicationsResponse"/></returns>
        public Task<DeleteEdgeUnitApplicationsResponse> DeleteEdgeUnitApplications(DeleteEdgeUnitApplicationsRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitApplicationsResponse>(req, "DeleteEdgeUnitApplications");
        }

        /// <summary>
        /// 删除应用列表
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitApplicationsResponse"/></returns>
        public DeleteEdgeUnitApplicationsResponse DeleteEdgeUnitApplicationsSync(DeleteEdgeUnitApplicationsRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitApplicationsResponse>(req, "DeleteEdgeUnitApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘单元
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitCloudResponse"/></returns>
        public Task<DeleteEdgeUnitCloudResponse> DeleteEdgeUnitCloud(DeleteEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitCloudResponse>(req, "DeleteEdgeUnitCloud");
        }

        /// <summary>
        /// 删除边缘单元
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitCloudResponse"/></returns>
        public DeleteEdgeUnitCloudResponse DeleteEdgeUnitCloudSync(DeleteEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitCloudResponse>(req, "DeleteEdgeUnitCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新部署边缘单元指定Grid下应用
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDeployGridItemResponse"/></returns>
        public Task<DeleteEdgeUnitDeployGridItemResponse> DeleteEdgeUnitDeployGridItem(DeleteEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitDeployGridItemResponse>(req, "DeleteEdgeUnitDeployGridItem");
        }

        /// <summary>
        /// 重新部署边缘单元指定Grid下应用
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDeployGridItemResponse"/></returns>
        public DeleteEdgeUnitDeployGridItemResponse DeleteEdgeUnitDeployGridItemSync(DeleteEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitDeployGridItemResponse>(req, "DeleteEdgeUnitDeployGridItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑单元设备
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDevicesRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDevicesResponse"/></returns>
        public Task<DeleteEdgeUnitDevicesResponse> DeleteEdgeUnitDevices(DeleteEdgeUnitDevicesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitDevicesResponse>(req, "DeleteEdgeUnitDevices");
        }

        /// <summary>
        /// 批量解绑单元设备
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDevicesRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDevicesResponse"/></returns>
        public DeleteEdgeUnitDevicesResponse DeleteEdgeUnitDevicesSync(DeleteEdgeUnitDevicesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitDevicesResponse>(req, "DeleteEdgeUnitDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定pod
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitPodRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitPodResponse"/></returns>
        public Task<DeleteEdgeUnitPodResponse> DeleteEdgeUnitPod(DeleteEdgeUnitPodRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitPodResponse>(req, "DeleteEdgeUnitPod");
        }

        /// <summary>
        /// 删除指定pod
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitPodRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitPodResponse"/></returns>
        public DeleteEdgeUnitPodResponse DeleteEdgeUnitPodSync(DeleteEdgeUnitPodRequest req)
        {
            return InternalRequestAsync<DeleteEdgeUnitPodResponse>(req, "DeleteEdgeUnitPod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDeviceRequest"/></param>
        /// <returns><see cref="DeleteIotDeviceResponse"/></returns>
        public Task<DeleteIotDeviceResponse> DeleteIotDevice(DeleteIotDeviceRequest req)
        {
            return InternalRequestAsync<DeleteIotDeviceResponse>(req, "DeleteIotDevice");
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDeviceRequest"/></param>
        /// <returns><see cref="DeleteIotDeviceResponse"/></returns>
        public DeleteIotDeviceResponse DeleteIotDeviceSync(DeleteIotDeviceRequest req)
        {
            return InternalRequestAsync<DeleteIotDeviceResponse>(req, "DeleteIotDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDeviceBatchRequest"/></param>
        /// <returns><see cref="DeleteIotDeviceBatchResponse"/></returns>
        public Task<DeleteIotDeviceBatchResponse> DeleteIotDeviceBatch(DeleteIotDeviceBatchRequest req)
        {
            return InternalRequestAsync<DeleteIotDeviceBatchResponse>(req, "DeleteIotDeviceBatch");
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteIotDeviceBatchRequest"/></param>
        /// <returns><see cref="DeleteIotDeviceBatchResponse"/></returns>
        public DeleteIotDeviceBatchResponse DeleteIotDeviceBatchSync(DeleteIotDeviceBatchRequest req)
        {
            return InternalRequestAsync<DeleteIotDeviceBatchResponse>(req, "DeleteIotDeviceBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消息路由
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageRouteRequest"/></param>
        /// <returns><see cref="DeleteMessageRouteResponse"/></returns>
        public Task<DeleteMessageRouteResponse> DeleteMessageRoute(DeleteMessageRouteRequest req)
        {
            return InternalRequestAsync<DeleteMessageRouteResponse>(req, "DeleteMessageRoute");
        }

        /// <summary>
        /// 删除消息路由
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageRouteRequest"/></param>
        /// <returns><see cref="DeleteMessageRouteResponse"/></returns>
        public DeleteMessageRouteResponse DeleteMessageRouteSync(DeleteMessageRouteRequest req)
        {
            return InternalRequestAsync<DeleteMessageRouteResponse>(req, "DeleteMessageRoute")
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
        /// 删除边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeUnitRequest"/></param>
        /// <returns><see cref="DeleteNodeUnitResponse"/></returns>
        public Task<DeleteNodeUnitResponse> DeleteNodeUnit(DeleteNodeUnitRequest req)
        {
            return InternalRequestAsync<DeleteNodeUnitResponse>(req, "DeleteNodeUnit");
        }

        /// <summary>
        /// 删除边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeUnitRequest"/></param>
        /// <returns><see cref="DeleteNodeUnitResponse"/></returns>
        public DeleteNodeUnitResponse DeleteNodeUnitSync(DeleteNodeUnitRequest req)
        {
            return InternalRequestAsync<DeleteNodeUnitResponse>(req, "DeleteNodeUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Secret
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest req)
        {
            return InternalRequestAsync<DeleteSecretResponse>(req, "DeleteSecret");
        }

        /// <summary>
        /// 删除Secret
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public DeleteSecretResponse DeleteSecretSync(DeleteSecretRequest req)
        {
            return InternalRequestAsync<DeleteSecretResponse>(req, "DeleteSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用模板可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeApplicationVisualizationResponse"/></returns>
        public Task<DescribeApplicationVisualizationResponse> DescribeApplicationVisualization(DescribeApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationVisualizationResponse>(req, "DescribeApplicationVisualization");
        }

        /// <summary>
        /// 获取应用模板可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeApplicationVisualizationResponse"/></returns>
        public DescribeApplicationVisualizationResponse DescribeApplicationVisualizationSync(DescribeApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationVisualizationResponse>(req, "DescribeApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用模板Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlResponse"/></returns>
        public Task<DescribeApplicationYamlResponse> DescribeApplicationYaml(DescribeApplicationYamlRequest req)
        {
            return InternalRequestAsync<DescribeApplicationYamlResponse>(req, "DescribeApplicationYaml");
        }

        /// <summary>
        /// 查询应用模板Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlResponse"/></returns>
        public DescribeApplicationYamlResponse DescribeApplicationYamlSync(DescribeApplicationYamlRequest req)
        {
            return InternalRequestAsync<DescribeApplicationYamlResponse>(req, "DescribeApplicationYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查应用模板的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlErrorResponse"/></returns>
        public Task<DescribeApplicationYamlErrorResponse> DescribeApplicationYamlError(DescribeApplicationYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeApplicationYamlErrorResponse>(req, "DescribeApplicationYamlError");
        }

        /// <summary>
        /// 检查应用模板的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlErrorResponse"/></returns>
        public DescribeApplicationYamlErrorResponse DescribeApplicationYamlErrorSync(DescribeApplicationYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeApplicationYamlErrorResponse>(req, "DescribeApplicationYamlError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// 获取应用模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ConfigMap详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapRequest"/></param>
        /// <returns><see cref="DescribeConfigMapResponse"/></returns>
        public Task<DescribeConfigMapResponse> DescribeConfigMap(DescribeConfigMapRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapResponse>(req, "DescribeConfigMap");
        }

        /// <summary>
        /// 获取ConfigMap详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapRequest"/></param>
        /// <returns><see cref="DescribeConfigMapResponse"/></returns>
        public DescribeConfigMapResponse DescribeConfigMapSync(DescribeConfigMapRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapResponse>(req, "DescribeConfigMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验ConfigMap的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeConfigMapYamlErrorResponse"/></returns>
        public Task<DescribeConfigMapYamlErrorResponse> DescribeConfigMapYamlError(DescribeConfigMapYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapYamlErrorResponse>(req, "DescribeConfigMapYamlError");
        }

        /// <summary>
        /// 校验ConfigMap的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeConfigMapYamlErrorResponse"/></returns>
        public DescribeConfigMapYamlErrorResponse DescribeConfigMapYamlErrorSync(DescribeConfigMapYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapYamlErrorResponse>(req, "DescribeConfigMapYamlError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ConfigMap列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapsRequest"/></param>
        /// <returns><see cref="DescribeConfigMapsResponse"/></returns>
        public Task<DescribeConfigMapsResponse> DescribeConfigMaps(DescribeConfigMapsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapsResponse>(req, "DescribeConfigMaps");
        }

        /// <summary>
        /// 获取ConfigMap列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapsRequest"/></param>
        /// <returns><see cref="DescribeConfigMapsResponse"/></returns>
        public DescribeConfigMapsResponse DescribeConfigMapsSync(DescribeConfigMapsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMapsResponse>(req, "DescribeConfigMaps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自动获取Draco设备的安装包
        /// </summary>
        /// <param name="req"><see cref="DescribeDracoEdgeNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeDracoEdgeNodeInstallerResponse"/></returns>
        public Task<DescribeDracoEdgeNodeInstallerResponse> DescribeDracoEdgeNodeInstaller(DescribeDracoEdgeNodeInstallerRequest req)
        {
            return InternalRequestAsync<DescribeDracoEdgeNodeInstallerResponse>(req, "DescribeDracoEdgeNodeInstaller");
        }

        /// <summary>
        /// 自动获取Draco设备的安装包
        /// </summary>
        /// <param name="req"><see cref="DescribeDracoEdgeNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeDracoEdgeNodeInstallerResponse"/></returns>
        public DescribeDracoEdgeNodeInstallerResponse DescribeDracoEdgeNodeInstallerSync(DescribeDracoEdgeNodeInstallerRequest req)
        {
            return InternalRequestAsync<DescribeDracoEdgeNodeInstallerResponse>(req, "DescribeDracoEdgeNodeInstaller")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取节点安装信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAgentNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeEdgeAgentNodeInstallerResponse"/></returns>
        public Task<DescribeEdgeAgentNodeInstallerResponse> DescribeEdgeAgentNodeInstaller(DescribeEdgeAgentNodeInstallerRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAgentNodeInstallerResponse>(req, "DescribeEdgeAgentNodeInstaller");
        }

        /// <summary>
        /// 获取节点安装信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAgentNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeEdgeAgentNodeInstallerResponse"/></returns>
        public DescribeEdgeAgentNodeInstallerResponse DescribeEdgeAgentNodeInstallerSync(DescribeEdgeAgentNodeInstallerRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAgentNodeInstallerResponse>(req, "DescribeEdgeAgentNodeInstaller")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘集群默认VPC信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeDefaultVpcRequest"/></param>
        /// <returns><see cref="DescribeEdgeDefaultVpcResponse"/></returns>
        public Task<DescribeEdgeDefaultVpcResponse> DescribeEdgeDefaultVpc(DescribeEdgeDefaultVpcRequest req)
        {
            return InternalRequestAsync<DescribeEdgeDefaultVpcResponse>(req, "DescribeEdgeDefaultVpc");
        }

        /// <summary>
        /// 获取边缘集群默认VPC信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeDefaultVpcRequest"/></param>
        /// <returns><see cref="DescribeEdgeDefaultVpcResponse"/></returns>
        public DescribeEdgeDefaultVpcResponse DescribeEdgeDefaultVpcSync(DescribeEdgeDefaultVpcRequest req)
        {
            return InternalRequestAsync<DescribeEdgeDefaultVpcResponse>(req, "DescribeEdgeDefaultVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeResponse"/></returns>
        public Task<DescribeEdgeNodeResponse> DescribeEdgeNode(DescribeEdgeNodeRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodeResponse>(req, "DescribeEdgeNode");
        }

        /// <summary>
        /// 获取边缘节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeResponse"/></returns>
        public DescribeEdgeNodeResponse DescribeEdgeNodeSync(DescribeEdgeNodeRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodeResponse>(req, "DescribeEdgeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节点Pod内的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodContainersResponse"/></returns>
        public Task<DescribeEdgeNodePodContainersResponse> DescribeEdgeNodePodContainers(DescribeEdgeNodePodContainersRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodePodContainersResponse>(req, "DescribeEdgeNodePodContainers");
        }

        /// <summary>
        /// 查询节点Pod内的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodContainersResponse"/></returns>
        public DescribeEdgeNodePodContainersResponse DescribeEdgeNodePodContainersSync(DescribeEdgeNodePodContainersRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodePodContainersResponse>(req, "DescribeEdgeNodePodContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节点Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodsResponse"/></returns>
        public Task<DescribeEdgeNodePodsResponse> DescribeEdgeNodePods(DescribeEdgeNodePodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodePodsResponse>(req, "DescribeEdgeNodePods");
        }

        /// <summary>
        /// 查询节点Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodsResponse"/></returns>
        public DescribeEdgeNodePodsResponse DescribeEdgeNodePodsSync(DescribeEdgeNodePodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodePodsResponse>(req, "DescribeEdgeNodePods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取节点备注信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRemarkListRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeRemarkListResponse"/></returns>
        public Task<DescribeEdgeNodeRemarkListResponse> DescribeEdgeNodeRemarkList(DescribeEdgeNodeRemarkListRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodeRemarkListResponse>(req, "DescribeEdgeNodeRemarkList");
        }

        /// <summary>
        /// 获取节点备注信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRemarkListRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeRemarkListResponse"/></returns>
        public DescribeEdgeNodeRemarkListResponse DescribeEdgeNodeRemarkListSync(DescribeEdgeNodeRemarkListRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodeRemarkListResponse>(req, "DescribeEdgeNodeRemarkList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodesResponse"/></returns>
        public Task<DescribeEdgeNodesResponse> DescribeEdgeNodes(DescribeEdgeNodesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodesResponse>(req, "DescribeEdgeNodes");
        }

        /// <summary>
        /// 查询边缘节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodesResponse"/></returns>
        public DescribeEdgeNodesResponse DescribeEdgeNodesSync(DescribeEdgeNodesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeNodesResponse>(req, "DescribeEdgeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeOperationLogsResponse"/></returns>
        public Task<DescribeEdgeOperationLogsResponse> DescribeEdgeOperationLogs(DescribeEdgeOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeOperationLogsResponse>(req, "DescribeEdgeOperationLogs");
        }

        /// <summary>
        /// 查询边缘操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeOperationLogsResponse"/></returns>
        public DescribeEdgeOperationLogsResponse DescribeEdgeOperationLogsSync(DescribeEdgeOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeOperationLogsResponse>(req, "DescribeEdgeOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元Pod
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePodRequest"/></param>
        /// <returns><see cref="DescribeEdgePodResponse"/></returns>
        public Task<DescribeEdgePodResponse> DescribeEdgePod(DescribeEdgePodRequest req)
        {
            return InternalRequestAsync<DescribeEdgePodResponse>(req, "DescribeEdgePod");
        }

        /// <summary>
        /// 查询边缘单元Pod
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePodRequest"/></param>
        /// <returns><see cref="DescribeEdgePodResponse"/></returns>
        public DescribeEdgePodResponse DescribeEdgePodSync(DescribeEdgePodRequest req)
        {
            return InternalRequestAsync<DescribeEdgePodResponse>(req, "DescribeEdgePod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预注册节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeSnNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeSnNodesResponse"/></returns>
        public Task<DescribeEdgeSnNodesResponse> DescribeEdgeSnNodes(DescribeEdgeSnNodesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeSnNodesResponse>(req, "DescribeEdgeSnNodes");
        }

        /// <summary>
        /// 查询预注册节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeSnNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeSnNodesResponse"/></returns>
        public DescribeEdgeSnNodesResponse DescribeEdgeSnNodesSync(DescribeEdgeSnNodesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeSnNodesResponse>(req, "DescribeEdgeSnNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationEventsResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationEventsResponse> DescribeEdgeUnitApplicationEvents(DescribeEdgeUnitApplicationEventsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationEventsResponse>(req, "DescribeEdgeUnitApplicationEvents");
        }

        /// <summary>
        /// 获取应用事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationEventsResponse"/></returns>
        public DescribeEdgeUnitApplicationEventsResponse DescribeEdgeUnitApplicationEventsSync(DescribeEdgeUnitApplicationEventsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationEventsResponse>(req, "DescribeEdgeUnitApplicationEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationLogsResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationLogsResponse> DescribeEdgeUnitApplicationLogs(DescribeEdgeUnitApplicationLogsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationLogsResponse>(req, "DescribeEdgeUnitApplicationLogs");
        }

        /// <summary>
        /// 获取应用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationLogsResponse"/></returns>
        public DescribeEdgeUnitApplicationLogsResponse DescribeEdgeUnitApplicationLogsSync(DescribeEdgeUnitApplicationLogsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationLogsResponse>(req, "DescribeEdgeUnitApplicationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用容器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodContainersResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationPodContainersResponse> DescribeEdgeUnitApplicationPodContainers(DescribeEdgeUnitApplicationPodContainersRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationPodContainersResponse>(req, "DescribeEdgeUnitApplicationPodContainers");
        }

        /// <summary>
        /// 获取应用容器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodContainersResponse"/></returns>
        public DescribeEdgeUnitApplicationPodContainersResponse DescribeEdgeUnitApplicationPodContainersSync(DescribeEdgeUnitApplicationPodContainersRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationPodContainersResponse>(req, "DescribeEdgeUnitApplicationPodContainers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用下Pod状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodsResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationPodsResponse> DescribeEdgeUnitApplicationPods(DescribeEdgeUnitApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationPodsResponse>(req, "DescribeEdgeUnitApplicationPods");
        }

        /// <summary>
        /// 获取应用下Pod状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodsResponse"/></returns>
        public DescribeEdgeUnitApplicationPodsResponse DescribeEdgeUnitApplicationPodsSync(DescribeEdgeUnitApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationPodsResponse>(req, "DescribeEdgeUnitApplicationPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单元可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationVisualizationResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationVisualizationResponse> DescribeEdgeUnitApplicationVisualization(DescribeEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationVisualizationResponse>(req, "DescribeEdgeUnitApplicationVisualization");
        }

        /// <summary>
        /// 获取单元可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationVisualizationResponse"/></returns>
        public DescribeEdgeUnitApplicationVisualizationResponse DescribeEdgeUnitApplicationVisualizationSync(DescribeEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationVisualizationResponse>(req, "DescribeEdgeUnitApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationYamlResponse> DescribeEdgeUnitApplicationYaml(DescribeEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationYamlResponse>(req, "DescribeEdgeUnitApplicationYaml");
        }

        /// <summary>
        /// 获取应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlResponse"/></returns>
        public DescribeEdgeUnitApplicationYamlResponse DescribeEdgeUnitApplicationYamlSync(DescribeEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationYamlResponse>(req, "DescribeEdgeUnitApplicationYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查单元应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlErrorResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationYamlErrorResponse> DescribeEdgeUnitApplicationYamlError(DescribeEdgeUnitApplicationYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationYamlErrorResponse>(req, "DescribeEdgeUnitApplicationYamlError");
        }

        /// <summary>
        /// 检查单元应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlErrorResponse"/></returns>
        public DescribeEdgeUnitApplicationYamlErrorResponse DescribeEdgeUnitApplicationYamlErrorSync(DescribeEdgeUnitApplicationYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationYamlErrorResponse>(req, "DescribeEdgeUnitApplicationYamlError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单元下应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationsResponse"/></returns>
        public Task<DescribeEdgeUnitApplicationsResponse> DescribeEdgeUnitApplications(DescribeEdgeUnitApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationsResponse>(req, "DescribeEdgeUnitApplications");
        }

        /// <summary>
        /// 获取单元下应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationsResponse"/></returns>
        public DescribeEdgeUnitApplicationsResponse DescribeEdgeUnitApplicationsSync(DescribeEdgeUnitApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitApplicationsResponse>(req, "DescribeEdgeUnitApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitCloudResponse"/></returns>
        public Task<DescribeEdgeUnitCloudResponse> DescribeEdgeUnitCloud(DescribeEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitCloudResponse>(req, "DescribeEdgeUnitCloud");
        }

        /// <summary>
        /// 查询边缘集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitCloudResponse"/></returns>
        public DescribeEdgeUnitCloudResponse DescribeEdgeUnitCloudSync(DescribeEdgeUnitCloudRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitCloudResponse>(req, "DescribeEdgeUnitCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元Grid列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridResponse"/></returns>
        public Task<DescribeEdgeUnitDeployGridResponse> DescribeEdgeUnitDeployGrid(DescribeEdgeUnitDeployGridRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridResponse>(req, "DescribeEdgeUnitDeployGrid");
        }

        /// <summary>
        /// 查询边缘单元Grid列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridResponse"/></returns>
        public DescribeEdgeUnitDeployGridResponse DescribeEdgeUnitDeployGridSync(DescribeEdgeUnitDeployGridRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridResponse>(req, "DescribeEdgeUnitDeployGrid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元指定Grid下的部署应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemResponse"/></returns>
        public Task<DescribeEdgeUnitDeployGridItemResponse> DescribeEdgeUnitDeployGridItem(DescribeEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridItemResponse>(req, "DescribeEdgeUnitDeployGridItem");
        }

        /// <summary>
        /// 查询边缘单元指定Grid下的部署应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemResponse"/></returns>
        public DescribeEdgeUnitDeployGridItemResponse DescribeEdgeUnitDeployGridItemSync(DescribeEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridItemResponse>(req, "DescribeEdgeUnitDeployGridItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定Grid下应用的Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemYamlResponse"/></returns>
        public Task<DescribeEdgeUnitDeployGridItemYamlResponse> DescribeEdgeUnitDeployGridItemYaml(DescribeEdgeUnitDeployGridItemYamlRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridItemYamlResponse>(req, "DescribeEdgeUnitDeployGridItemYaml");
        }

        /// <summary>
        /// 查询指定Grid下应用的Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemYamlResponse"/></returns>
        public DescribeEdgeUnitDeployGridItemYamlResponse DescribeEdgeUnitDeployGridItemYamlSync(DescribeEdgeUnitDeployGridItemYamlRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitDeployGridItemYamlResponse>(req, "DescribeEdgeUnitDeployGridItemYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元额外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitExtraRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitExtraResponse"/></returns>
        public Task<DescribeEdgeUnitExtraResponse> DescribeEdgeUnitExtra(DescribeEdgeUnitExtraRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitExtraResponse>(req, "DescribeEdgeUnitExtra");
        }

        /// <summary>
        /// 查询边缘单元额外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitExtraRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitExtraResponse"/></returns>
        public DescribeEdgeUnitExtraResponse DescribeEdgeUnitExtraSync(DescribeEdgeUnitExtraRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitExtraResponse>(req, "DescribeEdgeUnitExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元Grid事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridEventsResponse"/></returns>
        public Task<DescribeEdgeUnitGridEventsResponse> DescribeEdgeUnitGridEvents(DescribeEdgeUnitGridEventsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitGridEventsResponse>(req, "DescribeEdgeUnitGridEvents");
        }

        /// <summary>
        /// 查询边缘单元Grid事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridEventsResponse"/></returns>
        public DescribeEdgeUnitGridEventsResponse DescribeEdgeUnitGridEventsSync(DescribeEdgeUnitGridEventsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitGridEventsResponse>(req, "DescribeEdgeUnitGridEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元Grid的Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridPodsResponse"/></returns>
        public Task<DescribeEdgeUnitGridPodsResponse> DescribeEdgeUnitGridPods(DescribeEdgeUnitGridPodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitGridPodsResponse>(req, "DescribeEdgeUnitGridPods");
        }

        /// <summary>
        /// 查询边缘单元Grid的Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridPodsResponse"/></returns>
        public DescribeEdgeUnitGridPodsResponse DescribeEdgeUnitGridPodsSync(DescribeEdgeUnitGridPodsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitGridPodsResponse>(req, "DescribeEdgeUnitGridPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘集群监控状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitMonitorStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitMonitorStatusResponse"/></returns>
        public Task<DescribeEdgeUnitMonitorStatusResponse> DescribeEdgeUnitMonitorStatus(DescribeEdgeUnitMonitorStatusRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitMonitorStatusResponse>(req, "DescribeEdgeUnitMonitorStatus");
        }

        /// <summary>
        /// 查询边缘集群监控状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitMonitorStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitMonitorStatusResponse"/></returns>
        public DescribeEdgeUnitMonitorStatusResponse DescribeEdgeUnitMonitorStatusSync(DescribeEdgeUnitMonitorStatusRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitMonitorStatusResponse>(req, "DescribeEdgeUnitMonitorStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘集群NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeGroupResponse"/></returns>
        public Task<DescribeEdgeUnitNodeGroupResponse> DescribeEdgeUnitNodeGroup(DescribeEdgeUnitNodeGroupRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitNodeGroupResponse>(req, "DescribeEdgeUnitNodeGroup");
        }

        /// <summary>
        /// 查询边缘集群NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeGroupResponse"/></returns>
        public DescribeEdgeUnitNodeGroupResponse DescribeEdgeUnitNodeGroupSync(DescribeEdgeUnitNodeGroupRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitNodeGroupResponse>(req, "DescribeEdgeUnitNodeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元EdgeUnit模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeUnitTemplatesResponse"/></returns>
        public Task<DescribeEdgeUnitNodeUnitTemplatesResponse> DescribeEdgeUnitNodeUnitTemplates(DescribeEdgeUnitNodeUnitTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitNodeUnitTemplatesResponse>(req, "DescribeEdgeUnitNodeUnitTemplates");
        }

        /// <summary>
        /// 查询边缘单元EdgeUnit模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeUnitTemplatesResponse"/></returns>
        public DescribeEdgeUnitNodeUnitTemplatesResponse DescribeEdgeUnitNodeUnitTemplatesSync(DescribeEdgeUnitNodeUnitTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitNodeUnitTemplatesResponse>(req, "DescribeEdgeUnitNodeUnitTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitsCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitsCloudResponse"/></returns>
        public Task<DescribeEdgeUnitsCloudResponse> DescribeEdgeUnitsCloud(DescribeEdgeUnitsCloudRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitsCloudResponse>(req, "DescribeEdgeUnitsCloud");
        }

        /// <summary>
        /// 查询边缘单元列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitsCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitsCloudResponse"/></returns>
        public DescribeEdgeUnitsCloudResponse DescribeEdgeUnitsCloudSync(DescribeEdgeUnitsCloudRequest req)
        {
            return InternalRequestAsync<DescribeEdgeUnitsCloudResponse>(req, "DescribeEdgeUnitsCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDeviceRequest"/></param>
        /// <returns><see cref="DescribeIotDeviceResponse"/></returns>
        public Task<DescribeIotDeviceResponse> DescribeIotDevice(DescribeIotDeviceRequest req)
        {
            return InternalRequestAsync<DescribeIotDeviceResponse>(req, "DescribeIotDevice");
        }

        /// <summary>
        /// 获取设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDeviceRequest"/></param>
        /// <returns><see cref="DescribeIotDeviceResponse"/></returns>
        public DescribeIotDeviceResponse DescribeIotDeviceSync(DescribeIotDeviceRequest req)
        {
            return InternalRequestAsync<DescribeIotDeviceResponse>(req, "DescribeIotDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDevicesRequest"/></param>
        /// <returns><see cref="DescribeIotDevicesResponse"/></returns>
        public Task<DescribeIotDevicesResponse> DescribeIotDevices(DescribeIotDevicesRequest req)
        {
            return InternalRequestAsync<DescribeIotDevicesResponse>(req, "DescribeIotDevices");
        }

        /// <summary>
        /// 获取设备列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIotDevicesRequest"/></param>
        /// <returns><see cref="DescribeIotDevicesResponse"/></returns>
        public DescribeIotDevicesResponse DescribeIotDevicesSync(DescribeIotDevicesRequest req)
        {
            return InternalRequestAsync<DescribeIotDevicesResponse>(req, "DescribeIotDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消息路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageRouteListRequest"/></param>
        /// <returns><see cref="DescribeMessageRouteListResponse"/></returns>
        public Task<DescribeMessageRouteListResponse> DescribeMessageRouteList(DescribeMessageRouteListRequest req)
        {
            return InternalRequestAsync<DescribeMessageRouteListResponse>(req, "DescribeMessageRouteList");
        }

        /// <summary>
        /// 获取消息路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageRouteListRequest"/></param>
        /// <returns><see cref="DescribeMessageRouteListResponse"/></returns>
        public DescribeMessageRouteListResponse DescribeMessageRouteListSync(DescribeMessageRouteListRequest req)
        {
            return InternalRequestAsync<DescribeMessageRouteListResponse>(req, "DescribeMessageRouteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorMetricsRequest"/></param>
        /// <returns><see cref="DescribeMonitorMetricsResponse"/></returns>
        public Task<DescribeMonitorMetricsResponse> DescribeMonitorMetrics(DescribeMonitorMetricsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorMetricsResponse>(req, "DescribeMonitorMetrics");
        }

        /// <summary>
        /// 查询边缘单元监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorMetricsRequest"/></param>
        /// <returns><see cref="DescribeMonitorMetricsResponse"/></returns>
        public DescribeMonitorMetricsResponse DescribeMonitorMetricsSync(DescribeMonitorMetricsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorMetricsResponse>(req, "DescribeMonitorMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResponse"/></returns>
        public Task<DescribeNamespaceResponse> DescribeNamespace(DescribeNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceResponse>(req, "DescribeNamespace");
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResponse"/></returns>
        public DescribeNamespaceResponse DescribeNamespaceSync(DescribeNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceResponse>(req, "DescribeNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命名空间下的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceResourcesRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResourcesResponse"/></returns>
        public Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResources(DescribeNamespaceResourcesRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceResourcesResponse>(req, "DescribeNamespaceResources");
        }

        /// <summary>
        /// 获取命名空间下的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceResourcesRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResourcesResponse"/></returns>
        public DescribeNamespaceResourcesResponse DescribeNamespaceResourcesSync(DescribeNamespaceResourcesRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceResourcesResponse>(req, "DescribeNamespaceResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命名空间列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces");
        }

        /// <summary>
        /// 获取命名空间列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘单元NodeUnit列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitResponse"/></returns>
        public Task<DescribeNodeUnitResponse> DescribeNodeUnit(DescribeNodeUnitRequest req)
        {
            return InternalRequestAsync<DescribeNodeUnitResponse>(req, "DescribeNodeUnit");
        }

        /// <summary>
        /// 查询边缘单元NodeUnit列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitResponse"/></returns>
        public DescribeNodeUnitResponse DescribeNodeUnitSync(DescribeNodeUnitRequest req)
        {
            return InternalRequestAsync<DescribeNodeUnitResponse>(req, "DescribeNodeUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定NodeGroup下NodeUnit模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitTemplateOnNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitTemplateOnNodeGroupResponse"/></returns>
        public Task<DescribeNodeUnitTemplateOnNodeGroupResponse> DescribeNodeUnitTemplateOnNodeGroup(DescribeNodeUnitTemplateOnNodeGroupRequest req)
        {
            return InternalRequestAsync<DescribeNodeUnitTemplateOnNodeGroupResponse>(req, "DescribeNodeUnitTemplateOnNodeGroup");
        }

        /// <summary>
        /// 查询指定NodeGroup下NodeUnit模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitTemplateOnNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitTemplateOnNodeGroupResponse"/></returns>
        public DescribeNodeUnitTemplateOnNodeGroupResponse DescribeNodeUnitTemplateOnNodeGroupSync(DescribeNodeUnitTemplateOnNodeGroupRequest req)
        {
            return InternalRequestAsync<DescribeNodeUnitTemplateOnNodeGroupResponse>(req, "DescribeNodeUnitTemplateOnNodeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Secret详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest req)
        {
            return InternalRequestAsync<DescribeSecretResponse>(req, "DescribeSecret");
        }

        /// <summary>
        /// 获取Secret详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public DescribeSecretResponse DescribeSecretSync(DescribeSecretRequest req)
        {
            return InternalRequestAsync<DescribeSecretResponse>(req, "DescribeSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验Secret的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeSecretYamlErrorResponse"/></returns>
        public Task<DescribeSecretYamlErrorResponse> DescribeSecretYamlError(DescribeSecretYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeSecretYamlErrorResponse>(req, "DescribeSecretYamlError");
        }

        /// <summary>
        /// 校验Secret的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeSecretYamlErrorResponse"/></returns>
        public DescribeSecretYamlErrorResponse DescribeSecretYamlErrorSync(DescribeSecretYamlErrorRequest req)
        {
            return InternalRequestAsync<DescribeSecretYamlErrorResponse>(req, "DescribeSecretYamlError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Secrets列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretsRequest"/></param>
        /// <returns><see cref="DescribeSecretsResponse"/></returns>
        public Task<DescribeSecretsResponse> DescribeSecrets(DescribeSecretsRequest req)
        {
            return InternalRequestAsync<DescribeSecretsResponse>(req, "DescribeSecrets");
        }

        /// <summary>
        /// 获取Secrets列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretsRequest"/></param>
        /// <returns><see cref="DescribeSecretsResponse"/></returns>
        public DescribeSecretsResponse DescribeSecretsSync(DescribeSecretsRequest req)
        {
            return InternalRequestAsync<DescribeSecretsResponse>(req, "DescribeSecrets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的资源限制
        /// </summary>
        /// <param name="req"><see cref="DescribeYeheResourceLimitRequest"/></param>
        /// <returns><see cref="DescribeYeheResourceLimitResponse"/></returns>
        public Task<DescribeYeheResourceLimitResponse> DescribeYeheResourceLimit(DescribeYeheResourceLimitRequest req)
        {
            return InternalRequestAsync<DescribeYeheResourceLimitResponse>(req, "DescribeYeheResourceLimit");
        }

        /// <summary>
        /// 查询用户的资源限制
        /// </summary>
        /// <param name="req"><see cref="DescribeYeheResourceLimitRequest"/></param>
        /// <returns><see cref="DescribeYeheResourceLimitResponse"/></returns>
        public DescribeYeheResourceLimitResponse DescribeYeheResourceLimitSync(DescribeYeheResourceLimitRequest req)
        {
            return InternalRequestAsync<DescribeYeheResourceLimitResponse>(req, "DescribeYeheResourceLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组件市场的组件信息
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentRequest"/></param>
        /// <returns><see cref="GetMarketComponentResponse"/></returns>
        public Task<GetMarketComponentResponse> GetMarketComponent(GetMarketComponentRequest req)
        {
            return InternalRequestAsync<GetMarketComponentResponse>(req, "GetMarketComponent");
        }

        /// <summary>
        /// 获取组件市场的组件信息
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentRequest"/></param>
        /// <returns><see cref="GetMarketComponentResponse"/></returns>
        public GetMarketComponentResponse GetMarketComponentSync(GetMarketComponentRequest req)
        {
            return InternalRequestAsync<GetMarketComponentResponse>(req, "GetMarketComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组件市场组件列表
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentListRequest"/></param>
        /// <returns><see cref="GetMarketComponentListResponse"/></returns>
        public Task<GetMarketComponentListResponse> GetMarketComponentList(GetMarketComponentListRequest req)
        {
            return InternalRequestAsync<GetMarketComponentListResponse>(req, "GetMarketComponentList");
        }

        /// <summary>
        /// 获取组件市场组件列表
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentListRequest"/></param>
        /// <returns><see cref="GetMarketComponentListResponse"/></returns>
        public GetMarketComponentListResponse GetMarketComponentListSync(GetMarketComponentListRequest req)
        {
            return InternalRequestAsync<GetMarketComponentListResponse>(req, "GetMarketComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用模板基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBasicInfoResponse"/></returns>
        public Task<ModifyApplicationBasicInfoResponse> ModifyApplicationBasicInfo(ModifyApplicationBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationBasicInfoResponse>(req, "ModifyApplicationBasicInfo");
        }

        /// <summary>
        /// 修改应用模板基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBasicInfoResponse"/></returns>
        public ModifyApplicationBasicInfoResponse ModifyApplicationBasicInfoSync(ModifyApplicationBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationBasicInfoResponse>(req, "ModifyApplicationBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyApplicationVisualizationResponse"/></returns>
        public Task<ModifyApplicationVisualizationResponse> ModifyApplicationVisualization(ModifyApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationVisualizationResponse>(req, "ModifyApplicationVisualization");
        }

        /// <summary>
        /// 修改应用模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyApplicationVisualizationResponse"/></returns>
        public ModifyApplicationVisualizationResponse ModifyApplicationVisualizationSync(ModifyApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationVisualizationResponse>(req, "ModifyApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改ConfigMap
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigMapRequest"/></param>
        /// <returns><see cref="ModifyConfigMapResponse"/></returns>
        public Task<ModifyConfigMapResponse> ModifyConfigMap(ModifyConfigMapRequest req)
        {
            return InternalRequestAsync<ModifyConfigMapResponse>(req, "ModifyConfigMap");
        }

        /// <summary>
        /// 修改ConfigMap
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigMapRequest"/></param>
        /// <returns><see cref="ModifyConfigMapResponse"/></returns>
        public ModifyConfigMapResponse ModifyConfigMapSync(ModifyConfigMapRequest req)
        {
            return InternalRequestAsync<ModifyConfigMapResponse>(req, "ModifyConfigMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑draco设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeDracoNodeRequest"/></param>
        /// <returns><see cref="ModifyEdgeDracoNodeResponse"/></returns>
        public Task<ModifyEdgeDracoNodeResponse> ModifyEdgeDracoNode(ModifyEdgeDracoNodeRequest req)
        {
            return InternalRequestAsync<ModifyEdgeDracoNodeResponse>(req, "ModifyEdgeDracoNode");
        }

        /// <summary>
        /// 编辑draco设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeDracoNodeRequest"/></param>
        /// <returns><see cref="ModifyEdgeDracoNodeResponse"/></returns>
        public ModifyEdgeDracoNodeResponse ModifyEdgeDracoNodeSync(ModifyEdgeDracoNodeRequest req)
        {
            return InternalRequestAsync<ModifyEdgeDracoNodeResponse>(req, "ModifyEdgeDracoNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑边缘节点标签
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeNodeLabelsRequest"/></param>
        /// <returns><see cref="ModifyEdgeNodeLabelsResponse"/></returns>
        public Task<ModifyEdgeNodeLabelsResponse> ModifyEdgeNodeLabels(ModifyEdgeNodeLabelsRequest req)
        {
            return InternalRequestAsync<ModifyEdgeNodeLabelsResponse>(req, "ModifyEdgeNodeLabels");
        }

        /// <summary>
        /// 编辑边缘节点标签
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeNodeLabelsRequest"/></param>
        /// <returns><see cref="ModifyEdgeNodeLabelsResponse"/></returns>
        public ModifyEdgeNodeLabelsResponse ModifyEdgeNodeLabelsSync(ModifyEdgeNodeLabelsRequest req)
        {
            return InternalRequestAsync<ModifyEdgeNodeLabelsResponse>(req, "ModifyEdgeNodeLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘集群
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitResponse"/></returns>
        public Task<ModifyEdgeUnitResponse> ModifyEdgeUnit(ModifyEdgeUnitRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitResponse>(req, "ModifyEdgeUnit");
        }

        /// <summary>
        /// 修改边缘集群
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitResponse"/></returns>
        public ModifyEdgeUnitResponse ModifyEdgeUnitSync(ModifyEdgeUnitRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitResponse>(req, "ModifyEdgeUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改单元应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationBasicInfoResponse"/></returns>
        public Task<ModifyEdgeUnitApplicationBasicInfoResponse> ModifyEdgeUnitApplicationBasicInfo(ModifyEdgeUnitApplicationBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationBasicInfoResponse>(req, "ModifyEdgeUnitApplicationBasicInfo");
        }

        /// <summary>
        /// 修改单元应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationBasicInfoResponse"/></returns>
        public ModifyEdgeUnitApplicationBasicInfoResponse ModifyEdgeUnitApplicationBasicInfoSync(ModifyEdgeUnitApplicationBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationBasicInfoResponse>(req, "ModifyEdgeUnitApplicationBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可视化修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationVisualizationResponse"/></returns>
        public Task<ModifyEdgeUnitApplicationVisualizationResponse> ModifyEdgeUnitApplicationVisualization(ModifyEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationVisualizationResponse>(req, "ModifyEdgeUnitApplicationVisualization");
        }

        /// <summary>
        /// 可视化修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationVisualizationResponse"/></returns>
        public ModifyEdgeUnitApplicationVisualizationResponse ModifyEdgeUnitApplicationVisualizationSync(ModifyEdgeUnitApplicationVisualizationRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationVisualizationResponse>(req, "ModifyEdgeUnitApplicationVisualization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Yaml方式修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationYamlResponse"/></returns>
        public Task<ModifyEdgeUnitApplicationYamlResponse> ModifyEdgeUnitApplicationYaml(ModifyEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationYamlResponse>(req, "ModifyEdgeUnitApplicationYaml");
        }

        /// <summary>
        /// Yaml方式修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationYamlResponse"/></returns>
        public ModifyEdgeUnitApplicationYamlResponse ModifyEdgeUnitApplicationYamlSync(ModifyEdgeUnitApplicationYamlRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitApplicationYamlResponse>(req, "ModifyEdgeUnitApplicationYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新边缘单元信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitCloudApiRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitCloudApiResponse"/></returns>
        public Task<ModifyEdgeUnitCloudApiResponse> ModifyEdgeUnitCloudApi(ModifyEdgeUnitCloudApiRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitCloudApiResponse>(req, "ModifyEdgeUnitCloudApi");
        }

        /// <summary>
        /// 更新边缘单元信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitCloudApiRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitCloudApiResponse"/></returns>
        public ModifyEdgeUnitCloudApiResponse ModifyEdgeUnitCloudApiSync(ModifyEdgeUnitCloudApiRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitCloudApiResponse>(req, "ModifyEdgeUnitCloudApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘单元Grid部署应用副本数
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitDeployGridItemResponse"/></returns>
        public Task<ModifyEdgeUnitDeployGridItemResponse> ModifyEdgeUnitDeployGridItem(ModifyEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitDeployGridItemResponse>(req, "ModifyEdgeUnitDeployGridItem");
        }

        /// <summary>
        /// 修改边缘单元Grid部署应用副本数
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitDeployGridItemResponse"/></returns>
        public ModifyEdgeUnitDeployGridItemResponse ModifyEdgeUnitDeployGridItemSync(ModifyEdgeUnitDeployGridItemRequest req)
        {
            return InternalRequestAsync<ModifyEdgeUnitDeployGridItemResponse>(req, "ModifyEdgeUnitDeployGridItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyIotDeviceRequest"/></param>
        /// <returns><see cref="ModifyIotDeviceResponse"/></returns>
        public Task<ModifyIotDeviceResponse> ModifyIotDevice(ModifyIotDeviceRequest req)
        {
            return InternalRequestAsync<ModifyIotDeviceResponse>(req, "ModifyIotDevice");
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyIotDeviceRequest"/></param>
        /// <returns><see cref="ModifyIotDeviceResponse"/></returns>
        public ModifyIotDeviceResponse ModifyIotDeviceSync(ModifyIotDeviceRequest req)
        {
            return InternalRequestAsync<ModifyIotDeviceResponse>(req, "ModifyIotDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="ModifyNodeUnitTemplateResponse"/></returns>
        public Task<ModifyNodeUnitTemplateResponse> ModifyNodeUnitTemplate(ModifyNodeUnitTemplateRequest req)
        {
            return InternalRequestAsync<ModifyNodeUnitTemplateResponse>(req, "ModifyNodeUnitTemplate");
        }

        /// <summary>
        /// 修改边缘单元NodeUnit模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="ModifyNodeUnitTemplateResponse"/></returns>
        public ModifyNodeUnitTemplateResponse ModifyNodeUnitTemplateSync(ModifyNodeUnitTemplateRequest req)
        {
            return InternalRequestAsync<ModifyNodeUnitTemplateResponse>(req, "ModifyNodeUnitTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Secret
        /// </summary>
        /// <param name="req"><see cref="ModifySecretRequest"/></param>
        /// <returns><see cref="ModifySecretResponse"/></returns>
        public Task<ModifySecretResponse> ModifySecret(ModifySecretRequest req)
        {
            return InternalRequestAsync<ModifySecretResponse>(req, "ModifySecret");
        }

        /// <summary>
        /// 修改Secret
        /// </summary>
        /// <param name="req"><see cref="ModifySecretRequest"/></param>
        /// <returns><see cref="ModifySecretResponse"/></returns>
        public ModifySecretResponse ModifySecretSync(ModifySecretRequest req)
        {
            return InternalRequestAsync<ModifySecretResponse>(req, "ModifySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 单元应用重部署
        /// </summary>
        /// <param name="req"><see cref="RedeployEdgeUnitApplicationRequest"/></param>
        /// <returns><see cref="RedeployEdgeUnitApplicationResponse"/></returns>
        public Task<RedeployEdgeUnitApplicationResponse> RedeployEdgeUnitApplication(RedeployEdgeUnitApplicationRequest req)
        {
            return InternalRequestAsync<RedeployEdgeUnitApplicationResponse>(req, "RedeployEdgeUnitApplication");
        }

        /// <summary>
        /// 单元应用重部署
        /// </summary>
        /// <param name="req"><see cref="RedeployEdgeUnitApplicationRequest"/></param>
        /// <returns><see cref="RedeployEdgeUnitApplicationResponse"/></returns>
        public RedeployEdgeUnitApplicationResponse RedeployEdgeUnitApplicationSync(RedeployEdgeUnitApplicationRequest req)
        {
            return InternalRequestAsync<RedeployEdgeUnitApplicationResponse>(req, "RedeployEdgeUnitApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开关消息路由
        /// </summary>
        /// <param name="req"><see cref="SetRouteOnOffRequest"/></param>
        /// <returns><see cref="SetRouteOnOffResponse"/></returns>
        public Task<SetRouteOnOffResponse> SetRouteOnOff(SetRouteOnOffRequest req)
        {
            return InternalRequestAsync<SetRouteOnOffResponse>(req, "SetRouteOnOff");
        }

        /// <summary>
        /// 开关消息路由
        /// </summary>
        /// <param name="req"><see cref="SetRouteOnOffRequest"/></param>
        /// <returns><see cref="SetRouteOnOffResponse"/></returns>
        public SetRouteOnOffResponse SetRouteOnOffSync(SetRouteOnOffRequest req)
        {
            return InternalRequestAsync<SetRouteOnOffResponse>(req, "SetRouteOnOff")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
