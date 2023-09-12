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

    public class InternalMedicineBaseItem : AbstractModel
    {
        
        /// <summary>
        /// 体检报告-内科-腹部
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Abdomen")]
        public InternalMedicineAbdomen Abdomen{ get; set; }

        /// <summary>
        /// 体检报告-内科-心脏
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Heart")]
        public InternalMedicineHeart Heart{ get; set; }

        /// <summary>
        /// 体检报告-内科-血管
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vessel")]
        public InternalMedicineVessel Vessel{ get; set; }

        /// <summary>
        /// 体检报告-内科-呼吸系统
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RespiratorySystem")]
        public InternalMedicineRespiratorySystem RespiratorySystem{ get; set; }

        /// <summary>
        /// 体检报告-内科-内科其他
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 体检报告-内科-小结
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BriefSummary")]
        public InternalMedicineBriefSummary BriefSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Abdomen.", this.Abdomen);
            this.SetParamObj(map, prefix + "Heart.", this.Heart);
            this.SetParamObj(map, prefix + "Vessel.", this.Vessel);
            this.SetParamObj(map, prefix + "RespiratorySystem.", this.RespiratorySystem);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "BriefSummary.", this.BriefSummary);
        }
    }
}

