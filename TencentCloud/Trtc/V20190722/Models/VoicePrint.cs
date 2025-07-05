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

    public class VoicePrint : AbstractModel
    {
        
        /// <summary>
        /// 默认为0，表示不启用声纹。1表示启用声纹，此时需要填写voiceprint id。
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// VoicePrint Mode为1时需要填写，目前仅支持填写一个声纹id
        /// </summary>
        [JsonProperty("IdList")]
        public string[] IdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
        }
    }
}

