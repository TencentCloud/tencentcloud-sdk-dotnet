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
       private const string sdkVersion = "SDK_NET_3.0.1222";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 如果主任务下的报告不满足需求，可以基于主任务批量添加子任务
        /// </summary>
        /// <param name="req"><see cref="AddSubStructureTasksRequest"/></param>
        /// <returns><see cref="AddSubStructureTasksResponse"/></returns>
        public Task<AddSubStructureTasksResponse> AddSubStructureTasks(AddSubStructureTasksRequest req)
        {
            return InternalRequestAsync<AddSubStructureTasksResponse>(req, "AddSubStructureTasks");
        }

        /// <summary>
        /// 如果主任务下的报告不满足需求，可以基于主任务批量添加子任务
        /// </summary>
        /// <param name="req"><see cref="AddSubStructureTasksRequest"/></param>
        /// <returns><see cref="AddSubStructureTasksResponse"/></returns>
        public AddSubStructureTasksResponse AddSubStructureTasksSync(AddSubStructureTasksRequest req)
        {
            return InternalRequestAsync<AddSubStructureTasksResponse>(req, "AddSubStructureTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAutoClassifyStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoClassifyStructureTaskRequest"/></param>
        /// <returns><see cref="CreateAutoClassifyStructureTaskResponse"/></returns>
        public Task<CreateAutoClassifyStructureTaskResponse> CreateAutoClassifyStructureTask(CreateAutoClassifyStructureTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoClassifyStructureTaskResponse>(req, "CreateAutoClassifyStructureTask");
        }

        /// <summary>
        /// 本接口(CreateAutoClassifyStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateAutoClassifyStructureTaskRequest"/></param>
        /// <returns><see cref="CreateAutoClassifyStructureTaskResponse"/></returns>
        public CreateAutoClassifyStructureTaskResponse CreateAutoClassifyStructureTaskSync(CreateAutoClassifyStructureTaskRequest req)
        {
            return InternalRequestAsync<CreateAutoClassifyStructureTaskResponse>(req, "CreateAutoClassifyStructureTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public Task<CreateStructureTaskResponse> CreateStructureTask(CreateStructureTaskRequest req)
        {
            return InternalRequestAsync<CreateStructureTaskResponse>(req, "CreateStructureTask");
        }

        /// <summary>
        /// 本接口(CreateStructureTask)基于提供的客户及保单信息，创建并启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public CreateStructureTaskResponse CreateStructureTaskSync(CreateStructureTaskRequest req)
        {
            return InternalRequestAsync<CreateStructureTaskResponse>(req, "CreateStructureTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateUnderwriteTaskById)用于根据结构化任务ID创建核保任务
        /// </summary>
        /// <param name="req"><see cref="CreateUnderwriteTaskByIdRequest"/></param>
        /// <returns><see cref="CreateUnderwriteTaskByIdResponse"/></returns>
        public Task<CreateUnderwriteTaskByIdResponse> CreateUnderwriteTaskById(CreateUnderwriteTaskByIdRequest req)
        {
            return InternalRequestAsync<CreateUnderwriteTaskByIdResponse>(req, "CreateUnderwriteTaskById");
        }

        /// <summary>
        /// 本接口(CreateUnderwriteTaskById)用于根据结构化任务ID创建核保任务
        /// </summary>
        /// <param name="req"><see cref="CreateUnderwriteTaskByIdRequest"/></param>
        /// <returns><see cref="CreateUnderwriteTaskByIdResponse"/></returns>
        public CreateUnderwriteTaskByIdResponse CreateUnderwriteTaskByIdSync(CreateUnderwriteTaskByIdRequest req)
        {
            return InternalRequestAsync<CreateUnderwriteTaskByIdResponse>(req, "CreateUnderwriteTaskById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeMachineUnderwrite)用于查询机器核保任务数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineUnderwriteRequest"/></param>
        /// <returns><see cref="DescribeMachineUnderwriteResponse"/></returns>
        public Task<DescribeMachineUnderwriteResponse> DescribeMachineUnderwrite(DescribeMachineUnderwriteRequest req)
        {
            return InternalRequestAsync<DescribeMachineUnderwriteResponse>(req, "DescribeMachineUnderwrite");
        }

        /// <summary>
        /// 本接口(DescribeMachineUnderwrite)用于查询机器核保任务数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineUnderwriteRequest"/></param>
        /// <returns><see cref="DescribeMachineUnderwriteResponse"/></returns>
        public DescribeMachineUnderwriteResponse DescribeMachineUnderwriteSync(DescribeMachineUnderwriteRequest req)
        {
            return InternalRequestAsync<DescribeMachineUnderwriteResponse>(req, "DescribeMachineUnderwrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取图片质量分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public Task<DescribeQualityScoreResponse> DescribeQualityScore(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore");
        }

        /// <summary>
        /// 获取图片质量分
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityScoreRequest"/></param>
        /// <returns><see cref="DescribeQualityScoreResponse"/></returns>
        public DescribeQualityScoreResponse DescribeQualityScoreSync(DescribeQualityScoreRequest req)
        {
            return InternalRequestAsync<DescribeQualityScoreResponse>(req, "DescribeQualityScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 辅助用户对批量报告自动分类
        /// </summary>
        /// <param name="req"><see cref="DescribeReportClassifyRequest"/></param>
        /// <returns><see cref="DescribeReportClassifyResponse"/></returns>
        public Task<DescribeReportClassifyResponse> DescribeReportClassify(DescribeReportClassifyRequest req)
        {
            return InternalRequestAsync<DescribeReportClassifyResponse>(req, "DescribeReportClassify");
        }

        /// <summary>
        /// 辅助用户对批量报告自动分类
        /// </summary>
        /// <param name="req"><see cref="DescribeReportClassifyRequest"/></param>
        /// <returns><see cref="DescribeReportClassifyResponse"/></returns>
        public DescribeReportClassifyResponse DescribeReportClassifySync(DescribeReportClassifyRequest req)
        {
            return InternalRequestAsync<DescribeReportClassifyResponse>(req, "DescribeReportClassify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public Task<DescribeStructCompareDataResponse> DescribeStructCompareData(DescribeStructCompareDataRequest req)
        {
            return InternalRequestAsync<DescribeStructCompareDataResponse>(req, "DescribeStructCompareData");
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public DescribeStructCompareDataResponse DescribeStructCompareDataSync(DescribeStructCompareDataRequest req)
        {
            return InternalRequestAsync<DescribeStructCompareDataResponse>(req, "DescribeStructCompareData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 结构化复核差异查询接口，对比结构化复核前后数据差异，返回差异的部分。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureDifferenceRequest"/></param>
        /// <returns><see cref="DescribeStructureDifferenceResponse"/></returns>
        public Task<DescribeStructureDifferenceResponse> DescribeStructureDifference(DescribeStructureDifferenceRequest req)
        {
            return InternalRequestAsync<DescribeStructureDifferenceResponse>(req, "DescribeStructureDifference");
        }

        /// <summary>
        /// 结构化复核差异查询接口，对比结构化复核前后数据差异，返回差异的部分。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureDifferenceRequest"/></param>
        /// <returns><see cref="DescribeStructureDifferenceResponse"/></returns>
        public DescribeStructureDifferenceResponse DescribeStructureDifferenceSync(DescribeStructureDifferenceRequest req)
        {
            return InternalRequestAsync<DescribeStructureDifferenceResponse>(req, "DescribeStructureDifference")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeStructureResult)用于查询结构化结果接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureResultRequest"/></param>
        /// <returns><see cref="DescribeStructureResultResponse"/></returns>
        public Task<DescribeStructureResultResponse> DescribeStructureResult(DescribeStructureResultRequest req)
        {
            return InternalRequestAsync<DescribeStructureResultResponse>(req, "DescribeStructureResult");
        }

        /// <summary>
        /// 本接口(DescribeStructureResult)用于查询结构化结果接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureResultRequest"/></param>
        /// <returns><see cref="DescribeStructureResultResponse"/></returns>
        public DescribeStructureResultResponse DescribeStructureResultSync(DescribeStructureResultRequest req)
        {
            return InternalRequestAsync<DescribeStructureResultResponse>(req, "DescribeStructureResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public Task<DescribeStructureTaskResultResponse> DescribeStructureTaskResult(DescribeStructureTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeStructureTaskResultResponse>(req, "DescribeStructureTaskResult");
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public DescribeStructureTaskResultResponse DescribeStructureTaskResultSync(DescribeStructureTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeStructureTaskResultResponse>(req, "DescribeStructureTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeUnderwriteTask)用于查询核保任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeUnderwriteTaskRequest"/></param>
        /// <returns><see cref="DescribeUnderwriteTaskResponse"/></returns>
        public Task<DescribeUnderwriteTaskResponse> DescribeUnderwriteTask(DescribeUnderwriteTaskRequest req)
        {
            return InternalRequestAsync<DescribeUnderwriteTaskResponse>(req, "DescribeUnderwriteTask");
        }

        /// <summary>
        /// 本接口(DescribeUnderwriteTask)用于查询核保任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeUnderwriteTaskRequest"/></param>
        /// <returns><see cref="DescribeUnderwriteTaskResponse"/></returns>
        public DescribeUnderwriteTaskResponse DescribeUnderwriteTaskSync(DescribeUnderwriteTaskRequest req)
        {
            return InternalRequestAsync<DescribeUnderwriteTaskResponse>(req, "DescribeUnderwriteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传医疗影像文件，可以用来做结构化。
        /// </summary>
        /// <param name="req"><see cref="UploadMedicalFileRequest"/></param>
        /// <returns><see cref="UploadMedicalFileResponse"/></returns>
        public Task<UploadMedicalFileResponse> UploadMedicalFile(UploadMedicalFileRequest req)
        {
            return InternalRequestAsync<UploadMedicalFileResponse>(req, "UploadMedicalFile");
        }

        /// <summary>
        /// 上传医疗影像文件，可以用来做结构化。
        /// </summary>
        /// <param name="req"><see cref="UploadMedicalFileRequest"/></param>
        /// <returns><see cref="UploadMedicalFileResponse"/></returns>
        public UploadMedicalFileResponse UploadMedicalFileSync(UploadMedicalFileRequest req)
        {
            return InternalRequestAsync<UploadMedicalFileResponse>(req, "UploadMedicalFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
