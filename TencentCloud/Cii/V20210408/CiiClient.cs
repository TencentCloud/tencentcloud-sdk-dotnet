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

namespace TencentCloud.Cii.V20210408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cii.V20210408.Models;

   public class CiiClient : AbstractClient{

       private const string endpoint = "cii.tencentcloudapi.com";
       private const string version = "2021-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 中银三星需求，基于主任务批量添加结构化子任务
        /// </summary>
        /// <param name="req"><see cref="AddSubStructureTasksRequest"/></param>
        /// <returns><see cref="AddSubStructureTasksResponse"/></returns>
        public async Task<AddSubStructureTasksResponse> AddSubStructureTasks(AddSubStructureTasksRequest req)
        {
             JsonResponseModel<AddSubStructureTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSubStructureTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSubStructureTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 中银三星需求，基于主任务批量添加结构化子任务
        /// </summary>
        /// <param name="req"><see cref="AddSubStructureTasksRequest"/></param>
        /// <returns><see cref="AddSubStructureTasksResponse"/></returns>
        public AddSubStructureTasksResponse AddSubStructureTasksSync(AddSubStructureTasksRequest req)
        {
             JsonResponseModel<AddSubStructureTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSubStructureTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSubStructureTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateAutoClassifyStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoClassifyStructureTaskRequest"/></param>
        /// <returns><see cref="CreateAutoClassifyStructureTaskResponse"/></returns>
        public async Task<CreateAutoClassifyStructureTaskResponse> CreateAutoClassifyStructureTask(CreateAutoClassifyStructureTaskRequest req)
        {
             JsonResponseModel<CreateAutoClassifyStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoClassifyStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoClassifyStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateAutoClassifyStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoClassifyStructureTaskRequest"/></param>
        /// <returns><see cref="CreateAutoClassifyStructureTaskResponse"/></returns>
        public CreateAutoClassifyStructureTaskResponse CreateAutoClassifyStructureTaskSync(CreateAutoClassifyStructureTaskRequest req)
        {
             JsonResponseModel<CreateAutoClassifyStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoClassifyStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoClassifyStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public async Task<CreateStructureTaskResponse> CreateStructureTask(CreateStructureTaskRequest req)
        {
             JsonResponseModel<CreateStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public CreateStructureTaskResponse CreateStructureTaskSync(CreateStructureTaskRequest req)
        {
             JsonResponseModel<CreateStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateUnderwriteTaskById)用于根据结构化任务ID创建核保任务
        /// </summary>
        /// <param name="req"><see cref="CreateUnderwriteTaskByIdRequest"/></param>
        /// <returns><see cref="CreateUnderwriteTaskByIdResponse"/></returns>
        public async Task<CreateUnderwriteTaskByIdResponse> CreateUnderwriteTaskById(CreateUnderwriteTaskByIdRequest req)
        {
             JsonResponseModel<CreateUnderwriteTaskByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUnderwriteTaskById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnderwriteTaskByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateUnderwriteTaskById)用于根据结构化任务ID创建核保任务
        /// </summary>
        /// <param name="req"><see cref="CreateUnderwriteTaskByIdRequest"/></param>
        /// <returns><see cref="CreateUnderwriteTaskByIdResponse"/></returns>
        public CreateUnderwriteTaskByIdResponse CreateUnderwriteTaskByIdSync(CreateUnderwriteTaskByIdRequest req)
        {
             JsonResponseModel<CreateUnderwriteTaskByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUnderwriteTaskById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnderwriteTaskByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeMachineUnderwrite)用于查询机器核保任务数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineUnderwriteRequest"/></param>
        /// <returns><see cref="DescribeMachineUnderwriteResponse"/></returns>
        public async Task<DescribeMachineUnderwriteResponse> DescribeMachineUnderwrite(DescribeMachineUnderwriteRequest req)
        {
             JsonResponseModel<DescribeMachineUnderwriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineUnderwrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineUnderwriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeMachineUnderwrite)用于查询机器核保任务数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineUnderwriteRequest"/></param>
        /// <returns><see cref="DescribeMachineUnderwriteResponse"/></returns>
        public DescribeMachineUnderwriteResponse DescribeMachineUnderwriteSync(DescribeMachineUnderwriteRequest req)
        {
             JsonResponseModel<DescribeMachineUnderwriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineUnderwrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineUnderwriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// saas页面集成了自动分类功能，该接口提供自动分类结果
        /// </summary>
        /// <param name="req"><see cref="DescribeReportClassifyRequest"/></param>
        /// <returns><see cref="DescribeReportClassifyResponse"/></returns>
        public async Task<DescribeReportClassifyResponse> DescribeReportClassify(DescribeReportClassifyRequest req)
        {
             JsonResponseModel<DescribeReportClassifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReportClassify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportClassifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// saas页面集成了自动分类功能，该接口提供自动分类结果
        /// </summary>
        /// <param name="req"><see cref="DescribeReportClassifyRequest"/></param>
        /// <returns><see cref="DescribeReportClassifyResponse"/></returns>
        public DescribeReportClassifyResponse DescribeReportClassifySync(DescribeReportClassifyRequest req)
        {
             JsonResponseModel<DescribeReportClassifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReportClassify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportClassifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public async Task<DescribeStructCompareDataResponse> DescribeStructCompareData(DescribeStructCompareDataRequest req)
        {
             JsonResponseModel<DescribeStructCompareDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructCompareData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructCompareDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public DescribeStructCompareDataResponse DescribeStructCompareDataSync(DescribeStructCompareDataRequest req)
        {
             JsonResponseModel<DescribeStructCompareDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructCompareData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructCompareDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化复核差异查询接口，对比结构化复核前后数据差异，返回差异的部分。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureDifferenceRequest"/></param>
        /// <returns><see cref="DescribeStructureDifferenceResponse"/></returns>
        public async Task<DescribeStructureDifferenceResponse> DescribeStructureDifference(DescribeStructureDifferenceRequest req)
        {
             JsonResponseModel<DescribeStructureDifferenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructureDifference");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureDifferenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化复核差异查询接口，对比结构化复核前后数据差异，返回差异的部分。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureDifferenceRequest"/></param>
        /// <returns><see cref="DescribeStructureDifferenceResponse"/></returns>
        public DescribeStructureDifferenceResponse DescribeStructureDifferenceSync(DescribeStructureDifferenceRequest req)
        {
             JsonResponseModel<DescribeStructureDifferenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructureDifference");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureDifferenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStructureResult)用于查询结构化结果接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureResultRequest"/></param>
        /// <returns><see cref="DescribeStructureResultResponse"/></returns>
        public async Task<DescribeStructureResultResponse> DescribeStructureResult(DescribeStructureResultRequest req)
        {
             JsonResponseModel<DescribeStructureResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructureResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStructureResult)用于查询结构化结果接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureResultRequest"/></param>
        /// <returns><see cref="DescribeStructureResultResponse"/></returns>
        public DescribeStructureResultResponse DescribeStructureResultSync(DescribeStructureResultRequest req)
        {
             JsonResponseModel<DescribeStructureResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructureResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public async Task<DescribeStructureTaskResultResponse> DescribeStructureTaskResult(DescribeStructureTaskResultRequest req)
        {
             JsonResponseModel<DescribeStructureTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructureTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public DescribeStructureTaskResultResponse DescribeStructureTaskResultSync(DescribeStructureTaskResultRequest req)
        {
             JsonResponseModel<DescribeStructureTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructureTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeUnderwriteTask)用于查询核保任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeUnderwriteTaskRequest"/></param>
        /// <returns><see cref="DescribeUnderwriteTaskResponse"/></returns>
        public async Task<DescribeUnderwriteTaskResponse> DescribeUnderwriteTask(DescribeUnderwriteTaskRequest req)
        {
             JsonResponseModel<DescribeUnderwriteTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnderwriteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnderwriteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeUnderwriteTask)用于查询核保任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeUnderwriteTaskRequest"/></param>
        /// <returns><see cref="DescribeUnderwriteTaskResponse"/></returns>
        public DescribeUnderwriteTaskResponse DescribeUnderwriteTaskSync(DescribeUnderwriteTaskRequest req)
        {
             JsonResponseModel<DescribeUnderwriteTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnderwriteTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnderwriteTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传医疗影像文件，可以用来做结构化。
        /// </summary>
        /// <param name="req"><see cref="UploadMedicalFileRequest"/></param>
        /// <returns><see cref="UploadMedicalFileResponse"/></returns>
        public async Task<UploadMedicalFileResponse> UploadMedicalFile(UploadMedicalFileRequest req)
        {
             JsonResponseModel<UploadMedicalFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadMedicalFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadMedicalFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传医疗影像文件，可以用来做结构化。
        /// </summary>
        /// <param name="req"><see cref="UploadMedicalFileRequest"/></param>
        /// <returns><see cref="UploadMedicalFileResponse"/></returns>
        public UploadMedicalFileResponse UploadMedicalFileSync(UploadMedicalFileRequest req)
        {
             JsonResponseModel<UploadMedicalFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadMedicalFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadMedicalFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
