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

    public class CreateConditionsTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定值，monitor
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 视图名
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// 组名
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 是否为与关系
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [JsonProperty("ParentGroupID")]
        public long? ParentGroupID{ get; set; }

        /// <summary>
        /// 是否屏蔽
        /// </summary>
        [JsonProperty("IsShielded")]
        public long? IsShielded{ get; set; }

        /// <summary>
        /// 复合告警表达式
        /// </summary>
        [JsonProperty("ComplexExpression")]
        public string ComplexExpression{ get; set; }

        /// <summary>
        /// 指标告警条件
        /// </summary>
        [JsonProperty("Conditions")]
        public ModifyConditionsTemplateRequestCondition[] Conditions{ get; set; }

        /// <summary>
        /// 事件告警条件
        /// </summary>
        [JsonProperty("EventConditions")]
        public ModifyConditionsTemplateRequestEventCondition[] EventConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ParentGroupID", this.ParentGroupID);
            this.SetParamSimple(map, prefix + "IsShielded", this.IsShielded);
            this.SetParamSimple(map, prefix + "ComplexExpression", this.ComplexExpression);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "EventConditions.", this.EventConditions);
        }
    }
}

