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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShareStorageFileDTO : AbstractModel
    {
        
        /// <summary>
        /// 共享存储访问 Token，公有云里面为 Cos 访问 Token
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 共享存储访问 SecretId，公有云里面为 Cos 访问 SecretId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// 共享存储访问 SecretKey，公有云里面为 Cos 访问 SecretKey
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Token 过期时间，时间戳类型，精确到秒，如果是 -1 则表示没有过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenExpiredTime")]
        public long? TokenExpiredTime{ get; set; }

        /// <summary>
        /// Token 创建时间，时间戳类型，精确到秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenCreateTime")]
        public long? TokenCreateTime{ get; set; }

        /// <summary>
        /// 共享存储类型，公有云为 COS，私有化为 CSP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareStorageType")]
        public string ShareStorageType{ get; set; }

        /// <summary>
        /// 共享存储 EndPoint，公有云可以不使用该值，私有化需要使用该值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareStorageEndPoint")]
        public string ShareStorageEndPoint{ get; set; }

        /// <summary>
        /// 存储桶 Region
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 存储桶名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 文件映射，导入文件时，可能会存在文件名冲突，WeData 后端会自动校验，如果出现冲突，会基于传入的名称生成新的名称，文件上传到共享存储时请使用新生成的文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMappings")]
        public ShareStorageFileMappingDTO[] FileMappings{ get; set; }

        /// <summary>
        /// 文件过期时间，公有云中，默认的过期时间为 15 天
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileExpireTime")]
        public long? FileExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "TokenExpiredTime", this.TokenExpiredTime);
            this.SetParamSimple(map, prefix + "TokenCreateTime", this.TokenCreateTime);
            this.SetParamSimple(map, prefix + "ShareStorageType", this.ShareStorageType);
            this.SetParamSimple(map, prefix + "ShareStorageEndPoint", this.ShareStorageEndPoint);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamArrayObj(map, prefix + "FileMappings.", this.FileMappings);
            this.SetParamSimple(map, prefix + "FileExpireTime", this.FileExpireTime);
        }
    }
}

