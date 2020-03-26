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
        /// 分类内容下歌曲列表获取，根据CategoryID或CategoryCode
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
        /// 分类内容下歌曲列表获取，根据CategoryID或CategoryCode
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
        /// 根据接口的模式及歌曲ID来取得歌词信息。
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
        /// 根据接口的模式及歌曲ID来取得歌词信息。
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
        /// 根据接口的模式及歌曲ID来取得对应权限的歌曲播放地址等信息。
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
        /// 根据接口的模式及歌曲ID来取得对应权限的歌曲播放地址等信息。
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
        /// 获取素材库列表时使用
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
        /// 获取素材库列表时使用
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
        /// 客户上报用户数据功能，为了更好的为用户提供优质服务
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
        /// 客户上报用户数据功能，为了更好的为用户提供优质服务
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

    }
}
