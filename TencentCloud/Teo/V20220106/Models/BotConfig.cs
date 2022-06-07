/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotConfig : AbstractModel
    {
        
        /// <summary>
        /// bot开关
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 预置规则
        /// </summary>
        [JsonProperty("ManagedRule")]
        public BotManagedRule ManagedRule{ get; set; }

        /// <summary>
        /// 保留
        /// </summary>
        [JsonProperty("UaBotRule")]
        public BotManagedRule UaBotRule{ get; set; }

        /// <summary>
        /// 保留
        /// </summary>
        [JsonProperty("IspBotRule")]
        public BotManagedRule IspBotRule{ get; set; }

        /// <summary>
        /// 用户画像规则
        /// </summary>
        [JsonProperty("PortraitRule")]
        public BotPortraitRule PortraitRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "ManagedRule.", this.ManagedRule);
            this.SetParamObj(map, prefix + "UaBotRule.", this.UaBotRule);
            this.SetParamObj(map, prefix + "IspBotRule.", this.IspBotRule);
            this.SetParamObj(map, prefix + "PortraitRule.", this.PortraitRule);
        }
    }
}

