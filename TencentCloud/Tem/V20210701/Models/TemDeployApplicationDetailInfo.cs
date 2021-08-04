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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemDeployApplicationDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 分批发布策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployStrategyConf")]
        public DeployStrategyConf DeployStrategyConf{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 当前状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// beta分批详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BetaBatchDetail")]
        public DeployServiceBatchDetail BetaBatchDetail{ get; set; }

        /// <summary>
        /// 其他分批详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherBatchDetail")]
        public DeployServiceBatchDetail[] OtherBatchDetail{ get; set; }

        /// <summary>
        /// 老版本pod列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldVersionPodList")]
        public DescribeRunPodPage OldVersionPodList{ get; set; }

        /// <summary>
        /// 当前批次id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentBatchIndex")]
        public long? CurrentBatchIndex{ get; set; }

        /// <summary>
        /// 错误原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 当前批次状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentBatchStatus")]
        public string CurrentBatchStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DeployStrategyConf.", this.DeployStrategyConf);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "BetaBatchDetail.", this.BetaBatchDetail);
            this.SetParamArrayObj(map, prefix + "OtherBatchDetail.", this.OtherBatchDetail);
            this.SetParamObj(map, prefix + "OldVersionPodList.", this.OldVersionPodList);
            this.SetParamSimple(map, prefix + "CurrentBatchIndex", this.CurrentBatchIndex);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "CurrentBatchStatus", this.CurrentBatchStatus);
        }
    }
}

