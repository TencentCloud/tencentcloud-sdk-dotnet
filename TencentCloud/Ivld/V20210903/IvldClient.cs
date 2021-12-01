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

namespace TencentCloud.Ivld.V20210903
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ivld.V20210903.Models;

   public class IvldClient : AbstractClient{

       private const string endpoint = "ivld.tencentcloudapi.com";
       private const string version = "2021-09-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IvldClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IvldClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建智能标签任务。
        /// 
        /// 请注意，本接口为异步接口，**返回TaskId只代表任务创建成功，不代表任务执行成功**。
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
        /// 创建智能标签任务。
        /// 
        /// 请注意，本接口为异步接口，**返回TaskId只代表任务创建成功，不代表任务执行成功**。
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
        /// 将MediaId对应的媒资文件从系统中删除。
        /// 
        /// **请注意，本接口仅删除媒资文件，媒资文件对应的视频分析结果不会被删除**。如您需要删除结构化分析结果，请调用DeleteTask接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public async Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将MediaId对应的媒资文件从系统中删除。
        /// 
        /// **请注意，本接口仅删除媒资文件，媒资文件对应的视频分析结果不会被删除**。如您需要删除结构化分析结果，请调用DeleteTask接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public DeleteMediaResponse DeleteMediaSync(DeleteMediaRequest req)
        {
             JsonResponseModel<DeleteMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaRequest"/></param>
        /// <returns><see cref="DescribeMediaResponse"/></returns>
        public async Task<DescribeMediaResponse> DescribeMedia(DescribeMediaRequest req)
        {
             JsonResponseModel<DescribeMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaRequest"/></param>
        /// <returns><see cref="DescribeMediaResponse"/></returns>
        public DescribeMediaResponse DescribeMediaSync(DescribeMediaRequest req)
        {
             JsonResponseModel<DescribeMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个媒资文件
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediasRequest"/></param>
        /// <returns><see cref="DescribeMediasResponse"/></returns>
        public async Task<DescribeMediasResponse> DescribeMedias(DescribeMediasRequest req)
        {
             JsonResponseModel<DescribeMediasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMedias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的媒资文件信息，包括媒资状态，分辨率，帧率等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个媒资文件
        /// 
        /// 如果媒资文件未完成导入，本接口将仅输出媒资文件的状态信息；导入完成后，本接口还将输出媒资文件的其他元信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediasRequest"/></param>
        /// <returns><see cref="DescribeMediasResponse"/></returns>
        public DescribeMediasResponse DescribeMediasSync(DescribeMediasRequest req)
        {
             JsonResponseModel<DescribeMediasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMedias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述智能标签任务进度。
        /// 
        /// 请注意，**此接口仅返回任务执行状态信息，不返回任务执行结果**
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述智能标签任务进度。
        /// 
        /// 请注意，**此接口仅返回任务执行状态信息，不返回任务执行结果**
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述任务信息，如果任务成功完成，还将返回任务结果
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
        /// 描述任务信息，如果任务成功完成，还将返回任务结果
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
        /// 依照输入条件，描述命中的任务信息，包括任务创建时间，处理时间信息等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依照输入条件，描述命中的任务信息，包括任务创建时间，处理时间信息等。
        /// 
        /// 请注意，本接口最多支持同时描述**50**个任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将URL指向的媒资视频文件导入系统之中。
        /// 
        /// **请注意，本接口为异步接口**。接口返回MediaId仅代表导入视频任务发起，不代表任务完成，您可调用读接口(DescribeMedia/DescribeMedias)接口查询MediaId对应的媒资文件的状态。
        /// 
        /// 当前URL只支持COS地址，其形式为`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}`，其中`${Bucket}`为您的COS桶名称，Region为COS桶所在[可用区](https://cloud.tencent.com/document/product/213/6091)，`${ObjectKey}`为指向存储在COS桶内的待分析的视频的[ObjectKey](https://cloud.tencent.com/document/product/436/13324)
        /// 
        /// 分析完成后，本产品将在您的`${Bucket}`桶内创建名为`${ObjectKey}-${task-start-time}`的目录(`task-start-time`形式为1970-01-01T08:08:08)并将分析结果将回传回该目录，也即，结构化分析结果(包括图片，JSON等数据)将会写回`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}-${task-start-time}`目录
        /// </summary>
        /// <param name="req"><see cref="ImportMediaRequest"/></param>
        /// <returns><see cref="ImportMediaResponse"/></returns>
        public async Task<ImportMediaResponse> ImportMedia(ImportMediaRequest req)
        {
             JsonResponseModel<ImportMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将URL指向的媒资视频文件导入系统之中。
        /// 
        /// **请注意，本接口为异步接口**。接口返回MediaId仅代表导入视频任务发起，不代表任务完成，您可调用读接口(DescribeMedia/DescribeMedias)接口查询MediaId对应的媒资文件的状态。
        /// 
        /// 当前URL只支持COS地址，其形式为`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}`，其中`${Bucket}`为您的COS桶名称，Region为COS桶所在[可用区](https://cloud.tencent.com/document/product/213/6091)，`${ObjectKey}`为指向存储在COS桶内的待分析的视频的[ObjectKey](https://cloud.tencent.com/document/product/436/13324)
        /// 
        /// 分析完成后，本产品将在您的`${Bucket}`桶内创建名为`${ObjectKey}-${task-start-time}`的目录(`task-start-time`形式为1970-01-01T08:08:08)并将分析结果将回传回该目录，也即，结构化分析结果(包括图片，JSON等数据)将会写回`https://${Bucket}-${AppId}.cos.${Region}.myqcloud.com/${ObjectKey}-${task-start-time}`目录
        /// </summary>
        /// <param name="req"><see cref="ImportMediaRequest"/></param>
        /// <returns><see cref="ImportMediaResponse"/></returns>
        public ImportMediaResponse ImportMediaSync(ImportMediaRequest req)
        {
             JsonResponseModel<ImportMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
