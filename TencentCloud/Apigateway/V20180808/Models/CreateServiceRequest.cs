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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户自定义的服务名称。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 服务的前端请求类型。如 http、https、http&https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 用户自定义的服务描述。
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// 独立集群名称，用于指定创建服务所在的独立集群。
        /// </summary>
        [JsonProperty("ExclusiveSetName")]
        public string ExclusiveSetName{ get; set; }

        /// <summary>
        /// 网络类型列表，用于指定支持的访问类型，INNER为内网访问，OUTER为外网访问。默认为OUTER。
        /// </summary>
        [JsonProperty("NetTypes")]
        public string[] NetTypes{ get; set; }

        /// <summary>
        /// IP版本号，支持IPv4和IPv6，默认为IPv4。
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// 集群名称。保留字段，tsf serverlss类型使用。
        /// </summary>
        [JsonProperty("SetServerName")]
        public string SetServerName{ get; set; }

        /// <summary>
        /// 用户类型。保留类型，serverless用户使用。
        /// </summary>
        [JsonProperty("AppIdType")]
        public string AppIdType{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 独享实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// vpc属性
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "ExclusiveSetName", this.ExclusiveSetName);
            this.SetParamArraySimple(map, prefix + "NetTypes.", this.NetTypes);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "SetServerName", this.SetServerName);
            this.SetParamSimple(map, prefix + "AppIdType", this.AppIdType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
        }
    }
}

