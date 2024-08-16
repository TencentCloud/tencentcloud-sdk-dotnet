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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateGroupAction : AbstractModel
    {
        
        /// <summary>
        /// 经验库分组动作ID
        /// </summary>
        [JsonProperty("TemplateGroupActionId")]
        public long? TemplateGroupActionId{ get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        [JsonProperty("ActionId")]
        public long? ActionId{ get; set; }

        /// <summary>
        /// 分组动作顺序
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 分组动作通用配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GeneralConfiguration")]
        public string GeneralConfiguration{ get; set; }

        /// <summary>
        /// 分组动作自定义配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public string CustomConfiguration{ get; set; }

        /// <summary>
        /// 动作分组创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 动作分组更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("ActionTitle")]
        public string ActionTitle{ get; set; }

        /// <summary>
        /// 自身随机id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RandomId")]
        public long? RandomId{ get; set; }

        /// <summary>
        /// 恢复动作id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoverId")]
        public long? RecoverId{ get; set; }

        /// <summary>
        /// 执行动作id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteId")]
        public long? ExecuteId{ get; set; }

        /// <summary>
        /// 调用api类型，0:tat, 1:云api
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionApiType")]
        public long? ActionApiType{ get; set; }

        /// <summary>
        /// 1:故障，2:恢复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionAttribute")]
        public long? ActionAttribute{ get; set; }

        /// <summary>
        /// 动作类型：平台和自定义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 动作风险等级，1:低风险 2:中风险 3:高风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionRisk")]
        public string ActionRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateGroupActionId", this.TemplateGroupActionId);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "GeneralConfiguration", this.GeneralConfiguration);
            this.SetParamSimple(map, prefix + "CustomConfiguration", this.CustomConfiguration);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ActionTitle", this.ActionTitle);
            this.SetParamSimple(map, prefix + "RandomId", this.RandomId);
            this.SetParamSimple(map, prefix + "RecoverId", this.RecoverId);
            this.SetParamSimple(map, prefix + "ExecuteId", this.ExecuteId);
            this.SetParamSimple(map, prefix + "ActionApiType", this.ActionApiType);
            this.SetParamSimple(map, prefix + "ActionAttribute", this.ActionAttribute);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionRisk", this.ActionRisk);
        }
    }
}

