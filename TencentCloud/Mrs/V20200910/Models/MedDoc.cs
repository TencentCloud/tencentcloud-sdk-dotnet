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

    public class MedDoc : AbstractModel
    {
        
        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Advice")]
        public Advice Advice{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Diagnosis")]
        public DiagCertItem[] Diagnosis{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseaseMedicalHistory")]
        public DiseaseMedicalHistory DiseaseMedicalHistory{ get; set; }

        /// <summary>
        /// “”
        /// </summary>
        [JsonProperty("PersonalMedicalHistory")]
        public PersonalMedicalHistory PersonalMedicalHistory{ get; set; }

        /// <summary>
        /// “”
        /// </summary>
        [JsonProperty("ObstericalMedicalHistory")]
        public ObstericalMedicalHistory ObstericalMedicalHistory{ get; set; }

        /// <summary>
        /// “”
        /// </summary>
        [JsonProperty("FamilyMedicalHistory")]
        public FamilyMedicalHistory FamilyMedicalHistory{ get; set; }

        /// <summary>
        /// “”
        /// </summary>
        [JsonProperty("MenstrualMedicalHistory")]
        public MenstrualMedicalHistory MenstrualMedicalHistory{ get; set; }

        /// <summary>
        /// “”
        /// </summary>
        [JsonProperty("TreatmentRecord")]
        public TreatmentRecord TreatmentRecord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Advice.", this.Advice);
            this.SetParamArrayObj(map, prefix + "Diagnosis.", this.Diagnosis);
            this.SetParamObj(map, prefix + "DiseaseMedicalHistory.", this.DiseaseMedicalHistory);
            this.SetParamObj(map, prefix + "PersonalMedicalHistory.", this.PersonalMedicalHistory);
            this.SetParamObj(map, prefix + "ObstericalMedicalHistory.", this.ObstericalMedicalHistory);
            this.SetParamObj(map, prefix + "FamilyMedicalHistory.", this.FamilyMedicalHistory);
            this.SetParamObj(map, prefix + "MenstrualMedicalHistory.", this.MenstrualMedicalHistory);
            this.SetParamObj(map, prefix + "TreatmentRecord.", this.TreatmentRecord);
        }
    }
}

