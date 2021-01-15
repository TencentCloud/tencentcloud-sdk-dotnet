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

    }
}
