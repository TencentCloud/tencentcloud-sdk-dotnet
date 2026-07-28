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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForwardRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>转交人打码后的姓名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>转交人打码后的手机号</p>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// <p>进行转交的原因</p><p>枚举值：</p><ul><li>QUIT_FORWARD： 离职转交</li><li>FORWARD： 员工操作转交</li></ul>
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// <p>转交的详情信息</p>
        /// </summary>
        [JsonProperty("ForwardMessage")]
        public string ForwardMessage{ get; set; }

        /// <summary>
        /// <p>转交时间</p><p>单位：时间戳（秒级）</p>
        /// </summary>
        [JsonProperty("ForwardTime")]
        public long? ForwardTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "ForwardMessage", this.ForwardMessage);
            this.SetParamSimple(map, prefix + "ForwardTime", this.ForwardTime);
        }
    }
}

