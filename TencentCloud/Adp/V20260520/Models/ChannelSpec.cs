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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>渠道名称</p>
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// <p>渠道类型，详见ChannelType枚举</p><p>枚举值：</p><ul><li>10000： 微信服务号(Wechat)</li><li>10002： 企微应用(WeComApp)</li><li>10004： 微信客服(WechatCustomerService)</li><li>10009： 企微智能机器人(WeComRobot)</li><li>10013： 钉钉机器人(DingTalk)</li><li>10014： 企微智能机器人WebSocket(WeComRobot)</li><li>10015： 微信ClawBot(WechatClawBot)</li><li>10011： LINE(Line)</li><li>10012： Telegram(Telegram)</li><li>10016： 飞书机器人(Lark) </li></ul><p>C端场景（Scene=1时）只支持10014和10015</p>
        /// </summary>
        [JsonProperty("ChannelType")]
        public long? ChannelType{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>钉钉机器人配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DingTalk")]
        public DingTalkChannelConfig DingTalk{ get; set; }

        /// <summary>
        /// <p>飞书机器人配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lark")]
        public LarkChannelConfig Lark{ get; set; }

        /// <summary>
        /// <p>LINE配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Line")]
        public LineChannelConfig Line{ get; set; }

        /// <summary>
        /// <p>渠道场景：0-B端场景，1-C端场景</p>
        /// </summary>
        [JsonProperty("Scene")]
        public long? Scene{ get; set; }

        /// <summary>
        /// <p>Telegram配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Telegram")]
        public TelegramChannelConfig Telegram{ get; set; }

        /// <summary>
        /// <p>归属用户+Agent运行态标识（C端）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAgent")]
        public UserAgentReference UserAgent{ get; set; }

        /// <summary>
        /// <p>微信公众号/小程序配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Wechat")]
        public WechatChannelConfig Wechat{ get; set; }

        /// <summary>
        /// <p>微信ClawBot配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatClawBot")]
        public WechatClawBotChannelConfig WechatClawBot{ get; set; }

        /// <summary>
        /// <p>微信客服配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatCustomerService")]
        public WechatCustomerServiceChannelConfig WechatCustomerService{ get; set; }

        /// <summary>
        /// <p>企微应用配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WecomApp")]
        public WecomAppChannelConfig WecomApp{ get; set; }

        /// <summary>
        /// <p>企微机器人配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WecomRobot")]
        public WecomRobotChannelConfig WecomRobot{ get; set; }

        /// <summary>
        /// <p>共享群聊会话</p><p>false不共享群聊会话; true共享群聊会话</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareGroupConversation")]
        public bool? ShareGroupConversation{ get; set; }

        /// <summary>
        /// <p>是否调试态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDebug")]
        public bool? IsDebug{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "DingTalk.", this.DingTalk);
            this.SetParamObj(map, prefix + "Lark.", this.Lark);
            this.SetParamObj(map, prefix + "Line.", this.Line);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamObj(map, prefix + "Telegram.", this.Telegram);
            this.SetParamObj(map, prefix + "UserAgent.", this.UserAgent);
            this.SetParamObj(map, prefix + "Wechat.", this.Wechat);
            this.SetParamObj(map, prefix + "WechatClawBot.", this.WechatClawBot);
            this.SetParamObj(map, prefix + "WechatCustomerService.", this.WechatCustomerService);
            this.SetParamObj(map, prefix + "WecomApp.", this.WecomApp);
            this.SetParamObj(map, prefix + "WecomRobot.", this.WecomRobot);
            this.SetParamSimple(map, prefix + "ShareGroupConversation", this.ShareGroupConversation);
            this.SetParamSimple(map, prefix + "IsDebug", this.IsDebug);
        }
    }
}

