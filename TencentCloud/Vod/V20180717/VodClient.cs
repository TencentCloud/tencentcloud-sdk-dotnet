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
        /// ApplyUpload接口的同步版本，* 该接口用于申请媒体文件（和封面文件）的上传，获取文件上传到云点播的元信息（包括上传路径、上传签名等），用于后续上传接口。
        /// * 上传流程请参考 [服务端上传综述](/document/product/266/9759)。
        /// </summary>
        /// <param name="req">参考<see cref="ApplyUploadRequest"/></param>
        /// <returns>参考<see cref="ApplyUploadResponse"/>实例</returns>
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
        /// CommitUpload接口的同步版本，该接口用于确认媒体文件（和封面文件）上传到腾讯云点播的结果，并存储媒体信息，返回文件的播放地址和文件 ID。
        /// </summary>
        /// <param name="req">参考<see cref="CommitUploadRequest"/></param>
        /// <returns>参考<see cref="CommitUploadResponse"/>实例</returns>
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
        /// 3. 对多个媒体文件的媒体流进行裁剪拼接，生成一个新的媒体文件；
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
        /// ComposeMedia接口的同步版本，该接口用于制作媒体文件，可以
        /// 
        /// 1. 对一个媒体文件进行剪辑，生成一个新的媒体文件；
        /// 2. 对多个媒体文件进行裁剪拼接，生成一个新的媒体文件；
        /// 3. 对多个媒体文件的媒体流进行裁剪拼接，生成一个新的媒体文件；
        /// </summary>
        /// <param name="req">参考<see cref="ComposeMediaRequest"/></param>
        /// <returns>参考<see cref="ComposeMediaResponse"/>实例</returns>
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
        /// ConfirmEvents接口的同步版本，* 开发者调用拉取事件通知，获取到事件后，必须调用该接口来确认消息已经收到；
        /// * 开发者获取到事件句柄后，等待确认的有效时间为 30 秒，超出 30 秒会报参数错误（4000）；
        /// * 更多参考事件通知的[可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83)。
        /// </summary>
        /// <param name="req">参考<see cref="ConfirmEventsRequest"/></param>
        /// <returns>参考<see cref="ConfirmEventsResponse"/>实例</returns>
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
        /// CreateAIAnalysisTemplate接口的同步版本，创建用户自定义视频内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAIAnalysisTemplateResponse"/>实例</returns>
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
        /// CreateAIRecognitionTemplate接口的同步版本，创建用户自定义视频内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAIRecognitionTemplateResponse"/>实例</returns>
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
        /// CreateAnimatedGraphicsTemplate接口的同步版本，创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateAnimatedGraphicsTemplateResponse"/>实例</returns>
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
        /// CreateClass接口的同步版本，* 用于对媒体进行分类管理；
        /// * 该接口不影响既有媒体的分类，如需修改媒体分类，请调用[修改媒体文件属性](/document/product/266/31762)接口。
        /// * 分类层次不可超过 4 层。
        /// * 每个分类的子类数量不可超过 500 个。
        /// </summary>
        /// <param name="req">参考<see cref="CreateClassRequest"/></param>
        /// <returns>参考<see cref="CreateClassResponse"/>实例</returns>
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
        /// 创建用户自定义视频内容审核模板，数量上限：50。
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
        /// CreateContentReviewTemplate接口的同步版本，创建用户自定义视频内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateContentReviewTemplateResponse"/>实例</returns>
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
        /// CreateImageSpriteTemplate接口的同步版本，创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateImageSpriteTemplateResponse"/>实例</returns>
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
        /// 该接口用于创建人物样本，用于通过人脸识别等技术，进行内容识别、内容审核等视频处理。
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
        /// CreatePersonSample接口的同步版本，该接口用于创建人物样本，用于通过人脸识别等技术，进行内容识别、内容审核等视频处理。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonSampleRequest"/></param>
        /// <returns>参考<see cref="CreatePersonSampleResponse"/>实例</returns>
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
        /// CreateProcedureTemplate接口的同步版本，创建用户自定义的任务流模板，模板上限：50。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProcedureTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateProcedureTemplateResponse"/>实例</returns>
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
        /// CreateSampleSnapshotTemplate接口的同步版本，创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateSampleSnapshotTemplateResponse"/>实例</returns>
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
        /// CreateSnapshotByTimeOffsetTemplate接口的同步版本，创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateSnapshotByTimeOffsetTemplateResponse"/>实例</returns>
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
        /// CreateTranscodeTemplate接口的同步版本，创建用户自定义转码模板，数量上限：100。
        /// </summary>
        /// <param name="req">参考<see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateTranscodeTemplateResponse"/>实例</returns>
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
        /// CreateWatermarkTemplate接口的同步版本，创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req">参考<see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateWatermarkTemplateResponse"/>实例</returns>
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
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行内容审核、内容识别等视频处理。
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
        /// CreateWordSamples接口的同步版本，该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行内容审核、内容识别等视频处理。
        /// </summary>
        /// <param name="req">参考<see cref="CreateWordSamplesRequest"/></param>
        /// <returns>参考<see cref="CreateWordSamplesResponse"/>实例</returns>
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
        /// DeleteAIAnalysisTemplate接口的同步版本，删除用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAIAnalysisTemplateResponse"/>实例</returns>
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
        /// DeleteAIRecognitionTemplate接口的同步版本，删除用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAIRecognitionTemplateResponse"/>实例</returns>
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
        /// DeleteAnimatedGraphicsTemplate接口的同步版本，删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteAnimatedGraphicsTemplateResponse"/>实例</returns>
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
        /// DeleteClass接口的同步版本，* 仅当待删分类无子分类且无媒体关联情况下，可删除分类；
        /// * 否则，请先执行[删除媒体](/document/product/266/31764)及子分类，再删除该分类；
        /// </summary>
        /// <param name="req">参考<see cref="DeleteClassRequest"/></param>
        /// <returns>参考<see cref="DeleteClassResponse"/>实例</returns>
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
        /// 删除用户自定义视频内容审核模板。
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
        /// DeleteContentReviewTemplate接口的同步版本，删除用户自定义视频内容审核模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteContentReviewTemplateResponse"/>实例</returns>
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
        /// DeleteImageSpriteTemplate接口的同步版本，删除雪碧图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteImageSpriteTemplateResponse"/>实例</returns>
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
        /// DeleteMedia接口的同步版本，* 删除媒体及其对应的视频处理文件（如转码视频、雪碧图、截图、微信发布视频等）；
        /// * 可单独删除指定 ID 的视频文件下的转码，或者微信发布文件；
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMediaRequest"/></param>
        /// <returns>参考<see cref="DeleteMediaResponse"/>实例</returns>
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
        /// 该接口用于根据人物 ID，删除人物样本。
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
        /// DeletePersonSample接口的同步版本，该接口用于根据人物 ID，删除人物样本。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonSampleRequest"/></param>
        /// <returns>参考<see cref="DeletePersonSampleResponse"/>实例</returns>
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
        /// DeleteProcedureTemplate接口的同步版本，删除用户自定义的任务流模板。  
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProcedureTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteProcedureTemplateResponse"/>实例</returns>
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
        /// DeleteSampleSnapshotTemplate接口的同步版本，删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteSampleSnapshotTemplateResponse"/>实例</returns>
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
        /// DeleteSnapshotByTimeOffsetTemplate接口的同步版本，删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/>实例</returns>
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
        /// DeleteTranscodeTemplate接口的同步版本，删除用户自定义转码模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteTranscodeTemplateResponse"/>实例</returns>
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
        /// DeleteWatermarkTemplate接口的同步版本，删除用户自定义水印模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteWatermarkTemplateResponse"/>实例</returns>
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
        /// DeleteWordSamples接口的同步版本，该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteWordSamplesRequest"/></param>
        /// <returns>参考<see cref="DeleteWordSamplesResponse"/>实例</returns>
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
        /// DescribeAIAnalysisTemplates接口的同步版本，根据视频内容分析模板唯一标识，获取视频内容分析模板详情列表。返回结果包含符合条件的所有用户自定义视频内容分析模板及[系统预置视频内容分析模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.88.86.E6.9E.90.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAIAnalysisTemplatesResponse"/>实例</returns>
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
        /// DescribeAIRecognitionTemplates接口的同步版本，根据视频内容识别模板唯一标识，获取视频内容识别模板详情列表。返回结果包含符合条件的所有用户自定义视频内容识别模板及[系统预置视频内容识别模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E8.AF.86.E5.88.AB.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAIRecognitionTemplatesResponse"/>实例</returns>
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
        /// DescribeAdaptiveDynamicStreamingTemplates接口的同步版本，查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/>实例</returns>
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
        /// DescribeAllClass接口的同步版本，* 获得用户的所有分类信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAllClassRequest"/></param>
        /// <returns>参考<see cref="DescribeAllClassResponse"/>实例</returns>
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
        /// DescribeAnimatedGraphicsTemplates接口的同步版本，查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAnimatedGraphicsTemplatesResponse"/>实例</returns>
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
        /// 获取转自适应码流音频轨模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAudioTrackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAudioTrackTemplatesResponse"/></returns>
        public async Task<DescribeAudioTrackTemplatesResponse> DescribeAudioTrackTemplates(DescribeAudioTrackTemplatesRequest req)
        {
             JsonResponseModel<DescribeAudioTrackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAudioTrackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAudioTrackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAudioTrackTemplates接口的同步版本，获取转自适应码流音频轨模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAudioTrackTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeAudioTrackTemplatesResponse"/>实例</returns>
        public DescribeAudioTrackTemplatesResponse DescribeAudioTrackTemplatesSync(DescribeAudioTrackTemplatesRequest req)
        {
             JsonResponseModel<DescribeAudioTrackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAudioTrackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAudioTrackTemplatesResponse>>(strResp);
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
        /// DescribeCDNUsageData接口的同步版本，该接口用于查询点播 CDN 的流量、带宽等统计数据。
        ///    1. 可以查询最近365天内的 CDN 用量数据。
        ///    2.  查询时间跨度不超过90天。
        ///    3. 可以指定用量数据的时间粒度，支持5分钟、1小时、1天的时间粒度。
        ///    4.  流量为查询时间粒度内的总流量，带宽为查询时间粒度内的峰值带宽。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCDNUsageDataRequest"/></param>
        /// <returns>参考<see cref="DescribeCDNUsageDataResponse"/>实例</returns>
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
        /// 根据视频内容审核模板唯一标识，获取视频内容审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容审核模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
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
        /// DescribeContentReviewTemplates接口的同步版本，根据视频内容审核模板唯一标识，获取视频内容审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置内容审核模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.A7.86.E9.A2.91.E5.86.85.E5.AE.B9.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeContentReviewTemplatesResponse"/>实例</returns>
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
        /// DescribeImageSpriteTemplates接口的同步版本，查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeImageSpriteTemplatesResponse"/>实例</returns>
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
        /// DescribeMediaInfos接口的同步版本，1. 该接口可以获取多个媒体文件的多种信息，包括：
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
        /// <param name="req">参考<see cref="DescribeMediaInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeMediaInfosResponse"/>实例</returns>
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
        /// 该接口用于查询人物样本信息，支持根据人物 ID、名称、标签，分页查询。
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
        /// DescribePersonSamples接口的同步版本，该接口用于查询人物样本信息，支持根据人物 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonSamplesRequest"/></param>
        /// <returns>参考<see cref="DescribePersonSamplesResponse"/>实例</returns>
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
        /// DescribeProcedureTemplates接口的同步版本，根据任务流模板名字，获取任务流模板详情列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProcedureTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeProcedureTemplatesResponse"/>实例</returns>
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
        /// 该接口返回查询时间范围内每天使用的视频内容审核时长数据，单位： 秒。
        /// 
        /// 1. 可以查询最近365天内的视频内容审核时长统计数据。
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
        /// DescribeReviewDetails接口的同步版本，该接口返回查询时间范围内每天使用的视频内容审核时长数据，单位： 秒。
        /// 
        /// 1. 可以查询最近365天内的视频内容审核时长统计数据。
        /// 2. 查询时间跨度不超过90天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeReviewDetailsRequest"/></param>
        /// <returns>参考<see cref="DescribeReviewDetailsResponse"/>实例</returns>
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
        /// DescribeSampleSnapshotTemplates接口的同步版本，查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeSampleSnapshotTemplatesResponse"/>实例</returns>
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
        /// DescribeSnapshotByTimeOffsetTemplates接口的同步版本，查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/>实例</returns>
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
        /// DescribeSubAppIds接口的同步版本，该接口用于获取当前账号有权限的子应用列表，包含主应用。若尚未开通子应用功能，接口将返回 
        ///  FailedOperation。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubAppIdsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubAppIdsResponse"/>实例</returns>
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
        /// DescribeTaskDetail接口的同步版本，通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskDetailResponse"/>实例</returns>
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
        /// DescribeTasks接口的同步版本，* 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近三天（72 小时）内的任务。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
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
        /// DescribeTranscodeTemplates接口的同步版本，根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeTranscodeTemplatesResponse"/>实例</returns>
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
        /// 获取转自适应码流视频轨模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTrackTemplatesRequest"/></param>
        /// <returns><see cref="DescribeVideoTrackTemplatesResponse"/></returns>
        public async Task<DescribeVideoTrackTemplatesResponse> DescribeVideoTrackTemplates(DescribeVideoTrackTemplatesRequest req)
        {
             JsonResponseModel<DescribeVideoTrackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoTrackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoTrackTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeVideoTrackTemplates接口的同步版本，获取转自适应码流视频轨模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVideoTrackTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeVideoTrackTemplatesResponse"/>实例</returns>
        public DescribeVideoTrackTemplatesResponse DescribeVideoTrackTemplatesSync(DescribeVideoTrackTemplatesRequest req)
        {
             JsonResponseModel<DescribeVideoTrackTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoTrackTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoTrackTemplatesResponse>>(strResp);
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
        /// DescribeWatermarkTemplates接口的同步版本，查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeWatermarkTemplatesResponse"/>实例</returns>
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
        /// DescribeWordSamples接口的同步版本，该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeWordSamplesRequest"/></param>
        /// <returns>参考<see cref="DescribeWordSamplesResponse"/>实例</returns>
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
        /// EditMedia接口的同步版本，对视频进行编辑（剪辑、拼接等），生成一个新的点播视频。编辑的功能包括：
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
        /// </summary>
        /// <param name="req">参考<see cref="EditMediaRequest"/></param>
        /// <returns>参考<see cref="EditMediaResponse"/>实例</returns>
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
        /// ExecuteFunction接口的同步版本，本接口仅用于定制开发的特殊场景，除非云点播客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req">参考<see cref="ExecuteFunctionRequest"/></param>
        /// <returns>参考<see cref="ExecuteFunctionResponse"/>实例</returns>
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
        /// ForbidMediaDistribution接口的同步版本，* 对媒体禁播后，除了点播控制台预览，其他场景访问视频各种资源的 URL（原始文件、转码输出文件、截图等）均会返回 403。
        ///   禁播/解禁操作全网生效时间约 5~10 分钟。
        /// </summary>
        /// <param name="req">参考<see cref="ForbidMediaDistributionRequest"/></param>
        /// <returns>参考<see cref="ForbidMediaDistributionResponse"/>实例</returns>
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
        /// 
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
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（比如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
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
        /// LiveRealTimeClip接口的同步版本，直播即时剪辑，是指在直播过程中（即直播尚未结束时），客户可以在过往直播内容中选择一段，实时生成一个新的视频（HLS 格式），开发者可以将其立即分享出去，或者长久保存起来。
        /// 
        /// 腾讯云点播支持两种即时剪辑模式：
        /// - 剪辑固化：将剪辑出来的视频保存成独立的视频，拥有独立 FileId；适用于将精彩片段**长久保存**的场景；
        /// - 剪辑不固化：剪辑得到的视频附属于直播录制文件，没有独立 FileId；适用于将精彩片段**临时分享**的场景。
        /// 
        /// 注意：
        /// - 使用直播即时剪辑功能的前提是：目标直播流开启了[时移回看](https://cloud.tencent.com/document/product/267/32742)功能。
        /// - 直播即时剪辑是基于直播录制生成的 m3u8 文件进行的，故而其最小剪辑精度为一个 ts 切片，无法实现秒级或者更为精确的剪辑精度。
        /// 
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
        /// 剪辑不固化，由于其剪辑结果不是一个独立的视频，因而也不会纳入点播媒资视频管理（比如控制台的视频总数不会统计这一片段）中，也无法单独针对这个片段做转码、微信发布等任何视频处理操作。
        /// 
        /// 剪辑不固化的优势在于其剪辑操作十分“轻量化”，不会产生额外的存储开销。但其不足之处在于生命周期与原始录制视频相同，且无法进一步进行转码等视频处理。
        /// </summary>
        /// <param name="req">参考<see cref="LiveRealTimeClipRequest"/></param>
        /// <returns>参考<see cref="LiveRealTimeClipResponse"/>实例</returns>
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
        /// ModifyAIAnalysisTemplate接口的同步版本，修改用户自定义视频内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyAIAnalysisTemplateResponse"/>实例</returns>
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
        /// ModifyAIRecognitionTemplate接口的同步版本，修改用户自定义视频内容识别模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyAIRecognitionTemplateResponse"/>实例</returns>
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
        /// ModifyAnimatedGraphicsTemplate接口的同步版本，修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyAnimatedGraphicsTemplateResponse"/>实例</returns>
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
        /// ModifyClass接口的同步版本，修改媒体分类属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyClassRequest"/></param>
        /// <returns>参考<see cref="ModifyClassResponse"/>实例</returns>
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
        /// 修改用户自定义视频内容审核模板。
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
        /// ModifyContentReviewTemplate接口的同步版本，修改用户自定义视频内容审核模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyContentReviewTemplateResponse"/>实例</returns>
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
        /// ModifyImageSpriteTemplate接口的同步版本，修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyImageSpriteTemplateResponse"/>实例</returns>
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
        /// 修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面等。
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
        /// ModifyMediaInfo接口的同步版本，修改媒体文件的属性，包括分类、名称、描述、标签、过期时间、打点信息、视频封面等。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMediaInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyMediaInfoResponse"/>实例</returns>
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
        /// 该接口用于根据人物 ID，修改人物样本信息，包括名称、描述的修改，以及人脸、标签的添加、删除、重置操作。人脸删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
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
        /// ModifyPersonSample接口的同步版本，该接口用于根据人物 ID，修改人物样本信息，包括名称、描述的修改，以及人脸、标签的添加、删除、重置操作。人脸删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonSampleRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonSampleResponse"/>实例</returns>
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
        /// ModifySampleSnapshotTemplate接口的同步版本，修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifySampleSnapshotTemplateResponse"/>实例</returns>
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
        /// ModifySnapshotByTimeOffsetTemplate接口的同步版本，修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifySnapshotByTimeOffsetTemplateResponse"/>实例</returns>
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
        /// ModifySubAppIdInfo接口的同步版本，该接口用于修改子应用信息，但不允许修改主应用信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubAppIdInfoRequest"/></param>
        /// <returns>参考<see cref="ModifySubAppIdInfoResponse"/>实例</returns>
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
        /// ModifySubAppIdStatus接口的同步版本，该接口用于启用、停用子应用。被停用的子应用将封停对应域名，并限制控制台访问。
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubAppIdStatusRequest"/></param>
        /// <returns>参考<see cref="ModifySubAppIdStatusResponse"/>实例</returns>
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
        /// ModifyTranscodeTemplate接口的同步版本，修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyTranscodeTemplateResponse"/>实例</returns>
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
        /// ModifyWatermarkTemplate接口的同步版本，修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyWatermarkTemplateResponse"/>实例</returns>
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
        /// ModifyWordSample接口的同步版本，该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyWordSampleRequest"/></param>
        /// <returns>参考<see cref="ModifyWordSampleResponse"/>实例</returns>
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
        /// ProcessMedia接口的同步版本，对点播中的音视频媒体发起处理任务，功能包括：
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
        /// </summary>
        /// <param name="req">参考<see cref="ProcessMediaRequest"/></param>
        /// <returns>参考<see cref="ProcessMediaResponse"/>实例</returns>
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
        /// ProcessMediaByProcedure接口的同步版本，使用任务流模板，对点播中的视频发起处理任务。
        /// 有两种方式创建任务流模板：
        /// 1. 在控制台上创建和修改任务流模板；
        /// 2. 通过任务流模板接口创建任务流模板。
        /// </summary>
        /// <param name="req">参考<see cref="ProcessMediaByProcedureRequest"/></param>
        /// <returns>参考<see cref="ProcessMediaByProcedureResponse"/>实例</returns>
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
        /// 对来源为 URL 的音视频媒体发起处理任务，功能包括：
        /// 
        /// 1. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 2. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 3. 智能内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
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
        /// ProcessMediaByUrl接口的同步版本，对来源为 URL 的音视频媒体发起处理任务，功能包括：
        /// 
        /// 1. 智能内容审核（鉴黄、鉴恐、鉴政）；
        /// 2. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 3. 智能内容识别（视频片头片尾、人脸、文本全文、文本关键词、语音全文、语音关键词、物体）。
        /// </summary>
        /// <param name="req">参考<see cref="ProcessMediaByUrlRequest"/></param>
        /// <returns>参考<see cref="ProcessMediaByUrlResponse"/>实例</returns>
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
        /// PullEvents接口的同步版本，* 该接口用于业务服务器以 [可靠回调](https://cloud.tencent.com/document/product/266/33779#.E5.8F.AF.E9.9D.A0.E5.9B.9E.E8.B0.83) 的方式获取事件通知；
        /// * 接口为长轮询模式，即：如果服务端存在未消费事件，则立即返回给请求方；如果服务端没有未消费事件，则后台会将请求挂起，直到有新的事件产生为止；
        /// * 请求最多挂起5秒，建议请求方将超时时间设置为10秒；
        /// * 若该接口有事件返回，调用方必须在<font color="red">30秒</font>内调用 [确认事件通知](https://cloud.tencent.com/document/product/266/33434) 接口，确认事件通知已经处理，否则该事件通知在<font color="red">30秒</font>后会再次被拉取到。
        /// </summary>
        /// <param name="req">参考<see cref="PullEventsRequest"/></param>
        /// <returns>参考<see cref="PullEventsResponse"/>实例</returns>
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
        /// PullUpload接口的同步版本，该接口用于将一个网络上的视频拉取到云点播平台。
        /// </summary>
        /// <param name="req">参考<see cref="PullUploadRequest"/></param>
        /// <returns>参考<see cref="PullUploadResponse"/>实例</returns>
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
        /// PushUrlCache接口的同步版本，1. 预热指定的 URL 列表。
        /// 2. URL 的域名必须已在云点播中注册。
        /// 3. 单次请求最多指定20个 URL。
        /// </summary>
        /// <param name="req">参考<see cref="PushUrlCacheRequest"/></param>
        /// <returns>参考<see cref="PushUrlCacheResponse"/>实例</returns>
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
        /// ResetProcedureTemplate接口的同步版本，重新设置用户自定义任务流模板的内容。  
        /// </summary>
        /// <param name="req">参考<see cref="ResetProcedureTemplateRequest"/></param>
        /// <returns>参考<see cref="ResetProcedureTemplateResponse"/>实例</returns>
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
        /// - 根据媒体文件名或描述信息进行模糊搜索。
        /// - 根据媒体分类、标签进行检索。
        ///     - 指定分类集合 ClassIds（见输入参数），返回满足集合中任意分类的媒体。例如：媒体分类有电影、电视剧、综艺，其中电影分类下又有子分类历史片、动作片、言情片。如果 ClassIds 指定了电影、电视剧，那么电影和电视剧下的所有子分类都会返回；而如果 ClassIds 指定的是历史片、动作片，那么只有这2个子分类下的媒体才会返回。
        ///     - 指定标签集合 Tags（见输入参数），返回满足集合中任意标签的媒体。例如：媒体标签有二次元、宫斗、鬼畜，如果 Tags 指定了二次元、鬼畜2个标签，那么只要符合这2个标签中任意一个的媒体都会被检索出来。
        /// - 允许指定筛选某一来源 Source（见输入参数）的媒体。
        /// - 允许根据直播推流码、Vid（见输入参数）筛选直播录制的媒体。
        /// - 允许根据媒体的创建范围筛选媒体。
        /// - 允许对上述条件进行任意组合，检索同时满足以上条件的媒体。例如：筛选创建时间在2018年12月1日到2018年12月8日之间、分类为电影、带有宫斗标签的媒体。
        /// - 允许对结果进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
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
        /// SearchMedia接口的同步版本，搜索媒体信息，支持多种条件筛选，以及支持对返回结果排序、过滤等功能，具体包括：
        /// - 根据媒体文件名或描述信息进行模糊搜索。
        /// - 根据媒体分类、标签进行检索。
        ///     - 指定分类集合 ClassIds（见输入参数），返回满足集合中任意分类的媒体。例如：媒体分类有电影、电视剧、综艺，其中电影分类下又有子分类历史片、动作片、言情片。如果 ClassIds 指定了电影、电视剧，那么电影和电视剧下的所有子分类都会返回；而如果 ClassIds 指定的是历史片、动作片，那么只有这2个子分类下的媒体才会返回。
        ///     - 指定标签集合 Tags（见输入参数），返回满足集合中任意标签的媒体。例如：媒体标签有二次元、宫斗、鬼畜，如果 Tags 指定了二次元、鬼畜2个标签，那么只要符合这2个标签中任意一个的媒体都会被检索出来。
        /// - 允许指定筛选某一来源 Source（见输入参数）的媒体。
        /// - 允许根据直播推流码、Vid（见输入参数）筛选直播录制的媒体。
        /// - 允许根据媒体的创建范围筛选媒体。
        /// - 允许对上述条件进行任意组合，检索同时满足以上条件的媒体。例如：筛选创建时间在2018年12月1日到2018年12月8日之间、分类为电影、带有宫斗标签的媒体。
        /// - 允许对结果进行排序并分页返回，通过 Offset 和 Limit （见输入参数）来控制分页。
        /// 
        /// <div id="maxResultsDesc">接口返回结果数限制：</div>
        /// - <b><a href="#p_offset">Offset</a> 和 <a href="#p_limit">Limit</a> 两个参数影响单次分页查询结果数。特别注意：当这2个值都缺省时，本接口最多只返回10条查询结果。</b>
        /// - <b>最大支持返回5000条搜索结果，超出部分不再支持查询。如果搜索结果量太大，建议使用更精细的筛选条件来减少搜索结果。</b>
        /// </summary>
        /// <param name="req">参考<see cref="SearchMediaRequest"/></param>
        /// <returns>参考<see cref="SearchMediaResponse"/>实例</returns>
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
        /// 对 HLS 视频进行按时间段裁剪。
        /// 
        /// 注意：裁剪出来的视频与原始视频共用 ts，仅生成新的 m3u8。原始视频删除后，该裁剪视频也会被删除。
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
        /// SimpleHlsClip接口的同步版本，对 HLS 视频进行按时间段裁剪。
        /// 
        /// 注意：裁剪出来的视频与原始视频共用 ts，仅生成新的 m3u8。原始视频删除后，该裁剪视频也会被删除。
        /// </summary>
        /// <param name="req">参考<see cref="SimpleHlsClipRequest"/></param>
        /// <returns>参考<see cref="SimpleHlsClipResponse"/>实例</returns>
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
        /// WeChatMiniProgramPublish接口的同步版本，将点播视频发布到微信小程序，供微信小程序播放器播放。
        /// </summary>
        /// <param name="req">参考<see cref="WeChatMiniProgramPublishRequest"/></param>
        /// <returns>参考<see cref="WeChatMiniProgramPublishResponse"/>实例</returns>
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
