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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DNSConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>DNS 服务器地址</p><p>参数格式：需要有效 IP 地址</p><p>默认值：10.0.0.1</p>
        /// </summary>
        [JsonProperty("Servers")]
        public string[] Servers{ get; set; }

        /// <summary>
        /// <p>搜索域(对应 resolv.conf 的 search 指令)</p>
        /// </summary>
        [JsonProperty("Searches")]
        public string[] Searches{ get; set; }

        /// <summary>
        /// <p>配置项(对应  resolv.conf 选项)</p>
        /// </summary>
        [JsonProperty("Options")]
        public string[] Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Servers.", this.Servers);
            this.SetParamArraySimple(map, prefix + "Searches.", this.Searches);
            this.SetParamArraySimple(map, prefix + "Options.", this.Options);
        }
    }
}

