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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodLimitsByType : AbstractModel
    {
        
        /// <summary>
        /// TKE共享网卡非固定IP模式可支持的Pod数量
        /// </summary>
        [JsonProperty("TKERouteENINonStaticIP")]
        public long? TKERouteENINonStaticIP{ get; set; }

        /// <summary>
        /// TKE共享网卡固定IP模式可支持的Pod数量
        /// </summary>
        [JsonProperty("TKERouteENIStaticIP")]
        public long? TKERouteENIStaticIP{ get; set; }

        /// <summary>
        /// TKE独立网卡模式可支持的Pod数量
        /// </summary>
        [JsonProperty("TKEDirectENI")]
        public long? TKEDirectENI{ get; set; }

        /// <summary>
        /// TKE中继网卡模式可支持的Pod数量
        /// </summary>
        [JsonProperty("TKESubENI")]
        public long? TKESubENI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TKERouteENINonStaticIP", this.TKERouteENINonStaticIP);
            this.SetParamSimple(map, prefix + "TKERouteENIStaticIP", this.TKERouteENIStaticIP);
            this.SetParamSimple(map, prefix + "TKEDirectENI", this.TKEDirectENI);
            this.SetParamSimple(map, prefix + "TKESubENI", this.TKESubENI);
        }
    }
}

