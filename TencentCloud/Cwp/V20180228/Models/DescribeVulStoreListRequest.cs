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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulStoreListRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// <li>VulName- string - 是否必填：否 - 漏洞名称</li>
        /// <li>CveId- string - 是否必填：否 - cveid</li>
        /// <li>VulCategory- string - 是否必填：否 - 漏洞分类  1 Web-CMS漏洞 ,2 应用漏洞 ,4 Linux软件漏洞,5 Windows系统漏洞</li>
        /// <li>Method- string - 是否必填：否 - 检测方法 0版本对比,1 poc检测 </li>
        /// <li>SupportDefense- string - 是否必填：否 - 是否支持防御 0不支持,1支持</li>
        /// <li>FixSwitch- string - 是否必填：否 - 是否支持自动修复 0不支持,1支持</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 限制条数,默认10,最大100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量,默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序方式: [ASC:升序|DESC:降序]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 可选排序列: [PublishDate]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

