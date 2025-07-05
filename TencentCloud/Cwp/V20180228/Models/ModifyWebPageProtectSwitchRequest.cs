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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebPageProtectSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// 开关类型 1 防护开关  2 自动恢复开关 3 移除防护目录
        /// </summary>
        [JsonProperty("SwitchType")]
        public ulong? SwitchType{ get; set; }

        /// <summary>
        /// 需要操作开关的网站 最大100条
        /// </summary>
        [JsonProperty("Ids")]
        public string[] Ids{ get; set; }

        /// <summary>
        /// 1 开启 0 关闭 SwitchType 为 1 | 2 必填;
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SwitchType", this.SwitchType);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

