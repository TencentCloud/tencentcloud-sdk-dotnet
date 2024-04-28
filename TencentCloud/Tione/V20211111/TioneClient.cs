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
       private const string sdkVersion = "SDK_NET_3.0.995";

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
        /// 批量创建模型加速任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchModelAccTasksRequest"/></param>
        /// <returns><see cref="CreateBatchModelAccTasksResponse"/></returns>
        public Task<CreateBatchModelAccTasksResponse> CreateBatchModelAccTasks(CreateBatchModelAccTasksRequest req)
        {
            return InternalRequestAsync<CreateBatchModelAccTasksResponse>(req, "CreateBatchModelAccTasks");
        }

        /// <summary>
        /// 批量创建模型加速任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchModelAccTasksRequest"/></param>
        /// <returns><see cref="CreateBatchModelAccTasksResponse"/></returns>
        public CreateBatchModelAccTasksResponse CreateBatchModelAccTasksSync(CreateBatchModelAccTasksRequest req)
        {
            return InternalRequestAsync<CreateBatchModelAccTasksResponse>(req, "CreateBatchModelAccTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建批量预测任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchTaskRequest"/></param>
        /// <returns><see cref="CreateBatchTaskResponse"/></returns>
        public Task<CreateBatchTaskResponse> CreateBatchTask(CreateBatchTaskRequest req)
        {
            return InternalRequestAsync<CreateBatchTaskResponse>(req, "CreateBatchTask");
        }

        /// <summary>
        /// 创建批量预测任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchTaskRequest"/></param>
        /// <returns><see cref="CreateBatchTaskResponse"/></returns>
        public CreateBatchTaskResponse CreateBatchTaskSync(CreateBatchTaskRequest req)
        {
            return InternalRequestAsync<CreateBatchTaskResponse>(req, "CreateBatchTask")
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
        /// 保存镜像
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookImageRequest"/></param>
        /// <returns><see cref="CreateNotebookImageResponse"/></returns>
        public Task<CreateNotebookImageResponse> CreateNotebookImage(CreateNotebookImageRequest req)
        {
            return InternalRequestAsync<CreateNotebookImageResponse>(req, "CreateNotebookImage");
        }

        /// <summary>
        /// 保存镜像
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookImageRequest"/></param>
        /// <returns><see cref="CreateNotebookImageResponse"/></returns>
        public CreateNotebookImageResponse CreateNotebookImageSync(CreateNotebookImageRequest req)
        {
            return InternalRequestAsync<CreateNotebookImageResponse>(req, "CreateNotebookImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 保存优化模型
        /// </summary>
        /// <param name="req"><see cref="CreateOptimizedModelRequest"/></param>
        /// <returns><see cref="CreateOptimizedModelResponse"/></returns>
        public Task<CreateOptimizedModelResponse> CreateOptimizedModel(CreateOptimizedModelRequest req)
        {
            return InternalRequestAsync<CreateOptimizedModelResponse>(req, "CreateOptimizedModel");
        }

        /// <summary>
        /// 保存优化模型
        /// </summary>
        /// <param name="req"><see cref="CreateOptimizedModelRequest"/></param>
        /// <returns><see cref="CreateOptimizedModelResponse"/></returns>
        public CreateOptimizedModelResponse CreateOptimizedModelSync(CreateOptimizedModelRequest req)
        {
            return InternalRequestAsync<CreateOptimizedModelResponse>(req, "CreateOptimizedModel")
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
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public Task<CreateTrainingTaskResponse> CreateTrainingTask(CreateTrainingTaskRequest req)
        {
            return InternalRequestAsync<CreateTrainingTaskResponse>(req, "CreateTrainingTask");
        }

        /// <summary>
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public CreateTrainingTaskResponse CreateTrainingTaskSync(CreateTrainingTaskRequest req)
        {
            return InternalRequestAsync<CreateTrainingTaskResponse>(req, "CreateTrainingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除批量预测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchTaskRequest"/></param>
        /// <returns><see cref="DeleteBatchTaskResponse"/></returns>
        public Task<DeleteBatchTaskResponse> DeleteBatchTask(DeleteBatchTaskRequest req)
        {
            return InternalRequestAsync<DeleteBatchTaskResponse>(req, "DeleteBatchTask");
        }

        /// <summary>
        /// 删除批量预测任务
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchTaskRequest"/></param>
        /// <returns><see cref="DeleteBatchTaskResponse"/></returns>
        public DeleteBatchTaskResponse DeleteBatchTaskSync(DeleteBatchTaskRequest req)
        {
            return InternalRequestAsync<DeleteBatchTaskResponse>(req, "DeleteBatchTask")
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
        /// 删除模型加速任务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DeleteModelAccelerateTaskResponse"/></returns>
        public Task<DeleteModelAccelerateTaskResponse> DeleteModelAccelerateTask(DeleteModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<DeleteModelAccelerateTaskResponse>(req, "DeleteModelAccelerateTask");
        }

        /// <summary>
        /// 删除模型加速任务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DeleteModelAccelerateTaskResponse"/></returns>
        public DeleteModelAccelerateTaskResponse DeleteModelAccelerateTaskSync(DeleteModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<DeleteModelAccelerateTaskResponse>(req, "DeleteModelAccelerateTask")
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
        /// 删除notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookImageRecordRequest"/></param>
        /// <returns><see cref="DeleteNotebookImageRecordResponse"/></returns>
        public Task<DeleteNotebookImageRecordResponse> DeleteNotebookImageRecord(DeleteNotebookImageRecordRequest req)
        {
            return InternalRequestAsync<DeleteNotebookImageRecordResponse>(req, "DeleteNotebookImageRecord");
        }

        /// <summary>
        /// 删除notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookImageRecordRequest"/></param>
        /// <returns><see cref="DeleteNotebookImageRecordResponse"/></returns>
        public DeleteNotebookImageRecordResponse DeleteNotebookImageRecordSync(DeleteNotebookImageRecordRequest req)
        {
            return InternalRequestAsync<DeleteNotebookImageRecordResponse>(req, "DeleteNotebookImageRecord")
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
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public Task<DeleteTrainingTaskResponse> DeleteTrainingTask(DeleteTrainingTaskRequest req)
        {
            return InternalRequestAsync<DeleteTrainingTaskResponse>(req, "DeleteTrainingTask");
        }

        /// <summary>
        /// 删除训练任务
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public DeleteTrainingTaskResponse DeleteTrainingTaskSync(DeleteTrainingTaskRequest req)
        {
            return InternalRequestAsync<DeleteTrainingTaskResponse>(req, "DeleteTrainingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列举API
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIConfigsRequest"/></param>
        /// <returns><see cref="DescribeAPIConfigsResponse"/></returns>
        public Task<DescribeAPIConfigsResponse> DescribeAPIConfigs(DescribeAPIConfigsRequest req)
        {
            return InternalRequestAsync<DescribeAPIConfigsResponse>(req, "DescribeAPIConfigs");
        }

        /// <summary>
        /// 列举API
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIConfigsRequest"/></param>
        /// <returns><see cref="DescribeAPIConfigsResponse"/></returns>
        public DescribeAPIConfigsResponse DescribeAPIConfigsSync(DescribeAPIConfigsRequest req)
        {
            return InternalRequestAsync<DescribeAPIConfigsResponse>(req, "DescribeAPIConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批量预测任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public Task<DescribeBatchTaskResponse> DescribeBatchTask(DescribeBatchTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchTaskResponse>(req, "DescribeBatchTask");
        }

        /// <summary>
        /// 查询批量预测任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public DescribeBatchTaskResponse DescribeBatchTaskSync(DescribeBatchTaskRequest req)
        {
            return InternalRequestAsync<DescribeBatchTaskResponse>(req, "DescribeBatchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批量预测任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskInstancesResponse"/></returns>
        public Task<DescribeBatchTaskInstancesResponse> DescribeBatchTaskInstances(DescribeBatchTaskInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBatchTaskInstancesResponse>(req, "DescribeBatchTaskInstances");
        }

        /// <summary>
        /// 查询批量预测任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskInstancesResponse"/></returns>
        public DescribeBatchTaskInstancesResponse DescribeBatchTaskInstancesSync(DescribeBatchTaskInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBatchTaskInstancesResponse>(req, "DescribeBatchTaskInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批量预测任务列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTasksRequest"/></param>
        /// <returns><see cref="DescribeBatchTasksResponse"/></returns>
        public Task<DescribeBatchTasksResponse> DescribeBatchTasks(DescribeBatchTasksRequest req)
        {
            return InternalRequestAsync<DescribeBatchTasksResponse>(req, "DescribeBatchTasks");
        }

        /// <summary>
        /// 查询批量预测任务列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTasksRequest"/></param>
        /// <returns><see cref="DescribeBatchTasksResponse"/></returns>
        public DescribeBatchTasksResponse DescribeBatchTasksSync(DescribeBatchTasksRequest req)
        {
            return InternalRequestAsync<DescribeBatchTasksResponse>(req, "DescribeBatchTasks")
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
        /// 本接口(DescribeBillingSpecs)用于查询计费项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsResponse"/></returns>
        public Task<DescribeBillingSpecsResponse> DescribeBillingSpecs(DescribeBillingSpecsRequest req)
        {
            return InternalRequestAsync<DescribeBillingSpecsResponse>(req, "DescribeBillingSpecs");
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecs)用于查询计费项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsResponse"/></returns>
        public DescribeBillingSpecsResponse DescribeBillingSpecsSync(DescribeBillingSpecsRequest req)
        {
            return InternalRequestAsync<DescribeBillingSpecsResponse>(req, "DescribeBillingSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询按量计费计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public Task<DescribeBillingSpecsPriceResponse> DescribeBillingSpecsPrice(DescribeBillingSpecsPriceRequest req)
        {
            return InternalRequestAsync<DescribeBillingSpecsPriceResponse>(req, "DescribeBillingSpecsPrice");
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询按量计费计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public DescribeBillingSpecsPriceResponse DescribeBillingSpecsPriceSync(DescribeBillingSpecsPriceRequest req)
        {
            return InternalRequestAsync<DescribeBillingSpecsPriceResponse>(req, "DescribeBillingSpecsPrice")
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
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public Task<DescribeDatasetDetailStructuredResponse> DescribeDatasetDetailStructured(DescribeDatasetDetailStructuredRequest req)
        {
            return InternalRequestAsync<DescribeDatasetDetailStructuredResponse>(req, "DescribeDatasetDetailStructured");
        }

        /// <summary>
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public DescribeDatasetDetailStructuredResponse DescribeDatasetDetailStructuredSync(DescribeDatasetDetailStructuredRequest req)
        {
            return InternalRequestAsync<DescribeDatasetDetailStructuredResponse>(req, "DescribeDatasetDetailStructured")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public Task<DescribeDatasetDetailUnstructuredResponse> DescribeDatasetDetailUnstructured(DescribeDatasetDetailUnstructuredRequest req)
        {
            return InternalRequestAsync<DescribeDatasetDetailUnstructuredResponse>(req, "DescribeDatasetDetailUnstructured");
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public DescribeDatasetDetailUnstructuredResponse DescribeDatasetDetailUnstructuredSync(DescribeDatasetDetailUnstructuredRequest req)
        {
            return InternalRequestAsync<DescribeDatasetDetailUnstructuredResponse>(req, "DescribeDatasetDetailUnstructured")
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
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的事件API
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents");
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的事件API
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents")
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
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public Task<DescribeLatestTrainingMetricsResponse> DescribeLatestTrainingMetrics(DescribeLatestTrainingMetricsRequest req)
        {
            return InternalRequestAsync<DescribeLatestTrainingMetricsResponse>(req, "DescribeLatestTrainingMetrics");
        }

        /// <summary>
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public DescribeLatestTrainingMetricsResponse DescribeLatestTrainingMetricsSync(DescribeLatestTrainingMetricsRequest req)
        {
            return InternalRequestAsync<DescribeLatestTrainingMetricsResponse>(req, "DescribeLatestTrainingMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的日志API
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs");
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的日志API
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogsResponse>(req, "DescribeLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型加速引擎版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccEngineVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccEngineVersionsResponse"/></returns>
        public Task<DescribeModelAccEngineVersionsResponse> DescribeModelAccEngineVersions(DescribeModelAccEngineVersionsRequest req)
        {
            return InternalRequestAsync<DescribeModelAccEngineVersionsResponse>(req, "DescribeModelAccEngineVersions");
        }

        /// <summary>
        /// 查询模型加速引擎版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccEngineVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccEngineVersionsResponse"/></returns>
        public DescribeModelAccEngineVersionsResponse DescribeModelAccEngineVersionsSync(DescribeModelAccEngineVersionsRequest req)
        {
            return InternalRequestAsync<DescribeModelAccEngineVersionsResponse>(req, "DescribeModelAccEngineVersions")
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
        /// 查询模型加速任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTasksRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTasksResponse"/></returns>
        public Task<DescribeModelAccelerateTasksResponse> DescribeModelAccelerateTasks(DescribeModelAccelerateTasksRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateTasksResponse>(req, "DescribeModelAccelerateTasks");
        }

        /// <summary>
        /// 查询模型加速任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTasksRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTasksResponse"/></returns>
        public DescribeModelAccelerateTasksResponse DescribeModelAccelerateTasksSync(DescribeModelAccelerateTasksRequest req)
        {
            return InternalRequestAsync<DescribeModelAccelerateTasksResponse>(req, "DescribeModelAccelerateTasks")
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
        /// 展示服务的历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHistoryRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHistoryResponse"/></returns>
        public Task<DescribeModelServiceHistoryResponse> DescribeModelServiceHistory(DescribeModelServiceHistoryRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceHistoryResponse>(req, "DescribeModelServiceHistory");
        }

        /// <summary>
        /// 展示服务的历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHistoryRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHistoryResponse"/></returns>
        public DescribeModelServiceHistoryResponse DescribeModelServiceHistorySync(DescribeModelServiceHistoryRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceHistoryResponse>(req, "DescribeModelServiceHistory")
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
        /// 查询多个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public Task<DescribeModelServicesResponse> DescribeModelServices(DescribeModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeModelServicesResponse>(req, "DescribeModelServices");
        }

        /// <summary>
        /// 查询多个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public DescribeModelServicesResponse DescribeModelServicesSync(DescribeModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeModelServicesResponse>(req, "DescribeModelServices")
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
        /// 查询镜像kernel
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageKernelsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageKernelsResponse"/></returns>
        public Task<DescribeNotebookImageKernelsResponse> DescribeNotebookImageKernels(DescribeNotebookImageKernelsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookImageKernelsResponse>(req, "DescribeNotebookImageKernels");
        }

        /// <summary>
        /// 查询镜像kernel
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageKernelsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageKernelsResponse"/></returns>
        public DescribeNotebookImageKernelsResponse DescribeNotebookImageKernelsSync(DescribeNotebookImageKernelsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookImageKernelsResponse>(req, "DescribeNotebookImageKernels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageRecordsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageRecordsResponse"/></returns>
        public Task<DescribeNotebookImageRecordsResponse> DescribeNotebookImageRecords(DescribeNotebookImageRecordsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookImageRecordsResponse>(req, "DescribeNotebookImageRecords");
        }

        /// <summary>
        /// 查看notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageRecordsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageRecordsResponse"/></returns>
        public DescribeNotebookImageRecordsResponse DescribeNotebookImageRecordsSync(DescribeNotebookImageRecordsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookImageRecordsResponse>(req, "DescribeNotebookImageRecords")
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
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public Task<DescribeTrainingFrameworksResponse> DescribeTrainingFrameworks(DescribeTrainingFrameworksRequest req)
        {
            return InternalRequestAsync<DescribeTrainingFrameworksResponse>(req, "DescribeTrainingFrameworks");
        }

        /// <summary>
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public DescribeTrainingFrameworksResponse DescribeTrainingFrameworksSync(DescribeTrainingFrameworksRequest req)
        {
            return InternalRequestAsync<DescribeTrainingFrameworksResponse>(req, "DescribeTrainingFrameworks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public Task<DescribeTrainingMetricsResponse> DescribeTrainingMetrics(DescribeTrainingMetricsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingMetricsResponse>(req, "DescribeTrainingMetrics");
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public DescribeTrainingMetricsResponse DescribeTrainingMetricsSync(DescribeTrainingMetricsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingMetricsResponse>(req, "DescribeTrainingMetrics")
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
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public Task<DescribeTrainingModelsResponse> DescribeTrainingModels(DescribeTrainingModelsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelsResponse>(req, "DescribeTrainingModels");
        }

        /// <summary>
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public DescribeTrainingModelsResponse DescribeTrainingModelsSync(DescribeTrainingModelsRequest req)
        {
            return InternalRequestAsync<DescribeTrainingModelsResponse>(req, "DescribeTrainingModels")
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
        /// 增量更新在线推理服务的部分配置，不更新的配置项不需要传入
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServicePartialConfigRequest"/></param>
        /// <returns><see cref="ModifyModelServicePartialConfigResponse"/></returns>
        public Task<ModifyModelServicePartialConfigResponse> ModifyModelServicePartialConfig(ModifyModelServicePartialConfigRequest req)
        {
            return InternalRequestAsync<ModifyModelServicePartialConfigResponse>(req, "ModifyModelServicePartialConfig");
        }

        /// <summary>
        /// 增量更新在线推理服务的部分配置，不更新的配置项不需要传入
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServicePartialConfigRequest"/></param>
        /// <returns><see cref="ModifyModelServicePartialConfigResponse"/></returns>
        public ModifyModelServicePartialConfigResponse ModifyModelServicePartialConfigSync(ModifyModelServicePartialConfigRequest req)
        {
            return InternalRequestAsync<ModifyModelServicePartialConfigResponse>(req, "ModifyModelServicePartialConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Notebook
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookRequest"/></param>
        /// <returns><see cref="ModifyNotebookResponse"/></returns>
        public Task<ModifyNotebookResponse> ModifyNotebook(ModifyNotebookRequest req)
        {
            return InternalRequestAsync<ModifyNotebookResponse>(req, "ModifyNotebook");
        }

        /// <summary>
        /// 修改Notebook
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookRequest"/></param>
        /// <returns><see cref="ModifyNotebookResponse"/></returns>
        public ModifyNotebookResponse ModifyNotebookSync(ModifyNotebookRequest req)
        {
            return InternalRequestAsync<ModifyNotebookResponse>(req, "ModifyNotebook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Notebook标签
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookTagsRequest"/></param>
        /// <returns><see cref="ModifyNotebookTagsResponse"/></returns>
        public Task<ModifyNotebookTagsResponse> ModifyNotebookTags(ModifyNotebookTagsRequest req)
        {
            return InternalRequestAsync<ModifyNotebookTagsResponse>(req, "ModifyNotebookTags");
        }

        /// <summary>
        /// 修改Notebook标签
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookTagsRequest"/></param>
        /// <returns><see cref="ModifyNotebookTagsResponse"/></returns>
        public ModifyNotebookTagsResponse ModifyNotebookTagsSync(ModifyNotebookTagsRequest req)
        {
            return InternalRequestAsync<ModifyNotebookTagsResponse>(req, "ModifyNotebookTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新推理服务组流量分配
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceGroupWeightsRequest"/></param>
        /// <returns><see cref="ModifyServiceGroupWeightsResponse"/></returns>
        public Task<ModifyServiceGroupWeightsResponse> ModifyServiceGroupWeights(ModifyServiceGroupWeightsRequest req)
        {
            return InternalRequestAsync<ModifyServiceGroupWeightsResponse>(req, "ModifyServiceGroupWeights");
        }

        /// <summary>
        /// 更新推理服务组流量分配
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceGroupWeightsRequest"/></param>
        /// <returns><see cref="ModifyServiceGroupWeightsResponse"/></returns>
        public ModifyServiceGroupWeightsResponse ModifyServiceGroupWeightsSync(ModifyServiceGroupWeightsRequest req)
        {
            return InternalRequestAsync<ModifyServiceGroupWeightsResponse>(req, "ModifyServiceGroupWeights")
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
        /// 重启模型加速任务
        /// </summary>
        /// <param name="req"><see cref="RestartModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="RestartModelAccelerateTaskResponse"/></returns>
        public Task<RestartModelAccelerateTaskResponse> RestartModelAccelerateTask(RestartModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<RestartModelAccelerateTaskResponse>(req, "RestartModelAccelerateTask");
        }

        /// <summary>
        /// 重启模型加速任务
        /// </summary>
        /// <param name="req"><see cref="RestartModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="RestartModelAccelerateTaskResponse"/></returns>
        public RestartModelAccelerateTaskResponse RestartModelAccelerateTaskSync(RestartModelAccelerateTaskRequest req)
        {
            return InternalRequestAsync<RestartModelAccelerateTaskResponse>(req, "RestartModelAccelerateTask")
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
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public Task<StartTrainingTaskResponse> StartTrainingTask(StartTrainingTaskRequest req)
        {
            return InternalRequestAsync<StartTrainingTaskResponse>(req, "StartTrainingTask");
        }

        /// <summary>
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public StartTrainingTaskResponse StartTrainingTaskSync(StartTrainingTaskRequest req)
        {
            return InternalRequestAsync<StartTrainingTaskResponse>(req, "StartTrainingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止批量预测任务
        /// </summary>
        /// <param name="req"><see cref="StopBatchTaskRequest"/></param>
        /// <returns><see cref="StopBatchTaskResponse"/></returns>
        public Task<StopBatchTaskResponse> StopBatchTask(StopBatchTaskRequest req)
        {
            return InternalRequestAsync<StopBatchTaskResponse>(req, "StopBatchTask");
        }

        /// <summary>
        /// 停止批量预测任务
        /// </summary>
        /// <param name="req"><see cref="StopBatchTaskRequest"/></param>
        /// <returns><see cref="StopBatchTaskResponse"/></returns>
        public StopBatchTaskResponse StopBatchTaskSync(StopBatchTaskRequest req)
        {
            return InternalRequestAsync<StopBatchTaskResponse>(req, "StopBatchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止保存镜像
        /// </summary>
        /// <param name="req"><see cref="StopCreatingImageRequest"/></param>
        /// <returns><see cref="StopCreatingImageResponse"/></returns>
        public Task<StopCreatingImageResponse> StopCreatingImage(StopCreatingImageRequest req)
        {
            return InternalRequestAsync<StopCreatingImageResponse>(req, "StopCreatingImage");
        }

        /// <summary>
        /// 停止保存镜像
        /// </summary>
        /// <param name="req"><see cref="StopCreatingImageRequest"/></param>
        /// <returns><see cref="StopCreatingImageResponse"/></returns>
        public StopCreatingImageResponse StopCreatingImageSync(StopCreatingImageRequest req)
        {
            return InternalRequestAsync<StopCreatingImageResponse>(req, "StopCreatingImage")
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

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public Task<StopTrainingTaskResponse> StopTrainingTask(StopTrainingTaskRequest req)
        {
            return InternalRequestAsync<StopTrainingTaskResponse>(req, "StopTrainingTask");
        }

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public StopTrainingTaskResponse StopTrainingTaskSync(StopTrainingTaskRequest req)
        {
            return InternalRequestAsync<StopTrainingTaskResponse>(req, "StopTrainingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
