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

namespace TencentCloud.Tbp.V20190311
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbp.V20190311.Models;

   public class TbpClient : AbstractClient{

       private const string endpoint = "tbp.tencentcloudapi.com";
       private const string version = "2019-03-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TbpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TbpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 机器人会话接口，接收音频信息，传递给后台机器人
        /// </summary>
        /// <param name="req">参考<see cref="PostAudioRequest"/></param>
        /// <returns>参考<see cref="PostAudioResponse"/>实例</returns>
        public async Task<PostAudioResponse> PostAudio(PostAudioRequest req)
        {
             JsonResponseModel<PostAudioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PostAudio");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PostAudioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 机器人会话接口，接收文本信息，传递给后台机器人
        /// </summary>
        /// <param name="req">参考<see cref="PostTextRequest"/></param>
        /// <returns>参考<see cref="PostTextResponse"/>实例</returns>
        public async Task<PostTextResponse> PostText(PostTextRequest req)
        {
             JsonResponseModel<PostTextResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PostText");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PostTextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对当前机器人的会话状态进行复位
        /// </summary>
        /// <param name="req">参考<see cref="ResetRequest"/></param>
        /// <returns>参考<see cref="ResetResponse"/>实例</returns>
        public async Task<ResetResponse> Reset(ResetRequest req)
        {
             JsonResponseModel<ResetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Reset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
