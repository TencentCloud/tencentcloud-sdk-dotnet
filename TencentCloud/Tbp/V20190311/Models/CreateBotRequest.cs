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

namespace TencentCloud.Tbp.V20190311.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBotRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器人名称
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 机器人中文名称
        /// </summary>
        [JsonProperty("BotCnName")]
        public string BotCnName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
            this.SetParamSimple(map, prefix + "BotCnName", this.BotCnName);
        }
    }
}

