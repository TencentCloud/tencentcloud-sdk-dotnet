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

namespace TencentCloud.Mps.V20190612
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mps.V20190612.Models;

   public class MpsClient : AbstractClient{

       private const string endpoint = "mps.tencentcloudapi.com";
       private const string version = "2019-06-12";
       private const string sdkVersion = "SDK_NET_3.0.1225";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MpsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量删除媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchDeleteStreamLinkFlowResponse"/></returns>
        public Task<BatchDeleteStreamLinkFlowResponse> BatchDeleteStreamLinkFlow(BatchDeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchDeleteStreamLinkFlowResponse>(req, "BatchDeleteStreamLinkFlow");
        }

        /// <summary>
        /// 批量删除媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchDeleteStreamLinkFlowResponse"/></returns>
        public BatchDeleteStreamLinkFlowResponse BatchDeleteStreamLinkFlowSync(BatchDeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchDeleteStreamLinkFlowResponse>(req, "BatchDeleteStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启动媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchStartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchStartStreamLinkFlowResponse"/></returns>
        public Task<BatchStartStreamLinkFlowResponse> BatchStartStreamLinkFlow(BatchStartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchStartStreamLinkFlowResponse>(req, "BatchStartStreamLinkFlow");
        }

        /// <summary>
        /// 批量启动媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchStartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchStartStreamLinkFlowResponse"/></returns>
        public BatchStartStreamLinkFlowResponse BatchStartStreamLinkFlowSync(BatchStartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchStartStreamLinkFlowResponse>(req, "BatchStartStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量停止媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchStopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchStopStreamLinkFlowResponse"/></returns>
        public Task<BatchStopStreamLinkFlowResponse> BatchStopStreamLinkFlow(BatchStopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchStopStreamLinkFlowResponse>(req, "BatchStopStreamLinkFlow");
        }

        /// <summary>
        /// 批量停止媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="BatchStopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="BatchStopStreamLinkFlowResponse"/></returns>
        public BatchStopStreamLinkFlowResponse BatchStopStreamLinkFlowSync(BatchStopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<BatchStopStreamLinkFlowResponse>(req, "BatchStopStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate");
        }

        /// <summary>
        /// 创建用户自定义内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate");
        }

        /// <summary>
        /// 创建用户自定义内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<CreateAdaptiveDynamicStreamingTemplateResponse>(req, "CreateAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<CreateAnimatedGraphicsTemplateResponse>(req, "CreateAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能字幕新建热词库接口
        /// </summary>
        /// <param name="req"><see cref="CreateAsrHotwordsRequest"/></param>
        /// <returns><see cref="CreateAsrHotwordsResponse"/></returns>
        public Task<CreateAsrHotwordsResponse> CreateAsrHotwords(CreateAsrHotwordsRequest req)
        {
            return InternalRequestAsync<CreateAsrHotwordsResponse>(req, "CreateAsrHotwords");
        }

        /// <summary>
        /// 智能字幕新建热词库接口
        /// </summary>
        /// <param name="req"><see cref="CreateAsrHotwordsRequest"/></param>
        /// <returns><see cref="CreateAsrHotwordsResponse"/></returns>
        public CreateAsrHotwordsResponse CreateAsrHotwordsSync(CreateAsrHotwordsRequest req)
        {
            return InternalRequestAsync<CreateAsrHotwordsResponse>(req, "CreateAsrHotwords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate");
        }

        /// <summary>
        /// 创建用户自定义内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate");
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageSpriteTemplateResponse>(req, "CreateImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播录制模板
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate");
        }

        /// <summary>
        /// 创建直播录制模板
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="CreateLiveRecordTemplateResponse"/></returns>
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateSync(CreateLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordTemplateResponse>(req, "CreateLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、内容不适宜等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample");
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、内容不适宜等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体质检模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityControlTemplateResponse"/></returns>
        public Task<CreateQualityControlTemplateResponse> CreateQualityControlTemplate(CreateQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTemplateResponse>(req, "CreateQualityControlTemplate");
        }

        /// <summary>
        /// 创建媒体质检模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityControlTemplateResponse"/></returns>
        public CreateQualityControlTemplateResponse CreateQualityControlTemplateSync(CreateQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTemplateResponse>(req, "CreateQualityControlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate");
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateSampleSnapshotTemplateResponse>(req, "CreateSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建编排成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduleRequest"/></param>
        /// <returns><see cref="CreateScheduleResponse"/></returns>
        public Task<CreateScheduleResponse> CreateSchedule(CreateScheduleRequest req)
        {
            return InternalRequestAsync<CreateScheduleResponse>(req, "CreateSchedule");
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建编排成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduleRequest"/></param>
        /// <returns><see cref="CreateScheduleResponse"/></returns>
        public CreateScheduleResponse CreateScheduleSync(CreateScheduleRequest req)
        {
            return InternalRequestAsync<CreateScheduleResponse>(req, "CreateSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义智能字幕模板
        /// </summary>
        /// <param name="req"><see cref="CreateSmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="CreateSmartSubtitleTemplateResponse"/></returns>
        public Task<CreateSmartSubtitleTemplateResponse> CreateSmartSubtitleTemplate(CreateSmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<CreateSmartSubtitleTemplateResponse>(req, "CreateSmartSubtitleTemplate");
        }

        /// <summary>
        /// 创建自定义智能字幕模板
        /// </summary>
        /// <param name="req"><see cref="CreateSmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="CreateSmartSubtitleTemplateResponse"/></returns>
        public CreateSmartSubtitleTemplateResponse CreateSmartSubtitleTemplateSync(CreateSmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<CreateSmartSubtitleTemplateResponse>(req, "CreateSmartSubtitleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<CreateSnapshotByTimeOffsetTemplateResponse>(req, "CreateSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public CreateSnapshotByTimeOffsetTemplateResponse CreateSnapshotByTimeOffsetTemplateSync(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<CreateSnapshotByTimeOffsetTemplateResponse>(req, "CreateSnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体传输的事件Event。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkEventRequest"/></param>
        /// <returns><see cref="CreateStreamLinkEventResponse"/></returns>
        public Task<CreateStreamLinkEventResponse> CreateStreamLinkEvent(CreateStreamLinkEventRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkEventResponse>(req, "CreateStreamLinkEvent");
        }

        /// <summary>
        /// 创建媒体传输的事件Event。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkEventRequest"/></param>
        /// <returns><see cref="CreateStreamLinkEventResponse"/></returns>
        public CreateStreamLinkEventResponse CreateStreamLinkEventSync(CreateStreamLinkEventRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkEventResponse>(req, "CreateStreamLinkEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体传输的传输流配置。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public Task<CreateStreamLinkFlowResponse> CreateStreamLinkFlow(CreateStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkFlowResponse>(req, "CreateStreamLinkFlow");
        }

        /// <summary>
        /// 创建媒体传输的传输流配置。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkFlowRequest"/></param>
        /// <returns><see cref="CreateStreamLinkFlowResponse"/></returns>
        public CreateStreamLinkFlowResponse CreateStreamLinkFlowSync(CreateStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkFlowResponse>(req, "CreateStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体传输的输入配置。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkInputRequest"/></param>
        /// <returns><see cref="CreateStreamLinkInputResponse"/></returns>
        public Task<CreateStreamLinkInputResponse> CreateStreamLinkInput(CreateStreamLinkInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkInputResponse>(req, "CreateStreamLinkInput");
        }

        /// <summary>
        /// 创建媒体传输的输入配置。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkInputRequest"/></param>
        /// <returns><see cref="CreateStreamLinkInputResponse"/></returns>
        public CreateStreamLinkInputResponse CreateStreamLinkInputSync(CreateStreamLinkInputRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkInputResponse>(req, "CreateStreamLinkInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体传输流的输出信息。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public Task<CreateStreamLinkOutputInfoResponse> CreateStreamLinkOutputInfo(CreateStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkOutputInfoResponse>(req, "CreateStreamLinkOutputInfo");
        }

        /// <summary>
        /// 创建媒体传输流的输出信息。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="CreateStreamLinkOutputInfoResponse"/></returns>
        public CreateStreamLinkOutputInfoResponse CreateStreamLinkOutputInfoSync(CreateStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkOutputInfoResponse>(req, "CreateStreamLinkOutputInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全组，数量限制5个。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLinkSecurityGroupResponse"/></returns>
        public Task<CreateStreamLinkSecurityGroupResponse> CreateStreamLinkSecurityGroup(CreateStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkSecurityGroupResponse>(req, "CreateStreamLinkSecurityGroup");
        }

        /// <summary>
        /// 创建安全组，数量限制5个。
        /// </summary>
        /// <param name="req"><see cref="CreateStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateStreamLinkSecurityGroupResponse"/></returns>
        public CreateStreamLinkSecurityGroupResponse CreateStreamLinkSecurityGroupSync(CreateStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateStreamLinkSecurityGroupResponse>(req, "CreateStreamLinkSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：1000
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate");
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：1000
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对URL链接或COS中的视频发起入库任务。
        /// 可选在任务完成后向回调方发送任务完成状态信息。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDatabaseEntryTaskRequest"/></param>
        /// <returns><see cref="CreateVideoDatabaseEntryTaskResponse"/></returns>
        public Task<CreateVideoDatabaseEntryTaskResponse> CreateVideoDatabaseEntryTask(CreateVideoDatabaseEntryTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoDatabaseEntryTaskResponse>(req, "CreateVideoDatabaseEntryTask");
        }

        /// <summary>
        /// 对URL链接或COS中的视频发起入库任务。
        /// 可选在任务完成后向回调方发送任务完成状态信息。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDatabaseEntryTaskRequest"/></param>
        /// <returns><see cref="CreateVideoDatabaseEntryTaskResponse"/></returns>
        public CreateVideoDatabaseEntryTaskResponse CreateVideoDatabaseEntryTaskSync(CreateVideoDatabaseEntryTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoDatabaseEntryTaskResponse>(req, "CreateVideoDatabaseEntryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用检索值检索库中最接近检索值的若干视频。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSearchTaskRequest"/></param>
        /// <returns><see cref="CreateVideoSearchTaskResponse"/></returns>
        public Task<CreateVideoSearchTaskResponse> CreateVideoSearchTask(CreateVideoSearchTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoSearchTaskResponse>(req, "CreateVideoSearchTask");
        }

        /// <summary>
        /// 使用检索值检索库中最接近检索值的若干视频。
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSearchTaskRequest"/></param>
        /// <returns><see cref="CreateVideoSearchTaskResponse"/></returns>
        public CreateVideoSearchTaskResponse CreateVideoSearchTaskSync(CreateVideoSearchTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoSearchTaskResponse>(req, "CreateVideoSearchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate");
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<CreateWatermarkTemplateResponse>(req, "CreateWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples");
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
            return InternalRequestAsync<CreateWordSamplesResponse>(req, "CreateWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建工作流成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建工作流成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate");
        }

        /// <summary>
        /// 删除用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public DeleteAIAnalysisTemplateResponse DeleteAIAnalysisTemplateSync(DeleteAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisTemplateResponse>(req, "DeleteAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate");
        }

        /// <summary>
        /// 删除用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAdaptiveDynamicStreamingTemplateResponse>(req, "DeleteAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAnimatedGraphicsTemplateResponse>(req, "DeleteAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public DeleteAnimatedGraphicsTemplateResponse DeleteAnimatedGraphicsTemplateSync(DeleteAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAnimatedGraphicsTemplateResponse>(req, "DeleteAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除智能字幕热词库
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrHotwordsRequest"/></param>
        /// <returns><see cref="DeleteAsrHotwordsResponse"/></returns>
        public Task<DeleteAsrHotwordsResponse> DeleteAsrHotwords(DeleteAsrHotwordsRequest req)
        {
            return InternalRequestAsync<DeleteAsrHotwordsResponse>(req, "DeleteAsrHotwords");
        }

        /// <summary>
        /// 删除智能字幕热词库
        /// </summary>
        /// <param name="req"><see cref="DeleteAsrHotwordsRequest"/></param>
        /// <returns><see cref="DeleteAsrHotwordsResponse"/></returns>
        public DeleteAsrHotwordsResponse DeleteAsrHotwordsSync(DeleteAsrHotwordsRequest req)
        {
            return InternalRequestAsync<DeleteAsrHotwordsResponse>(req, "DeleteAsrHotwords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate");
        }

        /// <summary>
        /// 删除用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate");
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageSpriteTemplateResponse>(req, "DeleteImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播录制模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate");
        }

        /// <summary>
        /// 删除直播录制模板
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordTemplateResponse"/></returns>
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateSync(DeleteLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordTemplateResponse>(req, "DeleteLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于根据素材 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample");
        }

        /// <summary>
        /// 该接口用于根据素材 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除媒体质检模板
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityControlTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityControlTemplateResponse"/></returns>
        public Task<DeleteQualityControlTemplateResponse> DeleteQualityControlTemplate(DeleteQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityControlTemplateResponse>(req, "DeleteQualityControlTemplate");
        }

        /// <summary>
        /// 删除媒体质检模板
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityControlTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityControlTemplateResponse"/></returns>
        public DeleteQualityControlTemplateResponse DeleteQualityControlTemplateSync(DeleteQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityControlTemplateResponse>(req, "DeleteQualityControlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate");
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSampleSnapshotTemplateResponse>(req, "DeleteSampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除编排
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduleRequest"/></param>
        /// <returns><see cref="DeleteScheduleResponse"/></returns>
        public Task<DeleteScheduleResponse> DeleteSchedule(DeleteScheduleRequest req)
        {
            return InternalRequestAsync<DeleteScheduleResponse>(req, "DeleteSchedule");
        }

        /// <summary>
        /// 删除编排
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduleRequest"/></param>
        /// <returns><see cref="DeleteScheduleResponse"/></returns>
        public DeleteScheduleResponse DeleteScheduleSync(DeleteScheduleRequest req)
        {
            return InternalRequestAsync<DeleteScheduleResponse>(req, "DeleteSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义智能字幕模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmartSubtitleTemplateResponse"/></returns>
        public Task<DeleteSmartSubtitleTemplateResponse> DeleteSmartSubtitleTemplate(DeleteSmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmartSubtitleTemplateResponse>(req, "DeleteSmartSubtitleTemplate");
        }

        /// <summary>
        /// 删除用户自定义智能字幕模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmartSubtitleTemplateResponse"/></returns>
        public DeleteSmartSubtitleTemplateResponse DeleteSmartSubtitleTemplateSync(DeleteSmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmartSubtitleTemplateResponse>(req, "DeleteSmartSubtitleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotByTimeOffsetTemplateResponse>(req, "DeleteSnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除媒体传输的事件配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkEventRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkEventResponse"/></returns>
        public Task<DeleteStreamLinkEventResponse> DeleteStreamLinkEvent(DeleteStreamLinkEventRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkEventResponse>(req, "DeleteStreamLinkEvent");
        }

        /// <summary>
        /// 删除媒体传输的事件配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkEventRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkEventResponse"/></returns>
        public DeleteStreamLinkEventResponse DeleteStreamLinkEventSync(DeleteStreamLinkEventRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkEventResponse>(req, "DeleteStreamLinkEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除媒体传输的传输流配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public Task<DeleteStreamLinkFlowResponse> DeleteStreamLinkFlow(DeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkFlowResponse>(req, "DeleteStreamLinkFlow");
        }

        /// <summary>
        /// 删除媒体传输的传输流配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkFlowResponse"/></returns>
        public DeleteStreamLinkFlowResponse DeleteStreamLinkFlowSync(DeleteStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkFlowResponse>(req, "DeleteStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除媒体传输流的输出配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public Task<DeleteStreamLinkOutputResponse> DeleteStreamLinkOutput(DeleteStreamLinkOutputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkOutputResponse>(req, "DeleteStreamLinkOutput");
        }

        /// <summary>
        /// 删除媒体传输流的输出配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkOutputRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkOutputResponse"/></returns>
        public DeleteStreamLinkOutputResponse DeleteStreamLinkOutputSync(DeleteStreamLinkOutputRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkOutputResponse>(req, "DeleteStreamLinkOutput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全组。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkSecurityGroupResponse"/></returns>
        public Task<DeleteStreamLinkSecurityGroupResponse> DeleteStreamLinkSecurityGroup(DeleteStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkSecurityGroupResponse>(req, "DeleteStreamLinkSecurityGroup");
        }

        /// <summary>
        /// 删除安全组。
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteStreamLinkSecurityGroupResponse"/></returns>
        public DeleteStreamLinkSecurityGroupResponse DeleteStreamLinkSecurityGroupSync(DeleteStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteStreamLinkSecurityGroupResponse>(req, "DeleteStreamLinkSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTranscodeTemplateResponse>(req, "DeleteTranscodeTemplate");
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplateSync(DeleteTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTranscodeTemplateResponse>(req, "DeleteTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWatermarkTemplateResponse>(req, "DeleteWatermarkTemplate");
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplateSync(DeleteWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWatermarkTemplateResponse>(req, "DeleteWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
            return InternalRequestAsync<DeleteWordSamplesResponse>(req, "DeleteWordSamples");
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public DeleteWordSamplesResponse DeleteWordSamplesSync(DeleteWordSamplesRequest req)
        {
            return InternalRequestAsync<DeleteWordSamplesResponse>(req, "DeleteWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作流。对于已启用的工作流，需要禁用后才能删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow");
        }

        /// <summary>
        /// 删除工作流。对于已启用的工作流，需要禁用后才能删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据内容分析模板唯一标识，获取内容分析模板详情列表。返回结果包含符合条件的所有用户自定义内容分析模板及系统预置视频内容分析模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates");
        }

        /// <summary>
        /// 根据内容分析模板唯一标识，获取内容分析模板详情列表。返回结果包含符合条件的所有用户自定义内容分析模板及系统预置视频内容分析模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据内容识别模板唯一标识，获取内容识别模板详情列表。返回结果包含符合条件的所有用户自定义内容识别模板及系统预置视频内容识别模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates");
        }

        /// <summary>
        /// 根据内容识别模板唯一标识，获取内容识别模板详情列表。返回结果包含符合条件的所有用户自定义内容识别模板及系统预置视频内容识别模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates");
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAdaptiveDynamicStreamingTemplatesResponse>(req, "DescribeAdaptiveDynamicStreamingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates");
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAnimatedGraphicsTemplatesResponse>(req, "DescribeAnimatedGraphicsTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询智能字幕热词库
        /// </summary>
        /// <param name="req"><see cref="DescribeAsrHotwordsRequest"/></param>
        /// <returns><see cref="DescribeAsrHotwordsResponse"/></returns>
        public Task<DescribeAsrHotwordsResponse> DescribeAsrHotwords(DescribeAsrHotwordsRequest req)
        {
            return InternalRequestAsync<DescribeAsrHotwordsResponse>(req, "DescribeAsrHotwords");
        }

        /// <summary>
        /// 查询智能字幕热词库
        /// </summary>
        /// <param name="req"><see cref="DescribeAsrHotwordsRequest"/></param>
        /// <returns><see cref="DescribeAsrHotwordsResponse"/></returns>
        public DescribeAsrHotwordsResponse DescribeAsrHotwordsSync(DescribeAsrHotwordsRequest req)
        {
            return InternalRequestAsync<DescribeAsrHotwordsResponse>(req, "DescribeAsrHotwords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取热词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAsrHotwordsListRequest"/></param>
        /// <returns><see cref="DescribeAsrHotwordsListResponse"/></returns>
        public Task<DescribeAsrHotwordsListResponse> DescribeAsrHotwordsList(DescribeAsrHotwordsListRequest req)
        {
            return InternalRequestAsync<DescribeAsrHotwordsListResponse>(req, "DescribeAsrHotwordsList");
        }

        /// <summary>
        /// 获取热词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAsrHotwordsListRequest"/></param>
        /// <returns><see cref="DescribeAsrHotwordsListResponse"/></returns>
        public DescribeAsrHotwordsListResponse DescribeAsrHotwordsListSync(DescribeAsrHotwordsListRequest req)
        {
            return InternalRequestAsync<DescribeAsrHotwordsListResponse>(req, "DescribeAsrHotwordsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据智能审核模板唯一标识，获取智能审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及系统预置智能审核模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates");
        }

        /// <summary>
        /// 根据智能审核模板唯一标识，获取智能审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及系统预置智能审核模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据安全组反差关联的Flow信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAttachFlowsByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupAttachFlowsByIdResponse"/></returns>
        public Task<DescribeGroupAttachFlowsByIdResponse> DescribeGroupAttachFlowsById(DescribeGroupAttachFlowsByIdRequest req)
        {
            return InternalRequestAsync<DescribeGroupAttachFlowsByIdResponse>(req, "DescribeGroupAttachFlowsById");
        }

        /// <summary>
        /// 根据安全组反差关联的Flow信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAttachFlowsByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupAttachFlowsByIdResponse"/></returns>
        public DescribeGroupAttachFlowsByIdResponse DescribeGroupAttachFlowsByIdSync(DescribeGroupAttachFlowsByIdRequest req)
        {
            return InternalRequestAsync<DescribeGroupAttachFlowsByIdResponse>(req, "DescribeGroupAttachFlowsById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates");
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageSpriteTemplatesResponse>(req, "DescribeImageSpriteTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播录制模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public Task<DescribeLiveRecordTemplatesResponse> DescribeLiveRecordTemplates(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates");
        }

        /// <summary>
        /// 获取直播录制模板
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordTemplatesRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordTemplatesResponse"/></returns>
        public DescribeLiveRecordTemplatesResponse DescribeLiveRecordTemplatesSync(DescribeLiveRecordTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordTemplatesResponse>(req, "DescribeLiveRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取媒体的元信息，包括视频画面宽、高、编码格式、时长、帧率等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public Task<DescribeMediaMetaDataResponse> DescribeMediaMetaData(DescribeMediaMetaDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaMetaDataResponse>(req, "DescribeMediaMetaData");
        }

        /// <summary>
        /// 获取媒体的元信息，包括视频画面宽、高、编码格式、时长、帧率等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public DescribeMediaMetaDataResponse DescribeMediaMetaDataSync(DescribeMediaMetaDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaMetaDataResponse>(req, "DescribeMediaMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples");
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
            return InternalRequestAsync<DescribePersonSamplesResponse>(req, "DescribePersonSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户自定义媒体质检模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTemplatesResponse"/></returns>
        public Task<DescribeQualityControlTemplatesResponse> DescribeQualityControlTemplates(DescribeQualityControlTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTemplatesResponse>(req, "DescribeQualityControlTemplates");
        }

        /// <summary>
        /// 查询用户自定义媒体质检模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTemplatesResponse"/></returns>
        public DescribeQualityControlTemplatesResponse DescribeQualityControlTemplatesSync(DescribeQualityControlTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTemplatesResponse>(req, "DescribeQualityControlTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates");
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSampleSnapshotTemplatesResponse>(req, "DescribeSampleSnapshotTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询编排。
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulesRequest"/></param>
        /// <returns><see cref="DescribeSchedulesResponse"/></returns>
        public Task<DescribeSchedulesResponse> DescribeSchedules(DescribeSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeSchedulesResponse>(req, "DescribeSchedules");
        }

        /// <summary>
        /// 查询编排。
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulesRequest"/></param>
        /// <returns><see cref="DescribeSchedulesResponse"/></returns>
        public DescribeSchedulesResponse DescribeSchedulesSync(DescribeSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeSchedulesResponse>(req, "DescribeSchedules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据智能字幕 模板唯一标识，获取智能字幕模板详情列表。返回结果包含符合条件的所有用户自定义智能字幕模板及系统预置智能字幕模板
        /// </summary>
        /// <param name="req"><see cref="DescribeSmartSubtitleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSmartSubtitleTemplatesResponse"/></returns>
        public Task<DescribeSmartSubtitleTemplatesResponse> DescribeSmartSubtitleTemplates(DescribeSmartSubtitleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSmartSubtitleTemplatesResponse>(req, "DescribeSmartSubtitleTemplates");
        }

        /// <summary>
        /// 根据智能字幕 模板唯一标识，获取智能字幕模板详情列表。返回结果包含符合条件的所有用户自定义智能字幕模板及系统预置智能字幕模板
        /// </summary>
        /// <param name="req"><see cref="DescribeSmartSubtitleTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSmartSubtitleTemplatesResponse"/></returns>
        public DescribeSmartSubtitleTemplatesResponse DescribeSmartSubtitleTemplatesSync(DescribeSmartSubtitleTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSmartSubtitleTemplatesResponse>(req, "DescribeSmartSubtitleTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates");
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotByTimeOffsetTemplatesResponse>(req, "DescribeSnapshotByTimeOffsetTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输开通状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkActivateStateRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkActivateStateResponse"/></returns>
        public Task<DescribeStreamLinkActivateStateResponse> DescribeStreamLinkActivateState(DescribeStreamLinkActivateStateRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkActivateStateResponse>(req, "DescribeStreamLinkActivateState");
        }

        /// <summary>
        /// 查询媒体传输开通状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkActivateStateRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkActivateStateResponse"/></returns>
        public DescribeStreamLinkActivateStateResponse DescribeStreamLinkActivateStateSync(DescribeStreamLinkActivateStateRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkActivateStateResponse>(req, "DescribeStreamLinkActivateState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输事件的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventResponse"/></returns>
        public Task<DescribeStreamLinkEventResponse> DescribeStreamLinkEvent(DescribeStreamLinkEventRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventResponse>(req, "DescribeStreamLinkEvent");
        }

        /// <summary>
        /// 查询媒体传输事件的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventResponse"/></returns>
        public DescribeStreamLinkEventResponse DescribeStreamLinkEventSync(DescribeStreamLinkEventRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventResponse>(req, "DescribeStreamLinkEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输事件关联的所有媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventAttachedFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventAttachedFlowsResponse"/></returns>
        public Task<DescribeStreamLinkEventAttachedFlowsResponse> DescribeStreamLinkEventAttachedFlows(DescribeStreamLinkEventAttachedFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventAttachedFlowsResponse>(req, "DescribeStreamLinkEventAttachedFlows");
        }

        /// <summary>
        /// 查询媒体传输事件关联的所有媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventAttachedFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventAttachedFlowsResponse"/></returns>
        public DescribeStreamLinkEventAttachedFlowsResponse DescribeStreamLinkEventAttachedFlowsSync(DescribeStreamLinkEventAttachedFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventAttachedFlowsResponse>(req, "DescribeStreamLinkEventAttachedFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询媒体传输事件的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventsResponse"/></returns>
        public Task<DescribeStreamLinkEventsResponse> DescribeStreamLinkEvents(DescribeStreamLinkEventsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventsResponse>(req, "DescribeStreamLinkEvents");
        }

        /// <summary>
        /// 批量查询媒体传输事件的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkEventsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkEventsResponse"/></returns>
        public DescribeStreamLinkEventsResponse DescribeStreamLinkEventsSync(DescribeStreamLinkEventsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkEventsResponse>(req, "DescribeStreamLinkEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public Task<DescribeStreamLinkFlowResponse> DescribeStreamLinkFlow(DescribeStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowResponse>(req, "DescribeStreamLinkFlow");
        }

        /// <summary>
        /// 查询媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowResponse"/></returns>
        public DescribeStreamLinkFlowResponse DescribeStreamLinkFlowSync(DescribeStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowResponse>(req, "DescribeStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输流的日志信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public Task<DescribeStreamLinkFlowLogsResponse> DescribeStreamLinkFlowLogs(DescribeStreamLinkFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowLogsResponse>(req, "DescribeStreamLinkFlowLogs");
        }

        /// <summary>
        /// 查询媒体传输流的日志信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowLogsResponse"/></returns>
        public DescribeStreamLinkFlowLogsResponse DescribeStreamLinkFlowLogsSync(DescribeStreamLinkFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowLogsResponse>(req, "DescribeStreamLinkFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输流的媒体质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowMediaStatisticsResponse> DescribeStreamLinkFlowMediaStatistics(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowMediaStatisticsResponse>(req, "DescribeStreamLinkFlowMediaStatistics");
        }

        /// <summary>
        /// 查询媒体传输流的媒体质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowMediaStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowMediaStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowMediaStatisticsResponse DescribeStreamLinkFlowMediaStatisticsSync(DescribeStreamLinkFlowMediaStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowMediaStatisticsResponse>(req, "DescribeStreamLinkFlowMediaStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实时查询流的当前状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public Task<DescribeStreamLinkFlowRealtimeStatusResponse> DescribeStreamLinkFlowRealtimeStatus(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowRealtimeStatusResponse>(req, "DescribeStreamLinkFlowRealtimeStatus");
        }

        /// <summary>
        /// 实时查询流的当前状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowRealtimeStatusRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowRealtimeStatusResponse"/></returns>
        public DescribeStreamLinkFlowRealtimeStatusResponse DescribeStreamLinkFlowRealtimeStatusSync(DescribeStreamLinkFlowRealtimeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowRealtimeStatusResponse>(req, "DescribeStreamLinkFlowRealtimeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输流的SRT质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowSRTStatisticsResponse> DescribeStreamLinkFlowSRTStatistics(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowSRTStatisticsResponse>(req, "DescribeStreamLinkFlowSRTStatistics");
        }

        /// <summary>
        /// 查询媒体传输流的SRT质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowSRTStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowSRTStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowSRTStatisticsResponse DescribeStreamLinkFlowSRTStatisticsSync(DescribeStreamLinkFlowSRTStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowSRTStatisticsResponse>(req, "DescribeStreamLinkFlowSRTStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输流的媒体质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public Task<DescribeStreamLinkFlowStatisticsResponse> DescribeStreamLinkFlowStatistics(DescribeStreamLinkFlowStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowStatisticsResponse>(req, "DescribeStreamLinkFlowStatistics");
        }

        /// <summary>
        /// 查询媒体传输流的媒体质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowStatisticsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowStatisticsResponse"/></returns>
        public DescribeStreamLinkFlowStatisticsResponse DescribeStreamLinkFlowStatisticsSync(DescribeStreamLinkFlowStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowStatisticsResponse>(req, "DescribeStreamLinkFlowStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public Task<DescribeStreamLinkFlowsResponse> DescribeStreamLinkFlows(DescribeStreamLinkFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowsResponse>(req, "DescribeStreamLinkFlows");
        }

        /// <summary>
        /// 批量查询媒体输入流的配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkFlowsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkFlowsResponse"/></returns>
        public DescribeStreamLinkFlowsResponse DescribeStreamLinkFlowsSync(DescribeStreamLinkFlowsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkFlowsResponse>(req, "DescribeStreamLinkFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询媒体传输所有地区。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public Task<DescribeStreamLinkRegionsResponse> DescribeStreamLinkRegions(DescribeStreamLinkRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkRegionsResponse>(req, "DescribeStreamLinkRegions");
        }

        /// <summary>
        /// 查询媒体传输所有地区。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkRegionsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkRegionsResponse"/></returns>
        public DescribeStreamLinkRegionsResponse DescribeStreamLinkRegionsSync(DescribeStreamLinkRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkRegionsResponse>(req, "DescribeStreamLinkRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkSecurityGroupsResponse"/></returns>
        public Task<DescribeStreamLinkSecurityGroupsResponse> DescribeStreamLinkSecurityGroups(DescribeStreamLinkSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkSecurityGroupsResponse>(req, "DescribeStreamLinkSecurityGroups");
        }

        /// <summary>
        /// 批量查询安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamLinkSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeStreamLinkSecurityGroupsResponse"/></returns>
        public DescribeStreamLinkSecurityGroupsResponse DescribeStreamLinkSecurityGroupsSync(DescribeStreamLinkSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStreamLinkSecurityGroupsResponse>(req, "DescribeStreamLinkSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询7天之内提交的任务）。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询7天之内提交的任务）。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近七天（168小时）内的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近七天（168小时）内的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates");
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTranscodeTemplatesResponse>(req, "DescribeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID查询视频入库任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDatabaseEntryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVideoDatabaseEntryTaskDetailResponse"/></returns>
        public Task<DescribeVideoDatabaseEntryTaskDetailResponse> DescribeVideoDatabaseEntryTaskDetail(DescribeVideoDatabaseEntryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVideoDatabaseEntryTaskDetailResponse>(req, "DescribeVideoDatabaseEntryTaskDetail");
        }

        /// <summary>
        /// 根据任务ID查询视频入库任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDatabaseEntryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVideoDatabaseEntryTaskDetailResponse"/></returns>
        public DescribeVideoDatabaseEntryTaskDetailResponse DescribeVideoDatabaseEntryTaskDetailSync(DescribeVideoDatabaseEntryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVideoDatabaseEntryTaskDetailResponse>(req, "DescribeVideoDatabaseEntryTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID查询视频检索任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSearchTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVideoSearchTaskDetailResponse"/></returns>
        public Task<DescribeVideoSearchTaskDetailResponse> DescribeVideoSearchTaskDetail(DescribeVideoSearchTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVideoSearchTaskDetailResponse>(req, "DescribeVideoSearchTaskDetail");
        }

        /// <summary>
        /// 根据任务ID查询视频检索任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSearchTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVideoSearchTaskDetailResponse"/></returns>
        public DescribeVideoSearchTaskDetailResponse DescribeVideoSearchTaskDetailSync(DescribeVideoSearchTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVideoSearchTaskDetailResponse>(req, "DescribeVideoSearchTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates");
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWatermarkTemplatesResponse>(req, "DescribeWatermarkTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples");
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
            return InternalRequestAsync<DescribeWordSamplesResponse>(req, "DescribeWordSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据工作流 ID，获取工作流详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public Task<DescribeWorkflowsResponse> DescribeWorkflows(DescribeWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowsResponse>(req, "DescribeWorkflows");
        }

        /// <summary>
        /// 根据工作流 ID，获取工作流详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public DescribeWorkflowsResponse DescribeWorkflowsSync(DescribeWorkflowsRequest req)
        {
            return InternalRequestAsync<DescribeWorkflowsResponse>(req, "DescribeWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用自动化触发编排任务。
        /// </summary>
        /// <param name="req"><see cref="DisableScheduleRequest"/></param>
        /// <returns><see cref="DisableScheduleResponse"/></returns>
        public Task<DisableScheduleResponse> DisableSchedule(DisableScheduleRequest req)
        {
            return InternalRequestAsync<DisableScheduleResponse>(req, "DisableSchedule");
        }

        /// <summary>
        /// 禁用自动化触发编排任务。
        /// </summary>
        /// <param name="req"><see cref="DisableScheduleRequest"/></param>
        /// <returns><see cref="DisableScheduleResponse"/></returns>
        public DisableScheduleResponse DisableScheduleSync(DisableScheduleRequest req)
        {
            return InternalRequestAsync<DisableScheduleResponse>(req, "DisableSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用工作流。
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public Task<DisableWorkflowResponse> DisableWorkflow(DisableWorkflowRequest req)
        {
            return InternalRequestAsync<DisableWorkflowResponse>(req, "DisableWorkflow");
        }

        /// <summary>
        /// 禁用工作流。
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public DisableWorkflowResponse DisableWorkflowSync(DisableWorkflowRequest req)
        {
            return InternalRequestAsync<DisableWorkflowResponse>(req, "DisableWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑安全组下面关联的输入输出。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupResponse"/></returns>
        public Task<DisassociateSecurityGroupResponse> DisassociateSecurityGroup(DisassociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupResponse>(req, "DisassociateSecurityGroup");
        }

        /// <summary>
        /// 批量解绑安全组下面关联的输入输出。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupResponse"/></returns>
        public DisassociateSecurityGroupResponse DisassociateSecurityGroupSync(DisassociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupResponse>(req, "DisassociateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对视频进行编辑，生成一个新的视频。编辑的功能包括：
        ///  
        /// 
        /// 一、**剪辑任务**：简单的视频剪辑，如剪辑、拼接等
        /// 1. 对一个文件进行剪辑，生成一个新的视频；
        /// 2. 对多个文件进行拼接，生成一个新的视频；
        /// 3. 对多个文件进行剪辑，然后再拼接，生成一个新的视频。
        /// 
        /// 二、**合成任务**：通过接口描述信息，合成一个新的视频。
        /// 1. 多轨道（视频、音频、字幕）、多类型元素（视频、图片、音频、文字、空）
        /// 2. 图像级别：贴图、缩放、任意角度旋转、镜像等
        /// 3. 音频级别：音量控制、淡入淡出、混音等
        /// 4. 视频级别：转场、倍数播放、拼接、剪切、字幕、画中画、音画分离、出入场动效等
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia");
        }

        /// <summary>
        /// 对视频进行编辑，生成一个新的视频。编辑的功能包括：
        ///  
        /// 
        /// 一、**剪辑任务**：简单的视频剪辑，如剪辑、拼接等
        /// 1. 对一个文件进行剪辑，生成一个新的视频；
        /// 2. 对多个文件进行拼接，生成一个新的视频；
        /// 3. 对多个文件进行剪辑，然后再拼接，生成一个新的视频。
        /// 
        /// 二、**合成任务**：通过接口描述信息，合成一个新的视频。
        /// 1. 多轨道（视频、音频、字幕）、多类型元素（视频、图片、音频、文字、空）
        /// 2. 图像级别：贴图、缩放、任意角度旋转、镜像等
        /// 3. 音频级别：音量控制、淡入淡出、混音等
        /// 4. 视频级别：转场、倍数播放、拼接、剪切、字幕、画中画、音画分离、出入场动效等
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用自动化触发编排任务。
        /// </summary>
        /// <param name="req"><see cref="EnableScheduleRequest"/></param>
        /// <returns><see cref="EnableScheduleResponse"/></returns>
        public Task<EnableScheduleResponse> EnableSchedule(EnableScheduleRequest req)
        {
            return InternalRequestAsync<EnableScheduleResponse>(req, "EnableSchedule");
        }

        /// <summary>
        /// 启用自动化触发编排任务。
        /// </summary>
        /// <param name="req"><see cref="EnableScheduleRequest"/></param>
        /// <returns><see cref="EnableScheduleResponse"/></returns>
        public EnableScheduleResponse EnableScheduleSync(EnableScheduleRequest req)
        {
            return InternalRequestAsync<EnableScheduleResponse>(req, "EnableSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用工作流。
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public Task<EnableWorkflowResponse> EnableWorkflow(EnableWorkflowRequest req)
        {
            return InternalRequestAsync<EnableWorkflowResponse>(req, "EnableWorkflow");
        }

        /// <summary>
        /// 启用工作流。
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public EnableWorkflowResponse EnableWorkflowSync(EnableWorkflowRequest req)
        {
            return InternalRequestAsync<EnableWorkflowResponse>(req, "EnableWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云媒体处理客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction");
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云媒体处理客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask");
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
            return InternalRequestAsync<ManageTaskResponse>(req, "ManageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate");
        }

        /// <summary>
        /// 修改用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public ModifyAIAnalysisTemplateResponse ModifyAIAnalysisTemplateSync(ModifyAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIAnalysisTemplateResponse>(req, "ModifyAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate");
        }

        /// <summary>
        /// 修改用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate");
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAdaptiveDynamicStreamingTemplateResponse>(req, "ModifyAdaptiveDynamicStreamingTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate");
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAnimatedGraphicsTemplateResponse>(req, "ModifyAnimatedGraphicsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能字幕更新热词库接口
        /// </summary>
        /// <param name="req"><see cref="ModifyAsrHotwordsRequest"/></param>
        /// <returns><see cref="ModifyAsrHotwordsResponse"/></returns>
        public Task<ModifyAsrHotwordsResponse> ModifyAsrHotwords(ModifyAsrHotwordsRequest req)
        {
            return InternalRequestAsync<ModifyAsrHotwordsResponse>(req, "ModifyAsrHotwords");
        }

        /// <summary>
        /// 智能字幕更新热词库接口
        /// </summary>
        /// <param name="req"><see cref="ModifyAsrHotwordsRequest"/></param>
        /// <returns><see cref="ModifyAsrHotwordsResponse"/></returns>
        public ModifyAsrHotwordsResponse ModifyAsrHotwordsSync(ModifyAsrHotwordsRequest req)
        {
            return InternalRequestAsync<ModifyAsrHotwordsResponse>(req, "ModifyAsrHotwords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate");
        }

        /// <summary>
        /// 修改用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate");
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
            return InternalRequestAsync<ModifyImageSpriteTemplateResponse>(req, "ModifyImageSpriteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改直播录制模板
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public Task<ModifyLiveRecordTemplateResponse> ModifyLiveRecordTemplate(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate");
        }

        /// <summary>
        /// 修改直播录制模板
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordTemplateRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordTemplateResponse"/></returns>
        public ModifyLiveRecordTemplateResponse ModifyLiveRecordTemplateSync(ModifyLiveRecordTemplateRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordTemplateResponse>(req, "ModifyLiveRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample");
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
            return InternalRequestAsync<ModifyPersonSampleResponse>(req, "ModifyPersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体质检模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityControlTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityControlTemplateResponse"/></returns>
        public Task<ModifyQualityControlTemplateResponse> ModifyQualityControlTemplate(ModifyQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityControlTemplateResponse>(req, "ModifyQualityControlTemplate");
        }

        /// <summary>
        /// 修改媒体质检模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityControlTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityControlTemplateResponse"/></returns>
        public ModifyQualityControlTemplateResponse ModifyQualityControlTemplateSync(ModifyQualityControlTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityControlTemplateResponse>(req, "ModifyQualityControlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate");
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ModifySampleSnapshotTemplateResponse>(req, "ModifySampleSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改编排
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduleRequest"/></param>
        /// <returns><see cref="ModifyScheduleResponse"/></returns>
        public Task<ModifyScheduleResponse> ModifySchedule(ModifyScheduleRequest req)
        {
            return InternalRequestAsync<ModifyScheduleResponse>(req, "ModifySchedule");
        }

        /// <summary>
        /// 修改编排
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduleRequest"/></param>
        /// <returns><see cref="ModifyScheduleResponse"/></returns>
        public ModifyScheduleResponse ModifyScheduleSync(ModifyScheduleRequest req)
        {
            return InternalRequestAsync<ModifyScheduleResponse>(req, "ModifySchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义智能字幕模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="ModifySmartSubtitleTemplateResponse"/></returns>
        public Task<ModifySmartSubtitleTemplateResponse> ModifySmartSubtitleTemplate(ModifySmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<ModifySmartSubtitleTemplateResponse>(req, "ModifySmartSubtitleTemplate");
        }

        /// <summary>
        /// 修改用户自定义智能字幕模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySmartSubtitleTemplateRequest"/></param>
        /// <returns><see cref="ModifySmartSubtitleTemplateResponse"/></returns>
        public ModifySmartSubtitleTemplateResponse ModifySmartSubtitleTemplateSync(ModifySmartSubtitleTemplateRequest req)
        {
            return InternalRequestAsync<ModifySmartSubtitleTemplateResponse>(req, "ModifySmartSubtitleTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate");
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
            return InternalRequestAsync<ModifySnapshotByTimeOffsetTemplateResponse>(req, "ModifySnapshotByTimeOffsetTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体传输的事件配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkEventRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkEventResponse"/></returns>
        public Task<ModifyStreamLinkEventResponse> ModifyStreamLinkEvent(ModifyStreamLinkEventRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkEventResponse>(req, "ModifyStreamLinkEvent");
        }

        /// <summary>
        /// 修改媒体传输的事件配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkEventRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkEventResponse"/></returns>
        public ModifyStreamLinkEventResponse ModifyStreamLinkEventSync(ModifyStreamLinkEventRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkEventResponse>(req, "ModifyStreamLinkEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体传输的传输流配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public Task<ModifyStreamLinkFlowResponse> ModifyStreamLinkFlow(ModifyStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkFlowResponse>(req, "ModifyStreamLinkFlow");
        }

        /// <summary>
        /// 修改媒体传输的传输流配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkFlowRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkFlowResponse"/></returns>
        public ModifyStreamLinkFlowResponse ModifyStreamLinkFlowSync(ModifyStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkFlowResponse>(req, "ModifyStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体传输流的输入信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public Task<ModifyStreamLinkInputResponse> ModifyStreamLinkInput(ModifyStreamLinkInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkInputResponse>(req, "ModifyStreamLinkInput");
        }

        /// <summary>
        /// 修改媒体传输流的输入信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkInputRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkInputResponse"/></returns>
        public ModifyStreamLinkInputResponse ModifyStreamLinkInputSync(ModifyStreamLinkInputRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkInputResponse>(req, "ModifyStreamLinkInput")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体传输流的输出配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public Task<ModifyStreamLinkOutputInfoResponse> ModifyStreamLinkOutputInfo(ModifyStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkOutputInfoResponse>(req, "ModifyStreamLinkOutputInfo");
        }

        /// <summary>
        /// 修改媒体传输流的输出配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkOutputInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkOutputInfoResponse"/></returns>
        public ModifyStreamLinkOutputInfoResponse ModifyStreamLinkOutputInfoSync(ModifyStreamLinkOutputInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkOutputInfoResponse>(req, "ModifyStreamLinkOutputInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkSecurityGroupResponse"/></returns>
        public Task<ModifyStreamLinkSecurityGroupResponse> ModifyStreamLinkSecurityGroup(ModifyStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkSecurityGroupResponse>(req, "ModifyStreamLinkSecurityGroup");
        }

        /// <summary>
        /// 更新安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamLinkSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyStreamLinkSecurityGroupResponse"/></returns>
        public ModifyStreamLinkSecurityGroupResponse ModifyStreamLinkSecurityGroupSync(ModifyStreamLinkSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyStreamLinkSecurityGroupResponse>(req, "ModifyStreamLinkSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate");
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTranscodeTemplateResponse>(req, "ModifyTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate");
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWatermarkTemplateResponse>(req, "ModifyWatermarkTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample");
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
            return InternalRequestAsync<ModifyWordSampleResponse>(req, "ModifyWordSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 直播流处理事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 中的解析实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public Task<ParseLiveStreamProcessNotificationResponse> ParseLiveStreamProcessNotification(ParseLiveStreamProcessNotificationRequest req)
        {
            return InternalRequestAsync<ParseLiveStreamProcessNotificationResponse>(req, "ParseLiveStreamProcessNotification");
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 直播流处理事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 中的解析实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public ParseLiveStreamProcessNotificationResponse ParseLiveStreamProcessNotificationSync(ParseLiveStreamProcessNotificationRequest req)
        {
            return InternalRequestAsync<ParseLiveStreamProcessNotificationResponse>(req, "ParseLiveStreamProcessNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 中的解析函数，实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public Task<ParseNotificationResponse> ParseNotification(ParseNotificationRequest req)
        {
            return InternalRequestAsync<ParseNotificationResponse>(req, "ParseNotification");
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 中的解析函数，实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public ParseNotificationResponse ParseNotificationSync(ParseNotificationRequest req)
        {
            return InternalRequestAsync<ParseNotificationResponse>(req, "ParseNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起图片处理，功能包括：
        /// 1. 格式转换；
        /// 2. 图像增强；
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public Task<ProcessImageResponse> ProcessImage(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage");
        }

        /// <summary>
        /// 发起图片处理，功能包括：
        /// 1. 格式转换；
        /// 2. 图像增强；
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public ProcessImageResponse ProcessImageSync(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对直播流媒体发起处理任务，功能包括：
        /// 
        /// * 智能内容审核（画面鉴黄、敏感信息检测、声音鉴黄）；
        /// * 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音实时翻译、物体识别、游戏打点）。
        /// * 智能内容分析（新闻实时拆条）。
        /// * 质检（直播流格式诊断、音画内容检测（抖动、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等）、无参考打分）。
        /// * 录制
        /// 
        /// 直播流处理事件通知支持HTTP回调，也支持实时写入用户指定的消息队列 CMQ 中，用户从消息队列 CMQ 中获取事件通知结果，同时处理过程中存在输出文件的，会写入用户指定的输出文件的目标存储中。
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public Task<ProcessLiveStreamResponse> ProcessLiveStream(ProcessLiveStreamRequest req)
        {
            return InternalRequestAsync<ProcessLiveStreamResponse>(req, "ProcessLiveStream");
        }

        /// <summary>
        /// 对直播流媒体发起处理任务，功能包括：
        /// 
        /// * 智能内容审核（画面鉴黄、敏感信息检测、声音鉴黄）；
        /// * 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音实时翻译、物体识别、游戏打点）。
        /// * 智能内容分析（新闻实时拆条）。
        /// * 质检（直播流格式诊断、音画内容检测（抖动、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等）、无参考打分）。
        /// * 录制
        /// 
        /// 直播流处理事件通知支持HTTP回调，也支持实时写入用户指定的消息队列 CMQ 中，用户从消息队列 CMQ 中获取事件通知结果，同时处理过程中存在输出文件的，会写入用户指定的输出文件的目标存储中。
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public ProcessLiveStreamResponse ProcessLiveStreamSync(ProcessLiveStreamRequest req)
        {
            return InternalRequestAsync<ProcessLiveStreamResponse>(req, "ProcessLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对 URL视频链接 或 COS 中的媒体文件发起处理任务，功能包括：
        /// 1. 视频转码（普通转码、极速高清转码、音视频增强）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签、拆条、集锦、片头片尾、游戏打点）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音翻译、物体识别）。
        /// 10. 媒体质检（直播流格式诊断、音画内容检测（抖动、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等）、无参考打分）
        /// 11. 智能字幕（语音全文、语音热词、语音翻译）
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia");
        }

        /// <summary>
        /// 对 URL视频链接 或 COS 中的媒体文件发起处理任务，功能包括：
        /// 1. 视频转码（普通转码、极速高清转码、音视频增强）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签、拆条、集锦、片头片尾、游戏打点）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音翻译、物体识别）。
        /// 10. 媒体质检（直播流格式诊断、音画内容检测（抖动、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等）、无参考打分）
        /// 11. 智能字幕（语音全文、语音热词、语音翻译）
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能媒体识别，包含表情和动作识别。仅用于智学，其他调用无效。
        /// </summary>
        /// <param name="req"><see cref="RecognizeMediaForZhiXueRequest"/></param>
        /// <returns><see cref="RecognizeMediaForZhiXueResponse"/></returns>
        public Task<RecognizeMediaForZhiXueResponse> RecognizeMediaForZhiXue(RecognizeMediaForZhiXueRequest req)
        {
            return InternalRequestAsync<RecognizeMediaForZhiXueResponse>(req, "RecognizeMediaForZhiXue");
        }

        /// <summary>
        /// 智能媒体识别，包含表情和动作识别。仅用于智学，其他调用无效。
        /// </summary>
        /// <param name="req"><see cref="RecognizeMediaForZhiXueRequest"/></param>
        /// <returns><see cref="RecognizeMediaForZhiXueResponse"/></returns>
        public RecognizeMediaForZhiXueResponse RecognizeMediaForZhiXueSync(RecognizeMediaForZhiXueRequest req)
        {
            return InternalRequestAsync<RecognizeMediaForZhiXueResponse>(req, "RecognizeMediaForZhiXue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新设置一个已经存在且处于禁用状态的工作流。
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public Task<ResetWorkflowResponse> ResetWorkflow(ResetWorkflowRequest req)
        {
            return InternalRequestAsync<ResetWorkflowResponse>(req, "ResetWorkflow");
        }

        /// <summary>
        /// 重新设置一个已经存在且处于禁用状态的工作流。
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public ResetWorkflowResponse ResetWorkflowSync(ResetWorkflowRequest req)
        {
            return InternalRequestAsync<ResetWorkflowResponse>(req, "ResetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public Task<StartStreamLinkFlowResponse> StartStreamLinkFlow(StartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StartStreamLinkFlowResponse>(req, "StartStreamLinkFlow");
        }

        /// <summary>
        /// 启动媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="StartStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StartStreamLinkFlowResponse"/></returns>
        public StartStreamLinkFlowResponse StartStreamLinkFlowSync(StartStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StartStreamLinkFlowResponse>(req, "StartStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public Task<StopStreamLinkFlowResponse> StopStreamLinkFlow(StopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StopStreamLinkFlowResponse>(req, "StopStreamLinkFlow");
        }

        /// <summary>
        /// 停止媒体传输流。
        /// </summary>
        /// <param name="req"><see cref="StopStreamLinkFlowRequest"/></param>
        /// <returns><see cref="StopStreamLinkFlowResponse"/></returns>
        public StopStreamLinkFlowResponse StopStreamLinkFlowSync(StopStreamLinkFlowRequest req)
        {
            return InternalRequestAsync<StopStreamLinkFlowResponse>(req, "StopStreamLinkFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提取视频中的盲水印。
        /// </summary>
        /// <param name="req"><see cref="WithdrawsWatermarkRequest"/></param>
        /// <returns><see cref="WithdrawsWatermarkResponse"/></returns>
        public Task<WithdrawsWatermarkResponse> WithdrawsWatermark(WithdrawsWatermarkRequest req)
        {
            return InternalRequestAsync<WithdrawsWatermarkResponse>(req, "WithdrawsWatermark");
        }

        /// <summary>
        /// 提取视频中的盲水印。
        /// </summary>
        /// <param name="req"><see cref="WithdrawsWatermarkRequest"/></param>
        /// <returns><see cref="WithdrawsWatermarkResponse"/></returns>
        public WithdrawsWatermarkResponse WithdrawsWatermarkSync(WithdrawsWatermarkRequest req)
        {
            return InternalRequestAsync<WithdrawsWatermarkResponse>(req, "WithdrawsWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
