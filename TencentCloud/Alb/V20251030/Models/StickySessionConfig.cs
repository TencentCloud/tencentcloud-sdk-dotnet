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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StickySessionConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启会话保持。
        /// - **true**：开启。
        /// - **false**：不开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StickySessionEnabled")]
        public bool? StickySessionEnabled{ get; set; }

        /// <summary>
        /// 自定义 Cookie 名称。
        /// 长度为 1~255 个字符，只能包含英文字母和数字字符，且不能为`tgw_l7_tg_route`，该字段为目标组间会话保持Cookie保留字段。
        /// >仅当 **StickySessionEnabled** 为 **true** 时该参数生效。
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }

        /// <summary>
        /// 会话保持时间。
        /// 取值范围：**1-86400**，单位：**秒**。
        /// 默认值：**1000**。
        /// >仅当 **StickySessionEnabled** 为 **true**时，该参数生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CookieTimeout")]
        public long? CookieTimeout{ get; set; }

        /// <summary>
        /// 会话保持类型（处理Cookie的方式）。
        /// - **Insert**（默认值）：植入 Cookie。 客户端第一次访问后端服务时，应用型负载均衡会在返回请求中植入 Cookie。下次客户端请求时携带该 Cookie，负载均衡将请求转发到上次请求的相同后端服务。
        /// - **Rewrite**：重写 Cookie。 负载均衡会对用户自定义的 Cookie 进行重写，下次客户端请求时携带该 Cookie，负载均衡将请求转发到上次请求的相同后端服务。
        /// >仅当 **StickySessionEnabled** 为 **true** 时该参数生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StickySessionType")]
        public string StickySessionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StickySessionEnabled", this.StickySessionEnabled);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
            this.SetParamSimple(map, prefix + "CookieTimeout", this.CookieTimeout);
            this.SetParamSimple(map, prefix + "StickySessionType", this.StickySessionType);
        }
    }
}

