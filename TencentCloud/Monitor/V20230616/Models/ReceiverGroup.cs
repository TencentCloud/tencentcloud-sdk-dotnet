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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReceiverGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>本条发送规则的接收者类型</p><p>枚举值：</p><ul><li>UIDs： 按用户 UID</li><li>UINs： 按账号 UIN</li><li>Group： 按用户分组。ReceiverIds 为分组 ID</li><li>Oncall： 按值班表，且未被发送时的真实接收人覆盖</li><li>RtxName： 发送时解析出的员工 RTX 英文名</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// <p>本条规则配置的原始接收者 ID 列表。具体是哪一种 ID，由 ReceiverType 决定</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverIds")]
        public string[] ReceiverIds{ get; set; }

        /// <summary>
        /// <p>接收者展示名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// <p>用户分组展开后的成员用户 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberIds")]
        public string[] MemberIds{ get; set; }

        /// <summary>
        /// <p>该规则允许通知的星期。语义与 time.Weekday 一致</p><p>枚举值：</p><ul><li>0： 周日</li><li>1： 周一</li><li>2： 周二</li><li>3： 周三</li><li>4： 周四</li><li>5： 周五</li><li>6： 周六</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekDay")]
        public long?[] WeekDay{ get; set; }

        /// <summary>
        /// <p>通知时段相对当日零点的秒数偏移，需配合 TimeZoneName 解读</p><p>单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DayStartSeconds")]
        public long? DayStartSeconds{ get; set; }

        /// <summary>
        /// <p>通知时段相对当日零点的秒数偏移，需配合 TimeZoneName 解读</p><p>单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DayEndSeconds")]
        public long? DayEndSeconds{ get; set; }

        /// <summary>
        /// <p>DayStartSeconds、DayEndSeconds 所属时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeZoneName")]
        public string TimeZoneName{ get; set; }

        /// <summary>
        /// <p>该规则实际发送的接收渠道全名列表</p><p>枚举值：</p><ul><li>QCloudYehe_site： 腾讯云野鹤，站内信</li><li>QCloudYehe_email： 腾讯云野鹤，电子邮件</li><li>QCloudYehe_sms： 腾讯云野鹤，短信</li><li>QCloudYehe_wechat： 腾讯云野鹤，微信</li><li>QCloudYehe_voice： 腾讯云野鹤，语音</li><li>QCloudYehe_qywx： 腾讯云野鹤，企业微信</li><li>QCloudYehe_andon： 腾讯云野鹤，安灯</li><li>TOF_weWorkMessage： TOF，企业微信消息</li><li>TOF_email： TOF，企业邮箱</li><li>TOF_phoneCall： TOF，电话</li><li>WeWork： 企业微信机器人</li><li>WebHook： 自定义 WebHook</li><li>FeiShu： 飞书</li><li>DingDing： 钉钉</li><li>Slack： Slack</li><li>GoogleChat： Google Chat</li><li>Teams： Teams</li><li>TeamsWorkflow： Teams Workflow</li><li>PagerDuty： PagerDuty</li><li>CLS： 日志服务 CLS</li><li>AS： 弹性伸缩</li><li>TCSYehe： TCS 野鹤。正文的 SubChannel 取渠道名本身</li><li>SCF： 云函数。不返回 Contents</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelNames")]
        public string[] ChannelNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "ReceiverIds.", this.ReceiverIds);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamArraySimple(map, prefix + "MemberIds.", this.MemberIds);
            this.SetParamArraySimple(map, prefix + "WeekDay.", this.WeekDay);
            this.SetParamSimple(map, prefix + "DayStartSeconds", this.DayStartSeconds);
            this.SetParamSimple(map, prefix + "DayEndSeconds", this.DayEndSeconds);
            this.SetParamSimple(map, prefix + "TimeZoneName", this.TimeZoneName);
            this.SetParamArraySimple(map, prefix + "ChannelNames.", this.ChannelNames);
        }
    }
}

