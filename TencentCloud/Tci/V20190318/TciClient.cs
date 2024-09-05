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

namespace TencentCloud.Tci.V20190318
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tci.V20190318.Models;

   public class TciClient : AbstractClient{

       private const string endpoint = "tci.tencentcloudapi.com";
       private const string version = "2019-03-18";
       private const string sdkVersion = "SDK_NET_3.0.1082";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TciClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TciClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提供 AI 助教基础版本功能接口
        /// </summary>
        /// <param name="req"><see cref="AIAssistantRequest"/></param>
        /// <returns><see cref="AIAssistantResponse"/></returns>
        public Task<AIAssistantResponse> AIAssistant(AIAssistantRequest req)
        {
            return InternalRequestAsync<AIAssistantResponse>(req, "AIAssistant");
        }

        /// <summary>
        /// 提供 AI 助教基础版本功能接口
        /// </summary>
        /// <param name="req"><see cref="AIAssistantRequest"/></param>
        /// <returns><see cref="AIAssistantResponse"/></returns>
        public AIAssistantResponse AIAssistantSync(AIAssistantRequest req)
        {
            return InternalRequestAsync<AIAssistantResponse>(req, "AIAssistant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于取消已经提交的任务，目前只支持图像任务。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask");
        }

        /// <summary>
        /// 用于取消已经提交的任务，目前只支持图像任务。
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查人脸图片是否合法
        /// </summary>
        /// <param name="req"><see cref="CheckFacePhotoRequest"/></param>
        /// <returns><see cref="CheckFacePhotoResponse"/></returns>
        public Task<CheckFacePhotoResponse> CheckFacePhoto(CheckFacePhotoRequest req)
        {
            return InternalRequestAsync<CheckFacePhotoResponse>(req, "CheckFacePhoto");
        }

        /// <summary>
        /// 检查人脸图片是否合法
        /// </summary>
        /// <param name="req"><see cref="CheckFacePhotoRequest"/></param>
        /// <returns><see cref="CheckFacePhotoResponse"/></returns>
        public CheckFacePhotoResponse CheckFacePhotoSync(CheckFacePhotoRequest req)
        {
            return InternalRequestAsync<CheckFacePhotoResponse>(req, "CheckFacePhoto")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建人脸
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
            return InternalRequestAsync<CreateFaceResponse>(req, "CreateFace");
        }

        /// <summary>
        /// 创建人脸
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public CreateFaceResponse CreateFaceSync(CreateFaceRequest req)
        {
            return InternalRequestAsync<CreateFaceResponse>(req, "CreateFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建人员库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest req)
        {
            return InternalRequestAsync<CreateLibraryResponse>(req, "CreateLibrary");
        }

        /// <summary>
        /// 创建人员库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public CreateLibraryResponse CreateLibrarySync(CreateLibraryRequest req)
        {
            return InternalRequestAsync<CreateLibraryResponse>(req, "CreateLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建人员
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson");
        }

        /// <summary>
        /// 创建人员
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public CreatePersonResponse CreatePersonSync(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建词汇
        /// </summary>
        /// <param name="req"><see cref="CreateVocabRequest"/></param>
        /// <returns><see cref="CreateVocabResponse"/></returns>
        public Task<CreateVocabResponse> CreateVocab(CreateVocabRequest req)
        {
            return InternalRequestAsync<CreateVocabResponse>(req, "CreateVocab");
        }

        /// <summary>
        /// 创建词汇
        /// </summary>
        /// <param name="req"><see cref="CreateVocabRequest"/></param>
        /// <returns><see cref="CreateVocabResponse"/></returns>
        public CreateVocabResponse CreateVocabSync(CreateVocabRequest req)
        {
            return InternalRequestAsync<CreateVocabResponse>(req, "CreateVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 建立词汇库
        /// </summary>
        /// <param name="req"><see cref="CreateVocabLibRequest"/></param>
        /// <returns><see cref="CreateVocabLibResponse"/></returns>
        public Task<CreateVocabLibResponse> CreateVocabLib(CreateVocabLibRequest req)
        {
            return InternalRequestAsync<CreateVocabLibResponse>(req, "CreateVocabLib");
        }

        /// <summary>
        /// 建立词汇库
        /// </summary>
        /// <param name="req"><see cref="CreateVocabLibRequest"/></param>
        /// <returns><see cref="CreateVocabLibResponse"/></returns>
        public CreateVocabLibResponse CreateVocabLibSync(CreateVocabLibRequest req)
        {
            return InternalRequestAsync<CreateVocabLibResponse>(req, "CreateVocabLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除人脸
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
            return InternalRequestAsync<DeleteFaceResponse>(req, "DeleteFace");
        }

        /// <summary>
        /// 删除人脸
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public DeleteFaceResponse DeleteFaceSync(DeleteFaceRequest req)
        {
            return InternalRequestAsync<DeleteFaceResponse>(req, "DeleteFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除人员库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public Task<DeleteLibraryResponse> DeleteLibrary(DeleteLibraryRequest req)
        {
            return InternalRequestAsync<DeleteLibraryResponse>(req, "DeleteLibrary");
        }

        /// <summary>
        /// 删除人员库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public DeleteLibraryResponse DeleteLibrarySync(DeleteLibraryRequest req)
        {
            return InternalRequestAsync<DeleteLibraryResponse>(req, "DeleteLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson");
        }

        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除词汇
        /// </summary>
        /// <param name="req"><see cref="DeleteVocabRequest"/></param>
        /// <returns><see cref="DeleteVocabResponse"/></returns>
        public Task<DeleteVocabResponse> DeleteVocab(DeleteVocabRequest req)
        {
            return InternalRequestAsync<DeleteVocabResponse>(req, "DeleteVocab");
        }

        /// <summary>
        /// 删除词汇
        /// </summary>
        /// <param name="req"><see cref="DeleteVocabRequest"/></param>
        /// <returns><see cref="DeleteVocabResponse"/></returns>
        public DeleteVocabResponse DeleteVocabSync(DeleteVocabRequest req)
        {
            return InternalRequestAsync<DeleteVocabResponse>(req, "DeleteVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除词汇库
        /// </summary>
        /// <param name="req"><see cref="DeleteVocabLibRequest"/></param>
        /// <returns><see cref="DeleteVocabLibResponse"/></returns>
        public Task<DeleteVocabLibResponse> DeleteVocabLib(DeleteVocabLibRequest req)
        {
            return InternalRequestAsync<DeleteVocabLibResponse>(req, "DeleteVocabLib");
        }

        /// <summary>
        /// 删除词汇库
        /// </summary>
        /// <param name="req"><see cref="DeleteVocabLibRequest"/></param>
        /// <returns><see cref="DeleteVocabLibResponse"/></returns>
        public DeleteVocabLibResponse DeleteVocabLibSync(DeleteVocabLibRequest req)
        {
            return InternalRequestAsync<DeleteVocabLibResponse>(req, "DeleteVocabLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取标准化接口任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public Task<DescribeAITaskResultResponse> DescribeAITaskResult(DescribeAITaskResultRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResultResponse>(req, "DescribeAITaskResult");
        }

        /// <summary>
        /// 获取标准化接口任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public DescribeAITaskResultResponse DescribeAITaskResultSync(DescribeAITaskResultRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResultResponse>(req, "DescribeAITaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 人脸考勤查询结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAttendanceResultRequest"/></param>
        /// <returns><see cref="DescribeAttendanceResultResponse"/></returns>
        public Task<DescribeAttendanceResultResponse> DescribeAttendanceResult(DescribeAttendanceResultRequest req)
        {
            return InternalRequestAsync<DescribeAttendanceResultResponse>(req, "DescribeAttendanceResult");
        }

        /// <summary>
        /// 人脸考勤查询结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAttendanceResultRequest"/></param>
        /// <returns><see cref="DescribeAttendanceResultResponse"/></returns>
        public DescribeAttendanceResultResponse DescribeAttendanceResultSync(DescribeAttendanceResultRequest req)
        {
            return InternalRequestAsync<DescribeAttendanceResultResponse>(req, "DescribeAttendanceResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 音频评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAudioTaskRequest"/></param>
        /// <returns><see cref="DescribeAudioTaskResponse"/></returns>
        public Task<DescribeAudioTaskResponse> DescribeAudioTask(DescribeAudioTaskRequest req)
        {
            return InternalRequestAsync<DescribeAudioTaskResponse>(req, "DescribeAudioTask");
        }

        /// <summary>
        /// 音频评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeAudioTaskRequest"/></param>
        /// <returns><see cref="DescribeAudioTaskResponse"/></returns>
        public DescribeAudioTaskResponse DescribeAudioTaskSync(DescribeAudioTaskRequest req)
        {
            return InternalRequestAsync<DescribeAudioTaskResponse>(req, "DescribeAudioTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 音频对话任务评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationTaskRequest"/></param>
        /// <returns><see cref="DescribeConversationTaskResponse"/></returns>
        public Task<DescribeConversationTaskResponse> DescribeConversationTask(DescribeConversationTaskRequest req)
        {
            return InternalRequestAsync<DescribeConversationTaskResponse>(req, "DescribeConversationTask");
        }

        /// <summary>
        /// 音频对话任务评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationTaskRequest"/></param>
        /// <returns><see cref="DescribeConversationTaskResponse"/></returns>
        public DescribeConversationTaskResponse DescribeConversationTaskSync(DescribeConversationTaskRequest req)
        {
            return InternalRequestAsync<DescribeConversationTaskResponse>(req, "DescribeConversationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 视频精彩集锦结果查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeHighlightResultRequest"/></param>
        /// <returns><see cref="DescribeHighlightResultResponse"/></returns>
        public Task<DescribeHighlightResultResponse> DescribeHighlightResult(DescribeHighlightResultRequest req)
        {
            return InternalRequestAsync<DescribeHighlightResultResponse>(req, "DescribeHighlightResult");
        }

        /// <summary>
        /// 视频精彩集锦结果查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeHighlightResultRequest"/></param>
        /// <returns><see cref="DescribeHighlightResultResponse"/></returns>
        public DescribeHighlightResultResponse DescribeHighlightResultSync(DescribeHighlightResultRequest req)
        {
            return InternalRequestAsync<DescribeHighlightResultResponse>(req, "DescribeHighlightResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTaskRequest"/></param>
        /// <returns><see cref="DescribeImageTaskResponse"/></returns>
        public Task<DescribeImageTaskResponse> DescribeImageTask(DescribeImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeImageTaskResponse>(req, "DescribeImageTask");
        }

        /// <summary>
        /// 拉取任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTaskRequest"/></param>
        /// <returns><see cref="DescribeImageTaskResponse"/></returns>
        public DescribeImageTaskResponse DescribeImageTaskSync(DescribeImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeImageTaskResponse>(req, "DescribeImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取图像任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTaskStatisticRequest"/></param>
        /// <returns><see cref="DescribeImageTaskStatisticResponse"/></returns>
        public Task<DescribeImageTaskStatisticResponse> DescribeImageTaskStatistic(DescribeImageTaskStatisticRequest req)
        {
            return InternalRequestAsync<DescribeImageTaskStatisticResponse>(req, "DescribeImageTaskStatistic");
        }

        /// <summary>
        /// 获取图像任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageTaskStatisticRequest"/></param>
        /// <returns><see cref="DescribeImageTaskStatisticResponse"/></returns>
        public DescribeImageTaskStatisticResponse DescribeImageTaskStatisticSync(DescribeImageTaskStatisticRequest req)
        {
            return InternalRequestAsync<DescribeImageTaskStatisticResponse>(req, "DescribeImageTaskStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取人员库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public Task<DescribeLibrariesResponse> DescribeLibraries(DescribeLibrariesRequest req)
        {
            return InternalRequestAsync<DescribeLibrariesResponse>(req, "DescribeLibraries");
        }

        /// <summary>
        /// 获取人员库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public DescribeLibrariesResponse DescribeLibrariesSync(DescribeLibrariesRequest req)
        {
            return InternalRequestAsync<DescribeLibrariesResponse>(req, "DescribeLibraries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取人员详情
        /// </summary>
        /// <param name="req"><see cref="DescribePersonRequest"/></param>
        /// <returns><see cref="DescribePersonResponse"/></returns>
        public Task<DescribePersonResponse> DescribePerson(DescribePersonRequest req)
        {
            return InternalRequestAsync<DescribePersonResponse>(req, "DescribePerson");
        }

        /// <summary>
        /// 获取人员详情
        /// </summary>
        /// <param name="req"><see cref="DescribePersonRequest"/></param>
        /// <returns><see cref="DescribePersonResponse"/></returns>
        public DescribePersonResponse DescribePersonSync(DescribePersonRequest req)
        {
            return InternalRequestAsync<DescribePersonResponse>(req, "DescribePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribePersonsRequest"/></param>
        /// <returns><see cref="DescribePersonsResponse"/></returns>
        public Task<DescribePersonsResponse> DescribePersons(DescribePersonsRequest req)
        {
            return InternalRequestAsync<DescribePersonsResponse>(req, "DescribePersons");
        }

        /// <summary>
        /// 拉取人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribePersonsRequest"/></param>
        /// <returns><see cref="DescribePersonsResponse"/></returns>
        public DescribePersonsResponse DescribePersonsSync(DescribePersonsRequest req)
        {
            return InternalRequestAsync<DescribePersonsResponse>(req, "DescribePersons")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询词汇
        /// </summary>
        /// <param name="req"><see cref="DescribeVocabRequest"/></param>
        /// <returns><see cref="DescribeVocabResponse"/></returns>
        public Task<DescribeVocabResponse> DescribeVocab(DescribeVocabRequest req)
        {
            return InternalRequestAsync<DescribeVocabResponse>(req, "DescribeVocab");
        }

        /// <summary>
        /// 查询词汇
        /// </summary>
        /// <param name="req"><see cref="DescribeVocabRequest"/></param>
        /// <returns><see cref="DescribeVocabResponse"/></returns>
        public DescribeVocabResponse DescribeVocabSync(DescribeVocabRequest req)
        {
            return InternalRequestAsync<DescribeVocabResponse>(req, "DescribeVocab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询词汇库
        /// </summary>
        /// <param name="req"><see cref="DescribeVocabLibRequest"/></param>
        /// <returns><see cref="DescribeVocabLibResponse"/></returns>
        public Task<DescribeVocabLibResponse> DescribeVocabLib(DescribeVocabLibRequest req)
        {
            return InternalRequestAsync<DescribeVocabLibResponse>(req, "DescribeVocabLib");
        }

        /// <summary>
        /// 查询词汇库
        /// </summary>
        /// <param name="req"><see cref="DescribeVocabLibRequest"/></param>
        /// <returns><see cref="DescribeVocabLibResponse"/></returns>
        public DescribeVocabLibResponse DescribeVocabLibSync(DescribeVocabLibRequest req)
        {
            return InternalRequestAsync<DescribeVocabLibResponse>(req, "DescribeVocabLib")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改人员库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public Task<ModifyLibraryResponse> ModifyLibrary(ModifyLibraryRequest req)
        {
            return InternalRequestAsync<ModifyLibraryResponse>(req, "ModifyLibrary");
        }

        /// <summary>
        /// 修改人员库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public ModifyLibraryResponse ModifyLibrarySync(ModifyLibraryRequest req)
        {
            return InternalRequestAsync<ModifyLibraryResponse>(req, "ModifyLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonRequest"/></param>
        /// <returns><see cref="ModifyPersonResponse"/></returns>
        public Task<ModifyPersonResponse> ModifyPerson(ModifyPersonRequest req)
        {
            return InternalRequestAsync<ModifyPersonResponse>(req, "ModifyPerson");
        }

        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonRequest"/></param>
        /// <returns><see cref="ModifyPersonResponse"/></returns>
        public ModifyPersonResponse ModifyPersonSync(ModifyPersonRequest req)
        {
            return InternalRequestAsync<ModifyPersonResponse>(req, "ModifyPerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 音频任务提交接口
        /// </summary>
        /// <param name="req"><see cref="SubmitAudioTaskRequest"/></param>
        /// <returns><see cref="SubmitAudioTaskResponse"/></returns>
        public Task<SubmitAudioTaskResponse> SubmitAudioTask(SubmitAudioTaskRequest req)
        {
            return InternalRequestAsync<SubmitAudioTaskResponse>(req, "SubmitAudioTask");
        }

        /// <summary>
        /// 音频任务提交接口
        /// </summary>
        /// <param name="req"><see cref="SubmitAudioTaskRequest"/></param>
        /// <returns><see cref="SubmitAudioTaskResponse"/></returns>
        public SubmitAudioTaskResponse SubmitAudioTaskSync(SubmitAudioTaskRequest req)
        {
            return InternalRequestAsync<SubmitAudioTaskResponse>(req, "SubmitAudioTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交人员考勤任务，支持包括点播和直播资源；支持通过DescribeAttendanceResult查询结果，也支持通过NoticeUrl设置考勤回调结果，回调结果结构如下：
        /// ##### 回调事件结构
        ///  | 参数名称 | 类型 | 描述 | 
        ///  | ----  | ---  | ------  |
        ///  | jobid | Integer | 任务ID | 
        ///  | person_info | array of PersonInfo | 识别到的人员列表 | 
        /// #####子结构PersonInfo
        ///  | 参数名称 | 类型 | 描述 | 
        ///  | ----  | ---  | ------  |
        ///  | traceid | String | 可用于区分同一路视频流下的不同陌生人 | 
        ///  | personid | String | 识别到的人员ID，如果是陌生人则返回空串 | 
        ///  | libid | String | 识别到的人员所在的库ID，如果是陌生人则返回空串 | 
        ///  | timestamp | uint64 | 识别到人脸的绝对时间戳，单位ms | 
        ///  | image_url | string | 识别到人脸的事件抓图的下载地址，不长期保存，需要请及时下载 | 
        /// </summary>
        /// <param name="req"><see cref="SubmitCheckAttendanceTaskRequest"/></param>
        /// <returns><see cref="SubmitCheckAttendanceTaskResponse"/></returns>
        public Task<SubmitCheckAttendanceTaskResponse> SubmitCheckAttendanceTask(SubmitCheckAttendanceTaskRequest req)
        {
            return InternalRequestAsync<SubmitCheckAttendanceTaskResponse>(req, "SubmitCheckAttendanceTask");
        }

        /// <summary>
        /// 提交人员考勤任务，支持包括点播和直播资源；支持通过DescribeAttendanceResult查询结果，也支持通过NoticeUrl设置考勤回调结果，回调结果结构如下：
        /// ##### 回调事件结构
        ///  | 参数名称 | 类型 | 描述 | 
        ///  | ----  | ---  | ------  |
        ///  | jobid | Integer | 任务ID | 
        ///  | person_info | array of PersonInfo | 识别到的人员列表 | 
        /// #####子结构PersonInfo
        ///  | 参数名称 | 类型 | 描述 | 
        ///  | ----  | ---  | ------  |
        ///  | traceid | String | 可用于区分同一路视频流下的不同陌生人 | 
        ///  | personid | String | 识别到的人员ID，如果是陌生人则返回空串 | 
        ///  | libid | String | 识别到的人员所在的库ID，如果是陌生人则返回空串 | 
        ///  | timestamp | uint64 | 识别到人脸的绝对时间戳，单位ms | 
        ///  | image_url | string | 识别到人脸的事件抓图的下载地址，不长期保存，需要请及时下载 | 
        /// </summary>
        /// <param name="req"><see cref="SubmitCheckAttendanceTaskRequest"/></param>
        /// <returns><see cref="SubmitCheckAttendanceTaskResponse"/></returns>
        public SubmitCheckAttendanceTaskResponse SubmitCheckAttendanceTaskSync(SubmitCheckAttendanceTaskRequest req)
        {
            return InternalRequestAsync<SubmitCheckAttendanceTaskResponse>(req, "SubmitCheckAttendanceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持多路视频流，提交高级人员考勤任务
        /// </summary>
        /// <param name="req"><see cref="SubmitCheckAttendanceTaskPlusRequest"/></param>
        /// <returns><see cref="SubmitCheckAttendanceTaskPlusResponse"/></returns>
        public Task<SubmitCheckAttendanceTaskPlusResponse> SubmitCheckAttendanceTaskPlus(SubmitCheckAttendanceTaskPlusRequest req)
        {
            return InternalRequestAsync<SubmitCheckAttendanceTaskPlusResponse>(req, "SubmitCheckAttendanceTaskPlus");
        }

        /// <summary>
        /// 支持多路视频流，提交高级人员考勤任务
        /// </summary>
        /// <param name="req"><see cref="SubmitCheckAttendanceTaskPlusRequest"/></param>
        /// <returns><see cref="SubmitCheckAttendanceTaskPlusResponse"/></returns>
        public SubmitCheckAttendanceTaskPlusResponse SubmitCheckAttendanceTaskPlusSync(SubmitCheckAttendanceTaskPlusRequest req)
        {
            return InternalRequestAsync<SubmitCheckAttendanceTaskPlusResponse>(req, "SubmitCheckAttendanceTaskPlus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对话任务分析接口
        /// </summary>
        /// <param name="req"><see cref="SubmitConversationTaskRequest"/></param>
        /// <returns><see cref="SubmitConversationTaskResponse"/></returns>
        public Task<SubmitConversationTaskResponse> SubmitConversationTask(SubmitConversationTaskRequest req)
        {
            return InternalRequestAsync<SubmitConversationTaskResponse>(req, "SubmitConversationTask");
        }

        /// <summary>
        /// 对话任务分析接口
        /// </summary>
        /// <param name="req"><see cref="SubmitConversationTaskRequest"/></param>
        /// <returns><see cref="SubmitConversationTaskResponse"/></returns>
        public SubmitConversationTaskResponse SubmitConversationTaskSync(SubmitConversationTaskRequest req)
        {
            return InternalRequestAsync<SubmitConversationTaskResponse>(req, "SubmitConversationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起双路视频生成精彩集锦接口。该接口可以通过客户传入的学生音视频及老师视频两路Url，自动生成一堂课程的精彩集锦。需要通过DescribeHighlightResult
        /// 接口获取生成结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitDoubleVideoHighlightsRequest"/></param>
        /// <returns><see cref="SubmitDoubleVideoHighlightsResponse"/></returns>
        public Task<SubmitDoubleVideoHighlightsResponse> SubmitDoubleVideoHighlights(SubmitDoubleVideoHighlightsRequest req)
        {
            return InternalRequestAsync<SubmitDoubleVideoHighlightsResponse>(req, "SubmitDoubleVideoHighlights");
        }

        /// <summary>
        /// 发起双路视频生成精彩集锦接口。该接口可以通过客户传入的学生音视频及老师视频两路Url，自动生成一堂课程的精彩集锦。需要通过DescribeHighlightResult
        /// 接口获取生成结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitDoubleVideoHighlightsRequest"/></param>
        /// <returns><see cref="SubmitDoubleVideoHighlightsResponse"/></returns>
        public SubmitDoubleVideoHighlightsResponse SubmitDoubleVideoHighlightsSync(SubmitDoubleVideoHighlightsRequest req)
        {
            return InternalRequestAsync<SubmitDoubleVideoHighlightsResponse>(req, "SubmitDoubleVideoHighlights")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **传统课堂授课任务**：在此场景中，老师为站立授课，有白板或投影供老师展示课程内容，摄像头可以拍摄到老师的半身或者全身。拍摄视频为一路全局画面，且背景不动，要求画面稳定清晰。通过此接口可分析老师授课的行为及语音，以支持AI评教。  
        ///   
        /// **提供的功能接口有：**老师人脸识别、老师表情识别、老师肢体动作识别、语音识别。  可分析的指标维度包括：身份识别、正脸、侧脸、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、正面讲解、写板书、指黑板、语音转文字、发音时长、非发音时长、音量、语速、指定关键词的使用等
        ///   
        /// **对场景的要求为：**真实场景老师1人出现在画面中，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitFullBodyClassTaskRequest"/></param>
        /// <returns><see cref="SubmitFullBodyClassTaskResponse"/></returns>
        public Task<SubmitFullBodyClassTaskResponse> SubmitFullBodyClassTask(SubmitFullBodyClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitFullBodyClassTaskResponse>(req, "SubmitFullBodyClassTask");
        }

        /// <summary>
        /// **传统课堂授课任务**：在此场景中，老师为站立授课，有白板或投影供老师展示课程内容，摄像头可以拍摄到老师的半身或者全身。拍摄视频为一路全局画面，且背景不动，要求画面稳定清晰。通过此接口可分析老师授课的行为及语音，以支持AI评教。  
        ///   
        /// **提供的功能接口有：**老师人脸识别、老师表情识别、老师肢体动作识别、语音识别。  可分析的指标维度包括：身份识别、正脸、侧脸、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、正面讲解、写板书、指黑板、语音转文字、发音时长、非发音时长、音量、语速、指定关键词的使用等
        ///   
        /// **对场景的要求为：**真实场景老师1人出现在画面中，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitFullBodyClassTaskRequest"/></param>
        /// <returns><see cref="SubmitFullBodyClassTaskResponse"/></returns>
        public SubmitFullBodyClassTaskResponse SubmitFullBodyClassTaskSync(SubmitFullBodyClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitFullBodyClassTaskResponse>(req, "SubmitFullBodyClassTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起视频生成精彩集锦接口。该接口可以通过客户传入的课程音频数据及相关策略（如微笑抽取，专注抽取等），自动生成一堂课程的精彩集锦。需要通过QueryHighlightResult接口获取生成结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitHighlightsRequest"/></param>
        /// <returns><see cref="SubmitHighlightsResponse"/></returns>
        public Task<SubmitHighlightsResponse> SubmitHighlights(SubmitHighlightsRequest req)
        {
            return InternalRequestAsync<SubmitHighlightsResponse>(req, "SubmitHighlights");
        }

        /// <summary>
        /// 发起视频生成精彩集锦接口。该接口可以通过客户传入的课程音频数据及相关策略（如微笑抽取，专注抽取等），自动生成一堂课程的精彩集锦。需要通过QueryHighlightResult接口获取生成结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitHighlightsRequest"/></param>
        /// <returns><see cref="SubmitHighlightsResponse"/></returns>
        public SubmitHighlightsResponse SubmitHighlightsSync(SubmitHighlightsRequest req)
        {
            return InternalRequestAsync<SubmitHighlightsResponse>(req, "SubmitHighlights")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交图像分析任务
        /// </summary>
        /// <param name="req"><see cref="SubmitImageTaskRequest"/></param>
        /// <returns><see cref="SubmitImageTaskResponse"/></returns>
        public Task<SubmitImageTaskResponse> SubmitImageTask(SubmitImageTaskRequest req)
        {
            return InternalRequestAsync<SubmitImageTaskResponse>(req, "SubmitImageTask");
        }

        /// <summary>
        /// 提交图像分析任务
        /// </summary>
        /// <param name="req"><see cref="SubmitImageTaskRequest"/></param>
        /// <returns><see cref="SubmitImageTaskResponse"/></returns>
        public SubmitImageTaskResponse SubmitImageTaskSync(SubmitImageTaskRequest req)
        {
            return InternalRequestAsync<SubmitImageTaskResponse>(req, "SubmitImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高级图像分析任务，开放了图像任务里的所有开关，可以根据场景深度定制图像分析任务。支持的图像类别有，图片链接、图片二进制数据、点播链接和直播链接。
        /// </summary>
        /// <param name="req"><see cref="SubmitImageTaskPlusRequest"/></param>
        /// <returns><see cref="SubmitImageTaskPlusResponse"/></returns>
        public Task<SubmitImageTaskPlusResponse> SubmitImageTaskPlus(SubmitImageTaskPlusRequest req)
        {
            return InternalRequestAsync<SubmitImageTaskPlusResponse>(req, "SubmitImageTaskPlus");
        }

        /// <summary>
        /// 高级图像分析任务，开放了图像任务里的所有开关，可以根据场景深度定制图像分析任务。支持的图像类别有，图片链接、图片二进制数据、点播链接和直播链接。
        /// </summary>
        /// <param name="req"><see cref="SubmitImageTaskPlusRequest"/></param>
        /// <returns><see cref="SubmitImageTaskPlusResponse"/></returns>
        public SubmitImageTaskPlusResponse SubmitImageTaskPlusSync(SubmitImageTaskPlusRequest req)
        {
            return InternalRequestAsync<SubmitImageTaskPlusResponse>(req, "SubmitImageTaskPlus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **提交在线1对1课堂任务**  
        /// 对于在线1对1课堂，老师通过视频向学生授课，并且学生人数为1人。通过上传学生端的图像信息，可以获取学生的听课情况分析。 具体指一路全局画面且背景不动，有1位学生的头像或上半身的画面，要求画面稳定清晰。
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、语音识别。可分析的指标维度包括：学生身份识别、正脸、侧脸、抬头、低头、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、语音转文字、发音时长、非发音时长、音量、语速等。
        ///   
        /// **对场景的要求为：**真实常规1v1授课场景，学生2人以下，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitOneByOneClassTaskRequest"/></param>
        /// <returns><see cref="SubmitOneByOneClassTaskResponse"/></returns>
        public Task<SubmitOneByOneClassTaskResponse> SubmitOneByOneClassTask(SubmitOneByOneClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitOneByOneClassTaskResponse>(req, "SubmitOneByOneClassTask");
        }

        /// <summary>
        /// **提交在线1对1课堂任务**  
        /// 对于在线1对1课堂，老师通过视频向学生授课，并且学生人数为1人。通过上传学生端的图像信息，可以获取学生的听课情况分析。 具体指一路全局画面且背景不动，有1位学生的头像或上半身的画面，要求画面稳定清晰。
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、语音识别。可分析的指标维度包括：学生身份识别、正脸、侧脸、抬头、低头、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、语音转文字、发音时长、非发音时长、音量、语速等。
        ///   
        /// **对场景的要求为：**真实常规1v1授课场景，学生2人以下，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitOneByOneClassTaskRequest"/></param>
        /// <returns><see cref="SubmitOneByOneClassTaskResponse"/></returns>
        public SubmitOneByOneClassTaskResponse SubmitOneByOneClassTaskSync(SubmitOneByOneClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitOneByOneClassTaskResponse>(req, "SubmitOneByOneClassTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **提交线下小班（无课桌）课任务**  
        /// 线下小班课是指有学生无课桌的课堂，满座15人以下，全局画面且背景不动，能清晰看到。  
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、学生肢体动作识别。  可分析的指标维度包括：身份识别、正脸、侧脸、抬头、低头、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、站立、举手、坐着等。
        ///   
        /// **对场景的要求为：**真实常规教室，满座15人以下，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitOpenClassTaskRequest"/></param>
        /// <returns><see cref="SubmitOpenClassTaskResponse"/></returns>
        public Task<SubmitOpenClassTaskResponse> SubmitOpenClassTask(SubmitOpenClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitOpenClassTaskResponse>(req, "SubmitOpenClassTask");
        }

        /// <summary>
        /// **提交线下小班（无课桌）课任务**  
        /// 线下小班课是指有学生无课桌的课堂，满座15人以下，全局画面且背景不动，能清晰看到。  
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、学生肢体动作识别。  可分析的指标维度包括：身份识别、正脸、侧脸、抬头、低头、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、站立、举手、坐着等。
        ///   
        /// **对场景的要求为：**真实常规教室，满座15人以下，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitOpenClassTaskRequest"/></param>
        /// <returns><see cref="SubmitOpenClassTaskResponse"/></returns>
        public SubmitOpenClassTaskResponse SubmitOpenClassTaskSync(SubmitOpenClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitOpenClassTaskResponse>(req, "SubmitOpenClassTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **在线小班课任务**：此场景是在线授课场景，老师一般为坐着授课，摄像头可以拍摄到老师的头部及上半身。拍摄视频为一路全局画面，且背景不动，要求画面稳定清晰。通过此接口可分析老师授课的行为及语音，以支持AI评教。    
        ///   
        /// **提供的功能接口有：**老师人脸识别、老师表情识别、老师手势识别、光线识别、语音识别。 可分析的指标维度包括：身份识别、正脸、侧脸、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、点赞手势、听你说手势、听我说手势、拿教具行为、语音转文字、发音时长、非发音时长、音量、语速、指定关键词的使用等 
        ///   
        /// **对场景的要求为：**在线常规授课场景，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitPartialBodyClassTaskRequest"/></param>
        /// <returns><see cref="SubmitPartialBodyClassTaskResponse"/></returns>
        public Task<SubmitPartialBodyClassTaskResponse> SubmitPartialBodyClassTask(SubmitPartialBodyClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitPartialBodyClassTaskResponse>(req, "SubmitPartialBodyClassTask");
        }

        /// <summary>
        /// **在线小班课任务**：此场景是在线授课场景，老师一般为坐着授课，摄像头可以拍摄到老师的头部及上半身。拍摄视频为一路全局画面，且背景不动，要求画面稳定清晰。通过此接口可分析老师授课的行为及语音，以支持AI评教。    
        ///   
        /// **提供的功能接口有：**老师人脸识别、老师表情识别、老师手势识别、光线识别、语音识别。 可分析的指标维度包括：身份识别、正脸、侧脸、人脸坐标、人脸尺寸、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、点赞手势、听你说手势、听我说手势、拿教具行为、语音转文字、发音时长、非发音时长、音量、语速、指定关键词的使用等 
        ///   
        /// **对场景的要求为：**在线常规授课场景，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        /// </summary>
        /// <param name="req"><see cref="SubmitPartialBodyClassTaskRequest"/></param>
        /// <returns><see cref="SubmitPartialBodyClassTaskResponse"/></returns>
        public SubmitPartialBodyClassTaskResponse SubmitPartialBodyClassTaskSync(SubmitPartialBodyClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitPartialBodyClassTaskResponse>(req, "SubmitPartialBodyClassTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **提交线下传统面授大班课（含课桌）任务。**  
        /// 传统教室课堂是指有学生课堂有课桌的课堂，满座20-50人，全局画面且背景不动。  
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、学生肢体动作识别。可分析的指标维度包括：学生身份识别、正脸、侧脸、抬头、低头、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、举手、站立、坐着、趴桌子、玩手机等  
        ///   
        /// **对场景的要求为：**传统的学生上课教室，满座20-50人，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        ///   
        /// </summary>
        /// <param name="req"><see cref="SubmitTraditionalClassTaskRequest"/></param>
        /// <returns><see cref="SubmitTraditionalClassTaskResponse"/></returns>
        public Task<SubmitTraditionalClassTaskResponse> SubmitTraditionalClassTask(SubmitTraditionalClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitTraditionalClassTaskResponse>(req, "SubmitTraditionalClassTask");
        }

        /// <summary>
        /// **提交线下传统面授大班课（含课桌）任务。**  
        /// 传统教室课堂是指有学生课堂有课桌的课堂，满座20-50人，全局画面且背景不动。  
        ///   
        /// **提供的功能接口有：**学生人脸识别、学生表情识别、学生肢体动作识别。可分析的指标维度包括：学生身份识别、正脸、侧脸、抬头、低头、高兴、中性、高兴、中性、惊讶、厌恶、恐惧、愤怒、蔑视、悲伤、举手、站立、坐着、趴桌子、玩手机等  
        ///   
        /// **对场景的要求为：**传统的学生上课教室，满座20-50人，全局画面且背景不动；人脸上下角度在20度以内，左右角度在15度以内，歪头角度在15度以内；光照均匀，无遮挡，人脸清晰可见；像素最好在 100X100 像素以上，但是图像整体质量不能超过1080p。
        ///     
        /// **结果查询方式：**图像任务直接返回结果，点播及直播任务通过DescribeAITaskResult查询结果。
        ///   
        /// </summary>
        /// <param name="req"><see cref="SubmitTraditionalClassTaskRequest"/></param>
        /// <returns><see cref="SubmitTraditionalClassTaskResponse"/></returns>
        public SubmitTraditionalClassTaskResponse SubmitTraditionalClassTaskSync(SubmitTraditionalClassTaskRequest req)
        {
            return InternalRequestAsync<SubmitTraditionalClassTaskResponse>(req, "SubmitTraditionalClassTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分析音频信息
        /// </summary>
        /// <param name="req"><see cref="TransmitAudioStreamRequest"/></param>
        /// <returns><see cref="TransmitAudioStreamResponse"/></returns>
        public Task<TransmitAudioStreamResponse> TransmitAudioStream(TransmitAudioStreamRequest req)
        {
            return InternalRequestAsync<TransmitAudioStreamResponse>(req, "TransmitAudioStream");
        }

        /// <summary>
        /// 分析音频信息
        /// </summary>
        /// <param name="req"><see cref="TransmitAudioStreamRequest"/></param>
        /// <returns><see cref="TransmitAudioStreamResponse"/></returns>
        public TransmitAudioStreamResponse TransmitAudioStreamSync(TransmitAudioStreamRequest req)
        {
            return InternalRequestAsync<TransmitAudioStreamResponse>(req, "TransmitAudioStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
