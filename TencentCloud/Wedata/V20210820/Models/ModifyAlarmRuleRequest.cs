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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 规则名字
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 监控类型,1.task、2.workflow、3.project、4.baseline（默认为1.任务）
        /// </summary>
        [JsonProperty("MonitorType")]
        public long? MonitorType{ get; set; }

        /// <summary>
        /// 监控对象
        /// </summary>
        [JsonProperty("MonitorObjectIds")]
        public string[] MonitorObjectIds{ get; set; }

        /// <summary>
        /// 告警类型，1.失败告警、2.超时告警、3.成功告警、4.基线破线、5.基线预警、6.基线任务失败（默认1.失败告警）
        /// </summary>
        [JsonProperty("AlarmTypes")]
        public string[] AlarmTypes{ get; set; }

        /// <summary>
        /// 告警级别，1.普通、2.重要、3.紧急（默认1.普通）
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public long? AlarmLevel{ get; set; }

        /// <summary>
        /// 告警方式,1.邮件，2.短信，3.微信，4.语音，5.企业微信，6.Http，7.企业微信群；告警方式code列表（默认1.邮件）
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// 告警接收人类型：1.指定人员，2.任务责任人，3.值班表（默认1.指定人员）
        /// </summary>
        [JsonProperty("AlarmRecipientType")]
        public long? AlarmRecipientType{ get; set; }

        /// <summary>
        /// 告警接收人
        /// </summary>
        [JsonProperty("AlarmRecipients")]
        public string[] AlarmRecipients{ get; set; }

        /// <summary>
        /// 告警接收人ID
        /// </summary>
        [JsonProperty("AlarmRecipientIds")]
        public string[] AlarmRecipientIds{ get; set; }

        /// <summary>
        /// 扩展信息, 1.预计运行耗时（默认），2.预计完成时间，3.预计调度时间，4.周期内未完成；取值类型：1.指定指，2.历史均值（默认1.指定指）
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamArraySimple(map, prefix + "MonitorObjectIds.", this.MonitorObjectIds);
            this.SetParamArraySimple(map, prefix + "AlarmTypes.", this.AlarmTypes);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientType", this.AlarmRecipientType);
            this.SetParamArraySimple(map, prefix + "AlarmRecipients.", this.AlarmRecipients);
            this.SetParamArraySimple(map, prefix + "AlarmRecipientIds.", this.AlarmRecipientIds);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

