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
        ///     "多伦多": "ca",
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
        ///     "清远": "qy",
        ///     "雅加达": "jkt"
        /// 与 ApRegion 表达同一含义、格式不同：本字段为地域缩写，ApRegion 为腾讯云标准 ap-xxx 格式
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
        /// 负载均衡实例所在地域，腾讯云标准地域格式
        /// 参数格式：形如 ap-guangzhou
        /// 与 Region 表达同一含义、格式不同。监听器恒为单地域，数组长度恒为 0 或 1
        /// 出参在可识别时填充，无法识别时为空数组
        /// 枚举值：
        /// ap-guangzhou：广州
        /// ap-shanghai：上海
        /// ap-beijing：北京
        /// ap-chengdu：成都
        /// ap-chongqing：重庆
        /// ap-hongkong：中国香港
        /// ap-nanjing：南京
        /// ap-tianjin：天津
        /// ap-shenzhen：深圳
        /// ap-qingyuan：清远
        /// ap-guangzhou-open：广州Open
        /// ap-shenzhen-fsi：深圳金融
        /// ap-beijing-fsi：北京金融
        /// ap-shanghai-fsi：上海金融
        /// ap-hangzhou-ec：杭州
        /// ap-fuzhou-ec：福州
        /// ap-jinan-ec：济南
        /// ap-wuhan-ec：武汉
        /// ap-changsha-ec：长沙
        /// ap-hefei-ec：合肥
        /// ap-shenyang-ec：沈阳
        /// ap-xian-ec：西安
        /// ap-xibei-ec：西北
        /// ap-shijiazhuang-ec：石家庄
        /// ap-zhengzhou-ec：郑州
        /// ap-qingyuan-xinan：清远信安
        /// ap-shanghai-adc：上海ADC
        /// ap-shanghai-wxp-ops：上海无线城市运营
        /// ap-singapore：新加坡
        /// ap-seoul：首尔
        /// ap-tokyo：东京
        /// ap-osaka：大阪
        /// ap-mumbai：孟买
        /// ap-bangkok：曼谷
        /// ap-jakarta：雅加达
        /// ap-taipei：台北
        /// ap-johorbahru：柔佛巴鲁
        /// eu-frankfurt：法兰克福
        /// eu-moscow：莫斯科
        /// na-ashburn：弗吉尼亚
        /// na-siliconvalley：硅谷
        /// na-toronto：多伦多
        /// sa-saopaulo：圣保罗
        /// me-saudi-arabia：沙特阿拉伯
        /// </summary>
        [JsonProperty("ApRegion")]
        public string[] ApRegion{ get; set; }

        /// <summary>
        /// 负载均衡器的域名
        /// </summary>
        [JsonProperty("LoadBalancerDomain")]
        public string LoadBalancerDomain{ get; set; }

        /// <summary>
        /// 监听器所属appid
        /// </summary>
        [JsonProperty("MemberAppId")]
        public ulong? MemberAppId{ get; set; }

        /// <summary>
        /// 监听器自身所属uin
        /// </summary>
        [JsonProperty("MemberUin")]
        public string MemberUin{ get; set; }

        /// <summary>
        /// 监听器被接入的waf账号
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 集团账号昵称
        /// </summary>
        [JsonProperty("MemberNickName")]
        public string MemberNickName{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "ApRegion.", this.ApRegion);
            this.SetParamSimple(map, prefix + "LoadBalancerDomain", this.LoadBalancerDomain);
            this.SetParamSimple(map, prefix + "MemberAppId", this.MemberAppId);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "MemberNickName", this.MemberNickName);
        }
    }
}

