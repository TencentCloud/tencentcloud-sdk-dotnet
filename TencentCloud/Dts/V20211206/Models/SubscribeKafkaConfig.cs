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

    public class SubscribeKafkaConfig : AbstractModel
    {
        
        /// <summary>
        /// kafka分区数量，枚举值为1，4，8
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumberOfPartitions")]
        public ulong? NumberOfPartitions{ get; set; }

        /// <summary>
        /// 分区规则。当NumberOfPartitions > 1时，该项必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DistributeRules")]
        public DistributeRule[] DistributeRules{ get; set; }

        /// <summary>
        /// 默认分区策略。当NumberOfPartitions > 1时，该项必填。不满足DistributeRules中正则表达式的数据，将按照默认分区策略计算分区。
        /// 非mongo产品的枚举值为: table-按表名分区，pk-按表名+主键分区。mongo的枚举值为：collection-按集合名分区。
        /// 该字段与DistributeRules搭配使用，如果配置了该字段，视为配置了一条DistributeRules。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultRuleType")]
        public string DefaultRuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NumberOfPartitions", this.NumberOfPartitions);
            this.SetParamArrayObj(map, prefix + "DistributeRules.", this.DistributeRules);
            this.SetParamSimple(map, prefix + "DefaultRuleType", this.DefaultRuleType);
        }
    }
}

