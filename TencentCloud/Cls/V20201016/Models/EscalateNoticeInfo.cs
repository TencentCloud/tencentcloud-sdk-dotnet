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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EscalateNoticeInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警通知模板接收者信息。
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// 告警通知模板回调信息。
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// 告警升级开关。`true`：开启告警升级、`false`：关闭告警升级，默认：false
        /// </summary>
        [JsonProperty("Escalate")]
        public bool? Escalate{ get; set; }

        /// <summary>
        /// 告警升级间隔。单位：分钟，范围`[1，14400]`
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 升级条件。`1`：无人认领且未恢复、`2`：未恢复，默认为1
        /// - 无人认领且未恢复：告警没有恢复并且没有人认领则升级
        /// - 未恢复：当前告警持续未恢复则升级
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 告警升级后下一个环节的通知渠道配置，最多可配置5个环节。
        /// </summary>
        [JsonProperty("EscalateNotice")]
        public EscalateNoticeInfo EscalateNotice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamSimple(map, prefix + "Escalate", this.Escalate);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "EscalateNotice.", this.EscalateNotice);
        }
    }
}

