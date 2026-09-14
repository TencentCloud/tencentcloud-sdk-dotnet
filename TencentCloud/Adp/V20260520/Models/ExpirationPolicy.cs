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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpirationPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>有效时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EffectivePeriod")]
        public EffectivePeriod EffectivePeriod{ get; set; }

        /// <summary>
        /// <p>超过有效时间后的行为：1=NOT_RETRIEVABLE 不可被检索，2=RETRIEVABLE 仍可被检索；永久有效时无意义<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>EXPIRE_BEHAVIOR_UNKNOWN</td><td>0</td><td>未指定（服务端按默认处理）</td></tr><tr><td>EXPIRE_BEHAVIOR_NOT_RETRIEVABLE</td><td>1</td><td>不可被检索（到期下架）</td></tr><tr><td>EXPIRE_BEHAVIOR_RETRIEVABLE</td><td>2</td><td>仍可被检索（到期不下架，仅标记时效范围）</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ExpireBehavior")]
        public long? ExpireBehavior{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EffectivePeriod.", this.EffectivePeriod);
            this.SetParamSimple(map, prefix + "ExpireBehavior", this.ExpireBehavior);
        }
    }
}

