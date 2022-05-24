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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexPolicyField : AbstractModel
    {
        
        /// <summary>
        /// 是否开启warm阶段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmEnable")]
        public string WarmEnable{ get; set; }

        /// <summary>
        /// warm阶段转入时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarmMinAge")]
        public string WarmMinAge{ get; set; }

        /// <summary>
        /// 是否开启cold阶段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdEnable")]
        public string ColdEnable{ get; set; }

        /// <summary>
        /// cold阶段转入时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColdMinAge")]
        public string ColdMinAge{ get; set; }

        /// <summary>
        /// 是否开启frozen阶段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenEnable")]
        public string FrozenEnable{ get; set; }

        /// <summary>
        /// frozen阶段转入时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrozenMinAge")]
        public string FrozenMinAge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarmEnable", this.WarmEnable);
            this.SetParamSimple(map, prefix + "WarmMinAge", this.WarmMinAge);
            this.SetParamSimple(map, prefix + "ColdEnable", this.ColdEnable);
            this.SetParamSimple(map, prefix + "ColdMinAge", this.ColdMinAge);
            this.SetParamSimple(map, prefix + "FrozenEnable", this.FrozenEnable);
            this.SetParamSimple(map, prefix + "FrozenMinAge", this.FrozenMinAge);
        }
    }
}

