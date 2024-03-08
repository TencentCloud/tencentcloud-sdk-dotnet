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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicRule : AbstractModel
    {
        
        /// <summary>
        /// topic名。单topic时，所有的TopicName必须相同
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// topic分区策略，自定义topic时支持：Random（随机投递），集中投递到单Topic时支持：AllInPartitionZero（全部投递至partition0）、PartitionByTable(按表名分区)、PartitionByTableAndKey(按表名加主键分区)、PartitionByCols(按列分区)
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// 库名匹配规则，如Regular（正则匹配）, Default(不符合匹配规则的剩余库)，数组中最后一项必须为‘Default’
        /// </summary>
        [JsonProperty("DbMatchMode")]
        public string DbMatchMode{ get; set; }

        /// <summary>
        /// 库名，DbMatchMode=Regular时生效
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 表名匹配规则，如Regular（正则匹配）, Default(不符合匹配规则的剩余表)，数组中最后一项必须为‘Default’
        /// </summary>
        [JsonProperty("TableMatchMode")]
        public string TableMatchMode{ get; set; }

        /// <summary>
        /// 表名，仅TableMatchMode=Regular时生效
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 按列分区时需要选择配置列名，可以选择多列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public string[] Columns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "DbMatchMode", this.DbMatchMode);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "TableMatchMode", this.TableMatchMode);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamArraySimple(map, prefix + "Columns.", this.Columns);
        }
    }
}

