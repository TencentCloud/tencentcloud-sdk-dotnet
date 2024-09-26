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
       private const string sdkVersion = "SDK_NET_3.0.1097";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YinsudaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 申请合唱相关信息，用于标记用户的演唱是在合唱场景下。
        /// </summary>
        /// <param name="req"><see cref="ApplyChorusRequest"/></param>
        /// <returns><see cref="ApplyChorusResponse"/></returns>
        public Task<ApplyChorusResponse> ApplyChorus(ApplyChorusRequest req)
        {
            return InternalRequestAsync<ApplyChorusResponse>(req, "ApplyChorus");
        }

        /// <summary>
        /// 申请合唱相关信息，用于标记用户的演唱是在合唱场景下。
        /// </summary>
        /// <param name="req"><see cref="ApplyChorusRequest"/></param>
        /// <returns><see cref="ApplyChorusResponse"/></returns>
        public ApplyChorusResponse ApplyChorusSync(ApplyChorusRequest req)
        {
            return InternalRequestAsync<ApplyChorusResponse>(req, "ApplyChorus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取歌曲详细信息，包括：歌词下载链接、播放凭证、音高数据下载链接信息等。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public Task<BatchDescribeKTVMusicDetailsResponse> BatchDescribeKTVMusicDetails(BatchDescribeKTVMusicDetailsRequest req)
        {
            return InternalRequestAsync<BatchDescribeKTVMusicDetailsResponse>(req, "BatchDescribeKTVMusicDetails");
        }

        /// <summary>
        /// 批量获取歌曲详细信息，包括：歌词下载链接、播放凭证、音高数据下载链接信息等。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public BatchDescribeKTVMusicDetailsResponse BatchDescribeKTVMusicDetailsSync(BatchDescribeKTVMusicDetailsRequest req)
        {
            return InternalRequestAsync<BatchDescribeKTVMusicDetailsResponse>(req, "BatchDescribeKTVMusicDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public Task<CreateKTVRobotResponse> CreateKTVRobot(CreateKTVRobotRequest req)
        {
            return InternalRequestAsync<CreateKTVRobotResponse>(req, "CreateKTVRobot");
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public CreateKTVRobotResponse CreateKTVRobotSync(CreateKTVRobotRequest req)
        {
            return InternalRequestAsync<CreateKTVRobotResponse>(req, "CreateKTVRobot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据输入的规则匹配曲库中的歌曲。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMatchMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVMatchMusicsResponse"/></returns>
        public Task<DescribeKTVMatchMusicsResponse> DescribeKTVMatchMusics(DescribeKTVMatchMusicsRequest req)
        {
            return InternalRequestAsync<DescribeKTVMatchMusicsResponse>(req, "DescribeKTVMatchMusics");
        }

        /// <summary>
        /// 根据输入的规则匹配曲库中的歌曲。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMatchMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVMatchMusicsResponse"/></returns>
        public DescribeKTVMatchMusicsResponse DescribeKTVMatchMusicsSync(DescribeKTVMatchMusicsRequest req)
        {
            return InternalRequestAsync<DescribeKTVMatchMusicsResponse>(req, "DescribeKTVMatchMusics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取歌曲伴奏片段链接，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlResponse"/></returns>
        public Task<DescribeKTVMusicAccompanySegmentUrlResponse> DescribeKTVMusicAccompanySegmentUrl(DescribeKTVMusicAccompanySegmentUrlRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicAccompanySegmentUrlResponse>(req, "DescribeKTVMusicAccompanySegmentUrl");
        }

        /// <summary>
        /// 获取歌曲伴奏片段链接，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlResponse"/></returns>
        public DescribeKTVMusicAccompanySegmentUrlResponse DescribeKTVMusicAccompanySegmentUrlSync(DescribeKTVMusicAccompanySegmentUrlRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicAccompanySegmentUrlResponse>(req, "DescribeKTVMusicAccompanySegmentUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取歌曲伴奏高潮的开始、结束时间，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlVipRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlVipResponse"/></returns>
        public Task<DescribeKTVMusicAccompanySegmentUrlVipResponse> DescribeKTVMusicAccompanySegmentUrlVip(DescribeKTVMusicAccompanySegmentUrlVipRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicAccompanySegmentUrlVipResponse>(req, "DescribeKTVMusicAccompanySegmentUrlVip");
        }

        /// <summary>
        /// 获取歌曲伴奏高潮的开始、结束时间，可用于抢唱
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicAccompanySegmentUrlVipRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicAccompanySegmentUrlVipResponse"/></returns>
        public DescribeKTVMusicAccompanySegmentUrlVipResponse DescribeKTVMusicAccompanySegmentUrlVipSync(DescribeKTVMusicAccompanySegmentUrlVipRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicAccompanySegmentUrlVipResponse>(req, "DescribeKTVMusicAccompanySegmentUrlVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过标签过滤歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicsByTagRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicsByTagResponse"/></returns>
        public Task<DescribeKTVMusicsByTagResponse> DescribeKTVMusicsByTag(DescribeKTVMusicsByTagRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicsByTagResponse>(req, "DescribeKTVMusicsByTag");
        }

        /// <summary>
        /// 通过标签过滤歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicsByTagRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicsByTagResponse"/></returns>
        public DescribeKTVMusicsByTagResponse DescribeKTVMusicsByTagSync(DescribeKTVMusicsByTagRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicsByTagResponse>(req, "DescribeKTVMusicsByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public Task<DescribeKTVPlaylistDetailResponse> DescribeKTVPlaylistDetail(DescribeKTVPlaylistDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistDetailResponse>(req, "DescribeKTVPlaylistDetail");
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public DescribeKTVPlaylistDetailResponse DescribeKTVPlaylistDetailSync(DescribeKTVPlaylistDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistDetailResponse>(req, "DescribeKTVPlaylistDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取歌单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistsRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistsResponse"/></returns>
        public Task<DescribeKTVPlaylistsResponse> DescribeKTVPlaylists(DescribeKTVPlaylistsRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistsResponse>(req, "DescribeKTVPlaylists");
        }

        /// <summary>
        /// 获取歌单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistsRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistsResponse"/></returns>
        public DescribeKTVPlaylistsResponse DescribeKTVPlaylistsSync(DescribeKTVPlaylistsRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistsResponse>(req, "DescribeKTVPlaylists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机器人列表，支持 Id、状态等过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVRobotsRequest"/></param>
        /// <returns><see cref="DescribeKTVRobotsResponse"/></returns>
        public Task<DescribeKTVRobotsResponse> DescribeKTVRobots(DescribeKTVRobotsRequest req)
        {
            return InternalRequestAsync<DescribeKTVRobotsResponse>(req, "DescribeKTVRobots");
        }

        /// <summary>
        /// 获取机器人列表，支持 Id、状态等过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVRobotsRequest"/></param>
        /// <returns><see cref="DescribeKTVRobotsResponse"/></returns>
        public DescribeKTVRobotsResponse DescribeKTVRobotsSync(DescribeKTVRobotsRequest req)
        {
            return InternalRequestAsync<DescribeKTVRobotsResponse>(req, "DescribeKTVRobots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据关键词获取联想词列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public Task<DescribeKTVSuggestionsResponse> DescribeKTVSuggestions(DescribeKTVSuggestionsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSuggestionsResponse>(req, "DescribeKTVSuggestions");
        }

        /// <summary>
        /// 根据关键词获取联想词列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public DescribeKTVSuggestionsResponse DescribeKTVSuggestionsSync(DescribeKTVSuggestionsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSuggestionsResponse>(req, "DescribeKTVSuggestions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取标签分组及分组下的标签列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVTagsResponse"/></returns>
        public Task<DescribeKTVTagsResponse> DescribeKTVTags(DescribeKTVTagsRequest req)
        {
            return InternalRequestAsync<DescribeKTVTagsResponse>(req, "DescribeKTVTags");
        }

        /// <summary>
        /// 获取标签分组及分组下的标签列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVTagsResponse"/></returns>
        public DescribeKTVTagsResponse DescribeKTVTagsSync(DescribeKTVTagsRequest req)
        {
            return InternalRequestAsync<DescribeKTVTagsResponse>(req, "DescribeKTVTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取直播会员充值流水详细信息，包括：流水号，订单状态，下订单时间等
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVipTradeInfosRequest"/></param>
        /// <returns><see cref="DescribeLiveVipTradeInfosResponse"/></returns>
        public Task<DescribeLiveVipTradeInfosResponse> DescribeLiveVipTradeInfos(DescribeLiveVipTradeInfosRequest req)
        {
            return InternalRequestAsync<DescribeLiveVipTradeInfosResponse>(req, "DescribeLiveVipTradeInfos");
        }

        /// <summary>
        /// 批量获取直播会员充值流水详细信息，包括：流水号，订单状态，下订单时间等
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVipTradeInfosRequest"/></param>
        /// <returns><see cref="DescribeLiveVipTradeInfosResponse"/></returns>
        public DescribeLiveVipTradeInfosResponse DescribeLiveVipTradeInfosSync(DescribeLiveVipTradeInfosRequest req)
        {
            return InternalRequestAsync<DescribeLiveVipTradeInfosResponse>(req, "DescribeLiveVipTradeInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户信息，包括是否为直播会员，及直播会员信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// 获取用户信息，包括是否为直播会员，及直播会员信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取会员信息：获取用户是否开通会员
        /// </summary>
        /// <param name="req"><see cref="DescribeVipUserInfoRequest"/></param>
        /// <returns><see cref="DescribeVipUserInfoResponse"/></returns>
        public Task<DescribeVipUserInfoResponse> DescribeVipUserInfo(DescribeVipUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipUserInfoResponse>(req, "DescribeVipUserInfo");
        }

        /// <summary>
        /// 获取会员信息：获取用户是否开通会员
        /// </summary>
        /// <param name="req"><see cref="DescribeVipUserInfoRequest"/></param>
        /// <returns><see cref="DescribeVipUserInfoResponse"/></returns>
        public DescribeVipUserInfoResponse DescribeVipUserInfoSync(DescribeVipUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipUserInfoResponse>(req, "DescribeVipUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁机器人，机器人退出 RTC 房间。
        /// </summary>
        /// <param name="req"><see cref="DestroyKTVRobotRequest"/></param>
        /// <returns><see cref="DestroyKTVRobotResponse"/></returns>
        public Task<DestroyKTVRobotResponse> DestroyKTVRobot(DestroyKTVRobotRequest req)
        {
            return InternalRequestAsync<DestroyKTVRobotResponse>(req, "DestroyKTVRobot");
        }

        /// <summary>
        /// 销毁机器人，机器人退出 RTC 房间。
        /// </summary>
        /// <param name="req"><see cref="DestroyKTVRobotRequest"/></param>
        /// <returns><see cref="DestroyKTVRobotResponse"/></returns>
        public DestroyKTVRobotResponse DestroyKTVRobotSync(DestroyKTVRobotRequest req)
        {
            return InternalRequestAsync<DestroyKTVRobotResponse>(req, "DestroyKTVRobot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 充值直播会员，使该用户可以在直播场景使用
        /// </summary>
        /// <param name="req"><see cref="RechargeLiveVipRequest"/></param>
        /// <returns><see cref="RechargeLiveVipResponse"/></returns>
        public Task<RechargeLiveVipResponse> RechargeLiveVip(RechargeLiveVipRequest req)
        {
            return InternalRequestAsync<RechargeLiveVipResponse>(req, "RechargeLiveVip");
        }

        /// <summary>
        /// 充值直播会员，使该用户可以在直播场景使用
        /// </summary>
        /// <param name="req"><see cref="RechargeLiveVipRequest"/></param>
        /// <returns><see cref="RechargeLiveVipResponse"/></returns>
        public RechargeLiveVipResponse RechargeLiveVipSync(RechargeLiveVipRequest req)
        {
            return InternalRequestAsync<RechargeLiveVipResponse>(req, "RechargeLiveVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 充值会员
        /// </summary>
        /// <param name="req"><see cref="RechargeVipRequest"/></param>
        /// <returns><see cref="RechargeVipResponse"/></returns>
        public Task<RechargeVipResponse> RechargeVip(RechargeVipRequest req)
        {
            return InternalRequestAsync<RechargeVipResponse>(req, "RechargeVip");
        }

        /// <summary>
        /// 充值会员
        /// </summary>
        /// <param name="req"><see cref="RechargeVipRequest"/></param>
        /// <returns><see cref="RechargeVipResponse"/></returns>
        public RechargeVipResponse RechargeVipSync(RechargeVipRequest req)
        {
            return InternalRequestAsync<RechargeVipResponse>(req, "RechargeVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据关键词搜索歌曲，返回相关歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="SearchKTVMusicsRequest"/></param>
        /// <returns><see cref="SearchKTVMusicsResponse"/></returns>
        public Task<SearchKTVMusicsResponse> SearchKTVMusics(SearchKTVMusicsRequest req)
        {
            return InternalRequestAsync<SearchKTVMusicsResponse>(req, "SearchKTVMusics");
        }

        /// <summary>
        /// 根据关键词搜索歌曲，返回相关歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="SearchKTVMusicsRequest"/></param>
        /// <returns><see cref="SearchKTVMusicsResponse"/></returns>
        public SearchKTVMusicsResponse SearchKTVMusicsSync(SearchKTVMusicsRequest req)
        {
            return InternalRequestAsync<SearchKTVMusicsResponse>(req, "SearchKTVMusics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下发操作机器人指令，支持播放、暂停、恢复、歌单设置等操作指令，实现对机器人行为的控制。
        /// </summary>
        /// <param name="req"><see cref="SyncKTVRobotCommandRequest"/></param>
        /// <returns><see cref="SyncKTVRobotCommandResponse"/></returns>
        public Task<SyncKTVRobotCommandResponse> SyncKTVRobotCommand(SyncKTVRobotCommandRequest req)
        {
            return InternalRequestAsync<SyncKTVRobotCommandResponse>(req, "SyncKTVRobotCommand");
        }

        /// <summary>
        /// 下发操作机器人指令，支持播放、暂停、恢复、歌单设置等操作指令，实现对机器人行为的控制。
        /// </summary>
        /// <param name="req"><see cref="SyncKTVRobotCommandRequest"/></param>
        /// <returns><see cref="SyncKTVRobotCommandResponse"/></returns>
        public SyncKTVRobotCommandResponse SyncKTVRobotCommandSync(SyncKTVRobotCommandRequest req)
        {
            return InternalRequestAsync<SyncKTVRobotCommandResponse>(req, "SyncKTVRobotCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
