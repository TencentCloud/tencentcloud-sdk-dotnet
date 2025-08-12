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

    public class DashboardNoticeMode : AbstractModel
    {
        
        /// <summary>
        /// 仪表盘通知方式。<br>
        /// <li/>Uin：腾讯云用户<br>
        /// <li/>Group：腾讯云用户组<br>
        /// <li/>Email：自定义Email<br>
        /// <li/>WeCom: 企业微信回调<br>
        /// <li/>DingTalk：钉钉<br>
        /// <li/>Lark：飞书
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// 知方式对应的值。
        /// <br> <li/> 当ReceiverType不是 WeCom 时，Values必填。
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 仪表盘通知渠道。
        /// <br><li/> 支持：["Email","Sms","WeChat","Phone"]。
        /// <br><li/> 当ReceiverType是 Email 或 WeCom 时，ReceiverChannels不能赋值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverChannels")]
        public string[] ReceiverChannels{ get; set; }

        /// <summary>
        /// 回调Url。
        /// <br><li/> 当ReceiverType是 WeCom 时，Url必填。
        /// <br><li/> 当ReceiverType不是 WeCom 时，Url不能填写。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "ReceiverChannels.", this.ReceiverChannels);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

