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
        /// 创建异常信息
        /// </summary>
        /// <param name="req"><see cref="CreateTroubleInfoRequest"/></param>
        /// <returns><see cref="CreateTroubleInfoResponse"/></returns>
        public async Task<CreateTroubleInfoResponse> CreateTroubleInfo(CreateTroubleInfoRequest req)
        {
             JsonResponseModel<CreateTroubleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTroubleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTroubleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建异常信息
        /// </summary>
        /// <param name="req"><see cref="CreateTroubleInfoRequest"/></param>
        /// <returns><see cref="CreateTroubleInfoResponse"/></returns>
        public CreateTroubleInfoResponse CreateTroubleInfoSync(CreateTroubleInfoRequest req)
        {
             JsonResponseModel<CreateTroubleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTroubleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTroubleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SDKAppID下用户的异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询5天内数据，查询起止时间不超过1个小时。支持跨天查询。异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventResponse"/></returns>
        public async Task<DescribeAbnormalEventResponse> DescribeAbnormalEvent(DescribeAbnormalEventRequest req)
        {
             JsonResponseModel<DescribeAbnormalEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SDKAppID下用户的异常体验事件，返回异常体验ID与可能产生异常体验的原因。可查询5天内数据，查询起止时间不超过1个小时。支持跨天查询。异常体验ID映射见：https://cloud.tencent.com/document/product/647/44916
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventResponse"/></returns>
        public DescribeAbnormalEventResponse DescribeAbnormalEventSync(DescribeAbnormalEventRequest req)
        {
             JsonResponseModel<DescribeAbnormalEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表及用户通话质量数据，可查询14天内数据。DataType 不为null，查询实时数据时，查询起止时间不超过1个小时，每次查询用户不超过6个，支持跨天查询。DataType，UserIds为null时，默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。
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
        /// 查询指定时间内的用户列表及用户通话质量数据，可查询14天内数据。DataType 不为null，查询实时数据时，查询起止时间不超过1个小时，每次查询用户不超过6个，支持跨天查询。DataType，UserIds为null时，默认查询6个用户，同时支持每页查询100以内用户个数（PageSize不超过100）。接口用于查询质量问题，不推荐作为计费使用。
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
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailEventRequest"/></param>
        /// <returns><see cref="DescribeDetailEventResponse"/></returns>
        public async Task<DescribeDetailEventResponse> DescribeDetailEvent(DescribeDetailEventRequest req)
        {
             JsonResponseModel<DescribeDetailEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDetailEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户某次通话内的进退房，视频开关等详细事件。可查询14天内数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailEventRequest"/></param>
        /// <returns><see cref="DescribeDetailEventResponse"/></returns>
        public DescribeDetailEventResponse DescribeDetailEventSync(DescribeDetailEventRequest req)
        {
             JsonResponseModel<DescribeDetailEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDetailEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDetailEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可查询sdkqppid 每天的房间数和用户数，每分钟1次，可查询最近14天的数据。当天未结束，无法查到当天的房间数与用户数。
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
        /// 可查询sdkqppid 每天的房间数和用户数，每分钟1次，可查询最近14天的数据。当天未结束，无法查到当天的房间数与用户数。
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
        /// 查询sdkappid下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询14天内的数据。
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
        /// 查询sdkappid下的房间列表。默认返回10条通话，一次最多返回100条通话。可查询14天内的数据。
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
        /// 查询指定时间内的用户列表，可查询14天内数据。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInformationRequest"/></param>
        /// <returns><see cref="DescribeUserInformationResponse"/></returns>
        public async Task<DescribeUserInformationResponse> DescribeUserInformation(DescribeUserInformationRequest req)
        {
             JsonResponseModel<DescribeUserInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间内的用户列表，可查询14天内数据。默认每页查询6个用户，支持每页最大查询100个用户PageSize不超过100）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInformationRequest"/></param>
        /// <returns><see cref="DescribeUserInformationResponse"/></returns>
        public DescribeUserInformationResponse DescribeUserInformationSync(DescribeUserInformationRequest req)
        {
             JsonResponseModel<DescribeUserInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInformationResponse>>(strResp);
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

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置。
        /// 
        /// 注意：2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeResponse"/></returns>
        public async Task<StartMCUMixTranscodeResponse> StartMCUMixTranscode(StartMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：启动云端混流，并指定混流画面中各路画面的布局位置。
        /// 
        /// TRTC 的一个房间中可能会同时存在多路音视频流，您可以通过此 API 接口，通知腾讯云服务端将多路视频画面合成一路，并指定每一路画面的位置，同时将多路声音进行混音，最终形成一路音视频流，以便用于录制和直播观看。
        /// 
        /// 您可以通过此接口实现如下目标：
        /// - 设置最终直播流的画质和音质，包括视频分辨率、视频码率、视频帧率、以及声音质量等。
        /// - 设置各路画面的位置和布局，您只需要在启动时设置一次，排版引擎会自动完成后续的画面排布。
        /// - 设置录制文件名，用于二次回放。
        /// - 设置 CDN 直播流 ID，用于在 CDN 进行直播观看。
        /// 
        /// 目前已经支持了如下几种布局模板：
        /// - 悬浮模板：第一个进入房间的用户的视频画面会铺满整个屏幕，其他用户的视频画面从左下角依次水平排列，显示为小画面，最多4行，每行4个，小画面悬浮于大画面之上。最多支持1个大画面和15个小画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 九宫格模板：所有用户的视频画面大小一致，平分整个屏幕，人数越多，每个画面的尺寸越小。最多支持16个画面，如果用户只发送音频，仍然会占用画面位置。
        /// - 屏幕分享模板：适合视频会议和在线教育场景的布局，屏幕分享（或者主讲的摄像头）始终占据屏幕左侧的大画面位置，其他用户依次垂直排列于右侧，最多两列，每列最多8个小画面。最多支持1个大画面和15个小画面。若上行分辨率宽高比与画面输出宽高比不一致时，左侧大画面为了保持内容的完整性采用缩放方式处理，右侧小画面采用裁剪方式处理。
        /// - 画中画模板：适用于混合大小两路视频画面和其他用户混音，或者混合一路大画面和其他用户混音的场景。小画面悬浮于大画面之上，可以指定大小画面的用户以及小画面的显示位置。
        /// 
        /// 注意：2020年1月9号及以后创建的应用才能直接调用此接口。2020年1月9日之前创建的应用默认使用云直播的云端混流，如需切换至MCU混流，请[提交工单](https://console.cloud.tencent.com/workorder/category)寻求帮助。
        /// </summary>
        /// <param name="req"><see cref="StartMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StartMCUMixTranscodeResponse"/></returns>
        public StartMCUMixTranscodeResponse StartMCUMixTranscodeSync(StartMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StartMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public async Task<StopMCUMixTranscodeResponse> StopMCUMixTranscode(StopMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：结束云端混流
        /// </summary>
        /// <param name="req"><see cref="StopMCUMixTranscodeRequest"/></param>
        /// <returns><see cref="StopMCUMixTranscodeResponse"/></returns>
        public StopMCUMixTranscodeResponse StopMCUMixTranscodeSync(StopMCUMixTranscodeRequest req)
        {
             JsonResponseModel<StopMCUMixTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMCUMixTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMCUMixTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
