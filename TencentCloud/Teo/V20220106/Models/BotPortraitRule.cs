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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotPortraitRule : AbstractModel
    {
        
        /// <summary>
        /// 本功能的开关。
        /// 1. on 开启
        /// 2. off 关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 本规则的ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// JS挑战的规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgManagedIds")]
        public long?[] AlgManagedIds{ get; set; }

        /// <summary>
        /// 数字验证码的规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CapManagedIds")]
        public long?[] CapManagedIds{ get; set; }

        /// <summary>
        /// 观察的规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonManagedIds")]
        public long?[] MonManagedIds{ get; set; }

        /// <summary>
        /// 拦截的规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DropManagedIds")]
        public long?[] DropManagedIds{ get; set; }

        /// <summary>
        /// 保留。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManagedIds")]
        public long?[] ManagedIds{ get; set; }

        /// <summary>
        /// 保留。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransManagedIds")]
        public long?[] TransManagedIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "AlgManagedIds.", this.AlgManagedIds);
            this.SetParamArraySimple(map, prefix + "CapManagedIds.", this.CapManagedIds);
            this.SetParamArraySimple(map, prefix + "MonManagedIds.", this.MonManagedIds);
            this.SetParamArraySimple(map, prefix + "DropManagedIds.", this.DropManagedIds);
            this.SetParamArraySimple(map, prefix + "ManagedIds.", this.ManagedIds);
            this.SetParamArraySimple(map, prefix + "TransManagedIds.", this.TransManagedIds);
        }
    }
}

