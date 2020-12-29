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

namespace TencentCloud.Vms.V20200902
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vms.V20200902.Models;

   public class VmsClient : AbstractClient{

       private const string endpoint = "vms.tencentcloudapi.com";
       private const string version = "2020-09-02";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 给用户发语音验证码（仅支持数字）。
        /// </summary>
        /// <param name="req"><see cref="SendCodeVoiceRequest"/></param>
        /// <returns><see cref="SendCodeVoiceResponse"/></returns>
        public async Task<SendCodeVoiceResponse> SendCodeVoice(SendCodeVoiceRequest req)
        {
             JsonResponseModel<SendCodeVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCodeVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCodeVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给用户发语音验证码（仅支持数字）。
        /// </summary>
        /// <param name="req"><see cref="SendCodeVoiceRequest"/></param>
        /// <returns><see cref="SendCodeVoiceResponse"/></returns>
        public SendCodeVoiceResponse SendCodeVoiceSync(SendCodeVoiceRequest req)
        {
             JsonResponseModel<SendCodeVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCodeVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCodeVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给用户发送指定模板的语音通知。
        /// </summary>
        /// <param name="req"><see cref="SendTtsVoiceRequest"/></param>
        /// <returns><see cref="SendTtsVoiceResponse"/></returns>
        public async Task<SendTtsVoiceResponse> SendTtsVoice(SendTtsVoiceRequest req)
        {
             JsonResponseModel<SendTtsVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendTtsVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTtsVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给用户发送指定模板的语音通知。
        /// </summary>
        /// <param name="req"><see cref="SendTtsVoiceRequest"/></param>
        /// <returns><see cref="SendTtsVoiceResponse"/></returns>
        public SendTtsVoiceResponse SendTtsVoiceSync(SendTtsVoiceRequest req)
        {
             JsonResponseModel<SendTtsVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendTtsVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendTtsVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
