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

    public class StepDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 步骤序列
        /// </summary>
        [JsonProperty("StepNo")]
        public ulong? StepNo{ get; set; }

        /// <summary>
        /// 步骤展现名称
        /// </summary>
        [JsonProperty("StepName")]
        public string StepName{ get; set; }

        /// <summary>
        /// 步骤英文标识
        /// </summary>
        [JsonProperty("StepId")]
        public string StepId{ get; set; }

        /// <summary>
        /// 步骤状态:success(成功)、failed(失败)、running(执行中)、notStarted(未执行)、默认为notStarted
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前步骤开始的时间，格式为"yyyy-mm-dd hh:mm:ss"，该字段不存在或者为空是无意义 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 步骤错误信息
        /// </summary>
        [JsonProperty("StepMessage")]
        public string StepMessage{ get; set; }

        /// <summary>
        /// 执行进度
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("Errors")]
        public ProcessStepTip[] Errors{ get; set; }

        /// <summary>
        /// 告警提示
        /// </summary>
        [JsonProperty("Warnings")]
        public ProcessStepTip[] Warnings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepNo", this.StepNo);
            this.SetParamSimple(map, prefix + "StepName", this.StepName);
            this.SetParamSimple(map, prefix + "StepId", this.StepId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StepMessage", this.StepMessage);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamArrayObj(map, prefix + "Errors.", this.Errors);
            this.SetParamArrayObj(map, prefix + "Warnings.", this.Warnings);
        }
    }
}

