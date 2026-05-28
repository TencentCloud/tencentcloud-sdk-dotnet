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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCosObjectScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>1: 敏感数据识别 2:恶意文件扫描 3:批量扫描敏感数据</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>存储桶列表</p>
        /// </summary>
        [JsonProperty("BucketSet")]
        public string[] BucketSet{ get; set; }

        /// <summary>
        /// <p>任务参数</p>
        /// </summary>
        [JsonProperty("TaskArgs")]
        public string TaskArgs{ get; set; }

        /// <summary>
        /// <p>是否全部扫描</p>
        /// </summary>
        [JsonProperty("IsScanAll")]
        public bool? IsScanAll{ get; set; }

        /// <summary>
        /// <p>扫描时需要剔除的存储桶</p>
        /// </summary>
        [JsonProperty("DeleteBucketSet")]
        public string[] DeleteBucketSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "BucketSet.", this.BucketSet);
            this.SetParamSimple(map, prefix + "TaskArgs", this.TaskArgs);
            this.SetParamSimple(map, prefix + "IsScanAll", this.IsScanAll);
            this.SetParamArraySimple(map, prefix + "DeleteBucketSet.", this.DeleteBucketSet);
        }
    }
}

