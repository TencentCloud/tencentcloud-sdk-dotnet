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

    public class DescribeReplicationGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页输出实例列表的大小，参数默认值20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，取Limit整数倍。计算公式：offset=limit*(页码-1)。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 指定复制组 ID。例如：crs-rpl-m3zt****。请登录[Redis 控制台](https://console.cloud.tencent.com/redis/replication)的全球复制组列表获取复制组 ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 模糊查询的关键字，可以设置为复制组ID或复制组名称进行模糊查询。请登录[Redis 控制台](https://console.cloud.tencent.com/redis/replication)的全球复制组列表获取复制组 ID及名称。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

