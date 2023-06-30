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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BanConfig : AbstractModel
    {
        
        /// <summary>
        /// ip白名单，支持ipv4、ipv6，支持CIDR
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// ip黑名单，支持ipv4、ipv6，支持CIDR
        /// </summary>
        [JsonProperty("IpBlackList")]
        public string[] IpBlackList{ get; set; }

        /// <summary>
        /// 地域白名单（国家英文名）
        /// </summary>
        [JsonProperty("CountryWhiteList")]
        public string[] CountryWhiteList{ get; set; }

        /// <summary>
        /// 地域黑名单（国家英文名）
        /// </summary>
        [JsonProperty("CountryBlackList")]
        public string[] CountryBlackList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamArraySimple(map, prefix + "IpBlackList.", this.IpBlackList);
            this.SetParamArraySimple(map, prefix + "CountryWhiteList.", this.CountryWhiteList);
            this.SetParamArraySimple(map, prefix + "CountryBlackList.", this.CountryBlackList);
        }
    }
}

