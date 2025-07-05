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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLocalAccountsPage : AbstractModel
    {
        
        /// <summary>
        /// 公共分页对象
        /// </summary>
        [JsonProperty("Page")]
        public Paging Page{ get; set; }

        /// <summary>
        /// 获取账号列表响应的单个对象
        /// </summary>
        [JsonProperty("Items")]
        public DescribeLocalAccountsData[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Page.", this.Page);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

