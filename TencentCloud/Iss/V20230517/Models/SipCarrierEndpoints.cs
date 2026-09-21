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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SipCarrierEndpoints : AbstractModel
    {
        
        /// <summary>
        /// <p>电信IP</p>
        /// </summary>
        [JsonProperty("CT")]
        public string CT{ get; set; }

        /// <summary>
        /// <p>联通IP</p>
        /// </summary>
        [JsonProperty("CU")]
        public string CU{ get; set; }

        /// <summary>
        /// <p>移动IP</p>
        /// </summary>
        [JsonProperty("CMCC")]
        public string CMCC{ get; set; }

        /// <summary>
        /// <p>腾讯网络IP</p>
        /// </summary>
        [JsonProperty("BGP")]
        public string BGP{ get; set; }

        /// <summary>
        /// <p>中小运营商IP</p>
        /// </summary>
        [JsonProperty("CAP")]
        public string CAP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CT", this.CT);
            this.SetParamSimple(map, prefix + "CU", this.CU);
            this.SetParamSimple(map, prefix + "CMCC", this.CMCC);
            this.SetParamSimple(map, prefix + "BGP", this.BGP);
            this.SetParamSimple(map, prefix + "CAP", this.CAP);
        }
    }
}

