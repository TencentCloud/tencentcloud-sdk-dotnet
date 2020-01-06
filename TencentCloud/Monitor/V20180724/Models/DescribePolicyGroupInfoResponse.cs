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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 策略组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 策略组所属的项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 是否为默认策略，0表示非默认策略，1表示默认策略
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// 策略说明
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 策略类型名称
        /// </summary>
        [JsonProperty("ShowName")]
        public string ShowName{ get; set; }

        /// <summary>
        /// 最近编辑的用户uin
        /// </summary>
        [JsonProperty("LastEditUin")]
        public string LastEditUin{ get; set; }

        /// <summary>
        /// 最近编辑时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 该策略支持的地域
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// 策略类型的维度列表
        /// </summary>
        [JsonProperty("DimensionGroup")]
        public string[] DimensionGroup{ get; set; }

        /// <summary>
        /// 阈值规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionsConfig")]
        public DescribePolicyGroupInfoCondition[] ConditionsConfig{ get; set; }

        /// <summary>
        /// 产品事件规则列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventConfig")]
        public DescribePolicyGroupInfoEventCondition[] EventConfig{ get; set; }

        /// <summary>
        /// 用户接收人列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverInfos")]
        public DescribePolicyGroupInfoReceiverInfo[] ReceiverInfos{ get; set; }

        /// <summary>
        /// 用户回调信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Callback")]
        public DescribePolicyGroupInfoCallback Callback{ get; set; }

        /// <summary>
        /// 模板策略组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionsTemp")]
        public DescribePolicyGroupInfoConditionTpl ConditionsTemp{ get; set; }

        /// <summary>
        /// 是否可以设置成默认策略
        /// </summary>
        [JsonProperty("CanSetDefault")]
        public bool? CanSetDefault{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

