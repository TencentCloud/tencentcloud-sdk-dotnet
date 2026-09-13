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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmGroup : AbstractModel
    {
        
        /// <summary>
        /// 通知渠道ID，可通过基础平台通知渠道相关接口获取
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 通知渠道名称，可以是用户组名称或邮箱地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 是否启用邮件渠道，默认值：false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEmailChannel")]
        public bool? IsEmailChannel{ get; set; }

        /// <summary>
        /// 一组告警条件，有 启动，成功，失败和任务超时告警
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmConditions")]
        public string[] AlarmConditions{ get; set; }

        /// <summary>
        /// 通知渠道类型。取值：0 未指定，1 Email，2 Webhook，3 Teams，4 Slack
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelType")]
        public long? ChannelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "IsEmailChannel", this.IsEmailChannel);
            this.SetParamArraySimple(map, prefix + "AlarmConditions.", this.AlarmConditions);
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
        }
    }
}

