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

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>过滤条件名称。</p><p>枚举值：</p><ul><li>Timestamp： 创建时间（格式：2006-01-02 15:04:05.000）</li><li>UserName： 用户名</li><li>CacheCode： 缓存代码，后端redis节点</li><li>ClientAddr： 客户端地址</li><li>CommandDetail： 命令详情</li><li>CommandLatency： 命令延迟（毫秒）</li><li>CommandType： 命令类型</li><li>DBId： 数据库ID</li><li>ErrMsg： 错误信息</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>过滤条件匹配类型。</p><p>枚举值：</p><ul><li>INC： 包含，多个值之前是||的关系</li><li>EXC： 不包含，多个值之前是||的关系</li><li>EQS： 等于，多个值之前是||的关系</li><li>NEQ： 不等于，多个值之前是&amp;&amp;的关系</li><li>RA： 范围</li></ul>
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// <p>过滤条件匹配值。当Compare=RA时，例如：[&quot;1-100&quot;,&quot;200-300&quot;]。</p>
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

