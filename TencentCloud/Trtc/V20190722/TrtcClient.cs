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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TrtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接口说明：把房间所有用户从房间踢出，解散房间。
        /// </summary>
        /// <param name="req">参考<see cref="DissolveRoomRequest"/></param>
        /// <returns>参考<see cref="DissolveRoomResponse"/>实例</returns>
        public async Task<DissolveRoomResponse> DissolveRoom(DissolveRoomRequest req)
        {
             JsonResponseModel<DissolveRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DissolveRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DissolveRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口说明：将用户从房间踢出。
        /// </summary>
        /// <param name="req">参考<see cref="KickOutUserRequest"/></param>
        /// <returns>参考<see cref="KickOutUserResponse"/>实例</returns>
        public async Task<KickOutUserResponse> KickOutUser(KickOutUserRequest req)
        {
             JsonResponseModel<KickOutUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KickOutUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KickOutUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
