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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceCounterData : AbstractModel
    {
        
        /// <summary>
        /// DID总数
        /// </summary>
        [JsonProperty("DidCnt")]
        public ulong? DidCnt{ get; set; }

        /// <summary>
        /// VC总数
        /// </summary>
        [JsonProperty("VCCnt")]
        public ulong? VCCnt{ get; set; }

        /// <summary>
        /// CPT总数
        /// </summary>
        [JsonProperty("CPTCnt")]
        public ulong? CPTCnt{ get; set; }

        /// <summary>
        ///  VC验证总数 
        /// </summary>
        [JsonProperty("VerifyCnt")]
        public ulong? VerifyCnt{ get; set; }

        /// <summary>
        /// 权威机构数量
        /// </summary>
        [JsonProperty("AuthCnt")]
        public ulong? AuthCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DidCnt", this.DidCnt);
            this.SetParamSimple(map, prefix + "VCCnt", this.VCCnt);
            this.SetParamSimple(map, prefix + "CPTCnt", this.CPTCnt);
            this.SetParamSimple(map, prefix + "VerifyCnt", this.VerifyCnt);
            this.SetParamSimple(map, prefix + "AuthCnt", this.AuthCnt);
        }
    }
}

