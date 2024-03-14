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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiData : AbstractModel
    {
        
        /// <summary>
        /// 数据接入id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiId")]
        public string DiId{ get; set; }

        /// <summary>
        /// 数据接入创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 数据接入状态，0处理中，1正常，-2删除中，-3已删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// cvm数据源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiDataSourceCvm")]
        public DiDataSourceCvm DiDataSourceCvm{ get; set; }

        /// <summary>
        /// tke数据源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiDataSourceTke")]
        public DiDataSourceTke DiDataSourceTke{ get; set; }

        /// <summary>
        /// serverless目的端信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiDataSinkServerless")]
        public DiDataSinkServerless DiDataSinkServerless{ get; set; }

        /// <summary>
        /// 数据接入类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiDataSourceType")]
        public string DiDataSourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiId", this.DiId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "DiDataSourceCvm.", this.DiDataSourceCvm);
            this.SetParamObj(map, prefix + "DiDataSourceTke.", this.DiDataSourceTke);
            this.SetParamObj(map, prefix + "DiDataSinkServerless.", this.DiDataSinkServerless);
            this.SetParamSimple(map, prefix + "DiDataSourceType", this.DiDataSourceType);
        }
    }
}

