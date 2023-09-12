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

    public class GeneralExaminationOthers : AbstractModel
    {
        
        /// <summary>
        /// 面容与表情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Countenance")]
        public KeyValueItem Countenance{ get; set; }

        /// <summary>
        /// 精神状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MentalStatus")]
        public KeyValueItem MentalStatus{ get; set; }

        /// <summary>
        /// 发育及营养状况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DevelopmentCondition")]
        public KeyValueItem DevelopmentCondition{ get; set; }

        /// <summary>
        /// 记忆力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Memory")]
        public KeyValueItem Memory{ get; set; }

        /// <summary>
        /// 臀围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hipline")]
        public ValueUnitItem Hipline{ get; set; }

        /// <summary>
        /// 腰臀比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaistHipRatio")]
        public ValueUnitItem WaistHipRatio{ get; set; }

        /// <summary>
        /// 生活嗜好
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Addiction")]
        public KeyValueItem Addiction{ get; set; }

        /// <summary>
        /// 生活能力评定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbilityOfLifeADL")]
        public KeyValueItem AbilityOfLifeADL{ get; set; }

        /// <summary>
        /// 一般检查其他
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 胸围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChestCircumference")]
        public ChestCircumferenceItem ChestCircumference{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Countenance.", this.Countenance);
            this.SetParamObj(map, prefix + "MentalStatus.", this.MentalStatus);
            this.SetParamObj(map, prefix + "DevelopmentCondition.", this.DevelopmentCondition);
            this.SetParamObj(map, prefix + "Memory.", this.Memory);
            this.SetParamObj(map, prefix + "Hipline.", this.Hipline);
            this.SetParamObj(map, prefix + "WaistHipRatio.", this.WaistHipRatio);
            this.SetParamObj(map, prefix + "Addiction.", this.Addiction);
            this.SetParamObj(map, prefix + "AbilityOfLifeADL.", this.AbilityOfLifeADL);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "ChestCircumference.", this.ChestCircumference);
        }
    }
}

