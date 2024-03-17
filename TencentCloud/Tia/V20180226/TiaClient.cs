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
       private const string sdkVersion = "SDK_NET_3.0.966";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public Task<CreateJobResponse> CreateJob(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob");
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public CreateJobResponse CreateJobSync(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 部署模型，用以对外提供服务。有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel");
        }

        /// <summary>
        /// 部署模型，用以对外提供服务。有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob");
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定的部署模型。模型有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel");
        }

        /// <summary>
        /// 删除指定的部署模型。模型有两种部署模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob");
        }

        /// <summary>
        /// 获取训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述已经部署的某个模型。而模型部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public Task<DescribeModelResponse> DescribeModel(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel");
        }

        /// <summary>
        /// 描述已经部署的某个模型。而模型部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public DescribeModelResponse DescribeModelSync(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安装agent
        /// </summary>
        /// <param name="req"><see cref="InstallAgentRequest"/></param>
        /// <returns><see cref="InstallAgentResponse"/></returns>
        public Task<InstallAgentResponse> InstallAgent(InstallAgentRequest req)
        {
            return InternalRequestAsync<InstallAgentResponse>(req, "InstallAgent");
        }

        /// <summary>
        /// 安装agent
        /// </summary>
        /// <param name="req"><see cref="InstallAgentRequest"/></param>
        /// <returns><see cref="InstallAgentResponse"/></returns>
        public InstallAgentResponse InstallAgentSync(InstallAgentRequest req)
        {
            return InternalRequestAsync<InstallAgentResponse>(req, "InstallAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列举训练任务
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public Task<ListJobsResponse> ListJobs(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs");
        }

        /// <summary>
        /// 列举训练任务
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public ListJobsResponse ListJobsSync(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用以列举已经部署的模型。而部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。不同部署模式下的模型分开列出。
        /// </summary>
        /// <param name="req"><see cref="ListModelsRequest"/></param>
        /// <returns><see cref="ListModelsResponse"/></returns>
        public Task<ListModelsResponse> ListModels(ListModelsRequest req)
        {
            return InternalRequestAsync<ListModelsResponse>(req, "ListModels");
        }

        /// <summary>
        /// 用以列举已经部署的模型。而部署有两种模式：`无服务器模式` 和 `集群模式`。`无服务器模式` 下，模型文件被部署到无服务器云函数，即 [SCF](https://cloud.tencent.com/product/scf)，用户可以在其控制台上进一步操作。`集群模式` 下，模型文件被部署到 TI-A 的计算集群中。不同部署模式下的模型分开列出。
        /// </summary>
        /// <param name="req"><see cref="ListModelsRequest"/></param>
        /// <returns><see cref="ListModelsResponse"/></returns>
        public ListModelsResponse ListModelsSync(ListModelsRequest req)
        {
            return InternalRequestAsync<ListModelsResponse>(req, "ListModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TI-A 训练任务的日志
        /// </summary>
        /// <param name="req"><see cref="QueryLogsRequest"/></param>
        /// <returns><see cref="QueryLogsResponse"/></returns>
        public Task<QueryLogsResponse> QueryLogs(QueryLogsRequest req)
        {
            return InternalRequestAsync<QueryLogsResponse>(req, "QueryLogs");
        }

        /// <summary>
        /// 查询 TI-A 训练任务的日志
        /// </summary>
        /// <param name="req"><see cref="QueryLogsRequest"/></param>
        /// <returns><see cref="QueryLogsResponse"/></returns>
        public QueryLogsResponse QueryLogsSync(QueryLogsRequest req)
        {
            return InternalRequestAsync<QueryLogsResponse>(req, "QueryLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
