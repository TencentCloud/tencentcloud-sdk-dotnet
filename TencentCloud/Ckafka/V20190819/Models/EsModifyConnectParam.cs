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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsModifyConnectParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Es连接源的实例资源【不支持修改】</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>Es的连接port【不支持修改】</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Es连接源的实例vip【不支持修改】</p>
        /// </summary>
        [JsonProperty("ServiceVip")]
        public string ServiceVip{ get; set; }

        /// <summary>
        /// <p>Es连接源的vpcId【不支持修改】</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Es连接源的用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Es连接源的密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Es连接源是否为自建集群【不支持修改】</p>
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }

        /// <summary>
        /// <p>是否更新到关联的Datahub任务</p>
        /// </summary>
        [JsonProperty("IsUpdate")]
        public bool? IsUpdate{ get; set; }

        /// <summary>
        /// <p>es类型</p><p>枚举值：</p><ul><li>CLUSTER： 普通集群es</li><li>SERVERLESS： serverless形态es</li></ul>
        /// </summary>
        [JsonProperty("EsType")]
        public string EsType{ get; set; }

        /// <summary>
        /// <p>es版本，默认7.14.2</p><p>默认值：7.14.2</p>
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// <p>endpointUrl，es的serverless版本的访问入口地址</p>
        /// </summary>
        [JsonProperty("EndpointUrl")]
        public string EndpointUrl{ get; set; }

        /// <summary>
        /// <p>集群版 ES 连接协议，默认http协议</p><p>枚举值：</p><ul><li>http： http协议</li><li>https： https协议</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ServiceVip", this.ServiceVip);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SelfBuilt", this.SelfBuilt);
            this.SetParamSimple(map, prefix + "IsUpdate", this.IsUpdate);
            this.SetParamSimple(map, prefix + "EsType", this.EsType);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "EndpointUrl", this.EndpointUrl);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

