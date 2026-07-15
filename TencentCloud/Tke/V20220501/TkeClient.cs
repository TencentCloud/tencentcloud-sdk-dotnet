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
       private const string sdkVersion = "SDK_NET_3.0.1463";

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
        /// **通过 CAM 策略强制节点池安全配置**
        /// 
        /// 创建原生节点池（`CreateNodePool`）接口已接入 CAM 条件鉴权，会根据请求参数计算出一组**条件键（Condition Key）**并传入 CAM 鉴权。您可以在 CAM/SCP 策略中基于这些条件键配置 `deny` 规则，从而强制约束节点池的安全配置（如必须开启磁盘加密、安全加固等）。
        /// 
        /// **支持的条件键**
        /// 
        /// | 条件键 | 含义 | 取值 | 取值判定说明 |
        /// |--------|------|------|-------------|
        /// | `tke:NodePoolType` | 节点池类型 | `Native` / `External` | 取请求的节点池类型，未指定时默认为 `Native` |
        /// | `tke:SystemDiskEncrypted` | 系统盘是否加密 | `true` / `false` | 系统盘加密属性为 `ENCRYPT`（大小写不敏感）时为 `true`，否则为 `false` |
        /// | `tke:AllDataDisksEncrypted` | 所有数据盘是否都已加密 | `true` / `false` | 全部数据盘加密属性均为 `ENCRYPT` 时为 `true`；未配置数据盘时也为 `true`；只要有任一数据盘未加密即为 `false` |
        /// | `tke:SecurityAgentEnabled` | 是否开启安全加固（Security Agent） | `true` / `false` | 开启安全加固时为 `true`，否则为 `false` |
        /// 
        /// > 说明：所有条件键的取值均为字符串 `"true"` / `"false"`，请在策略中使用字符串形式匹配。
        /// 
        /// **使用方式**
        /// 
        /// 在 CAM 策略中使用 `bool_equal` 匹配条件键值为 `"false"`，配合 `effect: deny`，即可实现"未满足安全配置则拒绝创建节点池"的强制约束。
        /// 
        /// **示例一：强制开启安全加固**
        /// 
        /// 创建节点池时若未开启安全加固（`tke:SecurityAgentEnabled = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:SecurityAgentEnabled": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **示例二：强制数据盘加密**
        /// 
        /// 创建节点池时若存在未加密的数据盘（`tke:AllDataDisksEncrypted = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:AllDataDisksEncrypted": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **示例三：强制系统盘加密**
        /// 
        /// 创建节点池时若系统盘未加密（`tke:SystemDiskEncrypted = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:SystemDiskEncrypted": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **注意事项**
        /// 
        /// - 上述条件键在**未配置任何 CAM 策略**时不会影响节点池创建，仅在您显式配置了对应 `deny` 策略时才生效。
        /// - 如需同时强制多项安全配置，必须在同一策略的 `statement` 中配置多条 `deny` 规则，不能将多个条件键写入同一条 `condition`。
        /// - `tke:AllDataDisksEncrypted` 在**无数据盘**场景下取值为 `true`（不存在未加密的数据盘），因此仅约束"已配置的数据盘必须加密"，不会强制要求必须挂载数据盘。
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public Task<CreateNodePoolResponse> CreateNodePool(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool");
        }

        /// <summary>
        /// **通过 CAM 策略强制节点池安全配置**
        /// 
        /// 创建原生节点池（`CreateNodePool`）接口已接入 CAM 条件鉴权，会根据请求参数计算出一组**条件键（Condition Key）**并传入 CAM 鉴权。您可以在 CAM/SCP 策略中基于这些条件键配置 `deny` 规则，从而强制约束节点池的安全配置（如必须开启磁盘加密、安全加固等）。
        /// 
        /// **支持的条件键**
        /// 
        /// | 条件键 | 含义 | 取值 | 取值判定说明 |
        /// |--------|------|------|-------------|
        /// | `tke:NodePoolType` | 节点池类型 | `Native` / `External` | 取请求的节点池类型，未指定时默认为 `Native` |
        /// | `tke:SystemDiskEncrypted` | 系统盘是否加密 | `true` / `false` | 系统盘加密属性为 `ENCRYPT`（大小写不敏感）时为 `true`，否则为 `false` |
        /// | `tke:AllDataDisksEncrypted` | 所有数据盘是否都已加密 | `true` / `false` | 全部数据盘加密属性均为 `ENCRYPT` 时为 `true`；未配置数据盘时也为 `true`；只要有任一数据盘未加密即为 `false` |
        /// | `tke:SecurityAgentEnabled` | 是否开启安全加固（Security Agent） | `true` / `false` | 开启安全加固时为 `true`，否则为 `false` |
        /// 
        /// > 说明：所有条件键的取值均为字符串 `"true"` / `"false"`，请在策略中使用字符串形式匹配。
        /// 
        /// **使用方式**
        /// 
        /// 在 CAM 策略中使用 `bool_equal` 匹配条件键值为 `"false"`，配合 `effect: deny`，即可实现"未满足安全配置则拒绝创建节点池"的强制约束。
        /// 
        /// **示例一：强制开启安全加固**
        /// 
        /// 创建节点池时若未开启安全加固（`tke:SecurityAgentEnabled = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:SecurityAgentEnabled": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **示例二：强制数据盘加密**
        /// 
        /// 创建节点池时若存在未加密的数据盘（`tke:AllDataDisksEncrypted = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:AllDataDisksEncrypted": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **示例三：强制系统盘加密**
        /// 
        /// 创建节点池时若系统盘未加密（`tke:SystemDiskEncrypted = "false"`），则拒绝。
        /// 
        /// ```json
        /// {
        ///     "version": "2.0",
        ///     "statement": [
        ///         {
        ///             "effect": "deny",
        ///             "action": ["tke:CreateNodePool"],
        ///             "resource": ["*"],
        ///             "condition": {
        ///                 "bool_equal": {
        ///                     "tke:SystemDiskEncrypted": "false"
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }
        /// ```
        /// 
        /// **注意事项**
        /// 
        /// - 上述条件键在**未配置任何 CAM 策略**时不会影响节点池创建，仅在您显式配置了对应 `deny` 策略时才生效。
        /// - 如需同时强制多项安全配置，必须在同一策略的 `statement` 中配置多条 `deny` 规则，不能将多个条件键写入同一条 `condition`。
        /// - `tke:AllDataDisksEncrypted` 在**无数据盘**场景下取值为 `true`（不存在未加密的数据盘），因此仅约束"已配置的数据盘必须加密"，不会强制要求必须挂载数据盘。
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public CreateNodePoolResponse CreateNodePoolSync(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除原生节点池节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterMachinesRequest"/></param>
        /// <returns><see cref="DeleteClusterMachinesResponse"/></returns>
        public Task<DeleteClusterMachinesResponse> DeleteClusterMachines(DeleteClusterMachinesRequest req)
        {
            return InternalRequestAsync<DeleteClusterMachinesResponse>(req, "DeleteClusterMachines");
        }

        /// <summary>
        /// 删除原生节点池节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterMachinesRequest"/></param>
        /// <returns><see cref="DeleteClusterMachinesResponse"/></returns>
        public DeleteClusterMachinesResponse DeleteClusterMachinesSync(DeleteClusterMachinesRequest req)
        {
            return InternalRequestAsync<DeleteClusterMachinesResponse>(req, "DeleteClusterMachines")
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
        /// 查询托原生点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMachinesRequest"/></param>
        /// <returns><see cref="DescribeClusterMachinesResponse"/></returns>
        public Task<DescribeClusterMachinesResponse> DescribeClusterMachines(DescribeClusterMachinesRequest req)
        {
            return InternalRequestAsync<DescribeClusterMachinesResponse>(req, "DescribeClusterMachines");
        }

        /// <summary>
        /// 查询托原生点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMachinesRequest"/></param>
        /// <returns><see cref="DescribeClusterMachinesResponse"/></returns>
        public DescribeClusterMachinesResponse DescribeClusterMachinesSync(DescribeClusterMachinesRequest req)
        {
            return InternalRequestAsync<DescribeClusterMachinesResponse>(req, "DescribeClusterMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 请求该接口，会返回所有适配该机型和操作系统组合的gpu驱动版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGPUInfoRequest"/></param>
        /// <returns><see cref="DescribeGPUInfoResponse"/></returns>
        public Task<DescribeGPUInfoResponse> DescribeGPUInfo(DescribeGPUInfoRequest req)
        {
            return InternalRequestAsync<DescribeGPUInfoResponse>(req, "DescribeGPUInfo");
        }

        /// <summary>
        /// 请求该接口，会返回所有适配该机型和操作系统组合的gpu驱动版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGPUInfoRequest"/></param>
        /// <returns><see cref="DescribeGPUInfoResponse"/></returns>
        public DescribeGPUInfoResponse DescribeGPUInfoSync(DescribeGPUInfoRequest req)
        {
            return InternalRequestAsync<DescribeGPUInfoResponse>(req, "DescribeGPUInfo")
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
        /// 查询节点池健康度相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsElasticityStrengthRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsElasticityStrengthResponse"/></returns>
        public Task<DescribeNodePoolsElasticityStrengthResponse> DescribeNodePoolsElasticityStrength(DescribeNodePoolsElasticityStrengthRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsElasticityStrengthResponse>(req, "DescribeNodePoolsElasticityStrength");
        }

        /// <summary>
        /// 查询节点池健康度相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsElasticityStrengthRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsElasticityStrengthResponse"/></returns>
        public DescribeNodePoolsElasticityStrengthResponse DescribeNodePoolsElasticityStrengthSync(DescribeNodePoolsElasticityStrengthRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsElasticityStrengthResponse>(req, "DescribeNodePoolsElasticityStrength")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询原生节点机型配置
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public Task<DescribeZoneInstanceConfigInfosResponse> DescribeZoneInstanceConfigInfos(DescribeZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeZoneInstanceConfigInfosResponse>(req, "DescribeZoneInstanceConfigInfos");
        }

        /// <summary>
        /// 查询原生节点机型配置
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeZoneInstanceConfigInfosResponse"/></returns>
        public DescribeZoneInstanceConfigInfosResponse DescribeZoneInstanceConfigInfosSync(DescribeZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeZoneInstanceConfigInfosResponse>(req, "DescribeZoneInstanceConfigInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改原生节点
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public Task<ModifyClusterMachineResponse> ModifyClusterMachine(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine");
        }

        /// <summary>
        /// 修改原生节点
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public ModifyClusterMachineResponse ModifyClusterMachineSync(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine")
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

        /// <summary>
        /// 重启原生节点实例
        /// </summary>
        /// <param name="req"><see cref="RebootMachinesRequest"/></param>
        /// <returns><see cref="RebootMachinesResponse"/></returns>
        public Task<RebootMachinesResponse> RebootMachines(RebootMachinesRequest req)
        {
            return InternalRequestAsync<RebootMachinesResponse>(req, "RebootMachines");
        }

        /// <summary>
        /// 重启原生节点实例
        /// </summary>
        /// <param name="req"><see cref="RebootMachinesRequest"/></param>
        /// <returns><see cref="RebootMachinesResponse"/></returns>
        public RebootMachinesResponse RebootMachinesSync(RebootMachinesRequest req)
        {
            return InternalRequestAsync<RebootMachinesResponse>(req, "RebootMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置 TKE 节点池期望节点数
        /// </summary>
        /// <param name="req"><see cref="ScaleNodePoolRequest"/></param>
        /// <returns><see cref="ScaleNodePoolResponse"/></returns>
        public Task<ScaleNodePoolResponse> ScaleNodePool(ScaleNodePoolRequest req)
        {
            return InternalRequestAsync<ScaleNodePoolResponse>(req, "ScaleNodePool");
        }

        /// <summary>
        /// 设置 TKE 节点池期望节点数
        /// </summary>
        /// <param name="req"><see cref="ScaleNodePoolRequest"/></param>
        /// <returns><see cref="ScaleNodePoolResponse"/></returns>
        public ScaleNodePoolResponse ScaleNodePoolSync(ScaleNodePoolRequest req)
        {
            return InternalRequestAsync<ScaleNodePoolResponse>(req, "ScaleNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置是否开启节点登录
        /// </summary>
        /// <param name="req"><see cref="SetMachineLoginRequest"/></param>
        /// <returns><see cref="SetMachineLoginResponse"/></returns>
        public Task<SetMachineLoginResponse> SetMachineLogin(SetMachineLoginRequest req)
        {
            return InternalRequestAsync<SetMachineLoginResponse>(req, "SetMachineLogin");
        }

        /// <summary>
        /// 设置是否开启节点登录
        /// </summary>
        /// <param name="req"><see cref="SetMachineLoginRequest"/></param>
        /// <returns><see cref="SetMachineLoginResponse"/></returns>
        public SetMachineLoginResponse SetMachineLoginSync(SetMachineLoginRequest req)
        {
            return InternalRequestAsync<SetMachineLoginResponse>(req, "SetMachineLogin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (StartMachines) 用于启动一个或多个原生节点实例。
        /// 
        /// 只有状态为 Stopped 的实例才可以进行此操作。
        /// 接口调用成功后，等待一分钟左右，实例会进入 Running 状态。
        /// 支持批量操作。每次请求批量实例的上限为100。
        /// 本接口为同步接口，启动实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeClusterInstances 接口查询，如果实例的状态为 Running，则代表启动实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartMachinesRequest"/></param>
        /// <returns><see cref="StartMachinesResponse"/></returns>
        public Task<StartMachinesResponse> StartMachines(StartMachinesRequest req)
        {
            return InternalRequestAsync<StartMachinesResponse>(req, "StartMachines");
        }

        /// <summary>
        /// 本接口 (StartMachines) 用于启动一个或多个原生节点实例。
        /// 
        /// 只有状态为 Stopped 的实例才可以进行此操作。
        /// 接口调用成功后，等待一分钟左右，实例会进入 Running 状态。
        /// 支持批量操作。每次请求批量实例的上限为100。
        /// 本接口为同步接口，启动实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeClusterInstances 接口查询，如果实例的状态为 Running，则代表启动实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StartMachinesRequest"/></param>
        /// <returns><see cref="StartMachinesResponse"/></returns>
        public StartMachinesResponse StartMachinesSync(StartMachinesRequest req)
        {
            return InternalRequestAsync<StartMachinesResponse>(req, "StartMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (StopMachines) 用于关闭一个或多个原生节点实例。
        /// 
        /// 只有状态为 Running 的实例才可以进行此操作。
        /// 接口调用成功时，实例会进入 Stopping 状态；关闭实例成功时，实例会进入 Stopped 状态。
        /// 支持强制关闭。强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// 支持批量操作。每次请求批量实例的上限为 100。
        /// 本接口为同步接口，关闭实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeClusterInstances 接口查询，如果实例的状态为stopped_with_charging，则代表关闭实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopMachinesRequest"/></param>
        /// <returns><see cref="StopMachinesResponse"/></returns>
        public Task<StopMachinesResponse> StopMachines(StopMachinesRequest req)
        {
            return InternalRequestAsync<StopMachinesResponse>(req, "StopMachines");
        }

        /// <summary>
        /// 本接口 (StopMachines) 用于关闭一个或多个原生节点实例。
        /// 
        /// 只有状态为 Running 的实例才可以进行此操作。
        /// 接口调用成功时，实例会进入 Stopping 状态；关闭实例成功时，实例会进入 Stopped 状态。
        /// 支持强制关闭。强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// 支持批量操作。每次请求批量实例的上限为 100。
        /// 本接口为同步接口，关闭实例请求发送成功后会返回一个RequestId，此时操作并未立即完成。实例操作结果可以通过调用 DescribeClusterInstances 接口查询，如果实例的状态为stopped_with_charging，则代表关闭实例操作成功。
        /// </summary>
        /// <param name="req"><see cref="StopMachinesRequest"/></param>
        /// <returns><see cref="StopMachinesResponse"/></returns>
        public StopMachinesResponse StopMachinesSync(StopMachinesRequest req)
        {
            return InternalRequestAsync<StopMachinesResponse>(req, "StopMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
