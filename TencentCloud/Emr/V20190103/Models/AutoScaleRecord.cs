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

    public class AutoScaleRecord : AbstractModel
    {
        
        /// <summary>
        /// 扩缩容规则名。
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// "SCALE_OUT"和"SCALE_IN"，分别表示扩容和缩容。
        /// </summary>
        [JsonProperty("ScaleAction")]
        public string ScaleAction{ get; set; }

        /// <summary>
        /// 取值为"SUCCESS","FAILED","PART_SUCCESS","IN_PROCESS"，分别表示成功、失败、部分成功和流程中。
        /// </summary>
        [JsonProperty("ActionStatus")]
        public string ActionStatus{ get; set; }

        /// <summary>
        /// 流程触发时间。
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// 扩缩容相关描述信息。
        /// </summary>
        [JsonProperty("ScaleInfo")]
        public string ScaleInfo{ get; set; }

        /// <summary>
        /// 只在ScaleAction为SCALE_OUT时有效。
        /// </summary>
        [JsonProperty("ExpectScaleNum")]
        public long? ExpectScaleNum{ get; set; }

        /// <summary>
        /// 流程结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 策略类型，按负载或者按时间，1表示负载伸缩，2表示时间伸缩
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// 扩容时所使用规格信息。
        /// </summary>
        [JsonProperty("SpecInfo")]
        public string SpecInfo{ get; set; }

        /// <summary>
        /// 补偿扩容，0表示不开启，1表示开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// 补偿次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompensateCount")]
        public long? CompensateCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ActionStatus", this.ActionStatus);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamSimple(map, prefix + "ScaleInfo", this.ScaleInfo);
            this.SetParamSimple(map, prefix + "ExpectScaleNum", this.ExpectScaleNum);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "SpecInfo", this.SpecInfo);
            this.SetParamSimple(map, prefix + "CompensateFlag", this.CompensateFlag);
            this.SetParamSimple(map, prefix + "CompensateCount", this.CompensateCount);
        }
    }
}

