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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>策略 ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>启用状态<br>枚举值：<br>ON：启用<br>OFF：禁用</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>通知项列表（模块+子模块+等级+处置状态）</p>
        /// </summary>
        [JsonProperty("NotifyItems")]
        public WebhookNotifyItem[] NotifyItems{ get; set; }

        /// <summary>
        /// <p>接收的成员账号范围</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>通知资产范围</p>
        /// </summary>
        [JsonProperty("AssetScope")]
        public WebhookAssetScope AssetScope{ get; set; }

        /// <summary>
        /// <p>接收格式<br>枚举值：<br>TEXT：文本格式<br>JSON：JSON 格式</p>
        /// </summary>
        [JsonProperty("ReceiveFormat")]
        public string ReceiveFormat{ get; set; }

        /// <summary>
        /// <p>推送语言<br>枚举值：<br>zh：中文<br>en：英文</p>
        /// </summary>
        [JsonProperty("MsgLanguage")]
        public string MsgLanguage{ get; set; }

        /// <summary>
        /// <p>自定义透传字段列表，关闭时为空数组</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public WebhookCustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>接收机器人 ID 列表</p>
        /// </summary>
        [JsonProperty("ReceiverIDList")]
        public long?[] ReceiverIDList{ get; set; }

        /// <summary>
        /// <p>接收机器人精简信息（列表行展示用）</p>
        /// </summary>
        [JsonProperty("ReceiverList")]
        public WebhookReceiverBrief[] ReceiverList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "NotifyItems.", this.NotifyItems);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "AssetScope.", this.AssetScope);
            this.SetParamSimple(map, prefix + "ReceiveFormat", this.ReceiveFormat);
            this.SetParamSimple(map, prefix + "MsgLanguage", this.MsgLanguage);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArraySimple(map, prefix + "ReceiverIDList.", this.ReceiverIDList);
            this.SetParamArrayObj(map, prefix + "ReceiverList.", this.ReceiverList);
        }
    }
}

