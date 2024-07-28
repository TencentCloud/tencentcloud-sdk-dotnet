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

    public class ActionLibraryListResult : AbstractModel
    {
        
        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// 动作描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 动作类型。范围：["平台","自定义"]
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 动作风险描述
        /// </summary>
        [JsonProperty("RiskDesc")]
        public string RiskDesc{ get; set; }

        /// <summary>
        /// 动作ID
        /// </summary>
        [JsonProperty("ActionId")]
        public ulong? ActionId{ get; set; }

        /// <summary>
        /// 动作属性（ 1：故障  2：恢复）
        /// </summary>
        [JsonProperty("AttributeId")]
        public ulong? AttributeId{ get; set; }

        /// <summary>
        /// 关联的动作ID
        /// </summary>
        [JsonProperty("RelationActionId")]
        public ulong? RelationActionId{ get; set; }

        /// <summary>
        /// 操作命令
        /// </summary>
        [JsonProperty("ActionCommand")]
        public string ActionCommand{ get; set; }

        /// <summary>
        /// 动作类型( 0 -- tat   1 -- 云API）
        /// </summary>
        [JsonProperty("ActionCommandType")]
        public ulong? ActionCommandType{ get; set; }

        /// <summary>
        /// 自定义动作的参数，json string
        /// </summary>
        [JsonProperty("ActionContent")]
        public string ActionContent{ get; set; }

        /// <summary>
        /// 二级分类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 动作描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionDetail")]
        public string ActionDetail{ get; set; }

        /// <summary>
        /// 是否允许当前账号使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAllowed")]
        public bool? IsAllowed{ get; set; }

        /// <summary>
        /// 最佳实践案例的链接地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionBestCase")]
        public string ActionBestCase{ get; set; }

        /// <summary>
        /// 对象类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 监控指标ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricIdList")]
        public ulong?[] MetricIdList{ get; set; }

        /// <summary>
        /// 是否是新动作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNewAction")]
        public bool? IsNewAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RiskDesc", this.RiskDesc);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "AttributeId", this.AttributeId);
            this.SetParamSimple(map, prefix + "RelationActionId", this.RelationActionId);
            this.SetParamSimple(map, prefix + "ActionCommand", this.ActionCommand);
            this.SetParamSimple(map, prefix + "ActionCommandType", this.ActionCommandType);
            this.SetParamSimple(map, prefix + "ActionContent", this.ActionContent);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ActionDetail", this.ActionDetail);
            this.SetParamSimple(map, prefix + "IsAllowed", this.IsAllowed);
            this.SetParamSimple(map, prefix + "ActionBestCase", this.ActionBestCase);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamArraySimple(map, prefix + "MetricIdList.", this.MetricIdList);
            this.SetParamSimple(map, prefix + "IsNewAction", this.IsNewAction);
        }
    }
}

