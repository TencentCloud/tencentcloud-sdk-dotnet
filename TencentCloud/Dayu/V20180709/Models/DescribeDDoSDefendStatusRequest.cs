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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSDefendStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（basic表示基础防护；bgp表示独享包；bgp-multip表示共享包；bgpip表示高防IP；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源实例ID，只有当Business不是基础防护时才需要填写此字段；
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 基础防护的IP，只有当Business为基础防护时才需要填写此字段；
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 只有当Business为基础防护时才需要填写此字段，IP所属的产品类型，取值[public（CVM产品），bm（黑石产品），eni（弹性网卡），vpngw（VPN网关）， natgw（NAT网关），waf（Web应用安全产品），fpc（金融产品），gaap（GAAP产品）, other(托管IP)]
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 只有当Business为基础防护时才需要填写此字段，IP所属的产品子类，取值[cvm（CVM），lb（负载均衡器），eni（弹性网卡），vpngw（VPN），natgw（NAT），waf（WAF），fpc（金融），gaap（GAAP），other（托管IP），eip（黑石弹性IP）]
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 只有当Business为基础防护时才需要填写此字段，IP所属的资源实例ID，当绑定新IP时必须填写此字段；例如是弹性网卡的IP，则InstanceId填写弹性网卡的ID(eni-*);
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 只有当Business为基础防护时才需要填写此字段，表示IP所属的地域，取值：
        /// "bj":     华北地区(北京)
        /// "cd":     西南地区(成都)
        /// "cq":     西南地区(重庆)
        /// "gz":     华南地区(广州)
        /// "gzopen": 华南地区(广州Open)
        /// "hk":     中国香港
        /// "kr":     东南亚地区(首尔)
        /// "sh":     华东地区(上海)
        /// "shjr":   华东地区(上海金融)
        /// "szjr":   华南地区(深圳金融)
        /// "sg":     东南亚地区(新加坡)
        /// "th":     东南亚地区(泰国)
        /// "de":     欧洲地区(德国)
        /// "usw":    美国西部（硅谷）
        /// "ca":     北美地区(多伦多)
        /// "jp":     日本
        /// "hzec":   杭州
        /// "in":     印度
        /// "use":    美东地区（弗吉尼亚）
        /// "ru":     俄罗斯
        /// "tpe":    中国台湾
        /// "nj":     南京
        /// </summary>
        [JsonProperty("IPRegion")]
        public string IPRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IPRegion", this.IPRegion);
        }
    }
}

