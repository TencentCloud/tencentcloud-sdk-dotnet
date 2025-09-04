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

    public class CreateTcIcebergTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 表基本信息
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// 表字段信息
        /// </summary>
        [JsonProperty("Columns")]
        public TColumn[] Columns{ get; set; }

        /// <summary>
        /// 为true时只获取sql而不执行
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 表分区信息
        /// </summary>
        [JsonProperty("Partitions")]
        public TPartition[] Partitions{ get; set; }

        /// <summary>
        /// 表属性信息
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
        }
    }
}

