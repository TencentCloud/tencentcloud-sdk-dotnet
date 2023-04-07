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

    public class AwsS3FileUploadTrigger : AbstractModel
    {
        
        /// <summary>
        /// 绑定的 AWS S3 存储桶。
        /// </summary>
        [JsonProperty("S3Bucket")]
        public string S3Bucket{ get; set; }

        /// <summary>
        /// 绑定的桶所在 AWS 区域。
        /// </summary>
        [JsonProperty("S3Region")]
        public string S3Region{ get; set; }

        /// <summary>
        /// 绑定的输入路径目录，必须为绝对路径，即以 `/` 开头和结尾。如`/movie/201907/`，不填代表根目录`/`。	
        /// </summary>
        [JsonProperty("Dir")]
        public string Dir{ get; set; }

        /// <summary>
        /// 允许触发的文件格式列表，如 ["mp4", "flv", "mov"]。不填代表所有格式的文件都可以触发工作流。	
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }

        /// <summary>
        /// 绑定的 AWS S3 存储桶的秘钥ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("S3SecretId")]
        public string S3SecretId{ get; set; }

        /// <summary>
        /// 绑定的 AWS S3 存储桶的秘钥Key。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("S3SecretKey")]
        public string S3SecretKey{ get; set; }

        /// <summary>
        /// 绑定的 AWS S3 存储桶对应的 SQS事件队列。
        /// 注意：队列和桶需要在同一区域。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AwsSQS")]
        public AwsSQS AwsSQS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "S3Bucket", this.S3Bucket);
            this.SetParamSimple(map, prefix + "S3Region", this.S3Region);
            this.SetParamSimple(map, prefix + "Dir", this.Dir);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
            this.SetParamSimple(map, prefix + "S3SecretId", this.S3SecretId);
            this.SetParamSimple(map, prefix + "S3SecretKey", this.S3SecretKey);
            this.SetParamObj(map, prefix + "AwsSQS.", this.AwsSQS);
        }
    }
}

