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

    public class OphthalmologyBaseItem : AbstractModel
    {
        
        /// <summary>
        /// 裸眼视力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BareEyeSight")]
        public OphthalmologyBareEyeSight BareEyeSight{ get; set; }

        /// <summary>
        /// 矫正视力
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CorrectedVisualAcuity")]
        public OphthalmologyCorrectedVisualAcuity CorrectedVisualAcuity{ get; set; }

        /// <summary>
        /// 色觉
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColourVision")]
        public OphthalmologyColourVision ColourVision{ get; set; }

        /// <summary>
        /// 眼底
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fundoscopy")]
        public OphthalmologyFundoscopy Fundoscopy{ get; set; }

        /// <summary>
        /// 眼科其他
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 眼科小结
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BriefSummary")]
        public OphthalmologyBriefSummary BriefSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BareEyeSight.", this.BareEyeSight);
            this.SetParamObj(map, prefix + "CorrectedVisualAcuity.", this.CorrectedVisualAcuity);
            this.SetParamObj(map, prefix + "ColourVision.", this.ColourVision);
            this.SetParamObj(map, prefix + "Fundoscopy.", this.Fundoscopy);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "BriefSummary.", this.BriefSummary);
        }
    }
}

