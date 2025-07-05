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

    public class AccessURLRedirectParameters : AbstractModel
    {
        
        /// <summary>
        /// 状态码，取值为 301、302、303、307、308 之一。
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 目标请求协议，取值有：
        /// <li>http：目标请求协议 HTTP；</li>
        /// <li>https：目标请求协议 HTTPS；</li>
        /// <li>follow：跟随请求。</li>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 目标 HostName 。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostName")]
        public HostName HostName{ get; set; }

        /// <summary>
        /// 目标路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("URLPath")]
        public URLPath URLPath{ get; set; }

        /// <summary>
        /// 携带查询参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryString")]
        public AccessURLRedirectQueryString QueryString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HostName.", this.HostName);
            this.SetParamObj(map, prefix + "URLPath.", this.URLPath);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
        }
    }
}

