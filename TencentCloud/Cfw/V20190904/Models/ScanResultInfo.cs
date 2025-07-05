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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否禁封端口
        /// </summary>
        [JsonProperty("BanStatus")]
        public bool? BanStatus{ get; set; }

        /// <summary>
        /// 防护ip数量
        /// </summary>
        [JsonProperty("IPNum")]
        public ulong? IPNum{ get; set; }

        /// <summary>
        /// 是否开启防护
        /// </summary>
        [JsonProperty("IPStatus")]
        public bool? IPStatus{ get; set; }

        /// <summary>
        /// 是否拦截攻击
        /// </summary>
        [JsonProperty("IdpStatus")]
        public bool? IdpStatus{ get; set; }

        /// <summary>
        /// 暴露漏洞数量
        /// </summary>
        [JsonProperty("LeakNum")]
        public ulong? LeakNum{ get; set; }

        /// <summary>
        /// 暴露端口数量
        /// </summary>
        [JsonProperty("PortNum")]
        public ulong? PortNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamSimple(map, prefix + "IPNum", this.IPNum);
            this.SetParamSimple(map, prefix + "IPStatus", this.IPStatus);
            this.SetParamSimple(map, prefix + "IdpStatus", this.IdpStatus);
            this.SetParamSimple(map, prefix + "LeakNum", this.LeakNum);
            this.SetParamSimple(map, prefix + "PortNum", this.PortNum);
        }
    }
}

