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
       private const string sdkVersion = "SDK_NET_3.0.985";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 从经验库创建演练
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public Task<CreateTaskFromTemplateResponse> CreateTaskFromTemplate(CreateTaskFromTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskFromTemplateResponse>(req, "CreateTaskFromTemplate");
        }

        /// <summary>
        /// 从经验库创建演练
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFromTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskFromTemplateResponse"/></returns>
        public CreateTaskFromTemplateResponse CreateTaskFromTemplateSync(CreateTaskFromTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskFromTemplateResponse>(req, "CreateTaskFromTemplate")
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
        /// 查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// 查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取演练过程中的所有日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public Task<DescribeTaskExecuteLogsResponse> DescribeTaskExecuteLogs(DescribeTaskExecuteLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskExecuteLogsResponse>(req, "DescribeTaskExecuteLogs");
        }

        /// <summary>
        /// 获取演练过程中的所有日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskExecuteLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskExecuteLogsResponse"/></returns>
        public DescribeTaskExecuteLogsResponse DescribeTaskExecuteLogsSync(DescribeTaskExecuteLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskExecuteLogsResponse>(req, "DescribeTaskExecuteLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取护栏触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPolicyTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeTaskPolicyTriggerLogResponse"/></returns>
        public Task<DescribeTaskPolicyTriggerLogResponse> DescribeTaskPolicyTriggerLog(DescribeTaskPolicyTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskPolicyTriggerLogResponse>(req, "DescribeTaskPolicyTriggerLog");
        }

        /// <summary>
        /// 获取护栏触发日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPolicyTriggerLogRequest"/></param>
        /// <returns><see cref="DescribeTaskPolicyTriggerLogResponse"/></returns>
        public DescribeTaskPolicyTriggerLogResponse DescribeTaskPolicyTriggerLogSync(DescribeTaskPolicyTriggerLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskPolicyTriggerLogResponse>(req, "DescribeTaskPolicyTriggerLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询经验库
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public Task<DescribeTemplateResponse> DescribeTemplate(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate");
        }

        /// <summary>
        /// 查询经验库
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public DescribeTemplateResponse DescribeTemplateSync(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询经验库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList");
        }

        /// <summary>
        /// 查询经验库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 执行任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public Task<ExecuteTaskResponse> ExecuteTask(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask");
        }

        /// <summary>
        /// 执行任务
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskRequest"/></param>
        /// <returns><see cref="ExecuteTaskResponse"/></returns>
        public ExecuteTaskResponse ExecuteTaskSync(ExecuteTaskRequest req)
        {
            return InternalRequestAsync<ExecuteTaskResponse>(req, "ExecuteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 触发混沌演练任务的动作，对于实例进行演练操作
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public Task<ExecuteTaskInstanceResponse> ExecuteTaskInstance(ExecuteTaskInstanceRequest req)
        {
            return InternalRequestAsync<ExecuteTaskInstanceResponse>(req, "ExecuteTaskInstance");
        }

        /// <summary>
        /// 触发混沌演练任务的动作，对于实例进行演练操作
        /// </summary>
        /// <param name="req"><see cref="ExecuteTaskInstanceRequest"/></param>
        /// <returns><see cref="ExecuteTaskInstanceResponse"/></returns>
        public ExecuteTaskInstanceResponse ExecuteTaskInstanceSync(ExecuteTaskInstanceRequest req)
        {
            return InternalRequestAsync<ExecuteTaskInstanceResponse>(req, "ExecuteTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改任务运行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public Task<ModifyTaskRunStatusResponse> ModifyTaskRunStatus(ModifyTaskRunStatusRequest req)
        {
            return InternalRequestAsync<ModifyTaskRunStatusResponse>(req, "ModifyTaskRunStatus");
        }

        /// <summary>
        /// 修改任务运行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskRunStatusRequest"/></param>
        /// <returns><see cref="ModifyTaskRunStatusResponse"/></returns>
        public ModifyTaskRunStatusResponse ModifyTaskRunStatusSync(ModifyTaskRunStatusRequest req)
        {
            return InternalRequestAsync<ModifyTaskRunStatusResponse>(req, "ModifyTaskRunStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于触发混沌演练护栏（类型为触发和恢复2种）
        /// </summary>
        /// <param name="req"><see cref="TriggerPolicyRequest"/></param>
        /// <returns><see cref="TriggerPolicyResponse"/></returns>
        public Task<TriggerPolicyResponse> TriggerPolicy(TriggerPolicyRequest req)
        {
            return InternalRequestAsync<TriggerPolicyResponse>(req, "TriggerPolicy");
        }

        /// <summary>
        /// 用于触发混沌演练护栏（类型为触发和恢复2种）
        /// </summary>
        /// <param name="req"><see cref="TriggerPolicyRequest"/></param>
        /// <returns><see cref="TriggerPolicyResponse"/></returns>
        public TriggerPolicyResponse TriggerPolicySync(TriggerPolicyRequest req)
        {
            return InternalRequestAsync<TriggerPolicyResponse>(req, "TriggerPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
