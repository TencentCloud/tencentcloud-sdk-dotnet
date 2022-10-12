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

namespace TencentCloud.Wedata.V20210820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wedata.V20210820.Models;

   public class WedataClient : AbstractClient{

       private const string endpoint = "wedata.tencentcloudapi.com";
       private const string version = "2021-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WedataClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WedataClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public async Task<BatchDeleteTasksNewResponse> BatchDeleteTasksNew(BatchDeleteTasksNewRequest req)
        {
             JsonResponseModel<BatchDeleteTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量删除任务，仅对任务状态为”已停止“有效；
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteTasksNewRequest"/></param>
        /// <returns><see cref="BatchDeleteTasksNewResponse"/></returns>
        public BatchDeleteTasksNewResponse BatchDeleteTasksNewSync(BatchDeleteTasksNewRequest req)
        {
             JsonResponseModel<BatchDeleteTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public async Task<BatchModifyOwnersNewResponse> BatchModifyOwnersNew(BatchModifyOwnersNewRequest req)
        {
             JsonResponseModel<BatchModifyOwnersNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyOwnersNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyOwnersNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量修改任务责任人
        /// </summary>
        /// <param name="req"><see cref="BatchModifyOwnersNewRequest"/></param>
        /// <returns><see cref="BatchModifyOwnersNewResponse"/></returns>
        public BatchModifyOwnersNewResponse BatchModifyOwnersNewSync(BatchModifyOwnersNewRequest req)
        {
             JsonResponseModel<BatchModifyOwnersNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyOwnersNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyOwnersNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public async Task<BatchStopTasksNewResponse> BatchStopTasksNew(BatchStopTasksNewRequest req)
        {
             JsonResponseModel<BatchStopTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchStopTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 仅对任务状态为”调度中“和”已暂停“有效，对所选任务的任务实例进行终止，并停止调度
        /// </summary>
        /// <param name="req"><see cref="BatchStopTasksNewRequest"/></param>
        /// <returns><see cref="BatchStopTasksNewResponse"/></returns>
        public BatchStopTasksNewResponse BatchStopTasksNewSync(BatchStopTasksNewRequest req)
        {
             JsonResponseModel<BatchStopTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchStopTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchStopTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public async Task<CreateCustomFunctionResponse> CreateCustomFunction(CreateCustomFunctionRequest req)
        {
             JsonResponseModel<CreateCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建用户自定义函数
        /// </summary>
        /// <param name="req"><see cref="CreateCustomFunctionRequest"/></param>
        /// <returns><see cref="CreateCustomFunctionResponse"/></returns>
        public CreateCustomFunctionResponse CreateCustomFunctionSync(CreateCustomFunctionRequest req)
        {
             JsonResponseModel<CreateCustomFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public async Task<CreateDataSourceResponse> CreateDataSource(CreateDataSourceRequest req)
        {
             JsonResponseModel<CreateDataSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDataSourceRequest"/></param>
        /// <returns><see cref="CreateDataSourceResponse"/></returns>
        public CreateDataSourceResponse CreateDataSourceSync(CreateDataSourceRequest req)
        {
             JsonResponseModel<CreateDataSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public async Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
             JsonResponseModel<CreateFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建文件夹
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
             JsonResponseModel<CreateFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public async Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 创建工作流
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public async Task<DeleteDataSourcesResponse> DeleteDataSources(DeleteDataSourcesRequest req)
        {
             JsonResponseModel<DeleteDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDataSourcesRequest"/></param>
        /// <returns><see cref="DeleteDataSourcesResponse"/></returns>
        public DeleteDataSourcesResponse DeleteDataSourcesSync(DeleteDataSourcesRequest req)
        {
             JsonResponseModel<DeleteDataSourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataSources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataSourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public async Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest req)
        {
             JsonResponseModel<DeleteFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public DeleteFolderResponse DeleteFolderSync(DeleteFolderRequest req)
        {
             JsonResponseModel<DeleteFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public async Task<DeleteWorkflowNewResponse> DeleteWorkflowNew(DeleteWorkflowNewRequest req)
        {
             JsonResponseModel<DeleteWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 删除工作流
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowNewRequest"/></param>
        /// <returns><see cref="DeleteWorkflowNewResponse"/></returns>
        public DeleteWorkflowNewResponse DeleteWorkflowNewSync(DeleteWorkflowNewRequest req)
        {
             JsonResponseModel<DeleteWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public async Task<DescribeDataSourceListResponse> DescribeDataSourceList(DescribeDataSourceListRequest req)
        {
             JsonResponseModel<DescribeDataSourceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceListRequest"/></param>
        /// <returns><see cref="DescribeDataSourceListResponse"/></returns>
        public DescribeDataSourceListResponse DescribeDataSourceListSync(DescribeDataSourceListRequest req)
        {
             JsonResponseModel<DescribeDataSourceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public async Task<DescribeDataSourceWithoutInfoResponse> DescribeDataSourceWithoutInfo(DescribeDataSourceWithoutInfoRequest req)
        {
             JsonResponseModel<DescribeDataSourceWithoutInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSourceWithoutInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceWithoutInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSourceWithoutInfoRequest"/></param>
        /// <returns><see cref="DescribeDataSourceWithoutInfoResponse"/></returns>
        public DescribeDataSourceWithoutInfoResponse DescribeDataSourceWithoutInfoSync(DescribeDataSourceWithoutInfoRequest req)
        {
             JsonResponseModel<DescribeDataSourceWithoutInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSourceWithoutInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSourceWithoutInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public async Task<DescribeDatasourceResponse> DescribeDatasource(DescribeDatasourceRequest req)
        {
             JsonResponseModel<DescribeDatasourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 数据源详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceRequest"/></param>
        /// <returns><see cref="DescribeDatasourceResponse"/></returns>
        public DescribeDatasourceResponse DescribeDatasourceSync(DescribeDatasourceRequest req)
        {
             JsonResponseModel<DescribeDatasourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public async Task<DescribeDependTasksNewResponse> DescribeDependTasksNew(DescribeDependTasksNewRequest req)
        {
             JsonResponseModel<DescribeDependTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDependTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDependTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据层级查找上/下游任务节点
        /// </summary>
        /// <param name="req"><see cref="DescribeDependTasksNewRequest"/></param>
        /// <returns><see cref="DescribeDependTasksNewResponse"/></returns>
        public DescribeDependTasksNewResponse DescribeDependTasksNewSync(DescribeDependTasksNewRequest req)
        {
             JsonResponseModel<DescribeDependTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDependTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDependTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public async Task<DescribeFolderListResponse> DescribeFolderList(DescribeFolderListRequest req)
        {
             JsonResponseModel<DescribeFolderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFolderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹目录
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderListRequest"/></param>
        /// <returns><see cref="DescribeFolderListResponse"/></returns>
        public DescribeFolderListResponse DescribeFolderListSync(DescribeFolderListRequest req)
        {
             JsonResponseModel<DescribeFolderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFolderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public async Task<DescribeFolderWorkflowListResponse> DescribeFolderWorkflowList(DescribeFolderWorkflowListRequest req)
        {
             JsonResponseModel<DescribeFolderWorkflowListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFolderWorkflowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderWorkflowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 拉取文件夹下的工作流
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderWorkflowListRequest"/></param>
        /// <returns><see cref="DescribeFolderWorkflowListResponse"/></returns>
        public DescribeFolderWorkflowListResponse DescribeFolderWorkflowListSync(DescribeFolderWorkflowListRequest req)
        {
             JsonResponseModel<DescribeFolderWorkflowListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFolderWorkflowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFolderWorkflowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public async Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 获取实例日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public async Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public async Task<DescribeRelatedInstancesResponse> DescribeRelatedInstances(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例的关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRelatedInstancesResponse"/></returns>
        public DescribeRelatedInstancesResponse DescribeRelatedInstancesSync(DescribeRelatedInstancesRequest req)
        {
             JsonResponseModel<DescribeRelatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务具体详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public async Task<DescribeTaskInstancesResponse> DescribeTaskInstances(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInstancesRequest"/></param>
        /// <returns><see cref="DescribeTaskInstancesResponse"/></returns>
        public DescribeTaskInstancesResponse DescribeTaskInstancesSync(DescribeTaskInstancesRequest req)
        {
             JsonResponseModel<DescribeTaskInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public async Task<DescribeTaskScriptResponse> DescribeTaskScript(DescribeTaskScriptRequest req)
        {
             JsonResponseModel<DescribeTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 查询任务脚本
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskScriptRequest"/></param>
        /// <returns><see cref="DescribeTaskScriptResponse"/></returns>
        public DescribeTaskScriptResponse DescribeTaskScriptSync(DescribeTaskScriptRequest req)
        {
             JsonResponseModel<DescribeTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public async Task<DescribeTasksByPageResponse> DescribeTasksByPage(DescribeTasksByPageRequest req)
        {
             JsonResponseModel<DescribeTasksByPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasksByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 根据工作流分页查询任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksByPageRequest"/></param>
        /// <returns><see cref="DescribeTasksByPageResponse"/></returns>
        public DescribeTasksByPageResponse DescribeTasksByPageSync(DescribeTasksByPageRequest req)
        {
             JsonResponseModel<DescribeTasksByPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasksByPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksByPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public async Task<ForceSucInstancesResponse> ForceSucInstances(ForceSucInstancesRequest req)
        {
             JsonResponseModel<ForceSucInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForceSucInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForceSucInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量置成功
        /// </summary>
        /// <param name="req"><see cref="ForceSucInstancesRequest"/></param>
        /// <returns><see cref="ForceSucInstancesResponse"/></returns>
        public ForceSucInstancesResponse ForceSucInstancesSync(ForceSucInstancesRequest req)
        {
             JsonResponseModel<ForceSucInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForceSucInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForceSucInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public async Task<FreezeTasksResponse> FreezeTasks(FreezeTasksRequest req)
        {
             JsonResponseModel<FreezeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreezeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 批量冻结任务
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksRequest"/></param>
        /// <returns><see cref="FreezeTasksResponse"/></returns>
        public FreezeTasksResponse FreezeTasksSync(FreezeTasksRequest req)
        {
             JsonResponseModel<FreezeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreezeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public async Task<FreezeTasksByMultiWorkflowResponse> FreezeTasksByMultiWorkflow(FreezeTasksByMultiWorkflowRequest req)
        {
             JsonResponseModel<FreezeTasksByMultiWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreezeTasksByMultiWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksByMultiWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 基于多个工作流进行批量冻结任务操作
        /// </summary>
        /// <param name="req"><see cref="FreezeTasksByMultiWorkflowRequest"/></param>
        /// <returns><see cref="FreezeTasksByMultiWorkflowResponse"/></returns>
        public FreezeTasksByMultiWorkflowResponse FreezeTasksByMultiWorkflowSync(FreezeTasksByMultiWorkflowRequest req)
        {
             JsonResponseModel<FreezeTasksByMultiWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreezeTasksByMultiWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeTasksByMultiWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public async Task<KillInstancesResponse> KillInstances(KillInstancesRequest req)
        {
             JsonResponseModel<KillInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量终止操作
        /// </summary>
        /// <param name="req"><see cref="KillInstancesRequest"/></param>
        /// <returns><see cref="KillInstancesResponse"/></returns>
        public KillInstancesResponse KillInstancesSync(KillInstancesRequest req)
        {
             JsonResponseModel<KillInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public async Task<MakeUpTasksNewResponse> MakeUpTasksNew(MakeUpTasksNewRequest req)
        {
             JsonResponseModel<MakeUpTasksNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MakeUpTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 任务批量补录，调度状态任务才可以补录；
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="MakeUpTasksNewRequest"/></param>
        /// <returns><see cref="MakeUpTasksNewResponse"/></returns>
        public MakeUpTasksNewResponse MakeUpTasksNewSync(MakeUpTasksNewRequest req)
        {
             JsonResponseModel<MakeUpTasksNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MakeUpTasksNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpTasksNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public async Task<MakeUpWorkflowNewResponse> MakeUpWorkflowNew(MakeUpWorkflowNewRequest req)
        {
             JsonResponseModel<MakeUpWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MakeUpWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 工作流下所有任务的补录
        /// </summary>
        /// <param name="req"><see cref="MakeUpWorkflowNewRequest"/></param>
        /// <returns><see cref="MakeUpWorkflowNewResponse"/></returns>
        public MakeUpWorkflowNewResponse MakeUpWorkflowNewSync(MakeUpWorkflowNewRequest req)
        {
             JsonResponseModel<MakeUpWorkflowNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MakeUpWorkflowNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MakeUpWorkflowNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSource(ModifyDataSourceRequest req)
        {
             JsonResponseModel<ModifyDataSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDataSourceRequest"/></param>
        /// <returns><see cref="ModifyDataSourceResponse"/></returns>
        public ModifyDataSourceResponse ModifyDataSourceSync(ModifyDataSourceRequest req)
        {
             JsonResponseModel<ModifyDataSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDataSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public async Task<ModifyFolderResponse> ModifyFolder(ModifyFolderRequest req)
        {
             JsonResponseModel<ModifyFolderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 文件夹更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public ModifyFolderResponse ModifyFolderSync(ModifyFolderRequest req)
        {
             JsonResponseModel<ModifyFolderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFolder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFolderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public async Task<ModifyTaskInfoResponse> ModifyTaskInfo(ModifyTaskInfoRequest req)
        {
             JsonResponseModel<ModifyTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskInfoRequest"/></param>
        /// <returns><see cref="ModifyTaskInfoResponse"/></returns>
        public ModifyTaskInfoResponse ModifyTaskInfoSync(ModifyTaskInfoRequest req)
        {
             JsonResponseModel<ModifyTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public async Task<ModifyTaskLinksResponse> ModifyTaskLinks(ModifyTaskLinksRequest req)
        {
             JsonResponseModel<ModifyTaskLinksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 添加父任务依赖
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskLinksRequest"/></param>
        /// <returns><see cref="ModifyTaskLinksResponse"/></returns>
        public ModifyTaskLinksResponse ModifyTaskLinksSync(ModifyTaskLinksRequest req)
        {
             JsonResponseModel<ModifyTaskLinksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public async Task<ModifyTaskScriptResponse> ModifyTaskScript(ModifyTaskScriptRequest req)
        {
             JsonResponseModel<ModifyTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 修改任务脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskScriptRequest"/></param>
        /// <returns><see cref="ModifyTaskScriptResponse"/></returns>
        public ModifyTaskScriptResponse ModifyTaskScriptSync(ModifyTaskScriptRequest req)
        {
             JsonResponseModel<ModifyTaskScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public async Task<ModifyWorkflowInfoResponse> ModifyWorkflowInfo(ModifyWorkflowInfoRequest req)
        {
             JsonResponseModel<ModifyWorkflowInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkflowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowInfoRequest"/></param>
        /// <returns><see cref="ModifyWorkflowInfoResponse"/></returns>
        public ModifyWorkflowInfoResponse ModifyWorkflowInfoSync(ModifyWorkflowInfoRequest req)
        {
             JsonResponseModel<ModifyWorkflowInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkflowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public async Task<ModifyWorkflowScheduleResponse> ModifyWorkflowSchedule(ModifyWorkflowScheduleRequest req)
        {
             JsonResponseModel<ModifyWorkflowScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkflowSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 更新工作流调度
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkflowScheduleRequest"/></param>
        /// <returns><see cref="ModifyWorkflowScheduleResponse"/></returns>
        public ModifyWorkflowScheduleResponse ModifyWorkflowScheduleSync(ModifyWorkflowScheduleRequest req)
        {
             JsonResponseModel<ModifyWorkflowScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkflowSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkflowScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public async Task<RegisterEventResponse> RegisterEvent(RegisterEventRequest req)
        {
             JsonResponseModel<RegisterEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件
        /// </summary>
        /// <param name="req"><see cref="RegisterEventRequest"/></param>
        /// <returns><see cref="RegisterEventResponse"/></returns>
        public RegisterEventResponse RegisterEventSync(RegisterEventRequest req)
        {
             JsonResponseModel<RegisterEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public async Task<RegisterEventListenerResponse> RegisterEventListener(RegisterEventListenerRequest req)
        {
             JsonResponseModel<RegisterEventListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterEventListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 注册事件监听器
        /// </summary>
        /// <param name="req"><see cref="RegisterEventListenerRequest"/></param>
        /// <returns><see cref="RegisterEventListenerResponse"/></returns>
        public RegisterEventListenerResponse RegisterEventListenerSync(RegisterEventListenerRequest req)
        {
             JsonResponseModel<RegisterEventListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterEventListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterEventListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public async Task<RerunInstancesResponse> RerunInstances(RerunInstancesRequest req)
        {
             JsonResponseModel<RerunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RerunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RerunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 实例批量重跑
        /// </summary>
        /// <param name="req"><see cref="RerunInstancesRequest"/></param>
        /// <returns><see cref="RerunInstancesResponse"/></returns>
        public RerunInstancesResponse RerunInstancesSync(RerunInstancesRequest req)
        {
             JsonResponseModel<RerunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RerunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RerunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public async Task<RunTaskResponse> RunTask(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 运行任务
        /// </summary>
        /// <param name="req"><see cref="RunTaskRequest"/></param>
        /// <returns><see cref="RunTaskResponse"/></returns>
        public RunTaskResponse RunTaskSync(RunTaskRequest req)
        {
             JsonResponseModel<RunTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public async Task<SetTaskAlarmNewResponse> SetTaskAlarmNew(SetTaskAlarmNewRequest req)
        {
             JsonResponseModel<SetTaskAlarmNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTaskAlarmNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTaskAlarmNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 设置任务告警，新建/更新告警信息（最新）
        /// </summary>
        /// <param name="req"><see cref="SetTaskAlarmNewRequest"/></param>
        /// <returns><see cref="SetTaskAlarmNewResponse"/></returns>
        public SetTaskAlarmNewResponse SetTaskAlarmNewSync(SetTaskAlarmNewRequest req)
        {
             JsonResponseModel<SetTaskAlarmNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTaskAlarmNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTaskAlarmNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public async Task<SubmitTaskResponse> SubmitTask(SubmitTaskRequest req)
        {
             JsonResponseModel<SubmitTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交任务
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskRequest"/></param>
        /// <returns><see cref="SubmitTaskResponse"/></returns>
        public SubmitTaskResponse SubmitTaskSync(SubmitTaskRequest req)
        {
             JsonResponseModel<SubmitTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public async Task<SubmitWorkflowResponse> SubmitWorkflow(SubmitWorkflowRequest req)
        {
             JsonResponseModel<SubmitWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 提交工作流
        /// </summary>
        /// <param name="req"><see cref="SubmitWorkflowRequest"/></param>
        /// <returns><see cref="SubmitWorkflowResponse"/></returns>
        public SubmitWorkflowResponse SubmitWorkflowSync(SubmitWorkflowRequest req)
        {
             JsonResponseModel<SubmitWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public async Task<TriggerEventResponse> TriggerEvent(TriggerEventRequest req)
        {
             JsonResponseModel<TriggerEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TriggerEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p style="color:red;">[注意：该Beta版本只满足广州区部分白名单客户使用]</p>
        /// 触发事件
        /// </summary>
        /// <param name="req"><see cref="TriggerEventRequest"/></param>
        /// <returns><see cref="TriggerEventResponse"/></returns>
        public TriggerEventResponse TriggerEventSync(TriggerEventRequest req)
        {
             JsonResponseModel<TriggerEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TriggerEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TriggerEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
