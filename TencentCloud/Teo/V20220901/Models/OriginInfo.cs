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

    public class OriginInfo : AbstractModel
    {
        
        /// <summary>
        /// 源站类型，取值有：
        /// <li>IP_DOMAIN：IPV4、IPV6 或域名类型源站；</li>
        /// <li>COS：腾讯云 COS 对象存储源站；</li>
        /// <li>AWS_S3：AWS S3 对象存储源站；</li>
        /// <li>ORIGIN_GROUP：源站组类型源站；</li>
        ///  <li>VODEO：云点播-混合云版；</li>
        /// <li>SPACE：源站卸载，当前仅白名单开放；</li>
        /// <li>LB：负载均衡，当前仅白名单开放。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站地址，根据 OriginType 的取值分为以下情况：
        /// <li>当 OriginType = IP_DOMAIN 时，该参数请填写 IPv4、IPv6 地址或域名；</li>
        /// <li>当 OriginType = COS 时，该参数请填写 COS 桶的访问域名；</li>
        /// <li>当 OriginType = AWS_S3，该参数请填写 S3 桶的访问域名；</li>
        /// <li>当 OriginType = ORIGIN_GROUP 时，该参数请填写源站组 ID；</li>
        /// <li>当 OriginType = VODEO 时，如果 VodeoDistributionRange = ALL，则该参数填写 "all-buckets-in-vodeo-application"；如果 VodeoDistributionRange = Bucket，则该参数请填写对应存储桶域名；</li>
        /// <li>当 OriginType = LB 时，该参数请填写负载均衡实例 ID，该功能当前仅白名单开放；</li>
        /// <li>当 OriginType = SPACE 时，该参数请填写源站卸载空间 ID，该功能当前仅白名单开放。</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 备用源站组 ID，该参数仅在 OriginType = ORIGIN_GROUP 时生效，该字段为旧版能力，调用后控制台无法进行配置修改，如需使用请提交工单咨询。
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// 指定是否允许访问私有对象存储源站，该参数仅当源站类型 OriginType = COS 或 AWS_S3 时会生效，取值有：
        /// <li>on：使用私有鉴权；</li>
        /// <li>off：不使用私有鉴权。</li>
        /// 不填写时，默认值为off。
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// 私有鉴权使用参数，该参数仅当源站类型 PrivateAccess = on 时会生效。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// VODEO 子应用 ID。该参数当 OriginType = VODEO 时必填。
        /// </summary>
        [JsonProperty("VodeoSubAppId")]
        public long? VodeoSubAppId{ get; set; }

        /// <summary>
        /// VODEO 分发范围，该参数当 OriginType = VODEO 时必填。取值有： 
        /// <li>All：当前应用下所有存储桶；</li> 
        /// <li>Bucket：指定的某一个存储桶。</li>	
        /// </summary>
        [JsonProperty("VodeoDistributionRange")]
        public string VodeoDistributionRange{ get; set; }

        /// <summary>
        /// VODEO 存储桶 ID，该参数当 OriginType = VODEO 且 VodeoDistributionRange = Bucket 时必填。
        /// </summary>
        [JsonProperty("VodeoBucketId")]
        public string VodeoBucketId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "BackupOrigin", this.BackupOrigin);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "VodeoSubAppId", this.VodeoSubAppId);
            this.SetParamSimple(map, prefix + "VodeoDistributionRange", this.VodeoDistributionRange);
            this.SetParamSimple(map, prefix + "VodeoBucketId", this.VodeoBucketId);
        }
    }
}

