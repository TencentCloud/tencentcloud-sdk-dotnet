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

namespace TencentCloud.Irp.V20220805
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Irp.V20220805.Models;

   public class IrpClient : AbstractClient{

       private const string endpoint = "irp.tencentcloudapi.com";
       private const string version = "2022-08-05";
       private const string sdkVersion = "SDK_NET_3.0.1217";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IrpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IrpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取电商类推荐结果
        /// </summary>
        /// <param name="req"><see cref="DescribeGoodsRecommendRequest"/></param>
        /// <returns><see cref="DescribeGoodsRecommendResponse"/></returns>
        public Task<DescribeGoodsRecommendResponse> DescribeGoodsRecommend(DescribeGoodsRecommendRequest req)
        {
            return InternalRequestAsync<DescribeGoodsRecommendResponse>(req, "DescribeGoodsRecommend");
        }

        /// <summary>
        /// 获取电商类推荐结果
        /// </summary>
        /// <param name="req"><see cref="DescribeGoodsRecommendRequest"/></param>
        /// <returns><see cref="DescribeGoodsRecommendResponse"/></returns>
        public DescribeGoodsRecommendResponse DescribeGoodsRecommendSync(DescribeGoodsRecommendRequest req)
        {
            return InternalRequestAsync<DescribeGoodsRecommendResponse>(req, "DescribeGoodsRecommend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取信息流推荐结果
        /// </summary>
        /// <param name="req"><see cref="FeedRecommendRequest"/></param>
        /// <returns><see cref="FeedRecommendResponse"/></returns>
        public Task<FeedRecommendResponse> FeedRecommend(FeedRecommendRequest req)
        {
            return InternalRequestAsync<FeedRecommendResponse>(req, "FeedRecommend");
        }

        /// <summary>
        /// 获取信息流推荐结果
        /// </summary>
        /// <param name="req"><see cref="FeedRecommendRequest"/></param>
        /// <returns><see cref="FeedRecommendResponse"/></returns>
        public FeedRecommendResponse FeedRecommendSync(FeedRecommendRequest req)
        {
            return InternalRequestAsync<FeedRecommendResponse>(req, "FeedRecommend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报信息流场景内的行为数据，随着数据的积累，模型的效果会逐渐稳定。
        /// </summary>
        /// <param name="req"><see cref="ReportFeedBehaviorRequest"/></param>
        /// <returns><see cref="ReportFeedBehaviorResponse"/></returns>
        public Task<ReportFeedBehaviorResponse> ReportFeedBehavior(ReportFeedBehaviorRequest req)
        {
            return InternalRequestAsync<ReportFeedBehaviorResponse>(req, "ReportFeedBehavior");
        }

        /// <summary>
        /// 上报信息流场景内的行为数据，随着数据的积累，模型的效果会逐渐稳定。
        /// </summary>
        /// <param name="req"><see cref="ReportFeedBehaviorRequest"/></param>
        /// <returns><see cref="ReportFeedBehaviorResponse"/></returns>
        public ReportFeedBehaviorResponse ReportFeedBehaviorSync(ReportFeedBehaviorRequest req)
        {
            return InternalRequestAsync<ReportFeedBehaviorResponse>(req, "ReportFeedBehavior")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报被用于推荐的信息流内容信息
        /// </summary>
        /// <param name="req"><see cref="ReportFeedItemRequest"/></param>
        /// <returns><see cref="ReportFeedItemResponse"/></returns>
        public Task<ReportFeedItemResponse> ReportFeedItem(ReportFeedItemRequest req)
        {
            return InternalRequestAsync<ReportFeedItemResponse>(req, "ReportFeedItem");
        }

        /// <summary>
        /// 上报被用于推荐的信息流内容信息
        /// </summary>
        /// <param name="req"><see cref="ReportFeedItemRequest"/></param>
        /// <returns><see cref="ReportFeedItemResponse"/></returns>
        public ReportFeedItemResponse ReportFeedItemSync(ReportFeedItemRequest req)
        {
            return InternalRequestAsync<ReportFeedItemResponse>(req, "ReportFeedItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报信息流用户信息，请务必确认用户的唯一性，并在请求推荐结果时指定用户的唯一标识信息（UserId），否则将无法进行千人千面的推荐
        /// </summary>
        /// <param name="req"><see cref="ReportFeedUserRequest"/></param>
        /// <returns><see cref="ReportFeedUserResponse"/></returns>
        public Task<ReportFeedUserResponse> ReportFeedUser(ReportFeedUserRequest req)
        {
            return InternalRequestAsync<ReportFeedUserResponse>(req, "ReportFeedUser");
        }

        /// <summary>
        /// 上报信息流用户信息，请务必确认用户的唯一性，并在请求推荐结果时指定用户的唯一标识信息（UserId），否则将无法进行千人千面的推荐
        /// </summary>
        /// <param name="req"><see cref="ReportFeedUserRequest"/></param>
        /// <returns><see cref="ReportFeedUserResponse"/></returns>
        public ReportFeedUserResponse ReportFeedUserSync(ReportFeedUserRequest req)
        {
            return InternalRequestAsync<ReportFeedUserResponse>(req, "ReportFeedUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报电商类行为数据
        /// </summary>
        /// <param name="req"><see cref="ReportGoodsBehaviorRequest"/></param>
        /// <returns><see cref="ReportGoodsBehaviorResponse"/></returns>
        public Task<ReportGoodsBehaviorResponse> ReportGoodsBehavior(ReportGoodsBehaviorRequest req)
        {
            return InternalRequestAsync<ReportGoodsBehaviorResponse>(req, "ReportGoodsBehavior");
        }

        /// <summary>
        /// 上报电商类行为数据
        /// </summary>
        /// <param name="req"><see cref="ReportGoodsBehaviorRequest"/></param>
        /// <returns><see cref="ReportGoodsBehaviorResponse"/></returns>
        public ReportGoodsBehaviorResponse ReportGoodsBehaviorSync(ReportGoodsBehaviorRequest req)
        {
            return InternalRequestAsync<ReportGoodsBehaviorResponse>(req, "ReportGoodsBehavior")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报电商类商品信息
        /// </summary>
        /// <param name="req"><see cref="ReportGoodsInfoRequest"/></param>
        /// <returns><see cref="ReportGoodsInfoResponse"/></returns>
        public Task<ReportGoodsInfoResponse> ReportGoodsInfo(ReportGoodsInfoRequest req)
        {
            return InternalRequestAsync<ReportGoodsInfoResponse>(req, "ReportGoodsInfo");
        }

        /// <summary>
        /// 上报电商类商品信息
        /// </summary>
        /// <param name="req"><see cref="ReportGoodsInfoRequest"/></param>
        /// <returns><see cref="ReportGoodsInfoResponse"/></returns>
        public ReportGoodsInfoResponse ReportGoodsInfoSync(ReportGoodsInfoRequest req)
        {
            return InternalRequestAsync<ReportGoodsInfoResponse>(req, "ReportGoodsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
