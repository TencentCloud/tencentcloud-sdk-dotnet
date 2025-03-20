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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchemaSpaceData : AbstractModel
    {
        
        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// 数据空间（MB）。
        /// </summary>
        [JsonProperty("DataLength")]
        public float? DataLength{ get; set; }

        /// <summary>
        /// 索引空间（MB）。
        /// </summary>
        [JsonProperty("IndexLength")]
        public float? IndexLength{ get; set; }

        /// <summary>
        /// 碎片空间（MB）。
        /// </summary>
        [JsonProperty("DataFree")]
        public float? DataFree{ get; set; }

        /// <summary>
        /// 总使用空间（MB）。
        /// </summary>
        [JsonProperty("TotalLength")]
        public float? TotalLength{ get; set; }

        /// <summary>
        /// 碎片率（%）。
        /// </summary>
        [JsonProperty("FragRatio")]
        public float? FragRatio{ get; set; }

        /// <summary>
        /// 行数。
        /// </summary>
        [JsonProperty("TableRows")]
        public long? TableRows{ get; set; }

        /// <summary>
        /// 库中所有表对应的独立物理文件大小加和（MB）。
        /// </summary>
        [JsonProperty("PhysicalFileSize")]
        public float? PhysicalFileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "DataLength", this.DataLength);
            this.SetParamSimple(map, prefix + "IndexLength", this.IndexLength);
            this.SetParamSimple(map, prefix + "DataFree", this.DataFree);
            this.SetParamSimple(map, prefix + "TotalLength", this.TotalLength);
            this.SetParamSimple(map, prefix + "FragRatio", this.FragRatio);
            this.SetParamSimple(map, prefix + "TableRows", this.TableRows);
            this.SetParamSimple(map, prefix + "PhysicalFileSize", this.PhysicalFileSize);
        }
    }
}

