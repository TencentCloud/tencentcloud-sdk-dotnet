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

namespace TencentCloud.Dts.V20211206
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dts.V20211206.Models;

   public class DtsClient : AbstractClient{

       private const string endpoint = "dts.tencentcloudapi.com";
       private const string version = "2021-12-06";
       private const string sdkVersion = "SDK_NET_3.0.1169";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrationJobs接口查询到任务的状态为准备完成（Status="readyComplete"）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob");
        }

        /// <summary>
        /// 本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrationJobs接口查询到任务的状态为准备完成（Status="readyComplete"）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public CompleteMigrateJobResponse CompleteMigrateJobSync(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ConfigureSubscribeJob)用于配置数据订阅实例。
        /// </summary>
        /// <param name="req"><see cref="ConfigureSubscribeJobRequest"/></param>
        /// <returns><see cref="ConfigureSubscribeJobResponse"/></returns>
        public Task<ConfigureSubscribeJobResponse> ConfigureSubscribeJob(ConfigureSubscribeJobRequest req)
        {
            return InternalRequestAsync<ConfigureSubscribeJobResponse>(req, "ConfigureSubscribeJob");
        }

        /// <summary>
        /// 本接口(ConfigureSubscribeJob)用于配置数据订阅实例。
        /// </summary>
        /// <param name="req"><see cref="ConfigureSubscribeJobRequest"/></param>
        /// <returns><see cref="ConfigureSubscribeJobResponse"/></returns>
        public ConfigureSubscribeJobResponse ConfigureSubscribeJobSync(ConfigureSubscribeJobRequest req)
        {
            return InternalRequestAsync<ConfigureSubscribeJobResponse>(req, "ConfigureSubscribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置一个同步任务
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public Task<ConfigureSyncJobResponse> ConfigureSyncJob(ConfigureSyncJobRequest req)
        {
            return InternalRequestAsync<ConfigureSyncJobResponse>(req, "ConfigureSyncJob");
        }

        /// <summary>
        /// 配置一个同步任务
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public ConfigureSyncJobResponse ConfigureSyncJobSync(ConfigureSyncJobRequest req)
        {
            return InternalRequestAsync<ConfigureSyncJobResponse>(req, "ConfigureSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复一个暂停中的迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public Task<ContinueMigrateJobResponse> ContinueMigrateJob(ContinueMigrateJobRequest req)
        {
            return InternalRequestAsync<ContinueMigrateJobResponse>(req, "ContinueMigrateJob");
        }

        /// <summary>
        /// 恢复一个暂停中的迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ContinueMigrateJobRequest"/></param>
        /// <returns><see cref="ContinueMigrateJobResponse"/></returns>
        public ContinueMigrateJobResponse ContinueMigrateJobSync(ContinueMigrateJobRequest req)
        {
            return InternalRequestAsync<ContinueMigrateJobResponse>(req, "ContinueMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复处于已暂停状态的数据同步任务。
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public Task<ContinueSyncJobResponse> ContinueSyncJob(ContinueSyncJobRequest req)
        {
            return InternalRequestAsync<ContinueSyncJobResponse>(req, "ContinueSyncJob");
        }

        /// <summary>
        /// 恢复处于已暂停状态的数据同步任务。
        /// </summary>
        /// <param name="req"><see cref="ContinueSyncJobRequest"/></param>
        /// <returns><see cref="ContinueSyncJobResponse"/></returns>
        public ContinueSyncJobResponse ContinueSyncJobSync(ContinueSyncJobRequest req)
        {
            return InternalRequestAsync<ContinueSyncJobResponse>(req, "ContinueSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验同步任务，检查必要参数和周边配置。
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public Task<CreateCheckSyncJobResponse> CreateCheckSyncJob(CreateCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateCheckSyncJobResponse>(req, "CreateCheckSyncJob");
        }

        /// <summary>
        /// 校验同步任务，检查必要参数和周边配置。
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public CreateCheckSyncJobResponse CreateCheckSyncJobSync(CreateCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateCheckSyncJobResponse>(req, "CreateCheckSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建数据对比任务，创建成功后会返回数据对比任务 ID，形如：dts-8yv4w2i1-cmp-37skmii9，创建成功后可通过StartCompare启动一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public Task<CreateCompareTaskResponse> CreateCompareTask(CreateCompareTaskRequest req)
        {
            return InternalRequestAsync<CreateCompareTaskResponse>(req, "CreateCompareTask");
        }

        /// <summary>
        /// 本接口用于创建数据对比任务，创建成功后会返回数据对比任务 ID，形如：dts-8yv4w2i1-cmp-37skmii9，创建成功后可通过StartCompare启动一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public CreateCompareTaskResponse CreateCompareTaskSync(CreateCompareTaskRequest req)
        {
            return InternalRequestAsync<CreateCompareTaskResponse>(req, "CreateCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为订阅实例创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup");
        }

        /// <summary>
        /// 为订阅实例创建消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验迁移任务，
        /// 在开始迁移前, 必须调用本接口创建校验迁移任务, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrationCheckJob查看，
        /// 校验成功后,迁移任务若有修改, 则必须重新校验并通过后, 才能开始迁移
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob");
        }

        /// <summary>
        /// 校验迁移任务，
        /// 在开始迁移前, 必须调用本接口创建校验迁移任务, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrationCheckJob查看，
        /// 校验成功后,迁移任务若有修改, 则必须重新校验并通过后, 才能开始迁移
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public CreateMigrateCheckJobResponse CreateMigrateCheckJobSync(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买迁移任务。购买成功后会返回随机生成的迁移任务id列表，也可以通过查询迁移任务任务列表接口`DescribeMigrationJobs`看到购买成功的实例Id。注意，一旦购买成功后源及目标数据库类型，源及目标实例地域不可修改。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public Task<CreateMigrationServiceResponse> CreateMigrationService(CreateMigrationServiceRequest req)
        {
            return InternalRequestAsync<CreateMigrationServiceResponse>(req, "CreateMigrationService");
        }

        /// <summary>
        /// 购买迁移任务。购买成功后会返回随机生成的迁移任务id列表，也可以通过查询迁移任务任务列表接口`DescribeMigrationJobs`看到购买成功的实例Id。注意，一旦购买成功后源及目标数据库类型，源及目标实例地域不可修改。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public CreateMigrationServiceResponse CreateMigrationServiceSync(CreateMigrationServiceRequest req)
        {
            return InternalRequestAsync<CreateMigrationServiceResponse>(req, "CreateMigrationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在修改同步任务的配置后、通过该接口校验当前任务是否支持修改对象操作
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public Task<CreateModifyCheckSyncJobResponse> CreateModifyCheckSyncJob(CreateModifyCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateModifyCheckSyncJobResponse>(req, "CreateModifyCheckSyncJob");
        }

        /// <summary>
        /// 在修改同步任务的配置后、通过该接口校验当前任务是否支持修改对象操作
        /// </summary>
        /// <param name="req"><see cref="CreateModifyCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateModifyCheckSyncJobResponse"/></returns>
        public CreateModifyCheckSyncJobResponse CreateModifyCheckSyncJobSync(CreateModifyCheckSyncJobRequest req)
        {
            return InternalRequestAsync<CreateModifyCheckSyncJobResponse>(req, "CreateModifyCheckSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateSubscribe)用于创建一个数据订阅任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe");
        }

        /// <summary>
        /// 本接口(CreateSubscribe)用于创建一个数据订阅任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateSubscribeCheckJob)用于创建一个订阅校验任务。任务必须已经成功调用ConfigureSubscribeJob接口配置了所有的必要信息才能启动校验。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="CreateSubscribeCheckJobResponse"/></returns>
        public Task<CreateSubscribeCheckJobResponse> CreateSubscribeCheckJob(CreateSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<CreateSubscribeCheckJobResponse>(req, "CreateSubscribeCheckJob");
        }

        /// <summary>
        /// 本接口(CreateSubscribeCheckJob)用于创建一个订阅校验任务。任务必须已经成功调用ConfigureSubscribeJob接口配置了所有的必要信息才能启动校验。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="CreateSubscribeCheckJobResponse"/></returns>
        public CreateSubscribeCheckJobResponse CreateSubscribeCheckJobSync(CreateSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<CreateSubscribeCheckJobResponse>(req, "CreateSubscribeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public Task<CreateSyncJobResponse> CreateSyncJob(CreateSyncJobRequest req)
        {
            return InternalRequestAsync<CreateSyncJobResponse>(req, "CreateSyncJob");
        }

        /// <summary>
        /// 创建一个同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public CreateSyncJobResponse CreateSyncJobSync(CreateSyncJobRequest req)
        {
            return InternalRequestAsync<CreateSyncJobResponse>(req, "CreateSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一致性校验任务。当一致性校验任务状态为success、failed、canceled 时可以执行此操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public Task<DeleteCompareTaskResponse> DeleteCompareTask(DeleteCompareTaskRequest req)
        {
            return InternalRequestAsync<DeleteCompareTaskResponse>(req, "DeleteCompareTask");
        }

        /// <summary>
        /// 删除一致性校验任务。当一致性校验任务状态为success、failed、canceled 时可以执行此操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public DeleteCompareTaskResponse DeleteCompareTaskSync(DeleteCompareTaskRequest req)
        {
            return InternalRequestAsync<DeleteCompareTaskResponse>(req, "DeleteCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteConsumerGroup)用于删除一个订阅任务的消费组。
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup");
        }

        /// <summary>
        /// 本接口(DeleteConsumerGroup)用于删除一个订阅任务的消费组。
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询同步校验任务结果，检查必要参数和周边配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public Task<DescribeCheckSyncJobResultResponse> DescribeCheckSyncJobResult(DescribeCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeCheckSyncJobResultResponse>(req, "DescribeCheckSyncJobResult");
        }

        /// <summary>
        /// 查询同步校验任务结果，检查必要参数和周边配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public DescribeCheckSyncJobResultResponse DescribeCheckSyncJobResultSync(DescribeCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeCheckSyncJobResultResponse>(req, "DescribeCheckSyncJobResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一致性校验任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public Task<DescribeCompareReportResponse> DescribeCompareReport(DescribeCompareReportRequest req)
        {
            return InternalRequestAsync<DescribeCompareReportResponse>(req, "DescribeCompareReport");
        }

        /// <summary>
        /// 查询一致性校验任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public DescribeCompareReportResponse DescribeCompareReportSync(DescribeCompareReportRequest req)
        {
            return InternalRequestAsync<DescribeCompareReportResponse>(req, "DescribeCompareReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一致性校验任务列表，调用该接口后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public Task<DescribeCompareTasksResponse> DescribeCompareTasks(DescribeCompareTasksRequest req)
        {
            return InternalRequestAsync<DescribeCompareTasksResponse>(req, "DescribeCompareTasks");
        }

        /// <summary>
        /// 查询一致性校验任务列表，调用该接口后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public DescribeCompareTasksResponse DescribeCompareTasksSync(DescribeCompareTasksRequest req)
        {
            return InternalRequestAsync<DescribeCompareTasksResponse>(req, "DescribeCompareTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeConsumerGroups)用于获取订阅实例配置的消费者组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public Task<DescribeConsumerGroupsResponse> DescribeConsumerGroups(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups");
        }

        /// <summary>
        /// 本接口(DescribeConsumerGroups)用于获取订阅实例配置的消费者组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupsRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupsResponse"/></returns>
        public DescribeConsumerGroupsResponse DescribeConsumerGroupsSync(DescribeConsumerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupsResponse>(req, "DescribeConsumerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询支持迁移的云数据库实例
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public Task<DescribeMigrateDBInstancesResponse> DescribeMigrateDBInstances(DescribeMigrateDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMigrateDBInstancesResponse>(req, "DescribeMigrateDBInstances");
        }

        /// <summary>
        /// 本接口用于查询支持迁移的云数据库实例
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public DescribeMigrateDBInstancesResponse DescribeMigrateDBInstancesSync(DescribeMigrateDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMigrateDBInstancesResponse>(req, "DescribeMigrateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrationJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public Task<DescribeMigrationCheckJobResponse> DescribeMigrationCheckJob(DescribeMigrationCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrationCheckJobResponse>(req, "DescribeMigrationCheckJob");
        }

        /// <summary>
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrationJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public DescribeMigrationCheckJobResponse DescribeMigrationCheckJobSync(DescribeMigrationCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrationCheckJobResponse>(req, "DescribeMigrationCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail");
        }

        /// <summary>
        /// 查询某个迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public Task<DescribeMigrationJobsResponse> DescribeMigrationJobs(DescribeMigrationJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationJobsResponse>(req, "DescribeMigrationJobs");
        }

        /// <summary>
        /// 查询数据迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public DescribeMigrationJobsResponse DescribeMigrationJobsSync(DescribeMigrationJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationJobsResponse>(req, "DescribeMigrationJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在创建修改对象的校验任务后、通过该接口查看校验任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public Task<DescribeModifyCheckSyncJobResultResponse> DescribeModifyCheckSyncJobResult(DescribeModifyCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeModifyCheckSyncJobResultResponse>(req, "DescribeModifyCheckSyncJobResult");
        }

        /// <summary>
        /// 在创建修改对象的校验任务后、通过该接口查看校验任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeModifyCheckSyncJobResultResponse"/></returns>
        public DescribeModifyCheckSyncJobResultResponse DescribeModifyCheckSyncJobResultSync(DescribeModifyCheckSyncJobResultRequest req)
        {
            return InternalRequestAsync<DescribeModifyCheckSyncJobResultResponse>(req, "DescribeModifyCheckSyncJobResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeOffsetByTime)查询KafkaTopic中指定时间前最近的offset。
        /// 接口输出的offset是离这个时间最近的offset。
        /// 如果输入时间比当前时间晚的多，相当于输出的就是最新的offset；
        /// 如果输入时间比当前时间早的多，相当于输出的就是最老的offset；
        /// 如果输入空，默认0时间，也就是查询最老的offset。
        /// </summary>
        /// <param name="req"><see cref="DescribeOffsetByTimeRequest"/></param>
        /// <returns><see cref="DescribeOffsetByTimeResponse"/></returns>
        public Task<DescribeOffsetByTimeResponse> DescribeOffsetByTime(DescribeOffsetByTimeRequest req)
        {
            return InternalRequestAsync<DescribeOffsetByTimeResponse>(req, "DescribeOffsetByTime");
        }

        /// <summary>
        /// 本接口(DescribeOffsetByTime)查询KafkaTopic中指定时间前最近的offset。
        /// 接口输出的offset是离这个时间最近的offset。
        /// 如果输入时间比当前时间晚的多，相当于输出的就是最新的offset；
        /// 如果输入时间比当前时间早的多，相当于输出的就是最老的offset；
        /// 如果输入空，默认0时间，也就是查询最老的offset。
        /// </summary>
        /// <param name="req"><see cref="DescribeOffsetByTimeRequest"/></param>
        /// <returns><see cref="DescribeOffsetByTimeResponse"/></returns>
        public DescribeOffsetByTimeResponse DescribeOffsetByTimeSync(DescribeOffsetByTimeRequest req)
        {
            return InternalRequestAsync<DescribeOffsetByTimeResponse>(req, "DescribeOffsetByTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubscribeCheckJob)用于查询订阅校验任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeSubscribeCheckJobResponse"/></returns>
        public Task<DescribeSubscribeCheckJobResponse> DescribeSubscribeCheckJob(DescribeSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeCheckJobResponse>(req, "DescribeSubscribeCheckJob");
        }

        /// <summary>
        /// 本接口(DescribeSubscribeCheckJob)用于查询订阅校验任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeCheckJobRequest"/></param>
        /// <returns><see cref="DescribeSubscribeCheckJobResponse"/></returns>
        public DescribeSubscribeCheckJobResponse DescribeSubscribeCheckJobSync(DescribeSubscribeCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeCheckJobResponse>(req, "DescribeSubscribeCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubscribeDetail)获取数据订阅实例的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscribeDetailResponse"/></returns>
        public Task<DescribeSubscribeDetailResponse> DescribeSubscribeDetail(DescribeSubscribeDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeDetailResponse>(req, "DescribeSubscribeDetail");
        }

        /// <summary>
        /// 本接口(DescribeSubscribeDetail)获取数据订阅实例的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeDetailRequest"/></param>
        /// <returns><see cref="DescribeSubscribeDetailResponse"/></returns>
        public DescribeSubscribeDetailResponse DescribeSubscribeDetailSync(DescribeSubscribeDetailRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeDetailResponse>(req, "DescribeSubscribeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubscribes)获取数据订阅实例信息列表，默认分页，每次返回20条
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeJobsRequest"/></param>
        /// <returns><see cref="DescribeSubscribeJobsResponse"/></returns>
        public Task<DescribeSubscribeJobsResponse> DescribeSubscribeJobs(DescribeSubscribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeJobsResponse>(req, "DescribeSubscribeJobs");
        }

        /// <summary>
        /// 本接口(DescribeSubscribes)获取数据订阅实例信息列表，默认分页，每次返回20条
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeJobsRequest"/></param>
        /// <returns><see cref="DescribeSubscribeJobsResponse"/></returns>
        public DescribeSubscribeJobsResponse DescribeSubscribeJobsSync(DescribeSubscribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeJobsResponse>(req, "DescribeSubscribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubscribeReturnable)用于查询订阅任务是否可以销毁和退货。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeReturnableRequest"/></param>
        /// <returns><see cref="DescribeSubscribeReturnableResponse"/></returns>
        public Task<DescribeSubscribeReturnableResponse> DescribeSubscribeReturnable(DescribeSubscribeReturnableRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeReturnableResponse>(req, "DescribeSubscribeReturnable");
        }

        /// <summary>
        /// 本接口(DescribeSubscribeReturnable)用于查询订阅任务是否可以销毁和退货。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeReturnableRequest"/></param>
        /// <returns><see cref="DescribeSubscribeReturnableResponse"/></returns>
        public DescribeSubscribeReturnableResponse DescribeSubscribeReturnableSync(DescribeSubscribeReturnableRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeReturnableResponse>(req, "DescribeSubscribeReturnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询同步任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public Task<DescribeSyncJobsResponse> DescribeSyncJobs(DescribeSyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeSyncJobsResponse>(req, "DescribeSyncJobs");
        }

        /// <summary>
        /// 查询同步任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public DescribeSyncJobsResponse DescribeSyncJobsSync(DescribeSyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeSyncJobsResponse>(req, "DescribeSyncJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyIsolatedSubscribe）用于下线已隔离的数据订阅实例
        /// </summary>
        /// <param name="req"><see cref="DestroyIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="DestroyIsolatedSubscribeResponse"/></returns>
        public Task<DestroyIsolatedSubscribeResponse> DestroyIsolatedSubscribe(DestroyIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<DestroyIsolatedSubscribeResponse>(req, "DestroyIsolatedSubscribe");
        }

        /// <summary>
        /// 本接口（DestroyIsolatedSubscribe）用于下线已隔离的数据订阅实例
        /// </summary>
        /// <param name="req"><see cref="DestroyIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="DestroyIsolatedSubscribeResponse"/></returns>
        public DestroyIsolatedSubscribeResponse DestroyIsolatedSubscribeSync(DestroyIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<DestroyIsolatedSubscribeResponse>(req, "DestroyIsolatedSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下线数据迁移任务。计费任务必须先调用隔离(IsolateMigrateJob)接口，且只有是**已隔离**状态下，才能调用此接口销毁任务。对于不计费任务，调用隔离(IsolateMigrateJob)接口删除任务操作。
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public Task<DestroyMigrateJobResponse> DestroyMigrateJob(DestroyMigrateJobRequest req)
        {
            return InternalRequestAsync<DestroyMigrateJobResponse>(req, "DestroyMigrateJob");
        }

        /// <summary>
        /// 下线数据迁移任务。计费任务必须先调用隔离(IsolateMigrateJob)接口，且只有是**已隔离**状态下，才能调用此接口销毁任务。对于不计费任务，调用隔离(IsolateMigrateJob)接口删除任务操作。
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public DestroyMigrateJobResponse DestroyMigrateJobSync(DestroyMigrateJobRequest req)
        {
            return InternalRequestAsync<DestroyMigrateJobResponse>(req, "DestroyMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下线同步任务，任务在已隔离状态下可以通过此操作进行任务下线，即彻底删除任务。下线操作后可通过查询同步任务信息接口DescribeSyncJobs获取任务列表查看状态，此操作成功后无法看到此任务表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public Task<DestroySyncJobResponse> DestroySyncJob(DestroySyncJobRequest req)
        {
            return InternalRequestAsync<DestroySyncJobResponse>(req, "DestroySyncJob");
        }

        /// <summary>
        /// 下线同步任务，任务在已隔离状态下可以通过此操作进行任务下线，即彻底删除任务。下线操作后可通过查询同步任务信息接口DescribeSyncJobs获取任务列表查看状态，此操作成功后无法看到此任务表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public DestroySyncJobResponse DestroySyncJobSync(DestroySyncJobRequest req)
        {
            return InternalRequestAsync<DestroySyncJobResponse>(req, "DestroySyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  隔离退还数据迁移服务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。对于计费任务，在任务隔离后可进行解除隔离(RecoverMigrationJob)操作或直接进行下线销毁(DestroyMigrateJob)操作。对于不计费任务，调用此接口会直接销毁任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public Task<IsolateMigrateJobResponse> IsolateMigrateJob(IsolateMigrateJobRequest req)
        {
            return InternalRequestAsync<IsolateMigrateJobResponse>(req, "IsolateMigrateJob");
        }

        /// <summary>
        ///  隔离退还数据迁移服务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。对于计费任务，在任务隔离后可进行解除隔离(RecoverMigrationJob)操作或直接进行下线销毁(DestroyMigrateJob)操作。对于不计费任务，调用此接口会直接销毁任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public IsolateMigrateJobResponse IsolateMigrateJobSync(IsolateMigrateJobRequest req)
        {
            return InternalRequestAsync<IsolateMigrateJobResponse>(req, "IsolateMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateSubscribe）用于隔离订阅任务。调用后，订阅任务将不能使用。按量计费的任务会停止计费，包年包月的任务会自动退费
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public Task<IsolateSubscribeResponse> IsolateSubscribe(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe");
        }

        /// <summary>
        /// 本接口（IsolateSubscribe）用于隔离订阅任务。调用后，订阅任务将不能使用。按量计费的任务会停止计费，包年包月的任务会自动退费
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public IsolateSubscribeResponse IsolateSubscribeSync(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 隔离同步任务，隔离后可通过查询同步任务信息接口DescribeSyncJobs获取隔离后状态。在任务隔离后可进行解除隔离(RecoverSyncJob)操作或直接进行下线操作。对于不计费任务，调用此接口后会直接删除任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public Task<IsolateSyncJobResponse> IsolateSyncJob(IsolateSyncJobRequest req)
        {
            return InternalRequestAsync<IsolateSyncJobResponse>(req, "IsolateSyncJob");
        }

        /// <summary>
        /// 隔离同步任务，隔离后可通过查询同步任务信息接口DescribeSyncJobs获取隔离后状态。在任务隔离后可进行解除隔离(RecoverSyncJob)操作或直接进行下线操作。对于不计费任务，调用此接口后会直接删除任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public IsolateSyncJobResponse IsolateSyncJobSync(IsolateSyncJobRequest req)
        {
            return InternalRequestAsync<IsolateSyncJobResponse>(req, "IsolateSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改一致性校验任务，在任务创建后启动之前，可修改一致性校验参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public Task<ModifyCompareTaskResponse> ModifyCompareTask(ModifyCompareTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskResponse>(req, "ModifyCompareTask");
        }

        /// <summary>
        /// 修改一致性校验任务，在任务创建后启动之前，可修改一致性校验参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public ModifyCompareTaskResponse ModifyCompareTaskSync(ModifyCompareTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskResponse>(req, "ModifyCompareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改一致性校验任务名称
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public Task<ModifyCompareTaskNameResponse> ModifyCompareTaskName(ModifyCompareTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskNameResponse>(req, "ModifyCompareTaskName");
        }

        /// <summary>
        /// 修改一致性校验任务名称
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public ModifyCompareTaskNameResponse ModifyCompareTaskNameSync(ModifyCompareTaskNameRequest req)
        {
            return InternalRequestAsync<ModifyCompareTaskNameResponse>(req, "ModifyCompareTaskName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyConsumerGroupDescription)用于修改指定订阅消费组备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupDescriptionRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupDescriptionResponse"/></returns>
        public Task<ModifyConsumerGroupDescriptionResponse> ModifyConsumerGroupDescription(ModifyConsumerGroupDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupDescriptionResponse>(req, "ModifyConsumerGroupDescription");
        }

        /// <summary>
        /// 本接口(ModifyConsumerGroupDescription)用于修改指定订阅消费组备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupDescriptionRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupDescriptionResponse"/></returns>
        public ModifyConsumerGroupDescriptionResponse ModifyConsumerGroupDescriptionSync(ModifyConsumerGroupDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupDescriptionResponse>(req, "ModifyConsumerGroupDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyConsumerGroupPassword)用于修改指定订阅消费组密码。
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupPasswordRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupPasswordResponse"/></returns>
        public Task<ModifyConsumerGroupPasswordResponse> ModifyConsumerGroupPassword(ModifyConsumerGroupPasswordRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupPasswordResponse>(req, "ModifyConsumerGroupPassword");
        }

        /// <summary>
        /// 本接口(ModifyConsumerGroupPassword)用于修改指定订阅消费组密码。
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupPasswordRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupPasswordResponse"/></returns>
        public ModifyConsumerGroupPasswordResponse ModifyConsumerGroupPasswordSync(ModifyConsumerGroupPasswordRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupPasswordResponse>(req, "ModifyConsumerGroupPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整实例规格，此接口只支持按量计费任务的调整。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public Task<ModifyMigrateJobSpecResponse> ModifyMigrateJobSpec(ModifyMigrateJobSpecRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobSpecResponse>(req, "ModifyMigrateJobSpec");
        }

        /// <summary>
        /// 调整实例规格，此接口只支持按量计费任务的调整。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public ModifyMigrateJobSpecResponse ModifyMigrateJobSpecSync(ModifyMigrateJobSpecRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobSpecResponse>(req, "ModifyMigrateJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改迁移任务名
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public Task<ModifyMigrateNameResponse> ModifyMigrateName(ModifyMigrateNameRequest req)
        {
            return InternalRequestAsync<ModifyMigrateNameResponse>(req, "ModifyMigrateName");
        }

        /// <summary>
        /// 修改迁移任务名
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public ModifyMigrateNameResponse ModifyMigrateNameSync(ModifyMigrateNameRequest req)
        {
            return InternalRequestAsync<ModifyMigrateNameResponse>(req, "ModifyMigrateName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户在发现迁移任务对用户的数据库的负载影响较大时、可通过该接口限制任务的传输速率
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRateLimitRequest"/></param>
        /// <returns><see cref="ModifyMigrateRateLimitResponse"/></returns>
        public Task<ModifyMigrateRateLimitResponse> ModifyMigrateRateLimit(ModifyMigrateRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRateLimitResponse>(req, "ModifyMigrateRateLimit");
        }

        /// <summary>
        /// 用户在发现迁移任务对用户的数据库的负载影响较大时、可通过该接口限制任务的传输速率
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRateLimitRequest"/></param>
        /// <returns><see cref="ModifyMigrateRateLimitResponse"/></returns>
        public ModifyMigrateRateLimitResponse ModifyMigrateRateLimitSync(ModifyMigrateRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRateLimitResponse>(req, "ModifyMigrateRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改任务运行时属性，此接口不同于配置类接口，不会进行状态机判断。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRuntimeAttributeRequest"/></param>
        /// <returns><see cref="ModifyMigrateRuntimeAttributeResponse"/></returns>
        public Task<ModifyMigrateRuntimeAttributeResponse> ModifyMigrateRuntimeAttribute(ModifyMigrateRuntimeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRuntimeAttributeResponse>(req, "ModifyMigrateRuntimeAttribute");
        }

        /// <summary>
        /// 修改任务运行时属性，此接口不同于配置类接口，不会进行状态机判断。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateRuntimeAttributeRequest"/></param>
        /// <returns><see cref="ModifyMigrateRuntimeAttributeResponse"/></returns>
        public ModifyMigrateRuntimeAttributeResponse ModifyMigrateRuntimeAttributeSync(ModifyMigrateRuntimeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMigrateRuntimeAttributeResponse>(req, "ModifyMigrateRuntimeAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置迁移服务，配置成功后可通过`CreateMigrationCheckJob` 创建迁移校验任务接口发起校验任务，只有校验通过才能启动迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public Task<ModifyMigrationJobResponse> ModifyMigrationJob(ModifyMigrationJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrationJobResponse>(req, "ModifyMigrationJob");
        }

        /// <summary>
        /// 配置迁移服务，配置成功后可通过`CreateMigrationCheckJob` 创建迁移校验任务接口发起校验任务，只有校验通过才能启动迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public ModifyMigrationJobResponse ModifyMigrationJobSync(ModifyMigrationJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrationJobResponse>(req, "ModifyMigrationJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改订阅实例自动续费标识。只有包年包月的任务修改才有意义，按量计费任务修改后无影响。
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public Task<ModifySubscribeAutoRenewFlagResponse> ModifySubscribeAutoRenewFlag(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag");
        }

        /// <summary>
        /// 修改订阅实例自动续费标识。只有包年包月的任务修改才有意义，按量计费任务修改后无影响。
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public ModifySubscribeAutoRenewFlagResponse ModifySubscribeAutoRenewFlagSync(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeName)用于修改数据订阅实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public Task<ModifySubscribeNameResponse> ModifySubscribeName(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName");
        }

        /// <summary>
        /// 本接口(ModifySubscribeName)用于修改数据订阅实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public ModifySubscribeNameResponse ModifySubscribeNameSync(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeObjects)用于修改数据订阅对象和kafka分区规则，如果是mongo订阅，还可以修改输出聚合规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public Task<ModifySubscribeObjectsResponse> ModifySubscribeObjects(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects");
        }

        /// <summary>
        /// 本接口(ModifySubscribeObjects)用于修改数据订阅对象和kafka分区规则，如果是mongo订阅，还可以修改输出聚合规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public ModifySubscribeObjectsResponse ModifySubscribeObjectsSync(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持在同步任务启动后修改任务的配置
        /// 修改同步配置的完整流程：修改同步任务配置->创建修改同步任务配置的校验任务->查询修改配置的校验任务的结果->启动修改配置任务
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public Task<ModifySyncJobConfigResponse> ModifySyncJobConfig(ModifySyncJobConfigRequest req)
        {
            return InternalRequestAsync<ModifySyncJobConfigResponse>(req, "ModifySyncJobConfig");
        }

        /// <summary>
        /// 该接口支持在同步任务启动后修改任务的配置
        /// 修改同步配置的完整流程：修改同步任务配置->创建修改同步任务配置的校验任务->查询修改配置的校验任务的结果->启动修改配置任务
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobConfigRequest"/></param>
        /// <returns><see cref="ModifySyncJobConfigResponse"/></returns>
        public ModifySyncJobConfigResponse ModifySyncJobConfigSync(ModifySyncJobConfigRequest req)
        {
            return InternalRequestAsync<ModifySyncJobConfigResponse>(req, "ModifySyncJobConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户在发现同步任务对用户的数据库的负载影响较大时、可通过该接口限制任务的传输速率
        /// </summary>
        /// <param name="req"><see cref="ModifySyncRateLimitRequest"/></param>
        /// <returns><see cref="ModifySyncRateLimitResponse"/></returns>
        public Task<ModifySyncRateLimitResponse> ModifySyncRateLimit(ModifySyncRateLimitRequest req)
        {
            return InternalRequestAsync<ModifySyncRateLimitResponse>(req, "ModifySyncRateLimit");
        }

        /// <summary>
        /// 用户在发现同步任务对用户的数据库的负载影响较大时、可通过该接口限制任务的传输速率
        /// </summary>
        /// <param name="req"><see cref="ModifySyncRateLimitRequest"/></param>
        /// <returns><see cref="ModifySyncRateLimitResponse"/></returns>
        public ModifySyncRateLimitResponse ModifySyncRateLimitSync(ModifySyncRateLimitRequest req)
        {
            return InternalRequestAsync<ModifySyncRateLimitResponse>(req, "ModifySyncRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停一个迁移任务。
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public Task<PauseMigrateJobResponse> PauseMigrateJob(PauseMigrateJobRequest req)
        {
            return InternalRequestAsync<PauseMigrateJobResponse>(req, "PauseMigrateJob");
        }

        /// <summary>
        /// 暂停一个迁移任务。
        /// </summary>
        /// <param name="req"><see cref="PauseMigrateJobRequest"/></param>
        /// <returns><see cref="PauseMigrateJobResponse"/></returns>
        public PauseMigrateJobResponse PauseMigrateJobSync(PauseMigrateJobRequest req)
        {
            return InternalRequestAsync<PauseMigrateJobResponse>(req, "PauseMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停处于同步中的数据同步任务。
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public Task<PauseSyncJobResponse> PauseSyncJob(PauseSyncJobRequest req)
        {
            return InternalRequestAsync<PauseSyncJobResponse>(req, "PauseSyncJob");
        }

        /// <summary>
        /// 暂停处于同步中的数据同步任务。
        /// </summary>
        /// <param name="req"><see cref="PauseSyncJobRequest"/></param>
        /// <returns><see cref="PauseSyncJobResponse"/></returns>
        public PauseSyncJobResponse PauseSyncJobSync(PauseSyncJobRequest req)
        {
            return InternalRequestAsync<PauseSyncJobResponse>(req, "PauseSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除隔离数据迁移任务，用户手动发起隔离后的手动解隔离，只有任务状态为已隔离(手动操作)状态下才能触发此操作。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public Task<RecoverMigrateJobResponse> RecoverMigrateJob(RecoverMigrateJobRequest req)
        {
            return InternalRequestAsync<RecoverMigrateJobResponse>(req, "RecoverMigrateJob");
        }

        /// <summary>
        /// 解除隔离数据迁移任务，用户手动发起隔离后的手动解隔离，只有任务状态为已隔离(手动操作)状态下才能触发此操作。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public RecoverMigrateJobResponse RecoverMigrateJobSync(RecoverMigrateJobRequest req)
        {
            return InternalRequestAsync<RecoverMigrateJobResponse>(req, "RecoverMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除隔离同步任务，任务在已隔离状态下可调用该接口解除隔离状态任务，同时可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public Task<RecoverSyncJobResponse> RecoverSyncJob(RecoverSyncJobRequest req)
        {
            return InternalRequestAsync<RecoverSyncJobResponse>(req, "RecoverSyncJob");
        }

        /// <summary>
        /// 解除隔离同步任务，任务在已隔离状态下可调用该接口解除隔离状态任务，同时可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public RecoverSyncJobResponse RecoverSyncJobSync(RecoverSyncJobRequest req)
        {
            return InternalRequestAsync<RecoverSyncJobResponse>(req, "RecoverSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResetConsumerGroupOffset)用于重置订阅消费组的offset。调用DescribeConsumerGroups接口查询消费组状态，只有消费组状态为 Dead 或 Empty 才可以执行重置该操作。否则重置不会生效，接口也不会报错。
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public Task<ResetConsumerGroupOffsetResponse> ResetConsumerGroupOffset(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset");
        }

        /// <summary>
        /// 本接口(ResetConsumerGroupOffset)用于重置订阅消费组的offset。调用DescribeConsumerGroups接口查询消费组状态，只有消费组状态为 Dead 或 Empty 才可以执行重置该操作。否则重置不会生效，接口也不会报错。
        /// </summary>
        /// <param name="req"><see cref="ResetConsumerGroupOffsetRequest"/></param>
        /// <returns><see cref="ResetConsumerGroupOffsetResponse"/></returns>
        public ResetConsumerGroupOffsetResponse ResetConsumerGroupOffsetSync(ResetConsumerGroupOffsetRequest req)
        {
            return InternalRequestAsync<ResetConsumerGroupOffsetResponse>(req, "ResetConsumerGroupOffset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResetSubscribe)用于重置订阅实例，重置后，可以重新配置订阅任务。
        /// 可以调用 DescribeSubscribeDetail 查询订阅信息判断是否置成功。当SubsStatus变为notStarted时，表示重置成功。
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public Task<ResetSubscribeResponse> ResetSubscribe(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe");
        }

        /// <summary>
        /// 本接口(ResetSubscribe)用于重置订阅实例，重置后，可以重新配置订阅任务。
        /// 可以调用 DescribeSubscribeDetail 查询订阅信息判断是否置成功。当SubsStatus变为notStarted时，表示重置成功。
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public ResetSubscribeResponse ResetSubscribeSync(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整同步任务规格，此接口只支持按量计费任务的调整，调用此接口后不会立即生效，后台调整时间大概为3~5分钟。调用此接口后可通过查询同步任务信息接口DescribeSyncJobs，获取变配后的状态。
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public Task<ResizeSyncJobResponse> ResizeSyncJob(ResizeSyncJobRequest req)
        {
            return InternalRequestAsync<ResizeSyncJobResponse>(req, "ResizeSyncJob");
        }

        /// <summary>
        /// 调整同步任务规格，此接口只支持按量计费任务的调整，调用此接口后不会立即生效，后台调整时间大概为3~5分钟。调用此接口后可通过查询同步任务信息接口DescribeSyncJobs，获取变配后的状态。
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public ResizeSyncJobResponse ResizeSyncJobSync(ResizeSyncJobRequest req)
        {
            return InternalRequestAsync<ResizeSyncJobResponse>(req, "ResizeSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试数据迁移任务，针对异常情况可进行重试，对于redis在失败时也可重试。注意：此操作跳过校验阶段，直接重新发起任务，相当于从StartMigrationJob开始执行。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public Task<ResumeMigrateJobResponse> ResumeMigrateJob(ResumeMigrateJobRequest req)
        {
            return InternalRequestAsync<ResumeMigrateJobResponse>(req, "ResumeMigrateJob");
        }

        /// <summary>
        /// 重试数据迁移任务，针对异常情况可进行重试，对于redis在失败时也可重试。注意：此操作跳过校验阶段，直接重新发起任务，相当于从StartMigrationJob开始执行。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public ResumeMigrateJobResponse ResumeMigrateJobSync(ResumeMigrateJobRequest req)
        {
            return InternalRequestAsync<ResumeMigrateJobResponse>(req, "ResumeMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResumeSubscribe) 用于恢复报错的订阅任务。当订阅任务的状态为error时，可通过本接口尝试对任务进行恢复。
        /// </summary>
        /// <param name="req"><see cref="ResumeSubscribeRequest"/></param>
        /// <returns><see cref="ResumeSubscribeResponse"/></returns>
        public Task<ResumeSubscribeResponse> ResumeSubscribe(ResumeSubscribeRequest req)
        {
            return InternalRequestAsync<ResumeSubscribeResponse>(req, "ResumeSubscribe");
        }

        /// <summary>
        /// 本接口(ResumeSubscribe) 用于恢复报错的订阅任务。当订阅任务的状态为error时，可通过本接口尝试对任务进行恢复。
        /// </summary>
        /// <param name="req"><see cref="ResumeSubscribeRequest"/></param>
        /// <returns><see cref="ResumeSubscribeResponse"/></returns>
        public ResumeSubscribeResponse ResumeSubscribeSync(ResumeSubscribeRequest req)
        {
            return InternalRequestAsync<ResumeSubscribeResponse>(req, "ResumeSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试同步任务，部分可恢复报错情况下，可通过该接口重试同步任务，可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public Task<ResumeSyncJobResponse> ResumeSyncJob(ResumeSyncJobRequest req)
        {
            return InternalRequestAsync<ResumeSyncJobResponse>(req, "ResumeSyncJob");
        }

        /// <summary>
        /// 重试同步任务，部分可恢复报错情况下，可通过该接口重试同步任务，可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public ResumeSyncJobResponse ResumeSyncJobSync(ResumeSyncJobRequest req)
        {
            return InternalRequestAsync<ResumeSyncJobResponse>(req, "ResumeSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public Task<SkipCheckItemResponse> SkipCheckItem(SkipCheckItemRequest req)
        {
            return InternalRequestAsync<SkipCheckItemResponse>(req, "SkipCheckItem");
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public SkipCheckItemResponse SkipCheckItemSync(SkipCheckItemRequest req)
        {
            return InternalRequestAsync<SkipCheckItemResponse>(req, "SkipCheckItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public Task<SkipSyncCheckItemResponse> SkipSyncCheckItem(SkipSyncCheckItemRequest req)
        {
            return InternalRequestAsync<SkipSyncCheckItemResponse>(req, "SkipSyncCheckItem");
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public SkipSyncCheckItemResponse SkipSyncCheckItemSync(SkipSyncCheckItemRequest req)
        {
            return InternalRequestAsync<SkipSyncCheckItemResponse>(req, "SkipSyncCheckItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动一致性校验任务，启动之前需要先通过接口`CreateCompareTask` 创建一致性校验任务，启动后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public Task<StartCompareResponse> StartCompare(StartCompareRequest req)
        {
            return InternalRequestAsync<StartCompareResponse>(req, "StartCompare");
        }

        /// <summary>
        /// 启动一致性校验任务，启动之前需要先通过接口`CreateCompareTask` 创建一致性校验任务，启动后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public StartCompareResponse StartCompareSync(StartCompareRequest req)
        {
            return InternalRequestAsync<StartCompareResponse>(req, "StartCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob");
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在查询修改对象的校验任务的结果中的status为success后、通过该接口开始修改配置流程
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public Task<StartModifySyncJobResponse> StartModifySyncJob(StartModifySyncJobRequest req)
        {
            return InternalRequestAsync<StartModifySyncJobResponse>(req, "StartModifySyncJob");
        }

        /// <summary>
        /// 在查询修改对象的校验任务的结果中的status为success后、通过该接口开始修改配置流程
        /// </summary>
        /// <param name="req"><see cref="StartModifySyncJobRequest"/></param>
        /// <returns><see cref="StartModifySyncJobResponse"/></returns>
        public StartModifySyncJobResponse StartModifySyncJobSync(StartModifySyncJobRequest req)
        {
            return InternalRequestAsync<StartModifySyncJobResponse>(req, "StartModifySyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(StartSubscribe)用于启动一个kafka版本的数据订阅实例。只有当订阅任务的状态为checkPass时，才能调用本接口。
        /// </summary>
        /// <param name="req"><see cref="StartSubscribeRequest"/></param>
        /// <returns><see cref="StartSubscribeResponse"/></returns>
        public Task<StartSubscribeResponse> StartSubscribe(StartSubscribeRequest req)
        {
            return InternalRequestAsync<StartSubscribeResponse>(req, "StartSubscribe");
        }

        /// <summary>
        /// 本接口(StartSubscribe)用于启动一个kafka版本的数据订阅实例。只有当订阅任务的状态为checkPass时，才能调用本接口。
        /// </summary>
        /// <param name="req"><see cref="StartSubscribeRequest"/></param>
        /// <returns><see cref="StartSubscribeResponse"/></returns>
        public StartSubscribeResponse StartSubscribeSync(StartSubscribeRequest req)
        {
            return InternalRequestAsync<StartSubscribeResponse>(req, "StartSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动同步任务
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public Task<StartSyncJobResponse> StartSyncJob(StartSyncJobRequest req)
        {
            return InternalRequestAsync<StartSyncJobResponse>(req, "StartSyncJob");
        }

        /// <summary>
        /// 启动同步任务
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public StartSyncJobResponse StartSyncJobSync(StartSyncJobRequest req)
        {
            return InternalRequestAsync<StartSyncJobResponse>(req, "StartSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public Task<StopCompareResponse> StopCompare(StopCompareRequest req)
        {
            return InternalRequestAsync<StopCompareResponse>(req, "StopCompare");
        }

        /// <summary>
        /// 终止一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public StopCompareResponse StopCompareSync(StopCompareRequest req)
        {
            return InternalRequestAsync<StopCompareResponse>(req, "StopCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于终止数据迁移任务。
        /// 调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob");
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于终止数据迁移任务。
        /// 调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 结束同步任务，操作后可通过查询同步任务信息接口DescribeSyncJobs，获取操作后的状态。
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public Task<StopSyncJobResponse> StopSyncJob(StopSyncJobRequest req)
        {
            return InternalRequestAsync<StopSyncJobResponse>(req, "StopSyncJob");
        }

        /// <summary>
        /// 结束同步任务，操作后可通过查询同步任务信息接口DescribeSyncJobs，获取操作后的状态。
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public StopSyncJobResponse StopSyncJobSync(StopSyncJobRequest req)
        {
            return InternalRequestAsync<StopSyncJobResponse>(req, "StopSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
