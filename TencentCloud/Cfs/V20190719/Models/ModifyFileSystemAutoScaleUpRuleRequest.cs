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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFileSystemAutoScaleUpRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统 ID，通过查询文件系统列表获取；[DescribeCfsFileSystems](https://cloud.tencent.com/document/product/582/38170)
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 扩容阈值，范围[10-90]
        /// </summary>
        [JsonProperty("ScaleUpThreshold")]
        public ulong? ScaleUpThreshold{ get; set; }

        /// <summary>
        /// 扩容后目标阈值，范围[10-90]，该值要小于 ScaleUpThreshold
        /// </summary>
        [JsonProperty("TargetThreshold")]
        public ulong? TargetThreshold{ get; set; }

        /// <summary>
        /// 规则状态 0：关闭，1：开启；不传保留原状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "ScaleUpThreshold", this.ScaleUpThreshold);
            this.SetParamSimple(map, prefix + "TargetThreshold", this.TargetThreshold);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

