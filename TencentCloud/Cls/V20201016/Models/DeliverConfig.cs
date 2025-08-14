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

    public class DeliverConfig : AbstractModel
    {
        
        /// <summary>
        /// 地域信息。
        /// 
        /// 示例：
        ///  ap-guangzhou  广州地域；
        /// ap-nanjing 南京地域。
        /// 
        /// 详细信息请查看官网：
        /// 
        /// https://cloud.tencent.com/document/product/614/18940
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 日志主题ID。-通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 投递数据范围。
        /// 
        /// 0: 全部日志, 包括告警策略日常周期执行的所有日志，也包括告警策略变更产生的日志，默认值
        /// 
        /// 1:仅告警触发及恢复日志
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

