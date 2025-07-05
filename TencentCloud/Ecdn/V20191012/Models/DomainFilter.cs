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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤字段名，支持的列表如下：
        /// - origin：主源站。
        /// - domain：域名。
        /// - resourceId：域名id。
        /// - status：域名状态，online，offline，processing。
        /// - disable：域名封禁状态，normal，unlicensed。
        /// - projectId：项目ID。
        /// - fullUrlCache：全路径缓存，on或off。
        /// - https：是否配置https，on，off或processing。
        /// - originPullProtocol：回源协议类型，支持http，follow或https。
        /// - area：加速区域，支持mainland，overseas或global。
        /// - tagKey：标签键。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 过滤字段值。
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }

        /// <summary>
        /// 是否启用模糊查询，仅支持过滤字段名为origin，domain。
        /// </summary>
        [JsonProperty("Fuzzy")]
        public bool? Fuzzy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
            this.SetParamSimple(map, prefix + "Fuzzy", this.Fuzzy);
        }
    }
}

