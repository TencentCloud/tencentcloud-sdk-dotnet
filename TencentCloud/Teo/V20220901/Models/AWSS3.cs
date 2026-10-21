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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AWSS3 : AbstractModel
    {
        
        /// <summary>
        /// <p>AWS S3 存储桶对应的服务端点域名，取值可参考 <a href="https://docs.aws.amazon.com/zh_cn/general/latest/gr/rande.html#regional-endpoints">AWS 服务端点</a>。例如：s3.us-west-2.amazonaws.com 。</p>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// <p>AWS S3 存储桶名称。可在 AWS S3 控制台 Buckets（存储桶）列表中查看对应桶名。<br>长度须为 3–63 个字符，只能包含小写字母、数字、句点（.）和连字符（-），且必须以字母或数字开头和结尾。</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>日志文件在 AWS S3 桶中的存储目录路径，以 <code>/</code> 分隔可创建多级目录，且不能包含 <code>./..</code> 等相对路径段，路径总长度不超过 1024 个字节。<br>当目录路径存在时直接使用该路径，当目录路径不存在时会自动创建。<br>目录名仅允许由字母、数字、 及 <code>!-_.*&#39;()</code> 构成。<br>示例：<code>eo-logs/l7-access-logs</code> 。</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>授权 EdgeOne 访问 AWS S3 桶的 IAM 角色的 ARN。<br>需先在 AWS 账号中创建一个授予 EdgeOne 写入权限的 IAM 角色（创建方式详情见 <a href="https://cloud.tencent.com/document/product/1552/96007">推送至 AWS S3</a>），创建后可在 AWS IAM 控制台的角色详情页顶部查看并复制该角色的 ARN。<br>例如：<code>arn:aws:iam::123456789012:role/eo-logs</code> 。</p>
        /// </summary>
        [JsonProperty("RoleARN")]
        public string RoleARN{ get; set; }

        /// <summary>
        /// <p>数据压缩类型，取值有: <ul><li> gzip：gzip压缩。</li></ul>不填表示不启用压缩。</p>
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RoleARN", this.RoleARN);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

