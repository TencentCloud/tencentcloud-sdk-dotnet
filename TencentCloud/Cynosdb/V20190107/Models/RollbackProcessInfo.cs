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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackProcessInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否可以交换vip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsVipSwitchable")]
        public bool? IsVipSwitchable{ get; set; }

        /// <summary>
        /// vip可交换时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipSwitchableTime")]
        public string VipSwitchableTime{ get; set; }

        /// <summary>
        /// 交换实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExchangeInstanceInfoList")]
        public ExchangeInstanceInfo[] ExchangeInstanceInfoList{ get; set; }

        /// <summary>
        /// 交换RO组列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExchangeRoGroupInfoList")]
        public ExchangeRoGroupInfo[] ExchangeRoGroupInfoList{ get; set; }

        /// <summary>
        /// 当前步骤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentStep")]
        public string CurrentStep{ get; set; }

        /// <summary>
        /// 当前步骤进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentStepProgress")]
        public long? CurrentStepProgress{ get; set; }

        /// <summary>
        /// 当前步骤剩余时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentStepRemainingTime")]
        public string CurrentStepRemainingTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsVipSwitchable", this.IsVipSwitchable);
            this.SetParamSimple(map, prefix + "VipSwitchableTime", this.VipSwitchableTime);
            this.SetParamArrayObj(map, prefix + "ExchangeInstanceInfoList.", this.ExchangeInstanceInfoList);
            this.SetParamArrayObj(map, prefix + "ExchangeRoGroupInfoList.", this.ExchangeRoGroupInfoList);
            this.SetParamSimple(map, prefix + "CurrentStep", this.CurrentStep);
            this.SetParamSimple(map, prefix + "CurrentStepProgress", this.CurrentStepProgress);
            this.SetParamSimple(map, prefix + "CurrentStepRemainingTime", this.CurrentStepRemainingTime);
        }
    }
}

