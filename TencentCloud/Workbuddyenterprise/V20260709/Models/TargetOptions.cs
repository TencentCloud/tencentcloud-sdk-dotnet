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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetOptions : AbstractModel
    {
        
        /// <summary>
        /// <p>渠道类型（BOT_CHANNEL 必填）：FEISHU / DINGTALK / QQ / WECOM_NEW / WECOM_AIBOT / WECHAT_KF</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelType")]
        public string ChannelType{ get; set; }

        /// <summary>
        /// <p>渠道标识（BOT_CHANNEL 必填）：飞书 appId / 钉钉 appKey / QQ appId / 企微 corpId:agentId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// <p>回调 URL（WEBHOOK 必填）：仅允许 http/https，禁止内网地址（SSRF 防护）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>自定义请求头列表，与默认 Content-Type: application/json 合并</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }

        /// <summary>
        /// <p>HMAC-SHA256 签名密钥（WEBHOOK 可选）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Secret")]
        public string Secret{ get; set; }

        /// <summary>
        /// <p>接收目标 ID 集合（群 ID / 用户 ID / 频道 ID），BOT_CHANNEL 模式必填，至少一个</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecipientIdSet")]
        public string[] RecipientIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "Secret", this.Secret);
            this.SetParamArraySimple(map, prefix + "RecipientIdSet.", this.RecipientIdSet);
        }
    }
}

