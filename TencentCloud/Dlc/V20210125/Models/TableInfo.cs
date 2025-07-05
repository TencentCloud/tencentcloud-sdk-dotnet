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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据表配置信息。
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// 数据表格式。每次入参可选如下其一的KV结构，[TextFile，CSV，Json, Parquet, ORC, AVRD]。
        /// </summary>
        [JsonProperty("DataFormat")]
        public DataFormat DataFormat{ get; set; }

        /// <summary>
        /// 数据表列信息。
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// 数据表分块信息。
        /// </summary>
        [JsonProperty("Partitions")]
        public Partition[] Partitions{ get; set; }

        /// <summary>
        /// 数据存储路径。当前仅支持cos路径，格式如下：cosn://bucket-name/filepath。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamObj(map, prefix + "DataFormat.", this.DataFormat);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamSimple(map, prefix + "Location", this.Location);
        }
    }
}

