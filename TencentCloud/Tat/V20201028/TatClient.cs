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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 此接口用于创建命令。
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public async Task<CreateCommandResponse> CreateCommand(CreateCommandRequest req)
        {
             JsonResponseModel<CreateCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建命令。
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public CreateCommandResponse CreateCommandSync(CreateCommandRequest req)
        {
             JsonResponseModel<CreateCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除命令。
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public async Task<DeleteCommandResponse> DeleteCommand(DeleteCommandRequest req)
        {
             JsonResponseModel<DeleteCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除命令。
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public DeleteCommandResponse DeleteCommandSync(DeleteCommandRequest req)
        {
             JsonResponseModel<DeleteCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询自动化助手客户端的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public async Task<DescribeAutomationAgentStatusResponse> DescribeAutomationAgentStatus(DescribeAutomationAgentStatusRequest req)
        {
             JsonResponseModel<DescribeAutomationAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutomationAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutomationAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询自动化助手客户端的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public DescribeAutomationAgentStatusResponse DescribeAutomationAgentStatusSync(DescribeAutomationAgentStatusRequest req)
        {
             JsonResponseModel<DescribeAutomationAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutomationAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutomationAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询命令详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public async Task<DescribeCommandsResponse> DescribeCommands(DescribeCommandsRequest req)
        {
             JsonResponseModel<DescribeCommandsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询命令详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public DescribeCommandsResponse DescribeCommandsSync(DescribeCommandsRequest req)
        {
             JsonResponseModel<DescribeCommandsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public async Task<DescribeInvocationTasksResponse> DescribeInvocationTasks(DescribeInvocationTasksRequest req)
        {
             JsonResponseModel<DescribeInvocationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvocationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public DescribeInvocationTasksResponse DescribeInvocationTasksSync(DescribeInvocationTasksRequest req)
        {
             JsonResponseModel<DescribeInvocationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvocationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行活动详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocations(DescribeInvocationsRequest req)
        {
             JsonResponseModel<DescribeInvocationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行活动详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public DescribeInvocationsResponse DescribeInvocationsSync(DescribeInvocationsRequest req)
        {
             JsonResponseModel<DescribeInvocationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<InvokeCommandResponse> InvokeCommand(InvokeCommandRequest req)
        {
             JsonResponseModel<InvokeCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvokeCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<InvokeCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvokeCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于修改命令。
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public async Task<ModifyCommandResponse> ModifyCommand(ModifyCommandRequest req)
        {
             JsonResponseModel<ModifyCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于修改命令。
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public ModifyCommandResponse ModifyCommandSync(ModifyCommandRequest req)
        {
             JsonResponseModel<ModifyCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<RunCommandResponse> RunCommand(RunCommandRequest req)
        {
             JsonResponseModel<RunCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<RunCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
