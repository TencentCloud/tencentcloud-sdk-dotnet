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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 获取授权项目信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeAuthInfoResponse"/></returns>
        public async Task<DescribeAuthInfoResponse> DescribeAuthInfo(DescribeAuthInfoRequest req)
        {
             JsonResponseModel<DescribeAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取授权项目信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeAuthInfoResponse"/></returns>
        public DescribeAuthInfoResponse DescribeAuthInfoSync(DescribeAuthInfoRequest req)
        {
             JsonResponseModel<DescribeAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云音乐播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicResponse"/></returns>
        public async Task<DescribeCloudMusicResponse> DescribeCloudMusic(DescribeCloudMusicRequest req)
        {
             JsonResponseModel<DescribeCloudMusicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudMusic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudMusicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云音乐播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicResponse"/></returns>
        public DescribeCloudMusicResponse DescribeCloudMusicSync(DescribeCloudMusicRequest req)
        {
             JsonResponseModel<DescribeCloudMusicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudMusic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudMusicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取授权项目下已购云音乐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicPurchasedRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicPurchasedResponse"/></returns>
        public async Task<DescribeCloudMusicPurchasedResponse> DescribeCloudMusicPurchased(DescribeCloudMusicPurchasedRequest req)
        {
             JsonResponseModel<DescribeCloudMusicPurchasedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudMusicPurchased");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudMusicPurchasedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取授权项目下已购云音乐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudMusicPurchasedRequest"/></param>
        /// <returns><see cref="DescribeCloudMusicPurchasedResponse"/></returns>
        public DescribeCloudMusicPurchasedResponse DescribeCloudMusicPurchasedSync(DescribeCloudMusicPurchasedRequest req)
        {
             JsonResponseModel<DescribeCloudMusicPurchasedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudMusicPurchased");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudMusicPurchasedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据歌曲ID查询歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribeItemByIdRequest"/></param>
        /// <returns><see cref="DescribeItemByIdResponse"/></returns>
        public async Task<DescribeItemByIdResponse> DescribeItemById(DescribeItemByIdRequest req)
        {
             JsonResponseModel<DescribeItemByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeItemById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeItemByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据歌曲ID查询歌曲信息
        /// </summary>
        /// <param name="req"><see cref="DescribeItemByIdRequest"/></param>
        /// <returns><see cref="DescribeItemByIdResponse"/></returns>
        public DescribeItemByIdResponse DescribeItemByIdSync(DescribeItemByIdRequest req)
        {
             JsonResponseModel<DescribeItemByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeItemById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeItemByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeItemsRequest"/></param>
        /// <returns><see cref="DescribeItemsResponse"/></returns>
        public async Task<DescribeItemsResponse> DescribeItems(DescribeItemsRequest req)
        {
             JsonResponseModel<DescribeItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeItemsRequest"/></param>
        /// <returns><see cref="DescribeItemsResponse"/></returns>
        public DescribeItemsResponse DescribeItemsSync(DescribeItemsRequest req)
        {
             JsonResponseModel<DescribeItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据 Id 查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicDetailResponse"/></returns>
        public async Task<DescribeKTVMusicDetailResponse> DescribeKTVMusicDetail(DescribeKTVMusicDetailRequest req)
        {
             JsonResponseModel<DescribeKTVMusicDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKTVMusicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据 Id 查询歌曲的详细信息，包含基础信息及播放信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeKTVMusicDetailRequest"/></param>
        /// <returns><see cref="DescribeKTVMusicDetailResponse"/></returns>
        public DescribeKTVMusicDetailResponse DescribeKTVMusicDetailSync(DescribeKTVMusicDetailRequest req)
        {
             JsonResponseModel<DescribeKTVMusicDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKTVMusicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKTVMusicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据歌单 Id 获取歌单详情，包括歌单的基础信息以及歌曲列表。
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
        /// 根据歌单 Id 获取歌单详情，包括歌单的基础信息以及歌曲列表。
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
        /// 获取即时广播曲库推荐歌单列表。
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
        /// 获取即时广播曲库推荐歌单列表。
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
        /// 根据接口的模式及歌曲ID来取得歌词信息或者波形图信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLyricRequest"/></param>
        /// <returns><see cref="DescribeLyricResponse"/></returns>
        public async Task<DescribeLyricResponse> DescribeLyric(DescribeLyricRequest req)
        {
             JsonResponseModel<DescribeLyricResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLyric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLyricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据接口的模式及歌曲ID来取得歌词信息或者波形图信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLyricRequest"/></param>
        /// <returns><see cref="DescribeLyricResponse"/></returns>
        public DescribeLyricResponse DescribeLyricSync(DescribeLyricRequest req)
        {
             JsonResponseModel<DescribeLyricResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLyric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLyricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取曲库包歌曲播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicRequest"/></param>
        /// <returns><see cref="DescribeMusicResponse"/></returns>
        public async Task<DescribeMusicResponse> DescribeMusic(DescribeMusicRequest req)
        {
             JsonResponseModel<DescribeMusicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMusic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMusicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取曲库包歌曲播放信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMusicRequest"/></param>
        /// <returns><see cref="DescribeMusicResponse"/></returns>
        public DescribeMusicResponse DescribeMusicSync(DescribeMusicRequest req)
        {
             JsonResponseModel<DescribeMusicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMusic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMusicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取曲库包下已核销歌曲列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackageItemsRequest"/></param>
        /// <returns><see cref="DescribePackageItemsResponse"/></returns>
        public async Task<DescribePackageItemsResponse> DescribePackageItems(DescribePackageItemsRequest req)
        {
             JsonResponseModel<DescribePackageItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackageItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackageItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取曲库包下已核销歌曲列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackageItemsRequest"/></param>
        /// <returns><see cref="DescribePackageItemsResponse"/></returns>
        public DescribePackageItemsResponse DescribePackageItemsSync(DescribePackageItemsRequest req)
        {
             JsonResponseModel<DescribePackageItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackageItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackageItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已购曲库包列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public async Task<DescribePackagesResponse> DescribePackages(DescribePackagesRequest req)
        {
             JsonResponseModel<DescribePackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已购曲库包列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribePackagesRequest"/></param>
        /// <returns><see cref="DescribePackagesResponse"/></returns>
        public DescribePackagesResponse DescribePackagesSync(DescribePackagesRequest req)
        {
             JsonResponseModel<DescribePackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeStationsRequest"/></param>
        /// <returns><see cref="DescribeStationsResponse"/></returns>
        public async Task<DescribeStationsResponse> DescribeStations(DescribeStationsRequest req)
        {
             JsonResponseModel<DescribeStationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该服务后续会停用，不再建议使用
        /// </summary>
        /// <param name="req"><see cref="DescribeStationsRequest"/></param>
        /// <returns><see cref="DescribeStationsResponse"/></returns>
        public DescribeStationsResponse DescribeStationsSync(DescribeStationsRequest req)
        {
             JsonResponseModel<DescribeStationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据资源方，需要变更的参数，请求该接口进行变更，为空的参数默认为无变更
        /// </summary>
        /// <param name="req"><see cref="ModifyMusicOnShelvesRequest"/></param>
        /// <returns><see cref="ModifyMusicOnShelvesResponse"/></returns>
        public async Task<ModifyMusicOnShelvesResponse> ModifyMusicOnShelves(ModifyMusicOnShelvesRequest req)
        {
             JsonResponseModel<ModifyMusicOnShelvesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMusicOnShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMusicOnShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据资源方，需要变更的参数，请求该接口进行变更，为空的参数默认为无变更
        /// </summary>
        /// <param name="req"><see cref="ModifyMusicOnShelvesRequest"/></param>
        /// <returns><see cref="ModifyMusicOnShelvesResponse"/></returns>
        public ModifyMusicOnShelvesResponse ModifyMusicOnShelvesSync(ModifyMusicOnShelvesRequest req)
        {
             JsonResponseModel<ModifyMusicOnShelvesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMusicOnShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMusicOnShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据资源方所传歌曲信息，进行歌曲上架，多个歌曲同时请求时，需构造复合结构进行请求
        /// </summary>
        /// <param name="req"><see cref="PutMusicOnTheShelvesRequest"/></param>
        /// <returns><see cref="PutMusicOnTheShelvesResponse"/></returns>
        public async Task<PutMusicOnTheShelvesResponse> PutMusicOnTheShelves(PutMusicOnTheShelvesRequest req)
        {
             JsonResponseModel<PutMusicOnTheShelvesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutMusicOnTheShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMusicOnTheShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据资源方所传歌曲信息，进行歌曲上架，多个歌曲同时请求时，需构造复合结构进行请求
        /// </summary>
        /// <param name="req"><see cref="PutMusicOnTheShelvesRequest"/></param>
        /// <returns><see cref="PutMusicOnTheShelvesResponse"/></returns>
        public PutMusicOnTheShelvesResponse PutMusicOnTheShelvesSync(PutMusicOnTheShelvesRequest req)
        {
             JsonResponseModel<PutMusicOnTheShelvesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutMusicOnTheShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMusicOnTheShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户上报用户数据功能，为了更好地为用户提供优质服务
        /// </summary>
        /// <param name="req"><see cref="ReportDataRequest"/></param>
        /// <returns><see cref="ReportDataResponse"/></returns>
        public async Task<ReportDataResponse> ReportData(ReportDataRequest req)
        {
             JsonResponseModel<ReportDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户上报用户数据功能，为了更好地为用户提供优质服务
        /// </summary>
        /// <param name="req"><see cref="ReportDataRequest"/></param>
        /// <returns><see cref="ReportDataResponse"/></returns>
        public ReportDataResponse ReportDataSync(ReportDataRequest req)
        {
             JsonResponseModel<ReportDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据搜索条件，返回匹配的歌曲列表。
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
        /// 根据搜索条件，返回匹配的歌曲列表。
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
        /// 根据资源方所传MusicId进行将歌曲进行下架，多个MusicId使用逗号隔开
        /// </summary>
        /// <param name="req"><see cref="TakeMusicOffShelvesRequest"/></param>
        /// <returns><see cref="TakeMusicOffShelvesResponse"/></returns>
        public async Task<TakeMusicOffShelvesResponse> TakeMusicOffShelves(TakeMusicOffShelvesRequest req)
        {
             JsonResponseModel<TakeMusicOffShelvesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TakeMusicOffShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TakeMusicOffShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据资源方所传MusicId进行将歌曲进行下架，多个MusicId使用逗号隔开
        /// </summary>
        /// <param name="req"><see cref="TakeMusicOffShelvesRequest"/></param>
        /// <returns><see cref="TakeMusicOffShelvesResponse"/></returns>
        public TakeMusicOffShelvesResponse TakeMusicOffShelvesSync(TakeMusicOffShelvesRequest req)
        {
             JsonResponseModel<TakeMusicOffShelvesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TakeMusicOffShelves");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TakeMusicOffShelvesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
