/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndicatorBaseSimpleInfo : AbstractModel
    {
        
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MeasureUnit")]
        public long? MeasureUnit{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorCode")]
        public string IndicatorCode{ get; set; }

        /// <summary>
        /// 业务负责人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizOwnerName")]
        public string BizOwnerName{ get; set; }

        /// <summary>
        /// 技术服务站名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TechOwnerName")]
        public string TechOwnerName{ get; set; }

        /// <summary>
        /// 业务口径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCaliber")]
        public string BizCaliber{ get; set; }

        /// <summary>
        /// 指标类型（1-原子指标 2-衍生指标 3-复合指标）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorType")]
        public long? IndicatorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MeasureUnit", this.MeasureUnit);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IndicatorCode", this.IndicatorCode);
            this.SetParamSimple(map, prefix + "BizOwnerName", this.BizOwnerName);
            this.SetParamSimple(map, prefix + "TechOwnerName", this.TechOwnerName);
            this.SetParamSimple(map, prefix + "BizCaliber", this.BizCaliber);
            this.SetParamSimple(map, prefix + "IndicatorType", this.IndicatorType);
        }
    }
}

