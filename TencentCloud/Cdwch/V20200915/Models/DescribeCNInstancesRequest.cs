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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCNInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索的集群id名称
        /// </summary>
        [JsonProperty("SearchInstanceID")]
        public string SearchInstanceID{ get; set; }

        /// <summary>
        /// 搜索的集群name
        /// </summary>
        [JsonProperty("SearchInstanceName")]
        public string SearchInstanceName{ get; set; }

        /// <summary>
        /// 分页参数，第一页为0，第二页为10
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页参数，分页步长，默认为10
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 搜索标签列表
        /// </summary>
        [JsonProperty("SearchTags")]
        public SearchTags[] SearchTags{ get; set; }

        /// <summary>
        /// 集群类型，弹性版或自研数仓版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 组件名称列表
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchInstanceID", this.SearchInstanceID);
            this.SetParamSimple(map, prefix + "SearchInstanceName", this.SearchInstanceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "SearchTags.", this.SearchTags);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
        }
    }
}

