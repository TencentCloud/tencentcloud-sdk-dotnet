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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextTractorVehicleBack : AbstractModel
    {
        
        /// <summary>
        /// 号牌号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlateNo")]
        public string PlateNo{ get; set; }

        /// <summary>
        /// 准乘人数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowNum")]
        public string AllowNum{ get; set; }

        /// <summary>
        /// 联合收割机质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CombineHarvesterQuality")]
        public string CombineHarvesterQuality{ get; set; }

        /// <summary>
        /// 拖拉机最小使用质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TractorMinUsageWeight")]
        public string TractorMinUsageWeight{ get; set; }

        /// <summary>
        /// 拖拉机最大允许载质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TractorMaxAllowLoadCapacity")]
        public string TractorMaxAllowLoadCapacity{ get; set; }

        /// <summary>
        /// 外廓尺寸
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalSize")]
        public string ExternalSize{ get; set; }

        /// <summary>
        /// 检验记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VehicleType")]
        public string VehicleType{ get; set; }

        /// <summary>
        /// 住址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlateNo", this.PlateNo);
            this.SetParamSimple(map, prefix + "AllowNum", this.AllowNum);
            this.SetParamSimple(map, prefix + "CombineHarvesterQuality", this.CombineHarvesterQuality);
            this.SetParamSimple(map, prefix + "TractorMinUsageWeight", this.TractorMinUsageWeight);
            this.SetParamSimple(map, prefix + "TractorMaxAllowLoadCapacity", this.TractorMaxAllowLoadCapacity);
            this.SetParamSimple(map, prefix + "ExternalSize", this.ExternalSize);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "VehicleType", this.VehicleType);
            this.SetParamSimple(map, prefix + "Address", this.Address);
        }
    }
}

