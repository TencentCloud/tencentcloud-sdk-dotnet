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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateRegisterCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>IDC集群ID，形如<code>hpc-xxxxxxxx</code>。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>是否通过内网专线代理连接。</p><li>true：IDC机器需经PrivateLink代理接入</li><li>false：IDC机器可直连（默认值）</li><p></p>
        /// </summary>
        [JsonProperty("Proxy")]
        public bool? Proxy{ get; set; }

        /// <summary>
        /// <p>私有网络ID，形如<code>vpc-xxx</code>。仅当<code>Proxy=true</code>且集群未绑定VPC时必填。与SubnetId需同时指定或同时不指定。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>私有网络子网ID，形如<code>subnet-xxx</code>。仅当<code>Proxy=true</code>且集群未绑定VPC时必填。与VpcId需同时指定或同时不指定。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>注册码绑定的队列名称。不指定时由系统取集群默认队列。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>注册码有效期，单位：秒。默认值为604800（7天）。</p>
        /// </summary>
        [JsonProperty("ExpireSeconds")]
        public long? ExpireSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Proxy", this.Proxy);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "ExpireSeconds", this.ExpireSeconds);
        }
    }
}

