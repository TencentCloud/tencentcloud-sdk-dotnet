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

    public class AlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// 关联任务id
        /// </summary>
        [JsonProperty("TaskIds")]
        public string TaskIds{ get; set; }

        /// <summary>
        /// 告警类别；failure表示失败告警；overtime表示超时告警
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// 告警方式；SMS表示短信；Email表示邮件；HTTP 表示接口方式；Wechat表示微信方式
        /// </summary>
        [JsonProperty("AlarmWay")]
        public string AlarmWay{ get; set; }

        /// <summary>
        /// 告警接收人，多个告警接收人以;分割
        /// </summary>
        [JsonProperty("AlarmRecipient")]
        public string AlarmRecipient{ get; set; }

        /// <summary>
        /// 告警接收人id，多个告警接收人id以;分割
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// 预计运行的小时，取值范围0-23
        /// </summary>
        [JsonProperty("Hours")]
        public ulong? Hours{ get; set; }

        /// <summary>
        /// 预计运行分钟，取值范围0-59
        /// </summary>
        [JsonProperty("Minutes")]
        public ulong? Minutes{ get; set; }

        /// <summary>
        /// 告警出发时机；1表示第一次运行失败；2表示所有重试完成后失败；
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// 告警信息id
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警状态设置；1表示可用；0表示不可用，默认可用
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskIds", this.TaskIds);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmWay", this.AlarmWay);
            this.SetParamSimple(map, prefix + "AlarmRecipient", this.AlarmRecipient);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "Hours", this.Hours);
            this.SetParamSimple(map, prefix + "Minutes", this.Minutes);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

