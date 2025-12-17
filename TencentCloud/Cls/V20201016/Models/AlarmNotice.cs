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

    public class AlarmNotice : AbstractModel
    {
        
        /// <summary>
        /// 告警通知渠道组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 告警通知渠道组绑定的标签信息。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 告警模板的类型。可选值：
        /// <br><li> Trigger - 告警触发</li>
        /// <br><li> Recovery - 告警恢复</li>
        /// <br><li> All - 告警触发和告警恢复</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

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
        /// 告警通知模板ID。
        /// </summary>
        [JsonProperty("AlarmNoticeId")]
        public string AlarmNoticeId{ get; set; }

        /// <summary>
        /// 通知规则。
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// 免登录操作告警开关。
        /// 参数值： 1：关闭 2：开启（默认开启）
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }

        /// <summary>
        /// 调用链接域名。http:// 或者 https:// 开头，不能/结尾
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// 投递相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmNoticeDeliverConfig")]
        public AlarmNoticeDeliverConfig AlarmNoticeDeliverConfig{ get; set; }

        /// <summary>
        /// 创建时间。格式： YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近更新时间。格式： YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 投递日志开关。
        /// 
        /// 参数值：
        /// 
        /// 1：关闭
        /// 
        /// 2：开启 
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// 投递日志标识。
        /// 
        /// 参数值：
        /// 
        /// 1：未启用
        /// 
        /// 2：已启用
        /// 
        /// 3：投递异常
        /// </summary>
        [JsonProperty("DeliverFlag")]
        public ulong? DeliverFlag{ get; set; }

        /// <summary>
        /// 通知渠道组配置的告警屏蔽统计状态数量信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmShieldCount")]
        public AlarmShieldCount AlarmShieldCount{ get; set; }

        /// <summary>
        /// 统一设定自定义回调参数。
        /// -  true: 使用通知内容模板中的自定义回调参数覆盖告警策略中单独配置的请求头及请求内容。
        /// -  false:优先使用告警策略中单独配置的请求头及请求内容。
        /// </summary>
        [JsonProperty("CallbackPrioritize")]
        public bool? CallbackPrioritize{ get; set; }


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
            this.SetParamSimple(map, prefix + "AlarmNoticeId", this.AlarmNoticeId);
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
            this.SetParamSimple(map, prefix + "AlarmShieldStatus", this.AlarmShieldStatus);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamObj(map, prefix + "AlarmNoticeDeliverConfig.", this.AlarmNoticeDeliverConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamSimple(map, prefix + "DeliverFlag", this.DeliverFlag);
            this.SetParamObj(map, prefix + "AlarmShieldCount.", this.AlarmShieldCount);
            this.SetParamSimple(map, prefix + "CallbackPrioritize", this.CallbackPrioritize);
        }
    }
}

