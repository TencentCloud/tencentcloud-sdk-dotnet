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

    }
}
