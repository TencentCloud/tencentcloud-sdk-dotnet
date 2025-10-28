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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetTotalDurationResponse : AbstractModel
    {
        
        /// <summary>
        /// 语音:min
        /// </summary>
        [JsonProperty("Voice")]
        public long? Voice{ get; set; }

        /// <summary>
        /// 标清:min
        /// </summary>
        [JsonProperty("SD")]
        public long? SD{ get; set; }

        /// <summary>
        /// 高清:min
        /// </summary>
        [JsonProperty("HD")]
        public long? HD{ get; set; }

        /// <summary>
        /// 超高清:min
        /// </summary>
        [JsonProperty("FHD")]
        public long? FHD{ get; set; }

        /// <summary>
        /// 2k:min
        /// </summary>
        [JsonProperty("TwoK")]
        public long? TwoK{ get; set; }

        /// <summary>
        /// 4k:min
        /// </summary>
        [JsonProperty("FourK")]
        public long? FourK{ get; set; }

        /// <summary>
        /// 在线时长:min 
        /// </summary>
        [JsonProperty("Online")]
        public long? Online{ get; set; }

        /// <summary>
        /// 多网标清:min
        /// </summary>
        [JsonProperty("MultiSD")]
        public long? MultiSD{ get; set; }

        /// <summary>
        /// 多网高清:min
        /// </summary>
        [JsonProperty("MultiHD")]
        public long? MultiHD{ get; set; }

        /// <summary>
        /// 多网超高清:min
        /// </summary>
        [JsonProperty("MultiFHD")]
        public long? MultiFHD{ get; set; }

        /// <summary>
        /// 多网2k:min
        /// </summary>
        [JsonProperty("MultiTwoK")]
        public long? MultiTwoK{ get; set; }

        /// <summary>
        /// 多网4k:min
        /// </summary>
        [JsonProperty("MultiFourK")]
        public long? MultiFourK{ get; set; }

        /// <summary>
        /// 多网在线时长:min 
        /// </summary>
        [JsonProperty("MultiOnline")]
        public long? MultiOnline{ get; set; }

        /// <summary>
        /// 总抵扣时长:min 
        /// </summary>
        [JsonProperty("DeductDuration")]
        public long? DeductDuration{ get; set; }

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
            this.SetParamSimple(map, prefix + "Voice", this.Voice);
            this.SetParamSimple(map, prefix + "SD", this.SD);
            this.SetParamSimple(map, prefix + "HD", this.HD);
            this.SetParamSimple(map, prefix + "FHD", this.FHD);
            this.SetParamSimple(map, prefix + "TwoK", this.TwoK);
            this.SetParamSimple(map, prefix + "FourK", this.FourK);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "MultiSD", this.MultiSD);
            this.SetParamSimple(map, prefix + "MultiHD", this.MultiHD);
            this.SetParamSimple(map, prefix + "MultiFHD", this.MultiFHD);
            this.SetParamSimple(map, prefix + "MultiTwoK", this.MultiTwoK);
            this.SetParamSimple(map, prefix + "MultiFourK", this.MultiFourK);
            this.SetParamSimple(map, prefix + "MultiOnline", this.MultiOnline);
            this.SetParamSimple(map, prefix + "DeductDuration", this.DeductDuration);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

