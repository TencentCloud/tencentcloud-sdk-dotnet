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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIpHitItemsRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 计数标识
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 有效时间最小时间戳
        /// </summary>
        [JsonProperty("VtsMin")]
        public ulong? VtsMin{ get; set; }

        /// <summary>
        /// 有效时间最大时间戳
        /// </summary>
        [JsonProperty("VtsMax")]
        public ulong? VtsMax{ get; set; }

        /// <summary>
        /// 创建时间最小时间戳
        /// </summary>
        [JsonProperty("CtsMin")]
        public ulong? CtsMin{ get; set; }

        /// <summary>
        /// 创建时间最大时间戳
        /// </summary>
        [JsonProperty("CtsMax")]
        public ulong? CtsMax{ get; set; }

        /// <summary>
        /// 偏移参数
        /// </summary>
        [JsonProperty("Skip")]
        public ulong? Skip{ get; set; }

        /// <summary>
        /// 限制数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "VtsMin", this.VtsMin);
            this.SetParamSimple(map, prefix + "VtsMax", this.VtsMax);
            this.SetParamSimple(map, prefix + "CtsMin", this.CtsMin);
            this.SetParamSimple(map, prefix + "CtsMax", this.CtsMax);
            this.SetParamSimple(map, prefix + "Skip", this.Skip);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
        }
    }
}

