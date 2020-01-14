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

namespace TencentCloud.Tia.V20180226
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tia.V20180226.Models;

   public class TiaClient : AbstractClient{

       private const string endpoint = "tia.tencentcloudapi.com";
       private const string version = "2018-02-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建训练任务
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
        /// CreateJob接口的同步版本，创建训练任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateJobRequest"/></param>
        /// <returns>参考<see cref="CreateJobResponse"/>实例</returns>
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
        /// 部署模型，用以对外提供服务。有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public async Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
             JsonResponseModel<CreateModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateModel接口的同步版本，部署模型，用以对外提供服务。有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req">参考<see cref="CreateModelRequest"/></param>
        /// <returns>参考<see cref="CreateModelResponse"/>实例</returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
             JsonResponseModel<CreateModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteJob接口的同步版本，删除训练任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteJobRequest"/></param>
        /// <returns>参考<see cref="DeleteJobResponse"/>实例</returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定的部署模型。模型有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public async Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
             JsonResponseModel<DeleteModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteModel接口的同步版本，删除指定的部署模型。模型有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteModelRequest"/></param>
        /// <returns>参考<see cref="DeleteModelResponse"/>实例</returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
             JsonResponseModel<DeleteModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public async Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
             JsonResponseModel<DescribeJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeJob接口的同步版本，获取训练任务详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeJobRequest"/></param>
        /// <returns>参考<see cref="DescribeJobResponse"/>实例</returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
             JsonResponseModel<DescribeJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述已经部署的某个模型。而模型部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public async Task<DescribeModelResponse> DescribeModel(DescribeModelRequest req)
        {
             JsonResponseModel<DescribeModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeModel接口的同步版本，描述已经部署的某个模型。而模型部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeModelRequest"/></param>
        /// <returns>参考<see cref="DescribeModelResponse"/>实例</returns>
        public DescribeModelResponse DescribeModelSync(DescribeModelRequest req)
        {
             JsonResponseModel<DescribeModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安装agent
        /// </summary>
        /// <param name="req"><see cref="InstallAgentRequest"/></param>
        /// <returns><see cref="InstallAgentResponse"/></returns>
        public async Task<InstallAgentResponse> InstallAgent(InstallAgentRequest req)
        {
             JsonResponseModel<InstallAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstallAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InstallAgent接口的同步版本，安装agent
        /// </summary>
        /// <param name="req">参考<see cref="InstallAgentRequest"/></param>
        /// <returns>参考<see cref="InstallAgentResponse"/>实例</returns>
        public InstallAgentResponse InstallAgentSync(InstallAgentRequest req)
        {
             JsonResponseModel<InstallAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstallAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举训练任务
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public async Task<ListJobsResponse> ListJobs(ListJobsRequest req)
        {
             JsonResponseModel<ListJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListJobs接口的同步版本，列举训练任务
        /// </summary>
        /// <param name="req">参考<see cref="ListJobsRequest"/></param>
        /// <returns>参考<see cref="ListJobsResponse"/>实例</returns>
        public ListJobsResponse ListJobsSync(ListJobsRequest req)
        {
             JsonResponseModel<ListJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用以列举已经部署的模型。而部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。不同部署模式下的模型分开列出。
        /// </summary>
        /// <param name="req"><see cref="ListModelsRequest"/></param>
        /// <returns><see cref="ListModelsResponse"/></returns>
        public async Task<ListModelsResponse> ListModels(ListModelsRequest req)
        {
             JsonResponseModel<ListModelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListModels接口的同步版本，用以列举已经部署的模型。而部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。不同部署模式下的模型分开列出。
        /// </summary>
        /// <param name="req">参考<see cref="ListModelsRequest"/></param>
        /// <returns>参考<see cref="ListModelsResponse"/>实例</returns>
        public ListModelsResponse ListModelsSync(ListModelsRequest req)
        {
             JsonResponseModel<ListModelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 TI-A 训练任务的日志
        /// </summary>
        /// <param name="req"><see cref="QueryLogsRequest"/></param>
        /// <returns><see cref="QueryLogsResponse"/></returns>
        public async Task<QueryLogsResponse> QueryLogs(QueryLogsRequest req)
        {
             JsonResponseModel<QueryLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// QueryLogs接口的同步版本，查询 TI-A 训练任务的日志
        /// </summary>
        /// <param name="req">参考<see cref="QueryLogsRequest"/></param>
        /// <returns>参考<see cref="QueryLogsResponse"/>实例</returns>
        public QueryLogsResponse QueryLogsSync(QueryLogsRequest req)
        {
             JsonResponseModel<QueryLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
