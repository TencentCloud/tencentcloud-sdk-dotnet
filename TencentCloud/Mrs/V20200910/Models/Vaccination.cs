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

    public class Vaccination : AbstractModel
    {
        
        /// <summary>
        /// 序号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 疫苗名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vaccine")]
        public string Vaccine{ get; set; }

        /// <summary>
        /// 剂次
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Dose")]
        public string Dose{ get; set; }

        /// <summary>
        /// 接种日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 疫苗批号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LotNumber")]
        public string LotNumber{ get; set; }

        /// <summary>
        /// 生产企业
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 接种单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Clinic")]
        public string Clinic{ get; set; }

        /// <summary>
        /// 接种部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Site")]
        public string Site{ get; set; }

        /// <summary>
        /// 接种者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 疫苗批号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lot")]
        public string Lot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Vaccine", this.Vaccine);
            this.SetParamSimple(map, prefix + "Dose", this.Dose);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "LotNumber", this.LotNumber);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "Clinic", this.Clinic);
            this.SetParamSimple(map, prefix + "Site", this.Site);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Lot", this.Lot);
        }
    }
}

