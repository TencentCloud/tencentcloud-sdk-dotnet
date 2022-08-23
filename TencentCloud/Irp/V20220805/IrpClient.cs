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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IrpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 获取信息流推荐结果
        /// </summary>
        /// <param name="req"><see cref="FeedRecommendRequest"/></param>
        /// <returns><see cref="FeedRecommendResponse"/></returns>
        public async Task<FeedRecommendResponse> FeedRecommend(FeedRecommendRequest req)
        {
             JsonResponseModel<FeedRecommendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FeedRecommend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FeedRecommendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取信息流推荐结果
        /// </summary>
        /// <param name="req"><see cref="FeedRecommendRequest"/></param>
        /// <returns><see cref="FeedRecommendResponse"/></returns>
        public FeedRecommendResponse FeedRecommendSync(FeedRecommendRequest req)
        {
             JsonResponseModel<FeedRecommendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FeedRecommend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FeedRecommendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报信息流场景内的行为数据，随着数据的积累，模型的效果会逐渐稳定。
        /// </summary>
        /// <param name="req"><see cref="ReportFeedBehaviorRequest"/></param>
        /// <returns><see cref="ReportFeedBehaviorResponse"/></returns>
        public async Task<ReportFeedBehaviorResponse> ReportFeedBehavior(ReportFeedBehaviorRequest req)
        {
             JsonResponseModel<ReportFeedBehaviorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportFeedBehavior");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedBehaviorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报信息流场景内的行为数据，随着数据的积累，模型的效果会逐渐稳定。
        /// </summary>
        /// <param name="req"><see cref="ReportFeedBehaviorRequest"/></param>
        /// <returns><see cref="ReportFeedBehaviorResponse"/></returns>
        public ReportFeedBehaviorResponse ReportFeedBehaviorSync(ReportFeedBehaviorRequest req)
        {
             JsonResponseModel<ReportFeedBehaviorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportFeedBehavior");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedBehaviorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报被用于推荐的信息流内容信息
        /// </summary>
        /// <param name="req"><see cref="ReportFeedItemRequest"/></param>
        /// <returns><see cref="ReportFeedItemResponse"/></returns>
        public async Task<ReportFeedItemResponse> ReportFeedItem(ReportFeedItemRequest req)
        {
             JsonResponseModel<ReportFeedItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportFeedItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报被用于推荐的信息流内容信息
        /// </summary>
        /// <param name="req"><see cref="ReportFeedItemRequest"/></param>
        /// <returns><see cref="ReportFeedItemResponse"/></returns>
        public ReportFeedItemResponse ReportFeedItemSync(ReportFeedItemRequest req)
        {
             JsonResponseModel<ReportFeedItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportFeedItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报信息流用户信息，请务必确认用户的唯一性，并在请求推荐结果时指定用户的唯一标识信息（UserId），否则将无法进行千人千面的推荐
        /// </summary>
        /// <param name="req"><see cref="ReportFeedUserRequest"/></param>
        /// <returns><see cref="ReportFeedUserResponse"/></returns>
        public async Task<ReportFeedUserResponse> ReportFeedUser(ReportFeedUserRequest req)
        {
             JsonResponseModel<ReportFeedUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportFeedUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报信息流用户信息，请务必确认用户的唯一性，并在请求推荐结果时指定用户的唯一标识信息（UserId），否则将无法进行千人千面的推荐
        /// </summary>
        /// <param name="req"><see cref="ReportFeedUserRequest"/></param>
        /// <returns><see cref="ReportFeedUserResponse"/></returns>
        public ReportFeedUserResponse ReportFeedUserSync(ReportFeedUserRequest req)
        {
             JsonResponseModel<ReportFeedUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportFeedUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportFeedUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
