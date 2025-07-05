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

    public class VoicePrintInfo : AbstractModel
    {
        
        /// <summary>
        /// 声纹ID
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 和声纹绑定的MetaInfo
        /// </summary>
        [JsonProperty("VoicePrintMetaInfo")]
        public string VoicePrintMetaInfo{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 音频格式,当前只有0(代表wav)
        /// </summary>
        [JsonProperty("AudioFormat")]
        public ulong? AudioFormat{ get; set; }

        /// <summary>
        /// 音频名称
        /// </summary>
        [JsonProperty("AudioName")]
        public string AudioName{ get; set; }

        /// <summary>
        /// 请求毫秒时间戳
        /// </summary>
        [JsonProperty("ReqTimestamp")]
        public ulong? ReqTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "VoicePrintMetaInfo", this.VoicePrintMetaInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "AudioName", this.AudioName);
            this.SetParamSimple(map, prefix + "ReqTimestamp", this.ReqTimestamp);
        }
    }
}

