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

    public class GynaecologyBaseItem : AbstractModel
    {
        
        /// <summary>
        /// 外阴
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vulva")]
        public GynaecologyVulva Vulva{ get; set; }

        /// <summary>
        /// 阴道
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vagina")]
        public GynaecologyVagina Vagina{ get; set; }

        /// <summary>
        /// 子宫颈
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cervix")]
        public GynaecologyCervix Cervix{ get; set; }

        /// <summary>
        /// 子宫
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uterus")]
        public GynaecologyUterus Uterus{ get; set; }

        /// <summary>
        /// 子宫附件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Adnexal")]
        public GynaecologyAdnexal Adnexal{ get; set; }

        /// <summary>
        /// 盆腔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PelvicCavity")]
        public GynaecologyPelvicCavity PelvicCavity{ get; set; }

        /// <summary>
        /// 妇科其他
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 月经史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MenstrualHistory")]
        public GynaecologyMenstrualHistory MenstrualHistory{ get; set; }

        /// <summary>
        /// 小结
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BriefSummary")]
        public GynaecologyBriefSummary BriefSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Vulva.", this.Vulva);
            this.SetParamObj(map, prefix + "Vagina.", this.Vagina);
            this.SetParamObj(map, prefix + "Cervix.", this.Cervix);
            this.SetParamObj(map, prefix + "Uterus.", this.Uterus);
            this.SetParamObj(map, prefix + "Adnexal.", this.Adnexal);
            this.SetParamObj(map, prefix + "PelvicCavity.", this.PelvicCavity);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "MenstrualHistory.", this.MenstrualHistory);
            this.SetParamObj(map, prefix + "BriefSummary.", this.BriefSummary);
        }
    }
}

