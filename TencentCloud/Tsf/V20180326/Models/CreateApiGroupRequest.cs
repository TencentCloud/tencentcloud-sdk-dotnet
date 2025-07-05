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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApiGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 分组名称, 不能包含中文
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 分组上下文
        /// </summary>
        [JsonProperty("GroupContext")]
        public string GroupContext{ get; set; }

        /// <summary>
        /// 鉴权类型。secret： 密钥鉴权； none:无鉴权
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 分组类型,默认ms。 ms： 微服务分组； external:外部Api分组
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// 网关实体ID
        /// </summary>
        [JsonProperty("GatewayInstanceId")]
        public string GatewayInstanceId{ get; set; }

        /// <summary>
        /// 命名空间参数key值
        /// </summary>
        [JsonProperty("NamespaceNameKey")]
        public string NamespaceNameKey{ get; set; }

        /// <summary>
        /// 微服务名参数key值
        /// </summary>
        [JsonProperty("ServiceNameKey")]
        public string ServiceNameKey{ get; set; }

        /// <summary>
        /// 命名空间参数位置，path，header或query，默认是path
        /// </summary>
        [JsonProperty("NamespaceNameKeyPosition")]
        public string NamespaceNameKeyPosition{ get; set; }

        /// <summary>
        /// 微服务名参数位置，path，header或query，默认是path
        /// </summary>
        [JsonProperty("ServiceNameKeyPosition")]
        public string ServiceNameKeyPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupContext", this.GroupContext);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "GatewayInstanceId", this.GatewayInstanceId);
            this.SetParamSimple(map, prefix + "NamespaceNameKey", this.NamespaceNameKey);
            this.SetParamSimple(map, prefix + "ServiceNameKey", this.ServiceNameKey);
            this.SetParamSimple(map, prefix + "NamespaceNameKeyPosition", this.NamespaceNameKeyPosition);
            this.SetParamSimple(map, prefix + "ServiceNameKeyPosition", this.ServiceNameKeyPosition);
        }
    }
}

