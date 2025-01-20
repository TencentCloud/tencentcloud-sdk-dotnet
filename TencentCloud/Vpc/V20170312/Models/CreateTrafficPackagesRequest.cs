/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTrafficPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量包规格。可选值:
        /// <li>10: 10GB流量，有效期一个月</li>
        /// <li>50: 50GB流量，有效期一个月</li>
        /// <li>512: 512GB流量，有效期一个月</li>
        /// <li>1024: 1TB流量，有效期一个月</li>
        /// <li>5120: 5TB流量，有效期一个月</li>
        /// <li>51200: 50TB流量，有效期一个月</li>
        /// <li>60: 60GB流量，有效期半年</li>
        /// <li>300: 300GB流量，有效期半年</li>
        /// <li>600: 600GB流量，有效期半年</li>
        /// <li>3072: 3TB流量，有效期半年</li>
        /// <li>6144: 6TB流量，有效期半年</li>
        /// <li>30720: 30TB流量，有效期半年</li>
        /// <li>61440: 60TB流量，有效期半年</li>
        /// <li>307200: 300TB流量，有效期半年</li>
        /// </summary>
        [JsonProperty("TrafficAmount")]
        public ulong? TrafficAmount{ get; set; }

        /// <summary>
        /// 流量包数量，可选范围 1~20。
        /// </summary>
        [JsonProperty("TrafficPackageCount")]
        public ulong? TrafficPackageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficAmount", this.TrafficAmount);
            this.SetParamSimple(map, prefix + "TrafficPackageCount", this.TrafficPackageCount);
        }
    }
}

