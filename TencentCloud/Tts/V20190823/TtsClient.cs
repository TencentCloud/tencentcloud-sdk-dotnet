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

namespace TencentCloud.Tts.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tts.V20190823.Models;

   public class TtsClient : AbstractClient{

       private const string endpoint = "tts.tencentcloudapi.com";
       private const string version = "2019-08-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 内测期间免费使用。
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public async Task<TextToVoiceResponse> TextToVoice(TextToVoiceRequest req)
        {
             JsonResponseModel<TextToVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextToVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TextToVoice接口的同步版本，腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 内测期间免费使用。
        /// </summary>
        /// <param name="req">参考<see cref="TextToVoiceRequest"/></param>
        /// <returns>参考<see cref="TextToVoiceResponse"/>实例</returns>
        public TextToVoiceResponse TextToVoiceSync(TextToVoiceRequest req)
        {
             JsonResponseModel<TextToVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextToVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextToVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
