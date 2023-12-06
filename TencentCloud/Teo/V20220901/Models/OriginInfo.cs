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
        /// <li>COS：COS 源；</li>
        /// <li>ORIGIN_GROUP：源站组类型源站；</li>
        /// <li>AWS_S3：S3兼容对象存储源站；</li>
        /// <li>LB: 负载均衡类型源站；</li>
        /// <li>SPACE：EdgeOne Shield Space 存储。</li>  
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站地址，当 OriginType 参数指定为 ORIGIN_GROUP 时，该参数填写源站组 ID，其他情况下填写源站地址。
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 备用源站组 ID，该参数在 OriginType 参数指定为 ORIGIN_GROUP 时生效，为空表示不使用备用源站。
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// 指定是否允许访问私有对象存储源站，当源站类型 OriginType=COS 或 AWS_S3 时有效，取值有：
        /// <li>on：使用私有鉴权；</li>
        /// <li>off：不使用私有鉴权。</li>默认值：off。
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// 私有鉴权使用参数，当源站类型 PrivateAccess=on 时有效。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// MO 子应用 ID
        /// </summary>
        [JsonProperty("VodeoSubAppId")]
        public long? VodeoSubAppId{ get; set; }

        /// <summary>
        /// MO 分发范围，取值有： <li>All：全部</li> <li>Bucket：存储桶</li>
        /// </summary>
        [JsonProperty("VodeoDistributionRange")]
        public string VodeoDistributionRange{ get; set; }

        /// <summary>
        /// MO 存储桶 ID，分发范围(DistributionRange)为存储桶(Bucket)时必填	
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

