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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTagKeysRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>创建者用户 Uin，不传或为空只将 Uin 作为条件查询</p>
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// <p>数据偏移量，默认为 0, 必须为Limit参数的整数倍</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>每页大小，默认为 15，最大1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>是否展现项目标签。1:展示 0:不展示。本功能仅供历史客户使用，需提交工单加白主账号后，入参方可有效。</p>
        /// </summary>
        [JsonProperty("ShowProject")]
        public ulong? ShowProject{ get; set; }

        /// <summary>
        /// <p>标签类型。取值： Custom：自定义标签。 System：系统标签。 All：全部标签。 默认值：All。</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ShowProject", this.ShowProject);
            this.SetParamSimple(map, prefix + "Category", this.Category);
        }
    }
}

