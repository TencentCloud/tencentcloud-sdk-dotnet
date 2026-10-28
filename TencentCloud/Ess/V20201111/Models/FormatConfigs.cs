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

    public class FormatConfigs : AbstractModel
    {
        
        /// <summary>
        /// <p>合同对比结果过滤项</p><p>枚举值：</p><ul><li>1： 标点符号</li><li>2： 页眉页脚（包含页码）</li><li>3： 目录</li><li>4： 印章</li><li>5： 序号</li><li>6： 水印</li><li>7： 下划线</li></ul>
        /// </summary>
        [JsonProperty("Values")]
        public long?[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

