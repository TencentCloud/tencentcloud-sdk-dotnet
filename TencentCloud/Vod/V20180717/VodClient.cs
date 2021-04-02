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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// * 我们强烈建议您使用云点播提供的 [服务端上传 SDK](/document/product/266/9759#1.-.E5.8F.91.E8.B5.B7.E4.B8.8A.E4.BC.A0) 来上传文件。直接调用 API 进行上传的难度和工作量都显著大于使用 SDK。
        /// * 该接口用于申请媒体文件（和封面文件）的上传，获取文件上传到云点播的元信息（包括上传路径、上传签名等），用于后续上传接口。
        /// * 上传流程请参考 [服务端上传综述](/document/product/266/9759)。
        /// </summary>
        /// <param name="req"><see cref="ApplyUploadRequest"/></param>
        /// <returns><see cref="ApplyUploadResponse"/></returns>
        public async Task<ApplyUploadResponse> ApplyUpload(ApplyUploadRequest req)
        {
             JsonResponseModel<ApplyUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ApplyUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联媒资字幕，将指定的字幕关联到转自适应码流模板号对应的媒体输出文件中（或解除关联）。
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public async Task<AttachMediaSubtitlesResponse> AttachMediaSubtitles(AttachMediaSubtitlesRequest req)
        {
             JsonResponseModel<AttachMediaSubtitlesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachMediaSubtitles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachMediaSubtitlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联媒资字幕，将指定的字幕关联到转自适应码流模板号对应的媒体输出文件中（或解除关联）。
        /// </summary>
        /// <param name="req"><see cref="AttachMediaSubtitlesRequest"/></param>
        /// <returns><see cref="AttachMediaSubtitlesResponse"/></returns>
        public AttachMediaSubtitlesResponse AttachMediaSubtitlesSync(AttachMediaSubtitlesRequest req)
        {
             JsonResponseModel<AttachMediaSubtitlesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachMediaSubtitles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachMediaSubtitlesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public async Task<CommitUploadResponse> CommitUpload(CommitUploadRequest req)
        {
             JsonResponseModel<CommitUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req"><see cref="CommitUploadRequest"/></param>
        /// <returns><see cref="CommitUploadResponse"/></returns>
        public CommitUploadResponse CommitUploadSync(CommitUploadRequest req)
        {
             JsonResponseModel<CommitUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于制作媒体文件，可以
        /// 
        /// 1. 对一个媒体文件进行剪辑，生成一个新的媒体文件；
        /// 2. 对多个媒体文件进行裁剪拼接，生成一个新的媒体文件；
        /// 3. 对多个媒体文件的媒体流进行裁剪拼接，生成一个新的媒体文件。
        /// 
        /// 如使用事件通知，事件通知的类型为 [视频合成完成](https://cloud.tencent.com/document/product/266/43000)。
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public async Task<ComposeMediaResponse> ComposeMedia(ComposeMediaRequest req)
        {
             JsonResponseModel<ComposeMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ComposeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ComposeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于制作媒体文件，可以
        /// 
        /// 1. 对一个媒体文件进行剪辑，生成一个新的媒体文件；
        /// 2. 对多个媒体文件进行裁剪拼接，生成一个新的媒体文件；
        /// 3. 对多个媒体文件的媒体流进行裁剪拼接，生成一个新的媒体文件。
        /// 
        /// 如使用事件通知，事件通知的类型为 [视频合成完成](https://cloud.tencent.com/document/product/266/43000)。
        /// </summary>
        /// <param name="req"><see cref="ComposeMediaRequest"/></param>
        /// <returns><see cref="ComposeMediaResponse"/></returns>
        public ComposeMediaResponse ComposeMediaSync(ComposeMediaRequest req)
        {
             JsonResponseModel<ComposeMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ComposeMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ComposeMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 开发者调用拉取事件通知，获取到事件后，必须调用该接口来确认消息已经收到；
        /// * 开发者获取到事件句柄后，等待确认的有效时间为 30 秒，超出 30 秒会报参数错误（4000）；
        /// * 更多参考事件通知的[可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83)。
        /// </summary>
        /// <param name="req"><see cref="ConfirmEventsRequest"/></param>
        /// <returns><see cref="ConfirmEventsResponse"/></returns>
        public async Task<ConfirmEventsResponse> ConfirmEvents(ConfirmEventsRequest req)
        {
             JsonResponseModel<ConfirmEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfirmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ConfirmEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfirmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public async Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public async Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 用于对媒体进行分类管理；
        /// * 该接口不影响既有媒体的分类，如需修改媒体分类，请调用[修改媒体文件属性](/document/product/266/31762)接口。
        /// * 分类层次不可超过 4 层。
        /// * 每个分类的子类数量不可超过 500 个。
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public async Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容智能识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public async Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义视频内容智能识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个用户自定义的图片处理模板，数量上限：16。最多支持三次操作，例如：裁剪-缩略-裁剪。
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public async Task<CreateImageProcessingTemplateResponse> CreateImageProcessingTemplate(CreateImageProcessingTemplateRequest req)
        {
             JsonResponseModel<CreateImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个用户自定义的图片处理模板，数量上限：16。最多支持三次操作，例如：裁剪-缩略-裁剪。
        /// </summary>
        /// <param name="req"><see cref="CreateImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="CreateImageProcessingTemplateResponse"/></returns>
        public CreateImageProcessingTemplateResponse CreateImageProcessingTemplateSync(CreateImageProcessingTemplateRequest req)
        {
             JsonResponseModel<CreateImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public async Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、不适宜视频识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public async Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、不适宜视频识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义的任务流模板，模板上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public async Task<CreateProcedureTemplateResponse> CreateProcedureTemplate(CreateProcedureTemplateRequest req)
        {
             JsonResponseModel<CreateProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义的任务流模板，模板上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns><see cref="CreateProcedureTemplateResponse"/></returns>
        public CreateProcedureTemplateResponse CreateProcedureTemplateSync(CreateProcedureTemplateRequest req)
        {
             JsonResponseModel<CreateProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public async Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public CreateSnapshotByTimeOffsetTemplateResponse CreateSnapshotByTimeOffsetTemplateSync(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建点播子应用。
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public async Task<CreateSubAppIdResponse> CreateSubAppId(CreateSubAppIdRequest req)
        {
             JsonResponseModel<CreateSubAppIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建点播子应用。
        /// </summary>
        /// <param name="req"><see cref="CreateSubAppIdRequest"/></param>
        /// <returns><see cref="CreateSubAppIdResponse"/></returns>
        public CreateSubAppIdResponse CreateSubAppIdSync(CreateSubAppIdRequest req)
        {
             JsonResponseModel<CreateSubAppIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubAppId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubAppIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建超级播放器配置，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public async Task<CreateSuperPlayerConfigResponse> CreateSuperPlayerConfig(CreateSuperPlayerConfigRequest req)
        {
             JsonResponseModel<CreateSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建超级播放器配置，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="CreateSuperPlayerConfigResponse"/></returns>
        public CreateSuperPlayerConfigResponse CreateSuperPlayerConfigSync(CreateSuperPlayerConfigRequest req)
        {
             JsonResponseModel<CreateSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public async Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public async Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public async Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public DeleteAIAnalysisTemplateResponse DeleteAIAnalysisTemplateSync(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public async Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public DeleteAnimatedGraphicsTemplateResponse DeleteAnimatedGraphicsTemplateSync(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](/document/product/266/31764)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public async Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](/document/product/266/31764)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容智能识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public async Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义视频内容智能识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义图片处理模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public async Task<DeleteImageProcessingTemplateResponse> DeleteImageProcessingTemplate(DeleteImageProcessingTemplateRequest req)
        {
             JsonResponseModel<DeleteImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义图片处理模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageProcessingTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageProcessingTemplateResponse"/></returns>
        public DeleteImageProcessingTemplateResponse DeleteImageProcessingTemplateSync(DeleteImageProcessingTemplateRequest req)
        {
             JsonResponseModel<DeleteImageProcessingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageProcessingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageProcessingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public async Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 删除媒体及其对应的视频处理文件（如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的转码，或者微信发布文件；
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
        /// * 删除媒体及其对应的视频处理文件（如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的转码，或者微信发布文件；
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
        /// 该接口用于根据人物 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public async Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据人物 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义的任务流模板。  
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public async Task<DeleteProcedureTemplateResponse> DeleteProcedureTemplate(DeleteProcedureTemplateRequest req)
        {
             JsonResponseModel<DeleteProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义的任务流模板。  
        /// </summary>
        /// <param name="req"><see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns><see cref="DeleteProcedureTemplateResponse"/></returns>
        public DeleteProcedureTemplateResponse DeleteProcedureTemplateSync(DeleteProcedureTemplateRequest req)
        {
             JsonResponseModel<DeleteProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public async Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除超级播放器配置。  
        /// *注：系统预置播放器配置不允许删除。*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public async Task<DeleteSuperPlayerConfigResponse> DeleteSuperPlayerConfig(DeleteSuperPlayerConfigRequest req)
        {
             JsonResponseModel<DeleteSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除超级播放器配置。  
        /// *注：系统预置播放器配置不允许删除。*
        /// </summary>
        /// <param name="req"><see cref="DeleteSuperPlayerConfigRequest"/></param>
        /// <returns><see cref="DeleteSuperPlayerConfigResponse"/></returns>
        public DeleteSuperPlayerConfigResponse DeleteSuperPlayerConfigSync(DeleteSuperPlayerConfigRequest req)
        {
             JsonResponseModel<DeleteSuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public async Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplateSync(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplateSync(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public async Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public DeleteWordSamplesResponse DeleteWordSamplesSync(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容分析模板唯一标识，获取视频内容分析模板详情列表。返回结果包含符合条件的所有用户自定义视频内容分析模板及[系统预置视频内容分析模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public async Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容分析模板唯一标识，获取视频内容分析模板详情列表。返回结果包含符合条件的所有用户自定义视频内容分析模板及[系统预置视频内容分析模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容识别模板唯一标识，获取视频内容识别模板详情列表。返回结果包含符合条件的所有用户自定义视频内容识别模板及[系统预置视频内容识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public async Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容识别模板唯一标识，获取视频内容识别模板详情列表。返回结果包含符合条件的所有用户自定义视频内容识别模板及[系统预置视频内容识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public async Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public async Task<DescribeAllClassResponse> DescribeAllClass(DescribeAllClassRequest req)
        {
             JsonResponseModel<DescribeAllClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllClassRequest"/></param>
        /// <returns><see cref="DescribeAllClassResponse"/></returns>
        public DescribeAllClassResponse DescribeAllClassSync(DescribeAllClassRequest req)
        {
             JsonResponseModel<DescribeAllClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public async Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播域名的 CDN 带宽、流量等统计数据。
        /// * 查询的起始时间和结束时间跨度不超过90天。
        /// * 可以查询不同服务区域的数据。
        /// * 中国境内的数据支持查询指定地区、运营商的统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public async Task<DescribeCDNStatDetailsResponse> DescribeCDNStatDetails(DescribeCDNStatDetailsRequest req)
        {
             JsonResponseModel<DescribeCDNStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDNStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播域名的 CDN 带宽、流量等统计数据。
        /// * 查询的起始时间和结束时间跨度不超过90天。
        /// * 可以查询不同服务区域的数据。
        /// * 中国境内的数据支持查询指定地区、运营商的统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNStatDetailsRequest"/></param>
        /// <returns><see cref="DescribeCDNStatDetailsResponse"/></returns>
        public DescribeCDNStatDetailsResponse DescribeCDNStatDetailsSync(DescribeCDNStatDetailsRequest req)
        {
             JsonResponseModel<DescribeCDNStatDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDNStatDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNStatDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播 CDN 的流量、带宽等统计数据。
        ///    1. 可以查询最近365天内的 CDN 用量数据。
        ///    2.  查询时间跨度不超过90天。
        ///    3. 可以指定用量数据的时间粒度，支持5分钟、1小时、1天的时间粒度。
        ///    4.  流量为查询时间粒度内的总流量，带宽为查询时间粒度内的峰值带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public async Task<DescribeCDNUsageDataResponse> DescribeCDNUsageData(DescribeCDNUsageDataRequest req)
        {
             JsonResponseModel<DescribeCDNUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDNUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播 CDN 的流量、带宽等统计数据。
        ///    1. 可以查询最近365天内的 CDN 用量数据。
        ///    2.  查询时间跨度不超过90天。
        ///    3. 可以指定用量数据的时间粒度，支持5分钟、1小时、1天的时间粒度。
        ///    4.  流量为查询时间粒度内的总流量，带宽为查询时间粒度内的峰值带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns><see cref="DescribeCDNUsageDataResponse"/></returns>
        public DescribeCDNUsageDataResponse DescribeCDNUsageDataSync(DescribeCDNUsageDataRequest req)
        {
             JsonResponseModel<DescribeCDNUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDNUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDNUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询点播域名的 CDN 访问日志的下载链接。
        ///     1. 可以查询最近30天内的 CDN 日志下载链接。
        ///     2. 默认情况下 CDN 每小时生成一个日志文件，如果某一个小时没有 CDN 访问，不会生成日志文件。    
        ///     3. CDN 日志下载链接的有效期为24小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public async Task<DescribeCdnLogsResponse> DescribeCdnLogs(DescribeCdnLogsRequest req)
        {
             JsonResponseModel<DescribeCdnLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询点播域名的 CDN 访问日志的下载链接。
        ///     1. 可以查询最近30天内的 CDN 日志下载链接。
        ///     2. 默认情况下 CDN 每小时生成一个日志文件，如果某一个小时没有 CDN 访问，不会生成日志文件。    
        ///     3. CDN 日志下载链接的有效期为24小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnLogsResponse"/></returns>
        public DescribeCdnLogsResponse DescribeCdnLogsSync(DescribeCdnLogsRequest req)
        {
             JsonResponseModel<DescribeCdnLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容智能识别模板唯一标识，获取视频内容智能识别模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容智能识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public async Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据视频内容智能识别模板唯一标识，获取视频内容智能识别模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容智能识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询指定日期范围内每天的播放统计数据。
        /// * 可以查询最近30天的播放统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public async Task<DescribeDailyMediaPlayStatResponse> DescribeDailyMediaPlayStat(DescribeDailyMediaPlayStatRequest req)
        {
             JsonResponseModel<DescribeDailyMediaPlayStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDailyMediaPlayStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyMediaPlayStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询指定日期范围内每天的播放统计数据。
        /// * 可以查询最近30天的播放统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMediaPlayStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMediaPlayStatResponse"/></returns>
        public DescribeDailyMediaPlayStatResponse DescribeDailyMediaPlayStatSync(DescribeDailyMediaPlayStatRequest req)
        {
             JsonResponseModel<DescribeDailyMediaPlayStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDailyMediaPlayStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyMediaPlayStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询每日播放Top100 的媒体文件的播放统计数据。
        /// * 可以查询最近30天的播放统计数据。
        /// * 可以按播放次数或者播放流量查询。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问 M3U8 文件时统计播放次数；访问 TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public async Task<DescribeDailyMostPlayedStatResponse> DescribeDailyMostPlayedStat(DescribeDailyMostPlayedStatRequest req)
        {
             JsonResponseModel<DescribeDailyMostPlayedStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDailyMostPlayedStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyMostPlayedStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询每日播放Top100 的媒体文件的播放统计数据。
        /// * 可以查询最近30天的播放统计数据。
        /// * 可以按播放次数或者播放流量查询。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问 M3U8 文件时统计播放次数；访问 TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyMostPlayedStatRequest"/></param>
        /// <returns><see cref="DescribeDailyMostPlayedStatResponse"/></returns>
        public DescribeDailyMostPlayedStatResponse DescribeDailyMostPlayedStatSync(DescribeDailyMostPlayedStatRequest req)
        {
             JsonResponseModel<DescribeDailyMostPlayedStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDailyMostPlayedStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyMostPlayedStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询播放统计文件的下载地址。
        /// * 可以查询最近30天的播放统计文件下载地址。
        /// * 云点播每天对前一天的 CDN 请求日志进行分析处理，生成播放统计文件。
        /// * 播放统计文件内容包含媒体文件的播放次数、播放流量等统计信息。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问M3U8 文件时统计播放次数；访问TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放设备的统计：播放请求带了 UserAgent 参数，并且 UserAgent 包含 Android 或者 iPhone 等标识，会统计为移动端播放次数，否则统计为 PC 端播放次数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public async Task<DescribeDailyPlayStatFileListResponse> DescribeDailyPlayStatFileList(DescribeDailyPlayStatFileListRequest req)
        {
             JsonResponseModel<DescribeDailyPlayStatFileListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDailyPlayStatFileList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyPlayStatFileListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询播放统计文件的下载地址。
        /// * 可以查询最近30天的播放统计文件下载地址。
        /// * 云点播每天对前一天的 CDN 请求日志进行分析处理，生成播放统计文件。
        /// * 播放统计文件内容包含媒体文件的播放次数、播放流量等统计信息。
        /// * 播放次数统计说明：
        ///     1. HLS 文件：访问M3U8 文件时统计播放次数；访问TS 文件不统计播放次数。
        ///     2. 其它文件（如 MP4 文件）：播放请求带有 range 参数且 range 的 start 参数不等于0时不统计播放次数，其它情况统计播放次数。
        /// * 播放设备的统计：播放请求带了 UserAgent 参数，并且 UserAgent 包含 Android 或者 iPhone 等标识，会统计为移动端播放次数，否则统计为 PC 端播放次数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDailyPlayStatFileListRequest"/></param>
        /// <returns><see cref="DescribeDailyPlayStatFileListResponse"/></returns>
        public DescribeDailyPlayStatFileListResponse DescribeDailyPlayStatFileListSync(DescribeDailyPlayStatFileListRequest req)
        {
             JsonResponseModel<DescribeDailyPlayStatFileListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDailyPlayStatFileList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDailyPlayStatFileListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本 API 是 [旧版本加密](https://cloud.tencent.com/document/product/266/9638) 中[DescribeDrmDataKey 的 API 2017 接口](https://cloud.tencent.com/document/product/266/9643)的升级版本。
        /// 如果您是新接入点播加密的用户，不要使用该 API。请参考[视频加密综述](https://cloud.tencent.com/document/product/266/45552)使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmDataKeyRequest"/></param>
        /// <returns><see cref="DescribeDrmDataKeyResponse"/></returns>
        public async Task<DescribeDrmDataKeyResponse> DescribeDrmDataKey(DescribeDrmDataKeyRequest req)
        {
             JsonResponseModel<DescribeDrmDataKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDrmDataKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDrmDataKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本 API 是 [旧版本加密](https://cloud.tencent.com/document/product/266/9638) 中[DescribeDrmDataKey 的 API 2017 接口](https://cloud.tencent.com/document/product/266/9643)的升级版本。
        /// 如果您是新接入点播加密的用户，不要使用该 API。请参考[视频加密综述](https://cloud.tencent.com/document/product/266/45552)使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeDrmDataKeyRequest"/></param>
        /// <returns><see cref="DescribeDrmDataKeyResponse"/></returns>
        public DescribeDrmDataKeyResponse DescribeDrmDataKeySync(DescribeDrmDataKeyRequest req)
        {
             JsonResponseModel<DescribeDrmDataKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDrmDataKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDrmDataKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于业务服务器获取 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 事件通知的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsStateRequest"/></param>
        /// <returns><see cref="DescribeEventsStateResponse"/></returns>
        public async Task<DescribeEventsStateResponse> DescribeEventsState(DescribeEventsStateRequest req)
        {
             JsonResponseModel<DescribeEventsStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEventsState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于业务服务器获取 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 事件通知的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsStateRequest"/></param>
        /// <returns><see cref="DescribeEventsStateResponse"/></returns>
        public DescribeEventsStateResponse DescribeEventsStateSync(DescribeEventsStateRequest req)
        {
             JsonResponseModel<DescribeEventsStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEventsState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取图片处理模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public async Task<DescribeImageProcessingTemplatesResponse> DescribeImageProcessingTemplates(DescribeImageProcessingTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageProcessingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageProcessingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageProcessingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取图片处理模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageProcessingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageProcessingTemplatesResponse"/></returns>
        public DescribeImageProcessingTemplatesResponse DescribeImageProcessingTemplatesSync(DescribeImageProcessingTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageProcessingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageProcessingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageProcessingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public async Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 2. 可以指定回包只返回部分信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public async Task<DescribeMediaInfosResponse> DescribeMediaInfos(DescribeMediaInfosRequest req)
        {
             JsonResponseModel<DescribeMediaInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 2. 可以指定回包只返回部分信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaInfosRequest"/></param>
        /// <returns><see cref="DescribeMediaInfosResponse"/></returns>
        public DescribeMediaInfosResponse DescribeMediaInfosSync(DescribeMediaInfosRequest req)
        {
             JsonResponseModel<DescribeMediaInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口返回查询时间范围内每天使用的视频处理用量信息。
        ///    1. 可以查询最近365天内的视频处理统计数据。
        ///    2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessUsageDataRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessUsageDataResponse"/></returns>
        public async Task<DescribeMediaProcessUsageDataResponse> DescribeMediaProcessUsageData(DescribeMediaProcessUsageDataRequest req)
        {
             JsonResponseModel<DescribeMediaProcessUsageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaProcessUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaProcessUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeMediaProcessUsageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaProcessUsageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaProcessUsageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public async Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以查询用户已经购买的预付费商品的信息，包括：
        ///     1. 商品的类型、生效和失效日期。
        ///     2. 商品中每种资源的额度和剩余额度。
        /// </summary>
        /// <param name="req"><see cref="DescribePrepaidProductsRequest"/></param>
        /// <returns><see cref="DescribePrepaidProductsResponse"/></returns>
        public async Task<DescribePrepaidProductsResponse> DescribePrepaidProducts(DescribePrepaidProductsRequest req)
        {
             JsonResponseModel<DescribePrepaidProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrepaidProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrepaidProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribePrepaidProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrepaidProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrepaidProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务流模板名字，获取任务流模板详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public async Task<DescribeProcedureTemplatesResponse> DescribeProcedureTemplates(DescribeProcedureTemplatesRequest req)
        {
             JsonResponseModel<DescribeProcedureTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcedureTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcedureTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务流模板名字，获取任务流模板详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns><see cref="DescribeProcedureTemplatesResponse"/></returns>
        public DescribeProcedureTemplatesResponse DescribeProcedureTemplatesSync(DescribeProcedureTemplatesRequest req)
        {
             JsonResponseModel<DescribeProcedureTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProcedureTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcedureTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribeReviewDetailsResponse> DescribeReviewDetails(DescribeReviewDetailsRequest req)
        {
             JsonResponseModel<DescribeReviewDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReviewDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeReviewDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReviewDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReviewDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public async Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public async Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询存储空间使用情况和文件数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public async Task<DescribeStorageDataResponse> DescribeStorageData(DescribeStorageDataRequest req)
        {
             JsonResponseModel<DescribeStorageDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询存储空间使用情况和文件数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDataRequest"/></param>
        /// <returns><see cref="DescribeStorageDataResponse"/></returns>
        public DescribeStorageDataResponse DescribeStorageDataSync(DescribeStorageDataRequest req)
        {
             JsonResponseModel<DescribeStorageDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口返回查询时间范围内使用的点播存储空间，单位：字节。
        ///     1. 可以查询最近365天内的存储空间数据；
        ///     2. 查询时间跨度不超过90天；
        ///     3. 分钟粒度查询跨度不超过7天；
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageDetailsRequest"/></param>
        /// <returns><see cref="DescribeStorageDetailsResponse"/></returns>
        public async Task<DescribeStorageDetailsResponse> DescribeStorageDetails(DescribeStorageDetailsRequest req)
        {
             JsonResponseModel<DescribeStorageDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStorageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeStorageDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStorageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStorageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取当前账号有权限的子应用列表，包含主应用。若尚未开通子应用功能，接口将返回 
        ///  FailedOperation。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public async Task<DescribeSubAppIdsResponse> DescribeSubAppIds(DescribeSubAppIdsRequest req)
        {
             JsonResponseModel<DescribeSubAppIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubAppIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAppIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取当前账号有权限的子应用列表，包含主应用。若尚未开通子应用功能，接口将返回 
        ///  FailedOperation。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns><see cref="DescribeSubAppIdsResponse"/></returns>
        public DescribeSubAppIdsResponse DescribeSubAppIdsSync(DescribeSubAppIdsRequest req)
        {
             JsonResponseModel<DescribeSubAppIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubAppIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAppIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询超级播放器配置，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public async Task<DescribeSuperPlayerConfigsResponse> DescribeSuperPlayerConfigs(DescribeSuperPlayerConfigsRequest req)
        {
             JsonResponseModel<DescribeSuperPlayerConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSuperPlayerConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSuperPlayerConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询超级播放器配置，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSuperPlayerConfigsRequest"/></param>
        /// <returns><see cref="DescribeSuperPlayerConfigsResponse"/></returns>
        public DescribeSuperPlayerConfigsResponse DescribeSuperPlayerConfigsSync(DescribeSuperPlayerConfigsRequest req)
        {
             JsonResponseModel<DescribeSuperPlayerConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSuperPlayerConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSuperPlayerConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
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
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
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
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近三天（72 小时）内的任务。
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
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近三天（72 小时）内的任务。
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
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public async Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public async Task<DescribeVodDomainsResponse> DescribeVodDomains(DescribeVodDomainsRequest req)
        {
             JsonResponseModel<DescribeVodDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVodDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVodDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询点播域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVodDomainsRequest"/></param>
        /// <returns><see cref="DescribeVodDomainsResponse"/></returns>
        public DescribeVodDomainsResponse DescribeVodDomainsSync(DescribeVodDomainsRequest req)
        {
             JsonResponseModel<DescribeVodDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVodDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVodDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public async Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public async Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
             JsonResponseModel<EditMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<EditMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云点播客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public async Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云点播客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 对媒体禁播后，除了点播控制台预览，其他场景访问视频各种资源的 URL（原始文件、转码输出文件、截图等）均会返回 403。
        ///   禁播/解禁操作全网生效时间约 5~10 分钟。
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public async Task<ForbidMediaDistributionResponse> ForbidMediaDistribution(ForbidMediaDistributionRequest req)
        {
             JsonResponseModel<ForbidMediaDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForbidMediaDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidMediaDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 对媒体禁播后，除了点播控制台预览，其他场景访问视频各种资源的 URL（原始文件、转码输出文件、截图等）均会返回 403。
        ///   禁播/解禁操作全网生效时间约 5~10 分钟。
        /// </summary>
        /// <param name="req"><see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns><see cref="ForbidMediaDistributionResponse"/></returns>
        public ForbidMediaDistributionResponse ForbidMediaDistributionSync(ForbidMediaDistributionRequest req)
        {
             JsonResponseModel<ForbidMediaDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForbidMediaDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForbidMediaDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// ### 剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与直播录制视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与直播录制的完整视频有效期是一致的。一旦直播录制出来的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="LiveRealTimeClipRequest"/></param>
        /// <returns><see cref="LiveRealTimeClipResponse"/></returns>
        public async Task<LiveRealTimeClipResponse> LiveRealTimeClip(LiveRealTimeClipRequest req)
        {
             JsonResponseModel<LiveRealTimeClipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LiveRealTimeClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LiveRealTimeClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<LiveRealTimeClipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LiveRealTimeClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LiveRealTimeClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public async Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public async Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public ModifyAIAnalysisTemplateResponse ModifyAIAnalysisTemplateSync(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public async Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体分类属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public async Task<ModifyClassResponse> ModifyClass(ModifyClassRequest req)
        {
             JsonResponseModel<ModifyClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体分类属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyClassRequest"/></param>
        /// <returns><see cref="ModifyClassResponse"/></returns>
        public ModifyClassResponse ModifyClassSync(ModifyClassRequest req)
        {
             JsonResponseModel<ModifyClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容智能识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public async Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义视频内容智能识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public async Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面、字幕信息等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public async Task<ModifyMediaInfoResponse> ModifyMediaInfo(ModifyMediaInfoRequest req)
        {
             JsonResponseModel<ModifyMediaInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面、字幕信息等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaInfoResponse"/></returns>
        public ModifyMediaInfoResponse ModifyMediaInfoSync(ModifyMediaInfoRequest req)
        {
             JsonResponseModel<ModifyMediaInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public async Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public async Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改子应用信息，但不允许修改主应用信息。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public async Task<ModifySubAppIdInfoResponse> ModifySubAppIdInfo(ModifySubAppIdInfoRequest req)
        {
             JsonResponseModel<ModifySubAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改子应用信息，但不允许修改主应用信息。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns><see cref="ModifySubAppIdInfoResponse"/></returns>
        public ModifySubAppIdInfoResponse ModifySubAppIdInfoSync(ModifySubAppIdInfoRequest req)
        {
             JsonResponseModel<ModifySubAppIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubAppIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于启用、停用子应用。被停用的子应用将封停对应域名，并限制控制台访问。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public async Task<ModifySubAppIdStatusResponse> ModifySubAppIdStatus(ModifySubAppIdStatusRequest req)
        {
             JsonResponseModel<ModifySubAppIdStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubAppIdStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于启用、停用子应用。被停用的子应用将封停对应域名，并限制控制台访问。
        /// </summary>
        /// <param name="req"><see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns><see cref="ModifySubAppIdStatusResponse"/></returns>
        public ModifySubAppIdStatusResponse ModifySubAppIdStatusSync(ModifySubAppIdStatusRequest req)
        {
             JsonResponseModel<ModifySubAppIdStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubAppIdStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubAppIdStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改超级播放器配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public async Task<ModifySuperPlayerConfigResponse> ModifySuperPlayerConfig(ModifySuperPlayerConfigRequest req)
        {
             JsonResponseModel<ModifySuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改超级播放器配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySuperPlayerConfigRequest"/></param>
        /// <returns><see cref="ModifySuperPlayerConfigResponse"/></returns>
        public ModifySuperPlayerConfigResponse ModifySuperPlayerConfigSync(ModifySuperPlayerConfigRequest req)
        {
             JsonResponseModel<ModifySuperPlayerConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySuperPlayerConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySuperPlayerConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public async Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public async Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public async Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传 HLS 视频时，解析索引文件内容，返回待上传的分片文件列表。分片文件路径必须是当前目录或子目录的相对路径，不能是 URL，不能是绝对路径。
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public async Task<ParseStreamingManifestResponse> ParseStreamingManifest(ParseStreamingManifestRequest req)
        {
             JsonResponseModel<ParseStreamingManifestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseStreamingManifest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseStreamingManifestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传 HLS 视频时，解析索引文件内容，返回待上传的分片文件列表。分片文件路径必须是当前目录或子目录的相对路径，不能是 URL，不能是绝对路径。
        /// </summary>
        /// <param name="req"><see cref="ParseStreamingManifestRequest"/></param>
        /// <returns><see cref="ParseStreamingManifestResponse"/></returns>
        public ParseStreamingManifestResponse ParseStreamingManifestSync(ParseStreamingManifestRequest req)
        {
             JsonResponseModel<ParseStreamingManifestResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseStreamingManifest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseStreamingManifestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对点播中的音视频媒体发起处理任务，功能包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频截取一张图做封面；
        /// 7. 对视频转自适应码流（并加密）；
        /// 8. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 9. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 10. 智能内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public async Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
             JsonResponseModel<ProcessMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对点播中的音视频媒体发起处理任务，功能包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频截取一张图做封面；
        /// 7. 对视频转自适应码流（并加密）；
        /// 8. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 9. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 10. 智能内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
             JsonResponseModel<ProcessMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用任务流模板，对点播中的视频发起处理任务。
        /// 有两种方式创建任务流模板：
        /// 1. 在控制台上创建和修改任务流模板；
        /// 2. 通过任务流模板接口创建任务流模板。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public async Task<ProcessMediaByProcedureResponse> ProcessMediaByProcedure(ProcessMediaByProcedureRequest req)
        {
             JsonResponseModel<ProcessMediaByProcedureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMediaByProcedure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByProcedureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用任务流模板，对点播中的视频发起处理任务。
        /// 有两种方式创建任务流模板：
        /// 1. 在控制台上创建和修改任务流模板；
        /// 2. 通过任务流模板接口创建任务流模板。
        /// 
        /// 如使用事件通知，事件通知的类型为 [任务流状态变更](https://cloud.tencent.com/document/product/266/9636)。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns><see cref="ProcessMediaByProcedureResponse"/></returns>
        public ProcessMediaByProcedureResponse ProcessMediaByProcedureSync(ProcessMediaByProcedureRequest req)
        {
             JsonResponseModel<ProcessMediaByProcedureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMediaByProcedure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByProcedureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，请使用 MPS 产品的 [ProcessMedia](https://cloud.tencent.com/document/product/862/37578) 接口，在入参 InputInfo.UrlInputInfo.Url 中指定视频 URL。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public async Task<ProcessMediaByUrlResponse> ProcessMediaByUrl(ProcessMediaByUrlRequest req)
        {
             JsonResponseModel<ProcessMediaByUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMediaByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该 API 已经<font color='red'>不再维护</font>，请使用 MPS 产品的 [ProcessMedia](https://cloud.tencent.com/document/product/862/37578) 接口，在入参 InputInfo.UrlInputInfo.Url 中指定视频 URL。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns><see cref="ProcessMediaByUrlResponse"/></returns>
        public ProcessMediaByUrlResponse ProcessMediaByUrlSync(ProcessMediaByUrlRequest req)
        {
             JsonResponseModel<ProcessMediaByUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMediaByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于业务服务器以 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 的方式获取事件通知；
        /// * 接口为长轮询模式，即：如果服务端存在未消费事件，则立即返回给请求方；如果服务端没有未消费事件，则后台会将请求挂起，直到有新的事件产生为止；
        /// * 请求最多挂起5秒，建议请求方将超时时间设置为10秒；
        /// * 未被拉取的事件通知最多保留4天，超过该时限的事件通知可能会被清除；
        /// * 若该接口有事件返回，调用方必须在<font color="red">30秒</font>内调用 [确认事件通知](https://cloud.tencent.com/document/product/266/33434) 接口，确认事件通知已经处理，否则该事件通知在<font color="red">30秒</font>后会再次被拉取到。
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public async Task<PullEventsResponse> PullEvents(PullEventsRequest req)
        {
             JsonResponseModel<PullEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于业务服务器以 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 的方式获取事件通知；
        /// * 接口为长轮询模式，即：如果服务端存在未消费事件，则立即返回给请求方；如果服务端没有未消费事件，则后台会将请求挂起，直到有新的事件产生为止；
        /// * 请求最多挂起5秒，建议请求方将超时时间设置为10秒；
        /// * 未被拉取的事件通知最多保留4天，超过该时限的事件通知可能会被清除；
        /// * 若该接口有事件返回，调用方必须在<font color="red">30秒</font>内调用 [确认事件通知](https://cloud.tencent.com/document/product/266/33434) 接口，确认事件通知已经处理，否则该事件通知在<font color="red">30秒</font>后会再次被拉取到。
        /// </summary>
        /// <param name="req"><see cref="PullEventsRequest"/></param>
        /// <returns><see cref="PullEventsResponse"/></returns>
        public PullEventsResponse PullEventsSync(PullEventsRequest req)
        {
             JsonResponseModel<PullEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于将一个网络上的视频拉取到云点播平台。
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public async Task<PullUploadResponse> PullUpload(PullUploadRequest req)
        {
             JsonResponseModel<PullUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于将一个网络上的视频拉取到云点播平台。
        /// </summary>
        /// <param name="req"><see cref="PullUploadRequest"/></param>
        /// <returns><see cref="PullUploadResponse"/></returns>
        public PullUploadResponse PullUploadSync(PullUploadRequest req)
        {
             JsonResponseModel<PullUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PullUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 预热指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public async Task<PushUrlCacheResponse> PushUrlCache(PushUrlCacheRequest req)
        {
             JsonResponseModel<PushUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 预热指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// </summary>
        /// <param name="req"><see cref="PushUrlCacheRequest"/></param>
        /// <returns><see cref="PushUrlCacheResponse"/></returns>
        public PushUrlCacheResponse PushUrlCacheSync(PushUrlCacheRequest req)
        {
             JsonResponseModel<PushUrlCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新设置用户自定义任务流模板的内容。  
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public async Task<ResetProcedureTemplateResponse> ResetProcedureTemplate(ResetProcedureTemplateRequest req)
        {
             JsonResponseModel<ResetProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新设置用户自定义任务流模板的内容。  
        /// </summary>
        /// <param name="req"><see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns><see cref="ResetProcedureTemplateResponse"/></returns>
        public ResetProcedureTemplateResponse ResetProcedureTemplateSync(ResetProcedureTemplateRequest req)
        {
             JsonResponseModel<ResetProcedureTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetProcedureTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetProcedureTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// - 指定直播推流码集合 StreamIds（见输入参数）筛选直播录制的媒体。
        /// - 指定视频 ID 集合 Vids （见输入参数）筛选直播录制的媒体。
        /// - 指定媒体的创建时间范围筛选媒体。
        /// - （不推荐：应使用 Names、NamePrefixes 或 Descriptions 替代）指定单个文本 Text 对媒体文件名或描述信息进行模糊搜索。
        /// - （不推荐：应使用 SourceTypes 替代）指定单个媒体文件来源 SourceType 进行搜索。
        /// - （不推荐：应使用 StreamIds 替代）指定单个推流直播码 StreamId 进行搜索。
        /// - （不推荐：应使用 Vids 替代）指定单个视频 ID Vid 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个起始创建时间 StartTime 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个结尾创建时间 EndTime 进行搜索。
        /// - 以上参数之间可以任意组合进行检索。例如：筛选创建时间在2018年12月1日12:00:00到2018年12月8日12:00:00之间、分类为电影或电视剧、带有宫斗和悬疑标签的媒体。注意，任何支持数组输入的参数，其元素之间的搜索逻辑为‘或’。所有参数之间的逻辑关系为‘与’。
        /// 
        /// - 允许对结果根据创建时间进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
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
        /// <div id="maxResultsDesc">接口返回结果数限制：</div>
        /// - <b><a href="#p_offset">Offset</a> 和 <a href="#p_limit">Limit</a> 两个参数影响单次分页查询结果数。特别注意：当这2个值都缺省时，本接口最多只返回10条查询结果。</b>
        /// - <b>最大支持返回5000条搜索结果，超出部分不再支持查询。如果搜索结果量太大，建议使用更精细的筛选条件来减少搜索结果。</b>
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public async Task<SearchMediaResponse> SearchMedia(SearchMediaRequest req)
        {
             JsonResponseModel<SearchMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// - 指定直播推流码集合 StreamIds（见输入参数）筛选直播录制的媒体。
        /// - 指定视频 ID 集合 Vids （见输入参数）筛选直播录制的媒体。
        /// - 指定媒体的创建时间范围筛选媒体。
        /// - （不推荐：应使用 Names、NamePrefixes 或 Descriptions 替代）指定单个文本 Text 对媒体文件名或描述信息进行模糊搜索。
        /// - （不推荐：应使用 SourceTypes 替代）指定单个媒体文件来源 SourceType 进行搜索。
        /// - （不推荐：应使用 StreamIds 替代）指定单个推流直播码 StreamId 进行搜索。
        /// - （不推荐：应使用 Vids 替代）指定单个视频 ID Vid 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个起始创建时间 StartTime 进行搜索。
        /// - （不推荐：应使用 CreateTime 替代）指定单个结尾创建时间 EndTime 进行搜索。
        /// - 以上参数之间可以任意组合进行检索。例如：筛选创建时间在2018年12月1日12:00:00到2018年12月8日12:00:00之间、分类为电影或电视剧、带有宫斗和悬疑标签的媒体。注意，任何支持数组输入的参数，其元素之间的搜索逻辑为‘或’。所有参数之间的逻辑关系为‘与’。
        /// 
        /// - 允许对结果根据创建时间进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
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
        /// <div id="maxResultsDesc">接口返回结果数限制：</div>
        /// - <b><a href="#p_offset">Offset</a> 和 <a href="#p_limit">Limit</a> 两个参数影响单次分页查询结果数。特别注意：当这2个值都缺省时，本接口最多只返回10条查询结果。</b>
        /// - <b>最大支持返回5000条搜索结果，超出部分不再支持查询。如果搜索结果量太大，建议使用更精细的筛选条件来减少搜索结果。</b>
        /// </summary>
        /// <param name="req"><see cref="SearchMediaRequest"/></param>
        /// <returns><see cref="SearchMediaResponse"/></returns>
        public SearchMediaResponse SearchMediaSync(SearchMediaRequest req)
        {
             JsonResponseModel<SearchMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 HLS 视频进行按时间段裁剪，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段长久保存的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于输入文件，没有独立 FileId；适用于将精彩片段临时分享的场景。
        /// 
        /// 注意：
        /// - 剪辑是基于输入 m3u8 文件进行的，故而其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// 
        /// 
        /// ###剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始输入视频影响（即使原始输入视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始输入视频相互独立，可以独立管理、长久保存。
        /// 
        /// ###剪辑不固化
        /// 所谓剪辑不固化，是指剪辑所得到的结果（m3u8 文件）与原始输入视频共享相同的 ts 分片，新生成的视频不是一个独立完整的视频（没有独立 FileId，只有播放 URL），其有效期与原始输入的完整视频有效期是一致的。一旦原始输入的视频被删除，也会导致该片段无法播放。
        /// 
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（例如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req"><see cref="SimpleHlsClipRequest"/></param>
        /// <returns><see cref="SimpleHlsClipResponse"/></returns>
        public async Task<SimpleHlsClipResponse> SimpleHlsClip(SimpleHlsClipRequest req)
        {
             JsonResponseModel<SimpleHlsClipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SimpleHlsClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimpleHlsClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 HLS 视频进行按时间段裁剪，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段长久保存的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于输入文件，没有独立 FileId；适用于将精彩片段临时分享的场景。
        /// 
        /// 注意：
        /// - 剪辑是基于输入 m3u8 文件进行的，故而其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// 
        /// 
        /// ###剪辑固化
        /// 所谓剪辑固化，是指将剪辑出来的视频保存成一个独立的视频（拥有独立的 FileId）。其生命周期不受原始输入视频影响（即使原始输入视频被删除，剪辑结果也不会受到任何影响）；也可以对其进行转码、微信发布等二次处理。
        /// 
        /// 举例如下：一场完整的足球比赛，原始视频可能长达 2 个小时，客户出于节省成本的目的可以对这个视频存储 2 个月，但对于剪辑的「精彩时刻」视频却可以指定存储更长时间，同时可以单独对「精彩时刻」视频进行转码、微信发布等额外的点播操作，这时候可以选择剪辑并且固化的方案。
        /// 
        /// 剪辑固化的优势在于其生命周期与原始输入视频相互独立，可以独立管理、长久保存。
        /// 
        /// ###剪辑不固化
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
             JsonResponseModel<SimpleHlsClipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SimpleHlsClip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimpleHlsClipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对点播视频进行拆条，生成多个新的点播视频。
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public async Task<SplitMediaResponse> SplitMedia(SplitMediaRequest req)
        {
             JsonResponseModel<SplitMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SplitMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对点播视频进行拆条，生成多个新的点播视频。
        /// </summary>
        /// <param name="req"><see cref="SplitMediaRequest"/></param>
        /// <returns><see cref="SplitMediaResponse"/></returns>
        public SplitMediaResponse SplitMediaSync(SplitMediaRequest req)
        {
             JsonResponseModel<SplitMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SplitMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将点播视频发布到微信小程序，供微信小程序播放器播放。
        /// </summary>
        /// <param name="req"><see cref="WeChatMiniProgramPublishRequest"/></param>
        /// <returns><see cref="WeChatMiniProgramPublishResponse"/></returns>
        public async Task<WeChatMiniProgramPublishResponse> WeChatMiniProgramPublish(WeChatMiniProgramPublishRequest req)
        {
             JsonResponseModel<WeChatMiniProgramPublishResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WeChatMiniProgramPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WeChatMiniProgramPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将点播视频发布到微信小程序，供微信小程序播放器播放。
        /// </summary>
        /// <param name="req"><see cref="WeChatMiniProgramPublishRequest"/></param>
        /// <returns><see cref="WeChatMiniProgramPublishResponse"/></returns>
        public WeChatMiniProgramPublishResponse WeChatMiniProgramPublishSync(WeChatMiniProgramPublishRequest req)
        {
             JsonResponseModel<WeChatMiniProgramPublishResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WeChatMiniProgramPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WeChatMiniProgramPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
