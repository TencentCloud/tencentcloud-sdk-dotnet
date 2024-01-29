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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 获取协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="AcquireLockRequest"/></param>
        /// <returns><see cref="AcquireLockResponse"/></returns>
        public Task<AcquireLockResponse> AcquireLock(AcquireLockRequest req)
        {
            return InternalRequestAsync<AcquireLockResponse>(req, "AcquireLock");
        }

        /// <summary>
        /// 获取协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="AcquireLockRequest"/></param>
        /// <returns><see cref="AcquireLockResponse"/></returns>
        public AcquireLockResponse AcquireLockSync(AcquireLockRequest req)
        {
            return InternalRequestAsync<AcquireLockResponse>(req, "AcquireLock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上游依赖自动解析
        /// </summary>
        /// <param name="req"><see cref="AnalyzeDependentTasksRequest"/></param>
        /// <returns><see cref="AnalyzeDependentTasksResponse"/></returns>
        public Task<AnalyzeDependentTasksResponse> AnalyzeDependentTasks(AnalyzeDependentTasksRequest req)
        {
            return InternalRequestAsync<AnalyzeDependentTasksResponse>(req, "AnalyzeDependentTasks");
        }

        /// <summary>
        /// 上游依赖自动解析
        /// </summary>
        /// <param name="req"><see cref="AnalyzeDependentTasksRequest"/></param>
        /// <returns><see cref="AnalyzeDependentTasksResponse"/></returns>
        public AnalyzeDependentTasksResponse AnalyzeDependentTasksSync(AnalyzeDependentTasksRequest req)
        {
            return InternalRequestAsync<AnalyzeDependentTasksResponse>(req, "AnalyzeDependentTasks")
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
        /// 批量创建任务版本Ds
        /// </summary>
        /// <param name="req"><see cref="BatchCreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="BatchCreateTaskVersionDsResponse"/></returns>
        public Task<BatchCreateTaskVersionDsResponse> BatchCreateTaskVersionDs(BatchCreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<BatchCreateTaskVersionDsResponse>(req, "BatchCreateTaskVersionDs");
        }

        /// <summary>
        /// 批量创建任务版本Ds
        /// </summary>
        /// <param name="req"><see cref="BatchCreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="BatchCreateTaskVersionDsResponse"/></returns>
        public BatchCreateTaskVersionDsResponse BatchCreateTaskVersionDsSync(BatchCreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<BatchCreateTaskVersionDsResponse>(req, "BatchCreateTaskVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建虚拟任务, 用于新建跨工作流任务场景中新增跨工作流任务操作
        /// </summary>
        /// <param name="req"><see cref="BatchCreateVirtualTaskDsRequest"/></param>
        /// <returns><see cref="BatchCreateVirtualTaskDsResponse"/></returns>
        public Task<BatchCreateVirtualTaskDsResponse> BatchCreateVirtualTaskDs(BatchCreateVirtualTaskDsRequest req)
        {
            return InternalRequestAsync<BatchCreateVirtualTaskDsResponse>(req, "BatchCreateVirtualTaskDs");
        }

        /// <summary>
        /// 批量创建虚拟任务, 用于新建跨工作流任务场景中新增跨工作流任务操作
        /// </summary>
        /// <param name="req"><see cref="BatchCreateVirtualTaskDsRequest"/></param>
        /// <returns><see cref="BatchCreateVirtualTaskDsResponse"/></returns>
        public BatchCreateVirtualTaskDsResponse BatchCreateVirtualTaskDsSync(BatchCreateVirtualTaskDsRequest req)
        {
            return InternalRequestAsync<BatchCreateVirtualTaskDsResponse>(req, "BatchCreateVirtualTaskDs")
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
        /// 智能运维-批量删除任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public Task<BatchDeleteOpsTasksResponse> BatchDeleteOpsTasks(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks");
        }

        /// <summary>
        /// 智能运维-批量删除任务
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteOpsTasksRequest"/></param>
        /// <returns><see cref="BatchDeleteOpsTasksResponse"/></returns>
        public BatchDeleteOpsTasksResponse BatchDeleteOpsTasksSync(BatchDeleteOpsTasksRequest req)
        {
            return InternalRequestAsync<BatchDeleteOpsTasksResponse>(req, "BatchDeleteOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Ds批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksDsRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksDsResponse"/></returns>
        public Task<BatchDeleteTasksDsResponse> BatchDeleteTasksDs(BatchDeleteTasksDsRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksDsResponse>(req, "BatchDeleteTasksDs");
        }

        /// <summary>
        /// Ds批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksDsRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksDsResponse"/></returns>
        public BatchDeleteTasksDsResponse BatchDeleteTasksDsSync(BatchDeleteTasksDsRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksDsResponse>(req, "BatchDeleteTasksDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Ds批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksDsAsyncRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksDsAsyncResponse"/></returns>
        public Task<BatchDeleteTasksDsAsyncResponse> BatchDeleteTasksDsAsync(BatchDeleteTasksDsAsyncRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksDsAsyncResponse>(req, "BatchDeleteTasksDsAsync");
        }

        /// <summary>
        /// Ds批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksDsAsyncRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksDsAsyncResponse"/></returns>
        public BatchDeleteTasksDsAsyncResponse BatchDeleteTasksDsAsyncSync(BatchDeleteTasksDsAsyncRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksDsAsyncResponse>(req, "BatchDeleteTasksDsAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public Task<BatchDeleteTasksNewResponse> BatchDeleteTasksNew(BatchDeleteTasksNewRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksNewResponse>(req, "BatchDeleteTasksNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public BatchDeleteTasksNewResponse BatchDeleteTasksNewSync(BatchDeleteTasksNewRequest req)
        {
            return InternalRequestAsync<BatchDeleteTasksNewResponse>(req, "BatchDeleteTasksNew")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public Task<BatchModifyOwnersNewResponse> BatchModifyOwnersNew(BatchModifyOwnersNewRequest req)
        {
            return InternalRequestAsync<BatchModifyOwnersNewResponse>(req, "BatchModifyOwnersNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public BatchModifyOwnersNewResponse BatchModifyOwnersNewSync(BatchModifyOwnersNewRequest req)
        {
            return InternalRequestAsync<BatchModifyOwnersNewResponse>(req, "BatchModifyOwnersNew")
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
        /// 任务运维-任务列表 批量运行
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public Task<BatchRunOpsTaskResponse> BatchRunOpsTask(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask");
        }

        /// <summary>
        /// 任务运维-任务列表 批量运行
        /// </summary>
        /// <param name="req"><see cref="BatchRunOpsTaskRequest"/></param>
        /// <returns><see cref="BatchRunOpsTaskResponse"/></returns>
        public BatchRunOpsTaskResponse BatchRunOpsTaskSync(BatchRunOpsTaskRequest req)
        {
            return InternalRequestAsync<BatchRunOpsTaskResponse>(req, "BatchRunOpsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量运行任务, 用于工作流-任务配置-运行、工作流-任务右键-运行、任务运维-任务管理-更多操作-运行、任务运维-任务管理-选择任务-批量运行等场景。
        /// 1. 任务运行预判断
        /// 2. 更新db中任务状态
        /// 3. 通知scheduler进行运行操作
        /// </summary>
        /// <param name="req"><see cref="BatchRunTasksDsRequest"/></param>
        /// <returns><see cref="BatchRunTasksDsResponse"/></returns>
        public Task<BatchRunTasksDsResponse> BatchRunTasksDs(BatchRunTasksDsRequest req)
        {
            return InternalRequestAsync<BatchRunTasksDsResponse>(req, "BatchRunTasksDs");
        }

        /// <summary>
        /// 批量运行任务, 用于工作流-任务配置-运行、工作流-任务右键-运行、任务运维-任务管理-更多操作-运行、任务运维-任务管理-选择任务-批量运行等场景。
        /// 1. 任务运行预判断
        /// 2. 更新db中任务状态
        /// 3. 通知scheduler进行运行操作
        /// </summary>
        /// <param name="req"><see cref="BatchRunTasksDsRequest"/></param>
        /// <returns><see cref="BatchRunTasksDsResponse"/></returns>
        public BatchRunTasksDsResponse BatchRunTasksDsSync(BatchRunTasksDsRequest req)
        {
            return InternalRequestAsync<BatchRunTasksDsResponse>(req, "BatchRunTasksDs")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public Task<BatchStopTasksNewResponse> BatchStopTasksNew(BatchStopTasksNewRequest req)
        {
            return InternalRequestAsync<BatchStopTasksNewResponse>(req, "BatchStopTasksNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public BatchStopTasksNewResponse BatchStopTasksNewSync(BatchStopTasksNewRequest req)
        {
            return InternalRequestAsync<BatchStopTasksNewResponse>(req, "BatchStopTasksNew")
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
        /// 批量更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateTasksDsRequest"/></param>
        /// <returns><see cref="BatchUpdateTasksDsResponse"/></returns>
        public Task<BatchUpdateTasksDsResponse> BatchUpdateTasksDs(BatchUpdateTasksDsRequest req)
        {
            return InternalRequestAsync<BatchUpdateTasksDsResponse>(req, "BatchUpdateTasksDs");
        }

        /// <summary>
        /// 批量更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateTasksDsRequest"/></param>
        /// <returns><see cref="BatchUpdateTasksDsResponse"/></returns>
        public BatchUpdateTasksDsResponse BatchUpdateTasksDsSync(BatchUpdateTasksDsRequest req)
        {
            return InternalRequestAsync<BatchUpdateTasksDsResponse>(req, "BatchUpdateTasksDs")
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
        /// 新建用户自定义函数组件检查
        /// </summary>
        /// <param name="req"><see cref="CheckCustomFunctionPremiseRequest"/></param>
        /// <returns><see cref="CheckCustomFunctionPremiseResponse"/></returns>
        public Task<CheckCustomFunctionPremiseResponse> CheckCustomFunctionPremise(CheckCustomFunctionPremiseRequest req)
        {
            return InternalRequestAsync<CheckCustomFunctionPremiseResponse>(req, "CheckCustomFunctionPremise");
        }

        /// <summary>
        /// 新建用户自定义函数组件检查
        /// </summary>
        /// <param name="req"><see cref="CheckCustomFunctionPremiseRequest"/></param>
        /// <returns><see cref="CheckCustomFunctionPremiseResponse"/></returns>
        public CheckCustomFunctionPremiseResponse CheckCustomFunctionPremiseSync(CheckCustomFunctionPremiseRequest req)
        {
            return InternalRequestAsync<CheckCustomFunctionPremiseResponse>(req, "CheckCustomFunctionPremise")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查规则名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateRuleNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateRuleNameResponse"/></returns>
        public Task<CheckDuplicateRuleNameResponse> CheckDuplicateRuleName(CheckDuplicateRuleNameRequest req)
        {
            return InternalRequestAsync<CheckDuplicateRuleNameResponse>(req, "CheckDuplicateRuleName");
        }

        /// <summary>
        /// 检查规则名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateRuleNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateRuleNameResponse"/></returns>
        public CheckDuplicateRuleNameResponse CheckDuplicateRuleNameSync(CheckDuplicateRuleNameRequest req)
        {
            return InternalRequestAsync<CheckDuplicateRuleNameResponse>(req, "CheckDuplicateRuleName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查规则模板名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateTemplateNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateTemplateNameResponse"/></returns>
        public Task<CheckDuplicateTemplateNameResponse> CheckDuplicateTemplateName(CheckDuplicateTemplateNameRequest req)
        {
            return InternalRequestAsync<CheckDuplicateTemplateNameResponse>(req, "CheckDuplicateTemplateName");
        }

        /// <summary>
        /// 检查规则模板名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckDuplicateTemplateNameRequest"/></param>
        /// <returns><see cref="CheckDuplicateTemplateNameResponse"/></returns>
        public CheckDuplicateTemplateNameResponse CheckDuplicateTemplateNameSync(CheckDuplicateTemplateNameRequest req)
        {
            return InternalRequestAsync<CheckDuplicateTemplateNameResponse>(req, "CheckDuplicateTemplateName")
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
        /// 检查任务名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistDsRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistDsResponse"/></returns>
        public Task<CheckTaskNameExistDsResponse> CheckTaskNameExistDs(CheckTaskNameExistDsRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistDsResponse>(req, "CheckTaskNameExistDs");
        }

        /// <summary>
        /// 检查任务名称是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckTaskNameExistDsRequest"/></param>
        /// <returns><see cref="CheckTaskNameExistDsResponse"/></returns>
        public CheckTaskNameExistDsResponse CheckTaskNameExistDsSync(CheckTaskNameExistDsRequest req)
        {
            return InternalRequestAsync<CheckTaskNameExistDsResponse>(req, "CheckTaskNameExistDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查操作用户对所选任务是否有操作权限, 用于新建跨工作流任务场景中展示审批提示操作
        /// </summary>
        /// <param name="req"><see cref="CheckTaskPriorityDsRequest"/></param>
        /// <returns><see cref="CheckTaskPriorityDsResponse"/></returns>
        public Task<CheckTaskPriorityDsResponse> CheckTaskPriorityDs(CheckTaskPriorityDsRequest req)
        {
            return InternalRequestAsync<CheckTaskPriorityDsResponse>(req, "CheckTaskPriorityDs");
        }

        /// <summary>
        /// 检查操作用户对所选任务是否有操作权限, 用于新建跨工作流任务场景中展示审批提示操作
        /// </summary>
        /// <param name="req"><see cref="CheckTaskPriorityDsRequest"/></param>
        /// <returns><see cref="CheckTaskPriorityDsResponse"/></returns>
        public CheckTaskPriorityDsResponse CheckTaskPriorityDsSync(CheckTaskPriorityDsRequest req)
        {
            return InternalRequestAsync<CheckTaskPriorityDsResponse>(req, "CheckTaskPriorityDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清空回收站任务
        /// </summary>
        /// <param name="req"><see cref="ClearRecycleTaskRequest"/></param>
        /// <returns><see cref="ClearRecycleTaskResponse"/></returns>
        public Task<ClearRecycleTaskResponse> ClearRecycleTask(ClearRecycleTaskRequest req)
        {
            return InternalRequestAsync<ClearRecycleTaskResponse>(req, "ClearRecycleTask");
        }

        /// <summary>
        /// 清空回收站任务
        /// </summary>
        /// <param name="req"><see cref="ClearRecycleTaskRequest"/></param>
        /// <returns><see cref="ClearRecycleTaskResponse"/></returns>
        public ClearRecycleTaskResponse ClearRecycleTaskSync(ClearRecycleTaskRequest req)
        {
            return InternalRequestAsync<ClearRecycleTaskResponse>(req, "ClearRecycleTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交数据导出任务
        /// </summary>
        /// <param name="req"><see cref="CommitExportTaskRequest"/></param>
        /// <returns><see cref="CommitExportTaskResponse"/></returns>
        public Task<CommitExportTaskResponse> CommitExportTask(CommitExportTaskRequest req)
        {
            return InternalRequestAsync<CommitExportTaskResponse>(req, "CommitExportTask");
        }

        /// <summary>
        /// 提交数据导出任务
        /// </summary>
        /// <param name="req"><see cref="CommitExportTaskRequest"/></param>
        /// <returns><see cref="CommitExportTaskResponse"/></returns>
        public CommitExportTaskResponse CommitExportTaskSync(CommitExportTaskRequest req)
        {
            return InternalRequestAsync<CommitExportTaskResponse>(req, "CommitExportTask")
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
        /// Runner 规则检测结果上报
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupExecResultRequest"/></param>
        /// <returns><see cref="CommitRuleGroupExecResultResponse"/></returns>
        public Task<CommitRuleGroupExecResultResponse> CommitRuleGroupExecResult(CommitRuleGroupExecResultRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupExecResultResponse>(req, "CommitRuleGroupExecResult");
        }

        /// <summary>
        /// Runner 规则检测结果上报
        /// </summary>
        /// <param name="req"><see cref="CommitRuleGroupExecResultRequest"/></param>
        /// <returns><see cref="CommitRuleGroupExecResultResponse"/></returns>
        public CommitRuleGroupExecResultResponse CommitRuleGroupExecResultSync(CommitRuleGroupExecResultRequest req)
        {
            return InternalRequestAsync<CommitRuleGroupExecResultResponse>(req, "CommitRuleGroupExecResult")
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
        /// 工作流版本提交
        /// </summary>
        /// <param name="req"><see cref="CommitWorkflowRequest"/></param>
        /// <returns><see cref="CommitWorkflowResponse"/></returns>
        public Task<CommitWorkflowResponse> CommitWorkflow(CommitWorkflowRequest req)
        {
            return InternalRequestAsync<CommitWorkflowResponse>(req, "CommitWorkflow");
        }

        /// <summary>
        /// 工作流版本提交
        /// </summary>
        /// <param name="req"><see cref="CommitWorkflowRequest"/></param>
        /// <returns><see cref="CommitWorkflowResponse"/></returns>
        public CommitWorkflowResponse CommitWorkflowSync(CommitWorkflowRequest req)
        {
            return InternalRequestAsync<CommitWorkflowResponse>(req, "CommitWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对比任务版本
        /// </summary>
        /// <param name="req"><see cref="CompareDsTaskVersionInfoRequest"/></param>
        /// <returns><see cref="CompareDsTaskVersionInfoResponse"/></returns>
        public Task<CompareDsTaskVersionInfoResponse> CompareDsTaskVersionInfo(CompareDsTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<CompareDsTaskVersionInfoResponse>(req, "CompareDsTaskVersionInfo");
        }

        /// <summary>
        /// 对比任务版本
        /// </summary>
        /// <param name="req"><see cref="CompareDsTaskVersionInfoRequest"/></param>
        /// <returns><see cref="CompareDsTaskVersionInfoResponse"/></returns>
        public CompareDsTaskVersionInfoResponse CompareDsTaskVersionInfoSync(CompareDsTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<CompareDsTaskVersionInfoResponse>(req, "CompareDsTaskVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制任务Ds
        /// </summary>
        /// <param name="req"><see cref="CopyTaskDsRequest"/></param>
        /// <returns><see cref="CopyTaskDsResponse"/></returns>
        public Task<CopyTaskDsResponse> CopyTaskDs(CopyTaskDsRequest req)
        {
            return InternalRequestAsync<CopyTaskDsResponse>(req, "CopyTaskDs");
        }

        /// <summary>
        /// 复制任务Ds
        /// </summary>
        /// <param name="req"><see cref="CopyTaskDsRequest"/></param>
        /// <returns><see cref="CopyTaskDsResponse"/></returns>
        public CopyTaskDsResponse CopyTaskDsSync(CopyTaskDsRequest req)
        {
            return InternalRequestAsync<CopyTaskDsResponse>(req, "CopyTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制工作流
        /// </summary>
        /// <param name="req"><see cref="CopyWorkflowDsRequest"/></param>
        /// <returns><see cref="CopyWorkflowDsResponse"/></returns>
        public Task<CopyWorkflowDsResponse> CopyWorkflowDs(CopyWorkflowDsRequest req)
        {
            return InternalRequestAsync<CopyWorkflowDsResponse>(req, "CopyWorkflowDs");
        }

        /// <summary>
        /// 复制工作流
        /// </summary>
        /// <param name="req"><see cref="CopyWorkflowDsRequest"/></param>
        /// <returns><see cref="CopyWorkflowDsResponse"/></returns>
        public CopyWorkflowDsResponse CopyWorkflowDsSync(CopyWorkflowDsRequest req)
        {
            return InternalRequestAsync<CopyWorkflowDsResponse>(req, "CopyWorkflowDs")
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
        /// 创建基线
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineRequest"/></param>
        /// <returns><see cref="CreateBaselineResponse"/></returns>
        public Task<CreateBaselineResponse> CreateBaseline(CreateBaselineRequest req)
        {
            return InternalRequestAsync<CreateBaselineResponse>(req, "CreateBaseline");
        }

        /// <summary>
        /// 创建基线
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineRequest"/></param>
        /// <returns><see cref="CreateBaselineResponse"/></returns>
        public CreateBaselineResponse CreateBaselineSync(CreateBaselineRequest req)
        {
            return InternalRequestAsync<CreateBaselineResponse>(req, "CreateBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户数据开发浏览历史
        /// </summary>
        /// <param name="req"><see cref="CreateBrowsingHistoryRequest"/></param>
        /// <returns><see cref="CreateBrowsingHistoryResponse"/></returns>
        public Task<CreateBrowsingHistoryResponse> CreateBrowsingHistory(CreateBrowsingHistoryRequest req)
        {
            return InternalRequestAsync<CreateBrowsingHistoryResponse>(req, "CreateBrowsingHistory");
        }

        /// <summary>
        /// 创建用户数据开发浏览历史
        /// </summary>
        /// <param name="req"><see cref="CreateBrowsingHistoryRequest"/></param>
        /// <returns><see cref="CreateBrowsingHistoryResponse"/></returns>
        public CreateBrowsingHistoryResponse CreateBrowsingHistorySync(CreateBrowsingHistoryRequest req)
        {
            return InternalRequestAsync<CreateBrowsingHistoryResponse>(req, "CreateBrowsingHistory")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 创建开发空间版本
        /// </summary>
        /// <param name="req"><see cref="CreateFileVersionRequest"/></param>
        /// <returns><see cref="CreateFileVersionResponse"/></returns>
        public Task<CreateFileVersionResponse> CreateFileVersion(CreateFileVersionRequest req)
        {
            return InternalRequestAsync<CreateFileVersionResponse>(req, "CreateFileVersion");
        }

        /// <summary>
        /// 创建开发空间版本
        /// </summary>
        /// <param name="req"><see cref="CreateFileVersionRequest"/></param>
        /// <returns><see cref="CreateFileVersionResponse"/></returns>
        public CreateFileVersionResponse CreateFileVersionSync(CreateFileVersionRequest req)
        {
            return InternalRequestAsync<CreateFileVersionResponse>(req, "CreateFileVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder")
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
        /// 注册采集器
        /// </summary>
        /// <param name="req"><see cref="CreateInLongAgentRequest"/></param>
        /// <returns><see cref="CreateInLongAgentResponse"/></returns>
        public Task<CreateInLongAgentResponse> CreateInLongAgent(CreateInLongAgentRequest req)
        {
            return InternalRequestAsync<CreateInLongAgentResponse>(req, "CreateInLongAgent");
        }

        /// <summary>
        /// 注册采集器
        /// </summary>
        /// <param name="req"><see cref="CreateInLongAgentRequest"/></param>
        /// <returns><see cref="CreateInLongAgentResponse"/></returns>
        public CreateInLongAgentResponse CreateInLongAgentSync(CreateInLongAgentRequest req)
        {
            return InternalRequestAsync<CreateInLongAgentResponse>(req, "CreateInLongAgent")
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
        /// 创建任务连接
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public Task<CreateLinkResponse> CreateLink(CreateLinkRequest req)
        {
            return InternalRequestAsync<CreateLinkResponse>(req, "CreateLink");
        }

        /// <summary>
        /// 创建任务连接
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public CreateLinkResponse CreateLinkSync(CreateLinkRequest req)
        {
            return InternalRequestAsync<CreateLinkResponse>(req, "CreateLink")
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
        /// 补录任务
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public Task<CreateOpsMakePlanResponse> CreateOpsMakePlan(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan");
        }

        /// <summary>
        /// 补录任务
        /// </summary>
        /// <param name="req"><see cref="CreateOpsMakePlanRequest"/></param>
        /// <returns><see cref="CreateOpsMakePlanResponse"/></returns>
        public CreateOpsMakePlanResponse CreateOpsMakePlanSync(CreateOpsMakePlanRequest req)
        {
            return InternalRequestAsync<CreateOpsMakePlanResponse>(req, "CreateOpsMakePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理需要先将资源上传到cos中，然后调用该接口，将cos资源绑定到wedata
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateResourceRequest"/></param>
        /// <returns><see cref="CreateOrUpdateResourceResponse"/></returns>
        public Task<CreateOrUpdateResourceResponse> CreateOrUpdateResource(CreateOrUpdateResourceRequest req)
        {
            return InternalRequestAsync<CreateOrUpdateResourceResponse>(req, "CreateOrUpdateResource");
        }

        /// <summary>
        /// 资源管理需要先将资源上传到cos中，然后调用该接口，将cos资源绑定到wedata
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateResourceRequest"/></param>
        /// <returns><see cref="CreateOrUpdateResourceResponse"/></returns>
        public CreateOrUpdateResourceResponse CreateOrUpdateResourceSync(CreateOrUpdateResourceRequest req)
        {
            return InternalRequestAsync<CreateOrUpdateResourceResponse>(req, "CreateOrUpdateResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreatePathRequest"/></param>
        /// <returns><see cref="CreatePathResponse"/></returns>
        public Task<CreatePathResponse> CreatePath(CreatePathRequest req)
        {
            return InternalRequestAsync<CreatePathResponse>(req, "CreatePath");
        }

        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreatePathRequest"/></param>
        /// <returns><see cref="CreatePathResponse"/></returns>
        public CreatePathResponse CreatePathSync(CreatePathRequest req)
        {
            return InternalRequestAsync<CreatePathResponse>(req, "CreatePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目参数
        /// </summary>
        /// <param name="req"><see cref="CreateProjectParamDsRequest"/></param>
        /// <returns><see cref="CreateProjectParamDsResponse"/></returns>
        public Task<CreateProjectParamDsResponse> CreateProjectParamDs(CreateProjectParamDsRequest req)
        {
            return InternalRequestAsync<CreateProjectParamDsResponse>(req, "CreateProjectParamDs");
        }

        /// <summary>
        /// 创建项目参数
        /// </summary>
        /// <param name="req"><see cref="CreateProjectParamDsRequest"/></param>
        /// <returns><see cref="CreateProjectParamDsResponse"/></returns>
        public CreateProjectParamDsResponse CreateProjectParamDsSync(CreateProjectParamDsRequest req)
        {
            return InternalRequestAsync<CreateProjectParamDsResponse>(req, "CreateProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-创建资源目录
        /// </summary>
        /// <param name="req"><see cref="CreateResourceDirectoryRequest"/></param>
        /// <returns><see cref="CreateResourceDirectoryResponse"/></returns>
        public Task<CreateResourceDirectoryResponse> CreateResourceDirectory(CreateResourceDirectoryRequest req)
        {
            return InternalRequestAsync<CreateResourceDirectoryResponse>(req, "CreateResourceDirectory");
        }

        /// <summary>
        /// 资源管理-创建资源目录
        /// </summary>
        /// <param name="req"><see cref="CreateResourceDirectoryRequest"/></param>
        /// <returns><see cref="CreateResourceDirectoryResponse"/></returns>
        public CreateResourceDirectoryResponse CreateResourceDirectorySync(CreateResourceDirectoryRequest req)
        {
            return InternalRequestAsync<CreateResourceDirectoryResponse>(req, "CreateResourceDirectory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件路径的根目录为 /datastudio/resource，如果要在根目录下创建 aaa 文件夹，FilePath的值应该为 /datastudio/resource，如果根目录下已经创建了 aaa 文件夹，要在 aaa 下创建  bbb 文件夹，FilePath的值应该为 /datastudio/resource/aaa
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePathRequest"/></param>
        /// <returns><see cref="CreateResourcePathResponse"/></returns>
        public Task<CreateResourcePathResponse> CreateResourcePath(CreateResourcePathRequest req)
        {
            return InternalRequestAsync<CreateResourcePathResponse>(req, "CreateResourcePath");
        }

        /// <summary>
        /// 文件路径的根目录为 /datastudio/resource，如果要在根目录下创建 aaa 文件夹，FilePath的值应该为 /datastudio/resource，如果根目录下已经创建了 aaa 文件夹，要在 aaa 下创建  bbb 文件夹，FilePath的值应该为 /datastudio/resource/aaa
        /// </summary>
        /// <param name="req"><see cref="CreateResourcePathRequest"/></param>
        /// <returns><see cref="CreateResourcePathResponse"/></returns>
        public CreateResourcePathResponse CreateResourcePathSync(CreateResourcePathRequest req)
        {
            return InternalRequestAsync<CreateResourcePathResponse>(req, "CreateResourcePath")
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
        /// 创建规则模版
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public Task<CreateRuleTemplateResponse> CreateRuleTemplate(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate");
        }

        /// <summary>
        /// 创建规则模版
        /// </summary>
        /// <param name="req"><see cref="CreateRuleTemplateRequest"/></param>
        /// <returns><see cref="CreateRuleTemplateResponse"/></returns>
        public CreateRuleTemplateResponse CreateRuleTemplateSync(CreateRuleTemplateRequest req)
        {
            return InternalRequestAsync<CreateRuleTemplateResponse>(req, "CreateRuleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间导入开发空间脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptsImportTasksDsRequest"/></param>
        /// <returns><see cref="CreateScriptsImportTasksDsResponse"/></returns>
        public Task<CreateScriptsImportTasksDsResponse> CreateScriptsImportTasksDs(CreateScriptsImportTasksDsRequest req)
        {
            return InternalRequestAsync<CreateScriptsImportTasksDsResponse>(req, "CreateScriptsImportTasksDs");
        }

        /// <summary>
        /// 编排空间导入开发空间脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptsImportTasksDsRequest"/></param>
        /// <returns><see cref="CreateScriptsImportTasksDsResponse"/></returns>
        public CreateScriptsImportTasksDsResponse CreateScriptsImportTasksDsSync(CreateScriptsImportTasksDsRequest req)
        {
            return InternalRequestAsync<CreateScriptsImportTasksDsResponse>(req, "CreateScriptsImportTasksDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 创建任务Ds
        /// </summary>
        /// <param name="req"><see cref="CreateTaskDsRequest"/></param>
        /// <returns><see cref="CreateTaskDsResponse"/></returns>
        public Task<CreateTaskDsResponse> CreateTaskDs(CreateTaskDsRequest req)
        {
            return InternalRequestAsync<CreateTaskDsResponse>(req, "CreateTaskDs");
        }

        /// <summary>
        /// 创建任务Ds
        /// </summary>
        /// <param name="req"><see cref="CreateTaskDsRequest"/></param>
        /// <returns><see cref="CreateTaskDsResponse"/></returns>
        public CreateTaskDsResponse CreateTaskDsSync(CreateTaskDsRequest req)
        {
            return InternalRequestAsync<CreateTaskDsResponse>(req, "CreateTaskDs")
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
        /// 设置任务输入参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskInParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskInParamDsResponse"/></returns>
        public Task<CreateTaskInParamDsResponse> CreateTaskInParamDs(CreateTaskInParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskInParamDsResponse>(req, "CreateTaskInParamDs");
        }

        /// <summary>
        /// 设置任务输入参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskInParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskInParamDsResponse"/></returns>
        public CreateTaskInParamDsResponse CreateTaskInParamDsSync(CreateTaskInParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskInParamDsResponse>(req, "CreateTaskInParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置任务输出参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskOutParamDsResponse"/></returns>
        public Task<CreateTaskOutParamDsResponse> CreateTaskOutParamDs(CreateTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskOutParamDsResponse>(req, "CreateTaskOutParamDs");
        }

        /// <summary>
        /// 设置任务输出参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskOutParamDsResponse"/></returns>
        public CreateTaskOutParamDsResponse CreateTaskOutParamDsSync(CreateTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskOutParamDsResponse>(req, "CreateTaskOutParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量创建登记项
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutputRegistriesRequest"/></param>
        /// <returns><see cref="CreateTaskOutputRegistriesResponse"/></returns>
        public Task<CreateTaskOutputRegistriesResponse> CreateTaskOutputRegistries(CreateTaskOutputRegistriesRequest req)
        {
            return InternalRequestAsync<CreateTaskOutputRegistriesResponse>(req, "CreateTaskOutputRegistries");
        }

        /// <summary>
        /// 批量创建登记项
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutputRegistriesRequest"/></param>
        /// <returns><see cref="CreateTaskOutputRegistriesResponse"/></returns>
        public CreateTaskOutputRegistriesResponse CreateTaskOutputRegistriesSync(CreateTaskOutputRegistriesRequest req)
        {
            return InternalRequestAsync<CreateTaskOutputRegistriesResponse>(req, "CreateTaskOutputRegistries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或编辑产出登记项
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutputRegistryRequest"/></param>
        /// <returns><see cref="CreateTaskOutputRegistryResponse"/></returns>
        public Task<CreateTaskOutputRegistryResponse> CreateTaskOutputRegistry(CreateTaskOutputRegistryRequest req)
        {
            return InternalRequestAsync<CreateTaskOutputRegistryResponse>(req, "CreateTaskOutputRegistry");
        }

        /// <summary>
        /// 新增或编辑产出登记项
        /// </summary>
        /// <param name="req"><see cref="CreateTaskOutputRegistryRequest"/></param>
        /// <returns><see cref="CreateTaskOutputRegistryResponse"/></returns>
        public CreateTaskOutputRegistryResponse CreateTaskOutputRegistrySync(CreateTaskOutputRegistryRequest req)
        {
            return InternalRequestAsync<CreateTaskOutputRegistryResponse>(req, "CreateTaskOutputRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务引用参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskParamDsResponse"/></returns>
        public Task<CreateTaskParamDsResponse> CreateTaskParamDs(CreateTaskParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskParamDsResponse>(req, "CreateTaskParamDs");
        }

        /// <summary>
        /// 任务引用参数
        /// </summary>
        /// <param name="req"><see cref="CreateTaskParamDsRequest"/></param>
        /// <returns><see cref="CreateTaskParamDsResponse"/></returns>
        public CreateTaskParamDsResponse CreateTaskParamDsSync(CreateTaskParamDsRequest req)
        {
            return InternalRequestAsync<CreateTaskParamDsResponse>(req, "CreateTaskParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务版本
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public Task<CreateTaskVersionDsResponse> CreateTaskVersionDs(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs");
        }

        /// <summary>
        /// 创建任务版本
        /// </summary>
        /// <param name="req"><see cref="CreateTaskVersionDsRequest"/></param>
        /// <returns><see cref="CreateTaskVersionDsResponse"/></returns>
        public CreateTaskVersionDsResponse CreateTaskVersionDsSync(CreateTaskVersionDsRequest req)
        {
            return InternalRequestAsync<CreateTaskVersionDsResponse>(req, "CreateTaskVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
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
        /// DeleteBaseline
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRequest"/></param>
        /// <returns><see cref="DeleteBaselineResponse"/></returns>
        public Task<DeleteBaselineResponse> DeleteBaseline(DeleteBaselineRequest req)
        {
            return InternalRequestAsync<DeleteBaselineResponse>(req, "DeleteBaseline");
        }

        /// <summary>
        /// DeleteBaseline
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRequest"/></param>
        /// <returns><see cref="DeleteBaselineResponse"/></returns>
        public DeleteBaselineResponse DeleteBaselineSync(DeleteBaselineRequest req)
        {
            return InternalRequestAsync<DeleteBaselineResponse>(req, "DeleteBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchWorkflowDsRequest"/></param>
        /// <returns><see cref="DeleteBatchWorkflowDsResponse"/></returns>
        public Task<DeleteBatchWorkflowDsResponse> DeleteBatchWorkflowDs(DeleteBatchWorkflowDsRequest req)
        {
            return InternalRequestAsync<DeleteBatchWorkflowDsResponse>(req, "DeleteBatchWorkflowDs");
        }

        /// <summary>
        /// 批量删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchWorkflowDsRequest"/></param>
        /// <returns><see cref="DeleteBatchWorkflowDsResponse"/></returns>
        public DeleteBatchWorkflowDsResponse DeleteBatchWorkflowDsSync(DeleteBatchWorkflowDsRequest req)
        {
            return InternalRequestAsync<DeleteBatchWorkflowDsResponse>(req, "DeleteBatchWorkflowDs")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public Task<DeleteDataSourcesResponse> DeleteDataSources(DeleteDataSourcesRequest req)
        {
            return InternalRequestAsync<DeleteDataSourcesResponse>(req, "DeleteDataSources");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 删除事件
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventRequest"/></param>
        /// <returns><see cref="DeleteDsEventResponse"/></returns>
        public Task<DeleteDsEventResponse> DeleteDsEvent(DeleteDsEventRequest req)
        {
            return InternalRequestAsync<DeleteDsEventResponse>(req, "DeleteDsEvent");
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventRequest"/></param>
        /// <returns><see cref="DeleteDsEventResponse"/></returns>
        public DeleteDsEventResponse DeleteDsEventSync(DeleteDsEventRequest req)
        {
            return InternalRequestAsync<DeleteDsEventResponse>(req, "DeleteDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件监听者
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventListenerRequest"/></param>
        /// <returns><see cref="DeleteDsEventListenerResponse"/></returns>
        public Task<DeleteDsEventListenerResponse> DeleteDsEventListener(DeleteDsEventListenerRequest req)
        {
            return InternalRequestAsync<DeleteDsEventListenerResponse>(req, "DeleteDsEventListener");
        }

        /// <summary>
        /// 删除事件监听者
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventListenerRequest"/></param>
        /// <returns><see cref="DeleteDsEventListenerResponse"/></returns>
        public DeleteDsEventListenerResponse DeleteDsEventListenerSync(DeleteDsEventListenerRequest req)
        {
            return InternalRequestAsync<DeleteDsEventListenerResponse>(req, "DeleteDsEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件发布者
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventPublisherRequest"/></param>
        /// <returns><see cref="DeleteDsEventPublisherResponse"/></returns>
        public Task<DeleteDsEventPublisherResponse> DeleteDsEventPublisher(DeleteDsEventPublisherRequest req)
        {
            return InternalRequestAsync<DeleteDsEventPublisherResponse>(req, "DeleteDsEventPublisher");
        }

        /// <summary>
        /// 删除事件发布者
        /// </summary>
        /// <param name="req"><see cref="DeleteDsEventPublisherRequest"/></param>
        /// <returns><see cref="DeleteDsEventPublisherResponse"/></returns>
        public DeleteDsEventPublisherResponse DeleteDsEventPublisherSync(DeleteDsEventPublisherRequest req)
        {
            return InternalRequestAsync<DeleteDsEventPublisherResponse>(req, "DeleteDsEventPublisher")
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
        /// 通过任务ID删除所有事件
        /// </summary>
        /// <param name="req"><see cref="DeleteEventListenerByTaskIdRequest"/></param>
        /// <returns><see cref="DeleteEventListenerByTaskIdResponse"/></returns>
        public Task<DeleteEventListenerByTaskIdResponse> DeleteEventListenerByTaskId(DeleteEventListenerByTaskIdRequest req)
        {
            return InternalRequestAsync<DeleteEventListenerByTaskIdResponse>(req, "DeleteEventListenerByTaskId");
        }

        /// <summary>
        /// 通过任务ID删除所有事件
        /// </summary>
        /// <param name="req"><see cref="DeleteEventListenerByTaskIdRequest"/></param>
        /// <returns><see cref="DeleteEventListenerByTaskIdResponse"/></returns>
        public DeleteEventListenerByTaskIdResponse DeleteEventListenerByTaskIdSync(DeleteEventListenerByTaskIdRequest req)
        {
            return InternalRequestAsync<DeleteEventListenerByTaskIdResponse>(req, "DeleteEventListenerByTaskId")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public DeleteFolderResponse DeleteFolderSync(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除采集器
        /// </summary>
        /// <param name="req"><see cref="DeleteInLongAgentRequest"/></param>
        /// <returns><see cref="DeleteInLongAgentResponse"/></returns>
        public Task<DeleteInLongAgentResponse> DeleteInLongAgent(DeleteInLongAgentRequest req)
        {
            return InternalRequestAsync<DeleteInLongAgentResponse>(req, "DeleteInLongAgent");
        }

        /// <summary>
        /// 删除采集器
        /// </summary>
        /// <param name="req"><see cref="DeleteInLongAgentRequest"/></param>
        /// <returns><see cref="DeleteInLongAgentResponse"/></returns>
        public DeleteInLongAgentResponse DeleteInLongAgentSync(DeleteInLongAgentRequest req)
        {
            return InternalRequestAsync<DeleteInLongAgentResponse>(req, "DeleteInLongAgent")
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
        /// 删除任务连接
        /// </summary>
        /// <param name="req"><see cref="DeleteLinkRequest"/></param>
        /// <returns><see cref="DeleteLinkResponse"/></returns>
        public Task<DeleteLinkResponse> DeleteLink(DeleteLinkRequest req)
        {
            return InternalRequestAsync<DeleteLinkResponse>(req, "DeleteLink");
        }

        /// <summary>
        /// 删除任务连接
        /// </summary>
        /// <param name="req"><see cref="DeleteLinkRequest"/></param>
        /// <returns><see cref="DeleteLinkResponse"/></returns>
        public DeleteLinkResponse DeleteLinkSync(DeleteLinkRequest req)
        {
            return InternalRequestAsync<DeleteLinkResponse>(req, "DeleteLink")
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
        /// 删除项目参数版本
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamVersionDsResponse"/></returns>
        public Task<DeleteProjectParamVersionDsResponse> DeleteProjectParamVersionDs(DeleteProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamVersionDsResponse>(req, "DeleteProjectParamVersionDs");
        }

        /// <summary>
        /// 删除项目参数版本
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="DeleteProjectParamVersionDsResponse"/></returns>
        public DeleteProjectParamVersionDsResponse DeleteProjectParamVersionDsSync(DeleteProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<DeleteProjectParamVersionDsResponse>(req, "DeleteProjectParamVersionDs")
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
        /// 批量删除任务提交记录列表
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordListRequest"/></param>
        /// <returns><see cref="DeleteRecordListResponse"/></returns>
        public Task<DeleteRecordListResponse> DeleteRecordList(DeleteRecordListRequest req)
        {
            return InternalRequestAsync<DeleteRecordListResponse>(req, "DeleteRecordList");
        }

        /// <summary>
        /// 批量删除任务提交记录列表
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordListRequest"/></param>
        /// <returns><see cref="DeleteRecordListResponse"/></returns>
        public DeleteRecordListResponse DeleteRecordListSync(DeleteRecordListRequest req)
        {
            return InternalRequestAsync<DeleteRecordListResponse>(req, "DeleteRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除回收站任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecycleTaskRequest"/></param>
        /// <returns><see cref="DeleteRecycleTaskResponse"/></returns>
        public Task<DeleteRecycleTaskResponse> DeleteRecycleTask(DeleteRecycleTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecycleTaskResponse>(req, "DeleteRecycleTask");
        }

        /// <summary>
        /// 删除回收站任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecycleTaskRequest"/></param>
        /// <returns><see cref="DeleteRecycleTaskResponse"/></returns>
        public DeleteRecycleTaskResponse DeleteRecycleTaskSync(DeleteRecycleTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecycleTaskResponse>(req, "DeleteRecycleTask")
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
        /// 资源管理-删除资源目录
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcePathRequest"/></param>
        /// <returns><see cref="DeleteResourcePathResponse"/></returns>
        public Task<DeleteResourcePathResponse> DeleteResourcePath(DeleteResourcePathRequest req)
        {
            return InternalRequestAsync<DeleteResourcePathResponse>(req, "DeleteResourcePath");
        }

        /// <summary>
        /// 资源管理-删除资源目录
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcePathRequest"/></param>
        /// <returns><see cref="DeleteResourcePathResponse"/></returns>
        public DeleteResourcePathResponse DeleteResourcePathSync(DeleteResourcePathRequest req)
        {
            return InternalRequestAsync<DeleteResourcePathResponse>(req, "DeleteResourcePath")
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
        /// 删除规则模版
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleTemplateRequest"/></param>
        /// <returns><see cref="DeleteRuleTemplateResponse"/></returns>
        public Task<DeleteRuleTemplateResponse> DeleteRuleTemplate(DeleteRuleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRuleTemplateResponse>(req, "DeleteRuleTemplate");
        }

        /// <summary>
        /// 删除规则模版
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
        /// 删除任务Ds
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public Task<DeleteTaskDsResponse> DeleteTaskDs(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs");
        }

        /// <summary>
        /// 删除任务Ds
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskDsRequest"/></param>
        /// <returns><see cref="DeleteTaskDsResponse"/></returns>
        public DeleteTaskDsResponse DeleteTaskDsSync(DeleteTaskDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskDsResponse>(req, "DeleteTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-工作流-删除任务文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskFolderRequest"/></param>
        /// <returns><see cref="DeleteTaskFolderResponse"/></returns>
        public Task<DeleteTaskFolderResponse> DeleteTaskFolder(DeleteTaskFolderRequest req)
        {
            return InternalRequestAsync<DeleteTaskFolderResponse>(req, "DeleteTaskFolder");
        }

        /// <summary>
        /// 编排空间-工作流-删除任务文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskFolderRequest"/></param>
        /// <returns><see cref="DeleteTaskFolderResponse"/></returns>
        public DeleteTaskFolderResponse DeleteTaskFolderSync(DeleteTaskFolderRequest req)
        {
            return InternalRequestAsync<DeleteTaskFolderResponse>(req, "DeleteTaskFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务输入参数
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskInParamDsRequest"/></param>
        /// <returns><see cref="DeleteTaskInParamDsResponse"/></returns>
        public Task<DeleteTaskInParamDsResponse> DeleteTaskInParamDs(DeleteTaskInParamDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskInParamDsResponse>(req, "DeleteTaskInParamDs");
        }

        /// <summary>
        /// 删除任务输入参数
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskInParamDsRequest"/></param>
        /// <returns><see cref="DeleteTaskInParamDsResponse"/></returns>
        public DeleteTaskInParamDsResponse DeleteTaskInParamDsSync(DeleteTaskInParamDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskInParamDsResponse>(req, "DeleteTaskInParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务输出参数
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskOutParamDsRequest"/></param>
        /// <returns><see cref="DeleteTaskOutParamDsResponse"/></returns>
        public Task<DeleteTaskOutParamDsResponse> DeleteTaskOutParamDs(DeleteTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskOutParamDsResponse>(req, "DeleteTaskOutParamDs");
        }

        /// <summary>
        /// 删除任务输出参数
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskOutParamDsRequest"/></param>
        /// <returns><see cref="DeleteTaskOutParamDsResponse"/></returns>
        public DeleteTaskOutParamDsResponse DeleteTaskOutParamDsSync(DeleteTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<DeleteTaskOutParamDsResponse>(req, "DeleteTaskOutParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除产出登记项
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskOutputRegistryRequest"/></param>
        /// <returns><see cref="DeleteTaskOutputRegistryResponse"/></returns>
        public Task<DeleteTaskOutputRegistryResponse> DeleteTaskOutputRegistry(DeleteTaskOutputRegistryRequest req)
        {
            return InternalRequestAsync<DeleteTaskOutputRegistryResponse>(req, "DeleteTaskOutputRegistry");
        }

        /// <summary>
        /// 删除产出登记项
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskOutputRegistryRequest"/></param>
        /// <returns><see cref="DeleteTaskOutputRegistryResponse"/></returns>
        public DeleteTaskOutputRegistryResponse DeleteTaskOutputRegistrySync(DeleteTaskOutputRegistryRequest req)
        {
            return InternalRequestAsync<DeleteTaskOutputRegistryResponse>(req, "DeleteTaskOutputRegistry")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public Task<DeleteWorkflowNewResponse> DeleteWorkflowNew(DeleteWorkflowNewRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowNewResponse>(req, "DeleteWorkflowNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public DeleteWorkflowNewResponse DeleteWorkflowNewSync(DeleteWorkflowNewRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowNewResponse>(req, "DeleteWorkflowNew")
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
        /// 查询所有参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAllParamDsRequest"/></param>
        /// <returns><see cref="DescribeAllParamDsResponse"/></returns>
        public Task<DescribeAllParamDsResponse> DescribeAllParamDs(DescribeAllParamDsRequest req)
        {
            return InternalRequestAsync<DescribeAllParamDsResponse>(req, "DescribeAllParamDs");
        }

        /// <summary>
        /// 查询所有参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAllParamDsRequest"/></param>
        /// <returns><see cref="DescribeAllParamDsResponse"/></returns>
        public DescribeAllParamDsResponse DescribeAllParamDsSync(DescribeAllParamDsRequest req)
        {
            return InternalRequestAsync<DescribeAllParamDsResponse>(req, "DescribeAllParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeAllTaskTypeResponse"/></returns>
        public Task<DescribeAllTaskTypeResponse> DescribeAllTaskType(DescribeAllTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeAllTaskTypeResponse>(req, "DescribeAllTaskType");
        }

        /// <summary>
        /// 获取所有任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeAllTaskTypeResponse"/></returns>
        public DescribeAllTaskTypeResponse DescribeAllTaskTypeSync(DescribeAllTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeAllTaskTypeResponse>(req, "DescribeAllTaskType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务Id查找生产态子任务
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUsedVersionSonRequest"/></param>
        /// <returns><see cref="DescribeAllUsedVersionSonResponse"/></returns>
        public Task<DescribeAllUsedVersionSonResponse> DescribeAllUsedVersionSon(DescribeAllUsedVersionSonRequest req)
        {
            return InternalRequestAsync<DescribeAllUsedVersionSonResponse>(req, "DescribeAllUsedVersionSon");
        }

        /// <summary>
        /// 根据任务Id查找生产态子任务
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUsedVersionSonRequest"/></param>
        /// <returns><see cref="DescribeAllUsedVersionSonResponse"/></returns>
        public DescribeAllUsedVersionSonResponse DescribeAllUsedVersionSonSync(DescribeAllUsedVersionSonRequest req)
        {
            return InternalRequestAsync<DescribeAllUsedVersionSonResponse>(req, "DescribeAllUsedVersionSon")
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
        /// 查询基线DAG
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAllTaskDagRequest"/></param>
        /// <returns><see cref="DescribeBaselineAllTaskDagResponse"/></returns>
        public Task<DescribeBaselineAllTaskDagResponse> DescribeBaselineAllTaskDag(DescribeBaselineAllTaskDagRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAllTaskDagResponse>(req, "DescribeBaselineAllTaskDag");
        }

        /// <summary>
        /// 查询基线DAG
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAllTaskDagRequest"/></param>
        /// <returns><see cref="DescribeBaselineAllTaskDagResponse"/></returns>
        public DescribeBaselineAllTaskDagResponse DescribeBaselineAllTaskDagSync(DescribeBaselineAllTaskDagRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAllTaskDagResponse>(req, "DescribeBaselineAllTaskDag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基线列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineByIdRequest"/></param>
        /// <returns><see cref="DescribeBaselineByIdResponse"/></returns>
        public Task<DescribeBaselineByIdResponse> DescribeBaselineById(DescribeBaselineByIdRequest req)
        {
            return InternalRequestAsync<DescribeBaselineByIdResponse>(req, "DescribeBaselineById");
        }

        /// <summary>
        /// 基线列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineByIdRequest"/></param>
        /// <returns><see cref="DescribeBaselineByIdResponse"/></returns>
        public DescribeBaselineByIdResponse DescribeBaselineByIdSync(DescribeBaselineByIdRequest req)
        {
            return InternalRequestAsync<DescribeBaselineByIdResponse>(req, "DescribeBaselineById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询基线实例DAG
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstanceDagRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstanceDagResponse"/></returns>
        public Task<DescribeBaselineInstanceDagResponse> DescribeBaselineInstanceDag(DescribeBaselineInstanceDagRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstanceDagResponse>(req, "DescribeBaselineInstanceDag");
        }

        /// <summary>
        /// 查询基线实例DAG
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstanceDagRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstanceDagResponse"/></returns>
        public DescribeBaselineInstanceDagResponse DescribeBaselineInstanceDagSync(DescribeBaselineInstanceDagRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstanceDagResponse>(req, "DescribeBaselineInstanceDag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询基线实例关键任务实例甘特图
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstanceGanttRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstanceGanttResponse"/></returns>
        public Task<DescribeBaselineInstanceGanttResponse> DescribeBaselineInstanceGantt(DescribeBaselineInstanceGanttRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstanceGanttResponse>(req, "DescribeBaselineInstanceGantt");
        }

        /// <summary>
        /// 查询基线实例关键任务实例甘特图
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstanceGanttRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstanceGanttResponse"/></returns>
        public DescribeBaselineInstanceGanttResponse DescribeBaselineInstanceGanttSync(DescribeBaselineInstanceGanttRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstanceGanttResponse>(req, "DescribeBaselineInstanceGantt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询基线实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstancesRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstancesResponse"/></returns>
        public Task<DescribeBaselineInstancesResponse> DescribeBaselineInstances(DescribeBaselineInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstancesResponse>(req, "DescribeBaselineInstances");
        }

        /// <summary>
        /// 查询基线实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineInstancesRequest"/></param>
        /// <returns><see cref="DescribeBaselineInstancesResponse"/></returns>
        public DescribeBaselineInstancesResponse DescribeBaselineInstancesSync(DescribeBaselineInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBaselineInstancesResponse>(req, "DescribeBaselineInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基线列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinesRequest"/></param>
        /// <returns><see cref="DescribeBaselinesResponse"/></returns>
        public Task<DescribeBaselinesResponse> DescribeBaselines(DescribeBaselinesRequest req)
        {
            return InternalRequestAsync<DescribeBaselinesResponse>(req, "DescribeBaselines");
        }

        /// <summary>
        /// 基线列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinesRequest"/></param>
        /// <returns><see cref="DescribeBaselinesResponse"/></returns>
        public DescribeBaselinesResponse DescribeBaselinesSync(DescribeBaselinesRequest req)
        {
            return InternalRequestAsync<DescribeBaselinesResponse>(req, "DescribeBaselines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量操作任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public Task<DescribeBatchOperateTaskResponse> DescribeBatchOperateTask(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask");
        }

        /// <summary>
        /// 批量操作任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperateTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchOperateTaskResponse"/></returns>
        public DescribeBatchOperateTaskResponse DescribeBatchOperateTaskSync(DescribeBatchOperateTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperateTaskResponse>(req, "DescribeBatchOperateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取etl测试运行任务执行状态和日志
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTestRunRequest"/></param>
        /// <returns><see cref="DescribeBatchTestRunResponse"/></returns>
        public Task<DescribeBatchTestRunResponse> DescribeBatchTestRun(DescribeBatchTestRunRequest req)
        {
            return InternalRequestAsync<DescribeBatchTestRunResponse>(req, "DescribeBatchTestRun");
        }

        /// <summary>
        /// 批量获取etl测试运行任务执行状态和日志
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTestRunRequest"/></param>
        /// <returns><see cref="DescribeBatchTestRunResponse"/></returns>
        public DescribeBatchTestRunResponse DescribeBatchTestRunSync(DescribeBatchTestRunRequest req)
        {
            return InternalRequestAsync<DescribeBatchTestRunResponse>(req, "DescribeBatchTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能运维-事件列表-所属任务/基线过滤列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBelongToRequest"/></param>
        /// <returns><see cref="DescribeBelongToResponse"/></returns>
        public Task<DescribeBelongToResponse> DescribeBelongTo(DescribeBelongToRequest req)
        {
            return InternalRequestAsync<DescribeBelongToResponse>(req, "DescribeBelongTo");
        }

        /// <summary>
        /// 智能运维-事件列表-所属任务/基线过滤列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBelongToRequest"/></param>
        /// <returns><see cref="DescribeBelongToResponse"/></returns>
        public DescribeBelongToResponse DescribeBelongToSync(DescribeBelongToRequest req)
        {
            return InternalRequestAsync<DescribeBelongToResponse>(req, "DescribeBelongTo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户数据开发浏览历史
        /// </summary>
        /// <param name="req"><see cref="DescribeBrowsingHistoriesRequest"/></param>
        /// <returns><see cref="DescribeBrowsingHistoriesResponse"/></returns>
        public Task<DescribeBrowsingHistoriesResponse> DescribeBrowsingHistories(DescribeBrowsingHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeBrowsingHistoriesResponse>(req, "DescribeBrowsingHistories");
        }

        /// <summary>
        /// 查询用户数据开发浏览历史
        /// </summary>
        /// <param name="req"><see cref="DescribeBrowsingHistoriesRequest"/></param>
        /// <returns><see cref="DescribeBrowsingHistoriesResponse"/></returns>
        public DescribeBrowsingHistoriesResponse DescribeBrowsingHistoriesSync(DescribeBrowsingHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeBrowsingHistoriesResponse>(req, "DescribeBrowsingHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询子任务信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeChildrenDsRequest"/></param>
        /// <returns><see cref="DescribeChildrenDsResponse"/></returns>
        public Task<DescribeChildrenDsResponse> DescribeChildrenDs(DescribeChildrenDsRequest req)
        {
            return InternalRequestAsync<DescribeChildrenDsResponse>(req, "DescribeChildrenDs");
        }

        /// <summary>
        /// 查询子任务信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeChildrenDsRequest"/></param>
        /// <returns><see cref="DescribeChildrenDsResponse"/></returns>
        public DescribeChildrenDsResponse DescribeChildrenDsSync(DescribeChildrenDsRequest req)
        {
            return InternalRequestAsync<DescribeChildrenDsResponse>(req, "DescribeChildrenDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发空间-拉取指定路径目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeChildrenPathTreesRequest"/></param>
        /// <returns><see cref="DescribeChildrenPathTreesResponse"/></returns>
        public Task<DescribeChildrenPathTreesResponse> DescribeChildrenPathTrees(DescribeChildrenPathTreesRequest req)
        {
            return InternalRequestAsync<DescribeChildrenPathTreesResponse>(req, "DescribeChildrenPathTrees");
        }

        /// <summary>
        /// 开发空间-拉取指定路径目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeChildrenPathTreesRequest"/></param>
        /// <returns><see cref="DescribeChildrenPathTreesResponse"/></returns>
        public DescribeChildrenPathTreesResponse DescribeChildrenPathTreesSync(DescribeChildrenPathTreesRequest req)
        {
            return InternalRequestAsync<DescribeChildrenPathTreesResponse>(req, "DescribeChildrenPathTrees")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public Task<DescribeClusterNamespaceListResponse> DescribeClusterNamespaceList(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList");
        }

        /// <summary>
        /// 获取集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public DescribeClusterNamespaceListResponse DescribeClusterNamespaceListSync(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件或任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeDetailRequest"/></param>
        /// <returns><see cref="DescribeCodeDetailResponse"/></returns>
        public Task<DescribeCodeDetailResponse> DescribeCodeDetail(DescribeCodeDetailRequest req)
        {
            return InternalRequestAsync<DescribeCodeDetailResponse>(req, "DescribeCodeDetail");
        }

        /// <summary>
        /// 查询文件或任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeDetailRequest"/></param>
        /// <returns><see cref="DescribeCodeDetailResponse"/></returns>
        public DescribeCodeDetailResponse DescribeCodeDetailSync(DescribeCodeDetailRequest req)
        {
            return InternalRequestAsync<DescribeCodeDetailResponse>(req, "DescribeCodeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全局搜索查询文件或任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeDetailV2Request"/></param>
        /// <returns><see cref="DescribeCodeDetailV2Response"/></returns>
        public Task<DescribeCodeDetailV2Response> DescribeCodeDetailV2(DescribeCodeDetailV2Request req)
        {
            return InternalRequestAsync<DescribeCodeDetailV2Response>(req, "DescribeCodeDetailV2");
        }

        /// <summary>
        /// 全局搜索查询文件或任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeDetailV2Request"/></param>
        /// <returns><see cref="DescribeCodeDetailV2Response"/></returns>
        public DescribeCodeDetailV2Response DescribeCodeDetailV2Sync(DescribeCodeDetailV2Request req)
        {
            return InternalRequestAsync<DescribeCodeDetailV2Response>(req, "DescribeCodeDetailV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询最近5条代码搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchAuditInfoRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchAuditInfoResponse"/></returns>
        public Task<DescribeCodeSearchAuditInfoResponse> DescribeCodeSearchAuditInfo(DescribeCodeSearchAuditInfoRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchAuditInfoResponse>(req, "DescribeCodeSearchAuditInfo");
        }

        /// <summary>
        /// 查询最近5条代码搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchAuditInfoRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchAuditInfoResponse"/></returns>
        public DescribeCodeSearchAuditInfoResponse DescribeCodeSearchAuditInfoSync(DescribeCodeSearchAuditInfoRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchAuditInfoResponse>(req, "DescribeCodeSearchAuditInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取代码搜索最近n条关键字搜索信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchAuditInfoV2Request"/></param>
        /// <returns><see cref="DescribeCodeSearchAuditInfoV2Response"/></returns>
        public Task<DescribeCodeSearchAuditInfoV2Response> DescribeCodeSearchAuditInfoV2(DescribeCodeSearchAuditInfoV2Request req)
        {
            return InternalRequestAsync<DescribeCodeSearchAuditInfoV2Response>(req, "DescribeCodeSearchAuditInfoV2");
        }

        /// <summary>
        /// 获取代码搜索最近n条关键字搜索信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchAuditInfoV2Request"/></param>
        /// <returns><see cref="DescribeCodeSearchAuditInfoV2Response"/></returns>
        public DescribeCodeSearchAuditInfoV2Response DescribeCodeSearchAuditInfoV2Sync(DescribeCodeSearchAuditInfoV2Request req)
        {
            return InternalRequestAsync<DescribeCodeSearchAuditInfoV2Response>(req, "DescribeCodeSearchAuditInfoV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 代码搜索结果的统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchCountRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchCountResponse"/></returns>
        public Task<DescribeCodeSearchCountResponse> DescribeCodeSearchCount(DescribeCodeSearchCountRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchCountResponse>(req, "DescribeCodeSearchCount");
        }

        /// <summary>
        /// 代码搜索结果的统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchCountRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchCountResponse"/></returns>
        public DescribeCodeSearchCountResponse DescribeCodeSearchCountSync(DescribeCodeSearchCountRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchCountResponse>(req, "DescribeCodeSearchCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件搜索代码
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchInfoRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchInfoResponse"/></returns>
        public Task<DescribeCodeSearchInfoResponse> DescribeCodeSearchInfo(DescribeCodeSearchInfoRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchInfoResponse>(req, "DescribeCodeSearchInfo");
        }

        /// <summary>
        /// 根据条件搜索代码
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchInfoRequest"/></param>
        /// <returns><see cref="DescribeCodeSearchInfoResponse"/></returns>
        public DescribeCodeSearchInfoResponse DescribeCodeSearchInfoSync(DescribeCodeSearchInfoRequest req)
        {
            return InternalRequestAsync<DescribeCodeSearchInfoResponse>(req, "DescribeCodeSearchInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全局搜索根据条件搜索代码
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchInfoV2Request"/></param>
        /// <returns><see cref="DescribeCodeSearchInfoV2Response"/></returns>
        public Task<DescribeCodeSearchInfoV2Response> DescribeCodeSearchInfoV2(DescribeCodeSearchInfoV2Request req)
        {
            return InternalRequestAsync<DescribeCodeSearchInfoV2Response>(req, "DescribeCodeSearchInfoV2");
        }

        /// <summary>
        /// 全局搜索根据条件搜索代码
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeSearchInfoV2Request"/></param>
        /// <returns><see cref="DescribeCodeSearchInfoV2Response"/></returns>
        public DescribeCodeSearchInfoV2Response DescribeCodeSearchInfoV2Sync(DescribeCodeSearchInfoV2Request req)
        {
            return InternalRequestAsync<DescribeCodeSearchInfoV2Response>(req, "DescribeCodeSearchInfoV2")
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
        /// 获取 crontab topN 个数据时间周期
        /// </summary>
        /// <param name="req"><see cref="DescribeCrontabTopNDsRequest"/></param>
        /// <returns><see cref="DescribeCrontabTopNDsResponse"/></returns>
        public Task<DescribeCrontabTopNDsResponse> DescribeCrontabTopNDs(DescribeCrontabTopNDsRequest req)
        {
            return InternalRequestAsync<DescribeCrontabTopNDsResponse>(req, "DescribeCrontabTopNDs");
        }

        /// <summary>
        /// 获取 crontab topN 个数据时间周期
        /// </summary>
        /// <param name="req"><see cref="DescribeCrontabTopNDsRequest"/></param>
        /// <returns><see cref="DescribeCrontabTopNDsResponse"/></returns>
        public DescribeCrontabTopNDsResponse DescribeCrontabTopNDsSync(DescribeCrontabTopNDsRequest req)
        {
            return InternalRequestAsync<DescribeCrontabTopNDsResponse>(req, "DescribeCrontabTopNDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询函数版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeCustomFunctionVersionListResponse"/></returns>
        public Task<DescribeCustomFunctionVersionListResponse> DescribeCustomFunctionVersionList(DescribeCustomFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCustomFunctionVersionListResponse>(req, "DescribeCustomFunctionVersionList");
        }

        /// <summary>
        /// 查询函数版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeCustomFunctionVersionListResponse"/></returns>
        public DescribeCustomFunctionVersionListResponse DescribeCustomFunctionVersionListSync(DescribeCustomFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCustomFunctionVersionListResponse>(req, "DescribeCustomFunctionVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据来源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBasesRequest"/></param>
        /// <returns><see cref="DescribeDataBasesResponse"/></returns>
        public Task<DescribeDataBasesResponse> DescribeDataBases(DescribeDataBasesRequest req)
        {
            return InternalRequestAsync<DescribeDataBasesResponse>(req, "DescribeDataBases");
        }

        /// <summary>
        /// 查询数据来源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBasesRequest"/></param>
        /// <returns><see cref="DescribeDataBasesResponse"/></returns>
        public DescribeDataBasesResponse DescribeDataBasesSync(DescribeDataBasesRequest req)
        {
            return InternalRequestAsync<DescribeDataBasesResponse>(req, "DescribeDataBases")
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
        /// 获取数据开发任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDataDevelopTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeDataDevelopTaskTypeResponse"/></returns>
        public Task<DescribeDataDevelopTaskTypeResponse> DescribeDataDevelopTaskType(DescribeDataDevelopTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeDataDevelopTaskTypeResponse>(req, "DescribeDataDevelopTaskType");
        }

        /// <summary>
        /// 获取数据开发任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDataDevelopTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeDataDevelopTaskTypeResponse"/></returns>
        public DescribeDataDevelopTaskTypeResponse DescribeDataDevelopTaskTypeSync(DescribeDataDevelopTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeDataDevelopTaskTypeResponse>(req, "DescribeDataDevelopTaskType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则组数据对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataObjectsRequest"/></param>
        /// <returns><see cref="DescribeDataObjectsResponse"/></returns>
        public Task<DescribeDataObjectsResponse> DescribeDataObjects(DescribeDataObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDataObjectsResponse>(req, "DescribeDataObjects");
        }

        /// <summary>
        /// 查询规则组数据对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataObjectsRequest"/></param>
        /// <returns><see cref="DescribeDataObjectsResponse"/></returns>
        public DescribeDataObjectsResponse DescribeDataObjectsSync(DescribeDataObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDataObjectsResponse>(req, "DescribeDataObjects")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceListResponse>(req, "DescribeDataSourceList");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public Task<DescribeDataSourceWithoutInfoResponse> DescribeDataSourceWithoutInfo(DescribeDataSourceWithoutInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceWithoutInfoResponse>(req, "DescribeDataSourceWithoutInfo");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public DescribeDataSourceWithoutInfoResponse DescribeDataSourceWithoutInfoSync(DescribeDataSourceWithoutInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceWithoutInfoResponse>(req, "DescribeDataSourceWithoutInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据表导入状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTableImportProgressRequest"/></param>
        /// <returns><see cref="DescribeDataTableImportProgressResponse"/></returns>
        public Task<DescribeDataTableImportProgressResponse> DescribeDataTableImportProgress(DescribeDataTableImportProgressRequest req)
        {
            return InternalRequestAsync<DescribeDataTableImportProgressResponse>(req, "DescribeDataTableImportProgress");
        }

        /// <summary>
        /// 获取数据表导入状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTableImportProgressRequest"/></param>
        /// <returns><see cref="DescribeDataTableImportProgressResponse"/></returns>
        public DescribeDataTableImportProgressResponse DescribeDataTableImportProgressSync(DescribeDataTableImportProgressRequest req)
        {
            return InternalRequestAsync<DescribeDataTableImportProgressResponse>(req, "DescribeDataTableImportProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取字段类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTypesRequest"/></param>
        /// <returns><see cref="DescribeDataTypesResponse"/></returns>
        public Task<DescribeDataTypesResponse> DescribeDataTypes(DescribeDataTypesRequest req)
        {
            return InternalRequestAsync<DescribeDataTypesResponse>(req, "DescribeDataTypes");
        }

        /// <summary>
        /// 获取字段类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTypesRequest"/></param>
        /// <returns><see cref="DescribeDataTypesResponse"/></returns>
        public DescribeDataTypesResponse DescribeDataTypesSync(DescribeDataTypesRequest req)
        {
            return InternalRequestAsync<DescribeDataTypesResponse>(req, "DescribeDataTypes")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public Task<DescribeDatasourceResponse> DescribeDatasource(DescribeDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceResponse>(req, "DescribeDatasource");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 根据任务id获取下游依赖任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTaskListRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTaskListResponse"/></returns>
        public Task<DescribeDependOpsTaskListResponse> DescribeDependOpsTaskList(DescribeDependOpsTaskListRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTaskListResponse>(req, "DescribeDependOpsTaskList");
        }

        /// <summary>
        /// 根据任务id获取下游依赖任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDependOpsTaskListRequest"/></param>
        /// <returns><see cref="DescribeDependOpsTaskListResponse"/></returns>
        public DescribeDependOpsTaskListResponse DescribeDependOpsTaskListSync(DescribeDependOpsTaskListRequest req)
        {
            return InternalRequestAsync<DescribeDependOpsTaskListResponse>(req, "DescribeDependOpsTaskList")
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
        /// 根据层级查找开发态上下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksDevDsRequest"/></param>
        /// <returns><see cref="DescribeDependTasksDevDsResponse"/></returns>
        public Task<DescribeDependTasksDevDsResponse> DescribeDependTasksDevDs(DescribeDependTasksDevDsRequest req)
        {
            return InternalRequestAsync<DescribeDependTasksDevDsResponse>(req, "DescribeDependTasksDevDs");
        }

        /// <summary>
        /// 根据层级查找开发态上下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksDevDsRequest"/></param>
        /// <returns><see cref="DescribeDependTasksDevDsResponse"/></returns>
        public DescribeDependTasksDevDsResponse DescribeDependTasksDevDsSync(DescribeDependTasksDevDsRequest req)
        {
            return InternalRequestAsync<DescribeDependTasksDevDsResponse>(req, "DescribeDependTasksDevDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public Task<DescribeDependTasksNewResponse> DescribeDependTasksNew(DescribeDependTasksNewRequest req)
        {
            return InternalRequestAsync<DescribeDependTasksNewResponse>(req, "DescribeDependTasksNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public DescribeDependTasksNewResponse DescribeDependTasksNewSync(DescribeDependTasksNewRequest req)
        {
            return InternalRequestAsync<DescribeDependTasksNewResponse>(req, "DescribeDependTasksNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 【项目克隆任务模式】依赖任务信息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDependencyTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeDependencyTasksForProjectCloneResponse"/></returns>
        public Task<DescribeDependencyTasksForProjectCloneResponse> DescribeDependencyTasksForProjectClone(DescribeDependencyTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeDependencyTasksForProjectCloneResponse>(req, "DescribeDependencyTasksForProjectClone");
        }

        /// <summary>
        /// 【项目克隆任务模式】依赖任务信息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDependencyTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeDependencyTasksForProjectCloneResponse"/></returns>
        public DescribeDependencyTasksForProjectCloneResponse DescribeDependencyTasksForProjectCloneSync(DescribeDependencyTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeDependencyTasksForProjectCloneResponse>(req, "DescribeDependencyTasksForProjectClone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询依赖工作流信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeDependencyWorkflowForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeDependencyWorkflowForProjectCloneResponse"/></returns>
        public Task<DescribeDependencyWorkflowForProjectCloneResponse> DescribeDependencyWorkflowForProjectClone(DescribeDependencyWorkflowForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeDependencyWorkflowForProjectCloneResponse>(req, "DescribeDependencyWorkflowForProjectClone");
        }

        /// <summary>
        /// 查询依赖工作流信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeDependencyWorkflowForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeDependencyWorkflowForProjectCloneResponse"/></returns>
        public DescribeDependencyWorkflowForProjectCloneResponse DescribeDependencyWorkflowForProjectCloneSync(DescribeDependencyWorkflowForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeDependencyWorkflowForProjectCloneResponse>(req, "DescribeDependencyWorkflowForProjectClone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取开发空间支持的脚本类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDevelopmentSpaceSupportTypeRequest"/></param>
        /// <returns><see cref="DescribeDevelopmentSpaceSupportTypeResponse"/></returns>
        public Task<DescribeDevelopmentSpaceSupportTypeResponse> DescribeDevelopmentSpaceSupportType(DescribeDevelopmentSpaceSupportTypeRequest req)
        {
            return InternalRequestAsync<DescribeDevelopmentSpaceSupportTypeResponse>(req, "DescribeDevelopmentSpaceSupportType");
        }

        /// <summary>
        /// 获取开发空间支持的脚本类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDevelopmentSpaceSupportTypeRequest"/></param>
        /// <returns><see cref="DescribeDevelopmentSpaceSupportTypeResponse"/></returns>
        public DescribeDevelopmentSpaceSupportTypeResponse DescribeDevelopmentSpaceSupportTypeSync(DescribeDevelopmentSpaceSupportTypeRequest req)
        {
            return InternalRequestAsync<DescribeDevelopmentSpaceSupportTypeResponse>(req, "DescribeDevelopmentSpaceSupportType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询基线诊断信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnosticInfoByBaselineIdRequest"/></param>
        /// <returns><see cref="DescribeDiagnosticInfoByBaselineIdResponse"/></returns>
        public Task<DescribeDiagnosticInfoByBaselineIdResponse> DescribeDiagnosticInfoByBaselineId(DescribeDiagnosticInfoByBaselineIdRequest req)
        {
            return InternalRequestAsync<DescribeDiagnosticInfoByBaselineIdResponse>(req, "DescribeDiagnosticInfoByBaselineId");
        }

        /// <summary>
        /// 查询基线诊断信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnosticInfoByBaselineIdRequest"/></param>
        /// <returns><see cref="DescribeDiagnosticInfoByBaselineIdResponse"/></returns>
        public DescribeDiagnosticInfoByBaselineIdResponse DescribeDiagnosticInfoByBaselineIdSync(DescribeDiagnosticInfoByBaselineIdRequest req)
        {
            return InternalRequestAsync<DescribeDiagnosticInfoByBaselineIdResponse>(req, "DescribeDiagnosticInfoByBaselineId")
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
        /// 分页查询试运行实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstancePageRequest"/></param>
        /// <returns><see cref="DescribeDrInstancePageResponse"/></returns>
        public Task<DescribeDrInstancePageResponse> DescribeDrInstancePage(DescribeDrInstancePageRequest req)
        {
            return InternalRequestAsync<DescribeDrInstancePageResponse>(req, "DescribeDrInstancePage");
        }

        /// <summary>
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
        /// 查询试运行实例执行内容
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstanceScriptContentRequest"/></param>
        /// <returns><see cref="DescribeDrInstanceScriptContentResponse"/></returns>
        public Task<DescribeDrInstanceScriptContentResponse> DescribeDrInstanceScriptContent(DescribeDrInstanceScriptContentRequest req)
        {
            return InternalRequestAsync<DescribeDrInstanceScriptContentResponse>(req, "DescribeDrInstanceScriptContent");
        }

        /// <summary>
        /// 查询试运行实例执行内容
        /// </summary>
        /// <param name="req"><see cref="DescribeDrInstanceScriptContentRequest"/></param>
        /// <returns><see cref="DescribeDrInstanceScriptContentResponse"/></returns>
        public DescribeDrInstanceScriptContentResponse DescribeDrInstanceScriptContentSync(DescribeDrInstanceScriptContentRequest req)
        {
            return InternalRequestAsync<DescribeDrInstanceScriptContentResponse>(req, "DescribeDrInstanceScriptContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询试运行实例子实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrSonInstanceRequest"/></param>
        /// <returns><see cref="DescribeDrSonInstanceResponse"/></returns>
        public Task<DescribeDrSonInstanceResponse> DescribeDrSonInstance(DescribeDrSonInstanceRequest req)
        {
            return InternalRequestAsync<DescribeDrSonInstanceResponse>(req, "DescribeDrSonInstance");
        }

        /// <summary>
        /// 查询试运行实例子实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrSonInstanceRequest"/></param>
        /// <returns><see cref="DescribeDrSonInstanceResponse"/></returns>
        public DescribeDrSonInstanceResponse DescribeDrSonInstanceSync(DescribeDrSonInstanceRequest req)
        {
            return InternalRequestAsync<DescribeDrSonInstanceResponse>(req, "DescribeDrSonInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventRequest"/></param>
        /// <returns><see cref="DescribeDsEventResponse"/></returns>
        public Task<DescribeDsEventResponse> DescribeDsEvent(DescribeDsEventRequest req)
        {
            return InternalRequestAsync<DescribeDsEventResponse>(req, "DescribeDsEvent");
        }

        /// <summary>
        /// 分页查询事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventRequest"/></param>
        /// <returns><see cref="DescribeDsEventResponse"/></returns>
        public DescribeDsEventResponse DescribeDsEventSync(DescribeDsEventRequest req)
        {
            return InternalRequestAsync<DescribeDsEventResponse>(req, "DescribeDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件管理-查询事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDsEventDetailResponse"/></returns>
        public Task<DescribeDsEventDetailResponse> DescribeDsEventDetail(DescribeDsEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDsEventDetailResponse>(req, "DescribeDsEventDetail");
        }

        /// <summary>
        /// 事件管理-查询事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDsEventDetailResponse"/></returns>
        public DescribeDsEventDetailResponse DescribeDsEventDetailSync(DescribeDsEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDsEventDetailResponse>(req, "DescribeDsEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件监听者信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventListenerRequest"/></param>
        /// <returns><see cref="DescribeDsEventListenerResponse"/></returns>
        public Task<DescribeDsEventListenerResponse> DescribeDsEventListener(DescribeDsEventListenerRequest req)
        {
            return InternalRequestAsync<DescribeDsEventListenerResponse>(req, "DescribeDsEventListener");
        }

        /// <summary>
        /// 查询事件监听者信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventListenerRequest"/></param>
        /// <returns><see cref="DescribeDsEventListenerResponse"/></returns>
        public DescribeDsEventListenerResponse DescribeDsEventListenerSync(DescribeDsEventListenerRequest req)
        {
            return InternalRequestAsync<DescribeDsEventListenerResponse>(req, "DescribeDsEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件监听者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventListenerListRequest"/></param>
        /// <returns><see cref="DescribeDsEventListenerListResponse"/></returns>
        public Task<DescribeDsEventListenerListResponse> DescribeDsEventListenerList(DescribeDsEventListenerListRequest req)
        {
            return InternalRequestAsync<DescribeDsEventListenerListResponse>(req, "DescribeDsEventListenerList");
        }

        /// <summary>
        /// 查询事件监听者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventListenerListRequest"/></param>
        /// <returns><see cref="DescribeDsEventListenerListResponse"/></returns>
        public DescribeDsEventListenerListResponse DescribeDsEventListenerListSync(DescribeDsEventListenerListRequest req)
        {
            return InternalRequestAsync<DescribeDsEventListenerListResponse>(req, "DescribeDsEventListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件发布者信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventPublisherRequest"/></param>
        /// <returns><see cref="DescribeDsEventPublisherResponse"/></returns>
        public Task<DescribeDsEventPublisherResponse> DescribeDsEventPublisher(DescribeDsEventPublisherRequest req)
        {
            return InternalRequestAsync<DescribeDsEventPublisherResponse>(req, "DescribeDsEventPublisher");
        }

        /// <summary>
        /// 查询事件发布者信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventPublisherRequest"/></param>
        /// <returns><see cref="DescribeDsEventPublisherResponse"/></returns>
        public DescribeDsEventPublisherResponse DescribeDsEventPublisherSync(DescribeDsEventPublisherRequest req)
        {
            return InternalRequestAsync<DescribeDsEventPublisherResponse>(req, "DescribeDsEventPublisher")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件发布者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventPublisherListRequest"/></param>
        /// <returns><see cref="DescribeDsEventPublisherListResponse"/></returns>
        public Task<DescribeDsEventPublisherListResponse> DescribeDsEventPublisherList(DescribeDsEventPublisherListRequest req)
        {
            return InternalRequestAsync<DescribeDsEventPublisherListResponse>(req, "DescribeDsEventPublisherList");
        }

        /// <summary>
        /// 查询事件发布者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsEventPublisherListRequest"/></param>
        /// <returns><see cref="DescribeDsEventPublisherListResponse"/></returns>
        public DescribeDsEventPublisherListResponse DescribeDsEventPublisherListSync(DescribeDsEventPublisherListRequest req)
        {
            return InternalRequestAsync<DescribeDsEventPublisherListResponse>(req, "DescribeDsEventPublisherList")
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
        /// 查询 kettle 资源服务器目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeDsKettleServerFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsKettleServerFolderTreeResponse"/></returns>
        public Task<DescribeDsKettleServerFolderTreeResponse> DescribeDsKettleServerFolderTree(DescribeDsKettleServerFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsKettleServerFolderTreeResponse>(req, "DescribeDsKettleServerFolderTree");
        }

        /// <summary>
        /// 查询 kettle 资源服务器目录树
        /// </summary>
        /// <param name="req"><see cref="DescribeDsKettleServerFolderTreeRequest"/></param>
        /// <returns><see cref="DescribeDsKettleServerFolderTreeResponse"/></returns>
        public DescribeDsKettleServerFolderTreeResponse DescribeDsKettleServerFolderTreeSync(DescribeDsKettleServerFolderTreeRequest req)
        {
            return InternalRequestAsync<DescribeDsKettleServerFolderTreeResponse>(req, "DescribeDsKettleServerFolderTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务最新版本
        /// </summary>
        /// <param name="req"><see cref="DescribeDsLatestTaskVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeDsLatestTaskVersionInfoResponse"/></returns>
        public Task<DescribeDsLatestTaskVersionInfoResponse> DescribeDsLatestTaskVersionInfo(DescribeDsLatestTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeDsLatestTaskVersionInfoResponse>(req, "DescribeDsLatestTaskVersionInfo");
        }

        /// <summary>
        /// 获取任务最新版本
        /// </summary>
        /// <param name="req"><see cref="DescribeDsLatestTaskVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeDsLatestTaskVersionInfoResponse"/></returns>
        public DescribeDsLatestTaskVersionInfoResponse DescribeDsLatestTaskVersionInfoSync(DescribeDsLatestTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeDsLatestTaskVersionInfoResponse>(req, "DescribeDsLatestTaskVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据工作流id查询保存未提交任务
        /// </summary>
        /// <param name="req"><see cref="DescribeDsNotSubmitTasksAndCanRunByWorkflowRequest"/></param>
        /// <returns><see cref="DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse"/></returns>
        public Task<DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse> DescribeDsNotSubmitTasksAndCanRunByWorkflow(DescribeDsNotSubmitTasksAndCanRunByWorkflowRequest req)
        {
            return InternalRequestAsync<DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse>(req, "DescribeDsNotSubmitTasksAndCanRunByWorkflow");
        }

        /// <summary>
        /// 根据工作流id查询保存未提交任务
        /// </summary>
        /// <param name="req"><see cref="DescribeDsNotSubmitTasksAndCanRunByWorkflowRequest"/></param>
        /// <returns><see cref="DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse"/></returns>
        public DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse DescribeDsNotSubmitTasksAndCanRunByWorkflowSync(DescribeDsNotSubmitTasksAndCanRunByWorkflowRequest req)
        {
            return InternalRequestAsync<DescribeDsNotSubmitTasksAndCanRunByWorkflowResponse>(req, "DescribeDsNotSubmitTasksAndCanRunByWorkflow")
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
        /// 查看任务版本详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsTaskVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeDsTaskVersionInfoResponse"/></returns>
        public Task<DescribeDsTaskVersionInfoResponse> DescribeDsTaskVersionInfo(DescribeDsTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeDsTaskVersionInfoResponse>(req, "DescribeDsTaskVersionInfo");
        }

        /// <summary>
        /// 查看任务版本详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDsTaskVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeDsTaskVersionInfoResponse"/></returns>
        public DescribeDsTaskVersionInfoResponse DescribeDsTaskVersionInfoSync(DescribeDsTaskVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeDsTaskVersionInfoResponse>(req, "DescribeDsTaskVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取任务版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsTaskVersionListRequest"/></param>
        /// <returns><see cref="DescribeDsTaskVersionListResponse"/></returns>
        public Task<DescribeDsTaskVersionListResponse> DescribeDsTaskVersionList(DescribeDsTaskVersionListRequest req)
        {
            return InternalRequestAsync<DescribeDsTaskVersionListResponse>(req, "DescribeDsTaskVersionList");
        }

        /// <summary>
        /// 拉取任务版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDsTaskVersionListRequest"/></param>
        /// <returns><see cref="DescribeDsTaskVersionListResponse"/></returns>
        public DescribeDsTaskVersionListResponse DescribeDsTaskVersionListSync(DescribeDsTaskVersionListRequest req)
        {
            return InternalRequestAsync<DescribeDsTaskVersionListResponse>(req, "DescribeDsTaskVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据同步任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeEtlTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeEtlTaskTypeResponse"/></returns>
        public Task<DescribeEtlTaskTypeResponse> DescribeEtlTaskType(DescribeEtlTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeEtlTaskTypeResponse>(req, "DescribeEtlTaskType");
        }

        /// <summary>
        /// 获取数据同步任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeEtlTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeEtlTaskTypeResponse"/></returns>
        public DescribeEtlTaskTypeResponse DescribeEtlTaskTypeSync(DescribeEtlTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeEtlTaskTypeResponse>(req, "DescribeEtlTaskType")
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
        /// 智能运维事件详情1
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public Task<DescribeEventDetailResponse> DescribeEventDetail(DescribeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEventDetailResponse>(req, "DescribeEventDetail");
        }

        /// <summary>
        /// 智能运维事件详情1
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public DescribeEventDetailResponse DescribeEventDetailSync(DescribeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEventDetailResponse>(req, "DescribeEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件是否告警过滤条件
        /// </summary>
        /// <param name="req"><see cref="DescribeEventIsAlarmTypesRequest"/></param>
        /// <returns><see cref="DescribeEventIsAlarmTypesResponse"/></returns>
        public Task<DescribeEventIsAlarmTypesResponse> DescribeEventIsAlarmTypes(DescribeEventIsAlarmTypesRequest req)
        {
            return InternalRequestAsync<DescribeEventIsAlarmTypesResponse>(req, "DescribeEventIsAlarmTypes");
        }

        /// <summary>
        /// 事件是否告警过滤条件
        /// </summary>
        /// <param name="req"><see cref="DescribeEventIsAlarmTypesRequest"/></param>
        /// <returns><see cref="DescribeEventIsAlarmTypesResponse"/></returns>
        public DescribeEventIsAlarmTypesResponse DescribeEventIsAlarmTypesSync(DescribeEventIsAlarmTypesRequest req)
        {
            return InternalRequestAsync<DescribeEventIsAlarmTypesResponse>(req, "DescribeEventIsAlarmTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID获取任务监听事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListenerByTaskIdRequest"/></param>
        /// <returns><see cref="DescribeEventListenerByTaskIdResponse"/></returns>
        public Task<DescribeEventListenerByTaskIdResponse> DescribeEventListenerByTaskId(DescribeEventListenerByTaskIdRequest req)
        {
            return InternalRequestAsync<DescribeEventListenerByTaskIdResponse>(req, "DescribeEventListenerByTaskId");
        }

        /// <summary>
        /// 根据任务ID获取任务监听事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListenerByTaskIdRequest"/></param>
        /// <returns><see cref="DescribeEventListenerByTaskIdResponse"/></returns>
        public DescribeEventListenerByTaskIdResponse DescribeEventListenerByTaskIdSync(DescribeEventListenerByTaskIdRequest req)
        {
            return InternalRequestAsync<DescribeEventListenerByTaskIdResponse>(req, "DescribeEventListenerByTaskId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件管理-查询事件关联任务
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListenerTaskRequest"/></param>
        /// <returns><see cref="DescribeEventListenerTaskResponse"/></returns>
        public Task<DescribeEventListenerTaskResponse> DescribeEventListenerTask(DescribeEventListenerTaskRequest req)
        {
            return InternalRequestAsync<DescribeEventListenerTaskResponse>(req, "DescribeEventListenerTask");
        }

        /// <summary>
        /// 事件管理-查询事件关联任务
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListenerTaskRequest"/></param>
        /// <returns><see cref="DescribeEventListenerTaskResponse"/></returns>
        public DescribeEventListenerTaskResponse DescribeEventListenerTaskSync(DescribeEventListenerTaskRequest req)
        {
            return InternalRequestAsync<DescribeEventListenerTaskResponse>(req, "DescribeEventListenerTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEventTypesRequest"/></param>
        /// <returns><see cref="DescribeEventTypesResponse"/></returns>
        public Task<DescribeEventTypesResponse> DescribeEventTypes(DescribeEventTypesRequest req)
        {
            return InternalRequestAsync<DescribeEventTypesResponse>(req, "DescribeEventTypes");
        }

        /// <summary>
        /// 查询事件类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEventTypesRequest"/></param>
        /// <returns><see cref="DescribeEventTypesResponse"/></returns>
        public DescribeEventTypesResponse DescribeEventTypesSync(DescribeEventTypesRequest req)
        {
            return InternalRequestAsync<DescribeEventTypesResponse>(req, "DescribeEventTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能运维事件查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents");
        }

        /// <summary>
        /// 智能运维事件查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents")
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
        /// 获取执行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionLogRequest"/></param>
        /// <returns><see cref="DescribeExecutionLogResponse"/></returns>
        public Task<DescribeExecutionLogResponse> DescribeExecutionLog(DescribeExecutionLogRequest req)
        {
            return InternalRequestAsync<DescribeExecutionLogResponse>(req, "DescribeExecutionLog");
        }

        /// <summary>
        /// 获取执行日志
        /// </summary>
        /// <param name="req"><see cref="DescribeExecutionLogRequest"/></param>
        /// <returns><see cref="DescribeExecutionLogResponse"/></returns>
        public DescribeExecutionLogResponse DescribeExecutionLogSync(DescribeExecutionLogRequest req)
        {
            return InternalRequestAsync<DescribeExecutionLogResponse>(req, "DescribeExecutionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询父任务数据源信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeFatherDatasourceInfoDsRequest"/></param>
        /// <returns><see cref="DescribeFatherDatasourceInfoDsResponse"/></returns>
        public Task<DescribeFatherDatasourceInfoDsResponse> DescribeFatherDatasourceInfoDs(DescribeFatherDatasourceInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeFatherDatasourceInfoDsResponse>(req, "DescribeFatherDatasourceInfoDs");
        }

        /// <summary>
        /// 查询父任务数据源信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeFatherDatasourceInfoDsRequest"/></param>
        /// <returns><see cref="DescribeFatherDatasourceInfoDsResponse"/></returns>
        public DescribeFatherDatasourceInfoDsResponse DescribeFatherDatasourceInfoDsSync(DescribeFatherDatasourceInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeFatherDatasourceInfoDsResponse>(req, "DescribeFatherDatasourceInfoDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取关联父实例
        /// </summary>
        /// <param name="req"><see cref="DescribeFathersRequest"/></param>
        /// <returns><see cref="DescribeFathersResponse"/></returns>
        public Task<DescribeFathersResponse> DescribeFathers(DescribeFathersRequest req)
        {
            return InternalRequestAsync<DescribeFathersResponse>(req, "DescribeFathers");
        }

        /// <summary>
        /// 获取关联父实例
        /// </summary>
        /// <param name="req"><see cref="DescribeFathersRequest"/></param>
        /// <returns><see cref="DescribeFathersResponse"/></returns>
        public DescribeFathersResponse DescribeFathersSync(DescribeFathersRequest req)
        {
            return InternalRequestAsync<DescribeFathersResponse>(req, "DescribeFathers")
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
        /// 查询开发空间版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileVersionsRequest"/></param>
        /// <returns><see cref="DescribeFileVersionsResponse"/></returns>
        public Task<DescribeFileVersionsResponse> DescribeFileVersions(DescribeFileVersionsRequest req)
        {
            return InternalRequestAsync<DescribeFileVersionsResponse>(req, "DescribeFileVersions");
        }

        /// <summary>
        /// 查询开发空间版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileVersionsRequest"/></param>
        /// <returns><see cref="DescribeFileVersionsResponse"/></returns>
        public DescribeFileVersionsResponse DescribeFileVersionsSync(DescribeFileVersionsRequest req)
        {
            return InternalRequestAsync<DescribeFileVersionsResponse>(req, "DescribeFileVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public Task<DescribeFolderListResponse> DescribeFolderList(DescribeFolderListRequest req)
        {
            return InternalRequestAsync<DescribeFolderListResponse>(req, "DescribeFolderList");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public DescribeFolderListResponse DescribeFolderListSync(DescribeFolderListRequest req)
        {
            return InternalRequestAsync<DescribeFolderListResponse>(req, "DescribeFolderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public Task<DescribeFolderWorkflowListResponse> DescribeFolderWorkflowList(DescribeFolderWorkflowListRequest req)
        {
            return InternalRequestAsync<DescribeFolderWorkflowListResponse>(req, "DescribeFolderWorkflowList");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
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
        /// 获取全局工作流信息，用于跨工作流节点拉取租户所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalWorkflowDsRequest"/></param>
        /// <returns><see cref="DescribeGlobalWorkflowDsResponse"/></returns>
        public Task<DescribeGlobalWorkflowDsResponse> DescribeGlobalWorkflowDs(DescribeGlobalWorkflowDsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalWorkflowDsResponse>(req, "DescribeGlobalWorkflowDs");
        }

        /// <summary>
        /// 获取全局工作流信息，用于跨工作流节点拉取租户所有工作流列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalWorkflowDsRequest"/></param>
        /// <returns><see cref="DescribeGlobalWorkflowDsResponse"/></returns>
        public DescribeGlobalWorkflowDsResponse DescribeGlobalWorkflowDsSync(DescribeGlobalWorkflowDsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalWorkflowDsResponse>(req, "DescribeGlobalWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可导入的集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeImportableOfflineTaskRequest"/></param>
        /// <returns><see cref="DescribeImportableOfflineTaskResponse"/></returns>
        public Task<DescribeImportableOfflineTaskResponse> DescribeImportableOfflineTask(DescribeImportableOfflineTaskRequest req)
        {
            return InternalRequestAsync<DescribeImportableOfflineTaskResponse>(req, "DescribeImportableOfflineTask");
        }

        /// <summary>
        /// 查询可导入的集成任务
        /// </summary>
        /// <param name="req"><see cref="DescribeImportableOfflineTaskRequest"/></param>
        /// <returns><see cref="DescribeImportableOfflineTaskResponse"/></returns>
        public DescribeImportableOfflineTaskResponse DescribeImportableOfflineTaskSync(DescribeImportableOfflineTaskRequest req)
        {
            return InternalRequestAsync<DescribeImportableOfflineTaskResponse>(req, "DescribeImportableOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取采集器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentListResponse"/></returns>
        public Task<DescribeInLongAgentListResponse> DescribeInLongAgentList(DescribeInLongAgentListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentListResponse>(req, "DescribeInLongAgentList");
        }

        /// <summary>
        /// 获取采集器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentListResponse"/></returns>
        public DescribeInLongAgentListResponse DescribeInLongAgentListSync(DescribeInLongAgentListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentListResponse>(req, "DescribeInLongAgentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询采集器关联的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentTaskListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentTaskListResponse"/></returns>
        public Task<DescribeInLongAgentTaskListResponse> DescribeInLongAgentTaskList(DescribeInLongAgentTaskListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentTaskListResponse>(req, "DescribeInLongAgentTaskList");
        }

        /// <summary>
        /// 查询采集器关联的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentTaskListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentTaskListResponse"/></returns>
        public DescribeInLongAgentTaskListResponse DescribeInLongAgentTaskListSync(DescribeInLongAgentTaskListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentTaskListResponse>(req, "DescribeInLongAgentTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取采集器所在集群的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentVpcListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentVpcListResponse"/></returns>
        public Task<DescribeInLongAgentVpcListResponse> DescribeInLongAgentVpcList(DescribeInLongAgentVpcListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentVpcListResponse>(req, "DescribeInLongAgentVpcList");
        }

        /// <summary>
        /// 获取采集器所在集群的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongAgentVpcListRequest"/></param>
        /// <returns><see cref="DescribeInLongAgentVpcListResponse"/></returns>
        public DescribeInLongAgentVpcListResponse DescribeInLongAgentVpcListSync(DescribeInLongAgentVpcListRequest req)
        {
            return InternalRequestAsync<DescribeInLongAgentVpcListResponse>(req, "DescribeInLongAgentVpcList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TKE集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongTkeClusterListRequest"/></param>
        /// <returns><see cref="DescribeInLongTkeClusterListResponse"/></returns>
        public Task<DescribeInLongTkeClusterListResponse> DescribeInLongTkeClusterList(DescribeInLongTkeClusterListRequest req)
        {
            return InternalRequestAsync<DescribeInLongTkeClusterListResponse>(req, "DescribeInLongTkeClusterList");
        }

        /// <summary>
        /// 获取TKE集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInLongTkeClusterListRequest"/></param>
        /// <returns><see cref="DescribeInLongTkeClusterListResponse"/></returns>
        public DescribeInLongTkeClusterListResponse DescribeInLongTkeClusterListSync(DescribeInLongTkeClusterListRequest req)
        {
            return InternalRequestAsync<DescribeInLongTkeClusterListResponse>(req, "DescribeInLongTkeClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于任务类型获取任务信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeInfoTransByTypeIdDsRequest"/></param>
        /// <returns><see cref="DescribeInfoTransByTypeIdDsResponse"/></returns>
        public Task<DescribeInfoTransByTypeIdDsResponse> DescribeInfoTransByTypeIdDs(DescribeInfoTransByTypeIdDsRequest req)
        {
            return InternalRequestAsync<DescribeInfoTransByTypeIdDsResponse>(req, "DescribeInfoTransByTypeIdDs");
        }

        /// <summary>
        /// 基于任务类型获取任务信息Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeInfoTransByTypeIdDsRequest"/></param>
        /// <returns><see cref="DescribeInfoTransByTypeIdDsResponse"/></returns>
        public DescribeInfoTransByTypeIdDsResponse DescribeInfoTransByTypeIdDsSync(DescribeInfoTransByTypeIdDsRequest req)
        {
            return InternalRequestAsync<DescribeInfoTransByTypeIdDsResponse>(req, "DescribeInfoTransByTypeIdDs")
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
        /// 实例状态周期增长趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleReportResponse"/></returns>
        public Task<DescribeInstanceByCycleReportResponse> DescribeInstanceByCycleReport(DescribeInstanceByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleReportResponse>(req, "DescribeInstanceByCycleReport");
        }

        /// <summary>
        /// 实例状态周期增长趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeInstanceByCycleReportResponse"/></returns>
        public DescribeInstanceByCycleReportResponse DescribeInstanceByCycleReportSync(DescribeInstanceByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByCycleReportResponse>(req, "DescribeInstanceByCycleReport")
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
        /// 下载日志文件，返回日志URL
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogFileRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogFileResponse"/></returns>
        public Task<DescribeInstanceLogFileResponse> DescribeInstanceLogFile(DescribeInstanceLogFileRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogFileResponse>(req, "DescribeInstanceLogFile");
        }

        /// <summary>
        /// 下载日志文件，返回日志URL
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量，查询调度任务的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 数据质量，查询调度任务的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取实例列表，join task表一些信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesInfoWithTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeInstancesInfoWithTaskInfoResponse"/></returns>
        public Task<DescribeInstancesInfoWithTaskInfoResponse> DescribeInstancesInfoWithTaskInfo(DescribeInstancesInfoWithTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstancesInfoWithTaskInfoResponse>(req, "DescribeInstancesInfoWithTaskInfo");
        }

        /// <summary>
        /// 拉取实例列表，join task表一些信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesInfoWithTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeInstancesInfoWithTaskInfoResponse"/></returns>
        public DescribeInstancesInfoWithTaskInfoResponse DescribeInstancesInfoWithTaskInfoSync(DescribeInstancesInfoWithTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstancesInfoWithTaskInfoResponse>(req, "DescribeInstancesInfoWithTaskInfo")
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
        /// 数据集成大屏采集器状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsAgentStatusResponse"/></returns>
        public Task<DescribeIntegrationStatisticsAgentStatusResponse> DescribeIntegrationStatisticsAgentStatus(DescribeIntegrationStatisticsAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsAgentStatusResponse>(req, "DescribeIntegrationStatisticsAgentStatus");
        }

        /// <summary>
        /// 数据集成大屏采集器状态分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationStatisticsAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeIntegrationStatisticsAgentStatusResponse"/></returns>
        public DescribeIntegrationStatisticsAgentStatusResponse DescribeIntegrationStatisticsAgentStatusSync(DescribeIntegrationStatisticsAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeIntegrationStatisticsAgentStatusResponse>(req, "DescribeIntegrationStatisticsAgentStatus")
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
        /// 获取协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="DescribeLockRequest"/></param>
        /// <returns><see cref="DescribeLockResponse"/></returns>
        public Task<DescribeLockResponse> DescribeLock(DescribeLockRequest req)
        {
            return InternalRequestAsync<DescribeLockResponse>(req, "DescribeLock");
        }

        /// <summary>
        /// 获取协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="DescribeLockRequest"/></param>
        /// <returns><see cref="DescribeLockResponse"/></returns>
        public DescribeLockResponse DescribeLockSync(DescribeLockRequest req)
        {
            return InternalRequestAsync<DescribeLockResponse>(req, "DescribeLock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询质量监控组
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsByPageRequest"/></param>
        /// <returns><see cref="DescribeMonitorsByPageResponse"/></returns>
        public Task<DescribeMonitorsByPageResponse> DescribeMonitorsByPage(DescribeMonitorsByPageRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsByPageResponse>(req, "DescribeMonitorsByPage");
        }

        /// <summary>
        /// 分页查询质量监控组
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsByPageRequest"/></param>
        /// <returns><see cref="DescribeMonitorsByPageResponse"/></returns>
        public DescribeMonitorsByPageResponse DescribeMonitorsByPageSync(DescribeMonitorsByPageRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsByPageResponse>(req, "DescribeMonitorsByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新获取SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewSqlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeNewSqlTaskResultResponse"/></returns>
        public Task<DescribeNewSqlTaskResultResponse> DescribeNewSqlTaskResult(DescribeNewSqlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeNewSqlTaskResultResponse>(req, "DescribeNewSqlTaskResult");
        }

        /// <summary>
        /// 新获取SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewSqlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeNewSqlTaskResultResponse"/></returns>
        public DescribeNewSqlTaskResultResponse DescribeNewSqlTaskResultSync(DescribeNewSqlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeNewSqlTaskResultResponse>(req, "DescribeNewSqlTaskResult")
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
        /// 任务运维搜索 查询生产态任务数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTaskDatasourceRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTaskDatasourceResponse"/></returns>
        public Task<DescribeOperateOpsTaskDatasourceResponse> DescribeOperateOpsTaskDatasource(DescribeOperateOpsTaskDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTaskDatasourceResponse>(req, "DescribeOperateOpsTaskDatasource");
        }

        /// <summary>
        /// 任务运维搜索 查询生产态任务数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTaskDatasourceRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTaskDatasourceResponse"/></returns>
        public DescribeOperateOpsTaskDatasourceResponse DescribeOperateOpsTaskDatasourceSync(DescribeOperateOpsTaskDatasourceRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTaskDatasourceResponse>(req, "DescribeOperateOpsTaskDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维-查询生产态任务数据源类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTaskDatasourceTypeRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTaskDatasourceTypeResponse"/></returns>
        public Task<DescribeOperateOpsTaskDatasourceTypeResponse> DescribeOperateOpsTaskDatasourceType(DescribeOperateOpsTaskDatasourceTypeRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTaskDatasourceTypeResponse>(req, "DescribeOperateOpsTaskDatasourceType");
        }

        /// <summary>
        /// 任务运维-查询生产态任务数据源类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateOpsTaskDatasourceTypeRequest"/></param>
        /// <returns><see cref="DescribeOperateOpsTaskDatasourceTypeResponse"/></returns>
        public DescribeOperateOpsTaskDatasourceTypeResponse DescribeOperateOpsTaskDatasourceTypeSync(DescribeOperateOpsTaskDatasourceTypeRequest req)
        {
            return InternalRequestAsync<DescribeOperateOpsTaskDatasourceTypeResponse>(req, "DescribeOperateOpsTaskDatasourceType")
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
        /// 任务运维列表组合条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateTasksResponse"/></returns>
        public Task<DescribeOperateTasksResponse> DescribeOperateTasks(DescribeOperateTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateTasksResponse>(req, "DescribeOperateTasks");
        }

        /// <summary>
        /// 任务运维列表组合条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeOperateTasksRequest"/></param>
        /// <returns><see cref="DescribeOperateTasksResponse"/></returns>
        public DescribeOperateTasksResponse DescribeOperateTasksSync(DescribeOperateTasksRequest req)
        {
            return InternalRequestAsync<DescribeOperateTasksResponse>(req, "DescribeOperateTasks")
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
        /// 查询任务父依赖
        /// </summary>
        /// <param name="req"><see cref="DescribeParentTaskRequest"/></param>
        /// <returns><see cref="DescribeParentTaskResponse"/></returns>
        public Task<DescribeParentTaskResponse> DescribeParentTask(DescribeParentTaskRequest req)
        {
            return InternalRequestAsync<DescribeParentTaskResponse>(req, "DescribeParentTask");
        }

        /// <summary>
        /// 查询任务父依赖
        /// </summary>
        /// <param name="req"><see cref="DescribeParentTaskRequest"/></param>
        /// <returns><see cref="DescribeParentTaskResponse"/></returns>
        public DescribeParentTaskResponse DescribeParentTaskSync(DescribeParentTaskRequest req)
        {
            return InternalRequestAsync<DescribeParentTaskResponse>(req, "DescribeParentTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开发空间-拉取完整目录树
        /// </summary>
        /// <param name="req"><see cref="DescribePathTreesRequest"/></param>
        /// <returns><see cref="DescribePathTreesResponse"/></returns>
        public Task<DescribePathTreesResponse> DescribePathTrees(DescribePathTreesRequest req)
        {
            return InternalRequestAsync<DescribePathTreesResponse>(req, "DescribePathTrees");
        }

        /// <summary>
        /// 开发空间-拉取完整目录树
        /// </summary>
        /// <param name="req"><see cref="DescribePathTreesRequest"/></param>
        /// <returns><see cref="DescribePathTreesResponse"/></returns>
        public DescribePathTreesResponse DescribePathTreesSync(DescribePathTreesRequest req)
        {
            return InternalRequestAsync<DescribePathTreesResponse>(req, "DescribePathTrees")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据质量获取生产调度任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProdTasksRequest"/></param>
        /// <returns><see cref="DescribeProdTasksResponse"/></returns>
        public Task<DescribeProdTasksResponse> DescribeProdTasks(DescribeProdTasksRequest req)
        {
            return InternalRequestAsync<DescribeProdTasksResponse>(req, "DescribeProdTasks");
        }

        /// <summary>
        /// 数据质量获取生产调度任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProdTasksRequest"/></param>
        /// <returns><see cref="DescribeProdTasksResponse"/></returns>
        public DescribeProdTasksResponse DescribeProdTasksSync(DescribeProdTasksRequest req)
        {
            return InternalRequestAsync<DescribeProdTasksResponse>(req, "DescribeProdTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流画布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProdWorkflowCanvasInfoDsRequest"/></param>
        /// <returns><see cref="DescribeProdWorkflowCanvasInfoDsResponse"/></returns>
        public Task<DescribeProdWorkflowCanvasInfoDsResponse> DescribeProdWorkflowCanvasInfoDs(DescribeProdWorkflowCanvasInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeProdWorkflowCanvasInfoDsResponse>(req, "DescribeProdWorkflowCanvasInfoDs");
        }

        /// <summary>
        /// 获取工作流画布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProdWorkflowCanvasInfoDsRequest"/></param>
        /// <returns><see cref="DescribeProdWorkflowCanvasInfoDsResponse"/></returns>
        public DescribeProdWorkflowCanvasInfoDsResponse DescribeProdWorkflowCanvasInfoDsSync(DescribeProdWorkflowCanvasInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeProdWorkflowCanvasInfoDsResponse>(req, "DescribeProdWorkflowCanvasInfoDs")
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
        /// 查询项目全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamDsResponse"/></returns>
        public Task<DescribeProjectParamDsResponse> DescribeProjectParamDs(DescribeProjectParamDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamDsResponse>(req, "DescribeProjectParamDs");
        }

        /// <summary>
        /// 查询项目全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamDsResponse"/></returns>
        public DescribeProjectParamDsResponse DescribeProjectParamDsSync(DescribeProjectParamDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamDsResponse>(req, "DescribeProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamDsPageRequest"/></param>
        /// <returns><see cref="DescribeProjectParamDsPageResponse"/></returns>
        public Task<DescribeProjectParamDsPageResponse> DescribeProjectParamDsPage(DescribeProjectParamDsPageRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamDsPageResponse>(req, "DescribeProjectParamDsPage");
        }

        /// <summary>
        /// 查询项目全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamDsPageRequest"/></param>
        /// <returns><see cref="DescribeProjectParamDsPageResponse"/></returns>
        public DescribeProjectParamDsPageResponse DescribeProjectParamDsPageSync(DescribeProjectParamDsPageRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamDsPageResponse>(req, "DescribeProjectParamDsPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目参数历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamVersionDsResponse"/></returns>
        public Task<DescribeProjectParamVersionDsResponse> DescribeProjectParamVersionDs(DescribeProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamVersionDsResponse>(req, "DescribeProjectParamVersionDs");
        }

        /// <summary>
        /// 查询项目参数历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamVersionDsResponse"/></returns>
        public DescribeProjectParamVersionDsResponse DescribeProjectParamVersionDsSync(DescribeProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamVersionDsResponse>(req, "DescribeProjectParamVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取项目参数版本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamVersionInfoDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamVersionInfoDsResponse"/></returns>
        public Task<DescribeProjectParamVersionInfoDsResponse> DescribeProjectParamVersionInfoDs(DescribeProjectParamVersionInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamVersionInfoDsResponse>(req, "DescribeProjectParamVersionInfoDs");
        }

        /// <summary>
        /// 拉取项目参数版本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectParamVersionInfoDsRequest"/></param>
        /// <returns><see cref="DescribeProjectParamVersionInfoDsResponse"/></returns>
        public DescribeProjectParamVersionInfoDsResponse DescribeProjectParamVersionInfoDsSync(DescribeProjectParamVersionInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeProjectParamVersionInfoDsResponse>(req, "DescribeProjectParamVersionInfoDs")
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
        /// 即席分析-获取任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public Task<DescribeRecordListResponse> DescribeRecordList(DescribeRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRecordListResponse>(req, "DescribeRecordList");
        }

        /// <summary>
        /// 即席分析-获取任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordListRequest"/></param>
        /// <returns><see cref="DescribeRecordListResponse"/></returns>
        public DescribeRecordListResponse DescribeRecordListSync(DescribeRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRecordListResponse>(req, "DescribeRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回收站任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecycleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRecycleTaskDetailResponse"/></returns>
        public Task<DescribeRecycleTaskDetailResponse> DescribeRecycleTaskDetail(DescribeRecycleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRecycleTaskDetailResponse>(req, "DescribeRecycleTaskDetail");
        }

        /// <summary>
        /// 获取回收站任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecycleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRecycleTaskDetailResponse"/></returns>
        public DescribeRecycleTaskDetailResponse DescribeRecycleTaskDetailSync(DescribeRecycleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRecycleTaskDetailResponse>(req, "DescribeRecycleTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询回收站任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecycleTaskListRequest"/></param>
        /// <returns><see cref="DescribeRecycleTaskListResponse"/></returns>
        public Task<DescribeRecycleTaskListResponse> DescribeRecycleTaskList(DescribeRecycleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRecycleTaskListResponse>(req, "DescribeRecycleTaskList");
        }

        /// <summary>
        /// 查询回收站任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecycleTaskListRequest"/></param>
        /// <returns><see cref="DescribeRecycleTaskListResponse"/></returns>
        public DescribeRecycleTaskListResponse DescribeRecycleTaskListSync(DescribeRecycleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRecycleTaskListResponse>(req, "DescribeRecycleTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public Task<DescribeRelatedInstancesResponse> DescribeRelatedInstances(DescribeRelatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedInstancesResponse>(req, "DescribeRelatedInstances");
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public DescribeRelatedInstancesResponse DescribeRelatedInstancesSync(DescribeRelatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedInstancesResponse>(req, "DescribeRelatedInstances")
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
        /// 查询质量规则数据源
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeRuleDataSourcesResponse"/></returns>
        public Task<DescribeRuleDataSourcesResponse> DescribeRuleDataSources(DescribeRuleDataSourcesRequest req)
        {
            return InternalRequestAsync<DescribeRuleDataSourcesResponse>(req, "DescribeRuleDataSources");
        }

        /// <summary>
        /// 查询质量规则数据源
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeRuleDataSourcesResponse"/></returns>
        public DescribeRuleDataSourcesResponse DescribeRuleDataSourcesSync(DescribeRuleDataSourcesRequest req)
        {
            return InternalRequestAsync<DescribeRuleDataSourcesResponse>(req, "DescribeRuleDataSources")
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
        /// 查询规则执行导出结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecExportResultRequest"/></param>
        /// <returns><see cref="DescribeRuleExecExportResultResponse"/></returns>
        public Task<DescribeRuleExecExportResultResponse> DescribeRuleExecExportResult(DescribeRuleExecExportResultRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecExportResultResponse>(req, "DescribeRuleExecExportResult");
        }

        /// <summary>
        /// 查询规则执行导出结果
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecExportResultRequest"/></param>
        /// <returns><see cref="DescribeRuleExecExportResultResponse"/></returns>
        public DescribeRuleExecExportResultResponse DescribeRuleExecExportResultSync(DescribeRuleExecExportResultRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecExportResultResponse>(req, "DescribeRuleExecExportResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则执行历史， 最近30条
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecHistoryRequest"/></param>
        /// <returns><see cref="DescribeRuleExecHistoryResponse"/></returns>
        public Task<DescribeRuleExecHistoryResponse> DescribeRuleExecHistory(DescribeRuleExecHistoryRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecHistoryResponse>(req, "DescribeRuleExecHistory");
        }

        /// <summary>
        /// 查询规则执行历史， 最近30条
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecHistoryRequest"/></param>
        /// <returns><see cref="DescribeRuleExecHistoryResponse"/></returns>
        public DescribeRuleExecHistoryResponse DescribeRuleExecHistorySync(DescribeRuleExecHistoryRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecHistoryResponse>(req, "DescribeRuleExecHistory")
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
        /// 分页查询规则执行结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsByPageResponse"/></returns>
        public Task<DescribeRuleExecResultsByPageResponse> DescribeRuleExecResultsByPage(DescribeRuleExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsByPageResponse>(req, "DescribeRuleExecResultsByPage");
        }

        /// <summary>
        /// 分页查询规则执行结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleExecResultsByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleExecResultsByPageResponse"/></returns>
        public DescribeRuleExecResultsByPageResponse DescribeRuleExecResultsByPageSync(DescribeRuleExecResultsByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleExecResultsByPageResponse>(req, "DescribeRuleExecResultsByPage")
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
        /// 规则组执行结果分页查询接口不带鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthResponse"/></returns>
        public Task<DescribeRuleGroupExecResultsByPageWithoutAuthResponse> DescribeRuleGroupExecResultsByPageWithoutAuth(DescribeRuleGroupExecResultsByPageWithoutAuthRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageWithoutAuthResponse>(req, "DescribeRuleGroupExecResultsByPageWithoutAuth");
        }

        /// <summary>
        /// 规则组执行结果分页查询接口不带鉴权
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthRequest"/></param>
        /// <returns><see cref="DescribeRuleGroupExecResultsByPageWithoutAuthResponse"/></returns>
        public DescribeRuleGroupExecResultsByPageWithoutAuthResponse DescribeRuleGroupExecResultsByPageWithoutAuthSync(DescribeRuleGroupExecResultsByPageWithoutAuthRequest req)
        {
            return InternalRequestAsync<DescribeRuleGroupExecResultsByPageWithoutAuthResponse>(req, "DescribeRuleGroupExecResultsByPageWithoutAuth")
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
        /// 过滤条件【必要字段】{ruleId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleHistoryByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleHistoryByPageResponse"/></returns>
        public Task<DescribeRuleHistoryByPageResponse> DescribeRuleHistoryByPage(DescribeRuleHistoryByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleHistoryByPageResponse>(req, "DescribeRuleHistoryByPage");
        }

        /// <summary>
        /// 过滤条件【必要字段】{ruleId}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleHistoryByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleHistoryByPageResponse"/></returns>
        public DescribeRuleHistoryByPageResponse DescribeRuleHistoryByPageSync(DescribeRuleHistoryByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleHistoryByPageResponse>(req, "DescribeRuleHistoryByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTablesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTablesByPageResponse"/></returns>
        public Task<DescribeRuleTablesByPageResponse> DescribeRuleTablesByPage(DescribeRuleTablesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTablesByPageResponse>(req, "DescribeRuleTablesByPage");
        }

        /// <summary>
        /// 获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTablesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTablesByPageResponse"/></returns>
        public DescribeRuleTablesByPageResponse DescribeRuleTablesByPageSync(DescribeRuleTablesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTablesByPageResponse>(req, "DescribeRuleTablesByPage")
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
        /// 查询规则模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public Task<DescribeRuleTemplatesResponse> DescribeRuleTemplates(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates");
        }

        /// <summary>
        /// 查询规则模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesResponse"/></returns>
        public DescribeRuleTemplatesResponse DescribeRuleTemplatesSync(DescribeRuleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesResponse>(req, "DescribeRuleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 过滤条件】 {模版名称Name,支持模糊匹配} {模版类型type，1.系统模版 2.自定义模版} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleTemplatesByPageRequest"/></param>
        /// <returns><see cref="DescribeRuleTemplatesByPageResponse"/></returns>
        public Task<DescribeRuleTemplatesByPageResponse> DescribeRuleTemplatesByPage(DescribeRuleTemplatesByPageRequest req)
        {
            return InternalRequestAsync<DescribeRuleTemplatesByPageResponse>(req, "DescribeRuleTemplatesByPage");
        }

        /// <summary>
        /// 过滤条件】 {模版名称Name,支持模糊匹配} {模版类型type，1.系统模版 2.自定义模版} {质量检测维度QualityDims, 1.准确性 2.唯一性 3.完整性 4.一致性 5.及时性 6.有效性} 【排序字段】 { 引用数排序类型CitationOrderType，根据引用数量排序 ASC DESC}
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
        /// 在基线系统内查询单个调度任务实例
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstanceRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstanceResponse"/></returns>
        public Task<DescribeScheduleInstanceResponse> DescribeScheduleInstance(DescribeScheduleInstanceRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstanceResponse>(req, "DescribeScheduleInstance");
        }

        /// <summary>
        /// 在基线系统内查询单个调度任务实例
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduleInstanceRequest"/></param>
        /// <returns><see cref="DescribeScheduleInstanceResponse"/></returns>
        public DescribeScheduleInstanceResponse DescribeScheduleInstanceSync(DescribeScheduleInstanceRequest req)
        {
            return InternalRequestAsync<DescribeScheduleInstanceResponse>(req, "DescribeScheduleInstance")
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
        /// 获取脚本导出任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsImportTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeScriptsImportTaskTypeResponse"/></returns>
        public Task<DescribeScriptsImportTaskTypeResponse> DescribeScriptsImportTaskType(DescribeScriptsImportTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeScriptsImportTaskTypeResponse>(req, "DescribeScriptsImportTaskType");
        }

        /// <summary>
        /// 获取脚本导出任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsImportTaskTypeRequest"/></param>
        /// <returns><see cref="DescribeScriptsImportTaskTypeResponse"/></returns>
        public DescribeScriptsImportTaskTypeResponse DescribeScriptsImportTaskTypeSync(DescribeScriptsImportTaskTypeRequest req)
        {
            return InternalRequestAsync<DescribeScriptsImportTaskTypeResponse>(req, "DescribeScriptsImportTaskType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取关联子实例
        /// </summary>
        /// <param name="req"><see cref="DescribeSonInstancesRequest"/></param>
        /// <returns><see cref="DescribeSonInstancesResponse"/></returns>
        public Task<DescribeSonInstancesResponse> DescribeSonInstances(DescribeSonInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSonInstancesResponse>(req, "DescribeSonInstances");
        }

        /// <summary>
        /// 获取关联子实例
        /// </summary>
        /// <param name="req"><see cref="DescribeSonInstancesRequest"/></param>
        /// <returns><see cref="DescribeSonInstancesResponse"/></returns>
        public DescribeSonInstancesResponse DescribeSonInstancesSync(DescribeSonInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSonInstancesResponse>(req, "DescribeSonInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeSqlTaskResultResponse"/></returns>
        public Task<DescribeSqlTaskResultResponse> DescribeSqlTaskResult(DescribeSqlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeSqlTaskResultResponse>(req, "DescribeSqlTaskResult");
        }

        /// <summary>
        /// 获取SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeSqlTaskResultResponse"/></returns>
        public DescribeSqlTaskResultResponse DescribeSqlTaskResultSync(DescribeSqlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeSqlTaskResultResponse>(req, "DescribeSqlTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据标准规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardRuleDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeStandardRuleDetailInfoListResponse"/></returns>
        public Task<DescribeStandardRuleDetailInfoListResponse> DescribeStandardRuleDetailInfoList(DescribeStandardRuleDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStandardRuleDetailInfoListResponse>(req, "DescribeStandardRuleDetailInfoList");
        }

        /// <summary>
        /// 获取数据标准规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardRuleDetailInfoListRequest"/></param>
        /// <returns><see cref="DescribeStandardRuleDetailInfoListResponse"/></returns>
        public DescribeStandardRuleDetailInfoListResponse DescribeStandardRuleDetailInfoListSync(DescribeStandardRuleDetailInfoListRequest req)
        {
            return InternalRequestAsync<DescribeStandardRuleDetailInfoListResponse>(req, "DescribeStandardRuleDetailInfoList")
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
        /// 获取任务绑定的虚拟任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskBindVirtualTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskBindVirtualTaskResponse"/></returns>
        public Task<DescribeTaskBindVirtualTaskResponse> DescribeTaskBindVirtualTask(DescribeTaskBindVirtualTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskBindVirtualTaskResponse>(req, "DescribeTaskBindVirtualTask");
        }

        /// <summary>
        /// 获取任务绑定的虚拟任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskBindVirtualTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskBindVirtualTaskResponse"/></returns>
        public DescribeTaskBindVirtualTaskResponse DescribeTaskBindVirtualTaskSync(DescribeTaskBindVirtualTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskBindVirtualTaskResponse>(req, "DescribeTaskBindVirtualTask")
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
        /// 任务状态周期增长趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskByCycleReportRequest"/></param>
        /// <returns><see cref="DescribeTaskByCycleReportResponse"/></returns>
        public Task<DescribeTaskByCycleReportResponse> DescribeTaskByCycleReport(DescribeTaskByCycleReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskByCycleReportResponse>(req, "DescribeTaskByCycleReport");
        }

        /// <summary>
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务具体详情Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailDsRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailDsResponse"/></returns>
        public Task<DescribeTaskDetailDsResponse> DescribeTaskDetailDs(DescribeTaskDetailDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailDsResponse>(req, "DescribeTaskDetailDs");
        }

        /// <summary>
        /// 查询任务具体详情Ds
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailDsRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailDsResponse"/></returns>
        public DescribeTaskDetailDsResponse DescribeTaskDetailDsSync(DescribeTaskDetailDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailDsResponse>(req, "DescribeTaskDetailDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务输入参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskInParamDsResponse"/></returns>
        public Task<DescribeTaskInParamDsResponse> DescribeTaskInParamDs(DescribeTaskInParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskInParamDsResponse>(req, "DescribeTaskInParamDs");
        }

        /// <summary>
        /// 查询任务输入参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskInParamDsResponse"/></returns>
        public DescribeTaskInParamDsResponse DescribeTaskInParamDsSync(DescribeTaskInParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskInParamDsResponse>(req, "DescribeTaskInParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 离线任务实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceResponse"/></returns>
        public Task<DescribeTaskInstanceResponse> DescribeTaskInstance(DescribeTaskInstanceRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstanceResponse>(req, "DescribeTaskInstance");
        }

        /// <summary>
        /// 离线任务实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceResponse"/></returns>
        public DescribeTaskInstanceResponse DescribeTaskInstanceSync(DescribeTaskInstanceRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstanceResponse>(req, "DescribeTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 离线任务实例统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceReportDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceReportDetailResponse"/></returns>
        public Task<DescribeTaskInstanceReportDetailResponse> DescribeTaskInstanceReportDetail(DescribeTaskInstanceReportDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstanceReportDetailResponse>(req, "DescribeTaskInstanceReportDetail");
        }

        /// <summary>
        /// 离线任务实例统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstanceReportDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskInstanceReportDetailResponse"/></returns>
        public DescribeTaskInstanceReportDetailResponse DescribeTaskInstanceReportDetailSync(DescribeTaskInstanceReportDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstanceReportDetailResponse>(req, "DescribeTaskInstanceReportDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public Task<DescribeTaskInstancesResponse> DescribeTaskInstances(DescribeTaskInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstancesResponse>(req, "DescribeTaskInstances");
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public DescribeTaskInstancesResponse DescribeTaskInstancesSync(DescribeTaskInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTaskInstancesResponse>(req, "DescribeTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过指定基准时间，计算出最近一次任务基于该基准时间的运行时间
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLatestRunTimeRequest"/></param>
        /// <returns><see cref="DescribeTaskLatestRunTimeResponse"/></returns>
        public Task<DescribeTaskLatestRunTimeResponse> DescribeTaskLatestRunTime(DescribeTaskLatestRunTimeRequest req)
        {
            return InternalRequestAsync<DescribeTaskLatestRunTimeResponse>(req, "DescribeTaskLatestRunTime");
        }

        /// <summary>
        /// 通过指定基准时间，计算出最近一次任务基于该基准时间的运行时间
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLatestRunTimeRequest"/></param>
        /// <returns><see cref="DescribeTaskLatestRunTimeResponse"/></returns>
        public DescribeTaskLatestRunTimeResponse DescribeTaskLatestRunTimeSync(DescribeTaskLatestRunTimeRequest req)
        {
            return InternalRequestAsync<DescribeTaskLatestRunTimeResponse>(req, "DescribeTaskLatestRunTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于条件翻页获取任务列表, 用于新建跨工作流任务场景中展示工作流列表操作
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListByConditionDsRequest"/></param>
        /// <returns><see cref="DescribeTaskListByConditionDsResponse"/></returns>
        public Task<DescribeTaskListByConditionDsResponse> DescribeTaskListByConditionDs(DescribeTaskListByConditionDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskListByConditionDsResponse>(req, "DescribeTaskListByConditionDs");
        }

        /// <summary>
        /// 基于条件翻页获取任务列表, 用于新建跨工作流任务场景中展示工作流列表操作
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListByConditionDsRequest"/></param>
        /// <returns><see cref="DescribeTaskListByConditionDsResponse"/></returns>
        public DescribeTaskListByConditionDsResponse DescribeTaskListByConditionDsSync(DescribeTaskListByConditionDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskListByConditionDsResponse>(req, "DescribeTaskListByConditionDs")
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
        /// 查询任务输出参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOutParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskOutParamDsResponse"/></returns>
        public Task<DescribeTaskOutParamDsResponse> DescribeTaskOutParamDs(DescribeTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskOutParamDsResponse>(req, "DescribeTaskOutParamDs");
        }

        /// <summary>
        /// 查询任务输出参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOutParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskOutParamDsResponse"/></returns>
        public DescribeTaskOutParamDsResponse DescribeTaskOutParamDsSync(DescribeTaskOutParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskOutParamDsResponse>(req, "DescribeTaskOutParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定任务产出登记列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOutputRegistriesRequest"/></param>
        /// <returns><see cref="DescribeTaskOutputRegistriesResponse"/></returns>
        public Task<DescribeTaskOutputRegistriesResponse> DescribeTaskOutputRegistries(DescribeTaskOutputRegistriesRequest req)
        {
            return InternalRequestAsync<DescribeTaskOutputRegistriesResponse>(req, "DescribeTaskOutputRegistries");
        }

        /// <summary>
        /// 获取指定任务产出登记列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOutputRegistriesRequest"/></param>
        /// <returns><see cref="DescribeTaskOutputRegistriesResponse"/></returns>
        public DescribeTaskOutputRegistriesResponse DescribeTaskOutputRegistriesSync(DescribeTaskOutputRegistriesRequest req)
        {
            return InternalRequestAsync<DescribeTaskOutputRegistriesResponse>(req, "DescribeTaskOutputRegistries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务引用参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskParamDsResponse"/></returns>
        public Task<DescribeTaskParamDsResponse> DescribeTaskParamDs(DescribeTaskParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskParamDsResponse>(req, "DescribeTaskParamDs");
        }

        /// <summary>
        /// 查询任务引用参数
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskParamDsRequest"/></param>
        /// <returns><see cref="DescribeTaskParamDsResponse"/></returns>
        public DescribeTaskParamDsResponse DescribeTaskParamDsSync(DescribeTaskParamDsRequest req)
        {
            return InternalRequestAsync<DescribeTaskParamDsResponse>(req, "DescribeTaskParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于当前任务的数据时间计算依赖的上游任务数据时间
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskParentRunTimeRequest"/></param>
        /// <returns><see cref="DescribeTaskParentRunTimeResponse"/></returns>
        public Task<DescribeTaskParentRunTimeResponse> DescribeTaskParentRunTime(DescribeTaskParentRunTimeRequest req)
        {
            return InternalRequestAsync<DescribeTaskParentRunTimeResponse>(req, "DescribeTaskParentRunTime");
        }

        /// <summary>
        /// 基于当前任务的数据时间计算依赖的上游任务数据时间
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskParentRunTimeRequest"/></param>
        /// <returns><see cref="DescribeTaskParentRunTimeResponse"/></returns>
        public DescribeTaskParentRunTimeResponse DescribeTaskParentRunTimeSync(DescribeTaskParentRunTimeRequest req)
        {
            return InternalRequestAsync<DescribeTaskParentRunTimeResponse>(req, "DescribeTaskParentRunTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按起止日期统计离线任务的所有实例的运行指标总和
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportRequest"/></param>
        /// <returns><see cref="DescribeTaskReportResponse"/></returns>
        public Task<DescribeTaskReportResponse> DescribeTaskReport(DescribeTaskReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskReportResponse>(req, "DescribeTaskReport");
        }

        /// <summary>
        /// 按起止日期统计离线任务的所有实例的运行指标总和
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportRequest"/></param>
        /// <returns><see cref="DescribeTaskReportResponse"/></returns>
        public DescribeTaskReportResponse DescribeTaskReportSync(DescribeTaskReportRequest req)
        {
            return InternalRequestAsync<DescribeTaskReportResponse>(req, "DescribeTaskReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 离线任务周期统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportDetailListRequest"/></param>
        /// <returns><see cref="DescribeTaskReportDetailListResponse"/></returns>
        public Task<DescribeTaskReportDetailListResponse> DescribeTaskReportDetailList(DescribeTaskReportDetailListRequest req)
        {
            return InternalRequestAsync<DescribeTaskReportDetailListResponse>(req, "DescribeTaskReportDetailList");
        }

        /// <summary>
        /// 离线任务周期统计明细
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskReportDetailListRequest"/></param>
        /// <returns><see cref="DescribeTaskReportDetailListResponse"/></returns>
        public DescribeTaskReportDetailListResponse DescribeTaskReportDetailListSync(DescribeTaskReportDetailListRequest req)
        {
            return InternalRequestAsync<DescribeTaskReportDetailListResponse>(req, "DescribeTaskReportDetailList")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public Task<DescribeTaskScriptResponse> DescribeTaskScript(DescribeTaskScriptRequest req)
        {
            return InternalRequestAsync<DescribeTaskScriptResponse>(req, "DescribeTaskScript");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 根据脚本类型获取任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTypeByScriptTypeRequest"/></param>
        /// <returns><see cref="DescribeTaskTypeByScriptTypeResponse"/></returns>
        public Task<DescribeTaskTypeByScriptTypeResponse> DescribeTaskTypeByScriptType(DescribeTaskTypeByScriptTypeRequest req)
        {
            return InternalRequestAsync<DescribeTaskTypeByScriptTypeResponse>(req, "DescribeTaskTypeByScriptType");
        }

        /// <summary>
        /// 根据脚本类型获取任务类型
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTypeByScriptTypeRequest"/></param>
        /// <returns><see cref="DescribeTaskTypeByScriptTypeResponse"/></returns>
        public DescribeTaskTypeByScriptTypeResponse DescribeTaskTypeByScriptTypeSync(DescribeTaskTypeByScriptTypeRequest req)
        {
            return InternalRequestAsync<DescribeTaskTypeByScriptTypeResponse>(req, "DescribeTaskTypeByScriptType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public Task<DescribeTasksByPageResponse> DescribeTasksByPage(DescribeTasksByPageRequest req)
        {
            return InternalRequestAsync<DescribeTasksByPageResponse>(req, "DescribeTasksByPage");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public DescribeTasksByPageResponse DescribeTasksByPageSync(DescribeTasksByPageRequest req)
        {
            return InternalRequestAsync<DescribeTasksByPageResponse>(req, "DescribeTasksByPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeTasksForProjectCloneResponse"/></returns>
        public Task<DescribeTasksForProjectCloneResponse> DescribeTasksForProjectClone(DescribeTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeTasksForProjectCloneResponse>(req, "DescribeTasksForProjectClone");
        }

        /// <summary>
        /// 任务信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeTasksForProjectCloneResponse"/></returns>
        public DescribeTasksForProjectCloneResponse DescribeTasksForProjectCloneSync(DescribeTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeTasksForProjectCloneResponse>(req, "DescribeTasksForProjectClone")
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
        /// 查询规则模板操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateHistoryRequest"/></param>
        /// <returns><see cref="DescribeTemplateHistoryResponse"/></returns>
        public Task<DescribeTemplateHistoryResponse> DescribeTemplateHistory(DescribeTemplateHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTemplateHistoryResponse>(req, "DescribeTemplateHistory");
        }

        /// <summary>
        /// 查询规则模板操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateHistoryRequest"/></param>
        /// <returns><see cref="DescribeTemplateHistoryResponse"/></returns>
        public DescribeTemplateHistoryResponse DescribeTemplateHistorySync(DescribeTemplateHistoryRequest req)
        {
            return InternalRequestAsync<DescribeTemplateHistoryResponse>(req, "DescribeTemplateHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取etl测试运行任务执行状态和日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTestRunRequest"/></param>
        /// <returns><see cref="DescribeTestRunResponse"/></returns>
        public Task<DescribeTestRunResponse> DescribeTestRun(DescribeTestRunRequest req)
        {
            return InternalRequestAsync<DescribeTestRunResponse>(req, "DescribeTestRun");
        }

        /// <summary>
        /// 获取etl测试运行任务执行状态和日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTestRunRequest"/></param>
        /// <returns><see cref="DescribeTestRunResponse"/></returns>
        public DescribeTestRunResponse DescribeTestRunSync(DescribeTestRunRequest req)
        {
            return InternalRequestAsync<DescribeTestRunResponse>(req, "DescribeTestRun")
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
        /// 获取长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken");
        }

        /// <summary>
        /// 获取长连接Token
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken")
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
        /// 根据文件夹查询工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowByFordIdsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowByFordIdsResponse"/></returns>
        public Task<DescribeWorkflowByFordIdsResponse> DescribeWorkflowByFordIds(DescribeWorkflowByFordIdsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowByFordIdsResponse>(req, "DescribeWorkflowByFordIds");
        }

        /// <summary>
        /// 根据文件夹查询工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowByFordIdsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowByFordIdsResponse"/></returns>
        public DescribeWorkflowByFordIdsResponse DescribeWorkflowByFordIdsSync(DescribeWorkflowByFordIdsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowByFordIdsResponse>(req, "DescribeWorkflowByFordIds")
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
        /// 数据开发-获取工作流画布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoDsResponse"/></returns>
        public Task<DescribeWorkflowCanvasInfoDsResponse> DescribeWorkflowCanvasInfoDs(DescribeWorkflowCanvasInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoDsResponse>(req, "DescribeWorkflowCanvasInfoDs");
        }

        /// <summary>
        /// 数据开发-获取工作流画布信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasInfoDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasInfoDsResponse"/></returns>
        public DescribeWorkflowCanvasInfoDsResponse DescribeWorkflowCanvasInfoDsSync(DescribeWorkflowCanvasInfoDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasInfoDsResponse>(req, "DescribeWorkflowCanvasInfoDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasOpLogsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasOpLogsResponse"/></returns>
        public Task<DescribeWorkflowCanvasOpLogsResponse> DescribeWorkflowCanvasOpLogs(DescribeWorkflowCanvasOpLogsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasOpLogsResponse>(req, "DescribeWorkflowCanvasOpLogs");
        }

        /// <summary>
        /// 获取工作流操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasOpLogsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasOpLogsResponse"/></returns>
        public DescribeWorkflowCanvasOpLogsResponse DescribeWorkflowCanvasOpLogsSync(DescribeWorkflowCanvasOpLogsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasOpLogsResponse>(req, "DescribeWorkflowCanvasOpLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流画布操作人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasOperatorsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasOperatorsResponse"/></returns>
        public Task<DescribeWorkflowCanvasOperatorsResponse> DescribeWorkflowCanvasOperators(DescribeWorkflowCanvasOperatorsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasOperatorsResponse>(req, "DescribeWorkflowCanvasOperators");
        }

        /// <summary>
        /// 获取工作流画布操作人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowCanvasOperatorsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowCanvasOperatorsResponse"/></returns>
        public DescribeWorkflowCanvasOperatorsResponse DescribeWorkflowCanvasOperatorsSync(DescribeWorkflowCanvasOperatorsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowCanvasOperatorsResponse>(req, "DescribeWorkflowCanvasOperators")
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
        /// 工作流信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeWorkflowForProjectCloneResponse"/></returns>
        public Task<DescribeWorkflowForProjectCloneResponse> DescribeWorkflowForProjectClone(DescribeWorkflowForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowForProjectCloneResponse>(req, "DescribeWorkflowForProjectClone");
        }

        /// <summary>
        /// 工作流信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeWorkflowForProjectCloneResponse"/></returns>
        public DescribeWorkflowForProjectCloneResponse DescribeWorkflowForProjectCloneSync(DescribeWorkflowForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowForProjectCloneResponse>(req, "DescribeWorkflowForProjectClone")
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
        /// 查询运维画布信息，只需要获取边和节点
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowOpsCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowOpsCanvasInfoResponse"/></returns>
        public Task<DescribeWorkflowOpsCanvasInfoResponse> DescribeWorkflowOpsCanvasInfo(DescribeWorkflowOpsCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowOpsCanvasInfoResponse>(req, "DescribeWorkflowOpsCanvasInfo");
        }

        /// <summary>
        /// 查询运维画布信息，只需要获取边和节点
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowOpsCanvasInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkflowOpsCanvasInfoResponse"/></returns>
        public DescribeWorkflowOpsCanvasInfoResponse DescribeWorkflowOpsCanvasInfoSync(DescribeWorkflowOpsCanvasInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowOpsCanvasInfoResponse>(req, "DescribeWorkflowOpsCanvasInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowParamDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowParamDsResponse"/></returns>
        public Task<DescribeWorkflowParamDsResponse> DescribeWorkflowParamDs(DescribeWorkflowParamDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowParamDsResponse>(req, "DescribeWorkflowParamDs");
        }

        /// <summary>
        /// 查询工作流全局参数
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowParamDsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowParamDsResponse"/></returns>
        public DescribeWorkflowParamDsResponse DescribeWorkflowParamDsSync(DescribeWorkflowParamDsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowParamDsResponse>(req, "DescribeWorkflowParamDs")
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
        /// 工作流任务信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTasksForProjectCloneResponse"/></returns>
        public Task<DescribeWorkflowTasksForProjectCloneResponse> DescribeWorkflowTasksForProjectClone(DescribeWorkflowTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTasksForProjectCloneResponse>(req, "DescribeWorkflowTasksForProjectClone");
        }

        /// <summary>
        /// 工作流任务信息查询-项目克隆使用
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowTasksForProjectCloneRequest"/></param>
        /// <returns><see cref="DescribeWorkflowTasksForProjectCloneResponse"/></returns>
        public DescribeWorkflowTasksForProjectCloneResponse DescribeWorkflowTasksForProjectCloneSync(DescribeWorkflowTasksForProjectCloneRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowTasksForProjectCloneResponse>(req, "DescribeWorkflowTasksForProjectClone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例诊断信息
        /// </summary>
        /// <param name="req"><see cref="DiagnosePlusRequest"/></param>
        /// <returns><see cref="DiagnosePlusResponse"/></returns>
        public Task<DiagnosePlusResponse> DiagnosePlus(DiagnosePlusRequest req)
        {
            return InternalRequestAsync<DiagnosePlusResponse>(req, "DiagnosePlus");
        }

        /// <summary>
        /// 实例诊断信息
        /// </summary>
        /// <param name="req"><see cref="DiagnosePlusRequest"/></param>
        /// <returns><see cref="DiagnosePlusResponse"/></returns>
        public DiagnosePlusResponse DiagnosePlusSync(DiagnosePlusRequest req)
        {
            return InternalRequestAsync<DiagnosePlusResponse>(req, "DiagnosePlus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DownloadNewSqlResultRequest"/></param>
        /// <returns><see cref="DownloadNewSqlResultResponse"/></returns>
        public Task<DownloadNewSqlResultResponse> DownloadNewSqlResult(DownloadNewSqlResultRequest req)
        {
            return InternalRequestAsync<DownloadNewSqlResultResponse>(req, "DownloadNewSqlResult");
        }

        /// <summary>
        /// 下载SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DownloadNewSqlResultRequest"/></param>
        /// <returns><see cref="DownloadNewSqlResultResponse"/></returns>
        public DownloadNewSqlResultResponse DownloadNewSqlResultSync(DownloadNewSqlResultRequest req)
        {
            return InternalRequestAsync<DownloadNewSqlResultResponse>(req, "DownloadNewSqlResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DownloadSqlResultRequest"/></param>
        /// <returns><see cref="DownloadSqlResultResponse"/></returns>
        public Task<DownloadSqlResultResponse> DownloadSqlResult(DownloadSqlResultRequest req)
        {
            return InternalRequestAsync<DownloadSqlResultResponse>(req, "DownloadSqlResult");
        }

        /// <summary>
        /// 下载SQL执行结果
        /// </summary>
        /// <param name="req"><see cref="DownloadSqlResultRequest"/></param>
        /// <returns><see cref="DownloadSqlResultResponse"/></returns>
        public DownloadSqlResultResponse DownloadSqlResultSync(DownloadSqlResultRequest req)
        {
            return InternalRequestAsync<DownloadSqlResultResponse>(req, "DownloadSqlResult")
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
        /// 编辑基线
        /// </summary>
        /// <param name="req"><see cref="EditBaselineRequest"/></param>
        /// <returns><see cref="EditBaselineResponse"/></returns>
        public Task<EditBaselineResponse> EditBaseline(EditBaselineRequest req)
        {
            return InternalRequestAsync<EditBaselineResponse>(req, "EditBaseline");
        }

        /// <summary>
        /// 编辑基线
        /// </summary>
        /// <param name="req"><see cref="EditBaselineRequest"/></param>
        /// <returns><see cref="EditBaselineResponse"/></returns>
        public EditBaselineResponse EditBaselineSync(EditBaselineRequest req)
        {
            return InternalRequestAsync<EditBaselineResponse>(req, "EditBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件管理-导出事件
        /// </summary>
        /// <param name="req"><see cref="ExportDsEventRequest"/></param>
        /// <returns><see cref="ExportDsEventResponse"/></returns>
        public Task<ExportDsEventResponse> ExportDsEvent(ExportDsEventRequest req)
        {
            return InternalRequestAsync<ExportDsEventResponse>(req, "ExportDsEvent");
        }

        /// <summary>
        /// 事件管理-导出事件
        /// </summary>
        /// <param name="req"><see cref="ExportDsEventRequest"/></param>
        /// <returns><see cref="ExportDsEventResponse"/></returns>
        public ExportDsEventResponse ExportDsEventSync(ExportDsEventRequest req)
        {
            return InternalRequestAsync<ExportDsEventResponse>(req, "ExportDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量导出文件
        /// </summary>
        /// <param name="req"><see cref="ExportFilesRequest"/></param>
        /// <returns><see cref="ExportFilesResponse"/></returns>
        public Task<ExportFilesResponse> ExportFiles(ExportFilesRequest req)
        {
            return InternalRequestAsync<ExportFilesResponse>(req, "ExportFiles");
        }

        /// <summary>
        /// 批量导出文件
        /// </summary>
        /// <param name="req"><see cref="ExportFilesRequest"/></param>
        /// <returns><see cref="ExportFilesResponse"/></returns>
        public ExportFilesResponse ExportFilesSync(ExportFilesRequest req)
        {
            return InternalRequestAsync<ExportFilesResponse>(req, "ExportFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出项目参数
        /// </summary>
        /// <param name="req"><see cref="ExportProjectParamDsRequest"/></param>
        /// <returns><see cref="ExportProjectParamDsResponse"/></returns>
        public Task<ExportProjectParamDsResponse> ExportProjectParamDs(ExportProjectParamDsRequest req)
        {
            return InternalRequestAsync<ExportProjectParamDsResponse>(req, "ExportProjectParamDs");
        }

        /// <summary>
        /// 导出项目参数
        /// </summary>
        /// <param name="req"><see cref="ExportProjectParamDsRequest"/></param>
        /// <returns><see cref="ExportProjectParamDsResponse"/></returns>
        public ExportProjectParamDsResponse ExportProjectParamDsSync(ExportProjectParamDsRequest req)
        {
            return InternalRequestAsync<ExportProjectParamDsResponse>(req, "ExportProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出工作流(XML格式)，导出的文件存储在 cos 中(私有化 csp)，请自行下载，相关的下载信息在返回值中可以获取到
        /// </summary>
        /// <param name="req"><see cref="ExportWorkflowXmlRequest"/></param>
        /// <returns><see cref="ExportWorkflowXmlResponse"/></returns>
        public Task<ExportWorkflowXmlResponse> ExportWorkflowXml(ExportWorkflowXmlRequest req)
        {
            return InternalRequestAsync<ExportWorkflowXmlResponse>(req, "ExportWorkflowXml");
        }

        /// <summary>
        /// 导出工作流(XML格式)，导出的文件存储在 cos 中(私有化 csp)，请自行下载，相关的下载信息在返回值中可以获取到
        /// </summary>
        /// <param name="req"><see cref="ExportWorkflowXmlRequest"/></param>
        /// <returns><see cref="ExportWorkflowXmlResponse"/></returns>
        public ExportWorkflowXmlResponse ExportWorkflowXmlSync(ExportWorkflowXmlRequest req)
        {
            return InternalRequestAsync<ExportWorkflowXmlResponse>(req, "ExportWorkflowXml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出工作流到 Zip 文件，导出的文件存储在 cos 中(私有化 csp)，请自行下载，相关的下载信息在返回值中可以获取到
        /// </summary>
        /// <param name="req"><see cref="ExportWorkflowZipRequest"/></param>
        /// <returns><see cref="ExportWorkflowZipResponse"/></returns>
        public Task<ExportWorkflowZipResponse> ExportWorkflowZip(ExportWorkflowZipRequest req)
        {
            return InternalRequestAsync<ExportWorkflowZipResponse>(req, "ExportWorkflowZip");
        }

        /// <summary>
        /// 导出工作流到 Zip 文件，导出的文件存储在 cos 中(私有化 csp)，请自行下载，相关的下载信息在返回值中可以获取到
        /// </summary>
        /// <param name="req"><see cref="ExportWorkflowZipRequest"/></param>
        /// <returns><see cref="ExportWorkflowZipResponse"/></returns>
        public ExportWorkflowZipResponse ExportWorkflowZipSync(ExportWorkflowZipRequest req)
        {
            return InternalRequestAsync<ExportWorkflowZipResponse>(req, "ExportWorkflowZip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查找全部的文件夹
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public Task<FindAllFolderResponse> FindAllFolder(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder");
        }

        /// <summary>
        /// 查找全部的文件夹
        /// </summary>
        /// <param name="req"><see cref="FindAllFolderRequest"/></param>
        /// <returns><see cref="FindAllFolderResponse"/></returns>
        public FindAllFolderResponse FindAllFolderSync(FindAllFolderRequest req)
        {
            return InternalRequestAsync<FindAllFolderResponse>(req, "FindAllFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取下游依赖的任务列表Ds
        /// </summary>
        /// <param name="req"><see cref="FindDependTaskListDsRequest"/></param>
        /// <returns><see cref="FindDependTaskListDsResponse"/></returns>
        public Task<FindDependTaskListDsResponse> FindDependTaskListDs(FindDependTaskListDsRequest req)
        {
            return InternalRequestAsync<FindDependTaskListDsResponse>(req, "FindDependTaskListDs");
        }

        /// <summary>
        /// 拉取下游依赖的任务列表Ds
        /// </summary>
        /// <param name="req"><see cref="FindDependTaskListDsRequest"/></param>
        /// <returns><see cref="FindDependTaskListDsResponse"/></returns>
        public FindDependTaskListDsResponse FindDependTaskListDsSync(FindDependTaskListDsRequest req)
        {
            return InternalRequestAsync<FindDependTaskListDsResponse>(req, "FindDependTaskListDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量拉取下游依赖的任务列表Ds
        /// </summary>
        /// <param name="req"><see cref="FindDependTaskListsDsRequest"/></param>
        /// <returns><see cref="FindDependTaskListsDsResponse"/></returns>
        public Task<FindDependTaskListsDsResponse> FindDependTaskListsDs(FindDependTaskListsDsRequest req)
        {
            return InternalRequestAsync<FindDependTaskListsDsResponse>(req, "FindDependTaskListsDs");
        }

        /// <summary>
        /// 批量拉取下游依赖的任务列表Ds
        /// </summary>
        /// <param name="req"><see cref="FindDependTaskListsDsRequest"/></param>
        /// <returns><see cref="FindDependTaskListsDsResponse"/></returns>
        public FindDependTaskListsDsResponse FindDependTaskListsDsSync(FindDependTaskListsDsRequest req)
        {
            return InternalRequestAsync<FindDependTaskListsDsResponse>(req, "FindDependTaskListsDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间-根据项目名称和任务名称模糊查询所有任务
        /// </summary>
        /// <param name="req"><see cref="FindFuzzyTasksDsRequest"/></param>
        /// <returns><see cref="FindFuzzyTasksDsResponse"/></returns>
        public Task<FindFuzzyTasksDsResponse> FindFuzzyTasksDs(FindFuzzyTasksDsRequest req)
        {
            return InternalRequestAsync<FindFuzzyTasksDsResponse>(req, "FindFuzzyTasksDs");
        }

        /// <summary>
        /// 编排空间-根据项目名称和任务名称模糊查询所有任务
        /// </summary>
        /// <param name="req"><see cref="FindFuzzyTasksDsRequest"/></param>
        /// <returns><see cref="FindFuzzyTasksDsResponse"/></returns>
        public FindFuzzyTasksDsResponse FindFuzzyTasksDsSync(FindFuzzyTasksDsRequest req)
        {
            return InternalRequestAsync<FindFuzzyTasksDsResponse>(req, "FindFuzzyTasksDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 远端路径寻找任务
        /// </summary>
        /// <param name="req"><see cref="FindTaskByRemotePathRequest"/></param>
        /// <returns><see cref="FindTaskByRemotePathResponse"/></returns>
        public Task<FindTaskByRemotePathResponse> FindTaskByRemotePath(FindTaskByRemotePathRequest req)
        {
            return InternalRequestAsync<FindTaskByRemotePathResponse>(req, "FindTaskByRemotePath");
        }

        /// <summary>
        /// 远端路径寻找任务
        /// </summary>
        /// <param name="req"><see cref="FindTaskByRemotePathRequest"/></param>
        /// <returns><see cref="FindTaskByRemotePathResponse"/></returns>
        public FindTaskByRemotePathResponse FindTaskByRemotePathSync(FindTaskByRemotePathRequest req)
        {
            return InternalRequestAsync<FindTaskByRemotePathResponse>(req, "FindTaskByRemotePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public Task<ForceSucInstancesResponse> ForceSucInstances(ForceSucInstancesRequest req)
        {
            return InternalRequestAsync<ForceSucInstancesResponse>(req, "ForceSucInstances");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public ForceSucInstancesResponse ForceSucInstancesSync(ForceSucInstancesRequest req)
        {
            return InternalRequestAsync<ForceSucInstancesResponse>(req, "ForceSucInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例强制成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="ForceSucScheduleInstancesResponse"/></returns>
        public Task<ForceSucScheduleInstancesResponse> ForceSucScheduleInstances(ForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<ForceSucScheduleInstancesResponse>(req, "ForceSucScheduleInstances");
        }

        /// <summary>
        /// 实例强制成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="ForceSucScheduleInstancesResponse"/></returns>
        public ForceSucScheduleInstancesResponse ForceSucScheduleInstancesSync(ForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<ForceSucScheduleInstancesResponse>(req, "ForceSucScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 任务运维-批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public Task<FreezeOpsTasksResponse> FreezeOpsTasks(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks");
        }

        /// <summary>
        /// 任务运维-批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeOpsTasksRequest"/></param>
        /// <returns><see cref="FreezeOpsTasksResponse"/></returns>
        public FreezeOpsTasksResponse FreezeOpsTasksSync(FreezeOpsTasksRequest req)
        {
            return InternalRequestAsync<FreezeOpsTasksResponse>(req, "FreezeOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public Task<FreezeTasksResponse> FreezeTasks(FreezeTasksRequest req)
        {
            return InternalRequestAsync<FreezeTasksResponse>(req, "FreezeTasks");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public FreezeTasksResponse FreezeTasksSync(FreezeTasksRequest req)
        {
            return InternalRequestAsync<FreezeTasksResponse>(req, "FreezeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public Task<FreezeTasksByMultiWorkflowResponse> FreezeTasksByMultiWorkflow(FreezeTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<FreezeTasksByMultiWorkflowResponse>(req, "FreezeTasksByMultiWorkflow");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public FreezeTasksByMultiWorkflowResponse FreezeTasksByMultiWorkflowSync(FreezeTasksByMultiWorkflowRequest req)
        {
            return InternalRequestAsync<FreezeTasksByMultiWorkflowResponse>(req, "FreezeTasksByMultiWorkflow")
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
        /// 获取高级运行参数
        /// </summary>
        /// <param name="req"><see cref="GetAdvanceRunParamsRequest"/></param>
        /// <returns><see cref="GetAdvanceRunParamsResponse"/></returns>
        public Task<GetAdvanceRunParamsResponse> GetAdvanceRunParams(GetAdvanceRunParamsRequest req)
        {
            return InternalRequestAsync<GetAdvanceRunParamsResponse>(req, "GetAdvanceRunParams");
        }

        /// <summary>
        /// 获取高级运行参数
        /// </summary>
        /// <param name="req"><see cref="GetAdvanceRunParamsRequest"/></param>
        /// <returns><see cref="GetAdvanceRunParamsResponse"/></returns>
        public GetAdvanceRunParamsResponse GetAdvanceRunParamsSync(GetAdvanceRunParamsRequest req)
        {
            return InternalRequestAsync<GetAdvanceRunParamsResponse>(req, "GetAdvanceRunParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批量操作错误日志
        /// </summary>
        /// <param name="req"><see cref="GetBatchDetailErrorLogRequest"/></param>
        /// <returns><see cref="GetBatchDetailErrorLogResponse"/></returns>
        public Task<GetBatchDetailErrorLogResponse> GetBatchDetailErrorLog(GetBatchDetailErrorLogRequest req)
        {
            return InternalRequestAsync<GetBatchDetailErrorLogResponse>(req, "GetBatchDetailErrorLog");
        }

        /// <summary>
        /// 获取批量操作错误日志
        /// </summary>
        /// <param name="req"><see cref="GetBatchDetailErrorLogRequest"/></param>
        /// <returns><see cref="GetBatchDetailErrorLogResponse"/></returns>
        public GetBatchDetailErrorLogResponse GetBatchDetailErrorLogSync(GetBatchDetailErrorLogRequest req)
        {
            return InternalRequestAsync<GetBatchDetailErrorLogResponse>(req, "GetBatchDetailErrorLog")
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
        /// 开发空间获取最近一次测试运行记录信息
        /// </summary>
        /// <param name="req"><see cref="GetLatestAnalyseInfoRequest"/></param>
        /// <returns><see cref="GetLatestAnalyseInfoResponse"/></returns>
        public Task<GetLatestAnalyseInfoResponse> GetLatestAnalyseInfo(GetLatestAnalyseInfoRequest req)
        {
            return InternalRequestAsync<GetLatestAnalyseInfoResponse>(req, "GetLatestAnalyseInfo");
        }

        /// <summary>
        /// 开发空间获取最近一次测试运行记录信息
        /// </summary>
        /// <param name="req"><see cref="GetLatestAnalyseInfoRequest"/></param>
        /// <returns><see cref="GetLatestAnalyseInfoResponse"/></returns>
        public GetLatestAnalyseInfoResponse GetLatestAnalyseInfoSync(GetLatestAnalyseInfoRequest req)
        {
            return InternalRequestAsync<GetLatestAnalyseInfoResponse>(req, "GetLatestAnalyseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编排空间获取最近一次测试运行记录信息
        /// </summary>
        /// <param name="req"><see cref="GetLatestTestRunInfoRequest"/></param>
        /// <returns><see cref="GetLatestTestRunInfoResponse"/></returns>
        public Task<GetLatestTestRunInfoResponse> GetLatestTestRunInfo(GetLatestTestRunInfoRequest req)
        {
            return InternalRequestAsync<GetLatestTestRunInfoResponse>(req, "GetLatestTestRunInfo");
        }

        /// <summary>
        /// 编排空间获取最近一次测试运行记录信息
        /// </summary>
        /// <param name="req"><see cref="GetLatestTestRunInfoRequest"/></param>
        /// <returns><see cref="GetLatestTestRunInfoResponse"/></returns>
        public GetLatestTestRunInfoResponse GetLatestTestRunInfoSync(GetLatestTestRunInfoRequest req)
        {
            return InternalRequestAsync<GetLatestTestRunInfoResponse>(req, "GetLatestTestRunInfo")
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
        /// 回收站脚本文件目录树
        /// </summary>
        /// <param name="req"><see cref="GetPathTreesRequest"/></param>
        /// <returns><see cref="GetPathTreesResponse"/></returns>
        public Task<GetPathTreesResponse> GetPathTrees(GetPathTreesRequest req)
        {
            return InternalRequestAsync<GetPathTreesResponse>(req, "GetPathTrees");
        }

        /// <summary>
        /// 回收站脚本文件目录树
        /// </summary>
        /// <param name="req"><see cref="GetPathTreesRequest"/></param>
        /// <returns><see cref="GetPathTreesResponse"/></returns>
        public GetPathTreesResponse GetPathTreesSync(GetPathTreesRequest req)
        {
            return InternalRequestAsync<GetPathTreesResponse>(req, "GetPathTrees")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-获取资源上传的可用 cos 路径
        /// </summary>
        /// <param name="req"><see cref="GetResourceCosPathRequest"/></param>
        /// <returns><see cref="GetResourceCosPathResponse"/></returns>
        public Task<GetResourceCosPathResponse> GetResourceCosPath(GetResourceCosPathRequest req)
        {
            return InternalRequestAsync<GetResourceCosPathResponse>(req, "GetResourceCosPath");
        }

        /// <summary>
        /// 资源管理-获取资源上传的可用 cos 路径
        /// </summary>
        /// <param name="req"><see cref="GetResourceCosPathRequest"/></param>
        /// <returns><see cref="GetResourceCosPathResponse"/></returns>
        public GetResourceCosPathResponse GetResourceCosPathSync(GetResourceCosPathRequest req)
        {
            return InternalRequestAsync<GetResourceCosPathResponse>(req, "GetResourceCosPath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-拉取资源目录树
        /// </summary>
        /// <param name="req"><see cref="GetResourcePathTreeRequest"/></param>
        /// <returns><see cref="GetResourcePathTreeResponse"/></returns>
        public Task<GetResourcePathTreeResponse> GetResourcePathTree(GetResourcePathTreeRequest req)
        {
            return InternalRequestAsync<GetResourcePathTreeResponse>(req, "GetResourcePathTree");
        }

        /// <summary>
        /// 资源管理-拉取资源目录树
        /// </summary>
        /// <param name="req"><see cref="GetResourcePathTreeRequest"/></param>
        /// <returns><see cref="GetResourcePathTreeResponse"/></returns>
        public GetResourcePathTreeResponse GetResourcePathTreeSync(GetResourcePathTreeRequest req)
        {
            return InternalRequestAsync<GetResourcePathTreeResponse>(req, "GetResourcePathTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作流运行任务下游Ds
        /// </summary>
        /// <param name="req"><see cref="GetRunSonListDsRequest"/></param>
        /// <returns><see cref="GetRunSonListDsResponse"/></returns>
        public Task<GetRunSonListDsResponse> GetRunSonListDs(GetRunSonListDsRequest req)
        {
            return InternalRequestAsync<GetRunSonListDsResponse>(req, "GetRunSonListDs");
        }

        /// <summary>
        /// 获取工作流运行任务下游Ds
        /// </summary>
        /// <param name="req"><see cref="GetRunSonListDsRequest"/></param>
        /// <returns><see cref="GetRunSonListDsResponse"/></returns>
        public GetRunSonListDsResponse GetRunSonListDsSync(GetRunSonListDsRequest req)
        {
            return InternalRequestAsync<GetRunSonListDsResponse>(req, "GetRunSonListDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取调试任务实例状态信息
        /// </summary>
        /// <param name="req"><see cref="GetTestRunTaskInstancesStatusInfoRequest"/></param>
        /// <returns><see cref="GetTestRunTaskInstancesStatusInfoResponse"/></returns>
        public Task<GetTestRunTaskInstancesStatusInfoResponse> GetTestRunTaskInstancesStatusInfo(GetTestRunTaskInstancesStatusInfoRequest req)
        {
            return InternalRequestAsync<GetTestRunTaskInstancesStatusInfoResponse>(req, "GetTestRunTaskInstancesStatusInfo");
        }

        /// <summary>
        /// 获取调试任务实例状态信息
        /// </summary>
        /// <param name="req"><see cref="GetTestRunTaskInstancesStatusInfoRequest"/></param>
        /// <returns><see cref="GetTestRunTaskInstancesStatusInfoResponse"/></returns>
        public GetTestRunTaskInstancesStatusInfoResponse GetTestRunTaskInstancesStatusInfoSync(GetTestRunTaskInstancesStatusInfoRequest req)
        {
            return InternalRequestAsync<GetTestRunTaskInstancesStatusInfoResponse>(req, "GetTestRunTaskInstancesStatusInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 协同编辑资源锁心跳
        /// </summary>
        /// <param name="req"><see cref="HeartBeatRequest"/></param>
        /// <returns><see cref="HeartBeatResponse"/></returns>
        public Task<HeartBeatResponse> HeartBeat(HeartBeatRequest req)
        {
            return InternalRequestAsync<HeartBeatResponse>(req, "HeartBeat");
        }

        /// <summary>
        /// 协同编辑资源锁心跳
        /// </summary>
        /// <param name="req"><see cref="HeartBeatRequest"/></param>
        /// <returns><see cref="HeartBeatResponse"/></returns>
        public HeartBeatResponse HeartBeatSync(HeartBeatRequest req)
        {
            return InternalRequestAsync<HeartBeatResponse>(req, "HeartBeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件管理-导入事件
        /// </summary>
        /// <param name="req"><see cref="ImportDsEventRequest"/></param>
        /// <returns><see cref="ImportDsEventResponse"/></returns>
        public Task<ImportDsEventResponse> ImportDsEvent(ImportDsEventRequest req)
        {
            return InternalRequestAsync<ImportDsEventResponse>(req, "ImportDsEvent");
        }

        /// <summary>
        /// 事件管理-导入事件
        /// </summary>
        /// <param name="req"><see cref="ImportDsEventRequest"/></param>
        /// <returns><see cref="ImportDsEventResponse"/></returns>
        public ImportDsEventResponse ImportDsEventSync(ImportDsEventRequest req)
        {
            return InternalRequestAsync<ImportDsEventResponse>(req, "ImportDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量导入文件
        /// </summary>
        /// <param name="req"><see cref="ImportFilesRequest"/></param>
        /// <returns><see cref="ImportFilesResponse"/></returns>
        public Task<ImportFilesResponse> ImportFiles(ImportFilesRequest req)
        {
            return InternalRequestAsync<ImportFilesResponse>(req, "ImportFiles");
        }

        /// <summary>
        /// 批量导入文件
        /// </summary>
        /// <param name="req"><see cref="ImportFilesRequest"/></param>
        /// <returns><see cref="ImportFilesResponse"/></returns>
        public ImportFilesResponse ImportFilesSync(ImportFilesRequest req)
        {
            return InternalRequestAsync<ImportFilesResponse>(req, "ImportFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步导入集成任务
        /// </summary>
        /// <param name="req"><see cref="ImportOfflineTaskRequest"/></param>
        /// <returns><see cref="ImportOfflineTaskResponse"/></returns>
        public Task<ImportOfflineTaskResponse> ImportOfflineTask(ImportOfflineTaskRequest req)
        {
            return InternalRequestAsync<ImportOfflineTaskResponse>(req, "ImportOfflineTask");
        }

        /// <summary>
        /// 异步导入集成任务
        /// </summary>
        /// <param name="req"><see cref="ImportOfflineTaskRequest"/></param>
        /// <returns><see cref="ImportOfflineTaskResponse"/></returns>
        public ImportOfflineTaskResponse ImportOfflineTaskSync(ImportOfflineTaskRequest req)
        {
            return InternalRequestAsync<ImportOfflineTaskResponse>(req, "ImportOfflineTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入项目参数
        /// </summary>
        /// <param name="req"><see cref="ImportProjectParamDsRequest"/></param>
        /// <returns><see cref="ImportProjectParamDsResponse"/></returns>
        public Task<ImportProjectParamDsResponse> ImportProjectParamDs(ImportProjectParamDsRequest req)
        {
            return InternalRequestAsync<ImportProjectParamDsResponse>(req, "ImportProjectParamDs");
        }

        /// <summary>
        /// 导入项目参数
        /// </summary>
        /// <param name="req"><see cref="ImportProjectParamDsRequest"/></param>
        /// <returns><see cref="ImportProjectParamDsResponse"/></returns>
        public ImportProjectParamDsResponse ImportProjectParamDsSync(ImportProjectParamDsRequest req)
        {
            return InternalRequestAsync<ImportProjectParamDsResponse>(req, "ImportProjectParamDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据表：HIVE
        /// </summary>
        /// <param name="req"><see cref="ImportTableDataRequest"/></param>
        /// <returns><see cref="ImportTableDataResponse"/></returns>
        public Task<ImportTableDataResponse> ImportTableData(ImportTableDataRequest req)
        {
            return InternalRequestAsync<ImportTableDataResponse>(req, "ImportTableData");
        }

        /// <summary>
        /// 创建数据表：HIVE
        /// </summary>
        /// <param name="req"><see cref="ImportTableDataRequest"/></param>
        /// <returns><see cref="ImportTableDataResponse"/></returns>
        public ImportTableDataResponse ImportTableDataSync(ImportTableDataRequest req)
        {
            return InternalRequestAsync<ImportTableDataResponse>(req, "ImportTableData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 工作流导入（XML）
        /// </summary>
        /// <param name="req"><see cref="ImportWorkflowXmlRequest"/></param>
        /// <returns><see cref="ImportWorkflowXmlResponse"/></returns>
        public Task<ImportWorkflowXmlResponse> ImportWorkflowXml(ImportWorkflowXmlRequest req)
        {
            return InternalRequestAsync<ImportWorkflowXmlResponse>(req, "ImportWorkflowXml");
        }

        /// <summary>
        /// 工作流导入（XML）
        /// </summary>
        /// <param name="req"><see cref="ImportWorkflowXmlRequest"/></param>
        /// <returns><see cref="ImportWorkflowXmlResponse"/></returns>
        public ImportWorkflowXmlResponse ImportWorkflowXmlSync(ImportWorkflowXmlRequest req)
        {
            return InternalRequestAsync<ImportWorkflowXmlResponse>(req, "ImportWorkflowXml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 工作流导入（ZIP）
        /// </summary>
        /// <param name="req"><see cref="ImportWorkflowZipRequest"/></param>
        /// <returns><see cref="ImportWorkflowZipResponse"/></returns>
        public Task<ImportWorkflowZipResponse> ImportWorkflowZip(ImportWorkflowZipRequest req)
        {
            return InternalRequestAsync<ImportWorkflowZipResponse>(req, "ImportWorkflowZip");
        }

        /// <summary>
        /// 工作流导入（ZIP）
        /// </summary>
        /// <param name="req"><see cref="ImportWorkflowZipRequest"/></param>
        /// <returns><see cref="ImportWorkflowZipResponse"/></returns>
        public ImportWorkflowZipResponse ImportWorkflowZipSync(ImportWorkflowZipRequest req)
        {
            return InternalRequestAsync<ImportWorkflowZipResponse>(req, "ImportWorkflowZip")
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
        /// 任务是否存在监听事件
        /// </summary>
        /// <param name="req"><see cref="JudgeTaskListenEventRequest"/></param>
        /// <returns><see cref="JudgeTaskListenEventResponse"/></returns>
        public Task<JudgeTaskListenEventResponse> JudgeTaskListenEvent(JudgeTaskListenEventRequest req)
        {
            return InternalRequestAsync<JudgeTaskListenEventResponse>(req, "JudgeTaskListenEvent");
        }

        /// <summary>
        /// 任务是否存在监听事件
        /// </summary>
        /// <param name="req"><see cref="JudgeTaskListenEventRequest"/></param>
        /// <returns><see cref="JudgeTaskListenEventResponse"/></returns>
        public JudgeTaskListenEventResponse JudgeTaskListenEventSync(JudgeTaskListenEventRequest req)
        {
            return InternalRequestAsync<JudgeTaskListenEventResponse>(req, "JudgeTaskListenEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public Task<KillInstancesResponse> KillInstances(KillInstancesRequest req)
        {
            return InternalRequestAsync<KillInstancesResponse>(req, "KillInstances");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public KillInstancesResponse KillInstancesSync(KillInstancesRequest req)
        {
            return InternalRequestAsync<KillInstancesResponse>(req, "KillInstances")
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
        /// 批量kill实例
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public Task<KillScheduleInstancesResponse> KillScheduleInstances(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances");
        }

        /// <summary>
        /// 批量kill实例
        /// </summary>
        /// <param name="req"><see cref="KillScheduleInstancesRequest"/></param>
        /// <returns><see cref="KillScheduleInstancesResponse"/></returns>
        public KillScheduleInstancesResponse KillScheduleInstancesSync(KillScheduleInstancesRequest req)
        {
            return InternalRequestAsync<KillScheduleInstancesResponse>(req, "KillScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止试运行任务（多个）
        /// </summary>
        /// <param name="req"><see cref="KillTasksTestRunRequest"/></param>
        /// <returns><see cref="KillTasksTestRunResponse"/></returns>
        public Task<KillTasksTestRunResponse> KillTasksTestRun(KillTasksTestRunRequest req)
        {
            return InternalRequestAsync<KillTasksTestRunResponse>(req, "KillTasksTestRun");
        }

        /// <summary>
        /// 停止试运行任务（多个）
        /// </summary>
        /// <param name="req"><see cref="KillTasksTestRunRequest"/></param>
        /// <returns><see cref="KillTasksTestRunResponse"/></returns>
        public KillTasksTestRunResponse KillTasksTestRunSync(KillTasksTestRunRequest req)
        {
            return InternalRequestAsync<KillTasksTestRunResponse>(req, "KillTasksTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取操作详情列表
        /// </summary>
        /// <param name="req"><see cref="ListBatchDetailRequest"/></param>
        /// <returns><see cref="ListBatchDetailResponse"/></returns>
        public Task<ListBatchDetailResponse> ListBatchDetail(ListBatchDetailRequest req)
        {
            return InternalRequestAsync<ListBatchDetailResponse>(req, "ListBatchDetail");
        }

        /// <summary>
        /// 获取操作详情列表
        /// </summary>
        /// <param name="req"><see cref="ListBatchDetailRequest"/></param>
        /// <returns><see cref="ListBatchDetailResponse"/></returns>
        public ListBatchDetailResponse ListBatchDetailSync(ListBatchDetailRequest req)
        {
            return InternalRequestAsync<ListBatchDetailResponse>(req, "ListBatchDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取操作历史列表
        /// </summary>
        /// <param name="req"><see cref="ListBatchJobRequest"/></param>
        /// <returns><see cref="ListBatchJobResponse"/></returns>
        public Task<ListBatchJobResponse> ListBatchJob(ListBatchJobRequest req)
        {
            return InternalRequestAsync<ListBatchJobResponse>(req, "ListBatchJob");
        }

        /// <summary>
        /// 获取操作历史列表
        /// </summary>
        /// <param name="req"><see cref="ListBatchJobRequest"/></param>
        /// <returns><see cref="ListBatchJobResponse"/></returns>
        public ListBatchJobResponse ListBatchJobSync(ListBatchJobRequest req)
        {
            return InternalRequestAsync<ListBatchJobResponse>(req, "ListBatchJob")
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
        /// 任务批量补录，调度状态任务才可以补录；
        /// </summary>
        /// <param name="req"><see cref="MakeUpOpsTasksRequest"/></param>
        /// <returns><see cref="MakeUpOpsTasksResponse"/></returns>
        public Task<MakeUpOpsTasksResponse> MakeUpOpsTasks(MakeUpOpsTasksRequest req)
        {
            return InternalRequestAsync<MakeUpOpsTasksResponse>(req, "MakeUpOpsTasks");
        }

        /// <summary>
        /// 任务批量补录，调度状态任务才可以补录；
        /// </summary>
        /// <param name="req"><see cref="MakeUpOpsTasksRequest"/></param>
        /// <returns><see cref="MakeUpOpsTasksResponse"/></returns>
        public MakeUpOpsTasksResponse MakeUpOpsTasksSync(MakeUpOpsTasksRequest req)
        {
            return InternalRequestAsync<MakeUpOpsTasksResponse>(req, "MakeUpOpsTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 工作流补数据
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksByWorkflowRequest"/></param>
        /// <returns><see cref="MakeUpTasksByWorkflowResponse"/></returns>
        public Task<MakeUpTasksByWorkflowResponse> MakeUpTasksByWorkflow(MakeUpTasksByWorkflowRequest req)
        {
            return InternalRequestAsync<MakeUpTasksByWorkflowResponse>(req, "MakeUpTasksByWorkflow");
        }

        /// <summary>
        /// 工作流补数据
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksByWorkflowRequest"/></param>
        /// <returns><see cref="MakeUpTasksByWorkflowResponse"/></returns>
        public MakeUpTasksByWorkflowResponse MakeUpTasksByWorkflowSync(MakeUpTasksByWorkflowRequest req)
        {
            return InternalRequestAsync<MakeUpTasksByWorkflowResponse>(req, "MakeUpTasksByWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public Task<MakeUpTasksNewResponse> MakeUpTasksNew(MakeUpTasksNewRequest req)
        {
            return InternalRequestAsync<MakeUpTasksNewResponse>(req, "MakeUpTasksNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public MakeUpTasksNewResponse MakeUpTasksNewSync(MakeUpTasksNewRequest req)
        {
            return InternalRequestAsync<MakeUpTasksNewResponse>(req, "MakeUpTasksNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public Task<MakeUpWorkflowNewResponse> MakeUpWorkflowNew(MakeUpWorkflowNewRequest req)
        {
            return InternalRequestAsync<MakeUpWorkflowNewResponse>(req, "MakeUpWorkflowNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public MakeUpWorkflowNewResponse MakeUpWorkflowNewSync(MakeUpWorkflowNewRequest req)
        {
            return InternalRequestAsync<MakeUpWorkflowNewResponse>(req, "MakeUpWorkflowNew")
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
        /// 编辑基线告警状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineAlarmStatusRequest"/></param>
        /// <returns><see cref="ModifyBaselineAlarmStatusResponse"/></returns>
        public Task<ModifyBaselineAlarmStatusResponse> ModifyBaselineAlarmStatus(ModifyBaselineAlarmStatusRequest req)
        {
            return InternalRequestAsync<ModifyBaselineAlarmStatusResponse>(req, "ModifyBaselineAlarmStatus");
        }

        /// <summary>
        /// 编辑基线告警状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineAlarmStatusRequest"/></param>
        /// <returns><see cref="ModifyBaselineAlarmStatusResponse"/></returns>
        public ModifyBaselineAlarmStatusResponse ModifyBaselineAlarmStatusSync(ModifyBaselineAlarmStatusRequest req)
        {
            return InternalRequestAsync<ModifyBaselineAlarmStatusResponse>(req, "ModifyBaselineAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑基线实例中任务告警状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineTaskAlarmStatusRequest"/></param>
        /// <returns><see cref="ModifyBaselineTaskAlarmStatusResponse"/></returns>
        public Task<ModifyBaselineTaskAlarmStatusResponse> ModifyBaselineTaskAlarmStatus(ModifyBaselineTaskAlarmStatusRequest req)
        {
            return InternalRequestAsync<ModifyBaselineTaskAlarmStatusResponse>(req, "ModifyBaselineTaskAlarmStatus");
        }

        /// <summary>
        /// 编辑基线实例中任务告警状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineTaskAlarmStatusRequest"/></param>
        /// <returns><see cref="ModifyBaselineTaskAlarmStatusResponse"/></returns>
        public ModifyBaselineTaskAlarmStatusResponse ModifyBaselineTaskAlarmStatusSync(ModifyBaselineTaskAlarmStatusRequest req)
        {
            return InternalRequestAsync<ModifyBaselineTaskAlarmStatusResponse>(req, "ModifyBaselineTaskAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public Task<ModifyDataSourceResponse> ModifyDataSource(ModifyDataSourceRequest req)
        {
            return InternalRequestAsync<ModifyDataSourceResponse>(req, "ModifyDataSource");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public Task<ModifyFolderResponse> ModifyFolder(ModifyFolderRequest req)
        {
            return InternalRequestAsync<ModifyFolderResponse>(req, "ModifyFolder");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public ModifyFolderResponse ModifyFolderSync(ModifyFolderRequest req)
        {
            return InternalRequestAsync<ModifyFolderResponse>(req, "ModifyFolder")
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
        /// 编排空间-工作流-创建任务文件夹
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskFolderRequest"/></param>
        /// <returns><see cref="ModifyTaskFolderResponse"/></returns>
        public Task<ModifyTaskFolderResponse> ModifyTaskFolder(ModifyTaskFolderRequest req)
        {
            return InternalRequestAsync<ModifyTaskFolderResponse>(req, "ModifyTaskFolder");
        }

        /// <summary>
        /// 编排空间-工作流-创建任务文件夹
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskFolderRequest"/></param>
        /// <returns><see cref="ModifyTaskFolderResponse"/></returns>
        public ModifyTaskFolderResponse ModifyTaskFolderSync(ModifyTaskFolderRequest req)
        {
            return InternalRequestAsync<ModifyTaskFolderResponse>(req, "ModifyTaskFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public Task<ModifyTaskInfoResponse> ModifyTaskInfo(ModifyTaskInfoRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoResponse>(req, "ModifyTaskInfo");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoDsRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoDsResponse"/></returns>
        public Task<ModifyTaskInfoDsResponse> ModifyTaskInfoDs(ModifyTaskInfoDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoDsResponse>(req, "ModifyTaskInfoDs");
        }

        /// <summary>
        /// 更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoDsRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoDsResponse"/></returns>
        public ModifyTaskInfoDsResponse ModifyTaskInfoDsSync(ModifyTaskInfoDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskInfoDsResponse>(req, "ModifyTaskInfoDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public Task<ModifyTaskLinksResponse> ModifyTaskLinks(ModifyTaskLinksRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksResponse>(req, "ModifyTaskLinks");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksDsRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksDsResponse"/></returns>
        public Task<ModifyTaskLinksDsResponse> ModifyTaskLinksDs(ModifyTaskLinksDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksDsResponse>(req, "ModifyTaskLinksDs");
        }

        /// <summary>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksDsRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksDsResponse"/></returns>
        public ModifyTaskLinksDsResponse ModifyTaskLinksDsSync(ModifyTaskLinksDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskLinksDsResponse>(req, "ModifyTaskLinksDs")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public Task<ModifyTaskScriptResponse> ModifyTaskScript(ModifyTaskScriptRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptResponse>(req, "ModifyTaskScript");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 修改任务脚本Ds
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptDsRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptDsResponse"/></returns>
        public Task<ModifyTaskScriptDsResponse> ModifyTaskScriptDs(ModifyTaskScriptDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptDsResponse>(req, "ModifyTaskScriptDs");
        }

        /// <summary>
        /// 修改任务脚本Ds
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptDsRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptDsResponse"/></returns>
        public ModifyTaskScriptDsResponse ModifyTaskScriptDsSync(ModifyTaskScriptDsRequest req)
        {
            return InternalRequestAsync<ModifyTaskScriptDsResponse>(req, "ModifyTaskScriptDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public Task<ModifyWorkflowInfoResponse> ModifyWorkflowInfo(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public ModifyWorkflowInfoResponse ModifyWorkflowInfoSync(ModifyWorkflowInfoRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowInfoResponse>(req, "ModifyWorkflowInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public Task<ModifyWorkflowScheduleResponse> ModifyWorkflowSchedule(ModifyWorkflowScheduleRequest req)
        {
            return InternalRequestAsync<ModifyWorkflowScheduleResponse>(req, "ModifyWorkflowSchedule");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 移动文件
        /// </summary>
        /// <param name="req"><see cref="MoveFileRequest"/></param>
        /// <returns><see cref="MoveFileResponse"/></returns>
        public Task<MoveFileResponse> MoveFile(MoveFileRequest req)
        {
            return InternalRequestAsync<MoveFileResponse>(req, "MoveFile");
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="req"><see cref="MoveFileRequest"/></param>
        /// <returns><see cref="MoveFileResponse"/></returns>
        public MoveFileResponse MoveFileSync(MoveFileRequest req)
        {
            return InternalRequestAsync<MoveFileResponse>(req, "MoveFile")
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
        /// 库表管理-新建数据表-csv预览，最多支持500行预览
        /// </summary>
        /// <param name="req"><see cref="PreviewDataTableCsvRequest"/></param>
        /// <returns><see cref="PreviewDataTableCsvResponse"/></returns>
        public Task<PreviewDataTableCsvResponse> PreviewDataTableCsv(PreviewDataTableCsvRequest req)
        {
            return InternalRequestAsync<PreviewDataTableCsvResponse>(req, "PreviewDataTableCsv");
        }

        /// <summary>
        /// 库表管理-新建数据表-csv预览，最多支持500行预览
        /// </summary>
        /// <param name="req"><see cref="PreviewDataTableCsvRequest"/></param>
        /// <returns><see cref="PreviewDataTableCsvResponse"/></returns>
        public PreviewDataTableCsvResponse PreviewDataTableCsvSync(PreviewDataTableCsvRequest req)
        {
            return InternalRequestAsync<PreviewDataTableCsvResponse>(req, "PreviewDataTableCsv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作流版本信息
        /// </summary>
        /// <param name="req"><see cref="QueryWorkflowVersionRequest"/></param>
        /// <returns><see cref="QueryWorkflowVersionResponse"/></returns>
        public Task<QueryWorkflowVersionResponse> QueryWorkflowVersion(QueryWorkflowVersionRequest req)
        {
            return InternalRequestAsync<QueryWorkflowVersionResponse>(req, "QueryWorkflowVersion");
        }

        /// <summary>
        /// 查询工作流版本信息
        /// </summary>
        /// <param name="req"><see cref="QueryWorkflowVersionRequest"/></param>
        /// <returns><see cref="QueryWorkflowVersionResponse"/></returns>
        public QueryWorkflowVersionResponse QueryWorkflowVersionSync(QueryWorkflowVersionRequest req)
        {
            return InternalRequestAsync<QueryWorkflowVersionResponse>(req, "QueryWorkflowVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventRequest"/></param>
        /// <returns><see cref="RegisterDsEventResponse"/></returns>
        public Task<RegisterDsEventResponse> RegisterDsEvent(RegisterDsEventRequest req)
        {
            return InternalRequestAsync<RegisterDsEventResponse>(req, "RegisterDsEvent");
        }

        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventRequest"/></param>
        /// <returns><see cref="RegisterDsEventResponse"/></returns>
        public RegisterDsEventResponse RegisterDsEventSync(RegisterDsEventRequest req)
        {
            return InternalRequestAsync<RegisterDsEventResponse>(req, "RegisterDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册事件监听者
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventListenerRequest"/></param>
        /// <returns><see cref="RegisterDsEventListenerResponse"/></returns>
        public Task<RegisterDsEventListenerResponse> RegisterDsEventListener(RegisterDsEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterDsEventListenerResponse>(req, "RegisterDsEventListener");
        }

        /// <summary>
        /// 注册事件监听者
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventListenerRequest"/></param>
        /// <returns><see cref="RegisterDsEventListenerResponse"/></returns>
        public RegisterDsEventListenerResponse RegisterDsEventListenerSync(RegisterDsEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterDsEventListenerResponse>(req, "RegisterDsEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册事件发布者
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventPublisherRequest"/></param>
        /// <returns><see cref="RegisterDsEventPublisherResponse"/></returns>
        public Task<RegisterDsEventPublisherResponse> RegisterDsEventPublisher(RegisterDsEventPublisherRequest req)
        {
            return InternalRequestAsync<RegisterDsEventPublisherResponse>(req, "RegisterDsEventPublisher");
        }

        /// <summary>
        /// 注册事件发布者
        /// </summary>
        /// <param name="req"><see cref="RegisterDsEventPublisherRequest"/></param>
        /// <returns><see cref="RegisterDsEventPublisherResponse"/></returns>
        public RegisterDsEventPublisherResponse RegisterDsEventPublisherSync(RegisterDsEventPublisherRequest req)
        {
            return InternalRequestAsync<RegisterDsEventPublisherResponse>(req, "RegisterDsEventPublisher")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public Task<RegisterEventResponse> RegisterEvent(RegisterEventRequest req)
        {
            return InternalRequestAsync<RegisterEventResponse>(req, "RegisterEvent");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public Task<RegisterEventListenerResponse> RegisterEventListener(RegisterEventListenerRequest req)
        {
            return InternalRequestAsync<RegisterEventListenerResponse>(req, "RegisterEventListener");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 释放协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="ReleaseLockRequest"/></param>
        /// <returns><see cref="ReleaseLockResponse"/></returns>
        public Task<ReleaseLockResponse> ReleaseLock(ReleaseLockRequest req)
        {
            return InternalRequestAsync<ReleaseLockResponse>(req, "ReleaseLock");
        }

        /// <summary>
        /// 释放协同编辑资源锁
        /// </summary>
        /// <param name="req"><see cref="ReleaseLockRequest"/></param>
        /// <returns><see cref="ReleaseLockResponse"/></returns>
        public ReleaseLockResponse ReleaseLockSync(ReleaseLockRequest req)
        {
            return InternalRequestAsync<ReleaseLockResponse>(req, "ReleaseLock")
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
        /// 重命名文件
        /// </summary>
        /// <param name="req"><see cref="RenameFileRequest"/></param>
        /// <returns><see cref="RenameFileResponse"/></returns>
        public Task<RenameFileResponse> RenameFile(RenameFileRequest req)
        {
            return InternalRequestAsync<RenameFileResponse>(req, "RenameFile");
        }

        /// <summary>
        /// 重命名文件
        /// </summary>
        /// <param name="req"><see cref="RenameFileRequest"/></param>
        /// <returns><see cref="RenameFileResponse"/></returns>
        public RenameFileResponse RenameFileSync(RenameFileRequest req)
        {
            return InternalRequestAsync<RenameFileResponse>(req, "RenameFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-重命名资源
        /// </summary>
        /// <param name="req"><see cref="RenameResourceRequest"/></param>
        /// <returns><see cref="RenameResourceResponse"/></returns>
        public Task<RenameResourceResponse> RenameResource(RenameResourceRequest req)
        {
            return InternalRequestAsync<RenameResourceResponse>(req, "RenameResource");
        }

        /// <summary>
        /// 资源管理-重命名资源
        /// </summary>
        /// <param name="req"><see cref="RenameResourceRequest"/></param>
        /// <returns><see cref="RenameResourceResponse"/></returns>
        public RenameResourceResponse RenameResourceSync(RenameResourceRequest req)
        {
            return InternalRequestAsync<RenameResourceResponse>(req, "RenameResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-重命名资源文件
        /// </summary>
        /// <param name="req"><see cref="RenameResourceFileRequest"/></param>
        /// <returns><see cref="RenameResourceFileResponse"/></returns>
        public Task<RenameResourceFileResponse> RenameResourceFile(RenameResourceFileRequest req)
        {
            return InternalRequestAsync<RenameResourceFileResponse>(req, "RenameResourceFile");
        }

        /// <summary>
        /// 资源管理-重命名资源文件
        /// </summary>
        /// <param name="req"><see cref="RenameResourceFileRequest"/></param>
        /// <returns><see cref="RenameResourceFileResponse"/></returns>
        public RenameResourceFileResponse RenameResourceFileSync(RenameResourceFileRequest req)
        {
            return InternalRequestAsync<RenameResourceFileResponse>(req, "RenameResourceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源管理-重命名资源目录
        /// </summary>
        /// <param name="req"><see cref="RenameResourcePathRequest"/></param>
        /// <returns><see cref="RenameResourcePathResponse"/></returns>
        public Task<RenameResourcePathResponse> RenameResourcePath(RenameResourcePathRequest req)
        {
            return InternalRequestAsync<RenameResourcePathResponse>(req, "RenameResourcePath");
        }

        /// <summary>
        /// 资源管理-重命名资源目录
        /// </summary>
        /// <param name="req"><see cref="RenameResourcePathRequest"/></param>
        /// <returns><see cref="RenameResourcePathResponse"/></returns>
        public RenameResourcePathResponse RenameResourcePathSync(RenameResourcePathRequest req)
        {
            return InternalRequestAsync<RenameResourcePathResponse>(req, "RenameResourcePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RenameTaskDs
        /// </summary>
        /// <param name="req"><see cref="RenameTaskDsRequest"/></param>
        /// <returns><see cref="RenameTaskDsResponse"/></returns>
        public Task<RenameTaskDsResponse> RenameTaskDs(RenameTaskDsRequest req)
        {
            return InternalRequestAsync<RenameTaskDsResponse>(req, "RenameTaskDs");
        }

        /// <summary>
        /// RenameTaskDs
        /// </summary>
        /// <param name="req"><see cref="RenameTaskDsRequest"/></param>
        /// <returns><see cref="RenameTaskDsResponse"/></returns>
        public RenameTaskDsResponse RenameTaskDsSync(RenameTaskDsRequest req)
        {
            return InternalRequestAsync<RenameTaskDsResponse>(req, "RenameTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowDsResponse"/></returns>
        public Task<RenewWorkflowDsResponse> RenewWorkflowDs(RenewWorkflowDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowDsResponse>(req, "RenewWorkflowDs");
        }

        /// <summary>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowDsResponse"/></returns>
        public RenewWorkflowDsResponse RenewWorkflowDsSync(RenewWorkflowDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowDsResponse>(req, "RenewWorkflowDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动文件夹
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowFolderDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowFolderDsResponse"/></returns>
        public Task<RenewWorkflowFolderDsResponse> RenewWorkflowFolderDs(RenewWorkflowFolderDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowFolderDsResponse>(req, "RenewWorkflowFolderDs");
        }

        /// <summary>
        /// 移动文件夹
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowFolderDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowFolderDsResponse"/></returns>
        public RenewWorkflowFolderDsResponse RenewWorkflowFolderDsSync(RenewWorkflowFolderDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowFolderDsResponse>(req, "RenewWorkflowFolderDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新工作流下任务责任人
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowOwnerDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowOwnerDsResponse"/></returns>
        public Task<RenewWorkflowOwnerDsResponse> RenewWorkflowOwnerDs(RenewWorkflowOwnerDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowOwnerDsResponse>(req, "RenewWorkflowOwnerDs");
        }

        /// <summary>
        /// 批量更新工作流下任务责任人
        /// </summary>
        /// <param name="req"><see cref="RenewWorkflowOwnerDsRequest"/></param>
        /// <returns><see cref="RenewWorkflowOwnerDsResponse"/></returns>
        public RenewWorkflowOwnerDsResponse RenewWorkflowOwnerDsSync(RenewWorkflowOwnerDsRequest req)
        {
            return InternalRequestAsync<RenewWorkflowOwnerDsResponse>(req, "RenewWorkflowOwnerDs")
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
        /// 替换项目参数历史版本
        /// </summary>
        /// <param name="req"><see cref="ReplaceProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="ReplaceProjectParamVersionDsResponse"/></returns>
        public Task<ReplaceProjectParamVersionDsResponse> ReplaceProjectParamVersionDs(ReplaceProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<ReplaceProjectParamVersionDsResponse>(req, "ReplaceProjectParamVersionDs");
        }

        /// <summary>
        /// 替换项目参数历史版本
        /// </summary>
        /// <param name="req"><see cref="ReplaceProjectParamVersionDsRequest"/></param>
        /// <returns><see cref="ReplaceProjectParamVersionDsResponse"/></returns>
        public ReplaceProjectParamVersionDsResponse ReplaceProjectParamVersionDsSync(ReplaceProjectParamVersionDsRequest req)
        {
            return InternalRequestAsync<ReplaceProjectParamVersionDsResponse>(req, "ReplaceProjectParamVersionDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public Task<RerunInstancesResponse> RerunInstances(RerunInstancesRequest req)
        {
            return InternalRequestAsync<RerunInstancesResponse>(req, "RerunInstances");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public RerunInstancesResponse RerunInstancesSync(RerunInstancesRequest req)
        {
            return InternalRequestAsync<RerunInstancesResponse>(req, "RerunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按补录计划批量重跑/选择补录计划→补录任务→补录实例，点击重跑
        /// </summary>
        /// <param name="req"><see cref="RerunOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="RerunOpsMakePlanInstancesResponse"/></returns>
        public Task<RerunOpsMakePlanInstancesResponse> RerunOpsMakePlanInstances(RerunOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<RerunOpsMakePlanInstancesResponse>(req, "RerunOpsMakePlanInstances");
        }

        /// <summary>
        /// 按补录计划批量重跑/选择补录计划→补录任务→补录实例，点击重跑
        /// </summary>
        /// <param name="req"><see cref="RerunOpsMakePlanInstancesRequest"/></param>
        /// <returns><see cref="RerunOpsMakePlanInstancesResponse"/></returns>
        public RerunOpsMakePlanInstancesResponse RerunOpsMakePlanInstancesSync(RerunOpsMakePlanInstancesRequest req)
        {
            return InternalRequestAsync<RerunOpsMakePlanInstancesResponse>(req, "RerunOpsMakePlanInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RerunScheduleInstancesResponse"/></returns>
        public Task<RerunScheduleInstancesResponse> RerunScheduleInstances(RerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RerunScheduleInstancesResponse>(req, "RerunScheduleInstances");
        }

        /// <summary>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunScheduleInstancesRequest"/></param>
        /// <returns><see cref="RerunScheduleInstancesResponse"/></returns>
        public RerunScheduleInstancesResponse RerunScheduleInstancesSync(RerunScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RerunScheduleInstancesResponse>(req, "RerunScheduleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启采集器
        /// </summary>
        /// <param name="req"><see cref="RestartInLongAgentRequest"/></param>
        /// <returns><see cref="RestartInLongAgentResponse"/></returns>
        public Task<RestartInLongAgentResponse> RestartInLongAgent(RestartInLongAgentRequest req)
        {
            return InternalRequestAsync<RestartInLongAgentResponse>(req, "RestartInLongAgent");
        }

        /// <summary>
        /// 重启采集器
        /// </summary>
        /// <param name="req"><see cref="RestartInLongAgentRequest"/></param>
        /// <returns><see cref="RestartInLongAgentResponse"/></returns>
        public RestartInLongAgentResponse RestartInLongAgentSync(RestartInLongAgentRequest req)
        {
            return InternalRequestAsync<RestartInLongAgentResponse>(req, "RestartInLongAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 还原任务
        /// </summary>
        /// <param name="req"><see cref="RestoreRecycleTaskRequest"/></param>
        /// <returns><see cref="RestoreRecycleTaskResponse"/></returns>
        public Task<RestoreRecycleTaskResponse> RestoreRecycleTask(RestoreRecycleTaskRequest req)
        {
            return InternalRequestAsync<RestoreRecycleTaskResponse>(req, "RestoreRecycleTask");
        }

        /// <summary>
        /// 还原任务
        /// </summary>
        /// <param name="req"><see cref="RestoreRecycleTaskRequest"/></param>
        /// <returns><see cref="RestoreRecycleTaskResponse"/></returns>
        public RestoreRecycleTaskResponse RestoreRecycleTaskSync(RestoreRecycleTaskRequest req)
        {
            return InternalRequestAsync<RestoreRecycleTaskResponse>(req, "RestoreRecycleTask")
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
        /// 回滚自定义函数版本
        /// </summary>
        /// <param name="req"><see cref="RollbackCustomFunctionVersionRequest"/></param>
        /// <returns><see cref="RollbackCustomFunctionVersionResponse"/></returns>
        public Task<RollbackCustomFunctionVersionResponse> RollbackCustomFunctionVersion(RollbackCustomFunctionVersionRequest req)
        {
            return InternalRequestAsync<RollbackCustomFunctionVersionResponse>(req, "RollbackCustomFunctionVersion");
        }

        /// <summary>
        /// 回滚自定义函数版本
        /// </summary>
        /// <param name="req"><see cref="RollbackCustomFunctionVersionRequest"/></param>
        /// <returns><see cref="RollbackCustomFunctionVersionResponse"/></returns>
        public RollbackCustomFunctionVersionResponse RollbackCustomFunctionVersionSync(RollbackCustomFunctionVersionRequest req)
        {
            return InternalRequestAsync<RollbackCustomFunctionVersionResponse>(req, "RollbackCustomFunctionVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例强制成功
        /// </summary>
        /// <param name="req"><see cref="RunForceSucScheduleInstancesRequest"/></param>
        /// <returns><see cref="RunForceSucScheduleInstancesResponse"/></returns>
        public Task<RunForceSucScheduleInstancesResponse> RunForceSucScheduleInstances(RunForceSucScheduleInstancesRequest req)
        {
            return InternalRequestAsync<RunForceSucScheduleInstancesResponse>(req, "RunForceSucScheduleInstances");
        }

        /// <summary>
        /// 实例强制成功
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public Task<RunTaskResponse> RunTask(RunTaskRequest req)
        {
            return InternalRequestAsync<RunTaskResponse>(req, "RunTask");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public RunTaskResponse RunTaskSync(RunTaskRequest req)
        {
            return InternalRequestAsync<RunTaskResponse>(req, "RunTask")
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
        /// 批量保存任务位置
        /// </summary>
        /// <param name="req"><see cref="SavePositionsDsRequest"/></param>
        /// <returns><see cref="SavePositionsDsResponse"/></returns>
        public Task<SavePositionsDsResponse> SavePositionsDs(SavePositionsDsRequest req)
        {
            return InternalRequestAsync<SavePositionsDsResponse>(req, "SavePositionsDs");
        }

        /// <summary>
        /// 批量保存任务位置
        /// </summary>
        /// <param name="req"><see cref="SavePositionsDsRequest"/></param>
        /// <returns><see cref="SavePositionsDsResponse"/></returns>
        public SavePositionsDsResponse SavePositionsDsSync(SavePositionsDsRequest req)
        {
            return InternalRequestAsync<SavePositionsDsResponse>(req, "SavePositionsDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断脚本文件是否被任务列表所引用
        /// </summary>
        /// <param name="req"><see cref="ScriptUsedByOtherTaskDsRequest"/></param>
        /// <returns><see cref="ScriptUsedByOtherTaskDsResponse"/></returns>
        public Task<ScriptUsedByOtherTaskDsResponse> ScriptUsedByOtherTaskDs(ScriptUsedByOtherTaskDsRequest req)
        {
            return InternalRequestAsync<ScriptUsedByOtherTaskDsResponse>(req, "ScriptUsedByOtherTaskDs");
        }

        /// <summary>
        /// 判断脚本文件是否被任务列表所引用
        /// </summary>
        /// <param name="req"><see cref="ScriptUsedByOtherTaskDsRequest"/></param>
        /// <returns><see cref="ScriptUsedByOtherTaskDsResponse"/></returns>
        public ScriptUsedByOtherTaskDsResponse ScriptUsedByOtherTaskDsSync(ScriptUsedByOtherTaskDsRequest req)
        {
            return InternalRequestAsync<ScriptUsedByOtherTaskDsResponse>(req, "ScriptUsedByOtherTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public Task<SetTaskAlarmNewResponse> SetTaskAlarmNew(SetTaskAlarmNewRequest req)
        {
            return InternalRequestAsync<SetTaskAlarmNewResponse>(req, "SetTaskAlarmNew");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 即席分析终止任务接口
        /// </summary>
        /// <param name="req"><see cref="StopAdhocTaskRequest"/></param>
        /// <returns><see cref="StopAdhocTaskResponse"/></returns>
        public Task<StopAdhocTaskResponse> StopAdhocTask(StopAdhocTaskRequest req)
        {
            return InternalRequestAsync<StopAdhocTaskResponse>(req, "StopAdhocTask");
        }

        /// <summary>
        /// 即席分析终止任务接口
        /// </summary>
        /// <param name="req"><see cref="StopAdhocTaskRequest"/></param>
        /// <returns><see cref="StopAdhocTaskResponse"/></returns>
        public StopAdhocTaskResponse StopAdhocTaskSync(StopAdhocTaskRequest req)
        {
            return InternalRequestAsync<StopAdhocTaskResponse>(req, "StopAdhocTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交基线
        /// </summary>
        /// <param name="req"><see cref="StopBaselineRequest"/></param>
        /// <returns><see cref="StopBaselineResponse"/></returns>
        public Task<StopBaselineResponse> StopBaseline(StopBaselineRequest req)
        {
            return InternalRequestAsync<StopBaselineResponse>(req, "StopBaseline");
        }

        /// <summary>
        /// 提交基线
        /// </summary>
        /// <param name="req"><see cref="StopBaselineRequest"/></param>
        /// <returns><see cref="StopBaselineResponse"/></returns>
        public StopBaselineResponse StopBaselineSync(StopBaselineRequest req)
        {
            return InternalRequestAsync<StopBaselineResponse>(req, "StopBaseline")
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
        /// 终止etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="StopTestRunRequest"/></param>
        /// <returns><see cref="StopTestRunResponse"/></returns>
        public Task<StopTestRunResponse> StopTestRun(StopTestRunRequest req)
        {
            return InternalRequestAsync<StopTestRunResponse>(req, "StopTestRun");
        }

        /// <summary>
        /// 终止etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="StopTestRunRequest"/></param>
        /// <returns><see cref="StopTestRunResponse"/></returns>
        public StopTestRunResponse StopTestRunSync(StopTestRunRequest req)
        {
            return InternalRequestAsync<StopTestRunResponse>(req, "StopTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交基线
        /// </summary>
        /// <param name="req"><see cref="SubmitBaselineRequest"/></param>
        /// <returns><see cref="SubmitBaselineResponse"/></returns>
        public Task<SubmitBaselineResponse> SubmitBaseline(SubmitBaselineRequest req)
        {
            return InternalRequestAsync<SubmitBaselineResponse>(req, "SubmitBaseline");
        }

        /// <summary>
        /// 提交基线
        /// </summary>
        /// <param name="req"><see cref="SubmitBaselineRequest"/></param>
        /// <returns><see cref="SubmitBaselineResponse"/></returns>
        public SubmitBaselineResponse SubmitBaselineSync(SubmitBaselineRequest req)
        {
            return InternalRequestAsync<SubmitBaselineResponse>(req, "SubmitBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量提交etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="SubmitBatchTestRunRequest"/></param>
        /// <returns><see cref="SubmitBatchTestRunResponse"/></returns>
        public Task<SubmitBatchTestRunResponse> SubmitBatchTestRun(SubmitBatchTestRunRequest req)
        {
            return InternalRequestAsync<SubmitBatchTestRunResponse>(req, "SubmitBatchTestRun");
        }

        /// <summary>
        /// 批量提交etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="SubmitBatchTestRunRequest"/></param>
        /// <returns><see cref="SubmitBatchTestRunResponse"/></returns>
        public SubmitBatchTestRunResponse SubmitBatchTestRunSync(SubmitBatchTestRunRequest req)
        {
            return InternalRequestAsync<SubmitBatchTestRunResponse>(req, "SubmitBatchTestRun")
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
        /// 即席分析提交数据集成任务
        /// </summary>
        /// <param name="req"><see cref="SubmitIntegrationTaskRequest"/></param>
        /// <returns><see cref="SubmitIntegrationTaskResponse"/></returns>
        public Task<SubmitIntegrationTaskResponse> SubmitIntegrationTask(SubmitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SubmitIntegrationTaskResponse>(req, "SubmitIntegrationTask");
        }

        /// <summary>
        /// 即席分析提交数据集成任务
        /// </summary>
        /// <param name="req"><see cref="SubmitIntegrationTaskRequest"/></param>
        /// <returns><see cref="SubmitIntegrationTaskResponse"/></returns>
        public SubmitIntegrationTaskResponse SubmitIntegrationTaskSync(SubmitIntegrationTaskRequest req)
        {
            return InternalRequestAsync<SubmitIntegrationTaskResponse>(req, "SubmitIntegrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即席分析提交PySpark任务
        /// </summary>
        /// <param name="req"><see cref="SubmitPySparkTaskRequest"/></param>
        /// <returns><see cref="SubmitPySparkTaskResponse"/></returns>
        public Task<SubmitPySparkTaskResponse> SubmitPySparkTask(SubmitPySparkTaskRequest req)
        {
            return InternalRequestAsync<SubmitPySparkTaskResponse>(req, "SubmitPySparkTask");
        }

        /// <summary>
        /// 即席分析提交PySpark任务
        /// </summary>
        /// <param name="req"><see cref="SubmitPySparkTaskRequest"/></param>
        /// <returns><see cref="SubmitPySparkTaskResponse"/></returns>
        public SubmitPySparkTaskResponse SubmitPySparkTaskSync(SubmitPySparkTaskRequest req)
        {
            return InternalRequestAsync<SubmitPySparkTaskResponse>(req, "SubmitPySparkTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即席分析提交PYTHON任务
        /// </summary>
        /// <param name="req"><see cref="SubmitPythonTaskRequest"/></param>
        /// <returns><see cref="SubmitPythonTaskResponse"/></returns>
        public Task<SubmitPythonTaskResponse> SubmitPythonTask(SubmitPythonTaskRequest req)
        {
            return InternalRequestAsync<SubmitPythonTaskResponse>(req, "SubmitPythonTask");
        }

        /// <summary>
        /// 即席分析提交PYTHON任务
        /// </summary>
        /// <param name="req"><see cref="SubmitPythonTaskRequest"/></param>
        /// <returns><see cref="SubmitPythonTaskResponse"/></returns>
        public SubmitPythonTaskResponse SubmitPythonTaskSync(SubmitPythonTaskRequest req)
        {
            return InternalRequestAsync<SubmitPythonTaskResponse>(req, "SubmitPythonTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即席分析提交SHELL任务
        /// </summary>
        /// <param name="req"><see cref="SubmitShellTaskRequest"/></param>
        /// <returns><see cref="SubmitShellTaskResponse"/></returns>
        public Task<SubmitShellTaskResponse> SubmitShellTask(SubmitShellTaskRequest req)
        {
            return InternalRequestAsync<SubmitShellTaskResponse>(req, "SubmitShellTask");
        }

        /// <summary>
        /// 即席分析提交SHELL任务
        /// </summary>
        /// <param name="req"><see cref="SubmitShellTaskRequest"/></param>
        /// <returns><see cref="SubmitShellTaskResponse"/></returns>
        public SubmitShellTaskResponse SubmitShellTaskSync(SubmitShellTaskRequest req)
        {
            return InternalRequestAsync<SubmitShellTaskResponse>(req, "SubmitShellTask")
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
            return InternalRequestAsync<SubmitTaskResponse>(req, "SubmitTask");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 提交etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTestRunRequest"/></param>
        /// <returns><see cref="SubmitTestRunResponse"/></returns>
        public Task<SubmitTestRunResponse> SubmitTestRun(SubmitTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTestRunResponse>(req, "SubmitTestRun");
        }

        /// <summary>
        /// 提交etl测试运行任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTestRunRequest"/></param>
        /// <returns><see cref="SubmitTestRunResponse"/></returns>
        public SubmitTestRunResponse SubmitTestRunSync(SubmitTestRunRequest req)
        {
            return InternalRequestAsync<SubmitTestRunResponse>(req, "SubmitTestRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public Task<SubmitWorkflowResponse> SubmitWorkflow(SubmitWorkflowRequest req)
        {
            return InternalRequestAsync<SubmitWorkflowResponse>(req, "SubmitWorkflow");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public Task<TriggerEventResponse> TriggerEvent(TriggerEventRequest req)
        {
            return InternalRequestAsync<TriggerEventResponse>(req, "TriggerEvent");
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
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
        /// 批量更新高级设置
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskAdvancedSettingsRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskAdvancedSettingsResponse"/></returns>
        public Task<UpdateBatchTaskAdvancedSettingsResponse> UpdateBatchTaskAdvancedSettings(UpdateBatchTaskAdvancedSettingsRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskAdvancedSettingsResponse>(req, "UpdateBatchTaskAdvancedSettings");
        }

        /// <summary>
        /// 批量更新高级设置
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskAdvancedSettingsRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskAdvancedSettingsResponse"/></returns>
        public UpdateBatchTaskAdvancedSettingsResponse UpdateBatchTaskAdvancedSettingsSync(UpdateBatchTaskAdvancedSettingsRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskAdvancedSettingsResponse>(req, "UpdateBatchTaskAdvancedSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskDatasourceRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskDatasourceResponse"/></returns>
        public Task<UpdateBatchTaskDatasourceResponse> UpdateBatchTaskDatasource(UpdateBatchTaskDatasourceRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskDatasourceResponse>(req, "UpdateBatchTaskDatasource");
        }

        /// <summary>
        /// 批量更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskDatasourceRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskDatasourceResponse"/></returns>
        public UpdateBatchTaskDatasourceResponse UpdateBatchTaskDatasourceSync(UpdateBatchTaskDatasourceRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskDatasourceResponse>(req, "UpdateBatchTaskDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改责任人
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskInChargeRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskInChargeResponse"/></returns>
        public Task<UpdateBatchTaskInChargeResponse> UpdateBatchTaskInCharge(UpdateBatchTaskInChargeRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskInChargeResponse>(req, "UpdateBatchTaskInCharge");
        }

        /// <summary>
        /// 批量修改责任人
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskInChargeRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskInChargeResponse"/></returns>
        public UpdateBatchTaskInChargeResponse UpdateBatchTaskInChargeSync(UpdateBatchTaskInChargeRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskInChargeResponse>(req, "UpdateBatchTaskInCharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改参数
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskParameterRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskParameterResponse"/></returns>
        public Task<UpdateBatchTaskParameterResponse> UpdateBatchTaskParameter(UpdateBatchTaskParameterRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskParameterResponse>(req, "UpdateBatchTaskParameter");
        }

        /// <summary>
        /// 批量修改参数
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskParameterRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskParameterResponse"/></returns>
        public UpdateBatchTaskParameterResponse UpdateBatchTaskParameterSync(UpdateBatchTaskParameterRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskParameterResponse>(req, "UpdateBatchTaskParameter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新调度参数
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskParamsRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskParamsResponse"/></returns>
        public Task<UpdateBatchTaskParamsResponse> UpdateBatchTaskParams(UpdateBatchTaskParamsRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskParamsResponse>(req, "UpdateBatchTaskParams");
        }

        /// <summary>
        /// 批量更新调度参数
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskParamsRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskParamsResponse"/></returns>
        public UpdateBatchTaskParamsResponse UpdateBatchTaskParamsSync(UpdateBatchTaskParamsRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskParamsResponse>(req, "UpdateBatchTaskParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改资源组
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskResourceGroupRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskResourceGroupResponse"/></returns>
        public Task<UpdateBatchTaskResourceGroupResponse> UpdateBatchTaskResourceGroup(UpdateBatchTaskResourceGroupRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskResourceGroupResponse>(req, "UpdateBatchTaskResourceGroup");
        }

        /// <summary>
        /// 批量修改资源组
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskResourceGroupRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskResourceGroupResponse"/></returns>
        public UpdateBatchTaskResourceGroupResponse UpdateBatchTaskResourceGroupSync(UpdateBatchTaskResourceGroupRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskResourceGroupResponse>(req, "UpdateBatchTaskResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新调度周期设置
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskScheduleRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskScheduleResponse"/></returns>
        public Task<UpdateBatchTaskScheduleResponse> UpdateBatchTaskSchedule(UpdateBatchTaskScheduleRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskScheduleResponse>(req, "UpdateBatchTaskSchedule");
        }

        /// <summary>
        /// 批量更新调度周期设置
        /// </summary>
        /// <param name="req"><see cref="UpdateBatchTaskScheduleRequest"/></param>
        /// <returns><see cref="UpdateBatchTaskScheduleResponse"/></returns>
        public UpdateBatchTaskScheduleResponse UpdateBatchTaskScheduleSync(UpdateBatchTaskScheduleRequest req)
        {
            return InternalRequestAsync<UpdateBatchTaskScheduleResponse>(req, "UpdateBatchTaskSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件
        /// </summary>
        /// <param name="req"><see cref="UpdateDsEventRequest"/></param>
        /// <returns><see cref="UpdateDsEventResponse"/></returns>
        public Task<UpdateDsEventResponse> UpdateDsEvent(UpdateDsEventRequest req)
        {
            return InternalRequestAsync<UpdateDsEventResponse>(req, "UpdateDsEvent");
        }

        /// <summary>
        /// 更新事件
        /// </summary>
        /// <param name="req"><see cref="UpdateDsEventRequest"/></param>
        /// <returns><see cref="UpdateDsEventResponse"/></returns>
        public UpdateDsEventResponse UpdateDsEventSync(UpdateDsEventRequest req)
        {
            return InternalRequestAsync<UpdateDsEventResponse>(req, "UpdateDsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件监听
        /// </summary>
        /// <param name="req"><see cref="UpdateEventListenerRequest"/></param>
        /// <returns><see cref="UpdateEventListenerResponse"/></returns>
        public Task<UpdateEventListenerResponse> UpdateEventListener(UpdateEventListenerRequest req)
        {
            return InternalRequestAsync<UpdateEventListenerResponse>(req, "UpdateEventListener");
        }

        /// <summary>
        /// 更新事件监听
        /// </summary>
        /// <param name="req"><see cref="UpdateEventListenerRequest"/></param>
        /// <returns><see cref="UpdateEventListenerResponse"/></returns>
        public UpdateEventListenerResponse UpdateEventListenerSync(UpdateEventListenerRequest req)
        {
            return InternalRequestAsync<UpdateEventListenerResponse>(req, "UpdateEventListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新采集器
        /// </summary>
        /// <param name="req"><see cref="UpdateInLongAgentRequest"/></param>
        /// <returns><see cref="UpdateInLongAgentResponse"/></returns>
        public Task<UpdateInLongAgentResponse> UpdateInLongAgent(UpdateInLongAgentRequest req)
        {
            return InternalRequestAsync<UpdateInLongAgentResponse>(req, "UpdateInLongAgent");
        }

        /// <summary>
        /// 更新采集器
        /// </summary>
        /// <param name="req"><see cref="UpdateInLongAgentRequest"/></param>
        /// <returns><see cref="UpdateInLongAgentResponse"/></returns>
        public UpdateInLongAgentResponse UpdateInLongAgentSync(UpdateInLongAgentRequest req)
        {
            return InternalRequestAsync<UpdateInLongAgentResponse>(req, "UpdateInLongAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskDsRequest"/></param>
        /// <returns><see cref="UpdateTaskDsResponse"/></returns>
        public Task<UpdateTaskDsResponse> UpdateTaskDs(UpdateTaskDsRequest req)
        {
            return InternalRequestAsync<UpdateTaskDsResponse>(req, "UpdateTaskDs");
        }

        /// <summary>
        /// 更新任务Ds
        /// </summary>
        /// <param name="req"><see cref="UpdateTaskDsRequest"/></param>
        /// <returns><see cref="UpdateTaskDsResponse"/></returns>
        public UpdateTaskDsResponse UpdateTaskDsSync(UpdateTaskDsRequest req)
        {
            return InternalRequestAsync<UpdateTaskDsResponse>(req, "UpdateTaskDs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p style="color:red;">[该接口为 ds 中开发]</p>
        /// 更新工作流（包括工作流基本信息与工作流参数）
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowInfoRequest"/></param>
        /// <returns><see cref="UpdateWorkflowInfoResponse"/></returns>
        public Task<UpdateWorkflowInfoResponse> UpdateWorkflowInfo(UpdateWorkflowInfoRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowInfoResponse>(req, "UpdateWorkflowInfo");
        }

        /// <summary>
        /// <p style="color:red;">[该接口为 ds 中开发]</p>
        /// 更新工作流（包括工作流基本信息与工作流参数）
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowInfoRequest"/></param>
        /// <returns><see cref="UpdateWorkflowInfoResponse"/></returns>
        public UpdateWorkflowInfoResponse UpdateWorkflowInfoSync(UpdateWorkflowInfoRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowInfoResponse>(req, "UpdateWorkflowInfo")
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
        /// 保存高级运行用户自定义参数
        /// </summary>
        /// <param name="req"><see cref="UploadAdvanceRunParamsRequest"/></param>
        /// <returns><see cref="UploadAdvanceRunParamsResponse"/></returns>
        public Task<UploadAdvanceRunParamsResponse> UploadAdvanceRunParams(UploadAdvanceRunParamsRequest req)
        {
            return InternalRequestAsync<UploadAdvanceRunParamsResponse>(req, "UploadAdvanceRunParams");
        }

        /// <summary>
        /// 保存高级运行用户自定义参数
        /// </summary>
        /// <param name="req"><see cref="UploadAdvanceRunParamsRequest"/></param>
        /// <returns><see cref="UploadAdvanceRunParamsResponse"/></returns>
        public UploadAdvanceRunParamsResponse UploadAdvanceRunParamsSync(UploadAdvanceRunParamsRequest req)
        {
            return InternalRequestAsync<UploadAdvanceRunParamsResponse>(req, "UploadAdvanceRunParams")
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
        /// 文件上传需要先获取文件上传所需要的秘钥，文件位置等信息，因为文件名字可能会出现冲突，所以需要传入将要写入的文件，如果检测到文件名冲突，WeData 后端会在文件名上加入随机字符串。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesDsRequest"/></param>
        /// <returns><see cref="UploadFilesDsResponse"/></returns>
        public Task<UploadFilesDsResponse> UploadFilesDs(UploadFilesDsRequest req)
        {
            return InternalRequestAsync<UploadFilesDsResponse>(req, "UploadFilesDs");
        }

        /// <summary>
        /// 文件上传需要先获取文件上传所需要的秘钥，文件位置等信息，因为文件名字可能会出现冲突，所以需要传入将要写入的文件，如果检测到文件名冲突，WeData 后端会在文件名上加入随机字符串。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesDsRequest"/></param>
        /// <returns><see cref="UploadFilesDsResponse"/></returns>
        public UploadFilesDsResponse UploadFilesDsSync(UploadFilesDsRequest req)
        {
            return InternalRequestAsync<UploadFilesDsResponse>(req, "UploadFilesDs")
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
