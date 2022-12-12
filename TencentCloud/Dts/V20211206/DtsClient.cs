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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrationJobs接口查询到任务的状态为准备完成（Status="readyComplete"）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public async Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
             JsonResponseModel<CompleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CompleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置一个同步任务
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public async Task<ConfigureSyncJobResponse> ConfigureSyncJob(ConfigureSyncJobRequest req)
        {
             JsonResponseModel<ConfigureSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfigureSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfigureSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置一个同步任务
        /// </summary>
        /// <param name="req"><see cref="ConfigureSyncJobRequest"/></param>
        /// <returns><see cref="ConfigureSyncJobResponse"/></returns>
        public ConfigureSyncJobResponse ConfigureSyncJobSync(ConfigureSyncJobRequest req)
        {
             JsonResponseModel<ConfigureSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfigureSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfigureSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验同步任务，检查必要参数和周边配置。
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public async Task<CreateCheckSyncJobResponse> CreateCheckSyncJob(CreateCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验同步任务，检查必要参数和周边配置。
        /// </summary>
        /// <param name="req"><see cref="CreateCheckSyncJobRequest"/></param>
        /// <returns><see cref="CreateCheckSyncJobResponse"/></returns>
        public CreateCheckSyncJobResponse CreateCheckSyncJobSync(CreateCheckSyncJobRequest req)
        {
             JsonResponseModel<CreateCheckSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCheckSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据对比任务，创建成功后会返回数据对比任务 ID，形如：dts-8yv4w2i1-cmp-37skmii9，创建成功后可通过StartCompare启动一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public async Task<CreateCompareTaskResponse> CreateCompareTask(CreateCompareTaskRequest req)
        {
             JsonResponseModel<CreateCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据对比任务，创建成功后会返回数据对比任务 ID，形如：dts-8yv4w2i1-cmp-37skmii9，创建成功后可通过StartCompare启动一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="CreateCompareTaskRequest"/></param>
        /// <returns><see cref="CreateCompareTaskResponse"/></returns>
        public CreateCompareTaskResponse CreateCompareTaskSync(CreateCompareTaskRequest req)
        {
             JsonResponseModel<CreateCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验迁移任务，
        /// 在开始迁移前, 必须调用本接口创建校验迁移任务, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrationCheckJob查看，
        /// 校验成功后,迁移任务若有修改, 则必须重新校验并通过后, 才能开始迁移
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public async Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
             JsonResponseModel<CreateMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买迁移任务。购买成功后会返回随机生成的迁移任务id列表，也可以通过查询迁移任务任务列表接口`DescribeMigrationJobs`看到购买成功的实例Id。注意，一旦购买成功后源及目标数据库类型，源及目标实例地域不可修改。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public async Task<CreateMigrationServiceResponse> CreateMigrationService(CreateMigrationServiceRequest req)
        {
             JsonResponseModel<CreateMigrationServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买迁移任务。购买成功后会返回随机生成的迁移任务id列表，也可以通过查询迁移任务任务列表接口`DescribeMigrationJobs`看到购买成功的实例Id。注意，一旦购买成功后源及目标数据库类型，源及目标实例地域不可修改。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationServiceRequest"/></param>
        /// <returns><see cref="CreateMigrationServiceResponse"/></returns>
        public CreateMigrationServiceResponse CreateMigrationServiceSync(CreateMigrationServiceRequest req)
        {
             JsonResponseModel<CreateMigrationServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrationService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public async Task<CreateSyncJobResponse> CreateSyncJob(CreateSyncJobRequest req)
        {
             JsonResponseModel<CreateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateSyncJobRequest"/></param>
        /// <returns><see cref="CreateSyncJobResponse"/></returns>
        public CreateSyncJobResponse CreateSyncJobSync(CreateSyncJobRequest req)
        {
             JsonResponseModel<CreateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一致性校验任务。当一致性校验任务状态为success、failed、canceled 时可以执行此操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public async Task<DeleteCompareTaskResponse> DeleteCompareTask(DeleteCompareTaskRequest req)
        {
             JsonResponseModel<DeleteCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一致性校验任务。当一致性校验任务状态为success、failed、canceled 时可以执行此操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompareTaskRequest"/></param>
        /// <returns><see cref="DeleteCompareTaskResponse"/></returns>
        public DeleteCompareTaskResponse DeleteCompareTaskSync(DeleteCompareTaskRequest req)
        {
             JsonResponseModel<DeleteCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询同步校验任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public async Task<DescribeCheckSyncJobResultResponse> DescribeCheckSyncJobResult(DescribeCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询同步校验任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSyncJobResultRequest"/></param>
        /// <returns><see cref="DescribeCheckSyncJobResultResponse"/></returns>
        public DescribeCheckSyncJobResultResponse DescribeCheckSyncJobResultSync(DescribeCheckSyncJobResultRequest req)
        {
             JsonResponseModel<DescribeCheckSyncJobResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckSyncJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSyncJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一致性校验任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public async Task<DescribeCompareReportResponse> DescribeCompareReport(DescribeCompareReportRequest req)
        {
             JsonResponseModel<DescribeCompareReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompareReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一致性校验任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareReportRequest"/></param>
        /// <returns><see cref="DescribeCompareReportResponse"/></returns>
        public DescribeCompareReportResponse DescribeCompareReportSync(DescribeCompareReportRequest req)
        {
             JsonResponseModel<DescribeCompareReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompareReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一致性校验任务列表，调用该接口后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public async Task<DescribeCompareTasksResponse> DescribeCompareTasks(DescribeCompareTasksRequest req)
        {
             JsonResponseModel<DescribeCompareTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一致性校验任务列表，调用该接口后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompareTasksRequest"/></param>
        /// <returns><see cref="DescribeCompareTasksResponse"/></returns>
        public DescribeCompareTasksResponse DescribeCompareTasksSync(DescribeCompareTasksRequest req)
        {
             JsonResponseModel<DescribeCompareTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompareTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询支持迁移的云数据库实例
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public async Task<DescribeMigrateDBInstancesResponse> DescribeMigrateDBInstances(DescribeMigrateDBInstancesRequest req)
        {
             JsonResponseModel<DescribeMigrateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询支持迁移的云数据库实例
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeMigrateDBInstancesResponse"/></returns>
        public DescribeMigrateDBInstancesResponse DescribeMigrateDBInstancesSync(DescribeMigrateDBInstancesRequest req)
        {
             JsonResponseModel<DescribeMigrateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrationJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrationCheckJobResponse"/></returns>
        public async Task<DescribeMigrationCheckJobResponse> DescribeMigrationCheckJob(DescribeMigrationCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrationCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeMigrationCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public async Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public async Task<DescribeMigrationJobsResponse> DescribeMigrationJobs(DescribeMigrationJobsRequest req)
        {
             JsonResponseModel<DescribeMigrationJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrationJobsResponse"/></returns>
        public DescribeMigrationJobsResponse DescribeMigrationJobsSync(DescribeMigrationJobsRequest req)
        {
             JsonResponseModel<DescribeMigrationJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询同步任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public async Task<DescribeSyncJobsResponse> DescribeSyncJobs(DescribeSyncJobsRequest req)
        {
             JsonResponseModel<DescribeSyncJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSyncJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询同步任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncJobsRequest"/></param>
        /// <returns><see cref="DescribeSyncJobsResponse"/></returns>
        public DescribeSyncJobsResponse DescribeSyncJobsSync(DescribeSyncJobsRequest req)
        {
             JsonResponseModel<DescribeSyncJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSyncJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线数据迁移任务。计费任务必须先调用隔离(IsolateMigrateJob)接口，且只有是**已隔离**状态下，才能调用此接口销毁任务。对于不计费任务，调用隔离(IsolateMigrateJob)接口删除任务操作。
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public async Task<DestroyMigrateJobResponse> DestroyMigrateJob(DestroyMigrateJobRequest req)
        {
             JsonResponseModel<DestroyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线数据迁移任务。计费任务必须先调用隔离(IsolateMigrateJob)接口，且只有是**已隔离**状态下，才能调用此接口销毁任务。对于不计费任务，调用隔离(IsolateMigrateJob)接口删除任务操作。
        /// </summary>
        /// <param name="req"><see cref="DestroyMigrateJobRequest"/></param>
        /// <returns><see cref="DestroyMigrateJobResponse"/></returns>
        public DestroyMigrateJobResponse DestroyMigrateJobSync(DestroyMigrateJobRequest req)
        {
             JsonResponseModel<DestroyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线同步任务，任务在已隔离状态下可以通过此操作进行任务下线，即彻底删除任务。下线操作后可通过查询同步任务信息接口DescribeSyncJobs获取任务列表查看状态，此操作成功后无法看到此任务表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public async Task<DestroySyncJobResponse> DestroySyncJob(DestroySyncJobRequest req)
        {
             JsonResponseModel<DestroySyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下线同步任务，任务在已隔离状态下可以通过此操作进行任务下线，即彻底删除任务。下线操作后可通过查询同步任务信息接口DescribeSyncJobs获取任务列表查看状态，此操作成功后无法看到此任务表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroySyncJobRequest"/></param>
        /// <returns><see cref="DestroySyncJobResponse"/></returns>
        public DestroySyncJobResponse DestroySyncJobSync(DestroySyncJobRequest req)
        {
             JsonResponseModel<DestroySyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  隔离退还数据迁移服务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。对于计费任务，在任务隔离后可进行解除隔离(RecoverMigrationJob)操作或直接进行下线销毁(DestroyMigrateJob)操作。对于不计费任务，调用此接口会直接销毁任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public async Task<IsolateMigrateJobResponse> IsolateMigrateJob(IsolateMigrateJobRequest req)
        {
             JsonResponseModel<IsolateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  隔离退还数据迁移服务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。对于计费任务，在任务隔离后可进行解除隔离(RecoverMigrationJob)操作或直接进行下线销毁(DestroyMigrateJob)操作。对于不计费任务，调用此接口会直接销毁任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateMigrateJobRequest"/></param>
        /// <returns><see cref="IsolateMigrateJobResponse"/></returns>
        public IsolateMigrateJobResponse IsolateMigrateJobSync(IsolateMigrateJobRequest req)
        {
             JsonResponseModel<IsolateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离同步任务，隔离后可通过查询同步任务信息接口DescribeSyncJobs获取隔离后状态。在任务隔离后可进行解除隔离(RecoverSyncJob)操作或直接进行下线操作。对于不计费任务，调用此接口后会直接删除任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public async Task<IsolateSyncJobResponse> IsolateSyncJob(IsolateSyncJobRequest req)
        {
             JsonResponseModel<IsolateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离同步任务，隔离后可通过查询同步任务信息接口DescribeSyncJobs获取隔离后状态。在任务隔离后可进行解除隔离(RecoverSyncJob)操作或直接进行下线操作。对于不计费任务，调用此接口后会直接删除任务，无法进行恢复操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateSyncJobRequest"/></param>
        /// <returns><see cref="IsolateSyncJobResponse"/></returns>
        public IsolateSyncJobResponse IsolateSyncJobSync(IsolateSyncJobRequest req)
        {
             JsonResponseModel<IsolateSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改一致性校验任务，在任务创建后启动之前，可修改一致性校验参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public async Task<ModifyCompareTaskResponse> ModifyCompareTask(ModifyCompareTaskRequest req)
        {
             JsonResponseModel<ModifyCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改一致性校验任务，在任务创建后启动之前，可修改一致性校验参数
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskResponse"/></returns>
        public ModifyCompareTaskResponse ModifyCompareTaskSync(ModifyCompareTaskRequest req)
        {
             JsonResponseModel<ModifyCompareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCompareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改一致性校验任务名称
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public async Task<ModifyCompareTaskNameResponse> ModifyCompareTaskName(ModifyCompareTaskNameRequest req)
        {
             JsonResponseModel<ModifyCompareTaskNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCompareTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改一致性校验任务名称
        /// </summary>
        /// <param name="req"><see cref="ModifyCompareTaskNameRequest"/></param>
        /// <returns><see cref="ModifyCompareTaskNameResponse"/></returns>
        public ModifyCompareTaskNameResponse ModifyCompareTaskNameSync(ModifyCompareTaskNameRequest req)
        {
             JsonResponseModel<ModifyCompareTaskNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCompareTaskName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompareTaskNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整实例规格，此接口只支持按量计费任务的调整。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public async Task<ModifyMigrateJobSpecResponse> ModifyMigrateJobSpec(ModifyMigrateJobSpecRequest req)
        {
             JsonResponseModel<ModifyMigrateJobSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateJobSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整实例规格，此接口只支持按量计费任务的调整。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobSpecRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobSpecResponse"/></returns>
        public ModifyMigrateJobSpecResponse ModifyMigrateJobSpecSync(ModifyMigrateJobSpecRequest req)
        {
             JsonResponseModel<ModifyMigrateJobSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateJobSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改迁移任务名
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public async Task<ModifyMigrateNameResponse> ModifyMigrateName(ModifyMigrateNameRequest req)
        {
             JsonResponseModel<ModifyMigrateNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改迁移任务名
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateNameRequest"/></param>
        /// <returns><see cref="ModifyMigrateNameResponse"/></returns>
        public ModifyMigrateNameResponse ModifyMigrateNameSync(ModifyMigrateNameRequest req)
        {
             JsonResponseModel<ModifyMigrateNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置迁移服务，配置成功后可通过`CreateMigrationCheckJob` 创建迁移校验任务接口发起校验任务，只有校验通过才能启动迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public async Task<ModifyMigrationJobResponse> ModifyMigrationJob(ModifyMigrationJobRequest req)
        {
             JsonResponseModel<ModifyMigrationJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrationJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置迁移服务，配置成功后可通过`CreateMigrationCheckJob` 创建迁移校验任务接口发起校验任务，只有校验通过才能启动迁移任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationJobRequest"/></param>
        /// <returns><see cref="ModifyMigrationJobResponse"/></returns>
        public ModifyMigrationJobResponse ModifyMigrationJobSync(ModifyMigrationJobRequest req)
        {
             JsonResponseModel<ModifyMigrationJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrationJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除隔离数据迁移任务，用户手动发起隔离后的手动解隔离，只有任务状态为已隔离(手动操作)状态下才能触发此操作。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public async Task<RecoverMigrateJobResponse> RecoverMigrateJob(RecoverMigrateJobRequest req)
        {
             JsonResponseModel<RecoverMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除隔离数据迁移任务，用户手动发起隔离后的手动解隔离，只有任务状态为已隔离(手动操作)状态下才能触发此操作。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverMigrateJobRequest"/></param>
        /// <returns><see cref="RecoverMigrateJobResponse"/></returns>
        public RecoverMigrateJobResponse RecoverMigrateJobSync(RecoverMigrateJobRequest req)
        {
             JsonResponseModel<RecoverMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除隔离同步任务，任务在已隔离状态下可调用该接口解除隔离状态任务，同时可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public async Task<RecoverSyncJobResponse> RecoverSyncJob(RecoverSyncJobRequest req)
        {
             JsonResponseModel<RecoverSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除隔离同步任务，任务在已隔离状态下可调用该接口解除隔离状态任务，同时可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="RecoverSyncJobRequest"/></param>
        /// <returns><see cref="RecoverSyncJobResponse"/></returns>
        public RecoverSyncJobResponse RecoverSyncJobSync(RecoverSyncJobRequest req)
        {
             JsonResponseModel<RecoverSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整同步任务规格，此接口只支持按量计费任务的调整，调用此接口后不会立即生效，后台调整时间大概为3~5分钟。调用此接口后可通过查询同步任务信息接口DescribeSyncJobs，获取变配后的状态。
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public async Task<ResizeSyncJobResponse> ResizeSyncJob(ResizeSyncJobRequest req)
        {
             JsonResponseModel<ResizeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整同步任务规格，此接口只支持按量计费任务的调整，调用此接口后不会立即生效，后台调整时间大概为3~5分钟。调用此接口后可通过查询同步任务信息接口DescribeSyncJobs，获取变配后的状态。
        /// </summary>
        /// <param name="req"><see cref="ResizeSyncJobRequest"/></param>
        /// <returns><see cref="ResizeSyncJobResponse"/></returns>
        public ResizeSyncJobResponse ResizeSyncJobSync(ResizeSyncJobRequest req)
        {
             JsonResponseModel<ResizeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试数据迁移任务，针对异常情况可进行重试，对于redis在失败时也可重试。注意：此操作跳过校验阶段，直接重新发起任务，相当于从StartMigrationJob开始执行。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public async Task<ResumeMigrateJobResponse> ResumeMigrateJob(ResumeMigrateJobRequest req)
        {
             JsonResponseModel<ResumeMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试数据迁移任务，针对异常情况可进行重试，对于redis在失败时也可重试。注意：此操作跳过校验阶段，直接重新发起任务，相当于从StartMigrationJob开始执行。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeMigrateJobRequest"/></param>
        /// <returns><see cref="ResumeMigrateJobResponse"/></returns>
        public ResumeMigrateJobResponse ResumeMigrateJobSync(ResumeMigrateJobRequest req)
        {
             JsonResponseModel<ResumeMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试同步任务，部分可恢复报错情况下，可通过该接口重试同步任务，可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public async Task<ResumeSyncJobResponse> ResumeSyncJob(ResumeSyncJobRequest req)
        {
             JsonResponseModel<ResumeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试同步任务，部分可恢复报错情况下，可通过该接口重试同步任务，可通过查询同步任务信息接口DescribeSyncJobs，获取操作后状态。
        /// </summary>
        /// <param name="req"><see cref="ResumeSyncJobRequest"/></param>
        /// <returns><see cref="ResumeSyncJobResponse"/></returns>
        public ResumeSyncJobResponse ResumeSyncJobSync(ResumeSyncJobRequest req)
        {
             JsonResponseModel<ResumeSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public async Task<SkipCheckItemResponse> SkipCheckItem(SkipCheckItemRequest req)
        {
             JsonResponseModel<SkipCheckItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SkipCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipCheckItemRequest"/></param>
        /// <returns><see cref="SkipCheckItemResponse"/></returns>
        public SkipCheckItemResponse SkipCheckItemSync(SkipCheckItemRequest req)
        {
             JsonResponseModel<SkipCheckItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SkipCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public async Task<SkipSyncCheckItemResponse> SkipSyncCheckItem(SkipSyncCheckItemRequest req)
        {
             JsonResponseModel<SkipSyncCheckItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SkipSyncCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipSyncCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验检查项不通过后，可进行跳过此校验项操作，后端将不再校验该项。任何校验步骤都是不应该跳过的，通过校验是能正确执行的前置条件。支持跳过的产品及链路的校验项可 [参考文档](https://cloud.tencent.com/document/product/571/61639)。
        /// </summary>
        /// <param name="req"><see cref="SkipSyncCheckItemRequest"/></param>
        /// <returns><see cref="SkipSyncCheckItemResponse"/></returns>
        public SkipSyncCheckItemResponse SkipSyncCheckItemSync(SkipSyncCheckItemRequest req)
        {
             JsonResponseModel<SkipSyncCheckItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SkipSyncCheckItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SkipSyncCheckItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动一致性校验任务，启动之前需要先通过接口`CreateCompareTask` 创建一致性校验任务，启动后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public async Task<StartCompareResponse> StartCompare(StartCompareRequest req)
        {
             JsonResponseModel<StartCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动一致性校验任务，启动之前需要先通过接口`CreateCompareTask` 创建一致性校验任务，启动后可通过接口`DescribeCompareTasks` 查询一致性校验任务列表来获得启动后的状态
        /// </summary>
        /// <param name="req"><see cref="StartCompareRequest"/></param>
        /// <returns><see cref="StartCompareResponse"/></returns>
        public StartCompareResponse StartCompareSync(StartCompareRequest req)
        {
             JsonResponseModel<StartCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public async Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
             JsonResponseModel<StartMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
             JsonResponseModel<StartMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动同步任务
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public async Task<StartSyncJobResponse> StartSyncJob(StartSyncJobRequest req)
        {
             JsonResponseModel<StartSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动同步任务
        /// </summary>
        /// <param name="req"><see cref="StartSyncJobRequest"/></param>
        /// <returns><see cref="StartSyncJobResponse"/></returns>
        public StartSyncJobResponse StartSyncJobSync(StartSyncJobRequest req)
        {
             JsonResponseModel<StartSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 终止一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public async Task<StopCompareResponse> StopCompare(StopCompareRequest req)
        {
             JsonResponseModel<StopCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 终止一致性校验任务
        /// </summary>
        /// <param name="req"><see cref="StopCompareRequest"/></param>
        /// <returns><see cref="StopCompareResponse"/></returns>
        public StopCompareResponse StopCompareSync(StopCompareRequest req)
        {
             JsonResponseModel<StopCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于终止数据迁移任务。
        /// 调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public async Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
             JsonResponseModel<StopMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于终止数据迁移任务。
        /// 调用此接口后可通过查询迁移服务列表接口`DescribeMigrationJobs`来查询当前任务状态。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
             JsonResponseModel<StopMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结束同步任务，操作后可通过查询同步任务信息接口DescribeSyncJobs，获取操作后的状态。
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public async Task<StopSyncJobResponse> StopSyncJob(StopSyncJobRequest req)
        {
             JsonResponseModel<StopSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结束同步任务，操作后可通过查询同步任务信息接口DescribeSyncJobs，获取操作后的状态。
        /// </summary>
        /// <param name="req"><see cref="StopSyncJobRequest"/></param>
        /// <returns><see cref="StopSyncJobResponse"/></returns>
        public StopSyncJobResponse StopSyncJobSync(StopSyncJobRequest req)
        {
             JsonResponseModel<StopSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
