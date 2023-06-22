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

namespace TencentCloud.Yinsuda.V20220527
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yinsuda.V20220527.Models;

   public class YinsudaClient : AbstractClient{

       private const string endpoint = "yinsuda.tencentcloudapi.com";
       private const string version = "2022-05-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YinsudaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YinsudaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请合唱相关信息，用于标记用户的演唱是在合唱场景下。
        /// </summary>
        /// <param name="req"><see cref="ApplyChorusRequest"/></param>
        /// <returns><see cref="ApplyChorusResponse"/></returns>
        public async Task<ApplyChorusResponse> ApplyChorus(ApplyChorusRequest req)
        {
             JsonResponseModel<ApplyChorusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyChorus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyChorusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请合唱相关信息，用于标记用户的演唱是在合唱场景下。
        /// </summary>
        /// <param name="req"><see cref="ApplyChorusRequest"/></param>
        /// <returns><see cref="ApplyChorusResponse"/></returns>
        public ApplyChorusResponse ApplyChorusSync(ApplyChorusRequest req)
        {
             JsonResponseModel<ApplyChorusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyChorus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyChorusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取歌曲详细信息，包括：歌词下载链接、播放凭证、音高数据下载链接信息等。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public async Task<BatchDescribeKTVMusicDetailsResponse> BatchDescribeKTVMusicDetails(BatchDescribeKTVMusicDetailsRequest req)
        {
             JsonResponseModel<BatchDescribeKTVMusicDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDescribeKTVMusicDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeKTVMusicDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取歌曲详细信息，包括：歌词下载链接、播放凭证、音高数据下载链接信息等。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public BatchDescribeKTVMusicDetailsResponse BatchDescribeKTVMusicDetailsSync(BatchDescribeKTVMusicDetailsRequest req)
        {
             JsonResponseModel<BatchDescribeKTVMusicDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDescribeKTVMusicDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeKTVMusicDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public async Task<CreateKTVRobotResponse> CreateKTVRobot(CreateKTVRobotRequest req)
        {
             JsonResponseModel<CreateKTVRobotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKTVRobot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKTVRobotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public CreateKTVRobotResponse CreateKTVRobotSync(CreateKTVRobotRequest req)
        {
             JsonResponseModel<CreateKTVRobotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKTVRobot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKTVRobotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据输入的规则匹配曲库中的歌曲。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMatchMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVMatchMusicsResponse"/></returns>
        public async Task<DescribeKTVMatchMusicsResponse> DescribeKTVMatchMusics(DescribeKTVMatchMusicsRequest req)
        {
             JsonResponseModel<DescribeKTVMatchMusicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVMatchMusics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMatchMusicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据输入的规则匹配曲库中的歌曲。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMatchMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVMatchMusicsResponse"/></returns>
        public DescribeKTVMatchMusicsResponse DescribeKTVMatchMusicsSync(DescribeKTVMatchMusicsRequest req)
        {
             JsonResponseModel<DescribeKTVMatchMusicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVMatchMusics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMatchMusicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取歌曲伴奏片段链接，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlResponse"/></returns>
        public async Task<DescribeKTVMusicAccompanySegmentUrlResponse> DescribeKTVMusicAccompanySegmentUrl(DescribeKTVMusicAccompanySegmentUrlRequest req)
        {
             JsonResponseModel<DescribeKTVMusicAccompanySegmentUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVMusicAccompanySegmentUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicAccompanySegmentUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取歌曲伴奏片段链接，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlResponse"/></returns>
        public DescribeKTVMusicAccompanySegmentUrlResponse DescribeKTVMusicAccompanySegmentUrlSync(DescribeKTVMusicAccompanySegmentUrlRequest req)
        {
             JsonResponseModel<DescribeKTVMusicAccompanySegmentUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVMusicAccompanySegmentUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicAccompanySegmentUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签过滤歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicsByTagRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicsByTagResponse"/></returns>
        public async Task<DescribeKTVMusicsByTagResponse> DescribeKTVMusicsByTag(DescribeKTVMusicsByTagRequest req)
        {
             JsonResponseModel<DescribeKTVMusicsByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVMusicsByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicsByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签过滤歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicsByTagRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicsByTagResponse"/></returns>
        public DescribeKTVMusicsByTagResponse DescribeKTVMusicsByTagSync(DescribeKTVMusicsByTagRequest req)
        {
             JsonResponseModel<DescribeKTVMusicsByTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVMusicsByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicsByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public async Task<DescribeKTVPlaylistDetailResponse> DescribeKTVPlaylistDetail(DescribeKTVPlaylistDetailRequest req)
        {
             JsonResponseModel<DescribeKTVPlaylistDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVPlaylistDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVPlaylistDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public DescribeKTVPlaylistDetailResponse DescribeKTVPlaylistDetailSync(DescribeKTVPlaylistDetailRequest req)
        {
             JsonResponseModel<DescribeKTVPlaylistDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVPlaylistDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVPlaylistDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取歌单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistsRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistsResponse"/></returns>
        public async Task<DescribeKTVPlaylistsResponse> DescribeKTVPlaylists(DescribeKTVPlaylistsRequest req)
        {
             JsonResponseModel<DescribeKTVPlaylistsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVPlaylists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVPlaylistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取歌单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistsRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistsResponse"/></returns>
        public DescribeKTVPlaylistsResponse DescribeKTVPlaylistsSync(DescribeKTVPlaylistsRequest req)
        {
             JsonResponseModel<DescribeKTVPlaylistsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVPlaylists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVPlaylistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器人列表，支持 Id、状态等过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVRobotsRequest"/></param>
        /// <returns><see cref="DescribeKTVRobotsResponse"/></returns>
        public async Task<DescribeKTVRobotsResponse> DescribeKTVRobots(DescribeKTVRobotsRequest req)
        {
             JsonResponseModel<DescribeKTVRobotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVRobots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVRobotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器人列表，支持 Id、状态等过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVRobotsRequest"/></param>
        /// <returns><see cref="DescribeKTVRobotsResponse"/></returns>
        public DescribeKTVRobotsResponse DescribeKTVRobotsSync(DescribeKTVRobotsRequest req)
        {
             JsonResponseModel<DescribeKTVRobotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVRobots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVRobotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键词获取联想词列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public async Task<DescribeKTVSuggestionsResponse> DescribeKTVSuggestions(DescribeKTVSuggestionsRequest req)
        {
             JsonResponseModel<DescribeKTVSuggestionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVSuggestions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVSuggestionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键词获取联想词列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public DescribeKTVSuggestionsResponse DescribeKTVSuggestionsSync(DescribeKTVSuggestionsRequest req)
        {
             JsonResponseModel<DescribeKTVSuggestionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVSuggestions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVSuggestionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取标签分组及分组下的标签列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVTagsResponse"/></returns>
        public async Task<DescribeKTVTagsResponse> DescribeKTVTags(DescribeKTVTagsRequest req)
        {
             JsonResponseModel<DescribeKTVTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取标签分组及分组下的标签列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVTagsResponse"/></returns>
        public DescribeKTVTagsResponse DescribeKTVTagsSync(DescribeKTVTagsRequest req)
        {
             JsonResponseModel<DescribeKTVTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取直播会员充值流水详细信息，包括：流水号，订单状态，下订单时间等
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVipTradeInfosRequest"/></param>
        /// <returns><see cref="DescribeLiveVipTradeInfosResponse"/></returns>
        public async Task<DescribeLiveVipTradeInfosResponse> DescribeLiveVipTradeInfos(DescribeLiveVipTradeInfosRequest req)
        {
             JsonResponseModel<DescribeLiveVipTradeInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveVipTradeInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveVipTradeInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取直播会员充值流水详细信息，包括：流水号，订单状态，下订单时间等
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVipTradeInfosRequest"/></param>
        /// <returns><see cref="DescribeLiveVipTradeInfosResponse"/></returns>
        public DescribeLiveVipTradeInfosResponse DescribeLiveVipTradeInfosSync(DescribeLiveVipTradeInfosRequest req)
        {
             JsonResponseModel<DescribeLiveVipTradeInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveVipTradeInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveVipTradeInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息，包括是否为直播会员，及直播会员信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public async Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息，包括是否为直播会员，及直播会员信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁机器人，机器人退出 RTC 房间。
        /// </summary>
        /// <param name="req"><see cref="DestroyKTVRobotRequest"/></param>
        /// <returns><see cref="DestroyKTVRobotResponse"/></returns>
        public async Task<DestroyKTVRobotResponse> DestroyKTVRobot(DestroyKTVRobotRequest req)
        {
             JsonResponseModel<DestroyKTVRobotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyKTVRobot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyKTVRobotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁机器人，机器人退出 RTC 房间。
        /// </summary>
        /// <param name="req"><see cref="DestroyKTVRobotRequest"/></param>
        /// <returns><see cref="DestroyKTVRobotResponse"/></returns>
        public DestroyKTVRobotResponse DestroyKTVRobotSync(DestroyKTVRobotRequest req)
        {
             JsonResponseModel<DestroyKTVRobotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyKTVRobot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyKTVRobotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 充值直播会员，使该用户可以在直播场景使用
        /// </summary>
        /// <param name="req"><see cref="RechargeLiveVipRequest"/></param>
        /// <returns><see cref="RechargeLiveVipResponse"/></returns>
        public async Task<RechargeLiveVipResponse> RechargeLiveVip(RechargeLiveVipRequest req)
        {
             JsonResponseModel<RechargeLiveVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RechargeLiveVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeLiveVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 充值直播会员，使该用户可以在直播场景使用
        /// </summary>
        /// <param name="req"><see cref="RechargeLiveVipRequest"/></param>
        /// <returns><see cref="RechargeLiveVipResponse"/></returns>
        public RechargeLiveVipResponse RechargeLiveVipSync(RechargeLiveVipRequest req)
        {
             JsonResponseModel<RechargeLiveVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RechargeLiveVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeLiveVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键词搜索歌曲，返回相关歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="SearchKTVMusicsRequest"/></param>
        /// <returns><see cref="SearchKTVMusicsResponse"/></returns>
        public async Task<SearchKTVMusicsResponse> SearchKTVMusics(SearchKTVMusicsRequest req)
        {
             JsonResponseModel<SearchKTVMusicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchKTVMusics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchKTVMusicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键词搜索歌曲，返回相关歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="SearchKTVMusicsRequest"/></param>
        /// <returns><see cref="SearchKTVMusicsResponse"/></returns>
        public SearchKTVMusicsResponse SearchKTVMusicsSync(SearchKTVMusicsRequest req)
        {
             JsonResponseModel<SearchKTVMusicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchKTVMusics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchKTVMusicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发操作机器人指令，支持播放、暂停、恢复、歌单设置等操作指令，实现对机器人行为的控制。
        /// </summary>
        /// <param name="req"><see cref="SyncKTVRobotCommandRequest"/></param>
        /// <returns><see cref="SyncKTVRobotCommandResponse"/></returns>
        public async Task<SyncKTVRobotCommandResponse> SyncKTVRobotCommand(SyncKTVRobotCommandRequest req)
        {
             JsonResponseModel<SyncKTVRobotCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncKTVRobotCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncKTVRobotCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发操作机器人指令，支持播放、暂停、恢复、歌单设置等操作指令，实现对机器人行为的控制。
        /// </summary>
        /// <param name="req"><see cref="SyncKTVRobotCommandRequest"/></param>
        /// <returns><see cref="SyncKTVRobotCommandResponse"/></returns>
        public SyncKTVRobotCommandResponse SyncKTVRobotCommandSync(SyncKTVRobotCommandRequest req)
        {
             JsonResponseModel<SyncKTVRobotCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncKTVRobotCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncKTVRobotCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
