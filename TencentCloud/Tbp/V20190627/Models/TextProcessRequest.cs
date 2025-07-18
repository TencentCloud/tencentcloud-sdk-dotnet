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

namespace TencentCloud.Tbp.V20190627.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextProcessRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器人标识，用于定义抽象机器人。
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 机器人版本，取值"dev"或"release"，{调试版本：dev；线上版本：release}。
        /// </summary>
        [JsonProperty("BotEnv")]
        public string BotEnv{ get; set; }

        /// <summary>
        /// 终端标识，每个终端(或线程)对应一个，区分并发多用户。
        /// </summary>
        [JsonProperty("TerminalId")]
        public string TerminalId{ get; set; }

        /// <summary>
        /// 请求的文本。
        /// </summary>
        [JsonProperty("InputText")]
        public string InputText{ get; set; }

        /// <summary>
        /// 透传字段，透传给用户自定义的WebService服务。
        /// </summary>
        [JsonProperty("SessionAttributes")]
        public string SessionAttributes{ get; set; }

        /// <summary>
        /// 平台类型，{小程序：MiniProgram；小微：XiaoWei；公众号：OfficialAccount；企业微信: WXWork}。
        /// </summary>
        [JsonProperty("PlatformType")]
        public string PlatformType{ get; set; }

        /// <summary>
        /// 当PlatformType为微信公众号或企业微信时，传递对应微信公众号或企业微信的唯一标识
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "BotEnv", this.BotEnv);
            this.SetParamSimple(map, prefix + "TerminalId", this.TerminalId);
            this.SetParamSimple(map, prefix + "InputText", this.InputText);
            this.SetParamSimple(map, prefix + "SessionAttributes", this.SessionAttributes);
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
        }
    }
}

