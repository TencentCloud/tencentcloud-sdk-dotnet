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
        /// 取消一台或多台CVM实例执行的命令
        /// 
        /// * 如果命令还未下发到agent，任务状态处于处于PENDING、DELIVERING、DELIVER_DELAYED，取消后任务状态是CANCELLED
        /// * 如果命令已下发到agent，任务状态处于RUNNING， 取消后任务状态是TERMINATED
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public async Task<CancelInvocationResponse> CancelInvocation(CancelInvocationRequest req)
        {
             JsonResponseModel<CancelInvocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelInvocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelInvocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消一台或多台CVM实例执行的命令
        /// 
        /// * 如果命令还未下发到agent，任务状态处于处于PENDING、DELIVERING、DELIVER_DELAYED，取消后任务状态是CANCELLED
        /// * 如果命令已下发到agent，任务状态处于RUNNING， 取消后任务状态是TERMINATED
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public CancelInvocationResponse CancelInvocationSync(CancelInvocationRequest req)
        {
             JsonResponseModel<CancelInvocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelInvocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelInvocationResponse>>(strResp);
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
        /// 此接口用于创建执行器。
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public async Task<CreateInvokerResponse> CreateInvoker(CreateInvokerRequest req)
        {
             JsonResponseModel<CreateInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建执行器。
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public CreateInvokerResponse CreateInvokerSync(CreateInvokerRequest req)
        {
             JsonResponseModel<CreateInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于创建注册码。
        /// </summary>
        /// <param name="req"><see cref="CreateRegisterCodeRequest"/></param>
        /// <returns><see cref="CreateRegisterCodeResponse"/></returns>
        public async Task<CreateRegisterCodeResponse> CreateRegisterCode(CreateRegisterCodeRequest req)
        {
             JsonResponseModel<CreateRegisterCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRegisterCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRegisterCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于创建注册码。
        /// </summary>
        /// <param name="req"><see cref="CreateRegisterCodeRequest"/></param>
        /// <returns><see cref="CreateRegisterCodeResponse"/></returns>
        public CreateRegisterCodeResponse CreateRegisterCodeSync(CreateRegisterCodeRequest req)
        {
             JsonResponseModel<CreateRegisterCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRegisterCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRegisterCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除命令。
        /// 如果命令与执行器关联，则无法被删除。
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
        /// 如果命令与执行器关联，则无法被删除。
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
        /// 批量删除命令接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandsRequest"/></param>
        /// <returns><see cref="DeleteCommandsResponse"/></returns>
        public async Task<DeleteCommandsResponse> DeleteCommands(DeleteCommandsRequest req)
        {
             JsonResponseModel<DeleteCommandsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除命令接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandsRequest"/></param>
        /// <returns><see cref="DeleteCommandsResponse"/></returns>
        public DeleteCommandsResponse DeleteCommandsSync(DeleteCommandsRequest req)
        {
             JsonResponseModel<DeleteCommandsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除执行器。
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public async Task<DeleteInvokerResponse> DeleteInvoker(DeleteInvokerRequest req)
        {
             JsonResponseModel<DeleteInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除执行器。
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public DeleteInvokerResponse DeleteInvokerSync(DeleteInvokerRequest req)
        {
             JsonResponseModel<DeleteInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于批量删除注册码。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterCodesRequest"/></param>
        /// <returns><see cref="DeleteRegisterCodesResponse"/></returns>
        public async Task<DeleteRegisterCodesResponse> DeleteRegisterCodes(DeleteRegisterCodesRequest req)
        {
             JsonResponseModel<DeleteRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于批量删除注册码。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterCodesRequest"/></param>
        /// <returns><see cref="DeleteRegisterCodesResponse"/></returns>
        public DeleteRegisterCodesResponse DeleteRegisterCodesSync(DeleteRegisterCodesRequest req)
        {
             JsonResponseModel<DeleteRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于删除托管实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterInstanceRequest"/></param>
        /// <returns><see cref="DeleteRegisterInstanceResponse"/></returns>
        public async Task<DeleteRegisterInstanceResponse> DeleteRegisterInstance(DeleteRegisterInstanceRequest req)
        {
             JsonResponseModel<DeleteRegisterInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRegisterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRegisterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于删除托管实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegisterInstanceRequest"/></param>
        /// <returns><see cref="DeleteRegisterInstanceResponse"/></returns>
        public DeleteRegisterInstanceResponse DeleteRegisterInstanceSync(DeleteRegisterInstanceRequest req)
        {
             JsonResponseModel<DeleteRegisterInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRegisterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRegisterInstanceResponse>>(strResp);
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
        /// 此接口用于查询执行器的执行记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public async Task<DescribeInvokerRecordsResponse> DescribeInvokerRecords(DescribeInvokerRecordsRequest req)
        {
             JsonResponseModel<DescribeInvokerRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvokerRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokerRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行器的执行记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public DescribeInvokerRecordsResponse DescribeInvokerRecordsSync(DescribeInvokerRecordsRequest req)
        {
             JsonResponseModel<DescribeInvokerRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvokerRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokerRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public async Task<DescribeInvokersResponse> DescribeInvokers(DescribeInvokersRequest req)
        {
             JsonResponseModel<DescribeInvokersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvokers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询执行器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public DescribeInvokersResponse DescribeInvokersSync(DescribeInvokersRequest req)
        {
             JsonResponseModel<DescribeInvokersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvokers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于获取配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public async Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest req)
        {
             JsonResponseModel<DescribeQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于获取配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public DescribeQuotasResponse DescribeQuotasSync(DescribeQuotasRequest req)
        {
             JsonResponseModel<DescribeQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于查询 TAT 产品后台地域列表。
        /// RegionState 为 AVAILABLE，代表该地域的 TAT 后台服务已经可用；未返回，代表该地域的 TAT 后台服务尚不可用。
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
        /// 此接口用于查询 TAT 产品后台地域列表。
        /// RegionState 为 AVAILABLE，代表该地域的 TAT 后台服务已经可用；未返回，代表该地域的 TAT 后台服务尚不可用。
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
        /// 接口用于查询注册码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterCodesRequest"/></param>
        /// <returns><see cref="DescribeRegisterCodesResponse"/></returns>
        public async Task<DescribeRegisterCodesResponse> DescribeRegisterCodes(DescribeRegisterCodesRequest req)
        {
             JsonResponseModel<DescribeRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询注册码信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterCodesRequest"/></param>
        /// <returns><see cref="DescribeRegisterCodesResponse"/></returns>
        public DescribeRegisterCodesResponse DescribeRegisterCodesSync(DescribeRegisterCodesRequest req)
        {
             JsonResponseModel<DescribeRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询被托管的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterInstancesRequest"/></param>
        /// <returns><see cref="DescribeRegisterInstancesResponse"/></returns>
        public async Task<DescribeRegisterInstancesResponse> DescribeRegisterInstances(DescribeRegisterInstancesRequest req)
        {
             JsonResponseModel<DescribeRegisterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegisterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegisterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询被托管的实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegisterInstancesRequest"/></param>
        /// <returns><see cref="DescribeRegisterInstancesResponse"/></returns>
        public DescribeRegisterInstancesResponse DescribeRegisterInstancesSync(DescribeRegisterInstancesRequest req)
        {
             JsonResponseModel<DescribeRegisterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegisterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegisterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于停止执行器。
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public async Task<DisableInvokerResponse> DisableInvoker(DisableInvokerRequest req)
        {
             JsonResponseModel<DisableInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于停止执行器。
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public DisableInvokerResponse DisableInvokerSync(DisableInvokerRequest req)
        {
             JsonResponseModel<DisableInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于批量禁用注册码。
        /// </summary>
        /// <param name="req"><see cref="DisableRegisterCodesRequest"/></param>
        /// <returns><see cref="DisableRegisterCodesResponse"/></returns>
        public async Task<DisableRegisterCodesResponse> DisableRegisterCodes(DisableRegisterCodesRequest req)
        {
             JsonResponseModel<DisableRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于批量禁用注册码。
        /// </summary>
        /// <param name="req"><see cref="DisableRegisterCodesRequest"/></param>
        /// <returns><see cref="DisableRegisterCodesResponse"/></returns>
        public DisableRegisterCodesResponse DisableRegisterCodesSync(DisableRegisterCodesRequest req)
        {
             JsonResponseModel<DisableRegisterCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableRegisterCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRegisterCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于启用执行器。
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public async Task<EnableInvokerResponse> EnableInvoker(EnableInvokerRequest req)
        {
             JsonResponseModel<EnableInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于启用执行器。
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public EnableInvokerResponse EnableInvokerSync(EnableInvokerRequest req)
        {
             JsonResponseModel<EnableInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInvokerResponse>>(strResp);
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
        /// 此接口用于修改执行器。
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public async Task<ModifyInvokerResponse> ModifyInvoker(ModifyInvokerRequest req)
        {
             JsonResponseModel<ModifyInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于修改执行器。
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public ModifyInvokerResponse ModifyInvokerSync(ModifyInvokerRequest req)
        {
             JsonResponseModel<ModifyInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于修改托管实例信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRegisterInstanceRequest"/></param>
        /// <returns><see cref="ModifyRegisterInstanceResponse"/></returns>
        public async Task<ModifyRegisterInstanceResponse> ModifyRegisterInstance(ModifyRegisterInstanceRequest req)
        {
             JsonResponseModel<ModifyRegisterInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRegisterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRegisterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于修改托管实例信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyRegisterInstanceRequest"/></param>
        /// <returns><see cref="ModifyRegisterInstanceResponse"/></returns>
        public ModifyRegisterInstanceResponse ModifyRegisterInstanceSync(ModifyRegisterInstanceRequest req)
        {
             JsonResponseModel<ModifyRegisterInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRegisterInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRegisterInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于预览自定义参数替换后的命令内容。不会触发真实执行。
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public async Task<PreviewReplacedCommandContentResponse> PreviewReplacedCommandContent(PreviewReplacedCommandContentRequest req)
        {
             JsonResponseModel<PreviewReplacedCommandContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PreviewReplacedCommandContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewReplacedCommandContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于预览自定义参数替换后的命令内容。不会触发真实执行。
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public PreviewReplacedCommandContentResponse PreviewReplacedCommandContentSync(PreviewReplacedCommandContentRequest req)
        {
             JsonResponseModel<PreviewReplacedCommandContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PreviewReplacedCommandContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewReplacedCommandContentResponse>>(strResp);
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
