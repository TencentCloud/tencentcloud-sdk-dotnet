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
        /// 音频内容检测（Audio Moderation, AM）服务使用了波形分析、声纹分析等技术，能识别涉黄、涉政、涉恐等违规音频，同时支持用户配置音频黑库，打击自定义的违规内容。
        /// 
        /// <br>
        /// 接口返回值说明：调用本接口有两个返回值，一个是同步返回值，一个是识别完成后的异步回调返回值。
        /// 
        /// 音频识别结果存在于异步回调返回值中，异步回调返回值明细：
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// SeqID | String | 请求seqId唯一标识
        /// EvilFlag | Integer | 是否恶意：0正常，1可疑（Homology模块下：0未匹配到，1恶意，2白样本）
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情，20007谩骂
        /// Duration | Integer | 音频时长（单位：毫秒）
        /// PornDetect | [AudioDetectData](#ADD) | 音频智能鉴黄
        /// PolityDetect | [AudioDetectData](#ADD)| 音频涉政识别
        /// CurseDetect | [AudioDetectData](#ADD) | 音频谩骂识别
        /// CustomizedDetect | [AudioDetectData](#ADD) | 自定义识别
        /// Homology | [AudioDetectData](#ADD) | 相似度识别
        /// 
        /// 
        /// <span id="ADD"> AudioDetectData </span>
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// HitFlag | Integer | 0正常，1可疑
        /// Score | Integer | 判断分值
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情，20007谩骂
        /// Keywords | Array of String | 关键词明细
        /// StartTime | Array of String | 恶意开始时间（Homology、CustomizedDetect无此字段）
        /// EndTime | Array of String | 恶意结束时间（Homology、CustomizedDetect无此字段）
        /// SeedUrl | String | 命中的种子URL
        /// </summary>
        /// <param name="req"><see cref="AudioModerationRequest"/></param>
        /// <returns><see cref="AudioModerationResponse"/></returns>
        public async Task<AudioModerationResponse> AudioModeration(AudioModerationRequest req)
        {
             JsonResponseModel<AudioModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AudioModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AudioModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AudioModeration接口的同步版本，音频内容检测（Audio Moderation, AM）服务使用了波形分析、声纹分析等技术，能识别涉黄、涉政、涉恐等违规音频，同时支持用户配置音频黑库，打击自定义的违规内容。
        /// 
        /// <br>
        /// 接口返回值说明：调用本接口有两个返回值，一个是同步返回值，一个是识别完成后的异步回调返回值。
        /// 
        /// 音频识别结果存在于异步回调返回值中，异步回调返回值明细：
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// SeqID | String | 请求seqId唯一标识
        /// EvilFlag | Integer | 是否恶意：0正常，1可疑（Homology模块下：0未匹配到，1恶意，2白样本）
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情，20007谩骂
        /// Duration | Integer | 音频时长（单位：毫秒）
        /// PornDetect | [AudioDetectData](#ADD) | 音频智能鉴黄
        /// PolityDetect | [AudioDetectData](#ADD)| 音频涉政识别
        /// CurseDetect | [AudioDetectData](#ADD) | 音频谩骂识别
        /// CustomizedDetect | [AudioDetectData](#ADD) | 自定义识别
        /// Homology | [AudioDetectData](#ADD) | 相似度识别
        /// 
        /// 
        /// <span id="ADD"> AudioDetectData </span>
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// HitFlag | Integer | 0正常，1可疑
        /// Score | Integer | 判断分值
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情，20007谩骂
        /// Keywords | Array of String | 关键词明细
        /// StartTime | Array of String | 恶意开始时间（Homology、CustomizedDetect无此字段）
        /// EndTime | Array of String | 恶意结束时间（Homology、CustomizedDetect无此字段）
        /// SeedUrl | String | 命中的种子URL
        /// </summary>
        /// <param name="req">参考<see cref="AudioModerationRequest"/></param>
        /// <returns>参考<see cref="AudioModerationResponse"/>实例</returns>
        public AudioModerationResponse AudioModerationSync(AudioModerationRequest req)
        {
             JsonResponseModel<AudioModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AudioModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AudioModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口可以将文件新增到样本库
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
        /// CreateFileSample接口的同步版本，通过该接口可以将文件新增到样本库
        /// </summary>
        /// <param name="req">参考<see cref="CreateFileSampleRequest"/></param>
        /// <returns>参考<see cref="CreateFileSampleResponse"/>实例</returns>
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
        /// 新增文本类型样本库
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
        /// CreateTextSample接口的同步版本，新增文本类型样本库
        /// </summary>
        /// <param name="req">参考<see cref="CreateTextSampleRequest"/></param>
        /// <returns>参考<see cref="CreateTextSampleResponse"/>实例</returns>
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
        /// 删除文件样本库，支持批量删除，一次提交不超过20个
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
        /// DeleteFileSample接口的同步版本，删除文件样本库，支持批量删除，一次提交不超过20个
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFileSampleRequest"/></param>
        /// <returns>参考<see cref="DeleteFileSampleResponse"/>实例</returns>
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
        /// 删除文字样本库，暂时只支持单个删除
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
        /// DeleteTextSample接口的同步版本，删除文字样本库，暂时只支持单个删除
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTextSampleRequest"/></param>
        /// <returns>参考<see cref="DeleteTextSampleResponse"/>实例</returns>
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
        /// 查询文件样本库，支持批量查询
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
        /// DescribeFileSample接口的同步版本，查询文件样本库，支持批量查询
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFileSampleRequest"/></param>
        /// <returns>参考<see cref="DescribeFileSampleResponse"/>实例</returns>
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
        /// 根据日期，渠道和服务类型查询识别结果概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeModerationOverviewRequest"/></param>
        /// <returns><see cref="DescribeModerationOverviewResponse"/></returns>
        public async Task<DescribeModerationOverviewResponse> DescribeModerationOverview(DescribeModerationOverviewRequest req)
        {
             JsonResponseModel<DescribeModerationOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModerationOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModerationOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeModerationOverview接口的同步版本，根据日期，渠道和服务类型查询识别结果概览数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeModerationOverviewRequest"/></param>
        /// <returns>参考<see cref="DescribeModerationOverviewResponse"/>实例</returns>
        public DescribeModerationOverviewResponse DescribeModerationOverviewSync(DescribeModerationOverviewRequest req)
        {
             JsonResponseModel<DescribeModerationOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModerationOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModerationOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持批量查询文字样本库
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
        /// DescribeTextSample接口的同步版本，支持批量查询文字样本库
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTextSampleRequest"/></param>
        /// <returns>参考<see cref="DescribeTextSampleResponse"/>实例</returns>
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
        /// ImageModeration接口的同步版本，图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// </summary>
        /// <param name="req">参考<see cref="ImageModerationRequest"/></param>
        /// <returns>参考<see cref="ImageModerationResponse"/>实例</returns>
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
        /// TextModeration接口的同步版本，文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// </summary>
        /// <param name="req">参考<see cref="TextModerationRequest"/></param>
        /// <returns>参考<see cref="TextModerationResponse"/>实例</returns>
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

        /// <summary>
        /// 视频内容检测（Video Moderation, VM）服务能识别涉黄、涉政、涉恐等违规视频，同时支持用户配置视频黑库，打击自定义的违规内容。
        /// 
        /// <br>
        /// 接口返回值说明：调用本接口有两个返回值，一个是同步返回值，一个是识别完成后的异步回调返回值。
        /// 
        /// 视频识别结果存在于异步回调返回值中，异步回调返回值明细：
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// SeqID | String | 请求seqId唯一标识
        /// EvilFlag | Integer | 是否恶意：0正常，1可疑（Homology模块下：0未匹配到，1恶意，2白样本）
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情
        /// Duration | Integer | 视频时长（单位：秒）
        /// PornDetect | [VideoDetectData](#VDD) | 视频智能鉴黄
        /// PolityDetect | [VideoDetectData](#VDD) | 视频涉政识别
        /// Homology | [VideoDetectData](#VDD) | 相似度识别
        /// 
        /// 
        /// <span id="VDD">VideoDetectData</span>
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// HitFlag | Integer  | 0正常，1可疑
        /// Score | Integer | 判断分值
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情
        /// Keywords | Array of String | 关键词明细
        /// SeedUrl | String | 命中的种子URL
        /// </summary>
        /// <param name="req"><see cref="VideoModerationRequest"/></param>
        /// <returns><see cref="VideoModerationResponse"/></returns>
        public async Task<VideoModerationResponse> VideoModeration(VideoModerationRequest req)
        {
             JsonResponseModel<VideoModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VideoModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VideoModeration接口的同步版本，视频内容检测（Video Moderation, VM）服务能识别涉黄、涉政、涉恐等违规视频，同时支持用户配置视频黑库，打击自定义的违规内容。
        /// 
        /// <br>
        /// 接口返回值说明：调用本接口有两个返回值，一个是同步返回值，一个是识别完成后的异步回调返回值。
        /// 
        /// 视频识别结果存在于异步回调返回值中，异步回调返回值明细：
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// SeqID | String | 请求seqId唯一标识
        /// EvilFlag | Integer | 是否恶意：0正常，1可疑（Homology模块下：0未匹配到，1恶意，2白样本）
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情
        /// Duration | Integer | 视频时长（单位：秒）
        /// PornDetect | [VideoDetectData](#VDD) | 视频智能鉴黄
        /// PolityDetect | [VideoDetectData](#VDD) | 视频涉政识别
        /// Homology | [VideoDetectData](#VDD) | 相似度识别
        /// 
        /// 
        /// <span id="VDD">VideoDetectData</span>
        /// 
        /// 参数名 | 类型 | 描述
        /// -|-|-
        /// HitFlag | Integer  | 0正常，1可疑
        /// Score | Integer | 判断分值
        /// EvilType | Integer | 恶意类型：100正常，20001政治，20002色情
        /// Keywords | Array of String | 关键词明细
        /// SeedUrl | String | 命中的种子URL
        /// </summary>
        /// <param name="req">参考<see cref="VideoModerationRequest"/></param>
        /// <returns>参考<see cref="VideoModerationResponse"/>实例</returns>
        public VideoModerationResponse VideoModerationSync(VideoModerationRequest req)
        {
             JsonResponseModel<VideoModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VideoModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
