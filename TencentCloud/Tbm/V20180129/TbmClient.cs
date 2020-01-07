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

namespace TencentCloud.Tbm.V20180129
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbm.V20180129.Models;

   public class TbmClient : AbstractClient{

       private const string endpoint = "tbm.tencentcloudapi.com";
       private const string version = "2018-01-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TbmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌好评与差评评价条数，按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandCommentCountRequest"/></param>
        /// <returns><see cref="DescribeBrandCommentCountResponse"/></returns>
        public async Task<DescribeBrandCommentCountResponse> DescribeBrandCommentCount(DescribeBrandCommentCountRequest req)
        {
             JsonResponseModel<DescribeBrandCommentCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandCommentCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandCommentCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandCommentCount接口的同步版本，通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌好评与差评评价条数，按天输出结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandCommentCountRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandCommentCountResponse"/>实例</returns>
        public DescribeBrandCommentCountResponse DescribeBrandCommentCountSync(DescribeBrandCommentCountRequest req)
        {
             JsonResponseModel<DescribeBrandCommentCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandCommentCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandCommentCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 监测品牌关键词命中文章标题或全文的文章篇数，按天输出数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandExposureRequest"/></param>
        /// <returns><see cref="DescribeBrandExposureResponse"/></returns>
        public async Task<DescribeBrandExposureResponse> DescribeBrandExposure(DescribeBrandExposureRequest req)
        {
             JsonResponseModel<DescribeBrandExposureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandExposure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandExposureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandExposure接口的同步版本，监测品牌关键词命中文章标题或全文的文章篇数，按天输出数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandExposureRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandExposureResponse"/>实例</returns>
        public DescribeBrandExposureResponse DescribeBrandExposureSync(DescribeBrandExposureRequest req)
        {
             JsonResponseModel<DescribeBrandExposureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandExposure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandExposureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 监测品牌关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数。按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandMediaReportRequest"/></param>
        /// <returns><see cref="DescribeBrandMediaReportResponse"/></returns>
        public async Task<DescribeBrandMediaReportResponse> DescribeBrandMediaReport(DescribeBrandMediaReportRequest req)
        {
             JsonResponseModel<DescribeBrandMediaReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandMediaReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandMediaReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandMediaReport接口的同步版本，监测品牌关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数。按天输出结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandMediaReportRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandMediaReportResponse"/>实例</returns>
        public DescribeBrandMediaReportResponse DescribeBrandMediaReportSync(DescribeBrandMediaReportRequest req)
        {
             JsonResponseModel<DescribeBrandMediaReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandMediaReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandMediaReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门差评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandNegCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandNegCommentsResponse"/></returns>
        public async Task<DescribeBrandNegCommentsResponse> DescribeBrandNegComments(DescribeBrandNegCommentsRequest req)
        {
             JsonResponseModel<DescribeBrandNegCommentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandNegComments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandNegCommentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandNegComments接口的同步版本，通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门差评观点列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandNegCommentsRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandNegCommentsResponse"/>实例</returns>
        public DescribeBrandNegCommentsResponse DescribeBrandNegCommentsSync(DescribeBrandNegCommentsRequest req)
        {
             JsonResponseModel<DescribeBrandNegCommentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandNegComments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandNegCommentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门好评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandPosCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandPosCommentsResponse"/></returns>
        public async Task<DescribeBrandPosCommentsResponse> DescribeBrandPosComments(DescribeBrandPosCommentsRequest req)
        {
             JsonResponseModel<DescribeBrandPosCommentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandPosComments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandPosCommentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandPosComments接口的同步版本，通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门好评观点列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandPosCommentsRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandPosCommentsResponse"/>实例</returns>
        public DescribeBrandPosCommentsResponse DescribeBrandPosCommentsSync(DescribeBrandPosCommentsRequest req)
        {
             JsonResponseModel<DescribeBrandPosCommentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandPosComments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandPosCommentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的内容，每天聚合近30天热度最高的观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialOpinionRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialOpinionResponse"/></returns>
        public async Task<DescribeBrandSocialOpinionResponse> DescribeBrandSocialOpinion(DescribeBrandSocialOpinionRequest req)
        {
             JsonResponseModel<DescribeBrandSocialOpinionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandSocialOpinion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandSocialOpinionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandSocialOpinion接口的同步版本，检测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的内容，每天聚合近30天热度最高的观点列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandSocialOpinionRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandSocialOpinionResponse"/>实例</returns>
        public DescribeBrandSocialOpinionResponse DescribeBrandSocialOpinionSync(DescribeBrandSocialOpinionRequest req)
        {
             JsonResponseModel<DescribeBrandSocialOpinionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandSocialOpinion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandSocialOpinionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 监测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的条数。按天输出数据结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialReportRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialReportResponse"/></returns>
        public async Task<DescribeBrandSocialReportResponse> DescribeBrandSocialReport(DescribeBrandSocialReportRequest req)
        {
             JsonResponseModel<DescribeBrandSocialReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBrandSocialReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandSocialReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBrandSocialReport接口的同步版本，监测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的条数。按天输出数据结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBrandSocialReportRequest"/></param>
        /// <returns>参考<see cref="DescribeBrandSocialReportResponse"/>实例</returns>
        public DescribeBrandSocialReportResponse DescribeBrandSocialReportSync(DescribeBrandSocialReportRequest req)
        {
             JsonResponseModel<DescribeBrandSocialReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBrandSocialReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBrandSocialReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户定制的行业关键词，监测关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数，以及文章列表、来源渠道、作者、发布时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeIndustryNewsRequest"/></param>
        /// <returns><see cref="DescribeIndustryNewsResponse"/></returns>
        public async Task<DescribeIndustryNewsResponse> DescribeIndustryNews(DescribeIndustryNewsRequest req)
        {
             JsonResponseModel<DescribeIndustryNewsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndustryNews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndustryNewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIndustryNews接口的同步版本，根据客户定制的行业关键词，监测关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数，以及文章列表、来源渠道、作者、发布时间等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIndustryNewsRequest"/></param>
        /// <returns>参考<see cref="DescribeIndustryNewsResponse"/>实例</returns>
        public DescribeIndustryNewsResponse DescribeIndustryNewsSync(DescribeIndustryNewsRequest req)
        {
             JsonResponseModel<DescribeIndustryNewsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndustryNews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndustryNewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过分析洞察参与过品牌媒体互动的用户，比如公开发表品牌的新闻评论、在公开社交渠道发表过对品牌的评价观点等用户，返回用户的画像属性分布，例如性别、年龄、地域、喜爱的明星、喜爱的影视。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPortraitRequest"/></param>
        /// <returns><see cref="DescribeUserPortraitResponse"/></returns>
        public async Task<DescribeUserPortraitResponse> DescribeUserPortrait(DescribeUserPortraitRequest req)
        {
             JsonResponseModel<DescribeUserPortraitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserPortrait");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserPortraitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUserPortrait接口的同步版本，通过分析洞察参与过品牌媒体互动的用户，比如公开发表品牌的新闻评论、在公开社交渠道发表过对品牌的评价观点等用户，返回用户的画像属性分布，例如性别、年龄、地域、喜爱的明星、喜爱的影视。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserPortraitRequest"/></param>
        /// <returns>参考<see cref="DescribeUserPortraitResponse"/>实例</returns>
        public DescribeUserPortraitResponse DescribeUserPortraitSync(DescribeUserPortraitRequest req)
        {
             JsonResponseModel<DescribeUserPortraitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserPortrait");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserPortraitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
