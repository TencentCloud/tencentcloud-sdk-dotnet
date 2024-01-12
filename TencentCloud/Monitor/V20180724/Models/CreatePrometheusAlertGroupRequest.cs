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

    public class CreatePrometheusAlertGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// prometheus实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 告警分组名称，不能与其他告警分组重名
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 告警分组状态：
        /// 2 -- 启用
        /// 3 -- 禁用
        /// 不为空时会覆盖 `Rules`字段下所有告警规则状态
        /// </summary>
        [JsonProperty("GroupState")]
        public long? GroupState{ get; set; }

        /// <summary>
        /// 云监控告警通知模板ID列表，形如Consumer-xxxx或notice-xxxx
        /// </summary>
        [JsonProperty("AMPReceivers")]
        public string[] AMPReceivers{ get; set; }

        /// <summary>
        /// 自定义告警通知模板
        /// </summary>
        [JsonProperty("CustomReceiver")]
        public PrometheusAlertCustomReceiver CustomReceiver{ get; set; }

        /// <summary>
        /// 告警通知周期（收敛时间），为空默认1h
        /// </summary>
        [JsonProperty("RepeatInterval")]
        public string RepeatInterval{ get; set; }

        /// <summary>
        /// 要创建的告警规则列表
        /// </summary>
        [JsonProperty("Rules")]
        public PrometheusAlertGroupRuleSet[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupState", this.GroupState);
            this.SetParamArraySimple(map, prefix + "AMPReceivers.", this.AMPReceivers);
            this.SetParamObj(map, prefix + "CustomReceiver.", this.CustomReceiver);
            this.SetParamSimple(map, prefix + "RepeatInterval", this.RepeatInterval);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

