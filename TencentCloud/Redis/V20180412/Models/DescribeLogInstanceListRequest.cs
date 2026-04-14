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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志类型。</p><p>枚举值：</p><ul><li>auditLog： 审计日志。</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>每页输出的任务列表大小。</p><ul><li>取值范围：[1,100]。</li><li>默认值：20。</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移量。默认为0。取值为 Limit 整数倍。计算公式：offset=limit*(页码-1)。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>设置日志筛选字段，过滤并返回符合条件的日志。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>日志子类型。</p><p>枚举值：</p><ul><li>write： 写日志。</li><li>read： 读日志。</li><li>all： 读写日志。</li></ul>
        /// </summary>
        [JsonProperty("LogSubType")]
        public string LogSubType{ get; set; }

        /// <summary>
        /// <p>日志开关。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul><p>默认值：off</p>
        /// </summary>
        [JsonProperty("LogSwitch")]
        public string LogSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "LogSubType", this.LogSubType);
            this.SetParamSimple(map, prefix + "LogSwitch", this.LogSwitch);
        }
    }
}

