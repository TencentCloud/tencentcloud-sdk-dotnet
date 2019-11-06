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

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TciClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TciClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 提供 AI 助教基础版本功能接口
        /// </summary>
        /// <param name="req">参考<see cref="AIAssistantRequest"/></param>
        /// <returns>参考<see cref="AIAssistantResponse"/>实例</returns>
        public async Task<AIAssistantResponse> AIAssistant(AIAssistantRequest req)
        {
             JsonResponseModel<AIAssistantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AIAssistant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AIAssistantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于取消已经提交的任务，目前只支持图像任务。
        /// </summary>
        /// <param name="req">参考<see cref="CancelTaskRequest"/></param>
        /// <returns>参考<see cref="CancelTaskResponse"/>实例</returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查人脸图片是否合法
        /// </summary>
        /// <param name="req">参考<see cref="CheckFacePhotoRequest"/></param>
        /// <returns>参考<see cref="CheckFacePhotoResponse"/>实例</returns>
        public async Task<CheckFacePhotoResponse> CheckFacePhoto(CheckFacePhotoRequest req)
        {
             JsonResponseModel<CheckFacePhotoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckFacePhoto");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFacePhotoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人脸
        /// </summary>
        /// <param name="req">参考<see cref="CreateFaceRequest"/></param>
        /// <returns>参考<see cref="CreateFaceResponse"/>实例</returns>
        public async Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员库
        /// </summary>
        /// <param name="req">参考<see cref="CreateLibraryRequest"/></param>
        /// <returns>参考<see cref="CreateLibraryResponse"/>实例</returns>
        public async Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest req)
        {
             JsonResponseModel<CreateLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonRequest"/></param>
        /// <returns>参考<see cref="CreatePersonResponse"/>实例</returns>
        public async Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建词汇
        /// </summary>
        /// <param name="req">参考<see cref="CreateVocabRequest"/></param>
        /// <returns>参考<see cref="CreateVocabResponse"/>实例</returns>
        public async Task<CreateVocabResponse> CreateVocab(CreateVocabRequest req)
        {
             JsonResponseModel<CreateVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 建立词汇库
        /// </summary>
        /// <param name="req">参考<see cref="CreateVocabLibRequest"/></param>
        /// <returns>参考<see cref="CreateVocabLibResponse"/>实例</returns>
        public async Task<CreateVocabLibResponse> CreateVocabLib(CreateVocabLibRequest req)
        {
             JsonResponseModel<CreateVocabLibResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVocabLib");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVocabLibResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除人脸
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFaceRequest"/></param>
        /// <returns>参考<see cref="DeleteFaceResponse"/>实例</returns>
        public async Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除人员库
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLibraryRequest"/></param>
        /// <returns>参考<see cref="DeleteLibraryResponse"/>实例</returns>
        public async Task<DeleteLibraryResponse> DeleteLibrary(DeleteLibraryRequest req)
        {
             JsonResponseModel<DeleteLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonRequest"/></param>
        /// <returns>参考<see cref="DeletePersonResponse"/>实例</returns>
        public async Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除词汇
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVocabRequest"/></param>
        /// <returns>参考<see cref="DeleteVocabResponse"/>实例</returns>
        public async Task<DeleteVocabResponse> DeleteVocab(DeleteVocabRequest req)
        {
             JsonResponseModel<DeleteVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除词汇库
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVocabLibRequest"/></param>
        /// <returns>参考<see cref="DeleteVocabLibResponse"/>实例</returns>
        public async Task<DeleteVocabLibResponse> DeleteVocabLib(DeleteVocabLibRequest req)
        {
             JsonResponseModel<DeleteVocabLibResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVocabLib");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVocabLibResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取标准化接口任务结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAITaskResultRequest"/></param>
        /// <returns>参考<see cref="DescribeAITaskResultResponse"/>实例</returns>
        public async Task<DescribeAITaskResultResponse> DescribeAITaskResult(DescribeAITaskResultRequest req)
        {
             JsonResponseModel<DescribeAITaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAITaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAITaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 人脸考勤查询结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAttendanceResultRequest"/></param>
        /// <returns>参考<see cref="DescribeAttendanceResultResponse"/>实例</returns>
        public async Task<DescribeAttendanceResultResponse> DescribeAttendanceResult(DescribeAttendanceResultRequest req)
        {
             JsonResponseModel<DescribeAttendanceResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttendanceResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttendanceResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 音频评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAudioTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeAudioTaskResponse"/>实例</returns>
        public async Task<DescribeAudioTaskResponse> DescribeAudioTask(DescribeAudioTaskRequest req)
        {
             JsonResponseModel<DescribeAudioTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAudioTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAudioTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 音频对话任务评估任务信息查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeConversationTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeConversationTaskResponse"/>实例</returns>
        public async Task<DescribeConversationTaskResponse> DescribeConversationTask(DescribeConversationTaskRequest req)
        {
             JsonResponseModel<DescribeConversationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConversationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConversationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 视频精彩集锦结果查询接口，异步查询客户提交的请求的结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHighlightResultRequest"/></param>
        /// <returns>参考<see cref="DescribeHighlightResultResponse"/>实例</returns>
        public async Task<DescribeHighlightResultResponse> DescribeHighlightResult(DescribeHighlightResultRequest req)
        {
             JsonResponseModel<DescribeHighlightResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHighlightResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHighlightResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取任务详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeImageTaskResponse"/>实例</returns>
        public async Task<DescribeImageTaskResponse> DescribeImageTask(DescribeImageTaskRequest req)
        {
             JsonResponseModel<DescribeImageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取图像任务统计信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageTaskStatisticRequest"/></param>
        /// <returns>参考<see cref="DescribeImageTaskStatisticResponse"/>实例</returns>
        public async Task<DescribeImageTaskStatisticResponse> DescribeImageTaskStatistic(DescribeImageTaskStatisticRequest req)
        {
             JsonResponseModel<DescribeImageTaskStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageTaskStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageTaskStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLibrariesRequest"/></param>
        /// <returns>参考<see cref="DescribeLibrariesResponse"/>实例</returns>
        public async Task<DescribeLibrariesResponse> DescribeLibraries(DescribeLibrariesRequest req)
        {
             JsonResponseModel<DescribeLibrariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLibraries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLibrariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonRequest"/></param>
        /// <returns>参考<see cref="DescribePersonResponse"/>实例</returns>
        public async Task<DescribePersonResponse> DescribePerson(DescribePersonRequest req)
        {
             JsonResponseModel<DescribePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取人员列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonsRequest"/></param>
        /// <returns>参考<see cref="DescribePersonsResponse"/>实例</returns>
        public async Task<DescribePersonsResponse> DescribePersons(DescribePersonsRequest req)
        {
             JsonResponseModel<DescribePersonsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询词汇
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVocabRequest"/></param>
        /// <returns>参考<see cref="DescribeVocabResponse"/>实例</returns>
        public async Task<DescribeVocabResponse> DescribeVocab(DescribeVocabRequest req)
        {
             JsonResponseModel<DescribeVocabResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVocab");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVocabResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询词汇库
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVocabLibRequest"/></param>
        /// <returns>参考<see cref="DescribeVocabLibResponse"/>实例</returns>
        public async Task<DescribeVocabLibResponse> DescribeVocabLib(DescribeVocabLibRequest req)
        {
             JsonResponseModel<DescribeVocabLibResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVocabLib");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVocabLibResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员库信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLibraryRequest"/></param>
        /// <returns>参考<see cref="ModifyLibraryResponse"/>实例</returns>
        public async Task<ModifyLibraryResponse> ModifyLibrary(ModifyLibraryRequest req)
        {
             JsonResponseModel<ModifyLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonResponse"/>实例</returns>
        public async Task<ModifyPersonResponse> ModifyPerson(ModifyPersonRequest req)
        {
             JsonResponseModel<ModifyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 音频任务提交接口
        /// </summary>
        /// <param name="req">参考<see cref="SubmitAudioTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitAudioTaskResponse"/>实例</returns>
        public async Task<SubmitAudioTaskResponse> SubmitAudioTask(SubmitAudioTaskRequest req)
        {
             JsonResponseModel<SubmitAudioTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitAudioTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitAudioTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitCheckAttendanceTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitCheckAttendanceTaskResponse"/>实例</returns>
        public async Task<SubmitCheckAttendanceTaskResponse> SubmitCheckAttendanceTask(SubmitCheckAttendanceTaskRequest req)
        {
             JsonResponseModel<SubmitCheckAttendanceTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitCheckAttendanceTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCheckAttendanceTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持多路视频流，提交高级人员考勤任务
        /// </summary>
        /// <param name="req">参考<see cref="SubmitCheckAttendanceTaskPlusRequest"/></param>
        /// <returns>参考<see cref="SubmitCheckAttendanceTaskPlusResponse"/>实例</returns>
        public async Task<SubmitCheckAttendanceTaskPlusResponse> SubmitCheckAttendanceTaskPlus(SubmitCheckAttendanceTaskPlusRequest req)
        {
             JsonResponseModel<SubmitCheckAttendanceTaskPlusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitCheckAttendanceTaskPlus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCheckAttendanceTaskPlusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对话任务分析接口
        /// </summary>
        /// <param name="req">参考<see cref="SubmitConversationTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitConversationTaskResponse"/>实例</returns>
        public async Task<SubmitConversationTaskResponse> SubmitConversationTask(SubmitConversationTaskRequest req)
        {
             JsonResponseModel<SubmitConversationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitConversationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitConversationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起双路视频生成精彩集锦接口。该接口可以通过客户传入的学生音视频及老师视频两路Url，自动生成一堂课程的精彩集锦。需要通过DescribeHighlightResult
        /// 接口获取生成结果。
        /// </summary>
        /// <param name="req">参考<see cref="SubmitDoubleVideoHighlightsRequest"/></param>
        /// <returns>参考<see cref="SubmitDoubleVideoHighlightsResponse"/>实例</returns>
        public async Task<SubmitDoubleVideoHighlightsResponse> SubmitDoubleVideoHighlights(SubmitDoubleVideoHighlightsRequest req)
        {
             JsonResponseModel<SubmitDoubleVideoHighlightsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitDoubleVideoHighlights");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitDoubleVideoHighlightsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitFullBodyClassTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitFullBodyClassTaskResponse"/>实例</returns>
        public async Task<SubmitFullBodyClassTaskResponse> SubmitFullBodyClassTask(SubmitFullBodyClassTaskRequest req)
        {
             JsonResponseModel<SubmitFullBodyClassTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitFullBodyClassTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitFullBodyClassTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起视频生成精彩集锦接口。该接口可以通过客户传入的课程音频数据及相关策略（如微笑抽取，专注抽取等），自动生成一堂课程的精彩集锦。需要通过QueryHighlightResult接口获取生成结果。
        /// </summary>
        /// <param name="req">参考<see cref="SubmitHighlightsRequest"/></param>
        /// <returns>参考<see cref="SubmitHighlightsResponse"/>实例</returns>
        public async Task<SubmitHighlightsResponse> SubmitHighlights(SubmitHighlightsRequest req)
        {
             JsonResponseModel<SubmitHighlightsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitHighlights");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitHighlightsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交图像分析任务
        /// </summary>
        /// <param name="req">参考<see cref="SubmitImageTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitImageTaskResponse"/>实例</returns>
        public async Task<SubmitImageTaskResponse> SubmitImageTask(SubmitImageTaskRequest req)
        {
             JsonResponseModel<SubmitImageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 高级图像分析任务，开放了图像任务里的所有开关，可以根据场景深度定制图像分析任务。支持的图像类别有，图片链接、图片二进制数据、点播链接和直播链接。
        /// </summary>
        /// <param name="req">参考<see cref="SubmitImageTaskPlusRequest"/></param>
        /// <returns>参考<see cref="SubmitImageTaskPlusResponse"/>实例</returns>
        public async Task<SubmitImageTaskPlusResponse> SubmitImageTaskPlus(SubmitImageTaskPlusRequest req)
        {
             JsonResponseModel<SubmitImageTaskPlusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitImageTaskPlus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitImageTaskPlusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitOneByOneClassTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitOneByOneClassTaskResponse"/>实例</returns>
        public async Task<SubmitOneByOneClassTaskResponse> SubmitOneByOneClassTask(SubmitOneByOneClassTaskRequest req)
        {
             JsonResponseModel<SubmitOneByOneClassTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitOneByOneClassTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitOneByOneClassTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitOpenClassTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitOpenClassTaskResponse"/>实例</returns>
        public async Task<SubmitOpenClassTaskResponse> SubmitOpenClassTask(SubmitOpenClassTaskRequest req)
        {
             JsonResponseModel<SubmitOpenClassTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitOpenClassTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitOpenClassTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitPartialBodyClassTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitPartialBodyClassTaskResponse"/>实例</returns>
        public async Task<SubmitPartialBodyClassTaskResponse> SubmitPartialBodyClassTask(SubmitPartialBodyClassTaskRequest req)
        {
             JsonResponseModel<SubmitPartialBodyClassTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitPartialBodyClassTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitPartialBodyClassTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// <param name="req">参考<see cref="SubmitTraditionalClassTaskRequest"/></param>
        /// <returns>参考<see cref="SubmitTraditionalClassTaskResponse"/>实例</returns>
        public async Task<SubmitTraditionalClassTaskResponse> SubmitTraditionalClassTask(SubmitTraditionalClassTaskRequest req)
        {
             JsonResponseModel<SubmitTraditionalClassTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitTraditionalClassTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitTraditionalClassTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分析音频信息
        /// </summary>
        /// <param name="req">参考<see cref="TransmitAudioStreamRequest"/></param>
        /// <returns>参考<see cref="TransmitAudioStreamResponse"/>实例</returns>
        public async Task<TransmitAudioStreamResponse> TransmitAudioStream(TransmitAudioStreamRequest req)
        {
             JsonResponseModel<TransmitAudioStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransmitAudioStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransmitAudioStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
