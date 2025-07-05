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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FetchAndroidInstancesLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 安卓实例 ID 列表
        /// </summary>
        [JsonProperty("AndroidInstanceIds")]
        public string[] AndroidInstanceIds{ get; set; }

        /// <summary>
        /// cos 桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// cos 桶区域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// cos 桶目录，默认为 /log/
        /// </summary>
        [JsonProperty("BucketDirectory")]
        public string BucketDirectory{ get; set; }

        /// <summary>
        /// 下载最近几天的日志，默认值为 1
        /// </summary>
        [JsonProperty("RecentDays")]
        public ulong? RecentDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AndroidInstanceIds.", this.AndroidInstanceIds);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketDirectory", this.BucketDirectory);
            this.SetParamSimple(map, prefix + "RecentDays", this.RecentDays);
        }
    }
}

