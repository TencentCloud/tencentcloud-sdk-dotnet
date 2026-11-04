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
       private const string sdkVersion = "SDK_NET_3.0.1534";

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
        /// 
        /// 使用该接口调用时需要携带腾讯云的密钥信息用于身份信息鉴权，建议通过腾讯云的云 API SDK调用，具体可以参考
        /// https://cloud.tencent.com/document/product/1278/85305
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public Task<ChatCompletionResponse> ChatCompletion(ChatCompletionRequest req)
        {
            return InternalRequestAsync<ChatCompletionResponse>(req, "ChatCompletion");
        }

        /// <summary>
        /// 该接口支持与自行部署的大模型的聊天。
        /// 
        /// 使用该接口调用时需要携带腾讯云的密钥信息用于身份信息鉴权，建议通过腾讯云的云 API SDK调用，具体可以参考
        /// https://cloud.tencent.com/document/product/1278/85305
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionRequest"/></param>
        /// <returns><see cref="ChatCompletionResponse"/></returns>
        public ChatCompletionResponse ChatCompletionSync(ChatCompletionRequest req)
        {
            return InternalRequestAsync<ChatCompletionResponse>(req, "ChatCompletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource");
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
            return InternalRequestAsync<CreateDataSourceResponse>(req, "CreateDataSource")
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
        /// 创建任务式建模训练任务，Notebook，在线服务和批量预测任务日志下载任务API
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport");
        }

        /// <summary>
        /// 创建任务式建模训练任务，Notebook，在线服务和批量预测任务日志下载任务API
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport")
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
        /// 创建一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="CreateModelServiceAuthTokenResponse"/></returns>
        public Task<CreateModelServiceAuthTokenResponse> CreateModelServiceAuthToken(CreateModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<CreateModelServiceAuthTokenResponse>(req, "CreateModelServiceAuthToken");
        }

        /// <summary>
        /// 创建一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="CreateModelServiceAuthTokenResponse"/></returns>
        public CreateModelServiceAuthTokenResponse CreateModelServiceAuthTokenSync(CreateModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<CreateModelServiceAuthTokenResponse>(req, "CreateModelServiceAuthToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建挂载限制
        /// </summary>
        /// <param name="req"><see cref="CreateMountLimitRequest"/></param>
        /// <returns><see cref="CreateMountLimitResponse"/></returns>
        public Task<CreateMountLimitResponse> CreateMountLimit(CreateMountLimitRequest req)
        {
            return InternalRequestAsync<CreateMountLimitResponse>(req, "CreateMountLimit");
        }

        /// <summary>
        /// 创建挂载限制
        /// </summary>
        /// <param name="req"><see cref="CreateMountLimitRequest"/></param>
        /// <returns><see cref="CreateMountLimitResponse"/></returns>
        public CreateMountLimitResponse CreateMountLimitSync(CreateMountLimitRequest req)
        {
            return InternalRequestAsync<CreateMountLimitResponse>(req, "CreateMountLimit")
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
        /// 创建自定义角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// 创建自定义角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
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
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourceRequest"/></param>
        /// <returns><see cref="DeleteDataSourceResponse"/></returns>
        public Task<DeleteDataSourceResponse> DeleteDataSource(DeleteDataSourceRequest req)
        {
            return InternalRequestAsync<DeleteDataSourceResponse>(req, "DeleteDataSource");
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourceRequest"/></param>
        /// <returns><see cref="DeleteDataSourceResponse"/></returns>
        public DeleteDataSourceResponse DeleteDataSourceSync(DeleteDataSourceRequest req)
        {
            return InternalRequestAsync<DeleteDataSourceResponse>(req, "DeleteDataSource")
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
        /// 删除任务式建模训练任务，Notebook，在线服务和批量预测任务日志导出任务API
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public Task<DeleteExportResponse> DeleteExport(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport");
        }

        /// <summary>
        /// 删除任务式建模训练任务，Notebook，在线服务和批量预测任务日志导出任务API
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public DeleteExportResponse DeleteExportSync(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport")
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
        /// 删除一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="DeleteModelServiceAuthTokenResponse"/></returns>
        public Task<DeleteModelServiceAuthTokenResponse> DeleteModelServiceAuthToken(DeleteModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceAuthTokenResponse>(req, "DeleteModelServiceAuthToken");
        }

        /// <summary>
        /// 删除一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="DeleteModelServiceAuthTokenResponse"/></returns>
        public DeleteModelServiceAuthTokenResponse DeleteModelServiceAuthTokenSync(DeleteModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceAuthTokenResponse>(req, "DeleteModelServiceAuthToken")
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
        /// 删除挂载限制。注意：删除挂载限制后，该存储对应的所有数据源也会被删除
        /// </summary>
        /// <param name="req"><see cref="DeleteMountLimitRequest"/></param>
        /// <returns><see cref="DeleteMountLimitResponse"/></returns>
        public Task<DeleteMountLimitResponse> DeleteMountLimit(DeleteMountLimitRequest req)
        {
            return InternalRequestAsync<DeleteMountLimitResponse>(req, "DeleteMountLimit");
        }

        /// <summary>
        /// 删除挂载限制。注意：删除挂载限制后，该存储对应的所有数据源也会被删除
        /// </summary>
        /// <param name="req"><see cref="DeleteMountLimitRequest"/></param>
        /// <returns><see cref="DeleteMountLimitResponse"/></returns>
        public DeleteMountLimitResponse DeleteMountLimitSync(DeleteMountLimitRequest req)
        {
            return InternalRequestAsync<DeleteMountLimitResponse>(req, "DeleteMountLimit")
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
        /// 删除权限角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole");
        }

        /// <summary>
        /// 删除权限角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole")
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
        /// 列取访问权限规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public Task<DescribeAccessRulesResponse> DescribeAccessRules(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules");
        }

        /// <summary>
        /// 列取访问权限规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public DescribeAccessRulesResponse DescribeAccessRulesSync(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAnnotatedTaskList）用于查询用户标注任务详细信息列表；支持各种过滤条件；
        /// </summary>
        /// <param name="req"><see cref="DescribeAnnotatedTaskListRequest"/></param>
        /// <returns><see cref="DescribeAnnotatedTaskListResponse"/></returns>
        public Task<DescribeAnnotatedTaskListResponse> DescribeAnnotatedTaskList(DescribeAnnotatedTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAnnotatedTaskListResponse>(req, "DescribeAnnotatedTaskList");
        }

        /// <summary>
        /// 本接口（DescribeAnnotatedTaskList）用于查询用户标注任务详细信息列表；支持各种过滤条件；
        /// </summary>
        /// <param name="req"><see cref="DescribeAnnotatedTaskListRequest"/></param>
        /// <returns><see cref="DescribeAnnotatedTaskListResponse"/></returns>
        public DescribeAnnotatedTaskListResponse DescribeAnnotatedTaskListSync(DescribeAnnotatedTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAnnotatedTaskListResponse>(req, "DescribeAnnotatedTaskList")
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
        /// 查询资源组关联的工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupAttachedWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupAttachedWorkspacesResponse"/></returns>
        public Task<DescribeBillingResourceGroupAttachedWorkspacesResponse> DescribeBillingResourceGroupAttachedWorkspaces(DescribeBillingResourceGroupAttachedWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupAttachedWorkspacesResponse>(req, "DescribeBillingResourceGroupAttachedWorkspaces");
        }

        /// <summary>
        /// 查询资源组关联的工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupAttachedWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupAttachedWorkspacesResponse"/></returns>
        public DescribeBillingResourceGroupAttachedWorkspacesResponse DescribeBillingResourceGroupAttachedWorkspacesSync(DescribeBillingResourceGroupAttachedWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupAttachedWorkspacesResponse>(req, "DescribeBillingResourceGroupAttachedWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeBillingResourceGroupsResponse"/></returns>
        public Task<DescribeBillingResourceGroupsResponse> DescribeBillingResourceGroups(DescribeBillingResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeBillingResourceGroupsResponse>(req, "DescribeBillingResourceGroups");
        }

        /// <summary>
        /// 查询资源组列表
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
        /// 本接口(DescribeBillingSpecs) 提供查询计费项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingSpecsRequest"/></param>
        /// <returns><see cref="DescribeBillingSpecsResponse"/></returns>
        public Task<DescribeBillingSpecsResponse> DescribeBillingSpecs(DescribeBillingSpecsRequest req)
        {
            return InternalRequestAsync<DescribeBillingSpecsResponse>(req, "DescribeBillingSpecs");
        }

        /// <summary>
        /// 本接口(DescribeBillingSpecs) 提供查询计费项列表
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
        /// 获取数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceRequest"/></param>
        /// <returns><see cref="DescribeDataSourceResponse"/></returns>
        public Task<DescribeDataSourceResponse> DescribeDataSource(DescribeDataSourceRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceResponse>(req, "DescribeDataSource");
        }

        /// <summary>
        /// 获取数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceRequest"/></param>
        /// <returns><see cref="DescribeDataSourceResponse"/></returns>
        public DescribeDataSourceResponse DescribeDataSourceSync(DescribeDataSourceRequest req)
        {
            return InternalRequestAsync<DescribeDataSourceResponse>(req, "DescribeDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeDataSourcesResponse"/></returns>
        public Task<DescribeDataSourcesResponse> DescribeDataSources(DescribeDataSourcesRequest req)
        {
            return InternalRequestAsync<DescribeDataSourcesResponse>(req, "DescribeDataSources");
        }

        /// <summary>
        /// 获取数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourcesRequest"/></param>
        /// <returns><see cref="DescribeDataSourcesResponse"/></returns>
        public DescribeDataSourcesResponse DescribeDataSourcesSync(DescribeDataSourcesRequest req)
        {
            return InternalRequestAsync<DescribeDataSourcesResponse>(req, "DescribeDataSources")
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
        /// 查看任务式建模训练任务，Notebook，在线服务和批量预测任务日志下载任务状态API
        /// </summary>
        /// <param name="req"><see cref="DescribeExportRequest"/></param>
        /// <returns><see cref="DescribeExportResponse"/></returns>
        public Task<DescribeExportResponse> DescribeExport(DescribeExportRequest req)
        {
            return InternalRequestAsync<DescribeExportResponse>(req, "DescribeExport");
        }

        /// <summary>
        /// 查看任务式建模训练任务，Notebook，在线服务和批量预测任务日志下载任务状态API
        /// </summary>
        /// <param name="req"><see cref="DescribeExportRequest"/></param>
        /// <returns><see cref="DescribeExportResponse"/></returns>
        public DescribeExportResponse DescribeExportSync(DescribeExportRequest req)
        {
            return InternalRequestAsync<DescribeExportResponse>(req, "DescribeExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已废弃，收敛到统一接口
        /// 
        /// 查询推理镜像模板
        /// </summary>
        /// <param name="req"><see cref="DescribeInferTemplatesRequest"/></param>
        /// <returns><see cref="DescribeInferTemplatesResponse"/></returns>
        public Task<DescribeInferTemplatesResponse> DescribeInferTemplates(DescribeInferTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeInferTemplatesResponse>(req, "DescribeInferTemplates");
        }

        /// <summary>
        /// 已废弃，收敛到统一接口
        /// 
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
        /// DescribeMountInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeMountInstanceRequest"/></param>
        /// <returns><see cref="DescribeMountInstanceResponse"/></returns>
        public Task<DescribeMountInstanceResponse> DescribeMountInstance(DescribeMountInstanceRequest req)
        {
            return InternalRequestAsync<DescribeMountInstanceResponse>(req, "DescribeMountInstance");
        }

        /// <summary>
        /// DescribeMountInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeMountInstanceRequest"/></param>
        /// <returns><see cref="DescribeMountInstanceResponse"/></returns>
        public DescribeMountInstanceResponse DescribeMountInstanceSync(DescribeMountInstanceRequest req)
        {
            return InternalRequestAsync<DescribeMountInstanceResponse>(req, "DescribeMountInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 非数据源挂载时获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMountInstancesRequest"/></param>
        /// <returns><see cref="DescribeMountInstancesResponse"/></returns>
        public Task<DescribeMountInstancesResponse> DescribeMountInstances(DescribeMountInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMountInstancesResponse>(req, "DescribeMountInstances");
        }

        /// <summary>
        /// 非数据源挂载时获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMountInstancesRequest"/></param>
        /// <returns><see cref="DescribeMountInstancesResponse"/></returns>
        public DescribeMountInstancesResponse DescribeMountInstancesSync(DescribeMountInstancesRequest req)
        {
            return InternalRequestAsync<DescribeMountInstancesResponse>(req, "DescribeMountInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取挂载限制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMountLimitsRequest"/></param>
        /// <returns><see cref="DescribeMountLimitsResponse"/></returns>
        public Task<DescribeMountLimitsResponse> DescribeMountLimits(DescribeMountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeMountLimitsResponse>(req, "DescribeMountLimits");
        }

        /// <summary>
        /// 获取挂载限制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMountLimitsRequest"/></param>
        /// <returns><see cref="DescribeMountLimitsResponse"/></returns>
        public DescribeMountLimitsResponse DescribeMountLimitsSync(DescribeMountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeMountLimitsResponse>(req, "DescribeMountLimits")
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
        /// 查询平台镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribePlatformImagesRequest"/></param>
        /// <returns><see cref="DescribePlatformImagesResponse"/></returns>
        public Task<DescribePlatformImagesResponse> DescribePlatformImages(DescribePlatformImagesRequest req)
        {
            return InternalRequestAsync<DescribePlatformImagesResponse>(req, "DescribePlatformImages");
        }

        /// <summary>
        /// 查询平台镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribePlatformImagesRequest"/></param>
        /// <returns><see cref="DescribePlatformImagesResponse"/></returns>
        public DescribePlatformImagesResponse DescribePlatformImagesSync(DescribePlatformImagesRequest req)
        {
            return InternalRequestAsync<DescribePlatformImagesResponse>(req, "DescribePlatformImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询内置镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetImageListRequest"/></param>
        /// <returns><see cref="DescribePresetImageListResponse"/></returns>
        public Task<DescribePresetImageListResponse> DescribePresetImageList(DescribePresetImageListRequest req)
        {
            return InternalRequestAsync<DescribePresetImageListResponse>(req, "DescribePresetImageList");
        }

        /// <summary>
        /// 该接口用于查询内置镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetImageListRequest"/></param>
        /// <returns><see cref="DescribePresetImageListResponse"/></returns>
        public DescribePresetImageListResponse DescribePresetImageListSync(DescribePresetImageListRequest req)
        {
            return InternalRequestAsync<DescribePresetImageListResponse>(req, "DescribePresetImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 公共算法版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicAlgoVersionListRequest"/></param>
        /// <returns><see cref="DescribePublicAlgoVersionListResponse"/></returns>
        public Task<DescribePublicAlgoVersionListResponse> DescribePublicAlgoVersionList(DescribePublicAlgoVersionListRequest req)
        {
            return InternalRequestAsync<DescribePublicAlgoVersionListResponse>(req, "DescribePublicAlgoVersionList");
        }

        /// <summary>
        /// 公共算法版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicAlgoVersionListRequest"/></param>
        /// <returns><see cref="DescribePublicAlgoVersionListResponse"/></returns>
        public DescribePublicAlgoVersionListResponse DescribePublicAlgoVersionListSync(DescribePublicAlgoVersionListRequest req)
        {
            return InternalRequestAsync<DescribePublicAlgoVersionListResponse>(req, "DescribePublicAlgoVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleRequest"/></param>
        /// <returns><see cref="DescribeRoleResponse"/></returns>
        public Task<DescribeRoleResponse> DescribeRole(DescribeRoleRequest req)
        {
            return InternalRequestAsync<DescribeRoleResponse>(req, "DescribeRole");
        }

        /// <summary>
        /// 获取角色详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleRequest"/></param>
        /// <returns><see cref="DescribeRoleResponse"/></returns>
        public DescribeRoleResponse DescribeRoleSync(DescribeRoleRequest req)
        {
            return InternalRequestAsync<DescribeRoleResponse>(req, "DescribeRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色下已授权的用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleUsersRequest"/></param>
        /// <returns><see cref="DescribeRoleUsersResponse"/></returns>
        public Task<DescribeRoleUsersResponse> DescribeRoleUsers(DescribeRoleUsersRequest req)
        {
            return InternalRequestAsync<DescribeRoleUsersResponse>(req, "DescribeRoleUsers");
        }

        /// <summary>
        /// 获取角色下已授权的用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleUsersRequest"/></param>
        /// <returns><see cref="DescribeRoleUsersResponse"/></returns>
        public DescribeRoleUsersResponse DescribeRoleUsersSync(DescribeRoleUsersRequest req)
        {
            return InternalRequestAsync<DescribeRoleUsersResponse>(req, "DescribeRoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public Task<DescribeRolesResponse> DescribeRoles(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles");
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public DescribeRolesResponse DescribeRolesSync(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询子账号Linux用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountLinuxUserInfosRequest"/></param>
        /// <returns><see cref="DescribeSubAccountLinuxUserInfosResponse"/></returns>
        public Task<DescribeSubAccountLinuxUserInfosResponse> DescribeSubAccountLinuxUserInfos(DescribeSubAccountLinuxUserInfosRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountLinuxUserInfosResponse>(req, "DescribeSubAccountLinuxUserInfos");
        }

        /// <summary>
        /// 批量查询子账号Linux用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountLinuxUserInfosRequest"/></param>
        /// <returns><see cref="DescribeSubAccountLinuxUserInfosResponse"/></returns>
        public DescribeSubAccountLinuxUserInfosResponse DescribeSubAccountLinuxUserInfosSync(DescribeSubAccountLinuxUserInfosRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountLinuxUserInfosResponse>(req, "DescribeSubAccountLinuxUserInfos")
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
        /// 获取单个训练任务实例的登录链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodUrlRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodUrlResponse"/></returns>
        public Task<DescribeTrainingTaskPodUrlResponse> DescribeTrainingTaskPodUrl(DescribeTrainingTaskPodUrlRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskPodUrlResponse>(req, "DescribeTrainingTaskPodUrl");
        }

        /// <summary>
        /// 获取单个训练任务实例的登录链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingTaskPodUrlRequest"/></param>
        /// <returns><see cref="DescribeTrainingTaskPodUrlResponse"/></returns>
        public DescribeTrainingTaskPodUrlResponse DescribeTrainingTaskPodUrlSync(DescribeTrainingTaskPodUrlRequest req)
        {
            return InternalRequestAsync<DescribeTrainingTaskPodUrlResponse>(req, "DescribeTrainingTaskPodUrl")
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
        /// 查询工作空间详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceResponse"/></returns>
        public Task<DescribeWorkspaceResponse> DescribeWorkspace(DescribeWorkspaceRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceResponse>(req, "DescribeWorkspace");
        }

        /// <summary>
        /// 查询工作空间详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceResponse"/></returns>
        public DescribeWorkspaceResponse DescribeWorkspaceSync(DescribeWorkspaceRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceResponse>(req, "DescribeWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询空间成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceMembersRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceMembersResponse"/></returns>
        public Task<DescribeWorkspaceMembersResponse> DescribeWorkspaceMembers(DescribeWorkspaceMembersRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceMembersResponse>(req, "DescribeWorkspaceMembers");
        }

        /// <summary>
        /// 查询空间成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceMembersRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceMembersResponse"/></returns>
        public DescribeWorkspaceMembersResponse DescribeWorkspaceMembersSync(DescribeWorkspaceMembersRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceMembersResponse>(req, "DescribeWorkspaceMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ## DescribeWorkspaceQuotaUsage 接口文档
        /// 
        /// ### 接口描述
        /// 查询工作空间配额用量信息。该接口用于查询指定工作空间下某个子账号的配额使用情况，支持多种配额类型（CBS存储配额、Notebook开发机数量配额、托管按量资源规格限制）。
        /// 
        /// ### 错误码
        /// 
        /// | 错误码 | 说明 |
        /// |--------|------|
        /// | InvalidParameterValue | 参数值无效（如必填参数为空、QuotaType不在枚举范围内） |
        /// | FailedOperation.QueryDatabaseFail | 数据库查询失败 |
        /// 
        /// ### 示例
        /// 
        /// **请求示例**：
        /// ```json
        /// {
        ///   "QuotaType": "Notebook",
        ///   "SupervisorUin": "100012345678",
        ///   "SupervisorSubUin": "100012345679",
        ///   "TiProjectId": "ti-proj-123456"
        /// }
        /// ```
        /// 
        /// **响应示例**：
        /// ```json
        /// {
        ///   "QuotaType": "Notebook",
        ///   "QuotaEnabled": true,
        ///   "TotalQuota": 10,
        ///   "UsedQuota": 3,
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceQuotaUsageResponse"/></returns>
        public Task<DescribeWorkspaceQuotaUsageResponse> DescribeWorkspaceQuotaUsage(DescribeWorkspaceQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceQuotaUsageResponse>(req, "DescribeWorkspaceQuotaUsage");
        }

        /// <summary>
        /// ## DescribeWorkspaceQuotaUsage 接口文档
        /// 
        /// ### 接口描述
        /// 查询工作空间配额用量信息。该接口用于查询指定工作空间下某个子账号的配额使用情况，支持多种配额类型（CBS存储配额、Notebook开发机数量配额、托管按量资源规格限制）。
        /// 
        /// ### 错误码
        /// 
        /// | 错误码 | 说明 |
        /// |--------|------|
        /// | InvalidParameterValue | 参数值无效（如必填参数为空、QuotaType不在枚举范围内） |
        /// | FailedOperation.QueryDatabaseFail | 数据库查询失败 |
        /// 
        /// ### 示例
        /// 
        /// **请求示例**：
        /// ```json
        /// {
        ///   "QuotaType": "Notebook",
        ///   "SupervisorUin": "100012345678",
        ///   "SupervisorSubUin": "100012345679",
        ///   "TiProjectId": "ti-proj-123456"
        /// }
        /// ```
        /// 
        /// **响应示例**：
        /// ```json
        /// {
        ///   "QuotaType": "Notebook",
        ///   "QuotaEnabled": true,
        ///   "TotalQuota": 10,
        ///   "UsedQuota": 3,
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceQuotaUsageResponse"/></returns>
        public DescribeWorkspaceQuotaUsageResponse DescribeWorkspaceQuotaUsageSync(DescribeWorkspaceQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceQuotaUsageResponse>(req, "DescribeWorkspaceQuotaUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// # DescribeWorkspaceQuotas 接口文档
        /// 
        /// ## 接口描述
        /// 
        /// 查询指定工作空间下的配额配置和配额列表。该接口用于获取主账号在某个工作空间下的配额管理配置，包括是否启用配额管理、默认配额值以及针对子账号或用户组的具体配额分配情况。
        /// 
        /// 支持三种配额类型：
        /// - **CBS**：CBS存储配额管理
        /// - **Notebook**：开发机数量配额管理
        /// - **PostPaySpec**：托管按量资源规格限制
        /// 
        /// 
        /// 
        /// ## 请求参数
        /// 
        /// ### 公共参数（HTTP Header）
        /// | 参数名 | 类型 | 必填 | 描述 |
        /// |--------|------|------|------|
        /// | X-TC-Uin | string | 是 | 主账号Uin |
        /// | X-TC-ProjectId | uint32 | 是 | 工作空间ID |
        /// 
        /// ### 请求体参数
        /// | 参数名 | 类型 | 必填 | 描述 |
        /// |--------|------|------|------|
        /// | QuotaType | string | 是 | 配额类型，可选值：<br>- `CBS`：CBS存储配额<br>- `Notebook`：开发机数量配额<br>- `PostPaySpec`：托管按量资源规格限制 |
        /// 
        /// ## 响应参数
        /// 
        /// | 参数名 | 类型 | 描述 |
        /// |--------|------|------|
        /// | QuotaType | string | 配额类型 |
        /// | QuotaEnabled | bool | 是否启用配额管理功能 |
        /// | DefaultQuota | WorkspaceQuota | 默认配额配置（当QuotaEnabled为false时为空对象） |
        /// | Quotas | ][WorkspaceQuota | 配额列表，包含所有子账号或用户组的配额配置（仅当QuotaEnabled为true时返回） |
        /// 
        /// ### WorkspaceQuota
        /// 
        /// | 参数名 | 类型 | 描述 |
        /// |--------|------|------|
        /// | Id | string | 配额ID，格式：<br>- 用户配额：`{quota_type}-{uin}-{subuin}-{TiProjectId}`<br>- 用户组配额：`{quota_type}-{uin}-{groupid}-{TiProjectId}`<br>- 默认配额：`{quota_type}-{uin}-default-{TiProjectId}` |
        /// | QuotaType | string | 配额类型 |
        /// | Uin | string | 主账号Uin |
        /// | SubUin | string | 子账号Uin（当TargetType为USER时有值） |
        /// | SubUinName | string | 子账号名称（当TargetType为USER时有值） |
        /// | QuotaValue | uint32 | 配额值：<br>- CBS：容量（GiB），默认100，范围10-10000<br>- Notebook：数量（个），默认1，范围1-999<br>- PostPaySpec：无意义，关注QuotaData字段 |
        /// | QuotaData | []string | 配额数据（JSON数组格式）：<br>- 当QuotaType为PostPaySpec时，存储允许使用的规格ID列表 |
        /// | TargetType | string | 配额目标类型：<br>- `USER`：用户配额<br>- `USER_GROUP`：用户组配额 |
        /// | GroupId | string | 用户组ID（当TargetType为USER_GROUP时有值） |
        /// | GroupName | string | 用户组名称（当TargetType为USER_GROUP时有值） |
        /// | TiProjectId | string | 工作空间ID |
        /// 
        /// ## 业务逻辑
        /// 
        /// 1. **参数校验**：验证QuotaType参数是否合法
        /// 2. **查询配额配置**：根据主账号Uin、工作空间ID和配额类型查询配额配置
        /// 3. **配置不存在**：
        ///    - 返回系统默认的配额启用状态和默认配额值
        ///    - CBS默认启用，默认值100GiB
        ///    - Notebook默认启用，默认值1个
        ///    - PostPaySpec默认不启用
        /// 4. **配置存在但未启用**：
        ///    - QuotaEnabled返回false
        ///    - DefaultQuota返回空对象
        ///    - Quotas不返回
        /// 5. **配置存在且已启用**：
        ///    - QuotaEnabled返回true
        ///    - DefaultQuota返回配置的默认配额值
        ///    - Quotas返回所有子账号或用户组的配额列表
        ///    - 自动反序列化QuotaData字段（JSON数组）
        /// 
        /// ## 使用场景
        /// 
        /// 1. **配额管理页面初始化**：获取当前工作空间的配额配置状态
        /// 2. **配额列表展示**：展示所有子账号或用户组的配额分配情况
        /// 3. **配额编辑前查询**：在修改配额前获取当前配置
        /// 4. **权限控制判断**：判断是否启用了配额管理功能
        /// 
        /// ## 错误码
        /// 
        /// | 错误码 | 描述 | 解决方案 |
        /// |--------|------|----------|
        /// | InvalidParameterValue | 参数值错误 | 检查QuotaType参数是否为合法值（CBS/Notebook/PostPaySpec） |
        /// | FailedOperation.QueryDatabaseFail | 数据库查询失败 | 稍后重试或联系管理员 |
        /// 
        /// ## 请求示例
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "CBS"
        /// }
        /// ```
        /// 
        /// **HTTP Header:**
        /// ```
        /// X-TC-Uin: 100012345678
        /// X-TC-ProjectId: 123456
        /// ```
        /// 
        /// ## 响应示例
        /// 
        /// ### 示例1：配额已启用且有配额列表
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "CBS",
        ///   "QuotaEnabled": true,
        ///   "DefaultQuota": {
        ///     "Id": "CBS-100012345678-default-123456",
        ///     "QuotaType": "CBS",
        ///     "Uin": "100012345678",
        ///     "SubUin": "",
        ///     "SubUinName": "",
        ///     "QuotaValue": 100,
        ///     "QuotaData": [],
        ///     "TargetType": "",
        ///     "GroupId": "",
        ///     "GroupName": "",
        ///     "TiProjectId": "123456"
        ///   },
        ///   "Quotas": [
        ///     {
        ///       "Id": "CBS-100012345678-100012345679-123456",
        ///       "QuotaType": "CBS",
        ///       "Uin": "100012345678",
        ///       "SubUin": "100012345679",
        ///       "SubUinName": "张三",
        ///       "QuotaValue": 200,
        ///       "QuotaData": [],
        ///       "TargetType": "USER",
        ///       "GroupId": "",
        ///       "GroupName": "",
        ///       "TiProjectId": "123456"
        ///     },
        ///     {
        ///       "Id": "CBS-100012345678-group001-123456",
        ///       "QuotaType": "CBS",
        ///       "Uin": "100012345678",
        ///       "SubUin": "",
        ///       "SubUinName": "",
        ///       "QuotaValue": 500,
        ///       "QuotaData": [],
        ///       "TargetType": "USER_GROUP",
        ///       "GroupId": "group001",
        ///       "GroupName": "开发组",
        ///       "TiProjectId": "123456"
        ///     }
        ///   ]
        /// }
        /// ```
        /// 
        /// ### 示例2：配额未启用
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "PostPaySpec",
        ///   "QuotaEnabled": false,
        ///   "DefaultQuota": {},
        ///   "Quotas": []
        /// }
        /// ```
        /// 
        /// ### 示例3：PostPaySpec类型配额（带QuotaData）
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "PostPaySpec",
        ///   "QuotaEnabled": true,
        ///   "DefaultQuota": {
        ///     "Id": "PostPaySpec-100012345678-default-123456",
        ///     "QuotaType": "PostPaySpec",
        ///     "Uin": "100012345678",
        ///     "SubUin": "",
        ///     "SubUinName": "",
        ///     "QuotaValue": 0,
        ///     "QuotaData": ["spec-001", "spec-002", "spec-003"],
        ///     "TargetType": "",
        ///     "GroupId": "",
        ///     "GroupName": "",
        ///     "TiProjectId": "123456"
        ///   },
        ///   "Quotas": [
        ///     {
        ///       "Id": "PostPaySpec-100012345678-100012345679-123456",
        ///       "QuotaType": "PostPaySpec",
        ///       "Uin": "100012345678",
        ///       "SubUin": "100012345679",
        ///       "SubUinName": "李四",
        ///       "QuotaValue": 0,
        ///       "QuotaData": ["spec-001", "spec-002"],
        ///       "TargetType": "USER",
        ///       "GroupId": "",
        ///       "GroupName": "",
        ///       "TiProjectId": "123456"
        ///     }
        ///   ]
        /// }
        /// ```
        /// 
        /// ## 注意事项
        /// 
        /// 1. **配额继承规则**：
        ///    - 如果子账号或用户组没有单独配置配额，则使用DefaultQuota的值
        ///    - 用户组配额优先级高于默认配额，用户配额优先级最高
        /// 
        /// 2. **QuotaData字段**：
        ///    - 仅在QuotaType为PostPaySpec时有实际意义
        ///    - 存储的是允许使用的规格ID列表
        ///    - 其他类型的配额该字段为空数组
        /// 
        /// 3. **TargetType字段**：
        ///    - DefaultQuota的TargetType为空字符串
        ///    - Quotas列表中的每个配额都有明确的TargetType
        /// 
        /// 4. **配额值单位**：
        ///    - CBS配额：GiB（1 GiB = 1024 MiB）
        ///    - Notebook配额：个数
        /// 
        /// 5. **性能优化**：
        ///    - 接口会一次性返回所有配额列表，避免多次查询
        ///    - 建议前端做好缓存，减少重复请求
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceQuotasRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceQuotasResponse"/></returns>
        public Task<DescribeWorkspaceQuotasResponse> DescribeWorkspaceQuotas(DescribeWorkspaceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceQuotasResponse>(req, "DescribeWorkspaceQuotas");
        }

        /// <summary>
        /// # DescribeWorkspaceQuotas 接口文档
        /// 
        /// ## 接口描述
        /// 
        /// 查询指定工作空间下的配额配置和配额列表。该接口用于获取主账号在某个工作空间下的配额管理配置，包括是否启用配额管理、默认配额值以及针对子账号或用户组的具体配额分配情况。
        /// 
        /// 支持三种配额类型：
        /// - **CBS**：CBS存储配额管理
        /// - **Notebook**：开发机数量配额管理
        /// - **PostPaySpec**：托管按量资源规格限制
        /// 
        /// 
        /// 
        /// ## 请求参数
        /// 
        /// ### 公共参数（HTTP Header）
        /// | 参数名 | 类型 | 必填 | 描述 |
        /// |--------|------|------|------|
        /// | X-TC-Uin | string | 是 | 主账号Uin |
        /// | X-TC-ProjectId | uint32 | 是 | 工作空间ID |
        /// 
        /// ### 请求体参数
        /// | 参数名 | 类型 | 必填 | 描述 |
        /// |--------|------|------|------|
        /// | QuotaType | string | 是 | 配额类型，可选值：<br>- `CBS`：CBS存储配额<br>- `Notebook`：开发机数量配额<br>- `PostPaySpec`：托管按量资源规格限制 |
        /// 
        /// ## 响应参数
        /// 
        /// | 参数名 | 类型 | 描述 |
        /// |--------|------|------|
        /// | QuotaType | string | 配额类型 |
        /// | QuotaEnabled | bool | 是否启用配额管理功能 |
        /// | DefaultQuota | WorkspaceQuota | 默认配额配置（当QuotaEnabled为false时为空对象） |
        /// | Quotas | ][WorkspaceQuota | 配额列表，包含所有子账号或用户组的配额配置（仅当QuotaEnabled为true时返回） |
        /// 
        /// ### WorkspaceQuota
        /// 
        /// | 参数名 | 类型 | 描述 |
        /// |--------|------|------|
        /// | Id | string | 配额ID，格式：<br>- 用户配额：`{quota_type}-{uin}-{subuin}-{TiProjectId}`<br>- 用户组配额：`{quota_type}-{uin}-{groupid}-{TiProjectId}`<br>- 默认配额：`{quota_type}-{uin}-default-{TiProjectId}` |
        /// | QuotaType | string | 配额类型 |
        /// | Uin | string | 主账号Uin |
        /// | SubUin | string | 子账号Uin（当TargetType为USER时有值） |
        /// | SubUinName | string | 子账号名称（当TargetType为USER时有值） |
        /// | QuotaValue | uint32 | 配额值：<br>- CBS：容量（GiB），默认100，范围10-10000<br>- Notebook：数量（个），默认1，范围1-999<br>- PostPaySpec：无意义，关注QuotaData字段 |
        /// | QuotaData | []string | 配额数据（JSON数组格式）：<br>- 当QuotaType为PostPaySpec时，存储允许使用的规格ID列表 |
        /// | TargetType | string | 配额目标类型：<br>- `USER`：用户配额<br>- `USER_GROUP`：用户组配额 |
        /// | GroupId | string | 用户组ID（当TargetType为USER_GROUP时有值） |
        /// | GroupName | string | 用户组名称（当TargetType为USER_GROUP时有值） |
        /// | TiProjectId | string | 工作空间ID |
        /// 
        /// ## 业务逻辑
        /// 
        /// 1. **参数校验**：验证QuotaType参数是否合法
        /// 2. **查询配额配置**：根据主账号Uin、工作空间ID和配额类型查询配额配置
        /// 3. **配置不存在**：
        ///    - 返回系统默认的配额启用状态和默认配额值
        ///    - CBS默认启用，默认值100GiB
        ///    - Notebook默认启用，默认值1个
        ///    - PostPaySpec默认不启用
        /// 4. **配置存在但未启用**：
        ///    - QuotaEnabled返回false
        ///    - DefaultQuota返回空对象
        ///    - Quotas不返回
        /// 5. **配置存在且已启用**：
        ///    - QuotaEnabled返回true
        ///    - DefaultQuota返回配置的默认配额值
        ///    - Quotas返回所有子账号或用户组的配额列表
        ///    - 自动反序列化QuotaData字段（JSON数组）
        /// 
        /// ## 使用场景
        /// 
        /// 1. **配额管理页面初始化**：获取当前工作空间的配额配置状态
        /// 2. **配额列表展示**：展示所有子账号或用户组的配额分配情况
        /// 3. **配额编辑前查询**：在修改配额前获取当前配置
        /// 4. **权限控制判断**：判断是否启用了配额管理功能
        /// 
        /// ## 错误码
        /// 
        /// | 错误码 | 描述 | 解决方案 |
        /// |--------|------|----------|
        /// | InvalidParameterValue | 参数值错误 | 检查QuotaType参数是否为合法值（CBS/Notebook/PostPaySpec） |
        /// | FailedOperation.QueryDatabaseFail | 数据库查询失败 | 稍后重试或联系管理员 |
        /// 
        /// ## 请求示例
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "CBS"
        /// }
        /// ```
        /// 
        /// **HTTP Header:**
        /// ```
        /// X-TC-Uin: 100012345678
        /// X-TC-ProjectId: 123456
        /// ```
        /// 
        /// ## 响应示例
        /// 
        /// ### 示例1：配额已启用且有配额列表
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "CBS",
        ///   "QuotaEnabled": true,
        ///   "DefaultQuota": {
        ///     "Id": "CBS-100012345678-default-123456",
        ///     "QuotaType": "CBS",
        ///     "Uin": "100012345678",
        ///     "SubUin": "",
        ///     "SubUinName": "",
        ///     "QuotaValue": 100,
        ///     "QuotaData": [],
        ///     "TargetType": "",
        ///     "GroupId": "",
        ///     "GroupName": "",
        ///     "TiProjectId": "123456"
        ///   },
        ///   "Quotas": [
        ///     {
        ///       "Id": "CBS-100012345678-100012345679-123456",
        ///       "QuotaType": "CBS",
        ///       "Uin": "100012345678",
        ///       "SubUin": "100012345679",
        ///       "SubUinName": "张三",
        ///       "QuotaValue": 200,
        ///       "QuotaData": [],
        ///       "TargetType": "USER",
        ///       "GroupId": "",
        ///       "GroupName": "",
        ///       "TiProjectId": "123456"
        ///     },
        ///     {
        ///       "Id": "CBS-100012345678-group001-123456",
        ///       "QuotaType": "CBS",
        ///       "Uin": "100012345678",
        ///       "SubUin": "",
        ///       "SubUinName": "",
        ///       "QuotaValue": 500,
        ///       "QuotaData": [],
        ///       "TargetType": "USER_GROUP",
        ///       "GroupId": "group001",
        ///       "GroupName": "开发组",
        ///       "TiProjectId": "123456"
        ///     }
        ///   ]
        /// }
        /// ```
        /// 
        /// ### 示例2：配额未启用
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "PostPaySpec",
        ///   "QuotaEnabled": false,
        ///   "DefaultQuota": {},
        ///   "Quotas": []
        /// }
        /// ```
        /// 
        /// ### 示例3：PostPaySpec类型配额（带QuotaData）
        /// 
        /// ```json
        /// {
        ///   "QuotaType": "PostPaySpec",
        ///   "QuotaEnabled": true,
        ///   "DefaultQuota": {
        ///     "Id": "PostPaySpec-100012345678-default-123456",
        ///     "QuotaType": "PostPaySpec",
        ///     "Uin": "100012345678",
        ///     "SubUin": "",
        ///     "SubUinName": "",
        ///     "QuotaValue": 0,
        ///     "QuotaData": ["spec-001", "spec-002", "spec-003"],
        ///     "TargetType": "",
        ///     "GroupId": "",
        ///     "GroupName": "",
        ///     "TiProjectId": "123456"
        ///   },
        ///   "Quotas": [
        ///     {
        ///       "Id": "PostPaySpec-100012345678-100012345679-123456",
        ///       "QuotaType": "PostPaySpec",
        ///       "Uin": "100012345678",
        ///       "SubUin": "100012345679",
        ///       "SubUinName": "李四",
        ///       "QuotaValue": 0,
        ///       "QuotaData": ["spec-001", "spec-002"],
        ///       "TargetType": "USER",
        ///       "GroupId": "",
        ///       "GroupName": "",
        ///       "TiProjectId": "123456"
        ///     }
        ///   ]
        /// }
        /// ```
        /// 
        /// ## 注意事项
        /// 
        /// 1. **配额继承规则**：
        ///    - 如果子账号或用户组没有单独配置配额，则使用DefaultQuota的值
        ///    - 用户组配额优先级高于默认配额，用户配额优先级最高
        /// 
        /// 2. **QuotaData字段**：
        ///    - 仅在QuotaType为PostPaySpec时有实际意义
        ///    - 存储的是允许使用的规格ID列表
        ///    - 其他类型的配额该字段为空数组
        /// 
        /// 3. **TargetType字段**：
        ///    - DefaultQuota的TargetType为空字符串
        ///    - Quotas列表中的每个配额都有明确的TargetType
        /// 
        /// 4. **配额值单位**：
        ///    - CBS配额：GiB（1 GiB = 1024 MiB）
        ///    - Notebook配额：个数
        /// 
        /// 5. **性能优化**：
        ///    - 接口会一次性返回所有配额列表，避免多次查询
        ///    - 建议前端做好缓存，减少重复请求
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceQuotasRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceQuotasResponse"/></returns>
        public DescribeWorkspaceQuotasResponse DescribeWorkspaceQuotasSync(DescribeWorkspaceQuotasRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceQuotasResponse>(req, "DescribeWorkspaceQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public Task<DescribeWorkspacesResponse> DescribeWorkspaces(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces");
        }

        /// <summary>
        /// 查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public DescribeWorkspacesResponse DescribeWorkspacesSync(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启CLS日志投递
        /// </summary>
        /// <param name="req"><see cref="EnableTrainingTaskClsConfigRequest"/></param>
        /// <returns><see cref="EnableTrainingTaskClsConfigResponse"/></returns>
        public Task<EnableTrainingTaskClsConfigResponse> EnableTrainingTaskClsConfig(EnableTrainingTaskClsConfigRequest req)
        {
            return InternalRequestAsync<EnableTrainingTaskClsConfigResponse>(req, "EnableTrainingTaskClsConfig");
        }

        /// <summary>
        /// 开启CLS日志投递
        /// </summary>
        /// <param name="req"><see cref="EnableTrainingTaskClsConfigRequest"/></param>
        /// <returns><see cref="EnableTrainingTaskClsConfigResponse"/></returns>
        public EnableTrainingTaskClsConfigResponse EnableTrainingTaskClsConfigSync(EnableTrainingTaskClsConfigRequest req)
        {
            return InternalRequestAsync<EnableTrainingTaskClsConfigResponse>(req, "EnableTrainingTaskClsConfig")
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
        /// 修改一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="ModifyModelServiceAuthTokenResponse"/></returns>
        public Task<ModifyModelServiceAuthTokenResponse> ModifyModelServiceAuthToken(ModifyModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceAuthTokenResponse>(req, "ModifyModelServiceAuthToken");
        }

        /// <summary>
        /// 修改一个 AuthToken
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceAuthTokenRequest"/></param>
        /// <returns><see cref="ModifyModelServiceAuthTokenResponse"/></returns>
        public ModifyModelServiceAuthTokenResponse ModifyModelServiceAuthTokenSync(ModifyModelServiceAuthTokenRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceAuthTokenResponse>(req, "ModifyModelServiceAuthToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改服务鉴权配置
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceAuthorizationRequest"/></param>
        /// <returns><see cref="ModifyModelServiceAuthorizationResponse"/></returns>
        public Task<ModifyModelServiceAuthorizationResponse> ModifyModelServiceAuthorization(ModifyModelServiceAuthorizationRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceAuthorizationResponse>(req, "ModifyModelServiceAuthorization");
        }

        /// <summary>
        /// 修改服务鉴权配置
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceAuthorizationRequest"/></param>
        /// <returns><see cref="ModifyModelServiceAuthorizationResponse"/></returns>
        public ModifyModelServiceAuthorizationResponse ModifyModelServiceAuthorizationSync(ModifyModelServiceAuthorizationRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceAuthorizationResponse>(req, "ModifyModelServiceAuthorization")
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
        /// 修改自定义角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole");
        }

        /// <summary>
        /// 修改自定义角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义角色的权限规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyRoleAccessRulesResponse"/></returns>
        public Task<ModifyRoleAccessRulesResponse> ModifyRoleAccessRules(ModifyRoleAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyRoleAccessRulesResponse>(req, "ModifyRoleAccessRules");
        }

        /// <summary>
        /// 修改自定义角色的权限规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyRoleAccessRulesResponse"/></returns>
        public ModifyRoleAccessRulesResponse ModifyRoleAccessRulesSync(ModifyRoleAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyRoleAccessRulesResponse>(req, "ModifyRoleAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改角色下用户的授权状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleUserGrantRequest"/></param>
        /// <returns><see cref="ModifyRoleUserGrantResponse"/></returns>
        public Task<ModifyRoleUserGrantResponse> ModifyRoleUserGrant(ModifyRoleUserGrantRequest req)
        {
            return InternalRequestAsync<ModifyRoleUserGrantResponse>(req, "ModifyRoleUserGrant");
        }

        /// <summary>
        /// 修改角色下用户的授权状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleUserGrantRequest"/></param>
        /// <returns><see cref="ModifyRoleUserGrantResponse"/></returns>
        public ModifyRoleUserGrantResponse ModifyRoleUserGrantSync(ModifyRoleUserGrantRequest req)
        {
            return InternalRequestAsync<ModifyRoleUserGrantResponse>(req, "ModifyRoleUserGrant")
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
        /// 更新用户授权
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGrantRequest"/></param>
        /// <returns><see cref="ModifyUserGrantResponse"/></returns>
        public Task<ModifyUserGrantResponse> ModifyUserGrant(ModifyUserGrantRequest req)
        {
            return InternalRequestAsync<ModifyUserGrantResponse>(req, "ModifyUserGrant");
        }

        /// <summary>
        /// 更新用户授权
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGrantRequest"/></param>
        /// <returns><see cref="ModifyUserGrantResponse"/></returns>
        public ModifyUserGrantResponse ModifyUserGrantSync(ModifyUserGrantRequest req)
        {
            return InternalRequestAsync<ModifyUserGrantResponse>(req, "ModifyUserGrant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新空间用户列表
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceMembersRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceMembersResponse"/></returns>
        public Task<ModifyWorkspaceMembersResponse> ModifyWorkspaceMembers(ModifyWorkspaceMembersRequest req)
        {
            return InternalRequestAsync<ModifyWorkspaceMembersResponse>(req, "ModifyWorkspaceMembers");
        }

        /// <summary>
        /// 更新空间用户列表
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceMembersRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceMembersResponse"/></returns>
        public ModifyWorkspaceMembersResponse ModifyWorkspaceMembersSync(ModifyWorkspaceMembersRequest req)
        {
            return InternalRequestAsync<ModifyWorkspaceMembersResponse>(req, "ModifyWorkspaceMembers")
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

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateDataSourceRequest"/></param>
        /// <returns><see cref="UpdateDataSourceResponse"/></returns>
        public Task<UpdateDataSourceResponse> UpdateDataSource(UpdateDataSourceRequest req)
        {
            return InternalRequestAsync<UpdateDataSourceResponse>(req, "UpdateDataSource");
        }

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="UpdateDataSourceRequest"/></param>
        /// <returns><see cref="UpdateDataSourceResponse"/></returns>
        public UpdateDataSourceResponse UpdateDataSourceSync(UpdateDataSourceRequest req)
        {
            return InternalRequestAsync<UpdateDataSourceResponse>(req, "UpdateDataSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建挂载限制
        /// </summary>
        /// <param name="req"><see cref="UpdateMountLimitRequest"/></param>
        /// <returns><see cref="UpdateMountLimitResponse"/></returns>
        public Task<UpdateMountLimitResponse> UpdateMountLimit(UpdateMountLimitRequest req)
        {
            return InternalRequestAsync<UpdateMountLimitResponse>(req, "UpdateMountLimit");
        }

        /// <summary>
        /// 创建挂载限制
        /// </summary>
        /// <param name="req"><see cref="UpdateMountLimitRequest"/></param>
        /// <returns><see cref="UpdateMountLimitResponse"/></returns>
        public UpdateMountLimitResponse UpdateMountLimitSync(UpdateMountLimitRequest req)
        {
            return InternalRequestAsync<UpdateMountLimitResponse>(req, "UpdateMountLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新子账号Linux用户信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSubAccountLinuxUserInfoRequest"/></param>
        /// <returns><see cref="UpdateSubAccountLinuxUserInfoResponse"/></returns>
        public Task<UpdateSubAccountLinuxUserInfoResponse> UpdateSubAccountLinuxUserInfo(UpdateSubAccountLinuxUserInfoRequest req)
        {
            return InternalRequestAsync<UpdateSubAccountLinuxUserInfoResponse>(req, "UpdateSubAccountLinuxUserInfo");
        }

        /// <summary>
        /// 更新子账号Linux用户信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSubAccountLinuxUserInfoRequest"/></param>
        /// <returns><see cref="UpdateSubAccountLinuxUserInfoResponse"/></returns>
        public UpdateSubAccountLinuxUserInfoResponse UpdateSubAccountLinuxUserInfoSync(UpdateSubAccountLinuxUserInfoRequest req)
        {
            return InternalRequestAsync<UpdateSubAccountLinuxUserInfoResponse>(req, "UpdateSubAccountLinuxUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
