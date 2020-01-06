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

    public class DescribeResourceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgp表示独享包；bgp-multip表示共享包；bgpip表示高防IP；net表示高防IP专业版；shield表示棋牌）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 地域码搜索，可选，当不指定地域时空数组，当指定地域时，填地域码。例如：["gz", "sh"]
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// 线路搜索，可选，只有当获取高防IP资源列表是可以选填，取值为[1（BGP线路），2（南京电信），3（南京联通），99（第三方合作线路）]，当获取其他产品时请填空数组；
        /// </summary>
        [JsonProperty("Line")]
        public ulong?[] Line{ get; set; }

        /// <summary>
        /// 资源ID搜索，可选，当不为空数组时表示获取指定资源的资源列表；
        /// </summary>
        [JsonProperty("IdList")]
        public string[] IdList{ get; set; }

        /// <summary>
        /// 资源名称搜索，可选，当不为空字符串时表示按名称搜索资源；
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// IP搜索列表，可选，当不为空时表示安装IP搜索资源；
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// 资源状态搜索列表，可选，取值为[0（运行中）, 1（清洗中）, 2（封堵中）]，当填空数组时不进行状态搜索；
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// 即将到期搜索；可选，取值为[0（不搜索），1（搜索即将到期的资源）]
        /// </summary>
        [JsonProperty("Expire")]
        public ulong? Expire{ get; set; }

        /// <summary>
        /// 排序字段，可选
        /// </summary>
        [JsonProperty("OderBy")]
        public OrderBy[] OderBy{ get; set; }

        /// <summary>
        /// 一页条数，填0表示不分页
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 页起始偏移，取值为(页码-1)*一页条数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 高防IP专业版资源的CNAME，可选，只对高防IP专业版资源列表有效；
        /// </summary>
        [JsonProperty("CName")]
        public string CName{ get; set; }

        /// <summary>
        /// 高防IP专业版资源的域名，可选，只对高防IP专业版资源列表有效；
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArraySimple(map, prefix + "Line.", this.Line);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamArrayObj(map, prefix + "OderBy.", this.OderBy);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "CName", this.CName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

