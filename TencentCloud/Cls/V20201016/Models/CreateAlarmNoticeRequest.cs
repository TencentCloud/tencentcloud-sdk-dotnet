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

    public class CreateAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// 通知渠道组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的通知渠道组。最大支持50个标签键值对，并且不能有重复的键值对。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 【简易模式】（简易模式/告警模式二选一，分别配置相应参数）
        /// 需要发送通知的告警类型。可选值：
        /// - Trigger - 告警触发
        /// - Recovery - 告警恢复
        /// - All - 告警触发和告警恢复
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 【简易模式】（简易模式/告警模式二选一，分别配置相应参数）
        /// 通知接收对象。
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// 【简易模式】（简易模式/告警模式二选一，分别配置相应参数）
        /// 接口回调信息（包括企业微信、钉钉、飞书）。
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// 【高级模式】（简易模式/告警模式二选一，分别配置相应参数）
        /// 通知规则。
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// 查询数据链接。http:// 或者 https:// 开头，不能/结尾
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// 投递日志开关。可取值如下：
        /// 1：关闭（默认值）；
        /// 2：开启 
        /// 投递日志开关开启时， DeliverConfig参数必填。
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// 投递日志配置参数。当DeliverStatus开启时，必填。
        /// </summary>
        [JsonProperty("DeliverConfig")]
        public DeliverConfig DeliverConfig{ get; set; }

        /// <summary>
        /// 免登录操作告警开关。可取值如下：
        /// -      1：关闭
        /// -      2：开启（默认值）
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamObj(map, prefix + "DeliverConfig.", this.DeliverConfig);
            this.SetParamSimple(map, prefix + "AlarmShieldStatus", this.AlarmShieldStatus);
        }
    }
}

