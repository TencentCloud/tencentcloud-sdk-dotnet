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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 完成数据迁移任务.
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据.
        /// 只有当正在迁移的任务, 进入了准备完成阶段, 才能调用本接口完成迁移.
        /// </summary>
        /// <param name="req">参考<see cref="CompleteMigrateJobRequest"/></param>
        /// <returns>参考<see cref="CompleteMigrateJobResponse"/>实例</returns>
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
        /// 创建校验迁移任务
        /// 在开始迁移前, 必须调用本接口创建校验, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrateCheckJob查看.
        /// 校验成功后,迁移任务若有修改, 则必须重新创建校验并通过后, 才能开始迁移.
        /// </summary>
        /// <param name="req">参考<see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns>参考<see cref="CreateMigrateCheckJobResponse"/>实例</returns>
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
        /// 本接口用于创建数据迁移任务。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="CreateMigrateJobRequest"/></param>
        /// <returns>参考<see cref="CreateMigrateJobResponse"/>实例</returns>
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
        /// 在开始灾备同步前, 必须调用本接口创建校验, 且校验成功后才能开始同步数据. 校验的结果可以通过DescribeSyncCheckJob查看.
        /// 校验成功或失败后均可再修改, 修改后必须重新校验并通过后, 才能开始同步.
        /// </summary>
        /// <param name="req">参考<see cref="CreateSyncCheckJobRequest"/></param>
        /// <returns>参考<see cref="CreateSyncCheckJobResponse"/>实例</returns>
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
        /// 本接口(CreateSyncJob)用于创建灾备同步任务。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSyncJobRequest"/></param>
        /// <returns>参考<see cref="CreateSyncJobResponse"/>实例</returns>
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
        /// 删除数据迁移任务. 正在校验和正在迁移的任务不允许删除
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMigrateJobRequest"/></param>
        /// <returns>参考<see cref="DeleteMigrateJobResponse"/>实例</returns>
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
        /// 删除灾备同步任务 （运行中的同步任务不能删除）。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSyncJobRequest"/></param>
        /// <returns>参考<see cref="DeleteSyncJobResponse"/>实例</returns>
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
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrateJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrateCheckJobResponse"/>实例</returns>
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
        /// 查询数据迁移任务.
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrateJobsResponse"/>实例</returns>
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
        /// 本接口用于创建灾备同步校验任务后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartSyncJob' 开始迁移.
        /// 若未通过校验, 则会返回校验失败的原因. 可通过'ModifySyncJob'修改配置重新发起校验.
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSyncCheckJobRequest"/></param>
        /// <returns>参考<see cref="DescribeSyncCheckJobResponse"/>实例</returns>
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
        /// 查询在迁移平台发起的灾备同步任务
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSyncJobsRequest"/></param>
        /// <returns>参考<see cref="DescribeSyncJobsResponse"/>实例</returns>
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
        /// 修改数据迁移任务. 
        /// 当迁移任务处于下述状态时, 允许调用本接口: 迁移创建中, 创建完成, 校验成功, 校验失败, 迁移失败. 
        /// 源实例和目标实例类型不允许修改, 目标实例地域不允许修改。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMigrateJobRequest"/></param>
        /// <returns>参考<see cref="ModifyMigrateJobResponse"/>实例</returns>
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
        /// 修改灾备同步任务. 
        /// 当同步任务处于下述状态时, 允许调用本接口: 同步任务创建中, 创建完成, 校验成功, 校验失败. 
        /// 源实例和目标实例信息不允许修改，可以修改任务名、需要同步的库表。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySyncJobRequest"/></param>
        /// <returns>参考<see cref="ModifySyncJobResponse"/>实例</returns>
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
        /// 非定时任务会在调用后立即开始迁移，定时任务则会开始倒计时。
        /// 调用此接口前，请务必先校验数据迁移任务通过。
        /// </summary>
        /// <param name="req">参考<see cref="StartMigrateJobRequest"/></param>
        /// <returns>参考<see cref="StartMigrateJobResponse"/>实例</returns>
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
        /// 创建的灾备同步任务在校验成功后，可以调用该接口开始同步
        /// </summary>
        /// <param name="req">参考<see cref="StartSyncJobRequest"/></param>
        /// <returns>参考<see cref="StartSyncJobResponse"/>实例</returns>
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
        /// 撤销数据迁移任务.
        /// 在迁移过程中允许调用该接口撤销迁移, 撤销迁移的任务会失败.
        /// </summary>
        /// <param name="req">参考<see cref="StopMigrateJobRequest"/></param>
        /// <returns>参考<see cref="StopMigrateJobResponse"/>实例</returns>
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
        /// 将灾备升级为主实例，停止从原来所属主实例的同步，断开主备关系。
        /// </summary>
        /// <param name="req">参考<see cref="SwitchDrToMasterRequest"/></param>
        /// <returns>参考<see cref="SwitchDrToMasterResponse"/>实例</returns>
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

    }
}
