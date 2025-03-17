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

namespace TencentCloud.Wedata.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20210820.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2021-08-20";
       private const string sdkVersion = "SDK_NET_3.0.1201";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加项目用户角色
        /// </summary>
        /// <param name="req"><see cref="AddProjectUserRoleRequest"/></param>
        /// <returns><see cref="AddProjectUserRoleResponse"/></returns>
        public Task<AddProjectUserRoleResponse> AddProjectUserRole(AddProjectUserRoleRequest req)
        {
            return InternalRequestAsync<AddProjectUserRoleResponse>(req, "AddProjectUserRole");
        }

        /// <summary>
        /// 添加项目用户角色
        /// </summary>
        /// <param name="req"><see cref="AddProjectUserRoleRequest"/></param>
        /// <returns><see cref="AddProjectUserRoleResponse"/></returns>
        public AddProjectUserRoleResponse AddProjectUserRoleSync(AddProjectUserRoleRequest req)
        {
            return InternalRequestAsync<AddProjectUserRoleResponse>(req, "AddProjectUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public Task<BatchCreateIntegrationTaskAlarmsResponse> BatchCreateIntegrationTaskAlarms(BatchCreateIntegrationTaskAlarmsRequest req)
        {
            return InternalRequestAsync<BatchCreateIntegrationTaskAlarmsResponse>(req, "BatchCreateIntegrationTaskAlarms");
        }

        /// <summary>
        /// 批量创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="BatchCreateIntegrationTaskAlarmsRequest"/></param>
        /// <returns><see cref="BatchCreateIntegrationTaskAlarmsResponse"/></returns>
        public BatchCreateIntegrationTaskAlarmsResponse BatchCreateIntegrationTaskAlarmsSync(BatchCreateIntegrationTaskAlarmsRequest req)
        {
            return InternalRequestAsync<BatchCreateIntegrationTaskAlarmsResponse>(req, "BatchCreateIntegrationTaskAlarms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步批量创建任务版本
        /// </summary>
        /// <param name="req"><see cref="BatchCreateTaskVersionAsyncRequest"/></param>
        /// <returns><see cref="BatchCreateTaskVersionAsyncResponse"/></returns>
        public Task<BatchCreateTaskVersionAsyncResponse> BatchCreateTaskVersionAsync(BatchCreateTaskVersionAsyncRequest req)
        {
            return InternalRequestAsync<BatchCreateTaskVersionAsyncResponse>(req, "BatchCreateTaskVersionAsync");
        }

        /// <summary>
        /// 异步批量创建任务版本
        /// </summary>
        /// <param name="req"><see cref="BatchCreateTaskVersionAsyncRequest"/></param>
        /// <returns><see cref="BatchCreateTaskVersionAsyncResponse"/></returns>
        public BatchCreateTaskVersionAsyncResponse BatchCreateTaskVersionAsyncSync(BatchCreateTaskVersionAsyncRequest req)
        {
            return InternalRequestAsync<BatchCreateTaskVersionAsyncResponse>(req, "BatchCreateTaskVersionAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public Task<BatchDeleteIntegrationTasksResponse> BatchDeleteIntegrationTasks(BatchDeleteIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteIntegrationTasksResponse>(req, "BatchDeleteIntegrationTasks");
        }

        /// <summary>
        /// 批量删除集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteIntegrationTasksResponse"/></returns>
        public BatchDeleteIntegrationTasksResponse BatchDeleteIntegrationTasksSync(BatchDeleteIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteIntegrationTasksResponse>(req, "BatchDeleteIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维-批量删除任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public Task<BatchDeleteOpsTasksResponse> BatchDeleteOpsTasks(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks");
        }

        /// <summary>
        /// 任务运维-批量删除任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public BatchDeleteOpsTasksResponse BatchDeleteOpsTasksSync(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量置成功集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchForceSuccessIntegrationTaskInstancesResponse> BatchForceSuccessIntegrationTaskInstances(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchForceSuccessIntegrationTaskInstancesResponse>(req, "BatchForceSuccessIntegrationTaskInstances");
        }

        /// <summary>
        /// 批量置成功集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchForceSuccessIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchForceSuccessIntegrationTaskInstancesResponse"/></returns>
        public BatchForceSuccessIntegrationTaskInstancesResponse BatchForceSuccessIntegrationTaskInstancesSync(BatchForceSuccessIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchForceSuccessIntegrationTaskInstancesResponse>(req, "BatchForceSuccessIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量终止集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchKillIntegrationTaskInstancesResponse> BatchKillIntegrationTaskInstances(BatchKillIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchKillIntegrationTaskInstancesResponse>(req, "BatchKillIntegrationTaskInstances");
        }

        /// <summary>
        /// 批量终止集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchKillIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchKillIntegrationTaskInstancesResponse"/></returns>
        public BatchKillIntegrationTaskInstancesResponse BatchKillIntegrationTaskInstancesSync(BatchKillIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchKillIntegrationTaskInstancesResponse>(req, "BatchKillIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对集成离线任务执行批量补数据操作
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public Task<BatchMakeUpIntegrationTasksResponse> BatchMakeUpIntegrationTasks(BatchMakeUpIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchMakeUpIntegrationTasksResponse>(req, "BatchMakeUpIntegrationTasks");
        }

        /// <summary>
        /// 对集成离线任务执行批量补数据操作
        /// </summary>
        /// <param name="req"><see cref="BatchMakeUpIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchMakeUpIntegrationTasksResponse"/></returns>
        public BatchMakeUpIntegrationTasksResponse BatchMakeUpIntegrationTasksSync(BatchMakeUpIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchMakeUpIntegrationTasksResponse>(req, "BatchMakeUpIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOpsOwnersRequest"/></param>
        /// <returns><see cref="BatchModifyOpsOwnersResponse"/></returns>
        public Task<BatchModifyOpsOwnersResponse> BatchModifyOpsOwners(BatchModifyOpsOwnersRequest req)
        {
            return InternalRequestAsync<BatchModifyOpsOwnersResponse>(req, "BatchModifyOpsOwners");
        }

        /// <summary>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOpsOwnersRequest"/></param>
        /// <returns><see cref="BatchModifyOpsOwnersResponse"/></returns>
        public BatchModifyOpsOwnersResponse BatchModifyOpsOwnersSync(BatchModifyOpsOwnersRequest req)
        {
            return InternalRequestAsync<BatchModifyOpsOwnersResponse>(req, "BatchModifyOpsOwners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量重跑集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public Task<BatchRerunIntegrationTaskInstancesResponse> BatchRerunIntegrationTaskInstances(BatchRerunIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchRerunIntegrationTaskInstancesResponse>(req, "BatchRerunIntegrationTaskInstances");
        }

        /// <summary>
        /// 批量重跑集成任务实例
        /// </summary>
        /// <param name="req"><see cref="BatchRerunIntegrationTaskInstancesRequest"/></param>
        /// <returns><see cref="BatchRerunIntegrationTaskInstancesResponse"/></returns>
        public BatchRerunIntegrationTaskInstancesResponse BatchRerunIntegrationTaskInstancesSync(BatchRerunIntegrationTaskInstancesRequest req)
        {
            return InternalRequestAsync<BatchRerunIntegrationTaskInstancesResponse>(req, "BatchRerunIntegrationTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量继续执行集成实时任务
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public Task<BatchResumeIntegrationTasksResponse> BatchResumeIntegrationTasks(BatchResumeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchResumeIntegrationTasksResponse>(req, "BatchResumeIntegrationTasks");
        }

        /// <summary>
        /// 批量继续执行集成实时任务
        /// </summary>
        /// <param name="req"><see cref="BatchResumeIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchResumeIntegrationTasksResponse"/></returns>
        public BatchResumeIntegrationTasksResponse BatchResumeIntegrationTasksSync(BatchResumeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchResumeIntegrationTasksResponse>(req, "BatchResumeIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维-任务列表 批量启动
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public Task<BatchRunOpsTaskResponse> BatchRunOpsTask(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask");
        }

        /// <summary>
        /// 任务运维-任务列表 批量启动
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public BatchRunOpsTaskResponse BatchRunOpsTaskSync(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量运行集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public Task<BatchStartIntegrationTasksResponse> BatchStartIntegrationTasks(BatchStartIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStartIntegrationTasksResponse>(req, "BatchStartIntegrationTasks");
        }

        /// <summary>
        /// 批量运行集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStartIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStartIntegrationTasksResponse"/></returns>
        public BatchStartIntegrationTasksResponse BatchStartIntegrationTasksSync(BatchStartIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStartIntegrationTasksResponse>(req, "BatchStartIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量停止集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public Task<BatchStopIntegrationTasksResponse> BatchStopIntegrationTasks(BatchStopIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStopIntegrationTasksResponse>(req, "BatchStopIntegrationTasks");
        }

        /// <summary>
        /// 批量停止集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchStopIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchStopIntegrationTasksResponse"/></returns>
        public BatchStopIntegrationTasksResponse BatchStopIntegrationTasksSync(BatchStopIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchStopIntegrationTasksResponse>(req, "BatchStopIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopOpsTasksRequest"/></param>
        /// <returns><see cref="BatchStopOpsTasksResponse"/></returns>
        public Task<BatchStopOpsTasksResponse> BatchStopOpsTasks(BatchStopOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchStopOpsTasksResponse>(req, "BatchStopOpsTasks");
        }

        /// <summary>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopOpsTasksRequest"/></param>
        /// <returns><see cref="BatchStopOpsTasksResponse"/></returns>
        public BatchStopOpsTasksResponse BatchStopOpsTasksSync(BatchStopOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchStopOpsTasksResponse>(req, "BatchStopOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量停止工作流
        /// </summary>
        /// <param name="req"><see cref="BatchStopWorkflowsByIdsRequest"/></param>
        /// <returns><see cref="BatchStopWorkflowsByIdsResponse"/></returns>
        public Task<BatchStopWorkflowsByIdsResponse> BatchStopWorkflowsByIds(BatchStopWorkflowsByIdsRequest req)
        {
            return InternalRequestAsync<BatchStopWorkflowsByIdsResponse>(req, "BatchStopWorkflowsByIds");
        }

        /// <summary>
        /// 批量停止工作流
        /// </summary>
        /// <param name="req"><see cref="BatchStopWorkflowsByIdsRequest"/></param>
        /// <returns><see cref="BatchStopWorkflowsByIdsResponse"/></returns>
        public BatchStopWorkflowsByIdsResponse BatchStopWorkflowsByIdsSync(BatchStopWorkflowsByIdsRequest req)
        {
            return InternalRequestAsync<BatchStopWorkflowsByIdsResponse>(req, "BatchStopWorkflowsByIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public Task<BatchSuspendIntegrationTasksResponse> BatchSuspendIntegrationTasks(BatchSuspendIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchSuspendIntegrationTasksResponse>(req, "BatchSuspendIntegrationTasks");
        }

        /// <summary>
        /// 批量暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="BatchSuspendIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchSuspendIntegrationTasksResponse"/></returns>
        public BatchSuspendIntegrationTasksResponse BatchSuspendIntegrationTasksSync(BatchSuspendIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchSuspendIntegrationTasksResponse>(req, "BatchSuspendIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新集成任务（暂时仅支持批量更新责任人）
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public Task<BatchUpdateIntegrationTasksResponse> BatchUpdateIntegrationTasks(BatchUpdateIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchUpdateIntegrationTasksResponse>(req, "BatchUpdateIntegrationTasks");
        }

        /// <summary>
        /// 批量更新集成任务（暂时仅支持批量更新责任人）
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateIntegrationTasksRequest"/></param>
        /// <returns><see cref="BatchUpdateIntegrationTasksResponse"/></returns>
        public BatchUpdateIntegrationTasksResponse BatchUpdateIntegrationTasksSync(BatchUpdateIntegrationTasksRequest req)
        {
            return InternalRequestAsync<BatchUpdateIntegrationTasksResponse>(req, "BatchUpdateIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断告警规则重名
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public Task<CheckAlarmRegularNameExistResponse> CheckAlarmRegularNameExist(CheckAlarmRegularNameExistRequest req)
        {
            return InternalRequestAsync<CheckAlarmRegularNameExistResponse>(req, "CheckAlarmRegularNameExist");
        }

        /// <summary>
        /// 判断告警规则重名
        /// </summary>
        /// <param name="req"><see cref="CheckAlarmRegularNameExistRequest"/></param>
        /// <returns><see cref="CheckAlarmRegularNameExistResponse"/></returns>
        public CheckAlarmRegularNameExistResponse CheckAlarmRegularNameExistSync(CheckAlarmRegularNameExistRequest req)
        {
            return InternalRequestAsync<CheckAlarmRegularNameExistResponse>(req, "CheckAlarmRegularNameExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断集成节点名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public Task<CheckIntegrationNodeNameExistsResponse> CheckIntegrationNodeNameExists(CheckIntegrationNodeNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationNodeNameExistsResponse>(req, "CheckIntegrationNodeNameExists");
        }

        /// <summary>
        /// 判断集成节点名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationNodeNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationNodeNameExistsResponse"/></returns>
        public CheckIntegrationNodeNameExistsResponse CheckIntegrationNodeNameExistsSync(CheckIntegrationNodeNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationNodeNameExistsResponse>(req, "CheckIntegrationNodeNameExists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断集成任务名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public Task<CheckIntegrationTaskNameExistsResponse> CheckIntegrationTaskNameExists(CheckIntegrationTaskNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationTaskNameExistsResponse>(req, "CheckIntegrationTaskNameExists");
        }

        /// <summary>
        /// 判断集成任务名称是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckIntegrationTaskNameExistsRequest"/></param>
        /// <returns><see cref="CheckIntegrationTaskNameExistsResponse"/></returns>
        public CheckIntegrationTaskNameExistsResponse CheckIntegrationTaskNameExistsSync(CheckIntegrationTaskNameExistsRequest req)
        {
            return InternalRequestAsync<CheckIntegrationTaskNameExistsResponse>(req, "CheckIntegrationTaskNameExists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 离线任务重名校验
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public Task<CheckTaskNameExistResponse> CheckTaskNameExist(CheckTaskNameExistRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistResponse>(req, "CheckTaskNameExist");
        }

        /// <summary>
        /// 离线任务重名校验
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistResponse"/></returns>
        public CheckTaskNameExistResponse CheckTaskNameExistSync(CheckTaskNameExistRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistResponse>(req, "CheckTaskNameExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交集成任务
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public Task<CommitIntegrationTaskResponse> CommitIntegrationTask(CommitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CommitIntegrationTaskResponse>(req, "CommitIntegrationTask");
        }

        /// <summary>
        /// 提交集成任务
        /// </summary>
        /// <param name="req"><see cref="CommitIntegrationTaskRequest"/></param>
        /// <returns><see cref="CommitIntegrationTaskResponse"/></returns>
        public CommitIntegrationTaskResponse CommitIntegrationTaskSync(CommitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CommitIntegrationTaskResponse>(req, "CommitIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交规则组运行任务接口
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public Task<CommitRuleGroupTaskResponse> CommitRuleGroupTask(CommitRuleGroupTaskRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupTaskResponse>(req, "CommitRuleGroupTask");
        }

        /// <summary>
        /// 提交规则组运行任务接口
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupTaskRequest"/></param>
        /// <returns><see cref="CommitRuleGroupTaskResponse"/></returns>
        public CommitRuleGroupTaskResponse CommitRuleGroupTaskSync(CommitRuleGroupTaskRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupTaskResponse>(req, "CommitRuleGroupTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计任务实例状态
        /// </summary>
        /// <param name="req"><see cref="CountOpsInstanceStateRequest"/></param>
        /// <returns><see cref="CountOpsInstanceStateResponse"/></returns>
        public Task<CountOpsInstanceStateResponse> CountOpsInstanceState(CountOpsInstanceStateRequest req)
        {
            return InternalRequestAsync<CountOpsInstanceStateResponse>(req, "CountOpsInstanceState");
        }

        /// <summary>
        /// 统计任务实例状态
        /// </summary>
        /// <param name="req"><see cref="CountOpsInstanceStateRequest"/></param>
        /// <returns><see cref="CountOpsInstanceStateResponse"/></returns>
        public CountOpsInstanceStateResponse CountOpsInstanceStateSync(CountOpsInstanceStateRequest req)
        {
            return InternalRequestAsync<CountOpsInstanceStateResponse>(req, "CountOpsInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public Task<CreateCustomFunctionResponse> CreateCustomFunction(CreateCustomFunctionRequest req)
        {
            return InternalRequestAsync<CreateCustomFunctionResponse>(req, "CreateCustomFunction");
        }

        /// <summary>
        /// 创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public CreateCustomFunctionResponse CreateCustomFunctionSync(CreateCustomFunctionRequest req)
        {
            return InternalRequestAsync<CreateCustomFunctionResponse>(req, "CreateCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据建模，提供给云应用使用，实现“Wedata数据建模”的下单发货
        /// </summary>
        /// <param name="req"><see cref="CreateDataModelRequest"/></param>
        /// <returns><see cref="CreateDataModelResponse"/></returns>
        public Task<CreateDataModelResponse> CreateDataModel(CreateDataModelRequest req)
        {
            return InternalRequestAsync<CreateDataModelResponse>(req, "CreateDataModel");
        }

        /// <summary>
        /// 创建数据建模，提供给云应用使用，实现“Wedata数据建模”的下单发货
        /// </summary>
        /// <param name="req"><see cref="CreateDataModelRequest"/></param>
        /// <returns><see cref="CreateDataModelResponse"/></returns>
        public CreateDataModelResponse CreateDataModelSync(CreateDataModelRequest req)
        {
            return InternalRequestAsync<CreateDataModelResponse>(req, "CreateDataModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource");
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateDsFolderRequest"/></param>
        /// <returns><see cref="CreateDsFolderResponse"/></returns>
        public Task<CreateDsFolderResponse> CreateDsFolder(CreateDsFolderRequest req)
        {
            return InternalRequestAsync<CreateDsFolderResponse>(req, "CreateDsFolder");
        }

        /// <summary>
        /// 编排空间-创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateDsFolderRequest"/></param>
        /// <returns><see cref="CreateDsFolderResponse"/></returns>
        public CreateDsFolderResponse CreateDsFolderSync(CreateDsFolderRequest req)
        {
            return InternalRequestAsync<CreateDsFolderResponse>(req, "CreateDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 建hive表
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public Task<CreateHiveTableResponse> CreateHiveTable(CreateHiveTableRequest req)
        {
            return InternalRequestAsync<CreateHiveTableResponse>(req, "CreateHiveTable");
        }

        /// <summary>
        /// 建hive表
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableRequest"/></param>
        /// <returns><see cref="CreateHiveTableResponse"/></returns>
        public CreateHiveTableResponse CreateHiveTableSync(CreateHiveTableRequest req)
        {
            return InternalRequestAsync<CreateHiveTableResponse>(req, "CreateHiveTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建hive表，返回表名称
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public Task<CreateHiveTableByDDLResponse> CreateHiveTableByDDL(CreateHiveTableByDDLRequest req)
        {
            return InternalRequestAsync<CreateHiveTableByDDLResponse>(req, "CreateHiveTableByDDL");
        }

        /// <summary>
        /// 创建hive表，返回表名称
        /// </summary>
        /// <param name="req"><see cref="CreateHiveTableByDDLRequest"/></param>
        /// <returns><see cref="CreateHiveTableByDDLResponse"/></returns>
        public CreateHiveTableByDDLResponse CreateHiveTableByDDLSync(CreateHiveTableByDDLRequest req)
        {
            return InternalRequestAsync<CreateHiveTableByDDLResponse>(req, "CreateHiveTableByDDL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集成节点
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public Task<CreateIntegrationNodeResponse> CreateIntegrationNode(CreateIntegrationNodeRequest req)
        {
            return InternalRequestAsync<CreateIntegrationNodeResponse>(req, "CreateIntegrationNode");
        }

        /// <summary>
        /// 创建集成节点
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationNodeRequest"/></param>
        /// <returns><see cref="CreateIntegrationNodeResponse"/></returns>
        public CreateIntegrationNodeResponse CreateIntegrationNodeSync(CreateIntegrationNodeRequest req)
        {
            return InternalRequestAsync<CreateIntegrationNodeResponse>(req, "CreateIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集成任务
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public Task<CreateIntegrationTaskResponse> CreateIntegrationTask(CreateIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CreateIntegrationTaskResponse>(req, "CreateIntegrationTask");
        }

        /// <summary>
        /// 创建集成任务
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationTaskRequest"/></param>
        /// <returns><see cref="CreateIntegrationTaskResponse"/></returns>
        public CreateIntegrationTaskResponse CreateIntegrationTaskSync(CreateIntegrationTaskRequest req)
        {
            return InternalRequestAsync<CreateIntegrationTaskResponse>(req, "CreateIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建离线任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public Task<CreateOfflineTaskResponse> CreateOfflineTask(CreateOfflineTaskRequest req)
        {
            return InternalRequestAsync<CreateOfflineTaskResponse>(req, "CreateOfflineTask");
        }

        /// <summary>
        /// 创建离线任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineTaskRequest"/></param>
        /// <returns><see cref="CreateOfflineTaskResponse"/></returns>
        public CreateOfflineTaskResponse CreateOfflineTaskSync(CreateOfflineTaskRequest req)
        {
            return InternalRequestAsync<CreateOfflineTaskResponse>(req, "CreateOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量补数据（创建补录任务）
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public Task<CreateOpsMakePlanResponse> CreateOpsMakePlan(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan");
        }

        /// <summary>
        /// 批量补数据（创建补录任务）
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public CreateOpsMakePlanResponse CreateOpsMakePlanSync(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建质量规则接口
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 创建质量规则接口
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public Task<CreateRuleTemplateResponse> CreateRuleTemplate(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate");
        }

        /// <summary>
        /// 创建规则模板
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public CreateRuleTemplateResponse CreateRuleTemplateSync(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public Task<CreateTaskAlarmRegularResponse> CreateTaskAlarmRegular(CreateTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<CreateTaskAlarmRegularResponse>(req, "CreateTaskAlarmRegular");
        }

        /// <summary>
        /// 创建任务告警规则
        /// </summary>
        /// <param name="req"><see cref="CreateTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="CreateTaskAlarmRegularResponse"/></returns>
        public CreateTaskAlarmRegularResponse CreateTaskAlarmRegularSync(CreateTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<CreateTaskAlarmRegularResponse>(req, "CreateTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-工作流-创建任务文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFolderRequest"/></param>
        /// <returns><see cref="CreateTaskFolderResponse"/></returns>
        public Task<CreateTaskFolderResponse> CreateTaskFolder(CreateTaskFolderRequest req)
        {
            return InternalRequestAsync<CreateTaskFolderResponse>(req, "CreateTaskFolder");
        }

        /// <summary>
        /// 编排空间-工作流-创建任务文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFolderRequest"/></param>
        /// <returns><see cref="CreateTaskFolderResponse"/></returns>
        public CreateTaskFolderResponse CreateTaskFolderSync(CreateTaskFolderRequest req)
        {
            return InternalRequestAsync<CreateTaskFolderResponse>(req, "CreateTaskFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交任务版本
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public Task<CreateTaskVersionDsResponse> CreateTaskVersionDs(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs");
        }

        /// <summary>
        /// 提交任务版本
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public CreateTaskVersionDsResponse CreateTaskVersionDsSync(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowDsRequest"/></param>
        /// <returns><see cref="CreateWorkflowDsResponse"/></returns>
        public Task<CreateWorkflowDsResponse> CreateWorkflowDs(CreateWorkflowDsRequest req)
        {
            return InternalRequestAsync<CreateWorkflowDsResponse>(req, "CreateWorkflowDs");
        }

        /// <summary>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowDsRequest"/></param>
        /// <returns><see cref="CreateWorkflowDsResponse"/></returns>
        public CreateWorkflowDsResponse CreateWorkflowDsSync(CreateWorkflowDsRequest req)
        {
            return InternalRequestAsync<CreateWorkflowDsResponse>(req, "CreateWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取dag实例
        /// </summary>
        /// <param name="req"><see cref="DagInstancesRequest"/></param>
        /// <returns><see cref="DagInstancesResponse"/></returns>
        public Task<DagInstancesResponse> DagInstances(DagInstancesRequest req)
        {
            return InternalRequestAsync<DagInstancesResponse>(req, "DagInstances");
        }

        /// <summary>
        /// 拉取dag实例
        /// </summary>
        /// <param name="req"><see cref="DagInstancesRequest"/></param>
        /// <returns><see cref="DagInstancesResponse"/></returns>
        public DagInstancesResponse DagInstancesSync(DagInstancesRequest req)
        {
            return InternalRequestAsync<DagInstancesResponse>(req, "DagInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public Task<DeleteCustomFunctionResponse> DeleteCustomFunction(DeleteCustomFunctionRequest req)
        {
            return InternalRequestAsync<DeleteCustomFunctionResponse>(req, "DeleteCustomFunction");
        }

        /// <summary>
        /// 删除用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomFunctionRequest"/></param>
        /// <returns><see cref="DeleteCustomFunctionResponse"/></returns>
        public DeleteCustomFunctionResponse DeleteCustomFunctionSync(DeleteCustomFunctionRequest req)
        {
            return InternalRequestAsync<DeleteCustomFunctionResponse>(req, "DeleteCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁数据建模，提供给云应用使用，实现“Wedata数据建模”的销毁
        /// </summary>
        /// <param name="req"><see cref="DeleteDataModelRequest"/></param>
        /// <returns><see cref="DeleteDataModelResponse"/></returns>
        public Task<DeleteDataModelResponse> DeleteDataModel(DeleteDataModelRequest req)
        {
            return InternalRequestAsync<DeleteDataModelResponse>(req, "DeleteDataModel");
        }

        /// <summary>
        /// 销毁数据建模，提供给云应用使用，实现“Wedata数据建模”的销毁
        /// </summary>
        /// <param name="req"><see cref="DeleteDataModelRequest"/></param>
        /// <returns><see cref="DeleteDataModelResponse"/></returns>
        public DeleteDataModelResponse DeleteDataModelSync(DeleteDataModelRequest req)
        {
            return InternalRequestAsync<DeleteDataModelResponse>(req, "DeleteDataModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public Task<DeleteDataSourcesResponse> DeleteDataSources(DeleteDataSourcesRequest req)
        {
            return InternalRequestAsync<DeleteDataSourcesResponse>(req, "DeleteDataSources");
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public DeleteDataSourcesResponse DeleteDataSourcesSync(DeleteDataSourcesRequest req)
        {
            return InternalRequestAsync<DeleteDataSourcesResponse>(req, "DeleteDataSources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteDsFolderRequest"/></param>
        /// <returns><see cref="DeleteDsFolderResponse"/></returns>
        public Task<DeleteDsFolderResponse> DeleteDsFolder(DeleteDsFolderRequest req)
        {
            return InternalRequestAsync<DeleteDsFolderResponse>(req, "DeleteDsFolder");
        }

        /// <summary>
        /// 编排空间-删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteDsFolderRequest"/></param>
        /// <returns><see cref="DeleteDsFolderResponse"/></returns>
        public DeleteDsFolderResponse DeleteDsFolderSync(DeleteDsFolderRequest req)
        {
            return InternalRequestAsync<DeleteDsFolderResponse>(req, "DeleteDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public Task<DeleteFileResponse> DeleteFile(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile");
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public DeleteFileResponse DeleteFileSync(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发空间-批量删除目录和文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilePathRequest"/></param>
        /// <returns><see cref="DeleteFilePathResponse"/></returns>
        public Task<DeleteFilePathResponse> DeleteFilePath(DeleteFilePathRequest req)
        {
            return InternalRequestAsync<DeleteFilePathResponse>(req, "DeleteFilePath");
        }

        /// <summary>
        /// 开发空间-批量删除目录和文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilePathRequest"/></param>
        /// <returns><see cref="DeleteFilePathResponse"/></returns>
        public DeleteFilePathResponse DeleteFilePathSync(DeleteFilePathRequest req)
        {
            return InternalRequestAsync<DeleteFilePathResponse>(req, "DeleteFilePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集成节点
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public Task<DeleteIntegrationNodeResponse> DeleteIntegrationNode(DeleteIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationNodeResponse>(req, "DeleteIntegrationNode");
        }

        /// <summary>
        /// 删除集成节点
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationNodeRequest"/></param>
        /// <returns><see cref="DeleteIntegrationNodeResponse"/></returns>
        public DeleteIntegrationNodeResponse DeleteIntegrationNodeSync(DeleteIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationNodeResponse>(req, "DeleteIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public Task<DeleteIntegrationTaskResponse> DeleteIntegrationTask(DeleteIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationTaskResponse>(req, "DeleteIntegrationTask");
        }

        /// <summary>
        /// 删除集成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationTaskRequest"/></param>
        /// <returns><see cref="DeleteIntegrationTaskResponse"/></returns>
        public DeleteIntegrationTaskResponse DeleteIntegrationTaskSync(DeleteIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteIntegrationTaskResponse>(req, "DeleteIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public Task<DeleteOfflineTaskResponse> DeleteOfflineTask(DeleteOfflineTaskRequest req)
        {
            return InternalRequestAsync<DeleteOfflineTaskResponse>(req, "DeleteOfflineTask");
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineTaskRequest"/></param>
        /// <returns><see cref="DeleteOfflineTaskResponse"/></returns>
        public DeleteOfflineTaskResponse DeleteOfflineTaskSync(DeleteOfflineTaskRequest req)
        {
            return InternalRequestAsync<DeleteOfflineTaskResponse>(req, "DeleteOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目参数
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamDsResponse"/></returns>
        public Task<DeleteProjectParamDsResponse> DeleteProjectParamDs(DeleteProjectParamDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamDsResponse>(req, "DeleteProjectParamDs");
        }

        /// <summary>
        /// 删除项目参数
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamDsResponse"/></returns>
        public DeleteProjectParamDsResponse DeleteProjectParamDsSync(DeleteProjectParamDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamDsResponse>(req, "DeleteProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目用户
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectUsersRequest"/></param>
        /// <returns><see cref="DeleteProjectUsersResponse"/></returns>
        public Task<DeleteProjectUsersResponse> DeleteProjectUsers(DeleteProjectUsersRequest req)
        {
            return InternalRequestAsync<DeleteProjectUsersResponse>(req, "DeleteProjectUsers");
        }

        /// <summary>
        /// 删除项目用户
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectUsersRequest"/></param>
        /// <returns><see cref="DeleteProjectUsersResponse"/></returns>
        public DeleteProjectUsersResponse DeleteProjectUsersSync(DeleteProjectUsersRequest req)
        {
            return InternalRequestAsync<DeleteProjectUsersResponse>(req, "DeleteProjectUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理删除资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public Task<DeleteResourceResponse> DeleteResource(DeleteResourceRequest req)
        {
            return InternalRequestAsync<DeleteResourceResponse>(req, "DeleteResource");
        }

        /// <summary>
        /// 资源管理删除资源
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceRequest"/></param>
        /// <returns><see cref="DeleteResourceResponse"/></returns>
        public DeleteResourceResponse DeleteResourceSync(DeleteResourceRequest req)
        {
            return InternalRequestAsync<DeleteResourceResponse>(req, "DeleteResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public Task<DeleteResourceFileResponse> DeleteResourceFile(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile");
        }

        /// <summary>
        /// 资源管理-删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFileRequest"/></param>
        /// <returns><see cref="DeleteResourceFileResponse"/></returns>
        public DeleteResourceFileResponse DeleteResourceFileSync(DeleteResourceFileRequest req)
        {
            return InternalRequestAsync<DeleteResourceFileResponse>(req, "DeleteResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-批量删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFilesRequest"/></param>
        /// <returns><see cref="DeleteResourceFilesResponse"/></returns>
        public Task<DeleteResourceFilesResponse> DeleteResourceFiles(DeleteResourceFilesRequest req)
        {
            return InternalRequestAsync<DeleteResourceFilesResponse>(req, "DeleteResourceFiles");
        }

        /// <summary>
        /// 资源管理-批量删除资源文件
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceFilesRequest"/></param>
        /// <returns><see cref="DeleteResourceFilesResponse"/></returns>
        public DeleteResourceFilesResponse DeleteResourceFilesSync(DeleteResourceFilesRequest req)
        {
            return InternalRequestAsync<DeleteResourceFilesResponse>(req, "DeleteResourceFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除质量规则接口
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// 删除质量规则接口
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public Task<DeleteRuleTemplateResponse> DeleteRuleTemplate(DeleteRuleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRuleTemplateResponse>(req, "DeleteRuleTemplate");
        }

        /// <summary>
        /// 删除规则模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public DeleteRuleTemplateResponse DeleteRuleTemplateSync(DeleteRuleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRuleTemplateResponse>(req, "DeleteRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public Task<DeleteTaskAlarmRegularResponse> DeleteTaskAlarmRegular(DeleteTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<DeleteTaskAlarmRegularResponse>(req, "DeleteTaskAlarmRegular");
        }

        /// <summary>
        /// 删除任务告警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="DeleteTaskAlarmRegularResponse"/></returns>
        public DeleteTaskAlarmRegularResponse DeleteTaskAlarmRegularSync(DeleteTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<DeleteTaskAlarmRegularResponse>(req, "DeleteTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除编排空间任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public Task<DeleteTaskDsResponse> DeleteTaskDs(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs");
        }

        /// <summary>
        /// 删除编排空间任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public DeleteTaskDsResponse DeleteTaskDsSync(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过工作流Id删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowByIdRequest"/></param>
        /// <returns><see cref="DeleteWorkflowByIdResponse"/></returns>
        public Task<DeleteWorkflowByIdResponse> DeleteWorkflowById(DeleteWorkflowByIdRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowByIdResponse>(req, "DeleteWorkflowById");
        }

        /// <summary>
        /// 通过工作流Id删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowByIdRequest"/></param>
        /// <returns><see cref="DeleteWorkflowByIdResponse"/></returns>
        public DeleteWorkflowByIdResponse DeleteWorkflowByIdSync(DeleteWorkflowByIdRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowByIdResponse>(req, "DeleteWorkflowById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents");
        }

        /// <summary>
        /// 告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警接收人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public Task<DescribeAlarmReceiverResponse> DescribeAlarmReceiver(DescribeAlarmReceiverRequest req)
        {
            return InternalRequestAsync<DescribeAlarmReceiverResponse>(req, "DescribeAlarmReceiver");
        }

        /// <summary>
        /// 告警接收人详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmReceiverRequest"/></param>
        /// <returns><see cref="DescribeAlarmReceiverResponse"/></returns>
        public DescribeAlarmReceiverResponse DescribeAlarmReceiverSync(DescribeAlarmReceiverRequest req)
        {
            return InternalRequestAsync<DescribeAlarmReceiverResponse>(req, "DescribeAlarmReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询父目录下所有子文件夹+工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeAllByFolderNewRequest"/></param>
        /// <returns><see cref="DescribeAllByFolderNewResponse"/></returns>
        public Task<DescribeAllByFolderNewResponse> DescribeAllByFolderNew(DescribeAllByFolderNewRequest req)
        {
            return InternalRequestAsync<DescribeAllByFolderNewResponse>(req, "DescribeAllByFolderNew");
        }

        /// <summary>
        /// 查询父目录下所有子文件夹+工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeAllByFolderNewRequest"/></param>
        /// <returns><see cref="DescribeAllByFolderNewResponse"/></returns>
        public DescribeAllByFolderNewResponse DescribeAllByFolderNewSync(DescribeAllByFolderNewRequest req)
        {
            return InternalRequestAsync<DescribeAllByFolderNewResponse>(req, "DescribeAllByFolderNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取待审批列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveListRequest"/></param>
        /// <returns><see cref="DescribeApproveListResponse"/></returns>
        public Task<DescribeApproveListResponse> DescribeApproveList(DescribeApproveListRequest req)
        {
            return InternalRequestAsync<DescribeApproveListResponse>(req, "DescribeApproveList");
        }

        /// <summary>
        /// 获取待审批列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveListRequest"/></param>
        /// <returns><see cref="DescribeApproveListResponse"/></returns>
        public DescribeApproveListResponse DescribeApproveListSync(DescribeApproveListRequest req)
        {
            return InternalRequestAsync<DescribeApproveListResponse>(req, "DescribeApproveList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审批分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveTypeListRequest"/></param>
        /// <returns><see cref="DescribeApproveTypeListResponse"/></returns>
        public Task<DescribeApproveTypeListResponse> DescribeApproveTypeList(DescribeApproveTypeListRequest req)
        {
            return InternalRequestAsync<DescribeApproveTypeListResponse>(req, "DescribeApproveTypeList");
        }

        /// <summary>
        /// 获取审批分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApproveTypeListRequest"/></param>
        /// <returns><see cref="DescribeApproveTypeListResponse"/></returns>
        public DescribeApproveTypeListResponse DescribeApproveTypeListSync(DescribeApproveTypeListRequest req)
        {
            return InternalRequestAsync<DescribeApproveTypeListResponse>(req, "DescribeApproveTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量操作页面获取任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public Task<DescribeBatchOperateTaskResponse> DescribeBatchOperateTask(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask");
        }

        /// <summary>
        /// 批量操作页面获取任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public DescribeBatchOperateTaskResponse DescribeBatchOperateTaskSync(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出字段血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnLineageRequest"/></param>
        /// <returns><see cref="DescribeColumnLineageResponse"/></returns>
        public Task<DescribeColumnLineageResponse> DescribeColumnLineage(DescribeColumnLineageRequest req)
        {
            return InternalRequestAsync<DescribeColumnLineageResponse>(req, "DescribeColumnLineage");
        }

        /// <summary>
        /// 列出字段血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnLineageRequest"/></param>
        /// <returns><see cref="DescribeColumnLineageResponse"/></returns>
        public DescribeColumnLineageResponse DescribeColumnLineageSync(DescribeColumnLineageRequest req)
        {
            return InternalRequestAsync<DescribeColumnLineageResponse>(req, "DescribeColumnLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表的所有列元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnsMetaRequest"/></param>
        /// <returns><see cref="DescribeColumnsMetaResponse"/></returns>
        public Task<DescribeColumnsMetaResponse> DescribeColumnsMeta(DescribeColumnsMetaRequest req)
        {
            return InternalRequestAsync<DescribeColumnsMetaResponse>(req, "DescribeColumnsMeta");
        }

        /// <summary>
        /// 查询表的所有列元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeColumnsMetaRequest"/></param>
        /// <returns><see cref="DescribeColumnsMetaResponse"/></returns>
        public DescribeColumnsMetaResponse DescribeColumnsMetaSync(DescribeColumnsMetaRequest req)
        {
            return InternalRequestAsync<DescribeColumnsMetaResponse>(req, "DescribeColumnsMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量的概览页面数据监测情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public Task<DescribeDataCheckStatResponse> DescribeDataCheckStat(DescribeDataCheckStatRequest req)
        {
            return InternalRequestAsync<DescribeDataCheckStatResponse>(req, "DescribeDataCheckStat");
        }

        /// <summary>
        /// 数据质量的概览页面数据监测情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCheckStatRequest"/></param>
        /// <returns><see cref="DescribeDataCheckStatResponse"/></returns>
        public DescribeDataCheckStatResponse DescribeDataCheckStatSync(DescribeDataCheckStatRequest req)
        {
            return InternalRequestAsync<DescribeDataCheckStatResponse>(req, "DescribeDataCheckStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据服务API的发布态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataServicePublishedApiDetailRequest"/></param>
        /// <returns><see cref="DescribeDataServicePublishedApiDetailResponse"/></returns>
        public Task<DescribeDataServicePublishedApiDetailResponse> DescribeDataServicePublishedApiDetail(DescribeDataServicePublishedApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataServicePublishedApiDetailResponse>(req, "DescribeDataServicePublishedApiDetail");
        }

        /// <summary>
        /// 查询数据服务API的发布态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataServicePublishedApiDetailRequest"/></param>
        /// <returns><see cref="DescribeDataServicePublishedApiDetailResponse"/></returns>
        public DescribeDataServicePublishedApiDetailResponse DescribeDataServicePublishedApiDetailSync(DescribeDataServicePublishedApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataServicePublishedApiDetailResponse>(req, "DescribeDataServicePublishedApiDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据服务API的发布态信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataServicePublishedApiListRequest"/></param>
        /// <returns><see cref="DescribeDataServicePublishedApiListResponse"/></returns>
        public Task<DescribeDataServicePublishedApiListResponse> DescribeDataServicePublishedApiList(DescribeDataServicePublishedApiListRequest req)
        {
            return InternalRequestAsync<DescribeDataServicePublishedApiListResponse>(req, "DescribeDataServicePublishedApiList");
        }

        /// <summary>
        /// 获取数据服务API的发布态信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataServicePublishedApiListRequest"/></param>
        /// <returns><see cref="DescribeDataServicePublishedApiListResponse"/></returns>
        public DescribeDataServicePublishedApiListResponse DescribeDataServicePublishedApiListSync(DescribeDataServicePublishedApiListRequest req)
        {
            return InternalRequestAsync<DescribeDataServicePublishedApiListResponse>(req, "DescribeDataServicePublishedApiList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据源信息-数据源分页列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public Task<DescribeDataSourceInfoListResponse> DescribeDataSourceInfoList(DescribeDataSourceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceInfoListResponse>(req, "DescribeDataSourceInfoList");
        }

        /// <summary>
        /// 获取数据源信息-数据源分页列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceInfoListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceInfoListResponse"/></returns>
        public DescribeDataSourceInfoListResponse DescribeDataSourceInfoListSync(DescribeDataSourceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceInfoListResponse>(req, "DescribeDataSourceInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList");
        }

        /// <summary>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public DescribeDataSourceListResponse DescribeDataSourceListSync(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public Task<DescribeDatabaseInfoListResponse> DescribeDatabaseInfoList(DescribeDatabaseInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseInfoListResponse>(req, "DescribeDatabaseInfoList");
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseInfoListRequest"/></param>
        /// <returns><see cref="DescribeDatabaseInfoListResponse"/></returns>
        public DescribeDatabaseInfoListResponse DescribeDatabaseInfoListSync(DescribeDatabaseInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseInfoListResponse>(req, "DescribeDatabaseInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseMetasRequest"/></param>
        /// <returns><see cref="DescribeDatabaseMetasResponse"/></returns>
        public Task<DescribeDatabaseMetasResponse> DescribeDatabaseMetas(DescribeDatabaseMetasRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseMetasResponse>(req, "DescribeDatabaseMetas");
        }

        /// <summary>
        /// 查询数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseMetasRequest"/></param>
        /// <returns><see cref="DescribeDatabaseMetasResponse"/></returns>
        public DescribeDatabaseMetasResponse DescribeDatabaseMetasSync(DescribeDatabaseMetasRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseMetasResponse>(req, "DescribeDatabaseMetas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public Task<DescribeDatasourceResponse> DescribeDatasource(DescribeDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceResponse>(req, "DescribeDatasource");
        }

        /// <summary>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public DescribeDatasourceResponse DescribeDatasourceSync(DescribeDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceResponse>(req, "DescribeDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTasksResponse"/></returns>
        public Task<DescribeDependOpsTasksResponse> DescribeDependOpsTasks(DescribeDependOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTasksResponse>(req, "DescribeDependOpsTasks");
        }

        /// <summary>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTasksResponse"/></returns>
        public DescribeDependOpsTasksResponse DescribeDependOpsTasksSync(DescribeDependOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTasksResponse>(req, "DescribeDependOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过taskIds查询task详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTaskListsRequest"/></param>
        /// <returns><see cref="DescribeDependTaskListsResponse"/></returns>
        public Task<DescribeDependTaskListsResponse> DescribeDependTaskLists(DescribeDependTaskListsRequest req)
        {
            return InternalRequestAsync<DescribeDependTaskListsResponse>(req, "DescribeDependTaskLists");
        }

        /// <summary>
        /// 通过taskIds查询task详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTaskListsRequest"/></param>
        /// <returns><see cref="DescribeDependTaskListsResponse"/></returns>
        public DescribeDependTaskListsResponse DescribeDependTaskListsSync(DescribeDependTaskListsRequest req)
        {
            return InternalRequestAsync<DescribeDependTaskListsResponse>(req, "DescribeDependTaskLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 质量报告-查询质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public Task<DescribeDimensionScoreResponse> DescribeDimensionScore(DescribeDimensionScoreRequest req)
        {
            return InternalRequestAsync<DescribeDimensionScoreResponse>(req, "DescribeDimensionScore");
        }

        /// <summary>
        /// 质量报告-查询质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeDimensionScoreRequest"/></param>
        /// <returns><see cref="DescribeDimensionScoreResponse"/></returns>
        public DescribeDimensionScoreResponse DescribeDimensionScoreSync(DescribeDimensionScoreRequest req)
        {
            return InternalRequestAsync<DescribeDimensionScoreResponse>(req, "DescribeDimensionScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 无效API，没有上线过的业务功能
        /// 
        /// 分页查询试运行实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstancePageRequest"/></param>
        /// <returns><see cref="DescribeDrInstancePageResponse"/></returns>
        public Task<DescribeDrInstancePageResponse> DescribeDrInstancePage(DescribeDrInstancePageRequest req)
        {
            return InternalRequestAsync<DescribeDrInstancePageResponse>(req, "DescribeDrInstancePage");
        }

        /// <summary>
        /// 无效API，没有上线过的业务功能
        /// 
        /// 分页查询试运行实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstancePageRequest"/></param>
        /// <returns><see cref="DescribeDrInstancePageResponse"/></returns>
        public DescribeDrInstancePageResponse DescribeDrInstancePageSync(DescribeDrInstancePageRequest req)
        {
            return InternalRequestAsync<DescribeDrInstancePageResponse>(req, "DescribeDrInstancePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeDsFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsFolderTreeResponse"/></returns>
        public Task<DescribeDsFolderTreeResponse> DescribeDsFolderTree(DescribeDsFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsFolderTreeResponse>(req, "DescribeDsFolderTree");
        }

        /// <summary>
        /// 查询目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeDsFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsFolderTreeResponse"/></returns>
        public DescribeDsFolderTreeResponse DescribeDsFolderTreeSync(DescribeDsFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsFolderTreeResponse>(req, "DescribeDsFolderTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询父目录树，用于工作流、任务定位
        /// </summary>
        /// <param name="req"><see cref="DescribeDsParentFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsParentFolderTreeResponse"/></returns>
        public Task<DescribeDsParentFolderTreeResponse> DescribeDsParentFolderTree(DescribeDsParentFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsParentFolderTreeResponse>(req, "DescribeDsParentFolderTree");
        }

        /// <summary>
        /// 查询父目录树，用于工作流、任务定位
        /// </summary>
        /// <param name="req"><see cref="DescribeDsParentFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsParentFolderTreeResponse"/></returns>
        public DescribeDsParentFolderTreeResponse DescribeDsParentFolderTreeSync(DescribeDsParentFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsParentFolderTreeResponse>(req, "DescribeDsParentFolderTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取值班日历
        /// </summary>
        /// <param name="req"><see cref="DescribeDutyScheduleDetailsRequest"/></param>
        /// <returns><see cref="DescribeDutyScheduleDetailsResponse"/></returns>
        public Task<DescribeDutyScheduleDetailsResponse> DescribeDutyScheduleDetails(DescribeDutyScheduleDetailsRequest req)
        {
            return InternalRequestAsync<DescribeDutyScheduleDetailsResponse>(req, "DescribeDutyScheduleDetails");
        }

        /// <summary>
        /// 获取值班日历
        /// </summary>
        /// <param name="req"><see cref="DescribeDutyScheduleDetailsRequest"/></param>
        /// <returns><see cref="DescribeDutyScheduleDetailsResponse"/></returns>
        public DescribeDutyScheduleDetailsResponse DescribeDutyScheduleDetailsSync(DescribeDutyScheduleDetailsRequest req)
        {
            return InternalRequestAsync<DescribeDutyScheduleDetailsResponse>(req, "DescribeDutyScheduleDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取值班表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDutyScheduleListRequest"/></param>
        /// <returns><see cref="DescribeDutyScheduleListResponse"/></returns>
        public Task<DescribeDutyScheduleListResponse> DescribeDutyScheduleList(DescribeDutyScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeDutyScheduleListResponse>(req, "DescribeDutyScheduleList");
        }

        /// <summary>
        /// 获取值班表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDutyScheduleListRequest"/></param>
        /// <returns><see cref="DescribeDutyScheduleListResponse"/></returns>
        public DescribeDutyScheduleListResponse DescribeDutyScheduleListSync(DescribeDutyScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeDutyScheduleListResponse>(req, "DescribeDutyScheduleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据项目ID和事件名称查看事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventRequest"/></param>
        /// <returns><see cref="DescribeEventResponse"/></returns>
        public Task<DescribeEventResponse> DescribeEvent(DescribeEventRequest req)
        {
            return InternalRequestAsync<DescribeEventResponse>(req, "DescribeEvent");
        }

        /// <summary>
        /// 根据项目ID和事件名称查看事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventRequest"/></param>
        /// <returns><see cref="DescribeEventResponse"/></returns>
        public DescribeEventResponse DescribeEventSync(DescribeEventRequest req)
        {
            return InternalRequestAsync<DescribeEventResponse>(req, "DescribeEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件查找事件实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEventCasesRequest"/></param>
        /// <returns><see cref="DescribeEventCasesResponse"/></returns>
        public Task<DescribeEventCasesResponse> DescribeEventCases(DescribeEventCasesRequest req)
        {
            return InternalRequestAsync<DescribeEventCasesResponse>(req, "DescribeEventCases");
        }

        /// <summary>
        /// 根据条件查找事件实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEventCasesRequest"/></param>
        /// <returns><see cref="DescribeEventCasesResponse"/></returns>
        public DescribeEventCasesResponse DescribeEventCasesSync(DescribeEventCasesRequest req)
        {
            return InternalRequestAsync<DescribeEventCasesResponse>(req, "DescribeEventCases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看事件实例的消费任务
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribeEventConsumeTasksResponse"/></returns>
        public Task<DescribeEventConsumeTasksResponse> DescribeEventConsumeTasks(DescribeEventConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribeEventConsumeTasksResponse>(req, "DescribeEventConsumeTasks");
        }

        /// <summary>
        /// 查看事件实例的消费任务
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConsumeTasksRequest"/></param>
        /// <returns><see cref="DescribeEventConsumeTasksResponse"/></returns>
        public DescribeEventConsumeTasksResponse DescribeEventConsumeTasksSync(DescribeEventConsumeTasksRequest req)
        {
            return InternalRequestAsync<DescribeEventConsumeTasksResponse>(req, "DescribeEventConsumeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public Task<DescribeExecStrategyResponse> DescribeExecStrategy(DescribeExecStrategyRequest req)
        {
            return InternalRequestAsync<DescribeExecStrategyResponse>(req, "DescribeExecStrategy");
        }

        /// <summary>
        /// 查询规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="DescribeExecStrategyRequest"/></param>
        /// <returns><see cref="DescribeExecStrategyResponse"/></returns>
        public DescribeExecStrategyResponse DescribeExecStrategySync(DescribeExecStrategyRequest req)
        {
            return InternalRequestAsync<DescribeExecStrategyResponse>(req, "DescribeExecStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 元数据模型-字段基础信息查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeFieldBasicInfoResponse"/></returns>
        public Task<DescribeFieldBasicInfoResponse> DescribeFieldBasicInfo(DescribeFieldBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeFieldBasicInfoResponse>(req, "DescribeFieldBasicInfo");
        }

        /// <summary>
        /// 元数据模型-字段基础信息查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeFieldBasicInfoResponse"/></returns>
        public DescribeFieldBasicInfoResponse DescribeFieldBasicInfoSync(DescribeFieldBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeFieldBasicInfoResponse>(req, "DescribeFieldBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据项目id 获取项目下所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public Task<DescribeFolderWorkflowListResponse> DescribeFolderWorkflowList(DescribeFolderWorkflowListRequest req)
        {
            return InternalRequestAsync<DescribeFolderWorkflowListResponse>(req, "DescribeFolderWorkflowList");
        }

        /// <summary>
        /// 根据项目id 获取项目下所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public DescribeFolderWorkflowListResponse DescribeFolderWorkflowListSync(DescribeFolderWorkflowListRequest req)
        {
            return InternalRequestAsync<DescribeFolderWorkflowListResponse>(req, "DescribeFolderWorkflowList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询函数分类
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public Task<DescribeFunctionKindsResponse> DescribeFunctionKinds(DescribeFunctionKindsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionKindsResponse>(req, "DescribeFunctionKinds");
        }

        /// <summary>
        /// 查询函数分类
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionKindsRequest"/></param>
        /// <returns><see cref="DescribeFunctionKindsResponse"/></returns>
        public DescribeFunctionKindsResponse DescribeFunctionKindsSync(DescribeFunctionKindsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionKindsResponse>(req, "DescribeFunctionKinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询函数类型
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public Task<DescribeFunctionTypesResponse> DescribeFunctionTypes(DescribeFunctionTypesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionTypesResponse>(req, "DescribeFunctionTypes");
        }

        /// <summary>
        /// 查询函数类型
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionTypesRequest"/></param>
        /// <returns><see cref="DescribeFunctionTypesResponse"/></returns>
        public DescribeFunctionTypesResponse DescribeFunctionTypesSync(DescribeFunctionTypesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionTypesResponse>(req, "DescribeFunctionTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据周期类型查询所有实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleResponse"/></returns>
        public Task<DescribeInstanceByCycleResponse> DescribeInstanceByCycle(DescribeInstanceByCycleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleResponse>(req, "DescribeInstanceByCycle");
        }

        /// <summary>
        /// 根据周期类型查询所有实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleResponse"/></returns>
        public DescribeInstanceByCycleResponse DescribeInstanceByCycleSync(DescribeInstanceByCycleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleResponse>(req, "DescribeInstanceByCycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例详情页，返回某个实例所有生命周期信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailInfoResponse"/></returns>
        public Task<DescribeInstanceDetailInfoResponse> DescribeInstanceDetailInfo(DescribeInstanceDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailInfoResponse>(req, "DescribeInstanceDetailInfo");
        }

        /// <summary>
        /// 实例详情页，返回某个实例所有生命周期信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailInfoResponse"/></returns>
        public DescribeInstanceDetailInfoResponse DescribeInstanceDetailInfoSync(DescribeInstanceDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailInfoResponse>(req, "DescribeInstanceDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 日志获取详情页面
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public Task<DescribeInstanceLastLogResponse> DescribeInstanceLastLog(DescribeInstanceLastLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLastLogResponse>(req, "DescribeInstanceLastLog");
        }

        /// <summary>
        /// 日志获取详情页面
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLastLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLastLogResponse"/></returns>
        public DescribeInstanceLastLogResponse DescribeInstanceLastLogSync(DescribeInstanceLastLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLastLogResponse>(req, "DescribeInstanceLastLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public Task<DescribeInstanceLogResponse> DescribeInstanceLog(DescribeInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogResponse>(req, "DescribeInstanceLog");
        }

        /// <summary>
        /// 获取实例运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogResponse"/></returns>
        public DescribeInstanceLogResponse DescribeInstanceLogSync(DescribeInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogResponse>(req, "DescribeInstanceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取具体实例相关日志信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogDetailResponse"/></returns>
        public Task<DescribeInstanceLogDetailResponse> DescribeInstanceLogDetail(DescribeInstanceLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogDetailResponse>(req, "DescribeInstanceLogDetail");
        }

        /// <summary>
        /// 获取具体实例相关日志信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogDetailResponse"/></returns>
        public DescribeInstanceLogDetailResponse DescribeInstanceLogDetailSync(DescribeInstanceLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogDetailResponse>(req, "DescribeInstanceLogDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载日志文件，返回日志下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogFileRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogFileResponse"/></returns>
        public Task<DescribeInstanceLogFileResponse> DescribeInstanceLogFile(DescribeInstanceLogFileRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogFileResponse>(req, "DescribeInstanceLogFile");
        }

        /// <summary>
        /// 下载日志文件，返回日志下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogFileRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogFileResponse"/></returns>
        public DescribeInstanceLogFileResponse DescribeInstanceLogFileSync(DescribeInstanceLogFileRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogFileResponse>(req, "DescribeInstanceLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 离线任务实例运行日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public Task<DescribeInstanceLogListResponse> DescribeInstanceLogList(DescribeInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogListResponse>(req, "DescribeInstanceLogList");
        }

        /// <summary>
        /// 离线任务实例运行日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogListResponse"/></returns>
        public DescribeInstanceLogListResponse DescribeInstanceLogListSync(DescribeInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogListResponse>(req, "DescribeInstanceLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集成节点
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public Task<DescribeIntegrationNodeResponse> DescribeIntegrationNode(DescribeIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationNodeResponse>(req, "DescribeIntegrationNode");
        }

        /// <summary>
        /// 查询集成节点
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationNodeRequest"/></param>
        /// <returns><see cref="DescribeIntegrationNodeResponse"/></returns>
        public DescribeIntegrationNodeResponse DescribeIntegrationNodeSync(DescribeIntegrationNodeRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationNodeResponse>(req, "DescribeIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据集成大屏概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public Task<DescribeIntegrationStatisticsResponse> DescribeIntegrationStatistics(DescribeIntegrationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsResponse>(req, "DescribeIntegrationStatistics");
        }

        /// <summary>
        /// 数据集成大屏概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsResponse"/></returns>
        public DescribeIntegrationStatisticsResponse DescribeIntegrationStatisticsSync(DescribeIntegrationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsResponse>(req, "DescribeIntegrationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据集成大屏实例状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsInstanceTrendResponse> DescribeIntegrationStatisticsInstanceTrend(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsInstanceTrendResponse>(req, "DescribeIntegrationStatisticsInstanceTrend");
        }

        /// <summary>
        /// 数据集成大屏实例状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsInstanceTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsInstanceTrendResponse"/></returns>
        public DescribeIntegrationStatisticsInstanceTrendResponse DescribeIntegrationStatisticsInstanceTrendSync(DescribeIntegrationStatisticsInstanceTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsInstanceTrendResponse>(req, "DescribeIntegrationStatisticsInstanceTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据集成大屏同步条数统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsRecordsTrendResponse> DescribeIntegrationStatisticsRecordsTrend(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsRecordsTrendResponse>(req, "DescribeIntegrationStatisticsRecordsTrend");
        }

        /// <summary>
        /// 数据集成大屏同步条数统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsRecordsTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsRecordsTrendResponse"/></returns>
        public DescribeIntegrationStatisticsRecordsTrendResponse DescribeIntegrationStatisticsRecordsTrendSync(DescribeIntegrationStatisticsRecordsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsRecordsTrendResponse>(req, "DescribeIntegrationStatisticsRecordsTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据集成大屏任务状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public Task<DescribeIntegrationStatisticsTaskStatusResponse> DescribeIntegrationStatisticsTaskStatus(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusResponse>(req, "DescribeIntegrationStatisticsTaskStatus");
        }

        /// <summary>
        /// 数据集成大屏任务状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusResponse DescribeIntegrationStatisticsTaskStatusSync(DescribeIntegrationStatisticsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusResponse>(req, "DescribeIntegrationStatisticsTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据集成大屏任务状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public Task<DescribeIntegrationStatisticsTaskStatusTrendResponse> DescribeIntegrationStatisticsTaskStatusTrend(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusTrendResponse>(req, "DescribeIntegrationStatisticsTaskStatusTrend");
        }

        /// <summary>
        /// 数据集成大屏任务状态统计趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsTaskStatusTrendRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsTaskStatusTrendResponse"/></returns>
        public DescribeIntegrationStatisticsTaskStatusTrendResponse DescribeIntegrationStatisticsTaskStatusTrendSync(DescribeIntegrationStatisticsTaskStatusTrendRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsTaskStatusTrendResponse>(req, "DescribeIntegrationStatisticsTaskStatusTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public Task<DescribeIntegrationTaskResponse> DescribeIntegrationTask(DescribeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTaskResponse>(req, "DescribeIntegrationTask");
        }

        /// <summary>
        /// 查询集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTaskRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTaskResponse"/></returns>
        public DescribeIntegrationTaskResponse DescribeIntegrationTaskSync(DescribeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTaskResponse>(req, "DescribeIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集成任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public Task<DescribeIntegrationTasksResponse> DescribeIntegrationTasks(DescribeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTasksResponse>(req, "DescribeIntegrationTasks");
        }

        /// <summary>
        /// 查询集成任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationTasksRequest"/></param>
        /// <returns><see cref="DescribeIntegrationTasksResponse"/></returns>
        public DescribeIntegrationTasksResponse DescribeIntegrationTasksSync(DescribeIntegrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationTasksResponse>(req, "DescribeIntegrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集成任务版本节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public Task<DescribeIntegrationVersionNodesInfoResponse> DescribeIntegrationVersionNodesInfo(DescribeIntegrationVersionNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationVersionNodesInfoResponse>(req, "DescribeIntegrationVersionNodesInfo");
        }

        /// <summary>
        /// 查询集成任务版本节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationVersionNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeIntegrationVersionNodesInfoResponse"/></returns>
        public DescribeIntegrationVersionNodesInfoResponse DescribeIntegrationVersionNodesInfoSync(DescribeIntegrationVersionNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationVersionNodesInfoResponse>(req, "DescribeIntegrationVersionNodesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取离线任务长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public Task<DescribeOfflineTaskTokenResponse> DescribeOfflineTaskToken(DescribeOfflineTaskTokenRequest req)
        {
            return InternalRequestAsync<DescribeOfflineTaskTokenResponse>(req, "DescribeOfflineTaskToken");
        }

        /// <summary>
        /// 获取离线任务长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineTaskTokenRequest"/></param>
        /// <returns><see cref="DescribeOfflineTaskTokenResponse"/></returns>
        public DescribeOfflineTaskTokenResponse DescribeOfflineTaskTokenSync(DescribeOfflineTaskTokenRequest req)
        {
            return InternalRequestAsync<DescribeOfflineTaskTokenResponse>(req, "DescribeOfflineTaskToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维列表组合条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTasksResponse"/></returns>
        public Task<DescribeOperateOpsTasksResponse> DescribeOperateOpsTasks(DescribeOperateOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTasksResponse>(req, "DescribeOperateOpsTasks");
        }

        /// <summary>
        /// 任务运维列表组合条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTasksResponse"/></returns>
        public DescribeOperateOpsTasksResponse DescribeOperateOpsTasksSync(DescribeOperateOpsTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTasksResponse>(req, "DescribeOperateOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例运维-获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeOpsInstanceLogListResponse"/></returns>
        public Task<DescribeOpsInstanceLogListResponse> DescribeOpsInstanceLogList(DescribeOpsInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeOpsInstanceLogListResponse>(req, "DescribeOpsInstanceLogList");
        }

        /// <summary>
        /// 实例运维-获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsInstanceLogListRequest"/></param>
        /// <returns><see cref="DescribeOpsInstanceLogListResponse"/></returns>
        public DescribeOpsInstanceLogListResponse DescribeOpsInstanceLogListSync(DescribeOpsInstanceLogListRequest req)
        {
            return InternalRequestAsync<DescribeOpsInstanceLogListResponse>(req, "DescribeOpsInstanceLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据补录计划和补录任务获取补录实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanInstancesResponse"/></returns>
        public Task<DescribeOpsMakePlanInstancesResponse> DescribeOpsMakePlanInstances(DescribeOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanInstancesResponse>(req, "DescribeOpsMakePlanInstances");
        }

        /// <summary>
        /// 根据补录计划和补录任务获取补录实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanInstancesResponse"/></returns>
        public DescribeOpsMakePlanInstancesResponse DescribeOpsMakePlanInstancesSync(DescribeOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanInstancesResponse>(req, "DescribeOpsMakePlanInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看补录计划任务
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanTasksRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanTasksResponse"/></returns>
        public Task<DescribeOpsMakePlanTasksResponse> DescribeOpsMakePlanTasks(DescribeOpsMakePlanTasksRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanTasksResponse>(req, "DescribeOpsMakePlanTasks");
        }

        /// <summary>
        /// 查看补录计划任务
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlanTasksRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlanTasksResponse"/></returns>
        public DescribeOpsMakePlanTasksResponse DescribeOpsMakePlanTasksSync(DescribeOpsMakePlanTasksRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlanTasksResponse>(req, "DescribeOpsMakePlanTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件分页查询补录计划
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlansRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlansResponse"/></returns>
        public Task<DescribeOpsMakePlansResponse> DescribeOpsMakePlans(DescribeOpsMakePlansRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlansResponse>(req, "DescribeOpsMakePlans");
        }

        /// <summary>
        /// 根据条件分页查询补录计划
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsMakePlansRequest"/></param>
        /// <returns><see cref="DescribeOpsMakePlansResponse"/></returns>
        public DescribeOpsMakePlansResponse DescribeOpsMakePlansSync(DescribeOpsMakePlansRequest req)
        {
            return InternalRequestAsync<DescribeOpsMakePlansResponse>(req, "DescribeOpsMakePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户生产工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeOpsWorkflowsResponse"/></returns>
        public Task<DescribeOpsWorkflowsResponse> DescribeOpsWorkflows(DescribeOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeOpsWorkflowsResponse>(req, "DescribeOpsWorkflows");
        }

        /// <summary>
        /// 查询用户生产工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOpsWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeOpsWorkflowsResponse"/></returns>
        public DescribeOpsWorkflowsResponse DescribeOpsWorkflowsSync(DescribeOpsWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeOpsWorkflowsResponse>(req, "DescribeOpsWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全量函数
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public Task<DescribeOrganizationalFunctionsResponse> DescribeOrganizationalFunctions(DescribeOrganizationalFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationalFunctionsResponse>(req, "DescribeOrganizationalFunctions");
        }

        /// <summary>
        /// 查询全量函数
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationalFunctionsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationalFunctionsResponse"/></returns>
        public DescribeOrganizationalFunctionsResponse DescribeOrganizationalFunctionsSync(DescribeOrganizationalFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationalFunctionsResponse>(req, "DescribeOrganizationalFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取待提交任务预提交校验信息（注意：工作流编号或者任务编号列表，必须填一项）
        /// </summary>
        /// <param name="req"><see cref="DescribePendingSubmitTaskListRequest"/></param>
        /// <returns><see cref="DescribePendingSubmitTaskListResponse"/></returns>
        public Task<DescribePendingSubmitTaskListResponse> DescribePendingSubmitTaskList(DescribePendingSubmitTaskListRequest req)
        {
            return InternalRequestAsync<DescribePendingSubmitTaskListResponse>(req, "DescribePendingSubmitTaskList");
        }

        /// <summary>
        /// 获取待提交任务预提交校验信息（注意：工作流编号或者任务编号列表，必须填一项）
        /// </summary>
        /// <param name="req"><see cref="DescribePendingSubmitTaskListRequest"/></param>
        /// <returns><see cref="DescribePendingSubmitTaskListResponse"/></returns>
        public DescribePendingSubmitTaskListResponse DescribePendingSubmitTaskListSync(DescribePendingSubmitTaskListRequest req)
        {
            return InternalRequestAsync<DescribePendingSubmitTaskListResponse>(req, "DescribePendingSubmitTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject");
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
            return InternalRequestAsync<DescribeProjectResponse>(req, "DescribeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的用户，分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectUsersRequest"/></param>
        /// <returns><see cref="DescribeProjectUsersResponse"/></returns>
        public Task<DescribeProjectUsersResponse> DescribeProjectUsers(DescribeProjectUsersRequest req)
        {
            return InternalRequestAsync<DescribeProjectUsersResponse>(req, "DescribeProjectUsers");
        }

        /// <summary>
        /// 获取项目下的用户，分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectUsersRequest"/></param>
        /// <returns><see cref="DescribeProjectUsersResponse"/></returns>
        public DescribeProjectUsersResponse DescribeProjectUsersSync(DescribeProjectUsersRequest req)
        {
            return InternalRequestAsync<DescribeProjectUsersResponse>(req, "DescribeProjectUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 质量报告-质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public Task<DescribeQualityScoreResponse> DescribeQualityScore(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore");
        }

        /// <summary>
        /// 质量报告-质量评分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public DescribeQualityScoreResponse DescribeQualityScoreSync(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 质量报告-质量分周期趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public Task<DescribeQualityScoreTrendResponse> DescribeQualityScoreTrend(DescribeQualityScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreTrendResponse>(req, "DescribeQualityScoreTrend");
        }

        /// <summary>
        /// 质量报告-质量分周期趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreTrendResponse"/></returns>
        public DescribeQualityScoreTrendResponse DescribeQualityScoreTrendSync(DescribeQualityScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreTrendResponse>(req, "DescribeQualityScoreTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实时任务实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public Task<DescribeRealTimeTaskInstanceNodeInfoResponse> DescribeRealTimeTaskInstanceNodeInfo(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskInstanceNodeInfoResponse>(req, "DescribeRealTimeTaskInstanceNodeInfo");
        }

        /// <summary>
        /// 查询实时任务实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskInstanceNodeInfoResponse"/></returns>
        public DescribeRealTimeTaskInstanceNodeInfoResponse DescribeRealTimeTaskInstanceNodeInfoSync(DescribeRealTimeTaskInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskInstanceNodeInfoResponse>(req, "DescribeRealTimeTaskInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实时任务运行指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public Task<DescribeRealTimeTaskMetricOverviewResponse> DescribeRealTimeTaskMetricOverview(DescribeRealTimeTaskMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskMetricOverviewResponse>(req, "DescribeRealTimeTaskMetricOverview");
        }

        /// <summary>
        /// 实时任务运行指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskMetricOverviewResponse"/></returns>
        public DescribeRealTimeTaskMetricOverviewResponse DescribeRealTimeTaskMetricOverviewSync(DescribeRealTimeTaskMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskMetricOverviewResponse>(req, "DescribeRealTimeTaskMetricOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实时任务同步速度趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public Task<DescribeRealTimeTaskSpeedResponse> DescribeRealTimeTaskSpeed(DescribeRealTimeTaskSpeedRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskSpeedResponse>(req, "DescribeRealTimeTaskSpeed");
        }

        /// <summary>
        /// 实时任务同步速度趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRealTimeTaskSpeedRequest"/></param>
        /// <returns><see cref="DescribeRealTimeTaskSpeedResponse"/></returns>
        public DescribeRealTimeTaskSpeedResponse DescribeRealTimeTaskSpeedSync(DescribeRealTimeTaskSpeedRequest req)
        {
            return InternalRequestAsync<DescribeRealTimeTaskSpeedResponse>(req, "DescribeRealTimeTaskSpeed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询上报任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDetailResponse"/></returns>
        public Task<DescribeReportTaskDetailResponse> DescribeReportTaskDetail(DescribeReportTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskDetailResponse>(req, "DescribeReportTaskDetail");
        }

        /// <summary>
        /// 查询上报任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDetailResponse"/></returns>
        public DescribeReportTaskDetailResponse DescribeReportTaskDetailSync(DescribeReportTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskDetailResponse>(req, "DescribeReportTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询上报任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskListRequest"/></param>
        /// <returns><see cref="DescribeReportTaskListResponse"/></returns>
        public Task<DescribeReportTaskListResponse> DescribeReportTaskList(DescribeReportTaskListRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskListResponse>(req, "DescribeReportTaskList");
        }

        /// <summary>
        /// 查询上报任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskListRequest"/></param>
        /// <returns><see cref="DescribeReportTaskListResponse"/></returns>
        public DescribeReportTaskListResponse DescribeReportTaskListSync(DescribeReportTaskListRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskListResponse>(req, "DescribeReportTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源管理目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public Task<DescribeResourceManagePathTreesResponse> DescribeResourceManagePathTrees(DescribeResourceManagePathTreesRequest req)
        {
            return InternalRequestAsync<DescribeResourceManagePathTreesResponse>(req, "DescribeResourceManagePathTrees");
        }

        /// <summary>
        /// 获取资源管理目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceManagePathTreesRequest"/></param>
        /// <returns><see cref="DescribeResourceManagePathTreesResponse"/></returns>
        public DescribeResourceManagePathTreesResponse DescribeResourceManagePathTreesSync(DescribeResourceManagePathTreesRequest req)
        {
            return InternalRequestAsync<DescribeResourceManagePathTreesResponse>(req, "DescribeResourceManagePathTrees")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule");
        }

        /// <summary>
        /// 查询规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量概览页面触发维度分布统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public Task<DescribeRuleDimStatResponse> DescribeRuleDimStat(DescribeRuleDimStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleDimStatResponse>(req, "DescribeRuleDimStat");
        }

        /// <summary>
        /// 数据质量概览页面触发维度分布统计接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDimStatRequest"/></param>
        /// <returns><see cref="DescribeRuleDimStatResponse"/></returns>
        public DescribeRuleDimStatResponse DescribeRuleDimStatSync(DescribeRuleDimStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleDimStatResponse>(req, "DescribeRuleDimStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则执行结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public Task<DescribeRuleExecDetailResponse> DescribeRuleExecDetail(DescribeRuleExecDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecDetailResponse>(req, "DescribeRuleExecDetail");
        }

        /// <summary>
        /// 查询规则执行结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleExecDetailResponse"/></returns>
        public DescribeRuleExecDetailResponse DescribeRuleExecDetailSync(DescribeRuleExecDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecDetailResponse>(req, "DescribeRuleExecDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 规则执行日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public Task<DescribeRuleExecLogResponse> DescribeRuleExecLog(DescribeRuleExecLogRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecLogResponse>(req, "DescribeRuleExecLog");
        }

        /// <summary>
        /// 规则执行日志查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecLogRequest"/></param>
        /// <returns><see cref="DescribeRuleExecLogResponse"/></returns>
        public DescribeRuleExecLogResponse DescribeRuleExecLogSync(DescribeRuleExecLogRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecLogResponse>(req, "DescribeRuleExecLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 规则执行结果列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public Task<DescribeRuleExecResultsResponse> DescribeRuleExecResults(DescribeRuleExecResultsRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsResponse>(req, "DescribeRuleExecResults");
        }

        /// <summary>
        /// 规则执行结果列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsResponse"/></returns>
        public DescribeRuleExecResultsResponse DescribeRuleExecResultsSync(DescribeRuleExecResultsRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsResponse>(req, "DescribeRuleExecResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量概览页面规则运行情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public Task<DescribeRuleExecStatResponse> DescribeRuleExecStat(DescribeRuleExecStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecStatResponse>(req, "DescribeRuleExecStat");
        }

        /// <summary>
        /// 数据质量概览页面规则运行情况接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecStatRequest"/></param>
        /// <returns><see cref="DescribeRuleExecStatResponse"/></returns>
        public DescribeRuleExecStatResponse DescribeRuleExecStatSync(DescribeRuleExecStatRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecStatResponse>(req, "DescribeRuleExecStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则组详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public Task<DescribeRuleGroupResponse> DescribeRuleGroup(DescribeRuleGroupRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupResponse>(req, "DescribeRuleGroup");
        }

        /// <summary>
        /// 查询规则组详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupResponse"/></returns>
        public DescribeRuleGroupResponse DescribeRuleGroupSync(DescribeRuleGroupRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupResponse>(req, "DescribeRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 规则组执行结果分页查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public Task<DescribeRuleGroupExecResultsByPageResponse> DescribeRuleGroupExecResultsByPage(DescribeRuleGroupExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageResponse>(req, "DescribeRuleGroupExecResultsByPage");
        }

        /// <summary>
        /// 规则组执行结果分页查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageResponse"/></returns>
        public DescribeRuleGroupExecResultsByPageResponse DescribeRuleGroupExecResultsByPageSync(DescribeRuleGroupExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageResponse>(req, "DescribeRuleGroupExecResultsByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public Task<DescribeRuleGroupSubscriptionResponse> DescribeRuleGroupSubscription(DescribeRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupSubscriptionResponse>(req, "DescribeRuleGroupSubscription");
        }

        /// <summary>
        /// 查询规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupSubscriptionResponse"/></returns>
        public DescribeRuleGroupSubscriptionResponse DescribeRuleGroupSubscriptionSync(DescribeRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupSubscriptionResponse>(req, "DescribeRuleGroupSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表绑定执行规则组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public Task<DescribeRuleGroupTableResponse> DescribeRuleGroupTable(DescribeRuleGroupTableRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupTableResponse>(req, "DescribeRuleGroupTable");
        }

        /// <summary>
        /// 查询表绑定执行规则组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupTableRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupTableResponse"/></returns>
        public DescribeRuleGroupTableResponse DescribeRuleGroupTableSync(DescribeRuleGroupTableRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupTableResponse>(req, "DescribeRuleGroupTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 【过滤条件】
        /// {表名称TableName,支持模糊匹配}       {表负责人TableOwnerName,支持模糊匹配}      {监控方式MonitorTypes，1.未配置 2.关联生产调度 3.离线周期检测,支持多选}  {订阅人ReceiverUin}
        /// 【必要字段】
        /// {数据来源DatasourceId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public Task<DescribeRuleGroupsByPageResponse> DescribeRuleGroupsByPage(DescribeRuleGroupsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupsByPageResponse>(req, "DescribeRuleGroupsByPage");
        }

        /// <summary>
        /// 【过滤条件】
        /// {表名称TableName,支持模糊匹配}       {表负责人TableOwnerName,支持模糊匹配}      {监控方式MonitorTypes，1.未配置 2.关联生产调度 3.离线周期检测,支持多选}  {订阅人ReceiverUin}
        /// 【必要字段】
        /// {数据来源DatasourceId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupsByPageResponse"/></returns>
        public DescribeRuleGroupsByPageResponse DescribeRuleGroupsByPageSync(DescribeRuleGroupsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupsByPageResponse>(req, "DescribeRuleGroupsByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public Task<DescribeRuleTemplateResponse> DescribeRuleTemplate(DescribeRuleTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplateResponse>(req, "DescribeRuleTemplate");
        }

        /// <summary>
        /// 查询模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplateRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplateResponse"/></returns>
        public DescribeRuleTemplateResponse DescribeRuleTemplateSync(DescribeRuleTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplateResponse>(req, "DescribeRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public Task<DescribeRuleTemplatesResponse> DescribeRuleTemplates(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates");
        }

        /// <summary>
        /// 查询规则模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public DescribeRuleTemplatesResponse DescribeRuleTemplatesSync(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 【过滤条件】 {模板名称Name,支持模糊匹配} {模板类型type，1.系统模板 2.自定义模板} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public Task<DescribeRuleTemplatesByPageResponse> DescribeRuleTemplatesByPage(DescribeRuleTemplatesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesByPageResponse>(req, "DescribeRuleTemplatesByPage");
        }

        /// <summary>
        /// 【过滤条件】 {模板名称Name,支持模糊匹配} {模板类型type，1.系统模板 2.自定义模板} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public DescribeRuleTemplatesByPageResponse DescribeRuleTemplatesByPageSync(DescribeRuleTemplatesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesByPageResponse>(req, "DescribeRuleTemplatesByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询质量规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 查询质量规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询质量规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public Task<DescribeRulesByPageResponse> DescribeRulesByPage(DescribeRulesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRulesByPageResponse>(req, "DescribeRulesByPage");
        }

        /// <summary>
        /// 分页查询质量规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByPageRequest"/></param>
        /// <returns><see cref="DescribeRulesByPageResponse"/></returns>
        public DescribeRulesByPageResponse DescribeRulesByPageSync(DescribeRulesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRulesByPageResponse>(req, "DescribeRulesByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstancesRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstancesResponse"/></returns>
        public Task<DescribeScheduleInstancesResponse> DescribeScheduleInstances(DescribeScheduleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstancesResponse>(req, "DescribeScheduleInstances");
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstancesRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstancesResponse"/></returns>
        public DescribeScheduleInstancesResponse DescribeScheduleInstancesSync(DescribeScheduleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstancesResponse>(req, "DescribeScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运维大屏-实例状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerInstanceStatusResponse"/></returns>
        public Task<DescribeSchedulerInstanceStatusResponse> DescribeSchedulerInstanceStatus(DescribeSchedulerInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerInstanceStatusResponse>(req, "DescribeSchedulerInstanceStatus");
        }

        /// <summary>
        /// 运维大屏-实例状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerInstanceStatusResponse"/></returns>
        public DescribeSchedulerInstanceStatusResponse DescribeSchedulerInstanceStatusSync(DescribeSchedulerInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerInstanceStatusResponse>(req, "DescribeSchedulerInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运维大屏-实例运行时长排行
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerRunTimeInstanceCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerRunTimeInstanceCntByStatusResponse"/></returns>
        public Task<DescribeSchedulerRunTimeInstanceCntByStatusResponse> DescribeSchedulerRunTimeInstanceCntByStatus(DescribeSchedulerRunTimeInstanceCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerRunTimeInstanceCntByStatusResponse>(req, "DescribeSchedulerRunTimeInstanceCntByStatus");
        }

        /// <summary>
        /// 运维大屏-实例运行时长排行
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerRunTimeInstanceCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerRunTimeInstanceCntByStatusResponse"/></returns>
        public DescribeSchedulerRunTimeInstanceCntByStatusResponse DescribeSchedulerRunTimeInstanceCntByStatusSync(DescribeSchedulerRunTimeInstanceCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerRunTimeInstanceCntByStatusResponse>(req, "DescribeSchedulerRunTimeInstanceCntByStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskCntByStatusResponse"/></returns>
        public Task<DescribeSchedulerTaskCntByStatusResponse> DescribeSchedulerTaskCntByStatus(DescribeSchedulerTaskCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskCntByStatusResponse>(req, "DescribeSchedulerTaskCntByStatus");
        }

        /// <summary>
        /// 任务状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskCntByStatusRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskCntByStatusResponse"/></returns>
        public DescribeSchedulerTaskCntByStatusResponse DescribeSchedulerTaskCntByStatusSync(DescribeSchedulerTaskCntByStatusRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskCntByStatusResponse>(req, "DescribeSchedulerTaskCntByStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运维大屏-任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskTypeCntRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskTypeCntResponse"/></returns>
        public Task<DescribeSchedulerTaskTypeCntResponse> DescribeSchedulerTaskTypeCnt(DescribeSchedulerTaskTypeCntRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskTypeCntResponse>(req, "DescribeSchedulerTaskTypeCnt");
        }

        /// <summary>
        /// 运维大屏-任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulerTaskTypeCntRequest"/></param>
        /// <returns><see cref="DescribeSchedulerTaskTypeCntResponse"/></returns>
        public DescribeSchedulerTaskTypeCntResponse DescribeSchedulerTaskTypeCntSync(DescribeSchedulerTaskTypeCntRequest req)
        {
            return InternalRequestAsync<DescribeSchedulerTaskTypeCntResponse>(req, "DescribeSchedulerTaskTypeCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务状态趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticInstanceStatusTrendOpsRequest"/></param>
        /// <returns><see cref="DescribeStatisticInstanceStatusTrendOpsResponse"/></returns>
        public Task<DescribeStatisticInstanceStatusTrendOpsResponse> DescribeStatisticInstanceStatusTrendOps(DescribeStatisticInstanceStatusTrendOpsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticInstanceStatusTrendOpsResponse>(req, "DescribeStatisticInstanceStatusTrendOps");
        }

        /// <summary>
        /// 任务状态趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticInstanceStatusTrendOpsRequest"/></param>
        /// <returns><see cref="DescribeStatisticInstanceStatusTrendOpsResponse"/></returns>
        public DescribeStatisticInstanceStatusTrendOpsResponse DescribeStatisticInstanceStatusTrendOpsSync(DescribeStatisticInstanceStatusTrendOpsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticInstanceStatusTrendOpsResponse>(req, "DescribeStatisticInstanceStatusTrendOps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实时任务日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public Task<DescribeStreamTaskLogListResponse> DescribeStreamTaskLogList(DescribeStreamTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeStreamTaskLogListResponse>(req, "DescribeStreamTaskLogList");
        }

        /// <summary>
        /// 查询实时任务日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeStreamTaskLogListResponse"/></returns>
        public DescribeStreamTaskLogListResponse DescribeStreamTaskLogListSync(DescribeStreamTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeStreamTaskLogListResponse>(req, "DescribeStreamTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取下游任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSuccessorOpsTaskInfosRequest"/></param>
        /// <returns><see cref="DescribeSuccessorOpsTaskInfosResponse"/></returns>
        public Task<DescribeSuccessorOpsTaskInfosResponse> DescribeSuccessorOpsTaskInfos(DescribeSuccessorOpsTaskInfosRequest req)
        {
            return InternalRequestAsync<DescribeSuccessorOpsTaskInfosResponse>(req, "DescribeSuccessorOpsTaskInfos");
        }

        /// <summary>
        /// 获取下游任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSuccessorOpsTaskInfosRequest"/></param>
        /// <returns><see cref="DescribeSuccessorOpsTaskInfosResponse"/></returns>
        public DescribeSuccessorOpsTaskInfosResponse DescribeSuccessorOpsTaskInfosSync(DescribeSuccessorOpsTaskInfosRequest req)
        {
            return InternalRequestAsync<DescribeSuccessorOpsTaskInfosResponse>(req, "DescribeSuccessorOpsTaskInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 元数据模型-表基础信息查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTableBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeTableBasicInfoResponse"/></returns>
        public Task<DescribeTableBasicInfoResponse> DescribeTableBasicInfo(DescribeTableBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableBasicInfoResponse>(req, "DescribeTableBasicInfo");
        }

        /// <summary>
        /// 元数据模型-表基础信息查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTableBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeTableBasicInfoResponse"/></returns>
        public DescribeTableBasicInfoResponse DescribeTableBasicInfoSync(DescribeTableBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableBasicInfoResponse>(req, "DescribeTableBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public Task<DescribeTableInfoListResponse> DescribeTableInfoList(DescribeTableInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTableInfoListResponse>(req, "DescribeTableInfoList");
        }

        /// <summary>
        /// 获取数据表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableInfoListRequest"/></param>
        /// <returns><see cref="DescribeTableInfoListResponse"/></returns>
        public DescribeTableInfoListResponse DescribeTableInfoListSync(DescribeTableInfoListRequest req)
        {
            return InternalRequestAsync<DescribeTableInfoListResponse>(req, "DescribeTableInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出表血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageRequest"/></param>
        /// <returns><see cref="DescribeTableLineageResponse"/></returns>
        public Task<DescribeTableLineageResponse> DescribeTableLineage(DescribeTableLineageRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageResponse>(req, "DescribeTableLineage");
        }

        /// <summary>
        /// 列出表血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageRequest"/></param>
        /// <returns><see cref="DescribeTableLineageResponse"/></returns>
        public DescribeTableLineageResponse DescribeTableLineageSync(DescribeTableLineageRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageResponse>(req, "DescribeTableLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出表血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageInfoRequest"/></param>
        /// <returns><see cref="DescribeTableLineageInfoResponse"/></returns>
        public Task<DescribeTableLineageInfoResponse> DescribeTableLineageInfo(DescribeTableLineageInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageInfoResponse>(req, "DescribeTableLineageInfo");
        }

        /// <summary>
        /// 列出表血缘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableLineageInfoRequest"/></param>
        /// <returns><see cref="DescribeTableLineageInfoResponse"/></returns>
        public DescribeTableLineageInfoResponse DescribeTableLineageInfoSync(DescribeTableLineageInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableLineageInfoResponse>(req, "DescribeTableLineageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表元数据详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetaRequest"/></param>
        /// <returns><see cref="DescribeTableMetaResponse"/></returns>
        public Task<DescribeTableMetaResponse> DescribeTableMeta(DescribeTableMetaRequest req)
        {
            return InternalRequestAsync<DescribeTableMetaResponse>(req, "DescribeTableMeta");
        }

        /// <summary>
        /// 查询表元数据详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetaRequest"/></param>
        /// <returns><see cref="DescribeTableMetaResponse"/></returns>
        public DescribeTableMetaResponse DescribeTableMetaSync(DescribeTableMetaRequest req)
        {
            return InternalRequestAsync<DescribeTableMetaResponse>(req, "DescribeTableMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表元数据list
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetasRequest"/></param>
        /// <returns><see cref="DescribeTableMetasResponse"/></returns>
        public Task<DescribeTableMetasResponse> DescribeTableMetas(DescribeTableMetasRequest req)
        {
            return InternalRequestAsync<DescribeTableMetasResponse>(req, "DescribeTableMetas");
        }

        /// <summary>
        /// 获取表元数据list
        /// </summary>
        /// <param name="req"><see cref="DescribeTableMetasRequest"/></param>
        /// <returns><see cref="DescribeTableMetasResponse"/></returns>
        public DescribeTableMetasResponse DescribeTableMetasSync(DescribeTableMetasRequest req)
        {
            return InternalRequestAsync<DescribeTableMetasResponse>(req, "DescribeTableMetas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表的分区详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTablePartitionsRequest"/></param>
        /// <returns><see cref="DescribeTablePartitionsResponse"/></returns>
        public Task<DescribeTablePartitionsResponse> DescribeTablePartitions(DescribeTablePartitionsRequest req)
        {
            return InternalRequestAsync<DescribeTablePartitionsResponse>(req, "DescribeTablePartitions");
        }

        /// <summary>
        /// 查询表的分区详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTablePartitionsRequest"/></param>
        /// <returns><see cref="DescribeTablePartitionsResponse"/></returns>
        public DescribeTablePartitionsResponse DescribeTablePartitionsSync(DescribeTablePartitionsRequest req)
        {
            return InternalRequestAsync<DescribeTablePartitionsResponse>(req, "DescribeTablePartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 质量报告-查询表质量详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public Task<DescribeTableQualityDetailsResponse> DescribeTableQualityDetails(DescribeTableQualityDetailsRequest req)
        {
            return InternalRequestAsync<DescribeTableQualityDetailsResponse>(req, "DescribeTableQualityDetails");
        }

        /// <summary>
        /// 质量报告-查询表质量详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTableQualityDetailsRequest"/></param>
        /// <returns><see cref="DescribeTableQualityDetailsResponse"/></returns>
        public DescribeTableQualityDetailsResponse DescribeTableQualityDetailsSync(DescribeTableQualityDetailsRequest req)
        {
            return InternalRequestAsync<DescribeTableQualityDetailsResponse>(req, "DescribeTableQualityDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表schema信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public Task<DescribeTableSchemaInfoResponse> DescribeTableSchemaInfo(DescribeTableSchemaInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableSchemaInfoResponse>(req, "DescribeTableSchemaInfo");
        }

        /// <summary>
        /// 获取表schema信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTableSchemaInfoRequest"/></param>
        /// <returns><see cref="DescribeTableSchemaInfoResponse"/></returns>
        public DescribeTableSchemaInfoResponse DescribeTableSchemaInfoSync(DescribeTableSchemaInfoRequest req)
        {
            return InternalRequestAsync<DescribeTableSchemaInfoResponse>(req, "DescribeTableSchemaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表得分趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public Task<DescribeTableScoreTrendResponse> DescribeTableScoreTrend(DescribeTableScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeTableScoreTrendResponse>(req, "DescribeTableScoreTrend");
        }

        /// <summary>
        /// 查询表得分趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTableScoreTrendRequest"/></param>
        /// <returns><see cref="DescribeTableScoreTrendResponse"/></returns>
        public DescribeTableScoreTrendResponse DescribeTableScoreTrendSync(DescribeTableScoreTrendRequest req)
        {
            return InternalRequestAsync<DescribeTableScoreTrendResponse>(req, "DescribeTableScoreTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public Task<DescribeTaskAlarmRegulationsResponse> DescribeTaskAlarmRegulations(DescribeTaskAlarmRegulationsRequest req)
        {
            return InternalRequestAsync<DescribeTaskAlarmRegulationsResponse>(req, "DescribeTaskAlarmRegulations");
        }

        /// <summary>
        /// 查询任务告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskAlarmRegulationsRequest"/></param>
        /// <returns><see cref="DescribeTaskAlarmRegulationsResponse"/></returns>
        public DescribeTaskAlarmRegulationsResponse DescribeTaskAlarmRegulationsSync(DescribeTaskAlarmRegulationsRequest req)
        {
            return InternalRequestAsync<DescribeTaskAlarmRegulationsResponse>(req, "DescribeTaskAlarmRegulations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据周期类型 查询所有任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleResponse"/></returns>
        public Task<DescribeTaskByCycleResponse> DescribeTaskByCycle(DescribeTaskByCycleRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleResponse>(req, "DescribeTaskByCycle");
        }

        /// <summary>
        /// 根据周期类型 查询所有任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleResponse"/></returns>
        public DescribeTaskByCycleResponse DescribeTaskByCycleSync(DescribeTaskByCycleRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleResponse>(req, "DescribeTaskByCycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 能够调通但该API已经没有使用了，看北京数据最后一次上报是23年10月，有接近一千万条数据历史无效数据。当前策略，云API示例修订然后已经分析出来的无效API走预下线流程。
        /// https://capi.woa.com/api/detail?product=wedata&env=api_formal&version=2021-08-20&action=DescribeTaskByCycleReport
        /// 这两天在分析API的时候 有较多运维大屏的原始API当前已经没有使用了，但API没有下线。预计需要专项去梳理这一系列待下线API。
        /// 
        /// 任务状态周期增长趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleReportResponse"/></returns>
        public Task<DescribeTaskByCycleReportResponse> DescribeTaskByCycleReport(DescribeTaskByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleReportResponse>(req, "DescribeTaskByCycleReport");
        }

        /// <summary>
        /// 能够调通但该API已经没有使用了，看北京数据最后一次上报是23年10月，有接近一千万条数据历史无效数据。当前策略，云API示例修订然后已经分析出来的无效API走预下线流程。
        /// https://capi.woa.com/api/detail?product=wedata&env=api_formal&version=2021-08-20&action=DescribeTaskByCycleReport
        /// 这两天在分析API的时候 有较多运维大屏的原始API当前已经没有使用了，但API没有下线。预计需要专项去梳理这一系列待下线API。
        /// 
        /// 任务状态周期增长趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleReportResponse"/></returns>
        public DescribeTaskByCycleReportResponse DescribeTaskByCycleReportSync(DescribeTaskByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleReportResponse>(req, "DescribeTaskByCycleReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务状态趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByStatusReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByStatusReportResponse"/></returns>
        public Task<DescribeTaskByStatusReportResponse> DescribeTaskByStatusReport(DescribeTaskByStatusReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByStatusReportResponse>(req, "DescribeTaskByStatusReport");
        }

        /// <summary>
        /// 任务状态趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByStatusReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByStatusReportResponse"/></returns>
        public DescribeTaskByStatusReportResponse DescribeTaskByStatusReportSync(DescribeTaskByStatusReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByStatusReportResponse>(req, "DescribeTaskByStatusReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过任务查询表的血缘关系
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLineageRequest"/></param>
        /// <returns><see cref="DescribeTaskLineageResponse"/></returns>
        public Task<DescribeTaskLineageResponse> DescribeTaskLineage(DescribeTaskLineageRequest req)
        {
            return InternalRequestAsync<DescribeTaskLineageResponse>(req, "DescribeTaskLineage");
        }

        /// <summary>
        /// 通过任务查询表的血缘关系
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLineageRequest"/></param>
        /// <returns><see cref="DescribeTaskLineageResponse"/></returns>
        public DescribeTaskLineageResponse DescribeTaskLineageSync(DescribeTaskLineageRequest req)
        {
            return InternalRequestAsync<DescribeTaskLineageResponse>(req, "DescribeTaskLineage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看任务锁状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public Task<DescribeTaskLockStatusResponse> DescribeTaskLockStatus(DescribeTaskLockStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLockStatusResponse>(req, "DescribeTaskLockStatus");
        }

        /// <summary>
        /// 查看任务锁状态信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLockStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskLockStatusResponse"/></returns>
        public DescribeTaskLockStatusResponse DescribeTaskLockStatusSync(DescribeTaskLockStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskLockStatusResponse>(req, "DescribeTaskLockStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询任务运行历史
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRunHistoryRequest"/></param>
        /// <returns><see cref="DescribeTaskRunHistoryResponse"/></returns>
        public Task<DescribeTaskRunHistoryResponse> DescribeTaskRunHistory(DescribeTaskRunHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTaskRunHistoryResponse>(req, "DescribeTaskRunHistory");
        }

        /// <summary>
        /// 分页查询任务运行历史
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRunHistoryRequest"/></param>
        /// <returns><see cref="DescribeTaskRunHistoryResponse"/></returns>
        public DescribeTaskRunHistoryResponse DescribeTaskRunHistorySync(DescribeTaskRunHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTaskRunHistoryResponse>(req, "DescribeTaskRunHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public Task<DescribeTaskScriptResponse> DescribeTaskScript(DescribeTaskScriptRequest req)
        {
            return InternalRequestAsync<DescribeTaskScriptResponse>(req, "DescribeTaskScript");
        }

        /// <summary>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public DescribeTaskScriptResponse DescribeTaskScriptSync(DescribeTaskScriptRequest req)
        {
            return InternalRequestAsync<DescribeTaskScriptResponse>(req, "DescribeTaskScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实时任务表粒度指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTableMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeTaskTableMetricOverviewResponse"/></returns>
        public Task<DescribeTaskTableMetricOverviewResponse> DescribeTaskTableMetricOverview(DescribeTaskTableMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTaskTableMetricOverviewResponse>(req, "DescribeTaskTableMetricOverview");
        }

        /// <summary>
        /// 查询实时任务表粒度指标概览
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTableMetricOverviewRequest"/></param>
        /// <returns><see cref="DescribeTaskTableMetricOverviewResponse"/></returns>
        public DescribeTaskTableMetricOverviewResponse DescribeTaskTableMetricOverviewSync(DescribeTaskTableMetricOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTaskTableMetricOverviewResponse>(req, "DescribeTaskTableMetricOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则模板维度分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public Task<DescribeTemplateDimCountResponse> DescribeTemplateDimCount(DescribeTemplateDimCountRequest req)
        {
            return InternalRequestAsync<DescribeTemplateDimCountResponse>(req, "DescribeTemplateDimCount");
        }

        /// <summary>
        /// 查询规则模板维度分布情况
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateDimCountRequest"/></param>
        /// <returns><see cref="DescribeTemplateDimCountResponse"/></returns>
        public DescribeTemplateDimCountResponse DescribeTemplateDimCountSync(DescribeTemplateDimCountRequest req)
        {
            return InternalRequestAsync<DescribeTemplateDimCountResponse>(req, "DescribeTemplateDimCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取第三方运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdTaskRunLogRequest"/></param>
        /// <returns><see cref="DescribeThirdTaskRunLogResponse"/></returns>
        public Task<DescribeThirdTaskRunLogResponse> DescribeThirdTaskRunLog(DescribeThirdTaskRunLogRequest req)
        {
            return InternalRequestAsync<DescribeThirdTaskRunLogResponse>(req, "DescribeThirdTaskRunLog");
        }

        /// <summary>
        /// 获取第三方运行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdTaskRunLogRequest"/></param>
        /// <returns><see cref="DescribeThirdTaskRunLogResponse"/></returns>
        public DescribeThirdTaskRunLogResponse DescribeThirdTaskRunLogSync(DescribeThirdTaskRunLogRequest req)
        {
            return InternalRequestAsync<DescribeThirdTaskRunLogResponse>(req, "DescribeThirdTaskRunLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量概览页面表排行接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public Task<DescribeTopTableStatResponse> DescribeTopTableStat(DescribeTopTableStatRequest req)
        {
            return InternalRequestAsync<DescribeTopTableStatResponse>(req, "DescribeTopTableStat");
        }

        /// <summary>
        /// 数据质量概览页面表排行接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTopTableStatRequest"/></param>
        /// <returns><see cref="DescribeTopTableStatResponse"/></returns>
        public DescribeTopTableStatResponse DescribeTopTableStatSync(DescribeTopTableStatRequest req)
        {
            return InternalRequestAsync<DescribeTopTableStatResponse>(req, "DescribeTopTableStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量概览页面趋势变化接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public Task<DescribeTrendStatResponse> DescribeTrendStat(DescribeTrendStatRequest req)
        {
            return InternalRequestAsync<DescribeTrendStatResponse>(req, "DescribeTrendStat");
        }

        /// <summary>
        /// 数据质量概览页面趋势变化接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTrendStatRequest"/></param>
        /// <returns><see cref="DescribeTrendStatResponse"/></returns>
        public DescribeTrendStatResponse DescribeTrendStatSync(DescribeTrendStatRequest req)
        {
            return InternalRequestAsync<DescribeTrendStatResponse>(req, "DescribeTrendStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流画布
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoResponse"/></returns>
        public Task<DescribeWorkflowCanvasInfoResponse> DescribeWorkflowCanvasInfo(DescribeWorkflowCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoResponse>(req, "DescribeWorkflowCanvasInfo");
        }

        /// <summary>
        /// 查询工作流画布
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoResponse"/></returns>
        public DescribeWorkflowCanvasInfoResponse DescribeWorkflowCanvasInfoSync(DescribeWorkflowCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoResponse>(req, "DescribeWorkflowCanvasInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流画布运行起止时间
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowExecuteByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowExecuteByIdResponse"/></returns>
        public Task<DescribeWorkflowExecuteByIdResponse> DescribeWorkflowExecuteById(DescribeWorkflowExecuteByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowExecuteByIdResponse>(req, "DescribeWorkflowExecuteById");
        }

        /// <summary>
        /// 查询工作流画布运行起止时间
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowExecuteByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowExecuteByIdResponse"/></returns>
        public DescribeWorkflowExecuteByIdResponse DescribeWorkflowExecuteByIdSync(DescribeWorkflowExecuteByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowExecuteByIdResponse>(req, "DescribeWorkflowExecuteById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过工作流id，查询工作流详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowInfoByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowInfoByIdResponse"/></returns>
        public Task<DescribeWorkflowInfoByIdResponse> DescribeWorkflowInfoById(DescribeWorkflowInfoByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowInfoByIdResponse>(req, "DescribeWorkflowInfoById");
        }

        /// <summary>
        /// 通过工作流id，查询工作流详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowInfoByIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowInfoByIdResponse"/></returns>
        public DescribeWorkflowInfoByIdResponse DescribeWorkflowInfoByIdSync(DescribeWorkflowInfoByIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowInfoByIdResponse>(req, "DescribeWorkflowInfoById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据项目id 获取项目下所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowListByProjectIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowListByProjectIdResponse"/></returns>
        public Task<DescribeWorkflowListByProjectIdResponse> DescribeWorkflowListByProjectId(DescribeWorkflowListByProjectIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowListByProjectIdResponse>(req, "DescribeWorkflowListByProjectId");
        }

        /// <summary>
        /// 根据项目id 获取项目下所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowListByProjectIdRequest"/></param>
        /// <returns><see cref="DescribeWorkflowListByProjectIdResponse"/></returns>
        public DescribeWorkflowListByProjectIdResponse DescribeWorkflowListByProjectIdSync(DescribeWorkflowListByProjectIdRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowListByProjectIdResponse>(req, "DescribeWorkflowListByProjectId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流调度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowSchedulerInfoDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowSchedulerInfoDsResponse"/></returns>
        public Task<DescribeWorkflowSchedulerInfoDsResponse> DescribeWorkflowSchedulerInfoDs(DescribeWorkflowSchedulerInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowSchedulerInfoDsResponse>(req, "DescribeWorkflowSchedulerInfoDs");
        }

        /// <summary>
        /// 获取工作流调度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowSchedulerInfoDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowSchedulerInfoDsResponse"/></returns>
        public DescribeWorkflowSchedulerInfoDsResponse DescribeWorkflowSchedulerInfoDsSync(DescribeWorkflowSchedulerInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowSchedulerInfoDsResponse>(req, "DescribeWorkflowSchedulerInfoDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流任务数
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTaskCountRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTaskCountResponse"/></returns>
        public Task<DescribeWorkflowTaskCountResponse> DescribeWorkflowTaskCount(DescribeWorkflowTaskCountRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTaskCountResponse>(req, "DescribeWorkflowTaskCount");
        }

        /// <summary>
        /// 查询工作流任务数
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTaskCountRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTaskCountResponse"/></returns>
        public DescribeWorkflowTaskCountResponse DescribeWorkflowTaskCountSync(DescribeWorkflowTaskCountRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTaskCountResponse>(req, "DescribeWorkflowTaskCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例诊断，用于诊断 INITIAL、DEPENDENCE、ALLOCATED、LAUNCHED、EVENT_LISTENING、BEFORE_ASPECT、EXPIRED、FAILED状态的实例
        /// </summary>
        /// <param name="req"><see cref="DiagnoseProRequest"/></param>
        /// <returns><see cref="DiagnoseProResponse"/></returns>
        public Task<DiagnoseProResponse> DiagnosePro(DiagnoseProRequest req)
        {
            return InternalRequestAsync<DiagnoseProResponse>(req, "DiagnosePro");
        }

        /// <summary>
        /// 实例诊断，用于诊断 INITIAL、DEPENDENCE、ALLOCATED、LAUNCHED、EVENT_LISTENING、BEFORE_ASPECT、EXPIRED、FAILED状态的实例
        /// </summary>
        /// <param name="req"><see cref="DiagnoseProRequest"/></param>
        /// <returns><see cref="DiagnoseProResponse"/></returns>
        public DiagnoseProResponse DiagnoseProSync(DiagnoseProRequest req)
        {
            return InternalRequestAsync<DiagnoseProResponse>(req, "DiagnosePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调试运行集成任务
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public Task<DryRunDIOfflineTaskResponse> DryRunDIOfflineTask(DryRunDIOfflineTaskRequest req)
        {
            return InternalRequestAsync<DryRunDIOfflineTaskResponse>(req, "DryRunDIOfflineTask");
        }

        /// <summary>
        /// 调试运行集成任务
        /// </summary>
        /// <param name="req"><see cref="DryRunDIOfflineTaskRequest"/></param>
        /// <returns><see cref="DryRunDIOfflineTaskResponse"/></returns>
        public DryRunDIOfflineTaskResponse DryRunDIOfflineTaskSync(DryRunDIOfflineTaskRequest req)
        {
            return InternalRequestAsync<DryRunDIOfflineTaskResponse>(req, "DryRunDIOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间批量操作页面查找全部的文件夹
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public Task<FindAllFolderResponse> FindAllFolder(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder");
        }

        /// <summary>
        /// 编排空间批量操作页面查找全部的文件夹
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public FindAllFolderResponse FindAllFolderSync(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维-批量暂停任务
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public Task<FreezeOpsTasksResponse> FreezeOpsTasks(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks");
        }

        /// <summary>
        /// 任务运维-批量暂停任务
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public FreezeOpsTasksResponse FreezeOpsTasksSync(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停工作流下的所有任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByWorkflowIdsRequest"/></param>
        /// <returns><see cref="FreezeTasksByWorkflowIdsResponse"/></returns>
        public Task<FreezeTasksByWorkflowIdsResponse> FreezeTasksByWorkflowIds(FreezeTasksByWorkflowIdsRequest req)
        {
            return InternalRequestAsync<FreezeTasksByWorkflowIdsResponse>(req, "FreezeTasksByWorkflowIds");
        }

        /// <summary>
        /// 暂停工作流下的所有任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByWorkflowIdsRequest"/></param>
        /// <returns><see cref="FreezeTasksByWorkflowIdsResponse"/></returns>
        public FreezeTasksByWorkflowIdsResponse FreezeTasksByWorkflowIdsSync(FreezeTasksByWorkflowIdsRequest req)
        {
            return InternalRequestAsync<FreezeTasksByWorkflowIdsResponse>(req, "FreezeTasksByWorkflowIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成建hive表的sql
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public Task<GenHiveTableDDLSqlResponse> GenHiveTableDDLSql(GenHiveTableDDLSqlRequest req)
        {
            return InternalRequestAsync<GenHiveTableDDLSqlResponse>(req, "GenHiveTableDDLSql");
        }

        /// <summary>
        /// 生成建hive表的sql
        /// </summary>
        /// <param name="req"><see cref="GenHiveTableDDLSqlRequest"/></param>
        /// <returns><see cref="GenHiveTableDDLSqlResponse"/></returns>
        public GenHiveTableDDLSqlResponse GenHiveTableDDLSqlSync(GenHiveTableDDLSqlRequest req)
        {
            return InternalRequestAsync<GenHiveTableDDLSqlResponse>(req, "GenHiveTableDDLSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取cos token
        /// </summary>
        /// <param name="req"><see cref="GetCosTokenRequest"/></param>
        /// <returns><see cref="GetCosTokenResponse"/></returns>
        public Task<GetCosTokenResponse> GetCosToken(GetCosTokenRequest req)
        {
            return InternalRequestAsync<GetCosTokenResponse>(req, "GetCosToken");
        }

        /// <summary>
        /// 获取cos token
        /// </summary>
        /// <param name="req"><see cref="GetCosTokenRequest"/></param>
        /// <returns><see cref="GetCosTokenResponse"/></returns>
        public GetCosTokenResponse GetCosTokenSync(GetCosTokenRequest req)
        {
            return InternalRequestAsync<GetCosTokenResponse>(req, "GetCosToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发空间-获取数据开发脚本信息
        /// </summary>
        /// <param name="req"><see cref="GetFileInfoRequest"/></param>
        /// <returns><see cref="GetFileInfoResponse"/></returns>
        public Task<GetFileInfoResponse> GetFileInfo(GetFileInfoRequest req)
        {
            return InternalRequestAsync<GetFileInfoResponse>(req, "GetFileInfo");
        }

        /// <summary>
        /// 开发空间-获取数据开发脚本信息
        /// </summary>
        /// <param name="req"><see cref="GetFileInfoRequest"/></param>
        /// <returns><see cref="GetFileInfoResponse"/></returns>
        public GetFileInfoResponse GetFileInfoSync(GetFileInfoRequest req)
        {
            return InternalRequestAsync<GetFileInfoResponse>(req, "GetFileInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提取数据集成节点字段Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public Task<GetIntegrationNodeColumnSchemaResponse> GetIntegrationNodeColumnSchema(GetIntegrationNodeColumnSchemaRequest req)
        {
            return InternalRequestAsync<GetIntegrationNodeColumnSchemaResponse>(req, "GetIntegrationNodeColumnSchema");
        }

        /// <summary>
        /// 提取数据集成节点字段Schema
        /// </summary>
        /// <param name="req"><see cref="GetIntegrationNodeColumnSchemaRequest"/></param>
        /// <returns><see cref="GetIntegrationNodeColumnSchemaResponse"/></returns>
        public GetIntegrationNodeColumnSchemaResponse GetIntegrationNodeColumnSchemaSync(GetIntegrationNodeColumnSchemaRequest req)
        {
            return InternalRequestAsync<GetIntegrationNodeColumnSchemaResponse>(req, "GetIntegrationNodeColumnSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取离线任务实例列表(新)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public Task<GetOfflineDIInstanceListResponse> GetOfflineDIInstanceList(GetOfflineDIInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineDIInstanceListResponse>(req, "GetOfflineDIInstanceList");
        }

        /// <summary>
        /// 获取离线任务实例列表(新)
        /// </summary>
        /// <param name="req"><see cref="GetOfflineDIInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineDIInstanceListResponse"/></returns>
        public GetOfflineDIInstanceListResponse GetOfflineDIInstanceListSync(GetOfflineDIInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineDIInstanceListResponse>(req, "GetOfflineDIInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取离线任务实例
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public Task<GetOfflineInstanceListResponse> GetOfflineInstanceList(GetOfflineInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineInstanceListResponse>(req, "GetOfflineInstanceList");
        }

        /// <summary>
        /// 获取离线任务实例
        /// </summary>
        /// <param name="req"><see cref="GetOfflineInstanceListRequest"/></param>
        /// <returns><see cref="GetOfflineInstanceListResponse"/></returns>
        public GetOfflineInstanceListResponse GetOfflineInstanceListSync(GetOfflineInstanceListRequest req)
        {
            return InternalRequestAsync<GetOfflineInstanceListResponse>(req, "GetOfflineInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-判断资源文件是否存在
        /// </summary>
        /// <param name="req"><see cref="JudgeResourceFileRequest"/></param>
        /// <returns><see cref="JudgeResourceFileResponse"/></returns>
        public Task<JudgeResourceFileResponse> JudgeResourceFile(JudgeResourceFileRequest req)
        {
            return InternalRequestAsync<JudgeResourceFileResponse>(req, "JudgeResourceFile");
        }

        /// <summary>
        /// 资源管理-判断资源文件是否存在
        /// </summary>
        /// <param name="req"><see cref="JudgeResourceFileRequest"/></param>
        /// <returns><see cref="JudgeResourceFileResponse"/></returns>
        public JudgeResourceFileResponse JudgeResourceFileSync(JudgeResourceFileRequest req)
        {
            return InternalRequestAsync<JudgeResourceFileResponse>(req, "JudgeResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按补录计划批量终止实例。
        /// </summary>
        /// <param name="req"><see cref="KillOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="KillOpsMakePlanInstancesResponse"/></returns>
        public Task<KillOpsMakePlanInstancesResponse> KillOpsMakePlanInstances(KillOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<KillOpsMakePlanInstancesResponse>(req, "KillOpsMakePlanInstances");
        }

        /// <summary>
        /// 按补录计划批量终止实例。
        /// </summary>
        /// <param name="req"><see cref="KillOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="KillOpsMakePlanInstancesResponse"/></returns>
        public KillOpsMakePlanInstancesResponse KillOpsMakePlanInstancesSync(KillOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<KillOpsMakePlanInstancesResponse>(req, "KillOpsMakePlanInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量终止实例
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public Task<KillScheduleInstancesResponse> KillScheduleInstances(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances");
        }

        /// <summary>
        /// 批量终止实例
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public KillScheduleInstancesResponse KillScheduleInstancesSync(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public Task<LockIntegrationTaskResponse> LockIntegrationTask(LockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<LockIntegrationTaskResponse>(req, "LockIntegrationTask");
        }

        /// <summary>
        /// 锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="LockIntegrationTaskRequest"/></param>
        /// <returns><see cref="LockIntegrationTaskResponse"/></returns>
        public LockIntegrationTaskResponse LockIntegrationTaskSync(LockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<LockIntegrationTaskResponse>(req, "LockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改审批单状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyApproveStatusResponse"/></returns>
        public Task<ModifyApproveStatusResponse> ModifyApproveStatus(ModifyApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyApproveStatusResponse>(req, "ModifyApproveStatus");
        }

        /// <summary>
        /// 修改审批单状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyApproveStatusResponse"/></returns>
        public ModifyApproveStatusResponse ModifyApproveStatusSync(ModifyApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyApproveStatusResponse>(req, "ModifyApproveStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public Task<ModifyDataSourceResponse> ModifyDataSource(ModifyDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyDataSourceResponse>(req, "ModifyDataSource");
        }

        /// <summary>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public ModifyDataSourceResponse ModifyDataSourceSync(ModifyDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyDataSourceResponse>(req, "ModifyDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 质量报告-修改维度权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public Task<ModifyDimensionWeightResponse> ModifyDimensionWeight(ModifyDimensionWeightRequest req)
        {
            return InternalRequestAsync<ModifyDimensionWeightResponse>(req, "ModifyDimensionWeight");
        }

        /// <summary>
        /// 质量报告-修改维度权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDimensionWeightRequest"/></param>
        /// <returns><see cref="ModifyDimensionWeightResponse"/></returns>
        public ModifyDimensionWeightResponse ModifyDimensionWeightSync(ModifyDimensionWeightRequest req)
        {
            return InternalRequestAsync<ModifyDimensionWeightResponse>(req, "ModifyDimensionWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据开发模块-文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyDsFolderRequest"/></param>
        /// <returns><see cref="ModifyDsFolderResponse"/></returns>
        public Task<ModifyDsFolderResponse> ModifyDsFolder(ModifyDsFolderRequest req)
        {
            return InternalRequestAsync<ModifyDsFolderResponse>(req, "ModifyDsFolder");
        }

        /// <summary>
        /// 数据开发模块-文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyDsFolderRequest"/></param>
        /// <returns><see cref="ModifyDsFolderResponse"/></returns>
        public ModifyDsFolderResponse ModifyDsFolderSync(ModifyDsFolderRequest req)
        {
            return InternalRequestAsync<ModifyDsFolderResponse>(req, "ModifyDsFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public Task<ModifyExecStrategyResponse> ModifyExecStrategy(ModifyExecStrategyRequest req)
        {
            return InternalRequestAsync<ModifyExecStrategyResponse>(req, "ModifyExecStrategy");
        }

        /// <summary>
        /// 更新规则组执行策略
        /// </summary>
        /// <param name="req"><see cref="ModifyExecStrategyRequest"/></param>
        /// <returns><see cref="ModifyExecStrategyResponse"/></returns>
        public ModifyExecStrategyResponse ModifyExecStrategySync(ModifyExecStrategyRequest req)
        {
            return InternalRequestAsync<ModifyExecStrategyResponse>(req, "ModifyExecStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新集成节点
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public Task<ModifyIntegrationNodeResponse> ModifyIntegrationNode(ModifyIntegrationNodeRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationNodeResponse>(req, "ModifyIntegrationNode");
        }

        /// <summary>
        /// 更新集成节点
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationNodeRequest"/></param>
        /// <returns><see cref="ModifyIntegrationNodeResponse"/></returns>
        public ModifyIntegrationNodeResponse ModifyIntegrationNodeSync(ModifyIntegrationNodeRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationNodeResponse>(req, "ModifyIntegrationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新集成任务
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public Task<ModifyIntegrationTaskResponse> ModifyIntegrationTask(ModifyIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationTaskResponse>(req, "ModifyIntegrationTask");
        }

        /// <summary>
        /// 更新集成任务
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationTaskRequest"/></param>
        /// <returns><see cref="ModifyIntegrationTaskResponse"/></returns>
        public ModifyIntegrationTaskResponse ModifyIntegrationTaskSync(ModifyIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ModifyIntegrationTaskResponse>(req, "ModifyIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新监控状态
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public Task<ModifyMonitorStatusResponse> ModifyMonitorStatus(ModifyMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyMonitorStatusResponse>(req, "ModifyMonitorStatus");
        }

        /// <summary>
        /// 更新监控状态
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyMonitorStatusResponse"/></returns>
        public ModifyMonitorStatusResponse ModifyMonitorStatusSync(ModifyMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyMonitorStatusResponse>(req, "ModifyMonitorStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新质量规则接口
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// 更新质量规则接口
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public Task<ModifyRuleGroupSubscriptionResponse> ModifyRuleGroupSubscription(ModifyRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupSubscriptionResponse>(req, "ModifyRuleGroupSubscription");
        }

        /// <summary>
        /// 更新规则组订阅信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupSubscriptionRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupSubscriptionResponse"/></returns>
        public ModifyRuleGroupSubscriptionResponse ModifyRuleGroupSubscriptionSync(ModifyRuleGroupSubscriptionRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupSubscriptionResponse>(req, "ModifyRuleGroupSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public Task<ModifyRuleTemplateResponse> ModifyRuleTemplate(ModifyRuleTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRuleTemplateResponse>(req, "ModifyRuleTemplate");
        }

        /// <summary>
        /// 编辑规则模板
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleTemplateRequest"/></param>
        /// <returns><see cref="ModifyRuleTemplateResponse"/></returns>
        public ModifyRuleTemplateResponse ModifyRuleTemplateSync(ModifyRuleTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRuleTemplateResponse>(req, "ModifyRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改任务告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public Task<ModifyTaskAlarmRegularResponse> ModifyTaskAlarmRegular(ModifyTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<ModifyTaskAlarmRegularResponse>(req, "ModifyTaskAlarmRegular");
        }

        /// <summary>
        /// 修改任务告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskAlarmRegularRequest"/></param>
        /// <returns><see cref="ModifyTaskAlarmRegularResponse"/></returns>
        public ModifyTaskAlarmRegularResponse ModifyTaskAlarmRegularSync(ModifyTaskAlarmRegularRequest req)
        {
            return InternalRequestAsync<ModifyTaskAlarmRegularResponse>(req, "ModifyTaskAlarmRegular")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public Task<ModifyTaskInfoResponse> ModifyTaskInfo(ModifyTaskInfoRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoResponse>(req, "ModifyTaskInfo");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public ModifyTaskInfoResponse ModifyTaskInfoSync(ModifyTaskInfoRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoResponse>(req, "ModifyTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public Task<ModifyTaskLinksResponse> ModifyTaskLinks(ModifyTaskLinksRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksResponse>(req, "ModifyTaskLinks");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public ModifyTaskLinksResponse ModifyTaskLinksSync(ModifyTaskLinksRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksResponse>(req, "ModifyTaskLinks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重命名任务（任务编辑）
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public Task<ModifyTaskNameResponse> ModifyTaskName(ModifyTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyTaskNameResponse>(req, "ModifyTaskName");
        }

        /// <summary>
        /// 重命名任务（任务编辑）
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskNameRequest"/></param>
        /// <returns><see cref="ModifyTaskNameResponse"/></returns>
        public ModifyTaskNameResponse ModifyTaskNameSync(ModifyTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyTaskNameResponse>(req, "ModifyTaskName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public Task<ModifyTaskScriptResponse> ModifyTaskScript(ModifyTaskScriptRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptResponse>(req, "ModifyTaskScript");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public ModifyTaskScriptResponse ModifyTaskScriptSync(ModifyTaskScriptRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptResponse>(req, "ModifyTaskScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public Task<ModifyWorkflowInfoResponse> ModifyWorkflowInfo(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo");
        }

        /// <summary>
        /// 更新工作流信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public ModifyWorkflowInfoResponse ModifyWorkflowInfoSync(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public Task<ModifyWorkflowScheduleResponse> ModifyWorkflowSchedule(ModifyWorkflowScheduleRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowScheduleResponse>(req, "ModifyWorkflowSchedule");
        }

        /// <summary>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public ModifyWorkflowScheduleResponse ModifyWorkflowScheduleSync(ModifyWorkflowScheduleRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowScheduleResponse>(req, "ModifyWorkflowSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-工作流-移动任务到工作流文件夹
        /// </summary>
        /// <param name="req"><see cref="MoveTasksToFolderRequest"/></param>
        /// <returns><see cref="MoveTasksToFolderResponse"/></returns>
        public Task<MoveTasksToFolderResponse> MoveTasksToFolder(MoveTasksToFolderRequest req)
        {
            return InternalRequestAsync<MoveTasksToFolderResponse>(req, "MoveTasksToFolder");
        }

        /// <summary>
        /// 编排空间-工作流-移动任务到工作流文件夹
        /// </summary>
        /// <param name="req"><see cref="MoveTasksToFolderRequest"/></param>
        /// <returns><see cref="MoveTasksToFolderResponse"/></returns>
        public MoveTasksToFolderResponse MoveTasksToFolderSync(MoveTasksToFolderRequest req)
        {
            return InternalRequestAsync<MoveTasksToFolderResponse>(req, "MoveTasksToFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public Task<RegisterEventResponse> RegisterEvent(RegisterEventRequest req)
        {
            return InternalRequestAsync<RegisterEventResponse>(req, "RegisterEvent");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public RegisterEventResponse RegisterEventSync(RegisterEventRequest req)
        {
            return InternalRequestAsync<RegisterEventResponse>(req, "RegisterEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public Task<RegisterEventListenerResponse> RegisterEventListener(RegisterEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterEventListenerResponse>(req, "RegisterEventListener");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public RegisterEventListenerResponse RegisterEventListenerSync(RegisterEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterEventListenerResponse>(req, "RegisterEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除编排空间工作流
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkflowDsRequest"/></param>
        /// <returns><see cref="RemoveWorkflowDsResponse"/></returns>
        public Task<RemoveWorkflowDsResponse> RemoveWorkflowDs(RemoveWorkflowDsRequest req)
        {
            return InternalRequestAsync<RemoveWorkflowDsResponse>(req, "RemoveWorkflowDs");
        }

        /// <summary>
        /// 删除编排空间工作流
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkflowDsRequest"/></param>
        /// <returns><see cref="RemoveWorkflowDsResponse"/></returns>
        public RemoveWorkflowDsResponse RemoveWorkflowDsSync(RemoveWorkflowDsRequest req)
        {
            return InternalRequestAsync<RemoveWorkflowDsResponse>(req, "RemoveWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流下任务调度信息
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowSchedulerInfoDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowSchedulerInfoDsResponse"/></returns>
        public Task<RenewWorkflowSchedulerInfoDsResponse> RenewWorkflowSchedulerInfoDs(RenewWorkflowSchedulerInfoDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowSchedulerInfoDsResponse>(req, "RenewWorkflowSchedulerInfoDs");
        }

        /// <summary>
        /// 更新工作流下任务调度信息
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowSchedulerInfoDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowSchedulerInfoDsResponse"/></returns>
        public RenewWorkflowSchedulerInfoDsResponse RenewWorkflowSchedulerInfoDsSync(RenewWorkflowSchedulerInfoDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowSchedulerInfoDsResponse>(req, "RenewWorkflowSchedulerInfoDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 继续集成任务
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public Task<ResumeIntegrationTaskResponse> ResumeIntegrationTask(ResumeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ResumeIntegrationTaskResponse>(req, "ResumeIntegrationTask");
        }

        /// <summary>
        /// 继续集成任务
        /// </summary>
        /// <param name="req"><see cref="ResumeIntegrationTaskRequest"/></param>
        /// <returns><see cref="ResumeIntegrationTaskResponse"/></returns>
        public ResumeIntegrationTaskResponse ResumeIntegrationTaskSync(ResumeIntegrationTaskRequest req)
        {
            return InternalRequestAsync<ResumeIntegrationTaskResponse>(req, "ResumeIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 抢占锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public Task<RobAndLockIntegrationTaskResponse> RobAndLockIntegrationTask(RobAndLockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<RobAndLockIntegrationTaskResponse>(req, "RobAndLockIntegrationTask");
        }

        /// <summary>
        /// 抢占锁定集成任务
        /// </summary>
        /// <param name="req"><see cref="RobAndLockIntegrationTaskRequest"/></param>
        /// <returns><see cref="RobAndLockIntegrationTaskResponse"/></returns>
        public RobAndLockIntegrationTaskResponse RobAndLockIntegrationTaskSync(RobAndLockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<RobAndLockIntegrationTaskResponse>(req, "RobAndLockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="RunForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunForceSucScheduleInstancesResponse"/></returns>
        public Task<RunForceSucScheduleInstancesResponse> RunForceSucScheduleInstances(RunForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunForceSucScheduleInstancesResponse>(req, "RunForceSucScheduleInstances");
        }

        /// <summary>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="RunForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunForceSucScheduleInstancesResponse"/></returns>
        public RunForceSucScheduleInstancesResponse RunForceSucScheduleInstancesSync(RunForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunForceSucScheduleInstancesResponse>(req, "RunForceSucScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RunRerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunRerunScheduleInstancesResponse"/></returns>
        public Task<RunRerunScheduleInstancesResponse> RunRerunScheduleInstances(RunRerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunRerunScheduleInstancesResponse>(req, "RunRerunScheduleInstances");
        }

        /// <summary>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RunRerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunRerunScheduleInstancesResponse"/></returns>
        public RunRerunScheduleInstancesResponse RunRerunScheduleInstancesSync(RunRerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunRerunScheduleInstancesResponse>(req, "RunRerunScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启动工作流
        /// </summary>
        /// <param name="req"><see cref="RunTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="RunTasksByMultiWorkflowResponse"/></returns>
        public Task<RunTasksByMultiWorkflowResponse> RunTasksByMultiWorkflow(RunTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<RunTasksByMultiWorkflowResponse>(req, "RunTasksByMultiWorkflow");
        }

        /// <summary>
        /// 批量启动工作流
        /// </summary>
        /// <param name="req"><see cref="RunTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="RunTasksByMultiWorkflowResponse"/></returns>
        public RunTasksByMultiWorkflowResponse RunTasksByMultiWorkflowSync(RunTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<RunTasksByMultiWorkflowResponse>(req, "RunTasksByMultiWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public Task<SaveCustomFunctionResponse> SaveCustomFunction(SaveCustomFunctionRequest req)
        {
            return InternalRequestAsync<SaveCustomFunctionResponse>(req, "SaveCustomFunction");
        }

        /// <summary>
        /// 保存用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="SaveCustomFunctionRequest"/></param>
        /// <returns><see cref="SaveCustomFunctionResponse"/></returns>
        public SaveCustomFunctionResponse SaveCustomFunctionSync(SaveCustomFunctionRequest req)
        {
            return InternalRequestAsync<SaveCustomFunctionResponse>(req, "SaveCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public Task<SetTaskAlarmNewResponse> SetTaskAlarmNew(SetTaskAlarmNewRequest req)
        {
            return InternalRequestAsync<SetTaskAlarmNewResponse>(req, "SetTaskAlarmNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public SetTaskAlarmNewResponse SetTaskAlarmNewSync(SetTaskAlarmNewRequest req)
        {
            return InternalRequestAsync<SetTaskAlarmNewResponse>(req, "SetTaskAlarmNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动集成任务
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public Task<StartIntegrationTaskResponse> StartIntegrationTask(StartIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StartIntegrationTaskResponse>(req, "StartIntegrationTask");
        }

        /// <summary>
        /// 启动集成任务
        /// </summary>
        /// <param name="req"><see cref="StartIntegrationTaskRequest"/></param>
        /// <returns><see cref="StartIntegrationTaskResponse"/></returns>
        public StartIntegrationTaskResponse StartIntegrationTaskSync(StartIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StartIntegrationTaskResponse>(req, "StartIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止集成任务
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public Task<StopIntegrationTaskResponse> StopIntegrationTask(StopIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StopIntegrationTaskResponse>(req, "StopIntegrationTask");
        }

        /// <summary>
        /// 停止集成任务
        /// </summary>
        /// <param name="req"><see cref="StopIntegrationTaskRequest"/></param>
        /// <returns><see cref="StopIntegrationTaskResponse"/></returns>
        public StopIntegrationTaskResponse StopIntegrationTaskSync(StopIntegrationTaskRequest req)
        {
            return InternalRequestAsync<StopIntegrationTaskResponse>(req, "StopIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交自定义函数
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public Task<SubmitCustomFunctionResponse> SubmitCustomFunction(SubmitCustomFunctionRequest req)
        {
            return InternalRequestAsync<SubmitCustomFunctionResponse>(req, "SubmitCustomFunction");
        }

        /// <summary>
        /// 提交自定义函数
        /// </summary>
        /// <param name="req"><see cref="SubmitCustomFunctionRequest"/></param>
        /// <returns><see cref="SubmitCustomFunctionResponse"/></returns>
        public SubmitCustomFunctionResponse SubmitCustomFunctionSync(SubmitCustomFunctionRequest req)
        {
            return InternalRequestAsync<SubmitCustomFunctionResponse>(req, "SubmitCustomFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即席分析提交SQL任务
        /// </summary>
        /// <param name="req"><see cref="SubmitSqlTaskRequest"/></param>
        /// <returns><see cref="SubmitSqlTaskResponse"/></returns>
        public Task<SubmitSqlTaskResponse> SubmitSqlTask(SubmitSqlTaskRequest req)
        {
            return InternalRequestAsync<SubmitSqlTaskResponse>(req, "SubmitSqlTask");
        }

        /// <summary>
        /// 即席分析提交SQL任务
        /// </summary>
        /// <param name="req"><see cref="SubmitSqlTaskRequest"/></param>
        /// <returns><see cref="SubmitSqlTaskResponse"/></returns>
        public SubmitSqlTaskResponse SubmitSqlTaskSync(SubmitSqlTaskRequest req)
        {
            return InternalRequestAsync<SubmitSqlTaskResponse>(req, "SubmitSqlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskTestRunRequest"/></param>
        /// <returns><see cref="SubmitTaskTestRunResponse"/></returns>
        public Task<SubmitTaskTestRunResponse> SubmitTaskTestRun(SubmitTaskTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTaskTestRunResponse>(req, "SubmitTaskTestRun");
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskTestRunRequest"/></param>
        /// <returns><see cref="SubmitTaskTestRunResponse"/></returns>
        public SubmitTaskTestRunResponse SubmitTaskTestRunSync(SubmitTaskTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTaskTestRunResponse>(req, "SubmitTaskTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public Task<SubmitWorkflowResponse> SubmitWorkflow(SubmitWorkflowRequest req)
        {
            return InternalRequestAsync<SubmitWorkflowResponse>(req, "SubmitWorkflow");
        }

        /// <summary>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public SubmitWorkflowResponse SubmitWorkflowSync(SubmitWorkflowRequest req)
        {
            return InternalRequestAsync<SubmitWorkflowResponse>(req, "SubmitWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public Task<SuspendIntegrationTaskResponse> SuspendIntegrationTask(SuspendIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SuspendIntegrationTaskResponse>(req, "SuspendIntegrationTask");
        }

        /// <summary>
        /// 暂停集成任务
        /// </summary>
        /// <param name="req"><see cref="SuspendIntegrationTaskRequest"/></param>
        /// <returns><see cref="SuspendIntegrationTaskResponse"/></returns>
        public SuspendIntegrationTaskResponse SuspendIntegrationTaskSync(SuspendIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SuspendIntegrationTaskResponse>(req, "SuspendIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Inlong manager日志
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public Task<TaskLogResponse> TaskLog(TaskLogRequest req)
        {
            return InternalRequestAsync<TaskLogResponse>(req, "TaskLog");
        }

        /// <summary>
        /// 查询Inlong manager日志
        /// </summary>
        /// <param name="req"><see cref="TaskLogRequest"/></param>
        /// <returns><see cref="TaskLogResponse"/></returns>
        public TaskLogResponse TaskLogSync(TaskLogRequest req)
        {
            return InternalRequestAsync<TaskLogResponse>(req, "TaskLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件管理-触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerDsEventRequest"/></param>
        /// <returns><see cref="TriggerDsEventResponse"/></returns>
        public Task<TriggerDsEventResponse> TriggerDsEvent(TriggerDsEventRequest req)
        {
            return InternalRequestAsync<TriggerDsEventResponse>(req, "TriggerDsEvent");
        }

        /// <summary>
        /// 事件管理-触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerDsEventRequest"/></param>
        /// <returns><see cref="TriggerDsEventResponse"/></returns>
        public TriggerDsEventResponse TriggerDsEventSync(TriggerDsEventRequest req)
        {
            return InternalRequestAsync<TriggerDsEventResponse>(req, "TriggerDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public Task<TriggerEventResponse> TriggerEvent(TriggerEventRequest req)
        {
            return InternalRequestAsync<TriggerEventResponse>(req, "TriggerEvent");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public TriggerEventResponse TriggerEventSync(TriggerEventRequest req)
        {
            return InternalRequestAsync<TriggerEventResponse>(req, "TriggerEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动任务触发运行
        /// </summary>
        /// <param name="req"><see cref="TriggerManualTasksRequest"/></param>
        /// <returns><see cref="TriggerManualTasksResponse"/></returns>
        public Task<TriggerManualTasksResponse> TriggerManualTasks(TriggerManualTasksRequest req)
        {
            return InternalRequestAsync<TriggerManualTasksResponse>(req, "TriggerManualTasks");
        }

        /// <summary>
        /// 手动任务触发运行
        /// </summary>
        /// <param name="req"><see cref="TriggerManualTasksRequest"/></param>
        /// <returns><see cref="TriggerManualTasksResponse"/></returns>
        public TriggerManualTasksResponse TriggerManualTasksSync(TriggerManualTasksRequest req)
        {
            return InternalRequestAsync<TriggerManualTasksResponse>(req, "TriggerManualTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解锁集成任务
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public Task<UnlockIntegrationTaskResponse> UnlockIntegrationTask(UnlockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<UnlockIntegrationTaskResponse>(req, "UnlockIntegrationTask");
        }

        /// <summary>
        /// 解锁集成任务
        /// </summary>
        /// <param name="req"><see cref="UnlockIntegrationTaskRequest"/></param>
        /// <returns><see cref="UnlockIntegrationTaskResponse"/></returns>
        public UnlockIntegrationTaskResponse UnlockIntegrationTaskSync(UnlockIntegrationTaskRequest req)
        {
            return InternalRequestAsync<UnlockIntegrationTaskResponse>(req, "UnlockIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数语向wedata注册，提供自身cam角色信息，跳转域名、ip、端口信息等
        /// </summary>
        /// <param name="req"><see cref="UpdateDataModelRegistryInfoRequest"/></param>
        /// <returns><see cref="UpdateDataModelRegistryInfoResponse"/></returns>
        public Task<UpdateDataModelRegistryInfoResponse> UpdateDataModelRegistryInfo(UpdateDataModelRegistryInfoRequest req)
        {
            return InternalRequestAsync<UpdateDataModelRegistryInfoResponse>(req, "UpdateDataModelRegistryInfo");
        }

        /// <summary>
        /// 数语向wedata注册，提供自身cam角色信息，跳转域名、ip、端口信息等
        /// </summary>
        /// <param name="req"><see cref="UpdateDataModelRegistryInfoRequest"/></param>
        /// <returns><see cref="UpdateDataModelRegistryInfoResponse"/></returns>
        public UpdateDataModelRegistryInfoResponse UpdateDataModelRegistryInfoSync(UpdateDataModelRegistryInfoRequest req)
        {
            return InternalRequestAsync<UpdateDataModelRegistryInfoResponse>(req, "UpdateDataModelRegistryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作流责任人
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowOwnerRequest"/></param>
        /// <returns><see cref="UpdateWorkflowOwnerResponse"/></returns>
        public Task<UpdateWorkflowOwnerResponse> UpdateWorkflowOwner(UpdateWorkflowOwnerRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowOwnerResponse>(req, "UpdateWorkflowOwner");
        }

        /// <summary>
        /// 修改工作流责任人
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowOwnerRequest"/></param>
        /// <returns><see cref="UpdateWorkflowOwnerResponse"/></returns>
        public UpdateWorkflowOwnerResponse UpdateWorkflowOwnerSync(UpdateWorkflowOwnerRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowOwnerResponse>(req, "UpdateWorkflowOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存任务信息
        /// </summary>
        /// <param name="req"><see cref="UploadContentRequest"/></param>
        /// <returns><see cref="UploadContentResponse"/></returns>
        public Task<UploadContentResponse> UploadContent(UploadContentRequest req)
        {
            return InternalRequestAsync<UploadContentResponse>(req, "UploadContent");
        }

        /// <summary>
        /// 保存任务信息
        /// </summary>
        /// <param name="req"><see cref="UploadContentRequest"/></param>
        /// <returns><see cref="UploadContentResponse"/></returns>
        public UploadContentResponse UploadContentSync(UploadContentRequest req)
        {
            return InternalRequestAsync<UploadContentResponse>(req, "UploadContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-上传资源
        /// </summary>
        /// <param name="req"><see cref="UploadResourceRequest"/></param>
        /// <returns><see cref="UploadResourceResponse"/></returns>
        public Task<UploadResourceResponse> UploadResource(UploadResourceRequest req)
        {
            return InternalRequestAsync<UploadResourceResponse>(req, "UploadResource");
        }

        /// <summary>
        /// 资源管理-上传资源
        /// </summary>
        /// <param name="req"><see cref="UploadResourceRequest"/></param>
        /// <returns><see cref="UploadResourceResponse"/></returns>
        public UploadResourceResponse UploadResourceSync(UploadResourceRequest req)
        {
            return InternalRequestAsync<UploadResourceResponse>(req, "UploadResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
