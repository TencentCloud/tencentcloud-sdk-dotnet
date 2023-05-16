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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class S3InputInfo : AbstractModel
    {
        
        /// <summary>
        /// S3 bucket。
        /// </summary>
        [JsonProperty("S3Bucket")]
        public string S3Bucket{ get; set; }

        /// <summary>
        /// S3 bucket 对应的区域，目前支持：  
        /// us-east-1  
        /// eu-west-3
        /// </summary>
        [JsonProperty("S3Region")]
        public string S3Region{ get; set; }

        /// <summary>
        /// S3 bucket 中的媒体资源路径。
        /// </summary>
        [JsonProperty("S3Object")]
        public string S3Object{ get; set; }

        /// <summary>
        /// AWS 内网访问 媒体资源的秘钥id。
        /// </summary>
        [JsonProperty("S3SecretId")]
        public string S3SecretId{ get; set; }

        /// <summary>
        /// AWS 内网访问 媒体资源的秘钥key。
        /// </summary>
        [JsonProperty("S3SecretKey")]
        public string S3SecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "S3Bucket", this.S3Bucket);
            this.SetParamSimple(map, prefix + "S3Region", this.S3Region);
            this.SetParamSimple(map, prefix + "S3Object", this.S3Object);
            this.SetParamSimple(map, prefix + "S3SecretId", this.S3SecretId);
            this.SetParamSimple(map, prefix + "S3SecretKey", this.S3SecretKey);
        }
    }
}

