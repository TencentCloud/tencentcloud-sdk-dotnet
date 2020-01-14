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

namespace TencentCloud.Dts.V20180330
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dts.V20180330.Models;

   public class DtsClient : AbstractClient{

       private const string endpoint = "dts.tencentcloudapi.com";
       private const string version = "2018-03-30";

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
        /// 通过DescribeMigrateJobs接口查询到任务的状态为准备完成（status=8）时，此时可以调用本接口完成迁移任务。
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
        /// CompleteMigrateJob接口的同步版本，本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrateJobs接口查询到任务的状态为准备完成（status=8）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req">参考<see cref="CompleteMigrateJobRequest"/></param>
        /// <returns>参考<see cref="CompleteMigrateJobResponse"/>实例</returns>
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
        /// 创建校验迁移任务
        /// 在开始迁移前, 必须调用本接口创建校验, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrateCheckJob查看.
        /// 校验成功后,迁移任务若有修改, 则必须重新创建校验并通过后, 才能开始迁移.
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
        /// CreateMigrateCheckJob接口的同步版本，创建校验迁移任务
        /// 在开始迁移前, 必须调用本接口创建校验, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrateCheckJob查看.
        /// 校验成功后,迁移任务若有修改, 则必须重新创建校验并通过后, 才能开始迁移.
        /// </summary>
        /// <param name="req">参考<see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns>参考<see cref="CreateMigrateCheckJobResponse"/>实例</returns>
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
        /// 本接口（CreateMigrateJob）用于创建数据迁移任务。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public async Task<CreateMigrateJobResponse> CreateMigrateJob(CreateMigrateJobRequest req)
        {
             JsonResponseModel<CreateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateMigrateJob接口的同步版本，本接口（CreateMigrateJob）用于创建数据迁移任务。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="CreateMigrateJobRequest"/></param>
        /// <returns>参考<see cref="CreateMigrateJobResponse"/>实例</returns>
        public CreateMigrateJobResponse CreateMigrateJobSync(CreateMigrateJobRequest req)
        {
             JsonResponseModel<CreateMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在调用 StartSyncJob 接口启动灾备同步前, 必须调用本接口创建校验, 且校验成功后才能开始同步数据. 校验的结果可以通过 DescribeSyncCheckJob 查看.
        /// 校验成功后才能启动同步.
        /// </summary>
        /// <param name="req"><see cref="CreateSyncCheckJobRequest"/></param>
        /// <returns><see cref="CreateSyncCheckJobResponse"/></returns>
        public async Task<CreateSyncCheckJobResponse> CreateSyncCheckJob(CreateSyncCheckJobRequest req)
        {
             JsonResponseModel<CreateSyncCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSyncCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateSyncCheckJob接口的同步版本，在调用 StartSyncJob 接口启动灾备同步前, 必须调用本接口创建校验, 且校验成功后才能开始同步数据. 校验的结果可以通过 DescribeSyncCheckJob 查看.
        /// 校验成功后才能启动同步.
        /// </summary>
        /// <param name="req">参考<see cref="CreateSyncCheckJobRequest"/></param>
        /// <returns>参考<see cref="CreateSyncCheckJobResponse"/>实例</returns>
        public CreateSyncCheckJobResponse CreateSyncCheckJobSync(CreateSyncCheckJobRequest req)
        {
             JsonResponseModel<CreateSyncCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSyncCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSyncCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateSyncJob)用于创建灾备同步任务。
        /// 创建同步任务后，可以通过 CreateSyncCheckJob 接口发起校验任务。校验成功后才可以通过 StartSyncJob 接口启动同步任务。
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
        /// CreateSyncJob接口的同步版本，本接口(CreateSyncJob)用于创建灾备同步任务。
        /// 创建同步任务后，可以通过 CreateSyncCheckJob 接口发起校验任务。校验成功后才可以通过 StartSyncJob 接口启动同步任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSyncJobRequest"/></param>
        /// <returns>参考<see cref="CreateSyncJobResponse"/>实例</returns>
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
        /// 本接口（DeleteMigrationJob）用于删除数据迁移任务。当通过DescribeMigrateJobs接口查询到任务的状态为：检验中（status=3）、运行中（status=7）、准备完成（status=8）、撤销中（status=11）或者完成中（status=12）时，不允许删除任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public async Task<DeleteMigrateJobResponse> DeleteMigrateJob(DeleteMigrateJobRequest req)
        {
             JsonResponseModel<DeleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteMigrateJob接口的同步版本，本接口（DeleteMigrationJob）用于删除数据迁移任务。当通过DescribeMigrateJobs接口查询到任务的状态为：检验中（status=3）、运行中（status=7）、准备完成（status=8）、撤销中（status=11）或者完成中（status=12）时，不允许删除任务。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMigrateJobRequest"/></param>
        /// <returns>参考<see cref="DeleteMigrateJobResponse"/>实例</returns>
        public DeleteMigrateJobResponse DeleteMigrateJobSync(DeleteMigrateJobRequest req)
        {
             JsonResponseModel<DeleteMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除灾备同步任务 （运行中的同步任务不能删除）。
        /// </summary>
        /// <param name="req"><see cref="DeleteSyncJobRequest"/></param>
        /// <returns><see cref="DeleteSyncJobResponse"/></returns>
        public async Task<DeleteSyncJobResponse> DeleteSyncJob(DeleteSyncJobRequest req)
        {
             JsonResponseModel<DeleteSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteSyncJob接口的同步版本，删除灾备同步任务 （运行中的同步任务不能删除）。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSyncJobRequest"/></param>
        /// <returns>参考<see cref="DeleteSyncJobResponse"/>实例</returns>
        public DeleteSyncJobResponse DeleteSyncJobSync(DeleteSyncJobRequest req)
        {
             JsonResponseModel<DeleteSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSyncJobResponse>>(strResp);
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
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrateJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public async Task<DescribeMigrateCheckJobResponse> DescribeMigrateCheckJob(DescribeMigrateCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMigrateCheckJob接口的同步版本，本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrateJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrateCheckJobResponse"/>实例</returns>
        public DescribeMigrateCheckJobResponse DescribeMigrateCheckJobSync(DescribeMigrateCheckJobRequest req)
        {
             JsonResponseModel<DescribeMigrateCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据迁移任务.
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public async Task<DescribeMigrateJobsResponse> DescribeMigrateJobs(DescribeMigrateJobsRequest req)
        {
             JsonResponseModel<DescribeMigrateJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrateJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMigrateJobs接口的同步版本，查询数据迁移任务.
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrateJobsResponse"/>实例</returns>
        public DescribeMigrateJobsResponse DescribeMigrateJobsSync(DescribeMigrateJobsRequest req)
        {
             JsonResponseModel<DescribeMigrateJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrateJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrateJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于在通过 CreateSyncCheckJob 接口创建灾备同步校验任务后，获取校验的结果。能查询到当前校验的状态和进度。
        /// 若通过校验, 则可调用 StartSyncJob 启动同步任务。
        /// 若未通过校验, 则会返回校验失败的原因。 可通过 ModifySyncJob 修改配置，然后再次发起校验。
        /// 校验任务需要大概约30秒，当返回的 Status 不为 finished 时表示尚未校验完成，需要轮询该接口。
        /// 如果 Status=finished 且 CheckFlag=1 时表示校验成功。
        /// 如果 Status=finished 且 CheckFlag !=1 时表示校验失败。
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncCheckJobRequest"/></param>
        /// <returns><see cref="DescribeSyncCheckJobResponse"/></returns>
        public async Task<DescribeSyncCheckJobResponse> DescribeSyncCheckJob(DescribeSyncCheckJobRequest req)
        {
             JsonResponseModel<DescribeSyncCheckJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSyncCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSyncCheckJob接口的同步版本，本接口用于在通过 CreateSyncCheckJob 接口创建灾备同步校验任务后，获取校验的结果。能查询到当前校验的状态和进度。
        /// 若通过校验, 则可调用 StartSyncJob 启动同步任务。
        /// 若未通过校验, 则会返回校验失败的原因。 可通过 ModifySyncJob 修改配置，然后再次发起校验。
        /// 校验任务需要大概约30秒，当返回的 Status 不为 finished 时表示尚未校验完成，需要轮询该接口。
        /// 如果 Status=finished 且 CheckFlag=1 时表示校验成功。
        /// 如果 Status=finished 且 CheckFlag !=1 时表示校验失败。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSyncCheckJobRequest"/></param>
        /// <returns>参考<see cref="DescribeSyncCheckJobResponse"/>实例</returns>
        public DescribeSyncCheckJobResponse DescribeSyncCheckJobSync(DescribeSyncCheckJobRequest req)
        {
             JsonResponseModel<DescribeSyncCheckJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSyncCheckJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncCheckJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询在迁移平台发起的灾备同步任务
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
        /// DescribeSyncJobs接口的同步版本，查询在迁移平台发起的灾备同步任务
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSyncJobsRequest"/></param>
        /// <returns>参考<see cref="DescribeSyncJobsResponse"/>实例</returns>
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
        /// 本接口（ModifyMigrateJob）用于修改数据迁移任务。
        /// 当迁移任务处于下述状态时，允许调用本接口修改迁移任务：迁移创建中（status=1）、 校验成功(status=4)、校验失败(status=5)、迁移失败(status=10)。但源实例、目标实例类型和目标实例地域不允许修改。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public async Task<ModifyMigrateJobResponse> ModifyMigrateJob(ModifyMigrateJobRequest req)
        {
             JsonResponseModel<ModifyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyMigrateJob接口的同步版本，本接口（ModifyMigrateJob）用于修改数据迁移任务。
        /// 当迁移任务处于下述状态时，允许调用本接口修改迁移任务：迁移创建中（status=1）、 校验成功(status=4)、校验失败(status=5)、迁移失败(status=10)。但源实例、目标实例类型和目标实例地域不允许修改。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMigrateJobRequest"/></param>
        /// <returns>参考<see cref="ModifyMigrateJobResponse"/>实例</returns>
        public ModifyMigrateJobResponse ModifyMigrateJobSync(ModifyMigrateJobRequest req)
        {
             JsonResponseModel<ModifyMigrateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改灾备同步任务. 
        /// 当同步任务处于下述状态时, 允许调用本接口: 同步任务创建中, 创建完成, 校验成功, 校验失败. 
        /// 源实例和目标实例信息不允许修改，可以修改任务名、需要同步的库表。
        /// </summary>
        /// <param name="req"><see cref="ModifySyncJobRequest"/></param>
        /// <returns><see cref="ModifySyncJobResponse"/></returns>
        public async Task<ModifySyncJobResponse> ModifySyncJob(ModifySyncJobRequest req)
        {
             JsonResponseModel<ModifySyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifySyncJob接口的同步版本，修改灾备同步任务. 
        /// 当同步任务处于下述状态时, 允许调用本接口: 同步任务创建中, 创建完成, 校验成功, 校验失败. 
        /// 源实例和目标实例信息不允许修改，可以修改任务名、需要同步的库表。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySyncJobRequest"/></param>
        /// <returns>参考<see cref="ModifySyncJobResponse"/>实例</returns>
        public ModifySyncJobResponse ModifySyncJobSync(ModifySyncJobRequest req)
        {
             JsonResponseModel<ModifySyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。非定时迁移任务会在调用后立即开始迁移，定时任务则会开始倒计时。
        /// 调用此接口前，请务必先使用CreateMigrateCheckJob校验数据迁移任务，并通过DescribeMigrateJobs接口查询到任务状态为校验通过（status=4）时，才能启动数据迁移任务。
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
        /// StartMigrateJob接口的同步版本，本接口（StartMigrationJob）用于启动迁移任务。非定时迁移任务会在调用后立即开始迁移，定时任务则会开始倒计时。
        /// 调用此接口前，请务必先使用CreateMigrateCheckJob校验数据迁移任务，并通过DescribeMigrateJobs接口查询到任务状态为校验通过（status=4）时，才能启动数据迁移任务。
        /// </summary>
        /// <param name="req">参考<see cref="StartMigrateJobRequest"/></param>
        /// <returns>参考<see cref="StartMigrateJobResponse"/>实例</returns>
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
        /// 创建的灾备同步任务在通过 CreateSyncCheckJob 和 DescribeSyncCheckJob 确定校验成功后，可以调用该接口启动同步
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
        /// StartSyncJob接口的同步版本，创建的灾备同步任务在通过 CreateSyncCheckJob 和 DescribeSyncCheckJob 确定校验成功后，可以调用该接口启动同步
        /// </summary>
        /// <param name="req">参考<see cref="StartSyncJobRequest"/></param>
        /// <returns>参考<see cref="StartSyncJobResponse"/>实例</returns>
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
        /// 本接口（StopMigrateJob）用于撤销数据迁移任务。
        /// 在迁移过程中允许调用该接口撤销迁移, 撤销迁移的任务会失败。通过DescribeMigrateJobs接口查询到任务状态为运行中（status=7）或准备完成（status=8）时，才能撤销数据迁移任务。
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
        /// StopMigrateJob接口的同步版本，本接口（StopMigrateJob）用于撤销数据迁移任务。
        /// 在迁移过程中允许调用该接口撤销迁移, 撤销迁移的任务会失败。通过DescribeMigrateJobs接口查询到任务状态为运行中（status=7）或准备完成（status=8）时，才能撤销数据迁移任务。
        /// </summary>
        /// <param name="req">参考<see cref="StopMigrateJobRequest"/></param>
        /// <returns>参考<see cref="StopMigrateJobResponse"/>实例</returns>
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
        /// 将灾备升级为主实例，停止从原来所属主实例的同步，断开主备关系。
        /// </summary>
        /// <param name="req"><see cref="SwitchDrToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrToMasterResponse"/></returns>
        public async Task<SwitchDrToMasterResponse> SwitchDrToMaster(SwitchDrToMasterRequest req)
        {
             JsonResponseModel<SwitchDrToMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDrToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDrToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SwitchDrToMaster接口的同步版本，将灾备升级为主实例，停止从原来所属主实例的同步，断开主备关系。
        /// </summary>
        /// <param name="req">参考<see cref="SwitchDrToMasterRequest"/></param>
        /// <returns>参考<see cref="SwitchDrToMasterResponse"/>实例</returns>
        public SwitchDrToMasterResponse SwitchDrToMasterSync(SwitchDrToMasterRequest req)
        {
             JsonResponseModel<SwitchDrToMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDrToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDrToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
