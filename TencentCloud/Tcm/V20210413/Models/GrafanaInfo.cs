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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GrafanaInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 内网地址
        /// </summary>
        [JsonProperty("InternalURL")]
        public string InternalURL{ get; set; }

        /// <summary>
        /// 公网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicURL")]
        public string PublicURL{ get; set; }

        /// <summary>
        /// 公网失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicFailedReason")]
        public string PublicFailedReason{ get; set; }

        /// <summary>
        /// 公网失败详细信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicFailedMessage")]
        public string PublicFailedMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "InternalURL", this.InternalURL);
            this.SetParamSimple(map, prefix + "PublicURL", this.PublicURL);
            this.SetParamSimple(map, prefix + "PublicFailedReason", this.PublicFailedReason);
            this.SetParamSimple(map, prefix + "PublicFailedMessage", this.PublicFailedMessage);
        }
    }
}

