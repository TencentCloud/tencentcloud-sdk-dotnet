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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataFormat : AbstractModel
    {
        
        /// <summary>
        /// 文本格式，TextFile。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextFile")]
        public TextFile TextFile{ get; set; }

        /// <summary>
        /// 文本格式，CSV。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CSV")]
        public CSV CSV{ get; set; }

        /// <summary>
        /// 文本格式，Json。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Json")]
        public Other Json{ get; set; }

        /// <summary>
        /// Parquet格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Parquet")]
        public Other Parquet{ get; set; }

        /// <summary>
        /// ORC格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ORC")]
        public Other ORC{ get; set; }

        /// <summary>
        /// AVRO格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AVRO")]
        public Other AVRO{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TextFile.", this.TextFile);
            this.SetParamObj(map, prefix + "CSV.", this.CSV);
            this.SetParamObj(map, prefix + "Json.", this.Json);
            this.SetParamObj(map, prefix + "Parquet.", this.Parquet);
            this.SetParamObj(map, prefix + "ORC.", this.ORC);
            this.SetParamObj(map, prefix + "AVRO.", this.AVRO);
        }
    }
}

