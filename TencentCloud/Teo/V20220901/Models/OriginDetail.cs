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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginDetail : AbstractModel
    {
        
        /// <summary>
        /// 源站类型，取值有：
        /// <li>IP_DOMAIN：IPV4、IPV6 或域名类型源站；</li>
        /// <li>COS：腾讯云 COS 对象存储源站；</li>
        /// <li>AWS_S3：AWS S3 对象存储源站；</li>
        /// <li>ORIGIN_GROUP：源站组类型源站；</li>
        /// <li>VOD：云点播；</li>
        /// <li>SPACE：源站卸载，当前仅白名单开放；</li>
        /// <li>LB：负载均衡，当前仅白名单开放。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站地址，根据 OriginType 的取值分为以下情况：
        /// <li>当 OriginType = IP_DOMAIN 时，该参数为 IPv4、IPv6 地址或域名；</li>
        /// <li>当 OriginType = COS 时，该参数为 COS 桶的访问域名；</li>
        /// <li>当 OriginType = AWS_S3，该参数为 S3 桶的访问域名；</li>
        /// <li>当 OriginType = ORIGIN_GROUP 时，该参数为源站组 ID；</li>
        /// <li>当 OriginType = VOD 时，该参数请填写云点播应用 ID ；</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 备用源站组 ID，该参数仅在 OriginType = ORIGIN_GROUP 且配置了备源站组时会生效。
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// 主源源站组名称，当 OriginType = ORIGIN_GROUP 时该参数会返回值。
        /// </summary>
        [JsonProperty("OriginGroupName")]
        public string OriginGroupName{ get; set; }

        /// <summary>
        /// 备用源站组名称，该参数仅当 OriginType = ORIGIN_GROUP 且配置了备用源站组时会生效。
        /// </summary>
        [JsonProperty("BackOriginGroupName")]
        public string BackOriginGroupName{ get; set; }

        /// <summary>
        /// 指定是否允许访问私有对象存储源站，该参数仅当源站类型OriginType = COS 或 AWS_S3 时会生效，取值有：
        /// <li>on：使用私有鉴权；</li>
        /// <li>off：不使用私有鉴权。</li>
        /// 不填写，默认值为 off。
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// 私有鉴权使用参数，该参数仅当源站类型 PrivateAccess = on 时会生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// MO 子应用 ID
        /// </summary>
        [JsonProperty("VodeoSubAppId")]
        [System.Obsolete]
        public long? VodeoSubAppId{ get; set; }

        /// <summary>
        /// MO 分发范围，取值有： <li>All：全部</li> <li>Bucket：存储桶</li>
        /// </summary>
        [JsonProperty("VodeoDistributionRange")]
        [System.Obsolete]
        public string VodeoDistributionRange{ get; set; }

        /// <summary>
        /// MO 存储桶 ID，分发范围(DistributionRange)为存储桶(Bucket)时必填
        /// </summary>
        [JsonProperty("VodeoBucketId")]
        [System.Obsolete]
        public string VodeoBucketId{ get; set; }

        /// <summary>
        /// 云点播回源范围，当 OriginType = VOD 时该参数会返回值。取值有:<li>all：当前源站对应的云点播应用内所有文件，默认值为 all；</li> <li>bucket：当前源站对应的云点播应用下指定某一个存储桶内的文件。通过参数 VodBucketId 来指定存储桶。
        /// </li>
        /// </summary>
        [JsonProperty("VodOriginScope")]
        public string VodOriginScope{ get; set; }

        /// <summary>
        /// 云点播存储桶 ID，该参数当 OriginType = VOD 且 VodOriginScope = bucket 时必填。数据来源：云点播专业版应用下存储桶的存储 ID 。
        /// </summary>
        [JsonProperty("VodBucketId")]
        public string VodBucketId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "BackupOrigin", this.BackupOrigin);
            this.SetParamSimple(map, prefix + "OriginGroupName", this.OriginGroupName);
            this.SetParamSimple(map, prefix + "BackOriginGroupName", this.BackOriginGroupName);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "VodeoSubAppId", this.VodeoSubAppId);
            this.SetParamSimple(map, prefix + "VodeoDistributionRange", this.VodeoDistributionRange);
            this.SetParamSimple(map, prefix + "VodeoBucketId", this.VodeoBucketId);
            this.SetParamSimple(map, prefix + "VodOriginScope", this.VodOriginScope);
            this.SetParamSimple(map, prefix + "VodBucketId", this.VodBucketId);
        }
    }
}

