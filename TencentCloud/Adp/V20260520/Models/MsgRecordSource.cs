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

    public class MsgRecordSource : AbstractModel
    {
        
        /// <summary>
        /// 对话消息的接入渠道类型：0=未指定, 1=坐席, 2=体验页面(腾讯云), 3=评测端对话, 4=体验页面(手机号), 5=对话端API接入, 6=评测任务对话, 10=工作流调试, 10000=微信公众号, 10001=微信服务号, 10002=企微应用, 10003=网页组件, 10004=微信客服, 10005=微信小程序, 10006=元器, 10007=应用宝, 10008=元宝, 10009=企微智能机器人, 10010=元器API, 10011=LINE, 10012=Telegram, 10100=电脑管家, 20001=荣耀智能体平台, 20002=小米应用商店；user_id（string）为该渠道下的访客唯一标识。
        /// </summary>
        [JsonProperty("ChannelType")]
        public ulong? ChannelType{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("FromId")]
        public string FromId{ get; set; }

        /// <summary>
        /// 消息发送者的用户来源类型：1=用户（访客/C端用户）, 2=机器人（AI回复）, 3=坐席（人工客服）；from_id（string）为该来源类型下的用户唯一标识 ID。
        /// </summary>
        [JsonProperty("FromType")]
        public ulong? FromType{ get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [JsonProperty("UserAvatar")]
        public string UserAvatar{ get; set; }

        /// <summary>
        /// 访客ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 访客名称
        /// </summary>
        [JsonProperty("UserNickname")]
        public string UserNickname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "FromId", this.FromId);
            this.SetParamSimple(map, prefix + "FromType", this.FromType);
            this.SetParamSimple(map, prefix + "UserAvatar", this.UserAvatar);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserNickname", this.UserNickname);
        }
    }
}

