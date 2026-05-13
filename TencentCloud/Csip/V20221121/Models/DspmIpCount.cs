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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIpCount : AbstractModel
    {
        
        /// <summary>
        /// 访问Ip个数
        /// </summary>
        [JsonProperty("IpCount")]
        public long? IpCount{ get; set; }

        /// <summary>
        /// 未打标公网Ip个数
        /// </summary>
        [JsonProperty("UnmarkedPublicIpCount")]
        public long? UnmarkedPublicIpCount{ get; set; }

        /// <summary>
        /// 内网Ip个数
        /// </summary>
        [JsonProperty("PrivateIpCount")]
        public long? PrivateIpCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IpCount", this.IpCount);
            this.SetParamSimple(map, prefix + "UnmarkedPublicIpCount", this.UnmarkedPublicIpCount);
            this.SetParamSimple(map, prefix + "PrivateIpCount", this.PrivateIpCount);
        }
    }
}

