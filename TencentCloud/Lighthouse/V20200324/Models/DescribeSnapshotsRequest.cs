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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSnapshotsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询快照的 ID 列表。每次请求批量快照的上限为 100。 
        /// 可通过 [DescribeSnapshots](https://cloud.tencent.com/document/product/1207/54388) 接口返回值中的 SnapshotId		获取。
        /// 参数不支持同时指定 SnapshotIds 和 Filters。
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// 过滤器列表。
        /// <li>snapshot-id</li>按照【快照 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 可通过 <a href="https://cloud.tencent.com/document/product/1207/54388">DescribeSnapshots</a> 接口返回值中的 SnapshotId 获取。
        /// 
        /// <li>disk-id</li>按照【磁盘 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 可通过 <a href="https://cloud.tencent.com/document/product/1207/66093">DescribeDisks</a> 接口返回值中的 DiskId 获取。
        /// 
        /// <li>snapshot-name</li>按照【快照名称】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 可通过 <a href="https://cloud.tencent.com/document/product/1207/54388">DescribeSnapshots</a> 接口返回值中的 SnapshotName 获取。
        /// <li>instance-id</li>按照【实例 ID 】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 可通过 <a href="https://cloud.tencent.com/document/product/1207/47573">DescribeInstances</a> 接口返回值中的 InstanceId 获取。
        /// 
        /// 每次请求的 Filters 的上限为 10，Filter.Values 的上限为 5。参数不支持同时指定 SnapshotIds 和 Filters。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

