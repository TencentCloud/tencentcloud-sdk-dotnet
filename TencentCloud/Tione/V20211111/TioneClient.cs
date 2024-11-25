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

namespace TencentCloud.Tione.V20211111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tione.V20211111.Models;

   public class TioneClient : AbstractClient{

       private const string endpoint = "tione.tencentcloudapi.com";
       private const string version = "2021-11-11";
       private const string sdkVersion = "SDK_NET_3.0.1129";

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
        /// 该接口支持与自行部署的大模型的聊天。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public Task<ChatCompletionResponse> ChatCompletion(ChatCompletionRequest req)
        {
            return InternalRequestAsync<ChatCompletionResponse>(req, "ChatCompletion");
        }

        /// <summary>
        /// 该接口支持与自行部署的大模型的聊天。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public ChatCompletionResponse ChatCompletionSync(ChatCompletionRequest req)
        {
            return InternalRequestAsync<ChatCompletionResponse>(req, "ChatCompletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public Task<CreateDatasetResponse> CreateDataset(CreateDatasetRequest req)
        {
            return InternalRequestAsync<CreateDatasetResponse>(req, "CreateDataset");
        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public CreateDatasetResponse CreateDatasetSync(CreateDatasetRequest req)
        {
            return InternalRequestAsync<CreateDatasetResponse>(req, "CreateDataset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建、发布一个新的模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public Task<CreateModelServiceResponse> CreateModelService(CreateModelServiceRequest req)
        {
            return InternalRequestAsync<CreateModelServiceResponse>(req, "CreateModelService");
        }

        /// <summary>
        /// 用于创建、发布一个新的模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public CreateModelServiceResponse CreateModelServiceSync(CreateModelServiceRequest req)
        {
            return InternalRequestAsync<CreateModelServiceResponse>(req, "CreateModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Notebook
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookRequest"/></param>
        /// <returns><see cref="CreateNotebookResponse"/></returns>
        public Task<CreateNotebookResponse> CreateNotebook(CreateNotebookRequest req)
        {
            return InternalRequestAsync<CreateNotebookResponse>(req, "CreateNotebook");
        }

        /// <summary>
        /// 创建Notebook
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookRequest"/></param>
        /// <returns><see cref="CreateNotebookResponse"/></returns>
        public CreateNotebookResponse CreateNotebookSync(CreateNotebookRequest req)
        {
            return InternalRequestAsync<CreateNotebookResponse>(req, "CreateNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成Notebook访问链接
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookUrlResponse"/></returns>
        public Task<CreatePresignedNotebookUrlResponse> CreatePresignedNotebookUrl(CreatePresignedNotebookUrlRequest req)
        {
            return InternalRequestAsync<CreatePresignedNotebookUrlResponse>(req, "CreatePresignedNotebookUrl");
        }

        /// <summary>
        /// 生成Notebook访问链接
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookUrlResponse"/></returns>
        public CreatePresignedNotebookUrlResponse CreatePresignedNotebookUrlSync(CreatePresignedNotebookUrlRequest req)
        {
            return InternalRequestAsync<CreatePresignedNotebookUrlResponse>(req, "CreatePresignedNotebookUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public Task<CreateTrainingModelResponse> CreateTrainingModel(CreateTrainingModelRequest req)
        {
            return InternalRequestAsync<CreateTrainingModelResponse>(req, "CreateTrainingModel");
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public CreateTrainingModelResponse CreateTrainingModelSync(CreateTrainingModelRequest req)
        {
            return InternalRequestAsync<CreateTrainingModelResponse>(req, "CreateTrainingModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public Task<DeleteDatasetResponse> DeleteDataset(DeleteDatasetRequest req)
        {
            return InternalRequestAsync<DeleteDatasetResponse>(req, "DeleteDataset");
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public DeleteDatasetResponse DeleteDatasetSync(DeleteDatasetRequest req)
        {
            return InternalRequestAsync<DeleteDatasetResponse>(req, "DeleteDataset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据服务id删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public Task<DeleteModelServiceResponse> DeleteModelService(DeleteModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceResponse>(req, "DeleteModelService");
        }

        /// <summary>
        /// 根据服务id删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public DeleteModelServiceResponse DeleteModelServiceSync(DeleteModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceResponse>(req, "DeleteModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据服务组id删除服务组下所有模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceGroupRequest"/></param>
        /// <returns><see cref="DeleteModelServiceGroupResponse"/></returns>
        public Task<DeleteModelServiceGroupResponse> DeleteModelServiceGroup(DeleteModelServiceGroupRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceGroupResponse>(req, "DeleteModelServiceGroup");
        }

        /// <summary>
        /// 根据服务组id删除服务组下所有模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceGroupRequest"/></param>
        /// <returns><see cref="DeleteModelServiceGroupResponse"/></returns>
        public DeleteModelServiceGroupResponse DeleteModelServiceGroupSync(DeleteModelServiceGroupRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceGroupResponse>(req, "DeleteModelServiceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Notebook
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookRequest"/></param>
        /// <returns><see cref="DeleteNotebookResponse"/></returns>
        public Task<DeleteNotebookResponse> DeleteNotebook(DeleteNotebookRequest req)
        {
            return InternalRequestAsync<DeleteNotebookResponse>(req, "DeleteNotebook");
        }

        /// <summary>
        /// 删除Notebook
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookRequest"/></param>
        /// <returns><see cref="DeleteNotebookResponse"/></returns>
        public DeleteNotebookResponse DeleteNotebookSync(DeleteNotebookRequest req)
        {
            return InternalRequestAsync<DeleteNotebookResponse>(req, "DeleteNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public Task<DeleteTrainingModelResponse> DeleteTrainingModel(DeleteTrainingModelRequest req)
        {
            return InternalRequestAsync<DeleteTrainingModelResponse>(req, "DeleteTrainingModel");
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public DeleteTrainingModelResponse DeleteTrainingModelSync(DeleteTrainingModelRequest req)
        {
            return InternalRequestAsync<DeleteTrainingModelResponse>(req, "DeleteTrainingModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public Task<DeleteTrainingModelVersionResponse> DeleteTrainingModelVersion(DeleteTrainingModelVersionRequest req)
        {
            return InternalRequestAsync<DeleteTrainingModelVersionResponse>(req, "DeleteTrainingModelVersion");
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public DeleteTrainingModelVersionResponse DeleteTrainingModelVersionSync(DeleteTrainingModelVersionRequest req)
        {
            return InternalRequestAsync<DeleteTrainingModelVersionResponse>(req, "DeleteTrainingModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源组节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupResponse"/></returns>
        public Task<DescribeBillingResourceGroupResponse> DescribeBillingResourceGroup(DescribeBillingResourceGroupRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupResponse>(req, "DescribeBillingResourceGroup");
        }

        /// <summary>
        /// 查询资源组节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupResponse"/></returns>
        public DescribeBillingResourceGroupResponse DescribeBillingResourceGroupSync(DescribeBillingResourceGroupRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupResponse>(req, "DescribeBillingResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public Task<DescribeBillingResourceGroupsResponse> DescribeBillingResourceGroups(DescribeBillingResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupsResponse>(req, "DescribeBillingResourceGroups");
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public DescribeBillingResourceGroupsResponse DescribeBillingResourceGroupsSync(DescribeBillingResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupsResponse>(req, "DescribeBillingResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源组节点运行中的任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceInstanceRunningJobsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceInstanceRunningJobsResponse"/></returns>
        public Task<DescribeBillingResourceInstanceRunningJobsResponse> DescribeBillingResourceInstanceRunningJobs(DescribeBillingResourceInstanceRunningJobsRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceInstanceRunningJobsResponse>(req, "DescribeBillingResourceInstanceRunningJobs");
        }

        /// <summary>
        /// 查询资源组节点运行中的任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceInstanceRunningJobsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceInstanceRunningJobsResponse"/></returns>
        public DescribeBillingResourceInstanceRunningJobsResponse DescribeBillingResourceInstanceRunningJobsSync(DescribeBillingResourceInstanceRunningJobsRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceInstanceRunningJobsResponse>(req, "DescribeBillingResourceInstanceRunningJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取内置镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildInImagesRequest"/></param>
        /// <returns><see cref="DescribeBuildInImagesResponse"/></returns>
        public Task<DescribeBuildInImagesResponse> DescribeBuildInImages(DescribeBuildInImagesRequest req)
        {
            return InternalRequestAsync<DescribeBuildInImagesResponse>(req, "DescribeBuildInImages");
        }

        /// <summary>
        /// 获取内置镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildInImagesRequest"/></param>
        /// <returns><see cref="DescribeBuildInImagesResponse"/></returns>
        public DescribeBuildInImagesResponse DescribeBuildInImagesSync(DescribeBuildInImagesRequest req)
        {
            return InternalRequestAsync<DescribeBuildInImagesResponse>(req, "DescribeBuildInImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public Task<DescribeDatasetsResponse> DescribeDatasets(DescribeDatasetsRequest req)
        {
            return InternalRequestAsync<DescribeDatasetsResponse>(req, "DescribeDatasets");
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public DescribeDatasetsResponse DescribeDatasetsSync(DescribeDatasetsRequest req)
        {
            return InternalRequestAsync<DescribeDatasetsResponse>(req, "DescribeDatasets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public Task<DescribeInferTemplatesResponse> DescribeInferTemplates(DescribeInferTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeInferTemplatesResponse>(req, "DescribeInferTemplates");
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public DescribeInferTemplatesResponse DescribeInferTemplatesSync(DescribeInferTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeInferTemplatesResponse>(req, "DescribeInferTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型优化任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTaskResponse"/></returns>
        public Task<DescribeModelAccelerateTaskResponse> DescribeModelAccelerateTask(DescribeModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateTaskResponse>(req, "DescribeModelAccelerateTask");
        }

        /// <summary>
        /// 查询模型优化任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTaskResponse"/></returns>
        public DescribeModelAccelerateTaskResponse DescribeModelAccelerateTaskSync(DescribeModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateTaskResponse>(req, "DescribeModelAccelerateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 模型加速之后的模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateVersionsResponse"/></returns>
        public Task<DescribeModelAccelerateVersionsResponse> DescribeModelAccelerateVersions(DescribeModelAccelerateVersionsRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateVersionsResponse>(req, "DescribeModelAccelerateVersions");
        }

        /// <summary>
        /// 模型加速之后的模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateVersionsResponse"/></returns>
        public DescribeModelAccelerateVersionsResponse DescribeModelAccelerateVersionsSync(DescribeModelAccelerateVersionsRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateVersionsResponse>(req, "DescribeModelAccelerateVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public Task<DescribeModelServiceResponse> DescribeModelService(DescribeModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceResponse>(req, "DescribeModelService");
        }

        /// <summary>
        /// 查询单个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public DescribeModelServiceResponse DescribeModelServiceSync(DescribeModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceResponse>(req, "DescribeModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示服务的调用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceCallInfoRequest"/></param>
        /// <returns><see cref="DescribeModelServiceCallInfoResponse"/></returns>
        public Task<DescribeModelServiceCallInfoResponse> DescribeModelServiceCallInfo(DescribeModelServiceCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceCallInfoResponse>(req, "DescribeModelServiceCallInfo");
        }

        /// <summary>
        /// 展示服务的调用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceCallInfoRequest"/></param>
        /// <returns><see cref="DescribeModelServiceCallInfoResponse"/></returns>
        public DescribeModelServiceCallInfoResponse DescribeModelServiceCallInfoSync(DescribeModelServiceCallInfoRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceCallInfoResponse>(req, "DescribeModelServiceCallInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupResponse"/></returns>
        public Task<DescribeModelServiceGroupResponse> DescribeModelServiceGroup(DescribeModelServiceGroupRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceGroupResponse>(req, "DescribeModelServiceGroup");
        }

        /// <summary>
        /// 查询单个服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupResponse"/></returns>
        public DescribeModelServiceGroupResponse DescribeModelServiceGroupSync(DescribeModelServiceGroupRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceGroupResponse>(req, "DescribeModelServiceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列举在线推理服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupsRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupsResponse"/></returns>
        public Task<DescribeModelServiceGroupsResponse> DescribeModelServiceGroups(DescribeModelServiceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceGroupsResponse>(req, "DescribeModelServiceGroups");
        }

        /// <summary>
        /// 列举在线推理服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupsRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupsResponse"/></returns>
        public DescribeModelServiceGroupsResponse DescribeModelServiceGroupsSync(DescribeModelServiceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceGroupsResponse>(req, "DescribeModelServiceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询模型服务能否开启热更新
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHotUpdatedRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHotUpdatedResponse"/></returns>
        public Task<DescribeModelServiceHotUpdatedResponse> DescribeModelServiceHotUpdated(DescribeModelServiceHotUpdatedRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceHotUpdatedResponse>(req, "DescribeModelServiceHotUpdated");
        }

        /// <summary>
        /// 用于查询模型服务能否开启热更新
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHotUpdatedRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHotUpdatedResponse"/></returns>
        public DescribeModelServiceHotUpdatedResponse DescribeModelServiceHotUpdatedSync(DescribeModelServiceHotUpdatedRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceHotUpdatedResponse>(req, "DescribeModelServiceHotUpdated")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Notebook详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookRequest"/></param>
        /// <returns><see cref="DescribeNotebookResponse"/></returns>
        public Task<DescribeNotebookResponse> DescribeNotebook(DescribeNotebookRequest req)
        {
            return InternalRequestAsync<DescribeNotebookResponse>(req, "DescribeNotebook");
        }

        /// <summary>
        /// Notebook详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookRequest"/></param>
        /// <returns><see cref="DescribeNotebookResponse"/></returns>
        public DescribeNotebookResponse DescribeNotebookSync(DescribeNotebookRequest req)
        {
            return InternalRequestAsync<DescribeNotebookResponse>(req, "DescribeNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Notebook列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebooksRequest"/></param>
        /// <returns><see cref="DescribeNotebooksResponse"/></returns>
        public Task<DescribeNotebooksResponse> DescribeNotebooks(DescribeNotebooksRequest req)
        {
            return InternalRequestAsync<DescribeNotebooksResponse>(req, "DescribeNotebooks");
        }

        /// <summary>
        /// Notebook列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebooksRequest"/></param>
        /// <returns><see cref="DescribeNotebooksResponse"/></returns>
        public DescribeNotebooksResponse DescribeNotebooksSync(DescribeNotebooksRequest req)
        {
            return InternalRequestAsync<DescribeNotebooksResponse>(req, "DescribeNotebooks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public Task<DescribeTrainingModelVersionResponse> DescribeTrainingModelVersion(DescribeTrainingModelVersionRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelVersionResponse>(req, "DescribeTrainingModelVersion");
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public DescribeTrainingModelVersionResponse DescribeTrainingModelVersionSync(DescribeTrainingModelVersionRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelVersionResponse>(req, "DescribeTrainingModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public Task<DescribeTrainingModelVersionsResponse> DescribeTrainingModelVersions(DescribeTrainingModelVersionsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelVersionsResponse>(req, "DescribeTrainingModelVersions");
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public DescribeTrainingModelVersionsResponse DescribeTrainingModelVersionsSync(DescribeTrainingModelVersionsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelVersionsResponse>(req, "DescribeTrainingModelVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public Task<DescribeTrainingTaskResponse> DescribeTrainingTask(DescribeTrainingTaskRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskResponse>(req, "DescribeTrainingTask");
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public DescribeTrainingTaskResponse DescribeTrainingTaskSync(DescribeTrainingTaskRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskResponse>(req, "DescribeTrainingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public Task<DescribeTrainingTaskPodsResponse> DescribeTrainingTaskPods(DescribeTrainingTaskPodsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskPodsResponse>(req, "DescribeTrainingTaskPods");
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public DescribeTrainingTaskPodsResponse DescribeTrainingTaskPodsSync(DescribeTrainingTaskPodsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskPodsResponse>(req, "DescribeTrainingTaskPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public Task<DescribeTrainingTasksResponse> DescribeTrainingTasks(DescribeTrainingTasksRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTasksResponse>(req, "DescribeTrainingTasks");
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public DescribeTrainingTasksResponse DescribeTrainingTasksSync(DescribeTrainingTasksRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTasksResponse>(req, "DescribeTrainingTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于更新模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public Task<ModifyModelServiceResponse> ModifyModelService(ModifyModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceResponse>(req, "ModifyModelService");
        }

        /// <summary>
        /// 用于更新模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public ModifyModelServiceResponse ModifyModelServiceSync(ModifyModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceResponse>(req, "ModifyModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public Task<PushTrainingMetricsResponse> PushTrainingMetrics(PushTrainingMetricsRequest req)
        {
            return InternalRequestAsync<PushTrainingMetricsResponse>(req, "PushTrainingMetrics");
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public PushTrainingMetricsResponse PushTrainingMetricsSync(PushTrainingMetricsRequest req)
        {
            return InternalRequestAsync<PushTrainingMetricsResponse>(req, "PushTrainingMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 这是一个供您体验大模型聊天的接口。
        /// </summary>
        /// <param name="req"><see cref="SendChatMessageRequest"/></param>
        /// <returns><see cref="SendChatMessageResponse"/></returns>
        public Task<SendChatMessageResponse> SendChatMessage(SendChatMessageRequest req)
        {
            return InternalRequestAsync<SendChatMessageResponse>(req, "SendChatMessage");
        }

        /// <summary>
        /// 这是一个供您体验大模型聊天的接口。
        /// </summary>
        /// <param name="req"><see cref="SendChatMessageRequest"/></param>
        /// <returns><see cref="SendChatMessageResponse"/></returns>
        public SendChatMessageResponse SendChatMessageSync(SendChatMessageRequest req)
        {
            return InternalRequestAsync<SendChatMessageResponse>(req, "SendChatMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动Notebook
        /// </summary>
        /// <param name="req"><see cref="StartNotebookRequest"/></param>
        /// <returns><see cref="StartNotebookResponse"/></returns>
        public Task<StartNotebookResponse> StartNotebook(StartNotebookRequest req)
        {
            return InternalRequestAsync<StartNotebookResponse>(req, "StartNotebook");
        }

        /// <summary>
        /// 启动Notebook
        /// </summary>
        /// <param name="req"><see cref="StartNotebookRequest"/></param>
        /// <returns><see cref="StartNotebookResponse"/></returns>
        public StartNotebookResponse StartNotebookSync(StartNotebookRequest req)
        {
            return InternalRequestAsync<StartNotebookResponse>(req, "StartNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止模型加速任务
        /// </summary>
        /// <param name="req"><see cref="StopModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="StopModelAccelerateTaskResponse"/></returns>
        public Task<StopModelAccelerateTaskResponse> StopModelAccelerateTask(StopModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<StopModelAccelerateTaskResponse>(req, "StopModelAccelerateTask");
        }

        /// <summary>
        /// 停止模型加速任务
        /// </summary>
        /// <param name="req"><see cref="StopModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="StopModelAccelerateTaskResponse"/></returns>
        public StopModelAccelerateTaskResponse StopModelAccelerateTaskSync(StopModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<StopModelAccelerateTaskResponse>(req, "StopModelAccelerateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止Notebook
        /// </summary>
        /// <param name="req"><see cref="StopNotebookRequest"/></param>
        /// <returns><see cref="StopNotebookResponse"/></returns>
        public Task<StopNotebookResponse> StopNotebook(StopNotebookRequest req)
        {
            return InternalRequestAsync<StopNotebookResponse>(req, "StopNotebook");
        }

        /// <summary>
        /// 停止Notebook
        /// </summary>
        /// <param name="req"><see cref="StopNotebookRequest"/></param>
        /// <returns><see cref="StopNotebookResponse"/></returns>
        public StopNotebookResponse StopNotebookSync(StopNotebookRequest req)
        {
            return InternalRequestAsync<StopNotebookResponse>(req, "StopNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
