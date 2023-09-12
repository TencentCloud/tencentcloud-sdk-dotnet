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

    public class PhysicalExamination : AbstractModel
    {
        
        /// <summary>
        /// 一般检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GeneralExamination")]
        public GeneralExaminationBaseItem GeneralExamination{ get; set; }

        /// <summary>
        /// 内科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalMedicine")]
        public InternalMedicineBaseItem InternalMedicine{ get; set; }

        /// <summary>
        /// 外科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Surgery")]
        public SurgeryBaseItem Surgery{ get; set; }

        /// <summary>
        /// 口腔科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stomatology")]
        public StomatologyBaseItem Stomatology{ get; set; }

        /// <summary>
        /// 眼科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ophthalmology")]
        public OphthalmologyBaseItem Ophthalmology{ get; set; }

        /// <summary>
        /// 耳鼻喉科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Otolaryngology")]
        public OtolaryngologyBaseItem Otolaryngology{ get; set; }

        /// <summary>
        /// 妇科
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gynaecology")]
        public GynaecologyBaseItem Gynaecology{ get; set; }

        /// <summary>
        /// 未标准化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unclassified")]
        public KeyValueItem[] Unclassified{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "GeneralExamination.", this.GeneralExamination);
            this.SetParamObj(map, prefix + "InternalMedicine.", this.InternalMedicine);
            this.SetParamObj(map, prefix + "Surgery.", this.Surgery);
            this.SetParamObj(map, prefix + "Stomatology.", this.Stomatology);
            this.SetParamObj(map, prefix + "Ophthalmology.", this.Ophthalmology);
            this.SetParamObj(map, prefix + "Otolaryngology.", this.Otolaryngology);
            this.SetParamObj(map, prefix + "Gynaecology.", this.Gynaecology);
            this.SetParamArrayObj(map, prefix + "Unclassified.", this.Unclassified);
        }
    }
}

