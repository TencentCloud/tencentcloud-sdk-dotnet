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

    public class SyncDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 总步骤数
        /// </summary>
        [JsonProperty("StepAll")]
        public ulong? StepAll{ get; set; }

        /// <summary>
        /// 当前步骤
        /// </summary>
        [JsonProperty("StepNow")]
        public ulong? StepNow{ get; set; }

        /// <summary>
        /// 总体进度
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 当前步骤进度，范围为[0-100]，若为-1表示当前步骤不支持查看进度
        /// </summary>
        [JsonProperty("CurrentStepProgress")]
        public long? CurrentStepProgress{ get; set; }

        /// <summary>
        /// 同步两端数据量差距
        /// </summary>
        [JsonProperty("MasterSlaveDistance")]
        public long? MasterSlaveDistance{ get; set; }

        /// <summary>
        /// 同步两端时间差距
        /// </summary>
        [JsonProperty("SecondsBehindMaster")]
        public long? SecondsBehindMaster{ get; set; }

        /// <summary>
        /// 总体描述信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 详细步骤信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StepInfos")]
        public StepInfo[] StepInfos{ get; set; }

        /// <summary>
        /// 不能发起一致性校验的原因
        /// </summary>
        [JsonProperty("CauseOfCompareDisable")]
        public string CauseOfCompareDisable{ get; set; }

        /// <summary>
        /// 任务的错误和解决方案信息
        /// </summary>
        [JsonProperty("ErrInfo")]
        public ErrInfo ErrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepAll", this.StepAll);
            this.SetParamSimple(map, prefix + "StepNow", this.StepNow);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "CurrentStepProgress", this.CurrentStepProgress);
            this.SetParamSimple(map, prefix + "MasterSlaveDistance", this.MasterSlaveDistance);
            this.SetParamSimple(map, prefix + "SecondsBehindMaster", this.SecondsBehindMaster);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "StepInfos.", this.StepInfos);
            this.SetParamSimple(map, prefix + "CauseOfCompareDisable", this.CauseOfCompareDisable);
            this.SetParamObj(map, prefix + "ErrInfo.", this.ErrInfo);
        }
    }
}

