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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MenstrualHistoryBlock : AbstractModel
    {
        
        /// <summary>
        /// 末次月经
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastMenstrualPeriod")]
        public LastMenstrualPeriodBlock LastMenstrualPeriod{ get; set; }

        /// <summary>
        /// 月经量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstrualFlow")]
        public MenstrualFlowBlock MenstrualFlow{ get; set; }

        /// <summary>
        /// 初潮时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenarcheAge")]
        public LastMenstrualPeriodBlock MenarcheAge{ get; set; }

        /// <summary>
        /// 是否绝经
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstruationOrNot")]
        public MenstruationOrNotBlock MenstruationOrNot{ get; set; }

        /// <summary>
        /// 月经周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstrualCycles")]
        public LastMenstrualPeriodBlock MenstrualCycles{ get; set; }

        /// <summary>
        /// 月经经期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstrualPeriod")]
        public MenstrualPeriodBlock MenstrualPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LastMenstrualPeriod.", this.LastMenstrualPeriod);
            this.SetParamObj(map, prefix + "MenstrualFlow.", this.MenstrualFlow);
            this.SetParamObj(map, prefix + "MenarcheAge.", this.MenarcheAge);
            this.SetParamObj(map, prefix + "MenstruationOrNot.", this.MenstruationOrNot);
            this.SetParamObj(map, prefix + "MenstrualCycles.", this.MenstrualCycles);
            this.SetParamObj(map, prefix + "MenstrualPeriod.", this.MenstrualPeriod);
        }
    }
}

