/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Tione.V20191022
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tione.V20191022.Models;

   public class TioneClient : AbstractClient{

       private const string endpoint = "tione.tencentcloudapi.com";
       private const string version = "2019-10-22";
       private const string sdkVersion = "SDK_NET_3.0.1340";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TioneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TioneClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建存储库
        /// </summary>
        /// <param name="req"><see cref="CreateCodeRepositoryRequest"/></param>
        /// <returns><see cref="CreateCodeRepositoryResponse"/></returns>
        public Task<CreateCodeRepositoryResponse> CreateCodeRepository(CreateCodeRepositoryRequest req)
        {
            return InternalRequestAsync<CreateCodeRepositoryResponse>(req, "CreateCodeRepository");
        }

        /// <summary>
        /// 创建存储库
        /// </summary>
        /// <param name="req"><see cref="CreateCodeRepositoryRequest"/></param>
        /// <returns><see cref="CreateCodeRepositoryResponse"/></returns>
        public CreateCodeRepositoryResponse CreateCodeRepositorySync(CreateCodeRepositoryRequest req)
        {
            return InternalRequestAsync<CreateCodeRepositoryResponse>(req, "CreateCodeRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Notebook实例
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookInstanceRequest"/></param>
        /// <returns><see cref="CreateNotebookInstanceResponse"/></returns>
        public Task<CreateNotebookInstanceResponse> CreateNotebookInstance(CreateNotebookInstanceRequest req)
        {
            return InternalRequestAsync<CreateNotebookInstanceResponse>(req, "CreateNotebookInstance");
        }

        /// <summary>
        /// 创建Notebook实例
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookInstanceRequest"/></param>
        /// <returns><see cref="CreateNotebookInstanceResponse"/></returns>
        public CreateNotebookInstanceResponse CreateNotebookInstanceSync(CreateNotebookInstanceRequest req)
        {
            return InternalRequestAsync<CreateNotebookInstanceResponse>(req, "CreateNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Notebook生命周期脚本
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="CreateNotebookLifecycleScriptResponse"/></returns>
        public Task<CreateNotebookLifecycleScriptResponse> CreateNotebookLifecycleScript(CreateNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<CreateNotebookLifecycleScriptResponse>(req, "CreateNotebookLifecycleScript");
        }

        /// <summary>
        /// 创建Notebook生命周期脚本
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="CreateNotebookLifecycleScriptResponse"/></returns>
        public CreateNotebookLifecycleScriptResponse CreateNotebookLifecycleScriptSync(CreateNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<CreateNotebookLifecycleScriptResponse>(req, "CreateNotebookLifecycleScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Notebook授权Url
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookInstanceUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookInstanceUrlResponse"/></returns>
        public Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest req)
        {
            return InternalRequestAsync<CreatePresignedNotebookInstanceUrlResponse>(req, "CreatePresignedNotebookInstanceUrl");
        }

        /// <summary>
        /// 创建Notebook授权Url
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookInstanceUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookInstanceUrlResponse"/></returns>
        public CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrlSync(CreatePresignedNotebookInstanceUrlRequest req)
        {
            return InternalRequestAsync<CreatePresignedNotebookInstanceUrlResponse>(req, "CreatePresignedNotebookInstanceUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingJobRequest"/></param>
        /// <returns><see cref="CreateTrainingJobResponse"/></returns>
        public Task<CreateTrainingJobResponse> CreateTrainingJob(CreateTrainingJobRequest req)
        {
            return InternalRequestAsync<CreateTrainingJobResponse>(req, "CreateTrainingJob");
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingJobRequest"/></param>
        /// <returns><see cref="CreateTrainingJobResponse"/></returns>
        public CreateTrainingJobResponse CreateTrainingJobSync(CreateTrainingJobRequest req)
        {
            return InternalRequestAsync<CreateTrainingJobResponse>(req, "CreateTrainingJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除存储库
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeRepositoryRequest"/></param>
        /// <returns><see cref="DeleteCodeRepositoryResponse"/></returns>
        public Task<DeleteCodeRepositoryResponse> DeleteCodeRepository(DeleteCodeRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteCodeRepositoryResponse>(req, "DeleteCodeRepository");
        }

        /// <summary>
        /// 删除存储库
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeRepositoryRequest"/></param>
        /// <returns><see cref="DeleteCodeRepositoryResponse"/></returns>
        public DeleteCodeRepositoryResponse DeleteCodeRepositorySync(DeleteCodeRepositoryRequest req)
        {
            return InternalRequestAsync<DeleteCodeRepositoryResponse>(req, "DeleteCodeRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除notebook实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookInstanceRequest"/></param>
        /// <returns><see cref="DeleteNotebookInstanceResponse"/></returns>
        public Task<DeleteNotebookInstanceResponse> DeleteNotebookInstance(DeleteNotebookInstanceRequest req)
        {
            return InternalRequestAsync<DeleteNotebookInstanceResponse>(req, "DeleteNotebookInstance");
        }

        /// <summary>
        /// 删除notebook实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookInstanceRequest"/></param>
        /// <returns><see cref="DeleteNotebookInstanceResponse"/></returns>
        public DeleteNotebookInstanceResponse DeleteNotebookInstanceSync(DeleteNotebookInstanceRequest req)
        {
            return InternalRequestAsync<DeleteNotebookInstanceResponse>(req, "DeleteNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Notebook生命周期脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="DeleteNotebookLifecycleScriptResponse"/></returns>
        public Task<DeleteNotebookLifecycleScriptResponse> DeleteNotebookLifecycleScript(DeleteNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<DeleteNotebookLifecycleScriptResponse>(req, "DeleteNotebookLifecycleScript");
        }

        /// <summary>
        /// 删除Notebook生命周期脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="DeleteNotebookLifecycleScriptResponse"/></returns>
        public DeleteNotebookLifecycleScriptResponse DeleteNotebookLifecycleScriptSync(DeleteNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<DeleteNotebookLifecycleScriptResponse>(req, "DeleteNotebookLifecycleScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询存储库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeCodeRepositoriesResponse"/></returns>
        public Task<DescribeCodeRepositoriesResponse> DescribeCodeRepositories(DescribeCodeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeCodeRepositoriesResponse>(req, "DescribeCodeRepositories");
        }

        /// <summary>
        /// 查询存储库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeRepositoriesRequest"/></param>
        /// <returns><see cref="DescribeCodeRepositoriesResponse"/></returns>
        public DescribeCodeRepositoriesResponse DescribeCodeRepositoriesSync(DescribeCodeRepositoriesRequest req)
        {
            return InternalRequestAsync<DescribeCodeRepositoriesResponse>(req, "DescribeCodeRepositories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询存储库详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeCodeRepositoryResponse"/></returns>
        public Task<DescribeCodeRepositoryResponse> DescribeCodeRepository(DescribeCodeRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeCodeRepositoryResponse>(req, "DescribeCodeRepository");
        }

        /// <summary>
        /// 查询存储库详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeRepositoryRequest"/></param>
        /// <returns><see cref="DescribeCodeRepositoryResponse"/></returns>
        public DescribeCodeRepositoryResponse DescribeCodeRepositorySync(DescribeCodeRepositoryRequest req)
        {
            return InternalRequestAsync<DescribeCodeRepositoryResponse>(req, "DescribeCodeRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Notebook实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstanceRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstanceResponse"/></returns>
        public Task<DescribeNotebookInstanceResponse> DescribeNotebookInstance(DescribeNotebookInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNotebookInstanceResponse>(req, "DescribeNotebookInstance");
        }

        /// <summary>
        /// 查询Notebook实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstanceRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstanceResponse"/></returns>
        public DescribeNotebookInstanceResponse DescribeNotebookInstanceSync(DescribeNotebookInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNotebookInstanceResponse>(req, "DescribeNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Notebook实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstancesRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstancesResponse"/></returns>
        public Task<DescribeNotebookInstancesResponse> DescribeNotebookInstances(DescribeNotebookInstancesRequest req)
        {
            return InternalRequestAsync<DescribeNotebookInstancesResponse>(req, "DescribeNotebookInstances");
        }

        /// <summary>
        /// 查询Notebook实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstancesRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstancesResponse"/></returns>
        public DescribeNotebookInstancesResponse DescribeNotebookInstancesSync(DescribeNotebookInstancesRequest req)
        {
            return InternalRequestAsync<DescribeNotebookInstancesResponse>(req, "DescribeNotebookInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看notebook生命周期脚本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="DescribeNotebookLifecycleScriptResponse"/></returns>
        public Task<DescribeNotebookLifecycleScriptResponse> DescribeNotebookLifecycleScript(DescribeNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<DescribeNotebookLifecycleScriptResponse>(req, "DescribeNotebookLifecycleScript");
        }

        /// <summary>
        /// 查看notebook生命周期脚本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookLifecycleScriptRequest"/></param>
        /// <returns><see cref="DescribeNotebookLifecycleScriptResponse"/></returns>
        public DescribeNotebookLifecycleScriptResponse DescribeNotebookLifecycleScriptSync(DescribeNotebookLifecycleScriptRequest req)
        {
            return InternalRequestAsync<DescribeNotebookLifecycleScriptResponse>(req, "DescribeNotebookLifecycleScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看notebook生命周期脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookLifecycleScriptsRequest"/></param>
        /// <returns><see cref="DescribeNotebookLifecycleScriptsResponse"/></returns>
        public Task<DescribeNotebookLifecycleScriptsResponse> DescribeNotebookLifecycleScripts(DescribeNotebookLifecycleScriptsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookLifecycleScriptsResponse>(req, "DescribeNotebookLifecycleScripts");
        }

        /// <summary>
        /// 查看notebook生命周期脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookLifecycleScriptsRequest"/></param>
        /// <returns><see cref="DescribeNotebookLifecycleScriptsResponse"/></returns>
        public DescribeNotebookLifecycleScriptsResponse DescribeNotebookLifecycleScriptsSync(DescribeNotebookLifecycleScriptsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookLifecycleScriptsResponse>(req, "DescribeNotebookLifecycleScripts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Notebook概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSummaryRequest"/></param>
        /// <returns><see cref="DescribeNotebookSummaryResponse"/></returns>
        public Task<DescribeNotebookSummaryResponse> DescribeNotebookSummary(DescribeNotebookSummaryRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSummaryResponse>(req, "DescribeNotebookSummary");
        }

        /// <summary>
        /// 查询Notebook概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSummaryRequest"/></param>
        /// <returns><see cref="DescribeNotebookSummaryResponse"/></returns>
        public DescribeNotebookSummaryResponse DescribeNotebookSummarySync(DescribeNotebookSummaryRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSummaryResponse>(req, "DescribeNotebookSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询训练任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobResponse"/></returns>
        public Task<DescribeTrainingJobResponse> DescribeTrainingJob(DescribeTrainingJobRequest req)
        {
            return InternalRequestAsync<DescribeTrainingJobResponse>(req, "DescribeTrainingJob");
        }

        /// <summary>
        /// 查询训练任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobResponse"/></returns>
        public DescribeTrainingJobResponse DescribeTrainingJobSync(DescribeTrainingJobRequest req)
        {
            return InternalRequestAsync<DescribeTrainingJobResponse>(req, "DescribeTrainingJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobsRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobsResponse"/></returns>
        public Task<DescribeTrainingJobsResponse> DescribeTrainingJobs(DescribeTrainingJobsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingJobsResponse>(req, "DescribeTrainingJobs");
        }

        /// <summary>
        /// 查询训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobsRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobsResponse"/></returns>
        public DescribeTrainingJobsResponse DescribeTrainingJobsSync(DescribeTrainingJobsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingJobsResponse>(req, "DescribeTrainingJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StartNotebookInstanceRequest"/></param>
        /// <returns><see cref="StartNotebookInstanceResponse"/></returns>
        public Task<StartNotebookInstanceResponse> StartNotebookInstance(StartNotebookInstanceRequest req)
        {
            return InternalRequestAsync<StartNotebookInstanceResponse>(req, "StartNotebookInstance");
        }

        /// <summary>
        /// 启动Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StartNotebookInstanceRequest"/></param>
        /// <returns><see cref="StartNotebookInstanceResponse"/></returns>
        public StartNotebookInstanceResponse StartNotebookInstanceSync(StartNotebookInstanceRequest req)
        {
            return InternalRequestAsync<StartNotebookInstanceResponse>(req, "StartNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StopNotebookInstanceRequest"/></param>
        /// <returns><see cref="StopNotebookInstanceResponse"/></returns>
        public Task<StopNotebookInstanceResponse> StopNotebookInstance(StopNotebookInstanceRequest req)
        {
            return InternalRequestAsync<StopNotebookInstanceResponse>(req, "StopNotebookInstance");
        }

        /// <summary>
        /// 停止Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StopNotebookInstanceRequest"/></param>
        /// <returns><see cref="StopNotebookInstanceResponse"/></returns>
        public StopNotebookInstanceResponse StopNotebookInstanceSync(StopNotebookInstanceRequest req)
        {
            return InternalRequestAsync<StopNotebookInstanceResponse>(req, "StopNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingJobRequest"/></param>
        /// <returns><see cref="StopTrainingJobResponse"/></returns>
        public Task<StopTrainingJobResponse> StopTrainingJob(StopTrainingJobRequest req)
        {
            return InternalRequestAsync<StopTrainingJobResponse>(req, "StopTrainingJob");
        }

        /// <summary>
        /// 停止训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingJobRequest"/></param>
        /// <returns><see cref="StopTrainingJobResponse"/></returns>
        public StopTrainingJobResponse StopTrainingJobSync(StopTrainingJobRequest req)
        {
            return InternalRequestAsync<StopTrainingJobResponse>(req, "StopTrainingJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新存储库
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeRepositoryRequest"/></param>
        /// <returns><see cref="UpdateCodeRepositoryResponse"/></returns>
        public Task<UpdateCodeRepositoryResponse> UpdateCodeRepository(UpdateCodeRepositoryRequest req)
        {
            return InternalRequestAsync<UpdateCodeRepositoryResponse>(req, "UpdateCodeRepository");
        }

        /// <summary>
        /// 更新存储库
        /// </summary>
        /// <param name="req"><see cref="UpdateCodeRepositoryRequest"/></param>
        /// <returns><see cref="UpdateCodeRepositoryResponse"/></returns>
        public UpdateCodeRepositoryResponse UpdateCodeRepositorySync(UpdateCodeRepositoryRequest req)
        {
            return InternalRequestAsync<UpdateCodeRepositoryResponse>(req, "UpdateCodeRepository")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Notebook实例
        /// </summary>
        /// <param name="req"><see cref="UpdateNotebookInstanceRequest"/></param>
        /// <returns><see cref="UpdateNotebookInstanceResponse"/></returns>
        public Task<UpdateNotebookInstanceResponse> UpdateNotebookInstance(UpdateNotebookInstanceRequest req)
        {
            return InternalRequestAsync<UpdateNotebookInstanceResponse>(req, "UpdateNotebookInstance");
        }

        /// <summary>
        /// 更新Notebook实例
        /// </summary>
        /// <param name="req"><see cref="UpdateNotebookInstanceRequest"/></param>
        /// <returns><see cref="UpdateNotebookInstanceResponse"/></returns>
        public UpdateNotebookInstanceResponse UpdateNotebookInstanceSync(UpdateNotebookInstanceRequest req)
        {
            return InternalRequestAsync<UpdateNotebookInstanceResponse>(req, "UpdateNotebookInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
