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

namespace TencentCloud.Oceanus.V20190422
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Oceanus.V20190422.Models;

   public class OceanusClient : AbstractClient{

       private const string endpoint = "oceanus.tencentcloudapi.com";
       private const string version = "2019-04-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OceanusClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OceanusClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 检查快照是否可用
        /// </summary>
        /// <param name="req"><see cref="CheckSavepointRequest"/></param>
        /// <returns><see cref="CheckSavepointResponse"/></returns>
        public async Task<CheckSavepointResponse> CheckSavepoint(CheckSavepointRequest req)
        {
             JsonResponseModel<CheckSavepointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查快照是否可用
        /// </summary>
        /// <param name="req"><see cref="CheckSavepointRequest"/></param>
        /// <returns><see cref="CheckSavepointResponse"/></returns>
        public CheckSavepointResponse CheckSavepointSync(CheckSavepointRequest req)
        {
             JsonResponseModel<CheckSavepointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建作业接口，一个 AppId 最多允许创建1000个作业
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public async Task<CreateJobResponse> CreateJob(CreateJobRequest req)
        {
             JsonResponseModel<CreateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建作业接口，一个 AppId 最多允许创建1000个作业
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public CreateJobResponse CreateJobSync(CreateJobRequest req)
        {
             JsonResponseModel<CreateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建作业配置，一个作业最多有100个配置版本
        /// </summary>
        /// <param name="req"><see cref="CreateJobConfigRequest"/></param>
        /// <returns><see cref="CreateJobConfigResponse"/></returns>
        public async Task<CreateJobConfigResponse> CreateJobConfig(CreateJobConfigRequest req)
        {
             JsonResponseModel<CreateJobConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateJobConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建作业配置，一个作业最多有100个配置版本
        /// </summary>
        /// <param name="req"><see cref="CreateJobConfigRequest"/></param>
        /// <returns><see cref="CreateJobConfigResponse"/></returns>
        public CreateJobConfigResponse CreateJobConfigSync(CreateJobConfigRequest req)
        {
             JsonResponseModel<CreateJobConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateJobConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资源接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public async Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资源接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资源配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public async Task<CreateResourceConfigResponse> CreateResourceConfig(CreateResourceConfigRequest req)
        {
             JsonResponseModel<CreateResourceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResourceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资源配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public CreateResourceConfigResponse CreateResourceConfigSync(CreateResourceConfigRequest req)
        {
             JsonResponseModel<CreateResourceConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResourceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源版本
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigsRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigsResponse"/></returns>
        public async Task<DeleteResourceConfigsResponse> DeleteResourceConfigs(DeleteResourceConfigsRequest req)
        {
             JsonResponseModel<DeleteResourceConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源版本
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigsRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigsResponse"/></returns>
        public DeleteResourceConfigsResponse DeleteResourceConfigsSync(DeleteResourceConfigsRequest req)
        {
             JsonResponseModel<DeleteResourceConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源接口
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcesRequest"/></param>
        /// <returns><see cref="DeleteResourcesResponse"/></returns>
        public async Task<DeleteResourcesResponse> DeleteResources(DeleteResourcesRequest req)
        {
             JsonResponseModel<DeleteResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源接口
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcesRequest"/></param>
        /// <returns><see cref="DeleteResourcesResponse"/></returns>
        public DeleteResourcesResponse DeleteResourcesSync(DeleteResourcesRequest req)
        {
             JsonResponseModel<DeleteResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除作业表配置
        /// </summary>
        /// <param name="req"><see cref="DeleteTableConfigRequest"/></param>
        /// <returns><see cref="DeleteTableConfigResponse"/></returns>
        public async Task<DeleteTableConfigResponse> DeleteTableConfig(DeleteTableConfigRequest req)
        {
             JsonResponseModel<DeleteTableConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTableConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除作业表配置
        /// </summary>
        /// <param name="req"><see cref="DeleteTableConfigRequest"/></param>
        /// <returns><see cref="DeleteTableConfigResponse"/></returns>
        public DeleteTableConfigResponse DeleteTableConfigSync(DeleteTableConfigRequest req)
        {
             JsonResponseModel<DeleteTableConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTableConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业配置列表，一次最多查询100个
        /// </summary>
        /// <param name="req"><see cref="DescribeJobConfigsRequest"/></param>
        /// <returns><see cref="DescribeJobConfigsResponse"/></returns>
        public async Task<DescribeJobConfigsResponse> DescribeJobConfigs(DescribeJobConfigsRequest req)
        {
             JsonResponseModel<DescribeJobConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业配置列表，一次最多查询100个
        /// </summary>
        /// <param name="req"><see cref="DescribeJobConfigsRequest"/></param>
        /// <returns><see cref="DescribeJobConfigsResponse"/></returns>
        public DescribeJobConfigsResponse DescribeJobConfigsSync(DescribeJobConfigsRequest req)
        {
             JsonResponseModel<DescribeJobConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查找Savepoint列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSavepointRequest"/></param>
        /// <returns><see cref="DescribeJobSavepointResponse"/></returns>
        public async Task<DescribeJobSavepointResponse> DescribeJobSavepoint(DescribeJobSavepointRequest req)
        {
             JsonResponseModel<DescribeJobSavepointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查找Savepoint列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSavepointRequest"/></param>
        /// <returns><see cref="DescribeJobSavepointResponse"/></returns>
        public DescribeJobSavepointResponse DescribeJobSavepointSync(DescribeJobSavepointRequest req)
        {
             JsonResponseModel<DescribeJobSavepointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public async Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述资源配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceConfigsRequest"/></param>
        /// <returns><see cref="DescribeResourceConfigsResponse"/></returns>
        public async Task<DescribeResourceConfigsResponse> DescribeResourceConfigs(DescribeResourceConfigsRequest req)
        {
             JsonResponseModel<DescribeResourceConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述资源配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceConfigsRequest"/></param>
        /// <returns><see cref="DescribeResourceConfigsResponse"/></returns>
        public DescribeResourceConfigsResponse DescribeResourceConfigsSync(DescribeResourceConfigsRequest req)
        {
             JsonResponseModel<DescribeResourceConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源关联作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRelatedJobsRequest"/></param>
        /// <returns><see cref="DescribeResourceRelatedJobsResponse"/></returns>
        public async Task<DescribeResourceRelatedJobsResponse> DescribeResourceRelatedJobs(DescribeResourceRelatedJobsRequest req)
        {
             JsonResponseModel<DescribeResourceRelatedJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceRelatedJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceRelatedJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源关联作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRelatedJobsRequest"/></param>
        /// <returns><see cref="DescribeResourceRelatedJobsResponse"/></returns>
        public DescribeResourceRelatedJobsResponse DescribeResourceRelatedJobsSync(DescribeResourceRelatedJobsRequest req)
        {
             JsonResponseModel<DescribeResourceRelatedJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceRelatedJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceRelatedJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public async Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述系统资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemResourcesRequest"/></param>
        /// <returns><see cref="DescribeSystemResourcesResponse"/></returns>
        public async Task<DescribeSystemResourcesResponse> DescribeSystemResources(DescribeSystemResourcesRequest req)
        {
             JsonResponseModel<DescribeSystemResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSystemResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSystemResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述系统资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemResourcesRequest"/></param>
        /// <returns><see cref="DescribeSystemResourcesResponse"/></returns>
        public DescribeSystemResourcesResponse DescribeSystemResourcesSync(DescribeSystemResourcesRequest req)
        {
             JsonResponseModel<DescribeSystemResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSystemResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSystemResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启动或者恢复作业，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="RunJobsRequest"/></param>
        /// <returns><see cref="RunJobsResponse"/></returns>
        public async Task<RunJobsResponse> RunJobs(RunJobsRequest req)
        {
             JsonResponseModel<RunJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启动或者恢复作业，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="RunJobsRequest"/></param>
        /// <returns><see cref="RunJobsResponse"/></returns>
        public RunJobsResponse RunJobsSync(RunJobsRequest req)
        {
             JsonResponseModel<RunJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量停止作业，批量操作数量上限为20
        /// </summary>
        /// <param name="req"><see cref="StopJobsRequest"/></param>
        /// <returns><see cref="StopJobsResponse"/></returns>
        public async Task<StopJobsResponse> StopJobs(StopJobsRequest req)
        {
             JsonResponseModel<StopJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量停止作业，批量操作数量上限为20
        /// </summary>
        /// <param name="req"><see cref="StopJobsRequest"/></param>
        /// <returns><see cref="StopJobsResponse"/></returns>
        public StopJobsResponse StopJobsSync(StopJobsRequest req)
        {
             JsonResponseModel<StopJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 触发Savepoint
        /// </summary>
        /// <param name="req"><see cref="TriggerJobSavepointRequest"/></param>
        /// <returns><see cref="TriggerJobSavepointResponse"/></returns>
        public async Task<TriggerJobSavepointResponse> TriggerJobSavepoint(TriggerJobSavepointRequest req)
        {
             JsonResponseModel<TriggerJobSavepointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TriggerJobSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerJobSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 触发Savepoint
        /// </summary>
        /// <param name="req"><see cref="TriggerJobSavepointRequest"/></param>
        /// <returns><see cref="TriggerJobSavepointResponse"/></returns>
        public TriggerJobSavepointResponse TriggerJobSavepointSync(TriggerJobSavepointRequest req)
        {
             JsonResponseModel<TriggerJobSavepointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TriggerJobSavepoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerJobSavepointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
