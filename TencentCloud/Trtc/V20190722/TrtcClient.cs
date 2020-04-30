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

namespace TencentCloud.Trtc.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trtc.V20190722.Models;

   public class TrtcClient : AbstractClient{

       private const string endpoint = "trtc.tencentcloudapi.com";
       private const string version = "2019-07-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailRequest"/></param>
        /// <returns><see cref="DescribeCallDetailResponse"/></returns>
        public async Task<DescribeCallDetailResponse> DescribeCallDetail(DescribeCallDetailRequest req)
        {
             JsonResponseModel<DescribeCallDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailRequest"/></param>
        /// <returns><see cref="DescribeCallDetailResponse"/></returns>
        public DescribeCallDetailResponse DescribeCallDetailSync(DescribeCallDetailRequest req)
        {
             JsonResponseModel<DescribeCallDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询历史房间和用户数，每分钟1次，可查询最近5天的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryScaleRequest"/></param>
        /// <returns><see cref="DescribeHistoryScaleResponse"/></returns>
        public async Task<DescribeHistoryScaleResponse> DescribeHistoryScale(DescribeHistoryScaleRequest req)
        {
             JsonResponseModel<DescribeHistoryScaleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询历史房间和用户数，每分钟1次，可查询最近5天的数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryScaleRequest"/></param>
        /// <returns><see cref="DescribeHistoryScaleResponse"/></returns>
        public DescribeHistoryScaleResponse DescribeHistoryScaleSync(DescribeHistoryScaleRequest req)
        {
             JsonResponseModel<DescribeHistoryScaleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHistoryScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时网络状态，包括上行丢包与下行丢包。可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeNetworkRequest"/></param>
        /// <returns><see cref="DescribeRealtimeNetworkResponse"/></returns>
        public async Task<DescribeRealtimeNetworkResponse> DescribeRealtimeNetwork(DescribeRealtimeNetworkRequest req)
        {
             JsonResponseModel<DescribeRealtimeNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时网络状态，包括上行丢包与下行丢包。可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeNetworkRequest"/></param>
        /// <returns><see cref="DescribeRealtimeNetworkResponse"/></returns>
        public DescribeRealtimeNetworkResponse DescribeRealtimeNetworkSync(DescribeRealtimeNetworkRequest req)
        {
             JsonResponseModel<DescribeRealtimeNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时质量数据，包括：进房成功率，首帧秒开率，音频卡顿率，视频卡顿率。可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeQualityRequest"/></param>
        /// <returns><see cref="DescribeRealtimeQualityResponse"/></returns>
        public async Task<DescribeRealtimeQualityResponse> DescribeRealtimeQuality(DescribeRealtimeQualityRequest req)
        {
             JsonResponseModel<DescribeRealtimeQualityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeQuality");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeQualityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时质量数据，包括：进房成功率，首帧秒开率，音频卡顿率，视频卡顿率。可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeQualityRequest"/></param>
        /// <returns><see cref="DescribeRealtimeQualityResponse"/></returns>
        public DescribeRealtimeQualityResponse DescribeRealtimeQualitySync(DescribeRealtimeQualityRequest req)
        {
             JsonResponseModel<DescribeRealtimeQualityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeQuality");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeQualityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时规模，可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScaleRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScaleResponse"/></returns>
        public async Task<DescribeRealtimeScaleResponse> DescribeRealtimeScale(DescribeRealtimeScaleRequest req)
        {
             JsonResponseModel<DescribeRealtimeScaleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid维度下实时规模，可查询24小时内数据，查询起止时间不超过1个小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScaleRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScaleResponse"/></returns>
        public DescribeRealtimeScaleResponse DescribeRealtimeScaleSync(DescribeRealtimeScaleRequest req)
        {
             JsonResponseModel<DescribeRealtimeScaleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询最近5天的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInformationRequest"/></param>
        /// <returns><see cref="DescribeRoomInformationResponse"/></returns>
        public async Task<DescribeRoomInformationResponse> DescribeRoomInformation(DescribeRoomInformationRequest req)
        {
             JsonResponseModel<DescribeRoomInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sdkappid下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询最近5天的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInformationRequest"/></param>
        /// <returns><see cref="DescribeRoomInformationResponse"/></returns>
        public DescribeRoomInformationResponse DescribeRoomInformationSync(DescribeRoomInformationRequest req)
        {
             JsonResponseModel<DescribeRoomInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public async Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间移出，解散房间。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public async Task<RemoveUserResponse> RemoveUser(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间移出，适用于主播/房主/管理员踢人等场景。支持所有平台，Android、iOS、Windows 和 macOS 需升级到 TRTC SDK 6.6及以上版本。
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public RemoveUserResponse RemoveUserSync(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
