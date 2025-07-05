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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Table : AbstractModel
    {
        
        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// 表名。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 库表的存储引擎。
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 行数。
        /// </summary>
        [JsonProperty("TableRows")]
        public long? TableRows{ get; set; }

        /// <summary>
        /// 总使用空间（MB）。
        /// </summary>
        [JsonProperty("TotalLength")]
        public float? TotalLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "TableRows", this.TableRows);
            this.SetParamSimple(map, prefix + "TotalLength", this.TotalLength);
        }
    }
}

