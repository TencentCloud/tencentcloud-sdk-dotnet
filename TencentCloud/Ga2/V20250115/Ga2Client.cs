/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ga2.V20250115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ga2.V20250115.Models;

   public class Ga2Client : AbstractClient{

       private const string endpoint = "ga2.tencentcloudapi.com";
       private const string version = "2025-01-15";
       private const string sdkVersion = "SDK_NET_3.0.1401";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public Ga2Client(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public Ga2Client(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建加速地域
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerateAreasRequest"/></param>
        /// <returns><see cref="CreateAccelerateAreasResponse"/></returns>
        public Task<CreateAccelerateAreasResponse> CreateAccelerateAreas(CreateAccelerateAreasRequest req)
        {
            return InternalRequestAsync<CreateAccelerateAreasResponse>(req, "CreateAccelerateAreas");
        }

        /// <summary>
        /// 创建加速地域
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerateAreasRequest"/></param>
        /// <returns><see cref="CreateAccelerateAreasResponse"/></returns>
        public CreateAccelerateAreasResponse CreateAccelerateAreasSync(CreateAccelerateAreasRequest req)
        {
            return InternalRequestAsync<CreateAccelerateAreasResponse>(req, "CreateAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建终端节点组。
        /// </summary>
        /// <param name="req"><see cref="CreateEndpointGroupRequest"/></param>
        /// <returns><see cref="CreateEndpointGroupResponse"/></returns>
        public Task<CreateEndpointGroupResponse> CreateEndpointGroup(CreateEndpointGroupRequest req)
        {
            return InternalRequestAsync<CreateEndpointGroupResponse>(req, "CreateEndpointGroup");
        }

        /// <summary>
        /// 创建终端节点组。
        /// </summary>
        /// <param name="req"><see cref="CreateEndpointGroupRequest"/></param>
        /// <returns><see cref="CreateEndpointGroupResponse"/></returns>
        public CreateEndpointGroupResponse CreateEndpointGroupSync(CreateEndpointGroupRequest req)
        {
            return InternalRequestAsync<CreateEndpointGroupResponse>(req, "CreateEndpointGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建七层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingRuleRequest"/></param>
        /// <returns><see cref="CreateForwardingRuleResponse"/></returns>
        public Task<CreateForwardingRuleResponse> CreateForwardingRule(CreateForwardingRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardingRuleResponse>(req, "CreateForwardingRule");
        }

        /// <summary>
        /// 创建七层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingRuleRequest"/></param>
        /// <returns><see cref="CreateForwardingRuleResponse"/></returns>
        public CreateForwardingRuleResponse CreateForwardingRuleSync(CreateForwardingRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardingRuleResponse>(req, "CreateForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建全球加速实例
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorResponse"/></returns>
        public Task<CreateGlobalAcceleratorResponse> CreateGlobalAccelerator(CreateGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorResponse>(req, "CreateGlobalAccelerator");
        }

        /// <summary>
        /// 创建全球加速实例
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorResponse"/></returns>
        public CreateGlobalAcceleratorResponse CreateGlobalAcceleratorSync(CreateGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorResponse>(req, "CreateGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建监听器
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// 创建监听器
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除加速地域
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerateAreasRequest"/></param>
        /// <returns><see cref="DeleteAccelerateAreasResponse"/></returns>
        public Task<DeleteAccelerateAreasResponse> DeleteAccelerateAreas(DeleteAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DeleteAccelerateAreasResponse>(req, "DeleteAccelerateAreas");
        }

        /// <summary>
        /// 删除加速地域
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerateAreasRequest"/></param>
        /// <returns><see cref="DeleteAccelerateAreasResponse"/></returns>
        public DeleteAccelerateAreasResponse DeleteAccelerateAreasSync(DeleteAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DeleteAccelerateAreasResponse>(req, "DeleteAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除终端节点组。
        /// </summary>
        /// <param name="req"><see cref="DeleteEndpointGroupsRequest"/></param>
        /// <returns><see cref="DeleteEndpointGroupsResponse"/></returns>
        public Task<DeleteEndpointGroupsResponse> DeleteEndpointGroups(DeleteEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DeleteEndpointGroupsResponse>(req, "DeleteEndpointGroups");
        }

        /// <summary>
        /// 删除终端节点组。
        /// </summary>
        /// <param name="req"><see cref="DeleteEndpointGroupsRequest"/></param>
        /// <returns><see cref="DeleteEndpointGroupsResponse"/></returns>
        public DeleteEndpointGroupsResponse DeleteEndpointGroupsSync(DeleteEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DeleteEndpointGroupsResponse>(req, "DeleteEndpointGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardingRuleResponse"/></returns>
        public Task<DeleteForwardingRuleResponse> DeleteForwardingRule(DeleteForwardingRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardingRuleResponse>(req, "DeleteForwardingRule");
        }

        /// <summary>
        /// 删除七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardingRuleResponse"/></returns>
        public DeleteForwardingRuleResponse DeleteForwardingRuleSync(DeleteForwardingRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardingRuleResponse>(req, "DeleteForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除全球加速实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorResponse"/></returns>
        public Task<DeleteGlobalAcceleratorResponse> DeleteGlobalAccelerator(DeleteGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorResponse>(req, "DeleteGlobalAccelerator");
        }

        /// <summary>
        /// 删除全球加速实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorResponse"/></returns>
        public DeleteGlobalAcceleratorResponse DeleteGlobalAcceleratorSync(DeleteGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorResponse>(req, "DeleteGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// 删除监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询加速地域
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateAreasRequest"/></param>
        /// <returns><see cref="DescribeAccelerateAreasResponse"/></returns>
        public Task<DescribeAccelerateAreasResponse> DescribeAccelerateAreas(DescribeAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateAreasResponse>(req, "DescribeAccelerateAreas");
        }

        /// <summary>
        /// 查询加速地域
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateAreasRequest"/></param>
        /// <returns><see cref="DescribeAccelerateAreasResponse"/></returns>
        public DescribeAccelerateAreasResponse DescribeAccelerateAreasSync(DescribeAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateAreasResponse>(req, "DescribeAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可选加速区域
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccelerateRegionsResponse"/></returns>
        public Task<DescribeAccelerateRegionsResponse> DescribeAccelerateRegions(DescribeAccelerateRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateRegionsResponse>(req, "DescribeAccelerateRegions");
        }

        /// <summary>
        /// 查询可选加速区域
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccelerateRegionsResponse"/></returns>
        public DescribeAccelerateRegionsResponse DescribeAccelerateRegionsSync(DescribeAccelerateRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateRegionsResponse>(req, "DescribeAccelerateRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询跨境账单
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public Task<DescribeCrossBorderSettlementResponse> DescribeCrossBorderSettlement(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement");
        }

        /// <summary>
        /// 查询跨境账单
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public DescribeCrossBorderSettlementResponse DescribeCrossBorderSettlementSync(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询终端节点组。
        /// </summary>
        /// <param name="req"><see cref="DescribeEndpointGroupsRequest"/></param>
        /// <returns><see cref="DescribeEndpointGroupsResponse"/></returns>
        public Task<DescribeEndpointGroupsResponse> DescribeEndpointGroups(DescribeEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DescribeEndpointGroupsResponse>(req, "DescribeEndpointGroups");
        }

        /// <summary>
        /// 查询终端节点组。
        /// </summary>
        /// <param name="req"><see cref="DescribeEndpointGroupsRequest"/></param>
        /// <returns><see cref="DescribeEndpointGroupsResponse"/></returns>
        public DescribeEndpointGroupsResponse DescribeEndpointGroupsSync(DescribeEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DescribeEndpointGroupsResponse>(req, "DescribeEndpointGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardingRuleResponse"/></returns>
        public Task<DescribeForwardingRuleResponse> DescribeForwardingRule(DescribeForwardingRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardingRuleResponse>(req, "DescribeForwardingRule");
        }

        /// <summary>
        /// 查看七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardingRuleResponse"/></returns>
        public DescribeForwardingRuleResponse DescribeForwardingRuleSync(DescribeForwardingRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardingRuleResponse>(req, "DescribeForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改全球加速实例
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorsRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorsResponse"/></returns>
        public Task<DescribeGlobalAcceleratorsResponse> DescribeGlobalAccelerators(DescribeGlobalAcceleratorsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorsResponse>(req, "DescribeGlobalAccelerators");
        }

        /// <summary>
        /// 修改全球加速实例
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorsRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorsResponse"/></returns>
        public DescribeGlobalAcceleratorsResponse DescribeGlobalAcceleratorsSync(DescribeGlobalAcceleratorsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorsResponse>(req, "DescribeGlobalAccelerators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监听器
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// 查询监听器
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改加速地域
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerateAreasRequest"/></param>
        /// <returns><see cref="ModifyAccelerateAreasResponse"/></returns>
        public Task<ModifyAccelerateAreasResponse> ModifyAccelerateAreas(ModifyAccelerateAreasRequest req)
        {
            return InternalRequestAsync<ModifyAccelerateAreasResponse>(req, "ModifyAccelerateAreas");
        }

        /// <summary>
        /// 修改加速地域
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerateAreasRequest"/></param>
        /// <returns><see cref="ModifyAccelerateAreasResponse"/></returns>
        public ModifyAccelerateAreasResponse ModifyAccelerateAreasSync(ModifyAccelerateAreasRequest req)
        {
            return InternalRequestAsync<ModifyAccelerateAreasResponse>(req, "ModifyAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改终端节点组。
        /// </summary>
        /// <param name="req"><see cref="ModifyEndpointGroupRequest"/></param>
        /// <returns><see cref="ModifyEndpointGroupResponse"/></returns>
        public Task<ModifyEndpointGroupResponse> ModifyEndpointGroup(ModifyEndpointGroupRequest req)
        {
            return InternalRequestAsync<ModifyEndpointGroupResponse>(req, "ModifyEndpointGroup");
        }

        /// <summary>
        /// 修改终端节点组。
        /// </summary>
        /// <param name="req"><see cref="ModifyEndpointGroupRequest"/></param>
        /// <returns><see cref="ModifyEndpointGroupResponse"/></returns>
        public ModifyEndpointGroupResponse ModifyEndpointGroupSync(ModifyEndpointGroupRequest req)
        {
            return InternalRequestAsync<ModifyEndpointGroupResponse>(req, "ModifyEndpointGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改七层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardingRuleResponse"/></returns>
        public Task<ModifyForwardingRuleResponse> ModifyForwardingRule(ModifyForwardingRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardingRuleResponse>(req, "ModifyForwardingRule");
        }

        /// <summary>
        /// 修改七层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardingRuleResponse"/></returns>
        public ModifyForwardingRuleResponse ModifyForwardingRuleSync(ModifyForwardingRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardingRuleResponse>(req, "ModifyForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改全球加速实例
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorResponse"/></returns>
        public Task<ModifyGlobalAcceleratorResponse> ModifyGlobalAccelerator(ModifyGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorResponse>(req, "ModifyGlobalAccelerator");
        }

        /// <summary>
        /// 修改全球加速实例
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorResponse"/></returns>
        public ModifyGlobalAcceleratorResponse ModifyGlobalAcceleratorSync(ModifyGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorResponse>(req, "ModifyGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改监听器
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// 修改监听器
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
