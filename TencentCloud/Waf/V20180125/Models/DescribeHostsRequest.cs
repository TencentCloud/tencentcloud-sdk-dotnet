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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// 防护域名，如果是要查询某一具体的防护域名则传入此参数，要求是准确的域名，此参数不支持模糊搜索
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 防护域名ID，如果是要查询某一具体的防护域名则传入此参数，要求是准确的域名ID，此参数不支持模糊搜索
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 搜索条件，根据此参数对域名做模糊搜索
        /// </summary>
        [JsonProperty("Search")]
        public string Search{ get; set; }

        /// <summary>
        /// 复杂的搜索条件
        /// </summary>
        [JsonProperty("Item")]
        public SearchItem Item{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Search", this.Search);
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

