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

    public class VerifyTRTCVoicePrintResponse : AbstractModel
    {
        
        /// <summary>
        /// 被验证的目标声纹 ID
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 注册时写入的业务方 SpeakerId（以服务端记录为准）
        /// </summary>
        [JsonProperty("SpeakerId")]
        public string SpeakerId{ get; set; }

        /// <summary>
        /// 相似度分值（字符串形式，保留两位小数，范围约 0~100，越大越相似）
        /// </summary>
        [JsonProperty("Score")]
        public string Score{ get; set; }

        /// <summary>
        /// 服务端阈值判决结果，0=不通过，1=通过（默认阈值 60 分，由服务端统一维护）
        /// </summary>
        [JsonProperty("Decision")]
        public long? Decision{ get; set; }

        /// <summary>
        /// 结果描述，成功时为 voiceprint verify success
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Decision", this.Decision);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

