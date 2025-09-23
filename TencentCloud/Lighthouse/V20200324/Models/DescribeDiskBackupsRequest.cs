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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDiskBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的云硬盘备份点ID列表。可通过[DescribeDiskBackups](https://cloud.tencent.com/document/product/1207/84379)接口返回值字段DiskBackupSet获取。列表长度最大值为100。参数不支持同时指定 DiskBackupIds 和 Filters。
        /// </summary>
        [JsonProperty("DiskBackupIds")]
        public string[] DiskBackupIds{ get; set; }

        /// <summary>
        /// 过滤器列表。
        /// <li>disk-backup-id</li>按照【云硬盘备份点 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>disk-id</li>按照【云硬盘 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>disk-backup-state</li>按照【云硬盘备份点状态】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 取值：参考数据结构 [DiskBackup](https://cloud.tencent.com/document/product/1207/47576#DiskBackup) 下的DiskBackupState取值。
        /// <li>disk-usage</li>按照【云硬盘类型】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 取值：
        /// - SYSTEM_DISK - 系统盘
        /// - DATA_DISK - 数据盘
        /// <li>tag-key</li>
        /// 按照【标签键】进行过滤。 类型：String 必选：否
        /// <li>tag-value</li>
        /// 按照【标签值】进行过滤。 类型：String 必选：否
        /// <li>tag:tag-key</li>
        /// 按照【标签键值对】进行过滤。 tag-key使用具体的标签键进行替换。
        /// 每次请求的 Filters 的上限为 10，Filter.Values 的上限为5。参数不支持同时指定DiskBackupIds 和 Filters。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskBackupIds.", this.DiskBackupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

