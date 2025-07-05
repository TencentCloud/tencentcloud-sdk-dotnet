/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Vms.V20200902.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendCodeVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 验证码，仅支持填写数字，实际播报语音时，会自动在数字前补充语音文本"您的验证码是"。
        /// </summary>
        [JsonProperty("CodeMessage")]
        public string CodeMessage{ get; set; }

        /// <summary>
        /// 被叫手机号码，采用 e.164 标准，格式为+[国家或地区码][用户号码]。
        /// 例如：+8613711112222， 其中前面有一个+号 ，86为国家码，13711112222为手机号。
        /// </summary>
        [JsonProperty("CalledNumber")]
        public string CalledNumber{ get; set; }

        /// <summary>
        /// 在[语音控制台](https://console.cloud.tencent.com/vms)添加应用后生成的实际SdkAppid，示例如1400006666。
        /// </summary>
        [JsonProperty("VoiceSdkAppid")]
        public string VoiceSdkAppid{ get; set; }

        /// <summary>
        /// 播放次数，可选，最多3次，默认2次。
        /// </summary>
        [JsonProperty("PlayTimes")]
        public ulong? PlayTimes{ get; set; }

        /// <summary>
        /// 用户的 session 内容，腾讯 server 回包中会原样返回。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeMessage", this.CodeMessage);
            this.SetParamSimple(map, prefix + "CalledNumber", this.CalledNumber);
            this.SetParamSimple(map, prefix + "VoiceSdkAppid", this.VoiceSdkAppid);
            this.SetParamSimple(map, prefix + "PlayTimes", this.PlayTimes);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

