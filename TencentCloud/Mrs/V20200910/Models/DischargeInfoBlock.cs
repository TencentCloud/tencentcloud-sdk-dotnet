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

    public class DischargeInfoBlock : AbstractModel
    {
        
        /// <summary>
        /// 疾病史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseaseHistory")]
        public DiseaseHistoryBlock DiseaseHistory{ get; set; }

        /// <summary>
        /// 个人史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalHistory")]
        public PersonalHistoryBlock PersonalHistory{ get; set; }

        /// <summary>
        /// 药物史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DrugHistory")]
        public DrugHistoryBlock DrugHistory{ get; set; }

        /// <summary>
        /// 治疗相关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreatmentRecord")]
        public TreatmentRecordBlock TreatmentRecord{ get; set; }

        /// <summary>
        /// 文本段落
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParagraphBlock")]
        public ParagraphBlock ParagraphBlock{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DiseaseHistory.", this.DiseaseHistory);
            this.SetParamObj(map, prefix + "PersonalHistory.", this.PersonalHistory);
            this.SetParamObj(map, prefix + "DrugHistory.", this.DrugHistory);
            this.SetParamObj(map, prefix + "TreatmentRecord.", this.TreatmentRecord);
            this.SetParamObj(map, prefix + "ParagraphBlock.", this.ParagraphBlock);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

