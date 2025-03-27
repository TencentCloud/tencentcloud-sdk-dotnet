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

namespace TencentCloud.Tiw.V20190919
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiw.V20190919.Models;

   public class TiwClient : AbstractClient{

       private const string endpoint = "tiw.tencentcloudapi.com";
       private const string version = "2019-09-19";
       private const string sdkVersion = "SDK_NET_3.0.1210";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检测PPT文件，识别PPT中包含的动态转码任务（Transcode）不支持的元素
        /// </summary>
        /// <param name="req"><see cref="CreatePPTCheckTaskRequest"/></param>
        /// <returns><see cref="CreatePPTCheckTaskResponse"/></returns>
        public Task<CreatePPTCheckTaskResponse> CreatePPTCheckTask(CreatePPTCheckTaskRequest req)
        {
            return InternalRequestAsync<CreatePPTCheckTaskResponse>(req, "CreatePPTCheckTask");
        }

        /// <summary>
        /// 检测PPT文件，识别PPT中包含的动态转码任务（Transcode）不支持的元素
        /// </summary>
        /// <param name="req"><see cref="CreatePPTCheckTaskRequest"/></param>
        /// <returns><see cref="CreatePPTCheckTaskResponse"/></returns>
        public CreatePPTCheckTaskResponse CreatePPTCheckTaskSync(CreatePPTCheckTaskRequest req)
        {
            return InternalRequestAsync<CreatePPTCheckTaskResponse>(req, "CreatePPTCheckTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建白板板书生成任务, 在任务结束后，如果提供了回调地址，将通过回调地址通知板书生成结果
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public Task<CreateSnapshotTaskResponse> CreateSnapshotTask(CreateSnapshotTaskRequest req)
        {
            return InternalRequestAsync<CreateSnapshotTaskResponse>(req, "CreateSnapshotTask");
        }

        /// <summary>
        /// 创建白板板书生成任务, 在任务结束后，如果提供了回调地址，将通过回调地址通知板书生成结果
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public CreateSnapshotTaskResponse CreateSnapshotTaskSync(CreateSnapshotTaskRequest req)
        {
            return InternalRequestAsync<CreateSnapshotTaskResponse>(req, "CreateSnapshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个文档转码任务
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public Task<CreateTranscodeResponse> CreateTranscode(CreateTranscodeRequest req)
        {
            return InternalRequestAsync<CreateTranscodeResponse>(req, "CreateTranscode");
        }

        /// <summary>
        /// 创建一个文档转码任务
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public CreateTranscodeResponse CreateTranscodeSync(CreateTranscodeRequest req)
        {
            return InternalRequestAsync<CreateTranscodeResponse>(req, "CreateTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建视频生成任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public Task<CreateVideoGenerationTaskResponse> CreateVideoGenerationTask(CreateVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoGenerationTaskResponse>(req, "CreateVideoGenerationTask");
        }

        /// <summary>
        /// 创建视频生成任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public CreateVideoGenerationTaskResponse CreateVideoGenerationTaskSync(CreateVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoGenerationTaskResponse>(req, "CreateVideoGenerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询录制任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public Task<DescribeOnlineRecordResponse> DescribeOnlineRecord(DescribeOnlineRecordRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordResponse>(req, "DescribeOnlineRecord");
        }

        /// <summary>
        /// 查询录制任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public DescribeOnlineRecordResponse DescribeOnlineRecordSync(DescribeOnlineRecordRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordResponse>(req, "DescribeOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public Task<DescribeOnlineRecordCallbackResponse> DescribeOnlineRecordCallback(DescribeOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordCallbackResponse>(req, "DescribeOnlineRecordCallback");
        }

        /// <summary>
        /// 查询实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public DescribeOnlineRecordCallbackResponse DescribeOnlineRecordCallbackSync(DescribeOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<DescribeOnlineRecordCallbackResponse>(req, "DescribeOnlineRecordCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询PPT检测任务的执行进度或结果，支持查询最近半年内的任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckRequest"/></param>
        /// <returns><see cref="DescribePPTCheckResponse"/></returns>
        public Task<DescribePPTCheckResponse> DescribePPTCheck(DescribePPTCheckRequest req)
        {
            return InternalRequestAsync<DescribePPTCheckResponse>(req, "DescribePPTCheck");
        }

        /// <summary>
        /// 查询PPT检测任务的执行进度或结果，支持查询最近半年内的任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckRequest"/></param>
        /// <returns><see cref="DescribePPTCheckResponse"/></returns>
        public DescribePPTCheckResponse DescribePPTCheckSync(DescribePPTCheckRequest req)
        {
            return InternalRequestAsync<DescribePPTCheckResponse>(req, "DescribePPTCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询PPT检测任务回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckCallbackRequest"/></param>
        /// <returns><see cref="DescribePPTCheckCallbackResponse"/></returns>
        public Task<DescribePPTCheckCallbackResponse> DescribePPTCheckCallback(DescribePPTCheckCallbackRequest req)
        {
            return InternalRequestAsync<DescribePPTCheckCallbackResponse>(req, "DescribePPTCheckCallback");
        }

        /// <summary>
        /// 查询PPT检测任务回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckCallbackRequest"/></param>
        /// <returns><see cref="DescribePPTCheckCallbackResponse"/></returns>
        public DescribePPTCheckCallbackResponse DescribePPTCheckCallbackSync(DescribePPTCheckCallbackRequest req)
        {
            return InternalRequestAsync<DescribePPTCheckCallbackResponse>(req, "DescribePPTCheckCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据指定的任务类型，获取当前正在执行中的任务列表。只能查询最近3天内创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunningTasksRequest"/></param>
        /// <returns><see cref="DescribeRunningTasksResponse"/></returns>
        public Task<DescribeRunningTasksResponse> DescribeRunningTasks(DescribeRunningTasksRequest req)
        {
            return InternalRequestAsync<DescribeRunningTasksResponse>(req, "DescribeRunningTasks");
        }

        /// <summary>
        /// 根据指定的任务类型，获取当前正在执行中的任务列表。只能查询最近3天内创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunningTasksRequest"/></param>
        /// <returns><see cref="DescribeRunningTasksResponse"/></returns>
        public DescribeRunningTasksResponse DescribeRunningTasksSync(DescribeRunningTasksRequest req)
        {
            return InternalRequestAsync<DescribeRunningTasksResponse>(req, "DescribeRunningTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定白板板书生成任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public Task<DescribeSnapshotTaskResponse> DescribeSnapshotTask(DescribeSnapshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotTaskResponse>(req, "DescribeSnapshotTask");
        }

        /// <summary>
        /// 获取指定白板板书生成任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public DescribeSnapshotTaskResponse DescribeSnapshotTaskSync(DescribeSnapshotTaskRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotTaskResponse>(req, "DescribeSnapshotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public Task<DescribeTranscodeResponse> DescribeTranscode(DescribeTranscodeRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeResponse>(req, "DescribeTranscode");
        }

        /// <summary>
        /// 查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public DescribeTranscodeResponse DescribeTranscodeSync(DescribeTranscodeRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeResponse>(req, "DescribeTranscode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过文档URL查询转码任务，返回最近一天内最新的转码任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeByUrlRequest"/></param>
        /// <returns><see cref="DescribeTranscodeByUrlResponse"/></returns>
        public Task<DescribeTranscodeByUrlResponse> DescribeTranscodeByUrl(DescribeTranscodeByUrlRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeByUrlResponse>(req, "DescribeTranscodeByUrl");
        }

        /// <summary>
        /// 通过文档URL查询转码任务，返回最近一天内最新的转码任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeByUrlRequest"/></param>
        /// <returns><see cref="DescribeTranscodeByUrlResponse"/></returns>
        public DescribeTranscodeByUrlResponse DescribeTranscodeByUrlSync(DescribeTranscodeByUrlRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeByUrlResponse>(req, "DescribeTranscodeByUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public Task<DescribeTranscodeCallbackResponse> DescribeTranscodeCallback(DescribeTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeCallbackResponse>(req, "DescribeTranscodeCallback");
        }

        /// <summary>
        /// 查询文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public DescribeTranscodeCallbackResponse DescribeTranscodeCallbackSync(DescribeTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeCallbackResponse>(req, "DescribeTranscodeCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询录制视频生成任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public Task<DescribeVideoGenerationTaskResponse> DescribeVideoGenerationTask(DescribeVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskResponse>(req, "DescribeVideoGenerationTask");
        }

        /// <summary>
        /// 查询录制视频生成任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public DescribeVideoGenerationTaskResponse DescribeVideoGenerationTaskSync(DescribeVideoGenerationTaskRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskResponse>(req, "DescribeVideoGenerationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public Task<DescribeVideoGenerationTaskCallbackResponse> DescribeVideoGenerationTaskCallback(DescribeVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskCallbackResponse>(req, "DescribeVideoGenerationTaskCallback");
        }

        /// <summary>
        /// 查询录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public DescribeVideoGenerationTaskCallbackResponse DescribeVideoGenerationTaskCallbackSync(DescribeVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<DescribeVideoGenerationTaskCallbackResponse>(req, "DescribeVideoGenerationTaskCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningCallbackRequest"/></param>
        /// <returns><see cref="DescribeWarningCallbackResponse"/></returns>
        public Task<DescribeWarningCallbackResponse> DescribeWarningCallback(DescribeWarningCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWarningCallbackResponse>(req, "DescribeWarningCallback");
        }

        /// <summary>
        /// 查询告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningCallbackRequest"/></param>
        /// <returns><see cref="DescribeWarningCallbackResponse"/></returns>
        public DescribeWarningCallbackResponse DescribeWarningCallbackSync(DescribeWarningCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWarningCallbackResponse>(req, "DescribeWarningCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询推流任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public Task<DescribeWhiteboardPushResponse> DescribeWhiteboardPush(DescribeWhiteboardPushRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushResponse>(req, "DescribeWhiteboardPush");
        }

        /// <summary>
        /// 查询推流任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public DescribeWhiteboardPushResponse DescribeWhiteboardPushSync(DescribeWhiteboardPushRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushResponse>(req, "DescribeWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询白板推流回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public Task<DescribeWhiteboardPushCallbackResponse> DescribeWhiteboardPushCallback(DescribeWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushCallbackResponse>(req, "DescribeWhiteboardPushCallback");
        }

        /// <summary>
        /// 查询白板推流回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public DescribeWhiteboardPushCallbackResponse DescribeWhiteboardPushCallbackSync(DescribeWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<DescribeWhiteboardPushCallbackResponse>(req, "DescribeWhiteboardPushCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停实时录制
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public Task<PauseOnlineRecordResponse> PauseOnlineRecord(PauseOnlineRecordRequest req)
        {
            return InternalRequestAsync<PauseOnlineRecordResponse>(req, "PauseOnlineRecord");
        }

        /// <summary>
        /// 暂停实时录制
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public PauseOnlineRecordResponse PauseOnlineRecordSync(PauseOnlineRecordRequest req)
        {
            return InternalRequestAsync<PauseOnlineRecordResponse>(req, "PauseOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复实时录制
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public Task<ResumeOnlineRecordResponse> ResumeOnlineRecord(ResumeOnlineRecordRequest req)
        {
            return InternalRequestAsync<ResumeOnlineRecordResponse>(req, "ResumeOnlineRecord");
        }

        /// <summary>
        /// 恢复实时录制
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public ResumeOnlineRecordResponse ResumeOnlineRecordSync(ResumeOnlineRecordRequest req)
        {
            return InternalRequestAsync<ResumeOnlineRecordResponse>(req, "ResumeOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置实时录制回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40258
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public Task<SetOnlineRecordCallbackResponse> SetOnlineRecordCallback(SetOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackResponse>(req, "SetOnlineRecordCallback");
        }

        /// <summary>
        /// 设置实时录制回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40258
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public SetOnlineRecordCallbackResponse SetOnlineRecordCallbackSync(SetOnlineRecordCallbackRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackResponse>(req, "SetOnlineRecordCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置实时录制回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public Task<SetOnlineRecordCallbackKeyResponse> SetOnlineRecordCallbackKey(SetOnlineRecordCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackKeyResponse>(req, "SetOnlineRecordCallbackKey");
        }

        /// <summary>
        /// 设置实时录制回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public SetOnlineRecordCallbackKeyResponse SetOnlineRecordCallbackKeySync(SetOnlineRecordCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetOnlineRecordCallbackKeyResponse>(req, "SetOnlineRecordCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置PPT检测任务回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260#c9cbe05f-fe1a-4410-b4dc-40cc301c7b81
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackResponse"/></returns>
        public Task<SetPPTCheckCallbackResponse> SetPPTCheckCallback(SetPPTCheckCallbackRequest req)
        {
            return InternalRequestAsync<SetPPTCheckCallbackResponse>(req, "SetPPTCheckCallback");
        }

        /// <summary>
        /// 设置PPT检测任务回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260#c9cbe05f-fe1a-4410-b4dc-40cc301c7b81
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackResponse"/></returns>
        public SetPPTCheckCallbackResponse SetPPTCheckCallbackSync(SetPPTCheckCallbackRequest req)
        {
            return InternalRequestAsync<SetPPTCheckCallbackResponse>(req, "SetPPTCheckCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置PPT检测任务回调密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackKeyRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackKeyResponse"/></returns>
        public Task<SetPPTCheckCallbackKeyResponse> SetPPTCheckCallbackKey(SetPPTCheckCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetPPTCheckCallbackKeyResponse>(req, "SetPPTCheckCallbackKey");
        }

        /// <summary>
        /// 设置PPT检测任务回调密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackKeyRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackKeyResponse"/></returns>
        public SetPPTCheckCallbackKeyResponse SetPPTCheckCallbackKeySync(SetPPTCheckCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetPPTCheckCallbackKeyResponse>(req, "SetPPTCheckCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置文档转码回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public Task<SetTranscodeCallbackResponse> SetTranscodeCallback(SetTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackResponse>(req, "SetTranscodeCallback");
        }

        /// <summary>
        /// 设置文档转码回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public SetTranscodeCallbackResponse SetTranscodeCallbackSync(SetTranscodeCallbackRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackResponse>(req, "SetTranscodeCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置文档转码回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public Task<SetTranscodeCallbackKeyResponse> SetTranscodeCallbackKey(SetTranscodeCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackKeyResponse>(req, "SetTranscodeCallbackKey");
        }

        /// <summary>
        /// 设置文档转码回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public SetTranscodeCallbackKeyResponse SetTranscodeCallbackKeySync(SetTranscodeCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetTranscodeCallbackKeyResponse>(req, "SetTranscodeCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public Task<SetVideoGenerationTaskCallbackResponse> SetVideoGenerationTaskCallback(SetVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackResponse>(req, "SetVideoGenerationTaskCallback");
        }

        /// <summary>
        /// 设置录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public SetVideoGenerationTaskCallbackResponse SetVideoGenerationTaskCallbackSync(SetVideoGenerationTaskCallbackRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackResponse>(req, "SetVideoGenerationTaskCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置视频生成回调鉴权密钥
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public Task<SetVideoGenerationTaskCallbackKeyResponse> SetVideoGenerationTaskCallbackKey(SetVideoGenerationTaskCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackKeyResponse>(req, "SetVideoGenerationTaskCallbackKey");
        }

        /// <summary>
        /// 设置视频生成回调鉴权密钥
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public SetVideoGenerationTaskCallbackKeyResponse SetVideoGenerationTaskCallbackKeySync(SetVideoGenerationTaskCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetVideoGenerationTaskCallbackKeyResponse>(req, "SetVideoGenerationTaskCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="SetWarningCallbackRequest"/></param>
        /// <returns><see cref="SetWarningCallbackResponse"/></returns>
        public Task<SetWarningCallbackResponse> SetWarningCallback(SetWarningCallbackRequest req)
        {
            return InternalRequestAsync<SetWarningCallbackResponse>(req, "SetWarningCallback");
        }

        /// <summary>
        /// 设置告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="SetWarningCallbackRequest"/></param>
        /// <returns><see cref="SetWarningCallbackResponse"/></returns>
        public SetWarningCallbackResponse SetWarningCallbackSync(SetWarningCallbackRequest req)
        {
            return InternalRequestAsync<SetWarningCallbackResponse>(req, "SetWarningCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置白板推流回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public Task<SetWhiteboardPushCallbackResponse> SetWhiteboardPushCallback(SetWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackResponse>(req, "SetWhiteboardPushCallback");
        }

        /// <summary>
        /// 设置白板推流回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public SetWhiteboardPushCallbackResponse SetWhiteboardPushCallbackSync(SetWhiteboardPushCallbackRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackResponse>(req, "SetWhiteboardPushCallback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置白板推流回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public Task<SetWhiteboardPushCallbackKeyResponse> SetWhiteboardPushCallbackKey(SetWhiteboardPushCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackKeyResponse>(req, "SetWhiteboardPushCallbackKey");
        }

        /// <summary>
        /// 设置白板推流回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public SetWhiteboardPushCallbackKeyResponse SetWhiteboardPushCallbackKeySync(SetWhiteboardPushCallbackKeyRequest req)
        {
            return InternalRequestAsync<SetWhiteboardPushCallbackKeyResponse>(req, "SetWhiteboardPushCallbackKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起一个实时录制任务
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public Task<StartOnlineRecordResponse> StartOnlineRecord(StartOnlineRecordRequest req)
        {
            return InternalRequestAsync<StartOnlineRecordResponse>(req, "StartOnlineRecord");
        }

        /// <summary>
        /// 发起一个实时录制任务
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public StartOnlineRecordResponse StartOnlineRecordSync(StartOnlineRecordRequest req)
        {
            return InternalRequestAsync<StartOnlineRecordResponse>(req, "StartOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起一个白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public Task<StartWhiteboardPushResponse> StartWhiteboardPush(StartWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StartWhiteboardPushResponse>(req, "StartWhiteboardPush");
        }

        /// <summary>
        /// 发起一个白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public StartWhiteboardPushResponse StartWhiteboardPushSync(StartWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StartWhiteboardPushResponse>(req, "StartWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止实时录制
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public Task<StopOnlineRecordResponse> StopOnlineRecord(StopOnlineRecordRequest req)
        {
            return InternalRequestAsync<StopOnlineRecordResponse>(req, "StopOnlineRecord");
        }

        /// <summary>
        /// 停止实时录制
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public StopOnlineRecordResponse StopOnlineRecordSync(StopOnlineRecordRequest req)
        {
            return InternalRequestAsync<StopOnlineRecordResponse>(req, "StopOnlineRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public Task<StopWhiteboardPushResponse> StopWhiteboardPush(StopWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StopWhiteboardPushResponse>(req, "StopWhiteboardPush");
        }

        /// <summary>
        /// 停止白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public StopWhiteboardPushResponse StopWhiteboardPushSync(StopWhiteboardPushRequest req)
        {
            return InternalRequestAsync<StopWhiteboardPushResponse>(req, "StopWhiteboardPush")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
