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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Strategy : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 策略名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 地址来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public Source[] Source{ get; set; }

        /// <summary>
        /// 策略id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// 健康状态：ok健康、warn风险、down故障
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 生效的主力池id，null则为未知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivateMainPoolId")]
        public long? ActivateMainPoolId{ get; set; }

        /// <summary>
        /// 当前生效地址池所在级数，为0则代表兜底生效，null则为未知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivateLevel")]
        public long? ActivateLevel{ get; set; }

        /// <summary>
        /// 当前生效地址池集合类型：main主力；fallback兜底
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivePoolType")]
        public string ActivePoolType{ get; set; }

        /// <summary>
        /// 当前生效地址池流量策略：all解析所有；weight负载均衡
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveTrafficStrategy")]
        public string ActiveTrafficStrategy{ get; set; }

        /// <summary>
        /// 监控器数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorNum")]
        public ulong? MonitorNum{ get; set; }

        /// <summary>
        /// 是否开启：ENABLED开启；DISABLED关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEnabled")]
        public string IsEnabled{ get; set; }

        /// <summary>
        /// 是否保留线路：enabled保留，disabled不保留，只保留默认线路
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeepDomainRecords")]
        public string KeepDomainRecords{ get; set; }

        /// <summary>
        /// 调度模式：AUTO默认；PAUSE仅暂停不切换
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SwitchPoolType")]
        public string SwitchPoolType{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Source.", this.Source);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ActivateMainPoolId", this.ActivateMainPoolId);
            this.SetParamSimple(map, prefix + "ActivateLevel", this.ActivateLevel);
            this.SetParamSimple(map, prefix + "ActivePoolType", this.ActivePoolType);
            this.SetParamSimple(map, prefix + "ActiveTrafficStrategy", this.ActiveTrafficStrategy);
            this.SetParamSimple(map, prefix + "MonitorNum", this.MonitorNum);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "KeepDomainRecords", this.KeepDomainRecords);
            this.SetParamSimple(map, prefix + "SwitchPoolType", this.SwitchPoolType);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
        }
    }
}

