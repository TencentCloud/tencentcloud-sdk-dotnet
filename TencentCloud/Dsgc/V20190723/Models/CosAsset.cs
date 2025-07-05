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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosAsset : AbstractModel
    {
        
        /// <summary>
        /// 桶的个数
        /// </summary>
        [JsonProperty("BucketNums")]
        public long? BucketNums{ get; set; }

        /// <summary>
        /// 敏感桶的个数
        /// </summary>
        [JsonProperty("SensitiveBucketNums")]
        public long? SensitiveBucketNums{ get; set; }

        /// <summary>
        /// 文件个数
        /// </summary>
        [JsonProperty("FileNums")]
        public long? FileNums{ get; set; }

        /// <summary>
        /// 敏感文件的个数
        /// </summary>
        [JsonProperty("SensitiveFileNums")]
        public long? SensitiveFileNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketNums", this.BucketNums);
            this.SetParamSimple(map, prefix + "SensitiveBucketNums", this.SensitiveBucketNums);
            this.SetParamSimple(map, prefix + "FileNums", this.FileNums);
            this.SetParamSimple(map, prefix + "SensitiveFileNums", this.SensitiveFileNums);
        }
    }
}

