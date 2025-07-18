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

    public class HSTSParameters : AbstractModel
    {
        
        /// <summary>
        /// HSTS 配置开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 缓存 HSTS 头部时间，单位为秒，取值：1-31536000。<br>注意：当 Switch 为 on 时，此字段必填；当 Switch 为 off 时，无需填写此字段，若填写则不生效。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 是否允许其他子域名继承相同的 HSTS 头部，取值有：
        /// <li>on：允许其他子域名继承相同的 HSTS 头部；</li>
        /// <li>off：不允许其他子域名继承相同的 HSTS 头部。</li>注意：当 Switch 为 on 时，此字段必填；当 Switch 为 off 时，无需填写此字段，若填写则不生效。
        /// </summary>
        [JsonProperty("IncludeSubDomains")]
        public string IncludeSubDomains{ get; set; }

        /// <summary>
        /// 是否允许浏览器预加载 HSTS 头部，取值有：
        /// <li>on：允许浏览器预加载 HSTS 头部；</li>
        /// <li>off：不允许浏览器预加载 HSTS 头部。</li>注意：当 Switch 为 on 时，此字段必填；当 Switch 为 off 时，无需填写此字段，若填写则不生效。
        /// </summary>
        [JsonProperty("Preload")]
        public string Preload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "IncludeSubDomains", this.IncludeSubDomains);
            this.SetParamSimple(map, prefix + "Preload", this.Preload);
        }
    }
}

