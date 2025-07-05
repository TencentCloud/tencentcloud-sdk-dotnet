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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteAccelerationDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名所属站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 需要删除的加速域名ID列表。
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// 是否强制删除。当域名存在关联资源（如马甲域名、流量调度功能）时，是否强制删除该域名，取值有：
        /// <li> true：删除该域名及所有关联资源；</li>
        /// <li> false：当该加速域名存在关联资源时，不允许删除。</li>不填写，默认值为：false。
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

