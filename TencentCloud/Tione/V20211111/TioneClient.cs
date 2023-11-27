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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TioneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 该接口支持与自行部署的大模型的聊天。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public async Task<ChatCompletionResponse> ChatCompletion(ChatCompletionRequest req)
        {
             JsonResponseModel<ChatCompletionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChatCompletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatCompletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口支持与自行部署的大模型的聊天。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public ChatCompletionResponse ChatCompletionSync(ChatCompletionRequest req)
        {
             JsonResponseModel<ChatCompletionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChatCompletion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatCompletionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建模型加速任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchModelAccTasksRequest"/></param>
        /// <returns><see cref="CreateBatchModelAccTasksResponse"/></returns>
        public async Task<CreateBatchModelAccTasksResponse> CreateBatchModelAccTasks(CreateBatchModelAccTasksRequest req)
        {
             JsonResponseModel<CreateBatchModelAccTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatchModelAccTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchModelAccTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建模型加速任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchModelAccTasksRequest"/></param>
        /// <returns><see cref="CreateBatchModelAccTasksResponse"/></returns>
        public CreateBatchModelAccTasksResponse CreateBatchModelAccTasksSync(CreateBatchModelAccTasksRequest req)
        {
             JsonResponseModel<CreateBatchModelAccTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatchModelAccTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchModelAccTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跑批任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchTaskRequest"/></param>
        /// <returns><see cref="CreateBatchTaskResponse"/></returns>
        public async Task<CreateBatchTaskResponse> CreateBatchTask(CreateBatchTaskRequest req)
        {
             JsonResponseModel<CreateBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跑批任务
        /// </summary>
        /// <param name="req"><see cref="CreateBatchTaskRequest"/></param>
        /// <returns><see cref="CreateBatchTaskResponse"/></returns>
        public CreateBatchTaskResponse CreateBatchTaskSync(CreateBatchTaskRequest req)
        {
             JsonResponseModel<CreateBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public async Task<CreateDatasetResponse> CreateDataset(CreateDatasetRequest req)
        {
             JsonResponseModel<CreateDatasetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据集
        /// </summary>
        /// <param name="req"><see cref="CreateDatasetRequest"/></param>
        /// <returns><see cref="CreateDatasetResponse"/></returns>
        public CreateDatasetResponse CreateDatasetSync(CreateDatasetRequest req)
        {
             JsonResponseModel<CreateDatasetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建、发布一个新的模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public async Task<CreateModelServiceResponse> CreateModelService(CreateModelServiceRequest req)
        {
             JsonResponseModel<CreateModelServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建、发布一个新的模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public CreateModelServiceResponse CreateModelServiceSync(CreateModelServiceRequest req)
        {
             JsonResponseModel<CreateModelServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Notebook
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookRequest"/></param>
        /// <returns><see cref="CreateNotebookResponse"/></returns>
        public async Task<CreateNotebookResponse> CreateNotebook(CreateNotebookRequest req)
        {
             JsonResponseModel<CreateNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Notebook
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookRequest"/></param>
        /// <returns><see cref="CreateNotebookResponse"/></returns>
        public CreateNotebookResponse CreateNotebookSync(CreateNotebookRequest req)
        {
             JsonResponseModel<CreateNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存镜像
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookImageRequest"/></param>
        /// <returns><see cref="CreateNotebookImageResponse"/></returns>
        public async Task<CreateNotebookImageResponse> CreateNotebookImage(CreateNotebookImageRequest req)
        {
             JsonResponseModel<CreateNotebookImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebookImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存镜像
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookImageRequest"/></param>
        /// <returns><see cref="CreateNotebookImageResponse"/></returns>
        public CreateNotebookImageResponse CreateNotebookImageSync(CreateNotebookImageRequest req)
        {
             JsonResponseModel<CreateNotebookImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebookImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存优化模型
        /// </summary>
        /// <param name="req"><see cref="CreateOptimizedModelRequest"/></param>
        /// <returns><see cref="CreateOptimizedModelResponse"/></returns>
        public async Task<CreateOptimizedModelResponse> CreateOptimizedModel(CreateOptimizedModelRequest req)
        {
             JsonResponseModel<CreateOptimizedModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOptimizedModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOptimizedModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 保存优化模型
        /// </summary>
        /// <param name="req"><see cref="CreateOptimizedModelRequest"/></param>
        /// <returns><see cref="CreateOptimizedModelResponse"/></returns>
        public CreateOptimizedModelResponse CreateOptimizedModelSync(CreateOptimizedModelRequest req)
        {
             JsonResponseModel<CreateOptimizedModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOptimizedModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOptimizedModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public async Task<CreateTrainingModelResponse> CreateTrainingModel(CreateTrainingModelRequest req)
        {
             JsonResponseModel<CreateTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入模型
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingModelRequest"/></param>
        /// <returns><see cref="CreateTrainingModelResponse"/></returns>
        public CreateTrainingModelResponse CreateTrainingModelSync(CreateTrainingModelRequest req)
        {
             JsonResponseModel<CreateTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public async Task<CreateTrainingTaskResponse> CreateTrainingTask(CreateTrainingTaskRequest req)
        {
             JsonResponseModel<CreateTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模型训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingTaskRequest"/></param>
        /// <returns><see cref="CreateTrainingTaskResponse"/></returns>
        public CreateTrainingTaskResponse CreateTrainingTaskSync(CreateTrainingTaskRequest req)
        {
             JsonResponseModel<CreateTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除跑批任务
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchTaskRequest"/></param>
        /// <returns><see cref="DeleteBatchTaskResponse"/></returns>
        public async Task<DeleteBatchTaskResponse> DeleteBatchTask(DeleteBatchTaskRequest req)
        {
             JsonResponseModel<DeleteBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除跑批任务
        /// </summary>
        /// <param name="req"><see cref="DeleteBatchTaskRequest"/></param>
        /// <returns><see cref="DeleteBatchTaskResponse"/></returns>
        public DeleteBatchTaskResponse DeleteBatchTaskSync(DeleteBatchTaskRequest req)
        {
             JsonResponseModel<DeleteBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public async Task<DeleteDatasetResponse> DeleteDataset(DeleteDatasetRequest req)
        {
             JsonResponseModel<DeleteDatasetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据集
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasetRequest"/></param>
        /// <returns><see cref="DeleteDatasetResponse"/></returns>
        public DeleteDatasetResponse DeleteDatasetSync(DeleteDatasetRequest req)
        {
             JsonResponseModel<DeleteDatasetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型加速任务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DeleteModelAccelerateTaskResponse"/></returns>
        public async Task<DeleteModelAccelerateTaskResponse> DeleteModelAccelerateTask(DeleteModelAccelerateTaskRequest req)
        {
             JsonResponseModel<DeleteModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型加速任务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DeleteModelAccelerateTaskResponse"/></returns>
        public DeleteModelAccelerateTaskResponse DeleteModelAccelerateTaskSync(DeleteModelAccelerateTaskRequest req)
        {
             JsonResponseModel<DeleteModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据服务id删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public async Task<DeleteModelServiceResponse> DeleteModelService(DeleteModelServiceRequest req)
        {
             JsonResponseModel<DeleteModelServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据服务id删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public DeleteModelServiceResponse DeleteModelServiceSync(DeleteModelServiceRequest req)
        {
             JsonResponseModel<DeleteModelServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据服务组id删除服务组下所有模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceGroupRequest"/></param>
        /// <returns><see cref="DeleteModelServiceGroupResponse"/></returns>
        public async Task<DeleteModelServiceGroupResponse> DeleteModelServiceGroup(DeleteModelServiceGroupRequest req)
        {
             JsonResponseModel<DeleteModelServiceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModelServiceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelServiceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据服务组id删除服务组下所有模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceGroupRequest"/></param>
        /// <returns><see cref="DeleteModelServiceGroupResponse"/></returns>
        public DeleteModelServiceGroupResponse DeleteModelServiceGroupSync(DeleteModelServiceGroupRequest req)
        {
             JsonResponseModel<DeleteModelServiceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModelServiceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModelServiceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Notebook
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookRequest"/></param>
        /// <returns><see cref="DeleteNotebookResponse"/></returns>
        public async Task<DeleteNotebookResponse> DeleteNotebook(DeleteNotebookRequest req)
        {
             JsonResponseModel<DeleteNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Notebook
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookRequest"/></param>
        /// <returns><see cref="DeleteNotebookResponse"/></returns>
        public DeleteNotebookResponse DeleteNotebookSync(DeleteNotebookRequest req)
        {
             JsonResponseModel<DeleteNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookImageRecordRequest"/></param>
        /// <returns><see cref="DeleteNotebookImageRecordResponse"/></returns>
        public async Task<DeleteNotebookImageRecordResponse> DeleteNotebookImageRecord(DeleteNotebookImageRecordRequest req)
        {
             JsonResponseModel<DeleteNotebookImageRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotebookImageRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookImageRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookImageRecordRequest"/></param>
        /// <returns><see cref="DeleteNotebookImageRecordResponse"/></returns>
        public DeleteNotebookImageRecordResponse DeleteNotebookImageRecordSync(DeleteNotebookImageRecordRequest req)
        {
             JsonResponseModel<DeleteNotebookImageRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNotebookImageRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookImageRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public async Task<DeleteTrainingModelResponse> DeleteTrainingModel(DeleteTrainingModelRequest req)
        {
             JsonResponseModel<DeleteTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelResponse"/></returns>
        public DeleteTrainingModelResponse DeleteTrainingModelSync(DeleteTrainingModelRequest req)
        {
             JsonResponseModel<DeleteTrainingModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public async Task<DeleteTrainingModelVersionResponse> DeleteTrainingModelVersion(DeleteTrainingModelVersionRequest req)
        {
             JsonResponseModel<DeleteTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模型版本
        /// </summary>
        /// <param name="req"><see cref="DeleteTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DeleteTrainingModelVersionResponse"/></returns>
        public DeleteTrainingModelVersionResponse DeleteTrainingModelVersionSync(DeleteTrainingModelVersionRequest req)
        {
             JsonResponseModel<DeleteTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingModelVersionResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public async Task<DeleteTrainingTaskResponse> DeleteTrainingTask(DeleteTrainingTaskRequest req)
        {
             JsonResponseModel<DeleteTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingTaskResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteTrainingTaskRequest"/></param>
        /// <returns><see cref="DeleteTrainingTaskResponse"/></returns>
        public DeleteTrainingTaskResponse DeleteTrainingTaskSync(DeleteTrainingTaskRequest req)
        {
             JsonResponseModel<DeleteTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举API
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIConfigsRequest"/></param>
        /// <returns><see cref="DescribeAPIConfigsResponse"/></returns>
        public async Task<DescribeAPIConfigsResponse> DescribeAPIConfigs(DescribeAPIConfigsRequest req)
        {
             JsonResponseModel<DescribeAPIConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAPIConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举API
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIConfigsRequest"/></param>
        /// <returns><see cref="DescribeAPIConfigsResponse"/></returns>
        public DescribeAPIConfigsResponse DescribeAPIConfigsSync(DescribeAPIConfigsRequest req)
        {
             JsonResponseModel<DescribeAPIConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAPIConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跑批任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public async Task<DescribeBatchTaskResponse> DescribeBatchTask(DescribeBatchTaskRequest req)
        {
             JsonResponseModel<DescribeBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跑批任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskResponse"/></returns>
        public DescribeBatchTaskResponse DescribeBatchTaskSync(DescribeBatchTaskRequest req)
        {
             JsonResponseModel<DescribeBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跑批实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskInstancesResponse"/></returns>
        public async Task<DescribeBatchTaskInstancesResponse> DescribeBatchTaskInstances(DescribeBatchTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeBatchTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询跑批实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeBatchTaskInstancesResponse"/></returns>
        public DescribeBatchTaskInstancesResponse DescribeBatchTaskInstancesSync(DescribeBatchTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeBatchTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量预测任务列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTasksRequest"/></param>
        /// <returns><see cref="DescribeBatchTasksResponse"/></returns>
        public async Task<DescribeBatchTasksResponse> DescribeBatchTasks(DescribeBatchTasksRequest req)
        {
             JsonResponseModel<DescribeBatchTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量预测任务列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchTasksRequest"/></param>
        /// <returns><see cref="DescribeBatchTasksResponse"/></returns>
        public DescribeBatchTasksResponse DescribeBatchTasksSync(DescribeBatchTasksRequest req)
        {
             JsonResponseModel<DescribeBatchTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupResponse"/></returns>
        public async Task<DescribeBillingResourceGroupResponse> DescribeBillingResourceGroup(DescribeBillingResourceGroupRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupResponse"/></returns>
        public DescribeBillingResourceGroupResponse DescribeBillingResourceGroupSync(DescribeBillingResourceGroupRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public async Task<DescribeBillingResourceGroupsResponse> DescribeBillingResourceGroups(DescribeBillingResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public DescribeBillingResourceGroupsResponse DescribeBillingResourceGroupsSync(DescribeBillingResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组节点运行中的任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceInstanceRunningJobsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceInstanceRunningJobsResponse"/></returns>
        public async Task<DescribeBillingResourceInstanceRunningJobsResponse> DescribeBillingResourceInstanceRunningJobs(DescribeBillingResourceInstanceRunningJobsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceInstanceRunningJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingResourceInstanceRunningJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceInstanceRunningJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组节点运行中的任务
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceInstanceRunningJobsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceInstanceRunningJobsResponse"/></returns>
        public DescribeBillingResourceInstanceRunningJobsResponse DescribeBillingResourceInstanceRunningJobsSync(DescribeBillingResourceInstanceRunningJobsRequest req)
        {
             JsonResponseModel<DescribeBillingResourceInstanceRunningJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingResourceInstanceRunningJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingResourceInstanceRunningJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecs)用于查询计费项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsResponse"/></returns>
        public async Task<DescribeBillingSpecsResponse> DescribeBillingSpecs(DescribeBillingSpecsRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecs)用于查询计费项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsResponse"/></returns>
        public DescribeBillingSpecsResponse DescribeBillingSpecsSync(DescribeBillingSpecsRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询按量计费计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public async Task<DescribeBillingSpecsPriceResponse> DescribeBillingSpecsPrice(DescribeBillingSpecsPriceRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingSpecsPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecsPrice)用于查询按量计费计费项价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsPriceRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsPriceResponse"/></returns>
        public DescribeBillingSpecsPriceResponse DescribeBillingSpecsPriceSync(DescribeBillingSpecsPriceRequest req)
        {
             JsonResponseModel<DescribeBillingSpecsPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingSpecsPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingSpecsPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public async Task<DescribeDatasetDetailStructuredResponse> DescribeDatasetDetailStructured(DescribeDatasetDetailStructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailStructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasetDetailStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailStructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailStructuredResponse"/></returns>
        public DescribeDatasetDetailStructuredResponse DescribeDatasetDetailStructuredSync(DescribeDatasetDetailStructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailStructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasetDetailStructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailStructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public async Task<DescribeDatasetDetailUnstructuredResponse> DescribeDatasetDetailUnstructured(DescribeDatasetDetailUnstructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailUnstructuredResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasetDetailUnstructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailUnstructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询非结构化数据集详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetDetailUnstructuredRequest"/></param>
        /// <returns><see cref="DescribeDatasetDetailUnstructuredResponse"/></returns>
        public DescribeDatasetDetailUnstructuredResponse DescribeDatasetDetailUnstructuredSync(DescribeDatasetDetailUnstructuredRequest req)
        {
             JsonResponseModel<DescribeDatasetDetailUnstructuredResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasetDetailUnstructured");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetDetailUnstructuredResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public async Task<DescribeDatasetsResponse> DescribeDatasets(DescribeDatasetsRequest req)
        {
             JsonResponseModel<DescribeDatasetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据集列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasetsRequest"/></param>
        /// <returns><see cref="DescribeDatasetsResponse"/></returns>
        public DescribeDatasetsResponse DescribeDatasetsSync(DescribeDatasetsRequest req)
        {
             JsonResponseModel<DescribeDatasetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的事件API
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public async Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的事件API
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public async Task<DescribeInferTemplatesResponse> DescribeInferTemplates(DescribeInferTemplatesRequest req)
        {
             JsonResponseModel<DescribeInferTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInferTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInferTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public DescribeInferTemplatesResponse DescribeInferTemplatesSync(DescribeInferTemplatesRequest req)
        {
             JsonResponseModel<DescribeInferTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInferTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInferTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public async Task<DescribeLatestTrainingMetricsResponse> DescribeLatestTrainingMetrics(DescribeLatestTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeLatestTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLatestTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLatestTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近上报的训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeLatestTrainingMetricsResponse"/></returns>
        public DescribeLatestTrainingMetricsResponse DescribeLatestTrainingMetricsSync(DescribeLatestTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeLatestTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLatestTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLatestTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的日志API
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public async Task<DescribeLogsResponse> DescribeLogs(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务式建模训练任务，Notebook，在线服务和批量预测任务的日志API
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsRequest"/></param>
        /// <returns><see cref="DescribeLogsResponse"/></returns>
        public DescribeLogsResponse DescribeLogsSync(DescribeLogsRequest req)
        {
             JsonResponseModel<DescribeLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型加速引擎版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccEngineVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccEngineVersionsResponse"/></returns>
        public async Task<DescribeModelAccEngineVersionsResponse> DescribeModelAccEngineVersions(DescribeModelAccEngineVersionsRequest req)
        {
             JsonResponseModel<DescribeModelAccEngineVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelAccEngineVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccEngineVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型加速引擎版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccEngineVersionsRequest"/></param>
        /// <returns><see cref="DescribeModelAccEngineVersionsResponse"/></returns>
        public DescribeModelAccEngineVersionsResponse DescribeModelAccEngineVersionsSync(DescribeModelAccEngineVersionsRequest req)
        {
             JsonResponseModel<DescribeModelAccEngineVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelAccEngineVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccEngineVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型优化任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTaskResponse"/></returns>
        public async Task<DescribeModelAccelerateTaskResponse> DescribeModelAccelerateTask(DescribeModelAccelerateTaskRequest req)
        {
             JsonResponseModel<DescribeModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型优化任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTaskResponse"/></returns>
        public DescribeModelAccelerateTaskResponse DescribeModelAccelerateTaskSync(DescribeModelAccelerateTaskRequest req)
        {
             JsonResponseModel<DescribeModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型加速任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTasksRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTasksResponse"/></returns>
        public async Task<DescribeModelAccelerateTasksResponse> DescribeModelAccelerateTasks(DescribeModelAccelerateTasksRequest req)
        {
             JsonResponseModel<DescribeModelAccelerateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelAccelerateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccelerateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型加速任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelAccelerateTasksRequest"/></param>
        /// <returns><see cref="DescribeModelAccelerateTasksResponse"/></returns>
        public DescribeModelAccelerateTasksResponse DescribeModelAccelerateTasksSync(DescribeModelAccelerateTasksRequest req)
        {
             JsonResponseModel<DescribeModelAccelerateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelAccelerateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelAccelerateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public async Task<DescribeModelServiceResponse> DescribeModelService(DescribeModelServiceRequest req)
        {
             JsonResponseModel<DescribeModelServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public DescribeModelServiceResponse DescribeModelServiceSync(DescribeModelServiceRequest req)
        {
             JsonResponseModel<DescribeModelServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示服务的调用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceCallInfoRequest"/></param>
        /// <returns><see cref="DescribeModelServiceCallInfoResponse"/></returns>
        public async Task<DescribeModelServiceCallInfoResponse> DescribeModelServiceCallInfo(DescribeModelServiceCallInfoRequest req)
        {
             JsonResponseModel<DescribeModelServiceCallInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServiceCallInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceCallInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示服务的调用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceCallInfoRequest"/></param>
        /// <returns><see cref="DescribeModelServiceCallInfoResponse"/></returns>
        public DescribeModelServiceCallInfoResponse DescribeModelServiceCallInfoSync(DescribeModelServiceCallInfoRequest req)
        {
             JsonResponseModel<DescribeModelServiceCallInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServiceCallInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceCallInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupResponse"/></returns>
        public async Task<DescribeModelServiceGroupResponse> DescribeModelServiceGroup(DescribeModelServiceGroupRequest req)
        {
             JsonResponseModel<DescribeModelServiceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServiceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupResponse"/></returns>
        public DescribeModelServiceGroupResponse DescribeModelServiceGroupSync(DescribeModelServiceGroupRequest req)
        {
             JsonResponseModel<DescribeModelServiceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServiceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举在线推理服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupsRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupsResponse"/></returns>
        public async Task<DescribeModelServiceGroupsResponse> DescribeModelServiceGroups(DescribeModelServiceGroupsRequest req)
        {
             JsonResponseModel<DescribeModelServiceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServiceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举在线推理服务组
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceGroupsRequest"/></param>
        /// <returns><see cref="DescribeModelServiceGroupsResponse"/></returns>
        public DescribeModelServiceGroupsResponse DescribeModelServiceGroupsSync(DescribeModelServiceGroupsRequest req)
        {
             JsonResponseModel<DescribeModelServiceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServiceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示服务的历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHistoryRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHistoryResponse"/></returns>
        public async Task<DescribeModelServiceHistoryResponse> DescribeModelServiceHistory(DescribeModelServiceHistoryRequest req)
        {
             JsonResponseModel<DescribeModelServiceHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServiceHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示服务的历史版本
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHistoryRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHistoryResponse"/></returns>
        public DescribeModelServiceHistoryResponse DescribeModelServiceHistorySync(DescribeModelServiceHistoryRequest req)
        {
             JsonResponseModel<DescribeModelServiceHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServiceHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询模型服务能否开启热更新
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHotUpdatedRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHotUpdatedResponse"/></returns>
        public async Task<DescribeModelServiceHotUpdatedResponse> DescribeModelServiceHotUpdated(DescribeModelServiceHotUpdatedRequest req)
        {
             JsonResponseModel<DescribeModelServiceHotUpdatedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServiceHotUpdated");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceHotUpdatedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询模型服务能否开启热更新
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceHotUpdatedRequest"/></param>
        /// <returns><see cref="DescribeModelServiceHotUpdatedResponse"/></returns>
        public DescribeModelServiceHotUpdatedResponse DescribeModelServiceHotUpdatedSync(DescribeModelServiceHotUpdatedRequest req)
        {
             JsonResponseModel<DescribeModelServiceHotUpdatedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServiceHotUpdated");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServiceHotUpdatedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询多个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public async Task<DescribeModelServicesResponse> DescribeModelServices(DescribeModelServicesRequest req)
        {
             JsonResponseModel<DescribeModelServicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询多个服务
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public DescribeModelServicesResponse DescribeModelServicesSync(DescribeModelServicesRequest req)
        {
             JsonResponseModel<DescribeModelServicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Notebook详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookRequest"/></param>
        /// <returns><see cref="DescribeNotebookResponse"/></returns>
        public async Task<DescribeNotebookResponse> DescribeNotebook(DescribeNotebookRequest req)
        {
             JsonResponseModel<DescribeNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Notebook详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookRequest"/></param>
        /// <returns><see cref="DescribeNotebookResponse"/></returns>
        public DescribeNotebookResponse DescribeNotebookSync(DescribeNotebookRequest req)
        {
             JsonResponseModel<DescribeNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像kernel
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageKernelsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageKernelsResponse"/></returns>
        public async Task<DescribeNotebookImageKernelsResponse> DescribeNotebookImageKernels(DescribeNotebookImageKernelsRequest req)
        {
             JsonResponseModel<DescribeNotebookImageKernelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookImageKernels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookImageKernelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像kernel
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageKernelsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageKernelsResponse"/></returns>
        public DescribeNotebookImageKernelsResponse DescribeNotebookImageKernelsSync(DescribeNotebookImageKernelsRequest req)
        {
             JsonResponseModel<DescribeNotebookImageKernelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookImageKernels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookImageKernelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageRecordsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageRecordsResponse"/></returns>
        public async Task<DescribeNotebookImageRecordsResponse> DescribeNotebookImageRecords(DescribeNotebookImageRecordsRequest req)
        {
             JsonResponseModel<DescribeNotebookImageRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookImageRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookImageRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看notebook镜像保存记录
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookImageRecordsRequest"/></param>
        /// <returns><see cref="DescribeNotebookImageRecordsResponse"/></returns>
        public DescribeNotebookImageRecordsResponse DescribeNotebookImageRecordsSync(DescribeNotebookImageRecordsRequest req)
        {
             JsonResponseModel<DescribeNotebookImageRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookImageRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookImageRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Notebook列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebooksRequest"/></param>
        /// <returns><see cref="DescribeNotebooksResponse"/></returns>
        public async Task<DescribeNotebooksResponse> DescribeNotebooks(DescribeNotebooksRequest req)
        {
             JsonResponseModel<DescribeNotebooksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebooks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebooksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Notebook列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebooksRequest"/></param>
        /// <returns><see cref="DescribeNotebooksResponse"/></returns>
        public DescribeNotebooksResponse DescribeNotebooksSync(DescribeNotebooksRequest req)
        {
             JsonResponseModel<DescribeNotebooksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebooks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebooksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public async Task<DescribeTrainingFrameworksResponse> DescribeTrainingFrameworks(DescribeTrainingFrameworksRequest req)
        {
             JsonResponseModel<DescribeTrainingFrameworksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingFrameworks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingFrameworksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingFrameworksRequest"/></param>
        /// <returns><see cref="DescribeTrainingFrameworksResponse"/></returns>
        public DescribeTrainingFrameworksResponse DescribeTrainingFrameworksSync(DescribeTrainingFrameworksRequest req)
        {
             JsonResponseModel<DescribeTrainingFrameworksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingFrameworks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingFrameworksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public async Task<DescribeTrainingMetricsResponse> DescribeTrainingMetrics(DescribeTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingMetricsRequest"/></param>
        /// <returns><see cref="DescribeTrainingMetricsResponse"/></returns>
        public DescribeTrainingMetricsResponse DescribeTrainingMetricsSync(DescribeTrainingMetricsRequest req)
        {
             JsonResponseModel<DescribeTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public async Task<DescribeTrainingModelVersionResponse> DescribeTrainingModelVersion(DescribeTrainingModelVersionRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询模型版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionResponse"/></returns>
        public DescribeTrainingModelVersionResponse DescribeTrainingModelVersionSync(DescribeTrainingModelVersionRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public async Task<DescribeTrainingModelVersionsResponse> DescribeTrainingModelVersions(DescribeTrainingModelVersionsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModelVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelVersionsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelVersionsResponse"/></returns>
        public DescribeTrainingModelVersionsResponse DescribeTrainingModelVersionsSync(DescribeTrainingModelVersionsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModelVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public async Task<DescribeTrainingModelsResponse> DescribeTrainingModels(DescribeTrainingModelsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingModelsRequest"/></param>
        /// <returns><see cref="DescribeTrainingModelsResponse"/></returns>
        public DescribeTrainingModelsResponse DescribeTrainingModelsSync(DescribeTrainingModelsRequest req)
        {
             JsonResponseModel<DescribeTrainingModelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingModels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingModelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public async Task<DescribeTrainingTaskResponse> DescribeTrainingTask(DescribeTrainingTaskRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskResponse"/></returns>
        public DescribeTrainingTaskResponse DescribeTrainingTaskSync(DescribeTrainingTaskRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public async Task<DescribeTrainingTaskPodsResponse> DescribeTrainingTaskPods(DescribeTrainingTaskPodsRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskPodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTaskPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodsRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodsResponse"/></returns>
        public DescribeTrainingTaskPodsResponse DescribeTrainingTaskPodsSync(DescribeTrainingTaskPodsRequest req)
        {
             JsonResponseModel<DescribeTrainingTaskPodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTaskPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTaskPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public async Task<DescribeTrainingTasksResponse> DescribeTrainingTasks(DescribeTrainingTasksRequest req)
        {
             JsonResponseModel<DescribeTrainingTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 训练任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTasksRequest"/></param>
        /// <returns><see cref="DescribeTrainingTasksResponse"/></returns>
        public DescribeTrainingTasksResponse DescribeTrainingTasksSync(DescribeTrainingTasksRequest req)
        {
             JsonResponseModel<DescribeTrainingTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public async Task<ModifyModelServiceResponse> ModifyModelService(ModifyModelServiceRequest req)
        {
             JsonResponseModel<ModifyModelServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public ModifyModelServiceResponse ModifyModelServiceSync(ModifyModelServiceRequest req)
        {
             JsonResponseModel<ModifyModelServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModelService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增量更新在线推理服务的部分配置，不更新的配置项不需要传入
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServicePartialConfigRequest"/></param>
        /// <returns><see cref="ModifyModelServicePartialConfigResponse"/></returns>
        public async Task<ModifyModelServicePartialConfigResponse> ModifyModelServicePartialConfig(ModifyModelServicePartialConfigRequest req)
        {
             JsonResponseModel<ModifyModelServicePartialConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModelServicePartialConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelServicePartialConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增量更新在线推理服务的部分配置，不更新的配置项不需要传入
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServicePartialConfigRequest"/></param>
        /// <returns><see cref="ModifyModelServicePartialConfigResponse"/></returns>
        public ModifyModelServicePartialConfigResponse ModifyModelServicePartialConfigSync(ModifyModelServicePartialConfigRequest req)
        {
             JsonResponseModel<ModifyModelServicePartialConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModelServicePartialConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelServicePartialConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Notebook
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookRequest"/></param>
        /// <returns><see cref="ModifyNotebookResponse"/></returns>
        public async Task<ModifyNotebookResponse> ModifyNotebook(ModifyNotebookRequest req)
        {
             JsonResponseModel<ModifyNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Notebook
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookRequest"/></param>
        /// <returns><see cref="ModifyNotebookResponse"/></returns>
        public ModifyNotebookResponse ModifyNotebookSync(ModifyNotebookRequest req)
        {
             JsonResponseModel<ModifyNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Notebook标签
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookTagsRequest"/></param>
        /// <returns><see cref="ModifyNotebookTagsResponse"/></returns>
        public async Task<ModifyNotebookTagsResponse> ModifyNotebookTags(ModifyNotebookTagsRequest req)
        {
             JsonResponseModel<ModifyNotebookTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNotebookTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotebookTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Notebook标签
        /// </summary>
        /// <param name="req"><see cref="ModifyNotebookTagsRequest"/></param>
        /// <returns><see cref="ModifyNotebookTagsResponse"/></returns>
        public ModifyNotebookTagsResponse ModifyNotebookTagsSync(ModifyNotebookTagsRequest req)
        {
             JsonResponseModel<ModifyNotebookTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNotebookTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotebookTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新推理服务组流量分配
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceGroupWeightsRequest"/></param>
        /// <returns><see cref="ModifyServiceGroupWeightsResponse"/></returns>
        public async Task<ModifyServiceGroupWeightsResponse> ModifyServiceGroupWeights(ModifyServiceGroupWeightsRequest req)
        {
             JsonResponseModel<ModifyServiceGroupWeightsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceGroupWeights");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceGroupWeightsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新推理服务组流量分配
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceGroupWeightsRequest"/></param>
        /// <returns><see cref="ModifyServiceGroupWeightsResponse"/></returns>
        public ModifyServiceGroupWeightsResponse ModifyServiceGroupWeightsSync(ModifyServiceGroupWeightsRequest req)
        {
             JsonResponseModel<ModifyServiceGroupWeightsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceGroupWeights");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceGroupWeightsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public async Task<PushTrainingMetricsResponse> PushTrainingMetrics(PushTrainingMetricsRequest req)
        {
             JsonResponseModel<PushTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报训练自定义指标
        /// </summary>
        /// <param name="req"><see cref="PushTrainingMetricsRequest"/></param>
        /// <returns><see cref="PushTrainingMetricsResponse"/></returns>
        public PushTrainingMetricsResponse PushTrainingMetricsSync(PushTrainingMetricsRequest req)
        {
             JsonResponseModel<PushTrainingMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushTrainingMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushTrainingMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启模型加速任务
        /// </summary>
        /// <param name="req"><see cref="RestartModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="RestartModelAccelerateTaskResponse"/></returns>
        public async Task<RestartModelAccelerateTaskResponse> RestartModelAccelerateTask(RestartModelAccelerateTaskRequest req)
        {
             JsonResponseModel<RestartModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启模型加速任务
        /// </summary>
        /// <param name="req"><see cref="RestartModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="RestartModelAccelerateTaskResponse"/></returns>
        public RestartModelAccelerateTaskResponse RestartModelAccelerateTaskSync(RestartModelAccelerateTaskRequest req)
        {
             JsonResponseModel<RestartModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 这是一个供您体验大模型聊天的接口。
        /// </summary>
        /// <param name="req"><see cref="SendChatMessageRequest"/></param>
        /// <returns><see cref="SendChatMessageResponse"/></returns>
        public async Task<SendChatMessageResponse> SendChatMessage(SendChatMessageRequest req)
        {
             JsonResponseModel<SendChatMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendChatMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendChatMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 这是一个供您体验大模型聊天的接口。
        /// </summary>
        /// <param name="req"><see cref="SendChatMessageRequest"/></param>
        /// <returns><see cref="SendChatMessageResponse"/></returns>
        public SendChatMessageResponse SendChatMessageSync(SendChatMessageRequest req)
        {
             JsonResponseModel<SendChatMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendChatMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendChatMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Notebook
        /// </summary>
        /// <param name="req"><see cref="StartNotebookRequest"/></param>
        /// <returns><see cref="StartNotebookResponse"/></returns>
        public async Task<StartNotebookResponse> StartNotebook(StartNotebookRequest req)
        {
             JsonResponseModel<StartNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Notebook
        /// </summary>
        /// <param name="req"><see cref="StartNotebookRequest"/></param>
        /// <returns><see cref="StartNotebookResponse"/></returns>
        public StartNotebookResponse StartNotebookSync(StartNotebookRequest req)
        {
             JsonResponseModel<StartNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public async Task<StartTrainingTaskResponse> StartTrainingTask(StartTrainingTaskRequest req)
        {
             JsonResponseModel<StartTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StartTrainingTaskRequest"/></param>
        /// <returns><see cref="StartTrainingTaskResponse"/></returns>
        public StartTrainingTaskResponse StartTrainingTaskSync(StartTrainingTaskRequest req)
        {
             JsonResponseModel<StartTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止跑批任务
        /// </summary>
        /// <param name="req"><see cref="StopBatchTaskRequest"/></param>
        /// <returns><see cref="StopBatchTaskResponse"/></returns>
        public async Task<StopBatchTaskResponse> StopBatchTask(StopBatchTaskRequest req)
        {
             JsonResponseModel<StopBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止跑批任务
        /// </summary>
        /// <param name="req"><see cref="StopBatchTaskRequest"/></param>
        /// <returns><see cref="StopBatchTaskResponse"/></returns>
        public StopBatchTaskResponse StopBatchTaskSync(StopBatchTaskRequest req)
        {
             JsonResponseModel<StopBatchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopBatchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopBatchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止保存镜像
        /// </summary>
        /// <param name="req"><see cref="StopCreatingImageRequest"/></param>
        /// <returns><see cref="StopCreatingImageResponse"/></returns>
        public async Task<StopCreatingImageResponse> StopCreatingImage(StopCreatingImageRequest req)
        {
             JsonResponseModel<StopCreatingImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopCreatingImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCreatingImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止保存镜像
        /// </summary>
        /// <param name="req"><see cref="StopCreatingImageRequest"/></param>
        /// <returns><see cref="StopCreatingImageResponse"/></returns>
        public StopCreatingImageResponse StopCreatingImageSync(StopCreatingImageRequest req)
        {
             JsonResponseModel<StopCreatingImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopCreatingImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCreatingImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型加速任务
        /// </summary>
        /// <param name="req"><see cref="StopModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="StopModelAccelerateTaskResponse"/></returns>
        public async Task<StopModelAccelerateTaskResponse> StopModelAccelerateTask(StopModelAccelerateTaskRequest req)
        {
             JsonResponseModel<StopModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型加速任务
        /// </summary>
        /// <param name="req"><see cref="StopModelAccelerateTaskRequest"/></param>
        /// <returns><see cref="StopModelAccelerateTaskResponse"/></returns>
        public StopModelAccelerateTaskResponse StopModelAccelerateTaskSync(StopModelAccelerateTaskRequest req)
        {
             JsonResponseModel<StopModelAccelerateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopModelAccelerateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopModelAccelerateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止Notebook
        /// </summary>
        /// <param name="req"><see cref="StopNotebookRequest"/></param>
        /// <returns><see cref="StopNotebookResponse"/></returns>
        public async Task<StopNotebookResponse> StopNotebook(StopNotebookRequest req)
        {
             JsonResponseModel<StopNotebookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止Notebook
        /// </summary>
        /// <param name="req"><see cref="StopNotebookRequest"/></param>
        /// <returns><see cref="StopNotebookResponse"/></returns>
        public StopNotebookResponse StopNotebookSync(StopNotebookRequest req)
        {
             JsonResponseModel<StopNotebookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopNotebook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNotebookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public async Task<StopTrainingTaskResponse> StopTrainingTask(StopTrainingTaskRequest req)
        {
             JsonResponseModel<StopTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止模型训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingTaskRequest"/></param>
        /// <returns><see cref="StopTrainingTaskResponse"/></returns>
        public StopTrainingTaskResponse StopTrainingTaskSync(StopTrainingTaskRequest req)
        {
             JsonResponseModel<StopTrainingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopTrainingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
