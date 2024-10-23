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

namespace TencentCloud.Ame.V20190916
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ame.V20190916.Models;

   public class AmeClient : AbstractClient{

       private const string endpoint = "ame.tencentcloudapi.com";
       private const string version = "2019-09-16";
       private const string sdkVersion = "SDK_NET_3.0.1112";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 根据 Id 列表查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public Task<BatchDescribeKTVMusicDetailsResponse> BatchDescribeKTVMusicDetails(BatchDescribeKTVMusicDetailsRequest req)
        {
            return InternalRequestAsync<BatchDescribeKTVMusicDetailsResponse>(req, "BatchDescribeKTVMusicDetails");
        }

        /// <summary>
        /// 根据 Id 列表查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeKTVMusicDetailsRequest"/></param>
        /// <returns><see cref="BatchDescribeKTVMusicDetailsResponse"/></returns>
        public BatchDescribeKTVMusicDetailsResponse BatchDescribeKTVMusicDetailsSync(BatchDescribeKTVMusicDetailsRequest req)
        {
            return InternalRequestAsync<BatchDescribeKTVMusicDetailsResponse>(req, "BatchDescribeKTVMusicDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放直播互动曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public Task<CreateKTVRobotResponse> CreateKTVRobot(CreateKTVRobotRequest req)
        {
            return InternalRequestAsync<CreateKTVRobotResponse>(req, "CreateKTVRobot");
        }

        /// <summary>
        /// 创建机器人，支持进入 RTC 房间，播放直播互动曲库歌曲。
        /// </summary>
        /// <param name="req"><see cref="CreateKTVRobotRequest"/></param>
        /// <returns><see cref="CreateKTVRobotResponse"/></returns>
        public CreateKTVRobotResponse CreateKTVRobotSync(CreateKTVRobotRequest req)
        {
            return InternalRequestAsync<CreateKTVRobotResponse>(req, "CreateKTVRobot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取授权项目信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeAuthInfoResponse"/></returns>
        public Task<DescribeAuthInfoResponse> DescribeAuthInfo(DescribeAuthInfoRequest req)
        {
            return InternalRequestAsync<DescribeAuthInfoResponse>(req, "DescribeAuthInfo");
        }

        /// <summary>
        /// 获取授权项目信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeAuthInfoResponse"/></returns>
        public DescribeAuthInfoResponse DescribeAuthInfoSync(DescribeAuthInfoRequest req)
        {
            return InternalRequestAsync<DescribeAuthInfoResponse>(req, "DescribeAuthInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云音乐播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicResponse"/></returns>
        public Task<DescribeCloudMusicResponse> DescribeCloudMusic(DescribeCloudMusicRequest req)
        {
            return InternalRequestAsync<DescribeCloudMusicResponse>(req, "DescribeCloudMusic");
        }

        /// <summary>
        /// 获取云音乐播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicResponse"/></returns>
        public DescribeCloudMusicResponse DescribeCloudMusicSync(DescribeCloudMusicRequest req)
        {
            return InternalRequestAsync<DescribeCloudMusicResponse>(req, "DescribeCloudMusic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取授权项目下已购云音乐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicPurchasedRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicPurchasedResponse"/></returns>
        public Task<DescribeCloudMusicPurchasedResponse> DescribeCloudMusicPurchased(DescribeCloudMusicPurchasedRequest req)
        {
            return InternalRequestAsync<DescribeCloudMusicPurchasedResponse>(req, "DescribeCloudMusicPurchased");
        }

        /// <summary>
        /// 获取授权项目下已购云音乐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicPurchasedRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicPurchasedResponse"/></returns>
        public DescribeCloudMusicPurchasedResponse DescribeCloudMusicPurchasedSync(DescribeCloudMusicPurchasedRequest req)
        {
            return InternalRequestAsync<DescribeCloudMusicPurchasedResponse>(req, "DescribeCloudMusicPurchased")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据歌曲ID查询歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribeItemByIdRequest"/></param>
        /// <returns><see cref="DescribeItemByIdResponse"/></returns>
        public Task<DescribeItemByIdResponse> DescribeItemById(DescribeItemByIdRequest req)
        {
            return InternalRequestAsync<DescribeItemByIdResponse>(req, "DescribeItemById");
        }

        /// <summary>
        /// 根据歌曲ID查询歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribeItemByIdRequest"/></param>
        /// <returns><see cref="DescribeItemByIdResponse"/></returns>
        public DescribeItemByIdResponse DescribeItemByIdSync(DescribeItemByIdRequest req)
        {
            return InternalRequestAsync<DescribeItemByIdResponse>(req, "DescribeItemById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeItemsRequest"/></param>
        /// <returns><see cref="DescribeItemsResponse"/></returns>
        public Task<DescribeItemsResponse> DescribeItems(DescribeItemsRequest req)
        {
            return InternalRequestAsync<DescribeItemsResponse>(req, "DescribeItems");
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeItemsRequest"/></param>
        /// <returns><see cref="DescribeItemsResponse"/></returns>
        public DescribeItemsResponse DescribeItemsSync(DescribeItemsRequest req)
        {
            return InternalRequestAsync<DescribeItemsResponse>(req, "DescribeItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据 Id 查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicDetailResponse"/></returns>
        public Task<DescribeKTVMusicDetailResponse> DescribeKTVMusicDetail(DescribeKTVMusicDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicDetailResponse>(req, "DescribeKTVMusicDetail");
        }

        /// <summary>
        /// 根据 Id 查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicDetailResponse"/></returns>
        public DescribeKTVMusicDetailResponse DescribeKTVMusicDetailSync(DescribeKTVMusicDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicDetailResponse>(req, "DescribeKTVMusicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播互动曲库标签分组信息和标签信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicTagsResponse"/></returns>
        public Task<DescribeKTVMusicTagsResponse> DescribeKTVMusicTags(DescribeKTVMusicTagsRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicTagsResponse>(req, "DescribeKTVMusicTags");
        }

        /// <summary>
        /// 获取直播互动曲库标签分组信息和标签信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicTagsRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicTagsResponse"/></returns>
        public DescribeKTVMusicTagsResponse DescribeKTVMusicTagsSync(DescribeKTVMusicTagsRequest req)
        {
            return InternalRequestAsync<DescribeKTVMusicTagsResponse>(req, "DescribeKTVMusicTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情，包括歌单的基础信息以及歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public Task<DescribeKTVPlaylistDetailResponse> DescribeKTVPlaylistDetail(DescribeKTVPlaylistDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistDetailResponse>(req, "DescribeKTVPlaylistDetail");
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情，包括歌单的基础信息以及歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistDetailResponse"/></returns>
        public DescribeKTVPlaylistDetailResponse DescribeKTVPlaylistDetailSync(DescribeKTVPlaylistDetailRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistDetailResponse>(req, "DescribeKTVPlaylistDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播互动曲库推荐歌单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVPlaylistsRequest"/></param>
        /// <returns><see cref="DescribeKTVPlaylistsResponse"/></returns>
        public Task<DescribeKTVPlaylistsResponse> DescribeKTVPlaylists(DescribeKTVPlaylistsRequest req)
        {
            return InternalRequestAsync<DescribeKTVPlaylistsResponse>(req, "DescribeKTVPlaylists");
        }

        /// <summary>
        /// 获取直播互动曲库推荐歌单列表。
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
        /// 获取直播互动曲库歌手分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingerCategoriesRequest"/></param>
        /// <returns><see cref="DescribeKTVSingerCategoriesResponse"/></returns>
        public Task<DescribeKTVSingerCategoriesResponse> DescribeKTVSingerCategories(DescribeKTVSingerCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingerCategoriesResponse>(req, "DescribeKTVSingerCategories");
        }

        /// <summary>
        /// 获取直播互动曲库歌手分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingerCategoriesRequest"/></param>
        /// <returns><see cref="DescribeKTVSingerCategoriesResponse"/></returns>
        public DescribeKTVSingerCategoriesResponse DescribeKTVSingerCategoriesSync(DescribeKTVSingerCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingerCategoriesResponse>(req, "DescribeKTVSingerCategories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据歌手id，返回该歌手下歌曲列表。
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingerMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVSingerMusicsResponse"/></returns>
        public Task<DescribeKTVSingerMusicsResponse> DescribeKTVSingerMusics(DescribeKTVSingerMusicsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingerMusicsResponse>(req, "DescribeKTVSingerMusics");
        }

        /// <summary>
        /// 根据歌手id，返回该歌手下歌曲列表。
        /// 
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingerMusicsRequest"/></param>
        /// <returns><see cref="DescribeKTVSingerMusicsResponse"/></returns>
        public DescribeKTVSingerMusicsResponse DescribeKTVSingerMusicsSync(DescribeKTVSingerMusicsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingerMusicsResponse>(req, "DescribeKTVSingerMusics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据过滤条件，返回匹配的歌手列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingersRequest"/></param>
        /// <returns><see cref="DescribeKTVSingersResponse"/></returns>
        public Task<DescribeKTVSingersResponse> DescribeKTVSingers(DescribeKTVSingersRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingersResponse>(req, "DescribeKTVSingers");
        }

        /// <summary>
        /// 根据过滤条件，返回匹配的歌手列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSingersRequest"/></param>
        /// <returns><see cref="DescribeKTVSingersResponse"/></returns>
        public DescribeKTVSingersResponse DescribeKTVSingersSync(DescribeKTVSingersRequest req)
        {
            return InternalRequestAsync<DescribeKTVSingersResponse>(req, "DescribeKTVSingers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播互动曲库联想词
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public Task<DescribeKTVSuggestionsResponse> DescribeKTVSuggestions(DescribeKTVSuggestionsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSuggestionsResponse>(req, "DescribeKTVSuggestions");
        }

        /// <summary>
        /// 获取直播互动曲库联想词
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVSuggestionsRequest"/></param>
        /// <returns><see cref="DescribeKTVSuggestionsResponse"/></returns>
        public DescribeKTVSuggestionsResponse DescribeKTVSuggestionsSync(DescribeKTVSuggestionsRequest req)
        {
            return InternalRequestAsync<DescribeKTVSuggestionsResponse>(req, "DescribeKTVSuggestions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播互动曲库歌曲的周榜和月榜
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTopListRequest"/></param>
        /// <returns><see cref="DescribeKTVTopListResponse"/></returns>
        public Task<DescribeKTVTopListResponse> DescribeKTVTopList(DescribeKTVTopListRequest req)
        {
            return InternalRequestAsync<DescribeKTVTopListResponse>(req, "DescribeKTVTopList");
        }

        /// <summary>
        /// 获取直播互动曲库歌曲的周榜和月榜
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVTopListRequest"/></param>
        /// <returns><see cref="DescribeKTVTopListResponse"/></returns>
        public DescribeKTVTopListResponse DescribeKTVTopListSync(DescribeKTVTopListRequest req)
        {
            return InternalRequestAsync<DescribeKTVTopListResponse>(req, "DescribeKTVTopList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据接口的模式及歌曲ID来取得歌词信息或者波形图信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLyricRequest"/></param>
        /// <returns><see cref="DescribeLyricResponse"/></returns>
        public Task<DescribeLyricResponse> DescribeLyric(DescribeLyricRequest req)
        {
            return InternalRequestAsync<DescribeLyricResponse>(req, "DescribeLyric");
        }

        /// <summary>
        /// 根据接口的模式及歌曲ID来取得歌词信息或者波形图信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLyricRequest"/></param>
        /// <returns><see cref="DescribeLyricResponse"/></returns>
        public DescribeLyricResponse DescribeLyricSync(DescribeLyricRequest req)
        {
            return InternalRequestAsync<DescribeLyricResponse>(req, "DescribeLyric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取曲库包歌曲播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicRequest"/></param>
        /// <returns><see cref="DescribeMusicResponse"/></returns>
        public Task<DescribeMusicResponse> DescribeMusic(DescribeMusicRequest req)
        {
            return InternalRequestAsync<DescribeMusicResponse>(req, "DescribeMusic");
        }

        /// <summary>
        /// 获取曲库包歌曲播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicRequest"/></param>
        /// <returns><see cref="DescribeMusicResponse"/></returns>
        public DescribeMusicResponse DescribeMusicSync(DescribeMusicRequest req)
        {
            return InternalRequestAsync<DescribeMusicResponse>(req, "DescribeMusic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据音乐信息查询音乐是否在售
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicSaleStatusRequest"/></param>
        /// <returns><see cref="DescribeMusicSaleStatusResponse"/></returns>
        public Task<DescribeMusicSaleStatusResponse> DescribeMusicSaleStatus(DescribeMusicSaleStatusRequest req)
        {
            return InternalRequestAsync<DescribeMusicSaleStatusResponse>(req, "DescribeMusicSaleStatus");
        }

        /// <summary>
        /// 根据音乐信息查询音乐是否在售
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicSaleStatusRequest"/></param>
        /// <returns><see cref="DescribeMusicSaleStatusResponse"/></returns>
        public DescribeMusicSaleStatusResponse DescribeMusicSaleStatusSync(DescribeMusicSaleStatusRequest req)
        {
            return InternalRequestAsync<DescribeMusicSaleStatusResponse>(req, "DescribeMusicSaleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取曲库包下已核销歌曲列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackageItemsRequest"/></param>
        /// <returns><see cref="DescribePackageItemsResponse"/></returns>
        public Task<DescribePackageItemsResponse> DescribePackageItems(DescribePackageItemsRequest req)
        {
            return InternalRequestAsync<DescribePackageItemsResponse>(req, "DescribePackageItems");
        }

        /// <summary>
        /// 获取曲库包下已核销歌曲列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackageItemsRequest"/></param>
        /// <returns><see cref="DescribePackageItemsResponse"/></returns>
        public DescribePackageItemsResponse DescribePackageItemsSync(DescribePackageItemsRequest req)
        {
            return InternalRequestAsync<DescribePackageItemsResponse>(req, "DescribePackageItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取已购曲库包列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public Task<DescribePackagesResponse> DescribePackages(DescribePackagesRequest req)
        {
            return InternalRequestAsync<DescribePackagesResponse>(req, "DescribePackages");
        }

        /// <summary>
        /// 获取已购曲库包列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public DescribePackagesResponse DescribePackagesSync(DescribePackagesRequest req)
        {
            return InternalRequestAsync<DescribePackagesResponse>(req, "DescribePackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据购买曲库包用户可查询已回退的歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribePkgOfflineMusicRequest"/></param>
        /// <returns><see cref="DescribePkgOfflineMusicResponse"/></returns>
        public Task<DescribePkgOfflineMusicResponse> DescribePkgOfflineMusic(DescribePkgOfflineMusicRequest req)
        {
            return InternalRequestAsync<DescribePkgOfflineMusicResponse>(req, "DescribePkgOfflineMusic");
        }

        /// <summary>
        /// 根据购买曲库包用户可查询已回退的歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribePkgOfflineMusicRequest"/></param>
        /// <returns><see cref="DescribePkgOfflineMusicResponse"/></returns>
        public DescribePkgOfflineMusicResponse DescribePkgOfflineMusicSync(DescribePkgOfflineMusicRequest req)
        {
            return InternalRequestAsync<DescribePkgOfflineMusicResponse>(req, "DescribePkgOfflineMusic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeStationsRequest"/></param>
        /// <returns><see cref="DescribeStationsResponse"/></returns>
        public Task<DescribeStationsResponse> DescribeStations(DescribeStationsRequest req)
        {
            return InternalRequestAsync<DescribeStationsResponse>(req, "DescribeStations");
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeStationsRequest"/></param>
        /// <returns><see cref="DescribeStationsResponse"/></returns>
        public DescribeStationsResponse DescribeStationsSync(DescribeStationsRequest req)
        {
            return InternalRequestAsync<DescribeStationsResponse>(req, "DescribeStations")
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
        /// 根据资源方，需要变更的参数，请求该接口进行变更，为空的参数默认为无变更
        /// </summary>
        /// <param name="req"><see cref="ModifyMusicOnShelvesRequest"/></param>
        /// <returns><see cref="ModifyMusicOnShelvesResponse"/></returns>
        public Task<ModifyMusicOnShelvesResponse> ModifyMusicOnShelves(ModifyMusicOnShelvesRequest req)
        {
            return InternalRequestAsync<ModifyMusicOnShelvesResponse>(req, "ModifyMusicOnShelves");
        }

        /// <summary>
        /// 根据资源方，需要变更的参数，请求该接口进行变更，为空的参数默认为无变更
        /// </summary>
        /// <param name="req"><see cref="ModifyMusicOnShelvesRequest"/></param>
        /// <returns><see cref="ModifyMusicOnShelvesResponse"/></returns>
        public ModifyMusicOnShelvesResponse ModifyMusicOnShelvesSync(ModifyMusicOnShelvesRequest req)
        {
            return InternalRequestAsync<ModifyMusicOnShelvesResponse>(req, "ModifyMusicOnShelves")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据资源方所传歌曲信息，进行歌曲上架，多个歌曲同时请求时，需构造复合结构进行请求
        /// </summary>
        /// <param name="req"><see cref="PutMusicOnTheShelvesRequest"/></param>
        /// <returns><see cref="PutMusicOnTheShelvesResponse"/></returns>
        public Task<PutMusicOnTheShelvesResponse> PutMusicOnTheShelves(PutMusicOnTheShelvesRequest req)
        {
            return InternalRequestAsync<PutMusicOnTheShelvesResponse>(req, "PutMusicOnTheShelves");
        }

        /// <summary>
        /// 根据资源方所传歌曲信息，进行歌曲上架，多个歌曲同时请求时，需构造复合结构进行请求
        /// </summary>
        /// <param name="req"><see cref="PutMusicOnTheShelvesRequest"/></param>
        /// <returns><see cref="PutMusicOnTheShelvesResponse"/></returns>
        public PutMusicOnTheShelvesResponse PutMusicOnTheShelvesSync(PutMusicOnTheShelvesRequest req)
        {
            return InternalRequestAsync<PutMusicOnTheShelvesResponse>(req, "PutMusicOnTheShelves")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户上报用户数据功能，为了更好地为用户提供优质服务
        /// </summary>
        /// <param name="req"><see cref="ReportDataRequest"/></param>
        /// <returns><see cref="ReportDataResponse"/></returns>
        public Task<ReportDataResponse> ReportData(ReportDataRequest req)
        {
            return InternalRequestAsync<ReportDataResponse>(req, "ReportData");
        }

        /// <summary>
        /// 客户上报用户数据功能，为了更好地为用户提供优质服务
        /// </summary>
        /// <param name="req"><see cref="ReportDataRequest"/></param>
        /// <returns><see cref="ReportDataResponse"/></returns>
        public ReportDataResponse ReportDataSync(ReportDataRequest req)
        {
            return InternalRequestAsync<ReportDataResponse>(req, "ReportData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据搜索条件，返回匹配的歌曲列表。
        /// </summary>
        /// <param name="req"><see cref="SearchKTVMusicsRequest"/></param>
        /// <returns><see cref="SearchKTVMusicsResponse"/></returns>
        public Task<SearchKTVMusicsResponse> SearchKTVMusics(SearchKTVMusicsRequest req)
        {
            return InternalRequestAsync<SearchKTVMusicsResponse>(req, "SearchKTVMusics");
        }

        /// <summary>
        /// 根据搜索条件，返回匹配的歌曲列表。
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

        /// <summary>
        /// 根据资源方所传MusicId进行将歌曲进行下架，多个MusicId使用逗号隔开
        /// </summary>
        /// <param name="req"><see cref="TakeMusicOffShelvesRequest"/></param>
        /// <returns><see cref="TakeMusicOffShelvesResponse"/></returns>
        public Task<TakeMusicOffShelvesResponse> TakeMusicOffShelves(TakeMusicOffShelvesRequest req)
        {
            return InternalRequestAsync<TakeMusicOffShelvesResponse>(req, "TakeMusicOffShelves");
        }

        /// <summary>
        /// 根据资源方所传MusicId进行将歌曲进行下架，多个MusicId使用逗号隔开
        /// </summary>
        /// <param name="req"><see cref="TakeMusicOffShelvesRequest"/></param>
        /// <returns><see cref="TakeMusicOffShelvesResponse"/></returns>
        public TakeMusicOffShelvesResponse TakeMusicOffShelvesSync(TakeMusicOffShelvesRequest req)
        {
            return InternalRequestAsync<TakeMusicOffShelvesResponse>(req, "TakeMusicOffShelves")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
