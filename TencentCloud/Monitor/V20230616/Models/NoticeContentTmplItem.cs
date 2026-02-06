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

    public class NoticeContentTmplItem : AbstractModel
    {
        
        /// <summary>
        /// 官网通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QCloudYehe")]
        public QCloudYeheNoticeTmplMatcher[] QCloudYehe{ get; set; }

        /// <summary>
        /// 企业微信机器人通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeWorkRobot")]
        public WeWorkRobotNoticeTmplMatcher[] WeWorkRobot{ get; set; }

        /// <summary>
        /// 钉钉机器人通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DingDingRobot")]
        public DingDingRobotNoticeTmplMatcher[] DingDingRobot{ get; set; }

        /// <summary>
        /// 飞书机器人通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeiShuRobot")]
        public FeiShuRobotNoticeTmplMatcher[] FeiShuRobot{ get; set; }

        /// <summary>
        /// 自定义Webhook通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Webhook")]
        public WebhookNoticeTmplMatcher[] Webhook{ get; set; }

        /// <summary>
        /// Teams机器人通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TeamsRobot")]
        public TeamsRobotNoticeTmplMatcher[] TeamsRobot{ get; set; }

        /// <summary>
        /// PagerDutyRobot机器人通知渠道配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PagerDutyRobot")]
        public PagerDutyRobotNoticeTmplMatcher[] PagerDutyRobot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "QCloudYehe.", this.QCloudYehe);
            this.SetParamArrayObj(map, prefix + "WeWorkRobot.", this.WeWorkRobot);
            this.SetParamArrayObj(map, prefix + "DingDingRobot.", this.DingDingRobot);
            this.SetParamArrayObj(map, prefix + "FeiShuRobot.", this.FeiShuRobot);
            this.SetParamArrayObj(map, prefix + "Webhook.", this.Webhook);
            this.SetParamArrayObj(map, prefix + "TeamsRobot.", this.TeamsRobot);
            this.SetParamArrayObj(map, prefix + "PagerDutyRobot.", this.PagerDutyRobot);
        }
    }
}

