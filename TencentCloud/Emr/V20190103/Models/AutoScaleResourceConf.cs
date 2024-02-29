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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleResourceConf : AbstractModel
    {
        
        /// <summary>
        /// 配置ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 集群实例ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// 自动扩缩容保留最小实例数。
        /// </summary>
        [JsonProperty("ScaleLowerBound")]
        public long? ScaleLowerBound{ get; set; }

        /// <summary>
        /// 自动扩缩容最大实例数。
        /// </summary>
        [JsonProperty("ScaleUpperBound")]
        public long? ScaleUpperBound{ get; set; }

        /// <summary>
        /// 扩容规则类型，1为按负载指标扩容规则，2为按时间扩容规则
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// 下次能可扩容时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextTimeCanScale")]
        public ulong? NextTimeCanScale{ get; set; }

        /// <summary>
        /// 优雅缩容开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ScaleLowerBound", this.ScaleLowerBound);
            this.SetParamSimple(map, prefix + "ScaleUpperBound", this.ScaleUpperBound);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "NextTimeCanScale", this.NextTimeCanScale);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
        }
    }
}

