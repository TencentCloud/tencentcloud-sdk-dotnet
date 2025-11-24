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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcInfo : AbstractModel
    {
        
        /// <summary>
        /// dlc表信息
        /// </summary>
        [JsonProperty("TableInfo")]
        public DlcTableInfo TableInfo{ get; set; }

        /// <summary>
        /// dlc数据字段信息
        /// </summary>
        [JsonProperty("FieldInfos")]
        public DlcFiledInfo[] FieldInfos{ get; set; }

        /// <summary>
        /// dlc分区信息
        /// </summary>
        [JsonProperty("PartitionInfos")]
        public DlcPartitionInfo[] PartitionInfos{ get; set; }

        /// <summary>
        /// dlc分区额外信息
        /// </summary>
        [JsonProperty("PartitionExtra")]
        public DlcPartitionExtra PartitionExtra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableInfo.", this.TableInfo);
            this.SetParamArrayObj(map, prefix + "FieldInfos.", this.FieldInfos);
            this.SetParamArrayObj(map, prefix + "PartitionInfos.", this.PartitionInfos);
            this.SetParamObj(map, prefix + "PartitionExtra.", this.PartitionExtra);
        }
    }
}

