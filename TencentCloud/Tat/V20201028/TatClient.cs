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

namespace TencentCloud.Tat.V20201028
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tat.V20201028.Models;

   public class TatClient : AbstractClient{

       private const string endpoint = "tat.tencentcloudapi.com";
       private const string version = "2020-10-28";
       private const string sdkVersion = "SDK_NET_3.0.1217";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TatClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 取消一台或多台实例执行的命令
        /// 
        /// * 如果命令还未下发到agent，任务状态处于PENDING、DELIVERING、DELIVER_DELAYED，取消后任务状态是CANCELLED
        /// * 如果命令已下发到agent，任务状态处于RUNNING， 取消后任务状态是TERMINATED
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public Task<CancelInvocationResponse> CancelInvocation(CancelInvocationRequest req)
        {
            return InternalRequestAsync<CancelInvocationResponse>(req, "CancelInvocation");
        }

        /// <summary>
        /// 取消一台或多台实例执行的命令
        /// 
        /// * 如果命令还未下发到agent，任务状态处于PENDING、DELIVERING、DELIVER_DELAYED，取消后任务状态是CANCELLED
        /// * 如果命令已下发到agent，任务状态处于RUNNING， 取消后任务状态是TERMINATED
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public CancelInvocationResponse CancelInvocationSync(CancelInvocationRequest req)
        {
            return InternalRequestAsync<CancelInvocationResponse>(req, "CancelInvocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于创建命令。
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public Task<CreateCommandResponse> CreateCommand(CreateCommandRequest req)
        {
            return InternalRequestAsync<CreateCommandResponse>(req, "CreateCommand");
        }

        /// <summary>
        /// 此接口用于创建命令。
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public CreateCommandResponse CreateCommandSync(CreateCommandRequest req)
        {
            return InternalRequestAsync<CreateCommandResponse>(req, "CreateCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于创建执行器。
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public Task<CreateInvokerResponse> CreateInvoker(CreateInvokerRequest req)
        {
            return InternalRequestAsync<CreateInvokerResponse>(req, "CreateInvoker");
        }

        /// <summary>
        /// 此接口用于创建执行器。
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public CreateInvokerResponse CreateInvokerSync(CreateInvokerRequest req)
        {
            return InternalRequestAsync<CreateInvokerResponse>(req, "CreateInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于创建注册码。
        /// </summary>
        /// <param name="req"><see cref="CreateRegisterCodeRequest"/></param>
        /// <returns><see cref="CreateRegisterCodeResponse"/></returns>
        public Task<CreateRegisterCodeResponse> CreateRegisterCode(CreateRegisterCodeRequest req)
        {
            return InternalRequestAsync<CreateRegisterCodeResponse>(req, "CreateRegisterCode");
        }

        /// <summary>
        /// 接口用于创建注册码。
        /// </summary>
        /// <param name="req"><see cref="CreateRegisterCodeRequest"/></param>
        /// <returns><see cref="CreateRegisterCodeResponse"/></returns>
        public CreateRegisterCodeResponse CreateRegisterCodeSync(CreateRegisterCodeRequest req)
        {
            return InternalRequestAsync<CreateRegisterCodeResponse>(req, "CreateRegisterCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除命令。
        /// 如果命令与执行器关联，则无法被删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public Task<DeleteCommandResponse> DeleteCommand(DeleteCommandRequest req)
        {
            return InternalRequestAsync<DeleteCommandResponse>(req, "DeleteCommand");
        }

        /// <summary>
        /// 此接口用于删除命令。
        /// 如果命令与执行器关联，则无法被删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public DeleteCommandResponse DeleteCommandSync(DeleteCommandRequest req)
        {
            return InternalRequestAsync<DeleteCommandResponse>(req, "DeleteCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除命令接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandsRequest"/></param>
        /// <returns><see cref="DeleteCommandsResponse"/></returns>
        public Task<DeleteCommandsResponse> DeleteCommands(DeleteCommandsRequest req)
        {
            return InternalRequestAsync<DeleteCommandsResponse>(req, "DeleteCommands");
        }

        /// <summary>
        /// 批量删除命令接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandsRequest"/></param>
        /// <returns><see cref="DeleteCommandsResponse"/></returns>
        public DeleteCommandsResponse DeleteCommandsSync(DeleteCommandsRequest req)
        {
            return InternalRequestAsync<DeleteCommandsResponse>(req, "DeleteCommands")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除执行器。
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public Task<DeleteInvokerResponse> DeleteInvoker(DeleteInvokerRequest req)
        {
            return InternalRequestAsync<DeleteInvokerResponse>(req, "DeleteInvoker");
        }

        /// <summary>
        /// 此接口用于删除执行器。
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public DeleteInvokerResponse DeleteInvokerSync(DeleteInvokerRequest req)
        {
            return InternalRequestAsync<DeleteInvokerResponse>(req, "DeleteInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于批量删除注册码。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterCodesRequest"/></param>
        /// <returns><see cref="DeleteRegisterCodesResponse"/></returns>
        public Task<DeleteRegisterCodesResponse> DeleteRegisterCodes(DeleteRegisterCodesRequest req)
        {
            return InternalRequestAsync<DeleteRegisterCodesResponse>(req, "DeleteRegisterCodes");
        }

        /// <summary>
        /// 此接口用于批量删除注册码。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterCodesRequest"/></param>
        /// <returns><see cref="DeleteRegisterCodesResponse"/></returns>
        public DeleteRegisterCodesResponse DeleteRegisterCodesSync(DeleteRegisterCodesRequest req)
        {
            return InternalRequestAsync<DeleteRegisterCodesResponse>(req, "DeleteRegisterCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于删除托管实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterInstanceRequest"/></param>
        /// <returns><see cref="DeleteRegisterInstanceResponse"/></returns>
        public Task<DeleteRegisterInstanceResponse> DeleteRegisterInstance(DeleteRegisterInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRegisterInstanceResponse>(req, "DeleteRegisterInstance");
        }

        /// <summary>
        /// 接口用于删除托管实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterInstanceRequest"/></param>
        /// <returns><see cref="DeleteRegisterInstanceResponse"/></returns>
        public DeleteRegisterInstanceResponse DeleteRegisterInstanceSync(DeleteRegisterInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRegisterInstanceResponse>(req, "DeleteRegisterInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询自动化助手客户端的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public Task<DescribeAutomationAgentStatusResponse> DescribeAutomationAgentStatus(DescribeAutomationAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeAutomationAgentStatusResponse>(req, "DescribeAutomationAgentStatus");
        }

        /// <summary>
        /// 此接口用于查询自动化助手客户端的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public DescribeAutomationAgentStatusResponse DescribeAutomationAgentStatusSync(DescribeAutomationAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeAutomationAgentStatusResponse>(req, "DescribeAutomationAgentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询命令详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public Task<DescribeCommandsResponse> DescribeCommands(DescribeCommandsRequest req)
        {
            return InternalRequestAsync<DescribeCommandsResponse>(req, "DescribeCommands");
        }

        /// <summary>
        /// 此接口用于查询命令详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public DescribeCommandsResponse DescribeCommandsSync(DescribeCommandsRequest req)
        {
            return InternalRequestAsync<DescribeCommandsResponse>(req, "DescribeCommands")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询执行任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public Task<DescribeInvocationTasksResponse> DescribeInvocationTasks(DescribeInvocationTasksRequest req)
        {
            return InternalRequestAsync<DescribeInvocationTasksResponse>(req, "DescribeInvocationTasks");
        }

        /// <summary>
        /// 此接口用于查询执行任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public DescribeInvocationTasksResponse DescribeInvocationTasksSync(DescribeInvocationTasksRequest req)
        {
            return InternalRequestAsync<DescribeInvocationTasksResponse>(req, "DescribeInvocationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询执行活动详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public Task<DescribeInvocationsResponse> DescribeInvocations(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations");
        }

        /// <summary>
        /// 此接口用于查询执行活动详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public DescribeInvocationsResponse DescribeInvocationsSync(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询执行器的执行记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public Task<DescribeInvokerRecordsResponse> DescribeInvokerRecords(DescribeInvokerRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInvokerRecordsResponse>(req, "DescribeInvokerRecords");
        }

        /// <summary>
        /// 此接口用于查询执行器的执行记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public DescribeInvokerRecordsResponse DescribeInvokerRecordsSync(DescribeInvokerRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInvokerRecordsResponse>(req, "DescribeInvokerRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询执行器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public Task<DescribeInvokersResponse> DescribeInvokers(DescribeInvokersRequest req)
        {
            return InternalRequestAsync<DescribeInvokersResponse>(req, "DescribeInvokers");
        }

        /// <summary>
        /// 此接口用于查询执行器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public DescribeInvokersResponse DescribeInvokersSync(DescribeInvokersRequest req)
        {
            return InternalRequestAsync<DescribeInvokersResponse>(req, "DescribeInvokers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于获取配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest req)
        {
            return InternalRequestAsync<DescribeQuotasResponse>(req, "DescribeQuotas");
        }

        /// <summary>
        /// 此接口用于获取配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public DescribeQuotasResponse DescribeQuotasSync(DescribeQuotasRequest req)
        {
            return InternalRequestAsync<DescribeQuotasResponse>(req, "DescribeQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询 TAT 产品后台地域列表。
        /// RegionState 为 AVAILABLE，代表该地域的 TAT 后台服务已经可用；未返回，代表该地域的 TAT 后台服务尚不可用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 此接口用于查询 TAT 产品后台地域列表。
        /// RegionState 为 AVAILABLE，代表该地域的 TAT 后台服务已经可用；未返回，代表该地域的 TAT 后台服务尚不可用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于查询注册码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterCodesRequest"/></param>
        /// <returns><see cref="DescribeRegisterCodesResponse"/></returns>
        public Task<DescribeRegisterCodesResponse> DescribeRegisterCodes(DescribeRegisterCodesRequest req)
        {
            return InternalRequestAsync<DescribeRegisterCodesResponse>(req, "DescribeRegisterCodes");
        }

        /// <summary>
        /// 接口用于查询注册码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterCodesRequest"/></param>
        /// <returns><see cref="DescribeRegisterCodesResponse"/></returns>
        public DescribeRegisterCodesResponse DescribeRegisterCodesSync(DescribeRegisterCodesRequest req)
        {
            return InternalRequestAsync<DescribeRegisterCodesResponse>(req, "DescribeRegisterCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于查询被托管的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterInstancesRequest"/></param>
        /// <returns><see cref="DescribeRegisterInstancesResponse"/></returns>
        public Task<DescribeRegisterInstancesResponse> DescribeRegisterInstances(DescribeRegisterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRegisterInstancesResponse>(req, "DescribeRegisterInstances");
        }

        /// <summary>
        /// 接口用于查询被托管的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterInstancesRequest"/></param>
        /// <returns><see cref="DescribeRegisterInstancesResponse"/></returns>
        public DescribeRegisterInstancesResponse DescribeRegisterInstancesSync(DescribeRegisterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRegisterInstancesResponse>(req, "DescribeRegisterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于查询场景详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes");
        }

        /// <summary>
        /// 此接口用于查询场景详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于停止执行器。
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public Task<DisableInvokerResponse> DisableInvoker(DisableInvokerRequest req)
        {
            return InternalRequestAsync<DisableInvokerResponse>(req, "DisableInvoker");
        }

        /// <summary>
        /// 此接口用于停止执行器。
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public DisableInvokerResponse DisableInvokerSync(DisableInvokerRequest req)
        {
            return InternalRequestAsync<DisableInvokerResponse>(req, "DisableInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于批量禁用注册码。
        /// </summary>
        /// <param name="req"><see cref="DisableRegisterCodesRequest"/></param>
        /// <returns><see cref="DisableRegisterCodesResponse"/></returns>
        public Task<DisableRegisterCodesResponse> DisableRegisterCodes(DisableRegisterCodesRequest req)
        {
            return InternalRequestAsync<DisableRegisterCodesResponse>(req, "DisableRegisterCodes");
        }

        /// <summary>
        /// 此接口用于批量禁用注册码。
        /// </summary>
        /// <param name="req"><see cref="DisableRegisterCodesRequest"/></param>
        /// <returns><see cref="DisableRegisterCodesResponse"/></returns>
        public DisableRegisterCodesResponse DisableRegisterCodesSync(DisableRegisterCodesRequest req)
        {
            return InternalRequestAsync<DisableRegisterCodesResponse>(req, "DisableRegisterCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于启用执行器。
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public Task<EnableInvokerResponse> EnableInvoker(EnableInvokerRequest req)
        {
            return InternalRequestAsync<EnableInvokerResponse>(req, "EnableInvoker");
        }

        /// <summary>
        /// 此接口用于启用执行器。
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public EnableInvokerResponse EnableInvokerSync(EnableInvokerRequest req)
        {
            return InternalRequestAsync<EnableInvokerResponse>(req, "EnableInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在指定的实例上触发命令，调用成功返回执行活动ID（inv-xxxxxxxx），每个执行活动内部有一个或多个执行任务（invt-xxxxxxxx），每个执行任务代表命令在一台 CVM 或一台 Lighthouse 上的执行记录。
        /// 
        /// * 如果指定实例未安装 agent，或 agent 不在线，返回失败
        /// * 如果命令类型与 agent 运行环境不符，返回失败
        /// * 指定的实例需要处于 VPC 网络
        /// * 指定的实例需要处于 RUNNING 状态
        /// * 不可同时指定 CVM 和 Lighthouse
        /// </summary>
        /// <param name="req"><see cref="InvokeCommandRequest"/></param>
        /// <returns><see cref="InvokeCommandResponse"/></returns>
        public Task<InvokeCommandResponse> InvokeCommand(InvokeCommandRequest req)
        {
            return InternalRequestAsync<InvokeCommandResponse>(req, "InvokeCommand");
        }

        /// <summary>
        /// 在指定的实例上触发命令，调用成功返回执行活动ID（inv-xxxxxxxx），每个执行活动内部有一个或多个执行任务（invt-xxxxxxxx），每个执行任务代表命令在一台 CVM 或一台 Lighthouse 上的执行记录。
        /// 
        /// * 如果指定实例未安装 agent，或 agent 不在线，返回失败
        /// * 如果命令类型与 agent 运行环境不符，返回失败
        /// * 指定的实例需要处于 VPC 网络
        /// * 指定的实例需要处于 RUNNING 状态
        /// * 不可同时指定 CVM 和 Lighthouse
        /// </summary>
        /// <param name="req"><see cref="InvokeCommandRequest"/></param>
        /// <returns><see cref="InvokeCommandResponse"/></returns>
        public InvokeCommandResponse InvokeCommandSync(InvokeCommandRequest req)
        {
            return InternalRequestAsync<InvokeCommandResponse>(req, "InvokeCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于修改命令。
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public Task<ModifyCommandResponse> ModifyCommand(ModifyCommandRequest req)
        {
            return InternalRequestAsync<ModifyCommandResponse>(req, "ModifyCommand");
        }

        /// <summary>
        /// 此接口用于修改命令。
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public ModifyCommandResponse ModifyCommandSync(ModifyCommandRequest req)
        {
            return InternalRequestAsync<ModifyCommandResponse>(req, "ModifyCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于修改执行器。
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public Task<ModifyInvokerResponse> ModifyInvoker(ModifyInvokerRequest req)
        {
            return InternalRequestAsync<ModifyInvokerResponse>(req, "ModifyInvoker");
        }

        /// <summary>
        /// 此接口用于修改执行器。
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public ModifyInvokerResponse ModifyInvokerSync(ModifyInvokerRequest req)
        {
            return InternalRequestAsync<ModifyInvokerResponse>(req, "ModifyInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于修改托管实例信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRegisterInstanceRequest"/></param>
        /// <returns><see cref="ModifyRegisterInstanceResponse"/></returns>
        public Task<ModifyRegisterInstanceResponse> ModifyRegisterInstance(ModifyRegisterInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRegisterInstanceResponse>(req, "ModifyRegisterInstance");
        }

        /// <summary>
        /// 接口用于修改托管实例信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRegisterInstanceRequest"/></param>
        /// <returns><see cref="ModifyRegisterInstanceResponse"/></returns>
        public ModifyRegisterInstanceResponse ModifyRegisterInstanceSync(ModifyRegisterInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRegisterInstanceResponse>(req, "ModifyRegisterInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于预览自定义参数替换后的命令内容。不会触发真实执行。
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public Task<PreviewReplacedCommandContentResponse> PreviewReplacedCommandContent(PreviewReplacedCommandContentRequest req)
        {
            return InternalRequestAsync<PreviewReplacedCommandContentResponse>(req, "PreviewReplacedCommandContent");
        }

        /// <summary>
        /// 此接口用于预览自定义参数替换后的命令内容。不会触发真实执行。
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public PreviewReplacedCommandContentResponse PreviewReplacedCommandContentSync(PreviewReplacedCommandContentRequest req)
        {
            return InternalRequestAsync<PreviewReplacedCommandContentResponse>(req, "PreviewReplacedCommandContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 执行命令，调用成功返回执行活动ID（inv-xxxxxxxx），每个执行活动内部有一个或多个执行任务（invt-xxxxxxxx），每个执行任务代表命令在一台 CVM 或一台 Lighthouse 上的执行记录。
        /// 
        /// * 如果指定实例未安装 agent，或 agent 不在线，返回失败
        /// * 如果命令类型与 agent 运行环境不符，返回失败
        /// * 指定的实例需要处于 VPC 网络
        /// * 指定的实例需要处于 `RUNNING` 状态
        /// * 不可同时指定 CVM 和 Lighthouse
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public Task<RunCommandResponse> RunCommand(RunCommandRequest req)
        {
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand");
        }

        /// <summary>
        /// 执行命令，调用成功返回执行活动ID（inv-xxxxxxxx），每个执行活动内部有一个或多个执行任务（invt-xxxxxxxx），每个执行任务代表命令在一台 CVM 或一台 Lighthouse 上的执行记录。
        /// 
        /// * 如果指定实例未安装 agent，或 agent 不在线，返回失败
        /// * 如果命令类型与 agent 运行环境不符，返回失败
        /// * 指定的实例需要处于 VPC 网络
        /// * 指定的实例需要处于 `RUNNING` 状态
        /// * 不可同时指定 CVM 和 Lighthouse
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public RunCommandResponse RunCommandSync(RunCommandRequest req)
        {
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
