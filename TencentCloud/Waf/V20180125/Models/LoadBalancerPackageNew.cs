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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancerPackageNew : AbstractModel
    {
        
        /// <summary>
        /// 监听id
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听名
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 负载均衡id
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡名
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 地区
        /// "多伦多": "ca",
        ///     "广州": "gz",
        ///     "成都": "cd",
        ///     "福州": "fzec",
        ///     "深圳": "szx",
        ///     "印度": "in",
        ///     "济南": "jnec",
        ///     "重庆": "cq",
        ///     "天津": "tsn",
        ///     "欧洲东北": "ru",
        ///     "南京": "nj",
        ///     "美国硅谷": "usw",
        ///     "泰国": "th",
        ///     "广州Open": "gzopen",
        ///     "深圳金融": "szjr",
        ///     "法兰克福": "de",
        ///     "日本": "jp",
        ///     "弗吉尼亚": "use",
        ///     "北京": "bj",
        ///     "中国香港": "hk",
        ///     "杭州": "hzec",
        ///     "北京金融": "bjjr",
        ///     "上海金融": "shjr",
        ///     "台北": "tpe",
        ///     "首尔": "kr",
        ///     "上海": "sh",
        ///     "新加坡": "sg",
        ///     "清远": "qy"
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 接入IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 接入端口
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// VPCID
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public long? NumericalVpcId{ get; set; }

        /// <summary>
        /// CLB类型
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡器的域名
        /// </summary>
        [JsonProperty("LoadBalancerDomain")]
        public string LoadBalancerDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "LoadBalancerDomain", this.LoadBalancerDomain);
        }
    }
}

