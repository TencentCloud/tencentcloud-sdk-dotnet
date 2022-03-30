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

namespace TencentCloud.Cfg.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfg.V20210820.Models;

   public class CfgClient : AbstractClient{

       private const string endpoint = "cfg.tencentcloudapi.com";
       private const string version = "2021-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 从经验库创建演练
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public async Task<CreateTaskFromTemplateResponse> CreateTaskFromTemplate(CreateTaskFromTemplateRequest req)
        {
             JsonResponseModel<CreateTaskFromTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskFromTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFromTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从经验库创建演练
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public CreateTaskFromTemplateResponse CreateTaskFromTemplateSync(CreateTaskFromTemplateRequest req)
        {
             JsonResponseModel<CreateTaskFromTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskFromTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFromTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public async Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
             JsonResponseModel<DeleteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取演练过程中的所有日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public async Task<DescribeTaskExecuteLogsResponse> DescribeTaskExecuteLogs(DescribeTaskExecuteLogsRequest req)
        {
             JsonResponseModel<DescribeTaskExecuteLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskExecuteLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskExecuteLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取演练过程中的所有日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public DescribeTaskExecuteLogsResponse DescribeTaskExecuteLogsSync(DescribeTaskExecuteLogsRequest req)
        {
             JsonResponseModel<DescribeTaskExecuteLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskExecuteLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskExecuteLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public async Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询经验库
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public async Task<DescribeTemplateResponse> DescribeTemplate(DescribeTemplateRequest req)
        {
             JsonResponseModel<DescribeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询经验库
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public DescribeTemplateResponse DescribeTemplateSync(DescribeTemplateRequest req)
        {
             JsonResponseModel<DescribeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询经验库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public async Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询经验库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public async Task<ExecuteTaskResponse> ExecuteTask(ExecuteTaskRequest req)
        {
             JsonResponseModel<ExecuteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 执行任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public ExecuteTaskResponse ExecuteTaskSync(ExecuteTaskRequest req)
        {
             JsonResponseModel<ExecuteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 触发混沌演练任务的动作，对于实例进行演练操作
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public async Task<ExecuteTaskInstanceResponse> ExecuteTaskInstance(ExecuteTaskInstanceRequest req)
        {
             JsonResponseModel<ExecuteTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 触发混沌演练任务的动作，对于实例进行演练操作
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public ExecuteTaskInstanceResponse ExecuteTaskInstanceSync(ExecuteTaskInstanceRequest req)
        {
             JsonResponseModel<ExecuteTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务运行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public async Task<ModifyTaskRunStatusResponse> ModifyTaskRunStatus(ModifyTaskRunStatusRequest req)
        {
             JsonResponseModel<ModifyTaskRunStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskRunStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskRunStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改任务运行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public ModifyTaskRunStatusResponse ModifyTaskRunStatusSync(ModifyTaskRunStatusRequest req)
        {
             JsonResponseModel<ModifyTaskRunStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskRunStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskRunStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
