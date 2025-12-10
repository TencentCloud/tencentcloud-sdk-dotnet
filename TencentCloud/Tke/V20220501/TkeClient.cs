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
       private const string sdkVersion = "SDK_NET_3.0.1359";

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
