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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedRetentionPolicy : AbstractModel
    {
        
        /// <summary>
        /// 保留最新快照Days天内的每天最新的一个快照，取值范围：[0, 100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Days")]
        public ulong? Days{ get; set; }

        /// <summary>
        /// 保留最新快照Weeks周内的每周最新的一个快照，取值范围：[0, 100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weeks")]
        public ulong? Weeks{ get; set; }

        /// <summary>
        /// 保留最新快照Months月内的每月最新的一个快照， 取值范围：[0, 100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Months")]
        public ulong? Months{ get; set; }

        /// <summary>
        /// 保留最新快照Years年内的每年最新的一个快照，取值范围：[0, 100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Years")]
        public ulong? Years{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Days", this.Days);
            this.SetParamSimple(map, prefix + "Weeks", this.Weeks);
            this.SetParamSimple(map, prefix + "Months", this.Months);
            this.SetParamSimple(map, prefix + "Years", this.Years);
        }
    }
}

