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

    public class ModifyAlarmPolicyConditionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模块名，固定值 monitor</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>告警策略 ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>触发条件模板 Id，可不传</p>
        /// </summary>
        [JsonProperty("ConditionTemplateId")]
        public long? ConditionTemplateId{ get; set; }

        /// <summary>
        /// <p>指标触发条件</p>
        /// </summary>
        [JsonProperty("Condition")]
        public AlarmPolicyCondition Condition{ get; set; }

        /// <summary>
        /// <p>事件触发条件</p>
        /// </summary>
        [JsonProperty("EventCondition")]
        public AlarmPolicyEventCondition EventCondition{ get; set; }

        /// <summary>
        /// <p>全局过滤条件</p>
        /// </summary>
        [JsonProperty("Filter")]
        public AlarmPolicyFilter Filter{ get; set; }

        /// <summary>
        /// <p>聚合维度列表，指定按哪些维度 key 来做 group by</p>
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// <p>日志告警创建请求参数信息</p>
        /// </summary>
        [JsonProperty("LogAlarmReqInfo")]
        public LogAlarmReq LogAlarmReqInfo{ get; set; }

        /// <summary>
        /// <p>模板id，专供prom使用</p>
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// <p>启停状态，0=停用，1=启用</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>专供prom策略名称</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>事件配置的告警</p>
        /// </summary>
        [JsonProperty("EbSubject")]
        public string EbSubject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "ConditionTemplateId", this.ConditionTemplateId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamObj(map, prefix + "EventCondition.", this.EventCondition);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamObj(map, prefix + "LogAlarmReqInfo.", this.LogAlarmReqInfo);
            this.SetParamArraySimple(map, prefix + "NoticeIds.", this.NoticeIds);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "EbSubject", this.EbSubject);
        }
    }
}

