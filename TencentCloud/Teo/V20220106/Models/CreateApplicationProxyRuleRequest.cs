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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationProxyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 代理ID
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 协议，取值为TCP或者UDP
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// 端口，支持格式：
        /// 80：80端口
        /// 81-90：81至90端口
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// 源站类型，取值：
        /// custom：手动添加
        /// origins：源站组
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站信息：
        /// 当OriginType=custom时，表示多个：
        /// IP:端口
        /// 域名:端口
        /// 当OriginType=origins时，包含一个元素，表示源站组ID
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// 传递客户端IP，当Proto=TCP时，取值：
        /// TOA：TOA
        /// PPV1: Proxy Protocol传递，协议版本V1
        /// PPV2: Proxy Protocol传递，协议版本V2
        /// OFF：不传递
        /// 当Proto=UDP时，取值：
        /// PPV2: Proxy Protocol传递，协议版本V2
        /// OFF：不传递
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// 是否开启会话保持
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
        }
    }
}

