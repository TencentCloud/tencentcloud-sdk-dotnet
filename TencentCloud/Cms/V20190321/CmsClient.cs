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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 音频内容检测（Audio Moderation, AM）服务使用了波形分析、声纹分析等技术，能识别涉黄、涉政、涉恐等违规音频，同时支持用户配置音频黑库，打击自定义的违规内容。
        /// 
        /// 通过API直接上传音频即可进行检测，对于高危部分直接屏蔽，可疑部分人工复审，从而节省审核人力，释放业务风险。
        /// </summary>
        /// <param name="req">参考<see cref="AudioModerationRequest"/></param>
        /// <returns>参考<see cref="AudioModerationResponse"/>实例</returns>
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
        /// 根据日期，渠道和服务类型查询识别结果概览数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeModerationOverviewRequest"/></param>
        /// <returns>参考<see cref="DescribeModerationOverviewResponse"/>实例</returns>
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
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// 通过API获取检测的标签及置信度，可直接采信高置信度的结果，人工复审低置信度的结果，从而降低人工成本，提高审核效率。
        /// </summary>
        /// <param name="req">参考<see cref="ImageModerationRequest"/></param>
        /// <returns>参考<see cref="ImageModerationResponse"/>实例</returns>
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
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别涉黄、涉政、涉恐等有害内容，同时支持用户配置词库，打击自定义的违规文本。
        /// 通过API接口，能检测内容的危险等级，对于高危部分直接过滤，可疑部分人工复审，从而节省审核人力，释放业务风险。
        /// </summary>
        /// <param name="req">参考<see cref="TextModerationRequest"/></param>
        /// <returns>参考<see cref="TextModerationResponse"/>实例</returns>
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
        /// 视频内容检测（Video Moderation, VM）服务能识别涉黄、涉政、涉恐等违规视频，同时支持用户配置视频黑库，打击自定义的违规内容。
        /// 通过API直接上传视频即可进行检测，对于高危部分直接过滤，可疑部分人工复审，从而节省审核人力，释放业务风险。
        /// </summary>
        /// <param name="req">参考<see cref="VideoModerationRequest"/></param>
        /// <returns>参考<see cref="VideoModerationResponse"/>实例</returns>
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

    }
}
