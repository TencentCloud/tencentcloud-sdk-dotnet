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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterTRTCVoicePrintRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务方自定义的说话人唯一标识，同一 (AppId, SdkAppId, SpeakerId) 重复调用会覆盖旧声纹（软删旧记录 + 新建一行，返回新的 VoicePrintId）
        /// </summary>
        [JsonProperty("SpeakerId")]
        public string SpeakerId{ get; set; }

        /// <summary>
        /// 音频数据的 Base64 字符串。要求：16kHz/16bit/单声道 PCM 或 WAV；Base64 解码后大小 ≤ 2MB；PCM 裸数据时长 10s ≤ 时长 ≤ 45s（WAV 去掉 header 后按相同标准校验）
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// 音频格式，可选 pcm 或 wav，大小写不敏感，不传默认为 pcm
        /// </summary>
        [JsonProperty("AudioFormat")]
        public string AudioFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
        }
    }
}

