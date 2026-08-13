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
        /// <p>通知渠道组ID。-通过<a href="https://cloud.tencent.com/document/api/614/56462">获取通知渠道组列表</a>获取通知渠道组ID</p>
        /// </summary>
        [JsonProperty("AlarmNoticeId")]
        public string AlarmNoticeId{ get; set; }

        /// <summary>
        /// <p>标签描述列表，通过指定该参数可以同时绑定标签到相应的通知渠道组。最大支持10个标签键值对，并且不能有重复的键值对。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>通知渠道组名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>通知类型。可选值：</p><li> Trigger - 告警触发</li><li> Recovery - 告警恢复</li><li> All - 告警触发和告警恢复</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>通知接收对象。</p>
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// <p>接口回调信息（包括企业微信等）。</p>
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// <p>通知规则。</p><p>注意: </p><ul><li>Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，2组配置互斥。</li><li>传其中一组数据，则另一组数据置空。</li></ul>
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }

        /// <summary>
        /// <p>调用链接域名。http:// 或者 https:// 开头，不能/结尾</p>
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// <p>投递日志开关。</p><p>参数值：<br>1：关闭；</p><p>2：开启</p>
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public ulong? DeliverStatus{ get; set; }

        /// <summary>
        /// <p>投递日志配置。</p>
        /// </summary>
        [JsonProperty("DeliverConfig")]
        public DeliverConfig DeliverConfig{ get; set; }

        /// <summary>
        /// <p>免登录操作告警开关。</p><p>参数值：<br>        1：关闭<br>        2：开启（默认开启）</p>
        /// </summary>
        [JsonProperty("AlarmShieldStatus")]
        public ulong? AlarmShieldStatus{ get; set; }

        /// <summary>
        /// <p>告警详情安全认证跳转开关，未传时默认&quot;关闭&quot;</p><p>枚举值：</p><ul><li>1： 关闭（默认值）</li><li>2： 开启</li></ul>
        /// </summary>
        [JsonProperty("SecureDetailStatus")]
        public ulong? SecureDetailStatus{ get; set; }

        /// <summary>
        /// <p>统一设定自定义回调参数。</p><ul><li>true: 使用通知内容模板中的自定义回调参数覆盖告警策略中单独配置的请求头及请求内容。</li><li>false:优先使用告警策略中单独配置的请求头及请求内容。</li></ul>
        /// </summary>
        [JsonProperty("CallbackPrioritize")]
        public bool? CallbackPrioritize{ get; set; }


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
            this.SetParamSimple(map, prefix + "SecureDetailStatus", this.SecureDetailStatus);
            this.SetParamSimple(map, prefix + "CallbackPrioritize", this.CallbackPrioritize);
        }
    }
}

