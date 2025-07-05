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

    public class DNSConfig : AbstractModel
    {
        
        /// <summary>
        /// DNS 服务器IP地址列表
        /// </summary>
        [JsonProperty("Nameservers")]
        public string[] Nameservers{ get; set; }

        /// <summary>
        /// 对象选项列表，每个对象由name和value（可选）构成
        /// </summary>
        [JsonProperty("Options")]
        public DNSConfigOption[] Options{ get; set; }

        /// <summary>
        /// DNS搜索域列表
        /// </summary>
        [JsonProperty("Searches")]
        public string[] Searches{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Nameservers.", this.Nameservers);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
            this.SetParamArraySimple(map, prefix + "Searches.", this.Searches);
        }
    }
}

