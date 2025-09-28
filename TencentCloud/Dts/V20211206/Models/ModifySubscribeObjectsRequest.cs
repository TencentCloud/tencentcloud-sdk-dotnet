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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubscribeObjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据订阅实例的ID，可通过[DescribeSubscribeJobs](https://cloud.tencent.com/document/product/571/102943)接口获取。
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// 数据订阅的类型，非mongo任务的枚举值：0-全实例更新；1-数据更新；2-结构更新；3-数据更新+结构更新。mongo任务的枚举值：0-全实例更新；4-订阅单库；5-订阅单集合
        /// </summary>
        [JsonProperty("SubscribeObjectType")]
        public long? SubscribeObjectType{ get; set; }

        /// <summary>
        /// 修改后的订阅数据库表信息。会覆盖原来的订阅对象，所以除非 SubscribeObjectType = 0或2，否则该字段必填。
        /// </summary>
        [JsonProperty("Objects")]
        public ModifiedSubscribeObject[] Objects{ get; set; }

        /// <summary>
        /// kafka分区策略。如果不填，默认不修改。如果填了，会覆盖原来的策略。
        /// </summary>
        [JsonProperty("DistributeRules")]
        public DistributeRule[] DistributeRules{ get; set; }

        /// <summary>
        /// 默认分区策略。不满足DistributeRules中正则表达式的数据，将按照默认分区策略计算分区。
        /// 非mongo产品支持的默认策略: table-按表名分区，pk-按表名+主键分区。mongo的默认策略仅支持：collection-按集合名分区。
        /// 该字段与DistributeRules搭配使用。如果配置了DistributeRules，该字段也必填。如果配置了该字段，视为配置了一条DistributeRules，原来的分区策略也会被覆盖。
        /// </summary>
        [JsonProperty("DefaultRuleType")]
        public string DefaultRuleType{ get; set; }

        /// <summary>
        /// mongo输出聚合设置，mongo任务可选。如果不填，默认不修改。
        /// </summary>
        [JsonProperty("PipelineInfo")]
        public PipelineInfo[] PipelineInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeObjectType", this.SubscribeObjectType);
            this.SetParamArrayObj(map, prefix + "Objects.", this.Objects);
            this.SetParamArrayObj(map, prefix + "DistributeRules.", this.DistributeRules);
            this.SetParamSimple(map, prefix + "DefaultRuleType", this.DefaultRuleType);
            this.SetParamArrayObj(map, prefix + "PipelineInfo.", this.PipelineInfo);
        }
    }
}

