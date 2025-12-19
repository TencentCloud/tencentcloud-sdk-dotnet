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

namespace TencentCloud.Vod.V20180717
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vod.V20180717.Models;

   public class VodClient : AbstractClient{

       private const string endpoint = "vod.tencentcloudapi.com";
       private const string version = "2018-07-17";
       private const string sdkVersion = "SDK_NET_3.0.1363";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// * 我们强烈建议您使用云点播提供的 [服务端上传 SDK](/document/product/266/9759#1.-.E5.8F.91.E8.B5.B7.E4.B8.8A.E4.BC.A0) 来上传文件。直接调用 API 进行上传的难度和工作量都显著大于使用 SDK。
        /// * 该接口用于申请媒体文件（和封面文件）的上传，获取文件上传到云点播的元信息（包括上传路径、上传签名等），用于后续上传接口。
        /// * 上传流程请参考 [服务端上传综述](/document/product/266/9759)。
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload");
        }

        /// <summary>
        /// * 我们强烈建议您使用云点播提供的 [服务端上传 SDK](/document/product/266/9759#1.-.E5.8F.91.E8.B5.B7.E4.B8.8A.E4.BC.A0) 来上传文件。直接调用 API 进行上传的难度和工作量都显著大于使用 SDK。
        /// * 该接口用于申请媒体文件（和封面文件）的上传，获取文件上传到云点播的元信息（包括上传路径、上传签名等），用于后续上传接口。
        /// * 上传流程请参考 [服务端上传综述](/document/product/266/9759)。
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public ApplyUploadResponse ApplyUploadSync(ApplyUploadRequest req)
        {
            return InternalRequestAsync<ApplyUploadResponse>(req, "ApplyUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联媒资字幕，将指定的字幕关联到转自适应码流模板号对应的媒体输出文件中（或解除关联）。
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public Task<AttachMediaSubtitlesResponse> AttachMediaSubtitles(AttachMediaSubtitlesRequest req)
        {
            return InternalRequestAsync<AttachMediaSubtitlesResponse>(req, "AttachMediaSubtitles");
        }

        /// <summary>
        /// 关联媒资字幕，将指定的字幕关联到转自适应码流模板号对应的媒体输出文件中（或解除关联）。
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public AttachMediaSubtitlesResponse AttachMediaSubtitlesSync(AttachMediaSubtitlesRequest req)
        {
            return InternalRequestAsync<AttachMediaSubtitlesResponse>(req, "AttachMediaSubtitles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload");
        }

        /// <summary>
        /// 该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public CommitUploadResponse CommitUploadSync(CommitUploadRequest req)
        {
            return InternalRequestAsync<CommitUploadResponse>(req, "CommitUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于合成媒体文件，可以达到以下效果：
        /// 
        /// 1. **画面旋转**：对视频、图片的画面旋转一定角度，或按照某个方向翻转。
        /// 2. **声音控制**：升高降低视频、音频中声音的音量，或者对视频静音。
        /// 3. **画面叠加**：将视频、图片中的画面依序叠加在一起，如实现“画中画”的效果。
        /// 4. **声音混合**：将视频、音频中的声音混合在一起（混音）。
        /// 5. **声音提取**：将视频中的音频提取出来（不保留画面）。
        /// 6. **裁剪**：对视频、音频裁剪出指定时间段。
        /// 7. **拼接**：对视频、音频、图片按时间顺序前后拼接。
        /// 8. **转场**：将多段视频或图片拼接时，可以在段落之间添加转场效果。
        /// 
        /// 合成后的媒体封装格式可以是 MP4（视频）或 MP3（音频）。如使用事件通知，事件通知的类型为 [视频合成完成](https://cloud.tencent.com/document/product/266/43000)。
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public Task<ComposeMediaResponse> ComposeMedia(ComposeMediaRequest req)
        {
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia");
        }

        /// <summary>
        /// 该接口用于合成媒体文件，可以达到以下效果：
        /// 
        /// 1. **画面旋转**：对视频、图片的画面旋转一定角度，或按照某个方向翻转。
        /// 2. **声音控制**：升高降低视频、音频中声音的音量，或者对视频静音。
        /// 3. **画面叠加**：将视频、图片中的画面依序叠加在一起，如实现“画中画”的效果。
        /// 4. **声音混合**：将视频、音频中的声音混合在一起（混音）。
        /// 5. **声音提取**：将视频中的音频提取出来（不保留画面）。
        /// 6. **裁剪**：对视频、音频裁剪出指定时间段。
        /// 7. **拼接**：对视频、音频、图片按时间顺序前后拼接。
        /// 8. **转场**：将多段视频或图片拼接时，可以在段落之间添加转场效果。
        /// 
        /// 合成后的媒体封装格式可以是 MP4（视频）或 MP3（音频）。如使用事件通知，事件通知的类型为 [视频合成完成](https://cloud.tencent.com/document/product/266/43000)。
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public ComposeMediaResponse ComposeMediaSync(ComposeMediaRequest req)
        {
            return InternalRequestAsync<ComposeMediaResponse>(req, "ComposeMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 开发者调用拉取事件通知，获取到事件后，必须调用该接口来确认消息已经收到；
        /// * 开发者获取到事件句柄后，等待确认的有效时间为 30 秒，超出 30 秒会报参数错误（4000）；
        /// * 更多参考事件通知的[可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83)。
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public Task<ConfirmEventsResponse> ConfirmEvents(ConfirmEventsRequest req)
        {
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents");
        }

        /// <summary>
        /// * 开发者调用拉取事件通知，获取到事件后，必须调用该接口来确认消息已经收到；
        /// * 开发者获取到事件句柄后，等待确认的有效时间为 30 秒，超出 30 秒会报参数错误（4000）；
        /// * 更多参考事件通知的[可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83)。
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public ConfirmEventsResponse ConfirmEventsSync(ConfirmEventsRequest req)
        {
            return InternalRequestAsync<ConfirmEventsResponse>(req, "ConfirmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义音视频内容分析模板，数量上限：50。暂时不支持 HLS 格式。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate");
        }

        /// <summary>
        /// 创建用户自定义音视频内容分析模板，数量上限：50。暂时不支持 HLS 格式。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIAnalysisTemplateResponse>(req, "CreateAIAnalysisTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义音视频内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<CreateAIRecognitionTemplateResponse>(req, "CreateAIRecognitionTemplate");
        }

        /// <summary>
        /// 创建用户自定义音视频内容识别模板，数量上限：50。
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
        /// 该接口用于[生成 AIGC 图片](https://cloud.tencent.com/document/product/266/124473)。<b>接口处于内测阶段，如需使用请[联系我们](https://cloud.tencent.com/online-service?from=sales_sales&source=PRESALE)，接口调用会产生实际费用，</b>请参考点播 [AIGC 生图片计费文档](https://cloud.tencent.com/document/product/266/95125#9c4dc6ff-4b3f-4b25-bf2d-393889dfb9ac)。该功能结算模式为[后付费](https://cloud.tencent.com/document/product/266/2838)，日结客户当天使用将在第二天出账，月结客户将在次月1日统一出上月使用费用。
        /// </summary>
        /// <param name="req"><see cref="CreateAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateAigcImageTaskResponse"/></returns>
        public Task<CreateAigcImageTaskResponse> CreateAigcImageTask(CreateAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcImageTaskResponse>(req, "CreateAigcImageTask");
        }

        /// <summary>
        /// 该接口用于[生成 AIGC 图片](https://cloud.tencent.com/document/product/266/124473)。<b>接口处于内测阶段，如需使用请[联系我们](https://cloud.tencent.com/online-service?from=sales_sales&source=PRESALE)，接口调用会产生实际费用，</b>请参考点播 [AIGC 生图片计费文档](https://cloud.tencent.com/document/product/266/95125#9c4dc6ff-4b3f-4b25-bf2d-393889dfb9ac)。该功能结算模式为[后付费](https://cloud.tencent.com/document/product/266/2838)，日结客户当天使用将在第二天出账，月结客户将在次月1日统一出上月使用费用。
        /// </summary>
        /// <param name="req"><see cref="CreateAigcImageTaskRequest"/></param>
        /// <returns><see cref="CreateAigcImageTaskResponse"/></returns>
        public CreateAigcImageTaskResponse CreateAigcImageTaskSync(CreateAigcImageTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcImageTaskResponse>(req, "CreateAigcImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于[生成 AIGC 视频](https://cloud.tencent.com/document/product/266/124474)。<b>接口处于内测阶段，如需使用请[联系我们](https://cloud.tencent.com/online-service?from=sales_sales&source=PRESALE)，接口调用会产生实际费用</b>，请参考点播 [AIGC 生视频计费文档](https://cloud.tencent.com/document/product/266/95125#96b3b59a-f9e1-49e9-966a-bedb70a4bf12)。该功能结算模式为[后付费](https://cloud.tencent.com/document/product/266/2838)，日结客户当天使用将在第二天出账，月结客户将在次月1日统一出上月使用费用。
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoTaskResponse"/></returns>
        public Task<CreateAigcVideoTaskResponse> CreateAigcVideoTask(CreateAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoTaskResponse>(req, "CreateAigcVideoTask");
        }

        /// <summary>
        /// 该接口用于[生成 AIGC 视频](https://cloud.tencent.com/document/product/266/124474)。<b>接口处于内测阶段，如需使用请[联系我们](https://cloud.tencent.com/online-service?from=sales_sales&source=PRESALE)，接口调用会产生实际费用</b>，请参考点播 [AIGC 生视频计费文档](https://cloud.tencent.com/document/product/266/95125#96b3b59a-f9e1-49e9-966a-bedb70a4bf12)。该功能结算模式为[后付费](https://cloud.tencent.com/document/product/266/2838)，日结客户当天使用将在第二天出账，月结客户将在次月1日统一出上月使用费用。
        /// </summary>
        /// <param name="req"><see cref="CreateAigcVideoTaskRequest"/></param>
        /// <returns><see cref="CreateAigcVideoTaskResponse"/></returns>
        public CreateAigcVideoTaskResponse CreateAigcVideoTaskSync(CreateAigcVideoTaskRequest req)
        {
            return InternalRequestAsync<CreateAigcVideoTaskResponse>(req, "CreateAigcVideoTask")
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
        /// 由 VOD 创建新的日志集。
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogsetRequest"/></param>
        /// <returns><see cref="CreateCLSLogsetResponse"/></returns>
        public Task<CreateCLSLogsetResponse> CreateCLSLogset(CreateCLSLogsetRequest req)
        {
            return InternalRequestAsync<CreateCLSLogsetResponse>(req, "CreateCLSLogset");
        }

        /// <summary>
        /// 由 VOD 创建新的日志集。
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogsetRequest"/></param>
        /// <returns><see cref="CreateCLSLogsetResponse"/></returns>
        public CreateCLSLogsetResponse CreateCLSLogsetSync(CreateCLSLogsetRequest req)
        {
            return InternalRequestAsync<CreateCLSLogsetResponse>(req, "CreateCLSLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 VOD 下新的 CLS 日志主题
        /// </summary>
        /// <param name="req"><see cref="CreateCLSTopicRequest"/></param>
        /// <returns><see cref="CreateCLSTopicResponse"/></returns>
        public Task<CreateCLSTopicResponse> CreateCLSTopic(CreateCLSTopicRequest req)
        {
            return InternalRequestAsync<CreateCLSTopicResponse>(req, "CreateCLSTopic");
        }

        /// <summary>
        /// 创建 VOD 下新的 CLS 日志主题
        /// </summary>
        /// <param name="req"><see cref="CreateCLSTopicRequest"/></param>
        /// <returns><see cref="CreateCLSTopicResponse"/></returns>
        public CreateCLSTopicResponse CreateCLSTopicSync(CreateCLSTopicRequest req)
        {
            return InternalRequestAsync<CreateCLSTopicResponse>(req, "CreateCLSTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 用于对媒体进行分类管理；
        /// * 该接口不影响既有媒体的分类，如需修改媒体分类，请调用[修改媒体文件属性](/document/product/266/31762)接口。
        /// * 分类层次不可超过 4 层。
        /// * 每个分类的子类数量不可超过 500 个。
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass");
        }

        /// <summary>
        /// * 用于对媒体进行分类管理；
        /// * 该接口不影响既有媒体的分类，如需修改媒体分类，请调用[修改媒体文件属性](/document/product/266/31762)接口。
        /// * 分类层次不可超过 4 层。
        /// * 每个分类的子类数量不可超过 500 个。
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public CreateClassResponse CreateClassSync(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起复杂自适应码流处理任务，功能包括：
        /// 1. 按指定的自适应码流模板输出 HLS、DASH 自适应码流；
        /// 2. 自适应码流的内容保护方案可选择无加密、Widevine 或 FairPlay；
        /// 3. 支持添加片头片尾；
        /// 4. 输出的自适应码流可包含多语言音频流，每种语言分别来自不同的媒体文件；
        /// 5. 输出的自适应码流可包含多语言字幕流。
        /// 
        /// 注意事项：
        /// 1. 当使用片头时，片头媒体中的视频流需要和音频流对齐，否则将导致输出的内容音画不同步；
        /// 2. 如果输出的自适应码流需要包含主媒体的音频，那么需要在 AudioSet 参数中指定主媒体的 FileId；
        /// 3. 使用字幕时，需要先将字幕添加到主媒体，可通过 ModifyMediaInfo 接口或控制台的音视频详情页进行添加；
        /// 4. 暂不支持极速高清、水印。
        /// </summary>
        /// <param name="req"><see cref="CreateComplexAdaptiveDynamicStreamingTaskRequest"/></param>
        /// <returns><see cref="CreateComplexAdaptiveDynamicStreamingTaskResponse"/></returns>
        public Task<CreateComplexAdaptiveDynamicStreamingTaskResponse> CreateComplexAdaptiveDynamicStreamingTask(CreateComplexAdaptiveDynamicStreamingTaskRequest req)
        {
            return InternalRequestAsync<CreateComplexAdaptiveDynamicStreamingTaskResponse>(req, "CreateComplexAdaptiveDynamicStreamingTask");
        }

        /// <summary>
        /// 发起复杂自适应码流处理任务，功能包括：
        /// 1. 按指定的自适应码流模板输出 HLS、DASH 自适应码流；
        /// 2. 自适应码流的内容保护方案可选择无加密、Widevine 或 FairPlay；
        /// 3. 支持添加片头片尾；
        /// 4. 输出的自适应码流可包含多语言音频流，每种语言分别来自不同的媒体文件；
        /// 5. 输出的自适应码流可包含多语言字幕流。
        /// 
        /// 注意事项：
        /// 1. 当使用片头时，片头媒体中的视频流需要和音频流对齐，否则将导致输出的内容音画不同步；
        /// 2. 如果输出的自适应码流需要包含主媒体的音频，那么需要在 AudioSet 参数中指定主媒体的 FileId；
        /// 3. 使用字幕时，需要先将字幕添加到主媒体，可通过 ModifyMediaInfo 接口或控制台的音视频详情页进行添加；
        /// 4. 暂不支持极速高清、水印。
        /// </summary>
        /// <param name="req"><see cref="CreateComplexAdaptiveDynamicStreamingTaskRequest"/></param>
        /// <returns><see cref="CreateComplexAdaptiveDynamicStreamingTaskResponse"/></returns>
        public CreateComplexAdaptiveDynamicStreamingTaskResponse CreateComplexAdaptiveDynamicStreamingTaskSync(CreateComplexAdaptiveDynamicStreamingTaskRequest req)
        {
            return InternalRequestAsync<CreateComplexAdaptiveDynamicStreamingTaskResponse>(req, "CreateComplexAdaptiveDynamicStreamingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [创建审核模板](https://cloud.tencent.com/document/api/266/84391)。
        /// 创建用户自定义音视频内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [创建审核模板](https://cloud.tencent.com/document/api/266/84391)。
        /// 创建用户自定义音视频内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateContentReviewTemplateResponse>(req, "CreateContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public Task<CreateDomainVerifyRecordResponse> CreateDomainVerifyRecord(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord");
        }

        /// <summary>
        /// 该接口用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateDomainVerifyRecordResponse"/></returns>
        public CreateDomainVerifyRecordResponse CreateDomainVerifyRecordSync(CreateDomainVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateDomainVerifyRecordResponse>(req, "CreateDomainVerifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 创建音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public Task<CreateEnhanceMediaTemplateResponse> CreateEnhanceMediaTemplate(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 创建音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="CreateEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateEnhanceMediaTemplateResponse"/></returns>
        public CreateEnhanceMediaTemplateResponse CreateEnhanceMediaTemplateSync(CreateEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateEnhanceMediaTemplateResponse>(req, "CreateEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建片头片尾模板。
        /// - 最大支持模板数量为 100 个。
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public Task<CreateHeadTailTemplateResponse> CreateHeadTailTemplate(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate");
        }

        /// <summary>
        /// 创建片头片尾模板。
        /// - 最大支持模板数量为 100 个。
        /// </summary>
        /// <param name="req"><see cref="CreateHeadTailTemplateRequest"/></param>
        /// <returns><see cref="CreateHeadTailTemplateResponse"/></returns>
        public CreateHeadTailTemplateResponse CreateHeadTailTemplateSync(CreateHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<CreateHeadTailTemplateResponse>(req, "CreateHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个用户自定义的图片处理模板，数量上限：16。最多支持十次操作，例如：裁剪-缩略-裁剪-模糊-缩略-裁剪-缩略-裁剪-模糊-缩略。
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public Task<CreateImageProcessingTemplateResponse> CreateImageProcessingTemplate(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate");
        }

        /// <summary>
        /// 创建一个用户自定义的图片处理模板，数量上限：16。最多支持十次操作，例如：裁剪-缩略-裁剪-模糊-缩略-裁剪-缩略-裁剪-模糊-缩略。
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public CreateImageProcessingTemplateResponse CreateImageProcessingTemplateSync(CreateImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<CreateImageProcessingTemplateResponse>(req, "CreateImageProcessingTemplate")
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
        /// 创建即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<CreateJustInTimeTranscodeTemplateResponse> CreateJustInTimeTranscodeTemplate(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// 创建即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public CreateJustInTimeTranscodeTemplateResponse CreateJustInTimeTranscodeTemplateSync(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建自定义模板，模板用于 ProcessMediaByMPS 接口的部分功能。
        /// 创建模板时，需要将 MPS 相关参数以 JSON 格式填入 MPSCreateTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// 当前支持创建自定义模板的 MPS 功能：
        /// 1. [音视频增强](https://cloud.tencent.com/document/product/862/118703)。
        /// 
        /// > 以该种方式创建的任务模板：
        /// > 1. 模板的管理仍在点播平台中完成。
        /// > 2. 该功能目前仍在内测中，如需测试体验，您可以联系我们获得支持。
        /// </summary>
        /// <param name="req"><see cref="CreateMPSTemplateRequest"/></param>
        /// <returns><see cref="CreateMPSTemplateResponse"/></returns>
        public Task<CreateMPSTemplateResponse> CreateMPSTemplate(CreateMPSTemplateRequest req)
        {
            return InternalRequestAsync<CreateMPSTemplateResponse>(req, "CreateMPSTemplate");
        }

        /// <summary>
        /// 该接口用于创建自定义模板，模板用于 ProcessMediaByMPS 接口的部分功能。
        /// 创建模板时，需要将 MPS 相关参数以 JSON 格式填入 MPSCreateTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// 当前支持创建自定义模板的 MPS 功能：
        /// 1. [音视频增强](https://cloud.tencent.com/document/product/862/118703)。
        /// 
        /// > 以该种方式创建的任务模板：
        /// > 1. 模板的管理仍在点播平台中完成。
        /// > 2. 该功能目前仍在内测中，如需测试体验，您可以联系我们获得支持。
        /// </summary>
        /// <param name="req"><see cref="CreateMPSTemplateRequest"/></param>
        /// <returns><see cref="CreateMPSTemplateResponse"/></returns>
        public CreateMPSTemplateResponse CreateMPSTemplateSync(CreateMPSTemplateRequest req)
        {
            return InternalRequestAsync<CreateMPSTemplateResponse>(req, "CreateMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、不适宜视频识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample");
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、不适宜视频识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
            return InternalRequestAsync<CreatePersonSampleResponse>(req, "CreatePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义的任务流模板，模板上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public Task<CreateProcedureTemplateResponse> CreateProcedureTemplate(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate");
        }

        /// <summary>
        /// 创建用户自定义的任务流模板，模板上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public CreateProcedureTemplateResponse CreateProcedureTemplateSync(CreateProcedureTemplateRequest req)
        {
            return InternalRequestAsync<CreateProcedureTemplateResponse>(req, "CreateProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public Task<CreateQualityInspectTemplateResponse> CreateQualityInspectTemplate(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate");
        }

        /// <summary>
        /// 创建音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="CreateQualityInspectTemplateResponse"/></returns>
        public CreateQualityInspectTemplateResponse CreateQualityInspectTemplateSync(CreateQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<CreateQualityInspectTemplateResponse>(req, "CreateQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 创建视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public Task<CreateRebuildMediaTemplateResponse> CreateRebuildMediaTemplate(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 创建视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="CreateRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="CreateRebuildMediaTemplateResponse"/></returns>
        public CreateRebuildMediaTemplateResponse CreateRebuildMediaTemplateSync(CreateRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<CreateRebuildMediaTemplateResponse>(req, "CreateRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义审核模板，数量上限：50。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public Task<CreateReviewTemplateResponse> CreateReviewTemplate(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate");
        }

        /// <summary>
        /// 创建用户自定义审核模板，数量上限：50。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="CreateReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateReviewTemplateResponse"/></returns>
        public CreateReviewTemplateResponse CreateReviewTemplateSync(CreateReviewTemplateRequest req)
        {
            return InternalRequestAsync<CreateReviewTemplateResponse>(req, "CreateReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建轮播播单，数量上限：100。
        /// 轮播播单的每个文件可以指定源文件，也可以指定某个转码文件。
        /// 指定的文件必须是hls格式，所有的播单文件最好保持相同的码率和分辨率。
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public Task<CreateRoundPlayResponse> CreateRoundPlay(CreateRoundPlayRequest req)
        {
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay");
        }

        /// <summary>
        /// 该接口用于创建轮播播单，数量上限：100。
        /// 轮播播单的每个文件可以指定源文件，也可以指定某个转码文件。
        /// 指定的文件必须是hls格式，所有的播单文件最好保持相同的码率和分辨率。
        /// </summary>
        /// <param name="req"><see cref="CreateRoundPlayRequest"/></param>
        /// <returns><see cref="CreateRoundPlayResponse"/></returns>
        public CreateRoundPlayResponse CreateRoundPlaySync(CreateRoundPlayRequest req)
        {
            return InternalRequestAsync<CreateRoundPlayResponse>(req, "CreateRoundPlay")
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
        /// 该接口用于开通某地域的存储。
        ///   1. 用户开通点播业务时，系统默认为用户开通了部分地域的存储，用户如果需要开通其它地域的存储，可以通过该接口进行开通。
        ///   2. 通过 DescribeStorageRegions 接口可以查询到所有存储地域及已经开通的地域。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public Task<CreateStorageRegionResponse> CreateStorageRegion(CreateStorageRegionRequest req)
        {
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion");
        }

        /// <summary>
        /// 该接口用于开通某地域的存储。
        ///   1. 用户开通点播业务时，系统默认为用户开通了部分地域的存储，用户如果需要开通其它地域的存储，可以通过该接口进行开通。
        ///   2. 通过 DescribeStorageRegions 接口可以查询到所有存储地域及已经开通的地域。
        /// </summary>
        /// <param name="req"><see cref="CreateStorageRegionRequest"/></param>
        /// <returns><see cref="CreateStorageRegionResponse"/></returns>
        public CreateStorageRegionResponse CreateStorageRegionSync(CreateStorageRegionRequest req)
        {
            return InternalRequestAsync<CreateStorageRegionResponse>(req, "CreateStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建点播应用。
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public Task<CreateSubAppIdResponse> CreateSubAppId(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId");
        }

        /// <summary>
        /// 该接口用于创建点播应用。
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public CreateSubAppIdResponse CreateSubAppIdSync(CreateSubAppIdRequest req)
        {
            return InternalRequestAsync<CreateSubAppIdResponse>(req, "CreateSubAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 创建播放器配置，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public Task<CreateSuperPlayerConfigResponse> CreateSuperPlayerConfig(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 创建播放器配置，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public CreateSuperPlayerConfigResponse CreateSuperPlayerConfigSync(CreateSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<CreateSuperPlayerConfigResponse>(req, "CreateSuperPlayerConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate");
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTranscodeTemplateResponse>(req, "CreateTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于将加速域名添加到点播，一个用户最多添加20个加速域名。
        /// 1.域名添加成功后点播会进行域名的部署，域名由部署状态变为在线状态大概需要2分钟的时间。
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public Task<CreateVodDomainResponse> CreateVodDomain(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain");
        }

        /// <summary>
        /// 该接口用于将加速域名添加到点播，一个用户最多添加20个加速域名。
        /// 1.域名添加成功后点播会进行域名的部署，域名由部署状态变为在线状态大概需要2分钟的时间。
        /// </summary>
        /// <param name="req"><see cref="CreateVodDomainRequest"/></param>
        /// <returns><see cref="CreateVodDomainResponse"/></returns>
        public CreateVodDomainResponse CreateVodDomainSync(CreateVodDomainRequest req)
        {
            return InternalRequestAsync<CreateVodDomainResponse>(req, "CreateVodDomain")
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
        /// 删除用户自定义音视频内容分析模板。
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
        /// 删除用户自定义音视频内容分析模板。
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
        /// 删除用户自定义音视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAIRecognitionTemplateResponse>(req, "DeleteAIRecognitionTemplate");
        }

        /// <summary>
        /// 删除用户自定义音视频内容识别模板。
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
        /// 删除点播开通的日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSTopicRequest"/></param>
        /// <returns><see cref="DeleteCLSTopicResponse"/></returns>
        public Task<DeleteCLSTopicResponse> DeleteCLSTopic(DeleteCLSTopicRequest req)
        {
            return InternalRequestAsync<DeleteCLSTopicResponse>(req, "DeleteCLSTopic");
        }

        /// <summary>
        /// 删除点播开通的日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteCLSTopicRequest"/></param>
        /// <returns><see cref="DeleteCLSTopicResponse"/></returns>
        public DeleteCLSTopicResponse DeleteCLSTopicSync(DeleteCLSTopicRequest req)
        {
            return InternalRequestAsync<DeleteCLSTopicResponse>(req, "DeleteCLSTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](/document/product/266/31764)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass");
        }

        /// <summary>
        /// * 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](/document/product/266/31764)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [删除审核模板](https://cloud.tencent.com/document/api/266/84390)。
        /// 删除用户自定义音视频内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [删除审核模板](https://cloud.tencent.com/document/api/266/84390)。
        /// 删除用户自定义音视频内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteContentReviewTemplateResponse>(req, "DeleteContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 删除音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public Task<DeleteEnhanceMediaTemplateResponse> DeleteEnhanceMediaTemplate(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 删除音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteEnhanceMediaTemplateResponse"/></returns>
        public DeleteEnhanceMediaTemplateResponse DeleteEnhanceMediaTemplateSync(DeleteEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEnhanceMediaTemplateResponse>(req, "DeleteEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除片头片尾模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public Task<DeleteHeadTailTemplateResponse> DeleteHeadTailTemplate(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate");
        }

        /// <summary>
        /// 删除片头片尾模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteHeadTailTemplateRequest"/></param>
        /// <returns><see cref="DeleteHeadTailTemplateResponse"/></returns>
        public DeleteHeadTailTemplateResponse DeleteHeadTailTemplateSync(DeleteHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteHeadTailTemplateResponse>(req, "DeleteHeadTailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义图片处理模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public Task<DeleteImageProcessingTemplateResponse> DeleteImageProcessingTemplate(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate");
        }

        /// <summary>
        /// 删除用户自定义图片处理模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public DeleteImageProcessingTemplateResponse DeleteImageProcessingTemplateSync(DeleteImageProcessingTemplateRequest req)
        {
            return InternalRequestAsync<DeleteImageProcessingTemplateResponse>(req, "DeleteImageProcessingTemplate")
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
        /// 删除即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<DeleteJustInTimeTranscodeTemplateResponse> DeleteJustInTimeTranscodeTemplate(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// 删除即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplateResponse"/></returns>
        public DeleteJustInTimeTranscodeTemplateResponse DeleteJustInTimeTranscodeTemplateSync(DeleteJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplateResponse>(req, "DeleteJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义 MPS 任务模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteMPSTemplateRequest"/></param>
        /// <returns><see cref="DeleteMPSTemplateResponse"/></returns>
        public Task<DeleteMPSTemplateResponse> DeleteMPSTemplate(DeleteMPSTemplateRequest req)
        {
            return InternalRequestAsync<DeleteMPSTemplateResponse>(req, "DeleteMPSTemplate");
        }

        /// <summary>
        /// 删除用户自定义 MPS 任务模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteMPSTemplateRequest"/></param>
        /// <returns><see cref="DeleteMPSTemplateResponse"/></returns>
        public DeleteMPSTemplateResponse DeleteMPSTemplateSync(DeleteMPSTemplateRequest req)
        {
            return InternalRequestAsync<DeleteMPSTemplateResponse>(req, "DeleteMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 删除媒体及其对应的视频处理文件（原始文件、如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的原文件、转码视频、微信发布视频等；
        /// * 注意：原文件删除后，无法发起转码、微信发布等任何视频处理操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public Task<DeleteMediaResponse> DeleteMedia(DeleteMediaRequest req)
        {
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia");
        }

        /// <summary>
        /// * 删除媒体及其对应的视频处理文件（原始文件、如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的原文件、转码视频、微信发布视频等；
        /// * 注意：原文件删除后，无法发起转码、微信发布等任何视频处理操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaRequest"/></param>
        /// <returns><see cref="DeleteMediaResponse"/></returns>
        public DeleteMediaResponse DeleteMediaSync(DeleteMediaRequest req)
        {
            return InternalRequestAsync<DeleteMediaResponse>(req, "DeleteMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于根据人物 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample");
        }

        /// <summary>
        /// 该接口用于根据人物 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
            return InternalRequestAsync<DeletePersonSampleResponse>(req, "DeletePersonSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义的任务流模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public Task<DeleteProcedureTemplateResponse> DeleteProcedureTemplate(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate");
        }

        /// <summary>
        /// 删除用户自定义的任务流模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public DeleteProcedureTemplateResponse DeleteProcedureTemplateSync(DeleteProcedureTemplateRequest req)
        {
            return InternalRequestAsync<DeleteProcedureTemplateResponse>(req, "DeleteProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public Task<DeleteQualityInspectTemplateResponse> DeleteQualityInspectTemplate(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate");
        }

        /// <summary>
        /// 删除音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="DeleteQualityInspectTemplateResponse"/></returns>
        public DeleteQualityInspectTemplateResponse DeleteQualityInspectTemplateSync(DeleteQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<DeleteQualityInspectTemplateResponse>(req, "DeleteQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 删除视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public Task<DeleteRebuildMediaTemplateResponse> DeleteRebuildMediaTemplate(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 删除视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="DeleteRebuildMediaTemplateResponse"/></returns>
        public DeleteRebuildMediaTemplateResponse DeleteRebuildMediaTemplateSync(DeleteRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRebuildMediaTemplateResponse>(req, "DeleteRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户自定义审核模板。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public Task<DeleteReviewTemplateResponse> DeleteReviewTemplate(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate");
        }

        /// <summary>
        /// 删除用户自定义审核模板。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteReviewTemplateResponse"/></returns>
        public DeleteReviewTemplateResponse DeleteReviewTemplateSync(DeleteReviewTemplateRequest req)
        {
            return InternalRequestAsync<DeleteReviewTemplateResponse>(req, "DeleteReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于删除轮播播单。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public Task<DeleteRoundPlayResponse> DeleteRoundPlay(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay");
        }

        /// <summary>
        /// 该接口用于删除轮播播单。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoundPlayRequest"/></param>
        /// <returns><see cref="DeleteRoundPlayResponse"/></returns>
        public DeleteRoundPlayResponse DeleteRoundPlaySync(DeleteRoundPlayRequest req)
        {
            return InternalRequestAsync<DeleteRoundPlayResponse>(req, "DeleteRoundPlay")
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
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 删除播放器配置。  
        /// *注：系统预置播放器配置不允许删除。*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public Task<DeleteSuperPlayerConfigResponse> DeleteSuperPlayerConfig(DeleteSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<DeleteSuperPlayerConfigResponse>(req, "DeleteSuperPlayerConfig");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 删除播放器配置。  
        /// *注：系统预置播放器配置不允许删除。*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public DeleteSuperPlayerConfigResponse DeleteSuperPlayerConfigSync(DeleteSuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<DeleteSuperPlayerConfigResponse>(req, "DeleteSuperPlayerConfig")
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
        /// 该接口用于删除点播加速域名。
        /// 1、域名删除前需要先关闭所有区域的加速。
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public Task<DeleteVodDomainResponse> DeleteVodDomain(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain");
        }

        /// <summary>
        /// 该接口用于删除点播加速域名。
        /// 1、域名删除前需要先关闭所有区域的加速。
        /// </summary>
        /// <param name="req"><see cref="DeleteVodDomainRequest"/></param>
        /// <returns><see cref="DeleteVodDomainResponse"/></returns>
        public DeleteVodDomainResponse DeleteVodDomainSync(DeleteVodDomainRequest req)
        {
            return InternalRequestAsync<DeleteVodDomainResponse>(req, "DeleteVodDomain")
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
        /// 根据音视频内容分析模板唯一标识，获取音视频内容分析模板详情列表。返回结果包含符合条件的所有用户自定义音视频内容分析模板及[系统预置音视频内容分析模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates");
        }

        /// <summary>
        /// 根据音视频内容分析模板唯一标识，获取音视频内容分析模板详情列表。返回结果包含符合条件的所有用户自定义音视频内容分析模板及[系统预置音视频内容分析模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisTemplatesResponse>(req, "DescribeAIAnalysisTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据音视频内容识别模板唯一标识，获取音视频内容识别模板详情列表。返回结果包含符合条件的所有用户自定义音视频内容识别模板及[系统预置音视频内容识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAIRecognitionTemplatesResponse>(req, "DescribeAIRecognitionTemplates");
        }

        /// <summary>
        /// 根据音视频内容识别模板唯一标识，获取音视频内容识别模板详情列表。返回结果包含符合条件的所有用户自定义音视频内容识别模板及[系统预置音视频内容识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF)。
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
        /// 该接口返回查询时间范围内AIGC的统计信息。
        ///    1. 可以查询最近365天内的AIGC统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcUsageDataRequest"/></param>
        /// <returns><see cref="DescribeAigcUsageDataResponse"/></returns>
        public Task<DescribeAigcUsageDataResponse> DescribeAigcUsageData(DescribeAigcUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeAigcUsageDataResponse>(req, "DescribeAigcUsageData");
        }

        /// <summary>
        /// 该接口返回查询时间范围内AIGC的统计信息。
        ///    1. 可以查询最近365天内的AIGC统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAigcUsageDataRequest"/></param>
        /// <returns><see cref="DescribeAigcUsageDataResponse"/></returns>
        public DescribeAigcUsageDataResponse DescribeAigcUsageDataSync(DescribeAigcUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeAigcUsageDataResponse>(req, "DescribeAigcUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass");
        }

        /// <summary>
        /// * 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public DescribeAllClassResponse DescribeAllClassSync(DescribeAllClassRequest req)
        {
            return InternalRequestAsync<DescribeAllClassResponse>(req, "DescribeAllClass")
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
        /// 该接口用于查询点播域名的 CDN 带宽、流量等统计数据。
        /// * 查询的起始时间和结束时间跨度不超过90天。
        /// * 可以查询不同服务区域的数据。
        /// * 中国境内的数据支持查询指定地区、运营商的统计数据。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public Task<DescribeCDNStatDetailsResponse> DescribeCDNStatDetails(DescribeCDNStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails");
        }

        /// <summary>
        /// 该接口用于查询点播域名的 CDN 带宽、流量等统计数据。
        /// * 查询的起始时间和结束时间跨度不超过90天。
        /// * 可以查询不同服务区域的数据。
        /// * 中国境内的数据支持查询指定地区、运营商的统计数据。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public DescribeCDNStatDetailsResponse DescribeCDNStatDetailsSync(DescribeCDNStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCDNStatDetailsResponse>(req, "DescribeCDNStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询点播 CDN 的流量、带宽等统计数据。
        ///    1. 可以查询最近365天内的 CDN 用量数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 可以指定用量数据的时间粒度，支持5分钟、1小时、1天的时间粒度。
        ///    4. 流量为查询时间粒度内的总流量，带宽为查询时间粒度内的峰值带宽。
        ///    5. 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public Task<DescribeCDNUsageDataResponse> DescribeCDNUsageData(DescribeCDNUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData");
        }

        /// <summary>
        /// 该接口用于查询点播 CDN 的流量、带宽等统计数据。
        ///    1. 可以查询最近365天内的 CDN 用量数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 可以指定用量数据的时间粒度，支持5分钟、1小时、1天的时间粒度。
        ///    4. 流量为查询时间粒度内的总流量，带宽为查询时间粒度内的峰值带宽。
        ///    5. 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public DescribeCDNUsageDataResponse DescribeCDNUsageDataSync(DescribeCDNUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeCDNUsageDataResponse>(req, "DescribeCDNUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 VOD 创建的 CLS 日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogsetsRequest"/></param>
        /// <returns><see cref="DescribeCLSLogsetsResponse"/></returns>
        public Task<DescribeCLSLogsetsResponse> DescribeCLSLogsets(DescribeCLSLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSLogsetsResponse>(req, "DescribeCLSLogsets");
        }

        /// <summary>
        /// 查询 VOD 创建的 CLS 日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogsetsRequest"/></param>
        /// <returns><see cref="DescribeCLSLogsetsResponse"/></returns>
        public DescribeCLSLogsetsResponse DescribeCLSLogsetsSync(DescribeCLSLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSLogsetsResponse>(req, "DescribeCLSLogsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询点播域名下日志投递的目标主题。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSPushTargetsRequest"/></param>
        /// <returns><see cref="DescribeCLSPushTargetsResponse"/></returns>
        public Task<DescribeCLSPushTargetsResponse> DescribeCLSPushTargets(DescribeCLSPushTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSPushTargetsResponse>(req, "DescribeCLSPushTargets");
        }

        /// <summary>
        /// 查询点播域名下日志投递的目标主题。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSPushTargetsRequest"/></param>
        /// <returns><see cref="DescribeCLSPushTargetsResponse"/></returns>
        public DescribeCLSPushTargetsResponse DescribeCLSPushTargetsSync(DescribeCLSPushTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCLSPushTargetsResponse>(req, "DescribeCLSPushTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 VOD 创建的 CLS 日志主题列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSTopicsRequest"/></param>
        /// <returns><see cref="DescribeCLSTopicsResponse"/></returns>
        public Task<DescribeCLSTopicsResponse> DescribeCLSTopics(DescribeCLSTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCLSTopicsResponse>(req, "DescribeCLSTopics");
        }

        /// <summary>
        /// 查询 VOD 创建的 CLS 日志主题列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSTopicsRequest"/></param>
        /// <returns><see cref="DescribeCLSTopicsResponse"/></returns>
        public DescribeCLSTopicsResponse DescribeCLSTopicsSync(DescribeCLSTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCLSTopicsResponse>(req, "DescribeCLSTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询点播域名的 CDN （不含 EdgeOne 回源到 VOD 域名）访问日志的下载链接。
        ///     1. 可以查询最近30天内的 CDN 日志下载链接。
        ///     2. 默认情况下 CDN 每小时生成一个日志文件，如果某一个小时没有 CDN 访问，不会生成日志文件。    
        ///     3. CDN 日志下载链接的有效期为24小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public Task<DescribeCdnLogsResponse> DescribeCdnLogs(DescribeCdnLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs");
        }

        /// <summary>
        /// 查询点播域名的 CDN （不含 EdgeOne 回源到 VOD 域名）访问日志的下载链接。
        ///     1. 可以查询最近30天内的 CDN 日志下载链接。
        ///     2. 默认情况下 CDN 每小时生成一个日志文件，如果某一个小时没有 CDN 访问，不会生成日志文件。    
        ///     3. CDN 日志下载链接的有效期为24小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public DescribeCdnLogsResponse DescribeCdnLogsSync(DescribeCdnLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnLogsResponse>(req, "DescribeCdnLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口返回查询时间范围内客户端上传加速统计信息。
        ///    1. 可以查询最近365天内的客户端上传加速统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public Task<DescribeClientUploadAccelerationUsageDataResponse> DescribeClientUploadAccelerationUsageData(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData");
        }

        /// <summary>
        /// 该接口返回查询时间范围内客户端上传加速统计信息。
        ///    1. 可以查询最近365天内的客户端上传加速统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientUploadAccelerationUsageDataRequest"/></param>
        /// <returns><see cref="DescribeClientUploadAccelerationUsageDataResponse"/></returns>
        public DescribeClientUploadAccelerationUsageDataResponse DescribeClientUploadAccelerationUsageDataSync(DescribeClientUploadAccelerationUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeClientUploadAccelerationUsageDataResponse>(req, "DescribeClientUploadAccelerationUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [获取审核模板列表](https://cloud.tencent.com/document/api/266/84389)。
        /// 根据音视频内容审核模板唯一标识，获取音视频内容审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容审核模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [获取审核模板列表](https://cloud.tencent.com/document/api/266/84389)。
        /// 根据音视频内容审核模板唯一标识，获取音视频内容审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容审核模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeContentReviewTemplatesResponse>(req, "DescribeContentReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询轮播当前播放列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentPlaylistRequest"/></param>
        /// <returns><see cref="DescribeCurrentPlaylistResponse"/></returns>
        public Task<DescribeCurrentPlaylistResponse> DescribeCurrentPlaylist(DescribeCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<DescribeCurrentPlaylistResponse>(req, "DescribeCurrentPlaylist");
        }

        /// <summary>
        /// 查询轮播当前播放列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentPlaylistRequest"/></param>
        /// <returns><see cref="DescribeCurrentPlaylistResponse"/></returns>
        public DescribeCurrentPlaylistResponse DescribeCurrentPlaylistSync(DescribeCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<DescribeCurrentPlaylistResponse>(req, "DescribeCurrentPlaylist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询指定日期范围内每天的播放统计数据。
        /// * 可以查询最近一年的播放统计数据。
        /// * 结束日期和起始日期的时间跨度最大为90天。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public Task<DescribeDailyMediaPlayStatResponse> DescribeDailyMediaPlayStat(DescribeDailyMediaPlayStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMediaPlayStatResponse>(req, "DescribeDailyMediaPlayStat");
        }

        /// <summary>
        /// 该接口用于查询指定日期范围内每天的播放统计数据。
        /// * 可以查询最近一年的播放统计数据。
        /// * 结束日期和起始日期的时间跨度最大为90天。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public DescribeDailyMediaPlayStatResponse DescribeDailyMediaPlayStatSync(DescribeDailyMediaPlayStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMediaPlayStatResponse>(req, "DescribeDailyMediaPlayStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询每日播放Top100 的媒体文件的播放统计数据。
        /// * 可以查询最近一年的播放统计数据。
        /// * 可以按播放次数或者播放流量查询。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问 M3U8 文件时统计播放次数；访问 TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public Task<DescribeDailyMostPlayedStatResponse> DescribeDailyMostPlayedStat(DescribeDailyMostPlayedStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMostPlayedStatResponse>(req, "DescribeDailyMostPlayedStat");
        }

        /// <summary>
        /// 该接口用于查询每日播放Top100 的媒体文件的播放统计数据。
        /// * 可以查询最近一年的播放统计数据。
        /// * 可以按播放次数或者播放流量查询。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问 M3U8 文件时统计播放次数；访问 TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public DescribeDailyMostPlayedStatResponse DescribeDailyMostPlayedStatSync(DescribeDailyMostPlayedStatRequest req)
        {
            return InternalRequestAsync<DescribeDailyMostPlayedStatResponse>(req, "DescribeDailyMostPlayedStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询播放统计文件的下载地址。
        /// * 可以查询最近一年的播放统计文件下载地址，查询的起始日期和结束日期的时间跨度不超过90天。
        /// * 云点播每天对前一天的 CDN 请求日志进行分析处理，生成播放统计文件。
        /// * 播放统计文件内容包含媒体文件的播放次数、播放流量等统计信息。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问M3U8 文件时统计播放次数；访问TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放设备的统计：播放请求带了 UserAgent 参数，并且 UserAgent 包含 Android 或者 iPhone 等标识，会统计为移动端播放次数，否则统计为 PC 端播放次数。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public Task<DescribeDailyPlayStatFileListResponse> DescribeDailyPlayStatFileList(DescribeDailyPlayStatFileListRequest req)
        {
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList");
        }

        /// <summary>
        /// 该接口用于查询播放统计文件的下载地址。
        /// * 可以查询最近一年的播放统计文件下载地址，查询的起始日期和结束日期的时间跨度不超过90天。
        /// * 云点播每天对前一天的 CDN 请求日志进行分析处理，生成播放统计文件。
        /// * 播放统计文件内容包含媒体文件的播放次数、播放流量等统计信息。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问M3U8 文件时统计播放次数；访问TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放设备的统计：播放请求带了 UserAgent 参数，并且 UserAgent 包含 Android 或者 iPhone 等标识，会统计为移动端播放次数，否则统计为 PC 端播放次数。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public DescribeDailyPlayStatFileListResponse DescribeDailyPlayStatFileListSync(DescribeDailyPlayStatFileListRequest req)
        {
            return InternalRequestAsync<DescribeDailyPlayStatFileListResponse>(req, "DescribeDailyPlayStatFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询默认分发配置。
        /// * 分发域名和分发协议，即媒体文件分发 URL 中的域名和协议。媒体文件按默认分发配置进行分发。
        /// * 播放密钥，用于计算播放器签名。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="DescribeDefaultDistributionConfigResponse"/></returns>
        public Task<DescribeDefaultDistributionConfigResponse> DescribeDefaultDistributionConfig(DescribeDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<DescribeDefaultDistributionConfigResponse>(req, "DescribeDefaultDistributionConfig");
        }

        /// <summary>
        /// 该接口用于查询默认分发配置。
        /// * 分发域名和分发协议，即媒体文件分发 URL 中的域名和协议。媒体文件按默认分发配置进行分发。
        /// * 播放密钥，用于计算播放器签名。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="DescribeDefaultDistributionConfigResponse"/></returns>
        public DescribeDefaultDistributionConfigResponse DescribeDefaultDistributionConfigSync(DescribeDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<DescribeDefaultDistributionConfigResponse>(req, "DescribeDefaultDistributionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本 API 是 [旧版本加密](https://cloud.tencent.com/document/product/266/9638) 中 [DescribeDrmDataKey 的 API 2017 接口](https://cloud.tencent.com/document/product/266/9643) 的升级版本。
        /// 
        /// 如果您是新接入点播加密的用户，不要使用该 API，请参考 [视频加密综述](https://cloud.tencent.com/document/product/266/45552) 使用推荐的加密方式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmDataKeyRequest"/></param>
        /// <returns><see cref="DescribeDrmDataKeyResponse"/></returns>
        public Task<DescribeDrmDataKeyResponse> DescribeDrmDataKey(DescribeDrmDataKeyRequest req)
        {
            return InternalRequestAsync<DescribeDrmDataKeyResponse>(req, "DescribeDrmDataKey");
        }

        /// <summary>
        /// 本 API 是 [旧版本加密](https://cloud.tencent.com/document/product/266/9638) 中 [DescribeDrmDataKey 的 API 2017 接口](https://cloud.tencent.com/document/product/266/9643) 的升级版本。
        /// 
        /// 如果您是新接入点播加密的用户，不要使用该 API，请参考 [视频加密综述](https://cloud.tencent.com/document/product/266/45552) 使用推荐的加密方式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmDataKeyRequest"/></param>
        /// <returns><see cref="DescribeDrmDataKeyResponse"/></returns>
        public DescribeDrmDataKeyResponse DescribeDrmDataKeySync(DescribeDrmDataKeyRequest req)
        {
            return InternalRequestAsync<DescribeDrmDataKeyResponse>(req, "DescribeDrmDataKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 DRM 密钥提供商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public Task<DescribeDrmKeyProviderInfoResponse> DescribeDrmKeyProviderInfo(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo");
        }

        /// <summary>
        /// 查询 DRM 密钥提供商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="DescribeDrmKeyProviderInfoResponse"/></returns>
        public DescribeDrmKeyProviderInfoResponse DescribeDrmKeyProviderInfoSync(DescribeDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<DescribeDrmKeyProviderInfoResponse>(req, "DescribeDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 获取音画质重生模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public Task<DescribeEnhanceMediaTemplatesResponse> DescribeEnhanceMediaTemplates(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 获取音画质重生模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnhanceMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEnhanceMediaTemplatesResponse"/></returns>
        public DescribeEnhanceMediaTemplatesResponse DescribeEnhanceMediaTemplatesSync(DescribeEnhanceMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeEnhanceMediaTemplatesResponse>(req, "DescribeEnhanceMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云点播为客户提供了媒体上传、媒体管理、媒体处理等等服务，在这些服务执行过程或执行结束时，腾讯云点播也提供各种对应的事件通知，方便开发者感知服务处理状态，并做下一步的业务操作。
        /// 
        /// 开发者可以通过本接口来查询当前配置事件通知的接收方式、接收地址以及哪些事件开启了接收回调通知。
        /// 
        /// 默认接口请求频率限制：100次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public Task<DescribeEventConfigResponse> DescribeEventConfig(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig");
        }

        /// <summary>
        /// 腾讯云点播为客户提供了媒体上传、媒体管理、媒体处理等等服务，在这些服务执行过程或执行结束时，腾讯云点播也提供各种对应的事件通知，方便开发者感知服务处理状态，并做下一步的业务操作。
        /// 
        /// 开发者可以通过本接口来查询当前配置事件通知的接收方式、接收地址以及哪些事件开启了接收回调通知。
        /// 
        /// 默认接口请求频率限制：100次/秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventConfigRequest"/></param>
        /// <returns><see cref="DescribeEventConfigResponse"/></returns>
        public DescribeEventConfigResponse DescribeEventConfigSync(DescribeEventConfigRequest req)
        {
            return InternalRequestAsync<DescribeEventConfigResponse>(req, "DescribeEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 该接口用于业务服务器获取 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 事件通知的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsStateRequest"/></param>
        /// <returns><see cref="DescribeEventsStateResponse"/></returns>
        public Task<DescribeEventsStateResponse> DescribeEventsState(DescribeEventsStateRequest req)
        {
            return InternalRequestAsync<DescribeEventsStateResponse>(req, "DescribeEventsState");
        }

        /// <summary>
        /// * 该接口用于业务服务器获取 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 事件通知的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsStateRequest"/></param>
        /// <returns><see cref="DescribeEventsStateResponse"/></returns>
        public DescribeEventsStateResponse DescribeEventsStateSync(DescribeEventsStateRequest req)
        {
            return InternalRequestAsync<DescribeEventsStateResponse>(req, "DescribeEventsState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于异步获取文件属性。
        /// - 当前仅支持获取源文件的 Md5、Sha1。
        /// - 对输入文件为 HLS 或 DASH 的情况，仅获取索引文件的属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public Task<DescribeFileAttributesResponse> DescribeFileAttributes(DescribeFileAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes");
        }

        /// <summary>
        /// 用于异步获取文件属性。
        /// - 当前仅支持获取源文件的 Md5、Sha1。
        /// - 对输入文件为 HLS 或 DASH 的情况，仅获取索引文件的属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileAttributesRequest"/></param>
        /// <returns><see cref="DescribeFileAttributesResponse"/></returns>
        public DescribeFileAttributesResponse DescribeFileAttributesSync(DescribeFileAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFileAttributesResponse>(req, "DescribeFileAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取片头片尾模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public Task<DescribeHeadTailTemplatesResponse> DescribeHeadTailTemplates(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates");
        }

        /// <summary>
        /// 获取片头片尾模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHeadTailTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHeadTailTemplatesResponse"/></returns>
        public DescribeHeadTailTemplatesResponse DescribeHeadTailTemplatesSync(DescribeHeadTailTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHeadTailTemplatesResponse>(req, "DescribeHeadTailTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取图片处理模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public Task<DescribeImageProcessingTemplatesResponse> DescribeImageProcessingTemplates(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates");
        }

        /// <summary>
        /// 获取图片处理模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public DescribeImageProcessingTemplatesResponse DescribeImageProcessingTemplatesSync(DescribeImageProcessingTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeImageProcessingTemplatesResponse>(req, "DescribeImageProcessingTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天使用的图片审核用量信息。
        ///    1. 可以查询最近365天内的图片审核统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public Task<DescribeImageReviewUsageDataResponse> DescribeImageReviewUsageData(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData");
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天使用的图片审核用量信息。
        ///    1. 可以查询最近365天内的图片审核统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageReviewUsageDataRequest"/></param>
        /// <returns><see cref="DescribeImageReviewUsageDataResponse"/></returns>
        public DescribeImageReviewUsageDataResponse DescribeImageReviewUsageDataSync(DescribeImageReviewUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeImageReviewUsageDataResponse>(req, "DescribeImageReviewUsageData")
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
        /// 获取即时转码模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeJustInTimeTranscodeTemplatesResponse> DescribeJustInTimeTranscodeTemplates(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// 获取即时转码模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public DescribeJustInTimeTranscodeTemplatesResponse DescribeJustInTimeTranscodeTemplatesSync(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天 License 请求次数信息。
        ///    1. 可以查询最近365天内的 License 请求次数统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public Task<DescribeLicenseUsageDataResponse> DescribeLicenseUsageData(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData");
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天 License 请求次数信息。
        ///    1. 可以查询最近365天内的 License 请求次数统计数据。
        ///    2. 查询时间跨度不超过90天。
        ///    3. 查询时间跨度超过1天的，返回以天为粒度的数据，否则，返回以5分钟为粒度的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseUsageDataRequest"/></param>
        /// <returns><see cref="DescribeLicenseUsageDataResponse"/></returns>
        public DescribeLicenseUsageDataResponse DescribeLicenseUsageDataSync(DescribeLicenseUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeLicenseUsageDataResponse>(req, "DescribeLicenseUsageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户自定义媒体处理服务（MPS）任务模板。
        /// 查询模板列表时，需要将 MPS 相关参数以 JSON 格式填入 MPSDescribeTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// </summary>
        /// <param name="req"><see cref="DescribeMPSTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMPSTemplatesResponse"/></returns>
        public Task<DescribeMPSTemplatesResponse> DescribeMPSTemplates(DescribeMPSTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMPSTemplatesResponse>(req, "DescribeMPSTemplates");
        }

        /// <summary>
        /// 获取用户自定义媒体处理服务（MPS）任务模板。
        /// 查询模板列表时，需要将 MPS 相关参数以 JSON 格式填入 MPSDescribeTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// </summary>
        /// <param name="req"><see cref="DescribeMPSTemplatesRequest"/></param>
        /// <returns><see cref="DescribeMPSTemplatesResponse"/></returns>
        public DescribeMPSTemplatesResponse DescribeMPSTemplatesSync(DescribeMPSTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeMPSTemplatesResponse>(req, "DescribeMPSTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口可以获取多个媒体文件的多种信息，包括：
        ///     1. 基础信息（basicInfo）：包括媒体名称、分类、播放地址、封面图片等。
        ///     2. 元信息（metaData）：包括大小、时长、视频流信息、音频流信息等。
        ///     3. 转码结果信息（transcodeInfo）：包括该媒体转码生成的各种规格的媒体地址、视频流参数、音频流参数等。
        ///     4. 转动图结果信息（animatedGraphicsInfo）：对视频转动图（如 gif）后的动图信息。
        ///     5. 采样截图信息（sampleSnapshotInfo）：对视频采样截图后的截图信息。
        ///     6. 雪碧图信息（imageSpriteInfo）：对视频截取雪碧图后的雪碧图信息。
        ///     7. 指定时间点截图信息（snapshotByTimeOffsetInfo）：对视频依照指定时间点截图后，的截图信息。
        ///     8. 视频打点信息（keyFrameDescInfo）：对视频设置的打点信息。
        ///     9. 转自适应码流信息（adaptiveDynamicStreamingInfo）：包括规格、加密类型、打包格式等相关信息。
        ///     10. 审核信息（reviewInfo）：包括媒体审核及媒体封面审核信息。
        /// 2. 可以指定回包只返回部分信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos");
        }

        /// <summary>
        /// 1. 该接口可以获取多个媒体文件的多种信息，包括：
        ///     1. 基础信息（basicInfo）：包括媒体名称、分类、播放地址、封面图片等。
        ///     2. 元信息（metaData）：包括大小、时长、视频流信息、音频流信息等。
        ///     3. 转码结果信息（transcodeInfo）：包括该媒体转码生成的各种规格的媒体地址、视频流参数、音频流参数等。
        ///     4. 转动图结果信息（animatedGraphicsInfo）：对视频转动图（如 gif）后的动图信息。
        ///     5. 采样截图信息（sampleSnapshotInfo）：对视频采样截图后的截图信息。
        ///     6. 雪碧图信息（imageSpriteInfo）：对视频截取雪碧图后的雪碧图信息。
        ///     7. 指定时间点截图信息（snapshotByTimeOffsetInfo）：对视频依照指定时间点截图后，的截图信息。
        ///     8. 视频打点信息（keyFrameDescInfo）：对视频设置的打点信息。
        ///     9. 转自适应码流信息（adaptiveDynamicStreamingInfo）：包括规格、加密类型、打包格式等相关信息。
        ///     10. 审核信息（reviewInfo）：包括媒体审核及媒体封面审核信息。
        /// 2. 可以指定回包只返回部分信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public DescribeMediaInfosResponse DescribeMediaInfosSync(DescribeMediaInfosRequest req)
        {
            return InternalRequestAsync<DescribeMediaInfosResponse>(req, "DescribeMediaInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询媒体文件按指定时间粒度统计的播放数据
        /// * 可以查询最近一年的播放统计数据。
        /// * 时间粒度为小时，结束时间和起始时间的跨度最大为7天。
        /// * 时间粒度为天，结束时间和起始时间的跨度最大为90天。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public Task<DescribeMediaPlayStatDetailsResponse> DescribeMediaPlayStatDetails(DescribeMediaPlayStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails");
        }

        /// <summary>
        /// 该接口用于查询媒体文件按指定时间粒度统计的播放数据
        /// * 可以查询最近一年的播放统计数据。
        /// * 时间粒度为小时，结束时间和起始时间的跨度最大为7天。
        /// * 时间粒度为天，结束时间和起始时间的跨度最大为90天。
        /// * 播放统计仅针对 VOD 域名（即 EdgeOne 域名的分发不计入播放统计）。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPlayStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeMediaPlayStatDetailsResponse"/></returns>
        public DescribeMediaPlayStatDetailsResponse DescribeMediaPlayStatDetailsSync(DescribeMediaPlayStatDetailsRequest req)
        {
            return InternalRequestAsync<DescribeMediaPlayStatDetailsResponse>(req, "DescribeMediaPlayStatDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天使用的视频处理用量信息。
        ///    1. 可以查询最近365天内的视频处理统计数据。
        ///    2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public Task<DescribeMediaProcessUsageDataResponse> DescribeMediaProcessUsageData(DescribeMediaProcessUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData");
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天使用的视频处理用量信息。
        ///    1. 可以查询最近365天内的视频处理统计数据。
        ///    2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public DescribeMediaProcessUsageDataResponse DescribeMediaProcessUsageDataSync(DescribeMediaProcessUsageDataRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessUsageDataResponse>(req, "DescribeMediaProcessUsageData")
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
        /// 该接口可以查询用户已经购买的预付费商品的信息，包括：
        ///     1. 商品的类型、生效和失效日期。
        ///     2. 商品中每种资源的额度和剩余额度。
        /// </summary>
        /// <param name="req"><see cref="DescribePrepaidProductsRequest"/></param>
        /// <returns><see cref="DescribePrepaidProductsResponse"/></returns>
        public Task<DescribePrepaidProductsResponse> DescribePrepaidProducts(DescribePrepaidProductsRequest req)
        {
            return InternalRequestAsync<DescribePrepaidProductsResponse>(req, "DescribePrepaidProducts");
        }

        /// <summary>
        /// 该接口可以查询用户已经购买的预付费商品的信息，包括：
        ///     1. 商品的类型、生效和失效日期。
        ///     2. 商品中每种资源的额度和剩余额度。
        /// </summary>
        /// <param name="req"><see cref="DescribePrepaidProductsRequest"/></param>
        /// <returns><see cref="DescribePrepaidProductsResponse"/></returns>
        public DescribePrepaidProductsResponse DescribePrepaidProductsSync(DescribePrepaidProductsRequest req)
        {
            return InternalRequestAsync<DescribePrepaidProductsResponse>(req, "DescribePrepaidProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务流模板名字，获取任务流模板详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public Task<DescribeProcedureTemplatesResponse> DescribeProcedureTemplates(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates");
        }

        /// <summary>
        /// 根据任务流模板名字，获取任务流模板详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public DescribeProcedureTemplatesResponse DescribeProcedureTemplatesSync(DescribeProcedureTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeProcedureTemplatesResponse>(req, "DescribeProcedureTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取音画质检测模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public Task<DescribeQualityInspectTemplatesResponse> DescribeQualityInspectTemplates(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates");
        }

        /// <summary>
        /// 获取音画质检测模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityInspectTemplatesRequest"/></param>
        /// <returns><see cref="DescribeQualityInspectTemplatesResponse"/></returns>
        public DescribeQualityInspectTemplatesResponse DescribeQualityInspectTemplatesSync(DescribeQualityInspectTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeQualityInspectTemplatesResponse>(req, "DescribeQualityInspectTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 获取视频重生模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public Task<DescribeRebuildMediaTemplatesResponse> DescribeRebuildMediaTemplates(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 获取视频重生模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRebuildMediaTemplatesRequest"/></param>
        /// <returns><see cref="DescribeRebuildMediaTemplatesResponse"/></returns>
        public DescribeRebuildMediaTemplatesResponse DescribeRebuildMediaTemplatesSync(DescribeRebuildMediaTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeRebuildMediaTemplatesResponse>(req, "DescribeRebuildMediaTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <b>本接口已不推荐使用，用 [DescribeMediaProcessUsageData](/document/product/266/41464) 替代</b>
        /// 
        /// 该接口返回查询时间范围内每天使用的视频内容智能识别时长数据，单位： 秒。
        /// 
        /// 1. 可以查询最近365天内的视频内容智能识别时长统计数据。
        /// 2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public Task<DescribeReviewDetailsResponse> DescribeReviewDetails(DescribeReviewDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails");
        }

        /// <summary>
        /// <b>本接口已不推荐使用，用 [DescribeMediaProcessUsageData](/document/product/266/41464) 替代</b>
        /// 
        /// 该接口返回查询时间范围内每天使用的视频内容智能识别时长数据，单位： 秒。
        /// 
        /// 1. 可以查询最近365天内的视频内容智能识别时长统计数据。
        /// 2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns><see cref="DescribeReviewDetailsResponse"/></returns>
        public DescribeReviewDetailsResponse DescribeReviewDetailsSync(DescribeReviewDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReviewDetailsResponse>(req, "DescribeReviewDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审核模板列表。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public Task<DescribeReviewTemplatesResponse> DescribeReviewTemplates(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates");
        }

        /// <summary>
        /// 获取审核模板列表。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeReviewTemplatesResponse"/></returns>
        public DescribeReviewTemplatesResponse DescribeReviewTemplatesSync(DescribeReviewTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeReviewTemplatesResponse>(req, "DescribeReviewTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于获取轮播播单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public Task<DescribeRoundPlaysResponse> DescribeRoundPlays(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays");
        }

        /// <summary>
        /// 该接口用于获取轮播播单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoundPlaysRequest"/></param>
        /// <returns><see cref="DescribeRoundPlaysResponse"/></returns>
        public DescribeRoundPlaysResponse DescribeRoundPlaysSync(DescribeRoundPlaysRequest req)
        {
            return InternalRequestAsync<DescribeRoundPlaysResponse>(req, "DescribeRoundPlays")
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
        /// 查询存储空间使用情况和文件数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public Task<DescribeStorageDataResponse> DescribeStorageData(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData");
        }

        /// <summary>
        /// 查询存储空间使用情况和文件数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public DescribeStorageDataResponse DescribeStorageDataSync(DescribeStorageDataRequest req)
        {
            return InternalRequestAsync<DescribeStorageDataResponse>(req, "DescribeStorageData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口返回查询时间范围内使用的点播存储空间，单位：字节。
        ///     1. 可以查询最近365天内的存储空间数据；
        ///     2. 查询时间跨度不超过90天；
        ///     3. 分钟粒度查询跨度不超过7天；
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public Task<DescribeStorageDetailsResponse> DescribeStorageDetails(DescribeStorageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails");
        }

        /// <summary>
        /// 该接口返回查询时间范围内使用的点播存储空间，单位：字节。
        ///     1. 可以查询最近365天内的存储空间数据；
        ///     2. 查询时间跨度不超过90天；
        ///     3. 分钟粒度查询跨度不超过7天；
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public DescribeStorageDetailsResponse DescribeStorageDetailsSync(DescribeStorageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStorageDetailsResponse>(req, "DescribeStorageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于：
        ///   1. 查询点播可开通的所有存储园区列表。
        ///   2. 查询已经开通的园区列表。
        ///   3. 查询默认使用的存储园区。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public Task<DescribeStorageRegionsResponse> DescribeStorageRegions(DescribeStorageRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions");
        }

        /// <summary>
        /// 该接口用于：
        ///   1. 查询点播可开通的所有存储园区列表。
        ///   2. 查询已经开通的园区列表。
        ///   3. 查询默认使用的存储园区。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageRegionsRequest"/></param>
        /// <returns><see cref="DescribeStorageRegionsResponse"/></returns>
        public DescribeStorageRegionsResponse DescribeStorageRegionsSync(DescribeStorageRegionsRequest req)
        {
            return InternalRequestAsync<DescribeStorageRegionsResponse>(req, "DescribeStorageRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于获取当前账号的应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public Task<DescribeSubAppIdsResponse> DescribeSubAppIds(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds");
        }

        /// <summary>
        /// 该接口用于获取当前账号的应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public DescribeSubAppIdsResponse DescribeSubAppIdsSync(DescribeSubAppIdsRequest req)
        {
            return InternalRequestAsync<DescribeSubAppIdsResponse>(req, "DescribeSubAppIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 查询播放器配置，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public Task<DescribeSuperPlayerConfigsResponse> DescribeSuperPlayerConfigs(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 查询播放器配置，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public DescribeSuperPlayerConfigsResponse DescribeSuperPlayerConfigsSync(DescribeSuperPlayerConfigsRequest req)
        {
            return InternalRequestAsync<DescribeSuperPlayerConfigsResponse>(req, "DescribeSuperPlayerConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
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
        /// * 只能查询到最近三天（72 小时）内的任务。
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
        /// * 只能查询到最近三天（72 小时）内的任务。
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
        /// 该接口用于查询点播域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public Task<DescribeVodDomainsResponse> DescribeVodDomains(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains");
        }

        /// <summary>
        /// 该接口用于查询点播域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public DescribeVodDomainsResponse DescribeVodDomainsSync(DescribeVodDomainsRequest req)
        {
            return InternalRequestAsync<DescribeVodDomainsResponse>(req, "DescribeVodDomains")
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
        /// 对视频进行编辑（剪辑、拼接等），生成一个新的点播视频。编辑的功能包括：
        /// 
        /// 1. 对点播中的一个文件进行剪辑，生成一个新的视频；
        /// 2. 对点播中的多个文件进行拼接，生成一个新的视频；
        /// 3. 对点播中的多个文件进行剪辑，然后再拼接，生成一个新的视频；
        /// 4. 对点播中的一个流，直接生成一个新的视频；
        /// 5. 对点播中的一个流进行剪辑，生成一个新的视频；
        /// 6. 对点播中的多个流进行拼接，生成一个新的视频；
        /// 7. 对点播中的多个流进行剪辑，然后拼接，生成一个新的视频。
        /// 
        /// 对于生成的新视频，还可以指定生成后的视频是否要执行任务流。
        /// 
        /// >当对直播流做剪辑、拼接等操作时，请确保流结束后再操作。否则生成的视频可能不完整。
        /// 
        /// 如使用事件通知，事件通知的类型为 [视频编辑完成](https://cloud.tencent.com/document/product/266/33794)。
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia");
        }

        /// <summary>
        /// 对视频进行编辑（剪辑、拼接等），生成一个新的点播视频。编辑的功能包括：
        /// 
        /// 1. 对点播中的一个文件进行剪辑，生成一个新的视频；
        /// 2. 对点播中的多个文件进行拼接，生成一个新的视频；
        /// 3. 对点播中的多个文件进行剪辑，然后再拼接，生成一个新的视频；
        /// 4. 对点播中的一个流，直接生成一个新的视频；
        /// 5. 对点播中的一个流进行剪辑，生成一个新的视频；
        /// 6. 对点播中的多个流进行拼接，生成一个新的视频；
        /// 7. 对点播中的多个流进行剪辑，然后拼接，生成一个新的视频。
        /// 
        /// 对于生成的新视频，还可以指定生成后的视频是否要执行任务流。
        /// 
        /// >当对直播流做剪辑、拼接等操作时，请确保流结束后再操作。否则生成的视频可能不完整。
        /// 
        /// 如使用事件通知，事件通知的类型为 [视频编辑完成](https://cloud.tencent.com/document/product/266/33794)。
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
            return InternalRequestAsync<EditMediaResponse>(req, "EditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 使用模板发起音画质重生。
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public Task<EnhanceMediaByTemplateResponse> EnhanceMediaByTemplate(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 使用模板发起音画质重生。
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaByTemplateRequest"/></param>
        /// <returns><see cref="EnhanceMediaByTemplateResponse"/></returns>
        public EnhanceMediaByTemplateResponse EnhanceMediaByTemplateSync(EnhanceMediaByTemplateRequest req)
        {
            return InternalRequestAsync<EnhanceMediaByTemplateResponse>(req, "EnhanceMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播中的音视频媒体发起音画质重生任务。
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public Task<EnhanceMediaQualityResponse> EnhanceMediaQuality(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality");
        }

        /// <summary>
        /// 对点播中的音视频媒体发起音画质重生任务。
        /// </summary>
        /// <param name="req"><see cref="EnhanceMediaQualityRequest"/></param>
        /// <returns><see cref="EnhanceMediaQualityResponse"/></returns>
        public EnhanceMediaQualityResponse EnhanceMediaQualitySync(EnhanceMediaQualityRequest req)
        {
            return InternalRequestAsync<EnhanceMediaQualityResponse>(req, "EnhanceMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云点播客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction");
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云点播客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
            return InternalRequestAsync<ExecuteFunctionResponse>(req, "ExecuteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果有盗录溯源需求，请参考 [幽灵水印](https://cloud.tencent.com/document/product/266/94228)。
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public Task<ExtractCopyRightWatermarkResponse> ExtractCopyRightWatermark(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark");
        }

        /// <summary>
        /// 如果有盗录溯源需求，请参考 [幽灵水印](https://cloud.tencent.com/document/product/266/94228)。
        /// </summary>
        /// <param name="req"><see cref="ExtractCopyRightWatermarkRequest"/></param>
        /// <returns><see cref="ExtractCopyRightWatermarkResponse"/></returns>
        public ExtractCopyRightWatermarkResponse ExtractCopyRightWatermarkSync(ExtractCopyRightWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractCopyRightWatermarkResponse>(req, "ExtractCopyRightWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果有盗录溯源需求，推荐使用 [幽灵水印](https://cloud.tencent.com/document/product/266/94228)。
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public Task<ExtractTraceWatermarkResponse> ExtractTraceWatermark(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark");
        }

        /// <summary>
        /// 如果有盗录溯源需求，推荐使用 [幽灵水印](https://cloud.tencent.com/document/product/266/94228)。
        /// </summary>
        /// <param name="req"><see cref="ExtractTraceWatermarkRequest"/></param>
        /// <returns><see cref="ExtractTraceWatermarkResponse"/></returns>
        public ExtractTraceWatermarkResponse ExtractTraceWatermarkSync(ExtractTraceWatermarkRequest req)
        {
            return InternalRequestAsync<ExtractTraceWatermarkResponse>(req, "ExtractTraceWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对云点播的 HLS 视频实现快速拼接和快速剪辑，生成新的 HLS 格式的媒体。
        /// 
        /// 快速拼接或剪辑生成的视频，将产生新的 FileId 并进行固化，固化成功后新视频的文件独立于原始输入视频存在，不受原始视频删除等影响。
        /// 
        /// <font color='red'>注意：</font>通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对原始输入的视频进行删除、降冷等操作，否则拼接剪辑生成的视频播放可能出现异常。
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public Task<FastEditMediaResponse> FastEditMedia(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia");
        }

        /// <summary>
        /// 对云点播的 HLS 视频实现快速拼接和快速剪辑，生成新的 HLS 格式的媒体。
        /// 
        /// 快速拼接或剪辑生成的视频，将产生新的 FileId 并进行固化，固化成功后新视频的文件独立于原始输入视频存在，不受原始视频删除等影响。
        /// 
        /// <font color='red'>注意：</font>通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对原始输入的视频进行删除、降冷等操作，否则拼接剪辑生成的视频播放可能出现异常。
        /// </summary>
        /// <param name="req"><see cref="FastEditMediaRequest"/></param>
        /// <returns><see cref="FastEditMediaResponse"/></returns>
        public FastEditMediaResponse FastEditMediaSync(FastEditMediaRequest req)
        {
            return InternalRequestAsync<FastEditMediaResponse>(req, "FastEditMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 对媒体禁播后，除了点播控制台预览，其他场景访问视频各种资源的 URL（原始文件、转码输出文件、截图等）均会返回 403。
        ///   禁播/解禁操作全网生效时间约 5~10 分钟。
        /// * 注意：禁播媒体仅能操作标准存储和低频存储的媒体。低频存储媒体，必须存储至少 30 天，提前删除或变更存储类型，仍旧按照 30 天计费；如果禁播低频存储媒体，该媒体低频存储的时长不足 30 天，会产生提前删除计费；同时，禁播后该媒体的低频存储时长会从当前时间重新开始计算，如果不满 30 天继续对该媒体进行删除或变更存储类型，也将产生提前删除计费。例：媒体 001 已经低频存储了 10 天，此时对 001 进行禁播，低频存储的计费仍旧按 30 天计算（提前删除计费时长为 30 - 10 = 20 天）；禁播后 001 的低频存储时长重新开始计算，如果禁播后第 5 天删除了 001，低频存储计费也会按 30 天计算（提前删除计费时长为 30 - 5 = 25 天）；001 实际的低频存储时长为 10 + 5 = 15 天，低频存储计费时长为 10 + 20(提前删除计费)+ 5 + 25(提前删除计费) = 60 天。
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public Task<ForbidMediaDistributionResponse> ForbidMediaDistribution(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution");
        }

        /// <summary>
        /// * 对媒体禁播后，除了点播控制台预览，其他场景访问视频各种资源的 URL（原始文件、转码输出文件、截图等）均会返回 403。
        ///   禁播/解禁操作全网生效时间约 5~10 分钟。
        /// * 注意：禁播媒体仅能操作标准存储和低频存储的媒体。低频存储媒体，必须存储至少 30 天，提前删除或变更存储类型，仍旧按照 30 天计费；如果禁播低频存储媒体，该媒体低频存储的时长不足 30 天，会产生提前删除计费；同时，禁播后该媒体的低频存储时长会从当前时间重新开始计算，如果不满 30 天继续对该媒体进行删除或变更存储类型，也将产生提前删除计费。例：媒体 001 已经低频存储了 10 天，此时对 001 进行禁播，低频存储的计费仍旧按 30 天计算（提前删除计费时长为 30 - 10 = 20 天）；禁播后 001 的低频存储时长重新开始计算，如果禁播后第 5 天删除了 001，低频存储计费也会按 30 天计算（提前删除计费时长为 30 - 5 = 25 天）；001 实际的低频存储时长为 10 + 5 = 15 天，低频存储计费时长为 10 + 20(提前删除计费)+ 5 + 25(提前删除计费) = 60 天。
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public ForbidMediaDistributionResponse ForbidMediaDistributionSync(ForbidMediaDistributionRequest req)
        {
            return InternalRequestAsync<ForbidMediaDistributionResponse>(req, "ForbidMediaDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作轮播当前播放列表。支持的操作有：<li> Insert：向当前播列表插入播放节目。</li><li> Delete：删除播列表中的播放节目。</li>
        /// </summary>
        /// <param name="req"><see cref="HandleCurrentPlaylistRequest"/></param>
        /// <returns><see cref="HandleCurrentPlaylistResponse"/></returns>
        public Task<HandleCurrentPlaylistResponse> HandleCurrentPlaylist(HandleCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<HandleCurrentPlaylistResponse>(req, "HandleCurrentPlaylist");
        }

        /// <summary>
        /// 操作轮播当前播放列表。支持的操作有：<li> Insert：向当前播列表插入播放节目。</li><li> Delete：删除播列表中的播放节目。</li>
        /// </summary>
        /// <param name="req"><see cref="HandleCurrentPlaylistRequest"/></param>
        /// <returns><see cref="HandleCurrentPlaylistResponse"/></returns>
        public HandleCurrentPlaylistResponse HandleCurrentPlaylistSync(HandleCurrentPlaylistRequest req)
        {
            return InternalRequestAsync<HandleCurrentPlaylistResponse>(req, "HandleCurrentPlaylist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于将智能分析的结果导入到知识库中。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaKnowledgeRequest"/></param>
        /// <returns><see cref="ImportMediaKnowledgeResponse"/></returns>
        public Task<ImportMediaKnowledgeResponse> ImportMediaKnowledge(ImportMediaKnowledgeRequest req)
        {
            return InternalRequestAsync<ImportMediaKnowledgeResponse>(req, "ImportMediaKnowledge");
        }

        /// <summary>
        /// 用于将智能分析的结果导入到知识库中。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaKnowledgeRequest"/></param>
        /// <returns><see cref="ImportMediaKnowledgeResponse"/></returns>
        public ImportMediaKnowledgeResponse ImportMediaKnowledgeSync(ImportMediaKnowledgeRequest req)
        {
            return InternalRequestAsync<ImportMediaKnowledgeResponse>(req, "ImportMediaKnowledge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播中的音视频媒体发起音画质检测任务。
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public Task<InspectMediaQualityResponse> InspectMediaQuality(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality");
        }

        /// <summary>
        /// 对点播中的音视频媒体发起音画质检测任务。
        /// </summary>
        /// <param name="req"><see cref="InspectMediaQualityRequest"/></param>
        /// <returns><see cref="InspectMediaQualityResponse"/></returns>
        public InspectMediaQualityResponse InspectMediaQualitySync(InspectMediaQualityRequest req)
        {
            return InternalRequestAsync<InspectMediaQualityResponse>(req, "InspectMediaQuality")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播即时剪辑，是指在直播过程中（即直播尚未结束时），客户可以在过往直播内容中选择一段，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种即时剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段**长久保存**的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于直播录制文件，没有独立 FileId；适用于将精彩片段**临时分享**的场景。
        /// 
        /// 注意：
        /// - 使用直播即时剪辑功能的前提是：目标直播流开启了[时移回看](https://cloud.tencent.com/document/product/267/32742)功能。
        /// - 直播即时剪辑是基于直播录制生成的 m3u8 文件进行的，故而其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// - 由于直播过程中可能存在断流的情况，所以有可能导致剪辑生成的实际视频时长与期望不一致。例如剪辑某个直播流的时间区间为 2018-09-20T10:30:00Z 到 2018-09-20T10:40:00Z ，如果在该时间区间中发生过断流，那么返回的媒资文件的时长将少于 10 分钟，在这种情况下，可以通过输出参数 <a href="#p_segmentset">SegmentSet</a> 感知到。
        /// 
        /// ### 剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频是保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始直播录制视频影响（即使原始录制视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，直播录制出来的原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于直播即时剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择直播即时剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始录制视频相互独立，可以独立管理、长久保存。
        /// 
        /// <font color='red'>注意：</font>如果剪辑时指定进行固化，通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对直播录制视频进行删除、降冷等操作，否则剪辑生成的视频播放可能出现异常。
        /// 
        /// ### 剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与直播录制视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与直播录制的完整视频有效期是一致的。一旦直播录制出来的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public Task<LiveRealTimeClipResponse> LiveRealTimeClip(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip");
        }

        /// <summary>
        /// 直播即时剪辑，是指在直播过程中（即直播尚未结束时），客户可以在过往直播内容中选择一段，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种即时剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段**长久保存**的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于直播录制文件，没有独立 FileId；适用于将精彩片段**临时分享**的场景。
        /// 
        /// 注意：
        /// - 使用直播即时剪辑功能的前提是：目标直播流开启了[时移回看](https://cloud.tencent.com/document/product/267/32742)功能。
        /// - 直播即时剪辑是基于直播录制生成的 m3u8 文件进行的，故而其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// - 由于直播过程中可能存在断流的情况，所以有可能导致剪辑生成的实际视频时长与期望不一致。例如剪辑某个直播流的时间区间为 2018-09-20T10:30:00Z 到 2018-09-20T10:40:00Z ，如果在该时间区间中发生过断流，那么返回的媒资文件的时长将少于 10 分钟，在这种情况下，可以通过输出参数 <a href="#p_segmentset">SegmentSet</a> 感知到。
        /// 
        /// ### 剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频是保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始直播录制视频影响（即使原始录制视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，直播录制出来的原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于直播即时剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择直播即时剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始录制视频相互独立，可以独立管理、长久保存。
        /// 
        /// <font color='red'>注意：</font>如果剪辑时指定进行固化，通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对直播录制视频进行删除、降冷等操作，否则剪辑生成的视频播放可能出现异常。
        /// 
        /// ### 剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与直播录制视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与直播录制的完整视频有效期是一致的。一旦直播录制出来的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public LiveRealTimeClipResponse LiveRealTimeClipSync(LiveRealTimeClipRequest req)
        {
            return InternalRequestAsync<LiveRealTimeClipResponse>(req, "LiveRealTimeClip")
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
        /// 修改用户自定义音视频内容分析模板。
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
        /// 修改用户自定义音视频内容分析模板。
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
        /// 修改用户自定义音视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
            return InternalRequestAsync<ModifyAIRecognitionTemplateResponse>(req, "ModifyAIRecognitionTemplate");
        }

        /// <summary>
        /// 修改用户自定义音视频内容识别模板。
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
        /// 修改媒体分类属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass");
        }

        /// <summary>
        /// 修改媒体分类属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public ModifyClassResponse ModifyClassSync(ModifyClassRequest req)
        {
            return InternalRequestAsync<ModifyClassResponse>(req, "ModifyClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [修改审核模板](https://cloud.tencent.com/document/api/266/84388)。
        /// 修改用户自定义音视频内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版审核模板支持音视频审核和图片审核，详细请参考 [修改审核模板](https://cloud.tencent.com/document/api/266/84388)。
        /// 修改用户自定义音视频内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyContentReviewTemplateResponse>(req, "ModifyContentReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改默认分发配置。
        /// * 分发域名和分发协议，即媒体文件分发 URL 中的域名和协议。媒体文件按默认分发配置进行分发。
        /// * 播放密钥，用于计算播放器签名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="ModifyDefaultDistributionConfigResponse"/></returns>
        public Task<ModifyDefaultDistributionConfigResponse> ModifyDefaultDistributionConfig(ModifyDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<ModifyDefaultDistributionConfigResponse>(req, "ModifyDefaultDistributionConfig");
        }

        /// <summary>
        /// 该接口用于修改默认分发配置。
        /// * 分发域名和分发协议，即媒体文件分发 URL 中的域名和协议。媒体文件按默认分发配置进行分发。
        /// * 播放密钥，用于计算播放器签名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultDistributionConfigRequest"/></param>
        /// <returns><see cref="ModifyDefaultDistributionConfigResponse"/></returns>
        public ModifyDefaultDistributionConfigResponse ModifyDefaultDistributionConfigSync(ModifyDefaultDistributionConfigRequest req)
        {
            return InternalRequestAsync<ModifyDefaultDistributionConfigResponse>(req, "ModifyDefaultDistributionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于设置默认的存储地域。上传文件时如果没有指定地域，将上传到默认地域。
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public Task<ModifyDefaultStorageRegionResponse> ModifyDefaultStorageRegion(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion");
        }

        /// <summary>
        /// 该接口用于设置默认的存储地域。上传文件时如果没有指定地域，将上传到默认地域。
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultStorageRegionRequest"/></param>
        /// <returns><see cref="ModifyDefaultStorageRegionResponse"/></returns>
        public ModifyDefaultStorageRegionResponse ModifyDefaultStorageRegionSync(ModifyDefaultStorageRegionRequest req)
        {
            return InternalRequestAsync<ModifyDefaultStorageRegionResponse>(req, "ModifyDefaultStorageRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 修改音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public Task<ModifyEnhanceMediaTemplateResponse> ModifyEnhanceMediaTemplate(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 修改音画质重生模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnhanceMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyEnhanceMediaTemplateResponse"/></returns>
        public ModifyEnhanceMediaTemplateResponse ModifyEnhanceMediaTemplateSync(ModifyEnhanceMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyEnhanceMediaTemplateResponse>(req, "ModifyEnhanceMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云点播为客户提供了媒体上传、媒体管理、媒体处理等等服务，在这些服务执行过程或执行结束时，腾讯云点播也提供各种对应的事件通知，方便开发者感知服务处理状态，并做下一步的业务操作。
        /// 
        /// 开发者可以通过调用本接口来实现：
        /// - 设置接收回调通知的类型，目前有[ HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779) 和 [基于消息队列的可靠通知](https://cloud.tencent.com/document/product/266/33779) 两种类型。
        /// - 对于[ HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779)，可设置 3.0 格式回调的地址。3.0 格式回调的说明参见 [历史格式回调](https://cloud.tencent.com/document/product/266/33796)。
        /// - 对具体事件服务的通知事件选择设置接收或者忽略。
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public Task<ModifyEventConfigResponse> ModifyEventConfig(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig");
        }

        /// <summary>
        /// 腾讯云点播为客户提供了媒体上传、媒体管理、媒体处理等等服务，在这些服务执行过程或执行结束时，腾讯云点播也提供各种对应的事件通知，方便开发者感知服务处理状态，并做下一步的业务操作。
        /// 
        /// 开发者可以通过调用本接口来实现：
        /// - 设置接收回调通知的类型，目前有[ HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779) 和 [基于消息队列的可靠通知](https://cloud.tencent.com/document/product/266/33779) 两种类型。
        /// - 对于[ HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779)，可设置 3.0 格式回调的地址。3.0 格式回调的说明参见 [历史格式回调](https://cloud.tencent.com/document/product/266/33796)。
        /// - 对具体事件服务的通知事件选择设置接收或者忽略。
        /// </summary>
        /// <param name="req"><see cref="ModifyEventConfigRequest"/></param>
        /// <returns><see cref="ModifyEventConfigResponse"/></returns>
        public ModifyEventConfigResponse ModifyEventConfigSync(ModifyEventConfigRequest req)
        {
            return InternalRequestAsync<ModifyEventConfigResponse>(req, "ModifyEventConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改片头片尾模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public Task<ModifyHeadTailTemplateResponse> ModifyHeadTailTemplate(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate");
        }

        /// <summary>
        /// 修改片头片尾模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyHeadTailTemplateRequest"/></param>
        /// <returns><see cref="ModifyHeadTailTemplateResponse"/></returns>
        public ModifyHeadTailTemplateResponse ModifyHeadTailTemplateSync(ModifyHeadTailTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHeadTailTemplateResponse>(req, "ModifyHeadTailTemplate")
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
        /// 修改即时转码模板。
        /// - 注意：即时转码模板创建后，不推荐修改，如需修改参数，推荐使用新增模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<ModifyJustInTimeTranscodeTemplateResponse> ModifyJustInTimeTranscodeTemplate(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// 修改即时转码模板。
        /// - 注意：即时转码模板创建后，不推荐修改，如需修改参数，推荐使用新增模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyJustInTimeTranscodeTemplateResponse"/></returns>
        public ModifyJustInTimeTranscodeTemplateResponse ModifyJustInTimeTranscodeTemplateSync(ModifyJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<ModifyJustInTimeTranscodeTemplateResponse>(req, "ModifyJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义 MPS 任务模板。
        /// 修改模板时，需要将 MPS 相关参数以 JSON 格式填入 MPSModifyTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// </summary>
        /// <param name="req"><see cref="ModifyMPSTemplateRequest"/></param>
        /// <returns><see cref="ModifyMPSTemplateResponse"/></returns>
        public Task<ModifyMPSTemplateResponse> ModifyMPSTemplate(ModifyMPSTemplateRequest req)
        {
            return InternalRequestAsync<ModifyMPSTemplateResponse>(req, "ModifyMPSTemplate");
        }

        /// <summary>
        /// 修改用户自定义 MPS 任务模板。
        /// 修改模板时，需要将 MPS 相关参数以 JSON 格式填入 MPSModifyTemplateParams 参数中。关于具体的任务参数配置方法，请参考 MPS 任务模板相关文档说明。
        /// </summary>
        /// <param name="req"><see cref="ModifyMPSTemplateRequest"/></param>
        /// <returns><see cref="ModifyMPSTemplateResponse"/></returns>
        public ModifyMPSTemplateResponse ModifyMPSTemplateSync(ModifyMPSTemplateRequest req)
        {
            return InternalRequestAsync<ModifyMPSTemplateResponse>(req, "ModifyMPSTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面、字幕信息等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo");
        }

        /// <summary>
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面、字幕信息等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public ModifyMediaInfoResponse ModifyMediaInfoSync(ModifyMediaInfoRequest req)
        {
            return InternalRequestAsync<ModifyMediaInfoResponse>(req, "ModifyMediaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体文件的存储类型。
        /// 当媒体文件的存储类型为标准存储时，可以修改为以下类型：
        /// <li>低频存储</li>
        /// <li>归档存储</li>
        /// <li>深度归档存储</li>
        /// 当媒体文件的当前存储类型为低频存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// <li>归档存储</li>
        /// <li>深度归档存储</li>
        /// 当媒体文件的当前存储类型为归档存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// 当媒体文件的当前存储类型为深度归档存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public Task<ModifyMediaStorageClassResponse> ModifyMediaStorageClass(ModifyMediaStorageClassRequest req)
        {
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass");
        }

        /// <summary>
        /// 修改媒体文件的存储类型。
        /// 当媒体文件的存储类型为标准存储时，可以修改为以下类型：
        /// <li>低频存储</li>
        /// <li>归档存储</li>
        /// <li>深度归档存储</li>
        /// 当媒体文件的当前存储类型为低频存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// <li>归档存储</li>
        /// <li>深度归档存储</li>
        /// 当媒体文件的当前存储类型为归档存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// 当媒体文件的当前存储类型为深度归档存储时，可以修改为以下类型：
        /// <li>标准存储</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaStorageClassRequest"/></param>
        /// <returns><see cref="ModifyMediaStorageClassResponse"/></returns>
        public ModifyMediaStorageClassResponse ModifyMediaStorageClassSync(ModifyMediaStorageClassRequest req)
        {
            return InternalRequestAsync<ModifyMediaStorageClassResponse>(req, "ModifyMediaStorageClass")
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
        /// 修改音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public Task<ModifyQualityInspectTemplateResponse> ModifyQualityInspectTemplate(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate");
        }

        /// <summary>
        /// 修改音画质检测模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyQualityInspectTemplateRequest"/></param>
        /// <returns><see cref="ModifyQualityInspectTemplateResponse"/></returns>
        public ModifyQualityInspectTemplateResponse ModifyQualityInspectTemplateSync(ModifyQualityInspectTemplateRequest req)
        {
            return InternalRequestAsync<ModifyQualityInspectTemplateResponse>(req, "ModifyQualityInspectTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 修改视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public Task<ModifyRebuildMediaTemplateResponse> ModifyRebuildMediaTemplate(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，新版 [音画质重生](https://cloud.tencent.com/document/product/266/102571) 接口使用预置模板，详情请参见 [音画质重生模板](https://cloud.tencent.com/document/product/266/102586#50604b3f-0286-4a10-a3f7-18218116aff7)。
        /// 修改视频重生模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyRebuildMediaTemplateRequest"/></param>
        /// <returns><see cref="ModifyRebuildMediaTemplateResponse"/></returns>
        public ModifyRebuildMediaTemplateResponse ModifyRebuildMediaTemplateSync(ModifyRebuildMediaTemplateRequest req)
        {
            return InternalRequestAsync<ModifyRebuildMediaTemplateResponse>(req, "ModifyRebuildMediaTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户自定义审核模板。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public Task<ModifyReviewTemplateResponse> ModifyReviewTemplate(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate");
        }

        /// <summary>
        /// 修改用户自定义审核模板。
        /// >模板仅适用于 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 和 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// </summary>
        /// <param name="req"><see cref="ModifyReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyReviewTemplateResponse"/></returns>
        public ModifyReviewTemplateResponse ModifyReviewTemplateSync(ModifyReviewTemplateRequest req)
        {
            return InternalRequestAsync<ModifyReviewTemplateResponse>(req, "ModifyReviewTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改轮播播单。
        /// 修改后只有新的播放请求会生效，已经在播放中的用户在七天之内还可以播放修改前的播单。
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public Task<ModifyRoundPlayResponse> ModifyRoundPlay(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay");
        }

        /// <summary>
        /// 该接口用于修改轮播播单。
        /// 修改后只有新的播放请求会生效，已经在播放中的用户在七天之内还可以播放修改前的播单。
        /// </summary>
        /// <param name="req"><see cref="ModifyRoundPlayRequest"/></param>
        /// <returns><see cref="ModifyRoundPlayResponse"/></returns>
        public ModifyRoundPlayResponse ModifyRoundPlaySync(ModifyRoundPlayRequest req)
        {
            return InternalRequestAsync<ModifyRoundPlayResponse>(req, "ModifyRoundPlay")
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
        /// 该接口用于修改应用信息，但不允许修改默认应用信息。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public Task<ModifySubAppIdInfoResponse> ModifySubAppIdInfo(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo");
        }

        /// <summary>
        /// 该接口用于修改应用信息，但不允许修改默认应用信息。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public ModifySubAppIdInfoResponse ModifySubAppIdInfoSync(ModifySubAppIdInfoRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdInfoResponse>(req, "ModifySubAppIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于启用、停用应用。被停用的应用将封停对应域名，并限制控制台访问。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public Task<ModifySubAppIdStatusResponse> ModifySubAppIdStatus(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus");
        }

        /// <summary>
        /// 该接口用于启用、停用应用。被停用的应用将封停对应域名，并限制控制台访问。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public ModifySubAppIdStatusResponse ModifySubAppIdStatusSync(ModifySubAppIdStatusRequest req)
        {
            return InternalRequestAsync<ModifySubAppIdStatusResponse>(req, "ModifySubAppIdStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 修改播放器配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public Task<ModifySuperPlayerConfigResponse> ModifySuperPlayerConfig(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，新版播放器签名不再使用播放器配置模板，详细请参考 [播放器签名](https://cloud.tencent.com/document/product/266/45554)。
        /// 修改播放器配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public ModifySuperPlayerConfigResponse ModifySuperPlayerConfigSync(ModifySuperPlayerConfigRequest req)
        {
            return InternalRequestAsync<ModifySuperPlayerConfigResponse>(req, "ModifySuperPlayerConfig")
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
        /// 该接口用于修改点播域名的加速区域。
        /// 1、域名部署状态为 Online 状态时才允许修改加速区域。
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public Task<ModifyVodDomainAccelerateConfigResponse> ModifyVodDomainAccelerateConfig(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig");
        }

        /// <summary>
        /// 该接口用于修改点播域名的加速区域。
        /// 1、域名部署状态为 Online 状态时才允许修改加速区域。
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainAccelerateConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainAccelerateConfigResponse"/></returns>
        public ModifyVodDomainAccelerateConfigResponse ModifyVodDomainAccelerateConfigSync(ModifyVodDomainAccelerateConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainAccelerateConfigResponse>(req, "ModifyVodDomainAccelerateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改域名配置，可以修改域名的防盗链配置。
        /// 1、域名部署状态为 Online 状态时才允许修改域名的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public Task<ModifyVodDomainConfigResponse> ModifyVodDomainConfig(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig");
        }

        /// <summary>
        /// 该接口用于修改域名配置，可以修改域名的防盗链配置。
        /// 1、域名部署状态为 Online 状态时才允许修改域名的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyVodDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyVodDomainConfigResponse"/></returns>
        public ModifyVodDomainConfigResponse ModifyVodDomainConfigSync(ModifyVodDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyVodDomainConfigResponse>(req, "ModifyVodDomainConfig")
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
        /// 上传 HLS 视频时，解析索引文件内容，返回待上传的分片文件列表。分片文件路径必须是当前目录或子目录的相对路径，不能是 URL，不能是绝对路径。
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public Task<ParseStreamingManifestResponse> ParseStreamingManifest(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest");
        }

        /// <summary>
        /// 上传 HLS 视频时，解析索引文件内容，返回待上传的分片文件列表。分片文件路径必须是当前目录或子目录的相对路径，不能是 URL，不能是绝对路径。
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public ParseStreamingManifestResponse ParseStreamingManifestSync(ParseStreamingManifestRequest req)
        {
            return InternalRequestAsync<ParseStreamingManifestResponse>(req, "ParseStreamingManifest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，智能识别任务请使用图片智能识别 [ReviewImage](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// 
        /// 对点播中的图片文件发起处理任务，功能包括：
        /// 
        /// 1. 智能识别（令人反感的信息、不安全的信息、不适宜的信息）;
        /// 
        /// ><li>图片文件大小支持：文件 < 5M；</li>
        /// ><li>图片文件分辨率支持：建议分辨率大于256x256，否则可能会影响识别效果；</li>
        /// ><li>图片文件支持格式：PNG、JPG、JPEG、BMP、GIF、WEBP格式。</li>
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public Task<ProcessImageResponse> ProcessImage(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，智能识别任务请使用图片智能识别 [ReviewImage](https://cloud.tencent.com/document/api/266/73217) 接口。
        /// 
        /// 对点播中的图片文件发起处理任务，功能包括：
        /// 
        /// 1. 智能识别（令人反感的信息、不安全的信息、不适宜的信息）;
        /// 
        /// ><li>图片文件大小支持：文件 < 5M；</li>
        /// ><li>图片文件分辨率支持：建议分辨率大于256x256，否则可能会影响识别效果；</li>
        /// ><li>图片文件支持格式：PNG、JPG、JPEG、BMP、GIF、WEBP格式。</li>
        /// </summary>
        /// <param name="req"><see cref="ProcessImageRequest"/></param>
        /// <returns><see cref="ProcessImageResponse"/></returns>
        public ProcessImageResponse ProcessImageSync(ProcessImageRequest req)
        {
            return InternalRequestAsync<ProcessImageResponse>(req, "ProcessImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播中的音视频媒体发起处理任务，功能包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截取雪碧图；
        /// 6. 对视频截取一张图做封面；
        /// 7. 对视频转自适应码流（并加密）；
        /// 8. 内容审核（令人反感的信息、不安全的信息、不适宜的信息），<font color=red>不建议</font> 使用该接口发起，推荐使用 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 或 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217)；
        /// 9. 内容分析（标签、分类、封面、按帧标签），暂时不支持 HLS 格式；
        /// 10. 内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia");
        }

        /// <summary>
        /// 对点播中的音视频媒体发起处理任务，功能包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截取雪碧图；
        /// 6. 对视频截取一张图做封面；
        /// 7. 对视频转自适应码流（并加密）；
        /// 8. 内容审核（令人反感的信息、不安全的信息、不适宜的信息），<font color=red>不建议</font> 使用该接口发起，推荐使用 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 或 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217)；
        /// 9. 内容分析（标签、分类、封面、按帧标签），暂时不支持 HLS 格式；
        /// 10. 内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
            return InternalRequestAsync<ProcessMediaResponse>(req, "ProcessMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用媒体处理服务（MPS）的媒体处理能力，对点播中的视频发起媒体处理，任务发起时需将 MPS 相关参数以 JSON 格式填入 MPSProcessMediaParams 参数中。具体任务参数配置请参考[媒体处理 ProcessMedia 接口](https://cloud.tencent.com/document/api/862/37578)。 
        /// 当前支持的 MPS 功能：
        /// 1. [智能擦除](https://cloud.tencent.com/document/product/862/101530)：能够对视频画面中的 Logo、字幕、人脸和车牌等元素进行模糊、马赛克或无痕化处理，从而便于内容的传播和分享。该任务产生的新视频将生成新的 FileId 存储在点播平台的子应用中。
        /// 2. [音视频增强](https://cloud.tencent.com/document/product/862/118703)：该功能支持分布式实时画质增强，包含视频去毛刺、降噪、色彩增强、细节增强、人脸增强、SDR2HDR、大模型增强等功能，可大幅提升音视频质量，广泛应用于 OTT、电商、赛事等场景，有效实现 QoE 与 QoS 双维度提升，创造显著业务价值。
        /// 
        /// > 以该种方式发起的视频处理任务：
        /// > 1. 任务状态及结果的查询仍在点播平台中完成，使用 [DescribeTaskDetail](https://cloud.tencent.com/document/product/266/33431) 或 [DescribeTasks](https://cloud.tencent.com/document/product/266/33430) 查询任务。
        /// > 2. 相关功能的用量及账单将在 MPS 平台给出，因此在使用该功能前，首先需要开通 MPS 服务。
        /// > 3. 该功能目前仍在内测中，如需测试体验，您可以联系我们获得支持。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByMPSRequest"/></param>
        /// <returns><see cref="ProcessMediaByMPSResponse"/></returns>
        public Task<ProcessMediaByMPSResponse> ProcessMediaByMPS(ProcessMediaByMPSRequest req)
        {
            return InternalRequestAsync<ProcessMediaByMPSResponse>(req, "ProcessMediaByMPS");
        }

        /// <summary>
        /// 使用媒体处理服务（MPS）的媒体处理能力，对点播中的视频发起媒体处理，任务发起时需将 MPS 相关参数以 JSON 格式填入 MPSProcessMediaParams 参数中。具体任务参数配置请参考[媒体处理 ProcessMedia 接口](https://cloud.tencent.com/document/api/862/37578)。 
        /// 当前支持的 MPS 功能：
        /// 1. [智能擦除](https://cloud.tencent.com/document/product/862/101530)：能够对视频画面中的 Logo、字幕、人脸和车牌等元素进行模糊、马赛克或无痕化处理，从而便于内容的传播和分享。该任务产生的新视频将生成新的 FileId 存储在点播平台的子应用中。
        /// 2. [音视频增强](https://cloud.tencent.com/document/product/862/118703)：该功能支持分布式实时画质增强，包含视频去毛刺、降噪、色彩增强、细节增强、人脸增强、SDR2HDR、大模型增强等功能，可大幅提升音视频质量，广泛应用于 OTT、电商、赛事等场景，有效实现 QoE 与 QoS 双维度提升，创造显著业务价值。
        /// 
        /// > 以该种方式发起的视频处理任务：
        /// > 1. 任务状态及结果的查询仍在点播平台中完成，使用 [DescribeTaskDetail](https://cloud.tencent.com/document/product/266/33431) 或 [DescribeTasks](https://cloud.tencent.com/document/product/266/33430) 查询任务。
        /// > 2. 相关功能的用量及账单将在 MPS 平台给出，因此在使用该功能前，首先需要开通 MPS 服务。
        /// > 3. 该功能目前仍在内测中，如需测试体验，您可以联系我们获得支持。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByMPSRequest"/></param>
        /// <returns><see cref="ProcessMediaByMPSResponse"/></returns>
        public ProcessMediaByMPSResponse ProcessMediaByMPSSync(ProcessMediaByMPSRequest req)
        {
            return InternalRequestAsync<ProcessMediaByMPSResponse>(req, "ProcessMediaByMPS")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用任务流模板，对点播中的视频发起处理任务。
        /// 有两种方式创建任务流模板：
        /// 1. 在控制台上创建和修改任务流模板；
        /// 2. 通过任务流模板接口创建任务流模板。
        /// 
        /// 如使用事件通知，除音视频审核任务外的事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)；音视频审核任务事件通知的类型为 [音视频审核完成](https://cloud.tencent.com/document/product/266/81258)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public Task<ProcessMediaByProcedureResponse> ProcessMediaByProcedure(ProcessMediaByProcedureRequest req)
        {
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure");
        }

        /// <summary>
        /// 使用任务流模板，对点播中的视频发起处理任务。
        /// 有两种方式创建任务流模板：
        /// 1. 在控制台上创建和修改任务流模板；
        /// 2. 通过任务流模板接口创建任务流模板。
        /// 
        /// 如使用事件通知，除音视频审核任务外的事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)；音视频审核任务事件通知的类型为 [音视频审核完成](https://cloud.tencent.com/document/product/266/81258)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public ProcessMediaByProcedureResponse ProcessMediaByProcedureSync(ProcessMediaByProcedureRequest req)
        {
            return InternalRequestAsync<ProcessMediaByProcedureResponse>(req, "ProcessMediaByProcedure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，请使用 MPS 产品的 [ProcessMedia](https://cloud.tencent.com/document/product/862/37578) 接口，在入参 InputInfo.UrlInputInfo.Url 中指定视频 URL。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public Task<ProcessMediaByUrlResponse> ProcessMediaByUrl(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl");
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，请使用 MPS 产品的 [ProcessMedia](https://cloud.tencent.com/document/product/862/37578) 接口，在入参 InputInfo.UrlInputInfo.Url 中指定视频 URL。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public ProcessMediaByUrlResponse ProcessMediaByUrlSync(ProcessMediaByUrlRequest req)
        {
            return InternalRequestAsync<ProcessMediaByUrlResponse>(req, "ProcessMediaByUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// * 该接口用于业务服务器以 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 的方式获取事件通知；
        /// * 接口为长轮询模式，即：如果服务端存在未消费事件，则立即返回给请求方；如果服务端没有未消费事件，则后台会将请求挂起，直到有新的事件产生为止；
        /// * 请求最多挂起5秒，建议请求方将超时时间设置为10秒；
        /// * 未被拉取的事件通知最多保留4天，超过该时限的事件通知可能会被清除；
        /// * 若该接口有事件返回，调用方必须在<font color="red">30秒</font>内调用 [确认事件通知](https://cloud.tencent.com/document/product/266/33434) 接口，确认事件通知已经处理，否则该事件通知在<font color="red">30秒</font>后会再次被拉取到。
        /// * 当前，API 每次最多可以获取16个事件通知。
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public Task<PullEventsResponse> PullEvents(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents");
        }

        /// <summary>
        /// * 该接口用于业务服务器以 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 的方式获取事件通知；
        /// * 接口为长轮询模式，即：如果服务端存在未消费事件，则立即返回给请求方；如果服务端没有未消费事件，则后台会将请求挂起，直到有新的事件产生为止；
        /// * 请求最多挂起5秒，建议请求方将超时时间设置为10秒；
        /// * 未被拉取的事件通知最多保留4天，超过该时限的事件通知可能会被清除；
        /// * 若该接口有事件返回，调用方必须在<font color="red">30秒</font>内调用 [确认事件通知](https://cloud.tencent.com/document/product/266/33434) 接口，确认事件通知已经处理，否则该事件通知在<font color="red">30秒</font>后会再次被拉取到。
        /// * 当前，API 每次最多可以获取16个事件通知。
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public PullEventsResponse PullEventsSync(PullEventsRequest req)
        {
            return InternalRequestAsync<PullEventsResponse>(req, "PullEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于将一个网络上的视频拉取到云点播平台。
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public Task<PullUploadResponse> PullUpload(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload");
        }

        /// <summary>
        /// 该接口用于将一个网络上的视频拉取到云点播平台。
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public PullUploadResponse PullUploadSync(PullUploadRequest req)
        {
            return InternalRequestAsync<PullUploadResponse>(req, "PullUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 预热指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// 4. 默认预热配额为每天10000个 URL。
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public Task<PushUrlCacheResponse> PushUrlCache(PushUrlCacheRequest req)
        {
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache");
        }

        /// <summary>
        /// 1. 预热指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// 4. 默认预热配额为每天10000个 URL。
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public PushUrlCacheResponse PushUrlCacheSync(PushUrlCacheRequest req)
        {
            return InternalRequestAsync<PushUrlCacheResponse>(req, "PushUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 发起音画质重生
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public Task<RebuildMediaResponse> RebuildMedia(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 发起音画质重生
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaRequest"/></param>
        /// <returns><see cref="RebuildMediaResponse"/></returns>
        public RebuildMediaResponse RebuildMediaSync(RebuildMediaRequest req)
        {
            return InternalRequestAsync<RebuildMediaResponse>(req, "RebuildMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 使用模板发起视频重生。
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public Task<RebuildMediaByTemplateResponse> RebuildMediaByTemplate(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate");
        }

        /// <summary>
        /// 该 API 已经<font color=red>不再维护</font>，请使用新版接口 [音画质重生](https://cloud.tencent.com/document/api/266/102571)。
        /// 使用模板发起视频重生。
        /// </summary>
        /// <param name="req"><see cref="RebuildMediaByTemplateRequest"/></param>
        /// <returns><see cref="RebuildMediaByTemplateResponse"/></returns>
        public RebuildMediaByTemplateResponse RebuildMediaByTemplateSync(RebuildMediaByTemplateRequest req)
        {
            return InternalRequestAsync<RebuildMediaByTemplateResponse>(req, "RebuildMediaByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 刷新指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// 4. 默认刷新配额为每天100000个 URL。
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public Task<RefreshUrlCacheResponse> RefreshUrlCache(RefreshUrlCacheRequest req)
        {
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache");
        }

        /// <summary>
        /// 1. 刷新指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// 4. 默认刷新配额为每天100000个 URL。
        /// </summary>
        /// <param name="req"><see cref="RefreshUrlCacheRequest"/></param>
        /// <returns><see cref="RefreshUrlCacheResponse"/></returns>
        public RefreshUrlCacheResponse RefreshUrlCacheSync(RefreshUrlCacheRequest req)
        {
            return InternalRequestAsync<RefreshUrlCacheResponse>(req, "RefreshUrlCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能去除水印
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public Task<RemoveWatermarkResponse> RemoveWatermark(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark");
        }

        /// <summary>
        /// 智能去除水印
        /// </summary>
        /// <param name="req"><see cref="RemoveWatermarkRequest"/></param>
        /// <returns><see cref="RemoveWatermarkResponse"/></returns>
        public RemoveWatermarkResponse RemoveWatermarkSync(RemoveWatermarkRequest req)
        {
            return InternalRequestAsync<RemoveWatermarkResponse>(req, "RemoveWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新设置用户自定义任务流模板的内容。
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public Task<ResetProcedureTemplateResponse> ResetProcedureTemplate(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate");
        }

        /// <summary>
        /// 重新设置用户自定义任务流模板的内容。
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public ResetProcedureTemplateResponse ResetProcedureTemplateSync(ResetProcedureTemplateRequest req)
        {
            return InternalRequestAsync<ResetProcedureTemplateResponse>(req, "ResetProcedureTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当媒体文件的存储类型是归档存储或深度归档存储时，是不可访问的。如需访问，则需要调用本接口进行解冻，解冻后可访问的媒体文件是临时的，在有效期过后，则不可访问。
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public Task<RestoreMediaResponse> RestoreMedia(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia");
        }

        /// <summary>
        /// 当媒体文件的存储类型是归档存储或深度归档存储时，是不可访问的。如需访问，则需要调用本接口进行解冻，解冻后可访问的媒体文件是临时的，在有效期过后，则不可访问。
        /// </summary>
        /// <param name="req"><see cref="RestoreMediaRequest"/></param>
        /// <returns><see cref="RestoreMediaResponse"/></returns>
        public RestoreMediaResponse RestoreMediaSync(RestoreMediaRequest req)
        {
            return InternalRequestAsync<RestoreMediaResponse>(req, "RestoreMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播中的音视频媒体发起审核任务，智能检测视频画面、画面中的文字、语音中的文字、声音出现的违规内容。
        /// 
        /// 如使用事件通知，事件通知的类型为 [音视频审核完成](https://cloud.tencent.com/document/product/266/81258)。
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public Task<ReviewAudioVideoResponse> ReviewAudioVideo(ReviewAudioVideoRequest req)
        {
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo");
        }

        /// <summary>
        /// 对点播中的音视频媒体发起审核任务，智能检测视频画面、画面中的文字、语音中的文字、声音出现的违规内容。
        /// 
        /// 如使用事件通知，事件通知的类型为 [音视频审核完成](https://cloud.tencent.com/document/product/266/81258)。
        /// </summary>
        /// <param name="req"><see cref="ReviewAudioVideoRequest"/></param>
        /// <returns><see cref="ReviewAudioVideoResponse"/></returns>
        public ReviewAudioVideoResponse ReviewAudioVideoSync(ReviewAudioVideoRequest req)
        {
            return InternalRequestAsync<ReviewAudioVideoResponse>(req, "ReviewAudioVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播中的图片文件发起审核（令人反感的信息、不安全的信息、不适宜的信息）任务。
        /// 
        /// ><li>图片文件大小支持：文件 < 5M；</li>
        /// ><li>图片文件分辨率支持：建议分辨率大于256x256，否则可能会影响审核效果；</li>
        /// ><li>图片文件支持格式：PNG、JPG、JPEG、BMP、GIF、WEBP格式。</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public Task<ReviewImageResponse> ReviewImage(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage");
        }

        /// <summary>
        /// 对点播中的图片文件发起审核（令人反感的信息、不安全的信息、不适宜的信息）任务。
        /// 
        /// ><li>图片文件大小支持：文件 < 5M；</li>
        /// ><li>图片文件分辨率支持：建议分辨率大于256x256，否则可能会影响审核效果；</li>
        /// ><li>图片文件支持格式：PNG、JPG、JPEG、BMP、GIF、WEBP格式。</li>
        /// </summary>
        /// <param name="req"><see cref="ReviewImageRequest"/></param>
        /// <returns><see cref="ReviewImageResponse"/></returns>
        public ReviewImageResponse ReviewImageSync(ReviewImageRequest req)
        {
            return InternalRequestAsync<ReviewImageResponse>(req, "ReviewImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索媒体信息，支持多种条件筛选，以及支持对返回结果排序、过滤等功能，具体包括：
        /// - 指定文件 ID 集合 FileIds ，返回匹配集合中任意 ID 的媒体。
        /// - 根据多个媒体文件名 Names 或描述信息 Descriptions 进行模糊搜索。
        /// - 根据多个文件名前缀 NamePrefixes 进行搜索。
        /// - 指定分类集合 ClassIds（见输入参数），返回满足集合中任意分类的媒体。例如：媒体分类有电影、电视剧、综艺等，其中电影分类下又有子分类历史片、动作片、言情片。如果 ClassIds 指定了电影、电视剧，那么电影和电视剧下的所有子分类都会返回；而如果 ClassIds 指定的是历史片、动作片，那么只有这2个子分类下的媒体才会返回。
        /// - 指定标签集合 Tags（见输入参数），返回满足集合中任意标签的媒体。例如：媒体标签有二次元、宫斗、鬼畜，如果 Tags 指定了二次元、鬼畜2个标签，那么只要符合这2个标签中任意一个的媒体都会被检索出来。
        /// - 指定文件类型集合 Categories（见输入参数），返回满足集合中任意类型的媒体。例如：文件类型有 Video（视频）、 Audio （音频）、 Image （图片）。如果Categories指定了 Video 和 Audio 2个文件类型，那么符合这些类型的媒体都会被检索出来。
        /// - 指定来源集合 SourceTypes（见输入参数），返回满足集合中任意来源的媒体。例如：媒体来源有 Record (直播录制)、Upload （上传）等。如果 SourceTypes 指定了 Record 和 Upload ，那么符合这些来源的媒体都会被检索出来。
        /// - 指定文件封装格式集合 MediaTypes（见输入参数），返回满足集合中任意封装格式的媒体。例如：封装格式有 MP4、AVI、MP3 等。如果 MediaTypes 指定了 MP4 和 MP3，那么符合这些封装格式的媒体都会被检索出来。
        /// - 指定文件状态集合 Status（见输入参数），返回满足集合中任意状态的媒体。例如：文件状态有 Normal（正常）、SystemForbidden（平台封禁）、Forbidden（主动封禁）。如果 Status 指定了 Normal 和 Forbidden 2种文件状态，那么符合这些状态的媒体都会被检索出来。
        /// - 指定文件审核结果集合 ReviewResults（见输入参数），返回满足集合中任意状态的媒体。例如：文件审核结果有 pass（通过）、block（违规）等。如果 ReviewResults 指定了 pass 和 block 2种审核结果，那么符合这些审核结果的媒体都会被检索出来。
        /// - 指定直播推流码集合 StreamIds（见输入参数）筛选直播录制的媒体。
        /// - 指定媒体的创建时间范围筛选媒体。
        /// - 指定 TRTC 应用 ID 集合筛选媒体。
        /// - 指定 TRTC 房间 ID 集合筛选媒体。
        /// 
        /// - 以上参数之间可以任意组合进行检索。例如：筛选创建时间在2018年12月1日12:00:00到2018年12月8日12:00:00之间、分类为电影或电视剧、带有宫斗和悬疑标签的媒体。注意，任何支持数组输入的参数，其元素之间的搜索逻辑为‘或’。所有参数之间的逻辑关系为‘与’。
        /// 
        /// - 允许通过 Filters 控制返回的媒体信息种类（默认返回所有信息）。可选输入包括：
        ///     1. 基础信息（basicInfo）：包括媒体名称、分类、播放地址、封面图片等。
        ///     2. 元信息（metaData）：包括大小、时长、视频流信息、音频流信息等。
        ///     3. 转码结果信息（transcodeInfo）：包括该媒体转码生成的各种规格的媒体地址、视频流参数、音频流参数等。
        ///     4. 转动图结果信息（animatedGraphicsInfo）：对视频转动图（如 gif）后的动图信息。
        ///     5. 采样截图信息（sampleSnapshotInfo）：对视频采样截图后的截图信息。
        ///     6. 雪碧图信息（imageSpriteInfo）：对视频截取雪碧图后的雪碧图信息。
        ///     7. 指定时间点截图信息（snapshotByTimeOffsetInfo）：对视频依照指定时间点截图后，的截图信息。
        ///     8. 视频打点信息（keyFrameDescInfo）：对视频设置的打点信息。
        ///     9. 转自适应码流信息（adaptiveDynamicStreamingInfo）：包括规格、加密类型、打包格式等相关信息。
        /// 
        /// - 允许对结果根据创建时间进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
        /// 
        /// <div id="maxResultsDesc">接口返回结果数限制：</div>
        /// 
        /// - <b><a href="#p_offset">Offset</a> 和 <a href="#p_limit">Limit</a> 两个参数影响单次分页查询结果数。特别注意：当这2个值都缺省时，本接口最多只返回10条查询结果。</b>
        /// - <b>最大支持返回5000条搜索结果，超出部分不再支持查询。如果搜索结果量太大，建议使用更精细的筛选条件来减少搜索结果。</b>
        /// 
        /// <br>不推荐使用的条件筛选：
        /// - （不推荐：应使用 Names、NamePrefixes 或 Descriptions 替代）指定单个文本 Text 对媒体文件名或描述信息进行模糊搜索。
        /// - （不推荐：应使用 SourceTypes 替代）指定单个媒体文件来源 SourceType 进行搜索。
        /// - （不推荐：应使用 StreamIds 替代）指定单个推流直播码 StreamId 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个起始创建时间 StartTime 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个结尾创建时间 EndTime 进行搜索。
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public Task<SearchMediaResponse> SearchMedia(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia");
        }

        /// <summary>
        /// 搜索媒体信息，支持多种条件筛选，以及支持对返回结果排序、过滤等功能，具体包括：
        /// - 指定文件 ID 集合 FileIds ，返回匹配集合中任意 ID 的媒体。
        /// - 根据多个媒体文件名 Names 或描述信息 Descriptions 进行模糊搜索。
        /// - 根据多个文件名前缀 NamePrefixes 进行搜索。
        /// - 指定分类集合 ClassIds（见输入参数），返回满足集合中任意分类的媒体。例如：媒体分类有电影、电视剧、综艺等，其中电影分类下又有子分类历史片、动作片、言情片。如果 ClassIds 指定了电影、电视剧，那么电影和电视剧下的所有子分类都会返回；而如果 ClassIds 指定的是历史片、动作片，那么只有这2个子分类下的媒体才会返回。
        /// - 指定标签集合 Tags（见输入参数），返回满足集合中任意标签的媒体。例如：媒体标签有二次元、宫斗、鬼畜，如果 Tags 指定了二次元、鬼畜2个标签，那么只要符合这2个标签中任意一个的媒体都会被检索出来。
        /// - 指定文件类型集合 Categories（见输入参数），返回满足集合中任意类型的媒体。例如：文件类型有 Video（视频）、 Audio （音频）、 Image （图片）。如果Categories指定了 Video 和 Audio 2个文件类型，那么符合这些类型的媒体都会被检索出来。
        /// - 指定来源集合 SourceTypes（见输入参数），返回满足集合中任意来源的媒体。例如：媒体来源有 Record (直播录制)、Upload （上传）等。如果 SourceTypes 指定了 Record 和 Upload ，那么符合这些来源的媒体都会被检索出来。
        /// - 指定文件封装格式集合 MediaTypes（见输入参数），返回满足集合中任意封装格式的媒体。例如：封装格式有 MP4、AVI、MP3 等。如果 MediaTypes 指定了 MP4 和 MP3，那么符合这些封装格式的媒体都会被检索出来。
        /// - 指定文件状态集合 Status（见输入参数），返回满足集合中任意状态的媒体。例如：文件状态有 Normal（正常）、SystemForbidden（平台封禁）、Forbidden（主动封禁）。如果 Status 指定了 Normal 和 Forbidden 2种文件状态，那么符合这些状态的媒体都会被检索出来。
        /// - 指定文件审核结果集合 ReviewResults（见输入参数），返回满足集合中任意状态的媒体。例如：文件审核结果有 pass（通过）、block（违规）等。如果 ReviewResults 指定了 pass 和 block 2种审核结果，那么符合这些审核结果的媒体都会被检索出来。
        /// - 指定直播推流码集合 StreamIds（见输入参数）筛选直播录制的媒体。
        /// - 指定媒体的创建时间范围筛选媒体。
        /// - 指定 TRTC 应用 ID 集合筛选媒体。
        /// - 指定 TRTC 房间 ID 集合筛选媒体。
        /// 
        /// - 以上参数之间可以任意组合进行检索。例如：筛选创建时间在2018年12月1日12:00:00到2018年12月8日12:00:00之间、分类为电影或电视剧、带有宫斗和悬疑标签的媒体。注意，任何支持数组输入的参数，其元素之间的搜索逻辑为‘或’。所有参数之间的逻辑关系为‘与’。
        /// 
        /// - 允许通过 Filters 控制返回的媒体信息种类（默认返回所有信息）。可选输入包括：
        ///     1. 基础信息（basicInfo）：包括媒体名称、分类、播放地址、封面图片等。
        ///     2. 元信息（metaData）：包括大小、时长、视频流信息、音频流信息等。
        ///     3. 转码结果信息（transcodeInfo）：包括该媒体转码生成的各种规格的媒体地址、视频流参数、音频流参数等。
        ///     4. 转动图结果信息（animatedGraphicsInfo）：对视频转动图（如 gif）后的动图信息。
        ///     5. 采样截图信息（sampleSnapshotInfo）：对视频采样截图后的截图信息。
        ///     6. 雪碧图信息（imageSpriteInfo）：对视频截取雪碧图后的雪碧图信息。
        ///     7. 指定时间点截图信息（snapshotByTimeOffsetInfo）：对视频依照指定时间点截图后，的截图信息。
        ///     8. 视频打点信息（keyFrameDescInfo）：对视频设置的打点信息。
        ///     9. 转自适应码流信息（adaptiveDynamicStreamingInfo）：包括规格、加密类型、打包格式等相关信息。
        /// 
        /// - 允许对结果根据创建时间进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
        /// 
        /// <div id="maxResultsDesc">接口返回结果数限制：</div>
        /// 
        /// - <b><a href="#p_offset">Offset</a> 和 <a href="#p_limit">Limit</a> 两个参数影响单次分页查询结果数。特别注意：当这2个值都缺省时，本接口最多只返回10条查询结果。</b>
        /// - <b>最大支持返回5000条搜索结果，超出部分不再支持查询。如果搜索结果量太大，建议使用更精细的筛选条件来减少搜索结果。</b>
        /// 
        /// <br>不推荐使用的条件筛选：
        /// - （不推荐：应使用 Names、NamePrefixes 或 Descriptions 替代）指定单个文本 Text 对媒体文件名或描述信息进行模糊搜索。
        /// - （不推荐：应使用 SourceTypes 替代）指定单个媒体文件来源 SourceType 进行搜索。
        /// - （不推荐：应使用 StreamIds 替代）指定单个推流直播码 StreamId 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个起始创建时间 StartTime 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个结尾创建时间 EndTime 进行搜索。
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public SearchMediaResponse SearchMediaSync(SearchMediaRequest req)
        {
            return InternalRequestAsync<SearchMediaResponse>(req, "SearchMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用自然语言对媒体进行语义搜索。
        /// </summary>
        /// <param name="req"><see cref="SearchMediaBySemanticsRequest"/></param>
        /// <returns><see cref="SearchMediaBySemanticsResponse"/></returns>
        public Task<SearchMediaBySemanticsResponse> SearchMediaBySemantics(SearchMediaBySemanticsRequest req)
        {
            return InternalRequestAsync<SearchMediaBySemanticsResponse>(req, "SearchMediaBySemantics");
        }

        /// <summary>
        /// 使用自然语言对媒体进行语义搜索。
        /// </summary>
        /// <param name="req"><see cref="SearchMediaBySemanticsRequest"/></param>
        /// <returns><see cref="SearchMediaBySemanticsResponse"/></returns>
        public SearchMediaBySemanticsResponse SearchMediaBySemanticsSync(SearchMediaBySemanticsRequest req)
        {
            return InternalRequestAsync<SearchMediaBySemanticsResponse>(req, "SearchMediaBySemantics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为点播域名设置投递 CLS 的目标。
        /// </summary>
        /// <param name="req"><see cref="SetCLSPushTargetRequest"/></param>
        /// <returns><see cref="SetCLSPushTargetResponse"/></returns>
        public Task<SetCLSPushTargetResponse> SetCLSPushTarget(SetCLSPushTargetRequest req)
        {
            return InternalRequestAsync<SetCLSPushTargetResponse>(req, "SetCLSPushTarget");
        }

        /// <summary>
        /// 为点播域名设置投递 CLS 的目标。
        /// </summary>
        /// <param name="req"><see cref="SetCLSPushTargetRequest"/></param>
        /// <returns><see cref="SetCLSPushTargetResponse"/></returns>
        public SetCLSPushTargetResponse SetCLSPushTargetSync(SetCLSPushTargetRequest req)
        {
            return InternalRequestAsync<SetCLSPushTargetResponse>(req, "SetCLSPushTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置 DRM 密钥提供商信息。
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public Task<SetDrmKeyProviderInfoResponse> SetDrmKeyProviderInfo(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo");
        }

        /// <summary>
        /// 设置 DRM 密钥提供商信息。
        /// </summary>
        /// <param name="req"><see cref="SetDrmKeyProviderInfoRequest"/></param>
        /// <returns><see cref="SetDrmKeyProviderInfoResponse"/></returns>
        public SetDrmKeyProviderInfoResponse SetDrmKeyProviderInfoSync(SetDrmKeyProviderInfoRequest req)
        {
            return InternalRequestAsync<SetDrmKeyProviderInfoResponse>(req, "SetDrmKeyProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置点播域名 HTTPS 证书。
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public Task<SetVodDomainCertificateResponse> SetVodDomainCertificate(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate");
        }

        /// <summary>
        /// 设置点播域名 HTTPS 证书。
        /// </summary>
        /// <param name="req"><see cref="SetVodDomainCertificateRequest"/></param>
        /// <returns><see cref="SetVodDomainCertificateResponse"/></returns>
        public SetVodDomainCertificateResponse SetVodDomainCertificateSync(SetVodDomainCertificateRequest req)
        {
            return InternalRequestAsync<SetVodDomainCertificateResponse>(req, "SetVodDomainCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对 HLS 视频进行按时间段裁剪，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段长久保存的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于输入文件，没有独立 FileId；适用于将精彩片段临时分享的场景。
        /// 
        /// 该接口基于输入 m3u8 文件进行裁剪，其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// 
        /// ### 剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始输入视频影响（即使原始输入视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始输入视频相互独立，可以独立管理、长久保存。
        /// 
        /// <font color='red'>注意：</font>如果剪辑时指定进行固化，通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对原始输入的视频进行删除、降冷等操作，否则剪辑生成的视频播放可能出现异常。
        /// 
        /// ### 剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与原始输入视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与原始输入的完整视频有效期是一致的。一旦原始输入的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public Task<SimpleHlsClipResponse> SimpleHlsClip(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip");
        }

        /// <summary>
        /// 对 HLS 视频进行按时间段裁剪，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段长久保存的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于输入文件，没有独立 FileId；适用于将精彩片段临时分享的场景。
        /// 
        /// 该接口基于输入 m3u8 文件进行裁剪，其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// 
        /// ### 剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始输入视频影响（即使原始输入视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始输入视频相互独立，可以独立管理、长久保存。
        /// 
        /// <font color='red'>注意：</font>如果剪辑时指定进行固化，通过 ModifyEventConfig 接口启用接收剪辑固化事件通知，固化成功后将会收到一个 PersistenceComplete 类型的事件通知。在收到这个事件通知之前，不应该对原始输入的视频进行删除、降冷等操作，否则剪辑生成的视频播放可能出现异常。
        /// 
        /// ### 剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与原始输入视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与原始输入的完整视频有效期是一致的。一旦原始输入的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public SimpleHlsClipResponse SimpleHlsClipSync(SimpleHlsClipRequest req)
        {
            return InternalRequestAsync<SimpleHlsClipResponse>(req, "SimpleHlsClip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对点播视频进行拆条，生成多个新的点播视频。
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public Task<SplitMediaResponse> SplitMedia(SplitMediaRequest req)
        {
            return InternalRequestAsync<SplitMediaResponse>(req, "SplitMedia");
        }

        /// <summary>
        /// 对点播视频进行拆条，生成多个新的点播视频。
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public SplitMediaResponse SplitMediaSync(SplitMediaRequest req)
        {
            return InternalRequestAsync<SplitMediaResponse>(req, "SplitMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于验证域名解析值。
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public Task<VerifyDomainRecordResponse> VerifyDomainRecord(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord");
        }

        /// <summary>
        /// 该接口用于验证域名解析值。
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public VerifyDomainRecordResponse VerifyDomainRecordSync(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将点播视频发布到微信小程序，供微信小程序播放器播放。
        /// 本接口支持发布原始视频和转码后视频，暂不支持发布自适应码流。
        /// </summary>
        /// <param name="req"><see cref="WeChatMiniProgramPublishRequest"/></param>
        /// <returns><see cref="WeChatMiniProgramPublishResponse"/></returns>
        public Task<WeChatMiniProgramPublishResponse> WeChatMiniProgramPublish(WeChatMiniProgramPublishRequest req)
        {
            return InternalRequestAsync<WeChatMiniProgramPublishResponse>(req, "WeChatMiniProgramPublish");
        }

        /// <summary>
        /// 将点播视频发布到微信小程序，供微信小程序播放器播放。
        /// 本接口支持发布原始视频和转码后视频，暂不支持发布自适应码流。
        /// </summary>
        /// <param name="req"><see cref="WeChatMiniProgramPublishRequest"/></param>
        /// <returns><see cref="WeChatMiniProgramPublishResponse"/></returns>
        public WeChatMiniProgramPublishResponse WeChatMiniProgramPublishSync(WeChatMiniProgramPublishRequest req)
        {
            return InternalRequestAsync<WeChatMiniProgramPublishResponse>(req, "WeChatMiniProgramPublish")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
