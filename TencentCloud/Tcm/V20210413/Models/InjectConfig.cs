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

    public class InjectConfig : AbstractModel
    {
        
        /// <summary>
        /// 不需要进行代理的 ip 地址范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludeIPRanges")]
        public string[] ExcludeIPRanges{ get; set; }

        /// <summary>
        /// 是否等待sidecar启动
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HoldApplicationUntilProxyStarts")]
        public bool? HoldApplicationUntilProxyStarts{ get; set; }

        /// <summary>
        /// 是否允许sidecar等待
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HoldProxyUntilApplicationEnds")]
        public bool? HoldProxyUntilApplicationEnds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ExcludeIPRanges.", this.ExcludeIPRanges);
            this.SetParamSimple(map, prefix + "HoldApplicationUntilProxyStarts", this.HoldApplicationUntilProxyStarts);
            this.SetParamSimple(map, prefix + "HoldProxyUntilApplicationEnds", this.HoldProxyUntilApplicationEnds);
        }
    }
}

