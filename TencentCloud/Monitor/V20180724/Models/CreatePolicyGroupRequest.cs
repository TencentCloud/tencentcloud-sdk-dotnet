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

    public class CreatePolicyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 组策略名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 固定值，为"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 策略组所属视图的名称，若通过模版创建，可不传入
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// 策略组所属项目Id，会进行鉴权操作
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 模版策略组Id, 通过模版创建时才需要传
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public long? ConditionTempGroupId{ get; set; }

        /// <summary>
        /// 是否屏蔽策略组，0表示不屏蔽，1表示屏蔽。不填默认为0
        /// </summary>
        [JsonProperty("IsShielded")]
        public long? IsShielded{ get; set; }

        /// <summary>
        /// 策略组的备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 插入时间，戳格式为Unix时间戳，不填则按后台处理时间填充
        /// </summary>
        [JsonProperty("InsertTime")]
        public long? InsertTime{ get; set; }

        /// <summary>
        /// 策略组中的阈值告警规则
        /// </summary>
        [JsonProperty("Conditions")]
        public CreatePolicyGroupCondition[] Conditions{ get; set; }

        /// <summary>
        /// 策略组中的时间告警规则
        /// </summary>
        [JsonProperty("EventConditions")]
        public CreatePolicyGroupEventCondition[] EventConditions{ get; set; }

        /// <summary>
        /// 是否为后端调用。当且仅当值为1时，后台拉取策略模版中的规则填充入Conditions以及EventConditions字段
        /// </summary>
        [JsonProperty("BackEndCall")]
        public long? BackEndCall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ConditionTempGroupId", this.ConditionTempGroupId);
            this.SetParamSimple(map, prefix + "IsShielded", this.IsShielded);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "EventConditions.", this.EventConditions);
            this.SetParamSimple(map, prefix + "BackEndCall", this.BackEndCall);
        }
    }
}

