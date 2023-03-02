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

    public class FirstPage : AbstractModel
    {
        
        /// <summary>
        /// 出入院诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeDiagnosis")]
        public DischargeDiagnosis[] DischargeDiagnosis{ get; set; }

        /// <summary>
        /// 病理诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathologicalDiagnosis")]
        public BlockInfo PathologicalDiagnosis{ get; set; }

        /// <summary>
        /// 临床诊断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClinicalDiagnosis")]
        public BlockInfo ClinicalDiagnosis{ get; set; }

        /// <summary>
        /// 受伤中毒的外部原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DamagePoi")]
        public BlockInfoV2 DamagePoi{ get; set; }

        /// <summary>
        /// 病案首页第二页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fp2NdItems")]
        public Fp2NdItem[] Fp2NdItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DischargeDiagnosis.", this.DischargeDiagnosis);
            this.SetParamObj(map, prefix + "PathologicalDiagnosis.", this.PathologicalDiagnosis);
            this.SetParamObj(map, prefix + "ClinicalDiagnosis.", this.ClinicalDiagnosis);
            this.SetParamObj(map, prefix + "DamagePoi.", this.DamagePoi);
            this.SetParamArrayObj(map, prefix + "Fp2NdItems.", this.Fp2NdItems);
        }
    }
}

