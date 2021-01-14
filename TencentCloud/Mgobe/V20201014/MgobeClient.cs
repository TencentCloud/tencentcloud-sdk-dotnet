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

namespace TencentCloud.Mgobe.V20201014
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mgobe.V20201014.Models;

   public class MgobeClient : AbstractClient{

       private const string endpoint = "mgobe.tencentcloudapi.com";
       private const string version = "2020-10-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MgobeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MgobeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 修改房间玩家自定义属性
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerProfileRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerProfileResponse"/></returns>
        public async Task<ChangeRoomPlayerProfileResponse> ChangeRoomPlayerProfile(ChangeRoomPlayerProfileRequest req)
        {
             JsonResponseModel<ChangeRoomPlayerProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeRoomPlayerProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRoomPlayerProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改房间玩家自定义属性
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerProfileRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerProfileResponse"/></returns>
        public ChangeRoomPlayerProfileResponse ChangeRoomPlayerProfileSync(ChangeRoomPlayerProfileRequest req)
        {
             JsonResponseModel<ChangeRoomPlayerProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeRoomPlayerProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRoomPlayerProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改玩家自定义状态
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerStatusRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerStatusResponse"/></returns>
        public async Task<ChangeRoomPlayerStatusResponse> ChangeRoomPlayerStatus(ChangeRoomPlayerStatusRequest req)
        {
             JsonResponseModel<ChangeRoomPlayerStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeRoomPlayerStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRoomPlayerStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改玩家自定义状态
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerStatusRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerStatusResponse"/></returns>
        public ChangeRoomPlayerStatusResponse ChangeRoomPlayerStatusSync(ChangeRoomPlayerStatusRequest req)
        {
             JsonResponseModel<ChangeRoomPlayerStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeRoomPlayerStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRoomPlayerStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过game_id、room_id解散房间
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
        /// 通过game_id、room_id解散房间
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
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public async Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 踢出房间玩家
        /// </summary>
        /// <param name="req"><see cref="RemoveRoomPlayerRequest"/></param>
        /// <returns><see cref="RemoveRoomPlayerResponse"/></returns>
        public async Task<RemoveRoomPlayerResponse> RemoveRoomPlayer(RemoveRoomPlayerRequest req)
        {
             JsonResponseModel<RemoveRoomPlayerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveRoomPlayer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveRoomPlayerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 踢出房间玩家
        /// </summary>
        /// <param name="req"><see cref="RemoveRoomPlayerRequest"/></param>
        /// <returns><see cref="RemoveRoomPlayerResponse"/></returns>
        public RemoveRoomPlayerResponse RemoveRoomPlayerSync(RemoveRoomPlayerRequest req)
        {
             JsonResponseModel<RemoveRoomPlayerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveRoomPlayer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveRoomPlayerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
