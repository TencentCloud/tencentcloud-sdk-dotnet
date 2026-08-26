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

    public class CosBucketTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>存储桶名</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>最后一次扫描时间</p>
        /// </summary>
        [JsonProperty("LastScanTime")]
        public long? LastScanTime{ get; set; }

        /// <summary>
        /// <p>识别文件数量</p>
        /// </summary>
        [JsonProperty("IdentifyFileCount")]
        public ulong? IdentifyFileCount{ get; set; }

        /// <summary>
        /// <p>敏感文件数量</p>
        /// </summary>
        [JsonProperty("SensitiveFileCount")]
        public ulong? SensitiveFileCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "IdentifyFileCount", this.IdentifyFileCount);
            this.SetParamSimple(map, prefix + "SensitiveFileCount", this.SensitiveFileCount);
        }
    }
}

