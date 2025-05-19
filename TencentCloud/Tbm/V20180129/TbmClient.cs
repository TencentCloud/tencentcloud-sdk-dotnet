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
       private const string sdkVersion = "SDK_NET_3.0.1243";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌好评与差评评价条数，按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandCommentCountRequest"/></param>
        /// <returns><see cref="DescribeBrandCommentCountResponse"/></returns>
        public Task<DescribeBrandCommentCountResponse> DescribeBrandCommentCount(DescribeBrandCommentCountRequest req)
        {
            return InternalRequestAsync<DescribeBrandCommentCountResponse>(req, "DescribeBrandCommentCount");
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌好评与差评评价条数，按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandCommentCountRequest"/></param>
        /// <returns><see cref="DescribeBrandCommentCountResponse"/></returns>
        public DescribeBrandCommentCountResponse DescribeBrandCommentCountSync(DescribeBrandCommentCountRequest req)
        {
            return InternalRequestAsync<DescribeBrandCommentCountResponse>(req, "DescribeBrandCommentCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 监测品牌关键词命中文章标题或全文的文章篇数，按天输出数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandExposureRequest"/></param>
        /// <returns><see cref="DescribeBrandExposureResponse"/></returns>
        public Task<DescribeBrandExposureResponse> DescribeBrandExposure(DescribeBrandExposureRequest req)
        {
            return InternalRequestAsync<DescribeBrandExposureResponse>(req, "DescribeBrandExposure");
        }

        /// <summary>
        /// 监测品牌关键词命中文章标题或全文的文章篇数，按天输出数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandExposureRequest"/></param>
        /// <returns><see cref="DescribeBrandExposureResponse"/></returns>
        public DescribeBrandExposureResponse DescribeBrandExposureSync(DescribeBrandExposureRequest req)
        {
            return InternalRequestAsync<DescribeBrandExposureResponse>(req, "DescribeBrandExposure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 监测品牌关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数。按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandMediaReportRequest"/></param>
        /// <returns><see cref="DescribeBrandMediaReportResponse"/></returns>
        public Task<DescribeBrandMediaReportResponse> DescribeBrandMediaReport(DescribeBrandMediaReportRequest req)
        {
            return InternalRequestAsync<DescribeBrandMediaReportResponse>(req, "DescribeBrandMediaReport");
        }

        /// <summary>
        /// 监测品牌关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数。按天输出结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandMediaReportRequest"/></param>
        /// <returns><see cref="DescribeBrandMediaReportResponse"/></returns>
        public DescribeBrandMediaReportResponse DescribeBrandMediaReportSync(DescribeBrandMediaReportRequest req)
        {
            return InternalRequestAsync<DescribeBrandMediaReportResponse>(req, "DescribeBrandMediaReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门差评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandNegCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandNegCommentsResponse"/></returns>
        public Task<DescribeBrandNegCommentsResponse> DescribeBrandNegComments(DescribeBrandNegCommentsRequest req)
        {
            return InternalRequestAsync<DescribeBrandNegCommentsResponse>(req, "DescribeBrandNegComments");
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门差评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandNegCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandNegCommentsResponse"/></returns>
        public DescribeBrandNegCommentsResponse DescribeBrandNegCommentsSync(DescribeBrandNegCommentsRequest req)
        {
            return InternalRequestAsync<DescribeBrandNegCommentsResponse>(req, "DescribeBrandNegComments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门好评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandPosCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandPosCommentsResponse"/></returns>
        public Task<DescribeBrandPosCommentsResponse> DescribeBrandPosComments(DescribeBrandPosCommentsRequest req)
        {
            return InternalRequestAsync<DescribeBrandPosCommentsResponse>(req, "DescribeBrandPosComments");
        }

        /// <summary>
        /// 通过分析用户在评价品牌时用词的正负面情绪评分，返回品牌热门好评观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandPosCommentsRequest"/></param>
        /// <returns><see cref="DescribeBrandPosCommentsResponse"/></returns>
        public DescribeBrandPosCommentsResponse DescribeBrandPosCommentsSync(DescribeBrandPosCommentsRequest req)
        {
            return InternalRequestAsync<DescribeBrandPosCommentsResponse>(req, "DescribeBrandPosComments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的内容，每天聚合近30天热度最高的观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialOpinionRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialOpinionResponse"/></returns>
        public Task<DescribeBrandSocialOpinionResponse> DescribeBrandSocialOpinion(DescribeBrandSocialOpinionRequest req)
        {
            return InternalRequestAsync<DescribeBrandSocialOpinionResponse>(req, "DescribeBrandSocialOpinion");
        }

        /// <summary>
        /// 检测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的内容，每天聚合近30天热度最高的观点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialOpinionRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialOpinionResponse"/></returns>
        public DescribeBrandSocialOpinionResponse DescribeBrandSocialOpinionSync(DescribeBrandSocialOpinionRequest req)
        {
            return InternalRequestAsync<DescribeBrandSocialOpinionResponse>(req, "DescribeBrandSocialOpinion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 监测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的条数。按天输出数据结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialReportRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialReportResponse"/></returns>
        public Task<DescribeBrandSocialReportResponse> DescribeBrandSocialReport(DescribeBrandSocialReportRequest req)
        {
            return InternalRequestAsync<DescribeBrandSocialReportResponse>(req, "DescribeBrandSocialReport");
        }

        /// <summary>
        /// 监测品牌关键词出现在微博、QQ兴趣部落、论坛、博客等个人公开贡献资讯中的条数。按天输出数据结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBrandSocialReportRequest"/></param>
        /// <returns><see cref="DescribeBrandSocialReportResponse"/></returns>
        public DescribeBrandSocialReportResponse DescribeBrandSocialReportSync(DescribeBrandSocialReportRequest req)
        {
            return InternalRequestAsync<DescribeBrandSocialReportResponse>(req, "DescribeBrandSocialReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据客户定制的行业关键词，监测关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数，以及文章列表、来源渠道、作者、发布时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeIndustryNewsRequest"/></param>
        /// <returns><see cref="DescribeIndustryNewsResponse"/></returns>
        public Task<DescribeIndustryNewsResponse> DescribeIndustryNews(DescribeIndustryNewsRequest req)
        {
            return InternalRequestAsync<DescribeIndustryNewsResponse>(req, "DescribeIndustryNews");
        }

        /// <summary>
        /// 根据客户定制的行业关键词，监测关键词出现在媒体网站（新闻媒体、网络门户、政府网站、微信公众号、天天快报等）发布资讯标题和正文中的报道数，以及文章列表、来源渠道、作者、发布时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeIndustryNewsRequest"/></param>
        /// <returns><see cref="DescribeIndustryNewsResponse"/></returns>
        public DescribeIndustryNewsResponse DescribeIndustryNewsSync(DescribeIndustryNewsRequest req)
        {
            return InternalRequestAsync<DescribeIndustryNewsResponse>(req, "DescribeIndustryNews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过分析洞察参与过品牌媒体互动的用户，比如公开发表品牌的新闻评论、在公开社交渠道发表过对品牌的评价观点等用户，返回用户的画像属性分布，例如性别、年龄、地域、喜爱的明星、喜爱的影视。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPortraitRequest"/></param>
        /// <returns><see cref="DescribeUserPortraitResponse"/></returns>
        public Task<DescribeUserPortraitResponse> DescribeUserPortrait(DescribeUserPortraitRequest req)
        {
            return InternalRequestAsync<DescribeUserPortraitResponse>(req, "DescribeUserPortrait");
        }

        /// <summary>
        /// 通过分析洞察参与过品牌媒体互动的用户，比如公开发表品牌的新闻评论、在公开社交渠道发表过对品牌的评价观点等用户，返回用户的画像属性分布，例如性别、年龄、地域、喜爱的明星、喜爱的影视。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPortraitRequest"/></param>
        /// <returns><see cref="DescribeUserPortraitResponse"/></returns>
        public DescribeUserPortraitResponse DescribeUserPortraitSync(DescribeUserPortraitRequest req)
        {
            return InternalRequestAsync<DescribeUserPortraitResponse>(req, "DescribeUserPortrait")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
