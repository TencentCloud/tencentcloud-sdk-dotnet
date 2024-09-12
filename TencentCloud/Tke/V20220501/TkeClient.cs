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

namespace TencentCloud.Tke.V20220501
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20220501.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2022-05-01";
       private const string sdkVersion = "SDK_NET_3.0.1087";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建健康检测策略
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="CreateHealthCheckPolicyResponse"/></returns>
        public Task<CreateHealthCheckPolicyResponse> CreateHealthCheckPolicy(CreateHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckPolicyResponse>(req, "CreateHealthCheckPolicy");
        }

        /// <summary>
        /// 创建健康检测策略
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="CreateHealthCheckPolicyResponse"/></returns>
        public CreateHealthCheckPolicyResponse CreateHealthCheckPolicySync(CreateHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckPolicyResponse>(req, "CreateHealthCheckPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public Task<CreateNodePoolResponse> CreateNodePool(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool");
        }

        /// <summary>
        /// 创建 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public CreateNodePoolResponse CreateNodePoolSync(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除健康检测策略
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckPolicyResponse"/></returns>
        public Task<DeleteHealthCheckPolicyResponse> DeleteHealthCheckPolicy(DeleteHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckPolicyResponse>(req, "DeleteHealthCheckPolicy");
        }

        /// <summary>
        /// 删除健康检测策略
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckPolicyResponse"/></returns>
        public DeleteHealthCheckPolicyResponse DeleteHealthCheckPolicySync(DeleteHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckPolicyResponse>(req, "DeleteHealthCheckPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteNodePoolRequest"/></param>
        /// <returns><see cref="DeleteNodePoolResponse"/></returns>
        public Task<DeleteNodePoolResponse> DeleteNodePool(DeleteNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteNodePoolResponse>(req, "DeleteNodePool");
        }

        /// <summary>
        /// 删除 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteNodePoolRequest"/></param>
        /// <returns><see cref="DeleteNodePoolResponse"/></returns>
        public DeleteNodePoolResponse DeleteNodePoolSync(DeleteNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteNodePoolResponse>(req, "DeleteNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询健康检测策略
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckPoliciesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckPoliciesResponse"/></returns>
        public Task<DescribeHealthCheckPoliciesResponse> DescribeHealthCheckPolicies(DescribeHealthCheckPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckPoliciesResponse>(req, "DescribeHealthCheckPolicies");
        }

        /// <summary>
        /// 查询健康检测策略
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckPoliciesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckPoliciesResponse"/></returns>
        public DescribeHealthCheckPoliciesResponse DescribeHealthCheckPoliciesSync(DescribeHealthCheckPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckPoliciesResponse>(req, "DescribeHealthCheckPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询健康检测策略绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckPolicyBindingsRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckPolicyBindingsResponse"/></returns>
        public Task<DescribeHealthCheckPolicyBindingsResponse> DescribeHealthCheckPolicyBindings(DescribeHealthCheckPolicyBindingsRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckPolicyBindingsResponse>(req, "DescribeHealthCheckPolicyBindings");
        }

        /// <summary>
        /// 查询健康检测策略绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckPolicyBindingsRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckPolicyBindingsResponse"/></returns>
        public DescribeHealthCheckPolicyBindingsResponse DescribeHealthCheckPolicyBindingsSync(DescribeHealthCheckPolicyBindingsRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckPolicyBindingsResponse>(req, "DescribeHealthCheckPolicyBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询健康检测策略模板
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplateResponse"/></returns>
        public Task<DescribeHealthCheckTemplateResponse> DescribeHealthCheckTemplate(DescribeHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplateResponse>(req, "DescribeHealthCheckTemplate");
        }

        /// <summary>
        /// 查询健康检测策略模板
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplateResponse"/></returns>
        public DescribeHealthCheckTemplateResponse DescribeHealthCheckTemplateSync(DescribeHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplateResponse>(req, "DescribeHealthCheckTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TKE 节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsResponse"/></returns>
        public Task<DescribeNodePoolsResponse> DescribeNodePools(DescribeNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsResponse>(req, "DescribeNodePools");
        }

        /// <summary>
        /// 查询 TKE 节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsResponse"/></returns>
        public DescribeNodePoolsResponse DescribeNodePoolsSync(DescribeNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsResponse>(req, "DescribeNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改健康检测策略
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckPolicyResponse"/></returns>
        public Task<ModifyHealthCheckPolicyResponse> ModifyHealthCheckPolicy(ModifyHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckPolicyResponse>(req, "ModifyHealthCheckPolicy");
        }

        /// <summary>
        /// 修改健康检测策略
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckPolicyRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckPolicyResponse"/></returns>
        public ModifyHealthCheckPolicyResponse ModifyHealthCheckPolicySync(ModifyHealthCheckPolicyRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckPolicyResponse>(req, "ModifyHealthCheckPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolRequest"/></param>
        /// <returns><see cref="ModifyNodePoolResponse"/></returns>
        public Task<ModifyNodePoolResponse> ModifyNodePool(ModifyNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolResponse>(req, "ModifyNodePool");
        }

        /// <summary>
        /// 更新 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolRequest"/></param>
        /// <returns><see cref="ModifyNodePoolResponse"/></returns>
        public ModifyNodePoolResponse ModifyNodePoolSync(ModifyNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolResponse>(req, "ModifyNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
