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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>策略组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>策略组所属的项目id</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>是否为默认策略，0表示非默认策略，1表示默认策略</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// <p>策略说明</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>策略类型名称</p>
        /// </summary>
        [JsonProperty("ShowName")]
        public string ShowName{ get; set; }

        /// <summary>
        /// <p>最近编辑的用户uin</p>
        /// </summary>
        [JsonProperty("LastEditUin")]
        public string LastEditUin{ get; set; }

        /// <summary>
        /// <p>最近编辑时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>该策略支持的地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// <p>策略类型的维度列表</p>
        /// </summary>
        [JsonProperty("DimensionGroup")]
        public string[] DimensionGroup{ get; set; }

        /// <summary>
        /// <p>阈值规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionsConfig")]
        public DescribePolicyGroupInfoCondition[] ConditionsConfig{ get; set; }

        /// <summary>
        /// <p>产品事件规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventConfig")]
        public DescribePolicyGroupInfoEventCondition[] EventConfig{ get; set; }

        /// <summary>
        /// <p>用户接收人列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverInfos")]
        public DescribePolicyGroupInfoReceiverInfo[] ReceiverInfos{ get; set; }

        /// <summary>
        /// <p>用户回调信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Callback")]
        public DescribePolicyGroupInfoCallback Callback{ get; set; }

        /// <summary>
        /// <p>模板策略组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionsTemp")]
        public DescribePolicyGroupInfoConditionTpl ConditionsTemp{ get; set; }

        /// <summary>
        /// <p>是否可以设置成默认策略</p>
        /// </summary>
        [JsonProperty("CanSetDefault")]
        public bool? CanSetDefault{ get; set; }

        /// <summary>
        /// <p>是否且规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ShowName", this.ShowName);
            this.SetParamSimple(map, prefix + "LastEditUin", this.LastEditUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamArraySimple(map, prefix + "DimensionGroup.", this.DimensionGroup);
            this.SetParamArrayObj(map, prefix + "ConditionsConfig.", this.ConditionsConfig);
            this.SetParamArrayObj(map, prefix + "EventConfig.", this.EventConfig);
            this.SetParamArrayObj(map, prefix + "ReceiverInfos.", this.ReceiverInfos);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
            this.SetParamObj(map, prefix + "ConditionsTemp.", this.ConditionsTemp);
            this.SetParamSimple(map, prefix + "CanSetDefault", this.CanSetDefault);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

