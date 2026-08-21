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

namespace TencentCloud.Cloudrc.V20240606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtendedFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>过滤条件键</p><p>枚举值：</p><ul><li>ResourceType： 资源类型</li><li>ResourceId： 资源ID</li><li>ResourceAlias： 资源名称</li><li>PayMode： 计费模式</li><li>RegionCode： 地域编码</li><li>ZoneCode： 可用区编码</li><li>PublicIpAddress： 外网IP</li><li>PrivateIpAddress： 内网IP</li><li>VpcId： VPC ID</li><li>SubnetId： 子网ID</li><li>Tag： 标签</li></ul>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>过滤条件值</p>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// <p>匹配方式</p><p>枚举值：</p><ul><li>Equals： 等于</li><li>NotEquals： 不等于</li><li>Contains： 包含</li><li>NotContains： 不包含</li><li>Exists： 存在</li><li>NotExists： 不存在</li></ul>
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
        }
    }
}

