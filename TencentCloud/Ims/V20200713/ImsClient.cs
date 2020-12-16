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

namespace TencentCloud.Ims.V20200713
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ims.V20200713.Models;

   public class ImsClient : AbstractClient{

       private const string endpoint = "ims.tencentcloudapi.com";
       private const string version = "2020-07-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ImsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ImsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeImageStatRequest"/></param>
        /// <returns><see cref="DescribeImageStatResponse"/></returns>
        public async Task<DescribeImageStatResponse> DescribeImageStat(DescribeImageStatRequest req)
        {
             JsonResponseModel<DescribeImageStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeImageStatRequest"/></param>
        /// <returns><see cref="DescribeImageStatResponse"/></returns>
        public DescribeImageStatResponse DescribeImageStatSync(DescribeImageStatRequest req)
        {
             JsonResponseModel<DescribeImageStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片机器审核明细
        /// </summary>
        /// <param name="req"><see cref="DescribeImsListRequest"/></param>
        /// <returns><see cref="DescribeImsListResponse"/></returns>
        public async Task<DescribeImsListResponse> DescribeImsList(DescribeImsListRequest req)
        {
             JsonResponseModel<DescribeImsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片机器审核明细
        /// </summary>
        /// <param name="req"><see cref="DescribeImsListRequest"/></param>
        /// <returns><see cref="DescribeImsListResponse"/></returns>
        public DescribeImsListResponse DescribeImsListSync(DescribeImsListRequest req)
        {
             JsonResponseModel<DescribeImsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 图片内容检测服务（Image Moderation, IM）能自动扫描图片，识别涉黄、涉恐、涉政、涉毒等有害内容，同时支持用户配置图片黑名单，打击自定义的违规图片。
        /// 
        /// <div class="rno-api-explorer" style="margin-bottom:20px">
        ///     <div class="rno-api-explorer-inner">
        ///         <div class="rno-api-explorer-hd">
        ///             <div class="rno-api-explorer-title">
        ///                 关于版本迭代的描述
        ///             </div>
        ///         </div>
        ///         <div class="rno-api-explorer-body">
        ///             <div class="rno-api-explorer-cont">
        ///                 <p>当前页面版本为图片内容安全2020版本，2020.11.3日前接入的图片内容安全接口为2019版本，在此时间前接入的用户可直接访问以下链接进行维护操作：<a href="https://cloud.tencent.com/document/product/1125/38206" target="_blank">图片内容安全-2019版本</a></p>
        ///                 <p>2020版本相对2019版本进行了升级，支持更灵活的多场景业务策略配置以及更丰富的识别回调信息，满足不同业务的审核需求，建议按照2020版本接入指引进行接口升级；同时，2019版本也会持续维护直至用户不再使用为止。</p>
        ///             </div>
        ///         </div>
        ///     </div>
        /// </div>
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
        /// 
        /// <div class="rno-api-explorer" style="margin-bottom:20px">
        ///     <div class="rno-api-explorer-inner">
        ///         <div class="rno-api-explorer-hd">
        ///             <div class="rno-api-explorer-title">
        ///                 关于版本迭代的描述
        ///             </div>
        ///         </div>
        ///         <div class="rno-api-explorer-body">
        ///             <div class="rno-api-explorer-cont">
        ///                 <p>当前页面版本为图片内容安全2020版本，2020.11.3日前接入的图片内容安全接口为2019版本，在此时间前接入的用户可直接访问以下链接进行维护操作：<a href="https://cloud.tencent.com/document/product/1125/38206" target="_blank">图片内容安全-2019版本</a></p>
        ///                 <p>2020版本相对2019版本进行了升级，支持更灵活的多场景业务策略配置以及更丰富的识别回调信息，满足不同业务的审核需求，建议按照2020版本接入指引进行接口升级；同时，2019版本也会持续维护直至用户不再使用为止。</p>
        ///             </div>
        ///         </div>
        ///     </div>
        /// </div>
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

    }
}
