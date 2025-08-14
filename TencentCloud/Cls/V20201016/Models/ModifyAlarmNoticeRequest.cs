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

    public class ModifyAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// 通知渠道组ID。-通过[获取通知内容模板](https://cloud.tencent.com/document/api/614/111714)获取通知渠道组ID
        /// </summary>
        [JsonProperty("AlarmNoticeId")]
        public string AlarmNoticeId{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的通知渠道组。最大支持10个标签键值对，并且不能有重复的键值对。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 通知渠道组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 通知类型。可选值：
        /// <li> Trigger - 告警触发</li>
        /// <li> Recovery - 告警恢复</li>
        /// <li> All - 告警触发和告警恢复</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 通知接收对象。
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// 接口回调信息（包括企业微信等）。
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// 通知规则。
        /// 
        /// 注意: 
        /// 
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，2组配置互斥。
        /// - 传其中一组数据，则另一组数据置空。
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// 调用链接域名。http:// 或者 https:// 开头，不能/结尾
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// 投递日志开关。
        /// 
        /// 参数值：
        /// 1：关闭；
        /// 
        /// 2：开启 
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// 投递日志配置。
        /// </summary>
        [JsonProperty("DeliverConfig")]
        public DeliverConfig DeliverConfig{ get; set; }

        /// <summary>
        /// 免登录操作告警开关。
        /// 
        /// 参数值： 
        ///         1：关闭
        ///         2：开启（默认开启）
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmNoticeId", this.AlarmNoticeId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Name", this.Name);
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

