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

    public class TRTCVoicePrintItem : AbstractModel
    {
        
        /// <summary>
        /// 声纹 ID，36 位 UUID（含连字符）。对 (AppId, SdkAppId) 维度内唯一。
        /// 示例值：59d83c76-8f4e-4a1b-9c2d-0e7f8a6b5c4d
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 业务方自定义的说话人标识，长度不超过 128 字节，由客户在注册声纹时传入。同一 SpeakerId 可对应多条声纹。
        /// 示例值：user_12345
        /// </summary>
        [JsonProperty("SpeakerId")]
        public string SpeakerId{ get; set; }

        /// <summary>
        /// 声纹注册时间，ISO8601 格式，UTC 时区。
        /// 示例值：2025-04-24T10:20:30Z
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 声纹最近一次更新时间，ISO8601 格式，UTC 时区。未被更新过时等于 CreateTime。
        /// 示例值：2025-04-24T10:20:30Z
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

