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

namespace TencentCloud.Cms.V20190321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cms.V20190321.Models;

   public class CmsClient : AbstractClient{

       private const string endpoint = "cms.tencentcloudapi.com";
       private const string version = "2019-03-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 广交会商品企业信息发布内容审核
        /// </summary>
        /// <param name="req"><see cref="CommonMediaRecognitionRequest"/></param>
        /// <returns><see cref="CommonMediaRecognitionResponse"/></returns>
        public async Task<CommonMediaRecognitionResponse> CommonMediaRecognition(CommonMediaRecognitionRequest req)
        {
             JsonResponseModel<CommonMediaRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommonMediaRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommonMediaRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 广交会商品企业信息发布内容审核
        /// </summary>
        /// <param name="req"><see cref="CommonMediaRecognitionRequest"/></param>
        /// <returns><see cref="CommonMediaRecognitionResponse"/></returns>
        public CommonMediaRecognitionResponse CommonMediaRecognitionSync(CommonMediaRecognitionRequest req)
        {
             JsonResponseModel<CommonMediaRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommonMediaRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommonMediaRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 通过该接口可以将图片新增到样本库。
        /// </summary>
        /// <param name="req"><see cref="CreateFileSampleRequest"/></param>
        /// <returns><see cref="CreateFileSampleResponse"/></returns>
        public async Task<CreateFileSampleResponse> CreateFileSample(CreateFileSampleRequest req)
        {
             JsonResponseModel<CreateFileSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 通过该接口可以将图片新增到样本库。
        /// </summary>
        /// <param name="req"><see cref="CreateFileSampleRequest"/></param>
        /// <returns><see cref="CreateFileSampleResponse"/></returns>
        public CreateFileSampleResponse CreateFileSampleSync(CreateFileSampleRequest req)
        {
             JsonResponseModel<CreateFileSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 通过该接口可以将文本新增到样本库。
        /// </summary>
        /// <param name="req"><see cref="CreateTextSampleRequest"/></param>
        /// <returns><see cref="CreateTextSampleResponse"/></returns>
        public async Task<CreateTextSampleResponse> CreateTextSample(CreateTextSampleRequest req)
        {
             JsonResponseModel<CreateTextSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 通过该接口可以将文本新增到样本库。
        /// </summary>
        /// <param name="req"><see cref="CreateTextSampleRequest"/></param>
        /// <returns><see cref="CreateTextSampleResponse"/></returns>
        public CreateTextSampleResponse CreateTextSampleSync(CreateTextSampleRequest req)
        {
             JsonResponseModel<CreateTextSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 删除图片样本库，支持批量删除，一次提交不超过20个。
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSampleRequest"/></param>
        /// <returns><see cref="DeleteFileSampleResponse"/></returns>
        public async Task<DeleteFileSampleResponse> DeleteFileSample(DeleteFileSampleRequest req)
        {
             JsonResponseModel<DeleteFileSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 删除图片样本库，支持批量删除，一次提交不超过20个。
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSampleRequest"/></param>
        /// <returns><see cref="DeleteFileSampleResponse"/></returns>
        public DeleteFileSampleResponse DeleteFileSampleSync(DeleteFileSampleRequest req)
        {
             JsonResponseModel<DeleteFileSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 删除文本样本库，暂时只支持单个删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTextSampleRequest"/></param>
        /// <returns><see cref="DeleteTextSampleResponse"/></returns>
        public async Task<DeleteTextSampleResponse> DeleteTextSample(DeleteTextSampleRequest req)
        {
             JsonResponseModel<DeleteTextSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 删除文本样本库，暂时只支持单个删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTextSampleRequest"/></param>
        /// <returns><see cref="DeleteTextSampleResponse"/></returns>
        public DeleteTextSampleResponse DeleteTextSampleSync(DeleteTextSampleRequest req)
        {
             JsonResponseModel<DeleteTextSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 查询图片样本库，支持批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSampleRequest"/></param>
        /// <returns><see cref="DescribeFileSampleResponse"/></returns>
        public async Task<DescribeFileSampleResponse> DescribeFileSample(DescribeFileSampleRequest req)
        {
             JsonResponseModel<DescribeFileSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于图片内容安全、视频内容安全自定义识别库的管理。
        /// <br>
        /// 查询图片样本库，支持批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSampleRequest"/></param>
        /// <returns><see cref="DescribeFileSampleResponse"/></returns>
        public DescribeFileSampleResponse DescribeFileSampleSync(DescribeFileSampleRequest req)
        {
             JsonResponseModel<DescribeFileSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 支持批量查询文本样本库。
        /// </summary>
        /// <param name="req"><see cref="DescribeTextSampleRequest"/></param>
        /// <returns><see cref="DescribeTextSampleResponse"/></returns>
        public async Task<DescribeTextSampleResponse> DescribeTextSample(DescribeTextSampleRequest req)
        {
             JsonResponseModel<DescribeTextSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本文档适用于文本内容安全、音频内容安全自定义识别库的管理。
        /// <br>
        /// 支持批量查询文本样本库。
        /// </summary>
        /// <param name="req"><see cref="DescribeTextSampleRequest"/></param>
        /// <returns><see cref="DescribeTextSampleResponse"/></returns>
        public DescribeTextSampleResponse DescribeTextSampleSync(DescribeTextSampleRequest req)
        {
             JsonResponseModel<DescribeTextSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTextSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public async Task<ImageModerationResponse> ImageModeration(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public ImageModerationResponse ImageModerationSync(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public async Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
             JsonResponseModel<TextModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public TextModerationResponse TextModerationSync(TextModerationRequest req)
        {
             JsonResponseModel<TextModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
