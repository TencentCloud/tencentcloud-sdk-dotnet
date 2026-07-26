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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTrigger : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// <table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>APP_TRIGGER_TYPE_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>APP_TRIGGER_TYPE_SCHEDULED</td><td>1</td><td>定时触发</td></tr><tr><td>APP_TRIGGER_TYPE_WEBHOOK</td><td>2</td><td>Webhook 触发</td></tr></table>
        /// </summary>
        [JsonProperty("TriggerType")]
        public long? TriggerType{ get; set; }

        /// <summary>
        /// <table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_PROMPT</td><td>1</td><td>指令执行</td></tr><tr><td>APP_TRIGGER_EXECUTE_TYPE_WORKFLOW</td><td>2</td><td>工作流执行</td></tr></table>
        /// </summary>
        [JsonProperty("ExecuteType")]
        public long? ExecuteType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PushConfig")]
        public TimerPushConfig PushConfig{ get; set; }

        /// <summary>
        /// <table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>APP_TRIGGER_STATUS_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>APP_TRIGGER_STATUS_ENABLED</td><td>1</td><td>启用</td></tr><tr><td>APP_TRIGGER_STATUS_PAUSED</td><td>2</td><td>暂停</td></tr><tr><td>APP_TRIGGER_STATUS_DELETED</td><td>3</td><td>已删除</td></tr></table>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SuccessCount")]
        public string SuccessCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FailedCount")]
        public string FailedCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerConfig")]
        public TriggerConfig TriggerConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExecuteConfig")]
        public ExecuteConfig ExecuteConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerStatus")]
        public TriggerStatus TriggerStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamObj(map, prefix + "PushConfig.", this.PushConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamObj(map, prefix + "TriggerConfig.", this.TriggerConfig);
            this.SetParamObj(map, prefix + "ExecuteConfig.", this.ExecuteConfig);
            this.SetParamObj(map, prefix + "TriggerStatus.", this.TriggerStatus);
        }
    }
}

