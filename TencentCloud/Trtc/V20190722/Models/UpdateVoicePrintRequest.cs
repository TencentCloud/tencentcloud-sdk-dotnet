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

    public class UpdateVoicePrintRequest : AbstractModel
    {
        
        /// <summary>
        /// 声纹信息ID
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [JsonProperty("ReqTimestamp")]
        public ulong? ReqTimestamp{ get; set; }

        /// <summary>
        /// 音频格式,目前只支持0,代表wav
        /// </summary>
        [JsonProperty("AudioFormat")]
        public ulong? AudioFormat{ get; set; }

        /// <summary>
        /// 整个wav音频文件的base64字符串,其中wav文件限定为16k采样率, 16bit位深, 单声道, 8到18秒音频时长,有效音频不小于6秒(不能有太多静音段),编码数据大小不超过2M
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }

        /// <summary>
        /// 和声纹绑定的MetaInfo，长度最大不超过512
        /// </summary>
        [JsonProperty("AudioMetaInfo")]
        public string AudioMetaInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "ReqTimestamp", this.ReqTimestamp);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
            this.SetParamSimple(map, prefix + "AudioMetaInfo", this.AudioMetaInfo);
        }
    }
}

