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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// <p>负载均衡LD的ID</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>负载均衡LD的名称</p>
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// <p>负载均衡监听器的ID</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>负载均衡监听器的名称</p>
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// <p>负载均衡实例的端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

        /// <summary>
        /// <p>负载均衡LD的地域<br>与 ApRegion 表达同一含义、格式不同。本字段为地域缩写；入参与 ApRegion 同时传入时以 ApRegion 为准</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>监听器协议，http、https</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>负载均衡监听器所在的zone</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>负载均衡实例所在地域，腾讯云标准地域格式<br>参数格式：形如 ap-guangzhou<br>与 Region 表达同一含义、格式不同。监听器恒为单地域，数组长度恒为 0 或 1<br>入参可选；与 Region 同时传入时以本字段为准；取值不在枚举范围内时返回 UnsupportedRegion<br>出参在可识别时填充，无法识别时为空数组<br>枚举值：<br>ap-guangzhou：广州<br>ap-shanghai：上海<br>ap-beijing：北京<br>ap-chengdu：成都<br>ap-chongqing：重庆<br>ap-hongkong：中国香港<br>ap-nanjing：南京<br>ap-tianjin：天津<br>ap-shenzhen：深圳<br>ap-qingyuan：清远<br>ap-guangzhou-open：广州Open<br>ap-shenzhen-fsi：深圳金融<br>ap-beijing-fsi：北京金融<br>ap-shanghai-fsi：上海金融<br>ap-hangzhou-ec：杭州<br>ap-fuzhou-ec：福州<br>ap-jinan-ec：济南<br>ap-wuhan-ec：武汉<br>ap-changsha-ec：长沙<br>ap-hefei-ec：合肥<br>ap-shenyang-ec：沈阳<br>ap-xian-ec：西安<br>ap-xibei-ec：西北<br>ap-shijiazhuang-ec：石家庄<br>ap-zhengzhou-ec：郑州<br>ap-qingyuan-xinan：清远信安<br>ap-shanghai-adc：上海ADC<br>ap-shanghai-wxp-ops：上海无线城市运营<br>ap-singapore：新加坡<br>ap-seoul：首尔<br>ap-tokyo：东京<br>ap-osaka：大阪<br>ap-mumbai：孟买<br>ap-bangkok：曼谷<br>ap-jakarta：雅加达<br>ap-taipei：台北<br>ap-johorbahru：柔佛巴鲁<br>eu-frankfurt：法兰克福<br>eu-moscow：莫斯科<br>na-ashburn：弗吉尼亚<br>na-siliconvalley：硅谷<br>na-toronto：多伦多<br>sa-saopaulo：圣保罗<br>me-saudi-arabia：沙特阿拉伯</p>
        /// </summary>
        [JsonProperty("ApRegion")]
        public string[] ApRegion{ get; set; }

        /// <summary>
        /// <p>负载均衡实例的IP。域名化CLB VIP可填空。</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>负载均衡的VPCID，公网为-1，内网按实际填写</p>
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public long? NumericalVpcId{ get; set; }

        /// <summary>
        /// <p>负载均衡的网络类型。OPEN： 公网 INTERNAL ：内网</p>
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// <p>负载均衡的域名</p>
        /// </summary>
        [JsonProperty("LoadBalancerDomain")]
        public string LoadBalancerDomain{ get; set; }

        /// <summary>
        /// <p>监听器所属成员id</p>
        /// </summary>
        [JsonProperty("MemberAppId")]
        public ulong? MemberAppId{ get; set; }

        /// <summary>
        /// <p>监听器所属成员的uin</p>
        /// </summary>
        [JsonProperty("MemberUin")]
        public string MemberUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "ApRegion.", this.ApRegion);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "LoadBalancerDomain", this.LoadBalancerDomain);
            this.SetParamSimple(map, prefix + "MemberAppId", this.MemberAppId);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
        }
    }
}

