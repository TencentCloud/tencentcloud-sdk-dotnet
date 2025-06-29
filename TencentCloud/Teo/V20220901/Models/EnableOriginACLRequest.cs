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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableOriginACLRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 七层加速域名开启回源白名单的模式。
        /// <li>all：为站点下的所有七层加速域名开启回源白名单。</li>
        /// <li>specific：为站点下指定的七层加速域名开启回源白名单。</li>
        /// 当参数为空时，默认为specific。
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// 开启回源白名单的七层加速域名列表，当请求参数 L7EnableMode 为 all 时必须为空。
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// 四层代理 ID 开启回源白名单的模式。
        /// <li>all：为站点下的所有四层代理开启回源白名单。</li>
        /// <li>specific：为站点下指定的四层代理 ID 开启回源白名单。</li>
        /// 当参数为空时，默认为specific。
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// 开启回源白名单的四层代理 ID 列表，当请求参数 L4EnableMode 为 all 时必须为空。单次最多支持 200 个实例。
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
        }
    }
}

